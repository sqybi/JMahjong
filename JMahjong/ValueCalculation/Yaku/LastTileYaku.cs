using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 海底捞月（haitei raoyue）
    /// </summary>
    public class LastTileYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LastTileYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (playerHands.LatestTile.IsLastTileInWall
                && playerHands.LatestTile.IsSelfPick)
            {
                resultHan = 1;
            }
            
            return resultHan;
        }
    }
}
