using System;
using boardgames.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;
using UnityEngine;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000092 RID: 146
	public class WormMinRepRenderer : VersionedSubscriber<PendingGameData>
	{
		// Token: 0x060005B3 RID: 1459 RVA: 0x0002A214 File Offset: 0x00028414
		// Note: this type is marked as 'beforefieldinit'.
		static WormMinRepRenderer()
		{
			Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormMinRepRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr);
			WormMinRepRenderer.NativeFieldInfoPtr_reputationIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr, "reputationIcon");
			WormMinRepRenderer.NativeFieldInfoPtr_reputationText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr, "reputationText");
			WormMinRepRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr, 100664117);
			WormMinRepRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr, 100664118);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002A294 File Offset: 0x00028494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695565, XrefRangeEnd = 695574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormMinRepRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x0002A2D0 File Offset: 0x000284D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695574, XrefRangeEnd = 695577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormMinRepRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormMinRepRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormMinRepRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00004D6C File Offset: 0x00002F6C
		public WormMinRepRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002A30C File Offset: 0x0002850C
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00004D75 File Offset: 0x00002F75
		public unsafe GameObject reputationIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMinRepRenderer.NativeFieldInfoPtr_reputationIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMinRepRenderer.NativeFieldInfoPtr_reputationIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005B9 RID: 1465 RVA: 0x0002A33C File Offset: 0x0002853C
		// (set) Token: 0x060005BA RID: 1466 RVA: 0x00004D94 File Offset: 0x00002F94
		public unsafe TMP_Text reputationText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMinRepRenderer.NativeFieldInfoPtr_reputationText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormMinRepRenderer.NativeFieldInfoPtr_reputationText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeFieldInfoPtr_reputationIcon;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeFieldInfoPtr_reputationText;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
