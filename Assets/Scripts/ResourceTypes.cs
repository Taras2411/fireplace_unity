using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using UnityEngine;



public class HeatResource : Resource
{
    public override string Name { get { return "Heat"; } }
    public override string pathToIconSprite { get { return "Icons/local_fire_department_FILL1_wght400_GRAD0_fe7104"; } }
    public override void parsePlayPrefs()
    {
        Amount = PlayerPrefs.GetInt("HeatAmount",0);
        MaxAmount = PlayerPrefs.GetInt("HeatMaxAmount",0);
    }
    public override void savePlayPrefs()
    {
        PlayerPrefs.SetInt("HeatAmount", Amount);
        PlayerPrefs.SetInt("HeatMaxAmount", MaxAmount);
    }
}

public class FirewoodResource: Resource {
    public override string Name {
        get { return "Firewood"; }
    }
    public override string pathToIconSprite {
        get { return "Icons/forest_FILL1_wght400_GRAD0_opsz48_fe7104"; }
    }
    public override void parsePlayPrefs() {
        Amount = PlayerPrefs.GetInt("Firewood", 0);
        MaxAmount = PlayerPrefs.GetInt("FirewoodMax", 0);
    }
    public override void savePlayPrefs() {
        PlayerPrefs.SetInt("Firewood", Amount);
        PlayerPrefs.SetInt("FirewoodMax", MaxAmount);
    }
}


public class CoalResource : Resource{
    public override string Name { get { return "Coal"; } }
    public override string pathToIconSprite { get { return "Icons/outdoor_grill_FILL1_wght400_GRAD0_fe7104"; } }
    public override void parsePlayPrefs() {
        Amount = PlayerPrefs.GetInt("CoalAmount", 0);
        MaxAmount = PlayerPrefs.GetInt("CoalMaxAmount", 0);
    }
    public override void savePlayPrefs() {
        PlayerPrefs.SetInt("CoalAmount", Amount);
        PlayerPrefs.SetInt("CoalMaxAmount", MaxAmount);
    }
}

public class StartKitResource : Resource{
    public override string Name { get { return "StartKit"; } }
    public override string pathToIconSprite { get { return "Icons/restart_alt_FILL0_wght400_GRAD0_fe7104"; } }
    public override void parsePlayPrefs() {
        Amount = PlayerPrefs.GetInt("StartKitAmount", 0);
        MaxAmount = PlayerPrefs.GetInt("StartKitMaxAmount", 10);
    }
    public override void savePlayPrefs() {
        PlayerPrefs.SetInt("StartKitAmount", Amount);
        PlayerPrefs.SetInt("StartKitMaxAmount", MaxAmount);
    }
}

