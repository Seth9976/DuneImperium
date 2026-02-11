using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000054 RID: 84
	public class GroupOperation : AsyncOperationBase<IList<AsyncOperationHandle>>
	{
		// Token: 0x060004D3 RID: 1235 RVA: 0x00018480 File Offset: 0x00016680
		// Note: this type is marked as 'beforefieldinit'.
		static GroupOperation()
		{
			Il2CppClassPointerStore<GroupOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "GroupOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr);
			GroupOperation.NativeFieldInfoPtr_m_InternalOnComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "m_InternalOnComplete");
			GroupOperation.NativeFieldInfoPtr_m_LoadedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "m_LoadedCount");
			GroupOperation.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "m_Settings");
			GroupOperation.NativeFieldInfoPtr_debugName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "debugName");
			GroupOperation.NativeFieldInfoPtr_k_MaxDisplayedLocationLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "k_MaxDisplayedLocationLength");
			GroupOperation.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "<UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key>k__BackingField");
			GroupOperation.NativeFieldInfoPtr_m_CachedDependencyLocations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, "m_CachedDependencyLocations");
			GroupOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664133);
			GroupOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664134);
			GroupOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664135);
			GroupOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664136);
			GroupOperation.NativeMethodInfoPtr_GetDependentOps_Internal_IList_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664137);
			GroupOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664138);
			GroupOperation.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664139);
			GroupOperation.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664140);
			GroupOperation.NativeMethodInfoPtr_DependenciesAreUnchanged_Private_Boolean_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664141);
			GroupOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664142);
			GroupOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664143);
			GroupOperation.NativeMethodInfoPtr_CompleteIfDependenciesComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664144);
			GroupOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664145);
			GroupOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664146);
			GroupOperation.NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664147);
			GroupOperation.NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_GroupOperationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664148);
			GroupOperation.NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr, 100664149);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00018690 File Offset: 0x00016890
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1143223, RefRangeEnd = 1143225, XrefRangeStart = 1143198, XrefRangeEnd = 1143223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GroupOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GroupOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x000186CC File Offset: 0x000168CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143225, XrefRangeEnd = 1143256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00018714 File Offset: 0x00016914
		// (set) Token: 0x060004D7 RID: 1239 RVA: 0x00018754 File Offset: 0x00016954
		public unsafe virtual IOperationCacheKey UnityEngine.ResourceManagement.AsyncOperations.ICachable.Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00018798 File Offset: 0x00016998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143256, XrefRangeEnd = 1143257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<AsyncOperationHandle> GetDependentOps()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_GetDependentOps_Internal_IList_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<AsyncOperationHandle>>(intPtr3) : null;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x000187D8 File Offset: 0x000169D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143257, XrefRangeEnd = 1143262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00018828 File Offset: 0x00016A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143262, XrefRangeEnd = 1143284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00018864 File Offset: 0x00016A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143284, XrefRangeEnd = 1143303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000188BC File Offset: 0x00016ABC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143324, RefRangeEnd = 1143325, XrefRangeStart = 1143303, XrefRangeEnd = 1143324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DependenciesAreUnchanged(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_DependenciesAreUnchanged_Private_Boolean_List_1_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x0001890C File Offset: 0x00016B0C
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143325, XrefRangeEnd = 1143366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00018950 File Offset: 0x00016B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143366, XrefRangeEnd = 1143400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001898C File Offset: 0x00016B8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1143428, RefRangeEnd = 1143430, XrefRangeStart = 1143400, XrefRangeEnd = 1143428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompleteIfDependenciesComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_CompleteIfDependenciesComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x000189C0 File Offset: 0x00016BC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143430, RefRangeEnd = 1143431, XrefRangeStart = 1143430, XrefRangeEnd = 1143430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000189FC File Offset: 0x00016BFC
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143431, XrefRangeEnd = 1143454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GroupOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00018A44 File Offset: 0x00016C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1143462, RefRangeEnd = 1143464, XrefRangeStart = 1143454, XrefRangeEnd = 1143462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(List<AsyncOperationHandle> operations, bool releaseDependenciesOnFailure = true, bool allowFailedDependencies = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseDependenciesOnFailure;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowFailedDependencies;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00018AA4 File Offset: 0x00016CA4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1143472, RefRangeEnd = 1143473, XrefRangeStart = 1143464, XrefRangeEnd = 1143472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(List<AsyncOperationHandle> operations, GroupOperation.GroupOperationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operations);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref settings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_GroupOperationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00018AF4 File Offset: 0x00016CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143473, XrefRangeEnd = 1143474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOperationCompleted(AsyncOperationHandle op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GroupOperation.NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00003C18 File Offset: 0x00001E18
		public GroupOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00018B3C File Offset: 0x00016D3C
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00003C21 File Offset: 0x00001E21
		public unsafe Action<AsyncOperationHandle> m_InternalOnComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_InternalOnComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_InternalOnComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00018B6C File Offset: 0x00016D6C
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00003C40 File Offset: 0x00001E40
		public unsafe int m_LoadedCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_LoadedCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_LoadedCount)) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00018B94 File Offset: 0x00016D94
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00003C5B File Offset: 0x00001E5B
		public unsafe GroupOperation.GroupOperationSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_Settings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_Settings)) = value;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00018BBC File Offset: 0x00016DBC
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00003C76 File Offset: 0x00001E76
		public unsafe string debugName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_debugName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_debugName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00018BE4 File Offset: 0x00016DE4
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00003C95 File Offset: 0x00001E95
		public unsafe static int k_MaxDisplayedLocationLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(GroupOperation.NativeFieldInfoPtr_k_MaxDisplayedLocationLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GroupOperation.NativeFieldInfoPtr_k_MaxDisplayedLocationLength, (void*)(&value));
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00018C00 File Offset: 0x00016E00
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00003CA3 File Offset: 0x00001EA3
		public unsafe IOperationCacheKey _UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOperationCacheKey>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00018C30 File Offset: 0x00016E30
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00003CC2 File Offset: 0x00001EC2
		public unsafe HashSet<string> m_CachedDependencyLocations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_CachedDependencyLocations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GroupOperation.NativeFieldInfoPtr_m_CachedDependencyLocations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalOnComplete;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadedCount;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x0400037A RID: 890
		private static readonly IntPtr NativeFieldInfoPtr_debugName;

		// Token: 0x0400037B RID: 891
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxDisplayedLocationLength;

		// Token: 0x0400037C RID: 892
		private static readonly IntPtr NativeFieldInfoPtr__UnityEngine_ResourceManagement_AsyncOperations_ICachable_Key_k__BackingField;

		// Token: 0x0400037D RID: 893
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedDependencyLocations;

		// Token: 0x0400037E RID: 894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400037F RID: 895
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000380 RID: 896
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_get_Key_Private_Virtual_Final_New_get_IOperationCacheKey_0;

		// Token: 0x04000381 RID: 897
		private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ResourceManagement_AsyncOperations_ICachable_set_Key_Private_Virtual_Final_New_set_Void_IOperationCacheKey_0;

		// Token: 0x04000382 RID: 898
		private static readonly IntPtr NativeMethodInfoPtr_GetDependentOps_Internal_IList_1_AsyncOperationHandle_0;

		// Token: 0x04000383 RID: 899
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x04000384 RID: 900
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0;

		// Token: 0x04000385 RID: 901
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x04000386 RID: 902
		private static readonly IntPtr NativeMethodInfoPtr_DependenciesAreUnchanged_Private_Boolean_List_1_AsyncOperationHandle_0;

		// Token: 0x04000387 RID: 903
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x04000388 RID: 904
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x04000389 RID: 905
		private static readonly IntPtr NativeMethodInfoPtr_CompleteIfDependenciesComplete_Private_Void_0;

		// Token: 0x0400038A RID: 906
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x0400038B RID: 907
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x0400038C RID: 908
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_Boolean_Boolean_0;

		// Token: 0x0400038D RID: 909
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_List_1_AsyncOperationHandle_GroupOperationSettings_0;

		// Token: 0x0400038E RID: 910
		private static readonly IntPtr NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperationHandle_0;

		// Token: 0x02000092 RID: 146
		[Flags]
		public enum GroupOperationSettings
		{
			// Token: 0x040004F2 RID: 1266
			None = 0,
			// Token: 0x040004F3 RID: 1267
			ReleaseDependenciesOnFailure = 1,
			// Token: 0x040004F4 RID: 1268
			AllowFailedDependencies = 2
		}
	}
}
