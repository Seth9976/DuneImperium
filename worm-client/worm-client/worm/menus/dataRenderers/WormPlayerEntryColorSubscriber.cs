using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using worm.components;
using worm.match.data;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000093 RID: 147
	public class WormPlayerEntryColorSubscriber : VersionedSubscriber<WormColorData>
	{
		// Token: 0x060005BB RID: 1467 RVA: 0x0002A36C File Offset: 0x0002856C
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerEntryColorSubscriber()
		{
			Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormPlayerEntryColorSubscriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr);
			WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_picker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, "picker");
			WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, "toggles");
			WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_Event_HidePicker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, 100664119);
			WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_Event_TogglePicker_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, 100664120);
			WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, 100664121);
			WormPlayerEntryColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr, 100664122);
		}

		// Token: 0x060005BC RID: 1468 RVA: 0x0002A414 File Offset: 0x00028614
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695579, RefRangeEnd = 695580, XrefRangeStart = 695577, XrefRangeEnd = 695579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HidePicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_Event_HidePicker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BD RID: 1469 RVA: 0x0002A448 File Offset: 0x00028648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695580, XrefRangeEnd = 695591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_TogglePicker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_Event_TogglePicker_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x0002A47C File Offset: 0x0002867C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695591, XrefRangeEnd = 695603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerEntryColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x0002A4B8 File Offset: 0x000286B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695603, XrefRangeEnd = 695606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerEntryColorSubscriber()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerEntryColorSubscriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerEntryColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00004DB3 File Offset: 0x00002FB3
		public WormPlayerEntryColorSubscriber(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002A4F4 File Offset: 0x000286F4
		// (set) Token: 0x060005C2 RID: 1474 RVA: 0x00004DBC File Offset: 0x00002FBC
		public unsafe GameObject picker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_picker);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_picker), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x0002A524 File Offset: 0x00028724
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00004DDB File Offset: 0x00002FDB
		public unsafe WormSelectColorToggles toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectColorToggles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerEntryColorSubscriber.NativeFieldInfoPtr_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeFieldInfoPtr_picker;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeFieldInfoPtr_toggles;

		// Token: 0x04000350 RID: 848
		private static readonly IntPtr NativeMethodInfoPtr_Event_HidePicker_Public_Void_0;

		// Token: 0x04000351 RID: 849
		private static readonly IntPtr NativeMethodInfoPtr_Event_TogglePicker_Public_Void_0;

		// Token: 0x04000352 RID: 850
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000353 RID: 851
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
