using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // E tu�una bas�ld���nda sahneyi de�i�tir
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Demo_Scene2"); // Sahne ad�n�n do�ru yaz�ld���ndan emin olun
        }
    }
}
