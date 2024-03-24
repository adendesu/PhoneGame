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
    private Animator animator;
    private Vector3 thisPosition;
   void Start()
   {
       
       animator = GetComponent<Animator>();
       
        if (gameObject.tag == "character")
        {
            Sequence sequence = DOTween.Sequence();
            sequence
                .AppendInterval(2)
                .Append(gameObject.transform.DOMoveX(4, 0.5f).SetRelative(true))
                .AppendCallback(() =>
                {
                    thisPosition = gameObject.transform.position;
                });
           
        }
        else
        {
            thisPosition = gameObject.transform.position;
        }
    }
    ButtleCharacterStatus buttleCharacterStatus;
    public void NomalAttack(GameObject target)
    {
        
        GetStatus();
        int damage = buttleCharacterStatus.attack.Value;
        Sequence sequence = DOTween.Sequence();
        Vector3 targetPosition = new Vector3(target.transform.position.x + (target.transform.forward.x), target.transform.position.y,
            target.transform.position.z);
        sequence
            .Append(gameObject.transform.DOMove(targetPosition, 1))
            .JoinCallback(() =>
            {
                animator.SetBool("Run", true);
            })
            .AppendCallback(() =>
            {
                manager.GetComponent<ApplyDamageScript>().ApplyDamage(target, damage, 1);
            })
            .JoinCallback(() =>
            {
                animator.SetBool("Run", false);
                animator.SetBool("Attack", true);
            })
            .AppendInterval(1)
            .Append(gameObject.transform.DOMove(thisPosition, 0.5f))
            .JoinCallback(() =>
            {
                animator.SetBool("Attack", false);
            });


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
