using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200009B RID: 155
	public sealed class DTSubString : ValueType
	{
		// Token: 0x06000AD8 RID: 2776 RVA: 0x00057E30 File Offset: 0x00056030
		// Note: this type is marked as 'beforefieldinit'.
		static DTSubString()
		{
			Il2CppClassPointerStore<DTSubString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "DTSubString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DTSubString>.NativeClassPtr);
			DTSubString.NativeFieldInfoPtr_s = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "s");
			DTSubString.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "index");
			DTSubString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "length");
			DTSubString.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "type");
			DTSubString.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, "value");
			DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DTSubString>.NativeClassPtr, 100665214);
		}

		// Token: 0x170001CD RID: 461
		public unsafe char this[int relativeIndex]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1307331, RefRangeEnd = 1307333, XrefRangeStart = 1307331, XrefRangeEnd = 1307331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref relativeIndex;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DTSubString.NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00004995 File Offset: 0x00002B95
		public DTSubString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0000499E File Offset: 0x00002B9E
		public DTSubString()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DTSubString>.NativeClassPtr))
		{
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000ADC RID: 2780 RVA: 0x00057F28 File Offset: 0x00056128
		// (set) Token: 0x06000ADD RID: 2781 RVA: 0x000049B0 File Offset: 0x00002BB0
		public ReadOnlySpan<char> s
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s);
				return new ReadOnlySpan<char>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_s), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ReadOnlySpan<char>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x00057F58 File Offset: 0x00056158
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x000049DE File Offset: 0x00002BDE
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000AE0 RID: 2784 RVA: 0x00057F80 File Offset: 0x00056180
		// (set) Token: 0x06000AE1 RID: 2785 RVA: 0x000049F9 File Offset: 0x00002BF9
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00057FA8 File Offset: 0x000561A8
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x00004A14 File Offset: 0x00002C14
		public unsafe DTSubStringType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_type)) = value;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00057FD0 File Offset: 0x000561D0
		// (set) Token: 0x06000AE5 RID: 2789 RVA: 0x00004A2F File Offset: 0x00002C2F
		public unsafe int value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DTSubString.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x0400088D RID: 2189
		private static readonly IntPtr NativeFieldInfoPtr_s;

		// Token: 0x0400088E RID: 2190
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400088F RID: 2191
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04000890 RID: 2192
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000891 RID: 2193
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000892 RID: 2194
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Internal_get_Char_Int32_0;
	}
}
