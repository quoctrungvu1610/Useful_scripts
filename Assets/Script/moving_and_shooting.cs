using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_and_shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    float inputX, inputY;
    Rigidbody rb;
    public bool jump = false;
    public float jumpForce = 200f;
    public bool shoot = false;
    public GameObject bullet;
    public Transform bulletPos;
    public float bulletSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxis("Horizontal");
        inputY = Input.GetAxis("Vertical");
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
        rb.velocity = new Vector3(inputX * speed, rb.velocity.y, inputY * speed);
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
