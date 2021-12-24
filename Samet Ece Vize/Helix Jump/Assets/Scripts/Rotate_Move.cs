using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{   
    public float rotateSpeed;
    private float moveX; 
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");  // mouse ile karakteri haraket ettirmek
        if(Input.GetMouseButton(0)) { // 0 olması basılı olduğu sürece haraket etmesini istiyoruz
            transform.Rotate(0f, moveX *  rotateSpeed * Time.deltaTime, 0f); // x ve z ile işimiz yok değerleri0. y ekseninde hareket etmesini istiyoruz
        }
    }
}
