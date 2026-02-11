using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F0 RID: 496
	public sealed class ConnectionLaneStatus : ValueType
	{
		// Token: 0x060018E6 RID: 6374 RVA: 0x000799C4 File Offset: 0x00077BC4
		// Note: this type is marked as 'beforefieldinit'.
		static ConnectionLaneStatus()
		{
			Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ConnectionLaneStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr);
			ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingUnreliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "cbPendingUnreliable");
			ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "cbPendingReliable");
			ConnectionLaneStatus.NativeFieldInfoPtr_cbSentUnackedReliable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "cbSentUnackedReliable");
			ConnectionLaneStatus.NativeFieldInfoPtr__reservePad1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "_reservePad1");
			ConnectionLaneStatus.NativeFieldInfoPtr_ecQueueTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "ecQueueTime");
			ConnectionLaneStatus.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, "reserved");
			ConnectionLaneStatus.NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, 100667873);
			ConnectionLaneStatus.NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, 100667874);
			ConnectionLaneStatus.NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr, 100667875);
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060018E7 RID: 6375 RVA: 0x00079AA8 File Offset: 0x00077CA8
		public unsafe int PendingUnreliable
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionLaneStatus.NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060018E8 RID: 6376 RVA: 0x00079AEC File Offset: 0x00077CEC
		public unsafe int PendingReliable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionLaneStatus.NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060018E9 RID: 6377 RVA: 0x00079B30 File Offset: 0x00077D30
		public unsafe int SentUnackedReliable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConnectionLaneStatus.NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00007FC7 File Offset: 0x000061C7
		public ConnectionLaneStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00007FD0 File Offset: 0x000061D0
		public ConnectionLaneStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConnectionLaneStatus>.NativeClassPtr))
		{
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x00079B74 File Offset: 0x00077D74
		// (set) Token: 0x060018ED RID: 6381 RVA: 0x00007FE2 File Offset: 0x000061E2
		public unsafe int cbPendingUnreliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingUnreliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingUnreliable)) = value;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x00079B9C File Offset: 0x00077D9C
		// (set) Token: 0x060018EF RID: 6383 RVA: 0x00007FFD File Offset: 0x000061FD
		public unsafe int cbPendingReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbPendingReliable)) = value;
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00079BC4 File Offset: 0x00077DC4
		// (set) Token: 0x060018F1 RID: 6385 RVA: 0x00008018 File Offset: 0x00006218
		public unsafe int cbSentUnackedReliable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbSentUnackedReliable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_cbSentUnackedReliable)) = value;
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00079BEC File Offset: 0x00077DEC
		// (set) Token: 0x060018F3 RID: 6387 RVA: 0x00008033 File Offset: 0x00006233
		public unsafe int _reservePad1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr__reservePad1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr__reservePad1)) = value;
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x00079C14 File Offset: 0x00077E14
		// (set) Token: 0x060018F5 RID: 6389 RVA: 0x0000804E File Offset: 0x0000624E
		public unsafe long ecQueueTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_ecQueueTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_ecQueueTime)) = value;
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x00079C3C File Offset: 0x00077E3C
		// (set) Token: 0x060018F7 RID: 6391 RVA: 0x00008069 File Offset: 0x00006269
		public unsafe Il2CppStructArray<uint> reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_reserved);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConnectionLaneStatus.NativeFieldInfoPtr_reserved), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E48 RID: 7752
		private static readonly IntPtr NativeFieldInfoPtr_cbPendingUnreliable;

		// Token: 0x04001E49 RID: 7753
		private static readonly IntPtr NativeFieldInfoPtr_cbPendingReliable;

		// Token: 0x04001E4A RID: 7754
		private static readonly IntPtr NativeFieldInfoPtr_cbSentUnackedReliable;

		// Token: 0x04001E4B RID: 7755
		private static readonly IntPtr NativeFieldInfoPtr__reservePad1;

		// Token: 0x04001E4C RID: 7756
		private static readonly IntPtr NativeFieldInfoPtr_ecQueueTime;

		// Token: 0x04001E4D RID: 7757
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x04001E4E RID: 7758
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingUnreliable_Public_get_Int32_0;

		// Token: 0x04001E4F RID: 7759
		private static readonly IntPtr NativeMethodInfoPtr_get_PendingReliable_Public_get_Int32_0;

		// Token: 0x04001E50 RID: 7760
		private static readonly IntPtr NativeMethodInfoPtr_get_SentUnackedReliable_Public_get_Int32_0;
	}
}
