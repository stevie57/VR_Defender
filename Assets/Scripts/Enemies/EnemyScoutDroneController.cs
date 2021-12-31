using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScoutDroneController : EnemyController
{
    [SerializeField]
    private EnemyFlyingMovementController _flyingMovementController;

    private void Awake()
    {
        _flyingMovementController.SetUpMovementController(_enemyStats);
    }

    public override void AttackTarget(Vector3 targetPos, List<EnemyController> enemiesInWave)
    {
        base.AttackTarget(targetPos, enemiesInWave);
        MoveTowardsTarget(targetPos);
        Seperate(_enemiesInWave);
    }

    public override void MoveTowardsTarget(Vector3 targetPos)
    {
        _flyingMovementController.FlyTowardsTarget(targetPos);
    }

    public override void Seperate(List<EnemyController> flockList)
    {
        _flyingMovementController.Seperate(flockList);
    }
}
