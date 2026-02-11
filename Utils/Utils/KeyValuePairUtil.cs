using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Utils
{
	// Token: 0x02000031 RID: 49
	public static class KeyValuePairUtil : Object
	{
		// Token: 0x060001E9 RID: 489 RVA: 0x00002934 File Offset: 0x00000B34
		// Note: this type is marked as 'beforefieldinit'.
		static KeyValuePairUtil()
		{
			Il2CppClassPointerStore<KeyValuePairUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "KeyValuePairUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyValuePairUtil>.NativeClassPtr);
			KeyValuePairUtil.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_KeyValuePair_2_S_T_byref_S_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyValuePairUtil>.NativeClassPtr, 100663580);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000BE74 File Offset: 0x0000A074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181613, XrefRangeEnd = 1181622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Deconstruct<S, T>(this KeyValuePair<S, T> pair, out S fst, out T snd)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(S).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref fst;
			}
			ptr2 = intPtr2;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3;
			IntPtr intPtr4;
			if (!typeof(T).IsValueType)
			{
				intPtr3 = 0;
				intPtr4 = &intPtr3;
			}
			else
			{
				intPtr4 = ref snd;
			}
			ptr3 = intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(KeyValuePairUtil.MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_KeyValuePair_2_S_T_byref_S_byref_T_0<S, T>.Pointer, 0, (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			if (!typeof(S).IsValueType)
			{
				IntPtr intPtr7 = intPtr;
				fst = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<S>(intPtr7, false, false));
			}
			if (!typeof(T).IsValueType)
			{
				IntPtr intPtr8 = intPtr3;
				snd = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr8, false, false));
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000296D File Offset: 0x00000B6D
		public KeyValuePairUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Static_Void_KeyValuePair_2_S_T_byref_S_byref_T_0;

		// Token: 0x0200005C RID: 92
		private sealed class MethodInfoStoreGeneric_Deconstruct_Public_Static_Void_KeyValuePair_2_S_T_byref_S_byref_T_0<S, T>
		{
			// Token: 0x040001F0 RID: 496
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(KeyValuePairUtil.NativeMethodInfoPtr_Deconstruct_Public_Static_Void_KeyValuePair_2_S_T_byref_S_byref_T_0, Il2CppClassPointerStore<KeyValuePairUtil>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<S>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
