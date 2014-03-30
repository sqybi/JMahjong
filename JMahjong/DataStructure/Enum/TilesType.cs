namespace JMahjong.General.Enum
{
    /// <summary>
    /// 牌组类型
    /// </summary>
    public enum TilesType
    {
        /// <summary>
        /// 单张
        /// </summary>
        Singleton,

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
}
