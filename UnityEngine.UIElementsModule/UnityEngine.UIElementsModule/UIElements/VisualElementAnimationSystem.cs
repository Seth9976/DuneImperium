using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Unity.Profiling;
using UnityEngine.UIElements.Experimental;

namespace UnityEngine.UIElements
{
	// Token: 0x02000234 RID: 564
	public class VisualElementAnimationSystem : BaseVisualTreeUpdater
	{
		// Token: 0x060029AF RID: 10671 RVA: 0x000B628C File Offset: 0x000B448C
		// Note: this type is marked as 'beforefieldinit'.
		static VisualElementAnimationSystem()
		{
			Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "VisualElementAnimationSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr);
			VisualElementAnimationSystem.NativeFieldInfoPtr_m_Animations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "m_Animations");
			VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "m_IterationList");
			VisualElementAnimationSystem.NativeFieldInfoPtr_m_HasNewAnimations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "m_HasNewAnimations");
			VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationListDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "m_IterationListDirty");
			VisualElementAnimationSystem.NativeFieldInfoPtr_s_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "s_Description");
			VisualElementAnimationSystem.NativeFieldInfoPtr_s_ProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "s_ProfilerMarker");
			VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "s_StylePropertyAnimationDescription");
			VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationProfilerMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "s_StylePropertyAnimationProfilerMarker");
			VisualElementAnimationSystem.NativeFieldInfoPtr_lastUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, "lastUpdate");
			VisualElementAnimationSystem.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669555);
			VisualElementAnimationSystem.NativeMethodInfoPtr_get_stylePropertyAnimationProfilerMarker_Private_Static_get_ProfilerMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669556);
			VisualElementAnimationSystem.NativeMethodInfoPtr_UnregisterAnimation_Public_Void_IValueAnimationUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669557);
			VisualElementAnimationSystem.NativeMethodInfoPtr_UnregisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669558);
			VisualElementAnimationSystem.NativeMethodInfoPtr_RegisterAnimation_Public_Void_IValueAnimationUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669559);
			VisualElementAnimationSystem.NativeMethodInfoPtr_RegisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669560);
			VisualElementAnimationSystem.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669561);
			VisualElementAnimationSystem.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669562);
			VisualElementAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr, 100669563);
		}

		// Token: 0x17000D04 RID: 3332
		// (get) Token: 0x060029B0 RID: 10672 RVA: 0x000B6424 File Offset: 0x000B4624
		public unsafe override ProfilerMarker profilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346795, XrefRangeEnd = 346799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElementAnimationSystem.NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000D05 RID: 3333
		// (get) Token: 0x060029B1 RID: 10673 RVA: 0x000B646C File Offset: 0x000B466C
		public unsafe static ProfilerMarker stylePropertyAnimationProfilerMarker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346799, XrefRangeEnd = 346803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr_get_stylePropertyAnimationProfilerMarker_Private_Static_get_ProfilerMarker_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x000B649C File Offset: 0x000B469C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346806, RefRangeEnd = 346807, XrefRangeStart = 346803, XrefRangeEnd = 346806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr_UnregisterAnimation_Public_Void_IValueAnimationUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B3 RID: 10675 RVA: 0x000B64E0 File Offset: 0x000B46E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346824, RefRangeEnd = 346825, XrefRangeStart = 346807, XrefRangeEnd = 346824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnregisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr_UnregisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B4 RID: 10676 RVA: 0x000B6524 File Offset: 0x000B4724
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 346828, RefRangeEnd = 346829, XrefRangeStart = 346825, XrefRangeEnd = 346828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAnimation(UnityEngine.UIElements.Experimental.IValueAnimationUpdate anim)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anim);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr_RegisterAnimation_Public_Void_IValueAnimationUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x000B6568 File Offset: 0x000B4768
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 346846, RefRangeEnd = 346848, XrefRangeStart = 346829, XrefRangeEnd = 346846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterAnimations(List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> anims)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(anims);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr_RegisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x000B65AC File Offset: 0x000B47AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346848, XrefRangeEnd = 346892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElementAnimationSystem.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x000B65E8 File Offset: 0x000B47E8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VisualElementAnimationSystem.NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x000B6644 File Offset: 0x000B4844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 346892, XrefRangeEnd = 346907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VisualElementAnimationSystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VisualElementAnimationSystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualElementAnimationSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x00010C3F File Offset: 0x0000EE3F
		public VisualElementAnimationSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CFB RID: 3323
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x000B6680 File Offset: 0x000B4880
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x00010C48 File Offset: 0x0000EE48
		public unsafe HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_Animations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_Animations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_Animations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFC RID: 3324
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x000B66B0 File Offset: 0x000B48B0
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x00010C67 File Offset: 0x0000EE67
		public unsafe List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate> m_IterationList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<UnityEngine.UIElements.Experimental.IValueAnimationUpdate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CFD RID: 3325
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x000B66E0 File Offset: 0x000B48E0
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x00010C86 File Offset: 0x0000EE86
		public unsafe bool m_HasNewAnimations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_HasNewAnimations);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_HasNewAnimations)) = value;
			}
		}

		// Token: 0x17000CFE RID: 3326
		// (get) Token: 0x060029C0 RID: 10688 RVA: 0x000B6708 File Offset: 0x000B4908
		// (set) Token: 0x060029C1 RID: 10689 RVA: 0x00010CA1 File Offset: 0x0000EEA1
		public unsafe bool m_IterationListDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationListDirty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_m_IterationListDirty)) = value;
			}
		}

		// Token: 0x17000CFF RID: 3327
		// (get) Token: 0x060029C2 RID: 10690 RVA: 0x000B6730 File Offset: 0x000B4930
		// (set) Token: 0x060029C3 RID: 10691 RVA: 0x00010CBC File Offset: 0x0000EEBC
		public unsafe static string s_Description
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_Description, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_Description, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000B6750 File Offset: 0x000B4950
		// (set) Token: 0x060029C5 RID: 10693 RVA: 0x00010CCE File Offset: 0x0000EECE
		public unsafe static ProfilerMarker s_ProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_ProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060029C6 RID: 10694 RVA: 0x000B676C File Offset: 0x000B496C
		// (set) Token: 0x060029C7 RID: 10695 RVA: 0x00010CDC File Offset: 0x0000EEDC
		public unsafe static string s_StylePropertyAnimationDescription
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationDescription, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationDescription, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060029C8 RID: 10696 RVA: 0x000B678C File Offset: 0x000B498C
		// (set) Token: 0x060029C9 RID: 10697 RVA: 0x00010CEE File Offset: 0x0000EEEE
		public unsafe static ProfilerMarker s_StylePropertyAnimationProfilerMarker
		{
			get
			{
				ProfilerMarker profilerMarker;
				IL2CPP.il2cpp_field_static_get_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationProfilerMarker, (void*)(&profilerMarker));
				return profilerMarker;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(VisualElementAnimationSystem.NativeFieldInfoPtr_s_StylePropertyAnimationProfilerMarker, (void*)(&value));
			}
		}

		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x060029CA RID: 10698 RVA: 0x000B67A8 File Offset: 0x000B49A8
		// (set) Token: 0x060029CB RID: 10699 RVA: 0x00010CFC File Offset: 0x0000EEFC
		public unsafe long lastUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_lastUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualElementAnimationSystem.NativeFieldInfoPtr_lastUpdate)) = value;
			}
		}

		// Token: 0x060029CC RID: 10700 RVA: 0x000B67D0 File Offset: 0x000B49D0
		public long CurrentTimeMs()
		{
			return Panel.TimeSinceStartupMs();
		}

		// Token: 0x04001DAB RID: 7595
		private static readonly IntPtr NativeFieldInfoPtr_m_Animations;

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeFieldInfoPtr_m_IterationList;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeFieldInfoPtr_m_HasNewAnimations;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeFieldInfoPtr_m_IterationListDirty;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeFieldInfoPtr_s_Description;

		// Token: 0x04001DB0 RID: 7600
		private static readonly IntPtr NativeFieldInfoPtr_s_ProfilerMarker;

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_s_StylePropertyAnimationDescription;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeFieldInfoPtr_s_StylePropertyAnimationProfilerMarker;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeFieldInfoPtr_lastUpdate;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_get_profilerMarker_Public_Virtual_get_ProfilerMarker_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_get_stylePropertyAnimationProfilerMarker_Private_Static_get_ProfilerMarker_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterAnimation_Public_Void_IValueAnimationUpdate_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAnimation_Public_Void_IValueAnimationUpdate_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_RegisterAnimations_Public_Void_List_1_IValueAnimationUpdate_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001DBB RID: 7611
		private static readonly IntPtr NativeMethodInfoPtr_OnVersionChanged_Public_Virtual_Void_VisualElement_VersionChangeType_0;

		// Token: 0x04001DBC RID: 7612
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
