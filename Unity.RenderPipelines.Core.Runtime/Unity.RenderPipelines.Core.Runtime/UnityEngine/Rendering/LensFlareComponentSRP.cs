using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A1 RID: 161
	public sealed class LensFlareComponentSRP : MonoBehaviour
	{
		// Token: 0x06000BCF RID: 3023 RVA: 0x00038820 File Offset: 0x00036A20
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareComponentSRP()
		{
			Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareComponentSRP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr);
			LensFlareComponentSRP.NativeFieldInfoPtr_m_LensFlareData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "m_LensFlareData");
			LensFlareComponentSRP.NativeFieldInfoPtr_intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "intensity");
			LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "maxAttenuationDistance");
			LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "maxAttenuationScale");
			LensFlareComponentSRP.NativeFieldInfoPtr_distanceAttenuationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "distanceAttenuationCurve");
			LensFlareComponentSRP.NativeFieldInfoPtr_scaleByDistanceCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "scaleByDistanceCurve");
			LensFlareComponentSRP.NativeFieldInfoPtr_attenuationByLightShape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "attenuationByLightShape");
			LensFlareComponentSRP.NativeFieldInfoPtr_radialScreenAttenuationCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "radialScreenAttenuationCurve");
			LensFlareComponentSRP.NativeFieldInfoPtr_useOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "useOcclusion");
			LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "occlusionRadius");
			LensFlareComponentSRP.NativeFieldInfoPtr_useBackgroundCloudOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "useBackgroundCloudOcclusion");
			LensFlareComponentSRP.NativeFieldInfoPtr_sampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "sampleCount");
			LensFlareComponentSRP.NativeFieldInfoPtr_occlusionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "occlusionOffset");
			LensFlareComponentSRP.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "scale");
			LensFlareComponentSRP.NativeFieldInfoPtr_allowOffScreen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "allowOffScreen");
			LensFlareComponentSRP.NativeFieldInfoPtr_volumetricCloudOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "volumetricCloudOcclusion");
			LensFlareComponentSRP.NativeFieldInfoPtr_sCelestialAngularRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "sCelestialAngularRadius");
			LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRemapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, "occlusionRemapCurve");
			LensFlareComponentSRP.NativeMethodInfoPtr_get_lensFlareData_Public_get_LensFlareDataSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665088);
			LensFlareComponentSRP.NativeMethodInfoPtr_set_lensFlareData_Public_set_Void_LensFlareDataSRP_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665089);
			LensFlareComponentSRP.NativeMethodInfoPtr_celestialProjectedOcclusionRadius_Public_Single_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665090);
			LensFlareComponentSRP.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665091);
			LensFlareComponentSRP.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665092);
			LensFlareComponentSRP.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665093);
			LensFlareComponentSRP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr, 100665094);
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000BD0 RID: 3024 RVA: 0x00038A44 File Offset: 0x00036C44
		// (set) Token: 0x06000BD1 RID: 3025 RVA: 0x00038A84 File Offset: 0x00036C84
		public unsafe LensFlareDataSRP lensFlareData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_get_lensFlareData_Public_get_LensFlareDataSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LensFlareDataSRP>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971481, XrefRangeEnd = 971497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_set_lensFlareData_Public_set_Void_LensFlareDataSRP_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x00038AC8 File Offset: 0x00036CC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 971506, RefRangeEnd = 971508, XrefRangeStart = 971497, XrefRangeEnd = 971506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float celestialProjectedOcclusionRadius(Camera mainCam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainCam);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_celestialProjectedOcclusionRadius_Public_Single_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x00038B18 File Offset: 0x00036D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971508, XrefRangeEnd = 971521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00038B4C File Offset: 0x00036D4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971521, XrefRangeEnd = 971527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00038B80 File Offset: 0x00036D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971527, XrefRangeEnd = 971544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00038BB4 File Offset: 0x00036DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971544, XrefRangeEnd = 971577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareComponentSRP()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareComponentSRP>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareComponentSRP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x00007029 File Offset: 0x00005229
		public LensFlareComponentSRP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06000BD8 RID: 3032 RVA: 0x00038BF0 File Offset: 0x00036DF0
		// (set) Token: 0x06000BD9 RID: 3033 RVA: 0x00007032 File Offset: 0x00005232
		public unsafe LensFlareDataSRP m_LensFlareData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_m_LensFlareData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LensFlareDataSRP>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_m_LensFlareData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00038C20 File Offset: 0x00036E20
		// (set) Token: 0x06000BDB RID: 3035 RVA: 0x00007051 File Offset: 0x00005251
		public unsafe float intensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_intensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_intensity)) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06000BDC RID: 3036 RVA: 0x00038C48 File Offset: 0x00036E48
		// (set) Token: 0x06000BDD RID: 3037 RVA: 0x0000706C File Offset: 0x0000526C
		public unsafe float maxAttenuationDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationDistance)) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00038C70 File Offset: 0x00036E70
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00007087 File Offset: 0x00005287
		public unsafe float maxAttenuationScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_maxAttenuationScale)) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06000BE0 RID: 3040 RVA: 0x00038C98 File Offset: 0x00036E98
		// (set) Token: 0x06000BE1 RID: 3041 RVA: 0x000070A2 File Offset: 0x000052A2
		public unsafe AnimationCurve distanceAttenuationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_distanceAttenuationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_distanceAttenuationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06000BE2 RID: 3042 RVA: 0x00038CC8 File Offset: 0x00036EC8
		// (set) Token: 0x06000BE3 RID: 3043 RVA: 0x000070C1 File Offset: 0x000052C1
		public unsafe AnimationCurve scaleByDistanceCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_scaleByDistanceCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_scaleByDistanceCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x00038CF8 File Offset: 0x00036EF8
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x000070E0 File Offset: 0x000052E0
		public unsafe bool attenuationByLightShape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_attenuationByLightShape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_attenuationByLightShape)) = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000BE6 RID: 3046 RVA: 0x00038D20 File Offset: 0x00036F20
		// (set) Token: 0x06000BE7 RID: 3047 RVA: 0x000070FB File Offset: 0x000052FB
		public unsafe AnimationCurve radialScreenAttenuationCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_radialScreenAttenuationCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_radialScreenAttenuationCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000BE8 RID: 3048 RVA: 0x00038D50 File Offset: 0x00036F50
		// (set) Token: 0x06000BE9 RID: 3049 RVA: 0x0000711A File Offset: 0x0000531A
		public unsafe bool useOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_useOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_useOcclusion)) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06000BEA RID: 3050 RVA: 0x00038D78 File Offset: 0x00036F78
		// (set) Token: 0x06000BEB RID: 3051 RVA: 0x00007135 File Offset: 0x00005335
		public unsafe float occlusionRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRadius)) = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x00038DA0 File Offset: 0x00036FA0
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x00007150 File Offset: 0x00005350
		public unsafe bool useBackgroundCloudOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_useBackgroundCloudOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_useBackgroundCloudOcclusion)) = value;
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x00038DC8 File Offset: 0x00036FC8
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0000716B File Offset: 0x0000536B
		public unsafe uint sampleCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_sampleCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_sampleCount)) = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000BF0 RID: 3056 RVA: 0x00038DF0 File Offset: 0x00036FF0
		// (set) Token: 0x06000BF1 RID: 3057 RVA: 0x00007186 File Offset: 0x00005386
		public unsafe float occlusionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionOffset)) = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000BF2 RID: 3058 RVA: 0x00038E18 File Offset: 0x00037018
		// (set) Token: 0x06000BF3 RID: 3059 RVA: 0x000071A1 File Offset: 0x000053A1
		public unsafe float scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_scale)) = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000BF4 RID: 3060 RVA: 0x00038E40 File Offset: 0x00037040
		// (set) Token: 0x06000BF5 RID: 3061 RVA: 0x000071BC File Offset: 0x000053BC
		public unsafe bool allowOffScreen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_allowOffScreen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_allowOffScreen)) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000BF6 RID: 3062 RVA: 0x00038E68 File Offset: 0x00037068
		// (set) Token: 0x06000BF7 RID: 3063 RVA: 0x000071D7 File Offset: 0x000053D7
		public unsafe bool volumetricCloudOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_volumetricCloudOcclusion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_volumetricCloudOcclusion)) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000BF8 RID: 3064 RVA: 0x00038E90 File Offset: 0x00037090
		// (set) Token: 0x06000BF9 RID: 3065 RVA: 0x000071F2 File Offset: 0x000053F2
		public unsafe static float sCelestialAngularRadius
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(LensFlareComponentSRP.NativeFieldInfoPtr_sCelestialAngularRadius, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LensFlareComponentSRP.NativeFieldInfoPtr_sCelestialAngularRadius, (void*)(&value));
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000BFA RID: 3066 RVA: 0x00038EAC File Offset: 0x000370AC
		// (set) Token: 0x06000BFB RID: 3067 RVA: 0x00007200 File Offset: 0x00005400
		public unsafe TextureCurve occlusionRemapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRemapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareComponentSRP.NativeFieldInfoPtr_occlusionRemapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008E6 RID: 2278
		private static readonly IntPtr NativeFieldInfoPtr_m_LensFlareData;

		// Token: 0x040008E7 RID: 2279
		private static readonly IntPtr NativeFieldInfoPtr_intensity;

		// Token: 0x040008E8 RID: 2280
		private static readonly IntPtr NativeFieldInfoPtr_maxAttenuationDistance;

		// Token: 0x040008E9 RID: 2281
		private static readonly IntPtr NativeFieldInfoPtr_maxAttenuationScale;

		// Token: 0x040008EA RID: 2282
		private static readonly IntPtr NativeFieldInfoPtr_distanceAttenuationCurve;

		// Token: 0x040008EB RID: 2283
		private static readonly IntPtr NativeFieldInfoPtr_scaleByDistanceCurve;

		// Token: 0x040008EC RID: 2284
		private static readonly IntPtr NativeFieldInfoPtr_attenuationByLightShape;

		// Token: 0x040008ED RID: 2285
		private static readonly IntPtr NativeFieldInfoPtr_radialScreenAttenuationCurve;

		// Token: 0x040008EE RID: 2286
		private static readonly IntPtr NativeFieldInfoPtr_useOcclusion;

		// Token: 0x040008EF RID: 2287
		private static readonly IntPtr NativeFieldInfoPtr_occlusionRadius;

		// Token: 0x040008F0 RID: 2288
		private static readonly IntPtr NativeFieldInfoPtr_useBackgroundCloudOcclusion;

		// Token: 0x040008F1 RID: 2289
		private static readonly IntPtr NativeFieldInfoPtr_sampleCount;

		// Token: 0x040008F2 RID: 2290
		private static readonly IntPtr NativeFieldInfoPtr_occlusionOffset;

		// Token: 0x040008F3 RID: 2291
		private static readonly IntPtr NativeFieldInfoPtr_scale;

		// Token: 0x040008F4 RID: 2292
		private static readonly IntPtr NativeFieldInfoPtr_allowOffScreen;

		// Token: 0x040008F5 RID: 2293
		private static readonly IntPtr NativeFieldInfoPtr_volumetricCloudOcclusion;

		// Token: 0x040008F6 RID: 2294
		private static readonly IntPtr NativeFieldInfoPtr_sCelestialAngularRadius;

		// Token: 0x040008F7 RID: 2295
		private static readonly IntPtr NativeFieldInfoPtr_occlusionRemapCurve;

		// Token: 0x040008F8 RID: 2296
		private static readonly IntPtr NativeMethodInfoPtr_get_lensFlareData_Public_get_LensFlareDataSRP_0;

		// Token: 0x040008F9 RID: 2297
		private static readonly IntPtr NativeMethodInfoPtr_set_lensFlareData_Public_set_Void_LensFlareDataSRP_0;

		// Token: 0x040008FA RID: 2298
		private static readonly IntPtr NativeMethodInfoPtr_celestialProjectedOcclusionRadius_Public_Single_Camera_0;

		// Token: 0x040008FB RID: 2299
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x040008FC RID: 2300
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x040008FD RID: 2301
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x040008FE RID: 2302
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
