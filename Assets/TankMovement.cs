using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10f;        // 坦克前进的速度
    public float turnSpeed = 50f;    // 坦克转向的速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        
        // 获取左右转向输入 (A/D键对应Horizontal轴)
        float turn = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        // 控制坦克的前进和后退 (沿着Z轴移动)
        transform.Translate(Vector3.forward * move);

        // 控制坦克的转向 (沿着Y轴旋转)
        transform.Rotate(Vector3.up * turn);
    }
}
