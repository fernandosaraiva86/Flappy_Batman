using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Score scoreScript;

    private void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameController")
            .GetComponent<Score>();
    }
    private void Update()
    {
        if (PlayerController.Instance.gameStarted)
        {
            speed = 5f + scoreScript.GanhaLevel();
            
            transform.position += Vector3.left * speed * Time.deltaTime;

            if (transform.position.x < -10f)
            {
                Destroy(gameObject);
            }
        }
        
    }


}
