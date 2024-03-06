using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemData
{
    public static List<int> itemPieces = new List<int>();
}

public class ItemDataInfo : MonoBehaviour
{
    [System.NonSerialized] public UnityAction<string> ItemDataSet;
    string setStringData;

    void DataSet()
    {
        ItemDataSet?.Invoke(setStringData);
    }

    void CreateStringData()
    {
        int itemCount = ItemData.itemPieces.Count;
        for (int i =0; i < itemCount; i++)
        {
            setStringData += $"{ItemData.itemPieces[i]}";
            if(i < itemCount - 1)
            {
                setStringData += ",";
            }
        }
        DataSet();
    }
}
