using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x020000F8 RID: 248
	public static class TupleExtensions : Object
	{
		// Token: 0x06000FE9 RID: 4073 RVA: 0x00005C7E File Offset: 0x00003E7E
		// Note: this type is marked as 'beforefieldinit'.
		static TupleExtensions()
		{
			Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TupleExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr);
			TupleExtensions.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_Tuple_2_T1_T2_byref_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr, 100666054);
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x00070450 File Offset: 0x0006E650
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1321932, RefRangeEnd = 1321934, XrefRangeStart = 1321930, XrefRangeEnd = 1321932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deconstruct<T1, T2>(this Tuple<T1, T2> value, out T1 item1, out T2 item2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref item1;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(T2).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref item2;
			}
			ptr3 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(TupleExtensions.MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_Tuple_2_T1_T2_byref_T1_byref_T2_0<T1, T2>.Pointer, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(T1).IsValueType)
			{
				IntPtr intPtr7 = intPtr;
				item1 = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr7, false, false));
			}
			if (!typeof(T2).IsValueType)
			{
				IntPtr intPtr8 = intPtr3;
				item2 = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr8, false, false));
			}
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00005CB7 File Offset: 0x00003EB7
		public TupleExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CF0 RID: 3312
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Static_Void_Tuple_2_T1_T2_byref_T1_byref_T2_0;

		// Token: 0x020005A3 RID: 1443
		private sealed class MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_Tuple_2_T1_T2_byref_T1_byref_T2_0<T1, T2>
		{
			// Token: 0x0400472F RID: 18223
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TupleExtensions.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_Tuple_2_T1_T2_byref_T1_byref_T2_0, Il2CppClassPointerStore<TupleExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			}))));
		}
	}
}
