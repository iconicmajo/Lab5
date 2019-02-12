using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public int contador = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
        //if (collision.gameObject.tag == "Obstaculo"){
        //if (gameObject == false)
         //   Instantiate(gameObject, Vector3.zero, Quaternion.identity);

    }
}
