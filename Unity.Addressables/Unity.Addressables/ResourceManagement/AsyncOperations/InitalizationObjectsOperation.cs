using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.AddressableAssets.Initialization;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000006 RID: 6
	public class InitalizationObjectsOperation : AsyncOperationBase<bool>
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00004DA8 File Offset: 0x00002FA8
		// Note: this type is marked as 'beforefieldinit'.
		static InitalizationObjectsOperation()
		{
			Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.ResourceManagement.AsyncOperations", "InitalizationObjectsOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr);
			InitalizationObjectsOperation.NativeFieldInfoPtr_m_RtdOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, "m_RtdOp");
			InitalizationObjectsOperation.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, "m_Addressables");
			InitalizationObjectsOperation.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, "m_DepOp");
			InitalizationObjectsOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_ResourceManagerRuntimeData_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663310);
			InitalizationObjectsOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663311);
			InitalizationObjectsOperation.NativeMethodInfoPtr_LogRuntimeWarnings_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663312);
			InitalizationObjectsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663313);
			InitalizationObjectsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663314);
			InitalizationObjectsOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663315);
			InitalizationObjectsOperation.NativeMethodInfoPtr__Execute_b__8_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr, 100663316);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00004EA0 File Offset: 0x000030A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157715, XrefRangeEnd = 1157719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle<ResourceManagerRuntimeData> rtdOp, AddressablesImpl addressables)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rtdOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(addressables);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitalizationObjectsOperation.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_ResourceManagerRuntimeData_AddressablesImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004EFC File Offset: 0x000030FC
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157719, XrefRangeEnd = 1157721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitalizationObjectsOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004F40 File Offset: 0x00003140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157721, XrefRangeEnd = 1157748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool LogRuntimeWarnings(string pathToBuildLogs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pathToBuildLogs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitalizationObjectsOperation.NativeMethodInfoPtr_LogRuntimeWarnings_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004F90 File Offset: 0x00003190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157748, XrefRangeEnd = 1157778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitalizationObjectsOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004FD8 File Offset: 0x000031D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157778, XrefRangeEnd = 1157847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitalizationObjectsOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005014 File Offset: 0x00003214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157847, XrefRangeEnd = 1157850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitalizationObjectsOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitalizationObjectsOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitalizationObjectsOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005050 File Offset: 0x00003250
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157850, XrefRangeEnd = 1157876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Execute_b__8_0(AsyncOperationHandle<IList<AsyncOperationHandle>> obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitalizationObjectsOperation.NativeMethodInfoPtr__Execute_b__8_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000020DF File Offset: 0x000002DF
		public InitalizationObjectsOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00005098 File Offset: 0x00003298
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000020E8 File Offset: 0x000002E8
		public AsyncOperationHandle<ResourceManagerRuntimeData> m_RtdOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_RtdOp);
				return new AsyncOperationHandle<ResourceManagerRuntimeData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<ResourceManagerRuntimeData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_RtdOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<ResourceManagerRuntimeData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000050C8 File Offset: 0x000032C8
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002116 File Offset: 0x00000316
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000050F8 File Offset: 0x000032F8
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002135 File Offset: 0x00000335
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitalizationObjectsOperation.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_m_RtdOp;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_ResourceManagerRuntimeData_AddressablesImpl_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_LogRuntimeWarnings_Internal_Boolean_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr__Execute_b__8_0_Private_Void_AsyncOperationHandle_1_IList_1_AsyncOperationHandle_0;
	}
}
