using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�Ѿ� �߻� ���
public class BulletMove : MonoBehaviour
{

    Transform tr;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        StartCoroutine(DestroySelf());
    }

    // Update is called once per frame
    void Update()
    {
        tr.Translate(Vector3.up * speed);
    }

    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(5.0f);
        Destroy(this.gameObject);
    }

    public GameObject effectPrefab; //�� ������ �浹�� ����Ʈ������
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("enemy"))
        {
            Instantiate(effectPrefab, this.transform.position, Quaternion.identity);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
        Destroy(col.gameObject);
        Destroy(this.gameObject);
    }
}

