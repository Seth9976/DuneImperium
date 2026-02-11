using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Audio;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class AudioSource : AudioBehaviour
	{
		// Token: 0x0600005B RID: 91 RVA: 0x000041CC File Offset: 0x000023CC
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSource()
		{
			Il2CppClassPointerStore<AudioSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AudioModule.dll", "UnityEngine", "AudioSource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSource>.NativeClassPtr);
			AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663326);
			AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663327);
			AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663328);
			AudioSource.NativeMethodInfoPtr_Play_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663329);
			AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663330);
			AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663331);
			AudioSource.NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663332);
			AudioSource.NativeMethodInfoPtr_GetCustomCurveHelper_Private_Static_AnimationCurve_AudioSource_AudioSourceCurveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663333);
			AudioSource.NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663334);
			AudioSource.NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663335);
			AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663336);
			AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663337);
			AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663338);
			AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663339);
			AudioSource.NativeMethodInfoPtr_get_time_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663340);
			AudioSource.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663341);
			AudioSource.NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663342);
			AudioSource.NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663343);
			AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663344);
			AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663345);
			AudioSource.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663346);
			AudioSource.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663347);
			AudioSource.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663348);
			AudioSource.NativeMethodInfoPtr_Play_Public_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663349);
			AudioSource.NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663350);
			AudioSource.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663351);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663352);
			AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663353);
			AudioSource.NativeMethodInfoPtr_SetScheduledStartTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663354);
			AudioSource.NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663355);
			AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663356);
			AudioSource.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663357);
			AudioSource.NativeMethodInfoPtr_UnPause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663358);
			AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663359);
			AudioSource.NativeMethodInfoPtr_get_isVirtual_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663360);
			AudioSource.NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663361);
			AudioSource.NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663362);
			AudioSource.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663363);
			AudioSource.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663364);
			AudioSource.NativeMethodInfoPtr_get_ignoreListenerVolume_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663365);
			AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663366);
			AudioSource.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663367);
			AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663368);
			AudioSource.NativeMethodInfoPtr_get_ignoreListenerPause_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663369);
			AudioSource.NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663370);
			AudioSource.NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663371);
			AudioSource.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663372);
			AudioSource.NativeMethodInfoPtr_get_panStereo_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663373);
			AudioSource.NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663374);
			AudioSource.NativeMethodInfoPtr_get_spatialBlend_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663375);
			AudioSource.NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663376);
			AudioSource.NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663377);
			AudioSource.NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663378);
			AudioSource.NativeMethodInfoPtr_get_spatializePostEffects_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663379);
			AudioSource.NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663380);
			AudioSource.NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663381);
			AudioSource.NativeMethodInfoPtr_GetCustomCurve_Public_AnimationCurve_AudioSourceCurveType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663382);
			AudioSource.NativeMethodInfoPtr_get_reverbZoneMix_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663383);
			AudioSource.NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663384);
			AudioSource.NativeMethodInfoPtr_get_bypassEffects_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663385);
			AudioSource.NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663386);
			AudioSource.NativeMethodInfoPtr_get_bypassListenerEffects_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663387);
			AudioSource.NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663388);
			AudioSource.NativeMethodInfoPtr_get_bypassReverbZones_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663389);
			AudioSource.NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663390);
			AudioSource.NativeMethodInfoPtr_get_dopplerLevel_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663391);
			AudioSource.NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663392);
			AudioSource.NativeMethodInfoPtr_get_spread_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663393);
			AudioSource.NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663394);
			AudioSource.NativeMethodInfoPtr_get_priority_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663395);
			AudioSource.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663396);
			AudioSource.NativeMethodInfoPtr_get_mute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663397);
			AudioSource.NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663398);
			AudioSource.NativeMethodInfoPtr_get_minDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663399);
			AudioSource.NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663400);
			AudioSource.NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663401);
			AudioSource.NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663402);
			AudioSource.NativeMethodInfoPtr_get_rolloffMode_Public_get_AudioRolloffMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663403);
			AudioSource.NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663404);
			AudioSource.NativeMethodInfoPtr_GetOutputData_Public_Il2CppStructArray_1_Single_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663405);
			AudioSource.NativeMethodInfoPtr_GetOutputData_Public_Void_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663406);
			AudioSource.NativeMethodInfoPtr_GetSpectrumData_Public_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663407);
			AudioSource.NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663408);
			AudioSource.NativeMethodInfoPtr_get_minVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663409);
			AudioSource.NativeMethodInfoPtr_set_minVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663410);
			AudioSource.NativeMethodInfoPtr_get_maxVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663411);
			AudioSource.NativeMethodInfoPtr_set_maxVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663412);
			AudioSource.NativeMethodInfoPtr_get_rolloffFactor_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663413);
			AudioSource.NativeMethodInfoPtr_set_rolloffFactor_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663414);
			AudioSource.NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663415);
			AudioSource.NativeMethodInfoPtr_GetSpatializerFloat_Public_Boolean_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663416);
			AudioSource.NativeMethodInfoPtr_GetAmbisonicDecoderFloat_Public_Boolean_Int32_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663417);
			AudioSource.NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663418);
			AudioSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSource>.NativeClassPtr, 100663419);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004954 File Offset: 0x00002B54
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1258959, RefRangeEnd = 1258962, XrefRangeStart = 1258957, XrefRangeEnd = 1258959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPitch(AudioSource source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004998 File Offset: 0x00002B98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1258964, RefRangeEnd = 1258968, XrefRangeStart = 1258962, XrefRangeEnd = 1258964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetPitch(AudioSource source, float pitch)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000049DC File Offset: 0x00002BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258968, XrefRangeEnd = 1258970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayHelper(AudioSource source, ulong delay)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004A20 File Offset: 0x00002C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258970, XrefRangeEnd = 1258972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(double delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004A60 File Offset: 0x00002C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258972, XrefRangeEnd = 1258974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(clip);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258974, XrefRangeEnd = 1258976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop(bool stopOneShots)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stopOneShots;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004AF8 File Offset: 0x00002CF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258976, XrefRangeEnd = 1258978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004B50 File Offset: 0x00002D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258978, XrefRangeEnd = 1258980, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AnimationCurve GetCustomCurveHelper(AudioSource source, AudioSourceCurveType type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetCustomCurveHelper_Private_Static_AnimationCurve_AudioSource_AudioSourceCurveType_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004BA4 File Offset: 0x00002DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258980, XrefRangeEnd = 1258982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetOutputDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*samples = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004C0C File Offset: 0x00002E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258982, XrefRangeEnd = 1258984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetSpectrumDataHelper(AudioSource source, [Out] Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*samples = ((intPtr4 == 0) ? null : new Il2CppStructArray<float>(intPtr4));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00004C80 File Offset: 0x00002E80
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00004CBC File Offset: 0x00002EBC
		public unsafe float volume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1258986, RefRangeEnd = 1258987, XrefRangeStart = 1258984, XrefRangeEnd = 1258986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1259061, RefRangeEnd = 1259066, XrefRangeStart = 1258987, XrefRangeEnd = 1259061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004CFC File Offset: 0x00002EFC
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004D38 File Offset: 0x00002F38
		public unsafe float pitch
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1258959, RefRangeEnd = 1258962, XrefRangeStart = 1258959, XrefRangeEnd = 1258962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1258964, RefRangeEnd = 1258968, XrefRangeStart = 1258964, XrefRangeEnd = 1258968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004D78 File Offset: 0x00002F78
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00004DB4 File Offset: 0x00002FB4
		public unsafe float time
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1259068, RefRangeEnd = 1259072, XrefRangeStart = 1259066, XrefRangeEnd = 1259068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_time_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1259074, RefRangeEnd = 1259076, XrefRangeStart = 1259072, XrefRangeEnd = 1259074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_time_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00004DF4 File Offset: 0x00002FF4
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00004E30 File Offset: 0x00003030
		public unsafe int timeSamples
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259076, XrefRangeEnd = 1259078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259078, XrefRangeEnd = 1259080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004E70 File Offset: 0x00003070
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00004EB0 File Offset: 0x000030B0
		public unsafe AudioClip clip
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1259082, RefRangeEnd = 1259088, XrefRangeStart = 1259080, XrefRangeEnd = 1259082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1259090, RefRangeEnd = 1259093, XrefRangeStart = 1259088, XrefRangeEnd = 1259090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00004EF4 File Offset: 0x000030F4
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00004F34 File Offset: 0x00003134
		public unsafe AudioMixerGroup outputAudioMixerGroup
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259095, RefRangeEnd = 1259096, XrefRangeStart = 1259093, XrefRangeEnd = 1259095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioMixerGroup>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259098, RefRangeEnd = 1259099, XrefRangeStart = 1259096, XrefRangeEnd = 1259098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00004F78 File Offset: 0x00003178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259101, RefRangeEnd = 1259103, XrefRangeStart = 1259099, XrefRangeEnd = 1259101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00004FAC File Offset: 0x000031AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(ulong delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Play_Public_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004FEC File Offset: 0x000031EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259106, RefRangeEnd = 1259108, XrefRangeStart = 1259103, XrefRangeEnd = 1259106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayDelayed(float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000502C File Offset: 0x0000322C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1259111, RefRangeEnd = 1259114, XrefRangeStart = 1259108, XrefRangeEnd = 1259111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayScheduled(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000506C File Offset: 0x0000326C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259114, XrefRangeEnd = 1259126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000050B0 File Offset: 0x000032B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259138, RefRangeEnd = 1259139, XrefRangeStart = 1259126, XrefRangeEnd = 1259138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayOneShot(AudioClip clip, float volumeScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volumeScale;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005100 File Offset: 0x00003300
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1259141, RefRangeEnd = 1259145, XrefRangeStart = 1259139, XrefRangeEnd = 1259141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScheduledStartTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetScheduledStartTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00005140 File Offset: 0x00003340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259145, XrefRangeEnd = 1259147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetScheduledEndTime(double time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref time;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005180 File Offset: 0x00003380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1259149, RefRangeEnd = 1259151, XrefRangeStart = 1259147, XrefRangeEnd = 1259149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000051B4 File Offset: 0x000033B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1259153, RefRangeEnd = 1259157, XrefRangeStart = 1259151, XrefRangeEnd = 1259153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000051E8 File Offset: 0x000033E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259157, XrefRangeEnd = 1259159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnPause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_UnPause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000521C File Offset: 0x0000341C
		public unsafe bool isPlaying
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 1259161, RefRangeEnd = 1259173, XrefRangeStart = 1259159, XrefRangeEnd = 1259161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600007E RID: 126 RVA: 0x00005258 File Offset: 0x00003458
		public unsafe bool isVirtual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259173, XrefRangeEnd = 1259175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_isVirtual_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005294 File Offset: 0x00003494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259175, XrefRangeEnd = 1259176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayClipAtPoint(AudioClip clip, Vector3 position)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000052D8 File Offset: 0x000034D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1259211, RefRangeEnd = 1259212, XrefRangeStart = 1259176, XrefRangeEnd = 1259211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clip);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000081 RID: 129 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00005368 File Offset: 0x00003568
		public unsafe bool loop
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259214, RefRangeEnd = 1259215, XrefRangeStart = 1259212, XrefRangeEnd = 1259214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_loop_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1259217, RefRangeEnd = 1259220, XrefRangeStart = 1259215, XrefRangeEnd = 1259217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000053A8 File Offset: 0x000035A8
		// (set) Token: 0x06000084 RID: 132 RVA: 0x000053E4 File Offset: 0x000035E4
		public unsafe bool ignoreListenerVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259222, RefRangeEnd = 1259223, XrefRangeStart = 1259220, XrefRangeEnd = 1259222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_ignoreListenerVolume_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259225, RefRangeEnd = 1259226, XrefRangeStart = 1259223, XrefRangeEnd = 1259225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00005424 File Offset: 0x00003624
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00005460 File Offset: 0x00003660
		public unsafe bool playOnAwake
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259226, XrefRangeEnd = 1259228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1259230, RefRangeEnd = 1259236, XrefRangeStart = 1259228, XrefRangeEnd = 1259230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000054A0 File Offset: 0x000036A0
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000054DC File Offset: 0x000036DC
		public unsafe bool ignoreListenerPause
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259238, RefRangeEnd = 1259239, XrefRangeStart = 1259236, XrefRangeEnd = 1259238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_ignoreListenerPause_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259241, RefRangeEnd = 1259242, XrefRangeStart = 1259239, XrefRangeEnd = 1259241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000089 RID: 137 RVA: 0x0000551C File Offset: 0x0000371C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00005558 File Offset: 0x00003758
		public unsafe AudioVelocityUpdateMode velocityUpdateMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259244, RefRangeEnd = 1259245, XrefRangeStart = 1259242, XrefRangeEnd = 1259244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259247, RefRangeEnd = 1259248, XrefRangeStart = 1259245, XrefRangeEnd = 1259247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005598 File Offset: 0x00003798
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000055D4 File Offset: 0x000037D4
		public unsafe float panStereo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259250, RefRangeEnd = 1259251, XrefRangeStart = 1259248, XrefRangeEnd = 1259250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_panStereo_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1259253, RefRangeEnd = 1259255, XrefRangeStart = 1259251, XrefRangeEnd = 1259253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005614 File Offset: 0x00003814
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00005650 File Offset: 0x00003850
		public unsafe float spatialBlend
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259257, RefRangeEnd = 1259258, XrefRangeStart = 1259255, XrefRangeEnd = 1259257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_spatialBlend_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1259260, RefRangeEnd = 1259262, XrefRangeStart = 1259258, XrefRangeEnd = 1259260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005690 File Offset: 0x00003890
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000056CC File Offset: 0x000038CC
		public unsafe bool spatialize
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259262, XrefRangeEnd = 1259264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259264, XrefRangeEnd = 1259266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000570C File Offset: 0x0000390C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00005748 File Offset: 0x00003948
		public unsafe bool spatializePostEffects
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259266, XrefRangeEnd = 1259268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_spatializePostEffects_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259268, XrefRangeEnd = 1259270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00005788 File Offset: 0x00003988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(curve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000057D8 File Offset: 0x000039D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationCurve GetCustomCurve(AudioSourceCurveType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetCustomCurve_Public_AnimationCurve_AudioSourceCurveType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr3) : null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00005824 File Offset: 0x00003A24
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00005860 File Offset: 0x00003A60
		public unsafe float reverbZoneMix
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259270, XrefRangeEnd = 1259272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_reverbZoneMix_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259272, XrefRangeEnd = 1259274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000058A0 File Offset: 0x00003AA0
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000058DC File Offset: 0x00003ADC
		public unsafe bool bypassEffects
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259276, RefRangeEnd = 1259277, XrefRangeStart = 1259274, XrefRangeEnd = 1259276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_bypassEffects_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259279, RefRangeEnd = 1259280, XrefRangeStart = 1259277, XrefRangeEnd = 1259279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000099 RID: 153 RVA: 0x0000591C File Offset: 0x00003B1C
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00005958 File Offset: 0x00003B58
		public unsafe bool bypassListenerEffects
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259280, XrefRangeEnd = 1259282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_bypassListenerEffects_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259282, XrefRangeEnd = 1259284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00005998 File Offset: 0x00003B98
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000059D4 File Offset: 0x00003BD4
		public unsafe bool bypassReverbZones
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259284, XrefRangeEnd = 1259286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_bypassReverbZones_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259286, XrefRangeEnd = 1259288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00005A14 File Offset: 0x00003C14
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00005A50 File Offset: 0x00003C50
		public unsafe float dopplerLevel
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259290, RefRangeEnd = 1259291, XrefRangeStart = 1259288, XrefRangeEnd = 1259290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_dopplerLevel_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259293, RefRangeEnd = 1259294, XrefRangeStart = 1259291, XrefRangeEnd = 1259293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00005A90 File Offset: 0x00003C90
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00005ACC File Offset: 0x00003CCC
		public unsafe float spread
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259296, RefRangeEnd = 1259297, XrefRangeStart = 1259294, XrefRangeEnd = 1259296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_spread_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259299, RefRangeEnd = 1259300, XrefRangeStart = 1259297, XrefRangeEnd = 1259299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00005B0C File Offset: 0x00003D0C
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00005B48 File Offset: 0x00003D48
		public unsafe int priority
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259302, RefRangeEnd = 1259303, XrefRangeStart = 1259300, XrefRangeEnd = 1259302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_priority_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259305, RefRangeEnd = 1259306, XrefRangeStart = 1259303, XrefRangeEnd = 1259305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00005B88 File Offset: 0x00003D88
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00005BC4 File Offset: 0x00003DC4
		public unsafe bool mute
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259306, XrefRangeEnd = 1259308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_mute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259308, XrefRangeEnd = 1259310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00005C04 File Offset: 0x00003E04
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe float minDistance
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1259312, RefRangeEnd = 1259314, XrefRangeStart = 1259310, XrefRangeEnd = 1259312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_minDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1259316, RefRangeEnd = 1259323, XrefRangeStart = 1259314, XrefRangeEnd = 1259316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00005C80 File Offset: 0x00003E80
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x00005CBC File Offset: 0x00003EBC
		public unsafe float maxDistance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1259325, RefRangeEnd = 1259328, XrefRangeStart = 1259323, XrefRangeEnd = 1259325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 1259330, RefRangeEnd = 1259337, XrefRangeStart = 1259328, XrefRangeEnd = 1259330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00005CFC File Offset: 0x00003EFC
		// (set) Token: 0x060000AA RID: 170 RVA: 0x00005D38 File Offset: 0x00003F38
		public unsafe AudioRolloffMode rolloffMode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259339, RefRangeEnd = 1259340, XrefRangeStart = 1259337, XrefRangeEnd = 1259339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_rolloffMode_Public_get_AudioRolloffMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1259342, RefRangeEnd = 1259343, XrefRangeStart = 1259340, XrefRangeEnd = 1259342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005D78 File Offset: 0x00003F78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259343, XrefRangeEnd = 1259348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetOutputData(int numSamples, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numSamples;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetOutputData_Public_Il2CppStructArray_1_Single_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetOutputData(Il2CppStructArray<float> samples, int channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(samples);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetOutputData_Public_Void_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005E24 File Offset: 0x00004024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259348, XrefRangeEnd = 1259353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<float> GetSpectrumData(int numSamples, int channel, FFTWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref numSamples;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetSpectrumData_Public_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005E8C File Offset: 0x0000408C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetSpectrumData(Il2CppStructArray<float> samples, int channel, FFTWindow window)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(samples);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref channel;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref window;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00005EEC File Offset: 0x000040EC
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00005F28 File Offset: 0x00004128
		public unsafe float minVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259353, XrefRangeEnd = 1259359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_minVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259359, XrefRangeEnd = 1259365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_minVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00005F68 File Offset: 0x00004168
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00005FA4 File Offset: 0x000041A4
		public unsafe float maxVolume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259365, XrefRangeEnd = 1259371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_maxVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259371, XrefRangeEnd = 1259377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_maxVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00005FE4 File Offset: 0x000041E4
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00006020 File Offset: 0x00004220
		public unsafe float rolloffFactor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259377, XrefRangeEnd = 1259383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_get_rolloffFactor_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259383, XrefRangeEnd = 1259389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_set_rolloffFactor_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006060 File Offset: 0x00004260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259389, XrefRangeEnd = 1259391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetSpatializerFloat(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000060B8 File Offset: 0x000042B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259391, XrefRangeEnd = 1259393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetSpatializerFloat(int index, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetSpatializerFloat_Public_Boolean_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006110 File Offset: 0x00004310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259393, XrefRangeEnd = 1259395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetAmbisonicDecoderFloat(int index, out float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_GetAmbisonicDecoderFloat_Public_Boolean_Int32_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00006168 File Offset: 0x00004368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259395, XrefRangeEnd = 1259397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool SetAmbisonicDecoderFloat(int index, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000061C0 File Offset: 0x000043C0
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSource()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002335 File Offset: 0x00000535
		public AudioSource(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetPitch_Private_Static_Single_AudioSource_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_SetPitch_Private_Static_Void_AudioSource_Single_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_PlayHelper_Private_Static_Void_AudioSource_UInt64_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_Play_Private_Void_Double_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShotHelper_Private_Static_Void_AudioSource_AudioClip_Single_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Private_Void_Boolean_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomCurveHelper_Private_Static_Void_AudioSource_AudioSourceCurveType_AnimationCurve_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomCurveHelper_Private_Static_AnimationCurve_AudioSource_AudioSourceCurveType_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumDataHelper_Private_Static_Void_AudioSource_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_get_Single_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_time_Public_get_Single_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_set_time_Public_set_Void_Single_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSamples_Public_get_Int32_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSamples_Public_set_Void_Int32_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_clip_Public_get_AudioClip_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_set_clip_Public_set_Void_AudioClip_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_outputAudioMixerGroup_Public_get_AudioMixerGroup_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_set_outputAudioMixerGroup_Public_set_Void_AudioMixerGroup_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_UInt64_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_PlayDelayed_Public_Void_Single_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_PlayOneShot_Public_Void_AudioClip_Single_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_SetScheduledStartTime_Public_Void_Double_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_SetScheduledEndTime_Public_Void_Double_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_UnPause_Public_Void_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_get_isPlaying_Public_get_Boolean_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_get_isVirtual_Public_get_Boolean_0;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_0;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_PlayClipAtPoint_Public_Static_Void_AudioClip_Vector3_Single_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_get_loop_Public_get_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_set_loop_Public_set_Void_Boolean_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreListenerVolume_Public_get_Boolean_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreListenerVolume_Public_set_Void_Boolean_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_get_playOnAwake_Public_get_Boolean_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_set_playOnAwake_Public_set_Void_Boolean_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_get_ignoreListenerPause_Public_get_Boolean_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_set_ignoreListenerPause_Public_set_Void_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_get_velocityUpdateMode_Public_get_AudioVelocityUpdateMode_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_set_velocityUpdateMode_Public_set_Void_AudioVelocityUpdateMode_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_get_panStereo_Public_get_Single_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_set_panStereo_Public_set_Void_Single_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_get_spatialBlend_Public_get_Single_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_set_spatialBlend_Public_set_Void_Single_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_get_spatialize_Public_get_Boolean_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_set_spatialize_Public_set_Void_Boolean_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_get_spatializePostEffects_Public_get_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_set_spatializePostEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_SetCustomCurve_Public_Void_AudioSourceCurveType_AnimationCurve_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomCurve_Public_AnimationCurve_AudioSourceCurveType_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_get_reverbZoneMix_Public_get_Single_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_set_reverbZoneMix_Public_set_Void_Single_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_get_bypassEffects_Public_get_Boolean_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_get_bypassListenerEffects_Public_get_Boolean_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassListenerEffects_Public_set_Void_Boolean_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_get_bypassReverbZones_Public_get_Boolean_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_set_bypassReverbZones_Public_set_Void_Boolean_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_get_dopplerLevel_Public_get_Single_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_set_dopplerLevel_Public_set_Void_Single_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_get_spread_Public_get_Single_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_set_spread_Public_set_Void_Single_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_priority_Public_get_Int32_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_set_priority_Public_set_Void_Int32_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_get_mute_Public_get_Boolean_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_set_mute_Public_set_Void_Boolean_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_get_minDistance_Public_get_Single_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_set_minDistance_Public_set_Void_Single_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_maxDistance_Public_get_Single_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_set_maxDistance_Public_set_Void_Single_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_get_rolloffMode_Public_get_AudioRolloffMode_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_set_rolloffMode_Public_set_Void_AudioRolloffMode_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputData_Public_Il2CppStructArray_1_Single_Int32_Int32_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_GetOutputData_Public_Void_Il2CppStructArray_1_Single_Int32_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Il2CppStructArray_1_Single_Int32_Int32_FFTWindow_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_GetSpectrumData_Public_Void_Il2CppStructArray_1_Single_Int32_FFTWindow_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_get_minVolume_Public_get_Single_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_set_minVolume_Public_set_Void_Single_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_get_maxVolume_Public_get_Single_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_set_maxVolume_Public_set_Void_Single_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_get_rolloffFactor_Public_get_Single_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_set_rolloffFactor_Public_set_Void_Single_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_SetSpatializerFloat_Public_Boolean_Int32_Single_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_GetSpatializerFloat_Public_Boolean_Int32_byref_Single_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_GetAmbisonicDecoderFloat_Public_Boolean_Int32_byref_Single_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_SetAmbisonicDecoderFloat_Public_Boolean_Int32_Single_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
