using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.IO
{
	// Token: 0x0200054F RID: 1359
	public static class MonoLinqHelper : Object
	{
		// Token: 0x060053DA RID: 21466 RVA: 0x0001DA84 File Offset: 0x0001BC84
		// Note: this type is marked as 'beforefieldinit'.
		static MonoLinqHelper()
		{
			Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "MonoLinqHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr);
			MonoLinqHelper.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr, 100676170);
		}

		// Token: 0x060053DB RID: 21467 RVA: 0x001867F0 File Offset: 0x001849F0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1434607, RefRangeEnd = 1434614, XrefRangeStart = 1434605, XrefRangeEnd = 1434607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ToArray<T>(this IEnumerable<T> source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoLinqHelper.MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x060053DC RID: 21468 RVA: 0x0001DABD File Offset: 0x0001BCBD
		public MonoLinqHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400449C RID: 17564
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0;

		// Token: 0x0200072E RID: 1838
		private sealed class MethodInfoStoreGeneric_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x04004F2D RID: 20269
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(MonoLinqHelper.NativeMethodInfoPtr_ToArray_Public_Static_Il2CppArrayBase_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<MonoLinqHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
