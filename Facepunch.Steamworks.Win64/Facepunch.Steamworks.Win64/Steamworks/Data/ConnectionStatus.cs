using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F1 RID: 497
	public sealed class ConnectionStatus : ValueType
	{
		// Token: 0x060018F8 RID: 6392 RVA: 0x00079C6C File Offset: 0x00077E6C
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionStatus()
		{
			Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ConnectionStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr);
			ConnectionStatus.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "state");
			ConnectionStatus.NativeFieldInfoPtr_ping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "ping");
			ConnectionStatus.NativeFieldInfoPtr_connectionQualityLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "connectionQualityLocal");
			ConnectionStatus.NativeFieldInfoPtr_connectionQualityRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "connectionQualityRemote");
			ConnectionStatus.NativeFieldInfoPtr_outPacketsPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "outPacketsPerSec");
			ConnectionStatus.NativeFieldInfoPtr_outBytesPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "outBytesPerSec");
			ConnectionStatus.NativeFieldInfoPtr_inPacketsPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "inPacketsPerSec");
			ConnectionStatus.NativeFieldInfoPtr_inBytesPerSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "inBytesPerSec");
			ConnectionStatus.NativeFieldInfoPtr_sendRateBytesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "sendRateBytesPerSecond");
			ConnectionStatus.NativeFieldInfoPtr_cbPendingUnreliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "cbPendingUnreliable");
			ConnectionStatus.NativeFieldInfoPtr_cbPendingReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "cbPendingReliable");
			ConnectionStatus.NativeFieldInfoPtr_cbSentUnackedReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "cbSentUnackedReliable");
			ConnectionStatus.NativeFieldInfoPtr_ecQueueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "ecQueueTime");
			ConnectionStatus.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, "reserved");
			ConnectionStatus.NativeMethodInfoPtr_get_Ping_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667876);
			ConnectionStatus.NativeMethodInfoPtr_get_OutPacketsPerSec_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667877);
			ConnectionStatus.NativeMethodInfoPtr_get_OutBytesPerSec_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667878);
			ConnectionStatus.NativeMethodInfoPtr_get_InPacketsPerSec_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667879);
			ConnectionStatus.NativeMethodInfoPtr_get_InBytesPerSec_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667880);
			ConnectionStatus.NativeMethodInfoPtr_get_ConnectionQualityLocal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667881);
			ConnectionStatus.NativeMethodInfoPtr_get_ConnectionQualityRemote_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667882);
			ConnectionStatus.NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667883);
			ConnectionStatus.NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667884);
			ConnectionStatus.NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr, 100667885);
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x00079E7C File Offset: 0x0007807C
		public unsafe int Ping
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_Ping_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x00079EC0 File Offset: 0x000780C0
		public unsafe float OutPacketsPerSec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_OutPacketsPerSec_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060018FB RID: 6395 RVA: 0x00079F04 File Offset: 0x00078104
		public unsafe float OutBytesPerSec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_OutBytesPerSec_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060018FC RID: 6396 RVA: 0x00079F48 File Offset: 0x00078148
		public unsafe float InPacketsPerSec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_InPacketsPerSec_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060018FD RID: 6397 RVA: 0x00079F8C File Offset: 0x0007818C
		public unsafe float InBytesPerSec
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_InBytesPerSec_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060018FE RID: 6398 RVA: 0x00079FD0 File Offset: 0x000781D0
		public unsafe float ConnectionQualityLocal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_ConnectionQualityLocal_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060018FF RID: 6399 RVA: 0x0007A014 File Offset: 0x00078214
		public unsafe float ConnectionQualityRemote
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_ConnectionQualityRemote_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x06001900 RID: 6400 RVA: 0x0007A058 File Offset: 0x00078258
		public unsafe int PendingUnreliable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x06001901 RID: 6401 RVA: 0x0007A09C File Offset: 0x0007829C
		public unsafe int PendingReliable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x0007A0E0 File Offset: 0x000782E0
		public unsafe int SentUnackedReliable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionStatus.NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00008088 File Offset: 0x00006288
		public ConnectionStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00008091 File Offset: 0x00006291
		public ConnectionStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionStatus>.NativeClassPtr))
		{
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001905 RID: 6405 RVA: 0x0007A124 File Offset: 0x00078324
		// (set) Token: 0x06001906 RID: 6406 RVA: 0x000080A3 File Offset: 0x000062A3
		public unsafe ConnectionState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001907 RID: 6407 RVA: 0x0007A14C File Offset: 0x0007834C
		// (set) Token: 0x06001908 RID: 6408 RVA: 0x000080BE File Offset: 0x000062BE
		public unsafe int ping
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_ping);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_ping)) = value;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001909 RID: 6409 RVA: 0x0007A174 File Offset: 0x00078374
		// (set) Token: 0x0600190A RID: 6410 RVA: 0x000080D9 File Offset: 0x000062D9
		public unsafe float connectionQualityLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_connectionQualityLocal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_connectionQualityLocal)) = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x0600190B RID: 6411 RVA: 0x0007A19C File Offset: 0x0007839C
		// (set) Token: 0x0600190C RID: 6412 RVA: 0x000080F4 File Offset: 0x000062F4
		public unsafe float connectionQualityRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_connectionQualityRemote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_connectionQualityRemote)) = value;
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600190D RID: 6413 RVA: 0x0007A1C4 File Offset: 0x000783C4
		// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000810F File Offset: 0x0000630F
		public unsafe float outPacketsPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_outPacketsPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_outPacketsPerSec)) = value;
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600190F RID: 6415 RVA: 0x0007A1EC File Offset: 0x000783EC
		// (set) Token: 0x06001910 RID: 6416 RVA: 0x0000812A File Offset: 0x0000632A
		public unsafe float outBytesPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_outBytesPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_outBytesPerSec)) = value;
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x0007A214 File Offset: 0x00078414
		// (set) Token: 0x06001912 RID: 6418 RVA: 0x00008145 File Offset: 0x00006345
		public unsafe float inPacketsPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_inPacketsPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_inPacketsPerSec)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001913 RID: 6419 RVA: 0x0007A23C File Offset: 0x0007843C
		// (set) Token: 0x06001914 RID: 6420 RVA: 0x00008160 File Offset: 0x00006360
		public unsafe float inBytesPerSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_inBytesPerSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_inBytesPerSec)) = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001915 RID: 6421 RVA: 0x0007A264 File Offset: 0x00078464
		// (set) Token: 0x06001916 RID: 6422 RVA: 0x0000817B File Offset: 0x0000637B
		public unsafe int sendRateBytesPerSecond
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_sendRateBytesPerSecond);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_sendRateBytesPerSecond)) = value;
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x06001917 RID: 6423 RVA: 0x0007A28C File Offset: 0x0007848C
		// (set) Token: 0x06001918 RID: 6424 RVA: 0x00008196 File Offset: 0x00006396
		public unsafe int cbPendingUnreliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbPendingUnreliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbPendingUnreliable)) = value;
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001919 RID: 6425 RVA: 0x0007A2B4 File Offset: 0x000784B4
		// (set) Token: 0x0600191A RID: 6426 RVA: 0x000081B1 File Offset: 0x000063B1
		public unsafe int cbPendingReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbPendingReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbPendingReliable)) = value;
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x0600191B RID: 6427 RVA: 0x0007A2DC File Offset: 0x000784DC
		// (set) Token: 0x0600191C RID: 6428 RVA: 0x000081CC File Offset: 0x000063CC
		public unsafe int cbSentUnackedReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbSentUnackedReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_cbSentUnackedReliable)) = value;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x0600191D RID: 6429 RVA: 0x0007A304 File Offset: 0x00078504
		// (set) Token: 0x0600191E RID: 6430 RVA: 0x000081E7 File Offset: 0x000063E7
		public unsafe long ecQueueTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_ecQueueTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_ecQueueTime)) = value;
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x0600191F RID: 6431 RVA: 0x0007A32C File Offset: 0x0007852C
		// (set) Token: 0x06001920 RID: 6432 RVA: 0x00008202 File Offset: 0x00006402
		public unsafe Il2CppStructArray<uint> reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_reserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionStatus.NativeFieldInfoPtr_reserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E51 RID: 7761
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001E52 RID: 7762
		private static readonly IntPtr NativeFieldInfoPtr_ping;

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeFieldInfoPtr_connectionQualityLocal;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeFieldInfoPtr_connectionQualityRemote;

		// Token: 0x04001E55 RID: 7765
		private static readonly IntPtr NativeFieldInfoPtr_outPacketsPerSec;

		// Token: 0x04001E56 RID: 7766
		private static readonly IntPtr NativeFieldInfoPtr_outBytesPerSec;

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeFieldInfoPtr_inPacketsPerSec;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeFieldInfoPtr_inBytesPerSec;

		// Token: 0x04001E59 RID: 7769
		private static readonly IntPtr NativeFieldInfoPtr_sendRateBytesPerSecond;

		// Token: 0x04001E5A RID: 7770
		private static readonly IntPtr NativeFieldInfoPtr_cbPendingUnreliable;

		// Token: 0x04001E5B RID: 7771
		private static readonly IntPtr NativeFieldInfoPtr_cbPendingReliable;

		// Token: 0x04001E5C RID: 7772
		private static readonly IntPtr NativeFieldInfoPtr_cbSentUnackedReliable;

		// Token: 0x04001E5D RID: 7773
		private static readonly IntPtr NativeFieldInfoPtr_ecQueueTime;

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_get_Ping_Public_get_Int32_0;

		// Token: 0x04001E60 RID: 7776
		private static readonly IntPtr NativeMethodInfoPtr_get_OutPacketsPerSec_Public_get_Single_0;

		// Token: 0x04001E61 RID: 7777
		private static readonly IntPtr NativeMethodInfoPtr_get_OutBytesPerSec_Public_get_Single_0;

		// Token: 0x04001E62 RID: 7778
		private static readonly IntPtr NativeMethodInfoPtr_get_InPacketsPerSec_Public_get_Single_0;

		// Token: 0x04001E63 RID: 7779
		private static readonly IntPtr NativeMethodInfoPtr_get_InBytesPerSec_Public_get_Single_0;

		// Token: 0x04001E64 RID: 7780
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionQualityLocal_Public_get_Single_0;

		// Token: 0x04001E65 RID: 7781
		private static readonly IntPtr NativeMethodInfoPtr_get_ConnectionQualityRemote_Public_get_Single_0;

		// Token: 0x04001E66 RID: 7782
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0;

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0;
	}
}
