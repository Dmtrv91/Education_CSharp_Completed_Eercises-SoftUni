using System;

namespace ConsoleAppGlava11Exercise7Sequence
{
    class Sequence
    {
        private static int currentValue = 0;

        private Sequence()
        {
        }

        public static int NextValue()
        {
            currentValue++;
            return currentValue;
        }
    }
}