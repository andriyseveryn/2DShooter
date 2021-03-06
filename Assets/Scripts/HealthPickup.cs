using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    Player playerScript;
    public int healAmount;

    public GameObject effect;
    private void Start()
    {
        playerScript = FindObjectOfType<Player>().GetComponent<Player>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            Instantiate(effect, transform.position, transform.rotation);
            playerScript.Heal(healAmount);
            Destroy(gameObject);
        }
    }
}
