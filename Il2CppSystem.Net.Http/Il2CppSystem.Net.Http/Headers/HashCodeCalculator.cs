using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Net.Http.Headers
{
	// Token: 0x0200001F RID: 31
	public static class HashCodeCalculator : Object
	{
		// Token: 0x06000203 RID: 515 RVA: 0x00002CF2 File Offset: 0x00000EF2
		// Note: this type is marked as 'beforefieldinit'.
		static HashCodeCalculator()
		{
			Il2CppClassPointerStore<HashCodeCalculator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Net.Http.dll", "System.Net.Http.Headers", "HashCodeCalculator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HashCodeCalculator>.NativeClassPtr);
			HashCodeCalculator.NativeMethodInfoPtr_Calculate_Public_Static_Int32_ICollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HashCodeCalculator>.NativeClassPtr, 100663586);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000C138 File Offset: 0x0000A338
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1173466, RefRangeEnd = 1173474, XrefRangeStart = 1173449, XrefRangeEnd = 1173466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Calculate<T>(ICollection<T> list)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HashCodeCalculator.MethodInfoStoreGeneric_Calculate_Public_Static_Int32_ICollection_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002D2B File Offset: 0x00000F2B
		public HashCodeCalculator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_Calculate_Public_Static_Int32_ICollection_1_T_0;

		// Token: 0x0200004C RID: 76
		private sealed class MethodInfoStoreGeneric_Calculate_Public_Static_Int32_ICollection_1_T_0<T>
		{
			// Token: 0x0400032F RID: 815
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(HashCodeCalculator.NativeMethodInfoPtr_Calculate_Public_Static_Int32_ICollection_1_T_0, Il2CppClassPointerStore<HashCodeCalculator>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
