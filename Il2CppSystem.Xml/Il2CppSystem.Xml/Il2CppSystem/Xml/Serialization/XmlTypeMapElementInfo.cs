using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000EF RID: 239
	public class XmlTypeMapElementInfo : Object
	{
		// Token: 0x060015F4 RID: 5620 RVA: 0x00075348 File Offset: 0x00073548
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapElementInfo()
		{
			Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapElementInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr);
			XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_elementName");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_namespace");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__form = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_form");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__member = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_member");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_choiceValue");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_isNullable");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_nestingLevel");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_mappedType");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_type");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_wrappedElement");
			XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, "_explicitOrder");
			XmlTypeMapElementInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666795);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666796);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666797);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666798);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666799);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666800);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666801);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666802);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666803);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666804);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666805);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666806);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666807);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666808);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666809);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666810);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Member_Public_get_XmlTypeMapMember_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666811);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666812);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MultiReferenceType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666813);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666814);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666815);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666816);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666817);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666818);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666819);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666820);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666821);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666822);
			XmlTypeMapElementInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr, 100666823);
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00075698 File Offset: 0x00073898
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 389607, RefRangeEnd = 389614, XrefRangeStart = 389598, XrefRangeEnd = 389607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapElementInfo(XmlTypeMapMember member, TypeData type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapElementInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x060015F6 RID: 5622 RVA: 0x000756F8 File Offset: 0x000738F8
		public unsafe TypeData TypeData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x060015F7 RID: 5623 RVA: 0x00075738 File Offset: 0x00073938
		// (set) Token: 0x060015F8 RID: 5624 RVA: 0x00075778 File Offset: 0x00073978
		public unsafe Object ChoiceValue
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x000757BC File Offset: 0x000739BC
		// (set) Token: 0x060015FA RID: 5626 RVA: 0x000757F4 File Offset: 0x000739F4
		public unsafe string ElementName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00075838 File Offset: 0x00073A38
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00075870 File Offset: 0x00073A70
		public unsafe string Namespace
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x000758B4 File Offset: 0x00073AB4
		public unsafe string DataTypeNamespace
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 389617, RefRangeEnd = 389620, XrefRangeStart = 389614, XrefRangeEnd = 389617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x000758EC File Offset: 0x00073AEC
		public unsafe string DataTypeName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00075924 File Offset: 0x00073B24
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x00075960 File Offset: 0x00073B60
		public unsafe XmlSchemaForm Form
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 287294, RefRangeEnd = 287297, XrefRangeStart = 287294, XrefRangeEnd = 287297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x000759A0 File Offset: 0x00073BA0
		// (set) Token: 0x06001602 RID: 5634 RVA: 0x000759E0 File Offset: 0x00073BE0
		public unsafe XmlTypeMapping MappedType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00075A24 File Offset: 0x00073C24
		// (set) Token: 0x06001604 RID: 5636 RVA: 0x00075A60 File Offset: 0x00073C60
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x00075AA0 File Offset: 0x00073CA0
		public unsafe XmlTypeMapMember Member
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_Member_Public_get_XmlTypeMapMember_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr3) : null;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (set) Token: 0x06001606 RID: 5638 RVA: 0x00075AE0 File Offset: 0x00073CE0
		public unsafe int NestingLevel
		{
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00075B20 File Offset: 0x00073D20
		public unsafe bool MultiReferenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_MultiReferenceType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x00075B5C File Offset: 0x00073D5C
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x00075B98 File Offset: 0x00073D98
		public unsafe bool WrappedElement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x0600160A RID: 5642 RVA: 0x00075BD8 File Offset: 0x00073DD8
		// (set) Token: 0x0600160B RID: 5643 RVA: 0x00075C14 File Offset: 0x00073E14
		public unsafe bool IsTextElement
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389623, RefRangeEnd = 389624, XrefRangeStart = 389620, XrefRangeEnd = 389623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389636, RefRangeEnd = 389637, XrefRangeStart = 389624, XrefRangeEnd = 389636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x0600160C RID: 5644 RVA: 0x00075C54 File Offset: 0x00073E54
		// (set) Token: 0x0600160D RID: 5645 RVA: 0x00075C90 File Offset: 0x00073E90
		public unsafe bool IsUnnamedAnyElement
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389637, XrefRangeEnd = 389640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389651, RefRangeEnd = 389652, XrefRangeStart = 389640, XrefRangeEnd = 389651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x0600160E RID: 5646 RVA: 0x00075CD0 File Offset: 0x00073ED0
		// (set) Token: 0x0600160F RID: 5647 RVA: 0x00075D0C File Offset: 0x00073F0C
		public unsafe int ExplicitOrder
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 357464, RefRangeEnd = 357469, XrefRangeStart = 357464, XrefRangeEnd = 357469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapElementInfo.NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00075D4C File Offset: 0x00073F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389652, XrefRangeEnd = 389657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeMapElementInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x00075DA4 File Offset: 0x00073FA4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 389658, RefRangeEnd = 389671, XrefRangeStart = 389657, XrefRangeEnd = 389658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), XmlTypeMapElementInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001612 RID: 5650 RVA: 0x000094C0 File Offset: 0x000076C0
		public XmlTypeMapElementInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001613 RID: 5651 RVA: 0x00075DEC File Offset: 0x00073FEC
		// (set) Token: 0x06001614 RID: 5652 RVA: 0x000094C9 File Offset: 0x000076C9
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001615 RID: 5653 RVA: 0x00075E14 File Offset: 0x00074014
		// (set) Token: 0x06001616 RID: 5654 RVA: 0x000094E8 File Offset: 0x000076E8
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001617 RID: 5655 RVA: 0x00075E3C File Offset: 0x0007403C
		// (set) Token: 0x06001618 RID: 5656 RVA: 0x00009507 File Offset: 0x00007707
		public unsafe XmlSchemaForm _form
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__form);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__form)) = value;
			}
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00075E64 File Offset: 0x00074064
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00009522 File Offset: 0x00007722
		public unsafe XmlTypeMapMember _member
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__member);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapMember>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__member), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00075E94 File Offset: 0x00074094
		// (set) Token: 0x0600161C RID: 5660 RVA: 0x00009541 File Offset: 0x00007741
		public unsafe Object _choiceValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__choiceValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600161D RID: 5661 RVA: 0x00075EC4 File Offset: 0x000740C4
		// (set) Token: 0x0600161E RID: 5662 RVA: 0x00009560 File Offset: 0x00007760
		public unsafe bool _isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__isNullable)) = value;
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600161F RID: 5663 RVA: 0x00075EEC File Offset: 0x000740EC
		// (set) Token: 0x06001620 RID: 5664 RVA: 0x0000957B File Offset: 0x0000777B
		public unsafe int _nestingLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__nestingLevel)) = value;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001621 RID: 5665 RVA: 0x00075F14 File Offset: 0x00074114
		// (set) Token: 0x06001622 RID: 5666 RVA: 0x00009596 File Offset: 0x00007796
		public unsafe XmlTypeMapping _mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001623 RID: 5667 RVA: 0x00075F44 File Offset: 0x00074144
		// (set) Token: 0x06001624 RID: 5668 RVA: 0x000095B5 File Offset: 0x000077B5
		public unsafe TypeData _type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00075F74 File Offset: 0x00074174
		// (set) Token: 0x06001626 RID: 5670 RVA: 0x000095D4 File Offset: 0x000077D4
		public unsafe bool _wrappedElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__wrappedElement)) = value;
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001627 RID: 5671 RVA: 0x00075F9C File Offset: 0x0007419C
		// (set) Token: 0x06001628 RID: 5672 RVA: 0x000095EF File Offset: 0x000077EF
		public unsafe int _explicitOrder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapElementInfo.NativeFieldInfoPtr__explicitOrder)) = value;
			}
		}

		// Token: 0x04001175 RID: 4469
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04001176 RID: 4470
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x04001177 RID: 4471
		private static readonly IntPtr NativeFieldInfoPtr__form;

		// Token: 0x04001178 RID: 4472
		private static readonly IntPtr NativeFieldInfoPtr__member;

		// Token: 0x04001179 RID: 4473
		private static readonly IntPtr NativeFieldInfoPtr__choiceValue;

		// Token: 0x0400117A RID: 4474
		private static readonly IntPtr NativeFieldInfoPtr__isNullable;

		// Token: 0x0400117B RID: 4475
		private static readonly IntPtr NativeFieldInfoPtr__nestingLevel;

		// Token: 0x0400117C RID: 4476
		private static readonly IntPtr NativeFieldInfoPtr__mappedType;

		// Token: 0x0400117D RID: 4477
		private static readonly IntPtr NativeFieldInfoPtr__type;

		// Token: 0x0400117E RID: 4478
		private static readonly IntPtr NativeFieldInfoPtr__wrappedElement;

		// Token: 0x0400117F RID: 4479
		private static readonly IntPtr NativeFieldInfoPtr__explicitOrder;

		// Token: 0x04001180 RID: 4480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_XmlTypeMapMember_TypeData_0;

		// Token: 0x04001181 RID: 4481
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Public_get_TypeData_0;

		// Token: 0x04001182 RID: 4482
		private static readonly IntPtr NativeMethodInfoPtr_get_ChoiceValue_Public_get_Object_0;

		// Token: 0x04001183 RID: 4483
		private static readonly IntPtr NativeMethodInfoPtr_set_ChoiceValue_Public_set_Void_Object_0;

		// Token: 0x04001184 RID: 4484
		private static readonly IntPtr NativeMethodInfoPtr_get_ElementName_Public_get_String_0;

		// Token: 0x04001185 RID: 4485
		private static readonly IntPtr NativeMethodInfoPtr_set_ElementName_Public_set_Void_String_0;

		// Token: 0x04001186 RID: 4486
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x04001187 RID: 4487
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x04001188 RID: 4488
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypeNamespace_Public_get_String_0;

		// Token: 0x04001189 RID: 4489
		private static readonly IntPtr NativeMethodInfoPtr_get_DataTypeName_Public_get_String_0;

		// Token: 0x0400118A RID: 4490
		private static readonly IntPtr NativeMethodInfoPtr_get_Form_Public_get_XmlSchemaForm_0;

		// Token: 0x0400118B RID: 4491
		private static readonly IntPtr NativeMethodInfoPtr_set_Form_Public_set_Void_XmlSchemaForm_0;

		// Token: 0x0400118C RID: 4492
		private static readonly IntPtr NativeMethodInfoPtr_get_MappedType_Public_get_XmlTypeMapping_0;

		// Token: 0x0400118D RID: 4493
		private static readonly IntPtr NativeMethodInfoPtr_set_MappedType_Public_set_Void_XmlTypeMapping_0;

		// Token: 0x0400118E RID: 4494
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x0400118F RID: 4495
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0;

		// Token: 0x04001190 RID: 4496
		private static readonly IntPtr NativeMethodInfoPtr_get_Member_Public_get_XmlTypeMapMember_0;

		// Token: 0x04001191 RID: 4497
		private static readonly IntPtr NativeMethodInfoPtr_set_NestingLevel_Public_set_Void_Int32_0;

		// Token: 0x04001192 RID: 4498
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiReferenceType_Public_get_Boolean_0;

		// Token: 0x04001193 RID: 4499
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedElement_Public_get_Boolean_0;

		// Token: 0x04001194 RID: 4500
		private static readonly IntPtr NativeMethodInfoPtr_set_WrappedElement_Public_set_Void_Boolean_0;

		// Token: 0x04001195 RID: 4501
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTextElement_Public_get_Boolean_0;

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_set_IsTextElement_Public_set_Void_Boolean_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnnamedAnyElement_Public_get_Boolean_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnnamedAnyElement_Public_set_Void_Boolean_0;

		// Token: 0x04001199 RID: 4505
		private static readonly IntPtr NativeMethodInfoPtr_get_ExplicitOrder_Public_get_Int32_0;

		// Token: 0x0400119A RID: 4506
		private static readonly IntPtr NativeMethodInfoPtr_set_ExplicitOrder_Public_set_Void_Int32_0;

		// Token: 0x0400119B RID: 4507
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400119C RID: 4508
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
