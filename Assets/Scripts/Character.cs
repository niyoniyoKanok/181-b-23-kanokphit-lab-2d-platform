using UnityEngine;

public abstract class Character : MonoBehaviour
{
    //attributes
    private int health;
    public int Health
    {
        get { return health; }
        set { health = (value < 0) ? 0 : value; }
    }
    private int maxHealth;


    protected Animator anim;
    protected Rigidbody2D rb;
    [SerializeField] HealthBar healthBar;

    //initialize variable

    public void Initialize(int startHealth)
    {
        Health = startHealth;
        maxHealth = startHealth;
        Debug.Log($"{this.name} is initialed Health : {Health}");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        healthBar = GetComponentInChildren<HealthBar>();
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
        Debug.Log($"{this.name} took damage {damage} current health {Health}");
        healthBar.UpdateHealthBar(Health, maxHealth);
        IsDead();
    }

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;
        }
        else { return false; }
    }

    // Start is  called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}