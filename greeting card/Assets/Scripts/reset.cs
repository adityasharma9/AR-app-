using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

}
