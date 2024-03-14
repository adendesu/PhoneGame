using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.UI;
using TMPro;
public class CreateCharacterIcon : MonoBehaviour
{
    [SerializeField] CharacterDatas characterDatas;
    [SerializeField] GameObject characterIcon;
    [SerializeField] GameObject setTeam;
    private async UniTask Start()
    {
        for(int i = 0; i < CharacterData.characterID.Count; i++)
        {
            GameObject instansedIcon = Instantiate(characterIcon);
            instansedIcon.transform.parent = gameObject.transform;

            IconStatus iconStatus = instansedIcon.GetComponent<IconStatus>();
            iconStatus.characterNumber = characterDatas.characterStatuses[CharacterData.characterID[i]].characterNumber;
            iconStatus.characterIconID = CharacterData.characterID[i];
            iconStatus.characterIconLevel = CharacterData.characterLevel[i];
            iconStatus.characterIconExp = CharacterData.characterExp[i];
            iconStatus.setTeam = setTeam;

            instansedIcon.transform.GetChild(0).GetComponent<Image>().sprite = characterDatas.characterStatuses[CharacterData.characterID[i]].characterSprite;
            instansedIcon.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = $"Lv.{CharacterData.characterLevel[i]}";

            await UniTask.WaitForSeconds(0.001f);
        }
    }
}
