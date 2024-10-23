using UnityEngine;
using TMPro;

public class GameManager2D : MonoBehaviour
{
    public GameObject bolaPrefab;
    public TextMeshProUGUI scoreText;
    public float velocidadeBolas = 2f;

    private int acertos = 0;
    private int erros = 0;

    private float spawnRate = 1f; 
    private float minX = -7f, maxX = 7f;
    private float topY = 6f;

    private void Start()
    {
        InvokeRepeating("SpawnBola", 1f, spawnRate);
        AtualizarPlacar();
    }

    private void SpawnBola()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(minX, maxX), topY, 0f);
        GameObject bola = Instantiate(bolaPrefab, spawnPosition, Quaternion.identity);
        bola.GetComponent<BolaScript2D>().velocidade = velocidadeBolas;
    }

    public void Acertos()
    {
        acertos++;
        AtualizarPlacar();
    }

    public void Erros()
    {
        erros++;
        AtualizarPlacar();
    }

    private void AtualizarPlacar()
    {
        scoreText.text = "Acertos: " + acertos + " | Erros: " + erros;
    }
}