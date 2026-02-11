using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Platform.Android
{
	// Token: 0x020000B1 RID: 177
	[Serializable]
	public class AdaptiveIconsInfo : Object
	{
		// Token: 0x060008CC RID: 2252 RVA: 0x0002B130 File Offset: 0x00029330
		// Note: this type is marked as 'beforefieldinit'.
		static AdaptiveIconsInfo()
		{
			Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.Android", "AdaptiveIconsInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr);
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_idpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_idpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_mdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_mdpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_hdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_hdpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_xhdpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_xxhdpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "m_Adaptive_xxxhdpi");
			AdaptiveIconsInfo.NativeFieldInfoPtr_AdaptiveIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, "AdaptiveIcons");
			AdaptiveIconsInfo.NativeMethodInfoPtr_RefreshAdaptiveIcons_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664849);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveHdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664850);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveHdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664851);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveIdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664852);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveIdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664853);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveMdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664854);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveMdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664855);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXhdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664856);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXhdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664857);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXXHdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664858);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXXHdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664859);
			AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXXXHdpi_Public_get_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664860);
			AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXXXHdpi_Public_set_Void_AdaptiveIcon_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664861);
			AdaptiveIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr, 100664862);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0002B304 File Offset: 0x00029504
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077013, XrefRangeEnd = 1077041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAdaptiveIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_RefreshAdaptiveIcons_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0002B338 File Offset: 0x00029538
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0002B378 File Offset: 0x00029578
		public unsafe AdaptiveIcon AdaptiveHdpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveHdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveHdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0002B3BC File Offset: 0x000295BC
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x0002B3FC File Offset: 0x000295FC
		public unsafe AdaptiveIcon AdaptiveIdpi
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveIdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveIdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0002B440 File Offset: 0x00029640
		// (set) Token: 0x060008D3 RID: 2259 RVA: 0x0002B480 File Offset: 0x00029680
		public unsafe AdaptiveIcon AdaptiveMdpi
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveMdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveMdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0002B4C4 File Offset: 0x000296C4
		// (set) Token: 0x060008D5 RID: 2261 RVA: 0x0002B504 File Offset: 0x00029704
		public unsafe AdaptiveIcon AdaptiveXhdpi
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXhdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXhdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0002B548 File Offset: 0x00029748
		// (set) Token: 0x060008D7 RID: 2263 RVA: 0x0002B588 File Offset: 0x00029788
		public unsafe AdaptiveIcon AdaptiveXXHdpi
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXXHdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXXHdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0002B5CC File Offset: 0x000297CC
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x0002B60C File Offset: 0x0002980C
		public unsafe AdaptiveIcon AdaptiveXXXHdpi
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_get_AdaptiveXXXHdpi_Public_get_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr_set_AdaptiveXXXHdpi_Public_set_Void_AdaptiveIcon_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x0002B650 File Offset: 0x00029850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077041, XrefRangeEnd = 1077049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdaptiveIconsInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdaptiveIconsInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x00005594 File Offset: 0x00003794
		public AdaptiveIconsInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0002B68C File Offset: 0x0002988C
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x0000559D File Offset: 0x0000379D
		public unsafe AdaptiveIcon m_Adaptive_idpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_idpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_idpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0002B6BC File Offset: 0x000298BC
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x000055BC File Offset: 0x000037BC
		public unsafe AdaptiveIcon m_Adaptive_mdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_mdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_mdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0002B6EC File Offset: 0x000298EC
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x000055DB File Offset: 0x000037DB
		public unsafe AdaptiveIcon m_Adaptive_hdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_hdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_hdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002B71C File Offset: 0x0002991C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x000055FA File Offset: 0x000037FA
		public unsafe AdaptiveIcon m_Adaptive_xhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002B74C File Offset: 0x0002994C
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00005619 File Offset: 0x00003819
		public unsafe AdaptiveIcon m_Adaptive_xxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0002B77C File Offset: 0x0002997C
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00005638 File Offset: 0x00003838
		public unsafe AdaptiveIcon m_Adaptive_xxxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdaptiveIcon>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_m_Adaptive_xxxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0002B7AC File Offset: 0x000299AC
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00005657 File Offset: 0x00003857
		public unsafe List<AdaptiveIcon> AdaptiveIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_AdaptiveIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdaptiveIcon>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIconsInfo.NativeFieldInfoPtr_AdaptiveIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000648 RID: 1608
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_idpi;

		// Token: 0x04000649 RID: 1609
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_mdpi;

		// Token: 0x0400064A RID: 1610
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_hdpi;

		// Token: 0x0400064B RID: 1611
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_xhdpi;

		// Token: 0x0400064C RID: 1612
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_xxhdpi;

		// Token: 0x0400064D RID: 1613
		private static readonly IntPtr NativeFieldInfoPtr_m_Adaptive_xxxhdpi;

		// Token: 0x0400064E RID: 1614
		private static readonly IntPtr NativeFieldInfoPtr_AdaptiveIcons;

		// Token: 0x0400064F RID: 1615
		private static readonly IntPtr NativeMethodInfoPtr_RefreshAdaptiveIcons_Internal_Void_0;

		// Token: 0x04000650 RID: 1616
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveHdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x04000651 RID: 1617
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveHdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x04000652 RID: 1618
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveIdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x04000653 RID: 1619
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveIdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x04000654 RID: 1620
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveMdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x04000655 RID: 1621
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveMdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x04000656 RID: 1622
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveXhdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x04000657 RID: 1623
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveXhdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x04000658 RID: 1624
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveXXHdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x04000659 RID: 1625
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveXXHdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeMethodInfoPtr_get_AdaptiveXXXHdpi_Public_get_AdaptiveIcon_0;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_set_AdaptiveXXXHdpi_Public_set_Void_AdaptiveIcon_0;

		// Token: 0x0400065C RID: 1628
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
