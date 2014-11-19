namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

    /// <summary>
    /// 一发（ippatsu）
    /// </summary>
    public class OneShotYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public OneShotYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (playerHands.IsReadyHand
                && playerHands.IsOneShotRound)
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
