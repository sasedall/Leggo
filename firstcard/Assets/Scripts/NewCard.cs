using UnityEngine;

[CreateAssetMenu(fileName = "NewCard", menuName = "Card Game/Card")]
public class Card : ScriptableObject
{
	public string CardName;
	public int ManaCost;
	public int Attack;
	public int Health;
	public string Description;
	public Sprite Artwork;
}
/* Optional: Add references to visual or audio assets
	public Sprite Artwork;        // Card image
	public AudioClip SoundEffect; // Sound when card is played

	// Optional: Add abilities (extend this later for complex effects)
	public string AbilityKey;     // A key to reference specific actions (e.g., "DealDamage", "RestoreHealth")
	*/