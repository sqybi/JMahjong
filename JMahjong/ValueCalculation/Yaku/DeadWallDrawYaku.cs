namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
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
