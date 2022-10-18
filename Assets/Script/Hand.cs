using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject[] hat;
    public GameObject player;
    public GameObject grabHat;


    public Vector3 TeachHatPos()
    {
        if (grabHat == null)
        {
            return transform.position;
        }
        else
        {
            Vector3 pos = new Vector3(0, 1, 0);
            return grabHat.transform.position + pos;
        }
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
            grabHat = col.gameObject;

            Debug.Log("Hit Hat:" + hat);
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Hat")
        {
            grabHat = null;
            Debug.Log("Leave Hat:" + hat);
        }
    }
}
