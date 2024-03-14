using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SetTeamManager :MonoBehaviour,IRecieveSelectCharacterMessage
{
    int selectNumber = 0;
    
    [SerializeField] GameObject characterScroll;
    [SerializeField] TeamSelectUI teamSelectUI;
    public void SelectStage(int i)
    {
        selectNumber = i;
        characterScroll.SetActive(true);
    }

    public void SetCharacter(int characterNumber,int characterID,int characterLv,int characterExp)
    {
        bool canSet = true;
        for(int i = 0; i < 3; i++)
        {
            if (TeamData.isSetCharacter[i] == characterNumber)
            {
                canSet = false;
                teamSelectUI.DisplayMessage("同じキャラクターは編成できません。");
            }
        }
        if(canSet == true)
        {
            TeamData.isSetCharacter[selectNumber] = characterNumber;
            TeamData.character[selectNumber] = characterID;
            TeamData.characterLv[selectNumber] = characterLv;
            TeamData.characterExp[selectNumber] = characterExp;
        }


        SendUpdateMessage();
        characterScroll.SetActive(false);
    }

    void SendUpdateMessage()
    {
        ExecuteEvents.Execute<IRecieveUpdateMessage>(
            target: GameObject.FindGameObjectWithTag("WRDataObj"),
            eventData: null,
            functor: (recieveTarget,y)=>recieveTarget.CreateStringData());

        ExecuteEvents.Execute<IRecieveDisplayMessage>(
            target: gameObject,
            eventData: null,
            functor: (recieveTarget, y) => recieveTarget.UpdateDisplay(selectNumber));
    }
}
