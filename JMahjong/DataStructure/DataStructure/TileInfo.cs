using JMahjong.General.Enum;

namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 单张麻将牌
    /// </summary>
    public class TileInfo
    {
        /// <summary>
        /// 麻将牌类型（桶/索/万/风/三元）
        /// </summary>
        public TileType Type { get; set; }

        /// <summary>
        /// 麻将牌数字（0 => 红宝牌；1..9 => 普通牌；0..3 => 东/南/西/北；0..2 => 白/发/中）
        /// </summary>
        public int Number { get; set; }
    }
}
