using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace dwd.core
{
	// Token: 0x02000006 RID: 6
	public static class Finder : Object
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002544 File Offset: 0x00000744
		// Note: this type is marked as 'beforefieldinit'.
		static Finder()
		{
			Il2CppClassPointerStore<Finder>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-finder.dll", "dwd.core", "Finder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Finder>.NativeClassPtr);
			Finder.NativeFieldInfoPtr_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Finder>.NativeClassPtr, "TAG");
			Finder.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663303);
			Finder.NativeMethodInfoPtr_TryFind_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663304);
			Finder.NativeMethodInfoPtr_TryFind_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663305);
			Finder.NativeMethodInfoPtr_FindOrThrow_Public_Static_Void_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663306);
			Finder.NativeMethodInfoPtr_FindOrThrow_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663307);
			Finder.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663308);
			Finder.NativeMethodInfoPtr_Find_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Finder>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002614 File Offset: 0x00000814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1273672, RefRangeEnd = 1273674, XrefRangeStart = 1273668, XrefRangeEnd = 1273672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ClearCache()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Finder.NativeMethodInfoPtr_ClearCache_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000263C File Offset: 0x0000083C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 1273679, RefRangeEnd = 1273897, XrefRangeStart = 1273674, XrefRangeEnd = 1273679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryFind<T>(out T result) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref result;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_TryFind_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000026BC File Offset: 0x000008BC
		[CallerCount(61)]
		[CachedScanResults(RefRangeStart = 1273903, RefRangeEnd = 1273964, XrefRangeStart = 1273897, XrefRangeEnd = 1273903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T TryFind<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_TryFind_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000026EC File Offset: 0x000008EC
		[CallerCount(138)]
		[CachedScanResults(RefRangeStart = 1273971, RefRangeEnd = 1274109, XrefRangeStart = 1273964, XrefRangeEnd = 1273971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FindOrThrow<T>(out T result) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref result;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_FindOrThrow_Public_Static_Void_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					result = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002760 File Offset: 0x00000960
		[CallerCount(808)]
		[CachedScanResults(RefRangeStart = 1274117, RefRangeEnd = 1274925, XrefRangeStart = 1274109, XrefRangeEnd = 1274117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FindOrThrow<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_FindOrThrow_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002790 File Offset: 0x00000990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274925, XrefRangeEnd = 1274931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Find<T>(out T retval) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref retval;
				}
				ptr2 = intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_Find_Public_Static_Boolean_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr5 = intPtr;
					retval = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
				}
				return *IL2CPP.il2cpp_object_unbox(intPtr3);
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002810 File Offset: 0x00000A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274931, XrefRangeEnd = 1274940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Find<T>() where T : class
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Finder.MethodInfoStoreGeneric_Find_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000020E7 File Offset: 0x000002E7
		public Finder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002840 File Offset: 0x00000A40
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000020F0 File Offset: 0x000002F0
		public unsafe static string TAG
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Finder.NativeFieldInfoPtr_TAG, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Finder.NativeFieldInfoPtr_TAG, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_TAG;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_ClearCache_Public_Static_Void_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_TryFind_Public_Static_Boolean_byref_T_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_TryFind_Public_Static_T_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_FindOrThrow_Public_Static_Void_byref_T_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_FindOrThrow_Public_Static_T_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_T_0;

		// Token: 0x0200000A RID: 10
		private sealed class MethodInfoStoreGeneric_TryFind_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x0400001F RID: 31
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_TryFind_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000B RID: 11
		private sealed class MethodInfoStoreGeneric_TryFind_Public_Static_T_0<T>
		{
			// Token: 0x04000020 RID: 32
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_TryFind_Public_Static_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000C RID: 12
		private sealed class MethodInfoStoreGeneric_FindOrThrow_Public_Static_Void_byref_T_0<T>
		{
			// Token: 0x04000021 RID: 33
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_FindOrThrow_Public_Static_Void_byref_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000D RID: 13
		private sealed class MethodInfoStoreGeneric_FindOrThrow_Public_Static_T_0<T>
		{
			// Token: 0x04000022 RID: 34
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_FindOrThrow_Public_Static_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000E RID: 14
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_Boolean_byref_T_0<T>
		{
			// Token: 0x04000023 RID: 35
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_Find_Public_Static_Boolean_byref_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200000F RID: 15
		private sealed class MethodInfoStoreGeneric_Find_Public_Static_T_0<T>
		{
			// Token: 0x04000024 RID: 36
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Finder.NativeMethodInfoPtr_Find_Public_Static_T_0, Il2CppClassPointerStore<Finder>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
