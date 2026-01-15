using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject cardPrefab; // Prefab of the Card UI
	public Transform handPanel; // Reference to the UI panel for cards in hand
	public Card[] cardDatabase; // Array of ScriptableObjects (all card designs)

	void Start()
	{
		// For example, draw 3 cards at the start of the game
		DrawCard(cardDatabase[0]); // Replace with your deck/draw system
		DrawCard(cardDatabase[1]);
		DrawCard(cardDatabase[2]);
	}

	public void DrawCard(Card cardData)
	{
		// Create Card Logic
		CardLogic newCardLogic = new CardLogic(cardData);

		// Instantiate Card Prefab as a UI element in the hand
		GameObject cardGO = Instantiate(cardPrefab, handPanel);

		// Bind logic to visuals
		CardDisplay cardDisplay = cardGO.GetComponent<CardDisplay>();
		cardDisplay.BindToCardLogic(newCardLogic);

		// Example: Apply game logic to the cards
		// Simulate this card taking damage
		newCardLogic.TakeDamage(1);
	}
}