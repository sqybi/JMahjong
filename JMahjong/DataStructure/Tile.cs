namespace JMahjong.DataStructure
{
    /// <summary>
    /// 麻将牌的类型
    /// </summary>
    public enum TileType
    {
        /// <summary>
        /// 筒子
        /// </summary>
        Pin,
        /// <summary>
        /// 索子
        /// </summary>
        Sou,
        /// <summary>
        /// 万子
        /// </summary>
        Wan,
        /// <summary>
        /// 风牌
        /// </summary>
        Wind,
        /// <summary>
        /// 三元牌
        /// </summary>
        Dragon
    }

    /// <summary>
    /// 定义单张麻将牌
    /// </summary>
    public class Tile
    {
        /// <summary>
        /// 类型（桶/索/万/风/三元）
        /// </summary>
        public TileType Type { get; set; }

        /// <summary>
        /// 数字（1..4 => 东/南/西/北；1..3 => 白/发/中）
        /// </summary>
        public int Number { get; set; }
    }
}
