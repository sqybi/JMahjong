namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            var selectedMeldList = groupedMeldList.Where(meld => meld.Type == MeldType.ClosedSequence
                                                                 || meld.Type == MeldType.OpenSequence);
            if (selectedMeldList.Any(meld => IsThreeColor(meld, groupedMeldList)))
            {
                resultHan = 1;
            }

            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                resultHan *= 2;
            }
            
            return resultHan;
        }

        private static bool IsThreeColor(MeldInfo testMeld, IEnumerable<MeldInfo> groupedMeldList)
        {
            var tileTypeSet = new HashSet<TileType>();
            var selectedMeldList =
                groupedMeldList.Where(meld => meld.IndicatingTile.Number == testMeld.IndicatingTile.Number);
            foreach (var meld in selectedMeldList)
            {
                tileTypeSet.Add(meld.IndicatingTile.Type);
            }
            return tileTypeSet.Contains(TileType.Pin)
                   && tileTypeSet.Contains(TileType.Sou)
                   && tileTypeSet.Contains(TileType.Wan);
        }
    }
}
