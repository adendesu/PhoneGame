using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneMoveButton : MonoBehaviour
{
    SceneMoveManager sceneMoveManager;
    private void Start()
    {
        sceneMoveManager = (SceneMoveManager)FindObjectOfType(typeof(SceneMoveManager));
    }
    public void OnNextButton(string next)
    {
        sceneMoveManager.MoveScene(next);
    }
    public void OnBackButton()
    {
        sceneMoveManager.BackScene();
    }
}
