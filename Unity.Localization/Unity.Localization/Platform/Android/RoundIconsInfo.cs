using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Platform.Android
{
	// Token: 0x020000B2 RID: 178
	[Serializable]
	public class RoundIconsInfo : Object
	{
		// Token: 0x060008EA RID: 2282 RVA: 0x0002B7DC File Offset: 0x000299DC
		// Note: this type is marked as 'beforefieldinit'.
		static RoundIconsInfo()
		{
			Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.Android", "RoundIconsInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr);
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_idpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_idpi");
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_mdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_mdpi");
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_hdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_hdpi");
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_xhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_xhdpi");
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_xxhdpi");
			RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "m_Round_xxxhdpi");
			RoundIconsInfo.NativeFieldInfoPtr_RoundIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, "RoundIcons");
			RoundIconsInfo.NativeMethodInfoPtr_RefreshRoundIcons_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664863);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664864);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664865);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundIdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664866);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundIdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664867);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundMdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664868);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundMdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664869);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundXhdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664870);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundXhdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664871);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundXXHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664872);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundXXHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664873);
			RoundIconsInfo.NativeMethodInfoPtr_get_RoundXXXHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664874);
			RoundIconsInfo.NativeMethodInfoPtr_set_RoundXXXHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664875);
			RoundIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr, 100664876);
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077049, XrefRangeEnd = 1077077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshRoundIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_RefreshRoundIcons_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0002B9E4 File Offset: 0x00029BE4
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0002BA24 File Offset: 0x00029C24
		public unsafe LocalizedTexture RoundHdpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002BA68 File Offset: 0x00029C68
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x0002BAA8 File Offset: 0x00029CA8
		public unsafe LocalizedTexture RoundIdpi
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundIdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundIdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002BAEC File Offset: 0x00029CEC
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0002BB2C File Offset: 0x00029D2C
		public unsafe LocalizedTexture RoundMdpi
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundMdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundMdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028A RID: 650
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0002BB70 File Offset: 0x00029D70
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x0002BBB0 File Offset: 0x00029DB0
		public unsafe LocalizedTexture RoundXhdpi
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundXhdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundXhdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0002BBF4 File Offset: 0x00029DF4
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0002BC34 File Offset: 0x00029E34
		public unsafe LocalizedTexture RoundXXHdpi
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundXXHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundXXHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0002BC78 File Offset: 0x00029E78
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0002BCB8 File Offset: 0x00029EB8
		public unsafe LocalizedTexture RoundXXXHdpi
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_get_RoundXXXHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr_set_RoundXXXHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002BCFC File Offset: 0x00029EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077077, XrefRangeEnd = 1077085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RoundIconsInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RoundIconsInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RoundIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x00005676 File Offset: 0x00003876
		public RoundIconsInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0002BD38 File Offset: 0x00029F38
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0000567F File Offset: 0x0000387F
		public unsafe LocalizedTexture m_Round_idpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_idpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_idpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0002BD68 File Offset: 0x00029F68
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0000569E File Offset: 0x0000389E
		public unsafe LocalizedTexture m_Round_mdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_mdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_mdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0002BD98 File Offset: 0x00029F98
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x000056BD File Offset: 0x000038BD
		public unsafe LocalizedTexture m_Round_hdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_hdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_hdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0002BDC8 File Offset: 0x00029FC8
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x000056DC File Offset: 0x000038DC
		public unsafe LocalizedTexture m_Round_xhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x000056FB File Offset: 0x000038FB
		public unsafe LocalizedTexture m_Round_xxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002BE28 File Offset: 0x0002A028
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0000571A File Offset: 0x0000391A
		public unsafe LocalizedTexture m_Round_xxxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_m_Round_xxxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002BE58 File Offset: 0x0002A058
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00005739 File Offset: 0x00003939
		public unsafe List<LocalizedTexture> RoundIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_RoundIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalizedTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RoundIconsInfo.NativeFieldInfoPtr_RoundIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400065D RID: 1629
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_idpi;

		// Token: 0x0400065E RID: 1630
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_mdpi;

		// Token: 0x0400065F RID: 1631
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_hdpi;

		// Token: 0x04000660 RID: 1632
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_xhdpi;

		// Token: 0x04000661 RID: 1633
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_xxhdpi;

		// Token: 0x04000662 RID: 1634
		private static readonly IntPtr NativeFieldInfoPtr_m_Round_xxxhdpi;

		// Token: 0x04000663 RID: 1635
		private static readonly IntPtr NativeFieldInfoPtr_RoundIcons;

		// Token: 0x04000664 RID: 1636
		private static readonly IntPtr NativeMethodInfoPtr_RefreshRoundIcons_Internal_Void_0;

		// Token: 0x04000665 RID: 1637
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000666 RID: 1638
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000667 RID: 1639
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundIdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000668 RID: 1640
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundIdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000669 RID: 1641
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundMdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400066A RID: 1642
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundMdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x0400066B RID: 1643
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundXhdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400066C RID: 1644
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundXhdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x0400066D RID: 1645
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundXXHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400066E RID: 1646
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundXXHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x0400066F RID: 1647
		private static readonly IntPtr NativeMethodInfoPtr_get_RoundXXXHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000670 RID: 1648
		private static readonly IntPtr NativeMethodInfoPtr_set_RoundXXXHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000671 RID: 1649
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
