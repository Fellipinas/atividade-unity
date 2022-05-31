using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esquerda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 m;

        if(Input.GetKey(KeyCode.A))
        {
            m.x=  -0.02F;
            m.y=  0.0F;  
            m.z=  0.0F;
            transform.Translate(m);
         
        }
        


        if(Input.GetKey(KeyCode.D))
        {
            m.x=  0.02F;
            m.y=  0.0F;  
            m.z=  0.0F;
            transform.Translate(m);
            
        }
        


        
   

        if(Input.GetKey(KeyCode.W))
        {
            m.x=  0.0F;
            m.y=  0.02F;  
            m.z=  0.0F;
            transform.Translate(m);
           
        }

    }
}
