using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D myRigidbody;
    public float flyStrength = 1;
    public ScoreLogic logic;
    bool isBirdAlive = true;
    void Start()
    {
        gameObject.name = "Chrish Bird";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreLogic>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isBirdAlive){
            myRigidbody.velocity = Vector2.up * flyStrength;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision2D) {
        logic.gameOver();
        isBirdAlive = false;
    }
}
