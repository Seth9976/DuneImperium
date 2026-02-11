using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200019E RID: 414
	public class XmlSchemaAttributeGroup : XmlSchemaAnnotated
	{
		// Token: 0x0600242D RID: 9261 RVA: 0x000ABB14 File Offset: 0x000A9D14
		// Note: this type is marked as 'beforefieldinit'.
		static XmlSchemaAttributeGroup()
		{
			Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "XmlSchemaAttributeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr);
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "name");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "attributes");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_anyAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "anyAttribute");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_qname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "qname");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_redefined = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "redefined");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "attributeUses");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeWildcard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "attributeWildcard");
			XmlSchemaAttributeGroup.NativeFieldInfoPtr_selfReferenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, "selfReferenceCount");
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668547);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668548);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668549);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668550);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668551);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668552);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AttributeUses_Internal_get_XmlSchemaObjectTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668553);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AttributeWildcard_Internal_get_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668554);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_AttributeWildcard_Internal_set_Void_XmlSchemaAnyAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668555);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_RedefinedAttributeGroup_Public_get_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668556);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668557);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaAttributeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668558);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_SelfReferenceCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668559);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_SelfReferenceCount_Internal_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668560);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668561);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668562);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668563);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668564);
			XmlSchemaAttributeGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr, 100668565);
		}

		// Token: 0x17000C3D RID: 3133
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000ABD60 File Offset: 0x000A9F60
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x000ABD98 File Offset: 0x000A9F98
		public unsafe string Name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C3E RID: 3134
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x000ABDDC File Offset: 0x000A9FDC
		public unsafe XmlSchemaObjectCollection Attributes
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002431 RID: 9265 RVA: 0x000ABE1C File Offset: 0x000AA01C
		// (set) Token: 0x06002432 RID: 9266 RVA: 0x000ABE5C File Offset: 0x000AA05C
		public unsafe XmlSchemaAnyAttribute AnyAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C40 RID: 3136
		// (get) Token: 0x06002433 RID: 9267 RVA: 0x000ABEA0 File Offset: 0x000AA0A0
		public unsafe XmlQualifiedName QualifiedName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr3) : null;
			}
		}

		// Token: 0x17000C41 RID: 3137
		// (get) Token: 0x06002434 RID: 9268 RVA: 0x000ABEE0 File Offset: 0x000AA0E0
		public unsafe XmlSchemaObjectTable AttributeUses
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 411049, RefRangeEnd = 411073, XrefRangeStart = 411044, XrefRangeEnd = 411049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AttributeUses_Internal_get_XmlSchemaObjectTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr3) : null;
			}
		}

		// Token: 0x17000C42 RID: 3138
		// (get) Token: 0x06002435 RID: 9269 RVA: 0x000ABF20 File Offset: 0x000AA120
		// (set) Token: 0x06002436 RID: 9270 RVA: 0x000ABF60 File Offset: 0x000AA160
		public unsafe XmlSchemaAnyAttribute AttributeWildcard
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_AttributeWildcard_Internal_get_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_AttributeWildcard_Internal_set_Void_XmlSchemaAnyAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C43 RID: 3139
		// (get) Token: 0x06002437 RID: 9271 RVA: 0x000ABFA4 File Offset: 0x000AA1A4
		public unsafe XmlSchemaAttributeGroup RedefinedAttributeGroup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_RedefinedAttributeGroup_Public_get_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr3) : null;
			}
		}

		// Token: 0x17000C44 RID: 3140
		// (get) Token: 0x06002438 RID: 9272 RVA: 0x000ABFE4 File Offset: 0x000AA1E4
		// (set) Token: 0x06002439 RID: 9273 RVA: 0x000AC024 File Offset: 0x000AA224
		public unsafe XmlSchemaAttributeGroup Redefined
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaAttributeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C45 RID: 3141
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x000AC068 File Offset: 0x000AA268
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x000AC0A4 File Offset: 0x000AA2A4
		public unsafe int SelfReferenceCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_SelfReferenceCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_SelfReferenceCount_Internal_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C46 RID: 3142
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x000AC0E4 File Offset: 0x000AA2E4
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x000AC128 File Offset: 0x000AA328
		public unsafe override string NameAttribute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttributeGroup.NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttributeGroup.NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600243E RID: 9278 RVA: 0x000AC178 File Offset: 0x000AA378
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x000AC1BC File Offset: 0x000AA3BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 411073, XrefRangeEnd = 411085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override XmlSchemaObject Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlSchemaAttributeGroup.NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaObject>(intPtr3) : null;
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x000AC208 File Offset: 0x000AA408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 411096, RefRangeEnd = 411098, XrefRangeStart = 411085, XrefRangeEnd = 411096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlSchemaAttributeGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlSchemaAttributeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlSchemaAttributeGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0000F501 File Offset: 0x0000D701
		public XmlSchemaAttributeGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C35 RID: 3125
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x000AC244 File Offset: 0x000AA444
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x0000F50A File Offset: 0x0000D70A
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C36 RID: 3126
		// (get) Token: 0x06002444 RID: 9284 RVA: 0x000AC26C File Offset: 0x000AA46C
		// (set) Token: 0x06002445 RID: 9285 RVA: 0x0000F529 File Offset: 0x0000D729
		public unsafe XmlSchemaObjectCollection attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C37 RID: 3127
		// (get) Token: 0x06002446 RID: 9286 RVA: 0x000AC29C File Offset: 0x000AA49C
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x0000F548 File Offset: 0x0000D748
		public unsafe XmlSchemaAnyAttribute anyAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_anyAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_anyAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C38 RID: 3128
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x000AC2CC File Offset: 0x000AA4CC
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0000F567 File Offset: 0x0000D767
		public unsafe XmlQualifiedName qname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_qname);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlQualifiedName>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_qname), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C39 RID: 3129
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x000AC2FC File Offset: 0x000AA4FC
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0000F586 File Offset: 0x0000D786
		public unsafe XmlSchemaAttributeGroup redefined
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_redefined);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAttributeGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_redefined), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3A RID: 3130
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x000AC32C File Offset: 0x000AA52C
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0000F5A5 File Offset: 0x0000D7A5
		public unsafe XmlSchemaObjectTable attributeUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeUses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaObjectTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeUses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3B RID: 3131
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x000AC35C File Offset: 0x000AA55C
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x0000F5C4 File Offset: 0x0000D7C4
		public unsafe XmlSchemaAnyAttribute attributeWildcard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeWildcard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaAnyAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_attributeWildcard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C3C RID: 3132
		// (get) Token: 0x06002450 RID: 9296 RVA: 0x000AC38C File Offset: 0x000AA58C
		// (set) Token: 0x06002451 RID: 9297 RVA: 0x0000F5E3 File Offset: 0x0000D7E3
		public unsafe int selfReferenceCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_selfReferenceCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlSchemaAttributeGroup.NativeFieldInfoPtr_selfReferenceCount)) = value;
			}
		}

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeFieldInfoPtr_anyAttribute;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeFieldInfoPtr_qname;

		// Token: 0x04001B54 RID: 6996
		private static readonly IntPtr NativeFieldInfoPtr_redefined;

		// Token: 0x04001B55 RID: 6997
		private static readonly IntPtr NativeFieldInfoPtr_attributeUses;

		// Token: 0x04001B56 RID: 6998
		private static readonly IntPtr NativeFieldInfoPtr_attributeWildcard;

		// Token: 0x04001B57 RID: 6999
		private static readonly IntPtr NativeFieldInfoPtr_selfReferenceCount;

		// Token: 0x04001B58 RID: 7000
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001B59 RID: 7001
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001B5A RID: 7002
		private static readonly IntPtr NativeMethodInfoPtr_get_Attributes_Public_get_XmlSchemaObjectCollection_0;

		// Token: 0x04001B5B RID: 7003
		private static readonly IntPtr NativeMethodInfoPtr_get_AnyAttribute_Public_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001B5C RID: 7004
		private static readonly IntPtr NativeMethodInfoPtr_set_AnyAttribute_Public_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001B5D RID: 7005
		private static readonly IntPtr NativeMethodInfoPtr_get_QualifiedName_Public_get_XmlQualifiedName_0;

		// Token: 0x04001B5E RID: 7006
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeUses_Internal_get_XmlSchemaObjectTable_0;

		// Token: 0x04001B5F RID: 7007
		private static readonly IntPtr NativeMethodInfoPtr_get_AttributeWildcard_Internal_get_XmlSchemaAnyAttribute_0;

		// Token: 0x04001B60 RID: 7008
		private static readonly IntPtr NativeMethodInfoPtr_set_AttributeWildcard_Internal_set_Void_XmlSchemaAnyAttribute_0;

		// Token: 0x04001B61 RID: 7009
		private static readonly IntPtr NativeMethodInfoPtr_get_RedefinedAttributeGroup_Public_get_XmlSchemaAttributeGroup_0;

		// Token: 0x04001B62 RID: 7010
		private static readonly IntPtr NativeMethodInfoPtr_get_Redefined_Internal_get_XmlSchemaAttributeGroup_0;

		// Token: 0x04001B63 RID: 7011
		private static readonly IntPtr NativeMethodInfoPtr_set_Redefined_Internal_set_Void_XmlSchemaAttributeGroup_0;

		// Token: 0x04001B64 RID: 7012
		private static readonly IntPtr NativeMethodInfoPtr_get_SelfReferenceCount_Internal_get_Int32_0;

		// Token: 0x04001B65 RID: 7013
		private static readonly IntPtr NativeMethodInfoPtr_set_SelfReferenceCount_Internal_set_Void_Int32_0;

		// Token: 0x04001B66 RID: 7014
		private static readonly IntPtr NativeMethodInfoPtr_get_NameAttribute_Internal_Virtual_get_String_0;

		// Token: 0x04001B67 RID: 7015
		private static readonly IntPtr NativeMethodInfoPtr_set_NameAttribute_Internal_Virtual_set_Void_String_0;

		// Token: 0x04001B68 RID: 7016
		private static readonly IntPtr NativeMethodInfoPtr_SetQualifiedName_Internal_Void_XmlQualifiedName_0;

		// Token: 0x04001B69 RID: 7017
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Internal_Virtual_XmlSchemaObject_0;

		// Token: 0x04001B6A RID: 7018
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
