using UnityEngine;

public class Diamond : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter called with " + other.name); // OnTriggerEnter tetiklendiðinde konsolda görünecek

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player collided with diamond"); // Player tag'li nesne ile çarpýþma olduðunda konsolda görünecek

            GameManager.instance.AddDiamond(1); // GameManager'daki AddDiamond metodunu çaðýrýn ve sayacý arttýrýn
            Destroy(gameObject); // Elmasý yok edin
        }
    }
}
