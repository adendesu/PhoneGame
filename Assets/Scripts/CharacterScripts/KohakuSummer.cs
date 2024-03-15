using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class KohakuSummer : MonoBehaviour, CharacterBattleSkillIntereface
{
    ButtleCharacterStatus buttleCharacterStatus;
   public void NomalAttack(GameObject target) 
    {
        GetStatus();
        int damage = buttleCharacterStatus.attack.Value;
        target.GetComponent<ISurveDamageMessage>().ApplyDamage(damage);
        
    }
   public void SkillAttack() 
    {
        GetStatus();
    }
   public void BigSkillAttack() 
    {
        GetStatus();
    }

    void GetStatus()
    {
        if (buttleCharacterStatus == null)
        {
            buttleCharacterStatus = gameObject.GetComponent<ButtleCharacterStatus>();
        }
        
    }
}
