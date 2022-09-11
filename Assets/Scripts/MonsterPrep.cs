using UnityEngine;

public class MonsterPrep : MonoBehaviour
{
    [SerializeField] private new string name = "Monster";
    [SerializeField] private int maxHealth = 10;

    private int currentHealth;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        Debug.Log(rb.velocity);
    }

    // private void OnCollisionEnter(Collision collision)
    // {
    //     // currentHealth--;
    //     ChangeHealth(-1);
    // }
    //
    // private void ChangeHealth(int change)
    // {
    //     int oldHealth = currentHealth;
    //     int newHealth = Mathf.Clamp(oldHealth + change, 0, maxHealth);
    //     PrintHealth(change, oldHealth, newHealth);
    //     currentHealth = newHealth;
    // }
    //
    // private void PrintHealth(int change, int oldHealth, int newHealth)
    // {
    //     Debug.Log($"{name} took damage: {change}");
    //     Debug.Log($"    {oldHealth} -> {newHealth}");
    // }
}
