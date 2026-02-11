using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000186 RID: 390
	public sealed class SchemaElementDecl : SchemaDeclBase
	{
		// Token: 0x06001FA3 RID: 8099 RVA: 0x0009BA80 File Offset: 0x00099C80
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaElementDecl()
		{
			Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaElementDecl");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr);
			SchemaElementDecl.NativeFieldInfoPtr_attdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "attdefs");
			SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "defaultAttdefs");
			SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isIdDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasNonCDataAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_isAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isAbstract");
			SchemaElementDecl.NativeFieldInfoPtr_isNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNillable");
			SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "hasRequiredAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "isNotationDeclared");
			SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "prohibitedAttributes");
			SchemaElementDecl.NativeFieldInfoPtr_contentValidator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "contentValidator");
			SchemaElementDecl.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "anyAttribute");
			SchemaElementDecl.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "block");
			SchemaElementDecl.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "constraints");
			SchemaElementDecl.NativeFieldInfoPtr_schemaElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "schemaElement");
			SchemaElementDecl.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, "Empty");
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668059);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668060);
			SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668061);
			SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668062);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668063);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668064);
			SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668065);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668066);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668067);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668068);
			SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668069);
			SchemaElementDecl.NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668070);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668071);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668072);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668073);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668074);
			SchemaElementDecl.NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668075);
			SchemaElementDecl.NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668076);
			SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668077);
			SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668078);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668079);
			SchemaElementDecl.NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668080);
			SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668081);
			SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668082);
			SchemaElementDecl.NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668083);
			SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668084);
			SchemaElementDecl.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668085);
			SchemaElementDecl.NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668086);
			SchemaElementDecl.NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668087);
			SchemaElementDecl.NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668088);
			SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668089);
			SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668090);
			SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668091);
			SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668092);
			SchemaElementDecl.NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668093);
			SchemaElementDecl.NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr, 100668094);
		}

		// Token: 0x06001FA4 RID: 8100 RVA: 0x0009BEAC File Offset: 0x0009A0AC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 403558, RefRangeEnd = 403563, XrefRangeStart = 403538, XrefRangeEnd = 403558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA5 RID: 8101 RVA: 0x0009BEE8 File Offset: 0x0009A0E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403589, RefRangeEnd = 403592, XrefRangeStart = 403563, XrefRangeEnd = 403589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlSchemaDatatype dtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dtype);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FA6 RID: 8102 RVA: 0x0009BF34 File Offset: 0x0009A134
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403614, RefRangeEnd = 403617, XrefRangeStart = 403592, XrefRangeEnd = 403614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaElementDecl>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FA7 RID: 8103 RVA: 0x0009BF94 File Offset: 0x0009A194
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 403629, RefRangeEnd = 403630, XrefRangeStart = 403617, XrefRangeEnd = 403629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SchemaElementDecl CreateAnyTypeElementDecl()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06001FA8 RID: 8104 RVA: 0x0009BFC8 File Offset: 0x0009A1C8
		public unsafe bool System.Xml.IDtdAttributeListInfo.HasNonCDataAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x0009C004 File Offset: 0x0009A204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 403630, XrefRangeEnd = 403637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IDtdAttributeInfo System_Xml_IDtdAttributeListInfo_LookupAttribute(string prefix, string localName)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDtdAttributeInfo>(intPtr3) : null;
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x0009C068 File Offset: 0x0009A268
		[CallerCount(0)]
		public unsafe IEnumerable<IDtdDefaultAttributeInfo> System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IDtdDefaultAttributeInfo>>(intPtr3) : null;
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06001FAB RID: 8107 RVA: 0x0009C0A8 File Offset: 0x0009A2A8
		// (set) Token: 0x06001FAC RID: 8108 RVA: 0x0009C0E4 File Offset: 0x0009A2E4
		public unsafe bool IsIdDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06001FAD RID: 8109 RVA: 0x0009C124 File Offset: 0x0009A324
		// (set) Token: 0x06001FAE RID: 8110 RVA: 0x0009C160 File Offset: 0x0009A360
		public unsafe bool HasNonCDataAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x0009C1A0 File Offset: 0x0009A3A0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 403640, RefRangeEnd = 403651, XrefRangeStart = 403637, XrefRangeEnd = 403640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaElementDecl Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06001FB0 RID: 8112 RVA: 0x0009C1E0 File Offset: 0x0009A3E0
		// (set) Token: 0x06001FB1 RID: 8113 RVA: 0x0009C21C File Offset: 0x0009A41C
		public unsafe bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06001FB2 RID: 8114 RVA: 0x0009C25C File Offset: 0x0009A45C
		// (set) Token: 0x06001FB3 RID: 8115 RVA: 0x0009C298 File Offset: 0x0009A498
		public unsafe bool IsNillable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06001FB4 RID: 8116 RVA: 0x0009C2D8 File Offset: 0x0009A4D8
		// (set) Token: 0x06001FB5 RID: 8117 RVA: 0x0009C314 File Offset: 0x0009A514
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06001FB6 RID: 8118 RVA: 0x0009C354 File Offset: 0x0009A554
		// (set) Token: 0x06001FB7 RID: 8119 RVA: 0x0009C390 File Offset: 0x0009A590
		public unsafe bool IsNotationDeclared
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06001FB8 RID: 8120 RVA: 0x0009C3D0 File Offset: 0x0009A5D0
		public unsafe bool HasDefaultAttribute
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 403651, RefRangeEnd = 403654, XrefRangeStart = 403651, XrefRangeEnd = 403651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06001FB9 RID: 8121 RVA: 0x0009C40C File Offset: 0x0009A60C
		public unsafe bool HasRequiredAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06001FBA RID: 8122 RVA: 0x0009C448 File Offset: 0x0009A648
		// (set) Token: 0x06001FBB RID: 8123 RVA: 0x0009C488 File Offset: 0x0009A688
		public unsafe ContentValidator ContentValidator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06001FBC RID: 8124 RVA: 0x0009C4CC File Offset: 0x0009A6CC
		// (set) Token: 0x06001FBD RID: 8125 RVA: 0x0009C50C File Offset: 0x0009A70C
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06001FBE RID: 8126 RVA: 0x0009C550 File Offset: 0x0009A750
		// (set) Token: 0x06001FBF RID: 8127 RVA: 0x0009C590 File Offset: 0x0009A790
		public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> Constraints
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06001FC0 RID: 8128 RVA: 0x0009C5D4 File Offset: 0x0009A7D4
		// (set) Token: 0x06001FC1 RID: 8129 RVA: 0x0009C614 File Offset: 0x0009A814
		public unsafe XmlSchemaElement SchemaElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001FC2 RID: 8130 RVA: 0x0009C658 File Offset: 0x0009A858
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403667, RefRangeEnd = 403671, XrefRangeStart = 403654, XrefRangeEnd = 403667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddAttDef(SchemaAttDef attdef)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attdef);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001FC3 RID: 8131 RVA: 0x0009C69C File Offset: 0x0009A89C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 403674, RefRangeEnd = 403678, XrefRangeStart = 403671, XrefRangeEnd = 403674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef GetAttDef(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06001FC4 RID: 8132 RVA: 0x0009C6EC File Offset: 0x0009A8EC
		public unsafe IList<IDtdDefaultAttributeInfo> DefaultAttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IDtdDefaultAttributeInfo>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06001FC5 RID: 8133 RVA: 0x0009C72C File Offset: 0x0009A92C
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> AttDefs
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr3) : null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06001FC6 RID: 8134 RVA: 0x0009C76C File Offset: 0x0009A96C
		public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> ProhibitedAttributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr3) : null;
			}
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x0009C7AC File Offset: 0x0009A9AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 403695, RefRangeEnd = 403698, XrefRangeStart = 403678, XrefRangeEnd = 403695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckAttributes(Hashtable presence, bool standalone)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(presence);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref standalone;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaElementDecl.NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x0000CE1D File Offset: 0x0000B01D
		public SchemaElementDecl(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06001FC9 RID: 8137 RVA: 0x0009C7FC File Offset: 0x0009A9FC
		// (set) Token: 0x06001FCA RID: 8138 RVA: 0x0000CE26 File Offset: 0x0000B026
		public unsafe Dictionary<XmlQualifiedName, SchemaAttDef> attdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, SchemaAttDef>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_attdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06001FCB RID: 8139 RVA: 0x0009C82C File Offset: 0x0009AA2C
		// (set) Token: 0x06001FCC RID: 8140 RVA: 0x0000CE45 File Offset: 0x0000B045
		public unsafe List<IDtdDefaultAttributeInfo> defaultAttdefs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IDtdDefaultAttributeInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_defaultAttdefs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06001FCD RID: 8141 RVA: 0x0009C85C File Offset: 0x0009AA5C
		// (set) Token: 0x06001FCE RID: 8142 RVA: 0x0000CE64 File Offset: 0x0000B064
		public unsafe bool isIdDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isIdDeclared)) = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06001FCF RID: 8143 RVA: 0x0009C884 File Offset: 0x0009AA84
		// (set) Token: 0x06001FD0 RID: 8144 RVA: 0x0000CE7F File Offset: 0x0000B07F
		public unsafe bool hasNonCDataAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasNonCDataAttribute)) = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06001FD1 RID: 8145 RVA: 0x0009C8AC File Offset: 0x0009AAAC
		// (set) Token: 0x06001FD2 RID: 8146 RVA: 0x0000CE9A File Offset: 0x0000B09A
		public unsafe bool isAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isAbstract);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isAbstract)) = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06001FD3 RID: 8147 RVA: 0x0009C8D4 File Offset: 0x0009AAD4
		// (set) Token: 0x06001FD4 RID: 8148 RVA: 0x0000CEB5 File Offset: 0x0000B0B5
		public unsafe bool isNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNillable)) = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06001FD5 RID: 8149 RVA: 0x0009C8FC File Offset: 0x0009AAFC
		// (set) Token: 0x06001FD6 RID: 8150 RVA: 0x0000CED0 File Offset: 0x0000B0D0
		public unsafe bool hasRequiredAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_hasRequiredAttribute)) = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06001FD7 RID: 8151 RVA: 0x0009C924 File Offset: 0x0009AB24
		// (set) Token: 0x06001FD8 RID: 8152 RVA: 0x0000CEEB File Offset: 0x0000B0EB
		public unsafe bool isNotationDeclared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_isNotationDeclared)) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06001FD9 RID: 8153 RVA: 0x0009C94C File Offset: 0x0009AB4C
		// (set) Token: 0x06001FDA RID: 8154 RVA: 0x0000CF06 File Offset: 0x0000B106
		public unsafe Dictionary<XmlQualifiedName, XmlQualifiedName> prohibitedAttributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<XmlQualifiedName, XmlQualifiedName>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_prohibitedAttributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06001FDB RID: 8155 RVA: 0x0009C97C File Offset: 0x0009AB7C
		// (set) Token: 0x06001FDC RID: 8156 RVA: 0x0000CF25 File Offset: 0x0000B125
		public unsafe ContentValidator contentValidator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContentValidator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_contentValidator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06001FDD RID: 8157 RVA: 0x0009C9AC File Offset: 0x0009ABAC
		// (set) Token: 0x06001FDE RID: 8158 RVA: 0x0000CF44 File Offset: 0x0000B144
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06001FDF RID: 8159 RVA: 0x0009C9DC File Offset: 0x0009ABDC
		// (set) Token: 0x06001FE0 RID: 8160 RVA: 0x0000CF63 File Offset: 0x0000B163
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06001FE1 RID: 8161 RVA: 0x0009CA04 File Offset: 0x0009AC04
		// (set) Token: 0x06001FE2 RID: 8162 RVA: 0x0000CF7E File Offset: 0x0000B17E
		public unsafe Il2CppReferenceArray<CompiledIdentityConstraint> constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_constraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CompiledIdentityConstraint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06001FE3 RID: 8163 RVA: 0x0009CA34 File Offset: 0x0009AC34
		// (set) Token: 0x06001FE4 RID: 8164 RVA: 0x0000CF9D File Offset: 0x0000B19D
		public unsafe XmlSchemaElement schemaElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_schemaElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaElementDecl.NativeFieldInfoPtr_schemaElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06001FE5 RID: 8165 RVA: 0x0009CA64 File Offset: 0x0009AC64
		// (set) Token: 0x06001FE6 RID: 8166 RVA: 0x0000CFBC File Offset: 0x0000B1BC
		public unsafe static SchemaElementDecl Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaElementDecl.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001823 RID: 6179
		private static readonly IntPtr NativeFieldInfoPtr_attdefs;

		// Token: 0x04001824 RID: 6180
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttdefs;

		// Token: 0x04001825 RID: 6181
		private static readonly IntPtr NativeFieldInfoPtr_isIdDeclared;

		// Token: 0x04001826 RID: 6182
		private static readonly IntPtr NativeFieldInfoPtr_hasNonCDataAttribute;

		// Token: 0x04001827 RID: 6183
		private static readonly IntPtr NativeFieldInfoPtr_isAbstract;

		// Token: 0x04001828 RID: 6184
		private static readonly IntPtr NativeFieldInfoPtr_isNillable;

		// Token: 0x04001829 RID: 6185
		private static readonly IntPtr NativeFieldInfoPtr_hasRequiredAttribute;

		// Token: 0x0400182A RID: 6186
		private static readonly IntPtr NativeFieldInfoPtr_isNotationDeclared;

		// Token: 0x0400182B RID: 6187
		private static readonly IntPtr NativeFieldInfoPtr_prohibitedAttributes;

		// Token: 0x0400182C RID: 6188
		private static readonly IntPtr NativeFieldInfoPtr_contentValidator;

		// Token: 0x0400182D RID: 6189
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x0400182E RID: 6190
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x0400182F RID: 6191
		private static readonly IntPtr NativeFieldInfoPtr_constraints;

		// Token: 0x04001830 RID: 6192
		private static readonly IntPtr NativeFieldInfoPtr_schemaElement;

		// Token: 0x04001831 RID: 6193
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001832 RID: 6194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001833 RID: 6195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlSchemaDatatype_0;

		// Token: 0x04001834 RID: 6196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_XmlQualifiedName_String_0;

		// Token: 0x04001835 RID: 6197
		private static readonly IntPtr NativeMethodInfoPtr_CreateAnyTypeElementDecl_Internal_Static_SchemaElementDecl_0;

		// Token: 0x04001836 RID: 6198
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_get_HasNonCDataAttributes_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001837 RID: 6199
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupAttribute_Private_Virtual_Final_New_IDtdAttributeInfo_String_String_0;

		// Token: 0x04001838 RID: 6200
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeListInfo_LookupDefaultAttributes_Private_Virtual_Final_New_IEnumerable_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x04001839 RID: 6201
		private static readonly IntPtr NativeMethodInfoPtr_get_IsIdDeclared_Internal_get_Boolean_0;

		// Token: 0x0400183A RID: 6202
		private static readonly IntPtr NativeMethodInfoPtr_set_IsIdDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x0400183B RID: 6203
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNonCDataAttribute_Internal_get_Boolean_0;

		// Token: 0x0400183C RID: 6204
		private static readonly IntPtr NativeMethodInfoPtr_set_HasNonCDataAttribute_Internal_set_Void_Boolean_0;

		// Token: 0x0400183D RID: 6205
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_SchemaElementDecl_0;

		// Token: 0x0400183E RID: 6206
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Internal_get_Boolean_0;

		// Token: 0x0400183F RID: 6207
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Internal_set_Void_Boolean_0;

		// Token: 0x04001840 RID: 6208
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNillable_Internal_get_Boolean_0;

		// Token: 0x04001841 RID: 6209
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNillable_Internal_set_Void_Boolean_0;

		// Token: 0x04001842 RID: 6210
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Internal_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001843 RID: 6211
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Internal_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001844 RID: 6212
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNotationDeclared_Internal_get_Boolean_0;

		// Token: 0x04001845 RID: 6213
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNotationDeclared_Internal_set_Void_Boolean_0;

		// Token: 0x04001846 RID: 6214
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDefaultAttribute_Internal_get_Boolean_0;

		// Token: 0x04001847 RID: 6215
		private static readonly IntPtr NativeMethodInfoPtr_get_HasRequiredAttribute_Internal_get_Boolean_0;

		// Token: 0x04001848 RID: 6216
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentValidator_Internal_get_ContentValidator_0;

		// Token: 0x04001849 RID: 6217
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentValidator_Internal_set_Void_ContentValidator_0;

		// Token: 0x0400184A RID: 6218
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Internal_get_XmlSchemaAnyAttribute_0;

		// Token: 0x0400184B RID: 6219
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Internal_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x0400184C RID: 6220
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Internal_get_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

		// Token: 0x0400184D RID: 6221
		private static readonly IntPtr NativeMethodInfoPtr_set_Constraints_Internal_set_Void_Il2CppReferenceArray_1_CompiledIdentityConstraint_0;

		// Token: 0x0400184E RID: 6222
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaElement_Internal_get_XmlSchemaElement_0;

		// Token: 0x0400184F RID: 6223
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaElement_Internal_set_Void_XmlSchemaElement_0;

		// Token: 0x04001850 RID: 6224
		private static readonly IntPtr NativeMethodInfoPtr_AddAttDef_Internal_Void_SchemaAttDef_0;

		// Token: 0x04001851 RID: 6225
		private static readonly IntPtr NativeMethodInfoPtr_GetAttDef_Internal_SchemaAttDef_XmlQualifiedName_0;

		// Token: 0x04001852 RID: 6226
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultAttDefs_Internal_get_IList_1_IDtdDefaultAttributeInfo_0;

		// Token: 0x04001853 RID: 6227
		private static readonly IntPtr NativeMethodInfoPtr_get_AttDefs_Internal_get_Dictionary_2_XmlQualifiedName_SchemaAttDef_0;

		// Token: 0x04001854 RID: 6228
		private static readonly IntPtr NativeMethodInfoPtr_get_ProhibitedAttributes_Internal_get_Dictionary_2_XmlQualifiedName_XmlQualifiedName_0;

		// Token: 0x04001855 RID: 6229
		private static readonly IntPtr NativeMethodInfoPtr_CheckAttributes_Internal_Void_Hashtable_Boolean_0;
	}
}
