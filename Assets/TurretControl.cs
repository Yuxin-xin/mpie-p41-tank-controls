using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float turnSpeed = 75.0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = 0.0f;

        // 检测Q和E键
        if (Input.GetKey(KeyCode.Q))
        {
            rotation = -turnSpeed * Time.deltaTime; // 向左旋转
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotation = turnSpeed * Time.deltaTime; // 向右旋转
        }

        // 旋转炮塔
        Transform t = gameObject.transform;
        t.Rotate(0.0f, rotation, 0.0f);
    }
}
