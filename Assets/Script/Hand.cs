using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject[] hat;
    public GameObject player;
    public Vector3 hatPos;


    public Vector3 TeachHatPos()
    {
        return hatPos;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //”ÍˆÍ‚Æ–XŽqƒ^ƒO‚ª‚ ‚½‚Á‚½‚ç
        if (col.gameObject.tag == "Hat")
        {
            hatPos = col.transform.position;
            Debug.Log("Hit Hat:" + hatPos);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
