using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamecontrollerKHO : MonoBehaviour
{
    public GameObject pipePrefab;
    private float countdown;
    public float timeDuration;

    private void Awake()
    {
        countdown = timeDuration;
    }
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0)
        {
            Instantiate(pipePrefab, new Vector3(11, Random.Range(-2f, 0.8f), 0), Quaternion.identity);
            countdown = timeDuration;
        }
    }
}
