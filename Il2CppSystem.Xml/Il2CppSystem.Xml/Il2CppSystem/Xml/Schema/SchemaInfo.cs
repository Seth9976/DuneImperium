using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000189 RID: 393
	public class SchemaInfo : Object
	{
		// Token: 0x06002028 RID: 8232 RVA: 0x0009D9B0 File Offset: 0x0009BBB0
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaInfo()
		{
			Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr);
			SchemaInfo.NativeFieldInfoPtr_elementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDecls");
			SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "undeclaredElementDecls");
			SchemaInfo.NativeFieldInfoPtr_generalEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "generalEntities");
			SchemaInfo.NativeFieldInfoPtr_parameterEntities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "parameterEntities");
			SchemaInfo.NativeFieldInfoPtr_docTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "docTypeName");
			SchemaInfo.NativeFieldInfoPtr_internalDtdSubset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "internalDtdSubset");
			SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasNonCDataAttributes");
			SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "hasDefaultAttributes");
			SchemaInfo.NativeFieldInfoPtr_targetNamespaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "targetNamespaces");
			SchemaInfo.NativeFieldInfoPtr_attributeDecls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "attributeDecls");
			SchemaInfo.NativeFieldInfoPtr_errorCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "errorCount");
			SchemaInfo.NativeFieldInfoPtr_schemaType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "schemaType");
			SchemaInfo.NativeFieldInfoPtr_elementDeclsByType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "elementDeclsByType");
			SchemaInfo.NativeFieldInfoPtr_notations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, "notations");
			SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668133);
			SchemaInfo.NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668134);
			SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668135);
			SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668136);
			SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668137);
			SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668138);
			SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668139);
			SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668140);
			SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668141);
			SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668142);
			SchemaInfo.NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668143);
			SchemaInfo.NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668144);
			SchemaInfo.NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668145);
			SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668146);
			SchemaInfo.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668147);
			SchemaInfo.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668148);
			SchemaInfo.NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668149);
			SchemaInfo.NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668150);
			SchemaInfo.NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668151);
			SchemaInfo.NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668152);
			SchemaInfo.NativeMethodInfoPtr_Contains_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668153);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668154);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668155);
			SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668156);
			SchemaInfo.NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668157);
			SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668158);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668159);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668160);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668161);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668162);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668163);
			SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr, 100668164);
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x0009DD78 File Offset: 0x0009BF78
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 403781, RefRangeEnd = 403796, XrefRangeStart = 403741, XrefRangeEnd = 403781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600202A RID: 8234 RVA: 0x0009DDB4 File Offset: 0x0009BFB4
		// (set) Token: 0x0600202B RID: 8235 RVA: 0x0009DDF4 File Offset: 0x0009BFF4
		public unsafe XmlQualifiedName DocTypeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (set) Token: 0x0600202C RID: 8236 RVA: 0x0009DE38 File Offset: 0x0009C038
		public unsafe string InternalDtdSubset
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x0600202D RID: 8237 RVA: 0x0009DE7C File Offset: 0x0009C07C
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDecls
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x0600202E RID: 8238 RVA: 0x0009DEBC File Offset: 0x0009C0BC
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> UndeclaredElementDecls
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x0600202F RID: 8239 RVA: 0x0009DEFC File Offset: 0x0009C0FC
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> GeneralEntities
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 403803, RefRangeEnd = 403812, XrefRangeStart = 403796, XrefRangeEnd = 403803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002030 RID: 8240 RVA: 0x0009DF3C File Offset: 0x0009C13C
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> ParameterEntities
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 403819, RefRangeEnd = 403825, XrefRangeStart = 403812, XrefRangeEnd = 403819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr3) : null;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002031 RID: 8241 RVA: 0x0009DF7C File Offset: 0x0009C17C
		// (set) Token: 0x06002032 RID: 8242 RVA: 0x0009DFB8 File Offset: 0x0009C1B8
		public unsafe SchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 403825, RefRangeEnd = 403834, XrefRangeStart = 403825, XrefRangeEnd = 403825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06002033 RID: 8243 RVA: 0x0009DFF8 File Offset: 0x0009C1F8
		public unsafe Dictionary<string, bool> TargetNamespaces
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x0009E038 File Offset: 0x0009C238
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> ElementDeclsByType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06002035 RID: 8245 RVA: 0x0009E078 File Offset: 0x0009C278
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttributeDecls
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002036 RID: 8246 RVA: 0x0009E0B8 File Offset: 0x0009C2B8
		public unsafe Dictionary<string, SchemaNotation> Notations
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 403841, RefRangeEnd = 403849, XrefRangeStart = 403834, XrefRangeEnd = 403841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002037 RID: 8247 RVA: 0x0009E0F8 File Offset: 0x0009C2F8
		// (set) Token: 0x06002038 RID: 8248 RVA: 0x0009E134 File Offset: 0x0009C334
		public unsafe int ErrorCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403849, RefRangeEnd = 403852, XrefRangeStart = 403849, XrefRangeEnd = 403849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x0009E174 File Offset: 0x0009C374
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 403855, RefRangeEnd = 403860, XrefRangeStart = 403852, XrefRangeEnd = 403855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetElementDecl(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x0009E1C4 File Offset: 0x0009C3C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403863, RefRangeEnd = 403864, XrefRangeStart = 403860, XrefRangeEnd = 403863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl GetTypeDecl(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x0009E214 File Offset: 0x0009C414
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403867, RefRangeEnd = 403869, XrefRangeStart = 403864, XrefRangeEnd = 403867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement GetElement(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0009E264 File Offset: 0x0009C464
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403873, RefRangeEnd = 403874, XrefRangeStart = 403869, XrefRangeEnd = 403873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasSchema(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x0009E2B4 File Offset: 0x0009C4B4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 403878, RefRangeEnd = 403884, XrefRangeStart = 403874, XrefRangeEnd = 403878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(string ns)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ns);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Contains_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x0009E304 File Offset: 0x0009C504
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403892, RefRangeEnd = 403893, XrefRangeStart = 403884, XrefRangeEnd = 403892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXdr(SchemaElementDecl ed, XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0009E368 File Offset: 0x0009C568
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 403916, RefRangeEnd = 403918, XrefRangeStart = 403893, XrefRangeEnd = 403916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, XmlSchemaObject partialValidationType, out AttributeMatchState attributeMatchState)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partialValidationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &attributeMatchState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0009E3EC File Offset: 0x0009C5EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403919, RefRangeEnd = 403920, XrefRangeStart = 403918, XrefRangeEnd = 403919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttributeXsd(SchemaElementDecl ed, XmlQualifiedName qname, ref bool skip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ed);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(qname);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &skip;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x0009E45C File Offset: 0x0009C65C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 403961, RefRangeEnd = 403971, XrefRangeStart = 403920, XrefRangeEnd = 403961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(SchemaInfo sinfo, ValidationEventHandler eventhandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventhandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0009E4B0 File Offset: 0x0009C6B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403989, RefRangeEnd = 403990, XrefRangeStart = 403971, XrefRangeEnd = 403989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Finish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_Finish_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x0009E4E4 File Offset: 0x0009C6E4
		public unsafe virtual bool System.Xml.IDtdInfo.HasDefaultAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x0009E520 File Offset: 0x0009C720
		public unsafe virtual bool System.Xml.IDtdInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x0009E55C File Offset: 0x0009C75C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403990, XrefRangeEnd = 403999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdAttributeListInfo System_Xml_IDtdInfo_LookupAttributeList(string prefix, string localName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeListInfo>(intPtr3) : null;
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x0009E5C0 File Offset: 0x0009C7C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403999, XrefRangeEnd = 404006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IDtdEntityInfo System_Xml_IDtdInfo_LookupEntity(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdEntityInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0009E610 File Offset: 0x0009C810
		public unsafe virtual XmlQualifiedName System.Xml.IDtdInfo.Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x0009E650 File Offset: 0x0009C850
		public unsafe virtual string System.Xml.IDtdInfo.InternalDtdSubset
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaInfo.NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0000D152 File Offset: 0x0000B352
		public SchemaInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x0600204A RID: 8266 RVA: 0x0009E688 File Offset: 0x0009C888
		// (set) Token: 0x0600204B RID: 8267 RVA: 0x0000D15B File Offset: 0x0000B35B
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x0600204C RID: 8268 RVA: 0x0009E6B8 File Offset: 0x0009C8B8
		// (set) Token: 0x0600204D RID: 8269 RVA: 0x0000D17A File Offset: 0x0000B37A
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> undeclaredElementDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_undeclaredElementDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600204E RID: 8270 RVA: 0x0009E6E8 File Offset: 0x0009C8E8
		// (set) Token: 0x0600204F RID: 8271 RVA: 0x0000D199 File Offset: 0x0000B399
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> generalEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_generalEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002050 RID: 8272 RVA: 0x0009E718 File Offset: 0x0009C918
		// (set) Token: 0x06002051 RID: 8273 RVA: 0x0000D1B8 File Offset: 0x0000B3B8
		public unsafe Dictionary<XmlQualifiedName, SchemaEntity> parameterEntities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaEntity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_parameterEntities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0009E748 File Offset: 0x0009C948
		// (set) Token: 0x06002053 RID: 8275 RVA: 0x0000D1D7 File Offset: 0x0000B3D7
		public unsafe XmlQualifiedName docTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_docTypeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002054 RID: 8276 RVA: 0x0009E778 File Offset: 0x0009C978
		// (set) Token: 0x06002055 RID: 8277 RVA: 0x0000D1F6 File Offset: 0x0000B3F6
		public unsafe string internalDtdSubset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_internalDtdSubset), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002056 RID: 8278 RVA: 0x0009E7A0 File Offset: 0x0009C9A0
		// (set) Token: 0x06002057 RID: 8279 RVA: 0x0000D215 File Offset: 0x0000B415
		public unsafe bool hasNonCDataAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasNonCDataAttributes)) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002058 RID: 8280 RVA: 0x0009E7C8 File Offset: 0x0009C9C8
		// (set) Token: 0x06002059 RID: 8281 RVA: 0x0000D230 File Offset: 0x0000B430
		public unsafe bool hasDefaultAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_hasDefaultAttributes)) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x0600205A RID: 8282 RVA: 0x0009E7F0 File Offset: 0x0009C9F0
		// (set) Token: 0x0600205B RID: 8283 RVA: 0x0000D24B File Offset: 0x0000B44B
		public unsafe Dictionary<string, bool> targetNamespaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_targetNamespaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x0600205C RID: 8284 RVA: 0x0009E820 File Offset: 0x0009CA20
		// (set) Token: 0x0600205D RID: 8285 RVA: 0x0000D26A File Offset: 0x0000B46A
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attributeDecls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_attributeDecls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x0600205E RID: 8286 RVA: 0x0009E850 File Offset: 0x0009CA50
		// (set) Token: 0x0600205F RID: 8287 RVA: 0x0000D289 File Offset: 0x0000B489
		public unsafe int errorCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_errorCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_errorCount)) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002060 RID: 8288 RVA: 0x0009E878 File Offset: 0x0009CA78
		// (set) Token: 0x06002061 RID: 8289 RVA: 0x0000D2A4 File Offset: 0x0000B4A4
		public unsafe SchemaType schemaType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_schemaType)) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06002062 RID: 8290 RVA: 0x0009E8A0 File Offset: 0x0009CAA0
		// (set) Token: 0x06002063 RID: 8291 RVA: 0x0000D2BF File Offset: 0x0000B4BF
		public unsafe Dictionary<XmlQualifiedName, SchemaElementDecl> elementDeclsByType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaElementDecl>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_elementDeclsByType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06002064 RID: 8292 RVA: 0x0009E8D0 File Offset: 0x0009CAD0
		// (set) Token: 0x06002065 RID: 8293 RVA: 0x0000D2DE File Offset: 0x0000B4DE
		public unsafe Dictionary<string, SchemaNotation> notations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SchemaNotation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaInfo.NativeFieldInfoPtr_notations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001893 RID: 6291
		private static readonly IntPtr NativeFieldInfoPtr_elementDecls;

		// Token: 0x04001894 RID: 6292
		private static readonly IntPtr NativeFieldInfoPtr_undeclaredElementDecls;

		// Token: 0x04001895 RID: 6293
		private static readonly IntPtr NativeFieldInfoPtr_generalEntities;

		// Token: 0x04001896 RID: 6294
		private static readonly IntPtr NativeFieldInfoPtr_parameterEntities;

		// Token: 0x04001897 RID: 6295
		private static readonly IntPtr NativeFieldInfoPtr_docTypeName;

		// Token: 0x04001898 RID: 6296
		private static readonly IntPtr NativeFieldInfoPtr_internalDtdSubset;

		// Token: 0x04001899 RID: 6297
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttributes;

		// Token: 0x0400189A RID: 6298
		private static readonly IntPtr NativeFieldInfoPtr_hasDefaultAttributes;

		// Token: 0x0400189B RID: 6299
		private static readonly IntPtr NativeFieldInfoPtr_targetNamespaces;

		// Token: 0x0400189C RID: 6300
		private static readonly IntPtr NativeFieldInfoPtr_attributeDecls;

		// Token: 0x0400189D RID: 6301
		private static readonly IntPtr NativeFieldInfoPtr_errorCount;

		// Token: 0x0400189E RID: 6302
		private static readonly IntPtr NativeFieldInfoPtr_schemaType;

		// Token: 0x0400189F RID: 6303
		private static readonly IntPtr NativeFieldInfoPtr_elementDeclsByType;

		// Token: 0x040018A0 RID: 6304
		private static readonly IntPtr NativeFieldInfoPtr_notations;

		// Token: 0x040018A1 RID: 6305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040018A2 RID: 6306
		private static readonly IntPtr NativeMethodInfoPtr_get_DocTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x040018A3 RID: 6307
		private static readonly IntPtr NativeMethodInfoPtr_set_DocTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x040018A4 RID: 6308
		private static readonly IntPtr NativeMethodInfoPtr_set_InternalDtdSubset_Internal_set_Void_String_0;

		// Token: 0x040018A5 RID: 6309
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040018A6 RID: 6310
		private static readonly IntPtr NativeMethodInfoPtr_get_UndeclaredElementDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040018A7 RID: 6311
		private static readonly IntPtr NativeMethodInfoPtr_get_GeneralEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x040018A8 RID: 6312
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterEntities_Internal_get_Dictionary_2_XmlQualifiedName_SchemaEntity_0;

		// Token: 0x040018A9 RID: 6313
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Internal_get_SchemaType_0;

		// Token: 0x040018AA RID: 6314
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Internal_set_Void_SchemaType_0;

		// Token: 0x040018AB RID: 6315
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetNamespaces_Internal_get_Dictionary_2_String_Boolean_0;

		// Token: 0x040018AC RID: 6316
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDeclsByType_Internal_get_Dictionary_2_XmlQualifiedName_SchemaElementDecl_0;

		// Token: 0x040018AD RID: 6317
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeDecls_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;

		// Token: 0x040018AE RID: 6318
		private static readonly IntPtr NativeMethodInfoPtr_get_Notations_Internal_get_Dictionary_2_String_SchemaNotation_0;

		// Token: 0x040018AF RID: 6319
		private static readonly IntPtr NativeMethodInfoPtr_get_ErrorCount_Internal_get_Int32_0;

		// Token: 0x040018B0 RID: 6320
		private static readonly IntPtr NativeMethodInfoPtr_set_ErrorCount_Internal_set_Void_Int32_0;

		// Token: 0x040018B1 RID: 6321
		private static readonly IntPtr NativeMethodInfoPtr_GetElementDecl_Internal_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040018B2 RID: 6322
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDecl_Internal_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040018B3 RID: 6323
		private static readonly IntPtr NativeMethodInfoPtr_GetElement_Internal_XmlSchemaElement_XmlQualifiedName_0;

		// Token: 0x040018B4 RID: 6324
		private static readonly IntPtr NativeMethodInfoPtr_HasSchema_Internal_Boolean_String_0;

		// Token: 0x040018B5 RID: 6325
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Internal_Boolean_String_0;

		// Token: 0x040018B6 RID: 6326
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXdr_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_0;

		// Token: 0x040018B7 RID: 6327
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_XmlSchemaObject_byref_AttributeMatchState_0;

		// Token: 0x040018B8 RID: 6328
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeXsd_Internal_SchemaAttDef_SchemaElementDecl_XmlQualifiedName_byref_Boolean_0;

		// Token: 0x040018B9 RID: 6329
		private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_SchemaInfo_ValidationEventHandler_0;

		// Token: 0x040018BA RID: 6330
		private static readonly IntPtr NativeMethodInfoPtr_Finish_Internal_Void_0;

		// Token: 0x040018BB RID: 6331
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasDefaultAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040018BC RID: 6332
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040018BD RID: 6333
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupAttributeList_Private_Virtual_Final_New_IDtdAttributeListInfo_String_String_0;

		// Token: 0x040018BE RID: 6334
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_LookupEntity_Private_Virtual_Final_New_IDtdEntityInfo_String_0;

		// Token: 0x040018BF RID: 6335
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_Name_Private_Virtual_Final_New_get_XmlQualifiedName_0;

		// Token: 0x040018C0 RID: 6336
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdInfo_get_InternalDtdSubset_Private_Virtual_Final_New_get_String_0;
	}
}
