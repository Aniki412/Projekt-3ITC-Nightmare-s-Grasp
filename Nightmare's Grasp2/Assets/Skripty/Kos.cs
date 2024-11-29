using UnityEngine;

public class Kos : MonoBehaviour
{
    public Sprite[] kosSprites;
    private SpriteRenderer spriteRenderer;
    private int pocetOdpadu = 0; 

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ZmenSprite(); 
    }

    public void NaplnitKos()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            PlayerController playerController = player.GetComponent<PlayerController>();
            if (playerController != null && playerController.MaOdpadek())
            {
                Debug.Log("Kos naplnen");
                playerController.OdstranitOdpadek();
                pocetOdpadu++; 
                ZmenSprite();
            }
            else
            {
                Debug.Log("Nema odpadek");
            }
        }
    }

    private void ZmenSprite()
    {
            spriteRenderer.sprite = kosSprites[pocetOdpadu];
    }
}

