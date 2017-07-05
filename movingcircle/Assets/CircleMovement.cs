using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    CamBounds Boundaries;
    float speed = 20;

    // Use this for initialization
    void Start()
    {
        transform.position = Vector3.zero;
        Boundaries =Camera.main.GetBounds(GetComponent<SphereCollider>().radius);
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.aspect != Boundaries.Aspect)
        {
            Boundaries = Camera.main.GetBounds(GetComponent<SphereCollider>().radius);
        }

        Move(Boundaries, this.speed);
    }


    void Move(CamBounds camBounds, float speed = 10)
    {
        var shift = speed * Time.deltaTime;

        //up
        if (InputCtrl.SimKeyPressBool(KeyCode.W))
        {
            if (this.transform.position.y < camBounds.Top)
            {
                if (this.transform.position.y + shift >= camBounds.Top)
                {
                    this.transform.position = new Vector3(this.transform.position.x, camBounds.Top);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + shift);
                }

            }
        }

        //down
        if (InputCtrl.SimKeyPressBool(KeyCode.S))
        {
            if (this.transform.position.y > camBounds.Bottom)
            {
                if (this.transform.position.y - shift <= camBounds.Bottom)
                {
                    this.transform.position = new Vector3(this.transform.position.x, camBounds.Bottom);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - shift);
                }

            }
        }

        //left
        if (InputCtrl.SimKeyPressBool(KeyCode.A))
        {
            if (this.transform.position.x > camBounds.Left)
            {
                if (this.transform.position.x - shift <= camBounds.Left)
                {
                    this.transform.position = new Vector3(camBounds.Left, this.transform.position.y);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x - shift, this.transform.position.y);
                }
            }
        }

        //right
        if (InputCtrl.SimKeyPressBool(KeyCode.D))
        {
            if (this.transform.position.x < camBounds.Right)
            {
                if (this.transform.position.x + shift >= camBounds.Right)
                {
                    this.transform.position = new Vector3(camBounds.Right, this.transform.position.y);
                }
                else
                {
                    this.transform.position = new Vector3(this.transform.position.x + shift, this.transform.position.y);
                }
            }
        }
    }

}
