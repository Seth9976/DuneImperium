using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.VFX
{
	// Token: 0x0200000D RID: 13
	public class VisualEffect : Behaviour
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x00004EBC File Offset: 0x000030BC
		// Note: this type is marked as 'beforefieldinit'.
		static VisualEffect()
		{
			Il2CppClassPointerStore<VisualEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VisualEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr);
			VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, "m_cachedEventAttribute");
			VisualEffect.NativeFieldInfoPtr_outputEventReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, "outputEventReceived");
			VisualEffect.NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663329);
			VisualEffect.NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663330);
			VisualEffect.NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663331);
			VisualEffect.NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VisualEffect>.NativeClassPtr, 100663332);
			VisualEffect.get_pauseDelegateField = IL2CPP.ResolveICall<VisualEffect.get_pauseDelegate>("UnityEngine.VFX.VisualEffect::get_pause");
			VisualEffect.set_pauseDelegateField = IL2CPP.ResolveICall<VisualEffect.set_pauseDelegate>("UnityEngine.VFX.VisualEffect::set_pause");
			VisualEffect.get_playRateDelegateField = IL2CPP.ResolveICall<VisualEffect.get_playRateDelegate>("UnityEngine.VFX.VisualEffect::get_playRate");
			VisualEffect.set_playRateDelegateField = IL2CPP.ResolveICall<VisualEffect.set_playRateDelegate>("UnityEngine.VFX.VisualEffect::set_playRate");
			VisualEffect.get_startSeedDelegateField = IL2CPP.ResolveICall<VisualEffect.get_startSeedDelegate>("UnityEngine.VFX.VisualEffect::get_startSeed");
			VisualEffect.set_startSeedDelegateField = IL2CPP.ResolveICall<VisualEffect.set_startSeedDelegate>("UnityEngine.VFX.VisualEffect::set_startSeed");
			VisualEffect.get_resetSeedOnPlayDelegateField = IL2CPP.ResolveICall<VisualEffect.get_resetSeedOnPlayDelegate>("UnityEngine.VFX.VisualEffect::get_resetSeedOnPlay");
			VisualEffect.set_resetSeedOnPlayDelegateField = IL2CPP.ResolveICall<VisualEffect.set_resetSeedOnPlayDelegate>("UnityEngine.VFX.VisualEffect::set_resetSeedOnPlay");
			VisualEffect.get_initialEventIDDelegateField = IL2CPP.ResolveICall<VisualEffect.get_initialEventIDDelegate>("UnityEngine.VFX.VisualEffect::get_initialEventID");
			VisualEffect.set_initialEventIDDelegateField = IL2CPP.ResolveICall<VisualEffect.set_initialEventIDDelegate>("UnityEngine.VFX.VisualEffect::set_initialEventID");
			VisualEffect.get_initialEventNameDelegateField = IL2CPP.ResolveICall<VisualEffect.get_initialEventNameDelegate>("UnityEngine.VFX.VisualEffect::get_initialEventName");
			VisualEffect.set_initialEventNameDelegateField = IL2CPP.ResolveICall<VisualEffect.set_initialEventNameDelegate>("UnityEngine.VFX.VisualEffect::set_initialEventName");
			VisualEffect.get_culledDelegateField = IL2CPP.ResolveICall<VisualEffect.get_culledDelegate>("UnityEngine.VFX.VisualEffect::get_culled");
			VisualEffect.set_visualEffectAssetDelegateField = IL2CPP.ResolveICall<VisualEffect.set_visualEffectAssetDelegate>("UnityEngine.VFX.VisualEffect::set_visualEffectAsset");
			VisualEffect.SendEventFromScriptDelegateField = IL2CPP.ResolveICall<VisualEffect.SendEventFromScriptDelegate>("UnityEngine.VFX.VisualEffect::SendEventFromScript");
			VisualEffect.ReinitDelegateField = IL2CPP.ResolveICall<VisualEffect.ReinitDelegate>("UnityEngine.VFX.VisualEffect::Reinit");
			VisualEffect.AdvanceOneFrameDelegateField = IL2CPP.ResolveICall<VisualEffect.AdvanceOneFrameDelegate>("UnityEngine.VFX.VisualEffect::AdvanceOneFrame");
			VisualEffect.RecreateDataDelegateField = IL2CPP.ResolveICall<VisualEffect.RecreateDataDelegate>("UnityEngine.VFX.VisualEffect::RecreateData");
			VisualEffect.ResetOverrideDelegateField = IL2CPP.ResolveICall<VisualEffect.ResetOverrideDelegate>("UnityEngine.VFX.VisualEffect::ResetOverride");
			VisualEffect.GetTextureDimensionDelegateField = IL2CPP.ResolveICall<VisualEffect.GetTextureDimensionDelegate>("UnityEngine.VFX.VisualEffect::GetTextureDimension");
			VisualEffect.HasBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.HasBoolDelegate>("UnityEngine.VFX.VisualEffect::HasBool");
			VisualEffect.HasIntDelegateField = IL2CPP.ResolveICall<VisualEffect.HasIntDelegate>("UnityEngine.VFX.VisualEffect::HasInt");
			VisualEffect.HasUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.HasUIntDelegate>("UnityEngine.VFX.VisualEffect::HasUInt");
			VisualEffect.HasFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.HasFloatDelegate>("UnityEngine.VFX.VisualEffect::HasFloat");
			VisualEffect.HasVector2DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector2Delegate>("UnityEngine.VFX.VisualEffect::HasVector2");
			VisualEffect.HasVector3DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector3Delegate>("UnityEngine.VFX.VisualEffect::HasVector3");
			VisualEffect.HasVector4DelegateField = IL2CPP.ResolveICall<VisualEffect.HasVector4Delegate>("UnityEngine.VFX.VisualEffect::HasVector4");
			VisualEffect.HasMatrix4x4DelegateField = IL2CPP.ResolveICall<VisualEffect.HasMatrix4x4Delegate>("UnityEngine.VFX.VisualEffect::HasMatrix4x4");
			VisualEffect.HasTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.HasTextureDelegate>("UnityEngine.VFX.VisualEffect::HasTexture");
			VisualEffect.HasAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.HasAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::HasAnimationCurve");
			VisualEffect.HasGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.HasGradientDelegate>("UnityEngine.VFX.VisualEffect::HasGradient");
			VisualEffect.HasMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.HasMeshDelegate>("UnityEngine.VFX.VisualEffect::HasMesh");
			VisualEffect.HasSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.HasSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::HasSkinnedMeshRenderer");
			VisualEffect.HasGraphicsBufferDelegateField = IL2CPP.ResolveICall<VisualEffect.HasGraphicsBufferDelegate>("UnityEngine.VFX.VisualEffect::HasGraphicsBuffer");
			VisualEffect.SetBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.SetBoolDelegate>("UnityEngine.VFX.VisualEffect::SetBool");
			VisualEffect.SetIntDelegateField = IL2CPP.ResolveICall<VisualEffect.SetIntDelegate>("UnityEngine.VFX.VisualEffect::SetInt");
			VisualEffect.SetUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.SetUIntDelegate>("UnityEngine.VFX.VisualEffect::SetUInt");
			VisualEffect.SetFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.SetFloatDelegate>("UnityEngine.VFX.VisualEffect::SetFloat");
			VisualEffect.SetTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.SetTextureDelegate>("UnityEngine.VFX.VisualEffect::SetTexture");
			VisualEffect.SetAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.SetAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::SetAnimationCurve");
			VisualEffect.SetGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.SetGradientDelegate>("UnityEngine.VFX.VisualEffect::SetGradient");
			VisualEffect.SetMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.SetMeshDelegate>("UnityEngine.VFX.VisualEffect::SetMesh");
			VisualEffect.SetSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.SetSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::SetSkinnedMeshRenderer");
			VisualEffect.SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<VisualEffect.SetGraphicsBufferDelegate>("UnityEngine.VFX.VisualEffect::SetGraphicsBuffer");
			VisualEffect.GetBoolDelegateField = IL2CPP.ResolveICall<VisualEffect.GetBoolDelegate>("UnityEngine.VFX.VisualEffect::GetBool");
			VisualEffect.GetIntDelegateField = IL2CPP.ResolveICall<VisualEffect.GetIntDelegate>("UnityEngine.VFX.VisualEffect::GetInt");
			VisualEffect.GetUIntDelegateField = IL2CPP.ResolveICall<VisualEffect.GetUIntDelegate>("UnityEngine.VFX.VisualEffect::GetUInt");
			VisualEffect.GetFloatDelegateField = IL2CPP.ResolveICall<VisualEffect.GetFloatDelegate>("UnityEngine.VFX.VisualEffect::GetFloat");
			VisualEffect.GetTextureDelegateField = IL2CPP.ResolveICall<VisualEffect.GetTextureDelegate>("UnityEngine.VFX.VisualEffect::GetTexture");
			VisualEffect.GetMeshDelegateField = IL2CPP.ResolveICall<VisualEffect.GetMeshDelegate>("UnityEngine.VFX.VisualEffect::GetMesh");
			VisualEffect.GetSkinnedMeshRendererDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSkinnedMeshRendererDelegate>("UnityEngine.VFX.VisualEffect::GetSkinnedMeshRenderer");
			VisualEffect.GetGraphicsBufferDelegateField = IL2CPP.ResolveICall<VisualEffect.GetGraphicsBufferDelegate>("UnityEngine.VFX.VisualEffect::GetGraphicsBuffer");
			VisualEffect.Internal_GetGradientDelegateField = IL2CPP.ResolveICall<VisualEffect.Internal_GetGradientDelegate>("UnityEngine.VFX.VisualEffect::Internal_GetGradient");
			VisualEffect.Internal_GetAnimationCurveDelegateField = IL2CPP.ResolveICall<VisualEffect.Internal_GetAnimationCurveDelegate>("UnityEngine.VFX.VisualEffect::Internal_GetAnimationCurve");
			VisualEffect.GetSpawnSystemInfoDelegateField = IL2CPP.ResolveICall<VisualEffect.GetSpawnSystemInfoDelegate>("UnityEngine.VFX.VisualEffect::GetSpawnSystemInfo");
			VisualEffect.HasAnySystemAwakeDelegateField = IL2CPP.ResolveICall<VisualEffect.HasAnySystemAwakeDelegate>("UnityEngine.VFX.VisualEffect::HasAnySystemAwake");
			VisualEffect.get_aliveParticleCountDelegateField = IL2CPP.ResolveICall<VisualEffect.get_aliveParticleCountDelegate>("UnityEngine.VFX.VisualEffect::get_aliveParticleCount");
			VisualEffect.get_timeDelegateField = IL2CPP.ResolveICall<VisualEffect.get_timeDelegate>("UnityEngine.VFX.VisualEffect::get_time");
			VisualEffect.SimulateDelegateField = IL2CPP.ResolveICall<VisualEffect.SimulateDelegate>("UnityEngine.VFX.VisualEffect::Simulate");
			VisualEffect.SetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector2_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector2_Injected");
			VisualEffect.SetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector3_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector3_Injected");
			VisualEffect.SetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetVector4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetVector4_Injected");
			VisualEffect.SetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.SetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::SetMatrix4x4_Injected");
			VisualEffect.GetVector2_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector2_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector2_Injected");
			VisualEffect.GetVector3_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector3_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector3_Injected");
			VisualEffect.GetVector4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetVector4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetVector4_Injected");
			VisualEffect.GetMatrix4x4_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetMatrix4x4_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetMatrix4x4_Injected");
			VisualEffect.GetComputedBounds_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetComputedBounds_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetComputedBounds_Injected");
			VisualEffect.GetCurrentBoundsPadding_InjectedDelegateField = IL2CPP.ResolveICall<VisualEffect.GetCurrentBoundsPadding_InjectedDelegate>("UnityEngine.VFX.VisualEffect::GetCurrentBoundsPadding_Injected");
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00005370 File Offset: 0x00003570
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00002B62 File Offset: 0x00000D62
		public unsafe VisualEffectAsset visualEffectAsset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269815, XrefRangeEnd = 1269817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualEffectAsset>(intPtr3) : null;
			}
			set
			{
				VisualEffect.set_visualEffectAssetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000053B0 File Offset: 0x000035B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269817, XrefRangeEnd = 1269834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXEventAttribute CreateVFXEventAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000053F0 File Offset: 0x000035F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269834, XrefRangeEnd = 1269853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXEventAttribute InvokeGetCachedEventAttributeForOutputEvent_Internal(VisualEffect source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005434 File Offset: 0x00003634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1269853, XrefRangeEnd = 1269854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InvokeOutputEventReceived_Internal(VisualEffect source, int eventNameId)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventNameId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VisualEffect.NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002A38 File Offset: 0x00000C38
		public VisualEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00005478 File Offset: 0x00003678
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002A41 File Offset: 0x00000C41
		public unsafe VFXEventAttribute m_cachedEventAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_m_cachedEventAttribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000FF RID: 255 RVA: 0x000054A8 File Offset: 0x000036A8
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002A60 File Offset: 0x00000C60
		public unsafe Action<VFXOutputEventArgs> outputEventReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_outputEventReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VFXOutputEventArgs>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VisualEffect.NativeFieldInfoPtr_outputEventReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002A7F File Offset: 0x00000C7F
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002A91 File Offset: 0x00000C91
		public bool pause
		{
			get
			{
				return VisualEffect.get_pauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_pauseDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002AB6 File Offset: 0x00000CB6
		public float playRate
		{
			get
			{
				return VisualEffect.get_playRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_playRateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002AC9 File Offset: 0x00000CC9
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002ADB File Offset: 0x00000CDB
		public uint startSeed
		{
			get
			{
				return VisualEffect.get_startSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_startSeedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002AEE File Offset: 0x00000CEE
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002B00 File Offset: 0x00000D00
		public bool resetSeedOnPlay
		{
			get
			{
				return VisualEffect.get_resetSeedOnPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_resetSeedOnPlayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002B13 File Offset: 0x00000D13
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002B25 File Offset: 0x00000D25
		public int initialEventID
		{
			get
			{
				return VisualEffect.get_initialEventIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VisualEffect.set_initialEventIDDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000054D8 File Offset: 0x000036D8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002B38 File Offset: 0x00000D38
		public string initialEventName
		{
			get
			{
				IntPtr intPtr = VisualEffect.get_initialEventNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				VisualEffect.set_initialEventNameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00002B50 File Offset: 0x00000D50
		public bool culled
		{
			get
			{
				return VisualEffect.get_culledDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000054FC File Offset: 0x000036FC
		public void CheckValidVFXEventAttribute(VFXEventAttribute eventAttribute)
		{
			bool flag = eventAttribute != null && eventAttribute.vfxAsset != this.visualEffectAsset;
			if (flag)
			{
				throw new InvalidOperationException("Invalid VFXEventAttribute provided to VisualEffect. It has been created with another VisualEffectAsset. Use CreateVFXEventAttribute.");
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002B7A File Offset: 0x00000D7A
		public void SendEventFromScript(int eventNameID, VFXEventAttribute eventAttribute)
		{
			VisualEffect.SendEventFromScriptDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), eventNameID, IL2CPP.Il2CppObjectBaseToPtr(eventAttribute));
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002B93 File Offset: 0x00000D93
		public void SendEvent(int eventNameID, VFXEventAttribute eventAttribute)
		{
			this.CheckValidVFXEventAttribute(eventAttribute);
			this.SendEventFromScript(eventNameID, eventAttribute);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002BA7 File Offset: 0x00000DA7
		public void SendEvent(string eventName, VFXEventAttribute eventAttribute)
		{
			this.SendEvent(Shader.PropertyToID(eventName), eventAttribute);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002BB8 File Offset: 0x00000DB8
		public void SendEvent(int eventNameID)
		{
			this.SendEventFromScript(eventNameID, null);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00002BC4 File Offset: 0x00000DC4
		public void SendEvent(string eventName)
		{
			this.SendEvent(Shader.PropertyToID(eventName), null);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00002BD5 File Offset: 0x00000DD5
		public void Play(VFXEventAttribute eventAttribute)
		{
			this.SendEvent(VisualEffectAsset.PlayEventID, eventAttribute);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00002BE5 File Offset: 0x00000DE5
		public void Play()
		{
			this.SendEvent(VisualEffectAsset.PlayEventID);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public void Stop(VFXEventAttribute eventAttribute)
		{
			this.SendEvent(VisualEffectAsset.StopEventID, eventAttribute);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00002C04 File Offset: 0x00000E04
		public void Stop()
		{
			this.SendEvent(VisualEffectAsset.StopEventID);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00002C13 File Offset: 0x00000E13
		public void Reinit()
		{
			this.Reinit(true);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00002C1E File Offset: 0x00000E1E
		public void Reinit([Optional] bool sendInitialEventAndPrewarm)
		{
			VisualEffect.ReinitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), sendInitialEventAndPrewarm);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00002C31 File Offset: 0x00000E31
		public void AdvanceOneFrame()
		{
			VisualEffect.AdvanceOneFrameDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00002C43 File Offset: 0x00000E43
		public void RecreateData()
		{
			VisualEffect.RecreateDataDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00002C55 File Offset: 0x00000E55
		public void ResetOverride(int nameID)
		{
			VisualEffect.ResetOverrideDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00002C68 File Offset: 0x00000E68
		public TextureDimension GetTextureDimension(int nameID)
		{
			return VisualEffect.GetTextureDimensionDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002C7B File Offset: 0x00000E7B
		public bool HasBool(int nameID)
		{
			return VisualEffect.HasBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00002C8E File Offset: 0x00000E8E
		public bool HasInt(int nameID)
		{
			return VisualEffect.HasIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00002CA1 File Offset: 0x00000EA1
		public bool HasUInt(int nameID)
		{
			return VisualEffect.HasUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00002CB4 File Offset: 0x00000EB4
		public bool HasFloat(int nameID)
		{
			return VisualEffect.HasFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00002CC7 File Offset: 0x00000EC7
		public bool HasVector2(int nameID)
		{
			return VisualEffect.HasVector2DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00002CDA File Offset: 0x00000EDA
		public bool HasVector3(int nameID)
		{
			return VisualEffect.HasVector3DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002CED File Offset: 0x00000EED
		public bool HasVector4(int nameID)
		{
			return VisualEffect.HasVector4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002D00 File Offset: 0x00000F00
		public bool HasMatrix4x4(int nameID)
		{
			return VisualEffect.HasMatrix4x4DelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002D13 File Offset: 0x00000F13
		public bool HasTexture(int nameID)
		{
			return VisualEffect.HasTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002D26 File Offset: 0x00000F26
		public bool HasAnimationCurve(int nameID)
		{
			return VisualEffect.HasAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002D39 File Offset: 0x00000F39
		public bool HasGradient(int nameID)
		{
			return VisualEffect.HasGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00002D4C File Offset: 0x00000F4C
		public bool HasMesh(int nameID)
		{
			return VisualEffect.HasMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002D5F File Offset: 0x00000F5F
		public bool HasSkinnedMeshRenderer(int nameID)
		{
			return VisualEffect.HasSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002D72 File Offset: 0x00000F72
		public bool HasGraphicsBuffer(int nameID)
		{
			return VisualEffect.HasGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002D85 File Offset: 0x00000F85
		public void SetBool(int nameID, bool b)
		{
			VisualEffect.SetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, b);
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00002D99 File Offset: 0x00000F99
		public void SetInt(int nameID, int i)
		{
			VisualEffect.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002DAD File Offset: 0x00000FAD
		public void SetUInt(int nameID, uint i)
		{
			VisualEffect.SetUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, i);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002DC1 File Offset: 0x00000FC1
		public void SetFloat(int nameID, float f)
		{
			VisualEffect.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, f);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002DD5 File Offset: 0x00000FD5
		public void SetVector2(int nameID, Vector2 v)
		{
			this.SetVector2_Injected(nameID, ref v);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002DE0 File Offset: 0x00000FE0
		public void SetVector3(int nameID, Vector3 v)
		{
			this.SetVector3_Injected(nameID, ref v);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002DEB File Offset: 0x00000FEB
		public void SetVector4(int nameID, Vector4 v)
		{
			this.SetVector4_Injected(nameID, ref v);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002DF6 File Offset: 0x00000FF6
		public void SetMatrix4x4(int nameID, Matrix4x4 v)
		{
			this.SetMatrix4x4_Injected(nameID, ref v);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002E01 File Offset: 0x00001001
		public void SetTexture(int nameID, Texture t)
		{
			VisualEffect.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(t));
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00002E1A File Offset: 0x0000101A
		public void SetAnimationCurve(int nameID, AnimationCurve c)
		{
			VisualEffect.SetAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(c));
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002E33 File Offset: 0x00001033
		public void SetGradient(int nameID, Gradient g)
		{
			VisualEffect.SetGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(g));
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002E4C File Offset: 0x0000104C
		public void SetMesh(int nameID, Mesh m)
		{
			VisualEffect.SetMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002E65 File Offset: 0x00001065
		public void SetSkinnedMeshRenderer(int nameID, SkinnedMeshRenderer m)
		{
			VisualEffect.SetSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(m));
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002E7E File Offset: 0x0000107E
		public void SetGraphicsBuffer(int nameID, GraphicsBuffer g)
		{
			VisualEffect.SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(g));
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002E97 File Offset: 0x00001097
		public bool GetBool(int nameID)
		{
			return VisualEffect.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002EAA File Offset: 0x000010AA
		public int GetInt(int nameID)
		{
			return VisualEffect.GetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002EBD File Offset: 0x000010BD
		public uint GetUInt(int nameID)
		{
			return VisualEffect.GetUIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002ED0 File Offset: 0x000010D0
		public float GetFloat(int nameID)
		{
			return VisualEffect.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00005534 File Offset: 0x00003734
		public Vector2 GetVector2(int nameID)
		{
			Vector2 vector;
			this.GetVector2_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000554C File Offset: 0x0000374C
		public Vector3 GetVector3(int nameID)
		{
			Vector3 vector;
			this.GetVector3_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00005564 File Offset: 0x00003764
		public Vector4 GetVector4(int nameID)
		{
			Vector4 vector;
			this.GetVector4_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000557C File Offset: 0x0000377C
		public Matrix4x4 GetMatrix4x4(int nameID)
		{
			Matrix4x4 matrix4x;
			this.GetMatrix4x4_Injected(nameID, out matrix4x);
			return matrix4x;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005594 File Offset: 0x00003794
		public Texture GetTexture(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture>(intPtr2) : null;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000055C4 File Offset: 0x000037C4
		public Mesh GetMesh(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetMeshDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mesh>(intPtr2) : null;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000055F4 File Offset: 0x000037F4
		public SkinnedMeshRenderer GetSkinnedMeshRenderer(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetSkinnedMeshRendererDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005624 File Offset: 0x00003824
		public GraphicsBuffer GetGraphicsBuffer(int nameID)
		{
			IntPtr intPtr = VisualEffect.GetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GraphicsBuffer>(intPtr2) : null;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005654 File Offset: 0x00003854
		public Gradient GetGradient(int nameID)
		{
			Gradient gradient = new Gradient();
			this.Internal_GetGradient(nameID, gradient);
			return gradient;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002EE3 File Offset: 0x000010E3
		public void Internal_GetGradient(int nameID, Gradient gradient)
		{
			VisualEffect.Internal_GetGradientDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(gradient));
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005678 File Offset: 0x00003878
		public AnimationCurve GetAnimationCurve(int nameID)
		{
			AnimationCurve animationCurve = new AnimationCurve();
			this.Internal_GetAnimationCurve(nameID, animationCurve);
			return animationCurve;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002EFC File Offset: 0x000010FC
		public void Internal_GetAnimationCurve(int nameID, AnimationCurve curve)
		{
			VisualEffect.Internal_GetAnimationCurveDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(curve));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002F15 File Offset: 0x00001115
		public void GetSpawnSystemInfo(int nameID, IntPtr spawnerState)
		{
			VisualEffect.GetSpawnSystemInfoDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, spawnerState);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002F29 File Offset: 0x00001129
		public bool HasAnySystemAwake()
		{
			return VisualEffect.HasAnySystemAwakeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000569C File Offset: 0x0000389C
		public Bounds GetComputedBounds(int nameID)
		{
			Bounds bounds;
			this.GetComputedBounds_Injected(nameID, out bounds);
			return bounds;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000056B4 File Offset: 0x000038B4
		public Vector3 GetCurrentBoundsPadding(int nameID)
		{
			Vector3 vector;
			this.GetCurrentBoundsPadding_Injected(nameID, out vector);
			return vector;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000056CC File Offset: 0x000038CC
		public void GetSpawnSystemInfo(int nameID, VFXSpawnerState spawnState)
		{
			bool flag = spawnState == null;
			if (flag)
			{
				throw new NullReferenceException("GetSpawnSystemInfo expects a non null VFXSpawnerState.");
			}
			IntPtr ptr = spawnState.GetPtr();
			bool flag2 = ptr == IntPtr.Zero;
			if (flag2)
			{
				throw new NullReferenceException("GetSpawnSystemInfo use an unexpected not owned VFXSpawnerState.");
			}
			this.GetSpawnSystemInfo(nameID, ptr);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005718 File Offset: 0x00003918
		public VFXSpawnerState GetSpawnSystemInfo(int nameID)
		{
			VFXSpawnerState vfxspawnerState = new VFXSpawnerState();
			this.GetSpawnSystemInfo(nameID, vfxspawnerState);
			return vfxspawnerState;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000573C File Offset: 0x0000393C
		public bool HasSystem(int nameID)
		{
			VisualEffectAsset visualEffectAsset = this.visualEffectAsset;
			return visualEffectAsset != null && visualEffectAsset.HasSystem(nameID);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00005768 File Offset: 0x00003968
		public void GetSystemNames(List<string> names)
		{
			bool flag = names == null;
			if (flag)
			{
				throw new ArgumentNullException("names");
			}
			VisualEffectAsset visualEffectAsset = this.visualEffectAsset;
			bool flag2 = visualEffectAsset;
			if (flag2)
			{
				visualEffectAsset.GetSystemNames(names);
			}
			else
			{
				names.Clear();
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000057AC File Offset: 0x000039AC
		public void GetParticleSystemNames(List<string> names)
		{
			bool flag = names == null;
			if (flag)
			{
				throw new ArgumentNullException("names");
			}
			VisualEffectAsset visualEffectAsset = this.visualEffectAsset;
			bool flag2 = visualEffectAsset;
			if (flag2)
			{
				visualEffectAsset.GetParticleSystemNames(names);
			}
			else
			{
				names.Clear();
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x000057F0 File Offset: 0x000039F0
		public void GetOutputEventNames(List<string> names)
		{
			bool flag = names == null;
			if (flag)
			{
				throw new ArgumentNullException("names");
			}
			VisualEffectAsset visualEffectAsset = this.visualEffectAsset;
			bool flag2 = visualEffectAsset;
			if (flag2)
			{
				visualEffectAsset.GetOutputEventNames(names);
			}
			else
			{
				names.Clear();
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005834 File Offset: 0x00003A34
		public void GetSpawnSystemNames(List<string> names)
		{
			bool flag = names == null;
			if (flag)
			{
				throw new ArgumentNullException("names");
			}
			VisualEffectAsset visualEffectAsset = this.visualEffectAsset;
			bool flag2 = visualEffectAsset;
			if (flag2)
			{
				visualEffectAsset.GetSpawnSystemNames(names);
			}
			else
			{
				names.Clear();
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002F3B File Offset: 0x0000113B
		public void ResetOverride(string name)
		{
			this.ResetOverride(Shader.PropertyToID(name));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00005878 File Offset: 0x00003A78
		public bool HasInt(string name)
		{
			return this.HasInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005898 File Offset: 0x00003A98
		public bool HasUInt(string name)
		{
			return this.HasUInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000058B8 File Offset: 0x00003AB8
		public bool HasFloat(string name)
		{
			return this.HasFloat(Shader.PropertyToID(name));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000058D8 File Offset: 0x00003AD8
		public bool HasVector2(string name)
		{
			return this.HasVector2(Shader.PropertyToID(name));
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000058F8 File Offset: 0x00003AF8
		public bool HasVector3(string name)
		{
			return this.HasVector3(Shader.PropertyToID(name));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00005918 File Offset: 0x00003B18
		public bool HasVector4(string name)
		{
			return this.HasVector4(Shader.PropertyToID(name));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005938 File Offset: 0x00003B38
		public bool HasMatrix4x4(string name)
		{
			return this.HasMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005958 File Offset: 0x00003B58
		public bool HasTexture(string name)
		{
			return this.HasTexture(Shader.PropertyToID(name));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005978 File Offset: 0x00003B78
		public TextureDimension GetTextureDimension(string name)
		{
			return this.GetTextureDimension(Shader.PropertyToID(name));
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005998 File Offset: 0x00003B98
		public bool HasAnimationCurve(string name)
		{
			return this.HasAnimationCurve(Shader.PropertyToID(name));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x000059B8 File Offset: 0x00003BB8
		public bool HasGradient(string name)
		{
			return this.HasGradient(Shader.PropertyToID(name));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000059D8 File Offset: 0x00003BD8
		public bool HasMesh(string name)
		{
			return this.HasMesh(Shader.PropertyToID(name));
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000059F8 File Offset: 0x00003BF8
		public bool HasSkinnedMeshRenderer(string name)
		{
			return this.HasSkinnedMeshRenderer(Shader.PropertyToID(name));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00005A18 File Offset: 0x00003C18
		public bool HasGraphicsBuffer(string name)
		{
			return this.HasGraphicsBuffer(Shader.PropertyToID(name));
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00005A38 File Offset: 0x00003C38
		public bool HasBool(string name)
		{
			return this.HasBool(Shader.PropertyToID(name));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002F4B File Offset: 0x0000114B
		public void SetInt(string name, int i)
		{
			this.SetInt(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002F5C File Offset: 0x0000115C
		public void SetUInt(string name, uint i)
		{
			this.SetUInt(Shader.PropertyToID(name), i);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002F6D File Offset: 0x0000116D
		public void SetFloat(string name, float f)
		{
			this.SetFloat(Shader.PropertyToID(name), f);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002F7E File Offset: 0x0000117E
		public void SetVector2(string name, Vector2 v)
		{
			this.SetVector2(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002F8F File Offset: 0x0000118F
		public void SetVector3(string name, Vector3 v)
		{
			this.SetVector3(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00002FA0 File Offset: 0x000011A0
		public void SetVector4(string name, Vector4 v)
		{
			this.SetVector4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002FB1 File Offset: 0x000011B1
		public void SetMatrix4x4(string name, Matrix4x4 v)
		{
			this.SetMatrix4x4(Shader.PropertyToID(name), v);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002FC2 File Offset: 0x000011C2
		public void SetTexture(string name, Texture t)
		{
			this.SetTexture(Shader.PropertyToID(name), t);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00002FD3 File Offset: 0x000011D3
		public void SetAnimationCurve(string name, AnimationCurve c)
		{
			this.SetAnimationCurve(Shader.PropertyToID(name), c);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002FE4 File Offset: 0x000011E4
		public void SetGradient(string name, Gradient g)
		{
			this.SetGradient(Shader.PropertyToID(name), g);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002FF5 File Offset: 0x000011F5
		public void SetMesh(string name, Mesh m)
		{
			this.SetMesh(Shader.PropertyToID(name), m);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00003006 File Offset: 0x00001206
		public void SetSkinnedMeshRenderer(string name, SkinnedMeshRenderer m)
		{
			this.SetSkinnedMeshRenderer(Shader.PropertyToID(name), m);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00003017 File Offset: 0x00001217
		public void SetGraphicsBuffer(string name, GraphicsBuffer g)
		{
			this.SetGraphicsBuffer(Shader.PropertyToID(name), g);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00003028 File Offset: 0x00001228
		public void SetBool(string name, bool b)
		{
			this.SetBool(Shader.PropertyToID(name), b);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00005A58 File Offset: 0x00003C58
		public int GetInt(string name)
		{
			return this.GetInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00005A78 File Offset: 0x00003C78
		public uint GetUInt(string name)
		{
			return this.GetUInt(Shader.PropertyToID(name));
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00005A98 File Offset: 0x00003C98
		public float GetFloat(string name)
		{
			return this.GetFloat(Shader.PropertyToID(name));
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00005AB8 File Offset: 0x00003CB8
		public Vector2 GetVector2(string name)
		{
			return this.GetVector2(Shader.PropertyToID(name));
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public Vector3 GetVector3(string name)
		{
			return this.GetVector3(Shader.PropertyToID(name));
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00005AF8 File Offset: 0x00003CF8
		public Vector4 GetVector4(string name)
		{
			return this.GetVector4(Shader.PropertyToID(name));
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00005B18 File Offset: 0x00003D18
		public Matrix4x4 GetMatrix4x4(string name)
		{
			return this.GetMatrix4x4(Shader.PropertyToID(name));
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00005B38 File Offset: 0x00003D38
		public Texture GetTexture(string name)
		{
			return this.GetTexture(Shader.PropertyToID(name));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00005B58 File Offset: 0x00003D58
		public Mesh GetMesh(string name)
		{
			return this.GetMesh(Shader.PropertyToID(name));
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00005B78 File Offset: 0x00003D78
		public SkinnedMeshRenderer GetSkinnedMeshRenderer(string name)
		{
			return this.GetSkinnedMeshRenderer(Shader.PropertyToID(name));
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00005B98 File Offset: 0x00003D98
		public GraphicsBuffer GetGraphicsBuffer(string name)
		{
			return this.GetGraphicsBuffer(Shader.PropertyToID(name));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00005BB8 File Offset: 0x00003DB8
		public bool GetBool(string name)
		{
			return this.GetBool(Shader.PropertyToID(name));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public AnimationCurve GetAnimationCurve(string name)
		{
			return this.GetAnimationCurve(Shader.PropertyToID(name));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00005BF8 File Offset: 0x00003DF8
		public Gradient GetGradient(string name)
		{
			return this.GetGradient(Shader.PropertyToID(name));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00005C18 File Offset: 0x00003E18
		public bool HasSystem(string name)
		{
			return this.HasSystem(Shader.PropertyToID(name));
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00005C38 File Offset: 0x00003E38
		public VFXSpawnerState GetSpawnSystemInfo(string name)
		{
			return this.GetSpawnSystemInfo(Shader.PropertyToID(name));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00005C58 File Offset: 0x00003E58
		public Bounds GetComputedBounds(string name)
		{
			return this.GetComputedBounds(Shader.PropertyToID(name));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00005C78 File Offset: 0x00003E78
		public Vector3 GetCurrentBoundsPadding(string name)
		{
			return this.GetCurrentBoundsPadding(Shader.PropertyToID(name));
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00003039 File Offset: 0x00001239
		public int aliveParticleCount
		{
			get
			{
				return VisualEffect.get_aliveParticleCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000304B File Offset: 0x0000124B
		public float time
		{
			get
			{
				return VisualEffect.get_timeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000305D File Offset: 0x0000125D
		public void Simulate(float stepDeltaTime, [Optional] uint stepCount)
		{
			VisualEffect.SimulateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), stepDeltaTime, stepCount);
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00003071 File Offset: 0x00001271
		public void SetVector2_Injected(int nameID, ref Vector2 v)
		{
			VisualEffect.SetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00003085 File Offset: 0x00001285
		public void SetVector3_Injected(int nameID, ref Vector3 v)
		{
			VisualEffect.SetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00003099 File Offset: 0x00001299
		public void SetVector4_Injected(int nameID, ref Vector4 v)
		{
			VisualEffect.SetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000030AD File Offset: 0x000012AD
		public void SetMatrix4x4_Injected(int nameID, ref Matrix4x4 v)
		{
			VisualEffect.SetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref v);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000030C1 File Offset: 0x000012C1
		public void GetVector2_Injected(int nameID, out Vector2 ret)
		{
			VisualEffect.GetVector2_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000030D5 File Offset: 0x000012D5
		public void GetVector3_Injected(int nameID, out Vector3 ret)
		{
			VisualEffect.GetVector3_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x000030E9 File Offset: 0x000012E9
		public void GetVector4_Injected(int nameID, out Vector4 ret)
		{
			VisualEffect.GetVector4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x000030FD File Offset: 0x000012FD
		public void GetMatrix4x4_Injected(int nameID, out Matrix4x4 ret)
		{
			VisualEffect.GetMatrix4x4_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003111 File Offset: 0x00001311
		public void GetComputedBounds_Injected(int nameID, out Bounds ret)
		{
			VisualEffect.GetComputedBounds_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00003125 File Offset: 0x00001325
		public void GetCurrentBoundsPadding_Injected(int nameID, out Vector3 ret)
		{
			VisualEffect.GetCurrentBoundsPadding_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, out ret);
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_m_cachedEventAttribute;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_outputEventReceived;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_visualEffectAsset_Public_get_VisualEffectAsset_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CreateVFXEventAttribute_Public_VFXEventAttribute_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_InvokeGetCachedEventAttributeForOutputEvent_Internal_Private_Static_VFXEventAttribute_VisualEffect_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_InvokeOutputEventReceived_Internal_Private_Static_Void_VisualEffect_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly VisualEffect.get_pauseDelegate get_pauseDelegateField;

		// Token: 0x0400009B RID: 155
		private static readonly VisualEffect.set_pauseDelegate set_pauseDelegateField;

		// Token: 0x0400009C RID: 156
		private static readonly VisualEffect.get_playRateDelegate get_playRateDelegateField;

		// Token: 0x0400009D RID: 157
		private static readonly VisualEffect.set_playRateDelegate set_playRateDelegateField;

		// Token: 0x0400009E RID: 158
		private static readonly VisualEffect.get_startSeedDelegate get_startSeedDelegateField;

		// Token: 0x0400009F RID: 159
		private static readonly VisualEffect.set_startSeedDelegate set_startSeedDelegateField;

		// Token: 0x040000A0 RID: 160
		private static readonly VisualEffect.get_resetSeedOnPlayDelegate get_resetSeedOnPlayDelegateField;

		// Token: 0x040000A1 RID: 161
		private static readonly VisualEffect.set_resetSeedOnPlayDelegate set_resetSeedOnPlayDelegateField;

		// Token: 0x040000A2 RID: 162
		private static readonly VisualEffect.get_initialEventIDDelegate get_initialEventIDDelegateField;

		// Token: 0x040000A3 RID: 163
		private static readonly VisualEffect.set_initialEventIDDelegate set_initialEventIDDelegateField;

		// Token: 0x040000A4 RID: 164
		private static readonly VisualEffect.get_initialEventNameDelegate get_initialEventNameDelegateField;

		// Token: 0x040000A5 RID: 165
		private static readonly VisualEffect.set_initialEventNameDelegate set_initialEventNameDelegateField;

		// Token: 0x040000A6 RID: 166
		private static readonly VisualEffect.get_culledDelegate get_culledDelegateField;

		// Token: 0x040000A7 RID: 167
		private static readonly VisualEffect.set_visualEffectAssetDelegate set_visualEffectAssetDelegateField;

		// Token: 0x040000A8 RID: 168
		private static readonly VisualEffect.SendEventFromScriptDelegate SendEventFromScriptDelegateField;

		// Token: 0x040000A9 RID: 169
		private static readonly VisualEffect.ReinitDelegate ReinitDelegateField;

		// Token: 0x040000AA RID: 170
		private static readonly VisualEffect.AdvanceOneFrameDelegate AdvanceOneFrameDelegateField;

		// Token: 0x040000AB RID: 171
		private static readonly VisualEffect.RecreateDataDelegate RecreateDataDelegateField;

		// Token: 0x040000AC RID: 172
		private static readonly VisualEffect.ResetOverrideDelegate ResetOverrideDelegateField;

		// Token: 0x040000AD RID: 173
		private static readonly VisualEffect.GetTextureDimensionDelegate GetTextureDimensionDelegateField;

		// Token: 0x040000AE RID: 174
		private static readonly VisualEffect.HasBoolDelegate HasBoolDelegateField;

		// Token: 0x040000AF RID: 175
		private static readonly VisualEffect.HasIntDelegate HasIntDelegateField;

		// Token: 0x040000B0 RID: 176
		private static readonly VisualEffect.HasUIntDelegate HasUIntDelegateField;

		// Token: 0x040000B1 RID: 177
		private static readonly VisualEffect.HasFloatDelegate HasFloatDelegateField;

		// Token: 0x040000B2 RID: 178
		private static readonly VisualEffect.HasVector2Delegate HasVector2DelegateField;

		// Token: 0x040000B3 RID: 179
		private static readonly VisualEffect.HasVector3Delegate HasVector3DelegateField;

		// Token: 0x040000B4 RID: 180
		private static readonly VisualEffect.HasVector4Delegate HasVector4DelegateField;

		// Token: 0x040000B5 RID: 181
		private static readonly VisualEffect.HasMatrix4x4Delegate HasMatrix4x4DelegateField;

		// Token: 0x040000B6 RID: 182
		private static readonly VisualEffect.HasTextureDelegate HasTextureDelegateField;

		// Token: 0x040000B7 RID: 183
		private static readonly VisualEffect.HasAnimationCurveDelegate HasAnimationCurveDelegateField;

		// Token: 0x040000B8 RID: 184
		private static readonly VisualEffect.HasGradientDelegate HasGradientDelegateField;

		// Token: 0x040000B9 RID: 185
		private static readonly VisualEffect.HasMeshDelegate HasMeshDelegateField;

		// Token: 0x040000BA RID: 186
		private static readonly VisualEffect.HasSkinnedMeshRendererDelegate HasSkinnedMeshRendererDelegateField;

		// Token: 0x040000BB RID: 187
		private static readonly VisualEffect.HasGraphicsBufferDelegate HasGraphicsBufferDelegateField;

		// Token: 0x040000BC RID: 188
		private static readonly VisualEffect.SetBoolDelegate SetBoolDelegateField;

		// Token: 0x040000BD RID: 189
		private static readonly VisualEffect.SetIntDelegate SetIntDelegateField;

		// Token: 0x040000BE RID: 190
		private static readonly VisualEffect.SetUIntDelegate SetUIntDelegateField;

		// Token: 0x040000BF RID: 191
		private static readonly VisualEffect.SetFloatDelegate SetFloatDelegateField;

		// Token: 0x040000C0 RID: 192
		private static readonly VisualEffect.SetTextureDelegate SetTextureDelegateField;

		// Token: 0x040000C1 RID: 193
		private static readonly VisualEffect.SetAnimationCurveDelegate SetAnimationCurveDelegateField;

		// Token: 0x040000C2 RID: 194
		private static readonly VisualEffect.SetGradientDelegate SetGradientDelegateField;

		// Token: 0x040000C3 RID: 195
		private static readonly VisualEffect.SetMeshDelegate SetMeshDelegateField;

		// Token: 0x040000C4 RID: 196
		private static readonly VisualEffect.SetSkinnedMeshRendererDelegate SetSkinnedMeshRendererDelegateField;

		// Token: 0x040000C5 RID: 197
		private static readonly VisualEffect.SetGraphicsBufferDelegate SetGraphicsBufferDelegateField;

		// Token: 0x040000C6 RID: 198
		private static readonly VisualEffect.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x040000C7 RID: 199
		private static readonly VisualEffect.GetIntDelegate GetIntDelegateField;

		// Token: 0x040000C8 RID: 200
		private static readonly VisualEffect.GetUIntDelegate GetUIntDelegateField;

		// Token: 0x040000C9 RID: 201
		private static readonly VisualEffect.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x040000CA RID: 202
		private static readonly VisualEffect.GetTextureDelegate GetTextureDelegateField;

		// Token: 0x040000CB RID: 203
		private static readonly VisualEffect.GetMeshDelegate GetMeshDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly VisualEffect.GetSkinnedMeshRendererDelegate GetSkinnedMeshRendererDelegateField;

		// Token: 0x040000CD RID: 205
		private static readonly VisualEffect.GetGraphicsBufferDelegate GetGraphicsBufferDelegateField;

		// Token: 0x040000CE RID: 206
		private static readonly VisualEffect.Internal_GetGradientDelegate Internal_GetGradientDelegateField;

		// Token: 0x040000CF RID: 207
		private static readonly VisualEffect.Internal_GetAnimationCurveDelegate Internal_GetAnimationCurveDelegateField;

		// Token: 0x040000D0 RID: 208
		private static readonly VisualEffect.GetSpawnSystemInfoDelegate GetSpawnSystemInfoDelegateField;

		// Token: 0x040000D1 RID: 209
		private static readonly VisualEffect.HasAnySystemAwakeDelegate HasAnySystemAwakeDelegateField;

		// Token: 0x040000D2 RID: 210
		private static readonly VisualEffect.get_aliveParticleCountDelegate get_aliveParticleCountDelegateField;

		// Token: 0x040000D3 RID: 211
		private static readonly VisualEffect.get_timeDelegate get_timeDelegateField;

		// Token: 0x040000D4 RID: 212
		private static readonly VisualEffect.SimulateDelegate SimulateDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly VisualEffect.SetVector2_InjectedDelegate SetVector2_InjectedDelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly VisualEffect.SetVector3_InjectedDelegate SetVector3_InjectedDelegateField;

		// Token: 0x040000D7 RID: 215
		private static readonly VisualEffect.SetVector4_InjectedDelegate SetVector4_InjectedDelegateField;

		// Token: 0x040000D8 RID: 216
		private static readonly VisualEffect.SetMatrix4x4_InjectedDelegate SetMatrix4x4_InjectedDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly VisualEffect.GetVector2_InjectedDelegate GetVector2_InjectedDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly VisualEffect.GetVector3_InjectedDelegate GetVector3_InjectedDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly VisualEffect.GetVector4_InjectedDelegate GetVector4_InjectedDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly VisualEffect.GetMatrix4x4_InjectedDelegate GetMatrix4x4_InjectedDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly VisualEffect.GetComputedBounds_InjectedDelegate GetComputedBounds_InjectedDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly VisualEffect.GetCurrentBoundsPadding_InjectedDelegate GetCurrentBoundsPadding_InjectedDelegateField;

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600023F RID: 575
		private delegate bool get_pauseDelegate(IntPtr @this);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x06000241 RID: 577
		private delegate void set_pauseDelegate(IntPtr @this, bool value);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000243 RID: 579
		private delegate float get_playRateDelegate(IntPtr @this);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000245 RID: 581
		private delegate void set_playRateDelegate(IntPtr @this, float value);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000247 RID: 583
		private delegate uint get_startSeedDelegate(IntPtr @this);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000249 RID: 585
		private delegate void set_startSeedDelegate(IntPtr @this, uint value);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600024B RID: 587
		private delegate bool get_resetSeedOnPlayDelegate(IntPtr @this);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600024D RID: 589
		private delegate void set_resetSeedOnPlayDelegate(IntPtr @this, bool value);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600024F RID: 591
		private delegate int get_initialEventIDDelegate(IntPtr @this);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000251 RID: 593
		private delegate void set_initialEventIDDelegate(IntPtr @this, int value);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000253 RID: 595
		private delegate IntPtr get_initialEventNameDelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000255 RID: 597
		private delegate void set_initialEventNameDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000257 RID: 599
		private delegate bool get_culledDelegate(IntPtr @this);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000259 RID: 601
		private delegate void set_visualEffectAssetDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600025B RID: 603
		private delegate void SendEventFromScriptDelegate(IntPtr @this, int eventNameID, IntPtr eventAttribute);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600025D RID: 605
		private delegate void ReinitDelegate(IntPtr @this, bool sendInitialEventAndPrewarm);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600025F RID: 607
		private delegate void AdvanceOneFrameDelegate(IntPtr @this);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x06000261 RID: 609
		private delegate void RecreateDataDelegate(IntPtr @this);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000263 RID: 611
		private delegate void ResetOverrideDelegate(IntPtr @this, int nameID);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000265 RID: 613
		private delegate TextureDimension GetTextureDimensionDelegate(IntPtr @this, int nameID);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000267 RID: 615
		private delegate bool HasBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000269 RID: 617
		private delegate bool HasIntDelegate(IntPtr @this, int nameID);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x0600026B RID: 619
		private delegate bool HasUIntDelegate(IntPtr @this, int nameID);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600026D RID: 621
		private delegate bool HasFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x0600026F RID: 623
		private delegate bool HasVector2Delegate(IntPtr @this, int nameID);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x06000271 RID: 625
		private delegate bool HasVector3Delegate(IntPtr @this, int nameID);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000273 RID: 627
		private delegate bool HasVector4Delegate(IntPtr @this, int nameID);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000275 RID: 629
		private delegate bool HasMatrix4x4Delegate(IntPtr @this, int nameID);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000277 RID: 631
		private delegate bool HasTextureDelegate(IntPtr @this, int nameID);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000279 RID: 633
		private delegate bool HasAnimationCurveDelegate(IntPtr @this, int nameID);

		// Token: 0x02000090 RID: 144
		// (Invoke) Token: 0x0600027B RID: 635
		private delegate bool HasGradientDelegate(IntPtr @this, int nameID);

		// Token: 0x02000091 RID: 145
		// (Invoke) Token: 0x0600027D RID: 637
		private delegate bool HasMeshDelegate(IntPtr @this, int nameID);

		// Token: 0x02000092 RID: 146
		// (Invoke) Token: 0x0600027F RID: 639
		private delegate bool HasSkinnedMeshRendererDelegate(IntPtr @this, int nameID);

		// Token: 0x02000093 RID: 147
		// (Invoke) Token: 0x06000281 RID: 641
		private delegate bool HasGraphicsBufferDelegate(IntPtr @this, int nameID);

		// Token: 0x02000094 RID: 148
		// (Invoke) Token: 0x06000283 RID: 643
		private delegate void SetBoolDelegate(IntPtr @this, int nameID, bool b);

		// Token: 0x02000095 RID: 149
		// (Invoke) Token: 0x06000285 RID: 645
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int i);

		// Token: 0x02000096 RID: 150
		// (Invoke) Token: 0x06000287 RID: 647
		private delegate void SetUIntDelegate(IntPtr @this, int nameID, uint i);

		// Token: 0x02000097 RID: 151
		// (Invoke) Token: 0x06000289 RID: 649
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float f);

		// Token: 0x02000098 RID: 152
		// (Invoke) Token: 0x0600028B RID: 651
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr t);

		// Token: 0x02000099 RID: 153
		// (Invoke) Token: 0x0600028D RID: 653
		private delegate void SetAnimationCurveDelegate(IntPtr @this, int nameID, IntPtr c);

		// Token: 0x0200009A RID: 154
		// (Invoke) Token: 0x0600028F RID: 655
		private delegate void SetGradientDelegate(IntPtr @this, int nameID, IntPtr g);

		// Token: 0x0200009B RID: 155
		// (Invoke) Token: 0x06000291 RID: 657
		private delegate void SetMeshDelegate(IntPtr @this, int nameID, IntPtr m);

		// Token: 0x0200009C RID: 156
		// (Invoke) Token: 0x06000293 RID: 659
		private delegate void SetSkinnedMeshRendererDelegate(IntPtr @this, int nameID, IntPtr m);

		// Token: 0x0200009D RID: 157
		// (Invoke) Token: 0x06000295 RID: 661
		private delegate void SetGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr g);

		// Token: 0x0200009E RID: 158
		// (Invoke) Token: 0x06000297 RID: 663
		private delegate bool GetBoolDelegate(IntPtr @this, int nameID);

		// Token: 0x0200009F RID: 159
		// (Invoke) Token: 0x06000299 RID: 665
		private delegate int GetIntDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A0 RID: 160
		// (Invoke) Token: 0x0600029B RID: 667
		private delegate uint GetUIntDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A1 RID: 161
		// (Invoke) Token: 0x0600029D RID: 669
		private delegate float GetFloatDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A2 RID: 162
		// (Invoke) Token: 0x0600029F RID: 671
		private delegate IntPtr GetTextureDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A3 RID: 163
		// (Invoke) Token: 0x060002A1 RID: 673
		private delegate IntPtr GetMeshDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A4 RID: 164
		// (Invoke) Token: 0x060002A3 RID: 675
		private delegate IntPtr GetSkinnedMeshRendererDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A5 RID: 165
		// (Invoke) Token: 0x060002A5 RID: 677
		private delegate IntPtr GetGraphicsBufferDelegate(IntPtr @this, int nameID);

		// Token: 0x020000A6 RID: 166
		// (Invoke) Token: 0x060002A7 RID: 679
		private delegate void Internal_GetGradientDelegate(IntPtr @this, int nameID, IntPtr gradient);

		// Token: 0x020000A7 RID: 167
		// (Invoke) Token: 0x060002A9 RID: 681
		private delegate void Internal_GetAnimationCurveDelegate(IntPtr @this, int nameID, IntPtr curve);

		// Token: 0x020000A8 RID: 168
		// (Invoke) Token: 0x060002AB RID: 683
		private delegate void GetSpawnSystemInfoDelegate(IntPtr @this, int nameID, IntPtr spawnerState);

		// Token: 0x020000A9 RID: 169
		// (Invoke) Token: 0x060002AD RID: 685
		private delegate bool HasAnySystemAwakeDelegate(IntPtr @this);

		// Token: 0x020000AA RID: 170
		// (Invoke) Token: 0x060002AF RID: 687
		private delegate int get_aliveParticleCountDelegate(IntPtr @this);

		// Token: 0x020000AB RID: 171
		// (Invoke) Token: 0x060002B1 RID: 689
		private delegate float get_timeDelegate(IntPtr @this);

		// Token: 0x020000AC RID: 172
		// (Invoke) Token: 0x060002B3 RID: 691
		private delegate void SimulateDelegate(IntPtr @this, float stepDeltaTime, uint stepCount);

		// Token: 0x020000AD RID: 173
		// (Invoke) Token: 0x060002B5 RID: 693
		private delegate void SetVector2_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x020000AE RID: 174
		// (Invoke) Token: 0x060002B7 RID: 695
		private delegate void SetVector3_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x020000AF RID: 175
		// (Invoke) Token: 0x060002B9 RID: 697
		private delegate void SetVector4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x020000B0 RID: 176
		// (Invoke) Token: 0x060002BB RID: 699
		private delegate void SetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, IntPtr v);

		// Token: 0x020000B1 RID: 177
		// (Invoke) Token: 0x060002BD RID: 701
		private delegate void GetVector2_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000B2 RID: 178
		// (Invoke) Token: 0x060002BF RID: 703
		private delegate void GetVector3_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000B3 RID: 179
		// (Invoke) Token: 0x060002C1 RID: 705
		private delegate void GetVector4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000B4 RID: 180
		// (Invoke) Token: 0x060002C3 RID: 707
		private delegate void GetMatrix4x4_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000B5 RID: 181
		// (Invoke) Token: 0x060002C5 RID: 709
		private delegate void GetComputedBounds_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x060002C7 RID: 711
		private delegate void GetCurrentBoundsPadding_InjectedDelegate(IntPtr @this, int nameID, [Out] IntPtr ret);
	}
}
