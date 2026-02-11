using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000016 RID: 22
	public class CleanBundleCacheOperation : AsyncOperationBase<bool>
	{
		// Token: 0x060001EE RID: 494 RVA: 0x0000E00C File Offset: 0x0000C20C
		// Note: this type is marked as 'beforefieldinit'.
		static CleanBundleCacheOperation()
		{
			Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "CleanBundleCacheOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr);
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_Addressables");
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_DepOp");
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_CacheDirsForRemoval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_CacheDirsForRemoval");
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_EnumerationThread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_EnumerationThread");
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_BaseCachePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_BaseCachePath");
			CleanBundleCacheOperation.NativeFieldInfoPtr_m_UseMultiThreading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, "m_UseMultiThreading");
			CleanBundleCacheOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663728);
			CleanBundleCacheOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663729);
			CleanBundleCacheOperation.NativeMethodInfoPtr_CompleteInternal_Public_Void_Boolean_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663730);
			CleanBundleCacheOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663731);
			CleanBundleCacheOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663732);
			CleanBundleCacheOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663733);
			CleanBundleCacheOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663734);
			CleanBundleCacheOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663735);
			CleanBundleCacheOperation.NativeMethodInfoPtr_RemoveCacheEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663736);
			CleanBundleCacheOperation.NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663737);
			CleanBundleCacheOperation.NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663738);
			CleanBundleCacheOperation.NativeMethodInfoPtr_GetCacheDirsInUse_Private_HashSet_1_String_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr, 100663739);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000E1A4 File Offset: 0x0000C3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162308, XrefRangeEnd = 1162313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanBundleCacheOperation(AddressablesImpl aa, bool forceSingleThreading)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanBundleCacheOperation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(aa);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forceSingleThreading;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000E200 File Offset: 0x0000C400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162313, XrefRangeEnd = 1162323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<bool> Start(AsyncOperationHandle<IList<AsyncOperationHandle>> depOp)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(depOp));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<bool>(intPtr);
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000E250 File Offset: 0x0000C450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162329, RefRangeEnd = 1162330, XrefRangeStart = 1162323, XrefRangeEnd = 1162329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteInternal(bool result, bool success, string errorMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref result;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref success;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_CompleteInternal_Public_Void_Boolean_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000E2B0 File Offset: 0x0000C4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162330, XrefRangeEnd = 1162344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanBundleCacheOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162344, XrefRangeEnd = 1162350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanBundleCacheOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000E334 File Offset: 0x0000C534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162350, XrefRangeEnd = 1162356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> dependencies)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanBundleCacheOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000E384 File Offset: 0x0000C584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162356, XrefRangeEnd = 1162376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanBundleCacheOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162376, XrefRangeEnd = 1162379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnityEngine_ResourceManagement_IUpdateReceiver_Update(float unscaledDeltaTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref unscaledDeltaTime;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000E400 File Offset: 0x0000C600
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1162404, RefRangeEnd = 1162407, XrefRangeStart = 1162379, XrefRangeEnd = 1162404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveCacheEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_RemoveCacheEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000E434 File Offset: 0x0000C634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162407, XrefRangeEnd = 1162411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetermineCacheDirsNotInUse(Object data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000E478 File Offset: 0x0000C678
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1162445, RefRangeEnd = 1162447, XrefRangeStart = 1162411, XrefRangeEnd = 1162445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetermineCacheDirsNotInUse(HashSet<string> cacheDirsInUse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cacheDirsInUse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_HashSet_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162523, RefRangeEnd = 1162524, XrefRangeStart = 1162447, XrefRangeEnd = 1162523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HashSet<string> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(catalogOps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanBundleCacheOperation.NativeMethodInfoPtr_GetCacheDirsInUse_Private_HashSet_1_String_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000280F File Offset: 0x00000A0F
		public CleanBundleCacheOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001FC RID: 508 RVA: 0x0000E50C File Offset: 0x0000C70C
		// (set) Token: 0x060001FD RID: 509 RVA: 0x00002818 File Offset: 0x00000A18
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001FE RID: 510 RVA: 0x0000E53C File Offset: 0x0000C73C
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00002837 File Offset: 0x00000A37
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0000E56C File Offset: 0x0000C76C
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00002865 File Offset: 0x00000A65
		public unsafe List<string> m_CacheDirsForRemoval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_CacheDirsForRemoval);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_CacheDirsForRemoval), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0000E59C File Offset: 0x0000C79C
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00002884 File Offset: 0x00000A84
		public unsafe Thread m_EnumerationThread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_EnumerationThread);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Thread>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_EnumerationThread), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000E5CC File Offset: 0x0000C7CC
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000028A3 File Offset: 0x00000AA3
		public unsafe string m_BaseCachePath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_BaseCachePath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_BaseCachePath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000028C2 File Offset: 0x00000AC2
		public unsafe bool m_UseMultiThreading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_UseMultiThreading);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanBundleCacheOperation.NativeFieldInfoPtr_m_UseMultiThreading)) = value;
			}
		}

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_m_CacheDirsForRemoval;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_m_EnumerationThread;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseCachePath;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_m_UseMultiThreading;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_AsyncOperationHandle_1_Boolean_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_CompleteInternal_Public_Void_Boolean_Boolean_String_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_IUpdateReceiver_Update_Private_Virtual_Final_New_Void_Single_0;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeMethodInfoPtr_RemoveCacheEntries_Private_Void_0;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_Object_0;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeMethodInfoPtr_DetermineCacheDirsNotInUse_Private_Void_HashSet_1_String_0;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_GetCacheDirsInUse_Private_HashSet_1_String_IList_1_AsyncOperationHandle_0;
	}
}
