using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
public interface IRecieveSelectCharacterMessage :IEventSystemHandler 
{
    public void SetCharacter(int characterNumber,int characterID,int characterLv, int characterExp);
}
