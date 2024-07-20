using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] HelixPrefab;
    public GameObject Lastpice;
    [SerializeField] int Totalhelix;
    [SerializeField] float offset;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Totalhelix; i++)
        {
            var piece = HelixPrefab[UnityEngine.Random.Range(0,HelixPrefab.Length)];
            GameObject Spawn = Instantiate(piece, transform);
            Vector3 NewPos = Spawn.transform.position;
            NewPos.y -= offset * i;
            Spawn.transform.position = NewPos;
            var newRotation = UnityEngine.Random.Range(0, 360);
            Spawn.transform.rotation = Quaternion.Euler(0,newRotation,0);
        }

        GameObject p1 = Instantiate(Lastpice, transform);
        Vector3 newPos1 = p1.transform.position;
        newPos1.y -= offset * Totalhelix;
        p1.transform.position = newPos1;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
