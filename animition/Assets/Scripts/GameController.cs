using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public GameObject bgGround;
    public GameObject anotherBgGround;
    public GameObject column;
    public GameObject gameOverText;
    private float bgLen;
    public bool gameOver = false;

    public float speed = -1.5f;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            
            InitBgGround();
        }
		else if(instance != this)
		{
			Destroy(gameObject);
		}
    }

    private void InitBgGround()
    {
        anotherBgGround = GameObject.Instantiate(bgGround).gameObject;
        bgLen = bgGround.GetComponent<BoxCollider2D>().size.x;
        Vector3 origin = bgGround.GetComponent<Transform>().position;
        Vector3 offset = new Vector3(bgLen + origin.x, 0, 0);
        anotherBgGround.GetComponent<Transform>().position = offset + origin;
    }

    // Use this for initialization
    void Start()
    {
        column.GetComponent<Rigidbody2D>().velocity = new Vector2(-1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
		if(gameOver == true && Input.GetMouseButtonDown(0))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
    }

    public void BirdDied()
    {
        gameOver = true;
        gameOverText.SetActive(true);
    }
}
