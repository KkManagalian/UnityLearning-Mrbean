using TMPro;
using UnityEditor;
using UnityEngine;

public class ObjectCatch : MonoBehaviour
{
    public float sizeIncrease = 0.5f;
    public float massIncrease = 1f;
    private Rigidbody2D rb;
    OmegaSounds sfx;
    public TMP_Text counterText;
    public TMP_Text HealthText;
    private int count = 0;
    private int health = 3;


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
            transform.localScale += new Vector3(sizeIncrease,0 , 0);
            rb.mass += massIncrease;
            count++;
            counterText.text = "Virtuli apesti:\n" + count;
        }else if(collision.CompareTag("METEOR")){
            if (health==0)
            {
            #if UNITY_EDITOR
                // Stops Play Mode in the Unity Editor
                EditorApplication.isPlaying = false;
                 #else
                // Quits the built application
             Application.Quit();
            #endif
            }
            sfx.PlaySFX(4);
            health--;
            transform.localScale += new Vector3(0, sizeIncrease, 0);
            Destroy(collision.gameObject);

        }else if(collision.CompareTag("Special")){
            sfx.PlaySFX(2);
            health++;
            Destroy(collision.gameObject);
        }
    }
}
