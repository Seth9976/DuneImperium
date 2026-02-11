using System;
using boardgames.ranked.menus;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000095 RID: 149
	public class WormRankedFormatRenderer : VersionedView<RankedPlayProvider>
	{
		// Token: 0x060005CE RID: 1486 RVA: 0x0002A6FC File Offset: 0x000288FC
		// Note: this type is marked as 'beforefieldinit'.
		static WormRankedFormatRenderer()
		{
			Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormRankedFormatRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr);
			WormRankedFormatRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr, "display");
			WormRankedFormatRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr, 100664126);
			WormRankedFormatRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr, 100664127);
			WormRankedFormatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr, 100664128);
		}

		// Token: 0x060005CF RID: 1487 RVA: 0x0002A77C File Offset: 0x0002897C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695634, XrefRangeEnd = 695644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedFormatRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x0002A7B8 File Offset: 0x000289B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695644, XrefRangeEnd = 695678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormRankedFormatRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D1 RID: 1489 RVA: 0x0002A7F4 File Offset: 0x000289F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695678, XrefRangeEnd = 695681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormRankedFormatRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormRankedFormatRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormRankedFormatRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005D2 RID: 1490 RVA: 0x00004E41 File Offset: 0x00003041
		public WormRankedFormatRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x0002A830 File Offset: 0x00028A30
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004E4A File Offset: 0x0000304A
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedFormatRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormRankedFormatRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000359 RID: 857
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400035C RID: 860
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
