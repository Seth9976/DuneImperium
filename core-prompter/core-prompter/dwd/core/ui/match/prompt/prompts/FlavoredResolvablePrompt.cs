using System;
using dwd.core.data.composition;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.match.prompt.prompts
{
	// Token: 0x02000008 RID: 8
	public class FlavoredResolvablePrompt<TResult> : ResolvablePrompt<TResult>
	{
		// Token: 0x06000027 RID: 39 RVA: 0x0000484C File Offset: 0x00002A4C
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredResolvablePrompt()
		{
			Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.match.prompt.prompts", "FlavoredResolvablePrompt`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TResult>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr);
			FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__TheySeenMe_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, "<TheySeenMe>k__BackingField");
			FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__PromptData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, "<PromptData>k__BackingField");
			FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, 100663315);
			FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, 100663316);
			FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, 100663317);
			FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, 100663318);
			FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr, 100663319);
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00004944 File Offset: 0x00002B44
		// (set) Token: 0x06000029 RID: 41 RVA: 0x00004980 File Offset: 0x00002B80
		public unsafe virtual bool TheySeenMe
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x000049C0 File Offset: 0x00002BC0
		public unsafe virtual DataComposition PromptData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004A00 File Offset: 0x00002C00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213049, RefRangeEnd = 1213050, XrefRangeStart = 1213043, XrefRangeEnd = 1213049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredResolvablePrompt(DataComposition promptData, IEnumerable<string> additionalTags)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalTags);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004A60 File Offset: 0x00002C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213050, XrefRangeEnd = 1213055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredResolvablePrompt(DataComposition promptData, string flavor)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredResolvablePrompt<TResult>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(promptData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(flavor);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredResolvablePrompt<TResult>.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002133 File Offset: 0x00000333
		public FlavoredResolvablePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00004AC0 File Offset: 0x00002CC0
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0000213C File Offset: 0x0000033C
		public unsafe bool _TheySeenMe_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__TheySeenMe_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__TheySeenMe_k__BackingField)) = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00004AE8 File Offset: 0x00002CE8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x00002157 File Offset: 0x00000357
		public unsafe DataComposition _PromptData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__PromptData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredResolvablePrompt<TResult>.NativeFieldInfoPtr__PromptData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeFieldInfoPtr__TheySeenMe_k__BackingField;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeFieldInfoPtr__PromptData_k__BackingField;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_TheySeenMe_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_set_TheySeenMe_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_PromptData_Public_Virtual_Final_New_get_DataComposition_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_IEnumerable_1_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_String_0;
	}
}
