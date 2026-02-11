using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x02000055 RID: 85
	public static class RemoveRangeExtensions : Object
	{
		// Token: 0x0600060E RID: 1550 RVA: 0x000046CE File Offset: 0x000028CE
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveRangeExtensions()
		{
			Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RemoveRangeExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr);
			RemoveRangeExtensions.NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr, 100664084);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0002458C File Offset: 0x0002278C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960663, XrefRangeEnd = 960667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryRemoveElementsInRange<TValue>(this IList<TValue> list, int index, int count, out Exception error)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RemoveRangeExtensions.MethodInfoStoreGeneric_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			error = ((intPtr4 == 0) ? null : new Exception(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00004707 File Offset: 0x00002907
		public RemoveRangeExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0;

		// Token: 0x02000183 RID: 387
		private sealed class MethodInfoStoreGeneric_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0<TValue>
		{
			// Token: 0x0400103F RID: 4159
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RemoveRangeExtensions.NativeMethodInfoPtr_TryRemoveElementsInRange_Public_Static_Boolean_IList_1_TValue_Int32_Int32_byref_Exception_0, Il2CppClassPointerStore<RemoveRangeExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
