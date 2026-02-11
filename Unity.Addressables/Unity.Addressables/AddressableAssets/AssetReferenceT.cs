using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class AssetReferenceT<TObject> : AssetReference where TObject : Object
	{
		// Token: 0x06000197 RID: 407 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReferenceT()
		{
			Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReferenceT`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr);
			AssetReferenceT<TObject>.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr, 100663674);
			AssetReferenceT<TObject>.NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr, 100663675);
			AssetReferenceT<TObject>.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr, 100663676);
			AssetReferenceT<TObject>.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr, 100663677);
			AssetReferenceT<TObject>.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr, 100663678);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1161933, RefRangeEnd = 1161939, XrefRangeStart = 1161932, XrefRangeEnd = 1161933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReferenceT(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReferenceT<TObject>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceT<TObject>.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000CAE8 File Offset: 0x0000ACE8
		[CallerCount(0)]
		public unsafe AsyncOperationHandle<TObject> LoadAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReferenceT<TObject>.NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000CB20 File Offset: 0x0000AD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161939, XrefRangeEnd = 1161940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadAssetAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceT<TObject>.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000CB64 File Offset: 0x0000AD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161940, XrefRangeEnd = 1161946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceT<TObject>.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ValidateAsset(string mainAssetPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(mainAssetPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReferenceT<TObject>.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x000025BB File Offset: 0x000007BB
		public AssetReferenceT(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_Boolean_String_0;
	}
}
