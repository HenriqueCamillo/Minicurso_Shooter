using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [Tooltip("Prefab do projétil")]
    [SerializeField] GameObject projectile;
    [Tooltip("Posição onde o tiro será instanciado")]
    [SerializeField] Transform projectileSpawn;
    [Tooltip("Tempo de espera entre dois tiros")]
    [SerializeField] float shootRate;

    /// <summary>
    /// Chama o método de atirar a cada shootRate segundos
    /// </summary>
    private void Start()
    {
        InvokeRepeating("Shoot", 0f, shootRate);
    }

    /// <summary>
    /// Instancia um projétil virado para baixo
    /// </summary>
    private void Shoot()
    {
        Instantiate(projectile, projectileSpawn.position, Quaternion.Euler(0f, 0f, 180));
    }

}
