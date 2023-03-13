using System;
using UnityEngine;

namespace Game.Spawner
{
    public class StarPositionFix : MonoBehaviour
    {
        public bool isStar;
        
        private void OnCollisionEnter(Collision collision)
        {
            if (!collision.gameObject.CompareTag("Obstacle")) return;
            
            gameObject.SetActive(false);
            if (isStar)
                Spawner.AppleSpawn?.Invoke(gameObject);
            else
                Spawner.PropsSpawn?.Invoke(gameObject);
        }
    }
}
