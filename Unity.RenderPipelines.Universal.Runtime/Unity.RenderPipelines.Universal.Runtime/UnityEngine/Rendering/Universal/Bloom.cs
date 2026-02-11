using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000081 RID: 129
	[Serializable]
	public sealed class Bloom : VolumeComponent
	{
		// Token: 0x06000BB9 RID: 3001 RVA: 0x0003EAC0 File Offset: 0x0003CCC0
		// Note: this type is marked as 'beforefieldinit'.
		static Bloom()
		{
			Il2CppClassPointerStore<Bloom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "Bloom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bloom>.NativeClassPtr);
			Bloom.NativeFieldInfoPtr_skipIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "skipIterations");
			Bloom.NativeFieldInfoPtr_threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "threshold");
			Bloom.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "intensity");
			Bloom.NativeFieldInfoPtr_scatter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "scatter");
			Bloom.NativeFieldInfoPtr_clamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "clamp");
			Bloom.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "tint");
			Bloom.NativeFieldInfoPtr_highQualityFiltering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "highQualityFiltering");
			Bloom.NativeFieldInfoPtr_downscale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "downscale");
			Bloom.NativeFieldInfoPtr_maxIterations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "maxIterations");
			Bloom.NativeFieldInfoPtr_dirtTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "dirtTexture");
			Bloom.NativeFieldInfoPtr_dirtIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bloom>.NativeClassPtr, "dirtIntensity");
			Bloom.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bloom>.NativeClassPtr, 100664872);
			Bloom.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bloom>.NativeClassPtr, 100664873);
			Bloom.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bloom>.NativeClassPtr, 100664874);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0003EC08 File Offset: 0x0003CE08
		[CallerCount(0)]
		public unsafe bool IsActive()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bloom.NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0003EC44 File Offset: 0x0003CE44
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsTileCompatible()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bloom.NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0003EC80 File Offset: 0x0003CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 611031, XrefRangeEnd = 611085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bloom()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bloom>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bloom.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x00007423 File Offset: 0x00005623
		public Bloom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000BBE RID: 3006 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		// (set) Token: 0x06000BBF RID: 3007 RVA: 0x0000742C File Offset: 0x0000562C
		public unsafe ClampedIntParameter skipIterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_skipIterations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedIntParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_skipIterations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		// (set) Token: 0x06000BC1 RID: 3009 RVA: 0x0000744B File Offset: 0x0000564B
		public unsafe MinFloatParameter threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0003ED1C File Offset: 0x0003CF1C
		// (set) Token: 0x06000BC3 RID: 3011 RVA: 0x0000746A File Offset: 0x0000566A
		public unsafe MinFloatParameter intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_intensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_intensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0003ED4C File Offset: 0x0003CF4C
		// (set) Token: 0x06000BC5 RID: 3013 RVA: 0x00007489 File Offset: 0x00005689
		public unsafe ClampedFloatParameter scatter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_scatter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_scatter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x06000BC6 RID: 3014 RVA: 0x0003ED7C File Offset: 0x0003CF7C
		// (set) Token: 0x06000BC7 RID: 3015 RVA: 0x000074A8 File Offset: 0x000056A8
		public unsafe MinFloatParameter clamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_clamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_clamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046A RID: 1130
		// (get) Token: 0x06000BC8 RID: 3016 RVA: 0x0003EDAC File Offset: 0x0003CFAC
		// (set) Token: 0x06000BC9 RID: 3017 RVA: 0x000074C7 File Offset: 0x000056C7
		public unsafe ColorParameter tint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_tint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_tint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046B RID: 1131
		// (get) Token: 0x06000BCA RID: 3018 RVA: 0x0003EDDC File Offset: 0x0003CFDC
		// (set) Token: 0x06000BCB RID: 3019 RVA: 0x000074E6 File Offset: 0x000056E6
		public unsafe BoolParameter highQualityFiltering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_highQualityFiltering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_highQualityFiltering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046C RID: 1132
		// (get) Token: 0x06000BCC RID: 3020 RVA: 0x0003EE0C File Offset: 0x0003D00C
		// (set) Token: 0x06000BCD RID: 3021 RVA: 0x00007505 File Offset: 0x00005705
		public unsafe DownscaleParameter downscale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_downscale);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownscaleParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_downscale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06000BCE RID: 3022 RVA: 0x0003EE3C File Offset: 0x0003D03C
		// (set) Token: 0x06000BCF RID: 3023 RVA: 0x00007524 File Offset: 0x00005724
		public unsafe ClampedIntParameter maxIterations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_maxIterations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClampedIntParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_maxIterations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x0003EE6C File Offset: 0x0003D06C
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00007543 File Offset: 0x00005743
		public unsafe TextureParameter dirtTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BD2 RID: 3026 RVA: 0x0003EE9C File Offset: 0x0003D09C
		// (set) Token: 0x06000BD3 RID: 3027 RVA: 0x00007562 File Offset: 0x00005762
		public unsafe MinFloatParameter dirtIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtIntensity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MinFloatParameter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bloom.NativeFieldInfoPtr_dirtIntensity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_skipIterations;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr_threshold;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeFieldInfoPtr_scatter;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeFieldInfoPtr_clamp;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeFieldInfoPtr_highQualityFiltering;

		// Token: 0x040008BC RID: 2236
		private static readonly IntPtr NativeFieldInfoPtr_downscale;

		// Token: 0x040008BD RID: 2237
		private static readonly IntPtr NativeFieldInfoPtr_maxIterations;

		// Token: 0x040008BE RID: 2238
		private static readonly IntPtr NativeFieldInfoPtr_dirtTexture;

		// Token: 0x040008BF RID: 2239
		private static readonly IntPtr NativeFieldInfoPtr_dirtIntensity;

		// Token: 0x040008C0 RID: 2240
		private static readonly IntPtr NativeMethodInfoPtr_IsActive_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040008C1 RID: 2241
		private static readonly IntPtr NativeMethodInfoPtr_IsTileCompatible_Public_Virtual_Final_New_Boolean_0;

		// Token: 0x040008C2 RID: 2242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
