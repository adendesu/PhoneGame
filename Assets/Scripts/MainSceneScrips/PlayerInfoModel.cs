using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UniRx;

public class PlayerInfoModel : MonoBehaviour
{
   [System.NonSerialized] public ReactiveProperty<string> playerName = new ReactiveProperty<string>("");
    [System.NonSerialized] public ReactiveProperty<int> playerRank = new ReactiveProperty<int>(1);
    [System.NonSerialized] public ReactiveProperty<float> playerExp = new ReactiveProperty<float>(0f);

   

   public async UniTask UpdatePlayerData()
    {
        playerName.Value = PlayerData.playerName;
        int i = 1;
 
        playerRank.Value = PlayerData.playerRank;
        
        float exp = PlayerData.playerExp;
        while (exp >= 100)
        {
            i++;
            exp -= 100;
        }
        playerRank.Value = i;
        playerExp.Value = exp / 100;
    }
}
