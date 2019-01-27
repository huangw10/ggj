using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_start : MonoBehaviour
{
    // Start is called before the first frame update
    public void to_start()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
