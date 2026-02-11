using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.AddressableAssets.Utility
{
	// Token: 0x0200001C RID: 28
	public class ResourceManagerDiagnostics : Object
	{
		// Token: 0x0600023B RID: 571 RVA: 0x0000F16C File Offset: 0x0000D36C
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceManagerDiagnostics()
		{
			Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Utility", "ResourceManagerDiagnostics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr);
			ResourceManagerDiagnostics.NativeFieldInfoPtr_m_ResourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, "m_ResourceManager");
			ResourceManagerDiagnostics.NativeFieldInfoPtr_k_NumberOfCompletedOpResultEntriesToShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, "k_NumberOfCompletedOpResultEntriesToShow");
			ResourceManagerDiagnostics.NativeFieldInfoPtr_k_MaximumCompletedOpResultEntryLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, "k_MaximumCompletedOpResultEntryLength");
			ResourceManagerDiagnostics.NativeFieldInfoPtr_m_cachedDiagnosticInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, "m_cachedDiagnosticInfo");
			ResourceManagerDiagnostics.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663767);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_SumDependencyNameHashCodes_Internal_Int32_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663768);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_CalculateHashCode_Internal_Int32_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663769);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_CalculateCompletedOperationHashcode_Internal_Int32_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663770);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_GenerateCompletedOperationDisplayName_Internal_String_AsyncOperationHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663771);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_OnResourceManagerDiagnosticEvent_Private_Void_DiagnosticEventContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663772);
			ResourceManagerDiagnostics.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr, 100663773);
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000F278 File Offset: 0x0000D478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162993, XrefRangeEnd = 1163010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceManagerDiagnostics(ResourceManager resourceManager)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceManagerDiagnostics>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resourceManager);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000F2C4 File Offset: 0x0000D4C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163034, RefRangeEnd = 1163036, XrefRangeStart = 1163010, XrefRangeEnd = 1163034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SumDependencyNameHashCodes(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_SumDependencyNameHashCodes_Internal_Int32_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000F318 File Offset: 0x0000D518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1163050, RefRangeEnd = 1163052, XrefRangeStart = 1163036, XrefRangeEnd = 1163050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateHashCode(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_CalculateHashCode_Internal_Int32_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000F36C File Offset: 0x0000D56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163052, XrefRangeEnd = 1163056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CalculateCompletedOperationHashcode(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_CalculateCompletedOperationHashcode_Internal_Int32_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000F3C0 File Offset: 0x0000D5C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163100, RefRangeEnd = 1163101, XrefRangeStart = 1163056, XrefRangeEnd = 1163100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GenerateCompletedOperationDisplayName(AsyncOperationHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_GenerateCompletedOperationDisplayName_Internal_String_AsyncOperationHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000F410 File Offset: 0x0000D610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163101, XrefRangeEnd = 1163154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnResourceManagerDiagnosticEvent(ResourceManager.DiagnosticEventContext eventContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventContext));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_OnResourceManagerDiagnosticEvent_Private_Void_DiagnosticEventContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000F458 File Offset: 0x0000D658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1163154, XrefRangeEnd = 1163167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceManagerDiagnostics.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002A5F File Offset: 0x00000C5F
		public ResourceManagerDiagnostics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000F48C File Offset: 0x0000D68C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00002A68 File Offset: 0x00000C68
		public unsafe ResourceManager m_ResourceManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerDiagnostics.NativeFieldInfoPtr_m_ResourceManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerDiagnostics.NativeFieldInfoPtr_m_ResourceManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0000F4BC File Offset: 0x0000D6BC
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00002A87 File Offset: 0x00000C87
		public unsafe static int k_NumberOfCompletedOpResultEntriesToShow
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManagerDiagnostics.NativeFieldInfoPtr_k_NumberOfCompletedOpResultEntriesToShow, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManagerDiagnostics.NativeFieldInfoPtr_k_NumberOfCompletedOpResultEntriesToShow, (void*)(&value));
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000248 RID: 584 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00002A95 File Offset: 0x00000C95
		public unsafe static int k_MaximumCompletedOpResultEntryLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ResourceManagerDiagnostics.NativeFieldInfoPtr_k_MaximumCompletedOpResultEntryLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ResourceManagerDiagnostics.NativeFieldInfoPtr_k_MaximumCompletedOpResultEntryLength, (void*)(&value));
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0000F4F4 File Offset: 0x0000D6F4
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00002AA3 File Offset: 0x00000CA3
		public unsafe Dictionary<int, DiagnosticInfo> m_cachedDiagnosticInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerDiagnostics.NativeFieldInfoPtr_m_cachedDiagnosticInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, DiagnosticInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceManagerDiagnostics.NativeFieldInfoPtr_m_cachedDiagnosticInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001CD RID: 461
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceManager;

		// Token: 0x040001CE RID: 462
		private static readonly IntPtr NativeFieldInfoPtr_k_NumberOfCompletedOpResultEntriesToShow;

		// Token: 0x040001CF RID: 463
		private static readonly IntPtr NativeFieldInfoPtr_k_MaximumCompletedOpResultEntryLength;

		// Token: 0x040001D0 RID: 464
		private static readonly IntPtr NativeFieldInfoPtr_m_cachedDiagnosticInfo;

		// Token: 0x040001D1 RID: 465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResourceManager_0;

		// Token: 0x040001D2 RID: 466
		private static readonly IntPtr NativeMethodInfoPtr_SumDependencyNameHashCodes_Internal_Int32_AsyncOperationHandle_0;

		// Token: 0x040001D3 RID: 467
		private static readonly IntPtr NativeMethodInfoPtr_CalculateHashCode_Internal_Int32_AsyncOperationHandle_0;

		// Token: 0x040001D4 RID: 468
		private static readonly IntPtr NativeMethodInfoPtr_CalculateCompletedOperationHashcode_Internal_Int32_AsyncOperationHandle_0;

		// Token: 0x040001D5 RID: 469
		private static readonly IntPtr NativeMethodInfoPtr_GenerateCompletedOperationDisplayName_Internal_String_AsyncOperationHandle_0;

		// Token: 0x040001D6 RID: 470
		private static readonly IntPtr NativeMethodInfoPtr_OnResourceManagerDiagnosticEvent_Private_Void_DiagnosticEventContext_0;

		// Token: 0x040001D7 RID: 471
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
