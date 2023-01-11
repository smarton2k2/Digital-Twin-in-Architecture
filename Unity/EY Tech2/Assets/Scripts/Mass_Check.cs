using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mass_Check : MonoBehaviour
{
    [SerializeField] private Material testMaterial;
    public Rigidbody rb;
    public float mass;
    private float mass2;
    Renderer rend;
    // public GameObject objects;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = testMaterial;
    }
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        mass = mass + mass2;
        mass = rb.mass;
        if(mass >= 45000)
        {
            rend.material.SetColor("_Color",Color.black);
        }
        else if(mass < 45000)
        {
            if(mass <= 22500)
            {
                rend.material.SetColor("_Color",Color.green * (22500-mass)/22500 + Color.yellow * mass/22500);

            }
            else
            {
                rend.material.SetColor("_Color",Color.red * (mass-22500)/22500 + Color.yellow * (45000-mass)/22500);
            }
        }
    }
}
