using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [Tooltip("Prefab do projétil")]
    [SerializeField] GameObject projectile;
    [Tooltip("Posição onde o tiro será instanciado")]
    [SerializeField] Transform projectileSpawn;
    [Tooltip("Tempo de espera entre dois tiros")]
    [SerializeField] float cooldown = 0.1f;

    private bool canShoot = true;

    /// <summary>
    /// Chama o método de atirar caso a nave possa atirar e o botão seja pressionado
    /// </summary>
    void Update()
    {
        if (canShoot && Input.GetKey(KeyCode.J))
            StartCoroutine(ShootProjectile());
    }

    /// <summary>
    /// Instancia um projétil na posição de spawn, e desabilita o tiro por um tempo
    /// </summary>
    /// <returns></returns>
    private IEnumerator ShootProjectile()
    {
        canShoot = false;
        Instantiate(projectile, projectileSpawn.position, Quaternion.identity);
        yield return new WaitForSeconds(cooldown);
        canShoot = true;
    }
}
