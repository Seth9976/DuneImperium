using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dbgclient.data
{
	// Token: 0x020000CF RID: 207
	public class FriendOnlineStatusData : DataComponent
	{
		// Token: 0x060008CE RID: 2254 RVA: 0x000392D4 File Offset: 0x000374D4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendOnlineStatusData()
		{
			Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "FriendOnlineStatusData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr);
			FriendOnlineStatusData.NativeFieldInfoPtr__IsOnline_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr, "<IsOnline>k__BackingField");
			FriendOnlineStatusData.NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr, 100664569);
			FriendOnlineStatusData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr, 100664570);
			FriendOnlineStatusData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr, 100664571);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00039354 File Offset: 0x00037554
		public unsafe bool IsOnline
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendOnlineStatusData.NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x00039390 File Offset: 0x00037590
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 504876, RefRangeEnd = 504877, XrefRangeStart = 504875, XrefRangeEnd = 504876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendOnlineStatusData(bool isOnline)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendOnlineStatusData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isOnline;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendOnlineStatusData.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x000393D8 File Offset: 0x000375D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504877, XrefRangeEnd = 504884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendOnlineStatusData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x00006209 File Offset: 0x00004409
		public FriendOnlineStatusData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0003941C File Offset: 0x0003761C
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00006212 File Offset: 0x00004412
		public unsafe bool _IsOnline_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusData.NativeFieldInfoPtr__IsOnline_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendOnlineStatusData.NativeFieldInfoPtr__IsOnline_k__BackingField)) = value;
			}
		}

		// Token: 0x04000560 RID: 1376
		private static readonly IntPtr NativeFieldInfoPtr__IsOnline_k__BackingField;

		// Token: 0x04000561 RID: 1377
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOnline_Public_get_Boolean_0;

		// Token: 0x04000562 RID: 1378
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000563 RID: 1379
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
