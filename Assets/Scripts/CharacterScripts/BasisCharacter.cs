using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasisCharacter : MonoBehaviour, CharacterBattleSkillIntereface
{
    ButtleCharacterStatus buttleCharacterStatus;
    public void NomalAttack(GameObject target)
    {
        GetStatus();
        int damage = buttleCharacterStatus.attack.Value;
        target.GetComponent<ISurveDamageMessage>().ApplyDamage(target,buttleCharacterStatus.attack.Value,1);

    }
    public void SkillAttack(GameObject target)
    {
        
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
