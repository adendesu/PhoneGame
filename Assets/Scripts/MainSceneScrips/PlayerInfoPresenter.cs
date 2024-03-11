using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UniRx;

public class PlayerInfoPresenter : MonoBehaviour
{
    [SerializeField] PlayerUI playerUI;
    [SerializeField] PlayerInfoModel playerInfoModel;

    async UniTask Start()
    {
        await playerInfoModel.UpdatePlayerData();
        playerInfoModel.playerExp.Subscribe(_ => DisplayUI());
        DisplayUI();
    }
    void DisplayUI()
    {
        playerUI.DisplayPlayerInfo(playerInfoModel.playerName.Value, playerInfoModel.playerRank.Value.ToString(),playerInfoModel.playerExp.Value);
        Debug.Log(playerInfoModel.playerName.Value);
    }
}
