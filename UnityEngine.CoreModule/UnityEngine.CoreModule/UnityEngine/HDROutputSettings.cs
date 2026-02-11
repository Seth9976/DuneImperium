using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine
{
	// Token: 0x0200009A RID: 154
	public class HDROutputSettings : Object
	{
		// Token: 0x06000998 RID: 2456 RVA: 0x00034EE4 File Offset: 0x000330E4
		// Note: this type is marked as 'beforefieldinit'.
		static HDROutputSettings()
		{
			Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "HDROutputSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr);
			HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "m_DisplayIndex");
			HDROutputSettings.NativeFieldInfoPtr_displays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "displays");
			HDROutputSettings.NativeFieldInfoPtr__mainDisplay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, "_mainDisplay");
			HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664375);
			HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664376);
			HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664377);
			HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664378);
			HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664379);
			HDROutputSettings.NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664380);
			HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664381);
			HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664382);
			HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664383);
			HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664384);
			HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664385);
			HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664386);
			HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664387);
			HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664388);
			HDROutputSettings.NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664389);
			HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664390);
			HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664391);
			HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664392);
			HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664393);
			HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664394);
			HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr, 100664395);
			HDROutputSettings.GetAutomaticHDRTonemappingDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetAutomaticHDRTonemappingDelegate>("UnityEngine.HDROutputSettings::GetAutomaticHDRTonemapping");
			HDROutputSettings.GetGraphicsFormatDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetGraphicsFormatDelegate>("UnityEngine.HDROutputSettings::GetGraphicsFormat");
			HDROutputSettings.SetPaperWhiteNitsDelegateField = IL2CPP.ResolveICall<HDROutputSettings.SetPaperWhiteNitsDelegate>("UnityEngine.HDROutputSettings::SetPaperWhiteNits");
			HDROutputSettings.GetHDRModeChangeRequestedDelegateField = IL2CPP.ResolveICall<HDROutputSettings.GetHDRModeChangeRequestedDelegate>("UnityEngine.HDROutputSettings::GetHDRModeChangeRequested");
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x00035130 File Offset: 0x00033330
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650004, XrefRangeEnd = 650005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDROutputSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0003516C File Offset: 0x0003336C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDROutputSettings(int displayIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDROutputSettings>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x000351B4 File Offset: 0x000333B4
		public unsafe static HDROutputSettings main
		{
			[CallerCount(13)]
			[CachedScanResults(RefRangeStart = 650009, RefRangeEnd = 650022, XrefRangeStart = 650005, XrefRangeEnd = 650009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr3) : null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x000351E8 File Offset: 0x000333E8
		public unsafe bool active
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 650027, RefRangeEnd = 650035, XrefRangeStart = 650022, XrefRangeEnd = 650027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_active_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00035224 File Offset: 0x00033424
		public unsafe bool available
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650040, RefRangeEnd = 650043, XrefRangeStart = 650035, XrefRangeEnd = 650040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_available_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x000356C4 File Offset: 0x000338C4
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00035260 File Offset: 0x00033460
		public unsafe bool automaticHDRTonemapping
		{
			get
			{
				return HDROutputSettings.GetAutomaticHDRTonemapping(this.m_DisplayIndex);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650048, RefRangeEnd = 650050, XrefRangeStart = 650043, XrefRangeEnd = 650048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600099F RID: 2463 RVA: 0x000352A0 File Offset: 0x000334A0
		public unsafe ColorGamut displayColorGamut
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650055, RefRangeEnd = 650058, XrefRangeStart = 650050, XrefRangeEnd = 650055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x000352DC File Offset: 0x000334DC
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00005ACE File Offset: 0x00003CCE
		public unsafe float paperWhiteNits
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650063, RefRangeEnd = 650065, XrefRangeStart = 650058, XrefRangeEnd = 650063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				HDROutputSettings.SetPaperWhiteNits(this.m_DisplayIndex, value);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00035318 File Offset: 0x00033518
		public unsafe int maxFullFrameToneMapLuminance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650070, RefRangeEnd = 650072, XrefRangeStart = 650065, XrefRangeEnd = 650070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00035354 File Offset: 0x00033554
		public unsafe int maxToneMapLuminance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650077, RefRangeEnd = 650080, XrefRangeStart = 650072, XrefRangeEnd = 650077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x00035390 File Offset: 0x00033590
		public unsafe int minToneMapLuminance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650085, RefRangeEnd = 650087, XrefRangeStart = 650080, XrefRangeEnd = 650085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x000353CC File Offset: 0x000335CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 650092, RefRangeEnd = 650094, XrefRangeStart = 650087, XrefRangeEnd = 650092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RequestHDRModeChange(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0003540C File Offset: 0x0003360C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650094, XrefRangeEnd = 650096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetActive(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0003544C File Offset: 0x0003364C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650096, XrefRangeEnd = 650098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetAvailable(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0003548C File Offset: 0x0003368C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650098, XrefRangeEnd = 650119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetAutomaticHDRTonemapping(int displayIndex, bool scripted)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scripted;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x000354CC File Offset: 0x000336CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650119, XrefRangeEnd = 650121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ColorGamut GetDisplayColorGamut(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0003550C File Offset: 0x0003370C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650121, XrefRangeEnd = 650123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPaperWhiteNits(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0003554C File Offset: 0x0003374C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650123, XrefRangeEnd = 650125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxFullFrameToneMapLuminance(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0003558C File Offset: 0x0003378C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650125, XrefRangeEnd = 650127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMaxToneMapLuminance(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x000355CC File Offset: 0x000337CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650127, XrefRangeEnd = 650129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetMinToneMapLuminance(int displayIndex)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0003560C File Offset: 0x0003380C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650129, XrefRangeEnd = 650131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RequestHDRModeChangeInternal(int displayIndex, bool enabled)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref displayIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDROutputSettings.NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x00005A86 File Offset: 0x00003C86
		public HDROutputSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x0003564C File Offset: 0x0003384C
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00005A8F File Offset: 0x00003C8F
		public unsafe int m_DisplayIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HDROutputSettings.NativeFieldInfoPtr_m_DisplayIndex)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00035674 File Offset: 0x00033874
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00005AAA File Offset: 0x00003CAA
		public unsafe static Il2CppReferenceArray<HDROutputSettings> displays
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr_displays, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<HDROutputSettings>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr_displays, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x0003569C File Offset: 0x0003389C
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00005ABC File Offset: 0x00003CBC
		public unsafe static HDROutputSettings _mainDisplay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDROutputSettings>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(HDROutputSettings.NativeFieldInfoPtr__mainDisplay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060009B6 RID: 2486 RVA: 0x000356E4 File Offset: 0x000338E4
		public RenderTextureFormat format
		{
			get
			{
				return UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex));
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00035708 File Offset: 0x00033908
		public UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			get
			{
				return HDROutputSettings.GetGraphicsFormat(this.m_DisplayIndex);
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x00035728 File Offset: 0x00033928
		public bool HDRModeChangeRequested
		{
			get
			{
				return HDROutputSettings.GetHDRModeChangeRequested(this.m_DisplayIndex);
			}
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x00035748 File Offset: 0x00033948
		public static void SetPaperWhiteInNits(float paperWhite)
		{
			int num = 0;
			bool available = HDROutputSettings.GetAvailable(num);
			if (available)
			{
				HDROutputSettings.SetPaperWhiteNits(num, paperWhite);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x00005ADE File Offset: 0x00003CDE
		public static bool GetAutomaticHDRTonemapping(int displayIndex)
		{
			return HDROutputSettings.GetAutomaticHDRTonemappingDelegateField(displayIndex);
		}

		// Token: 0x060009BC RID: 2492 RVA: 0x00005AEB File Offset: 0x00003CEB
		public static UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormat(int displayIndex)
		{
			return HDROutputSettings.GetGraphicsFormatDelegateField(displayIndex);
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public static void SetPaperWhiteNits(int displayIndex, float paperWhite)
		{
			HDROutputSettings.SetPaperWhiteNitsDelegateField(displayIndex, paperWhite);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00005B06 File Offset: 0x00003D06
		public static bool GetHDRModeChangeRequested(int displayIndex)
		{
			return HDROutputSettings.GetHDRModeChangeRequestedDelegateField(displayIndex);
		}

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr_m_DisplayIndex;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr_displays;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr__mainDisplay;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeMethodInfoPtr_get_main_Public_Static_get_HDROutputSettings_0;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_get_Boolean_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_get_available_Public_get_Boolean_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_set_automaticHDRTonemapping_Public_set_Void_Boolean_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_get_displayColorGamut_Public_get_ColorGamut_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_get_paperWhiteNits_Public_get_Single_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_get_maxFullFrameToneMapLuminance_Public_get_Int32_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_get_maxToneMapLuminance_Public_get_Int32_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_get_minToneMapLuminance_Public_get_Int32_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_RequestHDRModeChange_Public_Void_Boolean_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_GetActive_Private_Static_Boolean_Int32_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_GetAvailable_Private_Static_Boolean_Int32_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_SetAutomaticHDRTonemapping_Private_Static_Void_Int32_Boolean_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayColorGamut_Private_Static_ColorGamut_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_GetPaperWhiteNits_Private_Static_Single_Int32_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxFullFrameToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_GetMaxToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_GetMinToneMapLuminance_Private_Static_Int32_Int32_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_RequestHDRModeChangeInternal_Private_Static_Void_Int32_Boolean_0;

		// Token: 0x04000786 RID: 1926
		private static readonly HDROutputSettings.GetAutomaticHDRTonemappingDelegate GetAutomaticHDRTonemappingDelegateField;

		// Token: 0x04000787 RID: 1927
		private static readonly HDROutputSettings.GetGraphicsFormatDelegate GetGraphicsFormatDelegateField;

		// Token: 0x04000788 RID: 1928
		private static readonly HDROutputSettings.SetPaperWhiteNitsDelegate SetPaperWhiteNitsDelegateField;

		// Token: 0x04000789 RID: 1929
		private static readonly HDROutputSettings.GetHDRModeChangeRequestedDelegate GetHDRModeChangeRequestedDelegateField;

		// Token: 0x0200051C RID: 1308
		// (Invoke) Token: 0x06003349 RID: 13129
		private delegate bool GetAutomaticHDRTonemappingDelegate(int displayIndex);

		// Token: 0x0200051D RID: 1309
		// (Invoke) Token: 0x0600334B RID: 13131
		private delegate UnityEngine.Experimental.Rendering.GraphicsFormat GetGraphicsFormatDelegate(int displayIndex);

		// Token: 0x0200051E RID: 1310
		// (Invoke) Token: 0x0600334D RID: 13133
		private delegate void SetPaperWhiteNitsDelegate(int displayIndex, float paperWhite);

		// Token: 0x0200051F RID: 1311
		// (Invoke) Token: 0x0600334F RID: 13135
		private delegate bool GetHDRModeChangeRequestedDelegate(int displayIndex);
	}
}
