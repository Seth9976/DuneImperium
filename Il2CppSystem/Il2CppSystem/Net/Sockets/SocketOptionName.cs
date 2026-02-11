using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200023E RID: 574
	[OriginalName("System.dll", "System.Net.Sockets", "SocketOptionName")]
	public enum SocketOptionName
	{
		// Token: 0x04001E4D RID: 7757
		Debug = 1,
		// Token: 0x04001E4E RID: 7758
		AcceptConnection,
		// Token: 0x04001E4F RID: 7759
		ReuseAddress = 4,
		// Token: 0x04001E50 RID: 7760
		KeepAlive = 8,
		// Token: 0x04001E51 RID: 7761
		DontRoute = 16,
		// Token: 0x04001E52 RID: 7762
		Broadcast = 32,
		// Token: 0x04001E53 RID: 7763
		UseLoopback = 64,
		// Token: 0x04001E54 RID: 7764
		Linger = 128,
		// Token: 0x04001E55 RID: 7765
		OutOfBandInline = 256,
		// Token: 0x04001E56 RID: 7766
		DontLinger = -129,
		// Token: 0x04001E57 RID: 7767
		ExclusiveAddressUse = -5,
		// Token: 0x04001E58 RID: 7768
		SendBuffer = 4097,
		// Token: 0x04001E59 RID: 7769
		ReceiveBuffer,
		// Token: 0x04001E5A RID: 7770
		SendLowWater,
		// Token: 0x04001E5B RID: 7771
		ReceiveLowWater,
		// Token: 0x04001E5C RID: 7772
		SendTimeout,
		// Token: 0x04001E5D RID: 7773
		ReceiveTimeout,
		// Token: 0x04001E5E RID: 7774
		Error,
		// Token: 0x04001E5F RID: 7775
		Type,
		// Token: 0x04001E60 RID: 7776
		ReuseUnicastPort = 12295,
		// Token: 0x04001E61 RID: 7777
		MaxConnections = 2147483647,
		// Token: 0x04001E62 RID: 7778
		IPOptions = 1,
		// Token: 0x04001E63 RID: 7779
		HeaderIncluded,
		// Token: 0x04001E64 RID: 7780
		TypeOfService,
		// Token: 0x04001E65 RID: 7781
		IpTimeToLive,
		// Token: 0x04001E66 RID: 7782
		MulticastInterface = 9,
		// Token: 0x04001E67 RID: 7783
		MulticastTimeToLive,
		// Token: 0x04001E68 RID: 7784
		MulticastLoopback,
		// Token: 0x04001E69 RID: 7785
		AddMembership,
		// Token: 0x04001E6A RID: 7786
		DropMembership,
		// Token: 0x04001E6B RID: 7787
		DontFragment,
		// Token: 0x04001E6C RID: 7788
		AddSourceMembership,
		// Token: 0x04001E6D RID: 7789
		DropSourceMembership,
		// Token: 0x04001E6E RID: 7790
		BlockSource,
		// Token: 0x04001E6F RID: 7791
		UnblockSource,
		// Token: 0x04001E70 RID: 7792
		PacketInformation,
		// Token: 0x04001E71 RID: 7793
		HopLimit = 21,
		// Token: 0x04001E72 RID: 7794
		IPProtectionLevel = 23,
		// Token: 0x04001E73 RID: 7795
		IPv6Only = 27,
		// Token: 0x04001E74 RID: 7796
		NoDelay = 1,
		// Token: 0x04001E75 RID: 7797
		BsdUrgent,
		// Token: 0x04001E76 RID: 7798
		Expedited = 2,
		// Token: 0x04001E77 RID: 7799
		NoChecksum = 1,
		// Token: 0x04001E78 RID: 7800
		ChecksumCoverage = 20,
		// Token: 0x04001E79 RID: 7801
		UpdateAcceptContext = 28683,
		// Token: 0x04001E7A RID: 7802
		UpdateConnectContext = 28688
	}
}
