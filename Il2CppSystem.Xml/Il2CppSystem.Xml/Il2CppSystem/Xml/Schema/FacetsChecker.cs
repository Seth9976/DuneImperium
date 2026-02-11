using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Text;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x0200016D RID: 365
	public class FacetsChecker : Object
	{
		// Token: 0x06001D2D RID: 7469 RVA: 0x00090A30 File Offset: 0x0008EC30
		// Note: this type is marked as 'beforefieldinit'.
		static FacetsChecker()
		{
			Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "FacetsChecker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr);
			FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667675);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667676);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667677);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667678);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667679);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667680);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667681);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667682);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667683);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667684);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667685);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667686);
			FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667687);
			FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667688);
			FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667689);
			FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667690);
			FacetsChecker.NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667691);
			FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667692);
			FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, 100667693);
		}

		// Token: 0x06001D2E RID: 7470 RVA: 0x00090BDC File Offset: 0x0008EDDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395859, XrefRangeEnd = 395872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckLexicalFacets(ref string parseString, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(parseString);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			parseString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr4) : null;
		}

		// Token: 0x06001D2F RID: 7471 RVA: 0x00090C58 File Offset: 0x0008EE58
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Object value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D30 RID: 7472 RVA: 0x00090CC8 File Offset: 0x0008EEC8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Decimal value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D31 RID: 7473 RVA: 0x00090D34 File Offset: 0x0008EF34
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(long value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00090DA0 File Offset: 0x0008EFA0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(int value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00090E0C File Offset: 0x0008F00C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(short value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00090E78 File Offset: 0x0008F078
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(DateTime value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D35 RID: 7477 RVA: 0x00090EE4 File Offset: 0x0008F0E4
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(double value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D36 RID: 7478 RVA: 0x00090F50 File Offset: 0x0008F150
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(float value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D37 RID: 7479 RVA: 0x00090FBC File Offset: 0x0008F1BC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(string value, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D38 RID: 7480 RVA: 0x0009102C File Offset: 0x0008F22C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(Il2CppStructArray<byte> value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D39 RID: 7481 RVA: 0x0009109C File Offset: 0x0008F29C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(TimeSpan value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D3A RID: 7482 RVA: 0x00091108 File Offset: 0x0008F308
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Exception CheckValueFacets(XmlQualifiedName value, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D3B RID: 7483 RVA: 0x00091178 File Offset: 0x0008F378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 395874, RefRangeEnd = 395875, XrefRangeStart = 395872, XrefRangeEnd = 395874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWhitespaceFacets(ref string s, XmlSchemaDatatype datatype)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(s);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			s = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001D3C RID: 7484 RVA: 0x000911DC File Offset: 0x0008F3DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395875, XrefRangeEnd = 395888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception CheckPatternFacets(RestrictionFacets restriction, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(restriction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001D3D RID: 7485 RVA: 0x00091240 File Offset: 0x0008F440
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool MatchEnumeration(Object value, ArrayList enumeration, XmlSchemaDatatype datatype)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D3E RID: 7486 RVA: 0x000912BC File Offset: 0x0008F4BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395888, XrefRangeEnd = 395958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual RestrictionFacets ConstructRestriction(DatatypeImplementation datatype, XmlSchemaObjectCollection facets, XmlNameTable nameTable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facets);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FacetsChecker.NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr3) : null;
		}

		// Token: 0x06001D3F RID: 7487 RVA: 0x0009133C File Offset: 0x0008F53C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395958, XrefRangeEnd = 395968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Decimal Power(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001D40 RID: 7488 RVA: 0x00091388 File Offset: 0x0008F588
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FacetsChecker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D41 RID: 7489 RVA: 0x0000C10B File Offset: 0x0000A30B
		public FacetsChecker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001649 RID: 5705
		private static readonly IntPtr NativeMethodInfoPtr_CheckLexicalFacets_Internal_Virtual_New_Exception_byref_String_XmlSchemaDatatype_0;

		// Token: 0x0400164A RID: 5706
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Object_XmlSchemaDatatype_0;

		// Token: 0x0400164B RID: 5707
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Decimal_XmlSchemaDatatype_0;

		// Token: 0x0400164C RID: 5708
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int64_XmlSchemaDatatype_0;

		// Token: 0x0400164D RID: 5709
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int32_XmlSchemaDatatype_0;

		// Token: 0x0400164E RID: 5710
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Int16_XmlSchemaDatatype_0;

		// Token: 0x0400164F RID: 5711
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_DateTime_XmlSchemaDatatype_0;

		// Token: 0x04001650 RID: 5712
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Double_XmlSchemaDatatype_0;

		// Token: 0x04001651 RID: 5713
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Single_XmlSchemaDatatype_0;

		// Token: 0x04001652 RID: 5714
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_String_XmlSchemaDatatype_0;

		// Token: 0x04001653 RID: 5715
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_Il2CppStructArray_1_Byte_XmlSchemaDatatype_0;

		// Token: 0x04001654 RID: 5716
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_TimeSpan_XmlSchemaDatatype_0;

		// Token: 0x04001655 RID: 5717
		private static readonly IntPtr NativeMethodInfoPtr_CheckValueFacets_Internal_Virtual_New_Exception_XmlQualifiedName_XmlSchemaDatatype_0;

		// Token: 0x04001656 RID: 5718
		private static readonly IntPtr NativeMethodInfoPtr_CheckWhitespaceFacets_Internal_Void_byref_String_XmlSchemaDatatype_0;

		// Token: 0x04001657 RID: 5719
		private static readonly IntPtr NativeMethodInfoPtr_CheckPatternFacets_Internal_Exception_RestrictionFacets_String_0;

		// Token: 0x04001658 RID: 5720
		private static readonly IntPtr NativeMethodInfoPtr_MatchEnumeration_Internal_Virtual_New_Boolean_Object_ArrayList_XmlSchemaDatatype_0;

		// Token: 0x04001659 RID: 5721
		private static readonly IntPtr NativeMethodInfoPtr_ConstructRestriction_Internal_Virtual_New_RestrictionFacets_DatatypeImplementation_XmlSchemaObjectCollection_XmlNameTable_0;

		// Token: 0x0400165A RID: 5722
		private static readonly IntPtr NativeMethodInfoPtr_Power_Internal_Static_Decimal_Int32_Int32_0;

		// Token: 0x0400165B RID: 5723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000259 RID: 601
		public sealed class FacetsCompiler : ValueType
		{
			// Token: 0x06003170 RID: 12656 RVA: 0x000DD0F4 File Offset: 0x000DB2F4
			// Note: this type is marked as 'beforefieldinit'.
			static FacetsCompiler()
			{
				Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsChecker>.NativeClassPtr, "FacetsCompiler");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr);
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "datatype");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "derivedRestriction");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "baseFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "baseFixedFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "validRestrictionFlags");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "nonNegativeInt");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "builtInType");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "builtInEnum");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "firstPattern");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "regStr");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "pattern_facet");
				FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "c_map");
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667694);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667695);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667696);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667697);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667698);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667699);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667700);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667701);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667702);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667703);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667704);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667705);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667706);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667707);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667708);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667709);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667710);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667711);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667712);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667713);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667714);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667715);
				FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, 100667716);
			}

			// Token: 0x06003171 RID: 12657 RVA: 0x000DD3DC File Offset: 0x000DB5DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395473, RefRangeEnd = 395474, XrefRangeStart = 395448, XrefRangeEnd = 395473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FacetsCompiler(DatatypeImplementation baseDatatype, RestrictionFacets restriction)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseDatatype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(restriction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003172 RID: 12658 RVA: 0x000DD440 File Offset: 0x000DB640
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395499, RefRangeEnd = 395500, XrefRangeStart = 395474, XrefRangeEnd = 395499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003173 RID: 12659 RVA: 0x000DD488 File Offset: 0x000DB688
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395525, RefRangeEnd = 395526, XrefRangeStart = 395500, XrefRangeEnd = 395525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003174 RID: 12660 RVA: 0x000DD4D0 File Offset: 0x000DB6D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395551, RefRangeEnd = 395552, XrefRangeStart = 395526, XrefRangeEnd = 395551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxLengthFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003175 RID: 12661 RVA: 0x000DD518 File Offset: 0x000DB718
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395575, RefRangeEnd = 395576, XrefRangeStart = 395552, XrefRangeEnd = 395575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompilePatternFacet(XmlSchemaPatternFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003176 RID: 12662 RVA: 0x000DD560 File Offset: 0x000DB760
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395592, RefRangeEnd = 395593, XrefRangeStart = 395576, XrefRangeEnd = 395592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileEnumerationFacet(XmlSchemaFacet facet, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003177 RID: 12663 RVA: 0x000DD5CC File Offset: 0x000DB7CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395621, RefRangeEnd = 395622, XrefRangeStart = 395593, XrefRangeEnd = 395621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileWhitespaceFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003178 RID: 12664 RVA: 0x000DD614 File Offset: 0x000DB814
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395637, RefRangeEnd = 395638, XrefRangeStart = 395622, XrefRangeEnd = 395637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxInclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003179 RID: 12665 RVA: 0x000DD65C File Offset: 0x000DB85C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395653, RefRangeEnd = 395654, XrefRangeStart = 395638, XrefRangeEnd = 395653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMaxExclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317A RID: 12666 RVA: 0x000DD6A4 File Offset: 0x000DB8A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395669, RefRangeEnd = 395670, XrefRangeStart = 395654, XrefRangeEnd = 395669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinInclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317B RID: 12667 RVA: 0x000DD6EC File Offset: 0x000DB8EC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395685, RefRangeEnd = 395686, XrefRangeStart = 395670, XrefRangeEnd = 395685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileMinExclusiveFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317C RID: 12668 RVA: 0x000DD734 File Offset: 0x000DB934
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395718, RefRangeEnd = 395719, XrefRangeStart = 395686, XrefRangeEnd = 395718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileTotalDigitsFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317D RID: 12669 RVA: 0x000DD77C File Offset: 0x000DB97C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395739, RefRangeEnd = 395740, XrefRangeStart = 395719, XrefRangeEnd = 395739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileFractionDigitsFacet(XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600317E RID: 12670 RVA: 0x000DD7C4 File Offset: 0x000DB9C4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395762, RefRangeEnd = 395763, XrefRangeStart = 395740, XrefRangeEnd = 395762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void FinishFacetCompile()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600317F RID: 12671 RVA: 0x000DD7FC File Offset: 0x000DB9FC
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 395766, RefRangeEnd = 395770, XrefRangeStart = 395763, XrefRangeEnd = 395766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckValue(Object value, XmlSchemaFacet facet)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003180 RID: 12672 RVA: 0x000DD858 File Offset: 0x000DBA58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395774, RefRangeEnd = 395775, XrefRangeStart = 395770, XrefRangeEnd = 395774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CompileFacetCombinations()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003181 RID: 12673 RVA: 0x000DD890 File Offset: 0x000DBA90
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395807, RefRangeEnd = 395808, XrefRangeStart = 395775, XrefRangeEnd = 395807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CopyFacetsFromBaseType()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003182 RID: 12674 RVA: 0x000DD8C8 File Offset: 0x000DBAC8
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 395808, RefRangeEnd = 395818, XrefRangeStart = 395808, XrefRangeEnd = 395808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object ParseFacetValue(XmlSchemaDatatype datatype, XmlSchemaFacet facet, string code, IXmlNamespaceResolver nsmgr, XmlNameTable nameTable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(datatype);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(facet);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(code);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06003183 RID: 12675 RVA: 0x000DD968 File Offset: 0x000DBB68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 395846, RefRangeEnd = 395847, XrefRangeStart = 395818, XrefRangeEnd = 395846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Preprocess(string pattern)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(pattern);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06003184 RID: 12676 RVA: 0x000DD9A4 File Offset: 0x000DBBA4
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 395847, RefRangeEnd = 395859, XrefRangeStart = 395847, XrefRangeEnd = 395847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void CheckProhibitedFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003185 RID: 12677 RVA: 0x000DDA0C File Offset: 0x000DBC0C
			[CallerCount(0)]
			public unsafe void CheckDupFlag(XmlSchemaFacet facet, RestrictionFlags flag, string errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorCode);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003186 RID: 12678 RVA: 0x000DDA74 File Offset: 0x000DBC74
			[CallerCount(0)]
			public unsafe void SetFlag(XmlSchemaFacet facet, RestrictionFlags flag)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(facet);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003187 RID: 12679 RVA: 0x000DDACC File Offset: 0x000DBCCC
			[CallerCount(0)]
			public unsafe void SetFlag(RestrictionFlags flag)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref flag;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003188 RID: 12680 RVA: 0x00014EE5 File Offset: 0x000130E5
			public FacetsCompiler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06003189 RID: 12681 RVA: 0x00014EEE File Offset: 0x000130EE
			public FacetsCompiler()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr))
			{
			}

			// Token: 0x170010A6 RID: 4262
			// (get) Token: 0x0600318A RID: 12682 RVA: 0x000DDB10 File Offset: 0x000DBD10
			// (set) Token: 0x0600318B RID: 12683 RVA: 0x00014F00 File Offset: 0x00013100
			public unsafe DatatypeImplementation datatype
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DatatypeImplementation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_datatype), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A7 RID: 4263
			// (get) Token: 0x0600318C RID: 12684 RVA: 0x000DDB40 File Offset: 0x000DBD40
			// (set) Token: 0x0600318D RID: 12685 RVA: 0x00014F1F File Offset: 0x0001311F
			public unsafe RestrictionFacets derivedRestriction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RestrictionFacets>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_derivedRestriction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010A8 RID: 4264
			// (get) Token: 0x0600318E RID: 12686 RVA: 0x000DDB70 File Offset: 0x000DBD70
			// (set) Token: 0x0600318F RID: 12687 RVA: 0x00014F3E File Offset: 0x0001313E
			public unsafe RestrictionFlags baseFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFlags)) = value;
				}
			}

			// Token: 0x170010A9 RID: 4265
			// (get) Token: 0x06003190 RID: 12688 RVA: 0x000DDB98 File Offset: 0x000DBD98
			// (set) Token: 0x06003191 RID: 12689 RVA: 0x00014F59 File Offset: 0x00013159
			public unsafe RestrictionFlags baseFixedFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_baseFixedFlags)) = value;
				}
			}

			// Token: 0x170010AA RID: 4266
			// (get) Token: 0x06003192 RID: 12690 RVA: 0x000DDBC0 File Offset: 0x000DBDC0
			// (set) Token: 0x06003193 RID: 12691 RVA: 0x00014F74 File Offset: 0x00013174
			public unsafe RestrictionFlags validRestrictionFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_validRestrictionFlags)) = value;
				}
			}

			// Token: 0x170010AB RID: 4267
			// (get) Token: 0x06003194 RID: 12692 RVA: 0x000DDBE8 File Offset: 0x000DBDE8
			// (set) Token: 0x06003195 RID: 12693 RVA: 0x00014F8F File Offset: 0x0001318F
			public unsafe XmlSchemaDatatype nonNegativeInt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_nonNegativeInt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AC RID: 4268
			// (get) Token: 0x06003196 RID: 12694 RVA: 0x000DDC18 File Offset: 0x000DBE18
			// (set) Token: 0x06003197 RID: 12695 RVA: 0x00014FAE File Offset: 0x000131AE
			public unsafe XmlSchemaDatatype builtInType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaDatatype>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010AD RID: 4269
			// (get) Token: 0x06003198 RID: 12696 RVA: 0x000DDC48 File Offset: 0x000DBE48
			// (set) Token: 0x06003199 RID: 12697 RVA: 0x00014FCD File Offset: 0x000131CD
			public unsafe XmlTypeCode builtInEnum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_builtInEnum)) = value;
				}
			}

			// Token: 0x170010AE RID: 4270
			// (get) Token: 0x0600319A RID: 12698 RVA: 0x000DDC70 File Offset: 0x000DBE70
			// (set) Token: 0x0600319B RID: 12699 RVA: 0x00014FE8 File Offset: 0x000131E8
			public unsafe bool firstPattern
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_firstPattern)) = value;
				}
			}

			// Token: 0x170010AF RID: 4271
			// (get) Token: 0x0600319C RID: 12700 RVA: 0x000DDC98 File Offset: 0x000DBE98
			// (set) Token: 0x0600319D RID: 12701 RVA: 0x00015003 File Offset: 0x00013203
			public unsafe StringBuilder regStr
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_regStr), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B0 RID: 4272
			// (get) Token: 0x0600319E RID: 12702 RVA: 0x000DDCC8 File Offset: 0x000DBEC8
			// (set) Token: 0x0600319F RID: 12703 RVA: 0x00015022 File Offset: 0x00013222
			public unsafe XmlSchemaPatternFacet pattern_facet
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaPatternFacet>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_pattern_facet), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170010B1 RID: 4273
			// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000DDCF8 File Offset: 0x000DBEF8
			// (set) Token: 0x060031A1 RID: 12705 RVA: 0x00015041 File Offset: 0x00013241
			public unsafe static Il2CppReferenceArray<FacetsChecker.FacetsCompiler.Map> c_map
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FacetsChecker.FacetsCompiler.Map>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FacetsChecker.FacetsCompiler.NativeFieldInfoPtr_c_map, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400263C RID: 9788
			private static readonly IntPtr NativeFieldInfoPtr_datatype;

			// Token: 0x0400263D RID: 9789
			private static readonly IntPtr NativeFieldInfoPtr_derivedRestriction;

			// Token: 0x0400263E RID: 9790
			private static readonly IntPtr NativeFieldInfoPtr_baseFlags;

			// Token: 0x0400263F RID: 9791
			private static readonly IntPtr NativeFieldInfoPtr_baseFixedFlags;

			// Token: 0x04002640 RID: 9792
			private static readonly IntPtr NativeFieldInfoPtr_validRestrictionFlags;

			// Token: 0x04002641 RID: 9793
			private static readonly IntPtr NativeFieldInfoPtr_nonNegativeInt;

			// Token: 0x04002642 RID: 9794
			private static readonly IntPtr NativeFieldInfoPtr_builtInType;

			// Token: 0x04002643 RID: 9795
			private static readonly IntPtr NativeFieldInfoPtr_builtInEnum;

			// Token: 0x04002644 RID: 9796
			private static readonly IntPtr NativeFieldInfoPtr_firstPattern;

			// Token: 0x04002645 RID: 9797
			private static readonly IntPtr NativeFieldInfoPtr_regStr;

			// Token: 0x04002646 RID: 9798
			private static readonly IntPtr NativeFieldInfoPtr_pattern_facet;

			// Token: 0x04002647 RID: 9799
			private static readonly IntPtr NativeFieldInfoPtr_c_map;

			// Token: 0x04002648 RID: 9800
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DatatypeImplementation_RestrictionFacets_0;

			// Token: 0x04002649 RID: 9801
			private static readonly IntPtr NativeMethodInfoPtr_CompileLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x0400264A RID: 9802
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x0400264B RID: 9803
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxLengthFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x0400264C RID: 9804
			private static readonly IntPtr NativeMethodInfoPtr_CompilePatternFacet_Internal_Void_XmlSchemaPatternFacet_0;

			// Token: 0x0400264D RID: 9805
			private static readonly IntPtr NativeMethodInfoPtr_CompileEnumerationFacet_Internal_Void_XmlSchemaFacet_IXmlNamespaceResolver_XmlNameTable_0;

			// Token: 0x0400264E RID: 9806
			private static readonly IntPtr NativeMethodInfoPtr_CompileWhitespaceFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x0400264F RID: 9807
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002650 RID: 9808
			private static readonly IntPtr NativeMethodInfoPtr_CompileMaxExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002651 RID: 9809
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinInclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002652 RID: 9810
			private static readonly IntPtr NativeMethodInfoPtr_CompileMinExclusiveFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002653 RID: 9811
			private static readonly IntPtr NativeMethodInfoPtr_CompileTotalDigitsFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002654 RID: 9812
			private static readonly IntPtr NativeMethodInfoPtr_CompileFractionDigitsFacet_Internal_Void_XmlSchemaFacet_0;

			// Token: 0x04002655 RID: 9813
			private static readonly IntPtr NativeMethodInfoPtr_FinishFacetCompile_Internal_Void_0;

			// Token: 0x04002656 RID: 9814
			private static readonly IntPtr NativeMethodInfoPtr_CheckValue_Private_Void_Object_XmlSchemaFacet_0;

			// Token: 0x04002657 RID: 9815
			private static readonly IntPtr NativeMethodInfoPtr_CompileFacetCombinations_Internal_Void_0;

			// Token: 0x04002658 RID: 9816
			private static readonly IntPtr NativeMethodInfoPtr_CopyFacetsFromBaseType_Private_Void_0;

			// Token: 0x04002659 RID: 9817
			private static readonly IntPtr NativeMethodInfoPtr_ParseFacetValue_Private_Object_XmlSchemaDatatype_XmlSchemaFacet_String_IXmlNamespaceResolver_XmlNameTable_0;

			// Token: 0x0400265A RID: 9818
			private static readonly IntPtr NativeMethodInfoPtr_Preprocess_Private_Static_String_String_0;

			// Token: 0x0400265B RID: 9819
			private static readonly IntPtr NativeMethodInfoPtr_CheckProhibitedFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

			// Token: 0x0400265C RID: 9820
			private static readonly IntPtr NativeMethodInfoPtr_CheckDupFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_String_0;

			// Token: 0x0400265D RID: 9821
			private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_XmlSchemaFacet_RestrictionFlags_0;

			// Token: 0x0400265E RID: 9822
			private static readonly IntPtr NativeMethodInfoPtr_SetFlag_Private_Void_RestrictionFlags_0;

			// Token: 0x0200029E RID: 670
			public sealed class Map : ValueType
			{
				// Token: 0x0600332D RID: 13101 RVA: 0x000E1554 File Offset: 0x000DF754
				// Note: this type is marked as 'beforefieldinit'.
				static Map()
				{
					Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler>.NativeClassPtr, "Map");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr);
					FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, "match");
					FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, "replacement");
					FacetsChecker.FacetsCompiler.Map.NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr, 100667718);
				}

				// Token: 0x0600332E RID: 13102 RVA: 0x000E15BC File Offset: 0x000DF7BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 395447, XrefRangeEnd = 395448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Map(char m, string r)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref m;
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FacetsChecker.FacetsCompiler.Map.NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600332F RID: 13103 RVA: 0x000162C0 File Offset: 0x000144C0
				public Map(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06003330 RID: 13104 RVA: 0x000162C9 File Offset: 0x000144C9
				public Map()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FacetsChecker.FacetsCompiler.Map>.NativeClassPtr))
				{
				}

				// Token: 0x17001125 RID: 4389
				// (get) Token: 0x06003331 RID: 13105 RVA: 0x000E161C File Offset: 0x000DF81C
				// (set) Token: 0x06003332 RID: 13106 RVA: 0x000162DB File Offset: 0x000144DB
				public unsafe char match
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_match)) = value;
					}
				}

				// Token: 0x17001126 RID: 4390
				// (get) Token: 0x06003333 RID: 13107 RVA: 0x000E1644 File Offset: 0x000DF844
				// (set) Token: 0x06003334 RID: 13108 RVA: 0x000162F6 File Offset: 0x000144F6
				public unsafe string replacement
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FacetsChecker.FacetsCompiler.Map.NativeFieldInfoPtr_replacement), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400286C RID: 10348
				private static readonly IntPtr NativeFieldInfoPtr_match;

				// Token: 0x0400286D RID: 10349
				private static readonly IntPtr NativeFieldInfoPtr_replacement;

				// Token: 0x0400286E RID: 10350
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Char_String_0;
			}
		}
	}
}
