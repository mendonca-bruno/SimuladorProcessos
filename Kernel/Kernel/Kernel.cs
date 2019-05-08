using System;
using System.Collections.Generic;
using Nucleo;

namespace Kernel
{
    public class OS
    {
        public Memory Memory { get; set; }
        public List<Process> Processes { get; set; }

        public OS()
        {
            Memory = new Memory(1024 * 2);
            Processes = new List<Process>();
        }

        public void AddProcess(Process process)
        {            
            Processes.Add(process);
        }

        public void Update()
        {
            for (int i = 0; i < Processes.Count; i++)
            {
                Processes[i].Update(new Quantum(1));
            }
        }
    }
}
