using System;
using Canis;
using dwd.core.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace boardgames.menus.behaviours
{
	// Token: 0x020001BE RID: 446
	public class SelectedChallengeRenderer : VersionedSubscriber<SelectedData<MatchInitData>>
	{
		// Token: 0x06001418 RID: 5144 RVA: 0x0005E7A8 File Offset: 0x0005C9A8
		// Note: this type is marked as 'beforefieldinit'.
		static SelectedChallengeRenderer()
		{
			Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.behaviours", "SelectedChallengeRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr);
			SelectedChallengeRenderer.NativeFieldInfoPtr_selectedChallengeProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr, "selectedChallengeProvider");
			SelectedChallengeRenderer.NativeFieldInfoPtr_imageProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr, "imageProvider");
			SelectedChallengeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr, 100666241);
			SelectedChallengeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr, 100666242);
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x0005E828 File Offset: 0x0005CA28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 519966, XrefRangeEnd = 520067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SelectedChallengeRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0005E864 File Offset: 0x0005CA64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 520067, XrefRangeEnd = 520070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectedChallengeRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectedChallengeRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectedChallengeRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0000B748 File Offset: 0x00009948
		public SelectedChallengeRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x0600141C RID: 5148 RVA: 0x0005E8A0 File Offset: 0x0005CAA0
		// (set) Token: 0x0600141D RID: 5149 RVA: 0x0000B751 File Offset: 0x00009951
		public unsafe SubscriptionProvider selectedChallengeProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeRenderer.NativeFieldInfoPtr_selectedChallengeProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeRenderer.NativeFieldInfoPtr_selectedChallengeProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x0600141E RID: 5150 RVA: 0x0005E8D0 File Offset: 0x0005CAD0
		// (set) Token: 0x0600141F RID: 5151 RVA: 0x0000B770 File Offset: 0x00009970
		public unsafe SubscriptionProvider imageProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeRenderer.NativeFieldInfoPtr_imageProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectedChallengeRenderer.NativeFieldInfoPtr_imageProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C63 RID: 3171
		private static readonly IntPtr NativeFieldInfoPtr_selectedChallengeProvider;

		// Token: 0x04000C64 RID: 3172
		private static readonly IntPtr NativeFieldInfoPtr_imageProvider;

		// Token: 0x04000C65 RID: 3173
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000C66 RID: 3174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
