
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }

    private int pocetOdpadu = 0;  
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    public void SetDirection(int smer)
    {
        if (animator != null)
        {
            animator.SetInteger("Smer", smer);
        }
    }
    public void PridatOdpadek()
    {
        pocetOdpadu++;
    }

    public bool MaOdpadek()
    {
        return pocetOdpadu > 0;
    }

    public void OdstranitOdpadek()
    {
        if (pocetOdpadu > 0)
        {
            pocetOdpadu--;
        }
    }
}
