using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float totalTime = 300f; // Baþlangýç zamaný (5 dakika = 300 saniye)
    public TMP_Text timeText; // TextMeshPro UI bileþeni

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
            UpdateTimeText();
        }
        else
        {
            // Zaman dolduðunda yapýlacak iþlemler
            Debug.Log("Zaman doldu! Bölüm baþarýsýz!");
        }
    }

    void UpdateTimeText()
    {
        int minutes = Mathf.FloorToInt(totalTime / 60);
        int seconds = Mathf.FloorToInt(totalTime % 60);
        timeText.text = string.Format("Zaman: {0:00}:{1:00}", minutes, seconds);
    }

    public bool SpendTime(float amount)
    {
        if (totalTime >= amount)
        {
            totalTime -= amount;
            UpdateTimeText();
            return true;
        }
        else
        {
            Debug.Log("Yeterli zaman yok!");
            return false;
        }
    }
}
