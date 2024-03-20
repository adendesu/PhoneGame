using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "CreateEnemy")]
public class EnemyStatus : ScriptableObject
{
    [Header("敵ID")]
    [SerializeField] public int enemyID = 0;

    [Header("敵モデル")]
    [SerializeField] public GameObject enemyModel = null;

    [Header("敵アイコン")]
    [SerializeField] public Sprite enemySprite = null;

    [Header("敵名")]
    [SerializeField] public string enemyName = "";
    
    [Header("敵HP")]
    [SerializeField] public int enemyHp = 0;

    [Header("敵攻撃力")]
    [SerializeField] public int enemyAttack = 0;

    [Header("敵防御力")]
    [SerializeField] public int enemyDefense = 0;


    public int ID { get { return enemyID; } }
    public string Name { get { return enemyName; } }
    public GameObject Model { get { return enemyModel; } }
    public Sprite Sprite { get { return enemySprite; } }
    public int Hp { get { return enemyHp; } }
    public int Attack { get { return enemyAttack; } }
    public int Defense { get { return enemyDefense; } }
}
