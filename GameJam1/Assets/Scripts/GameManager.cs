using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int diamondCount;
    public int totalDiamonds = 9; // Toplam elmas sayýsý

    public TextMeshProUGUI diamondCountText; // Elmas sayýsýný gösteren metin bileþeni
    public GameObject gameOverScreen; // Oyun bitiþ ekraný

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        diamondCount = 0;
        UpdateDiamondCountText(); // Baþlangýçta elmas sayýsýný göster
    }

    public void AddDiamond(int amount)
    {
        diamondCount += amount;
        Debug.Log("Toplam elmas: " + diamondCount);

        // Tüm elmaslar toplandýðýnda oyunu bitir
        if (diamondCount >= totalDiamonds)
        {
            EndGame();
        }
        else
        {
            UpdateDiamondCountText(); // Elmas sayýsýný güncelle
        }
    }

    void UpdateDiamondCountText()
    {
        if (diamondCountText != null)
        {
            diamondCountText.text = "Diamonds: " + diamondCount.ToString();
        }
    }

    void EndGame()
    {
        // Oyunu durdurabilir veya bitiþ ekranýný etkinleþtirebilirsiniz
        Time.timeScale = 0; // Oyunu durdurur
        gameOverScreen.SetActive(true); // Bitiþ ekranýný gösterir
    }
}
