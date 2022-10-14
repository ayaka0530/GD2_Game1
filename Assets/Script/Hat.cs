using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hat : MonoBehaviour
{
    public GameManager gameManager;
    bool[] isGet;
    //private GameObject parent;//親

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    { //2Dの衝突判定
        //プレイヤーにあたったら帽子が頭に乗る
        if (col.gameObject.tag == "Player")
        {
            gameManager.AddHatCount();
            //parent = this.gameObject.transform.parent.gameObject;
            transform.parent = col.transform;

            Vector3 pos = new Vector3(0, 1, 0);
            transform.position = col.transform.position + pos;

            col.gameObject.GetComponent<Player>().TakeHat(gameObject);


        }
    }

}
