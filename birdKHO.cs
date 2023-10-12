using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdKHO : MonoBehaviour
{
    private Rigidbody2D rigidbodyKHO;
    public float jumpforceKHO;
    private bool levelstart;
    // Start is called before the first frame update
    private void Awake()
    {
        rigidbodyKHO = this.gameObject.GetComponent<Rigidbody2D>();
        levelstart = false;
        rigidbodyKHO.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            if(levelstart == false)
            {
                levelstart = true;
                rigidbodyKHO.gravityScale = 8;
            }
            BirdKHOMoveUP();
        }
    }

    private void BirdKHOMoveUP()
    {
        rigidbodyKHO.velocity = Vector2.up * jumpforceKHO;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }
}
