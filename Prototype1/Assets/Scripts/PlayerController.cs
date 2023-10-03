using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour //Class PlayerController inherits from MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Controlling how much time is passing per second instead of per frame
       float time = Time.deltaTime * 20; //Moves 20 meters per second
       // transform.Translate(0, 0, 1);
       transform.Translate(Vector3.forward * time);
    }
}
