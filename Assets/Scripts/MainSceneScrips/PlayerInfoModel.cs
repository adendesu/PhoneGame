using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class PlayerInfoModel : MonoBehaviour
{
   [System.NonSerialized] public string playerName;
    [System.NonSerialized] public int playerRank;
    [System.NonSerialized] public int playerExp;

    [SerializeField] GameObject intefaceObj;

   void RankUp(int exp)
    {
        playerRank = exp;
        PlayerData.playerExp = exp;
        int rank = exp / 100;
        if (playerRank < rank)
        {
            playerRank = rank;
            PlayerData.playerRank = rank;
            intefaceObj.GetComponent<IUpdateMainViewMessage>().UpdateRank();
        }
    }

   public async UniTask UpdatePlayerData()
    {
        playerName = PlayerData.playerName;
        playerRank = PlayerData.playerRank;
        playerExp = PlayerData.playerExp;
    }
}
