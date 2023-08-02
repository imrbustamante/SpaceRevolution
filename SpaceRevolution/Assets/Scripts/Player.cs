using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //variavel para o rigidBody
    private Rigidbody2D rig;
    //vetor da posicao Inicial do Player
    private Vector3 posInicial;
    //variavel da velocidade
    private float speed;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        posInicial = new Vector3(0, 0, 0);
        transform.position = posInicial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
