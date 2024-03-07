using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneMove : MonoBehaviour
{
    public void MoveScene()
    {
        SceneManager.LoadScene("Main");
    }
}
