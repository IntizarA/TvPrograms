using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvPrograms
{
    class TVPrograms
    {
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public TimeSpan StartedAt { get; set; }
        public TimeSpan FinishedAt { get; set; }
        public int ChannelId { get; set; }
    }
}
