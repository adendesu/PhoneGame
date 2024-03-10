using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    [SerializeField] string[] sceneName;

    SceneMoveManager instance;

    Stack<string> sceneStack = new Stack<string>();
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void MoveScene(string nextName) 
    {
        sceneStack.Push(SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(nextName);
    }

    public void BackScene()
    {
        SceneManager.LoadScene(sceneStack.Pop());
    }

    public void ResetStack()
    {
        sceneStack.Clear();
    }
}
