using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("attack_item"))
        {
            Debug.Log("Temas Sa�land�");
            Destroy(gameObject);
        }
        Debug.Log(other);
    }

}
