using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaFloorMovement : MonoBehaviour
{
    public GameObject [] cubes;
    public int j = 0;
    public float moveSpeed;
    public int h = 0;
    private int tracker = 0;

    // Start is called before the first frame update

    void Start()
    {
        cubes = new GameObject[6400];
        for (int i = 0; i < 6400; i++)
        {
            if (i == 0)
            {
                cubes[i] = GameObject.Find("Cube");
            }
            else if (i < 10)
            {
                cubes[i] = GameObject.Find("Cube.00" + i);
            }
            else if (i < 100)
            {
                cubes[i] = GameObject.Find("Cube.0" + i);
            }
            else
            {
                cubes[i] = GameObject.Find("Cube." + i);
            }
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        for (int k = 0; k < 64; k++)
        {
            for (int m = 0; m < 100; m++)
            {
                CubeMovement activate = cubes[m+tracker].GetComponent<CubeMovement>();
                activate.trigger = true;
            }
            tracker = tracker + 100;
            double seconds = 0.2;
            yield return new WaitForSeconds(0.2f);
        }
    }
}
