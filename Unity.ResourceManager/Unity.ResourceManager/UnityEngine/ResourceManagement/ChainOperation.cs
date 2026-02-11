using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.ResourceManagement
{
	// Token: 0x02000008 RID: 8
	public class ChainOperation<TObject, TObjectDependency> : AsyncOperationBase<TObject>
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00005FE4 File Offset: 0x000041E4
		// Note: this type is marked as 'beforefieldinit'.
		static ChainOperation()
		{
			Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "ChainOperation`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObjectDependency>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr);
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_DepOp");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_WrappedOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_WrappedOp");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_depStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_depStatus");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_wrapStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_wrapStatus");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_Callback");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_CachedOnWrappedCompleted");
			ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, "m_ReleaseDependenciesOnFailure");
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663337);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663338);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663339);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663340);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663341);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663342);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663343);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663344);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663345);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663346);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663347);
			ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr, 100663348);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000061E0 File Offset: 0x000043E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135726, XrefRangeEnd = 1135731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainOperation<TObject, TObjectDependency>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000049 RID: 73 RVA: 0x0000621C File Offset: 0x0000441C
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135731, XrefRangeEnd = 1135755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006260 File Offset: 0x00004460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135755, XrefRangeEnd = 1135760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000062B0 File Offset: 0x000044B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135764, RefRangeEnd = 1135765, XrefRangeStart = 1135760, XrefRangeEnd = 1135764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle<TObjectDependency> dependentOp, Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dependentOp));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006318 File Offset: 0x00004518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135765, XrefRangeEnd = 1135775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006360 File Offset: 0x00004560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135775, XrefRangeEnd = 1135779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000639C File Offset: 0x0000459C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135779, XrefRangeEnd = 1135790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWrappedCompleted(AsyncOperationHandle<TObject> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000063E4 File Offset: 0x000045E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135790, XrefRangeEnd = 1135794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006420 File Offset: 0x00004620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135794, XrefRangeEnd = 1135796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000645C File Offset: 0x0000465C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135796, XrefRangeEnd = 1135798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000064B4 File Offset: 0x000046B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135798, XrefRangeEnd = 1135804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDownloadStatus(HashSet<Object> visited = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000064F8 File Offset: 0x000046F8
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135804, XrefRangeEnd = 1135810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperation<TObject, TObjectDependency>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000220B File Offset: 0x0000040B
		public ChainOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00006540 File Offset: 0x00004740
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002214 File Offset: 0x00000414
		public AsyncOperationHandle<TObjectDependency> m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle<TObjectDependency>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObjectDependency>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObjectDependency>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00006570 File Offset: 0x00004770
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002242 File Offset: 0x00000442
		public AsyncOperationHandle<TObject> m_WrappedOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_WrappedOp);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_WrappedOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000059 RID: 89 RVA: 0x000065A0 File Offset: 0x000047A0
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002270 File Offset: 0x00000470
		public unsafe DownloadStatus m_depStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_depStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_depStatus)) = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000065C8 File Offset: 0x000047C8
		// (set) Token: 0x0600005C RID: 92 RVA: 0x0000228B File Offset: 0x0000048B
		public unsafe DownloadStatus m_wrapStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_wrapStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_wrapStatus)) = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005D RID: 93 RVA: 0x000065F0 File Offset: 0x000047F0
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000022A6 File Offset: 0x000004A6
		public unsafe Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>> m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AsyncOperationHandle<TObjectDependency>, AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00006620 File Offset: 0x00004820
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000022C5 File Offset: 0x000004C5
		public unsafe Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00006650 File Offset: 0x00004850
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000022E4 File Offset: 0x000004E4
		public unsafe bool m_ReleaseDependenciesOnFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperation<TObject, TObjectDependency>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure)) = value;
			}
		}

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_m_WrappedOp;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_m_depStatus;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_m_wrapStatus;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedOnWrappedCompleted;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_1_TObjectDependency_Func_2_AsyncOperationHandle_1_TObjectDependency_AsyncOperationHandle_1_TObject_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;
	}
}
