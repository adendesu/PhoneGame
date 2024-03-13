using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class ButtleScripts : ButtleManager
{
   [System.NonSerialized] public ButtleCharacterStatus[] buttleCharacterStatus;
    [SerializeField] ButtleCharacterView buttleCharacterView;
    // Start is called before the first frame update
 

    // Update is called once per frame

   public void SendCharacterView(int number, Sprite sp, string n)
    {
        buttleCharacterView.SetCharacterView(number, sp, n);

    }

    public void SendDisView(int number)
    {
        buttleCharacterView.DisDisplay(number);

    }

    protected override async UniTask SetSubscribe()
    {
        buttleCharacterStatus[0].hp.Subscribe(_ => buttleCharacterView.DisplayCharacterView(0, buttleCharacterStatus[0].hp.Value, buttleCharacterStatus[0].max));
        buttleCharacterStatus[1].hp.Subscribe(_ => buttleCharacterView.DisplayCharacterView(1, buttleCharacterStatus[1].hp.Value, buttleCharacterStatus[1].max));
        buttleCharacterStatus[2].hp.Subscribe(_ => buttleCharacterView.DisplayCharacterView(2, buttleCharacterStatus[2].hp.Value, buttleCharacterStatus[2].max));

    }
}
