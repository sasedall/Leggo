using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
	private List<Card> allCards;

	void Start()
	{
		LoadAllCards();
		Debug.Log($"Loaded {allCards.Count} cards from Resources.");
	}

	// Load all cards from the "Resources/Cards" folder
	private void LoadAllCards()
	{
		allCards = new List<Card>(Resources.LoadAll<Card>("Cards"));
	}

	// Get a random card from the list
	public Card GetRandomCard()
	{
		if (allCards.Count == 0)
		{
			Debug.LogWarning("No cards loaded!");
			return null;
		}
		return allCards[Random.Range(0, allCards.Count)];
	}
}