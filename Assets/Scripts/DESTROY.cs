using TMPro;
using UnityEngine;

public class DESTROY : MonoBehaviour
{
    OmegaSounds sfx;
    public TMP_Text counterText;
    private int count=0;

    void Start()
    {
        sfx = FindFirstObjectByType<OmegaSounds>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Doonut"))
        {
            Destroy(collision.gameObject);
            count++;
            sfx.PlaySFX(0);
            counterText.text="Virtuli izlaisti:\n"+count;
        }
    }
}
