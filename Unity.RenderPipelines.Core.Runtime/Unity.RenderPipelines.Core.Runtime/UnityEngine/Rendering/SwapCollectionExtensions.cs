using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000059 RID: 89
	public static class SwapCollectionExtensions : Object
	{
		// Token: 0x0600062E RID: 1582 RVA: 0x000047A7 File Offset: 0x000029A7
		// Note: this type is marked as 'beforefieldinit'.
		static SwapCollectionExtensions()
		{
			Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "SwapCollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr);
			SwapCollectionExtensions.NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr, 100664100);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00024F94 File Offset: 0x00023194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960731, XrefRangeEnd = 960786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TrySwap<TValue>(this IList<TValue> list, int from, int to, out Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref from;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SwapCollectionExtensions.MethodInfoStoreGeneric_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new Exception(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x000047E0 File Offset: 0x000029E0
		public SwapCollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000489 RID: 1161
		private static readonly IntPtr NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0;

		// Token: 0x02000184 RID: 388
		private sealed class MethodInfoStoreGeneric_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>
		{
			// Token: 0x04001040 RID: 4160
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(SwapCollectionExtensions.NativeMethodInfoPtr_TrySwap_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0, Il2CppClassPointerStore<SwapCollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
