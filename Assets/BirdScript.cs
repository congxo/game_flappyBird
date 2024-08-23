using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flyStrength = 1;
    void Start()
    {
        gameObject.name = "Chrish Bird";
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("press space");
            myRigidbody.velocity = Vector2.up * flyStrength;
        }
    }
}
