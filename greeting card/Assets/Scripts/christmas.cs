using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class christmas : MonoBehaviour
{
    public void OnMouseUp()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }

}
