using UnityEngine.SceneManagement;
using UnityEngine;

public class Back : MonoBehaviour
{
    public void BackGame()
    {
        SceneManager.LoadScene("Welcome");
    }
}
