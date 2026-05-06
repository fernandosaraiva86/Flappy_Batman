using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject obstaclePrefab; //Obstaculos que serão spawnados
    public float spawnInterval = 2f; //Intervalo entra cada spawn
    public Vector3 spawnPosition = new Vector3(14f, -2f, 0f); //Posição onde será spawnado
    private float timer; //Controlador do intervalo

    //Dificuldade do game
    public float MaximoY = -0.1f;// Valor máximo do eixo Y para o spawn
    public float MinimoY = -3f;// Valor mínimo do eixo Y para o spawn

    
    private void Update()
    {
        if (PlayerController.Instance.gameStarted)
        {
            timer -= Time.deltaTime; //Contador do intervalo

            if (timer <= 0f)
            {
                {
                    SpawnObstacle(); //Método
                    timer = spawnInterval; //Reseta o contador
                }
            }

        }

    }

    void SpawnObstacle()
    {
        spawnPosition.y = Random.Range(MinimoY, MaximoY); //Spawnando aleatório no eixo Y
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity); //Instancia o obstáculo
    }

}
