using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private ParticleSystemRenderer Particle;
    private ParticleSystem Ps;
    public Material Mat;
    private Material MatCopy;
    private Shader Shader;

    private Color ColorApply = Color.white;

    public bool destoy = true;

    void Awake()
    {
        Ps = GetComponent<ParticleSystem>();
        Shader = Mat.shader;
        MatCopy = new Material(Shader);
        MatCopy.CopyPropertiesFromMaterial(Mat);
        Particle = GetComponent<ParticleSystemRenderer>();
        Particle.material = MatCopy;
        
    }

    void Start()
    {
        if (ColorApply != Color.white)
            Particle.material.color = ColorApply;
    }

    // Update is called once per frame
    void Update()
    {
        if (Ps)
        {
            if (!Ps.IsAlive() && destoy)
            {
                Destroy(gameObject);
            }
        }
    }

    public void ApplyRotation(Vector3 NewRotation)
    {
        Ps.startRotation3D = NewRotation;
    }
    public void ApplyColor(Color ColorToApply)
    {
        ColorApply = ColorToApply;
    }

    public void ChangeColor(Color ColorToApply)
    {
        MatCopy.color = ColorToApply;
        //Particle.material.color = ColorToApply;
    }

}
