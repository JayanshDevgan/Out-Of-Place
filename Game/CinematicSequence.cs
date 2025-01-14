using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// CinematicSequence Script.
/// </summary>
public class CinematicSequence : Script
{
    public Transform CameraTransform;
    //public Vector3 StartPosition;
    //public Vector3 TargetPosition;
    public float Duration;
    public float elapsedTime;

    public void Stop()
    {
       // Handle Stopping Logic (optional)
    }

    /// <inheritdoc/>
    public override void OnStart()
    {
        elapsedTime = 0f;
        // Here you can add code that needs to be called when script is created, just before the first game update
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
        elapsedTime += Time.DeltaTime;
        if (elapsedTime < Duration)
        {
            // Lerp: Camera Position
            // Camera.main.transform.Position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / Duration);
        }
        // Here you can add code that needs to be called every frame
    }
}
