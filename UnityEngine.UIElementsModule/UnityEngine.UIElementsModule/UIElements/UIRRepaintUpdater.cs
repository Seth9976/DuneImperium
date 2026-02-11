using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	// Token: 0x02000171 RID: 369
	public class UIRRepaintUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x06001B54 RID: 6996 RVA: 0x0007D51C File Offset: 0x0007B71C
		// Note: this type is marked as 'beforefieldinit'.
		static UIRRepaintUpdater()
		{
			Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UIRRepaintUpdater");
			UIRRepaintUpdater.NativeFieldInfoPtr_attachedPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "attachedPanel");
			UIRRepaintUpdater.NativeFieldInfoPtr_renderChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "renderChain");
			UIRRepaintUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "s_Description");
			UIRRepaintUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "s_ProfilerMarker");
			UIRRepaintUpdater.NativeFieldInfoPtr__drawStats_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "<drawStats>k__BackingField");
			UIRRepaintUpdater.NativeFieldInfoPtr__breakBatches_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "<breakBatches>k__BackingField");
			UIRRepaintUpdater.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, "<disposed>k__BackingField");
			UIRRepaintUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667270);
			UIRRepaintUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667271);
			UIRRepaintUpdater.NativeMethodInfoPtr_get_drawStats_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667272);
			UIRRepaintUpdater.NativeMethodInfoPtr_get_breakBatches_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667273);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667274);
			UIRRepaintUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667275);
			UIRRepaintUpdater.NativeMethodInfoPtr_CreateRenderChain_Protected_Virtual_New_RenderChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667276);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnGraphicsResourcesRecreate_Private_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667278);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelChanged_Private_Void_BaseVisualElementPanel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667279);
			UIRRepaintUpdater.NativeMethodInfoPtr_AttachToPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667280);
			UIRRepaintUpdater.NativeMethodInfoPtr_DetachFromPanel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667281);
			UIRRepaintUpdater.NativeMethodInfoPtr_InitRenderChain_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667282);
			UIRRepaintUpdater.NativeMethodInfoPtr_DestroyRenderChain_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667283);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelAtlasChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667284);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelHierarchyChanged_Private_Void_VisualElement_HierarchyChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667285);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelStandardShaderChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667286);
			UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelStandardWorldSpaceShaderChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667287);
			UIRRepaintUpdater.NativeMethodInfoPtr_ResetAllElementsDataRecursive_Private_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667288);
			UIRRepaintUpdater.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667289);
			UIRRepaintUpdater.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667290);
			UIRRepaintUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr, 100667291);
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x0007D774 File Offset: 0x0007B974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322902, XrefRangeEnd = 322910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIRRepaintUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIRRepaintUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x0007D7B0 File Offset: 0x0007B9B0
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322910, XrefRangeEnd = 322914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRRepaintUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0007D7F8 File Offset: 0x0007B9F8
		// (set) Token: 0x06001B79 RID: 7033 RVA: 0x0000C78D File Offset: 0x0000A98D
		public unsafe bool drawStats
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_get_drawStats_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._drawStats_k__BackingField = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001B58 RID: 7000 RVA: 0x0007D834 File Offset: 0x0007BA34
		// (set) Token: 0x06001B7A RID: 7034 RVA: 0x0000C796 File Offset: 0x0000A996
		public unsafe bool breakBatches
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_get_breakBatches_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._breakBatches_k__BackingField = value;
			}
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0007D870 File Offset: 0x0007BA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322914, XrefRangeEnd = 322920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRRepaintUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0007D8CC File Offset: 0x0007BACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322920, XrefRangeEnd = 322925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRRepaintUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5B RID: 7003 RVA: 0x0007D908 File Offset: 0x0007BB08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322925, XrefRangeEnd = 322930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual UnityEngine.UIElements.UIR.RenderChain CreateRenderChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRRepaintUpdater.NativeMethodInfoPtr_CreateRenderChain_Protected_Virtual_New_RenderChain_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.RenderChain>(intPtr3) : null;
		}

		// Token: 0x06001B5C RID: 7004 RVA: 0x0007D954 File Offset: 0x0007BB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322930, XrefRangeEnd = 322953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnGraphicsResourcesRecreate(bool recreate)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref recreate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnGraphicsResourcesRecreate_Private_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5D RID: 7005 RVA: 0x0007D988 File Offset: 0x0007BB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 322953, XrefRangeEnd = 322955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelChanged(BaseVisualElementPanel obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelChanged_Private_Void_BaseVisualElementPanel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B5E RID: 7006 RVA: 0x0007D9CC File Offset: 0x0007BBCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 322988, RefRangeEnd = 322989, XrefRangeStart = 322955, XrefRangeEnd = 322988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AttachToPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_AttachToPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B5F RID: 7007 RVA: 0x0007DA00 File Offset: 0x0007BC00
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323017, RefRangeEnd = 323019, XrefRangeStart = 322989, XrefRangeEnd = 323017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DetachFromPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_DetachFromPanel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x0007DA34 File Offset: 0x0007BC34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 323068, RefRangeEnd = 323069, XrefRangeStart = 323019, XrefRangeEnd = 323068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitRenderChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_InitRenderChain_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B61 RID: 7009 RVA: 0x0007DA68 File Offset: 0x0007BC68
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 323075, RefRangeEnd = 323079, XrefRangeStart = 323069, XrefRangeEnd = 323075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyRenderChain()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_DestroyRenderChain_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B62 RID: 7010 RVA: 0x0007DA9C File Offset: 0x0007BC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323079, XrefRangeEnd = 323080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelAtlasChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelAtlasChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B63 RID: 7011 RVA: 0x0007DAD0 File Offset: 0x0007BCD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323080, XrefRangeEnd = 323081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelHierarchyChanged(VisualElement ve, HierarchyChangeType changeType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref changeType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelHierarchyChanged_Private_Void_VisualElement_HierarchyChangeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B64 RID: 7012 RVA: 0x0007DB20 File Offset: 0x0007BD20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323081, XrefRangeEnd = 323104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelStandardShaderChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelStandardShaderChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B65 RID: 7013 RVA: 0x0007DB54 File Offset: 0x0007BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323104, XrefRangeEnd = 323127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPanelStandardWorldSpaceShaderChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_OnPanelStandardWorldSpaceShaderChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B66 RID: 7014 RVA: 0x0007DB88 File Offset: 0x0007BD88
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 323131, RefRangeEnd = 323133, XrefRangeStart = 323127, XrefRangeEnd = 323131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetAllElementsDataRecursive(VisualElement ve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_ResetAllElementsDataRecursive_Private_Void_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001B67 RID: 7015 RVA: 0x0007DBCC File Offset: 0x0007BDCC
		// (set) Token: 0x06001B68 RID: 7016 RVA: 0x0007DC08 File Offset: 0x0007BE08
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIRRepaintUpdater.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001B69 RID: 7017 RVA: 0x0007DC48 File Offset: 0x0007BE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323133, XrefRangeEnd = 323134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIRRepaintUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B6A RID: 7018 RVA: 0x0000C6D5 File Offset: 0x0000A8D5
		public UIRRepaintUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001B6B RID: 7019 RVA: 0x0007DC94 File Offset: 0x0007BE94
		// (set) Token: 0x06001B6C RID: 7020 RVA: 0x0000C6DE File Offset: 0x0000A8DE
		public unsafe BaseVisualElementPanel attachedPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr_attachedPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BaseVisualElementPanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr_attachedPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001B6D RID: 7021 RVA: 0x0007DCC4 File Offset: 0x0007BEC4
		// (set) Token: 0x06001B6E RID: 7022 RVA: 0x0000C6FD File Offset: 0x0000A8FD
		public unsafe UnityEngine.UIElements.UIR.RenderChain renderChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr_renderChain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.UIElements.UIR.RenderChain>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr_renderChain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x0007DCF4 File Offset: 0x0007BEF4
		// (set) Token: 0x06001B70 RID: 7024 RVA: 0x0000C71C File Offset: 0x0000A91C
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UIRRepaintUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRRepaintUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001B71 RID: 7025 RVA: 0x0007DD14 File Offset: 0x0007BF14
		// (set) Token: 0x06001B72 RID: 7026 RVA: 0x0000C72E File Offset: 0x0000A92E
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(UIRRepaintUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UIRRepaintUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001B73 RID: 7027 RVA: 0x0007DD30 File Offset: 0x0007BF30
		// (set) Token: 0x06001B74 RID: 7028 RVA: 0x0000C73C File Offset: 0x0000A93C
		public unsafe bool _drawStats_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__drawStats_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__drawStats_k__BackingField)) = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x0007DD58 File Offset: 0x0007BF58
		// (set) Token: 0x06001B76 RID: 7030 RVA: 0x0000C757 File Offset: 0x0000A957
		public unsafe bool _breakBatches_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__breakBatches_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__breakBatches_k__BackingField)) = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x0007DD80 File Offset: 0x0007BF80
		// (set) Token: 0x06001B78 RID: 7032 RVA: 0x0000C772 File Offset: 0x0000A972
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIRRepaintUpdater.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeFieldInfoPtr_attachedPanel;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeFieldInfoPtr_renderChain;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeFieldInfoPtr__drawStats_k__BackingField;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeFieldInfoPtr__breakBatches_k__BackingField;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x040012E2 RID: 4834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040012E3 RID: 4835
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x040012E4 RID: 4836
		private static readonly IntPtr NativeMethodInfoPtr_get_drawStats_Public_get_Boolean_0;

		// Token: 0x040012E5 RID: 4837
		private static readonly IntPtr NativeMethodInfoPtr_get_breakBatches_Public_get_Boolean_0;

		// Token: 0x040012E6 RID: 4838
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x040012E7 RID: 4839
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x040012E8 RID: 4840
		private static readonly IntPtr NativeMethodInfoPtr_CreateRenderChain_Protected_Virtual_New_RenderChain_0;

		// Token: 0x040012E9 RID: 4841
		private static readonly IntPtr NativeMethodInfoPtr_OnGraphicsResourcesRecreate_Private_Static_Void_Boolean_0;

		// Token: 0x040012EA RID: 4842
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelChanged_Private_Void_BaseVisualElementPanel_0;

		// Token: 0x040012EB RID: 4843
		private static readonly IntPtr NativeMethodInfoPtr_AttachToPanel_Private_Void_0;

		// Token: 0x040012EC RID: 4844
		private static readonly IntPtr NativeMethodInfoPtr_DetachFromPanel_Private_Void_0;

		// Token: 0x040012ED RID: 4845
		private static readonly IntPtr NativeMethodInfoPtr_InitRenderChain_Private_Void_0;

		// Token: 0x040012EE RID: 4846
		private static readonly IntPtr NativeMethodInfoPtr_DestroyRenderChain_Internal_Void_0;

		// Token: 0x040012EF RID: 4847
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelAtlasChanged_Private_Void_0;

		// Token: 0x040012F0 RID: 4848
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelHierarchyChanged_Private_Void_VisualElement_HierarchyChangeType_0;

		// Token: 0x040012F1 RID: 4849
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelStandardShaderChanged_Private_Void_0;

		// Token: 0x040012F2 RID: 4850
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelStandardWorldSpaceShaderChanged_Private_Void_0;

		// Token: 0x040012F3 RID: 4851
		private static readonly IntPtr NativeMethodInfoPtr_ResetAllElementsDataRecursive_Private_Void_VisualElement_0;

		// Token: 0x040012F4 RID: 4852
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x040012F5 RID: 4853
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x040012F6 RID: 4854
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
