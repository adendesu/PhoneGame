using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyDamageScript : MonoBehaviour,ISurveDamageMessage
{
    public void ApplyDamage(GameObject target,int ATK,float skill)
    {
        ButtleCharacterStatus buttleCharacterStatus = target.GetComponent<ButtleCharacterStatus>();
        int damage = (ATK / 2) - (buttleCharacterStatus.defense.Value / 4);
        buttleCharacterStatus.hp.Value -= damage * skill;
    }
}
