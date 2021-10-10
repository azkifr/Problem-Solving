using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    private GameObject toSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public bool ToSpawn = true;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    // Update is called once per frame
    public void spawnObject()
    {
        int randomItem = 0;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2 (screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
            
        }
    }
    IEnumerator ToSpawnTrue()
	{
		yield return new WaitForSeconds(4f);
		ToSpawn = true;
	}
}
