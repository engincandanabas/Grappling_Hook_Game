using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform player;
    private Vector3 target;
    public float lineOfSite;
    private float nextfiretime;
    public float fireRate = 1f;
    public GameObject bulletprefab;
    public Transform firePoint;
    public float speed;
    private GameObject[] bullets;
    int size;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!TriggerControl.playerdeath)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform.position;
            Vector3 difference = target - transform.position;
            float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotationZ);
            float distanceFromPlayer = Vector2.Distance(player.position, transform.position);


            if (distanceFromPlayer < lineOfSite)
            {
                Debug.LogWarning("gördü");
            }
            if (distanceFromPlayer <= lineOfSite && nextfiretime < Time.time)
            {
                GameObject bullet = Instantiate(bulletprefab, firePoint.position, Quaternion.Euler(0, 0, 0));
                
                /*float distanceFromPlayerbullet = Vector2.Distance(player.position, bullet.transform.position);
                bullet.transform.position = Vector2.MoveTowards(bullet.transform.position, player.position, speed * Time.deltaTime);*/
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.AddForce(firePoint.right * 10, ForceMode2D.Impulse);
                Debug.LogWarning("ates etti");
                nextfiretime = Time.time + fireRate;

            }
        }

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, lineOfSite);
    }
}
