using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionSpawner : MonoBehaviour
{
    public float minionMoveSpeed;
    public float superminionSpeed;

    public GameObject minionPrefab;
    public GameObject superMinionPrefab;
    public Transform[] spawnPoint;
    public float spwnInterval = 20.0f;
    public int minionPerWave = 4;//ƒ~ƒjƒIƒ“‚ğ¢Š«‚·‚é”
    public int wavesUntilSuperMinion = 3;
    private int waveCount = 0;

    public float delaBetweenMinion;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
