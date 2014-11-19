namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

    /// <summary>
    /// 立直（riichi）
    /// </summary>
    public class ReadyHandYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ReadyHandYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (playerHands.IsReadyHand)
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
