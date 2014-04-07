using System.Collections.Generic;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 一气通贯（ikkitsuukan）
    /// </summary>
    public class StraightYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public StraightYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            var indicatingDictionary = new Dictionary<TileType, HashSet<int>>(); 
            foreach (var meld in groupedMeldList)
            {
                if (meld.Type == MeldType.ClosedSequence
                    || meld.Type == MeldType.OpenSequence)
                {
                    if (!indicatingDictionary.ContainsKey(meld.IndicatingTile.Type))
                    {
                        indicatingDictionary[meld.IndicatingTile.Type] = new HashSet<int>();
                    }
                    indicatingDictionary[meld.IndicatingTile.Type].Add(meld.IndicatingTile.Number);
                }
            }

            foreach (var indicatingType in new List<TileType> {TileType.Pin, TileType.Sou, TileType.Wan})
            {
                if (indicatingDictionary.ContainsKey(indicatingType))
                {
                    var indicatingSet = indicatingDictionary[indicatingType];
                    if (indicatingSet.Contains(1)
                        && indicatingSet.Contains(4)
                        && indicatingSet.Contains(7))
                    {
                        resultHan = 1;
                    }
                }
            }

            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                resultHan *= 2;
            }

            return resultHan;
        }

        private bool IsStraight(MeldInfo testMeld, IEnumerable<MeldInfo> groupedMeldList)
        {
            HashSet<TileType> tileTypeSet = new HashSet<TileType>();
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
