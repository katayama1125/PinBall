using UnityEngine;
using System.Collections;

public class FripperController : MonoBehaviour
{
    private HingeJoint myHingeJoint;

    private float defaultAngle = 20;
    private float flickAngle = -20;

    // Use this for initialization
    void Start()
    {
        this.myHingeJoint = GetComponent<HingeJoint>();

        SetAngle(this.defaultAngle);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) || tag == "LeftFripperTag" && tag == "RightFripperTag")
        {
            SetAngle(this.flickAngle);
        }


        if (Input.GetKeyUp(KeyCode.LeftArrow) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.A) && tag == "LeftFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.RightArrow) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.D) && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) || Input.GetKeyUp(KeyCode.S) || tag == "LeftFripperTag" && tag == "RightFripperTag")
        {
            SetAngle(this.defaultAngle);
        }
    }

    public void SetAngle(float angle)
    {
        JointSpring jointSpr = this.myHingeJoint.spring;
        jointSpr.targetPosition = angle;
        this.myHingeJoint.spring = jointSpr;
    }
}