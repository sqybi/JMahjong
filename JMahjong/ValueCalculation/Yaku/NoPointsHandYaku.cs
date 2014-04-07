using System.Collections.Generic;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;
using System.Linq;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 平和（pinfu）
    /// </summary>
    public class NoPointsHandYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public NoPointsHandYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            if (YakuHelper.IsWinningCloseHands(groupedMeldList))
            {
                var acceptedTypeList = new List<MeldType>
                {
                    MeldType.ClosedSequence,
                    MeldType.Pair
                };

                if (groupedMeldList.All(meld => acceptedTypeList.Contains(meld.Type)))
                {
                    var indicatingTile = groupedMeldList.Single(meld => meld.Type == MeldType.Pair).IndicatingTile;
                    if (IsPairAllowed(indicatingTile, playerHands))
                    {
                        var sequences = groupedMeldList.Where(meld => meld.Type == MeldType.ClosedSequence);
                        if (IsSequenceAllowed(sequences, playerHands))
                        {
                            resultHan = 1;
                        }
                    }
                }
            }

            return resultHan;
        }

        /// <summary>
        /// 检查对子是否符合要求，即不能为场风、自风、三元牌
        /// </summary>
        /// <param name="indicatingTile">对子中的一张牌</param>
        /// <param name="playerHands">玩家手牌信息</param>
        /// <returns>对子是否符合要求</returns>
        private bool IsPairAllowed(TileInfo indicatingTile, PlayerHandsInfo playerHands)
        {
            if (indicatingTile.Type == TileType.Dragon)
            {
                return false;
            }
            if (indicatingTile.Type == TileType.Wind)
            {
                if (indicatingTile.Number == playerHands.OwnWind
                    || indicatingTile.Number == playerHands.PrevailingWind)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsSequenceAllowed(IEnumerable<MeldInfo> sequences, PlayerHandsInfo playerHands)
        {
            var latestTileType = playerHands.LatestTile.Tile.Type;
            var latestTileNumber = playerHands.LatestTile.Tile.Number;
            if (latestTileNumber == 0)
            {
                latestTileNumber = 5;
            }
            foreach (var sequence in sequences)
            {
                var indicatingTileType = sequence.IndicatingTile.Type;
                var indicatingTileNumber = sequence.IndicatingTile.Number;
                if (indicatingTileNumber == 0)
                {
                    indicatingTileNumber = 5;
                }
                if (indicatingTileType == latestTileType)
                {
                    // 听左面且非边张
                    if (indicatingTileNumber == latestTileNumber
                        && indicatingTileNumber != 7)
                    {
                        return true;
                    }
                    // 听右面且非边张
                    if (indicatingTileNumber + 2 == latestTileNumber
                        && indicatingTileNumber != 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
