using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // E tuþuna basýldýðýnda sahneyi deðiþtir
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Demo_Scene2"); // Sahne adýnýn doðru yazýldýðýndan emin olun
        }
    }
}
