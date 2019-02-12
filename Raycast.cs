using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{
    private Vector3 myRay;
    public float range = 100f;
    public float dano = 10f;
    public int contador = 0;
   
    public Camera fpsCam;
    //public Text score;

    
    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
   
}
    void Shoot()
    {
        RaycastHit hit;
       if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Debug.DrawRay(transform.position, myRay , Color.green);
            Target target = hit.transform.GetComponent<Target>();
            if(target != null)
            {
                target.TakeDamage(dano);
                
            }
        }
    }
   /*private void OnCollisionEnter(Collision other)
    {
        Destroy(other.gameObject);
    }*/
}
