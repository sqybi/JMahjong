using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 抢杠（chankan）
    /// </summary>
    public class RobbingQuadYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RobbingQuadYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
        {
            int resultHan = 0;

            if (playerHands.LatestTile.IsRobbingQuad
                && !playerHands.LatestTile.IsSelfPick)
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
