using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MenuButton : LoadSceneButton
{
    public PlanetData planetData;
    
    public override void loadScene()
    {
        base.loadScene();
        Data.planetData = planetData;
    }
}
