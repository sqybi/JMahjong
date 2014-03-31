using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    public static class YakuHelper
    {
        /// <summary>
        /// 是否为和牌需要的牌型，即四组加一对。七对子和国士无双不使用此方法判断。
        /// </summary>
        /// <param name="groupedTilesList">分割后的牌型</param>
        /// <returns>牌型是否可以和牌，不考虑无役的问题</returns>
        public static bool IsWinningHands(List<TilesInfo> groupedTilesList)
        {
            var acceptedTypeList = new List<TilesType>
            {
                TilesType.OpenSequence,
                TilesType.ClosedSequence,
                TilesType.OpenTriplet,
                TilesType.ClosedTriplet,
                TilesType.OpenQuad,
                TilesType.ClosedQuad,
                TilesType.Pair
            };

            return groupedTilesList.All(tiles => acceptedTypeList.Contains(tiles.Type))
                && groupedTilesList.Count(tiles => tiles.Type == TilesType.Pair) == 1;
        }

        /// <summary>
        /// 是否为门前清且和牌需要的牌型。
        /// </summary>
        /// <param name="groupedTilesList">分割后的牌型</param>
        /// <returns>牌型是否为门前清且可以和牌，不考虑无役的问题</returns>
        public static bool IsWinningCloseHands(List<TilesInfo> groupedTilesList)
        {
            var acceptedTypeList = new List<TilesType>
            {
                TilesType.ClosedSequence,
                TilesType.ClosedTriplet,
                TilesType.ClosedQuad,
                TilesType.Pair
            };

            return groupedTilesList.All(tiles => acceptedTypeList.Contains(tiles.Type))
                && groupedTilesList.Count(tiles => tiles.Type == TilesType.Pair) == 1;
        }
    }
}
