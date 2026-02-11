using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000FA RID: 250
	public class XmlTypeMapping : XmlMapping
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x00077898 File Offset: 0x00075A98
		// Note: this type is marked as 'beforefieldinit'.
		static XmlTypeMapping()
		{
			Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "XmlTypeMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr);
			XmlTypeMapping.NativeFieldInfoPtr_xmlType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "xmlType");
			XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "xmlTypeNamespace");
			XmlTypeMapping.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "type");
			XmlTypeMapping.NativeFieldInfoPtr_baseMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "baseMap");
			XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "multiReferenceType");
			XmlTypeMapping.NativeFieldInfoPtr_includeInSchema = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "includeInSchema");
			XmlTypeMapping.NativeFieldInfoPtr_isNullable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "isNullable");
			XmlTypeMapping.NativeFieldInfoPtr_isAny = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "isAny");
			XmlTypeMapping.NativeFieldInfoPtr__derivedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, "_derivedTypes");
			XmlTypeMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666880);
			XmlTypeMapping.NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666881);
			XmlTypeMapping.NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666882);
			XmlTypeMapping.NativeMethodInfoPtr_get_XmlType_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666883);
			XmlTypeMapping.NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666884);
			XmlTypeMapping.NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666885);
			XmlTypeMapping.NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666886);
			XmlTypeMapping.NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666887);
			XmlTypeMapping.NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666888);
			XmlTypeMapping.NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666889);
			XmlTypeMapping.NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666890);
			XmlTypeMapping.NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666891);
			XmlTypeMapping.NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666892);
			XmlTypeMapping.NativeMethodInfoPtr_get_IsNullable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666893);
			XmlTypeMapping.NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666894);
			XmlTypeMapping.NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666895);
			XmlTypeMapping.NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666896);
			XmlTypeMapping.NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666897);
			XmlTypeMapping.NativeMethodInfoPtr_GetRealElementMap_Internal_XmlTypeMapping_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666898);
			XmlTypeMapping.NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr, 100666899);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00077B0C File Offset: 0x00075D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 389886, RefRangeEnd = 389887, XrefRangeStart = 389877, XrefRangeEnd = 389886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping(string elementName, string ns, TypeData typeData, string xmlType, string xmlTypeNamespace)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XmlTypeMapping>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(elementName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ns);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeData);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(xmlTypeNamespace);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600169F RID: 5791 RVA: 0x00077BA4 File Offset: 0x00075DA4
		public unsafe string TypeFullName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 389887, RefRangeEnd = 389888, XrefRangeStart = 389887, XrefRangeEnd = 389887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x00077BDC File Offset: 0x00075DDC
		public unsafe TypeData TypeData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00077C1C File Offset: 0x00075E1C
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x00077C54 File Offset: 0x00075E54
		public unsafe string XmlType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_XmlType_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x00077C98 File Offset: 0x00075E98
		// (set) Token: 0x060016A4 RID: 5796 RVA: 0x00077CD0 File Offset: 0x00075ED0
		public unsafe string XmlTypeNamespace
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 389890, RefRangeEnd = 389902, XrefRangeStart = 389888, XrefRangeEnd = 389890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x00077D14 File Offset: 0x00075F14
		public unsafe bool HasXmlTypeNamespace
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 389902, RefRangeEnd = 389904, XrefRangeStart = 389902, XrefRangeEnd = 389902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x00077D50 File Offset: 0x00075F50
		public unsafe ArrayList DerivedTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00077D90 File Offset: 0x00075F90
		public unsafe bool MultiReferenceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00077DCC File Offset: 0x00075FCC
		// (set) Token: 0x060016A9 RID: 5801 RVA: 0x00077E0C File Offset: 0x0007600C
		public unsafe XmlTypeMapping BaseMap
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000740 RID: 1856
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00077E50 File Offset: 0x00076050
		public unsafe bool IncludeInSchema
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00077E90 File Offset: 0x00076090
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x00077ECC File Offset: 0x000760CC
		public unsafe bool IsNullable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_IsNullable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x00077F0C File Offset: 0x0007610C
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x00077F48 File Offset: 0x00076148
		public unsafe bool IsAny
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00077F88 File Offset: 0x00076188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389904, XrefRangeEnd = 389914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRealTypeMap(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00077FD8 File Offset: 0x000761D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389914, XrefRangeEnd = 389930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XmlTypeMapping GetRealElementMap(string name, string ens)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(ens);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_GetRealElementMap_Internal_XmlTypeMapping_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr3) : null;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x0007803C File Offset: 0x0007623C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389930, XrefRangeEnd = 389936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRoot(XmlQualifiedName qname)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(qname);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XmlTypeMapping.NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00009998 File Offset: 0x00007B98
		public XmlTypeMapping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x060016B3 RID: 5811 RVA: 0x00078080 File Offset: 0x00076280
		// (set) Token: 0x060016B4 RID: 5812 RVA: 0x000099A1 File Offset: 0x00007BA1
		public unsafe string xmlType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x060016B5 RID: 5813 RVA: 0x000780A8 File Offset: 0x000762A8
		// (set) Token: 0x060016B6 RID: 5814 RVA: 0x000099C0 File Offset: 0x00007BC0
		public unsafe string xmlTypeNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_xmlTypeNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x060016B7 RID: 5815 RVA: 0x000780D0 File Offset: 0x000762D0
		// (set) Token: 0x060016B8 RID: 5816 RVA: 0x000099DF File Offset: 0x00007BDF
		public unsafe TypeData type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000732 RID: 1842
		// (get) Token: 0x060016B9 RID: 5817 RVA: 0x00078100 File Offset: 0x00076300
		// (set) Token: 0x060016BA RID: 5818 RVA: 0x000099FE File Offset: 0x00007BFE
		public unsafe XmlTypeMapping baseMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_baseMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlTypeMapping>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_baseMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00078130 File Offset: 0x00076330
		// (set) Token: 0x060016BC RID: 5820 RVA: 0x00009A1D File Offset: 0x00007C1D
		public unsafe bool multiReferenceType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_multiReferenceType)) = value;
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x00078158 File Offset: 0x00076358
		// (set) Token: 0x060016BE RID: 5822 RVA: 0x00009A38 File Offset: 0x00007C38
		public unsafe bool includeInSchema
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_includeInSchema);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_includeInSchema)) = value;
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00078180 File Offset: 0x00076380
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x00009A53 File Offset: 0x00007C53
		public unsafe bool isNullable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isNullable);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isNullable)) = value;
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060016C1 RID: 5825 RVA: 0x000781A8 File Offset: 0x000763A8
		// (set) Token: 0x060016C2 RID: 5826 RVA: 0x00009A6E File Offset: 0x00007C6E
		public unsafe bool isAny
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isAny);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr_isAny)) = value;
			}
		}

		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x060016C3 RID: 5827 RVA: 0x000781D0 File Offset: 0x000763D0
		// (set) Token: 0x060016C4 RID: 5828 RVA: 0x00009A89 File Offset: 0x00007C89
		public unsafe ArrayList _derivedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr__derivedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XmlTypeMapping.NativeFieldInfoPtr__derivedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011E9 RID: 4585
		private static readonly IntPtr NativeFieldInfoPtr_xmlType;

		// Token: 0x040011EA RID: 4586
		private static readonly IntPtr NativeFieldInfoPtr_xmlTypeNamespace;

		// Token: 0x040011EB RID: 4587
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040011EC RID: 4588
		private static readonly IntPtr NativeFieldInfoPtr_baseMap;

		// Token: 0x040011ED RID: 4589
		private static readonly IntPtr NativeFieldInfoPtr_multiReferenceType;

		// Token: 0x040011EE RID: 4590
		private static readonly IntPtr NativeFieldInfoPtr_includeInSchema;

		// Token: 0x040011EF RID: 4591
		private static readonly IntPtr NativeFieldInfoPtr_isNullable;

		// Token: 0x040011F0 RID: 4592
		private static readonly IntPtr NativeFieldInfoPtr_isAny;

		// Token: 0x040011F1 RID: 4593
		private static readonly IntPtr NativeFieldInfoPtr__derivedTypes;

		// Token: 0x040011F2 RID: 4594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_String_TypeData_String_String_0;

		// Token: 0x040011F3 RID: 4595
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeFullName_Public_get_String_0;

		// Token: 0x040011F4 RID: 4596
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeData_Internal_get_TypeData_0;

		// Token: 0x040011F5 RID: 4597
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Internal_get_String_0;

		// Token: 0x040011F6 RID: 4598
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlType_Internal_set_Void_String_0;

		// Token: 0x040011F7 RID: 4599
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlTypeNamespace_Internal_get_String_0;

		// Token: 0x040011F8 RID: 4600
		private static readonly IntPtr NativeMethodInfoPtr_set_XmlTypeNamespace_Internal_set_Void_String_0;

		// Token: 0x040011F9 RID: 4601
		private static readonly IntPtr NativeMethodInfoPtr_get_HasXmlTypeNamespace_Internal_get_Boolean_0;

		// Token: 0x040011FA RID: 4602
		private static readonly IntPtr NativeMethodInfoPtr_get_DerivedTypes_Internal_get_ArrayList_0;

		// Token: 0x040011FB RID: 4603
		private static readonly IntPtr NativeMethodInfoPtr_get_MultiReferenceType_Internal_get_Boolean_0;

		// Token: 0x040011FC RID: 4604
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseMap_Internal_get_XmlTypeMapping_0;

		// Token: 0x040011FD RID: 4605
		private static readonly IntPtr NativeMethodInfoPtr_set_BaseMap_Internal_set_Void_XmlTypeMapping_0;

		// Token: 0x040011FE RID: 4606
		private static readonly IntPtr NativeMethodInfoPtr_set_IncludeInSchema_Internal_set_Void_Boolean_0;

		// Token: 0x040011FF RID: 4607
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Internal_get_Boolean_0;

		// Token: 0x04001200 RID: 4608
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Internal_set_Void_Boolean_0;

		// Token: 0x04001201 RID: 4609
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAny_Internal_get_Boolean_0;

		// Token: 0x04001202 RID: 4610
		private static readonly IntPtr NativeMethodInfoPtr_set_IsAny_Internal_set_Void_Boolean_0;

		// Token: 0x04001203 RID: 4611
		private static readonly IntPtr NativeMethodInfoPtr_GetRealTypeMap_Internal_XmlTypeMapping_Type_0;

		// Token: 0x04001204 RID: 4612
		private static readonly IntPtr NativeMethodInfoPtr_GetRealElementMap_Internal_XmlTypeMapping_String_String_0;

		// Token: 0x04001205 RID: 4613
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRoot_Internal_Void_XmlQualifiedName_0;
	}
}
