//auto generated, do not modify it

using MessagePack;
using System.Collections.Generic;

namespace Geek.Server.Proto
{
	[MessagePackObject(true)]
	public class ResBagInfo : Geek.Server.Message
	{
		[IgnoreMember]
		public const int Sid = -1516249246;

		[IgnoreMember]
		public const int MsgID = Sid;
		[IgnoreMember]
		public override int MsgId => MsgID;

        public Dictionary<int, long> ItemDic { get; set; } = new Dictionary<int, long>();
	}
}