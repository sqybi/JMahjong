using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
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
