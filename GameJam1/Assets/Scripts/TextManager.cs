using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public GameObject acceptButton; // Kabul Et butonunun referansý
    public float interactionDistance = 3f; // Etkileþim mesafesi
    private Transform player;

    void Start()
    {
        // Player'ý tag ile bul
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Butonu baþlangýçta gizli yap
        acceptButton.SetActive(false);
    }

    void Update()
    {
        // Player ile görev makinesi arasýndaki mesafeyi hesapla
        float distance = Vector3.Distance(player.position, transform.position);

        // Mesafe etkileþim mesafesinden küçükse butonu göster, deðilse gizle
        if (distance <= interactionDistance)
        {
            ShowAcceptButton();
        }
        else
        {
            HideAcceptButton();
        }
    }

    void ShowAcceptButton()
    {
        acceptButton.SetActive(true);
    }

    void HideAcceptButton()
    {
        acceptButton.SetActive(false);
    }

    // Kabul Et butonuna týklandýðýnda çaðrýlacak iþlev
    public void OnAcceptButtonClicked()
    {
        Debug.Log("Görev kabul edildi!");
        // Görevi kabul etme ile ilgili iþlemleri buraya ekleyin.
    }
}