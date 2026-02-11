using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Google.Apis.Sheets.v4.Data
{
	// Token: 0x020000AC RID: 172
	public class TextFormatRun : Object
	{
		// Token: 0x06000EB7 RID: 3767 RVA: 0x00043818 File Offset: 0x00041A18
		// Note: this type is marked as 'beforefieldinit'.
		static TextFormatRun()
		{
			Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Sheets.v4.dll", "Google.Apis.Sheets.v4.Data", "TextFormatRun");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr);
			TextFormatRun.NativeFieldInfoPtr__Format_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, "<Format>k__BackingField");
			TextFormatRun.NativeFieldInfoPtr__StartIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, "<StartIndex>k__BackingField");
			TextFormatRun.NativeFieldInfoPtr__ETag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, "<ETag>k__BackingField");
			TextFormatRun.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665318);
			TextFormatRun.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665319);
			TextFormatRun.NativeMethodInfoPtr_get_StartIndex_Public_Virtual_New_get_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665320);
			TextFormatRun.NativeMethodInfoPtr_set_StartIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665321);
			TextFormatRun.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665322);
			TextFormatRun.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665323);
			TextFormatRun.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr, 100665324);
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x00043910 File Offset: 0x00041B10
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x0004395C File Offset: 0x00041B5C
		public unsafe virtual TextFormat Format
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x000439AC File Offset: 0x00041BAC
		// (set) Token: 0x06000EBB RID: 3771 RVA: 0x000439F0 File Offset: 0x00041BF0
		public unsafe virtual Nullable<int> StartIndex
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_get_StartIndex_Public_Virtual_New_get_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_set_StartIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00043A44 File Offset: 0x00041C44
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x00043A88 File Offset: 0x00041C88
		public unsafe virtual string ETag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextFormatRun.NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00043AD8 File Offset: 0x00041CD8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextFormatRun()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextFormatRun>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextFormatRun.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0000914E File Offset: 0x0000734E
		public TextFormatRun(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x00043B14 File Offset: 0x00041D14
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00009157 File Offset: 0x00007357
		public unsafe TextFormat _Format_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__Format_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextFormat>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__Format_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06000EC2 RID: 3778 RVA: 0x00043B44 File Offset: 0x00041D44
		// (set) Token: 0x06000EC3 RID: 3779 RVA: 0x00009176 File Offset: 0x00007376
		public Nullable<int> _StartIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__StartIndex_k__BackingField);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__StartIndex_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06000EC4 RID: 3780 RVA: 0x00043B74 File Offset: 0x00041D74
		// (set) Token: 0x06000EC5 RID: 3781 RVA: 0x000091A4 File Offset: 0x000073A4
		public unsafe string _ETag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__ETag_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextFormatRun.NativeFieldInfoPtr__ETag_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000A35 RID: 2613
		private static readonly IntPtr NativeFieldInfoPtr__Format_k__BackingField;

		// Token: 0x04000A36 RID: 2614
		private static readonly IntPtr NativeFieldInfoPtr__StartIndex_k__BackingField;

		// Token: 0x04000A37 RID: 2615
		private static readonly IntPtr NativeFieldInfoPtr__ETag_k__BackingField;

		// Token: 0x04000A38 RID: 2616
		private static readonly IntPtr NativeMethodInfoPtr_get_Format_Public_Virtual_New_get_TextFormat_0;

		// Token: 0x04000A39 RID: 2617
		private static readonly IntPtr NativeMethodInfoPtr_set_Format_Public_Virtual_New_set_Void_TextFormat_0;

		// Token: 0x04000A3A RID: 2618
		private static readonly IntPtr NativeMethodInfoPtr_get_StartIndex_Public_Virtual_New_get_Nullable_1_Int32_0;

		// Token: 0x04000A3B RID: 2619
		private static readonly IntPtr NativeMethodInfoPtr_set_StartIndex_Public_Virtual_New_set_Void_Nullable_1_Int32_0;

		// Token: 0x04000A3C RID: 2620
		private static readonly IntPtr NativeMethodInfoPtr_get_ETag_Public_Virtual_New_get_String_0;

		// Token: 0x04000A3D RID: 2621
		private static readonly IntPtr NativeMethodInfoPtr_set_ETag_Public_Virtual_New_set_Void_String_0;

		// Token: 0x04000A3E RID: 2622
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
