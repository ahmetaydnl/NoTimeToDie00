using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("DemoScene"); // Sahne adýnýn doðru yazýldýðýndan emin olun
    }
}
