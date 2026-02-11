using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000A4 RID: 164
	[StructLayout(2)]
	public struct HashCode
	{
		// Token: 0x06000B5F RID: 2911 RVA: 0x00059EFC File Offset: 0x000580FC
		// Note: this type is marked as 'beforefieldinit'.
		static HashCode()
		{
			Il2CppClassPointerStore<HashCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "HashCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashCode>.NativeClassPtr);
			HashCode.NativeFieldInfoPtr_s_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "s_seed");
			HashCode.NativeFieldInfoPtr__v1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_v1");
			HashCode.NativeFieldInfoPtr__v2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_v2");
			HashCode.NativeFieldInfoPtr__v3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_v3");
			HashCode.NativeFieldInfoPtr__v4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_v4");
			HashCode.NativeFieldInfoPtr__queue1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_queue1");
			HashCode.NativeFieldInfoPtr__queue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_queue2");
			HashCode.NativeFieldInfoPtr__queue3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_queue3");
			HashCode.NativeFieldInfoPtr__length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HashCode>.NativeClassPtr, "_length");
			HashCode.NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665274);
			HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665275);
			HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665276);
			HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665277);
			HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665278);
			HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_T6_T7_T8_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665279);
			HashCode.NativeMethodInfoPtr_Rol_Private_Static_UInt32_UInt32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665280);
			HashCode.NativeMethodInfoPtr_Initialize_Private_Static_Void_byref_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665281);
			HashCode.NativeMethodInfoPtr_Round_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665282);
			HashCode.NativeMethodInfoPtr_QueueRound_Private_Static_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665283);
			HashCode.NativeMethodInfoPtr_MixState_Private_Static_UInt32_UInt32_UInt32_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665284);
			HashCode.NativeMethodInfoPtr_MixEmptyState_Private_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665285);
			HashCode.NativeMethodInfoPtr_MixFinal_Private_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665286);
			HashCode.NativeMethodInfoPtr_Add_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665287);
			HashCode.NativeMethodInfoPtr_Add_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665288);
			HashCode.NativeMethodInfoPtr_ToHashCode_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665289);
			HashCode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665290);
			HashCode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCode>.NativeClassPtr, 100665291);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0005A148 File Offset: 0x00058348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1307908, XrefRangeEnd = 1307909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GenerateGlobalSeed()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0005A178 File Offset: 0x00058378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307920, RefRangeEnd = 1307921, XrefRangeStart = 1307909, XrefRangeEnd = 1307920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine<T1, T2>(T1 value1, T2 value2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = value1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_0<T1, T2>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0005A238 File Offset: 0x00058438
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307940, RefRangeEnd = 1307941, XrefRangeStart = 1307921, XrefRangeEnd = 1307940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = value1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = value3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref value3;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_0<T1, T2, T3>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			return *IL2CPP.il2cpp_object_unbox(intPtr4);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0005A340 File Offset: 0x00058540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307966, RefRangeEnd = 1307967, XrefRangeStart = 1307941, XrefRangeEnd = 1307966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = value1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = value3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref value3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = value4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref value4;
			}
			ptr5 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_0<T1, T2, T3, T4>.Pointer, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			return *IL2CPP.il2cpp_object_unbox(intPtr5);
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0005A490 File Offset: 0x00058690
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1307999, RefRangeEnd = 1308000, XrefRangeStart = 1307967, XrefRangeEnd = 1307999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = value1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = value3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref value3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = value4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref value4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = value5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref value5;
			}
			ptr6 = intPtr5;
			IntPtr intPtr7;
			IntPtr intPtr6 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_0<T1, T2, T3, T4, T5>.Pointer, 0, (void**)ptr, ref intPtr7);
			Il2CppException.RaiseExceptionIfNecessary(intPtr7);
			return *IL2CPP.il2cpp_object_unbox(intPtr6);
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0005A628 File Offset: 0x00058828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1308041, RefRangeEnd = 1308042, XrefRangeStart = 1308000, XrefRangeEnd = 1308041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = value1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref value2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = value3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref value3;
			}
			ptr4 = intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4;
			if (!typeof(T4).IsValueType)
			{
				T4 t4 = value4;
				intPtr4 = ((t4 is string) ? IL2CPP.ManagedStringToIl2Cpp(t4 as string) : IL2CPP.Il2CppObjectBaseToPtr(t4 as Il2CppObjectBase));
			}
			else
			{
				intPtr4 = ref value4;
			}
			ptr5 = intPtr4;
			ref IntPtr ptr6 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr5;
			if (!typeof(T5).IsValueType)
			{
				T5 t5 = value5;
				intPtr5 = ((t5 is string) ? IL2CPP.ManagedStringToIl2Cpp(t5 as string) : IL2CPP.Il2CppObjectBaseToPtr(t5 as Il2CppObjectBase));
			}
			else
			{
				intPtr5 = ref value5;
			}
			ptr6 = intPtr5;
			ref IntPtr ptr7 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr6;
			if (!typeof(T6).IsValueType)
			{
				T6 t6 = value6;
				intPtr6 = ((t6 is string) ? IL2CPP.ManagedStringToIl2Cpp(t6 as string) : IL2CPP.Il2CppObjectBaseToPtr(t6 as Il2CppObjectBase));
			}
			else
			{
				intPtr6 = ref value6;
			}
			ptr7 = intPtr6;
			ref IntPtr ptr8 = ref ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr7;
			if (!typeof(T7).IsValueType)
			{
				T7 t7 = value7;
				intPtr7 = ((t7 is string) ? IL2CPP.ManagedStringToIl2Cpp(t7 as string) : IL2CPP.Il2CppObjectBaseToPtr(t7 as Il2CppObjectBase));
			}
			else
			{
				intPtr7 = ref value7;
			}
			ptr8 = intPtr7;
			ref IntPtr ptr9 = ref ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr8;
			if (!typeof(T8).IsValueType)
			{
				T8 t8 = value8;
				intPtr8 = ((t8 is string) ? IL2CPP.ManagedStringToIl2Cpp(t8 as string) : IL2CPP.Il2CppObjectBaseToPtr(t8 as Il2CppObjectBase));
			}
			else
			{
				intPtr8 = ref value8;
			}
			ptr9 = intPtr8;
			IntPtr intPtr10;
			IntPtr intPtr9 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_T6_T7_T8_0<T1, T2, T3, T4, T5, T6, T7, T8>.Pointer, 0, (void**)ptr, ref intPtr10);
			Il2CppException.RaiseExceptionIfNecessary(intPtr10);
			return *IL2CPP.il2cpp_object_unbox(intPtr9);
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0005A89C File Offset: 0x00058A9C
		[CallerCount(0)]
		public unsafe static uint Rol(uint value, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_Rol_Private_Static_UInt32_UInt32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0005A8E8 File Offset: 0x00058AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308042, XrefRangeEnd = 1308049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &v4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_Initialize_Private_Static_Void_byref_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0005A944 File Offset: 0x00058B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308049, XrefRangeEnd = 1308052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint Round(uint hash, uint input)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_Round_Private_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0005A990 File Offset: 0x00058B90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308052, XrefRangeEnd = 1308055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint QueueRound(uint hash, uint queuedValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref queuedValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_QueueRound_Private_Static_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0005A9DC File Offset: 0x00058BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308055, XrefRangeEnd = 1308058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint MixState(uint v1, uint v2, uint v3, uint v4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref v4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_MixState_Private_Static_UInt32_UInt32_UInt32_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0005AA44 File Offset: 0x00058C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1308062, RefRangeEnd = 1308064, XrefRangeStart = 1308058, XrefRangeEnd = 1308062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint MixEmptyState()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_MixEmptyState_Private_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0005AA74 File Offset: 0x00058C74
		[CallerCount(0)]
		public unsafe static uint MixFinal(uint hash)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hash;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_MixFinal_Private_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0005AAB4 File Offset: 0x00058CB4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1308073, RefRangeEnd = 1308086, XrefRangeStart = 1308064, XrefRangeEnd = 1308073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add<T>(T value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HashCode.MethodInfoStoreGeneric_Add_Public_Void_T_0<T>.Pointer, ref this, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0005AB20 File Offset: 0x00058D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1308102, RefRangeEnd = 1308103, XrefRangeStart = 1308086, XrefRangeEnd = 1308102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_Add_Private_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0005AB54 File Offset: 0x00058D54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1308128, RefRangeEnd = 1308129, XrefRangeStart = 1308103, XrefRangeEnd = 1308128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ToHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_ToHashCode_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0005AB84 File Offset: 0x00058D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308129, XrefRangeEnd = 1308135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0005ABB4 File Offset: 0x00058DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1308135, XrefRangeEnd = 1308141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00004DDB File Offset: 0x00002FDB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashCode>.NativeClassPtr, ref this));
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0005ABF8 File Offset: 0x00058DF8
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x00004DED File Offset: 0x00002FED
		public unsafe static uint s_seed
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(HashCode.NativeFieldInfoPtr_s_seed, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HashCode.NativeFieldInfoPtr_s_seed, (void*)(&value));
			}
		}

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeFieldInfoPtr_s_seed;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeFieldInfoPtr__v1;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeFieldInfoPtr__v2;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeFieldInfoPtr__v3;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeFieldInfoPtr__v4;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeFieldInfoPtr__queue1;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeFieldInfoPtr__queue2;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeFieldInfoPtr__queue3;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeFieldInfoPtr__length;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_GenerateGlobalSeed_Private_Static_UInt32_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_T6_T7_T8_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_Rol_Private_Static_UInt32_UInt32_Int32_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Private_Static_Void_byref_UInt32_byref_UInt32_byref_UInt32_byref_UInt32_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_Round_Private_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_QueueRound_Private_Static_UInt32_UInt32_UInt32_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_MixState_Private_Static_UInt32_UInt32_UInt32_UInt32_UInt32_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_MixEmptyState_Private_Static_UInt32_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_MixFinal_Private_Static_UInt32_UInt32_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_Add_Private_Void_Int32_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_ToHashCode_Public_Int32_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000967 RID: 2407
		[FieldOffset(0)]
		public uint _v1;

		// Token: 0x04000968 RID: 2408
		[FieldOffset(4)]
		public uint _v2;

		// Token: 0x04000969 RID: 2409
		[FieldOffset(8)]
		public uint _v3;

		// Token: 0x0400096A RID: 2410
		[FieldOffset(12)]
		public uint _v4;

		// Token: 0x0400096B RID: 2411
		[FieldOffset(16)]
		public uint _queue1;

		// Token: 0x0400096C RID: 2412
		[FieldOffset(20)]
		public uint _queue2;

		// Token: 0x0400096D RID: 2413
		[FieldOffset(24)]
		public uint _queue3;

		// Token: 0x0400096E RID: 2414
		[FieldOffset(28)]
		public uint _length;

		// Token: 0x0200058D RID: 1421
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_0<T1, T2>
		{
			// Token: 0x0400470D RID: 18189
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200058E RID: 1422
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_0<T1, T2, T3>
		{
			// Token: 0x0400470E RID: 18190
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}

		// Token: 0x0200058F RID: 1423
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_0<T1, T2, T3, T4>
		{
			// Token: 0x0400470F RID: 18191
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000590 RID: 1424
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_0<T1, T2, T3, T4, T5>
		{
			// Token: 0x04004710 RID: 18192
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000591 RID: 1425
		private sealed class MethodInfoStoreGeneric_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_T6_T7_T8_0<T1, T2, T3, T4, T5, T6, T7, T8>
		{
			// Token: 0x04004711 RID: 18193
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Combine_Public_Static_Int32_T1_T2_T3_T4_T5_T6_T7_T8_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T4>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T5>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T6>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T7>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T8>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000592 RID: 1426
		private sealed class MethodInfoStoreGeneric_Add_Public_Void_T_0<T>
		{
			// Token: 0x04004712 RID: 18194
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCode.NativeMethodInfoPtr_Add_Public_Void_T_0, Il2CppClassPointerStore<HashCode>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
