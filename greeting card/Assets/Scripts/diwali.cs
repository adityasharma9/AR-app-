using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class diwali : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

}
