using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x0200023B RID: 571
	[OriginalName("System.dll", "System.Net.Sockets", "SocketError")]
	public enum SocketError
	{
		// Token: 0x04001E0C RID: 7692
		Success,
		// Token: 0x04001E0D RID: 7693
		SocketError = -1,
		// Token: 0x04001E0E RID: 7694
		Interrupted = 10004,
		// Token: 0x04001E0F RID: 7695
		AccessDenied = 10013,
		// Token: 0x04001E10 RID: 7696
		Fault,
		// Token: 0x04001E11 RID: 7697
		InvalidArgument = 10022,
		// Token: 0x04001E12 RID: 7698
		TooManyOpenSockets = 10024,
		// Token: 0x04001E13 RID: 7699
		WouldBlock = 10035,
		// Token: 0x04001E14 RID: 7700
		InProgress,
		// Token: 0x04001E15 RID: 7701
		AlreadyInProgress,
		// Token: 0x04001E16 RID: 7702
		NotSocket,
		// Token: 0x04001E17 RID: 7703
		DestinationAddressRequired,
		// Token: 0x04001E18 RID: 7704
		MessageSize,
		// Token: 0x04001E19 RID: 7705
		ProtocolType,
		// Token: 0x04001E1A RID: 7706
		ProtocolOption,
		// Token: 0x04001E1B RID: 7707
		ProtocolNotSupported,
		// Token: 0x04001E1C RID: 7708
		SocketNotSupported,
		// Token: 0x04001E1D RID: 7709
		OperationNotSupported,
		// Token: 0x04001E1E RID: 7710
		ProtocolFamilyNotSupported,
		// Token: 0x04001E1F RID: 7711
		AddressFamilyNotSupported,
		// Token: 0x04001E20 RID: 7712
		AddressAlreadyInUse,
		// Token: 0x04001E21 RID: 7713
		AddressNotAvailable,
		// Token: 0x04001E22 RID: 7714
		NetworkDown,
		// Token: 0x04001E23 RID: 7715
		NetworkUnreachable,
		// Token: 0x04001E24 RID: 7716
		NetworkReset,
		// Token: 0x04001E25 RID: 7717
		ConnectionAborted,
		// Token: 0x04001E26 RID: 7718
		ConnectionReset,
		// Token: 0x04001E27 RID: 7719
		NoBufferSpaceAvailable,
		// Token: 0x04001E28 RID: 7720
		IsConnected,
		// Token: 0x04001E29 RID: 7721
		NotConnected,
		// Token: 0x04001E2A RID: 7722
		Shutdown,
		// Token: 0x04001E2B RID: 7723
		TimedOut = 10060,
		// Token: 0x04001E2C RID: 7724
		ConnectionRefused,
		// Token: 0x04001E2D RID: 7725
		HostDown = 10064,
		// Token: 0x04001E2E RID: 7726
		HostUnreachable,
		// Token: 0x04001E2F RID: 7727
		ProcessLimit = 10067,
		// Token: 0x04001E30 RID: 7728
		SystemNotReady = 10091,
		// Token: 0x04001E31 RID: 7729
		VersionNotSupported,
		// Token: 0x04001E32 RID: 7730
		NotInitialized,
		// Token: 0x04001E33 RID: 7731
		Disconnecting = 10101,
		// Token: 0x04001E34 RID: 7732
		TypeNotFound = 10109,
		// Token: 0x04001E35 RID: 7733
		HostNotFound = 11001,
		// Token: 0x04001E36 RID: 7734
		TryAgain,
		// Token: 0x04001E37 RID: 7735
		NoRecovery,
		// Token: 0x04001E38 RID: 7736
		NoData,
		// Token: 0x04001E39 RID: 7737
		IOPending = 997,
		// Token: 0x04001E3A RID: 7738
		OperationAborted = 995
	}
}
