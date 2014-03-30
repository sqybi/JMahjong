namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 最后进张牌信息
    /// </summary>
    public class LatestTileInfo
    {
        /// <summary>
        /// 牌面
        /// </summary>
        public TileInfo Tile { get; set; }

        /// <summary>
        /// 是否为自摸
        /// </summary>
        public bool IsFromWall { get; set; }

        /// <summary>
        /// 是否为海底/河底牌
        /// </summary>
        public bool IsLastTileInWall { get; set; }

        /// <summary>
        /// 是否为岭上牌
        /// </summary>
        public bool IsInDeadWall { get; set; }
    }
}
