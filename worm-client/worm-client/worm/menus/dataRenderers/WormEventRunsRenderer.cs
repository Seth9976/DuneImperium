using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using worm.components;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008B RID: 139
	public class WormEventRunsRenderer : VersionedView<WormEventsProvider>
	{
		// Token: 0x0600056F RID: 1391 RVA: 0x000295D8 File Offset: 0x000277D8
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventRunsRenderer()
		{
			Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventRunsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr);
			WormEventRunsRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, "display");
			WormEventRunsRenderer.NativeFieldInfoPtr_eventDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, "eventDataProvider");
			WormEventRunsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, 100664075);
			WormEventRunsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, 100664076);
			WormEventRunsRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, 100664077);
			WormEventRunsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr, 100664078);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00029680 File Offset: 0x00027880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695113, XrefRangeEnd = 695123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventRunsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000296BC File Offset: 0x000278BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695123, XrefRangeEnd = 695127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventRunsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x000296F8 File Offset: 0x000278F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695150, RefRangeEnd = 695151, XrefRangeStart = 695127, XrefRangeEnd = 695150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getDisplayText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventRunsRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00029730 File Offset: 0x00027930
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695151, XrefRangeEnd = 695154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventRunsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventRunsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventRunsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00004B2F File Offset: 0x00002D2F
		public WormEventRunsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0002976C File Offset: 0x0002796C
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x00004B38 File Offset: 0x00002D38
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventRunsRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventRunsRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0002979C File Offset: 0x0002799C
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x00004B57 File Offset: 0x00002D57
		public unsafe SubscriptionProvider eventDataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventRunsRenderer.NativeFieldInfoPtr_eventDataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventRunsRenderer.NativeFieldInfoPtr_eventDataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_eventDataProvider;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_getDisplayText_Private_String_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
