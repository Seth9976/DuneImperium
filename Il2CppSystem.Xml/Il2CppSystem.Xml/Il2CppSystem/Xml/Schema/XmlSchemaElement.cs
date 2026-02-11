using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020001B0 RID: 432
	public class XmlSchemaElement : XmlSchemaParticle
	{
		// Token: 0x06002553 RID: 9555 RVA: 0x000B0434 File Offset: 0x000AE634
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaElement()
		{
			Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr);
			XmlSchemaElement.NativeFieldInfoPtr_isAbstract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isAbstract");
			XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "hasAbstractAttribute");
			XmlSchemaElement.NativeFieldInfoPtr_isNillable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isNillable");
			XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "hasNillableAttribute");
			XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "isLocalTypeDerivationChecked");
			XmlSchemaElement.NativeFieldInfoPtr_block = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "block");
			XmlSchemaElement.NativeFieldInfoPtr_final = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "final");
			XmlSchemaElement.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "form");
			XmlSchemaElement.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "defaultValue");
			XmlSchemaElement.NativeFieldInfoPtr_fixedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "fixedValue");
			XmlSchemaElement.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "name");
			XmlSchemaElement.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "refName");
			XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "substitutionGroup");
			XmlSchemaElement.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "typeName");
			XmlSchemaElement.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "type");
			XmlSchemaElement.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "qualifiedName");
			XmlSchemaElement.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "elementType");
			XmlSchemaElement.NativeFieldInfoPtr_blockResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "blockResolved");
			XmlSchemaElement.NativeFieldInfoPtr_finalResolved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "finalResolved");
			XmlSchemaElement.NativeFieldInfoPtr_constraints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "constraints");
			XmlSchemaElement.NativeFieldInfoPtr_elementDecl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, "elementDecl");
			XmlSchemaElement.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668709);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668710);
			XmlSchemaElement.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668711);
			XmlSchemaElement.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668712);
			XmlSchemaElement.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668713);
			XmlSchemaElement.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668714);
			XmlSchemaElement.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668715);
			XmlSchemaElement.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668716);
			XmlSchemaElement.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668717);
			XmlSchemaElement.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668718);
			XmlSchemaElement.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668719);
			XmlSchemaElement.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668720);
			XmlSchemaElement.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668721);
			XmlSchemaElement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668722);
			XmlSchemaElement.NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668723);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668724);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668725);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668726);
			XmlSchemaElement.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668727);
			XmlSchemaElement.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668728);
			XmlSchemaElement.NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668729);
			XmlSchemaElement.NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668730);
			XmlSchemaElement.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668731);
			XmlSchemaElement.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668732);
			XmlSchemaElement.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668733);
			XmlSchemaElement.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668734);
			XmlSchemaElement.NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668735);
			XmlSchemaElement.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668736);
			XmlSchemaElement.NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668737);
			XmlSchemaElement.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668738);
			XmlSchemaElement.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668739);
			XmlSchemaElement.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668740);
			XmlSchemaElement.NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668741);
			XmlSchemaElement.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668742);
			XmlSchemaElement.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668743);
			XmlSchemaElement.NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668744);
			XmlSchemaElement.NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668745);
			XmlSchemaElement.NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668746);
			XmlSchemaElement.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668747);
			XmlSchemaElement.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668748);
			XmlSchemaElement.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668749);
			XmlSchemaElement.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668750);
			XmlSchemaElement.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668751);
			XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668752);
			XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668753);
			XmlSchemaElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr, 100668754);
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x000B09A0 File Offset: 0x000AEBA0
		// (set) Token: 0x06002555 RID: 9557 RVA: 0x000B09DC File Offset: 0x000AEBDC
		public unsafe bool IsAbstract
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411883, RefRangeEnd = 411884, XrefRangeStart = 411883, XrefRangeEnd = 411883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x06002556 RID: 9558 RVA: 0x000B0A1C File Offset: 0x000AEC1C
		// (set) Token: 0x06002557 RID: 9559 RVA: 0x000B0A58 File Offset: 0x000AEC58
		public unsafe XmlSchemaDerivationMethod Block
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x06002558 RID: 9560 RVA: 0x000B0A98 File Offset: 0x000AEC98
		// (set) Token: 0x06002559 RID: 9561 RVA: 0x000B0AD0 File Offset: 0x000AECD0
		public unsafe string DefaultValue
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x0600255A RID: 9562 RVA: 0x000B0B14 File Offset: 0x000AED14
		// (set) Token: 0x0600255B RID: 9563 RVA: 0x000B0B50 File Offset: 0x000AED50
		public unsafe XmlSchemaDerivationMethod Final
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x0600255C RID: 9564 RVA: 0x000B0B90 File Offset: 0x000AED90
		// (set) Token: 0x0600255D RID: 9565 RVA: 0x000B0BC8 File Offset: 0x000AEDC8
		public unsafe string FixedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x0600255E RID: 9566 RVA: 0x000B0C0C File Offset: 0x000AEE0C
		// (set) Token: 0x0600255F RID: 9567 RVA: 0x000B0C48 File Offset: 0x000AEE48
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x06002560 RID: 9568 RVA: 0x000B0C88 File Offset: 0x000AEE88
		// (set) Token: 0x06002561 RID: 9569 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x06002562 RID: 9570 RVA: 0x000B0D04 File Offset: 0x000AEF04
		// (set) Token: 0x06002563 RID: 9571 RVA: 0x000B0D40 File Offset: 0x000AEF40
		public unsafe bool IsNillable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 411884, RefRangeEnd = 411887, XrefRangeStart = 411884, XrefRangeEnd = 411884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x06002564 RID: 9572 RVA: 0x000B0D80 File Offset: 0x000AEF80
		public unsafe bool HasNillableAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x06002565 RID: 9573 RVA: 0x000B0DBC File Offset: 0x000AEFBC
		public unsafe bool HasAbstractAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x06002566 RID: 9574 RVA: 0x000B0DF8 File Offset: 0x000AEFF8
		// (set) Token: 0x06002567 RID: 9575 RVA: 0x000B0E38 File Offset: 0x000AF038
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 411896, RefRangeEnd = 411899, XrefRangeStart = 411887, XrefRangeEnd = 411896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x06002568 RID: 9576 RVA: 0x000B0E7C File Offset: 0x000AF07C
		// (set) Token: 0x06002569 RID: 9577 RVA: 0x000B0EBC File Offset: 0x000AF0BC
		public unsafe XmlQualifiedName SubstitutionGroup
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 411908, RefRangeEnd = 411910, XrefRangeStart = 411899, XrefRangeEnd = 411908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x0600256A RID: 9578 RVA: 0x000B0F00 File Offset: 0x000AF100
		// (set) Token: 0x0600256B RID: 9579 RVA: 0x000B0F40 File Offset: 0x000AF140
		public unsafe XmlQualifiedName SchemaTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 411919, RefRangeEnd = 411927, XrefRangeStart = 411910, XrefRangeEnd = 411919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x0600256C RID: 9580 RVA: 0x000B0F84 File Offset: 0x000AF184
		// (set) Token: 0x0600256D RID: 9581 RVA: 0x000B0FC4 File Offset: 0x000AF1C4
		public unsafe XmlSchemaType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x0600256E RID: 9582 RVA: 0x000B1008 File Offset: 0x000AF208
		public unsafe XmlSchemaObjectCollection Constraints
		{
			[CallerCount(20)]
			[CachedScanResults(RefRangeStart = 411932, RefRangeEnd = 411952, XrefRangeStart = 411927, XrefRangeEnd = 411932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x0600256F RID: 9583 RVA: 0x000B1048 File Offset: 0x000AF248
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002570 RID: 9584 RVA: 0x000B1088 File Offset: 0x000AF288
		public unsafe XmlSchemaType ElementSchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr3) : null;
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x06002571 RID: 9585 RVA: 0x000B10C8 File Offset: 0x000AF2C8
		public unsafe XmlSchemaDerivationMethod BlockResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x06002572 RID: 9586 RVA: 0x000B1104 File Offset: 0x000AF304
		public unsafe XmlSchemaDerivationMethod FinalResolved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000B1140 File Offset: 0x000AF340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQualifiedName(XmlQualifiedName value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000B1184 File Offset: 0x000AF384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetElementType(XmlSchemaType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000B11C8 File Offset: 0x000AF3C8
		[CallerCount(0)]
		public unsafe void SetBlockResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000B1208 File Offset: 0x000AF408
		[CallerCount(0)]
		public unsafe void SetFinalResolved(XmlSchemaDerivationMethod value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000CD8 RID: 3288
		// (get) Token: 0x06002577 RID: 9591 RVA: 0x000B1248 File Offset: 0x000AF448
		public unsafe bool HasConstraints
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 411952, RefRangeEnd = 411956, XrefRangeStart = 411952, XrefRangeEnd = 411952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000CD9 RID: 3289
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x000B1284 File Offset: 0x000AF484
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x000B12C0 File Offset: 0x000AF4C0
		public unsafe bool IsLocalTypeDerivationChecked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CDA RID: 3290
		// (get) Token: 0x0600257A RID: 9594 RVA: 0x000B1300 File Offset: 0x000AF500
		// (set) Token: 0x0600257B RID: 9595 RVA: 0x000B1340 File Offset: 0x000AF540
		public unsafe SchemaElementDecl ElementDecl
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CDB RID: 3291
		// (get) Token: 0x0600257C RID: 9596 RVA: 0x000B1384 File Offset: 0x000AF584
		// (set) Token: 0x0600257D RID: 9597 RVA: 0x000B13C8 File Offset: 0x000AF5C8
		public unsafe override string NameAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000CDC RID: 3292
		// (get) Token: 0x0600257E RID: 9598 RVA: 0x000B1418 File Offset: 0x000AF618
		public unsafe override string NameString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411956, XrefRangeEnd = 411957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000B145C File Offset: 0x000AF65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411957, XrefRangeEnd = 411958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000B14A8 File Offset: 0x000AF6A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 411981, RefRangeEnd = 411984, XrefRangeStart = 411958, XrefRangeEnd = 411981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaObject Clone(XmlSchema parentSchema)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentSchema);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000B14F8 File Offset: 0x000AF6F8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 411999, RefRangeEnd = 412004, XrefRangeStart = 411984, XrefRangeEnd = 411999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaElement()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x0000FBB5 File Offset: 0x0000DDB5
		public XmlSchemaElement(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x06002583 RID: 9603 RVA: 0x000B1534 File Offset: 0x000AF734
		// (set) Token: 0x06002584 RID: 9604 RVA: 0x0000FBBE File Offset: 0x0000DDBE
		public unsafe bool isAbstract
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isAbstract);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isAbstract)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06002585 RID: 9605 RVA: 0x000B155C File Offset: 0x000AF75C
		// (set) Token: 0x06002586 RID: 9606 RVA: 0x0000FBD9 File Offset: 0x0000DDD9
		public unsafe bool hasAbstractAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasAbstractAttribute)) = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06002587 RID: 9607 RVA: 0x000B1584 File Offset: 0x000AF784
		// (set) Token: 0x06002588 RID: 9608 RVA: 0x0000FBF4 File Offset: 0x0000DDF4
		public unsafe bool isNillable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isNillable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isNillable)) = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06002589 RID: 9609 RVA: 0x000B15AC File Offset: 0x000AF7AC
		// (set) Token: 0x0600258A RID: 9610 RVA: 0x0000FC0F File Offset: 0x0000DE0F
		public unsafe bool hasNillableAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_hasNillableAttribute)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x0600258B RID: 9611 RVA: 0x000B15D4 File Offset: 0x000AF7D4
		// (set) Token: 0x0600258C RID: 9612 RVA: 0x0000FC2A File Offset: 0x0000DE2A
		public unsafe bool isLocalTypeDerivationChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_isLocalTypeDerivationChecked)) = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x0600258D RID: 9613 RVA: 0x000B15FC File Offset: 0x000AF7FC
		// (set) Token: 0x0600258E RID: 9614 RVA: 0x0000FC45 File Offset: 0x0000DE45
		public unsafe XmlSchemaDerivationMethod block
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_block);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_block)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600258F RID: 9615 RVA: 0x000B1624 File Offset: 0x000AF824
		// (set) Token: 0x06002590 RID: 9616 RVA: 0x0000FC60 File Offset: 0x0000DE60
		public unsafe XmlSchemaDerivationMethod final
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_final);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_final)) = value;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002591 RID: 9617 RVA: 0x000B164C File Offset: 0x000AF84C
		// (set) Token: 0x06002592 RID: 9618 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x06002593 RID: 9619 RVA: 0x000B1674 File Offset: 0x000AF874
		// (set) Token: 0x06002594 RID: 9620 RVA: 0x0000FC96 File Offset: 0x0000DE96
		public unsafe string defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x000B169C File Offset: 0x000AF89C
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x0000FCB5 File Offset: 0x0000DEB5
		public unsafe string fixedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_fixedValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_fixedValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002597 RID: 9623 RVA: 0x000B16C4 File Offset: 0x000AF8C4
		// (set) Token: 0x06002598 RID: 9624 RVA: 0x0000FCD4 File Offset: 0x0000DED4
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002599 RID: 9625 RVA: 0x000B16EC File Offset: 0x000AF8EC
		// (set) Token: 0x0600259A RID: 9626 RVA: 0x0000FCF3 File Offset: 0x0000DEF3
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x0600259B RID: 9627 RVA: 0x000B171C File Offset: 0x000AF91C
		// (set) Token: 0x0600259C RID: 9628 RVA: 0x0000FD12 File Offset: 0x0000DF12
		public unsafe XmlQualifiedName substitutionGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_substitutionGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x0600259D RID: 9629 RVA: 0x000B174C File Offset: 0x000AF94C
		// (set) Token: 0x0600259E RID: 9630 RVA: 0x0000FD31 File Offset: 0x0000DF31
		public unsafe XmlQualifiedName typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_typeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_typeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600259F RID: 9631 RVA: 0x000B177C File Offset: 0x000AF97C
		// (set) Token: 0x060025A0 RID: 9632 RVA: 0x0000FD50 File Offset: 0x0000DF50
		public unsafe XmlSchemaType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x060025A1 RID: 9633 RVA: 0x000B17AC File Offset: 0x000AF9AC
		// (set) Token: 0x060025A2 RID: 9634 RVA: 0x0000FD6F File Offset: 0x0000DF6F
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x060025A3 RID: 9635 RVA: 0x000B17DC File Offset: 0x000AF9DC
		// (set) Token: 0x060025A4 RID: 9636 RVA: 0x0000FD8E File Offset: 0x0000DF8E
		public unsafe XmlSchemaType elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060025A5 RID: 9637 RVA: 0x000B180C File Offset: 0x000AFA0C
		// (set) Token: 0x060025A6 RID: 9638 RVA: 0x0000FDAD File Offset: 0x0000DFAD
		public unsafe XmlSchemaDerivationMethod blockResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_blockResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_blockResolved)) = value;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060025A7 RID: 9639 RVA: 0x000B1834 File Offset: 0x000AFA34
		// (set) Token: 0x060025A8 RID: 9640 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		public unsafe XmlSchemaDerivationMethod finalResolved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_finalResolved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_finalResolved)) = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060025A9 RID: 9641 RVA: 0x000B185C File Offset: 0x000AFA5C
		// (set) Token: 0x060025AA RID: 9642 RVA: 0x0000FDE3 File Offset: 0x0000DFE3
		public unsafe XmlSchemaObjectCollection constraints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_constraints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_constraints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060025AB RID: 9643 RVA: 0x000B188C File Offset: 0x000AFA8C
		// (set) Token: 0x060025AC RID: 9644 RVA: 0x0000FE02 File Offset: 0x0000E002
		public unsafe SchemaElementDecl elementDecl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementDecl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaElementDecl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaElement.NativeFieldInfoPtr_elementDecl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeFieldInfoPtr_isAbstract;

		// Token: 0x04001C38 RID: 7224
		private static readonly IntPtr NativeFieldInfoPtr_hasAbstractAttribute;

		// Token: 0x04001C39 RID: 7225
		private static readonly IntPtr NativeFieldInfoPtr_isNillable;

		// Token: 0x04001C3A RID: 7226
		private static readonly IntPtr NativeFieldInfoPtr_hasNillableAttribute;

		// Token: 0x04001C3B RID: 7227
		private static readonly IntPtr NativeFieldInfoPtr_isLocalTypeDerivationChecked;

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeFieldInfoPtr_block;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeFieldInfoPtr_final;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeFieldInfoPtr_fixedValue;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeFieldInfoPtr_substitutionGroup;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04001C45 RID: 7237
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001C46 RID: 7238
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x04001C47 RID: 7239
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x04001C48 RID: 7240
		private static readonly IntPtr NativeFieldInfoPtr_blockResolved;

		// Token: 0x04001C49 RID: 7241
		private static readonly IntPtr NativeFieldInfoPtr_finalResolved;

		// Token: 0x04001C4A RID: 7242
		private static readonly IntPtr NativeFieldInfoPtr_constraints;

		// Token: 0x04001C4B RID: 7243
		private static readonly IntPtr NativeFieldInfoPtr_elementDecl;

		// Token: 0x04001C4C RID: 7244
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAbstract_Public_get_Boolean_0;

		// Token: 0x04001C4D RID: 7245
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAbstract_Public_set_Void_Boolean_0;

		// Token: 0x04001C4E RID: 7246
		private static readonly IntPtr NativeMethodInfoPtr_get_Block_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C4F RID: 7247
		private static readonly IntPtr NativeMethodInfoPtr_set_Block_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C50 RID: 7248
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0;

		// Token: 0x04001C51 RID: 7249
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0;

		// Token: 0x04001C52 RID: 7250
		private static readonly IntPtr NativeMethodInfoPtr_get_Final_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C53 RID: 7251
		private static readonly IntPtr NativeMethodInfoPtr_set_Final_Public_set_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedValue_Public_get_String_0;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04001C58 RID: 7256
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001C59 RID: 7257
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNillable_Public_get_Boolean_0;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNillable_Public_set_Void_Boolean_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_get_HasNillableAttribute_Internal_get_Boolean_0;

		// Token: 0x04001C5D RID: 7261
		private static readonly IntPtr NativeMethodInfoPtr_get_HasAbstractAttribute_Internal_get_Boolean_0;

		// Token: 0x04001C5E RID: 7262
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001C5F RID: 7263
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001C60 RID: 7264
		private static readonly IntPtr NativeMethodInfoPtr_get_SubstitutionGroup_Public_get_XmlQualifiedName_0;

		// Token: 0x04001C61 RID: 7265
		private static readonly IntPtr NativeMethodInfoPtr_set_SubstitutionGroup_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001C62 RID: 7266
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001C63 RID: 7267
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001C64 RID: 7268
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x04001C65 RID: 7269
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaType_0;

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeMethodInfoPtr_get_Constraints_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementSchemaType_Public_get_XmlSchemaType_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_get_FinalResolved_Public_get_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_SetElementType_Internal_Void_XmlSchemaType_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_SetFinalResolved_Internal_Void_XmlSchemaDerivationMethod_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_get_HasConstraints_Internal_get_Boolean_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_get_IsLocalTypeDerivationChecked_Internal_get_Boolean_0;

		// Token: 0x04001C71 RID: 7281
		private static readonly IntPtr NativeMethodInfoPtr_set_IsLocalTypeDerivationChecked_Internal_set_Void_Boolean_0;

		// Token: 0x04001C72 RID: 7282
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementDecl_Internal_get_SchemaElementDecl_0;

		// Token: 0x04001C73 RID: 7283
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementDecl_Internal_set_Void_SchemaElementDecl_0;

		// Token: 0x04001C74 RID: 7284
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001C75 RID: 7285
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001C76 RID: 7286
		private static readonly IntPtr NativeMethodInfoPtr_get_NameString_Internal_Virtual_get_String_0;

		// Token: 0x04001C77 RID: 7287
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001C78 RID: 7288
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_XmlSchemaObject_XmlSchema_0;

		// Token: 0x04001C79 RID: 7289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
