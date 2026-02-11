using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Localization.Platform.Android
{
	// Token: 0x020000B0 RID: 176
	[Serializable]
	public class AdaptiveIcon : Object
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x0002AED0 File Offset: 0x000290D0
		// Note: this type is marked as 'beforefieldinit'.
		static AdaptiveIcon()
		{
			Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Platform.Android", "AdaptiveIcon");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr);
			AdaptiveIcon.NativeFieldInfoPtr_m_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, "m_Background");
			AdaptiveIcon.NativeFieldInfoPtr_m_Foreground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, "m_Foreground");
			AdaptiveIcon.NativeMethodInfoPtr_get_Background_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, 100664844);
			AdaptiveIcon.NativeMethodInfoPtr_set_Background_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, 100664845);
			AdaptiveIcon.NativeMethodInfoPtr_get_Foreground_Public_get_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, 100664846);
			AdaptiveIcon.NativeMethodInfoPtr_set_Foreground_Public_set_Void_LocalizedTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, 100664847);
			AdaptiveIcon.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr, 100664848);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0002AF8C File Offset: 0x0002918C
		// (set) Token: 0x060008C3 RID: 2243 RVA: 0x0002AFCC File Offset: 0x000291CC
		public unsafe LocalizedTexture Background
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIcon.NativeMethodInfoPtr_get_Background_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIcon.NativeMethodInfoPtr_set_Background_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0002B010 File Offset: 0x00029210
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0002B050 File Offset: 0x00029250
		public unsafe LocalizedTexture Foreground
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIcon.NativeMethodInfoPtr_get_Foreground_Public_get_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIcon.NativeMethodInfoPtr_set_Foreground_Public_set_Void_LocalizedTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0002B094 File Offset: 0x00029294
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AdaptiveIcon()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AdaptiveIcon>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AdaptiveIcon.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0000554D File Offset: 0x0000374D
		public AdaptiveIcon(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0002B0D0 File Offset: 0x000292D0
		// (set) Token: 0x060008C9 RID: 2249 RVA: 0x00005556 File Offset: 0x00003756
		public unsafe LocalizedTexture m_Background
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIcon.NativeFieldInfoPtr_m_Background);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIcon.NativeFieldInfoPtr_m_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0002B100 File Offset: 0x00029300
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00005575 File Offset: 0x00003775
		public unsafe LocalizedTexture m_Foreground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIcon.NativeFieldInfoPtr_m_Foreground);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizedTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AdaptiveIcon.NativeFieldInfoPtr_m_Foreground), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeFieldInfoPtr_m_Background;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeFieldInfoPtr_m_Foreground;

		// Token: 0x04000643 RID: 1603
		private static readonly IntPtr NativeMethodInfoPtr_get_Background_Public_get_LocalizedTexture_0;

		// Token: 0x04000644 RID: 1604
		private static readonly IntPtr NativeMethodInfoPtr_set_Background_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000645 RID: 1605
		private static readonly IntPtr NativeMethodInfoPtr_get_Foreground_Public_get_LocalizedTexture_0;

		// Token: 0x04000646 RID: 1606
		private static readonly IntPtr NativeMethodInfoPtr_set_Foreground_Public_set_Void_LocalizedTexture_0;

		// Token: 0x04000647 RID: 1607
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
