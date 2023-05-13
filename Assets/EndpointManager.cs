using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndpointManager : MonoBehaviour
{
    [SerializeField] GameObject winScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Called when the player collides with this object
    void OnTriggerEnter2D(Collider2D other)
    {
        winScreen.SetActive(true);
    }
}