using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using Cysharp.Threading.Tasks;

public class ButtleScripts : ButtleManager
{
   /*[System.NonSerialized]*/ public static ButtleCharacterStatus[] buttleCharacterStatus = new ButtleCharacterStatus[3];
    [SerializeField] ButtleCharacterView buttleCharacterView;
    List<(int number, ButtleCharacterStatus status)> statusTuple;
    
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
    public void SetCharacterView(int number, float hp, int max)
    {
        buttleCharacterView.DisplayCharacterView(number, hp, max);
    }

    protected override async UniTask SetSubscribe()
    {
      /*  GameObject[] character = GameObject.FindGameObjectsWithTag("character");
        for (int i = 0; i < character.Length; i++)
        {
            Debug.Log(character[i].GetComponent<ButtleCharacterStatus>().hp.Value);
           // character[i].GetComponent<ButtleCharacterStatus>().hp.Subscribe(_ => SetCharacterView(i, character[i].GetComponent<ButtleCharacterStatus>().hp.Value, character[i].GetComponent<ButtleCharacterStatus>().max));
        }*/
    }
}
