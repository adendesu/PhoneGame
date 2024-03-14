using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "CreateCharacter")]
public class CharacterStatus : ScriptableObject
{

    [Header("キャラクターID")]
    [SerializeField] public int characterID = 0;

    [Header("キャラクター種類")]
    [SerializeField] public int characterNumber = 0;

    [Header("キャラクターモデル")]
    [SerializeField] public GameObject characterModel = null;

    [Header("キャラクターアイコン")]
    [SerializeField] public Sprite characterSprite = null;

    [Header("キャラクター名")]
    [SerializeField] public string characterName = "";
    
    [Header("キャラクターHP")]
    [SerializeField] public int characterHp = 0;

    [Header("キャラクター攻撃力")]
    [SerializeField] public int characerAttack = 0;

    [Header("キャラクター防御力")]
    [SerializeField] public int characterDefense = 0;


    public int ID { get { return characterID; } }
    public int Number { get { return characterNumber; } }
    public string Name { get { return characterName; } }
    public GameObject Model { get { return characterModel; } }
    public Sprite Sprite { get { return characterSprite; } }
    public int Hp { get { return characterHp; } }
    public int Attack { get { return characerAttack; } }
    public int Defense { get { return characterDefense; } }
        
}
