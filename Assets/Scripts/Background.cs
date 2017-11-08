using UnityEngine;

[ExecuteInEditMode]
public class Background : MonoBehaviour {
	[SerializeField] int tileNmbX = 10;
	[SerializeField] int tileNmbY = 10;

	[SerializeField] SpriteRenderer grassPrefab;
	Vector3 tileSize;

	// Use this for initialization
	void Start ()
	{
		tileSize = grassPrefab.sprite.bounds.size;
		Generate();
	}
	void Clear()
	{
		for(int i = transform.childCount - 1; i >= 0; i--)
		{
			DestroyImmediate(transform.GetChild(i).gameObject);
		}
	}
	public void Generate()
	{
		Clear();
		for (int i = 0; i < tileNmbX; i++)
		{
			for (int j = 0; j < tileNmbY; j++)
			{
				SpriteRenderer grass = Instantiate(grassPrefab);
				grass.transform.position = new Vector3(i, j) - new Vector3(tileNmbX / 2, tileNmbY / 2) + tileSize / 2;
				grass.transform.parent = transform;
			}
		}
	}
}
