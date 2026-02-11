using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000023 RID: 35
	public class VisualTreeBindingsUpdater : BaseVisualTreeHierarchyTrackerUpdater
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x00023630 File Offset: 0x00021830
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeBindingsUpdater()
		{
			Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeBindingsUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr);
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_BindingRequestObjectVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_BindingRequestObjectVEPropertyName");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_AdditionalBindingObjectVEPropertyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_AdditionalBindingObjectVEPropertyName");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_Description");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_ProfilerMarker");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerBindingRequestsMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_ProfilerBindingRequestsMarker");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_MarkerUpdate");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerPoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "s_MarkerPoll");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr__disableBindingsThrottling_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "<disableBindingsThrottling>k__BackingField");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsWithBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "m_ElementsWithBindings");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "m_ElementsToAdd");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "m_ElementsToRemove");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_LastUpdateTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "m_LastUpdateTime");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToBind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "m_ElementsToBind");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr__temporaryObjectCache_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "<temporaryObjectCache>k__BackingField");
			VisualTreeBindingsUpdater.NativeFieldInfoPtr_updatedBindings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, "updatedBindings");
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663552);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_disableBindingsThrottling_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663553);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_GetBindingObjectFromElement_Private_IBinding_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663554);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_StartTracking_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663555);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_StopTracking_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663556);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_temporaryObjectCache_Public_get_Dictionary_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663557);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_GetAdditionalBinding_Public_Static_IBinding_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663558);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_StartTrackingRecursive_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663559);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_StopTrackingRecursive_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663560);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663561);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_OnHierarchyChange_Protected_Virtual_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663562);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_CurrentTime_Private_Static_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663563);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_PerformTrackingOperations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663564);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663565);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr_UpdateBindings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663566);
			VisualTreeBindingsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr, 100663567);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x000238CC File Offset: 0x00021ACC
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284008, XrefRangeEnd = 284012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00023914 File Offset: 0x00021B14
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000029C2 File Offset: 0x00000BC2
		public unsafe static bool disableBindingsThrottling
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284012, XrefRangeEnd = 284016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_disableBindingsThrottling_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				VisualTreeBindingsUpdater._disableBindingsThrottling_k__BackingField = value;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00023944 File Offset: 0x00021B44
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 284034, RefRangeEnd = 284038, XrefRangeStart = 284016, XrefRangeEnd = 284034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IBinding GetBindingObjectFromElement(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_GetBindingObjectFromElement_Private_IBinding_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBinding>(intPtr3) : null;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00023994 File Offset: 0x00021B94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284045, RefRangeEnd = 284047, XrefRangeStart = 284038, XrefRangeEnd = 284045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTracking(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_StartTracking_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x000239D8 File Offset: 0x00021BD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 284054, RefRangeEnd = 284057, XrefRangeStart = 284047, XrefRangeEnd = 284054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTracking(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_StopTracking_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00023A1C File Offset: 0x00021C1C
		// (set) Token: 0x06000222 RID: 546 RVA: 0x000029CA File Offset: 0x00000BCA
		public unsafe Dictionary<Object, Object> temporaryObjectCache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_get_temporaryObjectCache_Public_get_Dictionary_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, Object>>(intPtr3) : null;
			}
			set
			{
				this._temporaryObjectCache_k__BackingField = value;
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00023A5C File Offset: 0x00021C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284057, XrefRangeEnd = 284066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IBinding GetAdditionalBinding(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_GetAdditionalBinding_Public_Static_IBinding_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IBinding>(intPtr3) : null;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00023AA0 File Offset: 0x00021CA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284079, RefRangeEnd = 284081, XrefRangeStart = 284066, XrefRangeEnd = 284079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTrackingRecursive(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_StartTrackingRecursive_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00023AE4 File Offset: 0x00021CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284093, RefRangeEnd = 284094, XrefRangeStart = 284081, XrefRangeEnd = 284093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTrackingRecursive(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_StopTrackingRecursive_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00023B28 File Offset: 0x00021D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284094, XrefRangeEnd = 284107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref versionChangeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeBindingsUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00023B84 File Offset: 0x00021D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284107, XrefRangeEnd = 284108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnHierarchyChange(VisualElement ve, HierarchyChangeType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeBindingsUpdater.NativeMethodInfoPtr_OnHierarchyChange_Protected_Virtual_Void_VisualElement_HierarchyChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00023BE0 File Offset: 0x00021DE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284108, XrefRangeEnd = 284112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CurrentTime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_CurrentTime_Private_Static_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00023C10 File Offset: 0x00021E10
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284148, RefRangeEnd = 284149, XrefRangeStart = 284112, XrefRangeEnd = 284148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PerformTrackingOperations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_PerformTrackingOperations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00023C44 File Offset: 0x00021E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284149, XrefRangeEnd = 284231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeBindingsUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00023C80 File Offset: 0x00021E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 284288, RefRangeEnd = 284289, XrefRangeStart = 284231, XrefRangeEnd = 284288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBindings()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr_UpdateBindings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00023CB4 File Offset: 0x00021EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284289, XrefRangeEnd = 284326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeBindingsUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeBindingsUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeBindingsUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002870 File Offset: 0x00000A70
		public VisualTreeBindingsUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00023CF0 File Offset: 0x00021EF0
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002879 File Offset: 0x00000A79
		public unsafe static PropertyName s_BindingRequestObjectVEPropertyName
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_BindingRequestObjectVEPropertyName, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_BindingRequestObjectVEPropertyName, (void*)(&value));
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00023D0C File Offset: 0x00021F0C
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002887 File Offset: 0x00000A87
		public unsafe static PropertyName s_AdditionalBindingObjectVEPropertyName
		{
			get
			{
				PropertyName propertyName;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_AdditionalBindingObjectVEPropertyName, (void*)(&propertyName));
				return propertyName;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_AdditionalBindingObjectVEPropertyName, (void*)(&value));
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00023D28 File Offset: 0x00021F28
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002895 File Offset: 0x00000A95
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000209 RID: 521 RVA: 0x00023D48 File Offset: 0x00021F48
		// (set) Token: 0x0600020A RID: 522 RVA: 0x000028A7 File Offset: 0x00000AA7
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600020B RID: 523 RVA: 0x00023D64 File Offset: 0x00021F64
		// (set) Token: 0x0600020C RID: 524 RVA: 0x000028B5 File Offset: 0x00000AB5
		public unsafe static ProfilerMarker s_ProfilerBindingRequestsMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerBindingRequestsMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_ProfilerBindingRequestsMarker, (void*)(&value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600020D RID: 525 RVA: 0x00023D80 File Offset: 0x00021F80
		// (set) Token: 0x0600020E RID: 526 RVA: 0x000028C3 File Offset: 0x00000AC3
		public unsafe static ProfilerMarker s_MarkerUpdate
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerUpdate, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerUpdate, (void*)(&value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600020F RID: 527 RVA: 0x00023D9C File Offset: 0x00021F9C
		// (set) Token: 0x06000210 RID: 528 RVA: 0x000028D1 File Offset: 0x00000AD1
		public unsafe static ProfilerMarker s_MarkerPoll
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerPoll, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr_s_MarkerPoll, (void*)(&value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000211 RID: 529 RVA: 0x00023DB8 File Offset: 0x00021FB8
		// (set) Token: 0x06000212 RID: 530 RVA: 0x000028DF File Offset: 0x00000ADF
		public unsafe static bool _disableBindingsThrottling_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr__disableBindingsThrottling_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeBindingsUpdater.NativeFieldInfoPtr__disableBindingsThrottling_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00023DD4 File Offset: 0x00021FD4
		// (set) Token: 0x06000214 RID: 532 RVA: 0x000028ED File Offset: 0x00000AED
		public unsafe HashSet<VisualElement> m_ElementsWithBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsWithBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsWithBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000215 RID: 533 RVA: 0x00023E04 File Offset: 0x00022004
		// (set) Token: 0x06000216 RID: 534 RVA: 0x0000290C File Offset: 0x00000B0C
		public unsafe HashSet<VisualElement> m_ElementsToAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToAdd);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToAdd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000217 RID: 535 RVA: 0x00023E34 File Offset: 0x00022034
		// (set) Token: 0x06000218 RID: 536 RVA: 0x0000292B File Offset: 0x00000B2B
		public unsafe HashSet<VisualElement> m_ElementsToRemove
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToRemove);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToRemove), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000219 RID: 537 RVA: 0x00023E64 File Offset: 0x00022064
		// (set) Token: 0x0600021A RID: 538 RVA: 0x0000294A File Offset: 0x00000B4A
		public unsafe long m_LastUpdateTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_LastUpdateTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_LastUpdateTime)) = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00023E8C File Offset: 0x0002208C
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002965 File Offset: 0x00000B65
		public unsafe HashSet<VisualElement> m_ElementsToBind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToBind);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_m_ElementsToBind), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00023EBC File Offset: 0x000220BC
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002984 File Offset: 0x00000B84
		public unsafe Dictionary<Object, Object> _temporaryObjectCache_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr__temporaryObjectCache_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr__temporaryObjectCache_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00023EEC File Offset: 0x000220EC
		// (set) Token: 0x06000220 RID: 544 RVA: 0x000029A3 File Offset: 0x00000BA3
		public unsafe List<IBinding> updatedBindings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_updatedBindings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IBinding>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeBindingsUpdater.NativeFieldInfoPtr_updatedBindings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00023F1C File Offset: 0x0002211C
		public static void SetAdditionalBinding(VisualElement ve, IBinding b)
		{
			IBinding additionalBinding = VisualTreeBindingsUpdater.GetAdditionalBinding(ve);
			if (additionalBinding != null)
			{
				additionalBinding.Release();
			}
			ve.SetProperty(VisualTreeBindingsUpdater.s_AdditionalBindingObjectVEPropertyName, b);
			ve.IncrementVersion(VersionChangeType.Bindings);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x000029D3 File Offset: 0x00000BD3
		public static void ClearAdditionalBinding(VisualElement ve)
		{
			VisualTreeBindingsUpdater.SetAdditionalBinding(ve, null);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00023F54 File Offset: 0x00022154
		public static void AddBindingRequest(VisualElement ve, IBindingRequest req)
		{
			List<IBindingRequest> list = ve.GetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName).TryCast<List<IBindingRequest>>();
			bool flag = list == null;
			if (flag)
			{
				list = ObjectListPool<IBindingRequest>.Get();
				ve.SetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName, list);
			}
			list.Add(req);
			ve.IncrementVersion(VersionChangeType.Bindings);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00023FA0 File Offset: 0x000221A0
		public static void RemoveBindingRequest(VisualElement ve, IBindingRequest req)
		{
			List<IBindingRequest> list = ve.GetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName).TryCast<List<IBindingRequest>>();
			bool flag = list != null;
			if (flag)
			{
				req.Release();
				list.Remove(req);
				bool flag2 = list.Count == 0;
				if (flag2)
				{
					ObjectListPool<IBindingRequest>.Release(list);
					ve.SetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName, null);
				}
			}
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00023FFC File Offset: 0x000221FC
		public static void ClearBindingRequests(VisualElement ve)
		{
			List<IBindingRequest> list = ve.GetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName).TryCast<List<IBindingRequest>>();
			bool flag = list != null;
			if (flag)
			{
				List<IBindingRequest>.Enumerator enumerator = list.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						IBindingRequest bindingRequest = enumerator.Current;
						bindingRequest.Release();
					}
				}
				finally
				{
					enumerator.Dispose();
				}
				ObjectListPool<IBindingRequest>.Release(list);
				ve.SetProperty(VisualTreeBindingsUpdater.s_BindingRequestObjectVEPropertyName, null);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00024080 File Offset: 0x00022280
		public static bool ShouldThrottle(long startTime)
		{
			return !VisualTreeBindingsUpdater.disableBindingsThrottling && VisualTreeBindingsUpdater.CurrentTime() - startTime < 100L;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000029DE File Offset: 0x00000BDE
		public void PollElementsWithBindings(Action<VisualElement, IBinding> callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_s_BindingRequestObjectVEPropertyName;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_s_AdditionalBindingObjectVEPropertyName;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerBindingRequestsMarker;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerUpdate;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeFieldInfoPtr_s_MarkerPoll;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeFieldInfoPtr__disableBindingsThrottling_k__BackingField;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementsWithBindings;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementsToAdd;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementsToRemove;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeFieldInfoPtr_m_LastUpdateTime;

		// Token: 0x0400019D RID: 413
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementsToBind;

		// Token: 0x0400019E RID: 414
		private static readonly IntPtr NativeFieldInfoPtr__temporaryObjectCache_k__BackingField;

		// Token: 0x0400019F RID: 415
		private static readonly IntPtr NativeFieldInfoPtr_updatedBindings;

		// Token: 0x040001A0 RID: 416
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x040001A1 RID: 417
		private static readonly IntPtr NativeMethodInfoPtr_get_disableBindingsThrottling_Public_Static_get_Boolean_0;

		// Token: 0x040001A2 RID: 418
		private static readonly IntPtr NativeMethodInfoPtr_GetBindingObjectFromElement_Private_IBinding_VisualElement_0;

		// Token: 0x040001A3 RID: 419
		private static readonly IntPtr NativeMethodInfoPtr_StartTracking_Private_Void_VisualElement_0;

		// Token: 0x040001A4 RID: 420
		private static readonly IntPtr NativeMethodInfoPtr_StopTracking_Private_Void_VisualElement_0;

		// Token: 0x040001A5 RID: 421
		private static readonly IntPtr NativeMethodInfoPtr_get_temporaryObjectCache_Public_get_Dictionary_2_Object_Object_0;

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeMethodInfoPtr_GetAdditionalBinding_Public_Static_IBinding_VisualElement_0;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_StartTrackingRecursive_Private_Void_VisualElement_0;

		// Token: 0x040001A8 RID: 424
		private static readonly IntPtr NativeMethodInfoPtr_StopTrackingRecursive_Private_Void_VisualElement_0;

		// Token: 0x040001A9 RID: 425
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x040001AA RID: 426
		private static readonly IntPtr NativeMethodInfoPtr_OnHierarchyChange_Protected_Virtual_Void_VisualElement_HierarchyChangeType_0;

		// Token: 0x040001AB RID: 427
		private static readonly IntPtr NativeMethodInfoPtr_CurrentTime_Private_Static_Int64_0;

		// Token: 0x040001AC RID: 428
		private static readonly IntPtr NativeMethodInfoPtr_PerformTrackingOperations_Public_Void_0;

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBindings_Private_Void_0;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040001B0 RID: 432
		public const int k_MinUpdateDelayMs = 100;

		// Token: 0x040001B1 RID: 433
		public const int k_MaxBindingTimeMs = 100;

		// Token: 0x02000324 RID: 804
		public class RequestObjectListPool : ObjectListPool<IBindingRequest>
		{
		}
	}
}
