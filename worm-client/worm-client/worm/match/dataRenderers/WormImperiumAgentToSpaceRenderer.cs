using System;
using boardgames.hints;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.dataRenderers
{
	// Token: 0x0200013E RID: 318
	public class WormImperiumAgentToSpaceRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000E4C RID: 3660 RVA: 0x00043394 File Offset: 0x00041594
		// Note: this type is marked as 'beforefieldinit'.
		static WormImperiumAgentToSpaceRenderer()
		{
			Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormImperiumAgentToSpaceRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr);
			WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, "view");
			WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_wasSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, "wasSelected");
			WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, "viewManager");
			WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_hintManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, "hintManager");
			WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, 100665235);
			WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, 100665236);
			WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr, 100665237);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x00043450 File Offset: 0x00041650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706441, XrefRangeEnd = 706453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x0004348C File Offset: 0x0004168C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706453, XrefRangeEnd = 706503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000434C8 File Offset: 0x000416C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706503, XrefRangeEnd = 706506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormImperiumAgentToSpaceRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormImperiumAgentToSpaceRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormImperiumAgentToSpaceRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x00009857 File Offset: 0x00007A57
		public WormImperiumAgentToSpaceRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000E51 RID: 3665 RVA: 0x00043504 File Offset: 0x00041704
		// (set) Token: 0x06000E52 RID: 3666 RVA: 0x00009860 File Offset: 0x00007A60
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000E53 RID: 3667 RVA: 0x00043534 File Offset: 0x00041734
		// (set) Token: 0x06000E54 RID: 3668 RVA: 0x0000987F File Offset: 0x00007A7F
		public unsafe bool wasSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_wasSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_wasSelected)) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0004355C File Offset: 0x0004175C
		// (set) Token: 0x06000E56 RID: 3670 RVA: 0x0000989A File Offset: 0x00007A9A
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0004358C File Offset: 0x0004178C
		// (set) Token: 0x06000E58 RID: 3672 RVA: 0x000098B9 File Offset: 0x00007AB9
		public unsafe DBGHintManager hintManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_hintManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGHintManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormImperiumAgentToSpaceRenderer.NativeFieldInfoPtr_hintManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_wasSelected;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_hintManager;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
