using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016E RID: 366
	public class Numeric10FacetsChecker : FacetsChecker
	{
		// Token: 0x06001D42 RID: 7490 RVA: 0x000913C4 File Offset: 0x0008F5C4
		// Note: this type is marked as 'beforefieldinit'.
		static Numeric10FacetsChecker()
		{
			Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Numeric10FacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr);
			Numeric10FacetsChecker.NativeFieldInfoPtr_signs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "signs");
			Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "maxValue");
			Numeric10FacetsChecker.NativeFieldInfoPtr_minValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, "minValue");
			Numeric10FacetsChecker.NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667719);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667720);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667721);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667722);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667723);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667724);
			Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667725);
			Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667726);
			Numeric10FacetsChecker.NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr, 100667727);
		}

		// Token: 0x06001D43 RID: 7491 RVA: 0x000914E4 File Offset: 0x0008F6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395968, XrefRangeEnd = 395969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Numeric10FacetsChecker(Decimal minVal, Decimal maxVal)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Numeric10FacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref minVal;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D44 RID: 7492 RVA: 0x0009153C File Offset: 0x0008F73C
		[CallerCount(0)]
		public unsafe override Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D45 RID: 7493 RVA: 0x000915AC File Offset: 0x0008F7AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395969, XrefRangeEnd = 395997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00091618 File Offset: 0x0008F818
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395997, XrefRangeEnd = 396001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00091684 File Offset: 0x0008F884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396001, XrefRangeEnd = 396005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x000916F0 File Offset: 0x0008F8F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396005, XrefRangeEnd = 396009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x0009175C File Offset: 0x0008F95C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396009, XrefRangeEnd = 396014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4A RID: 7498 RVA: 0x000917D8 File Offset: 0x0008F9D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 396014, XrefRangeEnd = 396019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MatchEnumeration(Decimal value, ArrayList enumeration, XmlValueConverter valueConverter)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enumeration);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueConverter);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D4B RID: 7499 RVA: 0x00091848 File Offset: 0x0008FA48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 396067, RefRangeEnd = 396069, XrefRangeStart = 396019, XrefRangeEnd = 396067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckTotalAndFractionDigits(Decimal value, int totalDigits, int fractionDigits, bool checkTotal, bool checkFraction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref totalDigits;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fractionDigits;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkTotal;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref checkFraction;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Numeric10FacetsChecker.NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D4C RID: 7500 RVA: 0x0000C114 File Offset: 0x0000A314
		public Numeric10FacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x000918CC File Offset: 0x0008FACC
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0000C11D File Offset: 0x0000A31D
		public unsafe static Il2CppStructArray<char> signs
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Numeric10FacetsChecker.NativeFieldInfoPtr_signs, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Numeric10FacetsChecker.NativeFieldInfoPtr_signs, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x000918F4 File Offset: 0x0008FAF4
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0000C12F File Offset: 0x0000A32F
		public unsafe Decimal maxValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_maxValue)) = value;
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0009191C File Offset: 0x0008FB1C
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x0000C14A File Offset: 0x0000A34A
		public unsafe Decimal minValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_minValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Numeric10FacetsChecker.NativeFieldInfoPtr_minValue)) = value;
			}
		}

		// Token: 0x0400165C RID: 5724
		private static readonly IntPtr NativeFieldInfoPtr_signs;

		// Token: 0x0400165D RID: 5725
		private static readonly IntPtr NativeFieldInfoPtr_maxValue;

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeFieldInfoPtr_minValue;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Decimal_Decimal_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Decimal_XmlSchemaDatatype_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int64_XmlSchemaDatatype_0;

		// Token: 0x04001663 RID: 5731
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int32_XmlSchemaDatatype_0;

		// Token: 0x04001664 RID: 5732
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_Exception_Int16_XmlSchemaDatatype_0;

		// Token: 0x04001665 RID: 5733
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04001666 RID: 5734
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Boolean_Decimal_ArrayList_XmlValueConverter_0;

		// Token: 0x04001667 RID: 5735
		private static readonly IntPtr NativeMethodInfoPtr_CheckTotalAndFractionDigits_Internal_Exception_Decimal_Int32_Int32_Boolean_Boolean_0;
	}
}
