using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;
using UnityEngine;

// Token: 0x0200000D RID: 13
public class AudioObject : RegisteredComponent
{
	// Token: 0x06000186 RID: 390 RVA: 0x00018DA8 File Offset: 0x00016FA8
	// Note: this type is marked as 'beforefieldinit'.
	static AudioObject()
	{
		Il2CppClassPointerStore<AudioObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioObject");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioObject>.NativeClassPtr);
		AudioObject.NativeFieldInfoPtr__audioID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "<audioID>k__BackingField");
		AudioObject.NativeFieldInfoPtr__category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_category");
		AudioObject.NativeFieldInfoPtr__isPlayedAsMusic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "<isPlayedAsMusic>k__BackingField");
		AudioObject.NativeFieldInfoPtr__subItemPrimary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_subItemPrimary");
		AudioObject.NativeFieldInfoPtr__subItemSecondary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_subItemSecondary");
		AudioObject.NativeFieldInfoPtr__completelyPlayedDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_completelyPlayedDelegate");
		AudioObject.NativeFieldInfoPtr__pauseCoroutineCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_pauseCoroutineCounter");
		AudioObject.NativeFieldInfoPtr__volumeExcludingCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_volumeExcludingCategory");
		AudioObject.NativeFieldInfoPtr__volumeFromPrimaryFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_volumeFromPrimaryFade");
		AudioObject.NativeFieldInfoPtr__volumeFromSecondaryFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_volumeFromSecondaryFade");
		AudioObject.NativeFieldInfoPtr__volumeFromScriptCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_volumeFromScriptCall");
		AudioObject.NativeFieldInfoPtr__paused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_paused");
		AudioObject.NativeFieldInfoPtr__applicationPaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_applicationPaused");
		AudioObject.NativeFieldInfoPtr__primaryFader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_primaryFader");
		AudioObject.NativeFieldInfoPtr__secondaryFader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_secondaryFader");
		AudioObject.NativeFieldInfoPtr__playTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_playTime");
		AudioObject.NativeFieldInfoPtr__playStartTimeLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_playStartTimeLocal");
		AudioObject.NativeFieldInfoPtr__playStartTimeSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_playStartTimeSystem");
		AudioObject.NativeFieldInfoPtr__playScheduledTimeDsp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_playScheduledTimeDsp");
		AudioObject.NativeFieldInfoPtr__audioObjectTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioObjectTime");
		AudioObject.NativeFieldInfoPtr__IsInactive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_IsInactive");
		AudioObject.NativeFieldInfoPtr__stopRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_stopRequested");
		AudioObject.NativeFieldInfoPtr__finishSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_finishSequence");
		AudioObject.NativeFieldInfoPtr__loopSequenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_loopSequenceCount");
		AudioObject.NativeFieldInfoPtr__stopAfterFadeoutUserSetting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_stopAfterFadeoutUserSetting");
		AudioObject.NativeFieldInfoPtr__pauseWithFadeOutRequested = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_pauseWithFadeOutRequested");
		AudioObject.NativeFieldInfoPtr__dspTimeRemainingAtPause = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_dspTimeRemainingAtPause");
		AudioObject.NativeFieldInfoPtr__audioController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioController");
		AudioObject.NativeFieldInfoPtr__isCurrentPlaylistTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_isCurrentPlaylistTrack");
		AudioObject.NativeFieldInfoPtr__audioSource_MinDistance_Saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioSource_MinDistance_Saved");
		AudioObject.NativeFieldInfoPtr__audioSource_MaxDistance_Saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioSource_MaxDistance_Saved");
		AudioObject.NativeFieldInfoPtr__audioSource_SpatialBlend_Saved = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioSource_SpatialBlend_Saved");
		AudioObject.NativeFieldInfoPtr__lastChosenSubItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_lastChosenSubItemIndex");
		AudioObject.NativeFieldInfoPtr__audioSource1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioSource1");
		AudioObject.NativeFieldInfoPtr__audioSource2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_audioSource2");
		AudioObject.NativeFieldInfoPtr__primaryAudioSourcePaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_primaryAudioSourcePaused");
		AudioObject.NativeFieldInfoPtr__secondaryAudioSourcePaused = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "_secondaryAudioSourcePaused");
		AudioObject.NativeFieldInfoPtr_VOLUME_TRANSFORM_POWER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "VOLUME_TRANSFORM_POWER");
		AudioObject.NativeMethodInfoPtr_get_audioID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663477);
		AudioObject.NativeMethodInfoPtr_set_audioID_Internal_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663478);
		AudioObject.NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663479);
		AudioObject.NativeMethodInfoPtr_set_category_Internal_set_Void_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663480);
		AudioObject.NativeMethodInfoPtr_get_subItem_Public_get_AudioSubItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663481);
		AudioObject.NativeMethodInfoPtr_set_subItem_Internal_set_Void_AudioSubItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663482);
		AudioObject.NativeMethodInfoPtr_get_isPlayedAsMusic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663483);
		AudioObject.NativeMethodInfoPtr_set_isPlayedAsMusic_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663484);
		AudioObject.NativeMethodInfoPtr_get_audioItem_Public_get_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663485);
		AudioObject.NativeMethodInfoPtr_set_completelyPlayedDelegate_Public_set_Void_AudioEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663486);
		AudioObject.NativeMethodInfoPtr_get_completelyPlayedDelegate_Public_get_AudioEventDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663487);
		AudioObject.NativeMethodInfoPtr_get_volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663488);
		AudioObject.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663489);
		AudioObject.NativeMethodInfoPtr_get_volumeItem_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663490);
		AudioObject.NativeMethodInfoPtr_set_volumeItem_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663491);
		AudioObject.NativeMethodInfoPtr_get_volumeTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663492);
		AudioObject.NativeMethodInfoPtr_get_volumeTotalWithoutFade_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663493);
		AudioObject.NativeMethodInfoPtr_get_playCalledAtTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663494);
		AudioObject.NativeMethodInfoPtr_get_startedPlayingAtTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663495);
		AudioObject.NativeMethodInfoPtr_get_timeUntilEnd_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663496);
		AudioObject.NativeMethodInfoPtr_get_scheduledPlayingAtDspTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663497);
		AudioObject.NativeMethodInfoPtr_set_scheduledPlayingAtDspTime_Public_set_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663498);
		AudioObject.NativeMethodInfoPtr_get_clipLength_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663499);
		AudioObject.NativeMethodInfoPtr_get_audioTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663500);
		AudioObject.NativeMethodInfoPtr_set_audioTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663501);
		AudioObject.NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663502);
		AudioObject.NativeMethodInfoPtr_get_isFadeOutComplete_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663503);
		AudioObject.NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663504);
		AudioObject.NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663505);
		AudioObject.NativeMethodInfoPtr_get_pitch_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663506);
		AudioObject.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663507);
		AudioObject.NativeMethodInfoPtr_get_pan_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663508);
		AudioObject.NativeMethodInfoPtr_set_pan_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663509);
		AudioObject.NativeMethodInfoPtr_get_audioObjectTime_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663510);
		AudioObject.NativeMethodInfoPtr_get_stopAfterFadeOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663511);
		AudioObject.NativeMethodInfoPtr_set_stopAfterFadeOut_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663512);
		AudioObject.NativeMethodInfoPtr_FadeIn_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663513);
		AudioObject.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663514);
		AudioObject.NativeMethodInfoPtr_PlayAfter_Public_Void_String_Double_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663515);
		AudioObject.NativeMethodInfoPtr_PlayNow_Public_Void_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663516);
		AudioObject.NativeMethodInfoPtr_Play_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663517);
		AudioObject.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663518);
		AudioObject.NativeMethodInfoPtr_Stop_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663519);
		AudioObject.NativeMethodInfoPtr_Stop_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663520);
		AudioObject.NativeMethodInfoPtr_FinishSequence_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663521);
		AudioObject.NativeMethodInfoPtr__WaitForSecondsThenStop_Private_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663522);
		AudioObject.NativeMethodInfoPtr_FadeOut_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663523);
		AudioObject.NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663524);
		AudioObject.NativeMethodInfoPtr_Pause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663525);
		AudioObject.NativeMethodInfoPtr_Pause_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663526);
		AudioObject.NativeMethodInfoPtr__PauseNow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663527);
		AudioObject.NativeMethodInfoPtr_Unpause_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663528);
		AudioObject.NativeMethodInfoPtr_Unpause_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663529);
		AudioObject.NativeMethodInfoPtr__UnpauseNow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663530);
		AudioObject.NativeMethodInfoPtr__WaitThenPause_Private_IEnumerator_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663531);
		AudioObject.NativeMethodInfoPtr__PauseAudioSources_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663532);
		AudioObject.NativeMethodInfoPtr_IsPaused_Public_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663533);
		AudioObject.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663534);
		AudioObject.NativeMethodInfoPtr_IsPrimaryPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663535);
		AudioObject.NativeMethodInfoPtr_IsSecondaryPlaying_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663536);
		AudioObject.NativeMethodInfoPtr_get_primaryAudioSource_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663537);
		AudioObject.NativeMethodInfoPtr_get_secondaryAudioSource_Public_get_AudioSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663538);
		AudioObject.NativeMethodInfoPtr_SwitchAudioSources_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663539);
		AudioObject.NativeMethodInfoPtr__SwitchValues_Private_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663540);
		AudioObject.NativeMethodInfoPtr_get__volumeFromCategory_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663541);
		AudioObject.NativeMethodInfoPtr_get__volumeWithCategory_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663542);
		AudioObject.NativeMethodInfoPtr_get__stopClipAtTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663543);
		AudioObject.NativeMethodInfoPtr_get__startClipAtTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663544);
		AudioObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663545);
		AudioObject.NativeMethodInfoPtr__CreateSecondAudioSource_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663546);
		AudioObject.NativeMethodInfoPtr__Set0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663547);
		AudioObject.NativeMethodInfoPtr__SetReferences0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663548);
		AudioObject.NativeMethodInfoPtr__PlayScheduled_Private_Void_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663549);
		AudioObject.NativeMethodInfoPtr__PlayDelayed_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663550);
		AudioObject.NativeMethodInfoPtr__OnPlay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663551);
		AudioObject.NativeMethodInfoPtr__Stop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663552);
		AudioObject.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663553);
		AudioObject.NativeMethodInfoPtr__StartFadeOutIfNecessary_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663554);
		AudioObject.NativeMethodInfoPtr__IsAudioLoopSequenceMode_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663555);
		AudioObject.NativeMethodInfoPtr__ScheduleNextInLoopSequence_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663556);
		AudioObject.NativeMethodInfoPtr__UpdateFadeVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663557);
		AudioObject.NativeMethodInfoPtr__EqualizePowerForCrossfading_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663558);
		AudioObject.NativeMethodInfoPtr_get__shouldStopIfPrimaryFadedOut_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663559);
		AudioObject.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663560);
		AudioObject.NativeMethodInfoPtr_SetApplicationPaused_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663561);
		AudioObject.NativeMethodInfoPtr_DestroyAudioObject_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663562);
		AudioObject.NativeMethodInfoPtr_TransformVolume_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663563);
		AudioObject.NativeMethodInfoPtr_InverseTransformVolume_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663564);
		AudioObject.NativeMethodInfoPtr_TransformPitch_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663565);
		AudioObject.NativeMethodInfoPtr_InverseTransformPitch_Public_Static_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663566);
		AudioObject.NativeMethodInfoPtr__ApplyVolumeBoth_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663567);
		AudioObject.NativeMethodInfoPtr__ApplyVolumePrimary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663568);
		AudioObject.NativeMethodInfoPtr__ApplyVolumeSecondary_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663569);
		AudioObject.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663570);
		AudioObject.NativeMethodInfoPtr__RestoreAudioSourceSettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663571);
		AudioObject.NativeMethodInfoPtr_DoesBelongToCategory_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663572);
		AudioObject.NativeMethodInfoPtr__GetRandomLoopSequenceDelay_Private_Single_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663573);
		AudioObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663574);
		AudioObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, 100663575);
	}

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000187 RID: 391 RVA: 0x0001988C File Offset: 0x00017A8C
	// (set) Token: 0x06000188 RID: 392 RVA: 0x000198C4 File Offset: 0x00017AC4
	public unsafe string audioID
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_audioID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_audioID_Internal_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000189 RID: 393 RVA: 0x00019908 File Offset: 0x00017B08
	// (set) Token: 0x0600018A RID: 394 RVA: 0x00019948 File Offset: 0x00017B48
	public unsafe AudioCategory category
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_category_Internal_set_Void_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600018B RID: 395 RVA: 0x0001998C File Offset: 0x00017B8C
	// (set) Token: 0x0600018C RID: 396 RVA: 0x000199CC File Offset: 0x00017BCC
	public unsafe AudioSubItem subItem
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_subItem_Public_get_AudioSubItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSubItem>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_subItem_Internal_set_Void_AudioSubItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600018D RID: 397 RVA: 0x00019A10 File Offset: 0x00017C10
	// (set) Token: 0x0600018E RID: 398 RVA: 0x00019A4C File Offset: 0x00017C4C
	public unsafe bool isPlayedAsMusic
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_isPlayedAsMusic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_isPlayedAsMusic_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600018F RID: 399 RVA: 0x00019A8C File Offset: 0x00017C8C
	public unsafe AudioItem audioItem
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 852288, RefRangeEnd = 852289, XrefRangeStart = 852288, XrefRangeEnd = 852288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_audioItem_Public_get_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr3) : null;
		}
	}

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000191 RID: 401 RVA: 0x00019B10 File Offset: 0x00017D10
	// (set) Token: 0x06000190 RID: 400 RVA: 0x00019ACC File Offset: 0x00017CCC
	public unsafe AudioObject.AudioEventDelegate completelyPlayedDelegate
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_completelyPlayedDelegate_Public_get_AudioEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject.AudioEventDelegate>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_completelyPlayedDelegate_Public_set_Void_AudioEventDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000192 RID: 402 RVA: 0x00019B50 File Offset: 0x00017D50
	// (set) Token: 0x06000193 RID: 403 RVA: 0x00019B8C File Offset: 0x00017D8C
	public unsafe float volume
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852289, XrefRangeEnd = 852290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852290, XrefRangeEnd = 852297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000194 RID: 404 RVA: 0x00019BCC File Offset: 0x00017DCC
	// (set) Token: 0x06000195 RID: 405 RVA: 0x00019C08 File Offset: 0x00017E08
	public unsafe float volumeItem
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_volumeItem_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852297, XrefRangeEnd = 852298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_volumeItem_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000196 RID: 406 RVA: 0x00019C48 File Offset: 0x00017E48
	public unsafe float volumeTotal
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852298, XrefRangeEnd = 852299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_volumeTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000197 RID: 407 RVA: 0x00019C84 File Offset: 0x00017E84
	public unsafe float volumeTotalWithoutFade
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 852305, RefRangeEnd = 852309, XrefRangeStart = 852299, XrefRangeEnd = 852305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_volumeTotalWithoutFade_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x06000198 RID: 408 RVA: 0x00019CC0 File Offset: 0x00017EC0
	public unsafe double playCalledAtTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_playCalledAtTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x06000199 RID: 409 RVA: 0x00019CFC File Offset: 0x00017EFC
	public unsafe double startedPlayingAtTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_startedPlayingAtTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x0600019A RID: 410 RVA: 0x00019D38 File Offset: 0x00017F38
	public unsafe float timeUntilEnd
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852309, XrefRangeEnd = 852312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_timeUntilEnd_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x0600019B RID: 411 RVA: 0x00019D74 File Offset: 0x00017F74
	// (set) Token: 0x0600019C RID: 412 RVA: 0x00019DB0 File Offset: 0x00017FB0
	public unsafe double scheduledPlayingAtDspTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_scheduledPlayingAtDspTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852312, XrefRangeEnd = 852314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_scheduledPlayingAtDspTime_Public_set_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x0600019D RID: 413 RVA: 0x00019DF0 File Offset: 0x00017FF0
	public unsafe float clipLength
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 852315, RefRangeEnd = 852319, XrefRangeStart = 852314, XrefRangeEnd = 852315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_clipLength_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x0600019E RID: 414 RVA: 0x00019E2C File Offset: 0x0001802C
	// (set) Token: 0x0600019F RID: 415 RVA: 0x00019E68 File Offset: 0x00018068
	public unsafe float audioTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852319, XrefRangeEnd = 852320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_audioTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852320, XrefRangeEnd = 852323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_audioTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x00019EA8 File Offset: 0x000180A8
	public unsafe bool isFadingOut
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 852323, RefRangeEnd = 852324, XrefRangeStart = 852323, XrefRangeEnd = 852323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x060001A1 RID: 417 RVA: 0x00019EE4 File Offset: 0x000180E4
	public unsafe bool isFadeOutComplete
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_isFadeOutComplete_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B0 RID: 176
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x00019F20 File Offset: 0x00018120
	public unsafe bool isFadingOutOrScheduled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B1 RID: 177
	// (get) Token: 0x060001A3 RID: 419 RVA: 0x00019F5C File Offset: 0x0001815C
	public unsafe bool isFadingIn
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x00019F98 File Offset: 0x00018198
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x00019FD4 File Offset: 0x000181D4
	public unsafe float pitch
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852324, XrefRangeEnd = 852326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_pitch_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852326, XrefRangeEnd = 852328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000B3 RID: 179
	// (get) Token: 0x060001A6 RID: 422 RVA: 0x0001A014 File Offset: 0x00018214
	// (set) Token: 0x060001A7 RID: 423 RVA: 0x0001A050 File Offset: 0x00018250
	public unsafe float pan
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852328, XrefRangeEnd = 852330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_pan_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852330, XrefRangeEnd = 852332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_pan_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x060001A8 RID: 424 RVA: 0x0001A090 File Offset: 0x00018290
	public unsafe double audioObjectTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_audioObjectTime_Public_get_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B5 RID: 181
	// (get) Token: 0x060001A9 RID: 425 RVA: 0x0001A0CC File Offset: 0x000182CC
	// (set) Token: 0x060001AA RID: 426 RVA: 0x0001A108 File Offset: 0x00018308
	public unsafe bool stopAfterFadeOut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_stopAfterFadeOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_set_stopAfterFadeOut_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060001AB RID: 427 RVA: 0x0001A148 File Offset: 0x00018348
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 852337, RefRangeEnd = 852340, XrefRangeStart = 852332, XrefRangeEnd = 852337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeIn(float fadeInTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeInTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_FadeIn_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001AC RID: 428 RVA: 0x0001A188 File Offset: 0x00018388
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852340, XrefRangeEnd = 852341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayScheduled(double dspTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dspTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001AD RID: 429 RVA: 0x0001A1C8 File Offset: 0x000183C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852341, XrefRangeEnd = 852345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayAfter(string audioID, double deltaDspTime = 0.0, float volume = 1f, float startTime = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaDspTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_PlayAfter_Public_Void_String_Double_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AE RID: 430 RVA: 0x0001A234 File Offset: 0x00018434
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852345, XrefRangeEnd = 852357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void PlayNow(string audioID, float delay = 0f, float volume = 1f, float startTime = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_PlayNow_Public_Void_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AF RID: 431 RVA: 0x0001A2A0 File Offset: 0x000184A0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852372, RefRangeEnd = 852373, XrefRangeStart = 852357, XrefRangeEnd = 852372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play(float delay = 0f)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Play_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B0 RID: 432 RVA: 0x0001A2E0 File Offset: 0x000184E0
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 852374, RefRangeEnd = 852381, XrefRangeStart = 852373, XrefRangeEnd = 852374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B1 RID: 433 RVA: 0x0001A314 File Offset: 0x00018514
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 852387, RefRangeEnd = 852395, XrefRangeStart = 852381, XrefRangeEnd = 852387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop(float fadeOutLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Stop_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B2 RID: 434 RVA: 0x0001A354 File Offset: 0x00018554
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852395, XrefRangeEnd = 852409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop(float fadeOutLength, float startToFadeTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startToFadeTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Stop_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B3 RID: 435 RVA: 0x0001A3A0 File Offset: 0x000185A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852409, XrefRangeEnd = 852410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FinishSequence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_FinishSequence_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B4 RID: 436 RVA: 0x0001A3D4 File Offset: 0x000185D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852410, XrefRangeEnd = 852415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator _WaitForSecondsThenStop(float startToFadeTime, float fadeOutLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref startToFadeTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOutLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__WaitForSecondsThenStop_Private_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060001B5 RID: 437 RVA: 0x0001A430 File Offset: 0x00018630
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852415, XrefRangeEnd = 852416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeOut(float fadeOutLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_FadeOut_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B6 RID: 438 RVA: 0x0001A470 File Offset: 0x00018670
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 852419, RefRangeEnd = 852425, XrefRangeStart = 852416, XrefRangeEnd = 852419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void FadeOut(float fadeOutLength, float startToFadeTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startToFadeTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B7 RID: 439 RVA: 0x0001A4BC File Offset: 0x000186BC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852425, XrefRangeEnd = 852426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Pause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001B8 RID: 440 RVA: 0x0001A4F0 File Offset: 0x000186F0
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 852427, RefRangeEnd = 852432, XrefRangeStart = 852426, XrefRangeEnd = 852427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Pause(float fadeOutTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Pause_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001B9 RID: 441 RVA: 0x0001A530 File Offset: 0x00018730
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852444, RefRangeEnd = 852445, XrefRangeStart = 852432, XrefRangeEnd = 852444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _PauseNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__PauseNow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BA RID: 442 RVA: 0x0001A564 File Offset: 0x00018764
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852445, XrefRangeEnd = 852446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unpause()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Unpause_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BB RID: 443 RVA: 0x0001A598 File Offset: 0x00018798
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 852462, RefRangeEnd = 852466, XrefRangeStart = 852446, XrefRangeEnd = 852462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Unpause(float fadeInTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeInTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Unpause_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001BC RID: 444 RVA: 0x0001A5D8 File Offset: 0x000187D8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852466, XrefRangeEnd = 852481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _UnpauseNow()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__UnpauseNow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x0001A60C File Offset: 0x0001880C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852481, XrefRangeEnd = 852486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator _WaitThenPause(float waitTime, int counter)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref waitTime;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref counter;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__WaitThenPause_Private_IEnumerator_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x060001BE RID: 446 RVA: 0x0001A668 File Offset: 0x00018868
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852486, XrefRangeEnd = 852495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _PauseAudioSources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__PauseAudioSources_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x0001A69C File Offset: 0x0001889C
	[CallerCount(0)]
	public unsafe bool IsPaused(bool returnTrueIfStillFadingOut = true)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref returnTrueIfStillFadingOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_IsPaused_Public_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001C0 RID: 448 RVA: 0x0001A6E8 File Offset: 0x000188E8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 852496, RefRangeEnd = 852502, XrefRangeStart = 852495, XrefRangeEnd = 852496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_IsPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001C1 RID: 449 RVA: 0x0001A724 File Offset: 0x00018924
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852502, XrefRangeEnd = 852504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsPrimaryPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_IsPrimaryPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001C2 RID: 450 RVA: 0x0001A760 File Offset: 0x00018960
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 852508, RefRangeEnd = 852516, XrefRangeStart = 852504, XrefRangeEnd = 852508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool IsSecondaryPlaying()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_IsSecondaryPlaying_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x170000B6 RID: 182
	// (get) Token: 0x060001C3 RID: 451 RVA: 0x0001A79C File Offset: 0x0001899C
	public unsafe AudioSource primaryAudioSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_primaryAudioSource_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x060001C4 RID: 452 RVA: 0x0001A7DC File Offset: 0x000189DC
	public unsafe AudioSource secondaryAudioSource
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get_secondaryAudioSource_Public_get_AudioSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr3) : null;
		}
	}

	// Token: 0x060001C5 RID: 453 RVA: 0x0001A81C File Offset: 0x00018A1C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 852533, RefRangeEnd = 852538, XrefRangeStart = 852516, XrefRangeEnd = 852533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SwitchAudioSources()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_SwitchAudioSources_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001C6 RID: 454 RVA: 0x0001A850 File Offset: 0x00018A50
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 852540, RefRangeEnd = 852543, XrefRangeStart = 852538, XrefRangeEnd = 852540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SwitchValues<T>(ref T v1, ref T v2)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		IntPtr intPtr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			ref IntPtr ptr2 = ref *ptr;
			intPtr = IL2CPP.Il2CppObjectBaseToPtr(v1);
			ptr2 = &intPtr;
		}
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(v2);
		ptr3 = &intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(AudioObject.MethodInfoStoreGeneric__SwitchValues_Private_Void_byref_T_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		IntPtr intPtr5 = intPtr;
		v1 = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
		IntPtr intPtr6 = intPtr2;
		v2 = ((intPtr6 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr6, false, false));
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x060001C7 RID: 455 RVA: 0x0001A8D4 File Offset: 0x00018AD4
	public unsafe float _volumeFromCategory
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get__volumeFromCategory_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x060001C8 RID: 456 RVA: 0x0001A910 File Offset: 0x00018B10
	public unsafe float _volumeWithCategory
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 852543, RefRangeEnd = 852545, XrefRangeStart = 852543, XrefRangeEnd = 852543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get__volumeWithCategory_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001A94C File Offset: 0x00018B4C
	public unsafe float _stopClipAtTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get__stopClipAtTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000BB RID: 187
	// (get) Token: 0x060001CA RID: 458 RVA: 0x0001A988 File Offset: 0x00018B88
	public unsafe float _startClipAtTime
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get__startClipAtTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001CB RID: 459 RVA: 0x0001A9C4 File Offset: 0x00018BC4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852545, XrefRangeEnd = 852599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioObject.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CC RID: 460 RVA: 0x0001AA00 File Offset: 0x00018C00
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852630, RefRangeEnd = 852631, XrefRangeStart = 852599, XrefRangeEnd = 852630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _CreateSecondAudioSource()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__CreateSecondAudioSource_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CD RID: 461 RVA: 0x0001AA34 File Offset: 0x00018C34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852631, XrefRangeEnd = 852638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Set0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__Set0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CE RID: 462 RVA: 0x0001AA68 File Offset: 0x00018C68
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 852650, RefRangeEnd = 852653, XrefRangeStart = 852638, XrefRangeEnd = 852650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SetReferences0()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__SetReferences0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001CF RID: 463 RVA: 0x0001AA9C File Offset: 0x00018C9C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 852669, RefRangeEnd = 852671, XrefRangeStart = 852653, XrefRangeEnd = 852669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _PlayScheduled(double dspTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref dspTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__PlayScheduled_Private_Void_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001D0 RID: 464 RVA: 0x0001AADC File Offset: 0x00018CDC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852372, RefRangeEnd = 852373, XrefRangeStart = 852372, XrefRangeEnd = 852373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _PlayDelayed(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__PlayDelayed_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001D1 RID: 465 RVA: 0x0001AB1C File Offset: 0x00018D1C
	[CallerCount(0)]
	public unsafe void _OnPlay()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__OnPlay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D2 RID: 466 RVA: 0x0001AB50 File Offset: 0x00018D50
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 852677, RefRangeEnd = 852683, XrefRangeStart = 852671, XrefRangeEnd = 852677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__Stop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D3 RID: 467 RVA: 0x0001AB84 File Offset: 0x00018D84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852683, XrefRangeEnd = 852712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D4 RID: 468 RVA: 0x0001ABB8 File Offset: 0x00018DB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852712, XrefRangeEnd = 852718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _StartFadeOutIfNecessary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__StartFadeOutIfNecessary_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D5 RID: 469 RVA: 0x0001ABEC File Offset: 0x00018DEC
	[CallerCount(0)]
	public unsafe bool _IsAudioLoopSequenceMode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__IsAudioLoopSequenceMode_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001D6 RID: 470 RVA: 0x0001AC28 File Offset: 0x00018E28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852718, XrefRangeEnd = 852719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _ScheduleNextInLoopSequence()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__ScheduleNextInLoopSequence_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x060001D7 RID: 471 RVA: 0x0001AC64 File Offset: 0x00018E64
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852725, RefRangeEnd = 852726, XrefRangeStart = 852719, XrefRangeEnd = 852725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _UpdateFadeVolume()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__UpdateFadeVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001D8 RID: 472 RVA: 0x0001AC98 File Offset: 0x00018E98
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852726, XrefRangeEnd = 852728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float _EqualizePowerForCrossfading(float v)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__EqualizePowerForCrossfading_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x170000BC RID: 188
	// (get) Token: 0x060001D9 RID: 473 RVA: 0x0001ACE4 File Offset: 0x00018EE4
	public unsafe bool _shouldStopIfPrimaryFadedOut
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_get__shouldStopIfPrimaryFadedOut_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001DA RID: 474 RVA: 0x0001AD20 File Offset: 0x00018F20
	[CallerCount(0)]
	public unsafe void OnApplicationPause(bool b)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001DB RID: 475 RVA: 0x0001AD60 File Offset: 0x00018F60
	[CallerCount(0)]
	public unsafe void SetApplicationPaused(bool isPaused)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isPaused;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_SetApplicationPaused_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001DC RID: 476 RVA: 0x0001ADA0 File Offset: 0x00018FA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852728, XrefRangeEnd = 852736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void DestroyAudioObject()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_DestroyAudioObject_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001DD RID: 477 RVA: 0x0001ADD4 File Offset: 0x00018FD4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852736, XrefRangeEnd = 852737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TransformVolume(float volume)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_TransformVolume_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001DE RID: 478 RVA: 0x0001AE14 File Offset: 0x00019014
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852737, XrefRangeEnd = 852738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float InverseTransformVolume(float volume)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_InverseTransformVolume_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001DF RID: 479 RVA: 0x0001AE54 File Offset: 0x00019054
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852738, XrefRangeEnd = 852739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float TransformPitch(float pitchSemiTones)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pitchSemiTones;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_TransformPitch_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001E0 RID: 480 RVA: 0x0001AE94 File Offset: 0x00019094
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852739, XrefRangeEnd = 852741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float InverseTransformPitch(float pitch)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref pitch;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_InverseTransformPitch_Public_Static_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001E1 RID: 481 RVA: 0x0001AED4 File Offset: 0x000190D4
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 852750, RefRangeEnd = 852755, XrefRangeStart = 852741, XrefRangeEnd = 852750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ApplyVolumeBoth()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__ApplyVolumeBoth_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E2 RID: 482 RVA: 0x0001AF08 File Offset: 0x00019108
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852759, RefRangeEnd = 852760, XrefRangeStart = 852755, XrefRangeEnd = 852759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ApplyVolumePrimary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__ApplyVolumePrimary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E3 RID: 483 RVA: 0x0001AF3C File Offset: 0x0001913C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852760, XrefRangeEnd = 852767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ApplyVolumeSecondary()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__ApplyVolumeSecondary_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E4 RID: 484 RVA: 0x0001AF70 File Offset: 0x00019170
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852767, XrefRangeEnd = 852778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioObject.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E5 RID: 485 RVA: 0x0001AFAC File Offset: 0x000191AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852778, XrefRangeEnd = 852786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RestoreAudioSourceSettings()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__RestoreAudioSourceSettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001E6 RID: 486 RVA: 0x0001AFE0 File Offset: 0x000191E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852788, RefRangeEnd = 852789, XrefRangeStart = 852786, XrefRangeEnd = 852788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool DoesBelongToCategory(string categoryName)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr_DoesBelongToCategory_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001E7 RID: 487 RVA: 0x0001B030 File Offset: 0x00019230
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852789, XrefRangeEnd = 852790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float _GetRandomLoopSequenceDelay(AudioItem audioItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__GetRandomLoopSequenceDelay_Private_Single_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x060001E8 RID: 488 RVA: 0x0001B080 File Offset: 0x00019280
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852790, XrefRangeEnd = 852793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioObject.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x060001E9 RID: 489 RVA: 0x0001B0C4 File Offset: 0x000192C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852793, XrefRangeEnd = 852794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioObject>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001EA RID: 490 RVA: 0x00002B16 File Offset: 0x00000D16
	public AudioObject(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060001EB RID: 491 RVA: 0x0001B100 File Offset: 0x00019300
	// (set) Token: 0x060001EC RID: 492 RVA: 0x00002B1F File Offset: 0x00000D1F
	public unsafe string _audioID_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioID_k__BackingField);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060001ED RID: 493 RVA: 0x0001B128 File Offset: 0x00019328
	// (set) Token: 0x060001EE RID: 494 RVA: 0x00002B3E File Offset: 0x00000D3E
	public unsafe AudioCategory _category
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__category);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__category), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060001EF RID: 495 RVA: 0x0001B158 File Offset: 0x00019358
	// (set) Token: 0x060001F0 RID: 496 RVA: 0x00002B5D File Offset: 0x00000D5D
	public unsafe bool _isPlayedAsMusic_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__isPlayedAsMusic_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__isPlayedAsMusic_k__BackingField)) = value;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060001F1 RID: 497 RVA: 0x0001B180 File Offset: 0x00019380
	// (set) Token: 0x060001F2 RID: 498 RVA: 0x00002B78 File Offset: 0x00000D78
	public unsafe AudioSubItem _subItemPrimary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__subItemPrimary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSubItem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__subItemPrimary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060001F3 RID: 499 RVA: 0x0001B1B0 File Offset: 0x000193B0
	// (set) Token: 0x060001F4 RID: 500 RVA: 0x00002B97 File Offset: 0x00000D97
	public unsafe AudioSubItem _subItemSecondary
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__subItemSecondary);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSubItem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__subItemSecondary), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060001F5 RID: 501 RVA: 0x0001B1E0 File Offset: 0x000193E0
	// (set) Token: 0x060001F6 RID: 502 RVA: 0x00002BB6 File Offset: 0x00000DB6
	public unsafe AudioObject.AudioEventDelegate _completelyPlayedDelegate
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__completelyPlayedDelegate);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject.AudioEventDelegate>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__completelyPlayedDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060001F7 RID: 503 RVA: 0x0001B210 File Offset: 0x00019410
	// (set) Token: 0x060001F8 RID: 504 RVA: 0x00002BD5 File Offset: 0x00000DD5
	public unsafe int _pauseCoroutineCounter
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__pauseCoroutineCounter);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__pauseCoroutineCounter)) = value;
		}
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060001F9 RID: 505 RVA: 0x0001B238 File Offset: 0x00019438
	// (set) Token: 0x060001FA RID: 506 RVA: 0x00002BF0 File Offset: 0x00000DF0
	public unsafe float _volumeExcludingCategory
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeExcludingCategory);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeExcludingCategory)) = value;
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060001FB RID: 507 RVA: 0x0001B260 File Offset: 0x00019460
	// (set) Token: 0x060001FC RID: 508 RVA: 0x00002C0B File Offset: 0x00000E0B
	public unsafe float _volumeFromPrimaryFade
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromPrimaryFade);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromPrimaryFade)) = value;
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060001FD RID: 509 RVA: 0x0001B288 File Offset: 0x00019488
	// (set) Token: 0x060001FE RID: 510 RVA: 0x00002C26 File Offset: 0x00000E26
	public unsafe float _volumeFromSecondaryFade
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromSecondaryFade);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromSecondaryFade)) = value;
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060001FF RID: 511 RVA: 0x0001B2B0 File Offset: 0x000194B0
	// (set) Token: 0x06000200 RID: 512 RVA: 0x00002C41 File Offset: 0x00000E41
	public unsafe float _volumeFromScriptCall
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromScriptCall);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__volumeFromScriptCall)) = value;
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06000201 RID: 513 RVA: 0x0001B2D8 File Offset: 0x000194D8
	// (set) Token: 0x06000202 RID: 514 RVA: 0x00002C5C File Offset: 0x00000E5C
	public unsafe bool _paused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__paused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__paused)) = value;
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x06000203 RID: 515 RVA: 0x0001B300 File Offset: 0x00019500
	// (set) Token: 0x06000204 RID: 516 RVA: 0x00002C77 File Offset: 0x00000E77
	public unsafe bool _applicationPaused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__applicationPaused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__applicationPaused)) = value;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06000205 RID: 517 RVA: 0x0001B328 File Offset: 0x00019528
	// (set) Token: 0x06000206 RID: 518 RVA: 0x00002C92 File Offset: 0x00000E92
	public unsafe AudioFader _primaryFader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__primaryFader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioFader>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__primaryFader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x06000207 RID: 519 RVA: 0x0001B358 File Offset: 0x00019558
	// (set) Token: 0x06000208 RID: 520 RVA: 0x00002CB1 File Offset: 0x00000EB1
	public unsafe AudioFader _secondaryFader
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__secondaryFader);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioFader>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__secondaryFader), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x06000209 RID: 521 RVA: 0x0001B388 File Offset: 0x00019588
	// (set) Token: 0x0600020A RID: 522 RVA: 0x00002CD0 File Offset: 0x00000ED0
	public unsafe double _playTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playTime)) = value;
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x0600020B RID: 523 RVA: 0x0001B3B0 File Offset: 0x000195B0
	// (set) Token: 0x0600020C RID: 524 RVA: 0x00002CEB File Offset: 0x00000EEB
	public unsafe double _playStartTimeLocal
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playStartTimeLocal);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playStartTimeLocal)) = value;
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600020D RID: 525 RVA: 0x0001B3D8 File Offset: 0x000195D8
	// (set) Token: 0x0600020E RID: 526 RVA: 0x00002D06 File Offset: 0x00000F06
	public unsafe double _playStartTimeSystem
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playStartTimeSystem);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playStartTimeSystem)) = value;
		}
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x0600020F RID: 527 RVA: 0x0001B400 File Offset: 0x00019600
	// (set) Token: 0x06000210 RID: 528 RVA: 0x00002D21 File Offset: 0x00000F21
	public unsafe double _playScheduledTimeDsp
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playScheduledTimeDsp);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__playScheduledTimeDsp)) = value;
		}
	}

	// Token: 0x1700008B RID: 139
	// (get) Token: 0x06000211 RID: 529 RVA: 0x0001B428 File Offset: 0x00019628
	// (set) Token: 0x06000212 RID: 530 RVA: 0x00002D3C File Offset: 0x00000F3C
	public unsafe double _audioObjectTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioObjectTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioObjectTime)) = value;
		}
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06000213 RID: 531 RVA: 0x0001B450 File Offset: 0x00019650
	// (set) Token: 0x06000214 RID: 532 RVA: 0x00002D57 File Offset: 0x00000F57
	public unsafe bool _IsInactive
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__IsInactive);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__IsInactive)) = value;
		}
	}

	// Token: 0x1700008D RID: 141
	// (get) Token: 0x06000215 RID: 533 RVA: 0x0001B478 File Offset: 0x00019678
	// (set) Token: 0x06000216 RID: 534 RVA: 0x00002D72 File Offset: 0x00000F72
	public unsafe bool _stopRequested
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__stopRequested);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__stopRequested)) = value;
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06000217 RID: 535 RVA: 0x0001B4A0 File Offset: 0x000196A0
	// (set) Token: 0x06000218 RID: 536 RVA: 0x00002D8D File Offset: 0x00000F8D
	public unsafe bool _finishSequence
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__finishSequence);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__finishSequence)) = value;
		}
	}

	// Token: 0x1700008F RID: 143
	// (get) Token: 0x06000219 RID: 537 RVA: 0x0001B4C8 File Offset: 0x000196C8
	// (set) Token: 0x0600021A RID: 538 RVA: 0x00002DA8 File Offset: 0x00000FA8
	public unsafe int _loopSequenceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__loopSequenceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__loopSequenceCount)) = value;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600021B RID: 539 RVA: 0x0001B4F0 File Offset: 0x000196F0
	// (set) Token: 0x0600021C RID: 540 RVA: 0x00002DC3 File Offset: 0x00000FC3
	public unsafe bool _stopAfterFadeoutUserSetting
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__stopAfterFadeoutUserSetting);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__stopAfterFadeoutUserSetting)) = value;
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600021D RID: 541 RVA: 0x0001B518 File Offset: 0x00019718
	// (set) Token: 0x0600021E RID: 542 RVA: 0x00002DDE File Offset: 0x00000FDE
	public unsafe bool _pauseWithFadeOutRequested
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__pauseWithFadeOutRequested);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__pauseWithFadeOutRequested)) = value;
		}
	}

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x0600021F RID: 543 RVA: 0x0001B540 File Offset: 0x00019740
	// (set) Token: 0x06000220 RID: 544 RVA: 0x00002DF9 File Offset: 0x00000FF9
	public unsafe double _dspTimeRemainingAtPause
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__dspTimeRemainingAtPause);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__dspTimeRemainingAtPause)) = value;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000221 RID: 545 RVA: 0x0001B568 File Offset: 0x00019768
	// (set) Token: 0x06000222 RID: 546 RVA: 0x00002E14 File Offset: 0x00001014
	public unsafe AudioController _audioController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioController);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioController), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000223 RID: 547 RVA: 0x0001B598 File Offset: 0x00019798
	// (set) Token: 0x06000224 RID: 548 RVA: 0x00002E33 File Offset: 0x00001033
	public unsafe bool _isCurrentPlaylistTrack
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__isCurrentPlaylistTrack);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__isCurrentPlaylistTrack)) = value;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000225 RID: 549 RVA: 0x0001B5C0 File Offset: 0x000197C0
	// (set) Token: 0x06000226 RID: 550 RVA: 0x00002E4E File Offset: 0x0000104E
	public unsafe float _audioSource_MinDistance_Saved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_MinDistance_Saved);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_MinDistance_Saved)) = value;
		}
	}

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000227 RID: 551 RVA: 0x0001B5E8 File Offset: 0x000197E8
	// (set) Token: 0x06000228 RID: 552 RVA: 0x00002E69 File Offset: 0x00001069
	public unsafe float _audioSource_MaxDistance_Saved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_MaxDistance_Saved);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_MaxDistance_Saved)) = value;
		}
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000229 RID: 553 RVA: 0x0001B610 File Offset: 0x00019810
	// (set) Token: 0x0600022A RID: 554 RVA: 0x00002E84 File Offset: 0x00001084
	public unsafe float _audioSource_SpatialBlend_Saved
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_SpatialBlend_Saved);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource_SpatialBlend_Saved)) = value;
		}
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600022B RID: 555 RVA: 0x0001B638 File Offset: 0x00019838
	// (set) Token: 0x0600022C RID: 556 RVA: 0x00002E9F File Offset: 0x0000109F
	public unsafe int _lastChosenSubItemIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__lastChosenSubItemIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__lastChosenSubItemIndex)) = value;
		}
	}

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600022D RID: 557 RVA: 0x0001B660 File Offset: 0x00019860
	// (set) Token: 0x0600022E RID: 558 RVA: 0x00002EBA File Offset: 0x000010BA
	public unsafe AudioSource _audioSource1
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource1);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource1), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600022F RID: 559 RVA: 0x0001B690 File Offset: 0x00019890
	// (set) Token: 0x06000230 RID: 560 RVA: 0x00002ED9 File Offset: 0x000010D9
	public unsafe AudioSource _audioSource2
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource2);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSource>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__audioSource2), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000231 RID: 561 RVA: 0x0001B6C0 File Offset: 0x000198C0
	// (set) Token: 0x06000232 RID: 562 RVA: 0x00002EF8 File Offset: 0x000010F8
	public unsafe bool _primaryAudioSourcePaused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__primaryAudioSourcePaused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__primaryAudioSourcePaused)) = value;
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000233 RID: 563 RVA: 0x0001B6E8 File Offset: 0x000198E8
	// (set) Token: 0x06000234 RID: 564 RVA: 0x00002F13 File Offset: 0x00001113
	public unsafe bool _secondaryAudioSourcePaused
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__secondaryAudioSourcePaused);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.NativeFieldInfoPtr__secondaryAudioSourcePaused)) = value;
		}
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000235 RID: 565 RVA: 0x0001B710 File Offset: 0x00019910
	// (set) Token: 0x06000236 RID: 566 RVA: 0x00002F2E File Offset: 0x0000112E
	public unsafe static float VOLUME_TRANSFORM_POWER
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(AudioObject.NativeFieldInfoPtr_VOLUME_TRANSFORM_POWER, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioObject.NativeFieldInfoPtr_VOLUME_TRANSFORM_POWER, (void*)(&value));
		}
	}

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeFieldInfoPtr__audioID_k__BackingField;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeFieldInfoPtr__category;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeFieldInfoPtr__isPlayedAsMusic_k__BackingField;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeFieldInfoPtr__subItemPrimary;

	// Token: 0x04000126 RID: 294
	private static readonly IntPtr NativeFieldInfoPtr__subItemSecondary;

	// Token: 0x04000127 RID: 295
	private static readonly IntPtr NativeFieldInfoPtr__completelyPlayedDelegate;

	// Token: 0x04000128 RID: 296
	private static readonly IntPtr NativeFieldInfoPtr__pauseCoroutineCounter;

	// Token: 0x04000129 RID: 297
	private static readonly IntPtr NativeFieldInfoPtr__volumeExcludingCategory;

	// Token: 0x0400012A RID: 298
	private static readonly IntPtr NativeFieldInfoPtr__volumeFromPrimaryFade;

	// Token: 0x0400012B RID: 299
	private static readonly IntPtr NativeFieldInfoPtr__volumeFromSecondaryFade;

	// Token: 0x0400012C RID: 300
	private static readonly IntPtr NativeFieldInfoPtr__volumeFromScriptCall;

	// Token: 0x0400012D RID: 301
	private static readonly IntPtr NativeFieldInfoPtr__paused;

	// Token: 0x0400012E RID: 302
	private static readonly IntPtr NativeFieldInfoPtr__applicationPaused;

	// Token: 0x0400012F RID: 303
	private static readonly IntPtr NativeFieldInfoPtr__primaryFader;

	// Token: 0x04000130 RID: 304
	private static readonly IntPtr NativeFieldInfoPtr__secondaryFader;

	// Token: 0x04000131 RID: 305
	private static readonly IntPtr NativeFieldInfoPtr__playTime;

	// Token: 0x04000132 RID: 306
	private static readonly IntPtr NativeFieldInfoPtr__playStartTimeLocal;

	// Token: 0x04000133 RID: 307
	private static readonly IntPtr NativeFieldInfoPtr__playStartTimeSystem;

	// Token: 0x04000134 RID: 308
	private static readonly IntPtr NativeFieldInfoPtr__playScheduledTimeDsp;

	// Token: 0x04000135 RID: 309
	private static readonly IntPtr NativeFieldInfoPtr__audioObjectTime;

	// Token: 0x04000136 RID: 310
	private static readonly IntPtr NativeFieldInfoPtr__IsInactive;

	// Token: 0x04000137 RID: 311
	private static readonly IntPtr NativeFieldInfoPtr__stopRequested;

	// Token: 0x04000138 RID: 312
	private static readonly IntPtr NativeFieldInfoPtr__finishSequence;

	// Token: 0x04000139 RID: 313
	private static readonly IntPtr NativeFieldInfoPtr__loopSequenceCount;

	// Token: 0x0400013A RID: 314
	private static readonly IntPtr NativeFieldInfoPtr__stopAfterFadeoutUserSetting;

	// Token: 0x0400013B RID: 315
	private static readonly IntPtr NativeFieldInfoPtr__pauseWithFadeOutRequested;

	// Token: 0x0400013C RID: 316
	private static readonly IntPtr NativeFieldInfoPtr__dspTimeRemainingAtPause;

	// Token: 0x0400013D RID: 317
	private static readonly IntPtr NativeFieldInfoPtr__audioController;

	// Token: 0x0400013E RID: 318
	private static readonly IntPtr NativeFieldInfoPtr__isCurrentPlaylistTrack;

	// Token: 0x0400013F RID: 319
	private static readonly IntPtr NativeFieldInfoPtr__audioSource_MinDistance_Saved;

	// Token: 0x04000140 RID: 320
	private static readonly IntPtr NativeFieldInfoPtr__audioSource_MaxDistance_Saved;

	// Token: 0x04000141 RID: 321
	private static readonly IntPtr NativeFieldInfoPtr__audioSource_SpatialBlend_Saved;

	// Token: 0x04000142 RID: 322
	private static readonly IntPtr NativeFieldInfoPtr__lastChosenSubItemIndex;

	// Token: 0x04000143 RID: 323
	private static readonly IntPtr NativeFieldInfoPtr__audioSource1;

	// Token: 0x04000144 RID: 324
	private static readonly IntPtr NativeFieldInfoPtr__audioSource2;

	// Token: 0x04000145 RID: 325
	private static readonly IntPtr NativeFieldInfoPtr__primaryAudioSourcePaused;

	// Token: 0x04000146 RID: 326
	private static readonly IntPtr NativeFieldInfoPtr__secondaryAudioSourcePaused;

	// Token: 0x04000147 RID: 327
	private static readonly IntPtr NativeFieldInfoPtr_VOLUME_TRANSFORM_POWER;

	// Token: 0x04000148 RID: 328
	private static readonly IntPtr NativeMethodInfoPtr_get_audioID_Public_get_String_0;

	// Token: 0x04000149 RID: 329
	private static readonly IntPtr NativeMethodInfoPtr_set_audioID_Internal_set_Void_String_0;

	// Token: 0x0400014A RID: 330
	private static readonly IntPtr NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0;

	// Token: 0x0400014B RID: 331
	private static readonly IntPtr NativeMethodInfoPtr_set_category_Internal_set_Void_AudioCategory_0;

	// Token: 0x0400014C RID: 332
	private static readonly IntPtr NativeMethodInfoPtr_get_subItem_Public_get_AudioSubItem_0;

	// Token: 0x0400014D RID: 333
	private static readonly IntPtr NativeMethodInfoPtr_set_subItem_Internal_set_Void_AudioSubItem_0;

	// Token: 0x0400014E RID: 334
	private static readonly IntPtr NativeMethodInfoPtr_get_isPlayedAsMusic_Public_get_Boolean_0;

	// Token: 0x0400014F RID: 335
	private static readonly IntPtr NativeMethodInfoPtr_set_isPlayedAsMusic_Internal_set_Void_Boolean_0;

	// Token: 0x04000150 RID: 336
	private static readonly IntPtr NativeMethodInfoPtr_get_audioItem_Public_get_AudioItem_0;

	// Token: 0x04000151 RID: 337
	private static readonly IntPtr NativeMethodInfoPtr_set_completelyPlayedDelegate_Public_set_Void_AudioEventDelegate_0;

	// Token: 0x04000152 RID: 338
	private static readonly IntPtr NativeMethodInfoPtr_get_completelyPlayedDelegate_Public_get_AudioEventDelegate_0;

	// Token: 0x04000153 RID: 339
	private static readonly IntPtr NativeMethodInfoPtr_get_volume_Public_get_Single_0;

	// Token: 0x04000154 RID: 340
	private static readonly IntPtr NativeMethodInfoPtr_set_volume_Public_set_Void_Single_0;

	// Token: 0x04000155 RID: 341
	private static readonly IntPtr NativeMethodInfoPtr_get_volumeItem_Public_get_Single_0;

	// Token: 0x04000156 RID: 342
	private static readonly IntPtr NativeMethodInfoPtr_set_volumeItem_Public_set_Void_Single_0;

	// Token: 0x04000157 RID: 343
	private static readonly IntPtr NativeMethodInfoPtr_get_volumeTotal_Public_get_Single_0;

	// Token: 0x04000158 RID: 344
	private static readonly IntPtr NativeMethodInfoPtr_get_volumeTotalWithoutFade_Public_get_Single_0;

	// Token: 0x04000159 RID: 345
	private static readonly IntPtr NativeMethodInfoPtr_get_playCalledAtTime_Public_get_Double_0;

	// Token: 0x0400015A RID: 346
	private static readonly IntPtr NativeMethodInfoPtr_get_startedPlayingAtTime_Public_get_Double_0;

	// Token: 0x0400015B RID: 347
	private static readonly IntPtr NativeMethodInfoPtr_get_timeUntilEnd_Public_get_Single_0;

	// Token: 0x0400015C RID: 348
	private static readonly IntPtr NativeMethodInfoPtr_get_scheduledPlayingAtDspTime_Public_get_Double_0;

	// Token: 0x0400015D RID: 349
	private static readonly IntPtr NativeMethodInfoPtr_set_scheduledPlayingAtDspTime_Public_set_Void_Double_0;

	// Token: 0x0400015E RID: 350
	private static readonly IntPtr NativeMethodInfoPtr_get_clipLength_Public_get_Single_0;

	// Token: 0x0400015F RID: 351
	private static readonly IntPtr NativeMethodInfoPtr_get_audioTime_Public_get_Single_0;

	// Token: 0x04000160 RID: 352
	private static readonly IntPtr NativeMethodInfoPtr_set_audioTime_Public_set_Void_Single_0;

	// Token: 0x04000161 RID: 353
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingOut_Public_get_Boolean_0;

	// Token: 0x04000162 RID: 354
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadeOutComplete_Public_get_Boolean_0;

	// Token: 0x04000163 RID: 355
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingOutOrScheduled_Public_get_Boolean_0;

	// Token: 0x04000164 RID: 356
	private static readonly IntPtr NativeMethodInfoPtr_get_isFadingIn_Public_get_Boolean_0;

	// Token: 0x04000165 RID: 357
	private static readonly IntPtr NativeMethodInfoPtr_get_pitch_Public_get_Single_0;

	// Token: 0x04000166 RID: 358
	private static readonly IntPtr NativeMethodInfoPtr_set_pitch_Public_set_Void_Single_0;

	// Token: 0x04000167 RID: 359
	private static readonly IntPtr NativeMethodInfoPtr_get_pan_Public_get_Single_0;

	// Token: 0x04000168 RID: 360
	private static readonly IntPtr NativeMethodInfoPtr_set_pan_Public_set_Void_Single_0;

	// Token: 0x04000169 RID: 361
	private static readonly IntPtr NativeMethodInfoPtr_get_audioObjectTime_Public_get_Double_0;

	// Token: 0x0400016A RID: 362
	private static readonly IntPtr NativeMethodInfoPtr_get_stopAfterFadeOut_Public_get_Boolean_0;

	// Token: 0x0400016B RID: 363
	private static readonly IntPtr NativeMethodInfoPtr_set_stopAfterFadeOut_Public_set_Void_Boolean_0;

	// Token: 0x0400016C RID: 364
	private static readonly IntPtr NativeMethodInfoPtr_FadeIn_Public_Void_Single_0;

	// Token: 0x0400016D RID: 365
	private static readonly IntPtr NativeMethodInfoPtr_PlayScheduled_Public_Void_Double_0;

	// Token: 0x0400016E RID: 366
	private static readonly IntPtr NativeMethodInfoPtr_PlayAfter_Public_Void_String_Double_Single_Single_0;

	// Token: 0x0400016F RID: 367
	private static readonly IntPtr NativeMethodInfoPtr_PlayNow_Public_Void_String_Single_Single_Single_0;

	// Token: 0x04000170 RID: 368
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_Single_0;

	// Token: 0x04000171 RID: 369
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	// Token: 0x04000172 RID: 370
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Single_0;

	// Token: 0x04000173 RID: 371
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_Single_Single_0;

	// Token: 0x04000174 RID: 372
	private static readonly IntPtr NativeMethodInfoPtr_FinishSequence_Public_Void_0;

	// Token: 0x04000175 RID: 373
	private static readonly IntPtr NativeMethodInfoPtr__WaitForSecondsThenStop_Private_IEnumerator_Single_Single_0;

	// Token: 0x04000176 RID: 374
	private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_Single_0;

	// Token: 0x04000177 RID: 375
	private static readonly IntPtr NativeMethodInfoPtr_FadeOut_Public_Void_Single_Single_0;

	// Token: 0x04000178 RID: 376
	private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_0;

	// Token: 0x04000179 RID: 377
	private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Void_Single_0;

	// Token: 0x0400017A RID: 378
	private static readonly IntPtr NativeMethodInfoPtr__PauseNow_Private_Void_0;

	// Token: 0x0400017B RID: 379
	private static readonly IntPtr NativeMethodInfoPtr_Unpause_Public_Void_0;

	// Token: 0x0400017C RID: 380
	private static readonly IntPtr NativeMethodInfoPtr_Unpause_Public_Void_Single_0;

	// Token: 0x0400017D RID: 381
	private static readonly IntPtr NativeMethodInfoPtr__UnpauseNow_Private_Void_0;

	// Token: 0x0400017E RID: 382
	private static readonly IntPtr NativeMethodInfoPtr__WaitThenPause_Private_IEnumerator_Single_Int32_0;

	// Token: 0x0400017F RID: 383
	private static readonly IntPtr NativeMethodInfoPtr__PauseAudioSources_Private_Void_0;

	// Token: 0x04000180 RID: 384
	private static readonly IntPtr NativeMethodInfoPtr_IsPaused_Public_Boolean_Boolean_0;

	// Token: 0x04000181 RID: 385
	private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Boolean_0;

	// Token: 0x04000182 RID: 386
	private static readonly IntPtr NativeMethodInfoPtr_IsPrimaryPlaying_Public_Boolean_0;

	// Token: 0x04000183 RID: 387
	private static readonly IntPtr NativeMethodInfoPtr_IsSecondaryPlaying_Public_Boolean_0;

	// Token: 0x04000184 RID: 388
	private static readonly IntPtr NativeMethodInfoPtr_get_primaryAudioSource_Public_get_AudioSource_0;

	// Token: 0x04000185 RID: 389
	private static readonly IntPtr NativeMethodInfoPtr_get_secondaryAudioSource_Public_get_AudioSource_0;

	// Token: 0x04000186 RID: 390
	private static readonly IntPtr NativeMethodInfoPtr_SwitchAudioSources_Public_Void_0;

	// Token: 0x04000187 RID: 391
	private static readonly IntPtr NativeMethodInfoPtr__SwitchValues_Private_Void_byref_T_byref_T_0;

	// Token: 0x04000188 RID: 392
	private static readonly IntPtr NativeMethodInfoPtr_get__volumeFromCategory_Internal_get_Single_0;

	// Token: 0x04000189 RID: 393
	private static readonly IntPtr NativeMethodInfoPtr_get__volumeWithCategory_Internal_get_Single_0;

	// Token: 0x0400018A RID: 394
	private static readonly IntPtr NativeMethodInfoPtr_get__stopClipAtTime_Private_get_Single_0;

	// Token: 0x0400018B RID: 395
	private static readonly IntPtr NativeMethodInfoPtr_get__startClipAtTime_Private_get_Single_0;

	// Token: 0x0400018C RID: 396
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

	// Token: 0x0400018D RID: 397
	private static readonly IntPtr NativeMethodInfoPtr__CreateSecondAudioSource_Private_Void_0;

	// Token: 0x0400018E RID: 398
	private static readonly IntPtr NativeMethodInfoPtr__Set0_Private_Void_0;

	// Token: 0x0400018F RID: 399
	private static readonly IntPtr NativeMethodInfoPtr__SetReferences0_Private_Void_0;

	// Token: 0x04000190 RID: 400
	private static readonly IntPtr NativeMethodInfoPtr__PlayScheduled_Private_Void_Double_0;

	// Token: 0x04000191 RID: 401
	private static readonly IntPtr NativeMethodInfoPtr__PlayDelayed_Private_Void_Single_0;

	// Token: 0x04000192 RID: 402
	private static readonly IntPtr NativeMethodInfoPtr__OnPlay_Private_Void_0;

	// Token: 0x04000193 RID: 403
	private static readonly IntPtr NativeMethodInfoPtr__Stop_Private_Void_0;

	// Token: 0x04000194 RID: 404
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000195 RID: 405
	private static readonly IntPtr NativeMethodInfoPtr__StartFadeOutIfNecessary_Private_Void_0;

	// Token: 0x04000196 RID: 406
	private static readonly IntPtr NativeMethodInfoPtr__IsAudioLoopSequenceMode_Private_Boolean_0;

	// Token: 0x04000197 RID: 407
	private static readonly IntPtr NativeMethodInfoPtr__ScheduleNextInLoopSequence_Private_Boolean_0;

	// Token: 0x04000198 RID: 408
	private static readonly IntPtr NativeMethodInfoPtr__UpdateFadeVolume_Private_Void_0;

	// Token: 0x04000199 RID: 409
	private static readonly IntPtr NativeMethodInfoPtr__EqualizePowerForCrossfading_Private_Single_Single_0;

	// Token: 0x0400019A RID: 410
	private static readonly IntPtr NativeMethodInfoPtr_get__shouldStopIfPrimaryFadedOut_Private_get_Boolean_0;

	// Token: 0x0400019B RID: 411
	private static readonly IntPtr NativeMethodInfoPtr_OnApplicationPause_Private_Void_Boolean_0;

	// Token: 0x0400019C RID: 412
	private static readonly IntPtr NativeMethodInfoPtr_SetApplicationPaused_Private_Void_Boolean_0;

	// Token: 0x0400019D RID: 413
	private static readonly IntPtr NativeMethodInfoPtr_DestroyAudioObject_Public_Void_0;

	// Token: 0x0400019E RID: 414
	private static readonly IntPtr NativeMethodInfoPtr_TransformVolume_Public_Static_Single_Single_0;

	// Token: 0x0400019F RID: 415
	private static readonly IntPtr NativeMethodInfoPtr_InverseTransformVolume_Public_Static_Single_Single_0;

	// Token: 0x040001A0 RID: 416
	private static readonly IntPtr NativeMethodInfoPtr_TransformPitch_Public_Static_Single_Single_0;

	// Token: 0x040001A1 RID: 417
	private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPitch_Public_Static_Single_Single_0;

	// Token: 0x040001A2 RID: 418
	private static readonly IntPtr NativeMethodInfoPtr__ApplyVolumeBoth_Internal_Void_0;

	// Token: 0x040001A3 RID: 419
	private static readonly IntPtr NativeMethodInfoPtr__ApplyVolumePrimary_Internal_Void_0;

	// Token: 0x040001A4 RID: 420
	private static readonly IntPtr NativeMethodInfoPtr__ApplyVolumeSecondary_Internal_Void_0;

	// Token: 0x040001A5 RID: 421
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

	// Token: 0x040001A6 RID: 422
	private static readonly IntPtr NativeMethodInfoPtr__RestoreAudioSourceSettings_Private_Void_0;

	// Token: 0x040001A7 RID: 423
	private static readonly IntPtr NativeMethodInfoPtr_DoesBelongToCategory_Public_Boolean_String_0;

	// Token: 0x040001A8 RID: 424
	private static readonly IntPtr NativeMethodInfoPtr__GetRandomLoopSequenceDelay_Private_Single_AudioItem_0;

	// Token: 0x040001A9 RID: 425
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x040001AA RID: 426
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200022D RID: 557
	public sealed class AudioEventDelegate : MulticastDelegate
	{
		// Token: 0x06001E33 RID: 7731 RVA: 0x0008A588 File Offset: 0x00088788
		// Note: this type is marked as 'beforefieldinit'.
		static AudioEventDelegate()
		{
			Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "AudioEventDelegate");
			AudioObject.AudioEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr, 100663576);
			AudioObject.AudioEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr, 100663577);
			AudioObject.AudioEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioObject_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr, 100663578);
			AudioObject.AudioEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr, 100663579);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x0008A5FC File Offset: 0x000887FC
		[CallerCount(333)]
		[CachedScanResults(RefRangeStart = 312876, RefRangeEnd = 313209, XrefRangeStart = 312876, XrefRangeEnd = 313209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioEventDelegate(global::Il2CppSystem.Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioObject.AudioEventDelegate>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.AudioEventDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x0008A658 File Offset: 0x00088858
		[CallerCount(0)]
		public unsafe void Invoke(AudioObject audioObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.AudioEventDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x0008A69C File Offset: 0x0008889C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 479320, RefRangeEnd = 479322, XrefRangeStart = 479320, XrefRangeEnd = 479322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(AudioObject audioObject, AsyncCallback callback, global::Il2CppSystem.Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioObject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.AudioEventDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioObject_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06001E37 RID: 7735 RVA: 0x0008A710 File Offset: 0x00088910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.AudioEventDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x0000CF14 File Offset: 0x0000B114
		public AudioEventDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000CF1D File Offset: 0x0000B11D
		public static implicit operator AudioObject.AudioEventDelegate(Action<AudioObject> A_0)
		{
			return DelegateSupport.ConvertDelegate<AudioObject.AudioEventDelegate>(A_0);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x0000CF25 File Offset: 0x0000B125
		public static AudioObject.AudioEventDelegate operator +(AudioObject.AudioEventDelegate A_0, AudioObject.AudioEventDelegate A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<AudioObject.AudioEventDelegate>();
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x0000CF33 File Offset: 0x0000B133
		public static AudioObject.AudioEventDelegate operator -(AudioObject.AudioEventDelegate A_0, AudioObject.AudioEventDelegate A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<AudioObject.AudioEventDelegate>();
			}
			return delegate2;
		}

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400150F RID: 5391
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_AudioObject_0;

		// Token: 0x04001510 RID: 5392
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AudioObject_AsyncCallback_Object_0;

		// Token: 0x04001511 RID: 5393
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}

	// Token: 0x0200022E RID: 558
	[ObfuscatedName("AudioObject+<_WaitForSecondsThenStop>d__76")]
	public sealed class __WaitForSecondsThenStop_d__76 : global::Il2CppSystem.Object
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x0008A754 File Offset: 0x00088954
		// Note: this type is marked as 'beforefieldinit'.
		static __WaitForSecondsThenStop_d__76()
		{
			Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "<_WaitForSecondsThenStop>d__76");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, "<>1__state");
			AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, "<>2__current");
			AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_startToFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, "startToFadeTime");
			AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, "<>4__this");
			AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_fadeOutLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, "fadeOutLength");
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663580);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663581);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663582);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663583);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663584);
			AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr, 100663585);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0008A85C File Offset: 0x00088A5C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __WaitForSecondsThenStop_d__76(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioObject.__WaitForSecondsThenStop_d__76>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x0008A8A4 File Offset: 0x00088AA4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x0008A8D8 File Offset: 0x00088AD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852268, XrefRangeEnd = 852273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x0008A914 File Offset: 0x00088B14
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x0008A954 File Offset: 0x00088B54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852273, XrefRangeEnd = 852278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x0008A988 File Offset: 0x00088B88
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitForSecondsThenStop_d__76.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x0000CF44 File Offset: 0x0000B144
		public __WaitForSecondsThenStop_d__76(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x0008A9C8 File Offset: 0x00088BC8
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x0000CF4D File Offset: 0x0000B14D
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x0008A9F0 File Offset: 0x00088BF0
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0000CF68 File Offset: 0x0000B168
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x0008AA20 File Offset: 0x00088C20
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0000CF87 File Offset: 0x0000B187
		public unsafe float startToFadeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_startToFadeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_startToFadeTime)) = value;
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x0008AA48 File Offset: 0x00088C48
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0000CFA2 File Offset: 0x0000B1A2
		public unsafe AudioObject __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x0008AA78 File Offset: 0x00088C78
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0000CFC1 File Offset: 0x0000B1C1
		public unsafe float fadeOutLength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_fadeOutLength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitForSecondsThenStop_d__76.NativeFieldInfoPtr_fadeOutLength)) = value;
			}
		}

		// Token: 0x04001512 RID: 5394
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001513 RID: 5395
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001514 RID: 5396
		private static readonly IntPtr NativeFieldInfoPtr_startToFadeTime;

		// Token: 0x04001515 RID: 5397
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001516 RID: 5398
		private static readonly IntPtr NativeFieldInfoPtr_fadeOutLength;

		// Token: 0x04001517 RID: 5399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x0200022F RID: 559
	[ObfuscatedName("AudioObject+<_WaitThenPause>d__86")]
	public sealed class __WaitThenPause_d__86 : global::Il2CppSystem.Object
	{
		// Token: 0x06001E4E RID: 7758 RVA: 0x0008AAA0 File Offset: 0x00088CA0
		// Note: this type is marked as 'beforefieldinit'.
		static __WaitThenPause_d__86()
		{
			Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioObject>.NativeClassPtr, "<_WaitThenPause>d__86");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr);
			AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, "<>1__state");
			AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, "<>2__current");
			AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_waitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, "waitTime");
			AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, "<>4__this");
			AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_counter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, "counter");
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663586);
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663587);
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663588);
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663589);
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663590);
			AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr, 100663591);
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x0008ABA8 File Offset: 0x00088DA8
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __WaitThenPause_d__86(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioObject.__WaitThenPause_d__86>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x0008ABF0 File Offset: 0x00088DF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x0008AC24 File Offset: 0x00088E24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852278, XrefRangeEnd = 852283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x0008AC60 File Offset: 0x00088E60
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E53 RID: 7763 RVA: 0x0008ACA0 File Offset: 0x00088EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852283, XrefRangeEnd = 852288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x0008ACD4 File Offset: 0x00088ED4
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioObject.__WaitThenPause_d__86.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001E55 RID: 7765 RVA: 0x0000CFDC File Offset: 0x0000B1DC
		public __WaitThenPause_d__86(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x0008AD14 File Offset: 0x00088F14
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x0000CFE5 File Offset: 0x0000B1E5
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x0008AD3C File Offset: 0x00088F3C
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x0000D000 File Offset: 0x0000B200
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x0008AD6C File Offset: 0x00088F6C
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x0000D01F File Offset: 0x0000B21F
		public unsafe float waitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_waitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_waitTime)) = value;
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x0008AD94 File Offset: 0x00088F94
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x0000D03A File Offset: 0x0000B23A
		public unsafe AudioObject __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001E5E RID: 7774 RVA: 0x0008ADC4 File Offset: 0x00088FC4
		// (set) Token: 0x06001E5F RID: 7775 RVA: 0x0000D059 File Offset: 0x0000B259
		public unsafe int counter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_counter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioObject.__WaitThenPause_d__86.NativeFieldInfoPtr_counter)) = value;
			}
		}

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeFieldInfoPtr_waitTime;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr_counter;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x02000230 RID: 560
	private sealed class MethodInfoStoreGeneric__SwitchValues_Private_Void_byref_T_byref_T_0<T>
	{
		// Token: 0x04001528 RID: 5416
		internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AudioObject.NativeMethodInfoPtr__SwitchValues_Private_Void_byref_T_byref_T_0, Il2CppClassPointerStore<AudioObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
	}
}
