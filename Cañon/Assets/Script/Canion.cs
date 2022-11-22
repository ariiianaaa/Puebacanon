using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canion : MonoBehaviour
{
    public GameObject bocaCanion;
    public GameObject bala;
    GameObject balaClon;
    public float fuerzaDisparo; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

        }
    }
    void disparo()
    {
        balaClon = Instantiate(bala, bocaCanion.GetComponent<Transform>().position, Quaternion.identity);
        balaClon.GetComponent<Rigidbody>().AddForce(new Vector3(0,0, fuerzaDisparo));
    }
}
