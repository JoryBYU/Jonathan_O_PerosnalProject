using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryOutOfBounds : MonoBehaviour
{

    private float bottomScreen = -30;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //destorys existing blocks when past players position
        if (transform.position.z < bottomScreen)
        {
            Destroy(gameObject);
        }
    }
}
