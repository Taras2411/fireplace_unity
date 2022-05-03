using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using UnityEngine;

public abstract class Resource{
    public abstract string Name { get; }
    public abstract string pathToIconSprite { get; }
    int amount;
    public int Amount {
        get { return amount; }
        set {
            if (value < 0) {
                amount = 0;
            } else {
                amount = value;
            }
        }
    }
    int maxAmount;
    public int MaxAmount {
        get { return maxAmount; }
        set {
            if (value < 0) {
                maxAmount = 0;
            } else {
                maxAmount = value;
            }
        }

    }
    public abstract void parsePlayPrefs();
    public abstract void savePlayPrefs();   
}







public static class ResourcesFacory {

    public static List<Resource> resources = new List<Resource>();
    public static void FactoryInit(){
        foreach (var type in Assembly.GetExecutingAssembly().GetTypes()) {
            if (type.IsSubclassOf(typeof(Resource))) {
                resources.Add((Resource)Activator.CreateInstance(type));
            }
        }


    }


    public static T create<T>(string name) where T : Resource {
        var type = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(t => t.Name == name);
        if (type == null) {
            Debug.LogError("Could not find type " + name);
            return null;
        }
        return (T)Activator.CreateInstance(type);
    }
    //returns a list of all the resources in the game using reflection
    public static List<Resource> CreateAllResources() {
        var types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Resource)));
        var resources = new List<Resource>();
        foreach (var type in types) {
            resources.Add((Resource)Activator.CreateInstance(type));
        }
        return resources;
    }




}

