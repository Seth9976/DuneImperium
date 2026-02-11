using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000F4 RID: 244
	public static class Tuple : Object
	{
		// Token: 0x06000FA3 RID: 4003 RVA: 0x0006E668 File Offset: 0x0006C868
		// Note: this type is marked as 'beforefieldinit'.
		static Tuple()
		{
			Il2CppClassPointerStore<Tuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Tuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Tuple>.NativeClassPtr);
			Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100666010);
			Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_3_T1_T2_T3_T1_T2_T3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100666011);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100666012);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100666013);
			Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Tuple>.NativeClassPtr, 100666014);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0006E6FC File Offset: 0x0006C8FC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1321560, RefRangeEnd = 1321563, XrefRangeStart = 1321556, XrefRangeEnd = 1321560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = item1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = item2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item2;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Tuple.MethodInfoStoreGeneric_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0<T1, T2>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Tuple<T1, T2>>(intPtr5) : null;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0006E7C0 File Offset: 0x0006C9C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321567, RefRangeEnd = 1321568, XrefRangeStart = 1321563, XrefRangeEnd = 1321567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = item1;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item1;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = item2;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref item2;
			}
			ptr3 = intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			if (!typeof(T3).IsValueType)
			{
				T3 t3 = item3;
				intPtr3 = ((t3 is string) ? IL2CPP.ManagedStringToIl2Cpp(t3 as string) : IL2CPP.Il2CppObjectBaseToPtr(t3 as Il2CppObjectBase));
			}
			else
			{
				intPtr3 = ref item3;
			}
			ptr4 = intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(Tuple.MethodInfoStoreGeneric_Create_Public_Static_Tuple_3_T1_T2_T3_T1_T2_T3_0<T1, T2, T3>.Pointer, 0, (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr4;
			return (intPtr6 != 0) ? Il2CppObjectPool.Get<Tuple<T1, T2, T3>>(intPtr6) : null;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x0006E8CC File Offset: 0x0006CACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 786824, RefRangeEnd = 786825, XrefRangeStart = 786824, XrefRangeEnd = 786825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0006E918 File Offset: 0x0006CB18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321568, RefRangeEnd = 1321569, XrefRangeStart = 1321568, XrefRangeEnd = 1321568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x0006E974 File Offset: 0x0006CB74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1321569, RefRangeEnd = 1321570, XrefRangeStart = 1321569, XrefRangeEnd = 1321569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CombineHashCodes(int h1, int h2, int h3, int h4)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref h1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h3;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref h4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Tuple.NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00005C5A File Offset: 0x00003E5A
		public Tuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CBB RID: 3259
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0;

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_Tuple_3_T1_T2_T3_T1_T2_T3_0;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_0;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeMethodInfoPtr_CombineHashCodes_Internal_Static_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x020005A1 RID: 1441
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0<T1, T2>
		{
			// Token: 0x0400472D RID: 18221
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_2_T1_T2_T1_T2_0, Il2CppClassPointerStore<Tuple>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}

		// Token: 0x020005A2 RID: 1442
		private sealed class MethodInfoStoreGeneric_Create_Public_Static_Tuple_3_T1_T2_T3_T1_T2_T3_0<T1, T2, T3>
		{
			// Token: 0x0400472E RID: 18222
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Tuple.NativeMethodInfoPtr_Create_Public_Static_Tuple_3_T1_T2_T3_T1_T2_T3_0, Il2CppClassPointerStore<Tuple>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T3>.NativeClassPtr))
			}))));
		}
	}
}
