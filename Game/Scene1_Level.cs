using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

public static class WallFactory
{
    public static Actor CreateWall(Vector3 position, Vector3 scale)
    {
        Actor wall = new StaticModelActor("Wall");
        wall.Position = position;
        wall.Scale = scale;

        StaticModel staticModel = new StaticModel();
        Model wallMesh = FlaxEngine.Content.Load<Model>("WallMesh");

        if (wallMesh != null)
        {
            staticModel.Model = wallMesh;
        }
        else
        {
            Debug.LogError("Wall mesh not Found!");
        }

        return wall;
    }

}

/// <summary>
/// Scene1_Level Script.
/// </summary>
public class Scene1_Level : Script
{
    public float RoomSize = 10.0f;
    public float WallThinkness = 0.5f;

    /// <inheritdoc/>
    public override void OnStart()
    {
        Room();
        // Here you can add code that needs to be called when script is created, just before the first game update
    }


    private void Room()
    {
        CreateWall(new Vector3(0, 0, RoomSize / 2), new Vector3(RoomSize, WallThinkness, WallThinkness));
        CreateWall(new Vector3(0, 0, -RoomSize / 2), new Vector3(RoomSize, WallThinkness, WallThinkness));
        CreateWall(new Vector3(RoomSize / 2, 0, 0), new Vector3(WallThinkness, WallThinkness, RoomSize));
        CreateWall(new Vector3(-RoomSize / 2, 0, 0), new Vector3(WallThinkness, WallThinkness, RoomSize));
        CreateWall(new Vector3(0, RoomSize / 2, 0), new Vector3(RoomSize, WallThinkness, WallThinkness));
        CreateWall(new Vector3(0, -RoomSize / 2, 0), new Vector3(RoomSize, WallThinkness, WallThinkness));
    }

    private void CreateWall(Vector3 position, Vector3 scale)
    {
        var wall = WallFactory.CreateWall(position, scale);
        Scene.AddChild(wall);
    }

    /// <inheritdoc/>
    public override void OnEnable()
    {
        // Here you can add code that needs to be called when script is enabled (eg. register for events)
    }

    /// <inheritdoc/>
    public override void OnDisable()
    {
        // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
    }

    /// <inheritdoc/>
    public override void OnUpdate()
    {
        // Here you can add code that needs to be called every frame
    }
}
