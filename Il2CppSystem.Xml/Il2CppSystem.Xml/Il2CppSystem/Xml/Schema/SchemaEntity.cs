using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000187 RID: 391
	public sealed class SchemaEntity : Object
	{
		// Token: 0x06001FE7 RID: 8167 RVA: 0x0009CA8C File Offset: 0x0009AC8C
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaEntity()
		{
			Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaEntity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr);
			SchemaEntity.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "qname");
			SchemaEntity.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "url");
			SchemaEntity.NativeFieldInfoPtr_pubid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "pubid");
			SchemaEntity.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "text");
			SchemaEntity.NativeFieldInfoPtr_ndata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "ndata");
			SchemaEntity.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "lineNumber");
			SchemaEntity.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "linePosition");
			SchemaEntity.NativeFieldInfoPtr_isParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isParameter");
			SchemaEntity.NativeFieldInfoPtr_isExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isExternal");
			SchemaEntity.NativeFieldInfoPtr_parsingInProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "parsingInProgress");
			SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "isDeclaredInExternal");
			SchemaEntity.NativeFieldInfoPtr_baseURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "baseURI");
			SchemaEntity.NativeFieldInfoPtr_declaredURI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, "declaredURI");
			SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668096);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668097);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668098);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668099);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668100);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668101);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668102);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668103);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668104);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668105);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668106);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668107);
			SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668108);
			SchemaEntity.NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668109);
			SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668110);
			SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668111);
			SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668112);
			SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668113);
			SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668114);
			SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668115);
			SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668116);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668117);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668118);
			SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668119);
			SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668120);
			SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668121);
			SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668122);
			SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668123);
			SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668124);
			SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668125);
			SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668126);
			SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668127);
			SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668128);
			SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668129);
			SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668130);
			SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668131);
			SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr, 100668132);
		}

		// Token: 0x06001FE8 RID: 8168 RVA: 0x0009CEA4 File Offset: 0x0009B0A4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403705, RefRangeEnd = 403708, XrefRangeStart = 403698, XrefRangeEnd = 403705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaEntity(XmlQualifiedName qname, bool isParameter)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaEntity>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isParameter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06001FE9 RID: 8169 RVA: 0x0009CF00 File Offset: 0x0009B100
		public unsafe string System.Xml.IDtdEntityInfo.Name
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06001FEA RID: 8170 RVA: 0x0009CF38 File Offset: 0x0009B138
		public unsafe bool System.Xml.IDtdEntityInfo.IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06001FEB RID: 8171 RVA: 0x0009CF74 File Offset: 0x0009B174
		public unsafe bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06001FEC RID: 8172 RVA: 0x0009CFB0 File Offset: 0x0009B1B0
		public unsafe bool System.Xml.IDtdEntityInfo.IsUnparsedEntity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403708, XrefRangeEnd = 403709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06001FED RID: 8173 RVA: 0x0009CFEC File Offset: 0x0009B1EC
		public unsafe bool System.Xml.IDtdEntityInfo.IsParameterEntity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001FEE RID: 8174 RVA: 0x0009D028 File Offset: 0x0009B228
		public unsafe string System.Xml.IDtdEntityInfo.BaseUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403709, XrefRangeEnd = 403711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001FEF RID: 8175 RVA: 0x0009D060 File Offset: 0x0009B260
		public unsafe string System.Xml.IDtdEntityInfo.DeclaredUriString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403711, XrefRangeEnd = 403713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06001FF0 RID: 8176 RVA: 0x0009D098 File Offset: 0x0009B298
		public unsafe string System.Xml.IDtdEntityInfo.SystemId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06001FF1 RID: 8177 RVA: 0x0009D0D0 File Offset: 0x0009B2D0
		public unsafe string System.Xml.IDtdEntityInfo.PublicId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06001FF2 RID: 8178 RVA: 0x0009D108 File Offset: 0x0009B308
		public unsafe string System.Xml.IDtdEntityInfo.Text
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0009D140 File Offset: 0x0009B340
		public unsafe int System.Xml.IDtdEntityInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06001FF4 RID: 8180 RVA: 0x0009D17C File Offset: 0x0009B37C
		public unsafe int System.Xml.IDtdEntityInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0009D1B8 File Offset: 0x0009B3B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403728, RefRangeEnd = 403729, XrefRangeStart = 403713, XrefRangeEnd = 403728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPredefinedEntity(string n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(n);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06001FF6 RID: 8182 RVA: 0x0009D1FC File Offset: 0x0009B3FC
		public unsafe XmlQualifiedName Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06001FF7 RID: 8183 RVA: 0x0009D23C File Offset: 0x0009B43C
		// (set) Token: 0x06001FF8 RID: 8184 RVA: 0x0009D274 File Offset: 0x0009B474
		public unsafe string Url
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Url_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 403730, RefRangeEnd = 403731, XrefRangeStart = 403729, XrefRangeEnd = 403730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06001FF9 RID: 8185 RVA: 0x0009D2B8 File Offset: 0x0009B4B8
		// (set) Token: 0x06001FFA RID: 8186 RVA: 0x0009D2F0 File Offset: 0x0009B4F0
		public unsafe string Pubid
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pubid_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06001FFB RID: 8187 RVA: 0x0009D334 File Offset: 0x0009B534
		// (set) Token: 0x06001FFC RID: 8188 RVA: 0x0009D370 File Offset: 0x0009B570
		public unsafe bool IsExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06001FFD RID: 8189 RVA: 0x0009D3B0 File Offset: 0x0009B5B0
		// (set) Token: 0x06001FFE RID: 8190 RVA: 0x0009D3EC File Offset: 0x0009B5EC
		public unsafe bool DeclaredInExternal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06001FFF RID: 8191 RVA: 0x0009D42C File Offset: 0x0009B62C
		// (set) Token: 0x06002000 RID: 8192 RVA: 0x0009D46C File Offset: 0x0009B66C
		public unsafe XmlQualifiedName NData
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06002001 RID: 8193 RVA: 0x0009D4B0 File Offset: 0x0009B6B0
		// (set) Token: 0x06002002 RID: 8194 RVA: 0x0009D4E8 File Offset: 0x0009B6E8
		public unsafe string Text
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Text_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403732, RefRangeEnd = 403735, XrefRangeStart = 403731, XrefRangeEnd = 403732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06002003 RID: 8195 RVA: 0x0009D52C File Offset: 0x0009B72C
		// (set) Token: 0x06002004 RID: 8196 RVA: 0x0009D568 File Offset: 0x0009B768
		public unsafe int Line
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Line_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 170594, RefRangeEnd = 170603, XrefRangeStart = 170594, XrefRangeEnd = 170603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06002005 RID: 8197 RVA: 0x0009D5A8 File Offset: 0x0009B7A8
		// (set) Token: 0x06002006 RID: 8198 RVA: 0x0009D5E4 File Offset: 0x0009B7E4
		public unsafe int Pos
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06002007 RID: 8199 RVA: 0x0009D624 File Offset: 0x0009B824
		// (set) Token: 0x06002008 RID: 8200 RVA: 0x0009D65C File Offset: 0x0009B85C
		public unsafe string BaseURI
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403735, XrefRangeEnd = 403737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x0009D6A0 File Offset: 0x0009B8A0
		// (set) Token: 0x0600200A RID: 8202 RVA: 0x0009D6DC File Offset: 0x0009B8DC
		public unsafe bool ParsingInProgress
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x0600200B RID: 8203 RVA: 0x0009D71C File Offset: 0x0009B91C
		// (set) Token: 0x0600200C RID: 8204 RVA: 0x0009D754 File Offset: 0x0009B954
		public unsafe string DeclaredURI
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 403739, RefRangeEnd = 403741, XrefRangeStart = 403737, XrefRangeEnd = 403739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaEntity.NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600200D RID: 8205 RVA: 0x0000CFCE File Offset: 0x0000B1CE
		public SchemaEntity(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0009D798 File Offset: 0x0009B998
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0000CFD7 File Offset: 0x0000B1D7
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06002010 RID: 8208 RVA: 0x0009D7C8 File Offset: 0x0009B9C8
		// (set) Token: 0x06002011 RID: 8209 RVA: 0x0000CFF6 File Offset: 0x0000B1F6
		public unsafe string url
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0009D7F0 File Offset: 0x0009B9F0
		// (set) Token: 0x06002013 RID: 8211 RVA: 0x0000D015 File Offset: 0x0000B215
		public unsafe string pubid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_pubid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0009D818 File Offset: 0x0009BA18
		// (set) Token: 0x06002015 RID: 8213 RVA: 0x0000D034 File Offset: 0x0000B234
		public unsafe string text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06002016 RID: 8214 RVA: 0x0009D840 File Offset: 0x0009BA40
		// (set) Token: 0x06002017 RID: 8215 RVA: 0x0000D053 File Offset: 0x0000B253
		public unsafe XmlQualifiedName ndata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_ndata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06002018 RID: 8216 RVA: 0x0009D870 File Offset: 0x0009BA70
		// (set) Token: 0x06002019 RID: 8217 RVA: 0x0000D072 File Offset: 0x0000B272
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x0600201A RID: 8218 RVA: 0x0009D898 File Offset: 0x0009BA98
		// (set) Token: 0x0600201B RID: 8219 RVA: 0x0000D08D File Offset: 0x0000B28D
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x0600201C RID: 8220 RVA: 0x0009D8C0 File Offset: 0x0009BAC0
		// (set) Token: 0x0600201D RID: 8221 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		public unsafe bool isParameter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isParameter)) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x0600201E RID: 8222 RVA: 0x0009D8E8 File Offset: 0x0009BAE8
		// (set) Token: 0x0600201F RID: 8223 RVA: 0x0000D0C3 File Offset: 0x0000B2C3
		public unsafe bool isExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isExternal)) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002020 RID: 8224 RVA: 0x0009D910 File Offset: 0x0009BB10
		// (set) Token: 0x06002021 RID: 8225 RVA: 0x0000D0DE File Offset: 0x0000B2DE
		public unsafe bool parsingInProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_parsingInProgress)) = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06002022 RID: 8226 RVA: 0x0009D938 File Offset: 0x0009BB38
		// (set) Token: 0x06002023 RID: 8227 RVA: 0x0000D0F9 File Offset: 0x0000B2F9
		public unsafe bool isDeclaredInExternal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_isDeclaredInExternal)) = value;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06002024 RID: 8228 RVA: 0x0009D960 File Offset: 0x0009BB60
		// (set) Token: 0x06002025 RID: 8229 RVA: 0x0000D114 File Offset: 0x0000B314
		public unsafe string baseURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_baseURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06002026 RID: 8230 RVA: 0x0009D988 File Offset: 0x0009BB88
		// (set) Token: 0x06002027 RID: 8231 RVA: 0x0000D133 File Offset: 0x0000B333
		public unsafe string declaredURI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaEntity.NativeFieldInfoPtr_declaredURI), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001856 RID: 6230
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04001857 RID: 6231
		private static readonly IntPtr NativeFieldInfoPtr_url;

		// Token: 0x04001858 RID: 6232
		private static readonly IntPtr NativeFieldInfoPtr_pubid;

		// Token: 0x04001859 RID: 6233
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x0400185A RID: 6234
		private static readonly IntPtr NativeFieldInfoPtr_ndata;

		// Token: 0x0400185B RID: 6235
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x0400185C RID: 6236
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x0400185D RID: 6237
		private static readonly IntPtr NativeFieldInfoPtr_isParameter;

		// Token: 0x0400185E RID: 6238
		private static readonly IntPtr NativeFieldInfoPtr_isExternal;

		// Token: 0x0400185F RID: 6239
		private static readonly IntPtr NativeFieldInfoPtr_parsingInProgress;

		// Token: 0x04001860 RID: 6240
		private static readonly IntPtr NativeFieldInfoPtr_isDeclaredInExternal;

		// Token: 0x04001861 RID: 6241
		private static readonly IntPtr NativeFieldInfoPtr_baseURI;

		// Token: 0x04001862 RID: 6242
		private static readonly IntPtr NativeFieldInfoPtr_declaredURI;

		// Token: 0x04001863 RID: 6243
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_Boolean_0;

		// Token: 0x04001864 RID: 6244
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Name_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001865 RID: 6245
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001866 RID: 6246
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001867 RID: 6247
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsUnparsedEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001868 RID: 6248
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_IsParameterEntity_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001869 RID: 6249
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_BaseUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400186A RID: 6250
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_DeclaredUriString_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400186B RID: 6251
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_SystemId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_PublicId_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_Text_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdEntityInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeMethodInfoPtr_IsPredefinedEntity_Internal_Static_Boolean_String_0;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Internal_get_XmlQualifiedName_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_get_Url_Internal_get_String_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_set_Url_Internal_set_Void_String_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_get_Pubid_Internal_get_String_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_set_Pubid_Internal_set_Void_String_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_get_IsExternal_Internal_get_Boolean_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_set_IsExternal_Internal_set_Void_Boolean_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredInExternal_Internal_get_Boolean_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredInExternal_Internal_set_Void_Boolean_0;

		// Token: 0x0400187A RID: 6266
		private static readonly IntPtr NativeMethodInfoPtr_get_NData_Internal_get_XmlQualifiedName_0;

		// Token: 0x0400187B RID: 6267
		private static readonly IntPtr NativeMethodInfoPtr_set_NData_Internal_set_Void_XmlQualifiedName_0;

		// Token: 0x0400187C RID: 6268
		private static readonly IntPtr NativeMethodInfoPtr_get_Text_Internal_get_String_0;

		// Token: 0x0400187D RID: 6269
		private static readonly IntPtr NativeMethodInfoPtr_set_Text_Internal_set_Void_String_0;

		// Token: 0x0400187E RID: 6270
		private static readonly IntPtr NativeMethodInfoPtr_get_Line_Internal_get_Int32_0;

		// Token: 0x0400187F RID: 6271
		private static readonly IntPtr NativeMethodInfoPtr_set_Line_Internal_set_Void_Int32_0;

		// Token: 0x04001880 RID: 6272
		private static readonly IntPtr NativeMethodInfoPtr_get_Pos_Internal_get_Int32_0;

		// Token: 0x04001881 RID: 6273
		private static readonly IntPtr NativeMethodInfoPtr_set_Pos_Internal_set_Void_Int32_0;

		// Token: 0x04001882 RID: 6274
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseURI_Internal_get_String_0;

		// Token: 0x04001883 RID: 6275
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseURI_Internal_set_Void_String_0;

		// Token: 0x04001884 RID: 6276
		private static readonly IntPtr NativeMethodInfoPtr_get_ParsingInProgress_Internal_get_Boolean_0;

		// Token: 0x04001885 RID: 6277
		private static readonly IntPtr NativeMethodInfoPtr_set_ParsingInProgress_Internal_set_Void_Boolean_0;

		// Token: 0x04001886 RID: 6278
		private static readonly IntPtr NativeMethodInfoPtr_get_DeclaredURI_Internal_get_String_0;

		// Token: 0x04001887 RID: 6279
		private static readonly IntPtr NativeMethodInfoPtr_set_DeclaredURI_Internal_set_Void_String_0;
	}
}
