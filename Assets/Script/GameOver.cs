using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public static GameOver Instance { get; private set; }
    public bool IsGameOver = false;
    public TextMeshProUGUI textoGameOver;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void MetodoGameOver(string texto)
    {
        IsGameOver = true;
        textoGameOver.gameObject.SetActive(true);
        textoGameOver.text = texto;
    }
}
