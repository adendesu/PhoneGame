using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMoveManager : MonoBehaviour
{
    [SerializeField] string[] sceneName;

    Stack<string> sceneStack = new Stack<string>();
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
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
