using System;

namespace SortablePokerHands
{
    public class PokerHand : IComparable
    {
        public PokerHand(string hand)
        {

        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (obj is PokerHand poker)
            {
                return CompareTo(poker);
            }
            else
            {
                throw new ArgumentException("Object is not PokerHand");
            }
        }

        internal static int Compare(PokerHand a, PokerHand b)
        {
            throw new NotImplementedException();
        }
    }
}