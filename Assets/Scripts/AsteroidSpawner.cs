using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject asteroidPrefab;

    float colliderRadius;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 midRight = new Vector3(ScreenUtils.ScreenRight + colliderRadius, (ScreenUtils.ScreenTop + ScreenUtils.ScreenBottom) / 2, 0f);
        Vector3 midLeft = new Vector3(ScreenUtils.ScreenLeft - colliderRadius, (ScreenUtils.ScreenTop + ScreenUtils.ScreenBottom) / 2, 0f);
        Vector3 midTop = new Vector3(ScreenUtils.ScreenTop + colliderRadius, (ScreenUtils.ScreenRight + ScreenUtils.ScreenLeft) / 2, 0f);
        Vector3 midBottom = new Vector3(ScreenUtils.ScreenBottom - colliderRadius, (ScreenUtils.ScreenRight + ScreenUtils.ScreenLeft) / 2, 0f);

        SpawnAsteroid(Direction.Left, midRight);
        SpawnAsteroid(Direction.Right, midLeft);
        SpawnAsteroid(Direction.Up, midBottom);
        SpawnAsteroid(Direction.Down, midTop);

        //SpawnAsteroid();
        //asteroid.Initialize(Direction.Left, midLeft);
        //SpawnAsteroid();
        //asteroid.Initialize(Direction.Up, midTop);
        //SpawnAsteroid();
        //asteroid.Initialize(Direction.Down, midBottom);
    }

    void SpawnAsteroid(Direction direction, Vector3 position)
    {
        GameObject spawn = Instantiate(asteroidPrefab);
        colliderRadius = spawn.GetComponent<CircleCollider2D>().radius;

        spawn.GetComponent<Asteroid>().Initialize(direction, position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
