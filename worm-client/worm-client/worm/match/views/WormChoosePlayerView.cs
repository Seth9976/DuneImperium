using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.views
{
	// Token: 0x020000A9 RID: 169
	public class WormChoosePlayerView : UnitView
	{
		// Token: 0x06000688 RID: 1672 RVA: 0x0002C8D4 File Offset: 0x0002AAD4
		// Note: this type is marked as 'beforefieldinit'.
		static WormChoosePlayerView()
		{
			Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormChoosePlayerView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr);
			WormChoosePlayerView.NativeFieldInfoPtr_garrisonView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr, "garrisonView");
			WormChoosePlayerView.NativeFieldInfoPtr_deployedView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr, "deployedView");
			WormChoosePlayerView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr, 100664213);
			WormChoosePlayerView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr, 100664214);
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0002C954 File Offset: 0x0002AB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696495, XrefRangeEnd = 696508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormChoosePlayerView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0002C9B4 File Offset: 0x0002ABB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChoosePlayerView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChoosePlayerView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChoosePlayerView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000543E File Offset: 0x0000363E
		public WormChoosePlayerView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0002C9F0 File Offset: 0x0002ABF0
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x00005447 File Offset: 0x00003647
		public unsafe EntityView garrisonView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChoosePlayerView.NativeFieldInfoPtr_garrisonView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChoosePlayerView.NativeFieldInfoPtr_garrisonView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0002CA20 File Offset: 0x0002AC20
		// (set) Token: 0x0600068F RID: 1679 RVA: 0x00005466 File Offset: 0x00003666
		public unsafe EntityView deployedView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChoosePlayerView.NativeFieldInfoPtr_deployedView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChoosePlayerView.NativeFieldInfoPtr_deployedView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeFieldInfoPtr_garrisonView;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeFieldInfoPtr_deployedView;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
