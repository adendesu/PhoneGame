using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class CharacterGenerater : ButtleManager
{
    [SerializeField] CharacterDatas characterDatas;
    [SerializeField] private EnemyDatas enemyDatas;
    [SerializeField] GameObject[] genePoint;
    [SerializeField] private GameObject[] enemyGenePoint;
    [SerializeField] ButtleScripts buttleScripts;

    private EnemyDataSaver enemyDataSaver;

  protected override async UniTask GenerateCharacter()
  {
      enemyDataSaver = GameObject.FindGameObjectWithTag("EnemyData").GetComponent<EnemyDataSaver>();
        for (int i = 0; i < enemyDataSaver.enemyIDs.Count; i++)
        {
            GameObject enemy = Instantiate(enemyDatas.enemyStatuses[enemyDataSaver.enemyIDs[i]].enemyModel,enemyGenePoint[i].transform.position,Quaternion.Euler(0,-90,0));
            BasisCharacter basisCharacter =  enemy.AddComponent<BasisCharacter>();
            basisCharacter.manager = gameObject;
            ButtleCharacterStatus buttleCharacterStatus = enemy.AddComponent<ButtleCharacterStatus>();
            buttleCharacterStatus.stageNumber = i;
            buttleCharacterStatus.max =
                enemyDatas.enemyStatuses[enemyDataSaver.enemyIDs[i]].Hp * enemyDataSaver.enemyLvs[i];
            buttleCharacterStatus.stageNumber = i;
            buttleCharacterStatus.hp.Value = (float)enemyDatas.enemyStatuses[enemyDataSaver.enemyIDs[i]].Hp *
                                             enemyDataSaver.enemyLvs[i];
            buttleCharacterStatus.attack.Value = enemyDatas.enemyStatuses[enemyDataSaver.enemyIDs[i]].Attack *
                                                 enemyDataSaver.enemyLvs[i];
            
            buttleCharacterStatus.defense.Value = enemyDatas.enemyStatuses[enemyDataSaver.enemyIDs[i]].Defense *
                                                  enemyDataSaver.enemyLvs[i];
            buttleCharacterStatus.hp.Subscribe(_ => buttleScripts.SendDeathMotion(buttleCharacterStatus.stageNumber));

        }
        
       for(int i = 0; i < 3; i++)
        {
            if (TeamData.isSetCharacter[i] != -1)
            {
                GameObject chara = Instantiate(characterDatas.characterStatuses[TeamData.character[i]].characterModel,genePoint[i].transform.position,Quaternion.Euler(0,90,0));
                ButtleCharacterStatus buttleCharacterStatus = chara.AddComponent<ButtleCharacterStatus>();
                BasisCharacter basisCharacter = chara.AddComponent<BasisCharacter>();
                basisCharacter.manager = gameObject;
                buttleCharacterStatus.stageNumber = i;
                buttleCharacterStatus.max = characterDatas.characterStatuses[TeamData.character[i]].characterHp *
                                            TeamData.characterLv[i];
                buttleCharacterStatus.hp.Value = (float)characterDatas.characterStatuses[TeamData.character[i]].characterHp *
                                           TeamData.characterLv[i];
                buttleCharacterStatus.attack.Value = characterDatas.characterStatuses[TeamData.character[i]].characerAttack *
                                               TeamData.characterLv[i];
                buttleCharacterStatus.defense.Value =
                    characterDatas.characterStatuses[TeamData.character[i]].characterDefense * TeamData.characterLv[i];
                
              
                
                ButtleScripts.buttleCharacterStatus[i] = chara.GetComponent<ButtleCharacterStatus>();
                buttleCharacterStatus.hp.Subscribe(_ => buttleScripts.SetCharacterView(buttleCharacterStatus.stageNumber,buttleCharacterStatus.hp.Value, buttleCharacterStatus.max));

                buttleScripts.SendCharacterView(i,characterDatas.characterStatuses[TeamData.character[i]].characterSprite, characterDatas.characterStatuses[TeamData.character[i]].characterName);
                buttleScripts.SetCharacterView(i, buttleCharacterStatus.hp.Value, buttleCharacterStatus.max);

            }
            else
            {
                ButtleScripts.buttleCharacterStatus[i] = null;
                buttleScripts.SendDisView(i);
            }
        }
    }
}
