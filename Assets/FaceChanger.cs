using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FaceChanger : MonoBehaviour
{
    public SpriteRenderer baseHair;
    public SpriteRenderer baseFace;
    public SpriteRenderer baseBody;
    public SpriteRenderer baseBodyKit;
    public Sprite[] hairs;
    public Sprite[] faces;
    public Sprite[] bodies;
    public Sprite[] body_kits;

    public int h = 0;
    public int f = 0;
    public int b = 0;
    public int bk = 0;

    public bool checkHairs;
    public bool checkFaces;
    public bool checkBodies;
    public bool checkBodyKits;



    void Start()
    {
        checkHairs = true;
        checkFaces = false;
        checkBodies = false;
        checkBodyKits = false;
    }


    void Update()
    {
        baseHair.sprite = hairs[h];
        baseFace.sprite = faces[f];
        baseBody.sprite = bodies[b];
        baseBodyKit.sprite = body_kits[bk];

        if (Input.GetKey(KeyCode.A))
        {
            checkHairs = true;
            checkFaces = false;
            checkBodies = false;
            checkBodyKits = false;
        }

        if (Input.GetKey(KeyCode.S))
        {
            checkHairs = false;
            checkFaces = true;
            checkBodies = false;
            checkBodyKits = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            checkHairs = false;
            checkFaces = false;
            checkBodies = true;
            checkBodyKits = false;
        }

        if (Input.GetKey(KeyCode.F))
        {
            checkHairs = false;
            checkFaces = false;
            checkBodies = false;
            checkBodyKits = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (checkHairs)
            {
                if (h < hairs.Length - 1)
                    h++;
                else
                    h = 0;
            }

            if (checkFaces)
            {
                if (f < faces.Length - 1)
                    f++;
                else
                    f = 0;
            }

            if (checkBodies)
            {
                if (b < bodies.Length - 1)
                    b++;
                else
                    b = 0;
            }

            if (checkBodyKits)
            {
                if (bk < body_kits.Length - 1)
                    bk++;
                else
                    bk = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (checkHairs)
            {
                if (h > 0)
                    h--;
                else
                    h = hairs.Length - 1;
            }

            if (checkFaces)
            {
                if (f > 0)
                    f--;
                else
                    f = faces.Length - 1;
            }

            if (checkBodies)
            {
                if (b > 0)
                    b--;
                else
                    b = bodies.Length - 1;
            }

            if (checkBodyKits)
            {
                if (bk > 0)
                    bk--;
                else
                    bk = body_kits.Length - 1;
            }
        }
    }
}
