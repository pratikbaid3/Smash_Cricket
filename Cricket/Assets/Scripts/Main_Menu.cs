using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main_Menu : MonoBehaviour
{
    public GameObject gameController;
    private GameController gameOver;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = gameController.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver.gameOver==true)
        {
            gameObject.SetActive(true);
        }
    }

    public void PushButton()
    {
        gameOver.gameOver = false;
        gameObject.SetActive(false);
    }
}
