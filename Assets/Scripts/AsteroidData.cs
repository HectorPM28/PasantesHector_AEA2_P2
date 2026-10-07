using UnityEngine;

// TODO: crea el ScriptableObject [CreateAssetsMenu...] recorda que no ha d'heretar de MonoBehaviour
[CreateAssetMenu(fileName = "NewAsteroidData", menuName = "Asteroids/Asteroid Data")]
public class AsteroidData : ScriptableObject
{
	public Vector3 scale;
	public float minSpeed;
	public float maxSpeed;
	public int hp;
	public int score;
	public Color color;
	public int damage;
}