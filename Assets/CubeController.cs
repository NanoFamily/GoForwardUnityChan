using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    AudioSource audioSource;

    // 地面の位置
    private float groundLevel = -3.0f;

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadline = -10;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }


    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "BlockTouch")
        {
            audioSource = this.GetComponent<AudioSource>();
            this.GetComponent<AudioSource>().PlayOneShot(audioSource.clip);
        }

        if (tag == "UnityChanTouch")
        {
            audioSource = this.GetComponent<AudioSource>();
            audioSource.Stop();
        }

        if (tag == "GroundTouch")
        {
            audioSource = this.GetComponent<AudioSource>();
            audioSource.Play();

        }
    }
}


  

