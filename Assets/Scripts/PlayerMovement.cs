//using System.Collections;
//using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class PlayerMovement : NetworkBehaviour {
    [SerializeField] private float _speed = 10;
    private Rigidbody _rb;

    public int lapNumber;
    public int checkpointIndex;

    /*    private Vector3 moveDirection;*/
    public override void OnNetworkSpawn()
    {
        if (!IsOwner) Destroy(this);
    }

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
/*        lapNumber = 1;
        checkpointIndex = 0;*/
    }



    // Update is called once per frame
    void Update()
    {
        Move();
        //ProcessInputs();
    }


/*    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;
    }*/

    void Move()
    {
        var direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        _rb.velocity = direction * _speed;
    }
}
