using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void StartGameScene()
    {
        SceneManager.LoadScene("DemoScene"); // Sahne ad�n�n do�ru yaz�ld���ndan emin olun
    }
}
