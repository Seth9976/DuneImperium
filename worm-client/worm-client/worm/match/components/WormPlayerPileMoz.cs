using System;
using boardgames.moz;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;
using UnityEngine;
using UnityEngine.EventSystems;

namespace worm.match.components
{
	// Token: 0x02000208 RID: 520
	public class WormPlayerPileMoz : DBGTooltip
	{
		// Token: 0x06001701 RID: 5889 RVA: 0x0005DE14 File Offset: 0x0005C014
		// Note: this type is marked as 'beforefieldinit'.
		static WormPlayerPileMoz()
		{
			Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormPlayerPileMoz");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr);
			WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, "mozContainerPrefab");
			WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, "mozContainerInstance");
			WormPlayerPileMoz.NativeFieldInfoPtr_overlayCanvasRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, "overlayCanvasRect");
			WormPlayerPileMoz.NativeFieldInfoPtr_mozPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, "mozPile");
			WormPlayerPileMoz.NativeFieldInfoPtr_tooltipActive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, "tooltipActive");
			WormPlayerPileMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, 100666491);
			WormPlayerPileMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, 100666492);
			WormPlayerPileMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, 100666493);
			WormPlayerPileMoz.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr, 100666494);
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0005DEF8 File Offset: 0x0005C0F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717037, XrefRangeEnd = 717043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerPileMoz.NativeMethodInfoPtr_Start_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0005DF34 File Offset: 0x0005C134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717043, XrefRangeEnd = 717064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initMoz(PointerEventData eventData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerPileMoz.NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0005DF84 File Offset: 0x0005C184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717064, XrefRangeEnd = 717075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void endMoz()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlayerPileMoz.NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0005DFC0 File Offset: 0x0005C1C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717075, XrefRangeEnd = 717076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormPlayerPileMoz()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlayerPileMoz>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlayerPileMoz.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		public WormPlayerPileMoz(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0005DFFC File Offset: 0x0005C1FC
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000DCD9 File Offset: 0x0000BED9
		public unsafe GameObject mozContainerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0005E02C File Offset: 0x0005C22C
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000DCF8 File Offset: 0x0000BEF8
		public unsafe GameObject mozContainerInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozContainerInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0005E05C File Offset: 0x0005C25C
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000DD17 File Offset: 0x0000BF17
		public unsafe RectTransform overlayCanvasRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_overlayCanvasRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_overlayCanvasRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0005E08C File Offset: 0x0005C28C
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000DD36 File Offset: 0x0000BF36
		public unsafe ContainerView mozPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_mozPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0005E0BC File Offset: 0x0005C2BC
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000DD55 File Offset: 0x0000BF55
		public unsafe bool tooltipActive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_tooltipActive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlayerPileMoz.NativeFieldInfoPtr_tooltipActive)) = value;
			}
		}

		// Token: 0x04000D59 RID: 3417
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerPrefab;

		// Token: 0x04000D5A RID: 3418
		private static readonly IntPtr NativeFieldInfoPtr_mozContainerInstance;

		// Token: 0x04000D5B RID: 3419
		private static readonly IntPtr NativeFieldInfoPtr_overlayCanvasRect;

		// Token: 0x04000D5C RID: 3420
		private static readonly IntPtr NativeFieldInfoPtr_mozPile;

		// Token: 0x04000D5D RID: 3421
		private static readonly IntPtr NativeFieldInfoPtr_tooltipActive;

		// Token: 0x04000D5E RID: 3422
		private static readonly IntPtr NativeMethodInfoPtr_Start_Public_Virtual_Void_0;

		// Token: 0x04000D5F RID: 3423
		private static readonly IntPtr NativeMethodInfoPtr_initMoz_Protected_Virtual_Void_PointerEventData_0;

		// Token: 0x04000D60 RID: 3424
		private static readonly IntPtr NativeMethodInfoPtr_endMoz_Protected_Virtual_Void_0;

		// Token: 0x04000D61 RID: 3425
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
