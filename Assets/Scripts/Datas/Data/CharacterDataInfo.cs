using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CharacterData
{
    public static List<int> characterID = new List<int>();
    public static List<int> characterLevel = new List<int>();
    public static List<int> characterExp = new  List<int>();
}

public class CharacterDataInfo : MonoBehaviour
{
    [System.NonSerialized] public UnityAction<string> characterDataSet;
    string setStringData;

    void DataSet()
    {
        characterDataSet?.Invoke(setStringData);
    }

    void CreateStringData()
    {

        int characterCount = CharacterData.characterID.Count;
        for (int i = 0; i < characterCount; i++)
        {
            setStringData += $"{CharacterData.characterID[i]}.{CharacterData.characterLevel[i]}.{CharacterData.characterExp[i]}";
            if (i < characterCount - 1)
            {
                setStringData += ",";
            }
        }

        DataSet();
    }
}
