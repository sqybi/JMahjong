using System.Linq;

namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            int quadsCount = groupedMeldList.Count(meld => meld.Type == MeldType.ClosedQuad || meld.Type == MeldType.OpenQuad);

            if (quadsCount >= 3)
            {
                resultHan = 2;
            }

            return resultHan;
        }
    }
}
