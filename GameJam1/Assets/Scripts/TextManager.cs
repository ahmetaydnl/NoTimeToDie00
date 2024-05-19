using UnityEngine;
using UnityEngine.UI;

public class TaskManager : MonoBehaviour
{
    public GameObject acceptButton; // Kabul Et butonunun referans�
    public float interactionDistance = 3f; // Etkile�im mesafesi
    private Transform player;

    void Start()
    {
        // Player'� tag ile bul
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Butonu ba�lang��ta gizli yap
        acceptButton.SetActive(false);
    }

    void Update()
    {
        // Player ile g�rev makinesi aras�ndaki mesafeyi hesapla
        float distance = Vector3.Distance(player.position, transform.position);

        // Mesafe etkile�im mesafesinden k���kse butonu g�ster, de�ilse gizle
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

    // Kabul Et butonuna t�kland���nda �a�r�lacak i�lev
    public void OnAcceptButtonClicked()
    {
        Debug.Log("G�rev kabul edildi!");
        // G�revi kabul etme ile ilgili i�lemleri buraya ekleyin.
    }
}