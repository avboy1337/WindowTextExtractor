﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowTextExtractor
{
    class WindowInformation
    {
        public IDictionary<string, string> WindowDetails { get; private set; }

        public IDictionary<string, string> ProcessDetails { get; private set; }

        public WindowInformation() : this(new Dictionary<string, string>(), new Dictionary<string, string>())
        {
        }

        public WindowInformation(IDictionary<string, string> windowDetails, IDictionary<string, string> processDetails)
        {
            WindowDetails = windowDetails;
            ProcessDetails = processDetails;
        }

        public override string ToString()
        {
            const int paddingSize = 25;
            var builder = new StringBuilder(1024);
            
            if (WindowDetails.Keys.Any())
            {
                builder.AppendFormat($"Window Information {Environment.NewLine}");
            }
            
            foreach (var windowDetailKey in WindowDetails.Keys)
            {
                builder.AppendFormat($"{windowDetailKey.PadRight(paddingSize)}: {WindowDetails[windowDetailKey]}{Environment.NewLine}");
            }

            if (WindowDetails.Keys.Any())
            {
                builder.AppendFormat($"{Environment.NewLine}");
            }

            if (ProcessDetails.Keys.Any())
            {
                builder.AppendFormat($"Process Information {Environment.NewLine}");
            }

            foreach (var processDetailKey in ProcessDetails.Keys)
            {
                builder.AppendFormat($"{processDetailKey.PadRight(paddingSize)}: {ProcessDetails[processDetailKey]}{Environment.NewLine}");
            }

            return builder.ToString();
        }
    }
}
