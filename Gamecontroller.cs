using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Gamecontroller : MonoBehaviour
{
    public GameObject pipePrefab;
    public GameObject gamecontroller;
    private float countdown;
    
    public float timeDuration;
    
    public bool enableGenratePipe;
    // Start is called before the first frame update

    private void Start()
    {
       
        timeDuration = 1.5f;
        countdown = 1f;
        enableGenratePipe = false;
    }
    
    // Update is called once per frame

    void Update()
    {
        
        if ( enableGenratePipe == true)
        {

            countdown -= Time.deltaTime;
            if (countdown <= 0)
            {
                Instantiate(pipePrefab, new Vector3(10, Random.Range(-1.2f, 2.6f), 0), Quaternion.identity);
                countdown = timeDuration;
            }
        }
    }
}
