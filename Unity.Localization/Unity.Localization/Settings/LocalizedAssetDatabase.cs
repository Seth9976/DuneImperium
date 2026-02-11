using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x0200008E RID: 142
	[Serializable]
	public class LocalizedAssetDatabase : LocalizedDatabase<AssetTable, AssetTableEntry>
	{
		// Token: 0x060006E1 RID: 1761 RVA: 0x0002372C File Offset: 0x0002192C
		// Note: this type is marked as 'beforefieldinit'.
		static LocalizedAssetDatabase()
		{
			Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "LocalizedAssetDatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr);
			LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664544);
			LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAsset_Public_TObject_TableEntryReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664545);
			LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664546);
			LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAsset_Public_Virtual_New_TObject_TableReference_TableEntryReference_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664547);
			LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsyncInternal_Protected_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664548);
			LocalizedAssetDatabase.NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_Void_AssetTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664549);
			LocalizedAssetDatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr, 100664550);
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x000237E8 File Offset: 0x000219E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074365, XrefRangeEnd = 1074370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetDatabase.MethodInfoStoreGeneric_GetLocalizedAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_Locale_FallbackBehavior_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00023858 File Offset: 0x00021A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074370, XrefRangeEnd = 1074376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TObject GetLocalizedAsset<TObject>(TableEntryReference tableEntryReference, Locale locale = null) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetDatabase.MethodInfoStoreGeneric_GetLocalizedAsset_Public_TObject_TableEntryReference_Locale_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x000238BC File Offset: 0x00021ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074376, XrefRangeEnd = 1074378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsync<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetDatabase.MethodInfoStoreGeneric_GetLocalizedAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0002394C File Offset: 0x00021B4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074378, XrefRangeEnd = 1074381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TObject GetLocalizedAsset<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetDatabase.MethodInfoStoreGeneric_GetLocalizedAsset_Public_Virtual_New_TObject_TableReference_TableEntryReference_Locale_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000239D0 File Offset: 0x00021BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074381, XrefRangeEnd = 1074395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> GetLocalizedAssetAsyncInternal<TObject>(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings) where TObject : Object
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableReference));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tableEntryReference));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fallbackBehavior;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetDatabase.MethodInfoStoreGeneric_GetLocalizedAssetAsyncInternal_Protected_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00023A60 File Offset: 0x00021C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074395, XrefRangeEnd = 1074397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseTableContents(AssetTable table)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LocalizedAssetDatabase.NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_Void_AssetTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00023AB0 File Offset: 0x00021CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1074397, XrefRangeEnd = 1074403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalizedAssetDatabase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalizedAssetDatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00004A00 File Offset: 0x00002C00
		public LocalizedAssetDatabase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_Locale_FallbackBehavior_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedAsset_Public_TObject_TableEntryReference_Locale_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedAsset_Public_Virtual_New_TObject_TableReference_TableEntryReference_Locale_0;

		// Token: 0x040004E2 RID: 1250
		private static readonly IntPtr NativeMethodInfoPtr_GetLocalizedAssetAsyncInternal_Protected_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0;

		// Token: 0x040004E3 RID: 1251
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseTableContents_Internal_Virtual_Void_AssetTable_0;

		// Token: 0x040004E4 RID: 1252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000156 RID: 342
		private sealed class MethodInfoStoreGeneric_GetLocalizedAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_Locale_FallbackBehavior_0<TObject>
		{
			// Token: 0x04000A50 RID: 2640
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_AsyncOperationHandle_1_TObject_TableEntryReference_Locale_FallbackBehavior_0, Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000157 RID: 343
		private sealed class MethodInfoStoreGeneric_GetLocalizedAsset_Public_TObject_TableEntryReference_Locale_0<TObject>
		{
			// Token: 0x04000A51 RID: 2641
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAsset_Public_TObject_TableEntryReference_Locale_0, Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000158 RID: 344
		private sealed class MethodInfoStoreGeneric_GetLocalizedAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0<TObject>
		{
			// Token: 0x04000A52 RID: 2642
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0, Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000159 RID: 345
		private sealed class MethodInfoStoreGeneric_GetLocalizedAsset_Public_Virtual_New_TObject_TableReference_TableEntryReference_Locale_0<TObject>
		{
			// Token: 0x04000A53 RID: 2643
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAsset_Public_Virtual_New_TObject_TableReference_TableEntryReference_Locale_0, Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x0200015A RID: 346
		private sealed class MethodInfoStoreGeneric_GetLocalizedAssetAsyncInternal_Protected_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0<TObject>
		{
			// Token: 0x04000A54 RID: 2644
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LocalizedAssetDatabase.NativeMethodInfoPtr_GetLocalizedAssetAsyncInternal_Protected_Virtual_New_AsyncOperationHandle_1_TObject_TableReference_TableEntryReference_Locale_FallbackBehavior_0, Il2CppClassPointerStore<LocalizedAssetDatabase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
