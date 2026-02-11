using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000187 RID: 391
	public static class LazyInitializer : Object
	{
		// Token: 0x060019F2 RID: 6642 RVA: 0x0009FF28 File Offset: 0x0009E128
		// Note: this type is marked as 'beforefieldinit'.
		static LazyInitializer()
		{
			Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "LazyInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667830);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667831);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667832);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667833);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667834);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667835);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Object_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667836);
			LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Object_Func_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667837);
			LazyInitializer.NativeMethodInfoPtr_EnsureLockInitialized_Private_Static_Object_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr, 100667838);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x000A000C File Offset: 0x0009E20C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1351505, RefRangeEnd = 1351509, XrefRangeStart = 1351503, XrefRangeEnd = 1351505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitialized<T>(ref T target) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x000A0064 File Offset: 0x0009E264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351509, XrefRangeEnd = 1351512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x000A00BC File Offset: 0x0009E2BC
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 1351516, RefRangeEnd = 1351537, XrefRangeStart = 1351512, XrefRangeEnd = 1351516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitialized<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x000A0128 File Offset: 0x0009E328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1351537, XrefRangeEnd = 1351539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			target = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x000A0194 File Offset: 0x0009E394
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351543, RefRangeEnd = 1351545, XrefRangeStart = 1351539, XrefRangeEnd = 1351543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitialized<T>(ref T target, ref bool initialized, ref Object syncLock, Func<T> valueFactory)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &initialized;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(syncLock);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			target = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			syncLock = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x000A0234 File Offset: 0x0009E434
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351553, RefRangeEnd = 1351554, XrefRangeStart = 1351545, XrefRangeEnd = 1351553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target, ref bool initialized, ref Object syncLock, Func<T> valueFactory)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &initialized;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(syncLock);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			target = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			syncLock = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x000A02D4 File Offset: 0x0009E4D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351558, RefRangeEnd = 1351559, XrefRangeStart = 1351554, XrefRangeEnd = 1351558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitialized<T>(ref T target, ref Object syncLock, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(syncLock);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_byref_Object_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			target = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			syncLock = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x000A0368 File Offset: 0x0009E568
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1351568, RefRangeEnd = 1351569, XrefRangeStart = 1351559, XrefRangeEnd = 1351568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T EnsureInitializedCore<T>(ref T target, ref Object syncLock, Func<T> valueFactory) where T : class
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(target);
				ptr2 = &intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(syncLock);
			ptr3 = &intPtr2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueFactory);
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_byref_Object_Func_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			target = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			IntPtr intPtr6 = intPtr2;
			syncLock = ((intPtr6 == 0) ? null : new Object(intPtr6));
			return IL2CPP.PointerToValueGeneric<T>(intPtr3, false, true);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x000A03FC File Offset: 0x0009E5FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1351574, RefRangeEnd = 1351576, XrefRangeStart = 1351569, XrefRangeEnd = 1351574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object EnsureLockInitialized(ref Object syncLock)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(syncLock);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LazyInitializer.NativeMethodInfoPtr_EnsureLockInitialized_Private_Static_Object_byref_Object_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				syncLock = ((intPtr4 == 0) ? null : new Object(intPtr4));
				IntPtr intPtr5 = intPtr2;
				return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
			}
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0000845C File Offset: 0x0000665C
		public LazyInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400180B RID: 6155
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_0;

		// Token: 0x0400180C RID: 6156
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_0;

		// Token: 0x0400180D RID: 6157
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0;

		// Token: 0x0400180E RID: 6158
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0;

		// Token: 0x0400180F RID: 6159
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0;

		// Token: 0x04001810 RID: 6160
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0;

		// Token: 0x04001811 RID: 6161
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Object_Func_1_T_0;

		// Token: 0x04001812 RID: 6162
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Object_Func_1_T_0;

		// Token: 0x04001813 RID: 6163
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLockInitialized_Private_Static_Object_byref_Object_0;

		// Token: 0x020005FC RID: 1532
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_0<T>
		{
			// Token: 0x04004882 RID: 18562
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005FD RID: 1533
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_0<T>
		{
			// Token: 0x04004883 RID: 18563
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005FE RID: 1534
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x04004884 RID: 18564
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020005FF RID: 1535
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0<T>
		{
			// Token: 0x04004885 RID: 18565
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000600 RID: 1536
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0<T>
		{
			// Token: 0x04004886 RID: 18566
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000601 RID: 1537
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0<T>
		{
			// Token: 0x04004887 RID: 18567
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Boolean_byref_Object_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000602 RID: 1538
		private sealed class MethodInfoStoreGeneric_EnsureInitialized_Public_Static_T_byref_T_byref_Object_Func_1_T_0<T>
		{
			// Token: 0x04004888 RID: 18568
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitialized_Public_Static_T_byref_T_byref_Object_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000603 RID: 1539
		private sealed class MethodInfoStoreGeneric_EnsureInitializedCore_Private_Static_T_byref_T_byref_Object_Func_1_T_0<T>
		{
			// Token: 0x04004889 RID: 18569
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LazyInitializer.NativeMethodInfoPtr_EnsureInitializedCore_Private_Static_T_byref_T_byref_Object_Func_1_T_0, Il2CppClassPointerStore<LazyInitializer>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
