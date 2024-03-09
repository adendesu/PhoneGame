using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class PlayerInfoModel : MonoBehaviour
{
   [System.NonSerialized] public string playerName;
    [System.NonSerialized] public int playerRank;
    [System.NonSerialized] public int playerExp;

   

   public async UniTask UpdatePlayerData()
    {
        playerName = PlayerData.playerName;
        playerRank = PlayerData.playerRank;
        playerExp = PlayerData.playerExp;
    }
}
