using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTeamCharacter : MonoBehaviour
{

    [SerializeField] GameObject characterScrollView;
    public void onSetCharacterNumber(int i)
    {
        characterScrollView.SetActive(true);
    }

   
}
