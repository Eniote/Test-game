using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    [SerializeField] float speed = 1f;

    Rigidbody2D rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = speed * Time.deltaTime * Input.GetAxis("Horizontal");
        float yValue = speed * Time.deltaTime * Input.GetAxis("Vertical");

        Vector2 move = new Vector2(xValue, yValue);
        move.Normalize();
        rd.AddForce(move);

    }
}
