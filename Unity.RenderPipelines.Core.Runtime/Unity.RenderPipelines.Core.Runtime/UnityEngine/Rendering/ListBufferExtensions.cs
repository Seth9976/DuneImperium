using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x0200004B RID: 75
	public static class ListBufferExtensions : Object
	{
		// Token: 0x060005A4 RID: 1444 RVA: 0x000044AF File Offset: 0x000026AF
		// Note: this type is marked as 'beforefieldinit'.
		static ListBufferExtensions()
		{
			Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ListBufferExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr);
			ListBufferExtensions.NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr, 100664015);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x000227C4 File Offset: 0x000209C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960218, XrefRangeEnd = 960222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QuickSort<T>(this ListBuffer<T> self) where T : new()
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(self));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ListBufferExtensions.MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ListBuffer_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x000044E8 File Offset: 0x000026E8
		public ListBufferExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000431 RID: 1073
		private static readonly IntPtr NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0;

		// Token: 0x0200017E RID: 382
		private sealed class MethodInfoStoreGeneric_QuickSort_Public_Static_Void_ListBuffer_1_T_0<T>
		{
			// Token: 0x04001031 RID: 4145
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ListBufferExtensions.NativeMethodInfoPtr_QuickSort_Public_Static_Void_ListBuffer_1_T_0, Il2CppClassPointerStore<ListBufferExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
