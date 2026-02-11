using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.ui.prompt.prompts
{
	// Token: 0x02000018 RID: 24
	public class ChoicePrompt<TChoice> : ResolvablePrompt<TChoice>
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000071F4 File Offset: 0x000053F4
		// Note: this type is marked as 'beforefieldinit'.
		static ChoicePrompt()
		{
			Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-prompter.dll", "dwd.core.ui.prompt.prompts", "ChoicePrompt`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TChoice>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr);
			ChoicePrompt<TChoice>.NativeFieldInfoPtr__ValidChoices_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr, "<ValidChoices>k__BackingField");
			ChoicePrompt<TChoice>.NativeMethodInfoPtr_get_ValidChoices_Public_Virtual_Final_New_get_IEnumerable_1_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr, 100663393);
			ChoicePrompt<TChoice>.NativeMethodInfoPtr_set_ValidChoices_Private_set_Void_IEnumerable_1_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr, 100663394);
			ChoicePrompt<TChoice>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr, 100663395);
			ChoicePrompt<TChoice>.NativeMethodInfoPtr_resolve_Protected_Virtual_Void_TChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr, 100663396);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000117 RID: 279 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00007304 File Offset: 0x00005504
		public unsafe virtual IEnumerable<TChoice> ValidChoices
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChoicePrompt<TChoice>.NativeMethodInfoPtr_get_ValidChoices_Public_Virtual_Final_New_get_IEnumerable_1_TChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<TChoice>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChoicePrompt<TChoice>.NativeMethodInfoPtr_set_ValidChoices_Private_set_Void_IEnumerable_1_TChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00007348 File Offset: 0x00005548
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1213593, RefRangeEnd = 1213594, XrefRangeStart = 1213591, XrefRangeEnd = 1213593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChoicePrompt(IEnumerable<TChoice> validChoices)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChoicePrompt<TChoice>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validChoices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChoicePrompt<TChoice>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00007394 File Offset: 0x00005594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1213594, XrefRangeEnd = 1213598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void resolve(TChoice result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TChoice).IsValueType)
				{
					TChoice tchoice = result;
					intPtr = ((tchoice is string) ? IL2CPP.ManagedStringToIl2Cpp(tchoice as string) : IL2CPP.Il2CppObjectBaseToPtr(tchoice as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref result;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChoicePrompt<TChoice>.NativeMethodInfoPtr_resolve_Protected_Virtual_Void_TChoice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x000028DB File Offset: 0x00000ADB
		public ChoicePrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600011C RID: 284 RVA: 0x00007418 File Offset: 0x00005618
		// (set) Token: 0x0600011D RID: 285 RVA: 0x000028E4 File Offset: 0x00000AE4
		public unsafe IEnumerable<TChoice> _ValidChoices_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChoicePrompt<TChoice>.NativeFieldInfoPtr__ValidChoices_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<TChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChoicePrompt<TChoice>.NativeFieldInfoPtr__ValidChoices_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeFieldInfoPtr__ValidChoices_k__BackingField;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_get_ValidChoices_Public_Virtual_Final_New_get_IEnumerable_1_TChoice_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_set_ValidChoices_Private_set_Void_IEnumerable_1_TChoice_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_TChoice_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_resolve_Protected_Virtual_Void_TChoice_0;
	}
}
