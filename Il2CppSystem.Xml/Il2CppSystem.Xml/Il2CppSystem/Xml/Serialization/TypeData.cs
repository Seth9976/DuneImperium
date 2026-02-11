using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Xml.Schema;

namespace Il2CppSystem.Xml.Serialization
{
	// Token: 0x020000C4 RID: 196
	public class TypeData : Object
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x00068E18 File Offset: 0x00067018
		// Note: this type is marked as 'beforefieldinit'.
		static TypeData()
		{
			Il2CppClassPointerStore<TypeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Serialization", "TypeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeData>.NativeClassPtr);
			TypeData.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "type");
			TypeData.NativeFieldInfoPtr_elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "elementName");
			TypeData.NativeFieldInfoPtr_sType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "sType");
			TypeData.NativeFieldInfoPtr_listItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "listItemType");
			TypeData.NativeFieldInfoPtr_typeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "typeName");
			TypeData.NativeFieldInfoPtr_fullTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "fullTypeName");
			TypeData.NativeFieldInfoPtr_listItemTypeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "listItemTypeData");
			TypeData.NativeFieldInfoPtr_mappedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "mappedType");
			TypeData.NativeFieldInfoPtr_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "facet");
			TypeData.NativeFieldInfoPtr_typeConvertor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "typeConvertor");
			TypeData.NativeFieldInfoPtr_hasPublicConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "hasPublicConstructor");
			TypeData.NativeFieldInfoPtr_nullableOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "nullableOverride");
			TypeData.NativeFieldInfoPtr_keywords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeData>.NativeClassPtr, "keywords");
			TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666376);
			TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666377);
			TypeData.NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666378);
			TypeData.NativeMethodInfoPtr_ConvertForAssignment_Internal_Void_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666379);
			TypeData.NativeMethodInfoPtr_get_TypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666380);
			TypeData.NativeMethodInfoPtr_get_XmlType_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666381);
			TypeData.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666382);
			TypeData.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666383);
			TypeData.NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666384);
			TypeData.NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666385);
			TypeData.NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666386);
			TypeData.NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666387);
			TypeData.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666388);
			TypeData.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666389);
			TypeData.NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666390);
			TypeData.NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666391);
			TypeData.NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666392);
			TypeData.NativeMethodInfoPtr_get_HasPublicConstructor_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666393);
			TypeData.NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666394);
			TypeData.NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666395);
			TypeData.NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeData>.NativeClassPtr, 100666396);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000690F0 File Offset: 0x000672F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384033, XrefRangeEnd = 384034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeData(Type type, string elementName, bool isPrimitive)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimitive;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0006915C File Offset: 0x0006735C
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 384102, RefRangeEnd = 384156, XrefRangeStart = 384034, XrefRangeEnd = 384102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeData(Type type, string elementName, bool isPrimitive, TypeData mappedType, XmlSchemaPatternFacet facet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeData>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(elementName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPrimitive;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mappedType);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x000691F0 File Offset: 0x000673F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384156, XrefRangeEnd = 384162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LookupTypeConvertor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x00069224 File Offset: 0x00067424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384170, RefRangeEnd = 384171, XrefRangeStart = 384162, XrefRangeEnd = 384170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConvertForAssignment(ref Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(value);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_ConvertForAssignment_Internal_Void_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			}
		}

		// Token: 0x17000605 RID: 1541
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x0006927C File Offset: 0x0006747C
		public unsafe string TypeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_TypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000692B4 File Offset: 0x000674B4
		public unsafe string XmlType
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_XmlType_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000692EC File Offset: 0x000674EC
		public unsafe Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000608 RID: 1544
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x0006932C File Offset: 0x0006752C
		public unsafe string FullTypeName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000609 RID: 1545
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x00069364 File Offset: 0x00067564
		public unsafe SchemaTypes SchemaType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x060012ED RID: 4845 RVA: 0x000693A0 File Offset: 0x000675A0
		public unsafe bool IsListType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 384171, RefRangeEnd = 384174, XrefRangeStart = 384171, XrefRangeEnd = 384171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000693DC File Offset: 0x000675DC
		public unsafe bool IsComplexType
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 384174, RefRangeEnd = 384180, XrefRangeStart = 384174, XrefRangeEnd = 384174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060C RID: 1548
		// (get) Token: 0x060012EF RID: 4847 RVA: 0x00069418 File Offset: 0x00067618
		public unsafe bool IsValueType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 384184, RefRangeEnd = 384185, XrefRangeStart = 384180, XrefRangeEnd = 384184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700060D RID: 1549
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x00069454 File Offset: 0x00067654
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x00069490 File Offset: 0x00067690
		public unsafe bool IsNullable
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 384193, RefRangeEnd = 384198, XrefRangeStart = 384185, XrefRangeEnd = 384193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700060E RID: 1550
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000694D0 File Offset: 0x000676D0
		public unsafe TypeData ListItemTypeData
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 384211, RefRangeEnd = 384213, XrefRangeStart = 384198, XrefRangeEnd = 384211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr3) : null;
			}
		}

		// Token: 0x1700060F RID: 1551
		// (get) Token: 0x060012F3 RID: 4851 RVA: 0x00069510 File Offset: 0x00067710
		public unsafe Type ListItemType
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 384297, RefRangeEnd = 384303, XrefRangeStart = 384213, XrefRangeEnd = 384297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000610 RID: 1552
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x00069550 File Offset: 0x00067750
		public unsafe bool IsXsdType
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 384303, RefRangeEnd = 384306, XrefRangeStart = 384303, XrefRangeEnd = 384303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060012F5 RID: 4853 RVA: 0x0006958C File Offset: 0x0006778C
		public unsafe bool HasPublicConstructor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_get_HasPublicConstructor_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000695C8 File Offset: 0x000677C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 384314, RefRangeEnd = 384315, XrefRangeStart = 384306, XrefRangeEnd = 384314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyInfo GetIndexerProperty(Type collectionType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collectionType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0006960C File Offset: 0x0006780C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 384315, XrefRangeEnd = 384326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidOperationException CreateMissingAddMethodException(Type type, string inheritFrom, Type argumentType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(inheritFrom);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argumentType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr3) : null;
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x00069674 File Offset: 0x00067874
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 384337, RefRangeEnd = 384339, XrefRangeStart = 384326, XrefRangeEnd = 384337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetGenericListItemType(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeData.NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x0000802B File Offset: 0x0000622B
		public TypeData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x000696B8 File Offset: 0x000678B8
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x00008034 File Offset: 0x00006234
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x000696E8 File Offset: 0x000678E8
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x00008053 File Offset: 0x00006253
		public unsafe string elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00069710 File Offset: 0x00067910
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x00008072 File Offset: 0x00006272
		public unsafe SchemaTypes sType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_sType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_sType)) = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00069738 File Offset: 0x00067938
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x0000808D File Offset: 0x0000628D
		public unsafe Type listItemType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x00069768 File Offset: 0x00067968
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x000080AC File Offset: 0x000062AC
		public unsafe string typeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x00069790 File Offset: 0x00067990
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x000080CB File Offset: 0x000062CB
		public unsafe string fullTypeName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_fullTypeName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_fullTypeName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000697B8 File Offset: 0x000679B8
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x000080EA File Offset: 0x000062EA
		public unsafe TypeData listItemTypeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemTypeData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_listItemTypeData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x000697E8 File Offset: 0x000679E8
		// (set) Token: 0x06001309 RID: 4873 RVA: 0x00008109 File Offset: 0x00006309
		public unsafe TypeData mappedType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_mappedType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_mappedType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00069818 File Offset: 0x00067A18
		// (set) Token: 0x0600130B RID: 4875 RVA: 0x00008128 File Offset: 0x00006328
		public unsafe XmlSchemaPatternFacet facet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_facet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaPatternFacet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000601 RID: 1537
		// (get) Token: 0x0600130C RID: 4876 RVA: 0x00069848 File Offset: 0x00067A48
		// (set) Token: 0x0600130D RID: 4877 RVA: 0x00008147 File Offset: 0x00006347
		public unsafe MethodInfo typeConvertor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeConvertor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_typeConvertor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000602 RID: 1538
		// (get) Token: 0x0600130E RID: 4878 RVA: 0x00069878 File Offset: 0x00067A78
		// (set) Token: 0x0600130F RID: 4879 RVA: 0x00008166 File Offset: 0x00006366
		public unsafe bool hasPublicConstructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_hasPublicConstructor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_hasPublicConstructor)) = value;
			}
		}

		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06001310 RID: 4880 RVA: 0x000698A0 File Offset: 0x00067AA0
		// (set) Token: 0x06001311 RID: 4881 RVA: 0x00008181 File Offset: 0x00006381
		public unsafe bool nullableOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_nullableOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeData.NativeFieldInfoPtr_nullableOverride)) = value;
			}
		}

		// Token: 0x17000604 RID: 1540
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x000698C8 File Offset: 0x00067AC8
		// (set) Token: 0x06001313 RID: 4883 RVA: 0x0000819C File Offset: 0x0000639C
		public unsafe static Il2CppStringArray keywords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypeData.NativeFieldInfoPtr_keywords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypeData.NativeFieldInfoPtr_keywords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000F5A RID: 3930
		private static readonly IntPtr NativeFieldInfoPtr_elementName;

		// Token: 0x04000F5B RID: 3931
		private static readonly IntPtr NativeFieldInfoPtr_sType;

		// Token: 0x04000F5C RID: 3932
		private static readonly IntPtr NativeFieldInfoPtr_listItemType;

		// Token: 0x04000F5D RID: 3933
		private static readonly IntPtr NativeFieldInfoPtr_typeName;

		// Token: 0x04000F5E RID: 3934
		private static readonly IntPtr NativeFieldInfoPtr_fullTypeName;

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr_listItemTypeData;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeFieldInfoPtr_mappedType;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeFieldInfoPtr_facet;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeFieldInfoPtr_typeConvertor;

		// Token: 0x04000F63 RID: 3939
		private static readonly IntPtr NativeFieldInfoPtr_hasPublicConstructor;

		// Token: 0x04000F64 RID: 3940
		private static readonly IntPtr NativeFieldInfoPtr_nullableOverride;

		// Token: 0x04000F65 RID: 3941
		private static readonly IntPtr NativeFieldInfoPtr_keywords;

		// Token: 0x04000F66 RID: 3942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_0;

		// Token: 0x04000F67 RID: 3943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_String_Boolean_TypeData_XmlSchemaPatternFacet_0;

		// Token: 0x04000F68 RID: 3944
		private static readonly IntPtr NativeMethodInfoPtr_LookupTypeConvertor_Private_Void_0;

		// Token: 0x04000F69 RID: 3945
		private static readonly IntPtr NativeMethodInfoPtr_ConvertForAssignment_Internal_Void_byref_Object_0;

		// Token: 0x04000F6A RID: 3946
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeName_Public_get_String_0;

		// Token: 0x04000F6B RID: 3947
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlType_Public_get_String_0;

		// Token: 0x04000F6C RID: 3948
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x04000F6D RID: 3949
		private static readonly IntPtr NativeMethodInfoPtr_get_FullTypeName_Public_get_String_0;

		// Token: 0x04000F6E RID: 3950
		private static readonly IntPtr NativeMethodInfoPtr_get_SchemaType_Public_get_SchemaTypes_0;

		// Token: 0x04000F6F RID: 3951
		private static readonly IntPtr NativeMethodInfoPtr_get_IsListType_Public_get_Boolean_0;

		// Token: 0x04000F70 RID: 3952
		private static readonly IntPtr NativeMethodInfoPtr_get_IsComplexType_Public_get_Boolean_0;

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValueType_Public_get_Boolean_0;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeMethodInfoPtr_get_IsNullable_Public_get_Boolean_0;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeMethodInfoPtr_set_IsNullable_Public_set_Void_Boolean_0;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_get_ListItemTypeData_Public_get_TypeData_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_get_ListItemType_Public_get_Type_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_get_IsXsdType_Public_get_Boolean_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_get_HasPublicConstructor_Public_get_Boolean_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr_GetIndexerProperty_Public_Static_PropertyInfo_Type_0;

		// Token: 0x04000F79 RID: 3961
		private static readonly IntPtr NativeMethodInfoPtr_CreateMissingAddMethodException_Private_Static_InvalidOperationException_Type_String_Type_0;

		// Token: 0x04000F7A RID: 3962
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericListItemType_Internal_Static_Type_Type_0;
	}
}
