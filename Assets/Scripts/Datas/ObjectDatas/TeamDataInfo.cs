using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class TeamData
{
    public static int[] isSetCharacter = new int[3];
    public static int[] character = new int[3];
    public static int[] characterLv = new int[3];
    public static int[] characterExp = new int[3];
}

public class TeamDataInfo : MonoBehaviour,IRecieveUpdateMessage
{
    [System.NonSerialized] public UnityAction<string> teamDataSet;
    string setStringData;

    void DataSet()
    {
        teamDataSet?.Invoke(setStringData);
    }

   public void CreateStringData()
    {

        setStringData = "";
        for (int i = 0; i < 3; i++)
        {
            setStringData += $"{TeamData.isSetCharacter[i]}.{TeamData.character[i]}.{TeamData.characterLv[i]}.{TeamData.characterExp[i]}";
            if (i < 2)
            {
                setStringData += ",";
            }
        }

        DataSet();
    }
}
