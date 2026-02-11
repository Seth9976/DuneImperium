using System;
using boardgames.match.selection;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.dataRenderers
{
	// Token: 0x02000140 RID: 320
	public class WormIntrigueCardPlayableRenderer : VersionedView<DBGSelectionResponder>
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x00043778 File Offset: 0x00041978
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntrigueCardPlayableRenderer()
		{
			Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormIntrigueCardPlayableRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr);
			WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, "view");
			WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, "animator");
			WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_DimmedParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, "DimmedParam");
			WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_viewManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, "viewManager");
			WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, "entities");
			WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, 100665247);
			WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, 100665248);
			WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr, 100665249);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00043848 File Offset: 0x00041A48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706539, XrefRangeEnd = 706553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00043884 File Offset: 0x00041A84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706553, XrefRangeEnd = 706606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x000438C0 File Offset: 0x00041AC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 706606, XrefRangeEnd = 706609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntrigueCardPlayableRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueCardPlayableRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardPlayableRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x0000991F File Offset: 0x00007B1F
		public WormIntrigueCardPlayableRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000E67 RID: 3687 RVA: 0x000438FC File Offset: 0x00041AFC
		// (set) Token: 0x06000E68 RID: 3688 RVA: 0x00009928 File Offset: 0x00007B28
		public unsafe EntityView view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x0004392C File Offset: 0x00041B2C
		// (set) Token: 0x06000E6A RID: 3690 RVA: 0x00009947 File Offset: 0x00007B47
		public unsafe Animator animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000E6B RID: 3691 RVA: 0x0004395C File Offset: 0x00041B5C
		// (set) Token: 0x06000E6C RID: 3692 RVA: 0x00009966 File Offset: 0x00007B66
		public unsafe static int DimmedParam
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_DimmedParam, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_DimmedParam, (void*)(&value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x00043978 File Offset: 0x00041B78
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00009974 File Offset: 0x00007B74
		public unsafe ViewManager viewManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_viewManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ViewManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_viewManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000E6F RID: 3695 RVA: 0x000439A8 File Offset: 0x00041BA8
		// (set) Token: 0x06000E70 RID: 3696 RVA: 0x00009993 File Offset: 0x00007B93
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardPlayableRenderer.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_animator;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr_DimmedParam;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr_viewManager;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
