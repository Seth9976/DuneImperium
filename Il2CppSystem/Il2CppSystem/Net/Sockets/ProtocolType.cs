using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000238 RID: 568
	[OriginalName("System.dll", "System.Net.Sockets", "ProtocolType")]
	public enum ProtocolType
	{
		// Token: 0x04001DE3 RID: 7651
		IP,
		// Token: 0x04001DE4 RID: 7652
		IPv6HopByHopOptions = 0,
		// Token: 0x04001DE5 RID: 7653
		Icmp,
		// Token: 0x04001DE6 RID: 7654
		Igmp,
		// Token: 0x04001DE7 RID: 7655
		Ggp,
		// Token: 0x04001DE8 RID: 7656
		IPv4,
		// Token: 0x04001DE9 RID: 7657
		Tcp = 6,
		// Token: 0x04001DEA RID: 7658
		Pup = 12,
		// Token: 0x04001DEB RID: 7659
		Udp = 17,
		// Token: 0x04001DEC RID: 7660
		Idp = 22,
		// Token: 0x04001DED RID: 7661
		IPv6 = 41,
		// Token: 0x04001DEE RID: 7662
		IPv6RoutingHeader = 43,
		// Token: 0x04001DEF RID: 7663
		IPv6FragmentHeader,
		// Token: 0x04001DF0 RID: 7664
		IPSecEncapsulatingSecurityPayload = 50,
		// Token: 0x04001DF1 RID: 7665
		IPSecAuthenticationHeader,
		// Token: 0x04001DF2 RID: 7666
		IcmpV6 = 58,
		// Token: 0x04001DF3 RID: 7667
		IPv6NoNextHeader,
		// Token: 0x04001DF4 RID: 7668
		IPv6DestinationOptions,
		// Token: 0x04001DF5 RID: 7669
		ND = 77,
		// Token: 0x04001DF6 RID: 7670
		Raw = 255,
		// Token: 0x04001DF7 RID: 7671
		Unspecified = 0,
		// Token: 0x04001DF8 RID: 7672
		Ipx = 1000,
		// Token: 0x04001DF9 RID: 7673
		Spx = 1256,
		// Token: 0x04001DFA RID: 7674
		SpxII,
		// Token: 0x04001DFB RID: 7675
		Unknown = -1
	}
}
