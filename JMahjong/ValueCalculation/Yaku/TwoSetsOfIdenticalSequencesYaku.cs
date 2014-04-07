using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 二盃口（ryanpeikou）
    /// </summary>
    public class TwoSetsOfIdenticalSequencesYaku : IYaku
    {
        private bool allowSameSets;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="allowSameSets">是否允许由两个相同的一盃口组成</param>
        public TwoSetsOfIdenticalSequencesYaku(bool allowSameSets)
        {
            this.allowSameSets = allowSameSets;
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            int setsCount = 0;
            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                foreach (var meld in groupedMeldList)
                {
                    int meldInMelds = YakuHelper.CountMeldInMelds(meld.Type, meld.IndicatingTile, groupedMeldList);
                    if (allowSameSets)
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
