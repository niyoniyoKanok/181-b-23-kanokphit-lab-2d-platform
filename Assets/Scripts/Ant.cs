using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 velocity;
    public Transform[] MovePoint;
    public override void Behavior()
    {
      
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
