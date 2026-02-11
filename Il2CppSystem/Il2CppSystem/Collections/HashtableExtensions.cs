using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000157 RID: 343
	public static class HashtableExtensions : Object
	{
		// Token: 0x060014A6 RID: 5286 RVA: 0x00009305 File Offset: 0x00007505
		// Note: this type is marked as 'beforefieldinit'.
		static HashtableExtensions()
		{
			Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Collections", "HashtableExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr);
			HashtableExtensions.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr, 100666400);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0006C1F4 File Offset: 0x0006A3F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 466254, RefRangeEnd = 466258, XrefRangeStart = 466253, XrefRangeEnd = 466254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetValue<T>(this Hashtable table, Object key, out T value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(key);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(HashtableExtensions.MethodInfoStoreGeneric_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0000933E File Offset: 0x0000753E
		public HashtableExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0;

		// Token: 0x020002ED RID: 749
		private sealed class MethodInfoStoreGeneric_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0<T>
		{
			// Token: 0x04002352 RID: 9042
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashtableExtensions.NativeMethodInfoPtr_TryGetValue_Public_Static_Boolean_Hashtable_Object_byref_T_0, Il2CppClassPointerStore<HashtableExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
