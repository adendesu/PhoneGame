using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ButtleCharacterView : MonoBehaviour
{
    [SerializeField] Image[] characterSprite;
    [SerializeField] TMP_Text[] characterName;
    [SerializeField] TMP_Text[] characterHp;
    [SerializeField] TMP_Text[] characterMax;
    [SerializeField] Slider[] characterSlider;

    [SerializeField] GameObject[] characterUI;

   public void SetCharacterView(int number, Sprite sp, string n)
    {
        if (number != -1)
        {
            characterSprite[number].sprite = sp;
            characterName[number].text = n;
        }
        
    }

  public void DisplayCharacterView(int number, float hp, int max)
    {
        characterHp[number].text = hp.ToString();
        characterMax[number].text = max.ToString();
        characterSlider[number].value = hp / max;
    }

    public void DisDisplay(int i)
    {   
        characterUI[i].SetActive(false);
    }
}
