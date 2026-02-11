using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200034C RID: 844
	public static class BinaryConverter : Object
	{
		// Token: 0x060032A1 RID: 12961 RVA: 0x000FFA8C File Offset: 0x000FDC8C
		// Note: this type is marked as 'beforefieldinit'.
		static BinaryConverter()
		{
			Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "BinaryConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr);
			BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671218);
			BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671219);
			BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671220);
			BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671221);
			BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BinaryConverter>.NativeClassPtr, 100671222);
		}

		// Token: 0x060032A2 RID: 12962 RVA: 0x000FFB20 File Offset: 0x000FDD20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387113, RefRangeEnd = 1387116, XrefRangeStart = 1387082, XrefRangeEnd = 1387113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetBinaryTypeInfo(Type type, WriteObjectInfo objectInfo, string typeName, ObjectWriter objectWriter, out Object typeInformation, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectWriter);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060032A3 RID: 12963 RVA: 0x000FFBCC File Offset: 0x000FDDCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387136, RefRangeEnd = 1387137, XrefRangeStart = 1387116, XrefRangeEnd = 1387136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BinaryTypeEnum GetParserBinaryTypeInfo(Type type, out Object typeInformation)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060032A4 RID: 12964 RVA: 0x000FFC30 File Offset: 0x000FDE30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387138, RefRangeEnd = 1387140, XrefRangeStart = 1387137, XrefRangeEnd = 1387138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteTypeInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, int assemId, __BinaryWriter sout)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref assemId;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sout);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032A5 RID: 12965 RVA: 0x000FFC94 File Offset: 0x000FDE94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387142, RefRangeEnd = 1387144, XrefRangeStart = 1387140, XrefRangeEnd = 1387142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ReadTypeInfo(BinaryTypeEnum binaryTypeEnum, __BinaryParser input, out int assemId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &assemId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000FFCF4 File Offset: 0x000FDEF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387178, RefRangeEnd = 1387180, XrefRangeStart = 1387144, XrefRangeEnd = 1387178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TypeFromInfo(BinaryTypeEnum binaryTypeEnum, Object typeInformation, ObjectReader objectReader, BinaryAssemblyInfo assemblyInfo, out InternalPrimitiveTypeE primitiveTypeEnum, out string typeString, out Type type, out bool isVariant)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref binaryTypeEnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeInformation);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectReader);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyInfo);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &primitiveTypeEnum;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isVariant;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BinaryConverter.NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			typeString = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			type = ((intPtr5 == 0) ? null : new Type(intPtr5));
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x00011906 File Offset: 0x0000FB06
		public BinaryConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_GetBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_WriteObjectInfo_String_ObjectWriter_byref_Object_byref_Int32_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr_GetParserBinaryTypeInfo_Internal_Static_BinaryTypeEnum_Type_byref_Object_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr_WriteTypeInfo_Internal_Static_Void_BinaryTypeEnum_Object_Int32___BinaryWriter_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_ReadTypeInfo_Internal_Static_Object_BinaryTypeEnum___BinaryParser_byref_Int32_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_TypeFromInfo_Internal_Static_Void_BinaryTypeEnum_Object_ObjectReader_BinaryAssemblyInfo_byref_InternalPrimitiveTypeE_byref_String_byref_Type_byref_Boolean_0;
	}
}
