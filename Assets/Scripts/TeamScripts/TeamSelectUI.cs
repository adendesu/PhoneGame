using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;

public class TeamSelectUI : MonoBehaviour
{
    [SerializeField] GameObject cantSetMessage;

    public void DisplayMessage(string message)
    {
        cantSetMessage.GetComponent<TMP_Text>().text = message;
        Sequence sequence = DOTween.Sequence();

        sequence.Append(cantSetMessage.GetComponent<CanvasGroup>().DOFade(1, 0.2f))
            .AppendInterval(1)
            .Append(cantSetMessage.GetComponent<CanvasGroup>().DOFade(0, 0.2f));



    }
}
