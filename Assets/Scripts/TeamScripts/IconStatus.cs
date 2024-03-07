using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconStatus : MonoBehaviour
{
    public int characterIconID;
    public int characterIconLevel;
    public int characterIconExp;
   [System.NonSerialized] public GameObject setTeam;

    public void SelectCharacter()
    {
        ExecuteEvents.Execute<IRecieveSelectCharacterMessage>(
            target:setTeam,
            eventData:null,
            functor:(recieveTarget,y)=> recieveTarget.SetCharacter(characterIconID, characterIconLevel, characterIconExp));
    }
}
