using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 一盃口（iipeikou）
    /// </summary>
    public class OneSetOfIdenticalSequencesYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OneSetOfIdenticalSequencesYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                foreach (var meld in groupedMeldList)
                {
                    if (YakuHelper.CountMeldInMelds(meld.Type, meld.IndicatingTile, groupedMeldList) >= 2)
                    {
                        resultHan = 1;
                        break;
                    }
                }
            }

            return resultHan;
        }
    }
}
