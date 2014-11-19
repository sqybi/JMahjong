namespace JMahjong.Shared.DataStructure
{
    using JMahjong.Shared.Enum;

    /// <summary>
    /// 牌组
    /// </summary>
    public class MeldInfo
    {
        /// <summary>
        /// 牌组类型（单张/对子/明暗顺子/明暗刻子/明暗杠子）
        /// </summary>
        public MeldType Type { get; set; }

        /// <summary>
        /// 牌组指示牌（顺子 => 最小一张；其它 => 任意一张）
        /// </summary>
        public TileInfo IndicatingTile { get; set; }

        /// <summary>
        /// 弃牌来自的玩家
        /// </summary>
        public PlayerAbsolutePosition DiscardPlayerPosition { get; set; }
    }
}
