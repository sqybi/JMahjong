namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

    /// <summary>
    /// 三暗刻（san ankou）
    /// </summary>
    public class ThreeClosedTripletsYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public ThreeClosedTripletsYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 0;

            int closedTripletsCount = 0;
            foreach (var meld in groupedMeldList)
            {
                if (meld.Type == MeldType.ClosedTriplet)
                {
                    closedTripletsCount++;
                }
            }

            if (closedTripletsCount >= 3)
            {
                resultHan = 2;
            }

            return resultHan;
        }
    }
}
