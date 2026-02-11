using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.SmartFormat
{
	// Token: 0x0200002F RID: 47
	public class FormattingErrorEventArgs : EventArgs
	{
		// Token: 0x060002FF RID: 767 RVA: 0x00014F88 File Offset: 0x00013188
		// Note: this type is marked as 'beforefieldinit'.
		static FormattingErrorEventArgs()
		{
			Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.SmartFormat", "FormattingErrorEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr);
			FormattingErrorEventArgs.NativeFieldInfoPtr__Placeholder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, "<Placeholder>k__BackingField");
			FormattingErrorEventArgs.NativeFieldInfoPtr__ErrorIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, "<ErrorIndex>k__BackingField");
			FormattingErrorEventArgs.NativeFieldInfoPtr__IgnoreError_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, "<IgnoreError>k__BackingField");
			FormattingErrorEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663839);
			FormattingErrorEventArgs.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663840);
			FormattingErrorEventArgs.NativeMethodInfoPtr_set_Placeholder_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663841);
			FormattingErrorEventArgs.NativeMethodInfoPtr_get_ErrorIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663842);
			FormattingErrorEventArgs.NativeMethodInfoPtr_set_ErrorIndex_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663843);
			FormattingErrorEventArgs.NativeMethodInfoPtr_get_IgnoreError_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663844);
			FormattingErrorEventArgs.NativeMethodInfoPtr_set_IgnoreError_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr, 100663845);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00015080 File Offset: 0x00013280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1068231, XrefRangeEnd = 1068236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FormattingErrorEventArgs(string rawText, int errorIndex, bool ignoreError)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FormattingErrorEventArgs>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(rawText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref errorIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreError;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000301 RID: 769 RVA: 0x000150E8 File Offset: 0x000132E8
		// (set) Token: 0x06000302 RID: 770 RVA: 0x00015120 File Offset: 0x00013320
		public unsafe string Placeholder
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_get_Placeholder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_set_Placeholder_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00015164 File Offset: 0x00013364
		// (set) Token: 0x06000304 RID: 772 RVA: 0x000151A0 File Offset: 0x000133A0
		public unsafe int ErrorIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_get_ErrorIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 311421, RefRangeEnd = 311423, XrefRangeStart = 311421, XrefRangeEnd = 311423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_set_ErrorIndex_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000305 RID: 773 RVA: 0x000151E0 File Offset: 0x000133E0
		// (set) Token: 0x06000306 RID: 774 RVA: 0x0001521C File Offset: 0x0001341C
		public unsafe bool IgnoreError
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_get_IgnoreError_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FormattingErrorEventArgs.NativeMethodInfoPtr_set_IgnoreError_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x000030C4 File Offset: 0x000012C4
		public FormattingErrorEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0001525C File Offset: 0x0001345C
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000030CD File Offset: 0x000012CD
		public unsafe string _Placeholder_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__Placeholder_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__Placeholder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00015284 File Offset: 0x00013484
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000030EC File Offset: 0x000012EC
		public unsafe int _ErrorIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__ErrorIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__ErrorIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000152AC File Offset: 0x000134AC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00003107 File Offset: 0x00001307
		public unsafe bool _IgnoreError_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__IgnoreError_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FormattingErrorEventArgs.NativeFieldInfoPtr__IgnoreError_k__BackingField)) = value;
			}
		}

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeFieldInfoPtr__Placeholder_k__BackingField;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeFieldInfoPtr__ErrorIndex_k__BackingField;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeFieldInfoPtr__IgnoreError_k__BackingField;

		// Token: 0x0400023F RID: 575
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Int32_Boolean_0;

		// Token: 0x04000240 RID: 576
		private static readonly IntPtr NativeMethodInfoPtr_get_Placeholder_Public_get_String_0;

		// Token: 0x04000241 RID: 577
		private static readonly IntPtr NativeMethodInfoPtr_set_Placeholder_Internal_set_Void_String_0;

		// Token: 0x04000242 RID: 578
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorIndex_Public_get_Int32_0;

		// Token: 0x04000243 RID: 579
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorIndex_Internal_set_Void_Int32_0;

		// Token: 0x04000244 RID: 580
		private static readonly IntPtr NativeMethodInfoPtr_get_IgnoreError_Public_get_Boolean_0;

		// Token: 0x04000245 RID: 581
		private static readonly IntPtr NativeMethodInfoPtr_set_IgnoreError_Internal_set_Void_Boolean_0;
	}
}
