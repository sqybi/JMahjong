using System.Collections.Generic;
using JMahjong.General.DataStructure;
using JMahjong.General.Enum;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 对对和（toitoihou）
    /// </summary>
    public class AllTripletHandYaku : IYaku
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public AllTripletHandYaku()
        {
        }

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList)
        {
            int resultHan = 2;

            foreach (var meld in groupedMeldList)
            {
                if (meld.Type != MeldType.ClosedTriplet
                    && meld.Type != MeldType.OpenTriplet)
                {
                    resultHan = 0;
                    break;
                }
            }

            return resultHan;
        }
    }
}
