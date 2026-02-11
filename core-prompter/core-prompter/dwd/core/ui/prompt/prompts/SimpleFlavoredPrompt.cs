using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000027 RID: 39
	public class SimpleFlavoredPrompt : Object
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000823C File Offset: 0x0000643C
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleFlavoredPrompt()
		{
			Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "SimpleFlavoredPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr);
			SimpleFlavoredPrompt.NativeFieldInfoPtr_instanceFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, "instanceFlavors");
			SimpleFlavoredPrompt.NativeFieldInfoPtr__Resolved_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, "<Resolved>k__BackingField");
			SimpleFlavoredPrompt.NativeMethodInfoPtr_AddFlavors_Protected_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, 100663425);
			SimpleFlavoredPrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, 100663426);
			SimpleFlavoredPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, 100663427);
			SimpleFlavoredPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, 100663428);
			SimpleFlavoredPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr, 100663429);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000082F8 File Offset: 0x000064F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213794, XrefRangeEnd = 1213805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddFlavors([Optional] Il2CppStringArray additionalFlavors)
		{
			if (additionalFlavors == null)
			{
				additionalFlavors = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(additionalFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleFlavoredPrompt.NativeMethodInfoPtr_AddFlavors_Protected_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00008348 File Offset: 0x00006548
		public unsafe virtual IEnumerable<string> PrefabLookupTags
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleFlavoredPrompt.NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00008388 File Offset: 0x00006588
		// (set) Token: 0x06000168 RID: 360 RVA: 0x000083C4 File Offset: 0x000065C4
		public unsafe virtual bool Resolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleFlavoredPrompt.NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleFlavoredPrompt.NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00008404 File Offset: 0x00006604
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleFlavoredPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleFlavoredPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleFlavoredPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002B75 File Offset: 0x00000D75
		public void AddFlavors(params string[] additionalFlavors)
		{
			this.AddFlavors(new Il2CppStringArray(additionalFlavors));
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002B83 File Offset: 0x00000D83
		public SimpleFlavoredPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00008440 File Offset: 0x00006640
		// (set) Token: 0x0600016D RID: 365 RVA: 0x00002B8C File Offset: 0x00000D8C
		public unsafe List<string> instanceFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleFlavoredPrompt.NativeFieldInfoPtr_instanceFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleFlavoredPrompt.NativeFieldInfoPtr_instanceFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00008470 File Offset: 0x00006670
		// (set) Token: 0x0600016F RID: 367 RVA: 0x00002BAB File Offset: 0x00000DAB
		public unsafe bool _Resolved_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleFlavoredPrompt.NativeFieldInfoPtr__Resolved_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleFlavoredPrompt.NativeFieldInfoPtr__Resolved_k__BackingField)) = value;
			}
		}

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeFieldInfoPtr_instanceFlavors;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr__Resolved_k__BackingField;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_AddFlavors_Protected_Void_Il2CppStringArray_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_get_PrefabLookupTags_Public_Virtual_Final_New_get_IEnumerable_1_String_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_get_Resolved_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_set_Resolved_Protected_set_Void_Boolean_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
