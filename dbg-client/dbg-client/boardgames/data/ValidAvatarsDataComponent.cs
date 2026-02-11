using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000198 RID: 408
	public class ValidAvatarsDataComponent : VersionedDataComponent
	{
		// Token: 0x0600121E RID: 4638 RVA: 0x000574C0 File Offset: 0x000556C0
		// Note: this type is marked as 'beforefieldinit'.
		static ValidAvatarsDataComponent()
		{
			Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ValidAvatarsDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr);
			ValidAvatarsDataComponent.NativeFieldInfoPtr__Avatars_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, "<Avatars>k__BackingField");
			ValidAvatarsDataComponent.NativeMethodInfoPtr_get_Avatars_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, 100665832);
			ValidAvatarsDataComponent.NativeMethodInfoPtr_set_Avatars_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, 100665833);
			ValidAvatarsDataComponent.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, 100665834);
			ValidAvatarsDataComponent.NativeMethodInfoPtr_UpdateAvatars_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, 100665835);
			ValidAvatarsDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr, 100665836);
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600121F RID: 4639 RVA: 0x00057568 File Offset: 0x00055768
		// (set) Token: 0x06001220 RID: 4640 RVA: 0x000575A8 File Offset: 0x000557A8
		public unsafe List<string> Avatars
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsDataComponent.NativeMethodInfoPtr_get_Avatars_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsDataComponent.NativeMethodInfoPtr_set_Avatars_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001221 RID: 4641 RVA: 0x000575EC File Offset: 0x000557EC
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidAvatarsDataComponent(List<string> avatars)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidAvatarsDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsDataComponent.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001222 RID: 4642 RVA: 0x00057638 File Offset: 0x00055838
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514283, XrefRangeEnd = 514296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAvatars(List<string> avatars)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(avatars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidAvatarsDataComponent.NativeMethodInfoPtr_UpdateAvatars_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001223 RID: 4643 RVA: 0x0005767C File Offset: 0x0005587C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 515738, XrefRangeEnd = 515747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ValidAvatarsDataComponent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001224 RID: 4644 RVA: 0x0000AA64 File Offset: 0x00008C64
		public ValidAvatarsDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001225 RID: 4645 RVA: 0x000576C0 File Offset: 0x000558C0
		// (set) Token: 0x06001226 RID: 4646 RVA: 0x0000AA6D File Offset: 0x00008C6D
		public unsafe List<string> _Avatars_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsDataComponent.NativeFieldInfoPtr__Avatars_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidAvatarsDataComponent.NativeFieldInfoPtr__Avatars_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B18 RID: 2840
		private static readonly IntPtr NativeFieldInfoPtr__Avatars_k__BackingField;

		// Token: 0x04000B19 RID: 2841
		private static readonly IntPtr NativeMethodInfoPtr_get_Avatars_Public_get_List_1_String_0;

		// Token: 0x04000B1A RID: 2842
		private static readonly IntPtr NativeMethodInfoPtr_set_Avatars_Private_set_Void_List_1_String_0;

		// Token: 0x04000B1B RID: 2843
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04000B1C RID: 2844
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAvatars_Public_Void_List_1_String_0;

		// Token: 0x04000B1D RID: 2845
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
