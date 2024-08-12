using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBusARCADE
{
    private static EventBusARCADE _instance;

    public static EventBusARCADE Instance
    {
        get
        {
            if (_instance == null)
                _instance = new EventBusARCADE();

            return _instance;
        }
    }

    public Action GameHasStarted;
    public Action UserEarnedPoint;
    public Action StartParticles;
    public Action GameIsOver;
    public Action GameHasReloaded;
    public Action GameContinued;
}
