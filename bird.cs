using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class bird : MonoBehaviour
{
    
    private Rigidbody2D rigidbody;
    public float jumpForce;
    private bool levelstart;
    public GameObject gameController;
    // Start is called before the first frame update
    private void Awake()
    {
        rigidbody = this.gameObject.GetComponent<Rigidbody2D>();
        levelstart = false;
        rigidbody.gravityScale = 0;

    }

    

    // Update is called once per frame
    void Update()
    {
        // check
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (levelstart == false)
            {
                levelstart = true;
                rigidbody.gravityScale = 8;
                gameController.GetComponent<Gamecontroller>().enableGenratePipe = true;
            }
            BirdMoveup();
        }
    }

    private void BirdMoveup()
    {
        rigidbody.velocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ReloadScene();
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
