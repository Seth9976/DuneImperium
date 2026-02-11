using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000A5 RID: 165
	[Serializable]
	public sealed class LensFlareDataElementSRP : Object
	{
		// Token: 0x06000BFC RID: 3068 RVA: 0x00038EDC File Offset: 0x000370DC
		// Note: this type is marked as 'beforefieldinit'.
		static LensFlareDataElementSRP()
		{
			Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "LensFlareDataElementSRP");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr);
			LensFlareDataElementSRP.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "visible");
			LensFlareDataElementSRP.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "position");
			LensFlareDataElementSRP.NativeFieldInfoPtr_positionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionOffset");
			LensFlareDataElementSRP.NativeFieldInfoPtr_angularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "angularOffset");
			LensFlareDataElementSRP.NativeFieldInfoPtr_translationScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "translationScale");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_LocalIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_LocalIntensity");
			LensFlareDataElementSRP.NativeFieldInfoPtr_lensFlareTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "lensFlareTexture");
			LensFlareDataElementSRP.NativeFieldInfoPtr_uniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformScale");
			LensFlareDataElementSRP.NativeFieldInfoPtr_sizeXY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "sizeXY");
			LensFlareDataElementSRP.NativeFieldInfoPtr_allowMultipleElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "allowMultipleElement");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_Count");
			LensFlareDataElementSRP.NativeFieldInfoPtr_preserveAspectRatio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "preserveAspectRatio");
			LensFlareDataElementSRP.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "rotation");
			LensFlareDataElementSRP.NativeFieldInfoPtr_tint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "tint");
			LensFlareDataElementSRP.NativeFieldInfoPtr_blendMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "blendMode");
			LensFlareDataElementSRP.NativeFieldInfoPtr_autoRotate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "autoRotate");
			LensFlareDataElementSRP.NativeFieldInfoPtr_flareType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "flareType");
			LensFlareDataElementSRP.NativeFieldInfoPtr_modulateByLightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "modulateByLightColor");
			LensFlareDataElementSRP.NativeFieldInfoPtr_isFoldOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "isFoldOpened");
			LensFlareDataElementSRP.NativeFieldInfoPtr_distribution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distribution");
			LensFlareDataElementSRP.NativeFieldInfoPtr_lengthSpread = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "lengthSpread");
			LensFlareDataElementSRP.NativeFieldInfoPtr_positionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionCurve");
			LensFlareDataElementSRP.NativeFieldInfoPtr_scaleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "scaleCurve");
			LensFlareDataElementSRP.NativeFieldInfoPtr_seed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "seed");
			LensFlareDataElementSRP.NativeFieldInfoPtr_colorGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "colorGradient");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_IntensityVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_IntensityVariation");
			LensFlareDataElementSRP.NativeFieldInfoPtr_positionVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "positionVariation");
			LensFlareDataElementSRP.NativeFieldInfoPtr_scaleVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "scaleVariation");
			LensFlareDataElementSRP.NativeFieldInfoPtr_rotationVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "rotationVariation");
			LensFlareDataElementSRP.NativeFieldInfoPtr_enableRadialDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "enableRadialDistortion");
			LensFlareDataElementSRP.NativeFieldInfoPtr_targetSizeDistortion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "targetSizeDistortion");
			LensFlareDataElementSRP.NativeFieldInfoPtr_distortionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distortionCurve");
			LensFlareDataElementSRP.NativeFieldInfoPtr_distortionRelativeToCenter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "distortionRelativeToCenter");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_FallOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_FallOff");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_EdgeOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_EdgeOffset");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_SideCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_SideCount");
			LensFlareDataElementSRP.NativeFieldInfoPtr_m_SdfRoundness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "m_SdfRoundness");
			LensFlareDataElementSRP.NativeFieldInfoPtr_inverseSDF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "inverseSDF");
			LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformAngle");
			LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngleCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, "uniformAngleCurve");
			LensFlareDataElementSRP.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665096);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665097);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665098);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665099);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665100);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665101);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665102);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_fallOff_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665103);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665104);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665105);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665106);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665107);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665108);
			LensFlareDataElementSRP.NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665109);
			LensFlareDataElementSRP.NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr, 100665110);
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x00039358 File Offset: 0x00037558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 971577, XrefRangeEnd = 971633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LensFlareDataElementSRP()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LensFlareDataElementSRP>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000BFE RID: 3070 RVA: 0x00039394 File Offset: 0x00037594
		// (set) Token: 0x06000BFF RID: 3071 RVA: 0x000393D0 File Offset: 0x000375D0
		public unsafe float localIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000C00 RID: 3072 RVA: 0x00039410 File Offset: 0x00037610
		// (set) Token: 0x06000C01 RID: 3073 RVA: 0x0003944C File Offset: 0x0003764C
		public unsafe int count
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 366305, RefRangeEnd = 366308, XrefRangeStart = 366305, XrefRangeEnd = 366308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000C02 RID: 3074 RVA: 0x0003948C File Offset: 0x0003768C
		// (set) Token: 0x06000C03 RID: 3075 RVA: 0x000394C8 File Offset: 0x000376C8
		public unsafe float intensityVariation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000C04 RID: 3076 RVA: 0x00039508 File Offset: 0x00037708
		// (set) Token: 0x06000C05 RID: 3077 RVA: 0x00039544 File Offset: 0x00037744
		public unsafe float fallOff
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_fallOff_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x00039584 File Offset: 0x00037784
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x000395C0 File Offset: 0x000377C0
		public unsafe float edgeOffset
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x00039600 File Offset: 0x00037800
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0003963C File Offset: 0x0003783C
		public unsafe int sideCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0003967C File Offset: 0x0003787C
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x000396B8 File Offset: 0x000378B8
		public unsafe float sdfRoundness
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LensFlareDataElementSRP.NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0000721F File Offset: 0x0000541F
		public LensFlareDataElementSRP(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x000396F8 File Offset: 0x000378F8
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x00007228 File Offset: 0x00005428
		public unsafe bool visible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_visible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_visible)) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x00039720 File Offset: 0x00037920
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x00007243 File Offset: 0x00005443
		public unsafe float position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x00039748 File Offset: 0x00037948
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0000725E File Offset: 0x0000545E
		public unsafe Vector2 positionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionOffset)) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00039770 File Offset: 0x00037970
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00007279 File Offset: 0x00005479
		public unsafe float angularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_angularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_angularOffset)) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00039798 File Offset: 0x00037998
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00007294 File Offset: 0x00005494
		public unsafe Vector2 translationScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_translationScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_translationScale)) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x000397C0 File Offset: 0x000379C0
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000072AF File Offset: 0x000054AF
		public unsafe float m_LocalIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_LocalIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_LocalIntensity)) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x000397E8 File Offset: 0x000379E8
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x000072CA File Offset: 0x000054CA
		public unsafe Texture lensFlareTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_lensFlareTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_lensFlareTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06000C1B RID: 3099 RVA: 0x00039818 File Offset: 0x00037A18
		// (set) Token: 0x06000C1C RID: 3100 RVA: 0x000072E9 File Offset: 0x000054E9
		public unsafe float uniformScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformScale)) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x00039840 File Offset: 0x00037A40
		// (set) Token: 0x06000C1E RID: 3102 RVA: 0x00007304 File Offset: 0x00005504
		public unsafe Vector2 sizeXY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_sizeXY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_sizeXY)) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C1F RID: 3103 RVA: 0x00039868 File Offset: 0x00037A68
		// (set) Token: 0x06000C20 RID: 3104 RVA: 0x0000731F File Offset: 0x0000551F
		public unsafe bool allowMultipleElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_allowMultipleElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_allowMultipleElement)) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x00039890 File Offset: 0x00037A90
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x0000733A File Offset: 0x0000553A
		public unsafe int m_Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_Count)) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C23 RID: 3107 RVA: 0x000398B8 File Offset: 0x00037AB8
		// (set) Token: 0x06000C24 RID: 3108 RVA: 0x00007355 File Offset: 0x00005555
		public unsafe bool preserveAspectRatio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_preserveAspectRatio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_preserveAspectRatio)) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C25 RID: 3109 RVA: 0x000398E0 File Offset: 0x00037AE0
		// (set) Token: 0x06000C26 RID: 3110 RVA: 0x00007370 File Offset: 0x00005570
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06000C27 RID: 3111 RVA: 0x00039908 File Offset: 0x00037B08
		// (set) Token: 0x06000C28 RID: 3112 RVA: 0x0000738B File Offset: 0x0000558B
		public unsafe Color tint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_tint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_tint)) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06000C29 RID: 3113 RVA: 0x00039930 File Offset: 0x00037B30
		// (set) Token: 0x06000C2A RID: 3114 RVA: 0x000073A6 File Offset: 0x000055A6
		public unsafe SRPLensFlareBlendMode blendMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_blendMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_blendMode)) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06000C2B RID: 3115 RVA: 0x00039958 File Offset: 0x00037B58
		// (set) Token: 0x06000C2C RID: 3116 RVA: 0x000073C1 File Offset: 0x000055C1
		public unsafe bool autoRotate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_autoRotate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_autoRotate)) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06000C2D RID: 3117 RVA: 0x00039980 File Offset: 0x00037B80
		// (set) Token: 0x06000C2E RID: 3118 RVA: 0x000073DC File Offset: 0x000055DC
		public unsafe SRPLensFlareType flareType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_flareType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_flareType)) = value;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x000399A8 File Offset: 0x00037BA8
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x000073F7 File Offset: 0x000055F7
		public unsafe bool modulateByLightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_modulateByLightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_modulateByLightColor)) = value;
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x000399D0 File Offset: 0x00037BD0
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x00007412 File Offset: 0x00005612
		public unsafe bool isFoldOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_isFoldOpened);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_isFoldOpened)) = value;
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x000399F8 File Offset: 0x00037BF8
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0000742D File Offset: 0x0000562D
		public unsafe SRPLensFlareDistribution distribution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distribution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distribution)) = value;
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x00039A20 File Offset: 0x00037C20
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x00007448 File Offset: 0x00005648
		public unsafe float lengthSpread
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_lengthSpread);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_lengthSpread)) = value;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x00039A48 File Offset: 0x00037C48
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x00007463 File Offset: 0x00005663
		public unsafe AnimationCurve positionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00039A78 File Offset: 0x00037C78
		// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00007482 File Offset: 0x00005682
		public unsafe AnimationCurve scaleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_scaleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_scaleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x00039AA8 File Offset: 0x00037CA8
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x000074A1 File Offset: 0x000056A1
		public unsafe int seed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_seed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_seed)) = value;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000C3D RID: 3133 RVA: 0x00039AD0 File Offset: 0x00037CD0
		// (set) Token: 0x06000C3E RID: 3134 RVA: 0x000074BC File Offset: 0x000056BC
		public unsafe Gradient colorGradient
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_colorGradient);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_colorGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000C3F RID: 3135 RVA: 0x00039B00 File Offset: 0x00037D00
		// (set) Token: 0x06000C40 RID: 3136 RVA: 0x000074DB File Offset: 0x000056DB
		public unsafe float m_IntensityVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_IntensityVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_IntensityVariation)) = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000C41 RID: 3137 RVA: 0x00039B28 File Offset: 0x00037D28
		// (set) Token: 0x06000C42 RID: 3138 RVA: 0x000074F6 File Offset: 0x000056F6
		public unsafe Vector2 positionVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_positionVariation)) = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000C43 RID: 3139 RVA: 0x00039B50 File Offset: 0x00037D50
		// (set) Token: 0x06000C44 RID: 3140 RVA: 0x00007511 File Offset: 0x00005711
		public unsafe float scaleVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_scaleVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_scaleVariation)) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000C45 RID: 3141 RVA: 0x00039B78 File Offset: 0x00037D78
		// (set) Token: 0x06000C46 RID: 3142 RVA: 0x0000752C File Offset: 0x0000572C
		public unsafe float rotationVariation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_rotationVariation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_rotationVariation)) = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000C47 RID: 3143 RVA: 0x00039BA0 File Offset: 0x00037DA0
		// (set) Token: 0x06000C48 RID: 3144 RVA: 0x00007547 File Offset: 0x00005747
		public unsafe bool enableRadialDistortion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_enableRadialDistortion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_enableRadialDistortion)) = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00039BC8 File Offset: 0x00037DC8
		// (set) Token: 0x06000C4A RID: 3146 RVA: 0x00007562 File Offset: 0x00005762
		public unsafe Vector2 targetSizeDistortion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_targetSizeDistortion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_targetSizeDistortion)) = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000C4B RID: 3147 RVA: 0x00039BF0 File Offset: 0x00037DF0
		// (set) Token: 0x06000C4C RID: 3148 RVA: 0x0000757D File Offset: 0x0000577D
		public unsafe AnimationCurve distortionCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distortionCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distortionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000C4D RID: 3149 RVA: 0x00039C20 File Offset: 0x00037E20
		// (set) Token: 0x06000C4E RID: 3150 RVA: 0x0000759C File Offset: 0x0000579C
		public unsafe bool distortionRelativeToCenter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distortionRelativeToCenter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_distortionRelativeToCenter)) = value;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000C4F RID: 3151 RVA: 0x00039C48 File Offset: 0x00037E48
		// (set) Token: 0x06000C50 RID: 3152 RVA: 0x000075B7 File Offset: 0x000057B7
		public unsafe float m_FallOff
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_FallOff);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_FallOff)) = value;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000C51 RID: 3153 RVA: 0x00039C70 File Offset: 0x00037E70
		// (set) Token: 0x06000C52 RID: 3154 RVA: 0x000075D2 File Offset: 0x000057D2
		public unsafe float m_EdgeOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_EdgeOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_EdgeOffset)) = value;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00039C98 File Offset: 0x00037E98
		// (set) Token: 0x06000C54 RID: 3156 RVA: 0x000075ED File Offset: 0x000057ED
		public unsafe int m_SideCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_SideCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_SideCount)) = value;
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000C55 RID: 3157 RVA: 0x00039CC0 File Offset: 0x00037EC0
		// (set) Token: 0x06000C56 RID: 3158 RVA: 0x00007608 File Offset: 0x00005808
		public unsafe float m_SdfRoundness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_SdfRoundness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_m_SdfRoundness)) = value;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00039CE8 File Offset: 0x00037EE8
		// (set) Token: 0x06000C58 RID: 3160 RVA: 0x00007623 File Offset: 0x00005823
		public unsafe bool inverseSDF
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_inverseSDF);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_inverseSDF)) = value;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00039D10 File Offset: 0x00037F10
		// (set) Token: 0x06000C5A RID: 3162 RVA: 0x0000763E File Offset: 0x0000583E
		public unsafe float uniformAngle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngle)) = value;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00039D38 File Offset: 0x00037F38
		// (set) Token: 0x06000C5C RID: 3164 RVA: 0x00007659 File Offset: 0x00005859
		public unsafe AnimationCurve uniformAngleCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngleCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LensFlareDataElementSRP.NativeFieldInfoPtr_uniformAngleCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400090C RID: 2316
		private static readonly IntPtr NativeFieldInfoPtr_visible;

		// Token: 0x0400090D RID: 2317
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x0400090E RID: 2318
		private static readonly IntPtr NativeFieldInfoPtr_positionOffset;

		// Token: 0x0400090F RID: 2319
		private static readonly IntPtr NativeFieldInfoPtr_angularOffset;

		// Token: 0x04000910 RID: 2320
		private static readonly IntPtr NativeFieldInfoPtr_translationScale;

		// Token: 0x04000911 RID: 2321
		private static readonly IntPtr NativeFieldInfoPtr_m_LocalIntensity;

		// Token: 0x04000912 RID: 2322
		private static readonly IntPtr NativeFieldInfoPtr_lensFlareTexture;

		// Token: 0x04000913 RID: 2323
		private static readonly IntPtr NativeFieldInfoPtr_uniformScale;

		// Token: 0x04000914 RID: 2324
		private static readonly IntPtr NativeFieldInfoPtr_sizeXY;

		// Token: 0x04000915 RID: 2325
		private static readonly IntPtr NativeFieldInfoPtr_allowMultipleElement;

		// Token: 0x04000916 RID: 2326
		private static readonly IntPtr NativeFieldInfoPtr_m_Count;

		// Token: 0x04000917 RID: 2327
		private static readonly IntPtr NativeFieldInfoPtr_preserveAspectRatio;

		// Token: 0x04000918 RID: 2328
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04000919 RID: 2329
		private static readonly IntPtr NativeFieldInfoPtr_tint;

		// Token: 0x0400091A RID: 2330
		private static readonly IntPtr NativeFieldInfoPtr_blendMode;

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr_autoRotate;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr_flareType;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr_modulateByLightColor;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr_isFoldOpened;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr_distribution;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr_lengthSpread;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr_positionCurve;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr_scaleCurve;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_seed;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeFieldInfoPtr_colorGradient;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeFieldInfoPtr_m_IntensityVariation;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeFieldInfoPtr_positionVariation;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeFieldInfoPtr_scaleVariation;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeFieldInfoPtr_rotationVariation;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeFieldInfoPtr_enableRadialDistortion;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeFieldInfoPtr_targetSizeDistortion;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeFieldInfoPtr_distortionCurve;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeFieldInfoPtr_distortionRelativeToCenter;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeFieldInfoPtr_m_FallOff;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeFieldInfoPtr_m_EdgeOffset;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_m_SideCount;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeFieldInfoPtr_m_SdfRoundness;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_inverseSDF;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeFieldInfoPtr_uniformAngle;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeFieldInfoPtr_uniformAngleCurve;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_get_localIntensity_Public_get_Single_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_set_localIntensity_Public_set_Void_Single_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_get_count_Public_get_Int32_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_set_count_Public_set_Void_Int32_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_get_intensityVariation_Public_get_Single_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_set_intensityVariation_Public_set_Void_Single_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_get_fallOff_Public_get_Single_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_set_fallOff_Public_set_Void_Single_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_get_edgeOffset_Public_get_Single_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_set_edgeOffset_Public_set_Void_Single_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_get_sideCount_Public_get_Int32_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_set_sideCount_Public_set_Void_Int32_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_get_sdfRoundness_Public_get_Single_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_set_sdfRoundness_Public_set_Void_Single_0;
	}
}
