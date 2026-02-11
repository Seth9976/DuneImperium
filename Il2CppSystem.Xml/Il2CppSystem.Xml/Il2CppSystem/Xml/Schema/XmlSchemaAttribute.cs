using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019D RID: 413
	public class XmlSchemaAttribute : XmlSchemaAnnotated
	{
		// Token: 0x060023FA RID: 9210 RVA: 0x000AAF24 File Offset: 0x000A9124
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAttribute()
		{
			Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr);
			XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "defaultValue");
			XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "fixedValue");
			XmlSchemaAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "name");
			XmlSchemaAttribute.NativeFieldInfoPtr_form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "form");
			XmlSchemaAttribute.NativeFieldInfoPtr_use = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "use");
			XmlSchemaAttribute.NativeFieldInfoPtr_refName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "refName");
			XmlSchemaAttribute.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "typeName");
			XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "qualifiedName");
			XmlSchemaAttribute.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "type");
			XmlSchemaAttribute.NativeFieldInfoPtr_attributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "attributeType");
			XmlSchemaAttribute.NativeFieldInfoPtr_attDef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, "attDef");
			XmlSchemaAttribute.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668520);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668521);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668522);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668523);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668524);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668525);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668526);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668527);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668528);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668529);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668530);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668531);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668532);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668533);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668534);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668535);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668536);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668537);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668538);
			XmlSchemaAttribute.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668539);
			XmlSchemaAttribute.NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668540);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668541);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668542);
			XmlSchemaAttribute.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668543);
			XmlSchemaAttribute.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668544);
			XmlSchemaAttribute.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668545);
			XmlSchemaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr, 100668546);
		}

		// Token: 0x17000C28 RID: 3112
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x000AB24C File Offset: 0x000A944C
		// (set) Token: 0x060023FC RID: 9212 RVA: 0x000AB284 File Offset: 0x000A9484
		public unsafe string DefaultValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C29 RID: 3113
		// (get) Token: 0x060023FD RID: 9213 RVA: 0x000AB2C8 File Offset: 0x000A94C8
		// (set) Token: 0x060023FE RID: 9214 RVA: 0x000AB300 File Offset: 0x000A9500
		public unsafe string FixedValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_FixedValue_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2A RID: 3114
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000AB344 File Offset: 0x000A9544
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x000AB380 File Offset: 0x000A9580
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2B RID: 3115
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000AB3C0 File Offset: 0x000A95C0
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x000AB3F8 File Offset: 0x000A95F8
		public unsafe string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06002403 RID: 9219 RVA: 0x000AB43C File Offset: 0x000A963C
		// (set) Token: 0x06002404 RID: 9220 RVA: 0x000AB47C File Offset: 0x000A967C
		public unsafe XmlQualifiedName RefName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 410991, RefRangeEnd = 410997, XrefRangeStart = 410982, XrefRangeEnd = 410991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x000AB4C0 File Offset: 0x000A96C0
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x000AB500 File Offset: 0x000A9700
		public unsafe XmlQualifiedName SchemaTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 411006, RefRangeEnd = 411013, XrefRangeStart = 410997, XrefRangeEnd = 411006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06002407 RID: 9223 RVA: 0x000AB544 File Offset: 0x000A9744
		// (set) Token: 0x06002408 RID: 9224 RVA: 0x000AB584 File Offset: 0x000A9784
		public unsafe XmlSchemaSimpleType SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x000AB5C8 File Offset: 0x000A97C8
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x000AB604 File Offset: 0x000A9804
		public unsafe XmlSchemaUse Use
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600240B RID: 9227 RVA: 0x000AB644 File Offset: 0x000A9844
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000C31 RID: 3121
		// (get) Token: 0x0600240C RID: 9228 RVA: 0x000AB684 File Offset: 0x000A9884
		public unsafe XmlSchemaSimpleType AttributeSchemaType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr3) : null;
			}
		}

		// Token: 0x17000C32 RID: 3122
		// (get) Token: 0x0600240D RID: 9229 RVA: 0x000AB6C4 File Offset: 0x000A98C4
		public unsafe XmlSchemaDatatype Datatype
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 411013, RefRangeEnd = 411014, XrefRangeStart = 411013, XrefRangeEnd = 411013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000AB704 File Offset: 0x000A9904
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x000AB748 File Offset: 0x000A9948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAttributeType(XmlSchemaSimpleType value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000C33 RID: 3123
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x000AB78C File Offset: 0x000A998C
		// (set) Token: 0x06002411 RID: 9233 RVA: 0x000AB7CC File Offset: 0x000A99CC
		public unsafe SchemaAttDef AttDef
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C34 RID: 3124
		// (get) Token: 0x06002412 RID: 9234 RVA: 0x000AB810 File Offset: 0x000A9A10
		// (set) Token: 0x06002413 RID: 9235 RVA: 0x000AB854 File Offset: 0x000A9A54
		public unsafe override string NameAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000AB8A4 File Offset: 0x000A9AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411014, XrefRangeEnd = 411023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttribute.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x000AB8F0 File Offset: 0x000A9AF0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 411033, RefRangeEnd = 411044, XrefRangeStart = 411023, XrefRangeEnd = 411033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002416 RID: 9238 RVA: 0x0000F3AB File Offset: 0x0000D5AB
		public XmlSchemaAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C1D RID: 3101
		// (get) Token: 0x06002417 RID: 9239 RVA: 0x000AB92C File Offset: 0x000A9B2C
		// (set) Token: 0x06002418 RID: 9240 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		public unsafe string defaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_defaultValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06002419 RID: 9241 RVA: 0x000AB954 File Offset: 0x000A9B54
		// (set) Token: 0x0600241A RID: 9242 RVA: 0x0000F3D3 File Offset: 0x0000D5D3
		public unsafe string fixedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_fixedValue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x0600241B RID: 9243 RVA: 0x000AB97C File Offset: 0x000A9B7C
		// (set) Token: 0x0600241C RID: 9244 RVA: 0x0000F3F2 File Offset: 0x0000D5F2
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x000AB9A4 File Offset: 0x000A9BA4
		// (set) Token: 0x0600241E RID: 9246 RVA: 0x0000F411 File Offset: 0x0000D611
		public unsafe XmlSchemaForm form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_form)) = value;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x000AB9CC File Offset: 0x000A9BCC
		// (set) Token: 0x06002420 RID: 9248 RVA: 0x0000F42C File Offset: 0x0000D62C
		public unsafe XmlSchemaUse use
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_use);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_use)) = value;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06002421 RID: 9249 RVA: 0x000AB9F4 File Offset: 0x000A9BF4
		// (set) Token: 0x06002422 RID: 9250 RVA: 0x0000F447 File Offset: 0x0000D647
		public unsafe XmlQualifiedName refName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_refName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_refName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000ABA24 File Offset: 0x000A9C24
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x0000F466 File Offset: 0x0000D666
		public unsafe XmlQualifiedName typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_typeName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_typeName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000ABA54 File Offset: 0x000A9C54
		// (set) Token: 0x06002426 RID: 9254 RVA: 0x0000F485 File Offset: 0x0000D685
		public unsafe XmlQualifiedName qualifiedName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_qualifiedName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06002427 RID: 9255 RVA: 0x000ABA84 File Offset: 0x000A9C84
		// (set) Token: 0x06002428 RID: 9256 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public unsafe XmlSchemaSimpleType type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x06002429 RID: 9257 RVA: 0x000ABAB4 File Offset: 0x000A9CB4
		// (set) Token: 0x0600242A RID: 9258 RVA: 0x0000F4C3 File Offset: 0x0000D6C3
		public unsafe XmlSchemaSimpleType attributeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attributeType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaSimpleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attributeType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C27 RID: 3111
		// (get) Token: 0x0600242B RID: 9259 RVA: 0x000ABAE4 File Offset: 0x000A9CE4
		// (set) Token: 0x0600242C RID: 9260 RVA: 0x0000F4E2 File Offset: 0x0000D6E2
		public unsafe SchemaAttDef attDef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attDef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SchemaAttDef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttribute.NativeFieldInfoPtr_attDef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_fixedValue;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeFieldInfoPtr_form;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_use;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_refName;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeFieldInfoPtr_qualifiedName;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_attributeType;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeFieldInfoPtr_attDef;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultValue_Public_get_String_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultValue_Public_set_Void_String_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_get_FixedValue_Public_get_String_0;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeMethodInfoPtr_set_FixedValue_Public_set_Void_String_0;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x04001B3B RID: 6971
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001B3C RID: 6972
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001B3D RID: 6973
		private static readonly IntPtr NativeMethodInfoPtr_get_RefName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001B3E RID: 6974
		private static readonly IntPtr NativeMethodInfoPtr_set_RefName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001B3F RID: 6975
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaTypeName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001B40 RID: 6976
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaTypeName_Public_set_Void_XmlQualifiedName_0;

		// Token: 0x04001B41 RID: 6977
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001B42 RID: 6978
		private static readonly IntPtr NativeMethodInfoPtr_set_SchemaType_Public_set_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001B43 RID: 6979
		private static readonly IntPtr NativeMethodInfoPtr_get_Use_Public_get_XmlSchemaUse_0;

		// Token: 0x04001B44 RID: 6980
		private static readonly IntPtr NativeMethodInfoPtr_set_Use_Public_set_Void_XmlSchemaUse_0;

		// Token: 0x04001B45 RID: 6981
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001B46 RID: 6982
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeSchemaType_Public_get_XmlSchemaSimpleType_0;

		// Token: 0x04001B47 RID: 6983
		private static readonly IntPtr NativeMethodInfoPtr_get_Datatype_Internal_get_XmlSchemaDatatype_0;

		// Token: 0x04001B48 RID: 6984
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001B49 RID: 6985
		private static readonly IntPtr NativeMethodInfoPtr_SetAttributeType_Internal_Void_XmlSchemaSimpleType_0;

		// Token: 0x04001B4A RID: 6986
		private static readonly IntPtr NativeMethodInfoPtr_get_AttDef_Internal_get_SchemaAttDef_0;

		// Token: 0x04001B4B RID: 6987
		private static readonly IntPtr NativeMethodInfoPtr_set_AttDef_Internal_set_Void_SchemaAttDef_0;

		// Token: 0x04001B4C RID: 6988
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001B4D RID: 6989
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001B4E RID: 6990
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
