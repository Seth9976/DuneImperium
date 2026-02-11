using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000037 RID: 55
	public class ValidatingReaderNodeData : Object
	{
		// Token: 0x0600034E RID: 846 RVA: 0x00023804 File Offset: 0x00021A04
		// Note: this type is marked as 'beforefieldinit'.
		static ValidatingReaderNodeData()
		{
			Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ValidatingReaderNodeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr);
			ValidatingReaderNodeData.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "localName");
			ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "namespaceUri");
			ValidatingReaderNodeData.NativeFieldInfoPtr_prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "prefix");
			ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "nameWPrefix");
			ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "rawValue");
			ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "originalStringValue");
			ValidatingReaderNodeData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "depth");
			ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "attributePSVIInfo");
			ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "nodeType");
			ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "lineNo");
			ValidatingReaderNodeData.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, "linePos");
			ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663768);
			ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663769);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LocalName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663770);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663771);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663772);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663773);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Prefix_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663774);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663775);
			ValidatingReaderNodeData.NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663776);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_Depth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663777);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663778);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_RawValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663779);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663780);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663781);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663782);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663783);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663784);
			ValidatingReaderNodeData.NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663785);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663786);
			ValidatingReaderNodeData.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663787);
			ValidatingReaderNodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663788);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663789);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663790);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663791);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663792);
			ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr, 100663793);
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00023B18 File Offset: 0x00021D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 364822, RefRangeEnd = 364823, XrefRangeStart = 364820, XrefRangeEnd = 364822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00023B54 File Offset: 0x00021D54
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 364825, RefRangeEnd = 364831, XrefRangeStart = 364823, XrefRangeEnd = 364825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValidatingReaderNodeData(XmlNodeType nodeType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValidatingReaderNodeData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00023B9C File Offset: 0x00021D9C
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00023BD4 File Offset: 0x00021DD4
		public unsafe string LocalName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LocalName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00023C18 File Offset: 0x00021E18
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00023C50 File Offset: 0x00021E50
		public unsafe string Namespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000355 RID: 853 RVA: 0x00023C94 File Offset: 0x00021E94
		// (set) Token: 0x06000356 RID: 854 RVA: 0x00023CCC File Offset: 0x00021ECC
		public unsafe string Prefix
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Prefix_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00023D10 File Offset: 0x00021F10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364835, RefRangeEnd = 364837, XrefRangeStart = 364831, XrefRangeEnd = 364835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetAtomizedNameWPrefix(XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00023D58 File Offset: 0x00021F58
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00023D94 File Offset: 0x00021F94
		public unsafe int Depth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_Depth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00023DD4 File Offset: 0x00021FD4
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00023E0C File Offset: 0x0002200C
		public unsafe string RawValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_RawValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00023E50 File Offset: 0x00022050
		public unsafe string OriginalStringValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00023E88 File Offset: 0x00022088
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00023EC4 File Offset: 0x000220C4
		public unsafe XmlNodeType NodeType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 318242, RefRangeEnd = 318245, XrefRangeStart = 318242, XrefRangeEnd = 318245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00023F04 File Offset: 0x00022104
		// (set) Token: 0x06000360 RID: 864 RVA: 0x00023F44 File Offset: 0x00022144
		public unsafe AttributePSVIInfo AttInfo
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00023F88 File Offset: 0x00022188
		public unsafe int LineNumber
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00023FC4 File Offset: 0x000221C4
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00024000 File Offset: 0x00022200
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364848, RefRangeEnd = 364851, XrefRangeStart = 364837, XrefRangeEnd = 364848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear(XmlNodeType nodeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00024040 File Offset: 0x00022240
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364851, RefRangeEnd = 364853, XrefRangeStart = 364851, XrefRangeEnd = 364851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(int lineNo, int linePos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0002408C File Offset: 0x0002228C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364858, RefRangeEnd = 364861, XrefRangeStart = 364853, XrefRangeEnd = 364858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLineInfo(IXmlLineInfo lineInfo)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000240D0 File Offset: 0x000222D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 364867, RefRangeEnd = 364870, XrefRangeStart = 364861, XrefRangeEnd = 364867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string localName, string prefix, string ns, int depth)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(localName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref depth;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00024144 File Offset: 0x00022344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 364870, XrefRangeEnd = 364872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00024188 File Offset: 0x00022388
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 364874, RefRangeEnd = 364876, XrefRangeStart = 364872, XrefRangeEnd = 364874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItemData(string value, string originalStringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(originalStringValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidatingReaderNodeData.NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00003277 File Offset: 0x00001477
		public ValidatingReaderNodeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600036A RID: 874 RVA: 0x000241DC File Offset: 0x000223DC
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00003280 File Offset: 0x00001480
		public unsafe string localName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_localName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00024204 File Offset: 0x00022404
		// (set) Token: 0x0600036D RID: 877 RVA: 0x0000329F File Offset: 0x0000149F
		public unsafe string namespaceUri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_namespaceUri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600036E RID: 878 RVA: 0x0002422C File Offset: 0x0002242C
		// (set) Token: 0x0600036F RID: 879 RVA: 0x000032BE File Offset: 0x000014BE
		public unsafe string prefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_prefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_prefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00024254 File Offset: 0x00022454
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000032DD File Offset: 0x000014DD
		public unsafe string nameWPrefix
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nameWPrefix), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000372 RID: 882 RVA: 0x0002427C File Offset: 0x0002247C
		// (set) Token: 0x06000373 RID: 883 RVA: 0x000032FC File Offset: 0x000014FC
		public unsafe string rawValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_rawValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000242A4 File Offset: 0x000224A4
		// (set) Token: 0x06000375 RID: 885 RVA: 0x0000331B File Offset: 0x0000151B
		public unsafe string originalStringValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_originalStringValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000242CC File Offset: 0x000224CC
		// (set) Token: 0x06000377 RID: 887 RVA: 0x0000333A File Offset: 0x0000153A
		public unsafe int depth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_depth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_depth)) = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000242F4 File Offset: 0x000224F4
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00003355 File Offset: 0x00001555
		public unsafe AttributePSVIInfo attributePSVIInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributePSVIInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_attributePSVIInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00024324 File Offset: 0x00022524
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00003374 File Offset: 0x00001574
		public unsafe XmlNodeType nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_nodeType)) = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0002434C File Offset: 0x0002254C
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0000338F File Offset: 0x0000158F
		public unsafe int lineNo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_lineNo)) = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00024374 File Offset: 0x00022574
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000033AA File Offset: 0x000015AA
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidatingReaderNodeData.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeFieldInfoPtr_localName;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_namespaceUri;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_prefix;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_nameWPrefix;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_rawValue;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_originalStringValue;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeFieldInfoPtr_depth;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeFieldInfoPtr_attributePSVIInfo;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeFieldInfoPtr_nodeType;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeFieldInfoPtr_lineNo;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlNodeType_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalName_Public_get_String_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalName_Public_set_Void_String_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_get_Prefix_Public_get_String_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_set_Prefix_Public_set_Void_String_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_GetAtomizedNameWPrefix_Public_String_XmlNameTable_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_get_Depth_Public_get_Int32_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_set_Depth_Public_set_Void_Int32_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_get_RawValue_Public_get_String_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_set_RawValue_Public_set_Void_String_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalStringValue_Public_get_String_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_get_NodeType_Public_get_XmlNodeType_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_set_NodeType_Public_set_Void_XmlNodeType_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_get_AttInfo_Public_get_AttributePSVIInfo_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_set_AttInfo_Public_set_Void_AttributePSVIInfo_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_get_Int32_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_get_Int32_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_XmlNodeType_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_Int32_Int32_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_SetLineInfo_Internal_Void_IXmlLineInfo_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_String_Int32_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_SetItemData_Internal_Void_String_String_0;
	}
}
