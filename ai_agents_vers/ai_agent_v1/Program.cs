using System;
namespace csharp2_5;

public enum EnemyState
{
    idle,
    chase,
    attack,
    flee
}

public class Enemy
{
    private EnemyState currentState = EnemyState.idle;
    private float health = 100;
    private float distance;

    public void updateAI()
    {
        switch (currentState)
        {
            case EnemyState.idle:
                if (distance < 10) currentState = EnemyState.chase; break;
            case EnemyState.chase:
                if (distance < 2) currentState = EnemyState.attack;
                else if (distance > 15) currentState = EnemyState.idle;
                break;
            case EnemyState.attack:
                if (health < 20) currentState = EnemyState.flee;
                else if (distance < 3) currentState = EnemyState.chase;
                break;
            case EnemyState.flee:
                if (health <= 0) Console.WriteLine("Enemy died");
                break;
        }

        Console.WriteLine($"current State: {currentState}");
    }
}

