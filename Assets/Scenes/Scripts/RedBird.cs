using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedBird : Bird
{
    protected override void Fly()
    {
        birdPrefab.transform.Translate(Vector3.left * Time.deltaTime * 2);
        if (birdPrefab.transform.position.x < -14)
        {
            Destroy(birdPrefab);
        }
    }

    void Update()
    {
        Fly();
    }

}
