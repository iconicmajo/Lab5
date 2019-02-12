using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public new Rigidbody rigidbody;
    public Renderer rend;
    public Color Scolor;
    public Color Mcolor;
    bool mouseOn = false;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }
    public void OnMouseEnter()
    {
        //mouseOn = true;
        //color = rend.material.color;
        //rend.material.color = Material.SetColor("amarillo" Mcolor);
        GetComponent<Renderer>().material.SetColor("_Color", Mcolor);
    }
    public void OnMouseExit()
    {
        mouseOn = false;
        GetComponent<Renderer>().material.SetColor("_Color", Scolor);
    }
    // Update is called once per frame
    void OnMouseDown()
    {
        rigidbody.AddForce(transform.forward * 500f);
        rigidbody.useGravity = true;
    }
    private void OnMouseDrag()
    {
        rend.material.color -= Color.white * Time.deltaTime;
        
    }
}
