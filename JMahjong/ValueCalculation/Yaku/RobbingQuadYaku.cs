namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
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
