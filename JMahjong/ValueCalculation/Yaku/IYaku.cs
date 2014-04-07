using System.Collections.Generic;
using JMahjong.General.DataStructure;

namespace JMahjong.ValueCalculation.Yaku
{
    /// <summary>
    /// 役的接口
    /// </summary>
    public interface IYaku
    {
        /// <summary>
        /// 根据玩家手牌情况计算对应番数
        /// </summary>
        /// <param name="playerHands">玩家的完整手牌情况</param>
        /// <param name="groupedMeldList">分组后的手牌</param>
        /// <returns>该役应得的番数，0为无此役</returns>
        int GetHanByPlayerHands(PlayerHandsInfo playerHands, List<MeldInfo> groupedMeldList);
    }
}
