using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class PlayerInfoPresenter : MonoBehaviour,IUpdateMainViewMessage
{
    [SerializeField] PlayerUI playerUI;
    [SerializeField] PlayerInfoModel playerInfoModel;

    async UniTask Start()
    {
        await playerInfoModel.UpdatePlayerData();
        DisplayUI();
    }

    void DisplayUI()
    {
        playerUI.DisplayPlayerInfo(playerInfoModel.playerName, playerInfoModel.playerRank.ToString());
    }

    void UpdateRank()
    {
        DisplayUI();
    }
}
