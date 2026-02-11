using System;

namespace Steamworks
{
	// Token: 0x0200008A RID: 138
	public enum NetConnectionEnd
	{
		// Token: 0x04000EC6 RID: 3782
		Invalid,
		// Token: 0x04000EC7 RID: 3783
		App_Min = 1000,
		// Token: 0x04000EC8 RID: 3784
		App_Generic = 1000,
		// Token: 0x04000EC9 RID: 3785
		App_Max = 1999,
		// Token: 0x04000ECA RID: 3786
		AppException_Min,
		// Token: 0x04000ECB RID: 3787
		AppException_Generic = 2000,
		// Token: 0x04000ECC RID: 3788
		AppException_Max = 2999,
		// Token: 0x04000ECD RID: 3789
		Local_Min,
		// Token: 0x04000ECE RID: 3790
		Local_OfflineMode,
		// Token: 0x04000ECF RID: 3791
		Local_ManyRelayConnectivity,
		// Token: 0x04000ED0 RID: 3792
		Local_HostedServerPrimaryRelay,
		// Token: 0x04000ED1 RID: 3793
		Local_NetworkConfig,
		// Token: 0x04000ED2 RID: 3794
		Local_Rights,
		// Token: 0x04000ED3 RID: 3795
		Local_P2P_ICE_NoPublicAddresses,
		// Token: 0x04000ED4 RID: 3796
		Local_Max = 3999,
		// Token: 0x04000ED5 RID: 3797
		Remote_Min,
		// Token: 0x04000ED6 RID: 3798
		Remote_Timeout,
		// Token: 0x04000ED7 RID: 3799
		Remote_BadCrypt,
		// Token: 0x04000ED8 RID: 3800
		Remote_BadCert,
		// Token: 0x04000ED9 RID: 3801
		Remote_BadProtocolVersion = 4006,
		// Token: 0x04000EDA RID: 3802
		Remote_P2P_ICE_NoPublicAddresses,
		// Token: 0x04000EDB RID: 3803
		Remote_Max = 4999,
		// Token: 0x04000EDC RID: 3804
		Misc_Min,
		// Token: 0x04000EDD RID: 3805
		Misc_Generic,
		// Token: 0x04000EDE RID: 3806
		Misc_InternalError,
		// Token: 0x04000EDF RID: 3807
		Misc_Timeout,
		// Token: 0x04000EE0 RID: 3808
		Misc_SteamConnectivity = 5005,
		// Token: 0x04000EE1 RID: 3809
		Misc_NoRelaySessionsToClient,
		// Token: 0x04000EE2 RID: 3810
		Misc_P2P_Rendezvous = 5008,
		// Token: 0x04000EE3 RID: 3811
		Misc_P2P_NAT_Firewall,
		// Token: 0x04000EE4 RID: 3812
		Misc_PeerSentNoConnection,
		// Token: 0x04000EE5 RID: 3813
		Misc_Max = 5999
	}
}
