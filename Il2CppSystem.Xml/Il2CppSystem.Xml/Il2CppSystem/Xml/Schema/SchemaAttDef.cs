using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000181 RID: 385
	public sealed class SchemaAttDef : SchemaDeclBase
	{
		// Token: 0x06001EAC RID: 7852 RVA: 0x00097288 File Offset: 0x00095488
		// Note: this type is marked as 'beforefieldinit'.
		static SchemaAttDef()
		{
			Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "SchemaAttDef");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr);
			SchemaAttDef.NativeFieldInfoPtr_defExpanded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "defExpanded");
			SchemaAttDef.NativeFieldInfoPtr_lineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "lineNum");
			SchemaAttDef.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "linePos");
			SchemaAttDef.NativeFieldInfoPtr_valueLineNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLineNum");
			SchemaAttDef.NativeFieldInfoPtr_valueLinePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "valueLinePos");
			SchemaAttDef.NativeFieldInfoPtr_reserved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "reserved");
			SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "defaultValueChecked");
			SchemaAttDef.NativeFieldInfoPtr_schemaAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "schemaAttribute");
			SchemaAttDef.NativeFieldInfoPtr_Empty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, "Empty");
			SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667891);
			SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667892);
			SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667893);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667894);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667895);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667896);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667897);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667898);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667899);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667900);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667901);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667902);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667903);
			SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667904);
			SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667905);
			SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667906);
			SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667907);
			SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667908);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667909);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667910);
			SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667911);
			SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667912);
			SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667913);
			SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667914);
			SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667915);
			SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667916);
			SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667917);
			SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667918);
			SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667919);
			SchemaAttDef.NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667920);
			SchemaAttDef.NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667921);
			SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667922);
			SchemaAttDef.NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr, 100667923);
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x00097600 File Offset: 0x00095800
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 399707, RefRangeEnd = 399710, XrefRangeStart = 399706, XrefRangeEnd = 399707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef(XmlQualifiedName name, string prefix)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(prefix);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x00097660 File Offset: 0x00095860
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 399711, RefRangeEnd = 399712, XrefRangeStart = 399710, XrefRangeEnd = 399711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef(XmlQualifiedName name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x000976AC File Offset: 0x000958AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399712, XrefRangeEnd = 399713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchemaAttDef>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x000976E8 File Offset: 0x000958E8
		public unsafe string System.Xml.IDtdAttributeInfo.Prefix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399713, XrefRangeEnd = 399714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001EB1 RID: 7857 RVA: 0x00097720 File Offset: 0x00095920
		public unsafe string System.Xml.IDtdAttributeInfo.LocalName
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 399714, RefRangeEnd = 399719, XrefRangeStart = 399714, XrefRangeEnd = 399714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001EB2 RID: 7858 RVA: 0x00097758 File Offset: 0x00095958
		public unsafe int System.Xml.IDtdAttributeInfo.LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001EB3 RID: 7859 RVA: 0x00097794 File Offset: 0x00095994
		public unsafe int System.Xml.IDtdAttributeInfo.LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001EB4 RID: 7860 RVA: 0x000977D0 File Offset: 0x000959D0
		public unsafe bool System.Xml.IDtdAttributeInfo.IsNonCDataType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001EB5 RID: 7861 RVA: 0x0009780C File Offset: 0x00095A0C
		public unsafe bool System.Xml.IDtdAttributeInfo.IsDeclaredInExternal
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 308625, RefRangeEnd = 308626, XrefRangeStart = 308625, XrefRangeEnd = 308626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001EB6 RID: 7862 RVA: 0x00097848 File Offset: 0x00095A48
		public unsafe bool System.Xml.IDtdAttributeInfo.IsXmlAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001EB7 RID: 7863 RVA: 0x00097884 File Offset: 0x00095A84
		public unsafe string System.Xml.IDtdDefaultAttributeInfo.DefaultValueExpanded
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 399719, XrefRangeEnd = 399720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001EB8 RID: 7864 RVA: 0x000978BC File Offset: 0x00095ABC
		public unsafe Object System.Xml.IDtdDefaultAttributeInfo.DefaultValueTyped
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001EB9 RID: 7865 RVA: 0x000978FC File Offset: 0x00095AFC
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x00097938 File Offset: 0x00095B38
		public unsafe int System.Xml.IDtdDefaultAttributeInfo.ValueLinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x00097974 File Offset: 0x00095B74
		// (set) Token: 0x06001EBC RID: 7868 RVA: 0x000979B0 File Offset: 0x00095BB0
		public unsafe int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001EBD RID: 7869 RVA: 0x000979F0 File Offset: 0x00095BF0
		// (set) Token: 0x06001EBE RID: 7870 RVA: 0x00097A2C File Offset: 0x00095C2C
		public unsafe int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 337738, RefRangeEnd = 337747, XrefRangeStart = 337738, XrefRangeEnd = 337747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x00097A6C File Offset: 0x00095C6C
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x00097AA8 File Offset: 0x00095CA8
		public unsafe int ValueLinePosition
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368218, RefRangeEnd = 368219, XrefRangeStart = 368218, XrefRangeEnd = 368219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00097AE8 File Offset: 0x00095CE8
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x00097B24 File Offset: 0x00095D24
		public unsafe int ValueLineNumber
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 368217, RefRangeEnd = 368218, XrefRangeStart = 368217, XrefRangeEnd = 368218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x00097B64 File Offset: 0x00095D64
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x00097B9C File Offset: 0x00095D9C
		public unsafe string DefaultValueExpanded
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 399721, RefRangeEnd = 399724, XrefRangeStart = 399720, XrefRangeEnd = 399721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x00097BE0 File Offset: 0x00095DE0
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x00097C1C File Offset: 0x00095E1C
		public unsafe XmlTokenizedType TokenizedType
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 399725, RefRangeEnd = 399727, XrefRangeStart = 399724, XrefRangeEnd = 399725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 399729, RefRangeEnd = 399730, XrefRangeStart = 399727, XrefRangeEnd = 399729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06001EC7 RID: 7879 RVA: 0x00097C5C File Offset: 0x00095E5C
		// (set) Token: 0x06001EC8 RID: 7880 RVA: 0x00097C98 File Offset: 0x00095E98
		public unsafe SchemaAttDef.Reserve Reserved
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00097CD8 File Offset: 0x00095ED8
		public unsafe bool DefaultValueChecked
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06001ECA RID: 7882 RVA: 0x00097D14 File Offset: 0x00095F14
		// (set) Token: 0x06001ECB RID: 7883 RVA: 0x00097D54 File Offset: 0x00095F54
		public unsafe XmlSchemaAttribute SchemaAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00097D98 File Offset: 0x00095F98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 399744, RefRangeEnd = 399746, XrefRangeStart = 399730, XrefRangeEnd = 399744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckXmlSpace(IValidationEventHandling validationEventHandling)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(validationEventHandling);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00097DDC File Offset: 0x00095FDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 399749, RefRangeEnd = 399753, XrefRangeStart = 399746, XrefRangeEnd = 399749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchemaAttDef Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchemaAttDef.NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0000CA00 File Offset: 0x0000AC00
		public SchemaAttDef(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06001ECF RID: 7887 RVA: 0x00097E1C File Offset: 0x0009601C
		// (set) Token: 0x06001ED0 RID: 7888 RVA: 0x0000CA09 File Offset: 0x0000AC09
		public unsafe string defExpanded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defExpanded), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06001ED1 RID: 7889 RVA: 0x00097E44 File Offset: 0x00096044
		// (set) Token: 0x06001ED2 RID: 7890 RVA: 0x0000CA28 File Offset: 0x0000AC28
		public unsafe int lineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_lineNum)) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06001ED3 RID: 7891 RVA: 0x00097E6C File Offset: 0x0009606C
		// (set) Token: 0x06001ED4 RID: 7892 RVA: 0x0000CA43 File Offset: 0x0000AC43
		public unsafe int linePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_linePos)) = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x00097E94 File Offset: 0x00096094
		// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x0000CA5E File Offset: 0x0000AC5E
		public unsafe int valueLineNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLineNum)) = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x00097EBC File Offset: 0x000960BC
		// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x0000CA79 File Offset: 0x0000AC79
		public unsafe int valueLinePos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_valueLinePos)) = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00097EE4 File Offset: 0x000960E4
		// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0000CA94 File Offset: 0x0000AC94
		public unsafe SchemaAttDef.Reserve reserved
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_reserved)) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x00097F0C File Offset: 0x0009610C
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000CAAF File Offset: 0x0000ACAF
		public unsafe bool defaultValueChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_defaultValueChecked)) = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x00097F34 File Offset: 0x00096134
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x0000CACA File Offset: 0x0000ACCA
		public unsafe XmlSchemaAttribute schemaAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_schemaAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchemaAttDef.NativeFieldInfoPtr_schemaAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x00097F64 File Offset: 0x00096164
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0000CAE9 File Offset: 0x0000ACE9
		public unsafe static SchemaAttDef Empty
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SchemaAttDef.NativeFieldInfoPtr_Empty, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SchemaAttDef.NativeFieldInfoPtr_Empty, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001759 RID: 5977
		private static readonly IntPtr NativeFieldInfoPtr_defExpanded;

		// Token: 0x0400175A RID: 5978
		private static readonly IntPtr NativeFieldInfoPtr_lineNum;

		// Token: 0x0400175B RID: 5979
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x0400175C RID: 5980
		private static readonly IntPtr NativeFieldInfoPtr_valueLineNum;

		// Token: 0x0400175D RID: 5981
		private static readonly IntPtr NativeFieldInfoPtr_valueLinePos;

		// Token: 0x0400175E RID: 5982
		private static readonly IntPtr NativeFieldInfoPtr_reserved;

		// Token: 0x0400175F RID: 5983
		private static readonly IntPtr NativeFieldInfoPtr_defaultValueChecked;

		// Token: 0x04001760 RID: 5984
		private static readonly IntPtr NativeFieldInfoPtr_schemaAttribute;

		// Token: 0x04001761 RID: 5985
		private static readonly IntPtr NativeFieldInfoPtr_Empty;

		// Token: 0x04001762 RID: 5986
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_String_0;

		// Token: 0x04001763 RID: 5987
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlQualifiedName_0;

		// Token: 0x04001764 RID: 5988
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001765 RID: 5989
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_Prefix_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001766 RID: 5990
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LocalName_Private_Virtual_Final_New_get_String_0;

		// Token: 0x04001767 RID: 5991
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001768 RID: 5992
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_LinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001769 RID: 5993
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsNonCDataType_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400176A RID: 5994
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsDeclaredInExternal_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400176B RID: 5995
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdAttributeInfo_get_IsXmlAttribute_Private_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400176C RID: 5996
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueExpanded_Private_Virtual_Final_New_get_String_0;

		// Token: 0x0400176D RID: 5997
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_DefaultValueTyped_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400176E RID: 5998
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLineNumber_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400176F RID: 5999
		private static readonly IntPtr NativeMethodInfoPtr_System_Xml_IDtdDefaultAttributeInfo_get_ValueLinePosition_Private_Virtual_Final_New_get_Int32_0;

		// Token: 0x04001770 RID: 6000
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Internal_get_Int32_0;

		// Token: 0x04001771 RID: 6001
		private static readonly IntPtr NativeMethodInfoPtr_set_LinePosition_Internal_set_Void_Int32_0;

		// Token: 0x04001772 RID: 6002
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Internal_get_Int32_0;

		// Token: 0x04001773 RID: 6003
		private static readonly IntPtr NativeMethodInfoPtr_set_LineNumber_Internal_set_Void_Int32_0;

		// Token: 0x04001774 RID: 6004
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLinePosition_Internal_get_Int32_0;

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLinePosition_Internal_set_Void_Int32_0;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeMethodInfoPtr_get_ValueLineNumber_Internal_get_Int32_0;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeMethodInfoPtr_set_ValueLineNumber_Internal_set_Void_Int32_0;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueExpanded_Internal_get_String_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValueExpanded_Internal_set_Void_String_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_get_TokenizedType_Internal_get_XmlTokenizedType_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_set_TokenizedType_Internal_set_Void_XmlTokenizedType_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_get_Reserved_Internal_get_Reserve_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_set_Reserved_Internal_set_Void_Reserve_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValueChecked_Internal_get_Boolean_0;

		// Token: 0x0400177F RID: 6015
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaAttribute_Internal_get_XmlSchemaAttribute_0;

		// Token: 0x04001780 RID: 6016
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaAttribute_Internal_set_Void_XmlSchemaAttribute_0;

		// Token: 0x04001781 RID: 6017
		private static readonly IntPtr NativeMethodInfoPtr_CheckXmlSpace_Internal_Void_IValidationEventHandling_0;

		// Token: 0x04001782 RID: 6018
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_SchemaAttDef_0;

		// Token: 0x0200025C RID: 604
		public enum Reserve
		{
			// Token: 0x04002667 RID: 9831
			None,
			// Token: 0x04002668 RID: 9832
			XmlSpace,
			// Token: 0x04002669 RID: 9833
			XmlLang
		}
	}
}
