using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    private float chargeTime = 4.0f;
    private float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        //自動全身
        transform.position += transform.forward * Time.deltaTime;

        //指定時間の経過
        if (timeCount > chargeTime)
        {
            //進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);

            //タイムカウントを0に戻す
            timeCount = 0;
        }
    }
}
