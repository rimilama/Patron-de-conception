using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton _instance = null;

    public int val;

    public static Singleton Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<Singleton>();
                if(_instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.name = "singleton cree";
                    _instance = singleton.AddComponent<Singleton>();
                    DontDestroyOnLoad(singleton);
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
