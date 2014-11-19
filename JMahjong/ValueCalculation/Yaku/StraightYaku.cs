namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            var indicatingDictionary = new Dictionary<TileType, HashSet<int>>();
            var sequenceMeldList =
                groupedMeldList.Where(
                    meld => meld.Type == MeldType.ClosedSequence || meld.Type == MeldType.OpenSequence);
            foreach (var meld in sequenceMeldList)
            {
                if (!indicatingDictionary.ContainsKey(meld.IndicatingTile.Type))
                {
                    indicatingDictionary[meld.IndicatingTile.Type] = new HashSet<int>();
                }
                indicatingDictionary[meld.IndicatingTile.Type].Add(meld.IndicatingTile.Number);
            }

            var tileTypes = new List<TileType> { TileType.Pin, TileType.Sou, TileType.Wan };
            foreach (var indicatingType in tileTypes)
            {
                if (indicatingDictionary.ContainsKey(indicatingType))
                {
                    var indicatingSet = indicatingDictionary[indicatingType];
                    if (indicatingSet.Contains(1)
                        && indicatingSet.Contains(4)
                        && indicatingSet.Contains(7))
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
    }
}
