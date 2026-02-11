using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Dynamic.Utils
{
	// Token: 0x02000127 RID: 295
	public static class CollectionExtensions : Object
	{
		// Token: 0x06001151 RID: 4433 RVA: 0x0005A944 File Offset: 0x00058B44
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionExtensions()
		{
			Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Dynamic.Utils", "CollectionExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr);
			CollectionExtensions.NativeMethodInfoPtr_AddFirst_Public_Static_TrueReadOnlyCollection_1_T_ReadOnlyCollection_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100666580);
			CollectionExtensions.NativeMethodInfoPtr_AddLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100666581);
			CollectionExtensions.NativeMethodInfoPtr_RemoveFirst_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100666582);
			CollectionExtensions.NativeMethodInfoPtr_RemoveLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100666583);
			CollectionExtensions.NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_IEnumerable_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr, 100666584);
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0005A9D8 File Offset: 0x00058BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1029622, XrefRangeEnd = 1029631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static TrueReadOnlyCollection<T> AddFirst<T>(this ReadOnlyCollection<T> list, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_AddFirst_Public_Static_TrueReadOnlyCollection_1_T_ReadOnlyCollection_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr2;
			return (intPtr4 != 0) ? Il2CppObjectPool.Get<TrueReadOnlyCollection<T>>(intPtr4) : null;
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0005AA64 File Offset: 0x00058C64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1029636, RefRangeEnd = 1029637, XrefRangeStart = 1029631, XrefRangeEnd = 1029636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> AddLast<T>(this Il2CppArrayBase<T> array, T item)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = item;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref item;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_AddLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr2);
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x0005AAE8 File Offset: 0x00058CE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1029641, RefRangeEnd = 1029644, XrefRangeStart = 1029637, XrefRangeEnd = 1029641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> RemoveFirst<T>(this Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_RemoveFirst_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0005AB24 File Offset: 0x00058D24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1029648, RefRangeEnd = 1029650, XrefRangeStart = 1029644, XrefRangeEnd = 1029648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> RemoveLast<T>(this Il2CppArrayBase<T> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_RemoveLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x0005AB60 File Offset: 0x00058D60
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1029657, RefRangeEnd = 1029678, XrefRangeStart = 1029650, XrefRangeEnd = 1029657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReadOnlyCollection<T> ToReadOnly<T>(this IEnumerable<T> enumerable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(enumerable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionExtensions.MethodInfoStoreGeneric_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_IEnumerable_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x0000751C File Offset: 0x0000571C
		public CollectionExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C6D RID: 3181
		private static readonly IntPtr NativeMethodInfoPtr_AddFirst_Public_Static_TrueReadOnlyCollection_1_T_ReadOnlyCollection_1_T_T_0;

		// Token: 0x04000C6E RID: 3182
		private static readonly IntPtr NativeMethodInfoPtr_AddLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0;

		// Token: 0x04000C6F RID: 3183
		private static readonly IntPtr NativeMethodInfoPtr_RemoveFirst_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C70 RID: 3184
		private static readonly IntPtr NativeMethodInfoPtr_RemoveLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0;

		// Token: 0x04000C71 RID: 3185
		private static readonly IntPtr NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_IEnumerable_1_T_0;

		// Token: 0x0200034B RID: 843
		private sealed class MethodInfoStoreGeneric_AddFirst_Public_Static_TrueReadOnlyCollection_1_T_ReadOnlyCollection_1_T_T_0<T>
		{
			// Token: 0x040012F4 RID: 4852
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_AddFirst_Public_Static_TrueReadOnlyCollection_1_T_ReadOnlyCollection_1_T_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200034C RID: 844
		private sealed class MethodInfoStoreGeneric_AddLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0<T>
		{
			// Token: 0x040012F5 RID: 4853
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_AddLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200034D RID: 845
		private sealed class MethodInfoStoreGeneric_RemoveFirst_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040012F6 RID: 4854
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_RemoveFirst_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200034E RID: 846
		private sealed class MethodInfoStoreGeneric_RemoveLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x040012F7 RID: 4855
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_RemoveLast_Public_Static_Il2CppArrayBase_1_T_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200034F RID: 847
		private sealed class MethodInfoStoreGeneric_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_IEnumerable_1_T_0<T>
		{
			// Token: 0x040012F8 RID: 4856
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CollectionExtensions.NativeMethodInfoPtr_ToReadOnly_Public_Static_ReadOnlyCollection_1_T_IEnumerable_1_T_0, Il2CppClassPointerStore<CollectionExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
