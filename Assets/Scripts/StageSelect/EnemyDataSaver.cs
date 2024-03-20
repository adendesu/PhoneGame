using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDataSaver : MonoBehaviour
{
    public List<int> enemyIDs = new List<int>();
    public List<int> enemyLvs = new List<int>();
    
    private static EnemyDataSaver enemyDataSaverinstance;
    private void Awake()
    {
        if (enemyDataSaverinstance == null)
        {
            enemyDataSaverinstance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
}
