using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCube : MonoBehaviour
{

    float speedOfBox = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * this.speedOfBox;
    }
}
