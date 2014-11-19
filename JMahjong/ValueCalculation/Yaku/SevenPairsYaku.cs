namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

    /// <summary>
    /// 七对子（chiitoitsu / chiitoi）
    /// </summary>
    public class SevenPairsYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SevenPairsYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 2;

            if (groupedMeldList.Any(meld => meld.Type != MeldType.Pair))
            {
                resultHan = 0;
            }

            if (groupedMeldList.Distinct().Count() != groupedMeldList.Count)
            {
                resultHan = 0;
            }

            return resultHan;
        }
    }
}
