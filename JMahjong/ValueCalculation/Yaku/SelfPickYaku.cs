using System.Collections.Generic;
using System.Linq;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
        {
            int resultHan = 0;
            
            if (playerHands.LatestTile.IsSelfPick
                && YakuHelper.IsWinningCloseHands(groupedTilesList))
            {
                resultHan = 1;
            }

            return resultHan;
        }
    }
}
