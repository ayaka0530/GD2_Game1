using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hat : MonoBehaviour
{
    public GameManager gameManager;
    bool[] isGet;
    //private GameObject parent;//�e

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
    { //2D�̏Փ˔���
        //�v���C���[�ɂ���������X�q�����ɏ��
        if (col.gameObject.tag == "Player")
        {
            int hatCount;
            hatCount = gameManager.TeachHatCount();

            gameManager.AddHatCount();
            //parent = this.gameObject.transform.parent.gameObject;

            //�v���C���[�^�O�ƖX�q��e�q�t��
            transform.parent = col.transform;

            Vector3 pos = new Vector3(0, hatCount + 1, 0);
            //�v���C���[�^�O�̕��̂̏�ɖX�q��u��
            transform.position = col.transform.position + pos;

            col.gameObject.GetComponent<Player>().TakeHat(gameObject);


        }
    }

}
