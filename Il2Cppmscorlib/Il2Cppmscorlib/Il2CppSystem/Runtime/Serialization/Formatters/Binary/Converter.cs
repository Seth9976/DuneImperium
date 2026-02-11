using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000362 RID: 866
	public sealed class Converter : Object
	{
		// Token: 0x060033EF RID: 13295 RVA: 0x00103BD8 File Offset: 0x00101DD8
		// Note: this type is marked as 'beforefieldinit'.
		static Converter()
		{
			Il2CppClassPointerStore<Converter>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "Converter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Converter>.NativeClassPtr);
			Converter.NativeFieldInfoPtr_primitiveTypeEnumLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "primitiveTypeEnumLength");
			Converter.NativeFieldInfoPtr_typeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeA");
			Converter.NativeFieldInfoPtr_arrayTypeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "arrayTypeA");
			Converter.NativeFieldInfoPtr_valueA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "valueA");
			Converter.NativeFieldInfoPtr_typeCodeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeCodeA");
			Converter.NativeFieldInfoPtr_codeA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "codeA");
			Converter.NativeFieldInfoPtr_typeofISerializable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofISerializable");
			Converter.NativeFieldInfoPtr_typeofString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofString");
			Converter.NativeFieldInfoPtr_typeofConverter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofConverter");
			Converter.NativeFieldInfoPtr_typeofBoolean = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBoolean");
			Converter.NativeFieldInfoPtr_typeofByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByte");
			Converter.NativeFieldInfoPtr_typeofChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofChar");
			Converter.NativeFieldInfoPtr_typeofDecimal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimal");
			Converter.NativeFieldInfoPtr_typeofDouble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDouble");
			Converter.NativeFieldInfoPtr_typeofInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16");
			Converter.NativeFieldInfoPtr_typeofInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32");
			Converter.NativeFieldInfoPtr_typeofInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64");
			Converter.NativeFieldInfoPtr_typeofSByte = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByte");
			Converter.NativeFieldInfoPtr_typeofSingle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingle");
			Converter.NativeFieldInfoPtr_typeofTimeSpan = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpan");
			Converter.NativeFieldInfoPtr_typeofDateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTime");
			Converter.NativeFieldInfoPtr_typeofUInt16 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16");
			Converter.NativeFieldInfoPtr_typeofUInt32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32");
			Converter.NativeFieldInfoPtr_typeofUInt64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64");
			Converter.NativeFieldInfoPtr_typeofObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObject");
			Converter.NativeFieldInfoPtr_typeofSystemVoid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSystemVoid");
			Converter.NativeFieldInfoPtr_urtAssembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssembly");
			Converter.NativeFieldInfoPtr_urtAssemblyString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "urtAssemblyString");
			Converter.NativeFieldInfoPtr_typeofTypeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTypeArray");
			Converter.NativeFieldInfoPtr_typeofObjectArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofObjectArray");
			Converter.NativeFieldInfoPtr_typeofStringArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofStringArray");
			Converter.NativeFieldInfoPtr_typeofBooleanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofBooleanArray");
			Converter.NativeFieldInfoPtr_typeofByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofByteArray");
			Converter.NativeFieldInfoPtr_typeofCharArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofCharArray");
			Converter.NativeFieldInfoPtr_typeofDecimalArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDecimalArray");
			Converter.NativeFieldInfoPtr_typeofDoubleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDoubleArray");
			Converter.NativeFieldInfoPtr_typeofInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt16Array");
			Converter.NativeFieldInfoPtr_typeofInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt32Array");
			Converter.NativeFieldInfoPtr_typeofInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofInt64Array");
			Converter.NativeFieldInfoPtr_typeofSByteArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSByteArray");
			Converter.NativeFieldInfoPtr_typeofSingleArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofSingleArray");
			Converter.NativeFieldInfoPtr_typeofTimeSpanArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofTimeSpanArray");
			Converter.NativeFieldInfoPtr_typeofDateTimeArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofDateTimeArray");
			Converter.NativeFieldInfoPtr_typeofUInt16Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt16Array");
			Converter.NativeFieldInfoPtr_typeofUInt32Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt32Array");
			Converter.NativeFieldInfoPtr_typeofUInt64Array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofUInt64Array");
			Converter.NativeFieldInfoPtr_typeofMarshalByRefObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Converter>.NativeClassPtr, "typeofMarshalByRefObject");
			Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671318);
			Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671319);
			Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671320);
			Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671321);
			Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671322);
			Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671323);
			Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671324);
			Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671325);
			Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671326);
			Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671327);
			Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671328);
			Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671329);
			Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671330);
			Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671331);
			Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671332);
			Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Converter>.NativeClassPtr, 100671333);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x001040F4 File Offset: 0x001022F4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1387508, RefRangeEnd = 1387515, XrefRangeStart = 1387498, XrefRangeEnd = 1387508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToCode(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033F1 RID: 13297 RVA: 0x00104138 File Offset: 0x00102338
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387515, RefRangeEnd = 1387518, XrefRangeStart = 1387515, XrefRangeEnd = 1387515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWriteAsByteArray(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033F2 RID: 13298 RVA: 0x00104178 File Offset: 0x00102378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387518, RefRangeEnd = 1387519, XrefRangeStart = 1387518, XrefRangeEnd = 1387518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int TypeLength(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033F3 RID: 13299 RVA: 0x001041B8 File Offset: 0x001023B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387519, XrefRangeEnd = 1387531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToArrayType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x001041F8 File Offset: 0x001023F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387620, RefRangeEnd = 1387622, XrefRangeStart = 1387531, XrefRangeEnd = 1387620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F5 RID: 13301 RVA: 0x00104220 File Offset: 0x00102420
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387711, RefRangeEnd = 1387712, XrefRangeStart = 1387622, XrefRangeEnd = 1387711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitArrayTypeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00104248 File Offset: 0x00102448
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387724, RefRangeEnd = 1387726, XrefRangeStart = 1387712, XrefRangeEnd = 1387724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type ToType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00104288 File Offset: 0x00102488
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387771, RefRangeEnd = 1387772, XrefRangeStart = 1387726, XrefRangeEnd = 1387771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Array>(intPtr3) : null;
		}

		// Token: 0x060033F8 RID: 13304 RVA: 0x001042D8 File Offset: 0x001024D8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387815, RefRangeEnd = 1387817, XrefRangeStart = 1387772, XrefRangeEnd = 1387815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitiveArray(Type type, out Object typeInformation)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			typeInformation = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x0010433C File Offset: 0x0010253C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1387876, RefRangeEnd = 1387878, XrefRangeStart = 1387817, XrefRangeEnd = 1387876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitValueA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitValueA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x00104364 File Offset: 0x00102564
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1387890, RefRangeEnd = 1387891, XrefRangeStart = 1387878, XrefRangeEnd = 1387890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToComType(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060033FB RID: 13307 RVA: 0x0010439C File Offset: 0x0010259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387891, XrefRangeEnd = 1387904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitTypeCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FC RID: 13308 RVA: 0x001043C4 File Offset: 0x001025C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387904, XrefRangeEnd = 1387926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TypeCode ToTypeCode(InternalPrimitiveTypeE code)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref code;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033FD RID: 13309 RVA: 0x00104404 File Offset: 0x00102604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387926, XrefRangeEnd = 1387938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitCodeA()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060033FE RID: 13310 RVA: 0x0010442C File Offset: 0x0010262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1387938, XrefRangeEnd = 1387959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060033FF RID: 13311 RVA: 0x0010446C File Offset: 0x0010266C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1387962, RefRangeEnd = 1387965, XrefRangeStart = 1387959, XrefRangeEnd = 1387962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromString(string value, InternalPrimitiveTypeE code)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref code;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Converter.NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003400 RID: 13312 RVA: 0x00012486 File Offset: 0x00010686
		public Converter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x06003401 RID: 13313 RVA: 0x001044C0 File Offset: 0x001026C0
		// (set) Token: 0x06003402 RID: 13314 RVA: 0x0001248F File Offset: 0x0001068F
		public unsafe static int primitiveTypeEnumLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_primitiveTypeEnumLength, (void*)(&value));
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x06003403 RID: 13315 RVA: 0x001044DC File Offset: 0x001026DC
		// (set) Token: 0x06003404 RID: 13316 RVA: 0x0001249D File Offset: 0x0001069D
		public unsafe static Il2CppReferenceArray<Type> typeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x06003405 RID: 13317 RVA: 0x00104504 File Offset: 0x00102704
		// (set) Token: 0x06003406 RID: 13318 RVA: 0x000124AF File Offset: 0x000106AF
		public unsafe static Il2CppReferenceArray<Type> arrayTypeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_arrayTypeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_arrayTypeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06003407 RID: 13319 RVA: 0x0010452C File Offset: 0x0010272C
		// (set) Token: 0x06003408 RID: 13320 RVA: 0x000124C1 File Offset: 0x000106C1
		public unsafe static Il2CppStringArray valueA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_valueA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_valueA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06003409 RID: 13321 RVA: 0x00104554 File Offset: 0x00102754
		// (set) Token: 0x0600340A RID: 13322 RVA: 0x000124D3 File Offset: 0x000106D3
		public unsafe static Il2CppStructArray<TypeCode> typeCodeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeCodeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<TypeCode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeCodeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x0600340B RID: 13323 RVA: 0x0010457C File Offset: 0x0010277C
		// (set) Token: 0x0600340C RID: 13324 RVA: 0x000124E5 File Offset: 0x000106E5
		public unsafe static Il2CppStructArray<InternalPrimitiveTypeE> codeA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_codeA, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<InternalPrimitiveTypeE>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_codeA, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x0600340D RID: 13325 RVA: 0x001045A4 File Offset: 0x001027A4
		// (set) Token: 0x0600340E RID: 13326 RVA: 0x000124F7 File Offset: 0x000106F7
		public unsafe static Type typeofISerializable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofISerializable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofISerializable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x0600340F RID: 13327 RVA: 0x001045CC File Offset: 0x001027CC
		// (set) Token: 0x06003410 RID: 13328 RVA: 0x00012509 File Offset: 0x00010709
		public unsafe static Type typeofString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofString, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofString, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06003411 RID: 13329 RVA: 0x001045F4 File Offset: 0x001027F4
		// (set) Token: 0x06003412 RID: 13330 RVA: 0x0001251B File Offset: 0x0001071B
		public unsafe static Type typeofConverter
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofConverter, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofConverter, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x0010461C File Offset: 0x0010281C
		// (set) Token: 0x06003414 RID: 13332 RVA: 0x0001252D File Offset: 0x0001072D
		public unsafe static Type typeofBoolean
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBoolean, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBoolean, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06003415 RID: 13333 RVA: 0x00104644 File Offset: 0x00102844
		// (set) Token: 0x06003416 RID: 13334 RVA: 0x0001253F File Offset: 0x0001073F
		public unsafe static Type typeofByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06003417 RID: 13335 RVA: 0x0010466C File Offset: 0x0010286C
		// (set) Token: 0x06003418 RID: 13336 RVA: 0x00012551 File Offset: 0x00010751
		public unsafe static Type typeofChar
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofChar, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofChar, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06003419 RID: 13337 RVA: 0x00104694 File Offset: 0x00102894
		// (set) Token: 0x0600341A RID: 13338 RVA: 0x00012563 File Offset: 0x00010763
		public unsafe static Type typeofDecimal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x0600341B RID: 13339 RVA: 0x001046BC File Offset: 0x001028BC
		// (set) Token: 0x0600341C RID: 13340 RVA: 0x00012575 File Offset: 0x00010775
		public unsafe static Type typeofDouble
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDouble, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDouble, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x0600341D RID: 13341 RVA: 0x001046E4 File Offset: 0x001028E4
		// (set) Token: 0x0600341E RID: 13342 RVA: 0x00012587 File Offset: 0x00010787
		public unsafe static Type typeofInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600341F RID: 13343 RVA: 0x0010470C File Offset: 0x0010290C
		// (set) Token: 0x06003420 RID: 13344 RVA: 0x00012599 File Offset: 0x00010799
		public unsafe static Type typeofInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06003421 RID: 13345 RVA: 0x00104734 File Offset: 0x00102934
		// (set) Token: 0x06003422 RID: 13346 RVA: 0x000125AB File Offset: 0x000107AB
		public unsafe static Type typeofInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06003423 RID: 13347 RVA: 0x0010475C File Offset: 0x0010295C
		// (set) Token: 0x06003424 RID: 13348 RVA: 0x000125BD File Offset: 0x000107BD
		public unsafe static Type typeofSByte
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByte, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByte, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003425 RID: 13349 RVA: 0x00104784 File Offset: 0x00102984
		// (set) Token: 0x06003426 RID: 13350 RVA: 0x000125CF File Offset: 0x000107CF
		public unsafe static Type typeofSingle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingle, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingle, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003427 RID: 13351 RVA: 0x001047AC File Offset: 0x001029AC
		// (set) Token: 0x06003428 RID: 13352 RVA: 0x000125E1 File Offset: 0x000107E1
		public unsafe static Type typeofTimeSpan
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpan, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003429 RID: 13353 RVA: 0x001047D4 File Offset: 0x001029D4
		// (set) Token: 0x0600342A RID: 13354 RVA: 0x000125F3 File Offset: 0x000107F3
		public unsafe static Type typeofDateTime
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTime, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTime, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600342B RID: 13355 RVA: 0x001047FC File Offset: 0x001029FC
		// (set) Token: 0x0600342C RID: 13356 RVA: 0x00012605 File Offset: 0x00010805
		public unsafe static Type typeofUInt16
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600342D RID: 13357 RVA: 0x00104824 File Offset: 0x00102A24
		// (set) Token: 0x0600342E RID: 13358 RVA: 0x00012617 File Offset: 0x00010817
		public unsafe static Type typeofUInt32
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600342F RID: 13359 RVA: 0x0010484C File Offset: 0x00102A4C
		// (set) Token: 0x06003430 RID: 13360 RVA: 0x00012629 File Offset: 0x00010829
		public unsafe static Type typeofUInt64
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003431 RID: 13361 RVA: 0x00104874 File Offset: 0x00102A74
		// (set) Token: 0x06003432 RID: 13362 RVA: 0x0001263B File Offset: 0x0001083B
		public unsafe static Type typeofObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003433 RID: 13363 RVA: 0x0010489C File Offset: 0x00102A9C
		// (set) Token: 0x06003434 RID: 13364 RVA: 0x0001264D File Offset: 0x0001084D
		public unsafe static Type typeofSystemVoid
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSystemVoid, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003435 RID: 13365 RVA: 0x001048C4 File Offset: 0x00102AC4
		// (set) Token: 0x06003436 RID: 13366 RVA: 0x0001265F File Offset: 0x0001085F
		public unsafe static Assembly urtAssembly
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssembly, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssembly, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003437 RID: 13367 RVA: 0x001048EC File Offset: 0x00102AEC
		// (set) Token: 0x06003438 RID: 13368 RVA: 0x00012671 File Offset: 0x00010871
		public unsafe static string urtAssemblyString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_urtAssemblyString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_urtAssemblyString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x0010490C File Offset: 0x00102B0C
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00012683 File Offset: 0x00010883
		public unsafe static Type typeofTypeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTypeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTypeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600343B RID: 13371 RVA: 0x00104934 File Offset: 0x00102B34
		// (set) Token: 0x0600343C RID: 13372 RVA: 0x00012695 File Offset: 0x00010895
		public unsafe static Type typeofObjectArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofObjectArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofObjectArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600343D RID: 13373 RVA: 0x0010495C File Offset: 0x00102B5C
		// (set) Token: 0x0600343E RID: 13374 RVA: 0x000126A7 File Offset: 0x000108A7
		public unsafe static Type typeofStringArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofStringArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofStringArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600343F RID: 13375 RVA: 0x00104984 File Offset: 0x00102B84
		// (set) Token: 0x06003440 RID: 13376 RVA: 0x000126B9 File Offset: 0x000108B9
		public unsafe static Type typeofBooleanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofBooleanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003441 RID: 13377 RVA: 0x001049AC File Offset: 0x00102BAC
		// (set) Token: 0x06003442 RID: 13378 RVA: 0x000126CB File Offset: 0x000108CB
		public unsafe static Type typeofByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06003443 RID: 13379 RVA: 0x001049D4 File Offset: 0x00102BD4
		// (set) Token: 0x06003444 RID: 13380 RVA: 0x000126DD File Offset: 0x000108DD
		public unsafe static Type typeofCharArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofCharArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofCharArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06003445 RID: 13381 RVA: 0x001049FC File Offset: 0x00102BFC
		// (set) Token: 0x06003446 RID: 13382 RVA: 0x000126EF File Offset: 0x000108EF
		public unsafe static Type typeofDecimalArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDecimalArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06003447 RID: 13383 RVA: 0x00104A24 File Offset: 0x00102C24
		// (set) Token: 0x06003448 RID: 13384 RVA: 0x00012701 File Offset: 0x00010901
		public unsafe static Type typeofDoubleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDoubleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06003449 RID: 13385 RVA: 0x00104A4C File Offset: 0x00102C4C
		// (set) Token: 0x0600344A RID: 13386 RVA: 0x00012713 File Offset: 0x00010913
		public unsafe static Type typeofInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600344B RID: 13387 RVA: 0x00104A74 File Offset: 0x00102C74
		// (set) Token: 0x0600344C RID: 13388 RVA: 0x00012725 File Offset: 0x00010925
		public unsafe static Type typeofInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x0600344D RID: 13389 RVA: 0x00104A9C File Offset: 0x00102C9C
		// (set) Token: 0x0600344E RID: 13390 RVA: 0x00012737 File Offset: 0x00010937
		public unsafe static Type typeofInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x0600344F RID: 13391 RVA: 0x00104AC4 File Offset: 0x00102CC4
		// (set) Token: 0x06003450 RID: 13392 RVA: 0x00012749 File Offset: 0x00010949
		public unsafe static Type typeofSByteArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSByteArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSByteArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x06003451 RID: 13393 RVA: 0x00104AEC File Offset: 0x00102CEC
		// (set) Token: 0x06003452 RID: 13394 RVA: 0x0001275B File Offset: 0x0001095B
		public unsafe static Type typeofSingleArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofSingleArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofSingleArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x06003453 RID: 13395 RVA: 0x00104B14 File Offset: 0x00102D14
		// (set) Token: 0x06003454 RID: 13396 RVA: 0x0001276D File Offset: 0x0001096D
		public unsafe static Type typeofTimeSpanArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofTimeSpanArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x00104B3C File Offset: 0x00102D3C
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x0001277F File Offset: 0x0001097F
		public unsafe static Type typeofDateTimeArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofDateTimeArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x00104B64 File Offset: 0x00102D64
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x00012791 File Offset: 0x00010991
		public unsafe static Type typeofUInt16Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt16Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06003459 RID: 13401 RVA: 0x00104B8C File Offset: 0x00102D8C
		// (set) Token: 0x0600345A RID: 13402 RVA: 0x000127A3 File Offset: 0x000109A3
		public unsafe static Type typeofUInt32Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt32Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600345B RID: 13403 RVA: 0x00104BB4 File Offset: 0x00102DB4
		// (set) Token: 0x0600345C RID: 13404 RVA: 0x000127B5 File Offset: 0x000109B5
		public unsafe static Type typeofUInt64Array
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofUInt64Array, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600345D RID: 13405 RVA: 0x00104BDC File Offset: 0x00102DDC
		// (set) Token: 0x0600345E RID: 13406 RVA: 0x000127C7 File Offset: 0x000109C7
		public unsafe static Type typeofMarshalByRefObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Converter.NativeFieldInfoPtr_typeofMarshalByRefObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002ABE RID: 10942
		private static readonly IntPtr NativeFieldInfoPtr_primitiveTypeEnumLength;

		// Token: 0x04002ABF RID: 10943
		private static readonly IntPtr NativeFieldInfoPtr_typeA;

		// Token: 0x04002AC0 RID: 10944
		private static readonly IntPtr NativeFieldInfoPtr_arrayTypeA;

		// Token: 0x04002AC1 RID: 10945
		private static readonly IntPtr NativeFieldInfoPtr_valueA;

		// Token: 0x04002AC2 RID: 10946
		private static readonly IntPtr NativeFieldInfoPtr_typeCodeA;

		// Token: 0x04002AC3 RID: 10947
		private static readonly IntPtr NativeFieldInfoPtr_codeA;

		// Token: 0x04002AC4 RID: 10948
		private static readonly IntPtr NativeFieldInfoPtr_typeofISerializable;

		// Token: 0x04002AC5 RID: 10949
		private static readonly IntPtr NativeFieldInfoPtr_typeofString;

		// Token: 0x04002AC6 RID: 10950
		private static readonly IntPtr NativeFieldInfoPtr_typeofConverter;

		// Token: 0x04002AC7 RID: 10951
		private static readonly IntPtr NativeFieldInfoPtr_typeofBoolean;

		// Token: 0x04002AC8 RID: 10952
		private static readonly IntPtr NativeFieldInfoPtr_typeofByte;

		// Token: 0x04002AC9 RID: 10953
		private static readonly IntPtr NativeFieldInfoPtr_typeofChar;

		// Token: 0x04002ACA RID: 10954
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimal;

		// Token: 0x04002ACB RID: 10955
		private static readonly IntPtr NativeFieldInfoPtr_typeofDouble;

		// Token: 0x04002ACC RID: 10956
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16;

		// Token: 0x04002ACD RID: 10957
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32;

		// Token: 0x04002ACE RID: 10958
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64;

		// Token: 0x04002ACF RID: 10959
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByte;

		// Token: 0x04002AD0 RID: 10960
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingle;

		// Token: 0x04002AD1 RID: 10961
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpan;

		// Token: 0x04002AD2 RID: 10962
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTime;

		// Token: 0x04002AD3 RID: 10963
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16;

		// Token: 0x04002AD4 RID: 10964
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32;

		// Token: 0x04002AD5 RID: 10965
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64;

		// Token: 0x04002AD6 RID: 10966
		private static readonly IntPtr NativeFieldInfoPtr_typeofObject;

		// Token: 0x04002AD7 RID: 10967
		private static readonly IntPtr NativeFieldInfoPtr_typeofSystemVoid;

		// Token: 0x04002AD8 RID: 10968
		private static readonly IntPtr NativeFieldInfoPtr_urtAssembly;

		// Token: 0x04002AD9 RID: 10969
		private static readonly IntPtr NativeFieldInfoPtr_urtAssemblyString;

		// Token: 0x04002ADA RID: 10970
		private static readonly IntPtr NativeFieldInfoPtr_typeofTypeArray;

		// Token: 0x04002ADB RID: 10971
		private static readonly IntPtr NativeFieldInfoPtr_typeofObjectArray;

		// Token: 0x04002ADC RID: 10972
		private static readonly IntPtr NativeFieldInfoPtr_typeofStringArray;

		// Token: 0x04002ADD RID: 10973
		private static readonly IntPtr NativeFieldInfoPtr_typeofBooleanArray;

		// Token: 0x04002ADE RID: 10974
		private static readonly IntPtr NativeFieldInfoPtr_typeofByteArray;

		// Token: 0x04002ADF RID: 10975
		private static readonly IntPtr NativeFieldInfoPtr_typeofCharArray;

		// Token: 0x04002AE0 RID: 10976
		private static readonly IntPtr NativeFieldInfoPtr_typeofDecimalArray;

		// Token: 0x04002AE1 RID: 10977
		private static readonly IntPtr NativeFieldInfoPtr_typeofDoubleArray;

		// Token: 0x04002AE2 RID: 10978
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt16Array;

		// Token: 0x04002AE3 RID: 10979
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt32Array;

		// Token: 0x04002AE4 RID: 10980
		private static readonly IntPtr NativeFieldInfoPtr_typeofInt64Array;

		// Token: 0x04002AE5 RID: 10981
		private static readonly IntPtr NativeFieldInfoPtr_typeofSByteArray;

		// Token: 0x04002AE6 RID: 10982
		private static readonly IntPtr NativeFieldInfoPtr_typeofSingleArray;

		// Token: 0x04002AE7 RID: 10983
		private static readonly IntPtr NativeFieldInfoPtr_typeofTimeSpanArray;

		// Token: 0x04002AE8 RID: 10984
		private static readonly IntPtr NativeFieldInfoPtr_typeofDateTimeArray;

		// Token: 0x04002AE9 RID: 10985
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt16Array;

		// Token: 0x04002AEA RID: 10986
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt32Array;

		// Token: 0x04002AEB RID: 10987
		private static readonly IntPtr NativeFieldInfoPtr_typeofUInt64Array;

		// Token: 0x04002AEC RID: 10988
		private static readonly IntPtr NativeFieldInfoPtr_typeofMarshalByRefObject;

		// Token: 0x04002AED RID: 10989
		private static readonly IntPtr NativeMethodInfoPtr_ToCode_Internal_Static_InternalPrimitiveTypeE_Type_0;

		// Token: 0x04002AEE RID: 10990
		private static readonly IntPtr NativeMethodInfoPtr_IsWriteAsByteArray_Internal_Static_Boolean_InternalPrimitiveTypeE_0;

		// Token: 0x04002AEF RID: 10991
		private static readonly IntPtr NativeMethodInfoPtr_TypeLength_Internal_Static_Int32_InternalPrimitiveTypeE_0;

		// Token: 0x04002AF0 RID: 10992
		private static readonly IntPtr NativeMethodInfoPtr_ToArrayType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002AF1 RID: 10993
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeA_Private_Static_Void_0;

		// Token: 0x04002AF2 RID: 10994
		private static readonly IntPtr NativeMethodInfoPtr_InitArrayTypeA_Private_Static_Void_0;

		// Token: 0x04002AF3 RID: 10995
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Internal_Static_Type_InternalPrimitiveTypeE_0;

		// Token: 0x04002AF4 RID: 10996
		private static readonly IntPtr NativeMethodInfoPtr_CreatePrimitiveArray_Internal_Static_Array_InternalPrimitiveTypeE_Int32_0;

		// Token: 0x04002AF5 RID: 10997
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitiveArray_Internal_Static_Boolean_Type_byref_Object_0;

		// Token: 0x04002AF6 RID: 10998
		private static readonly IntPtr NativeMethodInfoPtr_InitValueA_Private_Static_Void_0;

		// Token: 0x04002AF7 RID: 10999
		private static readonly IntPtr NativeMethodInfoPtr_ToComType_Internal_Static_String_InternalPrimitiveTypeE_0;

		// Token: 0x04002AF8 RID: 11000
		private static readonly IntPtr NativeMethodInfoPtr_InitTypeCodeA_Private_Static_Void_0;

		// Token: 0x04002AF9 RID: 11001
		private static readonly IntPtr NativeMethodInfoPtr_ToTypeCode_Internal_Static_TypeCode_InternalPrimitiveTypeE_0;

		// Token: 0x04002AFA RID: 11002
		private static readonly IntPtr NativeMethodInfoPtr_InitCodeA_Private_Static_Void_0;

		// Token: 0x04002AFB RID: 11003
		private static readonly IntPtr NativeMethodInfoPtr_ToPrimitiveTypeEnum_Internal_Static_InternalPrimitiveTypeE_TypeCode_0;

		// Token: 0x04002AFC RID: 11004
		private static readonly IntPtr NativeMethodInfoPtr_FromString_Internal_Static_Object_String_InternalPrimitiveTypeE_0;
	}
}
