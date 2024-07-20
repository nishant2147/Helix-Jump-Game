using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerscript : MonoBehaviour
{
    private Rigidbody rb;
    float Ballbounce = 200f;
    public GameObject WinPage,GameoverPage;
    public GameObject Splashprefab;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        Invoke("DestroySplash", 2);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collider)
    {
        rb.velocity = new Vector3(rb.velocity.x,Ballbounce * Time.deltaTime,rb.velocity.z);

        GameObject splash = Instantiate(Splashprefab,new Vector3(transform.position.x,collider.transform.position.y + 0.1f, transform.position.z),transform.rotation);
        splash.transform.SetParent(GameObject.Find("HelixRing").transform);

        if (collider.collider.tag == "Finish")
        {
            WinPage.SetActive(true);
        }

        if (collider.collider.tag == "Green")
        {
            GameoverPage.SetActive(true);
            Time.timeScale = 0;
        }

        if (collider.collider.tag == "splash")
        {
            Splash splashs = collider.gameObject.GetComponent<Splash>();
            splashs.Destroysplash();
        }

        
        //newSplit.transform.parent = collider.transform;
    }
    public void Retrybutton()
    {
        int currentLevel = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentLevel);
    }
}
