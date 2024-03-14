using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayTeamCharacter : MonoBehaviour,IRecieveDisplayMessage
{
    [SerializeField] CharacterDatas characterDatas;
    [SerializeField] GameObject[] selectImage;
    [SerializeField] GameObject[] stages;
    [SerializeField] GameObject[] stagesLv;
    GameObject[] selectedCharacters = new GameObject[3];
    // Start is called before the first frame update
    void Start()
    {
        
        for(int i = 0; i < 3; i++) 
        {
            selectedCharacters[i] = null;
        }
        DisplayCharacter();
    }



   public void DisplayCharacter() 
    {
        for(int i = 0; i < 3; i++)
        {
            SetCharacter(i);
        }
    }

    public void UpdateDisplay(int stageNumber)
    {
        SetCharacter(stageNumber);
    }

    void SetCharacter(int i)
    {
        if (TeamData.isSetCharacter[i] == -1)
        {
            stagesLv[i].SetActive(false);
            selectImage[i].GetComponent<CanvasGroup>().alpha = 1;
        }
        else
        {
            stagesLv[i].SetActive(true);
            if (selectedCharacters[i] == null)
            {
                selectedCharacters[i] = Instantiate(characterDatas.characterStatuses[TeamData.character[i]].characterModel, stages[i].transform.position, Quaternion.Euler(0, -169.4f, 0));
                
            }
            else
            {
                Destroy(selectedCharacters[i]);
                selectedCharacters[i] = Instantiate(characterDatas.characterStatuses[TeamData.character[i]].characterModel, stages[i].transform.position, Quaternion.Euler(0, -169.4f, 0));

            }
            stagesLv[i].GetComponent<TMP_Text>().text = $"Lv.{TeamData.characterLv[i]}";
            selectImage[i].GetComponent<CanvasGroup>().alpha = 0;
        }
    }
}
