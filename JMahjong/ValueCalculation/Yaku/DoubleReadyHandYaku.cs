namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

    /// <summary>
    /// 双立直（w riichi）
    /// </summary>
    public class DoubleReadyHandYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DoubleReadyHandYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
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
