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
	// Token: 0x02000009 RID: 9
	public class ChainOperationTypelessDepedency<TObject> : AsyncOperationBase<TObject>
	{
		// Token: 0x06000063 RID: 99 RVA: 0x00006678 File Offset: 0x00004878
		// Note: this type is marked as 'beforefieldinit'.
		static ChainOperationTypelessDepedency()
		{
			Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement", "ChainOperationTypelessDepedency`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TObject>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr);
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_DepOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_DepOp");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_WrappedOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_WrappedOp");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_depStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_depStatus");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_wrapStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_wrapStatus");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_Callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_Callback");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_CachedOnWrappedCompleted");
			ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, "m_ReleaseDependenciesOnFailure");
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_WrappedOp_Internal_get_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663349);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663350);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663351);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663352);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663353);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663354);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663355);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663356);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663357);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663358);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663359);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663360);
			ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr, 100663361);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00006874 File Offset: 0x00004A74
		public unsafe AsyncOperationHandle<TObject> WrappedOp
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_WrappedOp_Internal_get_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new AsyncOperationHandle<TObject>(intPtr);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000068AC File Offset: 0x00004AAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135820, RefRangeEnd = 1135821, XrefRangeStart = 1135810, XrefRangeEnd = 1135820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChainOperationTypelessDepedency()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChainOperationTypelessDepedency<TObject>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000068E8 File Offset: 0x00004AE8
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135821, XrefRangeEnd = 1135831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000692C File Offset: 0x00004B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135831, XrefRangeEnd = 1135835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetDependencies(List<AsyncOperationHandle> deps)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(deps);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000697C File Offset: 0x00004B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1135852, RefRangeEnd = 1135853, XrefRangeStart = 1135835, XrefRangeEnd = 1135852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(AsyncOperationHandle dependentOp, Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> callback, bool releaseDependenciesOnFailure)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000069E4 File Offset: 0x00004BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135853, XrefRangeEnd = 1135861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool InvokeWaitForCompletion()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006A2C File Offset: 0x00004C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135861, XrefRangeEnd = 1135890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00006A68 File Offset: 0x00004C68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135890, XrefRangeEnd = 1135901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWrappedCompleted(AsyncOperationHandle<TObject> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006AB0 File Offset: 0x00004CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135901, XrefRangeEnd = 1135905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006AEC File Offset: 0x00004CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135905, XrefRangeEnd = 1135907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ReleaseDependencies()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006B28 File Offset: 0x00004D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135907, XrefRangeEnd = 1135909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DownloadStatus GetDownloadStatus(HashSet<Object> visited)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00006B80 File Offset: 0x00004D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135909, XrefRangeEnd = 1135915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDownloadStatus(HashSet<Object> visited = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visited);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00006BC4 File Offset: 0x00004DC4
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1135915, XrefRangeEnd = 1135921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChainOperationTypelessDepedency<TObject>.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000022FF File Offset: 0x000004FF
		public ChainOperationTypelessDepedency(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00006C0C File Offset: 0x00004E0C
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002308 File Offset: 0x00000508
		public AsyncOperationHandle m_DepOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_DepOp);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_DepOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00006C3C File Offset: 0x00004E3C
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00002336 File Offset: 0x00000536
		public AsyncOperationHandle<TObject> m_WrappedOp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_WrappedOp);
				return new AsyncOperationHandle<TObject>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_WrappedOp), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<TObject>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00006C6C File Offset: 0x00004E6C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002364 File Offset: 0x00000564
		public unsafe DownloadStatus m_depStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_depStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_depStatus)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00006C94 File Offset: 0x00004E94
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe DownloadStatus m_wrapStatus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_wrapStatus);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_wrapStatus)) = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00006CBC File Offset: 0x00004EBC
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000239A File Offset: 0x0000059A
		public unsafe Func<AsyncOperationHandle, AsyncOperationHandle<TObject>> m_Callback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_Callback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AsyncOperationHandle, AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_Callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x0600007D RID: 125 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe Action<AsyncOperationHandle<TObject>> m_CachedOnWrappedCompleted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<TObject>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_CachedOnWrappedCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00006D1C File Offset: 0x00004F1C
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe bool m_ReleaseDependenciesOnFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChainOperationTypelessDepedency<TObject>.NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure)) = value;
			}
		}

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_m_DepOp;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_m_WrappedOp;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeFieldInfoPtr_m_depStatus;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeFieldInfoPtr_m_wrapStatus;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr_m_Callback;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedOnWrappedCompleted;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr_m_ReleaseDependenciesOnFailure;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_get_WrappedOp_Internal_get_AsyncOperationHandle_1_TObject_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_GetDependencies_Public_Virtual_Void_List_1_AsyncOperationHandle_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_AsyncOperationHandle_Func_2_AsyncOperationHandle_AsyncOperationHandle_1_TObject_Boolean_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_OnWrappedCompleted_Private_Void_AsyncOperationHandle_1_TObject_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseDependencies_Internal_Virtual_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetDownloadStatus_Internal_Virtual_DownloadStatus_HashSet_1_Object_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDownloadStatus_Private_Void_HashSet_1_Object_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;
	}
}
