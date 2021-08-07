using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swarm : MonoBehaviour
{
    public GameObject boidPrefab;

    [Range(0, 300)]
    public int number;

    private void Start()
    {
        for (int i = 0; i < number; i++)
        {
            Instantiate(boidPrefab, Vector3.zero, Quaternion.identity);
        }
    }

}
