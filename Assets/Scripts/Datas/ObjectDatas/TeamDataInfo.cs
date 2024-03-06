using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TeamData
{
    public static int[] isSetCharacter = new int[6];
    public static int[] character = new int[6];
}

public class TeamDataInfo : MonoBehaviour
{
    [System.NonSerialized] public UnityAction<string> teamDataSet;
    string setStringData;

    void DataSet()
    {
        teamDataSet?.Invoke(setStringData);
    }

    void CreateStringData()
    {

       
        for (int i = 0; i < 6; i++)
        {
            setStringData += $"{TeamData.isSetCharacter[i]}.{TeamData.character[i]}";
            if (i < 5)
            {
                setStringData += ",";
            }
        }

        DataSet();
    }
}
