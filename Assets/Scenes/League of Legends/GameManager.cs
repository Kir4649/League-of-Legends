using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject minionnPrefab;
    public Vector3 blueSpawnLocation = new Vector3(-40, 1, -40);
    public Vector3 redSpawnLocation  = new Vector3( 40, 1,  40);
    public Vector3 botLaneLocation   = new Vector3( 40, 1, -40);
    public Vector3 topLaneLocation   = new Vector3(-40, 1, -40);
    bool spawn = true;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
            GameObject minionSpawned;
            minionSpawned = Instantiate(minionnPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAIScript>().destination = redSpawnLocation;
            minionSpawned = Instantiate(minionnPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAIScript>().destination = botLaneLocation;
            minionSpawned = Instantiate(minionnPrefab, blueSpawnLocation, Quaternion.identity);
            minionSpawned.GetComponent<MinionAIScript>().destination = topLaneLocation;

            spawn= false;
        }
    }
        
}
