using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefabs;
    [SerializeField] int spawn_Count;
    [SerializeField] int spawn_radius;

    private void Awake()
    {
        for (int i = 0; i < spawn_Count; i++)
        {
            Vector3 pos_randOnSpherePos = Random.onUnitSphere * spawn_radius;
            Vector3 rot_randOnSpherePos = Random.onUnitSphere * 100f;
            GameObject obj = Instantiate(prefabs, pos_randOnSpherePos, Quaternion.Euler(rot_randOnSpherePos));
        }
    }
}
