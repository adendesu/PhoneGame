using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class ButtleManager : MonoBehaviour
{
    // Start is called before the first frame update
    async  void Start()
    {
        await GenerateCharacter();
        await SetSubscribe();
    }
    

    protected virtual async UniTask GenerateCharacter() { }
    protected virtual async UniTask SetSubscribe() { }
}
