using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public float speed = 5.0f;
    public GameManager gameManager;
    public GameObject[] hat;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        this.gameObject.transform.DetachChildren();//�e�I�u�W�F�N�g������q�I�u�W�F�N�g��������

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

        if (Input.GetKey(KeyCode.Space) || (Input.GetKey(KeyCode.E)))
        {
                //�ЂƂÂX�q�������
                gameManager.SubtractHatCount();

                Vector3 pos = new Vector3(1, 0, 0);
                hat[0].transform.position = transform.position + pos;

                hat[0].transform.parent = null;
        }
    }

    public void TakeHat(GameObject hat)//�X�q��n��
    {
        this.hat[0] = hat;
    }
}
