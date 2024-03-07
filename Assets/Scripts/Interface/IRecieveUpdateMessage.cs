using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public interface IRecieveUpdateMessage : IEventSystemHandler
{
    void CreateStringData();
}
