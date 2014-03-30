using System.Collections.Generic;

namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 手牌信息
    /// </summary>
    public class HandsInfo
    {
        /// <summary>
        /// 浮动牌（未吃/碰/明杠/暗杠过的牌）
        /// </summary>
        public List<TileInfo> FreeTileList { get; set; }

        /// <summary>
        /// 固定牌组（吃/碰/明杠/暗杠过的牌组）
        /// </summary>
        public List<TilesInfo> StickedTilesList { get; set; }

        /// <summary>
        /// 最后进张牌（同时存在于FreeTileList中）
        /// </summary>
        public LatestTileInfo LatestTile { get; set; }
    }
}
