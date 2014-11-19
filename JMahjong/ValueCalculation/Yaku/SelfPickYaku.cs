namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;

    /// <summary>
    /// 门前清自摸（menzenchin tsumohou / tsumo）
    /// </summary>
    public class SelfPickYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SelfPickYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;
            
            if (playerHands.LatestTile.IsSelfPick
                && YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
