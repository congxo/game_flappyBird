using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float PipeSpeed = 1;
    public ScoreLogic logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<ScoreLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (logic.isGameOn)
        {

            transform.position = transform.position + Vector3.left * PipeSpeed * Time.deltaTime;
        }
        if (transform.position.x <= -10)
        {
            Destroy(gameObject);
        }
    }
}
