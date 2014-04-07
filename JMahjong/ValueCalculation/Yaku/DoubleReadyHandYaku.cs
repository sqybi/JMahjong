using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 立直（riichi）
    /// </summary>
    public class DoubleReadyHandYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DoubleReadyHandYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (playerHands.IsReadyHand
                && playerHands.IsReadyHandInFirstRound)
            {
                resultHan = 2;
            }

            return resultHan;
        }
    }
}
