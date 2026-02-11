using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x0200008F RID: 143
	public class ProbeTouchupVolume : MonoBehaviour
	{
		// Token: 0x06000AC4 RID: 2756 RVA: 0x00034A18 File Offset: 0x00032C18
		// Note: this type is marked as 'beforefieldinit'.
		static ProbeTouchupVolume()
		{
			Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ProbeTouchupVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr);
			ProbeTouchupVolume.NativeFieldInfoPtr_intensityScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, "intensityScale");
			ProbeTouchupVolume.NativeFieldInfoPtr_invalidateProbes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, "invalidateProbes");
			ProbeTouchupVolume.NativeFieldInfoPtr_overrideDilationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, "overrideDilationThreshold");
			ProbeTouchupVolume.NativeFieldInfoPtr_overriddenDilationThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, "overriddenDilationThreshold");
			ProbeTouchupVolume.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, "size");
			ProbeTouchupVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr, 100664969);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x00034AC0 File Offset: 0x00032CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969660, XrefRangeEnd = 969661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProbeTouchupVolume()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProbeTouchupVolume>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProbeTouchupVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0000686C File Offset: 0x00004A6C
		public ProbeTouchupVolume(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000AC7 RID: 2759 RVA: 0x00034AFC File Offset: 0x00032CFC
		// (set) Token: 0x06000AC8 RID: 2760 RVA: 0x00006875 File Offset: 0x00004A75
		public unsafe float intensityScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_intensityScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_intensityScale)) = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000AC9 RID: 2761 RVA: 0x00034B24 File Offset: 0x00032D24
		// (set) Token: 0x06000ACA RID: 2762 RVA: 0x00006890 File Offset: 0x00004A90
		public unsafe bool invalidateProbes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_invalidateProbes);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_invalidateProbes)) = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000ACB RID: 2763 RVA: 0x00034B4C File Offset: 0x00032D4C
		// (set) Token: 0x06000ACC RID: 2764 RVA: 0x000068AB File Offset: 0x00004AAB
		public unsafe bool overrideDilationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_overrideDilationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_overrideDilationThreshold)) = value;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000ACD RID: 2765 RVA: 0x00034B74 File Offset: 0x00032D74
		// (set) Token: 0x06000ACE RID: 2766 RVA: 0x000068C6 File Offset: 0x00004AC6
		public unsafe float overriddenDilationThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_overriddenDilationThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_overriddenDilationThreshold)) = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000ACF RID: 2767 RVA: 0x00034B9C File Offset: 0x00032D9C
		// (set) Token: 0x06000AD0 RID: 2768 RVA: 0x000068E1 File Offset: 0x00004AE1
		public unsafe Vector3 size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProbeTouchupVolume.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeFieldInfoPtr_intensityScale;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeFieldInfoPtr_invalidateProbes;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeFieldInfoPtr_overrideDilationThreshold;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeFieldInfoPtr_overriddenDilationThreshold;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
