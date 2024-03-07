using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class SetTeamManager :MonoBehaviour,IRecieveSelectCharacterMessage
{
    int selectNumber = 0;
    
    [SerializeField] GameObject characterScroll;
    public void SelectStage(int i)
    {
        selectNumber = i;
        characterScroll.SetActive(true);
    }

    public void SetCharacter(int characterID,int characterLv,int characterExp)
    {
        TeamData.isSetCharacter[selectNumber] = 1;
        TeamData.character[selectNumber] = characterID;
        TeamData.characterLv[selectNumber] = characterLv;
        TeamData.characterExp[selectNumber] = characterExp;

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
