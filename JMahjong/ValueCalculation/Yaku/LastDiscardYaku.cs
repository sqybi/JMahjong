using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 河底捞鱼（houtei raoyui）
    /// </summary>
    public class LastDiscardYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LastDiscardYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (playerHands.LatestTile.IsLastTileInWall
                && !playerHands.LatestTile.IsSelfPick)
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
