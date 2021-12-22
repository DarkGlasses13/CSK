using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    class WeaponVewer : MonoBehaviour
    {
        private List<WeaponVew> _vews = new List<WeaponVew>();

        public void Vew(Weapon weapon)
        {
            foreach (WeaponVew vew in _vews)
            {
                vew.gameObject.SetActive(false);

                if (vew.Weapon.ID == weapon.ID)
                {
                    vew.gameObject.SetActive(true);
                }
            }
        }

        public void Set(ItemDatabase database)
        {
            foreach (Weapon weapon in database.GetWeapons())
            {
                GameObject instantiatedVew = Instantiate(weapon.Vew, transform);
                instantiatedVew.SetActive(false);
                _vews.Add(instantiatedVew.GetComponent<WeaponVew>());
            }
        }
    }
}
