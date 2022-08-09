using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics_working : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public bool jump = false;
    float xInput, yInput;
    public int jumpForce;
    public float bulletSpeed;

    public GameObject bullet;
    public Transform bulletPos;
    bool shoot = false;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            shoot = true;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(xInput * speed, rb.velocity.y, yInput * speed);
        if (jump)
        {
            Jump();
            jump = false;
        }
        if (shoot)
        {
            Shoot();
            shoot = false;
        }
    }
    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
    }
    void Shoot()
    {
        GameObject bulletSpawn = Instantiate(bullet, bulletPos.position, bullet.transform.rotation);
        bulletSpawn.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, bulletSpeed);

    }
}
