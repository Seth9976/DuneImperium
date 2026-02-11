using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000050 RID: 80
	public sealed class AsyncOperationHandle<TObject> : ValueType
	{
		// Token: 0x06000477 RID: 1143 RVA: 0x00016868 File Offset: 0x00014A68
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperationHandle()
		{
			Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "AsyncOperationHandle`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr);
			AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_InternalOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, "m_InternalOp");
			AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, "m_Version");
			AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, "m_LocationName");
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664055);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_LocationName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664056);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664057);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_op_Implicit_Public_Static_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664058);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_AsyncOperationBase_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664059);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664060);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664061);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664062);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664063);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664064);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664065);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664066);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664067);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664068);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664069);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_CompletedTypeless_Public_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664070);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_CompletedTypeless_Public_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664071);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_DebugName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664072);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664073);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664074);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664075);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664076);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664077);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_WaitForCompletion_Public_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664078);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_InternalOp_Internal_get_AsyncOperationBase_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664079);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664080);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664081);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664082);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664083);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664084);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664085);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Result_Public_get_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664086);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664087);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664088);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664089);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664090);
			AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, 100664091);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00016BF4 File Offset: 0x00014DF4
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00016C38 File Offset: 0x00014E38
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x00016C74 File Offset: 0x00014E74
		public unsafe string LocationName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_LocationName_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00016CBC File Offset: 0x00014EBC
		[CallerCount(135)]
		[CachedScanResults(RefRangeStart = 1142040, RefRangeEnd = 1142175, XrefRangeStart = 1142039, XrefRangeEnd = 1142040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AsyncOperationHandle(AsyncOperationHandle<TObject> obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(obj));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_op_Implicit_Public_Static_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle(intPtr);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00016D00 File Offset: 0x00014F00
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1142207, RefRangeEnd = 1142211, XrefRangeStart = 1142175, XrefRangeEnd = 1142207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(AsyncOperationBase<TObject> op)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_AsyncOperationBase_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00016D50 File Offset: 0x00014F50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142211, XrefRangeEnd = 1142219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadStatus GetDownloadStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00016D94 File Offset: 0x00014F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142219, XrefRangeEnd = 1142232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00016DE8 File Offset: 0x00014FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142232, XrefRangeEnd = 1142260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00016E38 File Offset: 0x00015038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142260, XrefRangeEnd = 1142283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, int version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00016E98 File Offset: 0x00015098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142283, XrefRangeEnd = 1142334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, string locationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00016EFC File Offset: 0x000150FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1142414, RefRangeEnd = 1142416, XrefRangeStart = 1142334, XrefRangeEnd = 1142414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00016F6C File Offset: 0x0001516C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142416, XrefRangeEnd = 1142420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<TObject> Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TObject>(intPtr);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00016FA8 File Offset: 0x000151A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1142445, RefRangeEnd = 1142446, XrefRangeStart = 1142420, XrefRangeEnd = 1142445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Completed(Action<AsyncOperationHandle<TObject>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00016FF0 File Offset: 0x000151F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1142455, RefRangeEnd = 1142456, XrefRangeStart = 1142446, XrefRangeEnd = 1142455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Completed(Action<AsyncOperationHandle<TObject>> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00017038 File Offset: 0x00015238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142456, XrefRangeEnd = 1142600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseHandleOnCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00017070 File Offset: 0x00015270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142600, XrefRangeEnd = 1142630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_CompletedTypeless_Public_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000170B8 File Offset: 0x000152B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142630, XrefRangeEnd = 1142650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_CompletedTypeless(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_CompletedTypeless_Public_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00017100 File Offset: 0x00015300
		public unsafe string DebugName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1142659, RefRangeEnd = 1142660, XrefRangeStart = 1142650, XrefRangeEnd = 1142659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_DebugName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001713C File Offset: 0x0001533C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142660, XrefRangeEnd = 1142674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00017184 File Offset: 0x00015384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142674, XrefRangeEnd = 1142693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000171CC File Offset: 0x000153CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142693, XrefRangeEnd = 1142704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00017214 File Offset: 0x00015414
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1142704, RefRangeEnd = 1142707, XrefRangeStart = 1142704, XrefRangeEnd = 1142704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AsyncOperationHandle<TObject> other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AsyncOperationHandle_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001726C File Offset: 0x0001546C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1142707, RefRangeEnd = 1142710, XrefRangeStart = 1142707, XrefRangeEnd = 1142707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000172B0 File Offset: 0x000154B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1142729, RefRangeEnd = 1142730, XrefRangeStart = 1142710, XrefRangeEnd = 1142729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TObject WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_WaitForCompletion_Public_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x000172F0 File Offset: 0x000154F0
		public unsafe AsyncOperationBase<TObject> InternalOp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142730, XrefRangeEnd = 1142731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_InternalOp_Internal_get_AsyncOperationBase_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperationBase<TObject>>(intPtr3) : null;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00017334 File Offset: 0x00015534
		public unsafe bool IsDone
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1142737, RefRangeEnd = 1142742, XrefRangeStart = 1142731, XrefRangeEnd = 1142737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00017378 File Offset: 0x00015578
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1142742, RefRangeEnd = 1142750, XrefRangeStart = 1142742, XrefRangeEnd = 1142742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x000173BC File Offset: 0x000155BC
		public unsafe Exception OperationException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142750, XrefRangeEnd = 1142753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00017400 File Offset: 0x00015600
		public unsafe float PercentComplete
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1142768, RefRangeEnd = 1142769, XrefRangeStart = 1142753, XrefRangeEnd = 1142768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00017444 File Offset: 0x00015644
		public unsafe int ReferenceCount
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1142772, RefRangeEnd = 1142773, XrefRangeStart = 1142769, XrefRangeEnd = 1142772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00017488 File Offset: 0x00015688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1142805, RefRangeEnd = 1142806, XrefRangeStart = 1142773, XrefRangeEnd = 1142805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x000174C0 File Offset: 0x000156C0
		public unsafe TObject Result
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 1142809, RefRangeEnd = 1142822, XrefRangeStart = 1142806, XrefRangeEnd = 1142809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Result_Public_get_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TObject>(intPtr, false, true);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00017500 File Offset: 0x00015700
		public unsafe AsyncOperationStatus Status
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1142825, RefRangeEnd = 1142828, XrefRangeStart = 1142822, XrefRangeEnd = 1142825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00017544 File Offset: 0x00015744
		public unsafe Task<TObject> Task
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142828, XrefRangeEnd = 1142842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_get_Task_Public_get_Task_1_TObject_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<TObject>>(intPtr3) : null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00017588 File Offset: 0x00015788
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142842, XrefRangeEnd = 1142848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000175CC File Offset: 0x000157CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142848, XrefRangeEnd = 1142850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00017610 File Offset: 0x00015810
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00003B1E File Offset: 0x00001D1E
		public AsyncOperationHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00003B27 File Offset: 0x00001D27
		public AsyncOperationHandle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr))
		{
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00017648 File Offset: 0x00015848
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00003B39 File Offset: 0x00001D39
		public unsafe AsyncOperationBase<TObject> m_InternalOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_InternalOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperationBase<TObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_InternalOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00017678 File Offset: 0x00015878
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00003B58 File Offset: 0x00001D58
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000176A0 File Offset: 0x000158A0
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00003B73 File Offset: 0x00001D73
		public unsafe string m_LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle<TObject>.NativeFieldInfoPtr_m_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalOp;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_m_LocationName;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_get_LocationName_Internal_get_String_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AsyncOperationHandle_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_AsyncOperationBase_1_TObject_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_add_CompletedTypeless_Public_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_remove_CompletedTypeless_Public_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Public_get_String_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_TObject_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalOp_Internal_get_AsyncOperationBase_1_TObject_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_TObject_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_TObject_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0200008F RID: 143
		[ObfuscatedName("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006F3 RID: 1779 RVA: 0x000204DC File Offset: 0x0001E6DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr);
				AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr, "<>9");
				AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr, "<>9__20_0");
				AsyncOperationHandle<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr, 100664093);
				AsyncOperationHandle<TObject>.__c.NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__20_0_Internal_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr, 100664094);
			}

			// Token: 0x060006F4 RID: 1780 RVA: 0x00020594 File Offset: 0x0001E794
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle<TObject>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x000205D0 File Offset: 0x0001E7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142038, XrefRangeEnd = 1142039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReleaseHandleOnCompletion_b__20_0(AsyncOperationHandle<TObject> op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle<TObject>.__c.NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__20_0_Internal_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x00004B58 File Offset: 0x00002D58
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700020E RID: 526
			// (get) Token: 0x060006F7 RID: 1783 RVA: 0x00020618 File Offset: 0x0001E818
			// (set) Token: 0x060006F8 RID: 1784 RVA: 0x00004B61 File Offset: 0x00002D61
			public unsafe static AsyncOperationHandle<TObject>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperationHandle<TObject>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x060006F9 RID: 1785 RVA: 0x00020640 File Offset: 0x0001E840
			// (set) Token: 0x060006FA RID: 1786 RVA: 0x00004B73 File Offset: 0x00002D73
			public unsafe static Action<AsyncOperationHandle<TObject>> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncOperationHandle<TObject>.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004E8 RID: 1256
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004E9 RID: 1257
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x040004EA RID: 1258
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EB RID: 1259
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__20_0_Internal_Void_AsyncOperationHandle_1_TObject_0;
		}
	}
}
