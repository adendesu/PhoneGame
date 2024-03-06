using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System.IO;
using System;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] PlayerDataInfo playerDataInfo;
    [SerializeField] ItemDataInfo itemDataInfo;
    [SerializeField] CharacterDataInfo characterDataInfo;
    [SerializeField] TeamDataInfo teamDataInfo;

    string playerData;
    string itemData;
    string characterData;
    string teamData;

    void Awake()
    {
        playerDataInfo.playerDataSet = WritePlayerDataTextFile;
        itemDataInfo.ItemDataSet = WriteItemDataTextFile;
        characterDataInfo.characterDataSet = WriteCharacterDataTextFile;

        playerData = ReadPlayerDataTextFile();
        itemData = ReadItemDataTextFile();
        characterData = ReadCharacterTextFile();

        SetPlayerData();
        SetItemData();
        SetCharacterData();
    }




    public void WritePlayerDataTextFile(string writeText)
    {
        
        string filePath = Application.streamingAssetsPath + "/PlayerSaveData.txt";
        File.WriteAllText(filePath, writeText);
    }

    public void WriteItemDataTextFile(string writeText)
    {

        string filePath = Application.streamingAssetsPath + "/ItemSaveData.txt";
        File.WriteAllText(filePath, writeText);
    }

    public void WriteCharacterDataTextFile(string writeText)
    {

        string filePath = Application.streamingAssetsPath + "/CharacterSaveData.txt";
        File.WriteAllText(filePath, writeText);
    }




    private string ReadPlayerDataTextFile()
    {
        
        string filePath = Application.streamingAssetsPath + "/PlayerSaveData.txt";
        
        string playerData = File.ReadAllText(filePath);

        return playerData;
        
    }

    private string ReadItemDataTextFile()
    {
        
        string filePath = Application.streamingAssetsPath + "/ItemSaveData.txt";

        string itemData = File.ReadAllText(filePath);

        return itemData;

    }

    private string ReadCharacterTextFile()
    {

        string filePath = Application.streamingAssetsPath + "/CharacterSaveData.txt";

        string characterData = File.ReadAllText(filePath);

        return characterData;

    }

    private string ReadTeamTextFile()
    {

        string filePath = Application.streamingAssetsPath + "/TeamSaveData.txt";

        string teamData = File.ReadAllText(filePath);

        return teamData;

    }




    private void SetPlayerData()
    {
        string[] datas = playerData.Split(",");
        PlayerData.playerRank = int.Parse(datas[0]);
        PlayerData.playerExp = int.Parse(datas[1]);
    }

    private void SetItemData()
    {
        string[] datas = itemData.Split(",");
        for(int i = 0; i < datas.Length; i++)
        {
            ItemData.itemPieces.Add(int.Parse(datas[i]));
        }

    }

    private void SetCharacterData()
    {
        string[] datas = characterData.Split(",");
        for (int i = 0; i < datas.Length; i++)
        {
            string[] data = datas[i].Split(".");
            CharacterData.characterID.Add(int.Parse(data[0]));
            CharacterData.characterLevel.Add(int.Parse(data[1]));
            CharacterData.characterExp.Add(int.Parse(data[2]));

        }
    }
    private void SetTeamData()
    {
        string[] datas = teamData.Split(",");
        for (int i = 0; i < 6; i++)
        {
            string[] data = datas[i].Split(".");
            TeamData.setCharacter[i] = int.Parse(data[i]);
            TeamData.character[i] = int.Parse(data[i]);
        }
    }

}
