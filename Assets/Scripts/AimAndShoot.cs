using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAndShoot : MonoBehaviour
{
    [SerializeField] private Transform aimTransform;

    [SerializeField] private GameObject impactEffect;
    [SerializeField] private GameObject muzzleFlashEffect;
    [SerializeField] private Transform firePoint;

    private void Update()
    {
        HandleAiming();

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void HandleAiming()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 aimDirection = (mousePosition - transform.position).normalized;

        float angle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg;
        aimTransform.eulerAngles = new Vector3(0, 0, angle);
    }

    private void Shoot()
    {
        GameObject muzzleFlash = Instantiate(muzzleFlashEffect, firePoint.transform.position, Quaternion.identity);

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector3 aimDirection = (mousePosition - transform.position).normalized;

        RaycastHit2D hit = Physics2D.Raycast(firePoint.position, aimDirection);
        
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            GameObject impactGameObject = Instantiate(impactEffect, hit.point, Quaternion.identity);
            Destroy(impactGameObject, 0.3f);
        }

        Destroy(muzzleFlash, 0.1f);
    }
}
