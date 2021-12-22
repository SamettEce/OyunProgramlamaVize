using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    public Transform target; // topumuzun transformu
    private Vector3 offset;  
    public float smoothSpeed;
    void Start()
    {
        offset = transform.position - target.position; // kameranın pozisyonundan topun pozisyonunu çıkartalım
    }
    void Update()
    {
        // lerp methodu iki nokta arasını istediğimiz gibi doldurma biz doldurma olarak değil geçiş efekti olarak kullanacağız
        Vector3 newPos = Vector3.Lerp(transform.position, offset + target.position, smoothSpeed);
        transform.position = newPos;   

    }
}
