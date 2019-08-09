using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Bar : MonoBehaviour
{
    public GameObject GameController;
    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            if (gameObject.name == "1Run")
            {
                //Debug.Log("1");
                gc.score += 1;
            }
            else if (gameObject.name == "2Run")
            {
                //Debug.Log("2");
                gc.score += 2;
            }
            else if(gameObject.name=="4Run")
            {
                //Debug.Log("4");
                gc.score += 4;
            }
            else if(gameObject.name=="6Run")
            {
                //Debug.Log("6");
                gc.score += 6;
            }
            else if(gameObject.name=="Out")
            {
                //Debug.Log("OUT");
                gc.score = 0;
                gc.gameOver = true;
            }
        }
    }
}
