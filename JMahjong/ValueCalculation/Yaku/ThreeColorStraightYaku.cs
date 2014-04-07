using System.Collections.Generic;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 三色同顺（sanshoku doujun）
    /// </summary>
    public class ThreeColorStraightYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ThreeColorStraightYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            foreach (var meld in groupedMeldList)
            {
                if (meld.Type == MeldType.ClosedSequence
                    || meld.Type == MeldType.OpenSequence)
                {
                    if (IsThreeColor(meld, groupedMeldList))
                    {
                        resultHan = 1;
                        break;
                    }
                }
            }

            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                resultHan *= 2;
            }
            
            return resultHan;
        }

        private bool IsThreeColor(MeldInfo testMeld, IEnumerable<MeldInfo> groupedMeldList)
        {
            var tileTypeSet = new HashSet<TileType>();
            foreach (var meld in groupedMeldList)
            {
                if (meld.IndicatingTile.Number == testMeld.IndicatingTile.Number)
                {
                    tileTypeSet.Add(meld.IndicatingTile.Type);
                }
            }
            return tileTypeSet.Contains(TileType.Pin)
                   && tileTypeSet.Contains(TileType.Sou)
                   && tileTypeSet.Contains(TileType.Wan);
        }
    }
}
