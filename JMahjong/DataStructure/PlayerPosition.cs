using System.Globalization;

namespace JMahjong.DataStructure
{
    /// <summary>
    /// 玩家相对位置
    /// </summary>
    public enum PlayerRelativePosition
    {
        Self,
        Right,
        Opposite,
        Left
    }

    /// <summary>
    /// 玩家绝对位置
    /// </summary>
    public enum PlayerAbsolutePosition
    {
        East,
        South,
        West,
        North
    }
}
