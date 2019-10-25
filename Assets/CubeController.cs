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

        //キューブか判定
        if (tag == "BlockTouch")
        {
            AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
            gameObject.GetComponent<AudioSource>().PlayOneShot(clip);
        }

        if (tag == "UnityChanTouch")
        {
            audioSource = this.GetComponent<AudioSource>();
            audioSource.Stop();
        }

        if (tag == "GroundTouch")
        {
            AudioClip clip = gameObject.GetComponent<AudioSource>().clip;
            gameObject.GetComponent<AudioSource>().PlayOneShot(clip);

        }

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }
}


  

