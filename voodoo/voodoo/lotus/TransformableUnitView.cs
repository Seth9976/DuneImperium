using System;
using dwd.core.match;
using dwd.core.prefabs.implementations.byflavor;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using voodoo.flavors;

namespace lotus
{
	// Token: 0x02000078 RID: 120
	public class TransformableUnitView : UnitView
	{
		// Token: 0x06000712 RID: 1810 RVA: 0x00020D88 File Offset: 0x0001EF88
		// Note: this type is marked as 'beforefieldinit'.
		static TransformableUnitView()
		{
			Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "TransformableUnitView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr);
			TransformableUnitView.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "container");
			TransformableUnitView.NativeFieldInfoPtr_prefabLoader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "prefabLoader");
			TransformableUnitView.NativeFieldInfoPtr_subView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "subView");
			TransformableUnitView.NativeFieldInfoPtr_currentPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "currentPrefab");
			TransformableUnitView.NativeFieldInfoPtr_parentPileFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "parentPileFlavors");
			TransformableUnitView.NativeFieldInfoPtr_cachedContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, "cachedContext");
			TransformableUnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664268);
			TransformableUnitView.NativeMethodInfoPtr_RespawnSubview_Public_Void_IPileFlavors_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664269);
			TransformableUnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664270);
			TransformableUnitView.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664271);
			TransformableUnitView.NativeMethodInfoPtr_AddPosition_Public_Virtual_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664272);
			TransformableUnitView.NativeMethodInfoPtr_RemovePosition_Public_Virtual_Void_UnitPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664273);
			TransformableUnitView.NativeMethodInfoPtr_UpdateSubviewPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664274);
			TransformableUnitView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664275);
			TransformableUnitView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr, 100664276);
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00020EE4 File Offset: 0x0001F0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114083, XrefRangeEnd = 1114088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityComponent ec, EntityView p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformableUnitView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x00020F44 File Offset: 0x0001F144
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1114148, RefRangeEnd = 1114152, XrefRangeStart = 1114088, XrefRangeEnd = 1114148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RespawnSubview(IPileFlavors pileFlavors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pileFlavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformableUnitView.NativeMethodInfoPtr_RespawnSubview_Public_Void_IPileFlavors_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00020F88 File Offset: 0x0001F188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114152, XrefRangeEnd = 1114162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformableUnitView.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00020FC4 File Offset: 0x0001F1C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114162, XrefRangeEnd = 1114163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTransformParentChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformableUnitView.NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00020FF8 File Offset: 0x0001F1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114163, XrefRangeEnd = 1114165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void AddPosition(UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformableUnitView.NativeMethodInfoPtr_AddPosition_Public_Virtual_Void_UnitPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00021048 File Offset: 0x0001F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114165, XrefRangeEnd = 1114167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RemovePosition(UnitPosition position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(position);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformableUnitView.NativeMethodInfoPtr_RemovePosition_Public_Virtual_Void_UnitPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00021098 File Offset: 0x0001F298
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1114174, RefRangeEnd = 1114176, XrefRangeStart = 1114167, XrefRangeEnd = 1114174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSubviewPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformableUnitView.NativeMethodInfoPtr_UpdateSubviewPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x000210CC File Offset: 0x0001F2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114176, XrefRangeEnd = 1114179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDespawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransformableUnitView.NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0002111C File Offset: 0x0001F31C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransformableUnitView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransformableUnitView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransformableUnitView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x000057A5 File Offset: 0x000039A5
		public TransformableUnitView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00021158 File Offset: 0x0001F358
		// (set) Token: 0x0600071E RID: 1822 RVA: 0x000057AE File Offset: 0x000039AE
		public unsafe Transform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600071F RID: 1823 RVA: 0x00021188 File Offset: 0x0001F388
		// (set) Token: 0x06000720 RID: 1824 RVA: 0x000057CD File Offset: 0x000039CD
		public unsafe PrefabByFlavorLoader prefabLoader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_prefabLoader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrefabByFlavorLoader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_prefabLoader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000721 RID: 1825 RVA: 0x000211B8 File Offset: 0x0001F3B8
		// (set) Token: 0x06000722 RID: 1826 RVA: 0x000057EC File Offset: 0x000039EC
		public unsafe EntityView subView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_subView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_subView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000723 RID: 1827 RVA: 0x000211E8 File Offset: 0x0001F3E8
		// (set) Token: 0x06000724 RID: 1828 RVA: 0x0000580B File Offset: 0x00003A0B
		public unsafe GameObject currentPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_currentPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_currentPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00021218 File Offset: 0x0001F418
		// (set) Token: 0x06000726 RID: 1830 RVA: 0x0000582A File Offset: 0x00003A2A
		public unsafe IPileFlavors parentPileFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_parentPileFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPileFlavors>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_parentPileFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00021248 File Offset: 0x0001F448
		// (set) Token: 0x06000728 RID: 1832 RVA: 0x00005849 File Offset: 0x00003A49
		public PrefabFlavorContext cachedContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_cachedContext);
				return new PrefabFlavorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransformableUnitView.NativeFieldInfoPtr_cachedContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PrefabFlavorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400046F RID: 1135
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04000470 RID: 1136
		private static readonly IntPtr NativeFieldInfoPtr_prefabLoader;

		// Token: 0x04000471 RID: 1137
		private static readonly IntPtr NativeFieldInfoPtr_subView;

		// Token: 0x04000472 RID: 1138
		private static readonly IntPtr NativeFieldInfoPtr_currentPrefab;

		// Token: 0x04000473 RID: 1139
		private static readonly IntPtr NativeFieldInfoPtr_parentPileFlavors;

		// Token: 0x04000474 RID: 1140
		private static readonly IntPtr NativeFieldInfoPtr_cachedContext;

		// Token: 0x04000475 RID: 1141
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x04000476 RID: 1142
		private static readonly IntPtr NativeMethodInfoPtr_RespawnSubview_Public_Void_IPileFlavors_0;

		// Token: 0x04000477 RID: 1143
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x04000478 RID: 1144
		private static readonly IntPtr NativeMethodInfoPtr_OnTransformParentChanged_Private_Void_0;

		// Token: 0x04000479 RID: 1145
		private static readonly IntPtr NativeMethodInfoPtr_AddPosition_Public_Virtual_Void_UnitPosition_0;

		// Token: 0x0400047A RID: 1146
		private static readonly IntPtr NativeMethodInfoPtr_RemovePosition_Public_Virtual_Void_UnitPosition_0;

		// Token: 0x0400047B RID: 1147
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSubviewPosition_Private_Void_0;

		// Token: 0x0400047C RID: 1148
		private static readonly IntPtr NativeMethodInfoPtr_OnDespawn_Public_Virtual_Void_PoolableItem_0;

		// Token: 0x0400047D RID: 1149
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
