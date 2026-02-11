using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;

namespace UnityEngine.ResourceManagement.AsyncOperations
{
	// Token: 0x02000051 RID: 81
	public sealed class AsyncOperationHandle : ValueType
	{
		// Token: 0x060004A5 RID: 1189 RVA: 0x000176C8 File Offset: 0x000158C8
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncOperationHandle()
		{
			Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.AsyncOperations", "AsyncOperationHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr);
			AsyncOperationHandle.NativeFieldInfoPtr_m_InternalOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, "m_InternalOp");
			AsyncOperationHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, "m_Version");
			AsyncOperationHandle.NativeFieldInfoPtr_m_LocationName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, "m_LocationName");
			AsyncOperationHandle.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664095);
			AsyncOperationHandle.NativeMethodInfoPtr_get_LocationName_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664096);
			AsyncOperationHandle.NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664097);
			AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664098);
			AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664099);
			AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664100);
			AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664101);
			AsyncOperationHandle.NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664102);
			AsyncOperationHandle.NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664103);
			AsyncOperationHandle.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664104);
			AsyncOperationHandle.NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664105);
			AsyncOperationHandle.NativeMethodInfoPtr_Convert_Public_AsyncOperationHandle_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664106);
			AsyncOperationHandle.NativeMethodInfoPtr_Equals_Public_Boolean_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664107);
			AsyncOperationHandle.NativeMethodInfoPtr_get_DebugName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664108);
			AsyncOperationHandle.NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664109);
			AsyncOperationHandle.NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664110);
			AsyncOperationHandle.NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664111);
			AsyncOperationHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664112);
			AsyncOperationHandle.NativeMethodInfoPtr_get_InternalOp_Private_get_IAsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664113);
			AsyncOperationHandle.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664114);
			AsyncOperationHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664115);
			AsyncOperationHandle.NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664116);
			AsyncOperationHandle.NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664117);
			AsyncOperationHandle.NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664118);
			AsyncOperationHandle.NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664119);
			AsyncOperationHandle.NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664120);
			AsyncOperationHandle.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664121);
			AsyncOperationHandle.NativeMethodInfoPtr_get_Result_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664122);
			AsyncOperationHandle.NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664123);
			AsyncOperationHandle.NativeMethodInfoPtr_get_Task_Public_get_Task_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664124);
			AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664125);
			AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664126);
			AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664127);
			AsyncOperationHandle.NativeMethodInfoPtr_WaitForCompletion_Public_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, 100664128);
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x000179DC File Offset: 0x00015BDC
		public unsafe int Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_Version_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00017A20 File Offset: 0x00015C20
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00017A5C File Offset: 0x00015C5C
		public unsafe string LocationName
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_LocationName_Internal_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00017AA4 File Offset: 0x00015CA4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1142856, RefRangeEnd = 1142865, XrefRangeStart = 1142850, XrefRangeEnd = 1142856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00017AF4 File Offset: 0x00015CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142865, XrefRangeEnd = 1142867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, int version)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00017B54 File Offset: 0x00015D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142867, XrefRangeEnd = 1142873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, string locationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locationName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00017BB8 File Offset: 0x00015DB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 310353, RefRangeEnd = 310356, XrefRangeStart = 310353, XrefRangeEnd = 310356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle(IAsyncOperation op, int version, string locationName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr))
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00017C28 File Offset: 0x00015E28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1142877, RefRangeEnd = 1142879, XrefRangeStart = 1142873, XrefRangeEnd = 1142877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle Acquire()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00017C64 File Offset: 0x00015E64
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1142884, RefRangeEnd = 1142887, XrefRangeStart = 1142879, XrefRangeEnd = 1142884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Completed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00017CAC File Offset: 0x00015EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142887, XrefRangeEnd = 1142892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Completed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00017CF4 File Offset: 0x00015EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142892, XrefRangeEnd = 1142912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseHandleOnCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00017D2C File Offset: 0x00015F2C
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1142915, RefRangeEnd = 1142927, XrefRangeStart = 1142912, XrefRangeEnd = 1142915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncOperationHandle<T> Convert<T>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.MethodInfoStoreGeneric_Convert_Public_AsyncOperationHandle_1_T_0<T>.Pointer, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<T>(intPtr);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00017D68 File Offset: 0x00015F68
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1142704, RefRangeEnd = 1142707, XrefRangeStart = 1142704, XrefRangeEnd = 1142707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AsyncOperationHandle other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_Equals_Public_Boolean_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00017DC0 File Offset: 0x00015FC0
		public unsafe string DebugName
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 1142936, RefRangeEnd = 1142945, XrefRangeStart = 1142927, XrefRangeEnd = 1142936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_DebugName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00017DFC File Offset: 0x00015FFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1142950, RefRangeEnd = 1142952, XrefRangeStart = 1142945, XrefRangeEnd = 1142950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00017E44 File Offset: 0x00016044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142952, XrefRangeEnd = 1142957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Destroyed(Action<AsyncOperationHandle> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00017E8C File Offset: 0x0001608C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1142963, RefRangeEnd = 1142965, XrefRangeStart = 1142957, XrefRangeEnd = 1142963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00017ED4 File Offset: 0x000160D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1142707, RefRangeEnd = 1142710, XrefRangeStart = 1142707, XrefRangeEnd = 1142710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00017F18 File Offset: 0x00016118
		public unsafe IAsyncOperation InternalOp
		{
			[CallerCount(29)]
			[CachedScanResults(RefRangeStart = 1142968, RefRangeEnd = 1142997, XrefRangeStart = 1142965, XrefRangeEnd = 1142968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_InternalOp_Private_get_IAsyncOperation_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncOperation>(intPtr3) : null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00017F5C File Offset: 0x0001615C
		public unsafe bool IsDone
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 1143004, RefRangeEnd = 1143021, XrefRangeStart = 1142997, XrefRangeEnd = 1143004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00017FA0 File Offset: 0x000161A0
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 1143022, RefRangeEnd = 1143053, XrefRangeStart = 1143021, XrefRangeEnd = 1143022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00017FE4 File Offset: 0x000161E4
		public unsafe Exception OperationException
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1143058, RefRangeEnd = 1143065, XrefRangeStart = 1143053, XrefRangeEnd = 1143058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00018028 File Offset: 0x00016228
		public unsafe float PercentComplete
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1143070, RefRangeEnd = 1143073, XrefRangeStart = 1143065, XrefRangeEnd = 1143070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001806C File Offset: 0x0001626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143073, XrefRangeEnd = 1143080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadStatus GetDownloadStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x000180B0 File Offset: 0x000162B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1143094, RefRangeEnd = 1143097, XrefRangeStart = 1143080, XrefRangeEnd = 1143094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadStatus InternalGetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00018104 File Offset: 0x00016304
		public unsafe int ReferenceCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143097, XrefRangeEnd = 1143102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00018148 File Offset: 0x00016348
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1143108, RefRangeEnd = 1143118, XrefRangeStart = 1143102, XrefRangeEnd = 1143108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00018180 File Offset: 0x00016380
		public unsafe Object Result
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1143123, RefRangeEnd = 1143145, XrefRangeStart = 1143118, XrefRangeEnd = 1143123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_Result_Public_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000181C4 File Offset: 0x000163C4
		public unsafe AsyncOperationStatus Status
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1143150, RefRangeEnd = 1143168, XrefRangeStart = 1143145, XrefRangeEnd = 1143150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00018208 File Offset: 0x00016408
		public unsafe Task<Object> Task
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143168, XrefRangeEnd = 1143173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_get_Task_Public_get_Task_1_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x0001824C File Offset: 0x0001644C
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(22)]
			[CachedScanResults(RefRangeStart = 1143123, RefRangeEnd = 1143145, XrefRangeStart = 1143123, XrefRangeEnd = 1143145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00018290 File Offset: 0x00016490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1143173, XrefRangeEnd = 1143174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool System_Collections_IEnumerator_MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000182D4 File Offset: 0x000164D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001830C File Offset: 0x0001650C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1143191, RefRangeEnd = 1143198, XrefRangeStart = 1143174, XrefRangeEnd = 1143191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object WaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.NativeMethodInfoPtr_WaitForCompletion_Public_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00003B92 File Offset: 0x00001D92
		public AsyncOperationHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00003B9B File Offset: 0x00001D9B
		public AsyncOperationHandle()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr))
		{
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00018350 File Offset: 0x00016550
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003BAD File Offset: 0x00001DAD
		public unsafe IAsyncOperation m_InternalOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_InternalOp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAsyncOperation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_InternalOp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00018380 File Offset: 0x00016580
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00003BCC File Offset: 0x00001DCC
		public unsafe int m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x000183A8 File Offset: 0x000165A8
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00003BE7 File Offset: 0x00001DE7
		public unsafe string m_LocationName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_LocationName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncOperationHandle.NativeFieldInfoPtr_m_LocationName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalOp;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeFieldInfoPtr_m_LocationName;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Internal_get_Int32_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_get_LocationName_Internal_get_String_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_set_LocationName_Internal_set_Void_String_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_String_0;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IAsyncOperation_Int32_String_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Acquire_Internal_AsyncOperationHandle_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_add_Completed_Public_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr_remove_Completed_Public_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000354 RID: 852
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseHandleOnCompletion_Public_Void_0;

		// Token: 0x04000355 RID: 853
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_AsyncOperationHandle_1_T_0;

		// Token: 0x04000356 RID: 854
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_AsyncOperationHandle_0;

		// Token: 0x04000357 RID: 855
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Public_get_String_0;

		// Token: 0x04000358 RID: 856
		private static readonly IntPtr NativeMethodInfoPtr_add_Destroyed_Public_add_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeMethodInfoPtr_remove_Destroyed_Public_rem_Void_Action_1_AsyncOperationHandle_0;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalOp_Private_get_IAsyncOperation_0;

		// Token: 0x0400035D RID: 861
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDone_Public_get_Boolean_0;

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeMethodInfoPtr_get_OperationException_Public_get_Exception_0;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentComplete_Public_get_Single_0;

		// Token: 0x04000361 RID: 865
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Public_DownloadStatus_0;

		// Token: 0x04000362 RID: 866
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetDownloadStatus_Internal_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x04000363 RID: 867
		private static readonly IntPtr NativeMethodInfoPtr_get_ReferenceCount_Internal_get_Int32_0;

		// Token: 0x04000364 RID: 868
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x04000365 RID: 869
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Object_0;

		// Token: 0x04000366 RID: 870
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_AsyncOperationStatus_0;

		// Token: 0x04000367 RID: 871
		private static readonly IntPtr NativeMethodInfoPtr_get_Task_Public_get_Task_1_Object_0;

		// Token: 0x04000368 RID: 872
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000369 RID: 873
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400036A RID: 874
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400036B RID: 875
		private static readonly IntPtr NativeMethodInfoPtr_WaitForCompletion_Public_Object_0;

		// Token: 0x02000090 RID: 144
		[ObfuscatedName("UnityEngine.ResourceManagement.AsyncOperations.AsyncOperationHandle+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060006FB RID: 1787 RVA: 0x00020668 File Offset: 0x0001E868
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr);
				AsyncOperationHandle.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr, "<>9");
				AsyncOperationHandle.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr, "<>9__16_0");
				AsyncOperationHandle.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr, 100664130);
				AsyncOperationHandle.__c.NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__16_0_Internal_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr, 100664131);
			}

			// Token: 0x060006FC RID: 1788 RVA: 0x000206E4 File Offset: 0x0001E8E4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncOperationHandle.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006FD RID: 1789 RVA: 0x00020720 File Offset: 0x0001E920
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1136628, RefRangeEnd = 1136630, XrefRangeStart = 1136628, XrefRangeEnd = 1136630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReleaseHandleOnCompletion_b__16_0(AsyncOperationHandle op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncOperationHandle.__c.NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__16_0_Internal_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006FE RID: 1790 RVA: 0x00004B85 File Offset: 0x00002D85
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x060006FF RID: 1791 RVA: 0x00020768 File Offset: 0x0001E968
			// (set) Token: 0x06000700 RID: 1792 RVA: 0x00004B8E File Offset: 0x00002D8E
			public unsafe static AsyncOperationHandle.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncOperationHandle.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncOperationHandle.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncOperationHandle.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x06000701 RID: 1793 RVA: 0x00020790 File Offset: 0x0001E990
			// (set) Token: 0x06000702 RID: 1794 RVA: 0x00004BA0 File Offset: 0x00002DA0
			public unsafe static Action<AsyncOperationHandle> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AsyncOperationHandle.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AsyncOperationHandle.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040004EC RID: 1260
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040004ED RID: 1261
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x040004EE RID: 1262
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040004EF RID: 1263
			private static readonly IntPtr NativeMethodInfoPtr__ReleaseHandleOnCompletion_b__16_0_Internal_Void_AsyncOperationHandle_0;
		}

		// Token: 0x02000091 RID: 145
		private sealed class MethodInfoStoreGeneric_Convert_Public_AsyncOperationHandle_1_T_0<T>
		{
			// Token: 0x040004F0 RID: 1264
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AsyncOperationHandle.NativeMethodInfoPtr_Convert_Public_AsyncOperationHandle_1_T_0, Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
