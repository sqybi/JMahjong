using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 岭上开花（rinshan kaihou）
    /// </summary>
    public class DeadWallDrawYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DeadWallDrawYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
        {
            int resultHan = 0;

            if (playerHands.LatestTile.IsInDeadWall
                && playerHands.LatestTile.IsSelfPick)
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
