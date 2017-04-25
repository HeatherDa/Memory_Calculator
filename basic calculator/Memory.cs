using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_calculator
{
    public class Memory : Calculator
    {
        public decimal Mem { get; set; }
        public Memory() : base() { }

        public void MemoryStore(decimal number) {this.Mem=number; }
        public decimal MemoryRecall() { return this.Mem; }
        public void MemoryAdd(decimal number) {this.Mem=Mem+number; }
        public void MemoryClear() {this.Mem=0; }
    }
}
