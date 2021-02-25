using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int RoundTime = 0;
    private int Round = 0;
    public int Enemies = 0;
    private int MaxEnemyNum = 3;

    private bool RoundActive = false;

    private void Start()
    {
        MaxEnemyNum = 60;
    }

    private void Update()
    {
        
    }


    private void SpawnEnemy()
    {
        for(int i = 0; i < MaxEnemyNum; i++)
        {
            //Spawn Enemy
            Enemies--;
        }
    }

    private void RoundStart()
    {
        while (RoundActive == false)
        {
            if (Round != 1)
            {
                MaxEnemyNum = MaxEnemyNum + 40;
                Enemies = MaxEnemyNum;
                RoundActive = true;
            }
            else
            {
                Enemies = MaxEnemyNum;
                RoundActive = true;
            }
        }
    }

    private void EndRound()
    {
        
    }
}
