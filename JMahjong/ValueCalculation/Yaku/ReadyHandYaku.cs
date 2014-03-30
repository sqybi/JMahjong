using System.Collections.Generic;
using System.Net;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
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
