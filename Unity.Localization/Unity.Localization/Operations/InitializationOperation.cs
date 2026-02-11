using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	// Token: 0x020000B6 RID: 182
	public class InitializationOperation : WaitForCurrentOperationAsyncOperationBase<LocalizationSettings>
	{
		// Token: 0x06000965 RID: 2405 RVA: 0x0002D364 File Offset: 0x0002B564
		// Note: this type is marked as 'beforefieldinit'.
		static InitializationOperation()
		{
			Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Operations", "InitializationOperation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr);
			InitializationOperation.NativeFieldInfoPtr_m_UnloadBundlesOperationHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_UnloadBundlesOperationHandle");
			InitializationOperation.NativeFieldInfoPtr_m_LoadLocales = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_LoadLocales");
			InitializationOperation.NativeFieldInfoPtr_k_LocaleError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "k_LocaleError");
			InitializationOperation.NativeFieldInfoPtr_k_PreloadAssetTablesError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "k_PreloadAssetTablesError");
			InitializationOperation.NativeFieldInfoPtr_k_PreloadStringTablesError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "k_PreloadStringTablesError");
			InitializationOperation.NativeFieldInfoPtr_m_LoadLocalesCompletedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_LoadLocalesCompletedAction");
			InitializationOperation.NativeFieldInfoPtr_m_FinishPreloadingTablesAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_FinishPreloadingTablesAction");
			InitializationOperation.NativeFieldInfoPtr_m_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_Settings");
			InitializationOperation.NativeFieldInfoPtr_m_LoadDatabasesOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_LoadDatabasesOperations");
			InitializationOperation.NativeFieldInfoPtr_m_PreloadDatabasesOperation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_PreloadDatabasesOperation");
			InitializationOperation.NativeFieldInfoPtr_m_RemainingSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "m_RemainingSteps");
			InitializationOperation.NativeFieldInfoPtr_k_PreloadSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "k_PreloadSteps");
			InitializationOperation.NativeFieldInfoPtr_Pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "Pool");
			InitializationOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664916);
			InitializationOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664917);
			InitializationOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664918);
			InitializationOperation.NativeMethodInfoPtr_Init_Public_Void_LocalizationSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664919);
			InitializationOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664920);
			InitializationOperation.NativeMethodInfoPtr_LoadLocales_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664921);
			InitializationOperation.NativeMethodInfoPtr_CheckOperationSucceeded_Private_Boolean_AsyncOperationHandle_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664922);
			InitializationOperation.NativeMethodInfoPtr_LoadLocalesCompleted_Private_Void_AsyncOperationHandle_1_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664923);
			InitializationOperation.NativeMethodInfoPtr_PreloadTables_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664924);
			InitializationOperation.NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664925);
			InitializationOperation.NativeMethodInfoPtr_PostInitializeExtensions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664926);
			InitializationOperation.NativeMethodInfoPtr_FinishInitializing_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664927);
			InitializationOperation.NativeMethodInfoPtr_FinishInitializing_Private_Void_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664928);
			InitializationOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664929);
			InitializationOperation.NativeMethodInfoPtr___ctor_b__18_0_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664931);
			InitializationOperation.NativeMethodInfoPtr___ctor_b__18_1_Private_Void_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, 100664932);
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0002D5D8 File Offset: 0x0002B7D8
		public unsafe override float Progress
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077581, XrefRangeEnd = 1077586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0002D620 File Offset: 0x0002B820
		public unsafe override string DebugName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077586, XrefRangeEnd = 1077588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x0002D664 File Offset: 0x0002B864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077588, XrefRangeEnd = 1077618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitializationOperation()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0002D6A0 File Offset: 0x0002B8A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077621, RefRangeEnd = 1077622, XrefRangeStart = 1077618, XrefRangeEnd = 1077621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init(LocalizationSettings settings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_Init_Public_Void_LocalizationSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0002D6E4 File Offset: 0x0002B8E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077622, XrefRangeEnd = 1077642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0002D720 File Offset: 0x0002B920
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1077658, RefRangeEnd = 1077660, XrefRangeStart = 1077642, XrefRangeEnd = 1077658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLocales()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadLocales_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0002D754 File Offset: 0x0002B954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077660, XrefRangeEnd = 1077661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckOperationSucceeded(AsyncOperationHandle handle, string errorMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(errorMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_CheckOperationSucceeded_Private_Boolean_AsyncOperationHandle_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x0002D7B8 File Offset: 0x0002B9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077661, XrefRangeEnd = 1077670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLocalesCompleted(AsyncOperationHandle<Locale> operationHandle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(operationHandle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_LoadLocalesCompleted_Private_Void_AsyncOperationHandle_1_Locale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x0002D800 File Offset: 0x0002BA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077670, XrefRangeEnd = 1077693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadTables()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_PreloadTables_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0002D834 File Offset: 0x0002BA34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1077707, RefRangeEnd = 1077709, XrefRangeStart = 1077693, XrefRangeEnd = 1077707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PreloadTablesCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0002D868 File Offset: 0x0002BA68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1077740, RefRangeEnd = 1077741, XrefRangeStart = 1077709, XrefRangeEnd = 1077740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PostInitializeExtensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_PostInitializeExtensions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002D89C File Offset: 0x0002BA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077741, XrefRangeEnd = 1077745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitializing(AsyncOperationHandle op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(op));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_FinishInitializing_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x0002D8E4 File Offset: 0x0002BAE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1077752, RefRangeEnd = 1077756, XrefRangeStart = 1077745, XrefRangeEnd = 1077752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishInitializing(bool success, string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref success;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(error);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr_FinishInitializing_Private_Void_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x0002D934 File Offset: 0x0002BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077756, XrefRangeEnd = 1077767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002D970 File Offset: 0x0002BB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077767, XrefRangeEnd = 1077768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__18_0(AsyncOperationHandle _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr___ctor_b__18_0_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077768, XrefRangeEnd = 1077789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__18_1(AsyncOperationHandle _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.NativeMethodInfoPtr___ctor_b__18_1_Private_Void_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00005B0B File Offset: 0x00003D0B
		public InitializationOperation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x0002DA00 File Offset: 0x0002BC00
		// (set) Token: 0x06000978 RID: 2424 RVA: 0x00005B14 File Offset: 0x00003D14
		public AsyncOperationHandle m_UnloadBundlesOperationHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_UnloadBundlesOperationHandle);
				return new AsyncOperationHandle(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_UnloadBundlesOperationHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0002DA30 File Offset: 0x0002BC30
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x00005B42 File Offset: 0x00003D42
		public unsafe Action<AsyncOperationHandle> m_LoadLocales
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadLocales);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadLocales), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x0600097B RID: 2427 RVA: 0x0002DA60 File Offset: 0x0002BC60
		// (set) Token: 0x0600097C RID: 2428 RVA: 0x00005B61 File Offset: 0x00003D61
		public unsafe static string k_LocaleError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitializationOperation.NativeFieldInfoPtr_k_LocaleError, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationOperation.NativeFieldInfoPtr_k_LocaleError, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x0600097D RID: 2429 RVA: 0x0002DA80 File Offset: 0x0002BC80
		// (set) Token: 0x0600097E RID: 2430 RVA: 0x00005B73 File Offset: 0x00003D73
		public unsafe static string k_PreloadAssetTablesError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadAssetTablesError, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadAssetTablesError, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0002DAA0 File Offset: 0x0002BCA0
		// (set) Token: 0x06000980 RID: 2432 RVA: 0x00005B85 File Offset: 0x00003D85
		public unsafe static string k_PreloadStringTablesError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadStringTablesError, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadStringTablesError, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002DAC0 File Offset: 0x0002BCC0
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x00005B97 File Offset: 0x00003D97
		public unsafe Action<AsyncOperationHandle<Locale>> m_LoadLocalesCompletedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadLocalesCompletedAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle<Locale>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadLocalesCompletedAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0002DAF0 File Offset: 0x0002BCF0
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x00005BB6 File Offset: 0x00003DB6
		public unsafe Action<AsyncOperationHandle> m_FinishPreloadingTablesAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_FinishPreloadingTablesAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_FinishPreloadingTablesAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0002DB20 File Offset: 0x0002BD20
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x00005BD5 File Offset: 0x00003DD5
		public unsafe LocalizationSettings m_Settings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Settings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizationSettings>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_Settings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0002DB50 File Offset: 0x0002BD50
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public unsafe List<AsyncOperationHandle> m_LoadDatabasesOperations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadDatabasesOperations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperationHandle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_LoadDatabasesOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x0002DB80 File Offset: 0x0002BD80
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00005C13 File Offset: 0x00003E13
		public AsyncOperationHandle<IList<AsyncOperationHandle>> m_PreloadDatabasesOperation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_PreloadDatabasesOperation);
				return new AsyncOperationHandle<IList<AsyncOperationHandle>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_PreloadDatabasesOperation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncOperationHandle<IList<AsyncOperationHandle>>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x0002DBB0 File Offset: 0x0002BDB0
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00005C41 File Offset: 0x00003E41
		public unsafe int m_RemainingSteps
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_RemainingSteps);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.NativeFieldInfoPtr_m_RemainingSteps)) = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x0002DBD8 File Offset: 0x0002BDD8
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x00005C5C File Offset: 0x00003E5C
		public unsafe static int k_PreloadSteps
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadSteps, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationOperation.NativeFieldInfoPtr_k_PreloadSteps, (void*)(&value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0002DBF4 File Offset: 0x0002BDF4
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00005C6A File Offset: 0x00003E6A
		public unsafe static ObjectPool<InitializationOperation> Pool
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InitializationOperation.NativeFieldInfoPtr_Pool, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<InitializationOperation>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InitializationOperation.NativeFieldInfoPtr_Pool, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006AD RID: 1709
		private static readonly IntPtr NativeFieldInfoPtr_m_UnloadBundlesOperationHandle;

		// Token: 0x040006AE RID: 1710
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadLocales;

		// Token: 0x040006AF RID: 1711
		private static readonly IntPtr NativeFieldInfoPtr_k_LocaleError;

		// Token: 0x040006B0 RID: 1712
		private static readonly IntPtr NativeFieldInfoPtr_k_PreloadAssetTablesError;

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_k_PreloadStringTablesError;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadLocalesCompletedAction;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishPreloadingTablesAction;

		// Token: 0x040006B4 RID: 1716
		private static readonly IntPtr NativeFieldInfoPtr_m_Settings;

		// Token: 0x040006B5 RID: 1717
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadDatabasesOperations;

		// Token: 0x040006B6 RID: 1718
		private static readonly IntPtr NativeFieldInfoPtr_m_PreloadDatabasesOperation;

		// Token: 0x040006B7 RID: 1719
		private static readonly IntPtr NativeFieldInfoPtr_m_RemainingSteps;

		// Token: 0x040006B8 RID: 1720
		private static readonly IntPtr NativeFieldInfoPtr_k_PreloadSteps;

		// Token: 0x040006B9 RID: 1721
		private static readonly IntPtr NativeFieldInfoPtr_Pool;

		// Token: 0x040006BA RID: 1722
		private static readonly IntPtr NativeMethodInfoPtr_get_Progress_Protected_Virtual_get_Single_0;

		// Token: 0x040006BB RID: 1723
		private static readonly IntPtr NativeMethodInfoPtr_get_DebugName_Protected_Virtual_get_String_0;

		// Token: 0x040006BC RID: 1724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040006BD RID: 1725
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_LocalizationSettings_0;

		// Token: 0x040006BE RID: 1726
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

		// Token: 0x040006BF RID: 1727
		private static readonly IntPtr NativeMethodInfoPtr_LoadLocales_Private_Void_0;

		// Token: 0x040006C0 RID: 1728
		private static readonly IntPtr NativeMethodInfoPtr_CheckOperationSucceeded_Private_Boolean_AsyncOperationHandle_String_0;

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeMethodInfoPtr_LoadLocalesCompleted_Private_Void_AsyncOperationHandle_1_Locale_0;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeMethodInfoPtr_PreloadTables_Private_Void_0;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr_PreloadTablesCompleted_Private_Void_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_PostInitializeExtensions_Private_Void_0;

		// Token: 0x040006C5 RID: 1733
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitializing_Private_Void_AsyncOperationHandle_0;

		// Token: 0x040006C6 RID: 1734
		private static readonly IntPtr NativeMethodInfoPtr_FinishInitializing_Private_Void_Boolean_String_0;

		// Token: 0x040006C7 RID: 1735
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;

		// Token: 0x040006C8 RID: 1736
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__18_0_Private_Void_AsyncOperationHandle_0;

		// Token: 0x040006C9 RID: 1737
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__18_1_Private_Void_AsyncOperationHandle_0;

		// Token: 0x0200016A RID: 362
		public class UnloadBundlesOperation : AsyncOperationBase<Object>
		{
			// Token: 0x06000F61 RID: 3937 RVA: 0x00041D44 File Offset: 0x0003FF44
			// Note: this type is marked as 'beforefieldinit'.
			static UnloadBundlesOperation()
			{
				Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "UnloadBundlesOperation");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr);
				InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_OperationCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, "m_OperationCompleted");
				InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_UnloadBundleOperations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, "m_UnloadBundleOperations");
				InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, 100664933);
				InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, 100664934);
				InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, 100664935);
				InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, 100664936);
				InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr, 100664937);
			}

			// Token: 0x06000F62 RID: 3938 RVA: 0x00041DFC File Offset: 0x0003FFFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077476, XrefRangeEnd = 1077493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UnloadBundlesOperation()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation.UnloadBundlesOperation>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F63 RID: 3939 RVA: 0x00041E38 File Offset: 0x00040038
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077493, XrefRangeEnd = 1077531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F64 RID: 3940 RVA: 0x00041E74 File Offset: 0x00040074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077531, XrefRangeEnd = 1077538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnOperationCompleted(AsyncOperation obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000F65 RID: 3941 RVA: 0x00041EB8 File Offset: 0x000400B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077538, XrefRangeEnd = 1077542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool InvokeWaitForCompletion()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000F66 RID: 3942 RVA: 0x00041F00 File Offset: 0x00040100
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077542, XrefRangeEnd = 1077548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Destroy()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitializationOperation.UnloadBundlesOperation.NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F67 RID: 3943 RVA: 0x000086BB File Offset: 0x000068BB
			public UnloadBundlesOperation(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000423 RID: 1059
			// (get) Token: 0x06000F68 RID: 3944 RVA: 0x00041F3C File Offset: 0x0004013C
			// (set) Token: 0x06000F69 RID: 3945 RVA: 0x000086C4 File Offset: 0x000068C4
			public unsafe Action<AsyncOperation> m_OperationCompleted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_OperationCompleted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_OperationCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000424 RID: 1060
			// (get) Token: 0x06000F6A RID: 3946 RVA: 0x00041F6C File Offset: 0x0004016C
			// (set) Token: 0x06000F6B RID: 3947 RVA: 0x000086E3 File Offset: 0x000068E3
			public unsafe List<AsyncOperation> m_UnloadBundleOperations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_UnloadBundleOperations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncOperation>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitializationOperation.UnloadBundlesOperation.NativeFieldInfoPtr_m_UnloadBundleOperations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000A99 RID: 2713
			private static readonly IntPtr NativeFieldInfoPtr_m_OperationCompleted;

			// Token: 0x04000A9A RID: 2714
			private static readonly IntPtr NativeFieldInfoPtr_m_UnloadBundleOperations;

			// Token: 0x04000A9B RID: 2715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000A9C RID: 2716
			private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_Void_0;

			// Token: 0x04000A9D RID: 2717
			private static readonly IntPtr NativeMethodInfoPtr_OnOperationCompleted_Private_Void_AsyncOperation_0;

			// Token: 0x04000A9E RID: 2718
			private static readonly IntPtr NativeMethodInfoPtr_InvokeWaitForCompletion_Protected_Virtual_Boolean_0;

			// Token: 0x04000A9F RID: 2719
			private static readonly IntPtr NativeMethodInfoPtr_Destroy_Protected_Virtual_Void_0;
		}

		// Token: 0x0200016B RID: 363
		[ObfuscatedName("UnityEngine.Localization.Operations.InitializationOperation+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000F6C RID: 3948 RVA: 0x00041F9C File Offset: 0x0004019C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InitializationOperation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr);
				InitializationOperation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, "<>9");
				InitializationOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, 100664939);
				InitializationOperation.__c.NativeMethodInfoPtr___cctor_b__30_0_Internal_InitializationOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr, 100664940);
			}

			// Token: 0x06000F6D RID: 3949 RVA: 0x00042004 File Offset: 0x00040204
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitializationOperation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000F6E RID: 3950 RVA: 0x00042040 File Offset: 0x00040240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077548, XrefRangeEnd = 1077581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe InitializationOperation __cctor_b__30_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitializationOperation.__c.NativeMethodInfoPtr___cctor_b__30_0_Internal_InitializationOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InitializationOperation>(intPtr3) : null;
			}

			// Token: 0x06000F6F RID: 3951 RVA: 0x00008702 File Offset: 0x00006902
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000425 RID: 1061
			// (get) Token: 0x06000F70 RID: 3952 RVA: 0x00042080 File Offset: 0x00040280
			// (set) Token: 0x06000F71 RID: 3953 RVA: 0x0000870B File Offset: 0x0000690B
			public unsafe static InitializationOperation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InitializationOperation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InitializationOperation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InitializationOperation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000AA0 RID: 2720
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000AA1 RID: 2721
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000AA2 RID: 2722
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__30_0_Internal_InitializationOperation_0;
		}
	}
}
