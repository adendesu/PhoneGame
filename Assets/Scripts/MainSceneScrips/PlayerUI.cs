using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] TMP_Text playerRank;
    [SerializeField] Slider playerExpSlider;
    public void DisplayPlayerInfo(string name, string rank,float exp)
    {
        playerName.text = name;
        playerRank.text = rank;
        playerExpSlider.value = exp;
        Debug.Log(exp);
    }
        

}
