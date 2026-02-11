using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Diagnostics.Contracts
{
	// Token: 0x020004A7 RID: 1191
	public static class Contract : Object
	{
		// Token: 0x060049E0 RID: 18912 RVA: 0x0001B0C9 File Offset: 0x000192C9
		// Note: this type is marked as 'beforefieldinit'.
		static Contract()
		{
			Il2CppClassPointerStore<Contract>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Diagnostics.Contracts", "Contract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Contract>.NativeClassPtr);
			Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Contract>.NativeClassPtr, 100674044);
		}

		// Token: 0x060049E1 RID: 18913 RVA: 0x00156174 File Offset: 0x00154374
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414582, RefRangeEnd = 1414583, XrefRangeStart = 1414571, XrefRangeEnd = 1414582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ForAll<T>(IEnumerable<T> collection, Predicate<T> predicate)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(collection);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(predicate);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Contract.MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060049E2 RID: 18914 RVA: 0x0001B102 File Offset: 0x00019302
		public Contract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003C85 RID: 15493
		private static readonly IntPtr NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0;

		// Token: 0x020006DE RID: 1758
		private sealed class MethodInfoStoreGeneric_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0<T>
		{
			// Token: 0x04004C2C RID: 19500
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Contract.NativeMethodInfoPtr_ForAll_Public_Static_Boolean_IEnumerable_1_T_Predicate_1_T_0, Il2CppClassPointerStore<Contract>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
