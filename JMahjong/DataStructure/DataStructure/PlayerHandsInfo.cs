using System.Collections.Generic;

namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 和玩家相关的手牌信息
    /// </summary>
    public class PlayerHandsInfo
    {
        #region Meld

        /// <summary>
        /// 浮动牌（未吃/碰/明杠/暗杠过的牌）
        /// </summary>
        public List<TileInfo> FreeTileList { get; set; }

        /// <summary>
        /// 固定牌组（吃/碰/明杠/暗杠过的牌组）
        /// </summary>
        public List<MeldInfo> StickedMeldList { get; set; }

        /// <summary>
        /// 最后进张牌（同时存在于FreeTileList中）
        /// </summary>
        public LatestTileInfo LatestTile { get; set; }

        #endregion

        #region General Situation

        /// <summary>
        /// 场风（东/南/西/北）
        /// </summary>
        public int PrevailingWind { get; set; }

        /// <summary>
        /// 宝牌（不包含里宝牌）
        /// </summary>
        public List<TileInfo> Dora { get; set; }

        /// <summary>
        /// 里宝牌
        /// </summary>
        public List<TileInfo> UraDora { get; set; }

        /// <summary>
        /// 当前巡数
        /// </summary>
        public int Round { get; set; }

        #endregion

        #region Player Situation

        /// <summary>
        /// 自风（东/南/西/北）
        /// </summary>
        public int OwnWind { get; set; }

        /// <summary>
        /// 是否已经立直
        /// </summary>
        public bool IsReadyHand { get; set; }

        /// <summary>
        /// 是否为第一巡立直
        /// </summary>
        public bool IsReadyHandInFirstRound { get; set; }

        /// <summary>
        /// 是否为一发巡
        /// </summary>
        public bool IsOneShotRound { get; set; }

        #endregion
    }
}
