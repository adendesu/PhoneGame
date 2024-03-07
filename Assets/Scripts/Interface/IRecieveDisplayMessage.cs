using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface IRecieveDisplayMessage : IEventSystemHandler
{
    public void UpdateDisplay(int stageNumber);
}
