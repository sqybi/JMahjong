using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 七对子（chiitoitsu / chiitoi）
    /// </summary>
    public class SevenPairsYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SevenPairsYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<TilesInfo> groupedTilesList)
        {
            int resultHan = 2;

            if (groupedTilesList.Any(tiles => tiles.Type != TilesType.Pair))
            {
                resultHan = 0;
            }

            if (groupedTilesList.Distinct().Count() != groupedTilesList.Count)
            {
                resultHan = 0;
            }

            return resultHan;
        }
    }
}
