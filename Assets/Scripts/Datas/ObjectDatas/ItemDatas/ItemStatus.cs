using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item")]
public class ItemStatus : ScriptableObject
{
    [Header("アイテムID")]
    [SerializeField] public int itemID = 0;

    [Header("アイテム名")]
    [SerializeField] public string itemName = "";

    [Header("アイテム説明")]
    [SerializeField] public string itemExam = "";

    [Header("アイテムレアリティ")]
    [SerializeField,Range(0,2)] public int itemRarily = 0; //0:ノーマル　1:レア　2:スーパーレア

    [Header("アイテム画像")]
    [SerializeField] public Sprite  itemImage = null;


    public int ID { get { return itemID; } }
    public string Name { get { return itemName; } }
    public string Exam { get { return itemExam; } }
    public int Rarily { get { return itemRarily; } }
    public Sprite image { get { return itemImage; } }
}
