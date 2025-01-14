using System;
using System.Collections.Generic;
using FlaxEngine;

namespace Game;

/// <summary>
/// SceneManager Script.
/// </summary>
public class SceneManager : Script
{
    private List<CinematicSequence> sequence;
    private int currentSeqenceIndex;

    public event Action<CinematicSequence> OnSequenceChanged;

    public void Initialize(List<CinematicSequence> sequenceList)
    {
        sequence = sequenceList;
        currentSeqenceIndex = 0;
        StartSequence(currentSeqenceIndex);
    }

    private void StartSequence(int index)
    {
        if (index < 0 || index >= sequence.Count) return;

        if (currentSeqenceIndex != index)
        {
            StopSequence(currentSeqenceIndex);
            currentSeqenceIndex = index;
        }

        CinematicSequence newSequence = sequence[currentSeqenceIndex];
        newSequence.OnStart();
        OnSequenceChanged?.Invoke(newSequence);
    }

    private void StopSequence(int index)
    {
        if (index < 0 || index >= sequence.Count) return;

        CinematicSequence sequenceToStop = sequence[index];
        sequenceToStop.Stop();
    }

    private void TransitionToNextSequence()
    {
        int nextIndex = currentSeqenceIndex + 1;
        if (nextIndex < sequence.Count)
        {
            StartSequence(nextIndex);
        }
        else
        {
            StartSequence(0);
        }
    }

    /// <inheritdoc/>
    public override void OnStart()
    {
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
        // Here you can add code that needs to be called every frame
        if (currentSeqenceIndex >= 0 && currentSeqenceIndex < sequence.Count)
        {
            sequence[currentSeqenceIndex].OnUpdate();
        }
    }
}
