using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * BackgroundController, Phoenix Makins, 101193192, 10-24-2020, Controls the backgrounds movement their boundaries and their teleporting, 1 Revision which converted vertical movement to horizontal movement and changed the boundaries
 */
public class BackgroundController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Reset()
    {
        transform.position = new Vector3(verticalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -verticalBoundary)
        {
            _Reset();
        }
    }
}
