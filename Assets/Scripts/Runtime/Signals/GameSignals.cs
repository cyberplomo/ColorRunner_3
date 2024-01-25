
using strange.extensions.signal.impl;
using UnityEngine;

namespace Runtime.Signals
{
    public class GameSignals : Signal
    {
        //Game Behaviour
        public Signal onGameInitialize = new Signal();
        public Signal onLevelInitialize = new Signal();
        public Signal onLevelStart = new Signal();

        //In-Game
       
        public Signal<int> onTriggerDequeuePoolableObject = new Signal<int>();

      

        public Signal<GameObject> onSetCinemachineTarget = new Signal<GameObject>();

        
    }
}