using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hat : MonoBehaviour
{
    public GameManager gameManager;
    bool[] isGet;
    //deltatime

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
            int hatCount;
            hatCount = gameManager.TeachHatCount();

            gameManager.AddHatCount();
            //parent = this.gameObject.transform.parent.gameObject;

            //プレイヤータグと帽子を親子付け
            transform.parent = col.transform;

            Vector3 pos = new Vector3(0, hatCount + 1, 0);
            //プレイヤータグの物体の上に帽子を置く
            transform.position = col.transform.position + pos;

            col.gameObject.GetComponent<Player>().TakeHat(gameObject);

            //CancelInvoke("FlyHat");
            //Vector3　hatScale = gameObject.transform.localScale;
            //hatScale.y = 1;
            //gameObject.transform.localScale = hatScale;


        }
    }

    public void FlyHat()
    {
        Vector3 hatScale;
        hatScale = gameObject.transform.localScale;
        hatScale.y = 1;
        gameObject.transform.localScale = hatScale;

        int speed = 10;
        Vector3 pos = transform.position;
        pos.y += speed;
        GetComponent<Rigidbody2D>().velocity = new Vector3(0, speed, 0);
        Debug.Log("呼び出されました");
        CancelInvoke("PutHat");
    }

    public void PutHat()
    {
        Vector3 hatScale;
        hatScale = gameObject.transform.localScale;

        hatScale.y -= 0.9f;
        gameObject.transform.localScale = hatScale;

        //3.5秒後に関数を呼び出す
        Invoke("FlyHat", 2.0f);

    }
}
