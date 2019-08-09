using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ball;
    private bool _Spawned =false;
    public int score = 0;
    [SerializeField]
    private string _score;
    public Text scoreBoard;

    public bool gameOver = true;

    public GameObject mainMenu;
    // Start is called before the first frame update

    IEnumerator spawnBall()
    {
        float yPos = Random.Range(0, 2.65f);
        Instantiate(ball, new Vector3(9.6f, yPos, 0), Quaternion.identity);
        float waitTime = Random.Range(.8f, 2.5f);
        yield return new WaitForSeconds(waitTime);
        _Spawned = false;
    }

    void Start()
    {
        scoreBoard.text = "SCORE";
    }
    // Update is called once per frame
    void Update()
    {
        if(gameOver==false)
        {
            if (_Spawned==false)
            {
                _Spawned = true;
                StartCoroutine("spawnBall");
            }
        }
        
        _score = score.ToString();
        scoreBoard.text = _score;
        if(gameOver==true)
        {
            mainMenu.SetActive(true);
        }
    }
}
