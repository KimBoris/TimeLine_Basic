using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playerableDirecter;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            playerableDirecter.gameObject.SetActive(true);
            playerableDirecter.Play();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            playerableDirecter.gameObject.SetActive(false);
        }
    }
}
