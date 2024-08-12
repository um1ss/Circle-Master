using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventBus1VS1
{
    private static EventBus1VS1 _instance;

    public static EventBus1VS1 Instance
    {
        get
        {
            if (_instance == null)
                _instance = new EventBus1VS1();

            return _instance;
        }
    }

    public Action GameHasStarted;
    public Action StartParticles;
    public Action GameIsOver;
    public Action GameHasReloaded;

    public Action UserOneEarnedPoint;
    public Action UserTwoEarnedPoint;
}