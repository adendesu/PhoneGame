using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class CharacterGenerater : ButtleManager
{
    [SerializeField] CharacterDatas characterDatas;
    [SerializeField] GameObject[] genePoint;
    [SerializeField] ButtleScripts buttleScripts;


  protected override async UniTask GenerateCharacter()
    {
       for(int i = 0; i < 3; i++)
        {
            if (TeamData.isSetCharacter[i] != -1)
            {
                GameObject chara = Instantiate(characterDatas.characterStatuses[TeamData.character[i]].characterModel,genePoint[i].transform.position,Quaternion.Euler(0,90,0));
                ButtleCharacterStatus buttleCharacterStatus = chara.AddComponent<ButtleCharacterStatus>();
                BasisCharacter basisCharacter = chara.AddComponent<BasisCharacter>();

                buttleCharacterStatus.stageNumber = i;
                buttleCharacterStatus.max = characterDatas.characterStatuses[TeamData.character[i]].characterHp * TeamData.characterLv[i];
                buttleCharacterStatus.hp.Value = (float)characterDatas.characterStatuses[TeamData.character[i]].characterHp * TeamData.characterLv[i];
                buttleCharacterStatus.attack.Value = characterDatas.characterStatuses[TeamData.character[i]].characerAttack * TeamData.characterLv[i];
                buttleCharacterStatus.defense.Value = characterDatas.characterStatuses[TeamData.character[i]].characterDefense * TeamData.characterLv[i];

                ButtleScripts.buttleCharacterStatus[i] = chara.GetComponent<ButtleCharacterStatus>();
                buttleCharacterStatus.hp.Subscribe(_ => buttleScripts.SetCharacterView(i,buttleCharacterStatus.hp.Value, buttleCharacterStatus.max));

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
