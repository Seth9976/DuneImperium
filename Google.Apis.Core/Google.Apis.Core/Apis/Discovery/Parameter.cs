using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Google.Apis.Discovery
{
	// Token: 0x0200003E RID: 62
	public class Parameter : Object
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000D90C File Offset: 0x0000BB0C
		// Note: this type is marked as 'beforefieldinit'.
		static Parameter()
		{
			Il2CppClassPointerStore<Parameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Google.Apis.Core.dll", "Google.Apis.Discovery", "Parameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Parameter>.NativeClassPtr);
			Parameter.NativeFieldInfoPtr__Name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "<Name>k__BackingField");
			Parameter.NativeFieldInfoPtr__Pattern_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "<Pattern>k__BackingField");
			Parameter.NativeFieldInfoPtr__IsRequired_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "<IsRequired>k__BackingField");
			Parameter.NativeFieldInfoPtr__ParameterType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "<ParameterType>k__BackingField");
			Parameter.NativeFieldInfoPtr__DefaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Parameter>.NativeClassPtr, "<DefaultValue>k__BackingField");
			Parameter.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663712);
			Parameter.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663713);
			Parameter.NativeMethodInfoPtr_get_Pattern_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663714);
			Parameter.NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663715);
			Parameter.NativeMethodInfoPtr_get_IsRequired_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663716);
			Parameter.NativeMethodInfoPtr_set_IsRequired_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663717);
			Parameter.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663718);
			Parameter.NativeMethodInfoPtr_set_ParameterType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663719);
			Parameter.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663720);
			Parameter.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663721);
			Parameter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Parameter>.NativeClassPtr, 100663722);
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		// (set) Token: 0x0600029F RID: 671 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		public unsafe virtual string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002A0 RID: 672 RVA: 0x0000DAF8 File Offset: 0x0000BCF8
		// (set) Token: 0x060002A1 RID: 673 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public unsafe virtual string Pattern
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_get_Pattern_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000DB74 File Offset: 0x0000BD74
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000DBB0 File Offset: 0x0000BDB0
		public unsafe virtual bool IsRequired
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_get_IsRequired_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_set_IsRequired_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x0000DC28 File Offset: 0x0000BE28
		public unsafe virtual string ParameterType
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_get_ParameterType_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_set_ParameterType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x0000DC6C File Offset: 0x0000BE6C
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x0000DCA4 File Offset: 0x0000BEA4
		public unsafe virtual string DefaultValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Parameter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Parameter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Parameter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000310B File Offset: 0x0000130B
		public Parameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000DD24 File Offset: 0x0000BF24
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003114 File Offset: 0x00001314
		public unsafe string _Name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__Name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__Name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000DD4C File Offset: 0x0000BF4C
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003133 File Offset: 0x00001333
		public unsafe string _Pattern_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__Pattern_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__Pattern_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000DD74 File Offset: 0x0000BF74
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00003152 File Offset: 0x00001352
		public unsafe bool _IsRequired_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__IsRequired_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__IsRequired_k__BackingField)) = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000316D File Offset: 0x0000136D
		public unsafe string _ParameterType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__ParameterType_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__ParameterType_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000DDC4 File Offset: 0x0000BFC4
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000318C File Offset: 0x0000138C
		public unsafe string _DefaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__DefaultValue_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Parameter.NativeFieldInfoPtr__DefaultValue_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001BC RID: 444
		private static readonly IntPtr NativeFieldInfoPtr__Name_k__BackingField;

		// Token: 0x040001BD RID: 445
		private static readonly IntPtr NativeFieldInfoPtr__Pattern_k__BackingField;

		// Token: 0x040001BE RID: 446
		private static readonly IntPtr NativeFieldInfoPtr__IsRequired_k__BackingField;

		// Token: 0x040001BF RID: 447
		private static readonly IntPtr NativeFieldInfoPtr__ParameterType_k__BackingField;

		// Token: 0x040001C0 RID: 448
		private static readonly IntPtr NativeFieldInfoPtr__DefaultValue_k__BackingField;

		// Token: 0x040001C1 RID: 449
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001C2 RID: 450
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x040001C3 RID: 451
		private static readonly IntPtr NativeMethodInfoPtr_get_Pattern_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001C4 RID: 452
		private static readonly IntPtr NativeMethodInfoPtr_set_Pattern_Public_set_Void_String_0;

		// Token: 0x040001C5 RID: 453
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRequired_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040001C6 RID: 454
		private static readonly IntPtr NativeMethodInfoPtr_set_IsRequired_Public_set_Void_Boolean_0;

		// Token: 0x040001C7 RID: 455
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterType_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeMethodInfoPtr_set_ParameterType_Public_set_Void_String_0;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
