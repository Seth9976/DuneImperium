using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;

namespace UnityEngine.UIElements
{
	// Token: 0x02000239 RID: 569
	public class VisualTreeStyleUpdater : BaseVisualTreeUpdater
	{
		// Token: 0x060029FB RID: 10747 RVA: 0x000B724C File Offset: 0x000B544C
		// Note: this type is marked as 'beforefieldinit'.
		static VisualTreeStyleUpdater()
		{
			Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualTreeStyleUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr);
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_ApplyStyleUpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_ApplyStyleUpdateList");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_TransitionPropertyUpdateList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_TransitionPropertyUpdateList");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_IsApplyingStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_IsApplyingStyles");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_Version");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_LastVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_LastVersion");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_m_StyleContextHierarchyTraversal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "m_StyleContextHierarchyTraversal");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "s_Description");
			VisualTreeStyleUpdater.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "s_ProfilerMarker");
			VisualTreeStyleUpdater.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, "<disposed>k__BackingField");
			VisualTreeStyleUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669586);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669587);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669588);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669589);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669590);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669591);
			VisualTreeStyleUpdater.NativeMethodInfoPtr_ApplyStyles_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669592);
			VisualTreeStyleUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr, 100669593);
		}

		// Token: 0x17000D1A RID: 3354
		// (get) Token: 0x060029FC RID: 10748 RVA: 0x000B73D0 File Offset: 0x000B55D0
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347044, XrefRangeEnd = 347048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeStyleUpdater.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000B7418 File Offset: 0x000B5618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347048, XrefRangeEnd = 347055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeStyleUpdater.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000B7474 File Offset: 0x000B5674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347055, XrefRangeEnd = 347101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeStyleUpdater.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000D1B RID: 3355
		// (get) Token: 0x060029FF RID: 10751 RVA: 0x000B74B0 File Offset: 0x000B56B0
		// (set) Token: 0x06002A00 RID: 10752 RVA: 0x000B74EC File Offset: 0x000B56EC
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdater.NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdater.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002A01 RID: 10753 RVA: 0x000B752C File Offset: 0x000B572C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347101, XrefRangeEnd = 347102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualTreeStyleUpdater.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002A02 RID: 10754 RVA: 0x000B7578 File Offset: 0x000B5778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347102, XrefRangeEnd = 347108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyStyles()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdater.NativeMethodInfoPtr_ApplyStyles_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x000B75AC File Offset: 0x000B57AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 347108, XrefRangeEnd = 347126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualTreeStyleUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualTreeStyleUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualTreeStyleUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A04 RID: 10756 RVA: 0x00010E17 File Offset: 0x0000F017
		public VisualTreeStyleUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x000B75E8 File Offset: 0x000B57E8
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x00010E20 File Offset: 0x0000F020
		public unsafe HashSet<VisualElement> m_ApplyStyleUpdateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_ApplyStyleUpdateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_ApplyStyleUpdateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x000B7618 File Offset: 0x000B5818
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x00010E3F File Offset: 0x0000F03F
		public unsafe HashSet<VisualElement> m_TransitionPropertyUpdateList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_TransitionPropertyUpdateList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<VisualElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_TransitionPropertyUpdateList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x000B7648 File Offset: 0x000B5848
		// (set) Token: 0x06002A0A RID: 10762 RVA: 0x00010E5E File Offset: 0x0000F05E
		public unsafe bool m_IsApplyingStyles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_IsApplyingStyles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_IsApplyingStyles)) = value;
			}
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002A0B RID: 10763 RVA: 0x000B7670 File Offset: 0x000B5870
		// (set) Token: 0x06002A0C RID: 10764 RVA: 0x00010E79 File Offset: 0x0000F079
		public unsafe uint m_Version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_Version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_Version)) = value;
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06002A0D RID: 10765 RVA: 0x000B7698 File Offset: 0x000B5898
		// (set) Token: 0x06002A0E RID: 10766 RVA: 0x00010E94 File Offset: 0x0000F094
		public unsafe uint m_LastVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_LastVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_LastVersion)) = value;
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x06002A0F RID: 10767 RVA: 0x000B76C0 File Offset: 0x000B58C0
		// (set) Token: 0x06002A10 RID: 10768 RVA: 0x00010EAF File Offset: 0x0000F0AF
		public unsafe VisualTreeStyleUpdaterTraversal m_StyleContextHierarchyTraversal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_StyleContextHierarchyTraversal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualTreeStyleUpdaterTraversal>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr_m_StyleContextHierarchyTraversal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x06002A11 RID: 10769 RVA: 0x000B76F0 File Offset: 0x000B58F0
		// (set) Token: 0x06002A12 RID: 10770 RVA: 0x00010ECE File Offset: 0x0000F0CE
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeStyleUpdater.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeStyleUpdater.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06002A13 RID: 10771 RVA: 0x000B7710 File Offset: 0x000B5910
		// (set) Token: 0x06002A14 RID: 10772 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualTreeStyleUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualTreeStyleUpdater.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06002A15 RID: 10773 RVA: 0x000B772C File Offset: 0x000B592C
		// (set) Token: 0x06002A16 RID: 10774 RVA: 0x00010EEE File Offset: 0x0000F0EE
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualTreeStyleUpdater.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x06002A17 RID: 10775 RVA: 0x00010F09 File Offset: 0x0000F109
		// (set) Token: 0x06002A18 RID: 10776 RVA: 0x00010F11 File Offset: 0x0000F111
		public VisualTreeStyleUpdaterTraversal traversal
		{
			get
			{
				return this.m_StyleContextHierarchyTraversal;
			}
			set
			{
				this.m_StyleContextHierarchyTraversal = value;
				BaseVisualElementPanel panel = base.panel;
				if (panel != null)
				{
					panel.visualTree.IncrementVersion(VersionChangeType.Layout | VersionChangeType.StyleSheet | VersionChangeType.Styles | VersionChangeType.Transform);
				}
			}
		}

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeFieldInfoPtr_m_ApplyStyleUpdateList;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeFieldInfoPtr_m_TransitionPropertyUpdateList;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeFieldInfoPtr_m_IsApplyingStyles;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeFieldInfoPtr_m_LastVersion;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeFieldInfoPtr_m_StyleContextHierarchyTraversal;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x04001DE7 RID: 7655
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x04001DE8 RID: 7656
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001DE9 RID: 7657
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DEA RID: 7658
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Protected_get_Boolean_0;

		// Token: 0x04001DEB RID: 7659
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x04001DEC RID: 7660
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04001DED RID: 7661
		private static readonly IntPtr NativeMethodInfoPtr_ApplyStyles_Private_Void_0;

		// Token: 0x04001DEE RID: 7662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
