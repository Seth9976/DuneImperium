using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001EF RID: 495
	public sealed class ConnectionInfo : ValueType
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x000795A0 File Offset: 0x000777A0
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionInfo()
		{
			Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ConnectionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr);
			ConnectionInfo.NativeFieldInfoPtr_identity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "identity");
			ConnectionInfo.NativeFieldInfoPtr_userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "userData");
			ConnectionInfo.NativeFieldInfoPtr_listenSocket = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "listenSocket");
			ConnectionInfo.NativeFieldInfoPtr_address = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "address");
			ConnectionInfo.NativeFieldInfoPtr_pad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "pad");
			ConnectionInfo.NativeFieldInfoPtr_popRemote = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "popRemote");
			ConnectionInfo.NativeFieldInfoPtr_popRelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "popRelay");
			ConnectionInfo.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "state");
			ConnectionInfo.NativeFieldInfoPtr_endReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "endReason");
			ConnectionInfo.NativeFieldInfoPtr_endDebug = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "endDebug");
			ConnectionInfo.NativeFieldInfoPtr_connectionDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, "connectionDescription");
			ConnectionInfo.NativeMethodInfoPtr_get_State_Public_get_ConnectionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, 100667869);
			ConnectionInfo.NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, 100667870);
			ConnectionInfo.NativeMethodInfoPtr_get_Identity_Public_get_NetIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, 100667871);
			ConnectionInfo.NativeMethodInfoPtr_get_EndReason_Public_get_NetConnectionEnd_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr, 100667872);
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000796FC File Offset: 0x000778FC
		public unsafe ConnectionState State
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionInfo.NativeMethodInfoPtr_get_State_Public_get_ConnectionState_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060018CB RID: 6347 RVA: 0x00079740 File Offset: 0x00077940
		public unsafe NetAddress Address
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionInfo.NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00079784 File Offset: 0x00077984
		public unsafe NetIdentity Identity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionInfo.NativeMethodInfoPtr_get_Identity_Public_get_NetIdentity_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x000797C8 File Offset: 0x000779C8
		public unsafe NetConnectionEnd EndReason
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionInfo.NativeMethodInfoPtr_get_EndReason_Public_get_NetConnectionEnd_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00007E7B File Offset: 0x0000607B
		public ConnectionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018CF RID: 6351 RVA: 0x00007E84 File Offset: 0x00006084
		public ConnectionInfo()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionInfo>.NativeClassPtr))
		{
		}

		// Token: 0x170005E4 RID: 1508
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0007980C File Offset: 0x00077A0C
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00007E96 File Offset: 0x00006096
		public unsafe NetIdentity identity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_identity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_identity)) = value;
			}
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x00079834 File Offset: 0x00077A34
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x00007EB1 File Offset: 0x000060B1
		public unsafe long userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_userData);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_userData)) = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060018D4 RID: 6356 RVA: 0x0007985C File Offset: 0x00077A5C
		// (set) Token: 0x060018D5 RID: 6357 RVA: 0x00007ECC File Offset: 0x000060CC
		public unsafe Socket listenSocket
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_listenSocket);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_listenSocket)) = value;
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060018D6 RID: 6358 RVA: 0x00079884 File Offset: 0x00077A84
		// (set) Token: 0x060018D7 RID: 6359 RVA: 0x00007EE7 File Offset: 0x000060E7
		public unsafe NetAddress address
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_address);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_address)) = value;
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060018D8 RID: 6360 RVA: 0x000798AC File Offset: 0x00077AAC
		// (set) Token: 0x060018D9 RID: 6361 RVA: 0x00007F02 File Offset: 0x00006102
		public unsafe ushort pad
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_pad);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_pad)) = value;
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060018DA RID: 6362 RVA: 0x000798D4 File Offset: 0x00077AD4
		// (set) Token: 0x060018DB RID: 6363 RVA: 0x00007F1D File Offset: 0x0000611D
		public unsafe SteamNetworkingPOPID popRemote
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_popRemote);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_popRemote)) = value;
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x060018DC RID: 6364 RVA: 0x000798FC File Offset: 0x00077AFC
		// (set) Token: 0x060018DD RID: 6365 RVA: 0x00007F38 File Offset: 0x00006138
		public unsafe SteamNetworkingPOPID popRelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_popRelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_popRelay)) = value;
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x00079924 File Offset: 0x00077B24
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x00007F53 File Offset: 0x00006153
		public unsafe ConnectionState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x0007994C File Offset: 0x00077B4C
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x00007F6E File Offset: 0x0000616E
		public unsafe int endReason
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_endReason);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_endReason)) = value;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060018E2 RID: 6370 RVA: 0x00079974 File Offset: 0x00077B74
		// (set) Token: 0x060018E3 RID: 6371 RVA: 0x00007F89 File Offset: 0x00006189
		public unsafe string endDebug
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_endDebug);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_endDebug), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060018E4 RID: 6372 RVA: 0x0007999C File Offset: 0x00077B9C
		// (set) Token: 0x060018E5 RID: 6373 RVA: 0x00007FA8 File Offset: 0x000061A8
		public unsafe string connectionDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_connectionDescription);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionInfo.NativeFieldInfoPtr_connectionDescription), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001E39 RID: 7737
		private static readonly IntPtr NativeFieldInfoPtr_identity;

		// Token: 0x04001E3A RID: 7738
		private static readonly IntPtr NativeFieldInfoPtr_userData;

		// Token: 0x04001E3B RID: 7739
		private static readonly IntPtr NativeFieldInfoPtr_listenSocket;

		// Token: 0x04001E3C RID: 7740
		private static readonly IntPtr NativeFieldInfoPtr_address;

		// Token: 0x04001E3D RID: 7741
		private static readonly IntPtr NativeFieldInfoPtr_pad;

		// Token: 0x04001E3E RID: 7742
		private static readonly IntPtr NativeFieldInfoPtr_popRemote;

		// Token: 0x04001E3F RID: 7743
		private static readonly IntPtr NativeFieldInfoPtr_popRelay;

		// Token: 0x04001E40 RID: 7744
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001E41 RID: 7745
		private static readonly IntPtr NativeFieldInfoPtr_endReason;

		// Token: 0x04001E42 RID: 7746
		private static readonly IntPtr NativeFieldInfoPtr_endDebug;

		// Token: 0x04001E43 RID: 7747
		private static readonly IntPtr NativeFieldInfoPtr_connectionDescription;

		// Token: 0x04001E44 RID: 7748
		private static readonly IntPtr NativeMethodInfoPtr_get_State_Public_get_ConnectionState_0;

		// Token: 0x04001E45 RID: 7749
		private static readonly IntPtr NativeMethodInfoPtr_get_Address_Public_get_NetAddress_0;

		// Token: 0x04001E46 RID: 7750
		private static readonly IntPtr NativeMethodInfoPtr_get_Identity_Public_get_NetIdentity_0;

		// Token: 0x04001E47 RID: 7751
		private static readonly IntPtr NativeMethodInfoPtr_get_EndReason_Public_get_NetConnectionEnd_0;
	}
}
