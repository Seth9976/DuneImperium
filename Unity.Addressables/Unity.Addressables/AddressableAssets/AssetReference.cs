using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000013 RID: 19
	[Serializable]
	public class AssetReference : Object
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x0000CFA8 File Offset: 0x0000B1A8
		// Note: this type is marked as 'beforefieldinit'.
		static AssetReference()
		{
			Il2CppClassPointerStore<AssetReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "AssetReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReference>.NativeClassPtr);
			AssetReference.NativeFieldInfoPtr_m_AssetGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, "m_AssetGUID");
			AssetReference.NativeFieldInfoPtr_m_SubObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, "m_SubObjectName");
			AssetReference.NativeFieldInfoPtr_m_SubObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, "m_SubObjectType");
			AssetReference.NativeFieldInfoPtr_m_Operation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, "m_Operation");
			AssetReference.NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663688);
			AssetReference.NativeMethodInfoPtr_set_OperationHandle_Internal_set_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663689);
			AssetReference.NativeMethodInfoPtr_get_RuntimeKey_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663690);
			AssetReference.NativeMethodInfoPtr_get_AssetGUID_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663691);
			AssetReference.NativeMethodInfoPtr_get_SubObjectName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663692);
			AssetReference.NativeMethodInfoPtr_set_SubObjectName_Public_Virtual_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663693);
			AssetReference.NativeMethodInfoPtr_get_SubOjbectType_Internal_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663694);
			AssetReference.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663695);
			AssetReference.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663696);
			AssetReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663697);
			AssetReference.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663698);
			AssetReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663699);
			AssetReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663700);
			AssetReference.NativeMethodInfoPtr_CreateFailedOperation_Private_Static_AsyncOperationHandle_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663701);
			AssetReference.NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663702);
			AssetReference.NativeMethodInfoPtr_LoadScene_Public_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663703);
			AssetReference.NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663704);
			AssetReference.NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663705);
			AssetReference.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663706);
			AssetReference.NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_LoadSceneMode_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663707);
			AssetReference.NativeMethodInfoPtr_UnLoadScene_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663708);
			AssetReference.NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663709);
			AssetReference.NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663710);
			AssetReference.NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663711);
			AssetReference.NativeMethodInfoPtr_ReleaseAsset_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663712);
			AssetReference.NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_New_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663713);
			AssetReference.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663714);
			AssetReference.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReference>.NativeClassPtr, 100663715);
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000D258 File Offset: 0x0000B458
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000D290 File Offset: 0x0000B490
		public unsafe AsyncOperationHandle OperationHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_set_OperationHandle_Internal_set_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public unsafe virtual Object RuntimeKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161965, XrefRangeEnd = 1161970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_get_RuntimeKey_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x0000D324 File Offset: 0x0000B524
		public unsafe virtual string AssetGUID
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_get_AssetGUID_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000D368 File Offset: 0x0000B568
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000D3AC File Offset: 0x0000B5AC
		public unsafe virtual string SubObjectName
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_get_SubObjectName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_set_SubObjectName_Public_Virtual_New_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000D3FC File Offset: 0x0000B5FC
		public unsafe virtual Type SubOjbectType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161970, XrefRangeEnd = 1161979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_get_SubOjbectType_Internal_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000D448 File Offset: 0x0000B648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161979, XrefRangeEnd = 1161980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000D484 File Offset: 0x0000B684
		public unsafe bool IsDone
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161980, XrefRangeEnd = 1161981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161981, XrefRangeEnd = 1161986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1161992, RefRangeEnd = 1161993, XrefRangeStart = 1161986, XrefRangeEnd = 1161992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReference(string guid)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssetReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001BF RID: 447 RVA: 0x0000D548 File Offset: 0x0000B748
		public unsafe virtual Object Asset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161993, XrefRangeEnd = 1161997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_get_Asset_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000D594 File Offset: 0x0000B794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1161997, XrefRangeEnd = 1162002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162002, XrefRangeEnd = 1162019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperationHandle<T> CreateFailedOperation<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.MethodInfoStoreGeneric_CreateFailedOperation_Private_Static_AsyncOperationHandle_1_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<T>(intPtr);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000D604 File Offset: 0x0000B804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162019, XrefRangeEnd = 1162021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> LoadAsset<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.MethodInfoStoreGeneric_LoadAsset_Public_AsyncOperationHandle_1_TObject_0<TObject>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000D63C File Offset: 0x0000B83C
		[CallerCount(0)]
		public unsafe AsyncOperationHandle<SceneInstance> LoadScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_LoadScene_Public_AsyncOperationHandle_1_SceneInstance_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000D674 File Offset: 0x0000B874
		[CallerCount(0)]
		public unsafe AsyncOperationHandle<GameObject> Instantiate(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		[CallerCount(0)]
		public unsafe AsyncOperationHandle<GameObject> Instantiate(Transform parent = null, bool instantiateInWorldSpace = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssetReference.NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000D730 File Offset: 0x0000B930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162021, XrefRangeEnd = 1162036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<TObject> LoadAssetAsync<TObject>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.MethodInfoStoreGeneric_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0<TObject>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000D774 File Offset: 0x0000B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162036, XrefRangeEnd = 1162052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> LoadSceneAsync(LoadSceneMode loadMode = LoadSceneMode.Single, bool activateOnLoad = true, int priority = 100)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref loadMode;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref activateOnLoad;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_LoadSceneMode_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000D7E0 File Offset: 0x0000B9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162052, XrefRangeEnd = 1162063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<SceneInstance> UnLoadScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_UnLoadScene_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<SceneInstance>(intPtr);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000D824 File Offset: 0x0000BA24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162063, XrefRangeEnd = 1162067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<GameObject> InstantiateAsync(Vector3 position, Quaternion rotation, Transform parent = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000D894 File Offset: 0x0000BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162067, XrefRangeEnd = 1162071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AsyncOperationHandle<GameObject> InstantiateAsync(Transform parent = null, bool instantiateInWorldSpace = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instantiateInWorldSpace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Transform_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<GameObject>(intPtr);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162071, XrefRangeEnd = 1162074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RuntimeKeyIsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0000D940 File Offset: 0x0000BB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162074, XrefRangeEnd = 1162078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseAsset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_ReleaseAsset_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0000D97C File Offset: 0x0000BB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162078, XrefRangeEnd = 1162097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ReleaseInstance(GameObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_New_Void_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000D9CC File Offset: 0x0000BBCC
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateAsset(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000DA24 File Offset: 0x0000BC24
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ValidateAsset(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssetReference.NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000026DE File Offset: 0x000008DE
		public AssetReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x0000DA7C File Offset: 0x0000BC7C
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x000026E7 File Offset: 0x000008E7
		public unsafe string m_AssetGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_AssetGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_AssetGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000DAA4 File Offset: 0x0000BCA4
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00002706 File Offset: 0x00000906
		public unsafe string m_SubObjectName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_SubObjectName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_SubObjectName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000DACC File Offset: 0x0000BCCC
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00002725 File Offset: 0x00000925
		public unsafe string m_SubObjectType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_SubObjectType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_SubObjectType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000DAF4 File Offset: 0x0000BCF4
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00002744 File Offset: 0x00000944
		public AsyncOperationHandle m_Operation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_Operation);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssetReference.NativeFieldInfoPtr_m_Operation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeFieldInfoPtr_m_AssetGUID;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeFieldInfoPtr_m_SubObjectName;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeFieldInfoPtr_m_SubObjectType;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeFieldInfoPtr_m_Operation;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationHandle_Public_get_AsyncOperationHandle_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_set_OperationHandle_Internal_set_Void_AsyncOperationHandle_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_get_RuntimeKey_Public_Virtual_New_get_Object_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_get_AssetGUID_Public_Virtual_New_get_String_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_get_SubObjectName_Public_Virtual_New_get_String_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_set_SubObjectName_Public_Virtual_New_set_Void_String_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_get_SubOjbectType_Internal_Virtual_New_get_Type_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_get_Asset_Public_Virtual_New_get_Object_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000173 RID: 371
		private static readonly IntPtr NativeMethodInfoPtr_CreateFailedOperation_Private_Static_AsyncOperationHandle_1_T_0;

		// Token: 0x04000174 RID: 372
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000175 RID: 373
		private static readonly IntPtr NativeMethodInfoPtr_LoadScene_Public_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x04000176 RID: 374
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0;

		// Token: 0x04000177 RID: 375
		private static readonly IntPtr NativeMethodInfoPtr_Instantiate_Public_AsyncOperationHandle_1_GameObject_Transform_Boolean_0;

		// Token: 0x04000178 RID: 376
		private static readonly IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_LoadSceneAsync_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_LoadSceneMode_Boolean_Int32_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_UnLoadScene_Public_Virtual_New_AsyncOperationHandle_1_SceneInstance_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Vector3_Quaternion_Transform_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_InstantiateAsync_Public_Virtual_New_AsyncOperationHandle_1_GameObject_Transform_Boolean_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeKeyIsValid_Public_Virtual_New_Boolean_0;

		// Token: 0x0400017E RID: 382
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseAsset_Public_Virtual_New_Void_0;

		// Token: 0x0400017F RID: 383
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseInstance_Public_Virtual_New_Void_GameObject_0;

		// Token: 0x04000180 RID: 384
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_Object_0;

		// Token: 0x04000181 RID: 385
		private static readonly IntPtr NativeMethodInfoPtr_ValidateAsset_Public_Virtual_New_Boolean_String_0;

		// Token: 0x02000073 RID: 115
		private sealed class MethodInfoStoreGeneric_CreateFailedOperation_Private_Static_AsyncOperationHandle_1_T_0<T>
		{
			// Token: 0x04000375 RID: 885
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetReference.NativeMethodInfoPtr_CreateFailedOperation_Private_Static_AsyncOperationHandle_1_T_0, Il2CppClassPointerStore<AssetReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000074 RID: 116
		private sealed class MethodInfoStoreGeneric_LoadAsset_Public_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000376 RID: 886
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetReference.NativeMethodInfoPtr_LoadAsset_Public_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AssetReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}

		// Token: 0x02000075 RID: 117
		private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0<TObject>
		{
			// Token: 0x04000377 RID: 887
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AssetReference.NativeMethodInfoPtr_LoadAssetAsync_Public_Virtual_New_AsyncOperationHandle_1_TObject_0, Il2CppClassPointerStore<AssetReference>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) }))));
		}
	}
}
