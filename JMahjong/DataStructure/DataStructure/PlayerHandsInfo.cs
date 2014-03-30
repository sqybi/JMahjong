namespace JMahjong.General.DataStructure
{
    /// <summary>
    /// 和玩家相关的手牌信息
    /// </summary>
    public class PlayerHandsInfo
    {
        /// <summary>
        /// 牌面信息
        /// </summary>
        public HandsInfo Hands { get; set; }

        /// <summary>
        /// 玩家场况信息
        /// </summary>
        public PlayerSituationInfo Situation { get; set; }
    }
}
