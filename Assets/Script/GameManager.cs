using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public HUD HUD;
    public int vidas = 3;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.LogError("Hay m�s de un GameManager en la escena. Esto no est� permitido.");
            Destroy(gameObject);
        }
    }

    public void PerderVida()
    {
        if (vidas > 0)
        {
            vidas -= 1;

            if (HUD != null)
            {
                HUD.PerderVida(vidas); 
            }
            else
            {
                Debug.LogError("HUD no est� asignado en el GameManager.");
            }

            if (vidas <= 0)
            {
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over");
        
    }
}
