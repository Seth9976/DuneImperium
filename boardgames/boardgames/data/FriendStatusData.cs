using System;
using boardgames.utils;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200013F RID: 319
	public class FriendStatusData : DataComponent
	{
		// Token: 0x06001086 RID: 4230 RVA: 0x00043DF4 File Offset: 0x00041FF4
		// Note: this type is marked as 'beforefieldinit'.
		static FriendStatusData()
		{
			Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.data", "FriendStatusData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr);
			FriendStatusData.NativeFieldInfoPtr__Status_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr, "<Status>k__BackingField");
			FriendStatusData.NativeMethodInfoPtr_get_Status_Public_get_FriendStatuses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr, 100665718);
			FriendStatusData.NativeMethodInfoPtr__ctor_Public_Void_FriendStatuses_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr, 100665719);
			FriendStatusData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr, 100665720);
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00043E74 File Offset: 0x00042074
		public unsafe DBGConstants.FriendStatuses Status
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendStatusData.NativeMethodInfoPtr_get_Status_Public_get_FriendStatuses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x00043EB0 File Offset: 0x000420B0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 504768, RefRangeEnd = 504775, XrefRangeStart = 504768, XrefRangeEnd = 504775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendStatusData(DBGConstants.FriendStatuses status)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendStatusData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendStatusData.NativeMethodInfoPtr__ctor_Public_Void_FriendStatuses_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x00043EF8 File Offset: 0x000420F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999338, XrefRangeEnd = 999344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendStatusData.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00009A6E File Offset: 0x00007C6E
		public FriendStatusData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x0600108B RID: 4235 RVA: 0x00043F3C File Offset: 0x0004213C
		// (set) Token: 0x0600108C RID: 4236 RVA: 0x00009A77 File Offset: 0x00007C77
		public unsafe DBGConstants.FriendStatuses _Status_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusData.NativeFieldInfoPtr__Status_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendStatusData.NativeFieldInfoPtr__Status_k__BackingField)) = value;
			}
		}

		// Token: 0x04000A16 RID: 2582
		private static readonly IntPtr NativeFieldInfoPtr__Status_k__BackingField;

		// Token: 0x04000A17 RID: 2583
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_FriendStatuses_0;

		// Token: 0x04000A18 RID: 2584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FriendStatuses_0;

		// Token: 0x04000A19 RID: 2585
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
