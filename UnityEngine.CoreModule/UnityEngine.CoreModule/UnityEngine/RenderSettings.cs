using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x020000A5 RID: 165
	public sealed class RenderSettings : Object
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x0003AB54 File Offset: 0x00038D54
		// Note: this type is marked as 'beforefieldinit'.
		static RenderSettings()
		{
			Il2CppClassPointerStore<RenderSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RenderSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr);
			RenderSettings.NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664551);
			RenderSettings.NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664552);
			RenderSettings.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664553);
			RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664554);
			RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664555);
			RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664556);
			RenderSettings.NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664557);
			RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664558);
			RenderSettings.NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664559);
			RenderSettings.NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664560);
			RenderSettings.NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664561);
			RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664562);
			RenderSettings.NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664563);
			RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664564);
			RenderSettings.NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664565);
			RenderSettings.NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664566);
			RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664567);
			RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664568);
			RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664569);
			RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664570);
			RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664571);
			RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664572);
			RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664573);
			RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664574);
			RenderSettings.NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664575);
			RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664576);
			RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664577);
			RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664578);
			RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664579);
			RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664580);
			RenderSettings.NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664581);
			RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664582);
			RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664583);
			RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664584);
			RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664585);
			RenderSettings.NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664586);
			RenderSettings.NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664587);
			RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664588);
			RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664589);
			RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664590);
			RenderSettings.NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664591);
			RenderSettings.NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664592);
			RenderSettings.NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664593);
			RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664594);
			RenderSettings.NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664595);
			RenderSettings.NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664596);
			RenderSettings.NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664597);
			RenderSettings.NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664598);
			RenderSettings.NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664599);
			RenderSettings.NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664600);
			RenderSettings.NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664601);
			RenderSettings.NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664602);
			RenderSettings.NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664603);
			RenderSettings.NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664604);
			RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664605);
			RenderSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664606);
			RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664607);
			RenderSettings.NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664608);
			RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664609);
			RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664610);
			RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664611);
			RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664612);
			RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664613);
			RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664614);
			RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664615);
			RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664616);
			RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664617);
			RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664618);
			RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664619);
			RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr, 100664620);
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0003B0FC File Offset: 0x000392FC
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0003B12C File Offset: 0x0003932C
		public unsafe static float ambientSkyboxAmount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650769, XrefRangeEnd = 650771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650771, XrefRangeEnd = 650773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0003B160 File Offset: 0x00039360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650773, XrefRangeEnd = 650777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderSettings()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderSettings>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000C06 RID: 3078 RVA: 0x0003B19C File Offset: 0x0003939C
		// (set) Token: 0x06000C07 RID: 3079 RVA: 0x0003B1CC File Offset: 0x000393CC
		public unsafe static bool fog
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 650779, RefRangeEnd = 650782, XrefRangeStart = 650777, XrefRangeEnd = 650779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650784, RefRangeEnd = 650785, XrefRangeStart = 650782, XrefRangeEnd = 650784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000C08 RID: 3080 RVA: 0x0003B200 File Offset: 0x00039400
		// (set) Token: 0x06000C09 RID: 3081 RVA: 0x0003B230 File Offset: 0x00039430
		public unsafe static float fogStartDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650787, RefRangeEnd = 650789, XrefRangeStart = 650785, XrefRangeEnd = 650787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650791, RefRangeEnd = 650792, XrefRangeStart = 650789, XrefRangeEnd = 650791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000C0A RID: 3082 RVA: 0x0003B264 File Offset: 0x00039464
		// (set) Token: 0x06000C0B RID: 3083 RVA: 0x0003B294 File Offset: 0x00039494
		public unsafe static float fogEndDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650794, RefRangeEnd = 650796, XrefRangeStart = 650792, XrefRangeEnd = 650794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650798, RefRangeEnd = 650799, XrefRangeStart = 650796, XrefRangeEnd = 650798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000C0C RID: 3084 RVA: 0x0003B2C8 File Offset: 0x000394C8
		// (set) Token: 0x06000C0D RID: 3085 RVA: 0x0003B2F8 File Offset: 0x000394F8
		public unsafe static FogMode fogMode
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650801, RefRangeEnd = 650803, XrefRangeStart = 650799, XrefRangeEnd = 650801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650805, RefRangeEnd = 650806, XrefRangeStart = 650803, XrefRangeEnd = 650805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x0003B32C File Offset: 0x0003952C
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x0003B35C File Offset: 0x0003955C
		public unsafe static Color fogColor
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650808, RefRangeEnd = 650810, XrefRangeStart = 650806, XrefRangeEnd = 650808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650812, RefRangeEnd = 650813, XrefRangeStart = 650810, XrefRangeEnd = 650812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000C10 RID: 3088 RVA: 0x0003B390 File Offset: 0x00039590
		// (set) Token: 0x06000C11 RID: 3089 RVA: 0x0003B3C0 File Offset: 0x000395C0
		public unsafe static float fogDensity
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650815, RefRangeEnd = 650817, XrefRangeStart = 650813, XrefRangeEnd = 650815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650819, RefRangeEnd = 650820, XrefRangeStart = 650817, XrefRangeEnd = 650819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000C12 RID: 3090 RVA: 0x0003B3F4 File Offset: 0x000395F4
		// (set) Token: 0x06000C13 RID: 3091 RVA: 0x0003B424 File Offset: 0x00039624
		public unsafe static UnityEngine.Rendering.AmbientMode ambientMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650820, XrefRangeEnd = 650822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650822, XrefRangeEnd = 650824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x0003B458 File Offset: 0x00039658
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x0003B488 File Offset: 0x00039688
		public unsafe static Color ambientSkyColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650826, RefRangeEnd = 650827, XrefRangeStart = 650824, XrefRangeEnd = 650826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650827, XrefRangeEnd = 650829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0003B4BC File Offset: 0x000396BC
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0003B4EC File Offset: 0x000396EC
		public unsafe static Color ambientEquatorColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650831, RefRangeEnd = 650832, XrefRangeStart = 650829, XrefRangeEnd = 650831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650832, XrefRangeEnd = 650834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000C18 RID: 3096 RVA: 0x0003B520 File Offset: 0x00039720
		// (set) Token: 0x06000C19 RID: 3097 RVA: 0x0003B550 File Offset: 0x00039750
		public unsafe static Color ambientGroundColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650836, RefRangeEnd = 650837, XrefRangeStart = 650834, XrefRangeEnd = 650836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650837, XrefRangeEnd = 650839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0003B584 File Offset: 0x00039784
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0003B5B4 File Offset: 0x000397B4
		public unsafe static float ambientIntensity
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000C1C RID: 3100 RVA: 0x0003B5E8 File Offset: 0x000397E8
		// (set) Token: 0x06000C1D RID: 3101 RVA: 0x0003B618 File Offset: 0x00039818
		public unsafe static Color ambientLight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650839, XrefRangeEnd = 650841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650841, XrefRangeEnd = 650843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003B64C File Offset: 0x0003984C
		// (set) Token: 0x06000C1F RID: 3103 RVA: 0x0003B67C File Offset: 0x0003987C
		public unsafe static Color subtractiveShadowColor
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650845, RefRangeEnd = 650846, XrefRangeStart = 650843, XrefRangeEnd = 650845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650846, XrefRangeEnd = 650848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000C20 RID: 3104 RVA: 0x0003B6B0 File Offset: 0x000398B0
		// (set) Token: 0x06000C21 RID: 3105 RVA: 0x0003B6E4 File Offset: 0x000398E4
		public unsafe static Material skybox
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 650850, RefRangeEnd = 650858, XrefRangeStart = 650848, XrefRangeEnd = 650850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Material>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650860, RefRangeEnd = 650862, XrefRangeStart = 650858, XrefRangeEnd = 650860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0003B71C File Offset: 0x0003991C
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0003B750 File Offset: 0x00039950
		public unsafe static Light sun
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650864, RefRangeEnd = 650865, XrefRangeStart = 650862, XrefRangeEnd = 650864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Light>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650865, XrefRangeEnd = 650867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0003B788 File Offset: 0x00039988
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0003B7B8 File Offset: 0x000399B8
		public unsafe static UnityEngine.Rendering.SphericalHarmonicsL2 ambientProbe
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 650869, RefRangeEnd = 650871, XrefRangeStart = 650867, XrefRangeEnd = 650869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650871, XrefRangeEnd = 650873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0003B7EC File Offset: 0x000399EC
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0003B820 File Offset: 0x00039A20
		public unsafe static Cubemap customReflection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650873, XrefRangeEnd = 650877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650877, XrefRangeEnd = 650879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0003B858 File Offset: 0x00039A58
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0003B88C File Offset: 0x00039A8C
		public unsafe static Texture customReflectionTexture
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650879, XrefRangeEnd = 650881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0003B8C4 File Offset: 0x00039AC4
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0003B8F4 File Offset: 0x00039AF4
		public unsafe static float reflectionIntensity
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 650883, RefRangeEnd = 650884, XrefRangeStart = 650881, XrefRangeEnd = 650883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650884, XrefRangeEnd = 650886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0003B928 File Offset: 0x00039B28
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0003B958 File Offset: 0x00039B58
		public unsafe static int reflectionBounces
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650886, XrefRangeEnd = 650888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650888, XrefRangeEnd = 650890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0003B98C File Offset: 0x00039B8C
		public unsafe static Cubemap defaultReflection
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650890, XrefRangeEnd = 650892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cubemap>(intPtr3) : null;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C2F RID: 3119 RVA: 0x0003B9C0 File Offset: 0x00039BC0
		// (set) Token: 0x06000C30 RID: 3120 RVA: 0x0003B9F0 File Offset: 0x00039BF0
		public unsafe static UnityEngine.Rendering.DefaultReflectionMode defaultReflectionMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650892, XrefRangeEnd = 650894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650894, XrefRangeEnd = 650896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C31 RID: 3121 RVA: 0x0003BA24 File Offset: 0x00039C24
		// (set) Token: 0x06000C32 RID: 3122 RVA: 0x0003BA54 File Offset: 0x00039C54
		public unsafe static int defaultReflectionResolution
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650896, XrefRangeEnd = 650898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650898, XrefRangeEnd = 650900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000C33 RID: 3123 RVA: 0x0003BA88 File Offset: 0x00039C88
		// (set) Token: 0x06000C34 RID: 3124 RVA: 0x0003BAB8 File Offset: 0x00039CB8
		public unsafe static float haloStrength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650900, XrefRangeEnd = 650902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650902, XrefRangeEnd = 650904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000C35 RID: 3125 RVA: 0x0003BAEC File Offset: 0x00039CEC
		// (set) Token: 0x06000C36 RID: 3126 RVA: 0x0003BB1C File Offset: 0x00039D1C
		public unsafe static float flareStrength
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650904, XrefRangeEnd = 650906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650906, XrefRangeEnd = 650908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000C37 RID: 3127 RVA: 0x0003BB50 File Offset: 0x00039D50
		// (set) Token: 0x06000C38 RID: 3128 RVA: 0x0003BB80 File Offset: 0x00039D80
		public unsafe static float flareFadeSpeed
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650908, XrefRangeEnd = 650910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650910, XrefRangeEnd = 650912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x0003BBB4 File Offset: 0x00039DB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650912, XrefRangeEnd = 650914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetRenderSettings()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0003BBE8 File Offset: 0x00039DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650914, XrefRangeEnd = 650916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_Reset_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003BC10 File Offset: 0x00039E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650916, XrefRangeEnd = 650918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_fogColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x0003BC44 File Offset: 0x00039E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650918, XrefRangeEnd = 650920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_fogColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003BC78 File Offset: 0x00039E78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650920, XrefRangeEnd = 650922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientSkyColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0003BCAC File Offset: 0x00039EAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650922, XrefRangeEnd = 650924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientSkyColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0003BCE0 File Offset: 0x00039EE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650924, XrefRangeEnd = 650926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientEquatorColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0003BD14 File Offset: 0x00039F14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650926, XrefRangeEnd = 650928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientEquatorColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0003BD48 File Offset: 0x00039F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650928, XrefRangeEnd = 650930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientGroundColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0003BD7C File Offset: 0x00039F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650930, XrefRangeEnd = 650932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientGroundColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0003BDB0 File Offset: 0x00039FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650932, XrefRangeEnd = 650934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientLight_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0003BDE4 File Offset: 0x00039FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650934, XrefRangeEnd = 650936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientLight_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0003BE18 File Offset: 0x0003A018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650936, XrefRangeEnd = 650938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_subtractiveShadowColor_Injected(out Color ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0003BE4C File Offset: 0x0003A04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650938, XrefRangeEnd = 650940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_subtractiveShadowColor_Injected(ref Color value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0003BE80 File Offset: 0x0003A080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650940, XrefRangeEnd = 650942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_ambientProbe_Injected(out UnityEngine.Rendering.SphericalHarmonicsL2 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0003BEB4 File Offset: 0x0003A0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 650942, XrefRangeEnd = 650944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void set_ambientProbe_Injected(ref UnityEngine.Rendering.SphericalHarmonicsL2 value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderSettings.NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00006F2D File Offset: 0x0000512D
		public RenderSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyboxAmount_Public_Static_get_Single_0;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyboxAmount_Public_Static_set_Void_Single_0;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeMethodInfoPtr_get_fog_Public_Static_get_Boolean_0;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeMethodInfoPtr_set_fog_Public_Static_set_Void_Boolean_0;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeMethodInfoPtr_get_fogStartDistance_Public_Static_get_Single_0;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeMethodInfoPtr_set_fogStartDistance_Public_Static_set_Void_Single_0;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeMethodInfoPtr_get_fogEndDistance_Public_Static_get_Single_0;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr_set_fogEndDistance_Public_Static_set_Void_Single_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr_get_fogMode_Public_Static_get_FogMode_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_set_fogMode_Public_Static_set_Void_FogMode_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Public_Static_get_Color_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_set_fogColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_get_fogDensity_Public_Static_get_Single_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_set_fogDensity_Public_Static_set_Void_Single_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientMode_Public_Static_get_AmbientMode_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientMode_Public_Static_set_Void_AmbientMode_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Public_Static_get_Color_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Public_Static_set_Void_Color_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Public_Static_get_Color_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Public_Static_get_Color_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientIntensity_Public_Static_get_Single_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientIntensity_Public_Static_set_Void_Single_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Public_Static_get_Color_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Public_Static_set_Void_Color_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Public_Static_get_Color_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_set_subtractiveShadowColor_Public_Static_set_Void_Color_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_get_skybox_Public_Static_get_Material_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_set_skybox_Public_Static_set_Void_Material_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_get_sun_Public_Static_get_Light_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_set_sun_Public_Static_set_Void_Light_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Public_Static_get_SphericalHarmonicsL2_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientProbe_Public_Static_set_Void_SphericalHarmonicsL2_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_get_customReflection_Public_Static_get_Cubemap_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_set_customReflection_Public_Static_set_Void_Cubemap_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_get_customReflectionTexture_Public_Static_get_Texture_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_set_customReflectionTexture_Public_Static_set_Void_Texture_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionIntensity_Public_Static_get_Single_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionIntensity_Public_Static_set_Void_Single_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_get_reflectionBounces_Public_Static_get_Int32_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_set_reflectionBounces_Public_Static_set_Void_Int32_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflection_Internal_Static_get_Cubemap_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflectionMode_Public_Static_get_DefaultReflectionMode_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultReflectionMode_Public_Static_set_Void_DefaultReflectionMode_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultReflectionResolution_Public_Static_get_Int32_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultReflectionResolution_Public_Static_set_Void_Int32_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_get_haloStrength_Public_Static_get_Single_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_set_haloStrength_Public_Static_set_Void_Single_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_get_flareStrength_Public_Static_get_Single_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_set_flareStrength_Public_Static_set_Void_Single_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_get_flareFadeSpeed_Public_Static_get_Single_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_set_flareFadeSpeed_Public_Static_set_Void_Single_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderSettings_Internal_Static_Object_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Internal_Static_Void_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_get_fogColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_set_fogColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientSkyColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientEquatorColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientGroundColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientLight_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientLight_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_get_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_set_subtractiveShadowColor_Injected_Private_Static_Void_byref_Color_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_set_ambientProbe_Injected_Private_Static_Void_byref_SphericalHarmonicsL2_0;
	}
}
