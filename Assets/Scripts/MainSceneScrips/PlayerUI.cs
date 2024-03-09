using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] TMP_Text playerRank;

    public void DisplayPlayerInfo(string name, string rank)
    {
        playerName.text = name;
        playerRank.text = rank;
    }
        

}
