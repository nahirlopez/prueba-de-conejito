using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popiss : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
         
    }
    public GameObject caquita;
    public GameObject coneji;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(caquita);
            caquita.transform.position = coneji.transform.position;
        } 
       
    }
    
}
