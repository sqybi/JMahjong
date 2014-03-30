using System.Collections.Generic;

namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 玩家场况信息
    /// </summary>
    public class PlayerSituationInfo
    {
        /// <summary>
        /// 场风（东/南/西/北）
        /// </summary>
        private int PrevailingWind { get; set; }

        /// <summary>
        /// 自风（东/南/西/北）
        /// </summary>
        private int OwnWind { get; set; }

        /// <summary>
        /// 宝牌（不包含里宝牌）
        /// </summary>
        private List<TileInfo> Dora { get; set; }

        /// <summary>
        /// 里宝牌
        /// </summary>
        private List<TileInfo> UraDora { get; set; }
    }
}
