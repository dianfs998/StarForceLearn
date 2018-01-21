
using System;
using System.Collections.Generic;
using GameFramework.Event;
using GameFramework.Network;
using GameFramework.Fsm;
using GameFramework.Procedure;

namespace UnityGameFramework.Runtime
{
    internal static class AvoidJIT
    {
        private static void NeverCallMethod()
        {
            new Dictionary<int, EventHandler<GameEventArgs>>();
            new Dictionary<int, EventHandler<Packet>>();
            new Dictionary<int, FsmEventHandler<IProcedureManager>>();
        }
    }
}
