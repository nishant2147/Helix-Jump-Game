using UnityEngine;

public class Splash : MonoBehaviour
{
    public GameObject Splashprefab;

    internal void Destroysplash()
    {
        Destroy(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroysplash", 5);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
