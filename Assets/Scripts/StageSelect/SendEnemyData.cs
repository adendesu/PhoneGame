using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEnemyData: MonoBehaviour
{
    private StageEnemyData stageEnemyData;
    [SerializeField] private SceneMoveButton sceneMoveButton;
    public void OnClickStage()
    {
        stageEnemyData = gameObject.GetComponent<StageEnemyData>();
        EnemyDataSaver enemySaver = GameObject.FindGameObjectWithTag("EnemyData").GetComponent<EnemyDataSaver>();
        enemySaver.enemyCounts.Clear();
        enemySaver.enemyIDs.Clear();
        enemySaver.enemyLvs.Clear();

        for (int i = 0; i < stageEnemyData.enemyCount.Length; i++) 
        {
            enemySaver.enemyCounts.Add(stageEnemyData.enemyCount[i]);
        }
        
        for (int i = 0; i < stageEnemyData.enemyID.Length; i++)
        {
            enemySaver.enemyIDs.Add(stageEnemyData.enemyID[i]);
        }

        for (int i = 0; i < stageEnemyData.enemyLv.Length; i++)
        {
            enemySaver.enemyLvs.Add(stageEnemyData.enemyLv[i]);
        }
        
        

        enemySaver.thisStageNumber = stageEnemyData.stageNumber;
        sceneMoveButton.OnNextButton("SelectCharacter");
    }
}
