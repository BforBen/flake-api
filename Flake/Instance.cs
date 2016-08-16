using System;
using FlakeGen;

namespace Flake
{
    internal sealed class IdGen
    {
        private static volatile Id64Generator FlakeGen;
        private static object syncRoot = new Object();

        private IdGen() { }

        internal static Id64Generator Instance
        {
            get
            {
                if (FlakeGen == null)
                {
                    lock (syncRoot)
                    {
                        if (FlakeGen == null)
                        {
                            FlakeGen = new Id64Generator(generatorId: Properties.Settings.Default.GeneratorId);
                        }
                    }
                }

                return FlakeGen;
            }
        }
    }
}
