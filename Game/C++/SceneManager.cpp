#include "SceneManager.h"

SceneManager::SceneManager(const SpawnParams& params)
    : Script(params)
{
    // Enable ticking OnUpdate function
    _tickUpdate = true;
}

void SceneManager::OnEnable()
{
    // Here you can add code that needs to be called when script is enabled (eg. register for events)
}

void SceneManager::OnDisable()
{
    // Here you can add code that needs to be called when script is disabled (eg. unregister from events)
}

void SceneManager::OnUpdate()
{
    // Here you can add code that needs to be called every frame
}
