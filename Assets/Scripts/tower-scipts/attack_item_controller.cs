using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_item_controller : MonoBehaviour
{
    
    // Start is called before the first frame update
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime*4); // hasar olu�turucuyu hareket ettir
               
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            Debug.Log("Temas Sa�land�");
        }
    }
}
