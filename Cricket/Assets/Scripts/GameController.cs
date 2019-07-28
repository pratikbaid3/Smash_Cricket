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
    // Start is called before the first frame update

    IEnumerator spawnBall()
    {
        Instantiate(ball, new Vector3(9.6f, 0.56f, 0), Quaternion.identity);
        yield return new WaitForSeconds(3f);
        _Spawned = false;
    }

    void Start()
    {
        scoreBoard.text = "SCORE";
    }
    // Update is called once per frame
    void Update()
    {
        if(_Spawned==false)
        {
            _Spawned = true;
            StartCoroutine("spawnBall");
        }
        _score = score.ToString();
        scoreBoard.text = _score;
    }
}
