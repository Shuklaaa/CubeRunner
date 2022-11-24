using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    private float timetoSpawn = 2f;
    public float timeBetweenWaves =1f;
    // Start is called before the first frame update
    void Update()
    {
        if(Time.time >= timetoSpawn)
        {
            SpawnBlocks();
            timetoSpawn = Time.time + timeBetweenWaves;
        }
        if(Time.time%60==0)
        {
            timeBetweenWaves=timeBetweenWaves-0.1f;
        }
       

    }
    
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0,spawnPoints.Length);
       for(int i = 0; i< spawnPoints.Length;i++)
       {
         if(randomIndex !=i)
         {
            Instantiate(blockPrefab,spawnPoints[i].position, Quaternion.identity);
         }
       } 
    }

    
}
