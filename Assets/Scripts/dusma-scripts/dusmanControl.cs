using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanControl : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime); //d��manlar� sola hareket ettir

     
    }
    
}
