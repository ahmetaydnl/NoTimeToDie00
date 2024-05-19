using TMPro;
using UnityEngine;

public class TaskDisplay : MonoBehaviour
{
    public TextMeshProUGUI taskText;

    void Start()
    {
        if (taskText == null)
        {
            Debug.LogWarning("TextMeshPro component not found!");
        }
        else
        {
            taskText.text = "Hello, World!";
        }
    }
}
