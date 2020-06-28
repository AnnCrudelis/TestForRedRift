using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PlanetData", menuName = "Planet Data", order = 51)]
public class PlanetData : ScriptableObject
{
    [SerializeField]
    private string planetName;
    [SerializeField]
    private Sprite background;
    [SerializeField]
    private float gravity;

    public string PlanetName
    {
        get
        {
            return planetName;
        }
    }

    public Sprite Background
    {
        get
        {
            return background;
        }
    }
    public float Gravity
    {
        get
        {
            return gravity;
        }
    }
}
