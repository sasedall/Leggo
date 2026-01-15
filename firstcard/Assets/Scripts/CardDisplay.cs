using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardDisplay : MonoBehaviour
{
	public TextMeshProUGUI NameText;
	public TextMeshProUGUI ManaText;
	public TextMeshProUGUI AttackText;
	public TextMeshProUGUI HealthText;
	public TextMeshProUGUI DescriptionText;
	public Image ArtworkImage;

	private CardLogic cardLogic; // Reference to the logic

	// Bind the logic data to this UI display
	public void BindToCardLogic(CardLogic logic)
	{
		cardLogic = logic;

		// Subscribe to changes in card logic
		cardLogic.OnCardStateChanged += UpdateUI;

		// Update the UI immediately when bound
		UpdateUI();
	}

	// Update the UI elements when the card state changes
	private void UpdateUI()
	{
		NameText.text = cardLogic.CardName;
		ManaText.text = cardLogic.ManaCost.ToString();
		AttackText.text = cardLogic.Attack.ToString();
		HealthText.text = cardLogic.Health.ToString();
		DescriptionText.text = cardLogic.Description;

		// Optional: Update artwork
		if (ArtworkImage != null)
		{
			// Use artwork from the ScriptableObject if needed
			ArtworkImage.sprite = null; // You can assign based on custom logic or externally
		}
	}

	private void OnDestroy()
	{
		// Unsubscribe to avoid memory leaks when the card is destroyed
		if (cardLogic != null)
		{
			cardLogic.OnCardStateChanged -= UpdateUI;
		}
	}
}