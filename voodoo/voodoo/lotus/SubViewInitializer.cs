using System;
using dwd.core.match;
using dwd.core.match.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000077 RID: 119
	public class SubViewInitializer : Observer
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00020AB8 File Offset: 0x0001ECB8
		// Note: this type is marked as 'beforefieldinit'.
		static SubViewInitializer()
		{
			Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "SubViewInitializer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr);
			SubViewInitializer.NativeFieldInfoPtr_subViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, "subViews");
			SubViewInitializer.NativeFieldInfoPtr_entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, "entity");
			SubViewInitializer.NativeFieldInfoPtr_entityProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, "entityProvider");
			SubViewInitializer.NativeFieldInfoPtr_poolableItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, "poolableItem");
			SubViewInitializer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, 100664263);
			SubViewInitializer.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, 100664264);
			SubViewInitializer.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, 100664265);
			SubViewInitializer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, 100664266);
			SubViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr, 100664267);
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00020B9C File Offset: 0x0001ED9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114034, XrefRangeEnd = 1114047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubViewInitializer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00020BD8 File Offset: 0x0001EDD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114047, XrefRangeEnd = 1114049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void onDespawn(PoolableItem p)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubViewInitializer.NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00020C1C File Offset: 0x0001EE1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubViewInitializer.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00020C50 File Offset: 0x0001EE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114049, XrefRangeEnd = 1114083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SubViewInitializer.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00020C8C File Offset: 0x0001EE8C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SubViewInitializer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SubViewInitializer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SubViewInitializer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00005720 File Offset: 0x00003920
		public SubViewInitializer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x00020CC8 File Offset: 0x0001EEC8
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005729 File Offset: 0x00003929
		public unsafe List<EntityView> subViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_subViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EntityView>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_subViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600070C RID: 1804 RVA: 0x00020CF8 File Offset: 0x0001EEF8
		// (set) Token: 0x0600070D RID: 1805 RVA: 0x00005748 File Offset: 0x00003948
		public unsafe EntityComponent entity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_entity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_entity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600070E RID: 1806 RVA: 0x00020D28 File Offset: 0x0001EF28
		// (set) Token: 0x0600070F RID: 1807 RVA: 0x00005767 File Offset: 0x00003967
		public unsafe EntitiesProvider entityProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_entityProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_entityProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000710 RID: 1808 RVA: 0x00020D58 File Offset: 0x0001EF58
		// (set) Token: 0x06000711 RID: 1809 RVA: 0x00005786 File Offset: 0x00003986
		public unsafe PoolableItem poolableItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_poolableItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SubViewInitializer.NativeFieldInfoPtr_poolableItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000466 RID: 1126
		private static readonly IntPtr NativeFieldInfoPtr_subViews;

		// Token: 0x04000467 RID: 1127
		private static readonly IntPtr NativeFieldInfoPtr_entity;

		// Token: 0x04000468 RID: 1128
		private static readonly IntPtr NativeFieldInfoPtr_entityProvider;

		// Token: 0x04000469 RID: 1129
		private static readonly IntPtr NativeFieldInfoPtr_poolableItem;

		// Token: 0x0400046A RID: 1130
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400046B RID: 1131
		private static readonly IntPtr NativeMethodInfoPtr_onDespawn_Private_Void_PoolableItem_0;

		// Token: 0x0400046C RID: 1132
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x0400046D RID: 1133
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x0400046E RID: 1134
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
