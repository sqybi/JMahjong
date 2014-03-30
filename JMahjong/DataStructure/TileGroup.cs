namespace JMahjong.DataStructure
{
    /// <summary>
    /// 牌组类型
    /// </summary>
    public enum TileGroupType
    {
        /// <summary>
        /// 单张
        /// </summary>
        Single,

        /// <summary>
        /// 对子
        /// </summary>
        Pair,

        /// <summary>
        /// 明顺子
        /// </summary>
        OpenSequence,

        /// <summary>
        /// 暗顺子
        /// </summary>
        ClosedSequence,

        /// <summary>
        /// 明刻子
        /// </summary>
        OpenTriplet,

        /// <summary>
        /// 暗刻子
        /// </summary>
        ClosedTriplet,

        /// <summary>
        /// 明杠子
        /// </summary>
        OpenQuad,

        /// <summary>
        /// 暗杠子
        /// </summary>
        ClosedQuad
    }

    /// <summary>
    /// 牌组
    /// </summary>
    public class TileGroup
    {
        /// <summary>
        /// 牌组类型（单张/对子/明暗顺子/明暗刻子/明暗杠子）
        /// </summary>
        public TileGroupType Type { get; set; }

        /// <summary>
        /// 牌组指示牌（顺子 => 最小一张；其它 => 任意一张）
        /// </summary>
        public Tile IndicatingTile { get; set; }
    }
}
