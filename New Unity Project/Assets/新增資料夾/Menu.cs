using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
     public void gamestart()
    {

        Debug.Log("start");
        SceneManager.LoadScene("LV1");
    }

     public void quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
