using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public GameManager gameManager;
    public GameObject[] hat;
    public Hand hand;


    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        hand = GameObject.Find("PlayerHand").GetComponent<Hand>();

        //帽子の最大値が5個
        hat = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;

        if (Input.GetKey("left") || (Input.GetKey(KeyCode.A)))
        {
            position.x -= speed;
        }
        else if (Input.GetKey("right") || (Input.GetKey(KeyCode.D)))
        {
            position.x += speed;
        }
        transform.position = position;

        //帽子を置く
        if (Input.GetKeyDown(KeyCode.Space) || (Input.GetKeyDown(KeyCode.E)))//一回押したら(GetKeyDown)
        {
            int hatCount;
            hatCount = gameManager.TeachHatCount();
            Debug.Log("HatNum:" + hatCount);

            //ひとづつ帽子を消費する
            gameManager.SubtractHatCount();

            //プレイヤーの前に置く
            Vector3 pos = new Vector3(2, 0, 0);
            if(hatCount <= 0 || hatCount >= 6)
            {
                Debug.LogError("hatOcunt:" + hatCount);
            }
            hat[hatCount - 1].transform.position = transform.position + pos;

            hat[hatCount - 1].transform.position = hand.TeachHatPos();

            hat[hatCount - 1].transform.parent = null;

            //hat[0] = hat[1];//1が0にコピー
            //hat[1] = hat[2];
            //hat[2] = hat[3];
            //hat[3] = hat[4];
            //hat[4] = null;

            //for(int i = 0;i>5; ++i)
            //{
            //    hat[i] = hat[i + 1];

            //}

        }
    }

    public void TakeHat(GameObject hat)//帽子を渡す
    {

        if (this.hat[0] == null)
        {
            this.hat[0] = hat;
        }
        else if (this.hat[1] == null)
        {
            this.hat[1] = hat;
        }
        else if (this.hat[2] == null)
        {
            this.hat[2] = hat;
        }
        else if (this.hat[3] == null)
        {
            this.hat[3] = hat;
        }
        else if (this.hat[4] == null)
        {
            this.hat[4] = hat;
        }

        //for (int i = 0; i > 5; i++)
        //{
        //    if (this.hat[i] == null)
        //    {
        //        this.hat[i] = hat;
        //    }
        //}

    }

}
