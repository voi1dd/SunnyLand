using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P : MonoBehaviour
{
    string name = "tenes";
    public int life = 100;
    float speed = 3.5f;
    bool isdead = false;

    private Rigidbody2D rb; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"Personagem: {name} \n Vida: {life} \n Velocidade: {speed} \n Morto: {isdead}");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
