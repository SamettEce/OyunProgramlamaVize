using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rb; // top sürekli aşağı düşerken yukarı doğru zıplaması için rigid body kullanıyoruz
    [SerializeField] private GameObject splashImg;
    [SerializeField] private float jumpForce;
    private GameManager gm;
    private Ring ring;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    private void OnCollisionEnter(Collision other) { // bir objeye çarptığı zaman 
        rb.AddForce(Vector3.up * jumpForce); // yukarı doğru zıpla
        GameObject splash =  Instantiate(splashImg, transform.position - new Vector3(0, 0.22f, 0f), transform.rotation);// topun konumunu ayarlıyoruz
        splash.transform.SetParent(other.gameObject.transform); //splash konumu carptığımız objenin formuna
        Destroy(splash, 1);


        //çaprtığı objenin metaryel adını alır
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log("Metaryel Adı: " + metarialName);
        if(metarialName == "Unsafe Color (Instance)") {
            gm.restartGame();
        }
       
    }
}
