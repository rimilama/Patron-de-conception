using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerScene : MonoBehaviour
{
    public Text Val;
    // Start is called before the first frame update
    void Start()
    {
        Val.text = Singleton.Instance.val.ToString();
    }

    // Update is called once per frame
    public void GoToFirst()
    {
        SceneManager.LoadScene("One");
        Singleton.Instance.val++;
    }

    public void GoToSecond()
    {
        SceneManager.LoadScene("Two");
        Singleton.Instance.val++;
    }
}
