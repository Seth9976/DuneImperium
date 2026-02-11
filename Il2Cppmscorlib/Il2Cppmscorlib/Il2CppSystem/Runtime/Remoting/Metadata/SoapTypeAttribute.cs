using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020002E2 RID: 738
	public sealed class SoapTypeAttribute : SoapAttribute
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x000ED9C8 File Offset: 0x000EBBC8
		// Note: this type is marked as 'beforefieldinit'.
		static SoapTypeAttribute()
		{
			Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapTypeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr);
			SoapTypeAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_useAttribute");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlElementName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeName");
			SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_xmlTypeNamespace");
			SoapTypeAttribute.NativeFieldInfoPtr__isType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isType");
			SoapTypeAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, "_isElement");
			SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670620);
			SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670621);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670622);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670623);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670624);
			SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670625);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670626);
			SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670627);
			SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr, 100670628);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000EDB38 File Offset: 0x000EBD38
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapTypeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapTypeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06002DC2 RID: 11714 RVA: 0x000EDB74 File Offset: 0x000EBD74
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06002DC3 RID: 11715 RVA: 0x000EDBB0 File Offset: 0x000EBDB0
		public unsafe string XmlElementName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000EDBE8 File Offset: 0x000EBDE8
		public unsafe override string XmlNamespace
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x000EDC20 File Offset: 0x000EBE20
		public unsafe string XmlTypeName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x000EDC58 File Offset: 0x000EBE58
		public unsafe string XmlTypeNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06002DC7 RID: 11719 RVA: 0x000EDC90 File Offset: 0x000EBE90
		public unsafe bool IsInteropXmlElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06002DC8 RID: 11720 RVA: 0x000EDCCC File Offset: 0x000EBECC
		public unsafe bool IsInteropXmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x000EDD08 File Offset: 0x000EBF08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382168, XrefRangeEnd = 1382187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapTypeAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x0000F6C5 File Offset: 0x0000D8C5
		public SoapTypeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000EDD4C File Offset: 0x000EBF4C
		// (set) Token: 0x06002DCC RID: 11724 RVA: 0x0000F6CE File Offset: 0x0000D8CE
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002DCD RID: 11725 RVA: 0x000EDD74 File Offset: 0x000EBF74
		// (set) Token: 0x06002DCE RID: 11726 RVA: 0x0000F6E9 File Offset: 0x0000D8E9
		public unsafe string _xmlElementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlElementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06002DCF RID: 11727 RVA: 0x000EDD9C File Offset: 0x000EBF9C
		// (set) Token: 0x06002DD0 RID: 11728 RVA: 0x0000F708 File Offset: 0x0000D908
		public unsafe string _xmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06002DD1 RID: 11729 RVA: 0x000EDDC4 File Offset: 0x000EBFC4
		// (set) Token: 0x06002DD2 RID: 11730 RVA: 0x0000F727 File Offset: 0x0000D927
		public unsafe string _xmlTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06002DD3 RID: 11731 RVA: 0x000EDDEC File Offset: 0x000EBFEC
		// (set) Token: 0x06002DD4 RID: 11732 RVA: 0x0000F746 File Offset: 0x0000D946
		public unsafe string _xmlTypeNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__xmlTypeNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x000EDE14 File Offset: 0x000EC014
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x0000F765 File Offset: 0x0000D965
		public unsafe bool _isType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isType)) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06002DD7 RID: 11735 RVA: 0x000EDE3C File Offset: 0x000EC03C
		// (set) Token: 0x06002DD8 RID: 11736 RVA: 0x0000F780 File Offset: 0x0000D980
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapTypeAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x04002644 RID: 9796
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x04002645 RID: 9797
		private static readonly IntPtr NativeFieldInfoPtr__xmlElementName;

		// Token: 0x04002646 RID: 9798
		private static readonly IntPtr NativeFieldInfoPtr__xmlNamespace;

		// Token: 0x04002647 RID: 9799
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeName;

		// Token: 0x04002648 RID: 9800
		private static readonly IntPtr NativeFieldInfoPtr__xmlTypeNamespace;

		// Token: 0x04002649 RID: 9801
		private static readonly IntPtr NativeFieldInfoPtr__isType;

		// Token: 0x0400264A RID: 9802
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x0400264B RID: 9803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400264C RID: 9804
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x0400264D RID: 9805
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x0400264E RID: 9806
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x0400264F RID: 9807
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeName_Public_get_String_0;

		// Token: 0x04002650 RID: 9808
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeNamespace_Public_get_String_0;

		// Token: 0x04002651 RID: 9809
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlElement_Internal_get_Boolean_0;

		// Token: 0x04002652 RID: 9810
		private static readonly IntPtr NativeMethodInfoPtr_get_IsInteropXmlType_Internal_get_Boolean_0;

		// Token: 0x04002653 RID: 9811
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
