using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform weaponHold;
    public Gun defaultGun;
    private Gun equippedGun;

    void Start()
    {
        if (this.defaultGun != null)
        {
            EquipGun(this.defaultGun);
        }
    }

    public void EquipGun(Gun gunToEquip)
    {
        if (equippedGun != null)
        {
            Destroy(equippedGun.gameObject);
        }
        
        this.equippedGun = Instantiate(gunToEquip, weaponHold.position, weaponHold.rotation) as Gun;
        this.equippedGun.transform.parent = weaponHold;
    }

    public void Shoot()
    {
        if (equippedGun != null)
        {
            equippedGun.Shoot();
        }
    }
}
