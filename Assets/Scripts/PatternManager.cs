using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternManager : MonoBehaviour
{
    [Tooltip("Mesh on which pattern to be rendered")]
    public MeshRenderer meshRenderer;

    public Material gridMaterial;
    public Material stripMaterial;
    
    // 2 is the possibe minimum value we defined in shader (Max value is 50)
    private float currentDensity = 2;

    public void SetPatternDensity (float density)
    {
        meshRenderer.material.SetFloat("_Density", density);
        currentDensity = density;
    }

    public void DisplayGridPattern()
    {
        meshRenderer.material = gridMaterial;
        SetPatternDensity(currentDensity);
    }

    public void DisplayStripPattern()
    {
        meshRenderer.material = stripMaterial;
        SetPatternDensity(currentDensity);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initial setup
        DisplayGridPattern();
        SetPatternDensity(currentDensity);
    }
}
