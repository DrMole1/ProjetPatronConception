using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{


    //Instance
    public static Singleton instance;

    public enum gameState
    {
        Running,
        Paused
    };

    private gameState STATE = gameState.Running;
    private int score = 0;

    //Setup
    private void Awake()
    {
        if (instance)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            instance.score = 0;
            instance.STATE = gameState.Running;

            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<Singleton>();
                if (instance == null)
                {
                    GameObject container = new GameObject("GameManager");
                    instance = container.AddComponent<Singleton>();
                }
            }
            DontDestroyOnLoad(gameObject);
        }
    }
}
