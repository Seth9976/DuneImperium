using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000090 RID: 144
	public class ProbeVolume : MonoBehaviour
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x00034BC4 File Offset: 0x00032DC4
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeVolume()
		{
			Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr);
			ProbeVolume.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "mode");
			ProbeVolume.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "size");
			ProbeVolume.NativeFieldInfoPtr_overrideRendererFilters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "overrideRendererFilters");
			ProbeVolume.NativeFieldInfoPtr_minRendererVolumeSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "minRendererVolumeSize");
			ProbeVolume.NativeFieldInfoPtr_objectLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "objectLayerMask");
			ProbeVolume.NativeFieldInfoPtr_lowestSubdivLevelOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "lowestSubdivLevelOverride");
			ProbeVolume.NativeFieldInfoPtr_highestSubdivLevelOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "highestSubdivLevelOverride");
			ProbeVolume.NativeFieldInfoPtr_overridesSubdivLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "overridesSubdivLevels");
			ProbeVolume.NativeFieldInfoPtr_mightNeedRebaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "mightNeedRebaking");
			ProbeVolume.NativeFieldInfoPtr_cachedTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "cachedTransform");
			ProbeVolume.NativeFieldInfoPtr_cachedHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "cachedHashCode");
			ProbeVolume.NativeFieldInfoPtr_fillEmptySpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "fillEmptySpaces");
			ProbeVolume.NativeFieldInfoPtr_version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "version");
			ProbeVolume.NativeFieldInfoPtr_globalVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, "globalVolume");
			ProbeVolume.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, 100664970);
			ProbeVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr, 100664971);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00034D34 File Offset: 0x00032F34
		[CallerCount(0)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolume.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00034D68 File Offset: 0x00032F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969661, XrefRangeEnd = 969663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeVolume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x000068FC File Offset: 0x00004AFC
		public ProbeVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000AD5 RID: 2773 RVA: 0x00034DA4 File Offset: 0x00032FA4
		// (set) Token: 0x06000AD6 RID: 2774 RVA: 0x00006905 File Offset: 0x00004B05
		public unsafe ProbeVolume.Mode mode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_mode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_mode)) = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000AD7 RID: 2775 RVA: 0x00034DCC File Offset: 0x00032FCC
		// (set) Token: 0x06000AD8 RID: 2776 RVA: 0x00006920 File Offset: 0x00004B20
		public unsafe Vector3 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000AD9 RID: 2777 RVA: 0x00034DF4 File Offset: 0x00032FF4
		// (set) Token: 0x06000ADA RID: 2778 RVA: 0x0000693B File Offset: 0x00004B3B
		public unsafe bool overrideRendererFilters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_overrideRendererFilters);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_overrideRendererFilters)) = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000ADB RID: 2779 RVA: 0x00034E1C File Offset: 0x0003301C
		// (set) Token: 0x06000ADC RID: 2780 RVA: 0x00006956 File Offset: 0x00004B56
		public unsafe float minRendererVolumeSize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_minRendererVolumeSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_minRendererVolumeSize)) = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000ADD RID: 2781 RVA: 0x00034E44 File Offset: 0x00033044
		// (set) Token: 0x06000ADE RID: 2782 RVA: 0x00006971 File Offset: 0x00004B71
		public unsafe LayerMask objectLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_objectLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_objectLayerMask)) = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x00034E6C File Offset: 0x0003306C
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0000698C File Offset: 0x00004B8C
		public unsafe int lowestSubdivLevelOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_lowestSubdivLevelOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_lowestSubdivLevelOverride)) = value;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x00034E94 File Offset: 0x00033094
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x000069A7 File Offset: 0x00004BA7
		public unsafe int highestSubdivLevelOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_highestSubdivLevelOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_highestSubdivLevelOverride)) = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00034EBC File Offset: 0x000330BC
		// (set) Token: 0x06000AE4 RID: 2788 RVA: 0x000069C2 File Offset: 0x00004BC2
		public unsafe bool overridesSubdivLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_overridesSubdivLevels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_overridesSubdivLevels)) = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000AE5 RID: 2789 RVA: 0x00034EE4 File Offset: 0x000330E4
		// (set) Token: 0x06000AE6 RID: 2790 RVA: 0x000069DD File Offset: 0x00004BDD
		public unsafe bool mightNeedRebaking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_mightNeedRebaking);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_mightNeedRebaking)) = value;
			}
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00034F0C File Offset: 0x0003310C
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x000069F8 File Offset: 0x00004BF8
		public unsafe Matrix4x4 cachedTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_cachedTransform);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_cachedTransform)) = value;
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x00034F34 File Offset: 0x00033134
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00006A13 File Offset: 0x00004C13
		public unsafe int cachedHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_cachedHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_cachedHashCode)) = value;
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00034F5C File Offset: 0x0003315C
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00006A2E File Offset: 0x00004C2E
		public unsafe bool fillEmptySpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_fillEmptySpaces);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_fillEmptySpaces)) = value;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00034F84 File Offset: 0x00033184
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00006A49 File Offset: 0x00004C49
		public unsafe ProbeVolume.Version version
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_version);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_version)) = value;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00034FAC File Offset: 0x000331AC
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00006A64 File Offset: 0x00004C64
		public unsafe bool globalVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_globalVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeVolume.NativeFieldInfoPtr_globalVolume)) = value;
			}
		}

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeFieldInfoPtr_mode;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeFieldInfoPtr_overrideRendererFilters;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeFieldInfoPtr_minRendererVolumeSize;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeFieldInfoPtr_objectLayerMask;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeFieldInfoPtr_lowestSubdivLevelOverride;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeFieldInfoPtr_highestSubdivLevelOverride;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeFieldInfoPtr_overridesSubdivLevels;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeFieldInfoPtr_mightNeedRebaking;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeFieldInfoPtr_cachedTransform;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeFieldInfoPtr_cachedHashCode;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeFieldInfoPtr_fillEmptySpaces;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeFieldInfoPtr_version;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeFieldInfoPtr_globalVolume;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001D1 RID: 465
		public enum Mode
		{
			// Token: 0x040012B7 RID: 4791
			Global,
			// Token: 0x040012B8 RID: 4792
			Scene,
			// Token: 0x040012B9 RID: 4793
			Local
		}

		// Token: 0x020001D2 RID: 466
		public enum Version
		{
			// Token: 0x040012BB RID: 4795
			Initial,
			// Token: 0x040012BC RID: 4796
			LocalMode,
			// Token: 0x040012BD RID: 4797
			Count
		}
	}
}
