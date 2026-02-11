using System;

namespace Steamworks
{
	// Token: 0x0200008D RID: 141
	public enum NetConfig
	{
		// Token: 0x04000EF2 RID: 3826
		Invalid,
		// Token: 0x04000EF3 RID: 3827
		TimeoutInitial = 24,
		// Token: 0x04000EF4 RID: 3828
		TimeoutConnected,
		// Token: 0x04000EF5 RID: 3829
		SendBufferSize = 9,
		// Token: 0x04000EF6 RID: 3830
		ConnectionUserData = 40,
		// Token: 0x04000EF7 RID: 3831
		SendRateMin = 10,
		// Token: 0x04000EF8 RID: 3832
		SendRateMax,
		// Token: 0x04000EF9 RID: 3833
		NagleTime,
		// Token: 0x04000EFA RID: 3834
		IP_AllowWithoutAuth = 23,
		// Token: 0x04000EFB RID: 3835
		MTU_PacketSize = 32,
		// Token: 0x04000EFC RID: 3836
		MTU_DataSize,
		// Token: 0x04000EFD RID: 3837
		Unencrypted,
		// Token: 0x04000EFE RID: 3838
		SymmetricConnect = 37,
		// Token: 0x04000EFF RID: 3839
		LocalVirtualPort,
		// Token: 0x04000F00 RID: 3840
		DualWifi_Enable,
		// Token: 0x04000F01 RID: 3841
		EnableDiagnosticsUI = 46,
		// Token: 0x04000F02 RID: 3842
		FakePacketLoss_Send = 2,
		// Token: 0x04000F03 RID: 3843
		FakePacketLoss_Recv,
		// Token: 0x04000F04 RID: 3844
		FakePacketLag_Send,
		// Token: 0x04000F05 RID: 3845
		FakePacketLag_Recv,
		// Token: 0x04000F06 RID: 3846
		FakePacketReorder_Send,
		// Token: 0x04000F07 RID: 3847
		FakePacketReorder_Recv,
		// Token: 0x04000F08 RID: 3848
		FakePacketReorder_Time,
		// Token: 0x04000F09 RID: 3849
		FakePacketDup_Send = 26,
		// Token: 0x04000F0A RID: 3850
		FakePacketDup_Recv,
		// Token: 0x04000F0B RID: 3851
		FakePacketDup_TimeMax,
		// Token: 0x04000F0C RID: 3852
		PacketTraceMaxBytes = 41,
		// Token: 0x04000F0D RID: 3853
		FakeRateLimit_Send_Rate,
		// Token: 0x04000F0E RID: 3854
		FakeRateLimit_Send_Burst,
		// Token: 0x04000F0F RID: 3855
		FakeRateLimit_Recv_Rate,
		// Token: 0x04000F10 RID: 3856
		FakeRateLimit_Recv_Burst,
		// Token: 0x04000F11 RID: 3857
		Callback_ConnectionStatusChanged = 201,
		// Token: 0x04000F12 RID: 3858
		Callback_AuthStatusChanged,
		// Token: 0x04000F13 RID: 3859
		Callback_RelayNetworkStatusChanged,
		// Token: 0x04000F14 RID: 3860
		Callback_MessagesSessionRequest,
		// Token: 0x04000F15 RID: 3861
		Callback_MessagesSessionFailed,
		// Token: 0x04000F16 RID: 3862
		Callback_CreateConnectionSignaling,
		// Token: 0x04000F17 RID: 3863
		Callback_FakeIPResult,
		// Token: 0x04000F18 RID: 3864
		P2P_STUN_ServerList = 103,
		// Token: 0x04000F19 RID: 3865
		P2P_Transport_ICE_Enable,
		// Token: 0x04000F1A RID: 3866
		P2P_Transport_ICE_Penalty,
		// Token: 0x04000F1B RID: 3867
		P2P_Transport_SDR_Penalty,
		// Token: 0x04000F1C RID: 3868
		SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		// Token: 0x04000F1D RID: 3869
		SDRClient_ConsecutitivePingTimeoutsFail,
		// Token: 0x04000F1E RID: 3870
		SDRClient_MinPingsBeforePingAccurate,
		// Token: 0x04000F1F RID: 3871
		SDRClient_SingleSocket,
		// Token: 0x04000F20 RID: 3872
		SDRClient_ForceRelayCluster = 29,
		// Token: 0x04000F21 RID: 3873
		SDRClient_DebugTicketAddress,
		// Token: 0x04000F22 RID: 3874
		SDRClient_ForceProxyAddr,
		// Token: 0x04000F23 RID: 3875
		SDRClient_FakeClusterPing = 36,
		// Token: 0x04000F24 RID: 3876
		LogLevel_AckRTT = 13,
		// Token: 0x04000F25 RID: 3877
		LogLevel_PacketDecode,
		// Token: 0x04000F26 RID: 3878
		LogLevel_Message,
		// Token: 0x04000F27 RID: 3879
		LogLevel_PacketGaps,
		// Token: 0x04000F28 RID: 3880
		LogLevel_P2PRendezvous,
		// Token: 0x04000F29 RID: 3881
		LogLevel_SDRRelayPings,
		// Token: 0x04000F2A RID: 3882
		DELETED_EnumerateDevVars = 35
	}
}
