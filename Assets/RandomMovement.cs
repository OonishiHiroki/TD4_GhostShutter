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
        //�����S�g
        transform.position += transform.forward * Time.deltaTime;

        //�w�莞�Ԃ̌o��
        if (timeCount > chargeTime)
        {
            //�i�H�������_���ɕύX����
            Vector3 course = new Vector3(0, Random.Range(0, 360), 0);
            transform.localRotation = Quaternion.Euler(course);

            //�^�C���J�E���g��0�ɖ߂�
            timeCount = 0;
        }
    }
}
