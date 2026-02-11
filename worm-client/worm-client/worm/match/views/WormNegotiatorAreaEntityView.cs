using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace worm.match.views
{
	// Token: 0x020000AE RID: 174
	public class WormNegotiatorAreaEntityView : EntityView
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0002D2C8 File Offset: 0x0002B4C8
		// Note: this type is marked as 'beforefieldinit'.
		static WormNegotiatorAreaEntityView()
		{
			Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormNegotiatorAreaEntityView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr);
			WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player1NegotiatorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, "player1NegotiatorView");
			WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player2NegotiatorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, "player2NegotiatorView");
			WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player3NegotiatorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, "player3NegotiatorView");
			WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player4NegotiatorView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, "player4NegotiatorView");
			WormNegotiatorAreaEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, 100664240);
			WormNegotiatorAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr, 100664241);
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0002D370 File Offset: 0x0002B570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696751, XrefRangeEnd = 696770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormNegotiatorAreaEntityView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0002D3D0 File Offset: 0x0002B5D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormNegotiatorAreaEntityView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormNegotiatorAreaEntityView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormNegotiatorAreaEntityView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000055FE File Offset: 0x000037FE
		public WormNegotiatorAreaEntityView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0002D40C File Offset: 0x0002B60C
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00005607 File Offset: 0x00003807
		public unsafe ContainerView player1NegotiatorView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player1NegotiatorView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player1NegotiatorView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0002D43C File Offset: 0x0002B63C
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00005626 File Offset: 0x00003826
		public unsafe ContainerView player2NegotiatorView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player2NegotiatorView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player2NegotiatorView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060006C2 RID: 1730 RVA: 0x0002D46C File Offset: 0x0002B66C
		// (set) Token: 0x060006C3 RID: 1731 RVA: 0x00005645 File Offset: 0x00003845
		public unsafe ContainerView player3NegotiatorView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player3NegotiatorView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player3NegotiatorView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0002D49C File Offset: 0x0002B69C
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x00005664 File Offset: 0x00003864
		public unsafe ContainerView player4NegotiatorView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player4NegotiatorView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormNegotiatorAreaEntityView.NativeFieldInfoPtr_player4NegotiatorView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003DB RID: 987
		private static readonly IntPtr NativeFieldInfoPtr_player1NegotiatorView;

		// Token: 0x040003DC RID: 988
		private static readonly IntPtr NativeFieldInfoPtr_player2NegotiatorView;

		// Token: 0x040003DD RID: 989
		private static readonly IntPtr NativeFieldInfoPtr_player3NegotiatorView;

		// Token: 0x040003DE RID: 990
		private static readonly IntPtr NativeFieldInfoPtr_player4NegotiatorView;

		// Token: 0x040003DF RID: 991
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040003E0 RID: 992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
