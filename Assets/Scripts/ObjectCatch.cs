using UnityEngine;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    private Rigidbody2D rb;
    OmegaSounds sfx;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sfx = FindFirstObjectByType<OmegaSounds>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.IsChildOf(transform))
            return;

        if (collision.CompareTag("Doonut"))
        {
            sfx.PlaySFX(2);
            Destroy(collision.gameObject);
            transform.localScale += new Vector3(sizeIncrease, sizeIncrease, 0);
            rb.mass += massIncrease;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
