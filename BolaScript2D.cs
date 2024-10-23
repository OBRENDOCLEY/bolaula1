using UnityEngine;

public class BolaScript2D : MonoBehaviour
{
    public float velocidade = 2f; 
    private float lifeTime = 5f;
    private GameManager2D gameManager;
    private bool foiClicada = false;
    private Rigidbody2D rb2d;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager2D>();

        rb2d.velocity = new Vector2(0, -velocidade);
        Invoke("VerificarErro", lifeTime);
    }


    private void OnMouseDown()
    {
   
        foiClicada = true;

        gameManager.Acertos();

        Destroy(gameObject);
    }

    private void VerificarErro()
    {
        if (!foiClicada) 
        {
            gameManager.Erros();
        }
        Destroy(gameObject);
    }
}