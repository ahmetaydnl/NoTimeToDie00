using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private int diamondCount;
    public int totalDiamonds = 9; // Toplam elmas say�s�

    public TextMeshProUGUI diamondCountText; // Elmas say�s�n� g�steren metin bile�eni
    public GameObject gameOverScreen; // Oyun biti� ekran�

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        diamondCount = 0;
        UpdateDiamondCountText(); // Ba�lang��ta elmas say�s�n� g�ster
    }

    public void AddDiamond(int amount)
    {
        diamondCount += amount;
        Debug.Log("Toplam elmas: " + diamondCount);

        // T�m elmaslar topland���nda oyunu bitir
        if (diamondCount >= totalDiamonds)
        {
            EndGame();
        }
        else
        {
            UpdateDiamondCountText(); // Elmas say�s�n� g�ncelle
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
        // Oyunu durdurabilir veya biti� ekran�n� etkinle�tirebilirsiniz
        Time.timeScale = 0; // Oyunu durdurur
        gameOverScreen.SetActive(true); // Biti� ekran�n� g�sterir
    }
}
