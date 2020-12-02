using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Inventories;
using System;

namespace RPG.UI.Shops 
{
    public class ShopUI : MonoBehaviour
    {
        Shopper shopper = null;

        private void Start() {
            gameObject.SetActive(false);

            shopper = GameObject.FindGameObjectWithTag("Player").GetComponent<Shopper>();
            if (shopper == null) return;

            shopper.activeShopChanged += ShopChanged;
        }

        private void ShopChanged(Shop newShop)
        {
            gameObject.SetActive(newShop != null);
        }        
    }
}