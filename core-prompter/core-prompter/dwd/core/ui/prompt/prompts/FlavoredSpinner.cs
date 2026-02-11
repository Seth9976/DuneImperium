using System;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x0200001B RID: 27
	public class FlavoredSpinner : Spinner
	{
		// Token: 0x0600013A RID: 314 RVA: 0x00007AD0 File Offset: 0x00005CD0
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredSpinner()
		{
			Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "FlavoredSpinner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr);
			FlavoredSpinner.NativeFieldInfoPtr__PrefabLookupTags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr, "<PrefabLookupTags>k__BackingField");
			FlavoredSpinner.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr, 100663409);
			FlavoredSpinner.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr, 100663410);
			FlavoredSpinner.NativeMethodInfoPtr__ctor_Public_Void_String_LocalizedString_LocalizedString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr, 100663411);
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00007B50 File Offset: 0x00005D50
		public unsafe virtual IEnumerable<string> PrefabLookupTags
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredSpinner.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007B90 File Offset: 0x00005D90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213739, RefRangeEnd = 1213740, XrefRangeStart = 1213725, XrefRangeEnd = 1213739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredSpinner(IEnumerable<string> flavors, LocalizedString shownMessage = null, LocalizedString shownTitle = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shownMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shownTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredSpinner.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_LocalizedString_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00007C00 File Offset: 0x00005E00
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1213758, RefRangeEnd = 1213794, XrefRangeStart = 1213740, XrefRangeEnd = 1213758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredSpinner(string flavor, LocalizedString showMessage = null, LocalizedString shownTitle = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredSpinner>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(showMessage);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(shownTitle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredSpinner.NativeMethodInfoPtr__ctor_Public_Void_String_LocalizedString_LocalizedString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000029B5 File Offset: 0x00000BB5
		public FlavoredSpinner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00007C70 File Offset: 0x00005E70
		// (set) Token: 0x06000140 RID: 320 RVA: 0x000029BE File Offset: 0x00000BBE
		public unsafe IEnumerable<string> _PrefabLookupTags_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredSpinner.NativeFieldInfoPtr__PrefabLookupTags_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredSpinner.NativeFieldInfoPtr__PrefabLookupTags_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr__PrefabLookupTags_k__BackingField;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_LocalizedString_LocalizedString_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_LocalizedString_LocalizedString_0;
	}
}
