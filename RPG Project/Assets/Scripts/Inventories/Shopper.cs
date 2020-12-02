using System;
using UnityEngine;

namespace RPG.Inventories
{
    public class Shopper : MonoBehaviour {
        
        public event Action<Shop> activeShopChanged;

        public void SetActiveShop(Shop shop)
        {
            activeShopChanged(shop);
        }
    }
}