using System;
using Canis.utils.ids;
using dwd.core.data;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x02000110 RID: 272
	public class WormCreateUnitViewFromEntityIDRenderer : Subscriber<IDComponent<EntityID>>
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x0003D92C File Offset: 0x0003BB2C
		// Note: this type is marked as 'beforefieldinit'.
		static WormCreateUnitViewFromEntityIDRenderer()
		{
			Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormCreateUnitViewFromEntityIDRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr);
			WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_anchorContainerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, "anchorContainerView");
			WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_containerEntityComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, "containerEntityComponent");
			WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_unitEntityComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, "unitEntityComponent");
			WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, 100665006);
			WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, 100665007);
			WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr, 100665008);
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x0003D9D4 File Offset: 0x0003BBD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704310, XrefRangeEnd = 704330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C56 RID: 3158 RVA: 0x0003DA10 File Offset: 0x0003BC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704330, XrefRangeEnd = 704338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void onDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C57 RID: 3159 RVA: 0x0003DA4C File Offset: 0x0003BC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704338, XrefRangeEnd = 704341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCreateUnitViewFromEntityIDRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCreateUnitViewFromEntityIDRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCreateUnitViewFromEntityIDRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C58 RID: 3160 RVA: 0x000087CC File Offset: 0x000069CC
		public WormCreateUnitViewFromEntityIDRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x0003DA88 File Offset: 0x0003BC88
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x000087D5 File Offset: 0x000069D5
		public unsafe ContainerView anchorContainerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_anchorContainerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_anchorContainerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x0003DAB8 File Offset: 0x0003BCB8
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x000087F4 File Offset: 0x000069F4
		public unsafe EntityComponent containerEntityComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_containerEntityComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_containerEntityComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0003DAE8 File Offset: 0x0003BCE8
		// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00008813 File Offset: 0x00006A13
		public unsafe EntityComponent unitEntityComponent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_unitEntityComponent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCreateUnitViewFromEntityIDRenderer.NativeFieldInfoPtr_unitEntityComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeFieldInfoPtr_anchorContainerView;

		// Token: 0x04000726 RID: 1830
		private static readonly IntPtr NativeFieldInfoPtr_containerEntityComponent;

		// Token: 0x04000727 RID: 1831
		private static readonly IntPtr NativeFieldInfoPtr_unitEntityComponent;

		// Token: 0x04000728 RID: 1832
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000729 RID: 1833
		private static readonly IntPtr NativeMethodInfoPtr_onDestroy_Protected_Virtual_Void_0;

		// Token: 0x0400072A RID: 1834
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
