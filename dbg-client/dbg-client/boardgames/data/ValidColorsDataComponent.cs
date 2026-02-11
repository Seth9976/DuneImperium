using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.data
{
	// Token: 0x02000199 RID: 409
	public class ValidColorsDataComponent : VersionedDataComponent
	{
		// Token: 0x06001227 RID: 4647 RVA: 0x000576F0 File Offset: 0x000558F0
		// Note: this type is marked as 'beforefieldinit'.
		static ValidColorsDataComponent()
		{
			Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "ValidColorsDataComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr);
			ValidColorsDataComponent.NativeFieldInfoPtr__Colors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr, "<Colors>k__BackingField");
			ValidColorsDataComponent.NativeMethodInfoPtr_get_Colors_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr, 100665837);
			ValidColorsDataComponent.NativeMethodInfoPtr_set_Colors_Private_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr, 100665838);
			ValidColorsDataComponent.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr, 100665839);
			ValidColorsDataComponent.NativeMethodInfoPtr_UpdateColors_Public_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr, 100665840);
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001228 RID: 4648 RVA: 0x00057784 File Offset: 0x00055984
		// (set) Token: 0x06001229 RID: 4649 RVA: 0x000577C4 File Offset: 0x000559C4
		public unsafe List<string> Colors
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsDataComponent.NativeMethodInfoPtr_get_Colors_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsDataComponent.NativeMethodInfoPtr_set_Colors_Private_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600122A RID: 4650 RVA: 0x00057808 File Offset: 0x00055A08
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 504779, RefRangeEnd = 504807, XrefRangeStart = 504779, XrefRangeEnd = 504807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidColorsDataComponent(List<string> colors)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidColorsDataComponent>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsDataComponent.NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122B RID: 4651 RVA: 0x00057854 File Offset: 0x00055A54
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 514283, RefRangeEnd = 514296, XrefRangeStart = 514283, XrefRangeEnd = 514296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateColors(List<string> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidColorsDataComponent.NativeMethodInfoPtr_UpdateColors_Public_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600122C RID: 4652 RVA: 0x0000AA8C File Offset: 0x00008C8C
		public ValidColorsDataComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600122D RID: 4653 RVA: 0x00057898 File Offset: 0x00055A98
		// (set) Token: 0x0600122E RID: 4654 RVA: 0x0000AA95 File Offset: 0x00008C95
		public unsafe List<string> _Colors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsDataComponent.NativeFieldInfoPtr__Colors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidColorsDataComponent.NativeFieldInfoPtr__Colors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B1E RID: 2846
		private static readonly IntPtr NativeFieldInfoPtr__Colors_k__BackingField;

		// Token: 0x04000B1F RID: 2847
		private static readonly IntPtr NativeMethodInfoPtr_get_Colors_Public_get_List_1_String_0;

		// Token: 0x04000B20 RID: 2848
		private static readonly IntPtr NativeMethodInfoPtr_set_Colors_Private_set_Void_List_1_String_0;

		// Token: 0x04000B21 RID: 2849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_String_0;

		// Token: 0x04000B22 RID: 2850
		private static readonly IntPtr NativeMethodInfoPtr_UpdateColors_Public_Void_List_1_String_0;
	}
}
