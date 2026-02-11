using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200007C RID: 124
	public sealed class ReflectionProbe : Behaviour
	{
		// Token: 0x060005BF RID: 1471 RVA: 0x00029250 File Offset: 0x00027450
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionProbe()
		{
			Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ReflectionProbe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr);
			ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "reflectionProbeChanged");
			ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionSetActions");
			ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, "registeredDefaultReflectionTextureActions");
			ReflectionProbe.NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664022);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664023);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664024);
			ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664025);
			ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664026);
			ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionProbe>.NativeClassPtr, 100664028);
			ReflectionProbe.get_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_typeDelegate>("UnityEngine.ReflectionProbe::get_type");
			ReflectionProbe.set_typeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_typeDelegate>("UnityEngine.ReflectionProbe::set_type");
			ReflectionProbe.get_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_nearClipPlane");
			ReflectionProbe.set_nearClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_nearClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_nearClipPlane");
			ReflectionProbe.get_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::get_farClipPlane");
			ReflectionProbe.set_farClipPlaneDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_farClipPlaneDelegate>("UnityEngine.ReflectionProbe::set_farClipPlane");
			ReflectionProbe.get_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_intensityDelegate>("UnityEngine.ReflectionProbe::get_intensity");
			ReflectionProbe.set_intensityDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_intensityDelegate>("UnityEngine.ReflectionProbe::set_intensity");
			ReflectionProbe.get_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_hdrDelegate>("UnityEngine.ReflectionProbe::get_hdr");
			ReflectionProbe.set_hdrDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_hdrDelegate>("UnityEngine.ReflectionProbe::set_hdr");
			ReflectionProbe.get_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::get_renderDynamicObjects");
			ReflectionProbe.set_renderDynamicObjectsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_renderDynamicObjectsDelegate>("UnityEngine.ReflectionProbe::set_renderDynamicObjects");
			ReflectionProbe.get_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::get_shadowDistance");
			ReflectionProbe.set_shadowDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_shadowDistanceDelegate>("UnityEngine.ReflectionProbe::set_shadowDistance");
			ReflectionProbe.get_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_resolutionDelegate>("UnityEngine.ReflectionProbe::get_resolution");
			ReflectionProbe.set_resolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_resolutionDelegate>("UnityEngine.ReflectionProbe::set_resolution");
			ReflectionProbe.get_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_cullingMaskDelegate>("UnityEngine.ReflectionProbe::get_cullingMask");
			ReflectionProbe.set_cullingMaskDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_cullingMaskDelegate>("UnityEngine.ReflectionProbe::set_cullingMask");
			ReflectionProbe.get_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_clearFlagsDelegate>("UnityEngine.ReflectionProbe::get_clearFlags");
			ReflectionProbe.set_clearFlagsDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_clearFlagsDelegate>("UnityEngine.ReflectionProbe::set_clearFlags");
			ReflectionProbe.get_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_blendDistanceDelegate>("UnityEngine.ReflectionProbe::get_blendDistance");
			ReflectionProbe.set_blendDistanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_blendDistanceDelegate>("UnityEngine.ReflectionProbe::set_blendDistance");
			ReflectionProbe.get_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_boxProjectionDelegate>("UnityEngine.ReflectionProbe::get_boxProjection");
			ReflectionProbe.set_boxProjectionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_boxProjectionDelegate>("UnityEngine.ReflectionProbe::set_boxProjection");
			ReflectionProbe.get_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_modeDelegate>("UnityEngine.ReflectionProbe::get_mode");
			ReflectionProbe.set_modeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_modeDelegate>("UnityEngine.ReflectionProbe::set_mode");
			ReflectionProbe.get_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_importanceDelegate>("UnityEngine.ReflectionProbe::get_importance");
			ReflectionProbe.set_importanceDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_importanceDelegate>("UnityEngine.ReflectionProbe::set_importance");
			ReflectionProbe.set_refreshModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_refreshModeDelegate>("UnityEngine.ReflectionProbe::set_refreshMode");
			ReflectionProbe.get_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::get_timeSlicingMode");
			ReflectionProbe.set_timeSlicingModeDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_timeSlicingModeDelegate>("UnityEngine.ReflectionProbe::set_timeSlicingMode");
			ReflectionProbe.get_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bakedTextureDelegate>("UnityEngine.ReflectionProbe::get_bakedTexture");
			ReflectionProbe.set_bakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_bakedTextureDelegate>("UnityEngine.ReflectionProbe::set_bakedTexture");
			ReflectionProbe.get_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::get_customBakedTexture");
			ReflectionProbe.set_customBakedTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_customBakedTextureDelegate>("UnityEngine.ReflectionProbe::set_customBakedTexture");
			ReflectionProbe.get_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::get_realtimeTexture");
			ReflectionProbe.set_realtimeTextureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_realtimeTextureDelegate>("UnityEngine.ReflectionProbe::set_realtimeTexture");
			ReflectionProbe.get_textureDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureDelegate>("UnityEngine.ReflectionProbe::get_texture");
			ReflectionProbe.ResetDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ResetDelegate>("UnityEngine.ReflectionProbe::Reset");
			ReflectionProbe.IsFinishedRenderingDelegateField = IL2CPP.ResolveICall<ReflectionProbe.IsFinishedRenderingDelegate>("UnityEngine.ReflectionProbe::IsFinishedRendering");
			ReflectionProbe.ScheduleRenderDelegateField = IL2CPP.ResolveICall<ReflectionProbe.ScheduleRenderDelegate>("UnityEngine.ReflectionProbe::ScheduleRender");
			ReflectionProbe.BlendCubemapDelegateField = IL2CPP.ResolveICall<ReflectionProbe.BlendCubemapDelegate>("UnityEngine.ReflectionProbe::BlendCubemap");
			ReflectionProbe.UpdateCachedStateDelegateField = IL2CPP.ResolveICall<ReflectionProbe.UpdateCachedStateDelegate>("UnityEngine.ReflectionProbe::UpdateCachedState");
			ReflectionProbe.get_minBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_minBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_minBakedCubemapResolution");
			ReflectionProbe.get_maxBakedCubemapResolutionDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_maxBakedCubemapResolutionDelegate>("UnityEngine.ReflectionProbe::get_maxBakedCubemapResolution");
			ReflectionProbe.get_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_size_InjectedDelegate>("UnityEngine.ReflectionProbe::get_size_Injected");
			ReflectionProbe.set_size_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_size_InjectedDelegate>("UnityEngine.ReflectionProbe::set_size_Injected");
			ReflectionProbe.get_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_center_InjectedDelegate>("UnityEngine.ReflectionProbe::get_center_Injected");
			ReflectionProbe.set_center_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_center_InjectedDelegate>("UnityEngine.ReflectionProbe::set_center_Injected");
			ReflectionProbe.get_bounds_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_bounds_InjectedDelegate>("UnityEngine.ReflectionProbe::get_bounds_Injected");
			ReflectionProbe.get_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::get_backgroundColor_Injected");
			ReflectionProbe.set_backgroundColor_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.set_backgroundColor_InjectedDelegate>("UnityEngine.ReflectionProbe::set_backgroundColor_Injected");
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField = IL2CPP.ResolveICall<ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate>("UnityEngine.ReflectionProbe::get_textureHDRDecodeValues_Injected");
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00029650 File Offset: 0x00027850
		// (set) Token: 0x060005F0 RID: 1520 RVA: 0x00004550 File Offset: 0x00002750
		public unsafe UnityEngine.Rendering.ReflectionProbeRefreshMode refreshMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 646379, RefRangeEnd = 646380, XrefRangeStart = 646377, XrefRangeEnd = 646379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				ReflectionProbe.set_refreshModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005C1 RID: 1473 RVA: 0x0002968C File Offset: 0x0002788C
		public unsafe static Vector4 defaultTextureHDRDecodeValues
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 646385, RefRangeEnd = 646387, XrefRangeStart = 646380, XrefRangeEnd = 646385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x000296BC File Offset: 0x000278BC
		public unsafe static Texture defaultTexture
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 646389, RefRangeEnd = 646390, XrefRangeStart = 646387, XrefRangeEnd = 646389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr3) : null;
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000296F0 File Offset: 0x000278F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646390, XrefRangeEnd = 646394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallReflectionProbeEvent(ReflectionProbe probe, ReflectionProbe.ReflectionProbeEvent probeEvent)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(probe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probeEvent;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x00029734 File Offset: 0x00027934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646394, XrefRangeEnd = 646412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CallSetDefaultReflection(Texture defaultReflectionCubemap)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(defaultReflectionCubemap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x0002976C File Offset: 0x0002796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646412, XrefRangeEnd = 646414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void get_defaultTextureHDRDecodeValues_Injected(out Vector4 ret)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &ret;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionProbe.NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x000042ED File Offset: 0x000024ED
		public ReflectionProbe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000297A0 File Offset: 0x000279A0
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000042F6 File Offset: 0x000024F6
		public unsafe static Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> reflectionProbeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_reflectionProbeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000297C8 File Offset: 0x000279C8
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x00004308 File Offset: 0x00002508
		public unsafe static Dictionary<int, Action<Texture>> registeredDefaultReflectionSetActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action<Texture>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionSetActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005CB RID: 1483 RVA: 0x000297F0 File Offset: 0x000279F0
		// (set) Token: 0x060005CC RID: 1484 RVA: 0x0000431A File Offset: 0x0000251A
		public unsafe static List<Action<Texture>> registeredDefaultReflectionTextureActions
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Action<Texture>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReflectionProbe.NativeFieldInfoPtr_registeredDefaultReflectionTextureActions, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x0000432C File Offset: 0x0000252C
		// (set) Token: 0x060005CE RID: 1486 RVA: 0x0000433E File Offset: 0x0000253E
		public UnityEngine.Rendering.ReflectionProbeType type
		{
			get
			{
				return ReflectionProbe.get_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_typeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005CF RID: 1487 RVA: 0x00029818 File Offset: 0x00027A18
		// (set) Token: 0x060005D0 RID: 1488 RVA: 0x00004351 File Offset: 0x00002551
		public Vector3 size
		{
			get
			{
				Vector3 vector;
				this.get_size_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_size_Injected(ref value);
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005D1 RID: 1489 RVA: 0x00029830 File Offset: 0x00027A30
		// (set) Token: 0x060005D2 RID: 1490 RVA: 0x0000435B File Offset: 0x0000255B
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005D3 RID: 1491 RVA: 0x00004365 File Offset: 0x00002565
		// (set) Token: 0x060005D4 RID: 1492 RVA: 0x00004377 File Offset: 0x00002577
		public float nearClipPlane
		{
			get
			{
				return ReflectionProbe.get_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_nearClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x0000438A File Offset: 0x0000258A
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x0000439C File Offset: 0x0000259C
		public float farClipPlane
		{
			get
			{
				return ReflectionProbe.get_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_farClipPlaneDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x000043AF File Offset: 0x000025AF
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x000043C1 File Offset: 0x000025C1
		public float intensity
		{
			get
			{
				return ReflectionProbe.get_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_intensityDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00029848 File Offset: 0x00027A48
		public Bounds bounds
		{
			get
			{
				Bounds bounds;
				this.get_bounds_Injected(out bounds);
				return bounds;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x000043D4 File Offset: 0x000025D4
		// (set) Token: 0x060005DB RID: 1499 RVA: 0x000043E6 File Offset: 0x000025E6
		public bool hdr
		{
			get
			{
				return ReflectionProbe.get_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_hdrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000043F9 File Offset: 0x000025F9
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x0000440B File Offset: 0x0000260B
		public bool renderDynamicObjects
		{
			get
			{
				return ReflectionProbe.get_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_renderDynamicObjectsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x0000441E File Offset: 0x0000261E
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00004430 File Offset: 0x00002630
		public float shadowDistance
		{
			get
			{
				return ReflectionProbe.get_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_shadowDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00004443 File Offset: 0x00002643
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00004455 File Offset: 0x00002655
		public int resolution
		{
			get
			{
				return ReflectionProbe.get_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_resolutionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00004468 File Offset: 0x00002668
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x0000447A File Offset: 0x0000267A
		public int cullingMask
		{
			get
			{
				return ReflectionProbe.get_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_cullingMaskDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x0000448D File Offset: 0x0000268D
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x0000449F File Offset: 0x0000269F
		public UnityEngine.Rendering.ReflectionProbeClearFlags clearFlags
		{
			get
			{
				return ReflectionProbe.get_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_clearFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005E6 RID: 1510 RVA: 0x00029860 File Offset: 0x00027A60
		// (set) Token: 0x060005E7 RID: 1511 RVA: 0x000044B2 File Offset: 0x000026B2
		public Color backgroundColor
		{
			get
			{
				Color color;
				this.get_backgroundColor_Injected(out color);
				return color;
			}
			set
			{
				this.set_backgroundColor_Injected(ref value);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x000044BC File Offset: 0x000026BC
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x000044CE File Offset: 0x000026CE
		public float blendDistance
		{
			get
			{
				return ReflectionProbe.get_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_blendDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005EA RID: 1514 RVA: 0x000044E1 File Offset: 0x000026E1
		// (set) Token: 0x060005EB RID: 1515 RVA: 0x000044F3 File Offset: 0x000026F3
		public bool boxProjection
		{
			get
			{
				return ReflectionProbe.get_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_boxProjectionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x00004506 File Offset: 0x00002706
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x00004518 File Offset: 0x00002718
		public UnityEngine.Rendering.ReflectionProbeMode mode
		{
			get
			{
				return ReflectionProbe.get_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_modeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x0000452B File Offset: 0x0000272B
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x0000453D File Offset: 0x0000273D
		public int importance
		{
			get
			{
				return ReflectionProbe.get_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_importanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060005F1 RID: 1521 RVA: 0x00004563 File Offset: 0x00002763
		// (set) Token: 0x060005F2 RID: 1522 RVA: 0x00004575 File Offset: 0x00002775
		public UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode
		{
			get
			{
				return ReflectionProbe.get_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				ReflectionProbe.set_timeSlicingModeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060005F3 RID: 1523 RVA: 0x00029878 File Offset: 0x00027A78
		// (set) Token: 0x060005F4 RID: 1524 RVA: 0x00004588 File Offset: 0x00002788
		public Texture bakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_bakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005F5 RID: 1525 RVA: 0x000298A4 File Offset: 0x00027AA4
		// (set) Token: 0x060005F6 RID: 1526 RVA: 0x000045A0 File Offset: 0x000027A0
		public Texture customBakedTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_customBakedTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060005F7 RID: 1527 RVA: 0x000298D0 File Offset: 0x00027AD0
		// (set) Token: 0x060005F8 RID: 1528 RVA: 0x000045B8 File Offset: 0x000027B8
		public RenderTexture realtimeTexture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				ReflectionProbe.set_realtimeTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060005F9 RID: 1529 RVA: 0x000298FC File Offset: 0x00027AFC
		public Texture texture
		{
			get
			{
				IntPtr intPtr = ReflectionProbe.get_textureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060005FA RID: 1530 RVA: 0x00029928 File Offset: 0x00027B28
		public Vector4 textureHDRDecodeValues
		{
			get
			{
				Vector4 vector;
				this.get_textureHDRDecodeValues_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x000045D0 File Offset: 0x000027D0
		public void Reset()
		{
			ReflectionProbe.ResetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x00029940 File Offset: 0x00027B40
		public int RenderProbe()
		{
			return this.RenderProbe(null);
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0002995C File Offset: 0x00027B5C
		public int RenderProbe(RenderTexture targetTexture)
		{
			return this.ScheduleRender(this.timeSlicingMode, targetTexture);
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x000045E2 File Offset: 0x000027E2
		public bool IsFinishedRendering(int renderId)
		{
			return ReflectionProbe.IsFinishedRenderingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), renderId);
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000045F5 File Offset: 0x000027F5
		public int ScheduleRender(UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, RenderTexture targetTexture)
		{
			return ReflectionProbe.ScheduleRenderDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), timeSlicingMode, IL2CPP.Il2CppObjectBaseToPtr(targetTexture));
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000460E File Offset: 0x0000280E
		public static bool BlendCubemap(Texture src, Texture dst, float blend, RenderTexture target)
		{
			return ReflectionProbe.BlendCubemapDelegateField(IL2CPP.Il2CppObjectBaseToPtr(src), IL2CPP.Il2CppObjectBaseToPtr(dst), blend, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000462D File Offset: 0x0000282D
		public static void UpdateCachedState()
		{
			ReflectionProbe.UpdateCachedStateDelegateField();
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x00004639 File Offset: 0x00002839
		public static int minBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_minBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x00004645 File Offset: 0x00002845
		public static int maxBakedCubemapResolution
		{
			get
			{
				return ReflectionProbe.get_maxBakedCubemapResolutionDelegateField();
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x00004651 File Offset: 0x00002851
		public static void add_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000465E File Offset: 0x0000285E
		public static void remove_reflectionProbeChanged(Action<ReflectionProbe, ReflectionProbe.ReflectionProbeEvent> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000466B File Offset: 0x0000286B
		public static void add_defaultReflectionSet(Action<Cubemap> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0002997C File Offset: 0x00027B7C
		public static void remove_defaultReflectionSet(Action<Cubemap> value)
		{
			Action<Texture> action;
			bool flag = ReflectionProbe.registeredDefaultReflectionSetActions.TryGetValue(value.Method.GetHashCode(), out action);
			if (flag)
			{
				ReflectionProbe.remove_defaultReflectionTexture(action);
				ReflectionProbe.registeredDefaultReflectionSetActions.Remove(value.Method.GetHashCode());
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00004678 File Offset: 0x00002878
		public static void add_defaultReflectionTexture(Action<Texture> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00004685 File Offset: 0x00002885
		public static void remove_defaultReflectionTexture(Action<Texture> value)
		{
			ReflectionProbe.registeredDefaultReflectionTextureActions.Remove(value);
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00004694 File Offset: 0x00002894
		public void get_size_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x000046A7 File Offset: 0x000028A7
		public void set_size_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_size_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x000046BA File Offset: 0x000028BA
		public void get_center_Injected(out Vector3 ret)
		{
			ReflectionProbe.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x000046CD File Offset: 0x000028CD
		public void set_center_Injected(ref Vector3 value)
		{
			ReflectionProbe.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x000046E0 File Offset: 0x000028E0
		public void get_bounds_Injected(out Bounds ret)
		{
			ReflectionProbe.get_bounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x000046F3 File Offset: 0x000028F3
		public void get_backgroundColor_Injected(out Color ret)
		{
			ReflectionProbe.get_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00004706 File Offset: 0x00002906
		public void set_backgroundColor_Injected(ref Color value)
		{
			ReflectionProbe.set_backgroundColor_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00004719 File Offset: 0x00002919
		public void get_textureHDRDecodeValues_Injected(out Vector4 ret)
		{
			ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_reflectionProbeChanged;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_registeredDefaultReflectionSetActions;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_registeredDefaultReflectionTextureActions;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeMethodInfoPtr_get_refreshMode_Public_get_ReflectionProbeRefreshMode_0;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Public_Static_get_Vector4_0;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTexture_Public_Static_get_Texture_0;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeMethodInfoPtr_CallReflectionProbeEvent_Private_Static_Void_ReflectionProbe_ReflectionProbeEvent_0;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeMethodInfoPtr_CallSetDefaultReflection_Private_Static_Void_Texture_0;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultTextureHDRDecodeValues_Injected_Private_Static_Void_byref_Vector4_0;

		// Token: 0x04000514 RID: 1300
		private static readonly ReflectionProbe.get_typeDelegate get_typeDelegateField;

		// Token: 0x04000515 RID: 1301
		private static readonly ReflectionProbe.set_typeDelegate set_typeDelegateField;

		// Token: 0x04000516 RID: 1302
		private static readonly ReflectionProbe.get_nearClipPlaneDelegate get_nearClipPlaneDelegateField;

		// Token: 0x04000517 RID: 1303
		private static readonly ReflectionProbe.set_nearClipPlaneDelegate set_nearClipPlaneDelegateField;

		// Token: 0x04000518 RID: 1304
		private static readonly ReflectionProbe.get_farClipPlaneDelegate get_farClipPlaneDelegateField;

		// Token: 0x04000519 RID: 1305
		private static readonly ReflectionProbe.set_farClipPlaneDelegate set_farClipPlaneDelegateField;

		// Token: 0x0400051A RID: 1306
		private static readonly ReflectionProbe.get_intensityDelegate get_intensityDelegateField;

		// Token: 0x0400051B RID: 1307
		private static readonly ReflectionProbe.set_intensityDelegate set_intensityDelegateField;

		// Token: 0x0400051C RID: 1308
		private static readonly ReflectionProbe.get_hdrDelegate get_hdrDelegateField;

		// Token: 0x0400051D RID: 1309
		private static readonly ReflectionProbe.set_hdrDelegate set_hdrDelegateField;

		// Token: 0x0400051E RID: 1310
		private static readonly ReflectionProbe.get_renderDynamicObjectsDelegate get_renderDynamicObjectsDelegateField;

		// Token: 0x0400051F RID: 1311
		private static readonly ReflectionProbe.set_renderDynamicObjectsDelegate set_renderDynamicObjectsDelegateField;

		// Token: 0x04000520 RID: 1312
		private static readonly ReflectionProbe.get_shadowDistanceDelegate get_shadowDistanceDelegateField;

		// Token: 0x04000521 RID: 1313
		private static readonly ReflectionProbe.set_shadowDistanceDelegate set_shadowDistanceDelegateField;

		// Token: 0x04000522 RID: 1314
		private static readonly ReflectionProbe.get_resolutionDelegate get_resolutionDelegateField;

		// Token: 0x04000523 RID: 1315
		private static readonly ReflectionProbe.set_resolutionDelegate set_resolutionDelegateField;

		// Token: 0x04000524 RID: 1316
		private static readonly ReflectionProbe.get_cullingMaskDelegate get_cullingMaskDelegateField;

		// Token: 0x04000525 RID: 1317
		private static readonly ReflectionProbe.set_cullingMaskDelegate set_cullingMaskDelegateField;

		// Token: 0x04000526 RID: 1318
		private static readonly ReflectionProbe.get_clearFlagsDelegate get_clearFlagsDelegateField;

		// Token: 0x04000527 RID: 1319
		private static readonly ReflectionProbe.set_clearFlagsDelegate set_clearFlagsDelegateField;

		// Token: 0x04000528 RID: 1320
		private static readonly ReflectionProbe.get_blendDistanceDelegate get_blendDistanceDelegateField;

		// Token: 0x04000529 RID: 1321
		private static readonly ReflectionProbe.set_blendDistanceDelegate set_blendDistanceDelegateField;

		// Token: 0x0400052A RID: 1322
		private static readonly ReflectionProbe.get_boxProjectionDelegate get_boxProjectionDelegateField;

		// Token: 0x0400052B RID: 1323
		private static readonly ReflectionProbe.set_boxProjectionDelegate set_boxProjectionDelegateField;

		// Token: 0x0400052C RID: 1324
		private static readonly ReflectionProbe.get_modeDelegate get_modeDelegateField;

		// Token: 0x0400052D RID: 1325
		private static readonly ReflectionProbe.set_modeDelegate set_modeDelegateField;

		// Token: 0x0400052E RID: 1326
		private static readonly ReflectionProbe.get_importanceDelegate get_importanceDelegateField;

		// Token: 0x0400052F RID: 1327
		private static readonly ReflectionProbe.set_importanceDelegate set_importanceDelegateField;

		// Token: 0x04000530 RID: 1328
		private static readonly ReflectionProbe.set_refreshModeDelegate set_refreshModeDelegateField;

		// Token: 0x04000531 RID: 1329
		private static readonly ReflectionProbe.get_timeSlicingModeDelegate get_timeSlicingModeDelegateField;

		// Token: 0x04000532 RID: 1330
		private static readonly ReflectionProbe.set_timeSlicingModeDelegate set_timeSlicingModeDelegateField;

		// Token: 0x04000533 RID: 1331
		private static readonly ReflectionProbe.get_bakedTextureDelegate get_bakedTextureDelegateField;

		// Token: 0x04000534 RID: 1332
		private static readonly ReflectionProbe.set_bakedTextureDelegate set_bakedTextureDelegateField;

		// Token: 0x04000535 RID: 1333
		private static readonly ReflectionProbe.get_customBakedTextureDelegate get_customBakedTextureDelegateField;

		// Token: 0x04000536 RID: 1334
		private static readonly ReflectionProbe.set_customBakedTextureDelegate set_customBakedTextureDelegateField;

		// Token: 0x04000537 RID: 1335
		private static readonly ReflectionProbe.get_realtimeTextureDelegate get_realtimeTextureDelegateField;

		// Token: 0x04000538 RID: 1336
		private static readonly ReflectionProbe.set_realtimeTextureDelegate set_realtimeTextureDelegateField;

		// Token: 0x04000539 RID: 1337
		private static readonly ReflectionProbe.get_textureDelegate get_textureDelegateField;

		// Token: 0x0400053A RID: 1338
		private static readonly ReflectionProbe.ResetDelegate ResetDelegateField;

		// Token: 0x0400053B RID: 1339
		private static readonly ReflectionProbe.IsFinishedRenderingDelegate IsFinishedRenderingDelegateField;

		// Token: 0x0400053C RID: 1340
		private static readonly ReflectionProbe.ScheduleRenderDelegate ScheduleRenderDelegateField;

		// Token: 0x0400053D RID: 1341
		private static readonly ReflectionProbe.BlendCubemapDelegate BlendCubemapDelegateField;

		// Token: 0x0400053E RID: 1342
		private static readonly ReflectionProbe.UpdateCachedStateDelegate UpdateCachedStateDelegateField;

		// Token: 0x0400053F RID: 1343
		private static readonly ReflectionProbe.get_minBakedCubemapResolutionDelegate get_minBakedCubemapResolutionDelegateField;

		// Token: 0x04000540 RID: 1344
		private static readonly ReflectionProbe.get_maxBakedCubemapResolutionDelegate get_maxBakedCubemapResolutionDelegateField;

		// Token: 0x04000541 RID: 1345
		private static readonly ReflectionProbe.get_size_InjectedDelegate get_size_InjectedDelegateField;

		// Token: 0x04000542 RID: 1346
		private static readonly ReflectionProbe.set_size_InjectedDelegate set_size_InjectedDelegateField;

		// Token: 0x04000543 RID: 1347
		private static readonly ReflectionProbe.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x04000544 RID: 1348
		private static readonly ReflectionProbe.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x04000545 RID: 1349
		private static readonly ReflectionProbe.get_bounds_InjectedDelegate get_bounds_InjectedDelegateField;

		// Token: 0x04000546 RID: 1350
		private static readonly ReflectionProbe.get_backgroundColor_InjectedDelegate get_backgroundColor_InjectedDelegateField;

		// Token: 0x04000547 RID: 1351
		private static readonly ReflectionProbe.set_backgroundColor_InjectedDelegate set_backgroundColor_InjectedDelegateField;

		// Token: 0x04000548 RID: 1352
		private static readonly ReflectionProbe.get_textureHDRDecodeValues_InjectedDelegate get_textureHDRDecodeValues_InjectedDelegateField;

		// Token: 0x0200045C RID: 1116
		public enum ReflectionProbeEvent
		{
			// Token: 0x04002B69 RID: 11113
			ReflectionProbeAdded,
			// Token: 0x04002B6A RID: 11114
			ReflectionProbeRemoved
		}

		// Token: 0x0200045D RID: 1117
		public sealed class <>c__DisplayClass95_0
		{
		}

		// Token: 0x0200045E RID: 1118
		public sealed class <>c__DisplayClass98_0
		{
		}

		// Token: 0x0200045F RID: 1119
		// (Invoke) Token: 0x060031B5 RID: 12725
		private delegate UnityEngine.Rendering.ReflectionProbeType get_typeDelegate(IntPtr @this);

		// Token: 0x02000460 RID: 1120
		// (Invoke) Token: 0x060031B7 RID: 12727
		private delegate void set_typeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeType value);

		// Token: 0x02000461 RID: 1121
		// (Invoke) Token: 0x060031B9 RID: 12729
		private delegate float get_nearClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000462 RID: 1122
		// (Invoke) Token: 0x060031BB RID: 12731
		private delegate void set_nearClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000463 RID: 1123
		// (Invoke) Token: 0x060031BD RID: 12733
		private delegate float get_farClipPlaneDelegate(IntPtr @this);

		// Token: 0x02000464 RID: 1124
		// (Invoke) Token: 0x060031BF RID: 12735
		private delegate void set_farClipPlaneDelegate(IntPtr @this, float value);

		// Token: 0x02000465 RID: 1125
		// (Invoke) Token: 0x060031C1 RID: 12737
		private delegate float get_intensityDelegate(IntPtr @this);

		// Token: 0x02000466 RID: 1126
		// (Invoke) Token: 0x060031C3 RID: 12739
		private delegate void set_intensityDelegate(IntPtr @this, float value);

		// Token: 0x02000467 RID: 1127
		// (Invoke) Token: 0x060031C5 RID: 12741
		private delegate bool get_hdrDelegate(IntPtr @this);

		// Token: 0x02000468 RID: 1128
		// (Invoke) Token: 0x060031C7 RID: 12743
		private delegate void set_hdrDelegate(IntPtr @this, bool value);

		// Token: 0x02000469 RID: 1129
		// (Invoke) Token: 0x060031C9 RID: 12745
		private delegate bool get_renderDynamicObjectsDelegate(IntPtr @this);

		// Token: 0x0200046A RID: 1130
		// (Invoke) Token: 0x060031CB RID: 12747
		private delegate void set_renderDynamicObjectsDelegate(IntPtr @this, bool value);

		// Token: 0x0200046B RID: 1131
		// (Invoke) Token: 0x060031CD RID: 12749
		private delegate float get_shadowDistanceDelegate(IntPtr @this);

		// Token: 0x0200046C RID: 1132
		// (Invoke) Token: 0x060031CF RID: 12751
		private delegate void set_shadowDistanceDelegate(IntPtr @this, float value);

		// Token: 0x0200046D RID: 1133
		// (Invoke) Token: 0x060031D1 RID: 12753
		private delegate int get_resolutionDelegate(IntPtr @this);

		// Token: 0x0200046E RID: 1134
		// (Invoke) Token: 0x060031D3 RID: 12755
		private delegate void set_resolutionDelegate(IntPtr @this, int value);

		// Token: 0x0200046F RID: 1135
		// (Invoke) Token: 0x060031D5 RID: 12757
		private delegate int get_cullingMaskDelegate(IntPtr @this);

		// Token: 0x02000470 RID: 1136
		// (Invoke) Token: 0x060031D7 RID: 12759
		private delegate void set_cullingMaskDelegate(IntPtr @this, int value);

		// Token: 0x02000471 RID: 1137
		// (Invoke) Token: 0x060031D9 RID: 12761
		private delegate UnityEngine.Rendering.ReflectionProbeClearFlags get_clearFlagsDelegate(IntPtr @this);

		// Token: 0x02000472 RID: 1138
		// (Invoke) Token: 0x060031DB RID: 12763
		private delegate void set_clearFlagsDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeClearFlags value);

		// Token: 0x02000473 RID: 1139
		// (Invoke) Token: 0x060031DD RID: 12765
		private delegate float get_blendDistanceDelegate(IntPtr @this);

		// Token: 0x02000474 RID: 1140
		// (Invoke) Token: 0x060031DF RID: 12767
		private delegate void set_blendDistanceDelegate(IntPtr @this, float value);

		// Token: 0x02000475 RID: 1141
		// (Invoke) Token: 0x060031E1 RID: 12769
		private delegate bool get_boxProjectionDelegate(IntPtr @this);

		// Token: 0x02000476 RID: 1142
		// (Invoke) Token: 0x060031E3 RID: 12771
		private delegate void set_boxProjectionDelegate(IntPtr @this, bool value);

		// Token: 0x02000477 RID: 1143
		// (Invoke) Token: 0x060031E5 RID: 12773
		private delegate UnityEngine.Rendering.ReflectionProbeMode get_modeDelegate(IntPtr @this);

		// Token: 0x02000478 RID: 1144
		// (Invoke) Token: 0x060031E7 RID: 12775
		private delegate void set_modeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeMode value);

		// Token: 0x02000479 RID: 1145
		// (Invoke) Token: 0x060031E9 RID: 12777
		private delegate int get_importanceDelegate(IntPtr @this);

		// Token: 0x0200047A RID: 1146
		// (Invoke) Token: 0x060031EB RID: 12779
		private delegate void set_importanceDelegate(IntPtr @this, int value);

		// Token: 0x0200047B RID: 1147
		// (Invoke) Token: 0x060031ED RID: 12781
		private delegate void set_refreshModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeRefreshMode value);

		// Token: 0x0200047C RID: 1148
		// (Invoke) Token: 0x060031EF RID: 12783
		private delegate UnityEngine.Rendering.ReflectionProbeTimeSlicingMode get_timeSlicingModeDelegate(IntPtr @this);

		// Token: 0x0200047D RID: 1149
		// (Invoke) Token: 0x060031F1 RID: 12785
		private delegate void set_timeSlicingModeDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode value);

		// Token: 0x0200047E RID: 1150
		// (Invoke) Token: 0x060031F3 RID: 12787
		private delegate IntPtr get_bakedTextureDelegate(IntPtr @this);

		// Token: 0x0200047F RID: 1151
		// (Invoke) Token: 0x060031F5 RID: 12789
		private delegate void set_bakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000480 RID: 1152
		// (Invoke) Token: 0x060031F7 RID: 12791
		private delegate IntPtr get_customBakedTextureDelegate(IntPtr @this);

		// Token: 0x02000481 RID: 1153
		// (Invoke) Token: 0x060031F9 RID: 12793
		private delegate void set_customBakedTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000482 RID: 1154
		// (Invoke) Token: 0x060031FB RID: 12795
		private delegate IntPtr get_realtimeTextureDelegate(IntPtr @this);

		// Token: 0x02000483 RID: 1155
		// (Invoke) Token: 0x060031FD RID: 12797
		private delegate void set_realtimeTextureDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000484 RID: 1156
		// (Invoke) Token: 0x060031FF RID: 12799
		private delegate IntPtr get_textureDelegate(IntPtr @this);

		// Token: 0x02000485 RID: 1157
		// (Invoke) Token: 0x06003201 RID: 12801
		private delegate void ResetDelegate(IntPtr @this);

		// Token: 0x02000486 RID: 1158
		// (Invoke) Token: 0x06003203 RID: 12803
		private delegate bool IsFinishedRenderingDelegate(IntPtr @this, int renderId);

		// Token: 0x02000487 RID: 1159
		// (Invoke) Token: 0x06003205 RID: 12805
		private delegate int ScheduleRenderDelegate(IntPtr @this, UnityEngine.Rendering.ReflectionProbeTimeSlicingMode timeSlicingMode, IntPtr targetTexture);

		// Token: 0x02000488 RID: 1160
		// (Invoke) Token: 0x06003207 RID: 12807
		private delegate bool BlendCubemapDelegate(IntPtr src, IntPtr dst, float blend, IntPtr target);

		// Token: 0x02000489 RID: 1161
		// (Invoke) Token: 0x06003209 RID: 12809
		private delegate void UpdateCachedStateDelegate();

		// Token: 0x0200048A RID: 1162
		// (Invoke) Token: 0x0600320B RID: 12811
		private delegate int get_minBakedCubemapResolutionDelegate();

		// Token: 0x0200048B RID: 1163
		// (Invoke) Token: 0x0600320D RID: 12813
		private delegate int get_maxBakedCubemapResolutionDelegate();

		// Token: 0x0200048C RID: 1164
		// (Invoke) Token: 0x0600320F RID: 12815
		private delegate void get_size_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200048D RID: 1165
		// (Invoke) Token: 0x06003211 RID: 12817
		private delegate void set_size_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200048E RID: 1166
		// (Invoke) Token: 0x06003213 RID: 12819
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200048F RID: 1167
		// (Invoke) Token: 0x06003215 RID: 12821
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000490 RID: 1168
		// (Invoke) Token: 0x06003217 RID: 12823
		private delegate void get_bounds_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000491 RID: 1169
		// (Invoke) Token: 0x06003219 RID: 12825
		private delegate void get_backgroundColor_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x02000492 RID: 1170
		// (Invoke) Token: 0x0600321B RID: 12827
		private delegate void set_backgroundColor_InjectedDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000493 RID: 1171
		// (Invoke) Token: 0x0600321D RID: 12829
		private delegate void get_textureHDRDecodeValues_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);
	}
}
