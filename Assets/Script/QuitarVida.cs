using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarVida : MonoBehaviour
{
    public VidaJugador vidaJugador;
    public bool PuedeDa�ar = true;
    private float Cooldown = 0.01f;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player") && PuedeDa�ar)
        {
            vidaJugador.RecibirDa�o(1);
            PuedeDa�ar = false;
            StartCoroutine(CooldownDa�o());
        }
    }

    IEnumerator CooldownDa�o()
    {
        yield return new WaitForSeconds(Cooldown);
        PuedeDa�ar = true;
    }
}
