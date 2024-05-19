using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with " + other.name); // OnTriggerEnter tetiklendi�inde konsolda g�r�necek

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with diamond"); // Player tag'li nesne ile �arp��ma oldu�unda konsolda g�r�necek

            GameManager.instance.AddDiamond(1); // GameManager'daki AddDiamond metodunu �a��r�n ve sayac� artt�r�n
            Destroy(gameObject); // Elmas� yok edin
        }
    }
}
