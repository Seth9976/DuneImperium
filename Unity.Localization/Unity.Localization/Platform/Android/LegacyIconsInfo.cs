using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.Platform.Android
{
	// Token: 0x020000B3 RID: 179
	[Serializable]
	public class LegacyIconsInfo : Object
	{
		// Token: 0x06000908 RID: 2312 RVA: 0x0002BE88 File Offset: 0x0002A088
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyIconsInfo()
		{
			Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.Android", "LegacyIconsInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr);
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_idpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_idpi");
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_mdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_mdpi");
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_hdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_hdpi");
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_xhdpi");
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_xxhdpi");
			LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxxhdpi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "m_Legacy_xxxhdpi");
			LegacyIconsInfo.NativeFieldInfoPtr_LegacyIcons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, "LegacyIcons");
			LegacyIconsInfo.NativeMethodInfoPtr_RefreshLegacyIcons_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664877);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664878);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664879);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyIdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664880);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyIdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664881);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyMdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664882);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyMdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664883);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXhdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664884);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXhdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664885);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXXHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664886);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXXHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664887);
			LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXXXHdpi_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664888);
			LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXXXHdpi_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664889);
			LegacyIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr, 100664890);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002C05C File Offset: 0x0002A25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077085, XrefRangeEnd = 1077113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshLegacyIcons()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_RefreshLegacyIcons_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0002C090 File Offset: 0x0002A290
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x0002C0D0 File Offset: 0x0002A2D0
		public unsafe LocalizedTexture LegacyHdpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0002C114 File Offset: 0x0002A314
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x0002C154 File Offset: 0x0002A354
		public unsafe LocalizedTexture LegacyIdpi
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyIdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyIdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0002C198 File Offset: 0x0002A398
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x0002C1D8 File Offset: 0x0002A3D8
		public unsafe LocalizedTexture LegacyMdpi
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyMdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyMdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0002C21C File Offset: 0x0002A41C
		// (set) Token: 0x06000911 RID: 2321 RVA: 0x0002C25C File Offset: 0x0002A45C
		public unsafe LocalizedTexture LegacyXhdpi
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXhdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXhdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0002C2A0 File Offset: 0x0002A4A0
		// (set) Token: 0x06000913 RID: 2323 RVA: 0x0002C2E0 File Offset: 0x0002A4E0
		public unsafe LocalizedTexture LegacyXXHdpi
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXXHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXXHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0002C324 File Offset: 0x0002A524
		// (set) Token: 0x06000915 RID: 2325 RVA: 0x0002C364 File Offset: 0x0002A564
		public unsafe LocalizedTexture LegacyXXXHdpi
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_get_LegacyXXXHdpi_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr_set_LegacyXXXHdpi_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x0002C3A8 File Offset: 0x0002A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1077113, XrefRangeEnd = 1077121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyIconsInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyIconsInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyIconsInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x00005758 File Offset: 0x00003958
		public LegacyIconsInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0002C3E4 File Offset: 0x0002A5E4
		// (set) Token: 0x06000919 RID: 2329 RVA: 0x00005761 File Offset: 0x00003961
		public unsafe LocalizedTexture m_Legacy_idpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_idpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_idpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0002C414 File Offset: 0x0002A614
		// (set) Token: 0x0600091B RID: 2331 RVA: 0x00005780 File Offset: 0x00003980
		public unsafe LocalizedTexture m_Legacy_mdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_mdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_mdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0002C444 File Offset: 0x0002A644
		// (set) Token: 0x0600091D RID: 2333 RVA: 0x0000579F File Offset: 0x0000399F
		public unsafe LocalizedTexture m_Legacy_hdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_hdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_hdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0002C474 File Offset: 0x0002A674
		// (set) Token: 0x0600091F RID: 2335 RVA: 0x000057BE File Offset: 0x000039BE
		public unsafe LocalizedTexture m_Legacy_xhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0002C4A4 File Offset: 0x0002A6A4
		// (set) Token: 0x06000921 RID: 2337 RVA: 0x000057DD File Offset: 0x000039DD
		public unsafe LocalizedTexture m_Legacy_xxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x000057FC File Offset: 0x000039FC
		public unsafe LocalizedTexture m_Legacy_xxxhdpi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxxhdpi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_m_Legacy_xxxhdpi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002C504 File Offset: 0x0002A704
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x0000581B File Offset: 0x00003A1B
		public unsafe List<LocalizedTexture> LegacyIcons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_LegacyIcons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LocalizedTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LegacyIconsInfo.NativeFieldInfoPtr_LegacyIcons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000672 RID: 1650
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_idpi;

		// Token: 0x04000673 RID: 1651
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_mdpi;

		// Token: 0x04000674 RID: 1652
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_hdpi;

		// Token: 0x04000675 RID: 1653
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_xhdpi;

		// Token: 0x04000676 RID: 1654
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_xxhdpi;

		// Token: 0x04000677 RID: 1655
		private static readonly IntPtr NativeFieldInfoPtr_m_Legacy_xxxhdpi;

		// Token: 0x04000678 RID: 1656
		private static readonly IntPtr NativeFieldInfoPtr_LegacyIcons;

		// Token: 0x04000679 RID: 1657
		private static readonly IntPtr NativeMethodInfoPtr_RefreshLegacyIcons_Internal_Void_0;

		// Token: 0x0400067A RID: 1658
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400067B RID: 1659
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x0400067C RID: 1660
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyIdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400067D RID: 1661
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyIdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x0400067E RID: 1662
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyMdpi_Public_get_LocalizedTexture_0;

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyMdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyXhdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyXhdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyXXHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyXXHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_get_LegacyXXXHdpi_Public_get_LocalizedTexture_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_set_LegacyXXXHdpi_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
