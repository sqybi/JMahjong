namespace JMahjong.ValueCalculation.Yaku
{
    using System.Collections.Generic;
    using System.Linq;
    using JMahjong.Shared.DataStructure;
    using JMahjong.Shared.Enum;

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

        public int GetHanByPlayerHands(PlayerHandsInfo playerHands, IList<MeldInfo> groupedMeldList)
        {
            int resultHan = 2;

            if (groupedMeldList.Any(
                    meld => meld.Type != MeldType.ClosedTriplet
                            && meld.Type != MeldType.OpenTriplet))
            {
                resultHan = 0;
            }

            return resultHan;
        }
    }
}
