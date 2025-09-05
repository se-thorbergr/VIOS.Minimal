// Program.cs — VIOS.Minimal (mdk2pbscript)
using System;
using Sandbox.ModAPI.Ingame;
using VRage.Game;

namespace IngameScript
{
    public partial class Program : MyGridProgram
    {
        public Program()
        {
            Runtime.UpdateFrequency = UpdateFrequency.Update100;
            Echo("VIOS.Minimal: ready");
        }

        public void Save() { }

        public void Main(string argument, UpdateType updateSource)
        {
            try { /* minimal */ }
            catch (Exception ex) { Echo("VIOS ERROR: " + ex.Message); }
        }
    }
}
