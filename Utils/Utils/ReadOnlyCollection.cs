using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Utils
{
	// Token: 0x02000034 RID: 52
	public static class ReadOnlyCollection : Object
	{
		// Token: 0x0600022D RID: 557 RVA: 0x0000299A File Offset: 0x00000B9A
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyCollection()
		{
			Il2CppClassPointerStore<ReadOnlyCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Utils", "ReadOnlyCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyCollection>.NativeClassPtr);
			ReadOnlyCollection.NativeMethodInfoPtr_Empty_Public_Static_IReadOnlyCollection_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyCollection>.NativeClassPtr, 100663838);
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000D894 File Offset: 0x0000BA94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1183774, RefRangeEnd = 1183775, XrefRangeStart = 1183770, XrefRangeEnd = 1183774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IReadOnlyCollection<T> Empty<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyCollection.MethodInfoStoreGeneric_Empty_Public_Static_IReadOnlyCollection_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyCollection<T>>(intPtr3) : null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x000029D3 File Offset: 0x00000BD3
		public ReadOnlyCollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_Empty_Public_Static_IReadOnlyCollection_1_T_0;

		// Token: 0x020000B2 RID: 178
		private sealed class MethodInfoStoreGeneric_Empty_Public_Static_IReadOnlyCollection_1_T_0<T>
		{
			// Token: 0x040003A0 RID: 928
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ReadOnlyCollection.NativeMethodInfoPtr_Empty_Public_Static_IReadOnlyCollection_1_T_0, Il2CppClassPointerStore<ReadOnlyCollection>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
