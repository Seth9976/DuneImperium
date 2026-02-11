using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200003A RID: 58
	public static class ArrayBuilderExtensions : Object
	{
		// Token: 0x0600036D RID: 877 RVA: 0x00002C84 File Offset: 0x00000E84
		// Note: this type is marked as 'beforefieldinit'.
		static ArrayBuilderExtensions()
		{
			Il2CppClassPointerStore<ArrayBuilderExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "ArrayBuilderExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArrayBuilderExtensions>.NativeClassPtr);
			ArrayBuilderExtensions.NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_ArrayBuilder_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArrayBuilderExtensions>.NativeClassPtr, 100664145);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00020FD4 File Offset: 0x0001F1D4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1012091, RefRangeEnd = 1012096, XrefRangeStart = 1012086, XrefRangeEnd = 1012091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> ToReadOnly<T>(this Il2CppSystem.Collections.Generic.ArrayBuilder<T> builder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(builder));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArrayBuilderExtensions.MethodInfoStoreGeneric_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_ArrayBuilder_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00002CBD File Offset: 0x00000EBD
		public ArrayBuilderExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000297 RID: 663
		private static readonly IntPtr NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_ArrayBuilder_1_T_0;

		// Token: 0x020001DC RID: 476
		private sealed class MethodInfoStoreGeneric_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_ArrayBuilder_1_T_0<T>
		{
			// Token: 0x04000FB9 RID: 4025
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ArrayBuilderExtensions.NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_ArrayBuilder_1_T_0, Il2CppClassPointerStore<ArrayBuilderExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
