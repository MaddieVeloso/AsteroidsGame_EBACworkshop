using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidBody;
    public float velocidadeMaxima = 1.0f;
    public GameObject prefabExplosao2;

    public GameObject prefabAsteroideP;

     void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidBody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Vector3 posicao = new Vector3(0f, 0f, 0f);
        Instantiate(prefabExplosao2, posicao, Quaternion.identity);
        Vector3 posicao2 = transform.position;
        Instantiate(prefabAsteroideP, posicao2, Quaternion.identity);
        Instantiate(prefabAsteroideP, posicao2, Quaternion.identity);
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}