using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed;

    Transform tr;
    Vector2 mousePosition;

    public Vector2 limitPoint1;
    public Vector2 limitPoint2;

    public GameObject prefabBullet;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine(FireBullet());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireBullet()
    {
        while(true)
        {
            Instantiate(prefabBullet, tr.position, Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("GameOver");
    }

}
