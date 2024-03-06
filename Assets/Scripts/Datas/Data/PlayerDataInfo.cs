using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerData
{
    public static int playerRank;
    public static int playerExp;
}

public class PlayerDataInfo : MonoBehaviour
{
    [System.NonSerialized] public UnityAction<string> playerDataSet;

    string setStringData;
    // Start is called before the first frame update

    void DataSet()
    {
        playerDataSet?.Invoke(setStringData);
    }

    void CreateStringData()
    {
        setStringData = $"{PlayerData.playerRank},{PlayerData.playerExp}";
        DataSet();
    }
}


