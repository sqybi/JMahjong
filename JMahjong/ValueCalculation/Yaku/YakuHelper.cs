namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

    public static class YakuHelper
    {
        /// <summary>
        /// 是否为和牌需要的牌型，即四组加一对。七对子和国士无双不使用此方法判断。
        /// </summary>
        /// <param name="meldList">分割后的牌型</param>
        /// <returns>牌型是否可以和牌，不考虑无役的问题</returns>
        public static bool IsWinningHands(IList<MeldInfo> meldList)
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
        public static bool IsWinningCloseHands(IList<MeldInfo> meldList)
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

        /// <summary>
        /// 统计某个牌组在分组后的手牌中出现的次数
        /// </summary>
        /// <param name="meldType">牌组类型</param>
        /// <param name="indicatingTile">牌组指示牌</param>
        /// <param name="melds">分组的手牌信息</param>
        /// <returns>牌组在手牌中出现的次数</returns>
        public static int CountMeldInMelds(MeldType meldType, TileInfo indicatingTile, IEnumerable<MeldInfo> melds)
        {
            return melds.Count(meld => meld.Type == meldType && meld.IndicatingTile == indicatingTile);
        }
    }
}
