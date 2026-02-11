using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000111 RID: 273
	public class TypedObject : Object
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x0007E4B8 File Offset: 0x0007C6B8
		// Note: this type is marked as 'beforefieldinit'.
		static TypedObject()
		{
			Il2CppClassPointerStore<TypedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "TypedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedObject>.NativeClassPtr);
			TypedObject.NativeFieldInfoPtr_dstruct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "dstruct");
			TypedObject.NativeFieldInfoPtr_ovalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "ovalue");
			TypedObject.NativeFieldInfoPtr_svalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "svalue");
			TypedObject.NativeFieldInfoPtr_xsdtype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "xsdtype");
			TypedObject.NativeFieldInfoPtr_dim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "dim");
			TypedObject.NativeFieldInfoPtr_isList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "isList");
			TypedObject.NativeMethodInfoPtr_get_Dim_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667083);
			TypedObject.NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667084);
			TypedObject.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667085);
			TypedObject.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667086);
			TypedObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667087);
			TypedObject.NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667088);
			TypedObject.NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667089);
			TypedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667090);
			TypedObject.NativeMethodInfoPtr_SetDecimal_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667091);
			TypedObject.NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667092);
			TypedObject.NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, 100667093);
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x0007E63C File Offset: 0x0007C83C
		public unsafe int Dim
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Dim_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x0007E678 File Offset: 0x0007C878
		public unsafe bool IsList
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0007E6B4 File Offset: 0x0007C8B4
		public unsafe bool IsDecimal
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x0007E6F0 File Offset: 0x0007C8F0
		public unsafe Il2CppStructArray<Decimal> Dvalue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr3) : null;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x0007E730 File Offset: 0x0007C930
		public unsafe Object Value
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0007E770 File Offset: 0x0007C970
		public unsafe XmlSchemaDatatype Type
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr3) : null;
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0007E7B0 File Offset: 0x0007C9B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 391968, RefRangeEnd = 391973, XrefRangeStart = 391957, XrefRangeEnd = 391968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedObject(Object obj, string svalue, XmlSchemaDatatype xsdtype)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(svalue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xsdtype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x0007E820 File Offset: 0x0007CA20
		[CallerCount(0)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001879 RID: 6265 RVA: 0x0007E864 File Offset: 0x0007CA64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 391980, RefRangeEnd = 391983, XrefRangeStart = 391973, XrefRangeEnd = 391980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDecimal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_SetDecimal_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0007E898 File Offset: 0x0007CA98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391983, XrefRangeEnd = 391987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ListDValueEquals(TypedObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x0007E8E8 File Offset: 0x0007CAE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 391995, RefRangeEnd = 391996, XrefRangeStart = 391987, XrefRangeEnd = 391995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(TypedObject other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0000A77C File Offset: 0x0000897C
		public TypedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x0007E938 File Offset: 0x0007CB38
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x0000A785 File Offset: 0x00008985
		public unsafe TypedObject.DecimalStruct dstruct
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dstruct);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypedObject.DecimalStruct>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dstruct), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0007E968 File Offset: 0x0007CB68
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x0000A7A4 File Offset: 0x000089A4
		public unsafe Object ovalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_ovalue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_ovalue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x0007E998 File Offset: 0x0007CB98
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x0000A7C3 File Offset: 0x000089C3
		public unsafe string svalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_svalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_svalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x0007E9C0 File Offset: 0x0007CBC0
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x0000A7E2 File Offset: 0x000089E2
		public unsafe XmlSchemaDatatype xsdtype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_xsdtype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_xsdtype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0007E9F0 File Offset: 0x0007CBF0
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x0000A801 File Offset: 0x00008A01
		public unsafe int dim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_dim)) = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x0007EA18 File Offset: 0x0007CC18
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x0000A81C File Offset: 0x00008A1C
		public unsafe bool isList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_isList);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.NativeFieldInfoPtr_isList)) = value;
			}
		}

		// Token: 0x0400131E RID: 4894
		private static readonly IntPtr NativeFieldInfoPtr_dstruct;

		// Token: 0x0400131F RID: 4895
		private static readonly IntPtr NativeFieldInfoPtr_ovalue;

		// Token: 0x04001320 RID: 4896
		private static readonly IntPtr NativeFieldInfoPtr_svalue;

		// Token: 0x04001321 RID: 4897
		private static readonly IntPtr NativeFieldInfoPtr_xsdtype;

		// Token: 0x04001322 RID: 4898
		private static readonly IntPtr NativeFieldInfoPtr_dim;

		// Token: 0x04001323 RID: 4899
		private static readonly IntPtr NativeFieldInfoPtr_isList;

		// Token: 0x04001324 RID: 4900
		private static readonly IntPtr NativeMethodInfoPtr_get_Dim_Public_get_Int32_0;

		// Token: 0x04001325 RID: 4901
		private static readonly IntPtr NativeMethodInfoPtr_get_IsList_Public_get_Boolean_0;

		// Token: 0x04001326 RID: 4902
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0;

		// Token: 0x04001327 RID: 4903
		private static readonly IntPtr NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0;

		// Token: 0x04001328 RID: 4904
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;

		// Token: 0x04001329 RID: 4905
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_XmlSchemaDatatype_0;

		// Token: 0x0400132A RID: 4906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_String_XmlSchemaDatatype_0;

		// Token: 0x0400132B RID: 4907
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400132C RID: 4908
		private static readonly IntPtr NativeMethodInfoPtr_SetDecimal_Public_Void_0;

		// Token: 0x0400132D RID: 4909
		private static readonly IntPtr NativeMethodInfoPtr_ListDValueEquals_Private_Boolean_TypedObject_0;

		// Token: 0x0400132E RID: 4910
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_TypedObject_0;

		// Token: 0x02000255 RID: 597
		public class DecimalStruct : Object
		{
			// Token: 0x06003145 RID: 12613 RVA: 0x000DC884 File Offset: 0x000DAA84
			// Note: this type is marked as 'beforefieldinit'.
			static DecimalStruct()
			{
				Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypedObject>.NativeClassPtr, "DecimalStruct");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr);
				TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, "isDecimal");
				TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, "dvalue");
				TypedObject.DecimalStruct.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100667094);
				TypedObject.DecimalStruct.NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100667095);
				TypedObject.DecimalStruct.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100667096);
				TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100667097);
				TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr, 100667098);
			}

			// Token: 0x1700109A RID: 4250
			// (get) Token: 0x06003146 RID: 12614 RVA: 0x000DC93C File Offset: 0x000DAB3C
			// (set) Token: 0x06003147 RID: 12615 RVA: 0x000DC978 File Offset: 0x000DAB78
			public unsafe bool IsDecimal
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x1700109B RID: 4251
			// (get) Token: 0x06003148 RID: 12616 RVA: 0x000DC9B8 File Offset: 0x000DABB8
			public unsafe Il2CppStructArray<Decimal> Dvalue
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr3) : null;
				}
			}

			// Token: 0x06003149 RID: 12617 RVA: 0x000DC9F8 File Offset: 0x000DABF8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 391951, RefRangeEnd = 391952, XrefRangeStart = 391946, XrefRangeEnd = 391951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecimalStruct()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600314A RID: 12618 RVA: 0x000DCA34 File Offset: 0x000DAC34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391952, XrefRangeEnd = 391957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DecimalStruct(int dim)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedObject.DecimalStruct>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref dim;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedObject.DecimalStruct.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600314B RID: 12619 RVA: 0x00014D81 File Offset: 0x00012F81
			public DecimalStruct(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x0600314C RID: 12620 RVA: 0x000DCA7C File Offset: 0x000DAC7C
			// (set) Token: 0x0600314D RID: 12621 RVA: 0x00014D8A File Offset: 0x00012F8A
			public unsafe bool isDecimal
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_isDecimal)) = value;
				}
			}

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x0600314E RID: 12622 RVA: 0x000DCAA4 File Offset: 0x000DACA4
			// (set) Token: 0x0600314F RID: 12623 RVA: 0x00014DA5 File Offset: 0x00012FA5
			public unsafe Il2CppStructArray<Decimal> dvalue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Decimal>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedObject.DecimalStruct.NativeFieldInfoPtr_dvalue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002624 RID: 9764
			private static readonly IntPtr NativeFieldInfoPtr_isDecimal;

			// Token: 0x04002625 RID: 9765
			private static readonly IntPtr NativeFieldInfoPtr_dvalue;

			// Token: 0x04002626 RID: 9766
			private static readonly IntPtr NativeMethodInfoPtr_get_IsDecimal_Public_get_Boolean_0;

			// Token: 0x04002627 RID: 9767
			private static readonly IntPtr NativeMethodInfoPtr_set_IsDecimal_Public_set_Void_Boolean_0;

			// Token: 0x04002628 RID: 9768
			private static readonly IntPtr NativeMethodInfoPtr_get_Dvalue_Public_get_Il2CppStructArray_1_Decimal_0;

			// Token: 0x04002629 RID: 9769
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400262A RID: 9770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
		}
	}
}
