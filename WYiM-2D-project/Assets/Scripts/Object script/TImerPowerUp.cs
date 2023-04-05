using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerPowerUp : MonoBehaviour
{

    public GameObject timerPU;
    public TimerScript timer;

    // Start is called before the first frame update
    void Start()
    {
        timerPU.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D hit){
        if(hit.CompareTag("Player")){
            hit.GetComponent<TimerScript>().moreTime();
            Destroy(gameObject);
        }
    }

}
