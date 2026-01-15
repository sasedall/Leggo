using System; // For the event system

public class CardLogic
{
	public string CardName { get; private set; }
	public int ManaCost { get; private set; }
	public int Attack { get; private set; }
	public int Health { get; private set; }
	public string Description { get; private set; }

	public event Action OnCardStateChanged; // Notify visuals to update when something changes

	public CardLogic(Card cardData)
	{
		// Initialize logic from ScriptableObject data
		CardName = cardData.CardName;
		ManaCost = cardData.ManaCost;
		Attack = cardData.Attack;
		Health = cardData.Health;
		Description = cardData.Description;
	}

	// Perform game logic actions
	public void TakeDamage(int damage)
	{
		Health -= damage;
		if (Health < 0) Health = 0;

		// Notify listeners (like visuals) that the state has changed
		OnCardStateChanged?.Invoke();
	}

	public bool CanPlay(int availableMana)
	{
		return availableMana >= ManaCost;
	}
}