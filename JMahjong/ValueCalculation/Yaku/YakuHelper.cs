using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    public static class YakuHelper
    {
        /// <summary>
        /// 是否为和牌需要的牌型，即四组加一对。七对子和国士无双不使用此方法判断。
        /// </summary>
        /// <param name="meldList">分割后的牌型</param>
        /// <returns>牌型是否可以和牌，不考虑无役的问题</returns>
        public static bool IsWinningHands(List<MeldInfo> meldList)
        {
            var acceptedTypeList = new List<MeldType>
            {
                MeldType.OpenSequence,
                MeldType.ClosedSequence,
                MeldType.OpenTriplet,
                MeldType.ClosedTriplet,
                MeldType.OpenQuad,
                MeldType.ClosedQuad,
                MeldType.Pair
            };

            return meldList.All(meld => acceptedTypeList.Contains(meld.Type))
                && meldList.Count(meld => meld.Type == MeldType.Pair) == 1;
        }

        /// <summary>
        /// 是否为门前清且和牌需要的牌型。
        /// </summary>
        /// <param name="meldList">分割后的牌型</param>
        /// <returns>牌型是否为门前清且可以和牌，不考虑无役的问题</returns>
        public static bool IsWinningCloseHands(List<MeldInfo> meldList)
        {
            var acceptedTypeList = new List<MeldType>
            {
                MeldType.ClosedSequence,
                MeldType.ClosedTriplet,
                MeldType.ClosedQuad,
                MeldType.Pair
            };

            return meldList.All(meld => acceptedTypeList.Contains(meld.Type))
                && meldList.Count(meld => meld.Type == MeldType.Pair) == 1;
        }

        public static int CountInMelds(MeldType meldType, TileInfo indicatingTile, IEnumerable<MeldInfo> meldList)
        {
            int count = 0;
            foreach (var meld in meldList)
            {
                if (meld.Type == meldType
                    && meld.IndicatingTile == indicatingTile)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
