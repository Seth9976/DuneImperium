using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;

namespace worm.match.views
{
	// Token: 0x020000A8 RID: 168
	public class WormCardView : UnitView
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x0002C79C File Offset: 0x0002A99C
		// Note: this type is marked as 'beforefieldinit'.
		static WormCardView()
		{
			Il2CppClassPointerStore<WormCardView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.views", "WormCardView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormCardView>.NativeClassPtr);
			WormCardView.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormCardView>.NativeClassPtr, "container");
			WormCardView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardView>.NativeClassPtr, 100664211);
			WormCardView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormCardView>.NativeClassPtr, 100664212);
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0002C808 File Offset: 0x0002AA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 696464, XrefRangeEnd = 696495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormCardView.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0002C868 File Offset: 0x0002AA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormCardView()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormCardView>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormCardView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x00005416 File Offset: 0x00003616
		public WormCardView(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
		// (set) Token: 0x06000687 RID: 1671 RVA: 0x0000541F File Offset: 0x0000361F
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardView.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormCardView.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityComponent_EntityView_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
