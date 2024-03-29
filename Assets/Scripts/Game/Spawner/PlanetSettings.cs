using System.Collections.Generic;
using UnityEngine;

namespace Game.Spawner
{
    
    [System.Serializable]
    public class SpawnerObject
    {
        public string name;
        public List<GameObject> spawnPrefabs;
        public int spawnCountMix;
        public int spawnCountMax;
        public int GetSpawnCount => Random.Range(spawnCountMix, spawnCountMax);
    }

    [CreateAssetMenu(fileName = "PlanetSettings", menuName = "Planet/New Planet Settings", order = 1)]
    public class PlanetSettings : ScriptableObject
    {
        public string planetName;
        public int size;
        public int totalStarCount;
        public float meteorStartDelay, meteorBetweenDelay, meteorCount;
        public List<Color> planetColors = new List<Color>(new Color[2]);
        public List<SpawnerObject> spawnerObjects;
    }
}
