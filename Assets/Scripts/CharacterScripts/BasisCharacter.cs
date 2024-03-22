using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using DG.Tweening;
using Cysharp.Threading.Tasks;
using Sequence = DG.Tweening.Sequence;

public class BasisCharacter : MonoBehaviour, CharacterBattleSkillIntereface
{
    public GameObject manager { set; private get; }
   void Start()
    {
        if (gameObject.tag == "character")
        {
            Sequence sequence = DOTween.Sequence();
            sequence
                .AppendInterval(2)
                .Append(gameObject.transform.DOMoveX(4, 0.5f).SetRelative(true));

        }
    }
    ButtleCharacterStatus buttleCharacterStatus;
    public void NomalAttack(GameObject target)
    {
        GetStatus();
        int damage = buttleCharacterStatus.attack.Value;
        manager.GetComponent<ApplyDamageScript>().ApplyDamage(target,damage,1);

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
