using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class DebugTest : MonoBehaviour
{
    private int[] a = new int[2];
    // Start is called before the first frame update
    void Start()
    {

       /* Debug.Log("start");
        for (int i = 0; i < 2; i++)
        {
            a[i] = i;
        }*/

       /* Debug.Log($"{PlayerData.playerRank},{PlayerData.playerExp}");
        for(int i = 0; i < ItemData.itemPieces.Count; i++)
        {
            Debug.Log($"アイテム数{i}:{ItemData.itemPieces[i]}");
        }

        for(int i = 0; i < CharacterData.characterID.Count; i++)
        {
            Debug.Log($"キャラクター{CharacterData.characterID[i]}:{CharacterData.characterLevel[i]}:{CharacterData.characterExp[i]}");
        }*/

    }

   /* async UniTask Update()
    {
        Debug.Log("update");
        for (int i = 0; i < 2; i++)
        {
            Debug.Log(a[i]);
        }
    }*/

    public void Back()
    {
        SceneManager.LoadScene("Title");
    }
    
}
