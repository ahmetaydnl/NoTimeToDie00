using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float totalTime = 300f; // Ba�lang�� zaman� (5 dakika = 300 saniye)
    public TMP_Text timeText; // TextMeshPro UI bile�eni

    void Update()
    {
        if (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
            UpdateTimeText();
        }
        else
        {
            // Zaman doldu�unda yap�lacak i�lemler
            Debug.Log("Zaman doldu! B�l�m ba�ar�s�z!");
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
