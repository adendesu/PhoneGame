using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEnemyData: MonoBehaviour
{
    private StageEnemyData stageEnemyData;
    public void OnClickStage()
    {
        stageEnemyData = gameObject.GetComponent<StageEnemyData>();
        EnemyDataSaver enemySaver = GameObject.FindGameObjectWithTag("EnemyData").GetComponent<EnemyDataSaver>();
        enemySaver.enemyIDs.Clear();
        enemySaver.enemyLvs.Clear();
        for (int i = 0; i < stageEnemyData.enemyID.Length; i++) 
        {
            enemySaver.enemyIDs.Add(stageEnemyData.enemyID[i]);
            enemySaver.enemyLvs.Add(stageEnemyData.enemyLv[i]);
        }
    }
}
