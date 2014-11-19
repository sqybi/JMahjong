using System.Linq;

namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

    /// <summary>
    /// 二盃口（ryanpeikou）
    /// </summary>
    public class TwoSetsOfIdenticalSequencesYaku : IYaku
    {
        private readonly bool _allowSameSets;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="allowSameSets">是否允许由两个相同的一盃口组成</param>
        public TwoSetsOfIdenticalSequencesYaku(bool allowSameSets)
        {
            _allowSameSets = allowSameSets;
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            int setsCount = 0;
            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                var selectedGroupedList =
                    groupedMeldList.Select(
                        meld => YakuHelper.CountMeldInMelds(meld.Type, meld.IndicatingTile, groupedMeldList));
                foreach (int meldInMelds in selectedGroupedList)
                {
                    if (_allowSameSets)
                    {
                        setsCount += meldInMelds / 2;
                    }
                    else
                    {
                        setsCount += meldInMelds >= 2 ? 1 : 0;
                    }
                }
            }

            if (setsCount >= 2)
            {
                resultHan = 2;
            }

            return resultHan;
        }
    }
}
