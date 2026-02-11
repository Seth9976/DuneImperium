using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace boardgames.menus
{
	// Token: 0x020001A8 RID: 424
	public static class OfflineMatchesHelper : Object
	{
		// Token: 0x060012E3 RID: 4835 RVA: 0x0005A89C File Offset: 0x00058A9C
		// Note: this type is marked as 'beforefieldinit'.
		static OfflineMatchesHelper()
		{
			Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus", "OfflineMatchesHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr);
			OfflineMatchesHelper.NativeMethodInfoPtr_loadOfflineMatches_Public_Static_List_1_OfflineMatches_1_T_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr, 100666067);
			OfflineMatchesHelper.NativeMethodInfoPtr_GetMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr, 100666068);
			OfflineMatchesHelper.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_SaveMetaData_SaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr, 100666069);
			OfflineMatchesHelper.NativeMethodInfoPtr_GetAllOfflineMatches_Public_Static_List_1_T_List_1_OfflineMatches_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr, 100666070);
			OfflineMatchesHelper.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Static_List_1_T_List_1_OfflineMatches_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr, 100666071);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x0005A930 File Offset: 0x00058B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518446, RefRangeEnd = 518447, XrefRangeStart = 518427, XrefRangeEnd = 518446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<OfflineMatches<T>> loadOfflineMatches<T>(Il2CppStringArray assetPaths) where T : MatchInitData
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetPaths);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesHelper.MethodInfoStoreGeneric_loadOfflineMatches_Public_Static_List_1_OfflineMatches_1_T_Il2CppStringArray_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<OfflineMatches<T>>>(intPtr3) : null;
			}
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0005A974 File Offset: 0x00058B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518453, RefRangeEnd = 518454, XrefRangeStart = 518447, XrefRangeEnd = 518453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetMatchInitData<T>(List<OfflineMatches<T>> offlineMatches, string scenarioName) where T : MatchInitData
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offlineMatches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(scenarioName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesHelper.MethodInfoStoreGeneric_GetMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012E6 RID: 4838 RVA: 0x0005A9C4 File Offset: 0x00058BC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518459, RefRangeEnd = 518460, XrefRangeStart = 518454, XrefRangeEnd = 518459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetSavedGameMatchInitData<T>(List<OfflineMatches<T>> offlineMatches, SaveMetaData metaData, SaveData data) where T : MatchInitData
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offlineMatches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metaData);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesHelper.MethodInfoStoreGeneric_GetSavedGameMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_SaveMetaData_SaveData_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x0005AA28 File Offset: 0x00058C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 518460, XrefRangeEnd = 518472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> GetAllOfflineMatches<T>(List<OfflineMatches<T>> offlineMatches) where T : MatchInitData
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offlineMatches);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesHelper.MethodInfoStoreGeneric_GetAllOfflineMatches_Public_Static_List_1_T_List_1_OfflineMatches_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
			}
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x0005AA6C File Offset: 0x00058C6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 518484, RefRangeEnd = 518485, XrefRangeStart = 518472, XrefRangeEnd = 518484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<T> GetOfflineMatchesOfType<T>(List<OfflineMatches<T>> offlineMatches, string type) where T : MatchInitData
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(offlineMatches);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OfflineMatchesHelper.MethodInfoStoreGeneric_GetOfflineMatchesOfType_Public_Static_List_1_T_List_1_OfflineMatches_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<T>>(intPtr3) : null;
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x0000AE38 File Offset: 0x00009038
		public OfflineMatchesHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_loadOfflineMatches_Public_Static_List_1_OfflineMatches_1_T_Il2CppStringArray_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_GetMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_String_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_SaveMetaData_SaveData_0;

		// Token: 0x04000BA4 RID: 2980
		private static readonly IntPtr NativeMethodInfoPtr_GetAllOfflineMatches_Public_Static_List_1_T_List_1_OfflineMatches_1_T_0;

		// Token: 0x04000BA5 RID: 2981
		private static readonly IntPtr NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Static_List_1_T_List_1_OfflineMatches_1_T_String_0;

		// Token: 0x02000398 RID: 920
		private sealed class MethodInfoStoreGeneric_loadOfflineMatches_Public_Static_List_1_OfflineMatches_1_T_Il2CppStringArray_0<T>
		{
			// Token: 0x04001B02 RID: 6914
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OfflineMatchesHelper.NativeMethodInfoPtr_loadOfflineMatches_Public_Static_List_1_OfflineMatches_1_T_Il2CppStringArray_0, Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000399 RID: 921
		private sealed class MethodInfoStoreGeneric_GetMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_String_0<T>
		{
			// Token: 0x04001B03 RID: 6915
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OfflineMatchesHelper.NativeMethodInfoPtr_GetMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_String_0, Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039A RID: 922
		private sealed class MethodInfoStoreGeneric_GetSavedGameMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_SaveMetaData_SaveData_0<T>
		{
			// Token: 0x04001B04 RID: 6916
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OfflineMatchesHelper.NativeMethodInfoPtr_GetSavedGameMatchInitData_Public_Static_T_List_1_OfflineMatches_1_T_SaveMetaData_SaveData_0, Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039B RID: 923
		private sealed class MethodInfoStoreGeneric_GetAllOfflineMatches_Public_Static_List_1_T_List_1_OfflineMatches_1_T_0<T>
		{
			// Token: 0x04001B05 RID: 6917
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OfflineMatchesHelper.NativeMethodInfoPtr_GetAllOfflineMatches_Public_Static_List_1_T_List_1_OfflineMatches_1_T_0, Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200039C RID: 924
		private sealed class MethodInfoStoreGeneric_GetOfflineMatchesOfType_Public_Static_List_1_T_List_1_OfflineMatches_1_T_String_0<T>
		{
			// Token: 0x04001B06 RID: 6918
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OfflineMatchesHelper.NativeMethodInfoPtr_GetOfflineMatchesOfType_Public_Static_List_1_T_List_1_OfflineMatches_1_T_String_0, Il2CppClassPointerStore<OfflineMatchesHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
