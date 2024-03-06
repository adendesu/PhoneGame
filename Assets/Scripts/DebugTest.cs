using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class DebugTest : MonoBehaviour
{
    // Start is called before the first frame update
    async UniTask Start()
    {

        UniTask.WaitForSeconds(2);
        Debug.Log($"{PlayerData.playerRank},{PlayerData.playerExp}");
        for(int i = 0; i < ItemData.itemPieces.Count; i++)
        {
            Debug.Log($"アイテム数{i}:{ItemData.itemPieces[i]}");
        }

        for(int i = 0; i < CharacterData.characterID.Count; i++)
        {
            Debug.Log($"キャラクター{CharacterData.characterID[i]}:{CharacterData.characterLevel[i]}:{CharacterData.characterExp[i]}");
        }

    }

    
}
