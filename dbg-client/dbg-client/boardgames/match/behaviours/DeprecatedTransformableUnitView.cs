using System;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace boardgames.match.behaviours
{
	// Token: 0x02000288 RID: 648
	public class DeprecatedTransformableUnitView : Observer
	{
		// Token: 0x06001E75 RID: 7797 RVA: 0x00082F7C File Offset: 0x0008117C
		// Note: this type is marked as 'beforefieldinit'.
		static DeprecatedTransformableUnitView()
		{
			Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.behaviours", "DeprecatedTransformableUnitView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr);
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "container");
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_subView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "subView");
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "prefabLoader");
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_currentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "currentPrefab");
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "updateManager");
			DeprecatedTransformableUnitView.NativeFieldInfoPtr_requesterFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, "requesterFlavors");
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668286);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668287);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668288);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668289);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668290);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_createSubView_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668291);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr_updatePositionLayer_Private_Void_UnitView_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668292);
			DeprecatedTransformableUnitView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr, 100668293);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x000830C4 File Offset: 0x000812C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539005, XrefRangeEnd = 539008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x000830F8 File Offset: 0x000812F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539008, XrefRangeEnd = 539044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeprecatedTransformableUnitView.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x00083134 File Offset: 0x00081334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539044, XrefRangeEnd = 539138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DeprecatedTransformableUnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x00083170 File Offset: 0x00081370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539138, XrefRangeEnd = 539140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x000831A4 File Offset: 0x000813A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539140, XrefRangeEnd = 539141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x000831E8 File Offset: 0x000813E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539141, XrefRangeEnd = 539152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void createSubView()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr_createSubView_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0008321C File Offset: 0x0008141C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539152, XrefRangeEnd = 539156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updatePositionLayer(UnitView unit, UnitPosition unitPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(unit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unitPosition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr_updatePositionLayer_Private_Void_UnitView_UnitPosition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x00083270 File Offset: 0x00081470
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeprecatedTransformableUnitView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeprecatedTransformableUnitView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeprecatedTransformableUnitView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x00010171 File Offset: 0x0000E371
		public DeprecatedTransformableUnitView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x000832AC File Offset: 0x000814AC
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0001017A File Offset: 0x0000E37A
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x000832DC File Offset: 0x000814DC
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x00010199 File Offset: 0x0000E399
		public unsafe UnitView subView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_subView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_subView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x0008330C File Offset: 0x0008150C
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x0008333C File Offset: 0x0008153C
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x000101D7 File Offset: 0x0000E3D7
		public unsafe UnitView currentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_currentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_currentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x0008336C File Offset: 0x0008156C
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x000101F6 File Offset: 0x0000E3F6
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x0008339C File Offset: 0x0008159C
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x00010215 File Offset: 0x0000E415
		public unsafe Component requesterFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_requesterFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Component>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DeprecatedTransformableUnitView.NativeFieldInfoPtr_requesterFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeFieldInfoPtr_subView;

		// Token: 0x0400133D RID: 4925
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x0400133E RID: 4926
		private static readonly IntPtr NativeFieldInfoPtr_currentPrefab;

		// Token: 0x0400133F RID: 4927
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x04001340 RID: 4928
		private static readonly IntPtr NativeFieldInfoPtr_requesterFlavors;

		// Token: 0x04001341 RID: 4929
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04001342 RID: 4930
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04001343 RID: 4931
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04001344 RID: 4932
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x04001345 RID: 4933
		private static readonly IntPtr NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0;

		// Token: 0x04001346 RID: 4934
		private static readonly IntPtr NativeMethodInfoPtr_createSubView_Private_Void_0;

		// Token: 0x04001347 RID: 4935
		private static readonly IntPtr NativeMethodInfoPtr_updatePositionLayer_Private_Void_UnitView_UnitPosition_0;

		// Token: 0x04001348 RID: 4936
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
