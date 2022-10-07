using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public GameObject hat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space") || (Input.GetKey(KeyCode.E)))
        {
            Vector3 tmp = GameObject.Find("player").transform.position;
            Instantiate(hat, new Vector3(tmp.x, tmp.y, tmp.z), Quaternion.identity);
        }
    }
}
