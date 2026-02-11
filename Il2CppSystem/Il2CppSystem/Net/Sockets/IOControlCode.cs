using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000234 RID: 564
	[OriginalName("System.dll", "System.Net.Sockets", "IOControlCode")]
	public enum IOControlCode : long
	{
		// Token: 0x04001DB6 RID: 7606
		AsyncIO = 2147772029L,
		// Token: 0x04001DB7 RID: 7607
		NonBlockingIO,
		// Token: 0x04001DB8 RID: 7608
		DataToRead = 1074030207L,
		// Token: 0x04001DB9 RID: 7609
		OobDataRead = 1074033415L,
		// Token: 0x04001DBA RID: 7610
		AssociateHandle = 2281701377L,
		// Token: 0x04001DBB RID: 7611
		EnableCircularQueuing = 671088642L,
		// Token: 0x04001DBC RID: 7612
		Flush = 671088644L,
		// Token: 0x04001DBD RID: 7613
		GetBroadcastAddress = 1207959557L,
		// Token: 0x04001DBE RID: 7614
		GetExtensionFunctionPointer = 3355443206L,
		// Token: 0x04001DBF RID: 7615
		GetQos,
		// Token: 0x04001DC0 RID: 7616
		GetGroupQos,
		// Token: 0x04001DC1 RID: 7617
		MultipointLoopback = 2281701385L,
		// Token: 0x04001DC2 RID: 7618
		MulticastScope,
		// Token: 0x04001DC3 RID: 7619
		SetQos,
		// Token: 0x04001DC4 RID: 7620
		SetGroupQos,
		// Token: 0x04001DC5 RID: 7621
		TranslateHandle = 3355443213L,
		// Token: 0x04001DC6 RID: 7622
		RoutingInterfaceQuery = 3355443220L,
		// Token: 0x04001DC7 RID: 7623
		RoutingInterfaceChange = 2281701397L,
		// Token: 0x04001DC8 RID: 7624
		AddressListQuery = 1207959574L,
		// Token: 0x04001DC9 RID: 7625
		AddressListChange = 671088663L,
		// Token: 0x04001DCA RID: 7626
		QueryTargetPnpHandle = 1207959576L,
		// Token: 0x04001DCB RID: 7627
		NamespaceChange = 2281701401L,
		// Token: 0x04001DCC RID: 7628
		AddressListSort = 3355443225L,
		// Token: 0x04001DCD RID: 7629
		ReceiveAll = 2550136833L,
		// Token: 0x04001DCE RID: 7630
		ReceiveAllMulticast,
		// Token: 0x04001DCF RID: 7631
		ReceiveAllIgmpMulticast,
		// Token: 0x04001DD0 RID: 7632
		KeepAliveValues,
		// Token: 0x04001DD1 RID: 7633
		AbsorbRouterAlert,
		// Token: 0x04001DD2 RID: 7634
		UnicastInterface,
		// Token: 0x04001DD3 RID: 7635
		LimitBroadcasts,
		// Token: 0x04001DD4 RID: 7636
		BindToInterface,
		// Token: 0x04001DD5 RID: 7637
		MulticastInterface,
		// Token: 0x04001DD6 RID: 7638
		AddMulticastGroupOnInterface,
		// Token: 0x04001DD7 RID: 7639
		DeleteMulticastGroupFromInterface
	}
}
