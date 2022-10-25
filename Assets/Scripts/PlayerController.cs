using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform movePoint;

    [SerializeField]
    private LayerMask borderLayer;

    private Vector3 nextPosition;
    private float horizontal;
    private float vertical;
    private float distance;

    void Start()
    {
        nextPosition = movePoint.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, speed * Time.deltaTime);

        distance = Vector3.Distance(transform.position, movePoint.position);

        if (distance > 0.1f)
            return;

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal != 0)
        {
            nextPosition = movePoint.position + new Vector3(horizontal, 0f, 0f);

            if (!Physics2D.OverlapCircle(nextPosition, 0.2f, borderLayer))
            {
                movePoint.position = nextPosition;
            }
        }

        else if (vertical != 0)
        {
            nextPosition = movePoint.position + new Vector3(0f, vertical, 0f);

            if (!Physics2D.OverlapCircle(nextPosition, 0.2f, borderLayer))
            {
                movePoint.position = nextPosition;
            }
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(movePoint.position, 0.2f);
    }
}
