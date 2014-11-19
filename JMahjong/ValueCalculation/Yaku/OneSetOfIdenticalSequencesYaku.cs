namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (YakuHelper.IsWinningCloseHands(groupedMeldList)
                && groupedMeldList.Any(meld => YakuHelper.CountMeldInMelds(meld.Type, meld.IndicatingTile, groupedMeldList) >= 2))
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
