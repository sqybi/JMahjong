using System.Collections.Generic;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 三杠子（san kantsu）
    /// </summary>
    public class ThreeQuadsYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ThreeQuadsYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            int quadsCount = 0;
            foreach (var meld in groupedMeldList)
            {
                if (meld.Type == MeldType.ClosedQuad
                    || meld.Type == MeldType.OpenQuad)
                {
                    quadsCount++;
                }
            }

            if (quadsCount >= 3)
            {
                resultHan = 2;
            }

            return resultHan;
        }
    }
}
