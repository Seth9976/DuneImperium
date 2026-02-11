using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Utils
{
	// Token: 0x0200002E RID: 46
	public static class DictionaryUtil : Object
	{
		// Token: 0x060001CB RID: 459 RVA: 0x0000B498 File Offset: 0x00009698
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryUtil()
		{
			Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "DictionaryUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr);
			DictionaryUtil.NativeMethodInfoPtr_GetOrElse_Public_Static_V_Dictionary_2_K_V_K_Func_1_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr, 100663559);
			DictionaryUtil.NativeMethodInfoPtr_AddCounts_Public_Static_Dictionary_2_K_Int32_Dictionary_2_K_Int32_Dictionary_2_K_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr, 100663560);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181293, XrefRangeEnd = 1181301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static V GetOrElse<K, V>(this Dictionary<K, V> dict, K key, Func<V> defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(K).IsValueType)
			{
				K k = key;
				intPtr = ((k is string) ? IL2CPP.ManagedStringToIl2Cpp(k as string) : IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref key;
			}
			ptr2 = intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultValue);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryUtil.MethodInfoStoreGeneric_GetOrElse_Public_Static_V_Dictionary_2_K_V_K_Func_1_V_0<K, V>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<V>(intPtr2, false, true);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000B588 File Offset: 0x00009788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181301, XrefRangeEnd = 1181352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Dictionary<K, int> AddCounts<K>(this Dictionary<K, int> self, Dictionary<K, int> other)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryUtil.MethodInfoStoreGeneric_AddCounts_Public_Static_Dictionary_2_K_Int32_Dictionary_2_K_Int32_Dictionary_2_K_Int32_0<K>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<K, int>>(intPtr3) : null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000028BC File Offset: 0x00000ABC
		public DictionaryUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012D RID: 301
		private static readonly IntPtr NativeMethodInfoPtr_GetOrElse_Public_Static_V_Dictionary_2_K_V_K_Func_1_V_0;

		// Token: 0x0400012E RID: 302
		private static readonly IntPtr NativeMethodInfoPtr_AddCounts_Public_Static_Dictionary_2_K_Int32_Dictionary_2_K_Int32_Dictionary_2_K_Int32_0;

		// Token: 0x02000048 RID: 72
		private sealed class MethodInfoStoreGeneric_GetOrElse_Public_Static_V_Dictionary_2_K_V_K_Func_1_V_0<K, V>
		{
			// Token: 0x040001DC RID: 476
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DictionaryUtil.NativeMethodInfoPtr_GetOrElse_Public_Static_V_Dictionary_2_K_V_K_Func_1_V_0, Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000049 RID: 73
		private sealed class MethodInfoStoreGeneric_AddCounts_Public_Static_Dictionary_2_K_Int32_Dictionary_2_K_Int32_Dictionary_2_K_Int32_0<K>
		{
			// Token: 0x040001DD RID: 477
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(DictionaryUtil.NativeMethodInfoPtr_AddCounts_Public_Static_Dictionary_2_K_Int32_Dictionary_2_K_Int32_Dictionary_2_K_Int32_0, Il2CppClassPointerStore<DictionaryUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)) }))));
		}
	}
}
