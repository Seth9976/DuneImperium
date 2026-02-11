using System;
using dwd.core._3rdParty.AudioToolkit.AudioToolkit;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000005 RID: 5
public class AudioController : SingletonMonoBehaviour<AudioController>
{
	// Token: 0x0600000F RID: 15 RVA: 0x00013618 File Offset: 0x00011818
	// Note: this type is marked as 'beforefieldinit'.
	static AudioController()
	{
		Il2CppClassPointerStore<AudioController>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioController>.NativeClassPtr);
		AudioController.NativeFieldInfoPtr_AUDIO_TOOLKIT_VERSION = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "AUDIO_TOOLKIT_VERSION");
		AudioController.NativeFieldInfoPtr_AudioObjectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "AudioObjectPrefab");
		AudioController.NativeFieldInfoPtr_Persistent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "Persistent");
		AudioController.NativeFieldInfoPtr_UnloadAudioClipsOnDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "UnloadAudioClipsOnDestroy");
		AudioController.NativeFieldInfoPtr_UsePooledAudioObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "UsePooledAudioObjects");
		AudioController.NativeFieldInfoPtr_PlayWithZeroVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "PlayWithZeroVolume");
		AudioController.NativeFieldInfoPtr_EqualPowerCrossfade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "EqualPowerCrossfade");
		AudioController.NativeFieldInfoPtr_musicCrossFadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "musicCrossFadeTime");
		AudioController.NativeFieldInfoPtr_specifyCrossFadeInAndOutSeperately = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "specifyCrossFadeInAndOutSeperately");
		AudioController.NativeFieldInfoPtr__musicCrossFadeTime_In = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_musicCrossFadeTime_In");
		AudioController.NativeFieldInfoPtr__musicCrossFadeTime_Out = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_musicCrossFadeTime_Out");
		AudioController.NativeFieldInfoPtr_AudioCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "AudioCategories");
		AudioController.NativeFieldInfoPtr_musicPlaylist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "musicPlaylist");
		AudioController.NativeFieldInfoPtr_loopPlaylist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "loopPlaylist");
		AudioController.NativeFieldInfoPtr_shufflePlaylist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "shufflePlaylist");
		AudioController.NativeFieldInfoPtr_crossfadePlaylist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "crossfadePlaylist");
		AudioController.NativeFieldInfoPtr_delayBetweenPlaylistTracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "delayBetweenPlaylistTracks");
		AudioController.NativeFieldInfoPtr_logging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "logging");
		AudioController.NativeFieldInfoPtr__currentMusicReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_currentMusicReference");
		AudioController.NativeFieldInfoPtr__currentAudioListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_currentAudioListener");
		AudioController.NativeFieldInfoPtr__musicEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_musicEnabled");
		AudioController.NativeFieldInfoPtr__soundMuted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_soundMuted");
		AudioController.NativeFieldInfoPtr__categoriesValidated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_categoriesValidated");
		AudioController.NativeFieldInfoPtr__isAdditionalAudioController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_isAdditionalAudioController");
		AudioController.NativeFieldInfoPtr__audioDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_audioDisabled");
		AudioController.NativeFieldInfoPtr__audioItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_audioItems");
		AudioController.NativeFieldInfoPtr__playlistPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_playlistPlayed");
		AudioController.NativeFieldInfoPtr__isPlaylistPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_isPlaylistPlaying");
		AudioController.NativeFieldInfoPtr__volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_volume");
		AudioController.NativeFieldInfoPtr__systemTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_systemTime");
		AudioController.NativeFieldInfoPtr__lastSystemTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_lastSystemTime");
		AudioController.NativeFieldInfoPtr__systemDeltaTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_systemDeltaTime");
		AudioController.NativeFieldInfoPtr__additionalAudioControllers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_additionalAudioControllers");
		AudioController.NativeFieldInfoPtr__currentInspectorSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "_currentInspectorSelection");
		AudioController.NativeFieldInfoPtr_resolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "resolver");
		AudioController.NativeFieldInfoPtr_hasResolver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController>.NativeClassPtr, "hasResolver");
		AudioController.NativeMethodInfoPtr_set_DisableAudio_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663301);
		AudioController.NativeMethodInfoPtr_get_DisableAudio_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663302);
		AudioController.NativeMethodInfoPtr_get_isAdditionalAudioController_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663303);
		AudioController.NativeMethodInfoPtr_set_isAdditionalAudioController_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663304);
		AudioController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663305);
		AudioController.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663306);
		AudioController.NativeMethodInfoPtr_get_musicEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663307);
		AudioController.NativeMethodInfoPtr_set_musicEnabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663308);
		AudioController.NativeMethodInfoPtr_get_soundMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663309);
		AudioController.NativeMethodInfoPtr_set_soundMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663310);
		AudioController.NativeMethodInfoPtr_get_musicCrossFadeTime_In_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663311);
		AudioController.NativeMethodInfoPtr_set_musicCrossFadeTime_In_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663312);
		AudioController.NativeMethodInfoPtr_get_musicCrossFadeTime_Out_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663313);
		AudioController.NativeMethodInfoPtr_set_musicCrossFadeTime_Out_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663314);
		AudioController.NativeMethodInfoPtr_get_systemTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663315);
		AudioController.NativeMethodInfoPtr_get_systemDeltaTime_Public_Static_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663316);
		AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663317);
		AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663318);
		AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663319);
		AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663320);
		AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Transform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663321);
		AudioController.NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663322);
		AudioController.NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663323);
		AudioController.NativeMethodInfoPtr_PauseMusic_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663324);
		AudioController.NativeMethodInfoPtr_IsMusicPaused_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663325);
		AudioController.NativeMethodInfoPtr_UnpauseMusic_Public_Static_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663326);
		AudioController.NativeMethodInfoPtr_EnqueueMusic_Public_Static_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663327);
		AudioController.NativeMethodInfoPtr_GetMusicPlaylist_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663328);
		AudioController.NativeMethodInfoPtr_SetMusicPlaylist_Public_Static_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663329);
		AudioController.NativeMethodInfoPtr_PlayMusicPlaylist_Public_Static_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663330);
		AudioController.NativeMethodInfoPtr_PlayNextMusicOnPlaylist_Public_Static_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663331);
		AudioController.NativeMethodInfoPtr_PlayPreviousMusicOnPlaylist_Public_Static_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663332);
		AudioController.NativeMethodInfoPtr_IsPlaylistPlaying_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663333);
		AudioController.NativeMethodInfoPtr_ClearPlaylist_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663334);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663335);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663336);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663337);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663338);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663339);
		AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663340);
		AudioController.NativeMethodInfoPtr_PlayScheduled_Public_Static_AudioObject_String_Double_Vector3_Transform_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663341);
		AudioController.NativeMethodInfoPtr_PlayAfter_Public_Static_AudioObject_String_AudioObject_Double_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663342);
		AudioController.NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663343);
		AudioController.NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663344);
		AudioController.NativeMethodInfoPtr_StopAll_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663345);
		AudioController.NativeMethodInfoPtr_StopAll_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663346);
		AudioController.NativeMethodInfoPtr_PauseAll_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663347);
		AudioController.NativeMethodInfoPtr_UnpauseAll_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663348);
		AudioController.NativeMethodInfoPtr_PauseCategory_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663349);
		AudioController.NativeMethodInfoPtr_UnpauseCategory_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663350);
		AudioController.NativeMethodInfoPtr_StopCategory_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663351);
		AudioController.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663352);
		AudioController.NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663353);
		AudioController.NativeMethodInfoPtr_GetPlayingAudioObjectsInCategory_Public_Static_Void_IList_1_AudioObject_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663354);
		AudioController.NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663355);
		AudioController.NativeMethodInfoPtr_GetPlayingAudioObjectsCount_Public_Static_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663356);
		AudioController.NativeMethodInfoPtr_EnableMusic_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663357);
		AudioController.NativeMethodInfoPtr_MuteSound_Public_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663358);
		AudioController.NativeMethodInfoPtr_IsMusicEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663359);
		AudioController.NativeMethodInfoPtr_IsSoundMuted_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663360);
		AudioController.NativeMethodInfoPtr_GetCurrentAudioListener_Public_Static_AudioListener_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663361);
		AudioController.NativeMethodInfoPtr_GetCurrentMusic_Public_Static_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663362);
		AudioController.NativeMethodInfoPtr_GetCategory_Public_Static_AudioCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663363);
		AudioController.NativeMethodInfoPtr_SetCategoryVolume_Public_Static_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663364);
		AudioController.NativeMethodInfoPtr_GetCategoryVolume_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663365);
		AudioController.NativeMethodInfoPtr_SetGlobalVolume_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663366);
		AudioController.NativeMethodInfoPtr_GetGlobalVolume_Public_Static_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663367);
		AudioController.NativeMethodInfoPtr_NewCategory_Public_Static_AudioCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663368);
		AudioController.NativeMethodInfoPtr_RemoveCategory_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663369);
		AudioController.NativeMethodInfoPtr_AddToCategory_Public_Static_Void_AudioCategory_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663370);
		AudioController.NativeMethodInfoPtr_AddToCategory_Public_Static_AudioItem_AudioCategory_AudioClip_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663371);
		AudioController.NativeMethodInfoPtr_RemoveAudioItem_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663372);
		AudioController.NativeMethodInfoPtr_IsValidAudioID_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663373);
		AudioController.NativeMethodInfoPtr_GetAudioItem_Public_Static_AudioItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663374);
		AudioController.NativeMethodInfoPtr_DetachAllAudios_Public_Static_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663375);
		AudioController.NativeMethodInfoPtr_GetAudioItemMaxDistance_Public_Static_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663376);
		AudioController.NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663377);
		AudioController.NativeMethodInfoPtr_getPlayingClips_Protected_HashSet_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663378);
		AudioController.NativeMethodInfoPtr_set__currentMusic_Private_Static_set_Void_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663379);
		AudioController.NativeMethodInfoPtr_get__currentMusic_Private_Static_get_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663380);
		AudioController.NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663381);
		AudioController.NativeMethodInfoPtr__GetAudioItem_Internal_AudioItem_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663382);
		AudioController.NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663383);
		AudioController.NativeMethodInfoPtr__StopMusic_Protected_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663384);
		AudioController.NativeMethodInfoPtr__PauseMusic_Protected_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663385);
		AudioController.NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Vector3_Transform_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663386);
		AudioController.NativeMethodInfoPtr__EnqueueMusic_Protected_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663387);
		AudioController.NativeMethodInfoPtr__PlayMusicPlaylist_Protected_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663388);
		AudioController.NativeMethodInfoPtr__PlayMusicTrackWithID_Private_AudioObject_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663389);
		AudioController.NativeMethodInfoPtr__PlayNextMusicOnPlaylist_Internal_AudioObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663390);
		AudioController.NativeMethodInfoPtr__PlayPreviousMusicOnPlaylist_Internal_AudioObject_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663391);
		AudioController.NativeMethodInfoPtr__ResetLastPlayedList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663392);
		AudioController.NativeMethodInfoPtr__GetNextMusicTrack_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663393);
		AudioController.NativeMethodInfoPtr__GetPreviousMusicTrack_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663394);
		AudioController.NativeMethodInfoPtr__GetPreviousMusicTrackShuffled_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663395);
		AudioController.NativeMethodInfoPtr__RemoveLastPlayedOnList_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663396);
		AudioController.NativeMethodInfoPtr__GetNextMusicTrackShuffled_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663397);
		AudioController.NativeMethodInfoPtr__GetNextMusicTrackInOrder_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663398);
		AudioController.NativeMethodInfoPtr__GetPreviousMusicTrackInOrder_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663399);
		AudioController.NativeMethodInfoPtr__PlayAsSound_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663400);
		AudioController.NativeMethodInfoPtr__PlayAsMusic_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663401);
		AudioController.NativeMethodInfoPtr__PlayEx_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663402);
		AudioController.NativeMethodInfoPtr_PlayAudioItem_Public_AudioObject_AudioItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663403);
		AudioController.NativeMethodInfoPtr__GetCategory_Internal_AudioCategory_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663404);
		AudioController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663405);
		AudioController.NativeMethodInfoPtr__UpdateSystemTime_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663406);
		AudioController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663407);
		AudioController.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663408);
		AudioController.NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663409);
		AudioController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663410);
		AudioController.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663411);
		AudioController.NativeMethodInfoPtr_AwakeSingleton_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663412);
		AudioController.NativeMethodInfoPtr__ValidateCategories_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663413);
		AudioController.NativeMethodInfoPtr__InvalidateCategories_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663414);
		AudioController.NativeMethodInfoPtr_InitializeAudioItems_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663415);
		AudioController.NativeMethodInfoPtr__InitializeAudioItems_Private_Void_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663416);
		AudioController.NativeMethodInfoPtr__RegisterAdditionalAudioController_Private_Void_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663417);
		AudioController.NativeMethodInfoPtr__SyncCategoryVolumes_Private_Void_AudioController_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663418);
		AudioController.NativeMethodInfoPtr__UnregisterAdditionalAudioController_Private_Void_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663419);
		AudioController.NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663420);
		AudioController.NativeMethodInfoPtr__ChooseSingleSubItem_Internal_Static_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663421);
		AudioController.NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663422);
		AudioController.NativeMethodInfoPtr__ChooseRandomSubitem_Private_Static_Int32_AudioItem_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663423);
		AudioController.NativeMethodInfoPtr_isOdd_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663424);
		AudioController.NativeMethodInfoPtr_PlayAudioSubItem_Public_AudioObject_AudioSubItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663425);
		AudioController.NativeMethodInfoPtr__GetAudioController_Private_AudioController_AudioSubItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663426);
		AudioController.NativeMethodInfoPtr__NotifyPlaylistTrackCompleteleyPlayed_Internal_Void_AudioObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663427);
		AudioController.NativeMethodInfoPtr__ValidateAudioObjectPrefab_Private_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663428);
		AudioController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663429);
		AudioController.NativeMethodInfoPtr_getResolver_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663430);
		AudioController.NativeMethodInfoPtr_resolve_Private_Void_AudioSubItem_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController>.NativeClassPtr, 100663431);
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x06000011 RID: 17 RVA: 0x00014394 File Offset: 0x00012594
	// (set) Token: 0x06000010 RID: 16 RVA: 0x00014354 File Offset: 0x00012554
	public unsafe bool DisableAudio
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_DisableAudio_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 850290, RefRangeEnd = 850291, XrefRangeStart = 850290, XrefRangeEnd = 850290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_DisableAudio_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x06000012 RID: 18 RVA: 0x000143D0 File Offset: 0x000125D0
	// (set) Token: 0x06000013 RID: 19 RVA: 0x0001440C File Offset: 0x0001260C
	public unsafe bool isAdditionalAudioController
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_isAdditionalAudioController_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_isAdditionalAudioController_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000029 RID: 41
	// (get) Token: 0x06000014 RID: 20 RVA: 0x0001444C File Offset: 0x0001264C
	// (set) Token: 0x06000015 RID: 21 RVA: 0x00014488 File Offset: 0x00012688
	public unsafe float Volume
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850291, XrefRangeEnd = 850292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x06000016 RID: 22 RVA: 0x000144C8 File Offset: 0x000126C8
	// (set) Token: 0x06000017 RID: 23 RVA: 0x00014504 File Offset: 0x00012704
	public unsafe bool musicEnabled
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_musicEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850292, XrefRangeEnd = 850304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_musicEnabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x06000018 RID: 24 RVA: 0x00014544 File Offset: 0x00012744
	// (set) Token: 0x06000019 RID: 25 RVA: 0x00014580 File Offset: 0x00012780
	public unsafe bool soundMuted
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_soundMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850304, XrefRangeEnd = 850305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_soundMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x0600001A RID: 26 RVA: 0x000145C0 File Offset: 0x000127C0
	// (set) Token: 0x0600001B RID: 27 RVA: 0x000145FC File Offset: 0x000127FC
	public unsafe float musicCrossFadeTime_In
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_musicCrossFadeTime_In_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_musicCrossFadeTime_In_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x0600001C RID: 28 RVA: 0x0001463C File Offset: 0x0001283C
	// (set) Token: 0x0600001D RID: 29 RVA: 0x00014678 File Offset: 0x00012878
	public unsafe float musicCrossFadeTime_Out
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_musicCrossFadeTime_Out_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 604707, RefRangeEnd = 604708, XrefRangeStart = 604707, XrefRangeEnd = 604708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set_musicCrossFadeTime_Out_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600001E RID: 30 RVA: 0x000146B8 File Offset: 0x000128B8
	public unsafe static double systemTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850310, XrefRangeEnd = 850314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_systemTime_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600001F RID: 31 RVA: 0x000146E8 File Offset: 0x000128E8
	public unsafe static double systemDeltaTime
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850314, XrefRangeEnd = 850318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get_systemDeltaTime_Public_Static_get_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00014718 File Offset: 0x00012918
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 850326, RefRangeEnd = 850328, XrefRangeStart = 850318, XrefRangeEnd = 850326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusic(string audioID, float volume, float delay, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00014788 File Offset: 0x00012988
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850328, XrefRangeEnd = 850332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusic(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000147CC File Offset: 0x000129CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850332, XrefRangeEnd = 850336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusic(string audioID, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00014820 File Offset: 0x00012A20
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850336, XrefRangeEnd = 850344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusic(string audioID, Vector3 worldPosition, Transform parentObj = null, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000024 RID: 36 RVA: 0x000148B0 File Offset: 0x00012AB0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850344, XrefRangeEnd = 850353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusic(string audioID, Transform parentObj, float volume = 1f, float delay = 0f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Transform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00014930 File Offset: 0x00012B30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850353, XrefRangeEnd = 850358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopMusic()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00014960 File Offset: 0x00012B60
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850358, XrefRangeEnd = 850363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool StopMusic(float fadeOut)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000027 RID: 39 RVA: 0x000149A0 File Offset: 0x00012BA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850363, XrefRangeEnd = 850368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool PauseMusic(float fadeOut = 0f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PauseMusic_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000149E0 File Offset: 0x00012BE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850368, XrefRangeEnd = 850376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMusicPaused()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsMusicPaused_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00014A10 File Offset: 0x00012C10
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 850394, RefRangeEnd = 850396, XrefRangeStart = 850376, XrefRangeEnd = 850394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool UnpauseMusic(float fadeIn = 0f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeIn;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_UnpauseMusic_Public_Static_Boolean_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00014A50 File Offset: 0x00012C50
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850396, XrefRangeEnd = 850406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int EnqueueMusic(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_EnqueueMusic_Public_Static_Int32_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00014A94 File Offset: 0x00012C94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850406, XrefRangeEnd = 850418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppStringArray GetMusicPlaylist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetMusicPlaylist_Public_Static_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00014AC8 File Offset: 0x00012CC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850418, XrefRangeEnd = 850428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetMusicPlaylist(Il2CppStringArray playlist)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playlist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_SetMusicPlaylist_Public_Static_Void_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00014B00 File Offset: 0x00012D00
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850428, XrefRangeEnd = 850438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayMusicPlaylist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayMusicPlaylist_Public_Static_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00014B34 File Offset: 0x00012D34
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850438, XrefRangeEnd = 850443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayNextMusicOnPlaylist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayNextMusicOnPlaylist_Public_Static_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00014B68 File Offset: 0x00012D68
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850443, XrefRangeEnd = 850448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayPreviousMusicOnPlaylist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayPreviousMusicOnPlaylist_Public_Static_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00014B9C File Offset: 0x00012D9C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 850458, RefRangeEnd = 850461, XrefRangeStart = 850448, XrefRangeEnd = 850458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPlaylistPlaying()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsPlaylistPlaying_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00014BCC File Offset: 0x00012DCC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850461, XrefRangeEnd = 850466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void ClearPlaylist()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_ClearPlaylist_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00014BF4 File Offset: 0x00012DF4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 850486, RefRangeEnd = 850492, XrefRangeStart = 850466, XrefRangeEnd = 850486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, global::Il2CppSystem.Object context = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00014C4C File Offset: 0x00012E4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850492, XrefRangeEnd = 850509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, float volume, float delay = 0f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00014CBC File Offset: 0x00012EBC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 850517, RefRangeEnd = 850520, XrefRangeStart = 850509, XrefRangeEnd = 850517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, Transform parentObj, global::Il2CppSystem.Object context = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00014D24 File Offset: 0x00012F24
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850520, XrefRangeEnd = 850525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, Transform parentObj, float volume, float delay = 0f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00014DA4 File Offset: 0x00012FA4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 850529, RefRangeEnd = 850530, XrefRangeStart = 850525, XrefRangeEnd = 850529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, Vector3 worldPosition, Transform parentObj = null, global::Il2CppSystem.Object context = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00014E1C File Offset: 0x0001301C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 850534, RefRangeEnd = 850536, XrefRangeStart = 850530, XrefRangeEnd = 850534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject Play(string audioID, Vector3 worldPosition, Transform parentObj, float volume, float delay = 0f, float startTime = 0f, global::Il2CppSystem.Object context = null)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_Object_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00014EC0 File Offset: 0x000130C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850536, XrefRangeEnd = 850540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayScheduled(string audioID, double dspTime, Vector3 worldPosition, Transform parentObj = null, float volume = 1f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayScheduled_Public_Static_AudioObject_String_Double_Vector3_Transform_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00014F50 File Offset: 0x00013150
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 850557, RefRangeEnd = 850558, XrefRangeStart = 850540, XrefRangeEnd = 850557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject PlayAfter(string audioID, AudioObject playingAudio, double deltaDspTime = 0.0, float volume = 1f, float startTime = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playingAudio);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref deltaDspTime;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayAfter_Public_Static_AudioObject_String_AudioObject_Double_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00014FD0 File Offset: 0x000131D0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 850587, RefRangeEnd = 850588, XrefRangeStart = 850558, XrefRangeEnd = 850587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Stop(string audioID, float fadeOutLength)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOutLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00015020 File Offset: 0x00013220
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850588, XrefRangeEnd = 850592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool Stop(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00015064 File Offset: 0x00013264
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850592, XrefRangeEnd = 850616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopAll(float fadeOutLength)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_StopAll_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00015098 File Offset: 0x00013298
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850616, XrefRangeEnd = 850643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopAll()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_StopAll_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600003E RID: 62 RVA: 0x000150C0 File Offset: 0x000132C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850643, XrefRangeEnd = 850667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseAll(float fadeOutLength = 0f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PauseAll_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600003F RID: 63 RVA: 0x000150F4 File Offset: 0x000132F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850667, XrefRangeEnd = 850697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnpauseAll(float fadeInLength = 0f)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeInLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_UnpauseAll_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00015128 File Offset: 0x00013328
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850697, XrefRangeEnd = 850730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void PauseCategory(string categoryName, float fadeOutLength = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOutLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PauseCategory_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0001516C File Offset: 0x0001336C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850730, XrefRangeEnd = 850760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void UnpauseCategory(string categoryName, float fadeInLength = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeInLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_UnpauseCategory_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000151B0 File Offset: 0x000133B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850760, XrefRangeEnd = 850793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void StopCategory(string categoryName, float fadeOutLength = 0f)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeOutLength;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_StopCategory_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000151F4 File Offset: 0x000133F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850793, XrefRangeEnd = 850816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsPlaying(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00015238 File Offset: 0x00013438
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 850835, RefRangeEnd = 850837, XrefRangeStart = 850816, XrefRangeEnd = 850835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPlayingAudioObjects(IList<AudioObject> objs, string audioID, bool includePausedAudio = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(audioID);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePausedAudio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00015290 File Offset: 0x00013490
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 850856, RefRangeEnd = 850859, XrefRangeStart = 850837, XrefRangeEnd = 850856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPlayingAudioObjectsInCategory(IList<AudioObject> objs, string categoryName, bool includePausedAudio = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(categoryName);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePausedAudio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetPlayingAudioObjectsInCategory_Public_Static_Void_IList_1_AudioObject_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x000152E8 File Offset: 0x000134E8
	[CallerCount(12)]
	[CachedScanResults(RefRangeStart = 850877, RefRangeEnd = 850889, XrefRangeStart = 850859, XrefRangeEnd = 850877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void GetPlayingAudioObjects(IList<AudioObject> objs, bool includePausedAudio = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objs);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePausedAudio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0001532C File Offset: 0x0001352C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850889, XrefRangeEnd = 850909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int GetPlayingAudioObjectsCount(string audioID, bool includePausedAudio = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref includePausedAudio;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetPlayingAudioObjectsCount_Public_Static_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0001537C File Offset: 0x0001357C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850909, XrefRangeEnd = 850924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void EnableMusic(bool b)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_EnableMusic_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000049 RID: 73 RVA: 0x000153B0 File Offset: 0x000135B0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850924, XrefRangeEnd = 850929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void MuteSound(bool b)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_MuteSound_Public_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x000153E4 File Offset: 0x000135E4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850929, XrefRangeEnd = 850932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsMusicEnabled()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsMusicEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00015414 File Offset: 0x00013614
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850932, XrefRangeEnd = 850935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsSoundMuted()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsSoundMuted_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00015444 File Offset: 0x00013644
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 850964, RefRangeEnd = 850968, XrefRangeStart = 850935, XrefRangeEnd = 850964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioListener GetCurrentAudioListener()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetCurrentAudioListener_Public_Static_AudioListener_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioListener>(intPtr3) : null;
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00015478 File Offset: 0x00013678
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850968, XrefRangeEnd = 850972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioObject GetCurrentMusic()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetCurrentMusic_Public_Static_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000154AC File Offset: 0x000136AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 850972, XrefRangeEnd = 850982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioCategory GetCategory(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetCategory_Public_Static_AudioCategory_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr3) : null;
		}
	}

	// Token: 0x0600004F RID: 79 RVA: 0x000154F0 File Offset: 0x000136F0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851002, RefRangeEnd = 851003, XrefRangeStart = 850982, XrefRangeEnd = 851002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetCategoryVolume(string name, float volume)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_SetCategoryVolume_Public_Static_Void_String_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00015534 File Offset: 0x00013734
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851003, XrefRangeEnd = 851023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetCategoryVolume(string name)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetCategoryVolume_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00015578 File Offset: 0x00013778
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851023, XrefRangeEnd = 851033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void SetGlobalVolume(float volume)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref volume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_SetGlobalVolume_Public_Static_Void_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000052 RID: 82 RVA: 0x000155AC File Offset: 0x000137AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851033, XrefRangeEnd = 851036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetGlobalVolume()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetGlobalVolume_Public_Static_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000053 RID: 83 RVA: 0x000155DC File Offset: 0x000137DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851036, XrefRangeEnd = 851067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioCategory NewCategory(string categoryName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_NewCategory_Public_Static_AudioCategory_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr3) : null;
		}
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00015620 File Offset: 0x00013820
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851067, XrefRangeEnd = 851083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void RemoveCategory(string categoryName)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(categoryName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_RemoveCategory_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00015658 File Offset: 0x00013858
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851083, XrefRangeEnd = 851094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void AddToCategory(AudioCategory category, AudioItem audioItem)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_AddToCategory_Public_Static_Void_AudioCategory_AudioItem_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000156A0 File Offset: 0x000138A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851094, XrefRangeEnd = 851124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioItem AddToCategory(AudioCategory category, AudioClip audioClip, string audioID)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(category);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(audioClip);
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(audioID);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_AddToCategory_Public_Static_AudioItem_AudioCategory_AudioClip_String_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr3) : null;
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00015708 File Offset: 0x00013908
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851124, XrefRangeEnd = 851149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool RemoveAudioItem(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_RemoveAudioItem_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000058 RID: 88 RVA: 0x0001574C File Offset: 0x0001394C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851149, XrefRangeEnd = 851157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool IsValidAudioID(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_IsValidAudioID_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00015790 File Offset: 0x00013990
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851165, RefRangeEnd = 851167, XrefRangeStart = 851157, XrefRangeEnd = 851165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioItem GetAudioItem(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetAudioItem_Public_Static_AudioItem_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr3) : null;
		}
	}

	// Token: 0x0600005A RID: 90 RVA: 0x000157D4 File Offset: 0x000139D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851167, XrefRangeEnd = 851173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void DetachAllAudios(GameObject gameObjectWithAudios)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameObjectWithAudios);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_DetachAllAudios_Public_Static_Void_GameObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600005B RID: 91 RVA: 0x0001580C File Offset: 0x00013A0C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851173, XrefRangeEnd = 851186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static float GetAudioItemMaxDistance(string audioID)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_GetAudioItemMaxDistance_Public_Static_Single_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00015850 File Offset: 0x00013A50
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851199, RefRangeEnd = 851202, XrefRangeStart = 851186, XrefRangeEnd = 851199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadAllAudioClips()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00015884 File Offset: 0x00013A84
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851247, RefRangeEnd = 851248, XrefRangeStart = 851202, XrefRangeEnd = 851247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe HashSet<AudioClip> getPlayingClips()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_getPlayingClips_Protected_HashSet_1_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<AudioClip>>(intPtr3) : null;
	}

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600005F RID: 95 RVA: 0x000158FC File Offset: 0x00013AFC
	// (set) Token: 0x0600005E RID: 94 RVA: 0x000158C4 File Offset: 0x00013AC4
	public unsafe static AudioObject _currentMusic
	{
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 851265, RefRangeEnd = 851291, XrefRangeStart = 851257, XrefRangeEnd = 851265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_get__currentMusic_Private_Static_get_AudioObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 851256, RefRangeEnd = 851257, XrefRangeStart = 851248, XrefRangeEnd = 851256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_set__currentMusic_Private_Static_set_Void_AudioObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00015930 File Offset: 0x00013B30
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 851311, RefRangeEnd = 851316, XrefRangeStart = 851291, XrefRangeEnd = 851311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ApplyVolumeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00015964 File Offset: 0x00013B64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851316, XrefRangeEnd = 851321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioItem _GetAudioItem(string audioID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetAudioItem_Internal_AudioItem_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr3) : null;
		}
	}

	// Token: 0x06000062 RID: 98 RVA: 0x000159B4 File Offset: 0x00013BB4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851336, RefRangeEnd = 851338, XrefRangeStart = 851321, XrefRangeEnd = 851336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayMusic(string audioID, float volume, float delay, float startTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00015A30 File Offset: 0x00013C30
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 851346, RefRangeEnd = 851351, XrefRangeStart = 851338, XrefRangeEnd = 851346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _StopMusic(float fadeOutLength)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOutLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__StopMusic_Protected_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00015A7C File Offset: 0x00013C7C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851359, RefRangeEnd = 851362, XrefRangeStart = 851351, XrefRangeEnd = 851359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _PauseMusic(float fadeOut)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref fadeOut;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PauseMusic_Protected_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00015AC8 File Offset: 0x00013CC8
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851403, RefRangeEnd = 851406, XrefRangeStart = 851362, XrefRangeEnd = 851403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayMusic(string audioID, Vector3 position, Transform parentObj, float volume, float delay, float startTime)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref position;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Vector3_Transform_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00015B64 File Offset: 0x00013D64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851406, XrefRangeEnd = 851413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _EnqueueMusic(string audioID)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__EnqueueMusic_Protected_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00015BB4 File Offset: 0x00013DB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851413, XrefRangeEnd = 851420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayMusicPlaylist()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayMusicPlaylist_Protected_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00015BF4 File Offset: 0x00013DF4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851435, RefRangeEnd = 851437, XrefRangeStart = 851420, XrefRangeEnd = 851435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayMusicTrackWithID(int nextTrack, float delay, bool addToPlayedList)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref nextTrack;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref addToPlayedList;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayMusicTrackWithID_Private_AudioObject_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00015C5C File Offset: 0x00013E5C
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851451, RefRangeEnd = 851454, XrefRangeStart = 851437, XrefRangeEnd = 851451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayNextMusicOnPlaylist(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayNextMusicOnPlaylist_Internal_AudioObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00015CA8 File Offset: 0x00013EA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851454, XrefRangeEnd = 851456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayPreviousMusicOnPlaylist(float delay)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayPreviousMusicOnPlaylist_Internal_AudioObject_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00015CF4 File Offset: 0x00013EF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851456, XrefRangeEnd = 851461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ResetLastPlayedList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ResetLastPlayedList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00015D28 File Offset: 0x00013F28
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851461, XrefRangeEnd = 851471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetNextMusicTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetNextMusicTrack_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00015D64 File Offset: 0x00013F64
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851490, RefRangeEnd = 851491, XrefRangeStart = 851471, XrefRangeEnd = 851490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetPreviousMusicTrack()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetPreviousMusicTrack_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00015DA0 File Offset: 0x00013FA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851491, XrefRangeEnd = 851497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetPreviousMusicTrackShuffled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetPreviousMusicTrackShuffled_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00015DDC File Offset: 0x00013FDC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851506, RefRangeEnd = 851508, XrefRangeStart = 851497, XrefRangeEnd = 851506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RemoveLastPlayedOnList()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__RemoveLastPlayedOnList_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00015E10 File Offset: 0x00014010
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851525, RefRangeEnd = 851526, XrefRangeStart = 851508, XrefRangeEnd = 851525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetNextMusicTrackShuffled()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetNextMusicTrackShuffled_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00015E4C File Offset: 0x0001404C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851526, XrefRangeEnd = 851536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetNextMusicTrackInOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetNextMusicTrackInOrder_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00015E88 File Offset: 0x00014088
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851536, XrefRangeEnd = 851555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetPreviousMusicTrackInOrder()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetPreviousMusicTrackInOrder_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00015EC4 File Offset: 0x000140C4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 851567, RefRangeEnd = 851573, XrefRangeStart = 851555, XrefRangeEnd = 851567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayAsSound(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null, global::Il2CppSystem.Object context = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playWithoutAudioObject;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObject);
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayAsSound_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00015FA4 File Offset: 0x000141A4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851573, XrefRangeEnd = 851574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayAsMusic(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playWithoutAudioObject;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObject);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayAsMusic_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00016070 File Offset: 0x00014270
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851615, RefRangeEnd = 851618, XrefRangeStart = 851574, XrefRangeEnd = 851615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject _PlayEx(string audioID, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, double dspTime = 0.0, AudioObject useExistingAudioObject = null, bool playAsMusic = false, global::Il2CppSystem.Object context = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(audioID);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playWithoutAudioObject;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObject);
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playAsMusic;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__PlayEx_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00016160 File Offset: 0x00014360
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851645, RefRangeEnd = 851647, XrefRangeStart = 851618, XrefRangeEnd = 851645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject PlayAudioItem(AudioItem sndItem, float volume, Vector3 worldPosition, Transform parentObj = null, float delay = 0f, float startTime = 0f, bool playWithoutAudioObject = false, AudioObject useExistingAudioObj = null, double dspTime = 0.0, bool playAsMusic = false, global::Il2CppSystem.Object context = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sndItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playWithoutAudioObject;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObj);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playAsMusic;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayAudioItem_Public_AudioObject_AudioItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00016250 File Offset: 0x00014450
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 851649, RefRangeEnd = 851654, XrefRangeStart = 851647, XrefRangeEnd = 851649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioCategory _GetCategory(string name)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetCategory_Internal_AudioCategory_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr3) : null;
		}
	}

	// Token: 0x06000078 RID: 120 RVA: 0x000162A0 File Offset: 0x000144A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851654, XrefRangeEnd = 851658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000079 RID: 121 RVA: 0x000162D4 File Offset: 0x000144D4
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851674, RefRangeEnd = 851676, XrefRangeStart = 851658, XrefRangeEnd = 851674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static void _UpdateSystemTime()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__UpdateSystemTime_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007A RID: 122 RVA: 0x000162FC File Offset: 0x000144FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851676, XrefRangeEnd = 851680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioController.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00016338 File Offset: 0x00014538
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851680, XrefRangeEnd = 851686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600007C RID: 124 RVA: 0x0001636C File Offset: 0x0001456C
	public unsafe override bool isSingletonObject
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioController.NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000163B4 File Offset: 0x000145B4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851686, XrefRangeEnd = 851690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnDestroy()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioController.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x000163F0 File Offset: 0x000145F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851690, XrefRangeEnd = 851714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00016424 File Offset: 0x00014624
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851750, RefRangeEnd = 851752, XrefRangeStart = 851714, XrefRangeEnd = 851750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AwakeSingleton()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_AwakeSingleton_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00016458 File Offset: 0x00014658
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 851770, RefRangeEnd = 851778, XrefRangeStart = 851752, XrefRangeEnd = 851770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ValidateCategories()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ValidateCategories_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000081 RID: 129 RVA: 0x0001648C File Offset: 0x0001468C
	[CallerCount(0)]
	public unsafe void _InvalidateCategories()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__InvalidateCategories_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000082 RID: 130 RVA: 0x000164C0 File Offset: 0x000146C0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851778, XrefRangeEnd = 851796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void InitializeAudioItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_InitializeAudioItems_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000083 RID: 131 RVA: 0x000164F4 File Offset: 0x000146F4
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 851804, RefRangeEnd = 851808, XrefRangeStart = 851796, XrefRangeEnd = 851804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _InitializeAudioItems(AudioController audioController)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__InitializeAudioItems_Private_Void_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00016538 File Offset: 0x00014738
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851824, RefRangeEnd = 851825, XrefRangeStart = 851808, XrefRangeEnd = 851824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _RegisterAdditionalAudioController(AudioController ac)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ac);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__RegisterAdditionalAudioController_Private_Void_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000085 RID: 133 RVA: 0x0001657C File Offset: 0x0001477C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851825, XrefRangeEnd = 851829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _SyncCategoryVolumes(AudioController toSync, AudioController syncWith)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toSync);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(syncWith);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__SyncCategoryVolumes_Private_Void_AudioController_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000165D0 File Offset: 0x000147D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851829, XrefRangeEnd = 851843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _UnregisterAdditionalAudioController(AudioController ac)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(ac);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__UnregisterAdditionalAudioController_Private_Void_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00016614 File Offset: 0x00014814
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851843, XrefRangeEnd = 851848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<AudioSubItem> _ChooseSubItems(AudioItem audioItem, AudioObject useExistingAudioObj)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSubItem>>(intPtr3) : null;
	}

	// Token: 0x06000088 RID: 136 RVA: 0x0001666C File Offset: 0x0001486C
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 851852, RefRangeEnd = 851854, XrefRangeStart = 851848, XrefRangeEnd = 851852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static AudioSubItem _ChooseSingleSubItem(AudioItem audioItem, AudioPickSubItemMode pickMode, AudioObject useExistingAudioObj)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickMode;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ChooseSingleSubItem_Internal_Static_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioSubItem>(intPtr3) : null;
	}

	// Token: 0x06000089 RID: 137 RVA: 0x000166D0 File Offset: 0x000148D0
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 851884, RefRangeEnd = 851887, XrefRangeStart = 851854, XrefRangeEnd = 851884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static Il2CppReferenceArray<AudioSubItem> _ChooseSubItems(AudioItem audioItem, AudioPickSubItemMode pickMode, AudioObject useExistingAudioObj)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref pickMode;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObj);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSubItem>>(intPtr3) : null;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00016734 File Offset: 0x00014934
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 851887, XrefRangeEnd = 851893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static int _ChooseRandomSubitem(AudioItem audioItem, bool allowSameElementTwiceInRow, int lastChosen, bool switchOddsEvens = false)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowSameElementTwiceInRow;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lastChosen;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref switchOddsEvens;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ChooseRandomSubitem_Private_Static_Int32_AudioItem_Boolean_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600008B RID: 139 RVA: 0x000167A0 File Offset: 0x000149A0
	[CallerCount(0)]
	public unsafe static bool isOdd(int i)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref i;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_isOdd_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600008C RID: 140 RVA: 0x000167E0 File Offset: 0x000149E0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 851989, RefRangeEnd = 851990, XrefRangeStart = 851893, XrefRangeEnd = 851989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioObject PlayAudioSubItem(AudioSubItem subItem, float volume, Vector3 worldPosition, Transform parentObj, float delay, float startTime, bool playWithoutAudioObject, AudioObject useExistingAudioObj, double dspTime = 0.0, bool playAsMusic = false, global::Il2CppSystem.Object context = null)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subItem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref volume;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parentObj);
		ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
		ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startTime;
		ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playWithoutAudioObject;
		ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(useExistingAudioObj);
		ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dspTime;
		ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playAsMusic;
		ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_PlayAudioSubItem_Public_AudioObject_AudioSubItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
	}

	// Token: 0x0600008D RID: 141 RVA: 0x000168D0 File Offset: 0x00014AD0
	[CallerCount(0)]
	public unsafe AudioController _GetAudioController(AudioSubItem subItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__GetAudioController_Private_AudioController_AudioSubItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioController>(intPtr3) : null;
		}
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00016920 File Offset: 0x00014B20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852008, RefRangeEnd = 852009, XrefRangeStart = 851990, XrefRangeEnd = 852008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NotifyPlaylistTrackCompleteleyPlayed(AudioObject audioObject)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioObject);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__NotifyPlaylistTrackCompleteleyPlayed_Internal_Void_AudioObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00016964 File Offset: 0x00014B64
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 852032, RefRangeEnd = 852034, XrefRangeStart = 852009, XrefRangeEnd = 852032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ValidateAudioObjectPrefab(GameObject audioPrefab)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioPrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ValidateAudioObjectPrefab_Private_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x000169A8 File Offset: 0x00014BA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852034, XrefRangeEnd = 852058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x000169E4 File Offset: 0x00014BE4
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852085, RefRangeEnd = 852086, XrefRangeStart = 852058, XrefRangeEnd = 852085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void getResolver()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_getResolver_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00016A18 File Offset: 0x00014C18
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852098, RefRangeEnd = 852099, XrefRangeStart = 852086, XrefRangeEnd = 852098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void resolve(AudioSubItem subitem, global::Il2CppSystem.Object context)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(subitem);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController.NativeMethodInfoPtr_resolve_Private_Void_AudioSubItem_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x000020DE File Offset: 0x000002DE
	public AudioController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00016A6C File Offset: 0x00014C6C
	// (set) Token: 0x06000095 RID: 149 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe static string AUDIO_TOOLKIT_VERSION
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr_AUDIO_TOOLKIT_VERSION, (void*)(&intPtr));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr_AUDIO_TOOLKIT_VERSION, IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000096 RID: 150 RVA: 0x00016A8C File Offset: 0x00014C8C
	// (set) Token: 0x06000097 RID: 151 RVA: 0x000020F9 File Offset: 0x000002F9
	public unsafe GameObject AudioObjectPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_AudioObjectPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_AudioObjectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000098 RID: 152 RVA: 0x00016ABC File Offset: 0x00014CBC
	// (set) Token: 0x06000099 RID: 153 RVA: 0x00002118 File Offset: 0x00000318
	public unsafe bool Persistent
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_Persistent);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_Persistent)) = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600009A RID: 154 RVA: 0x00016AE4 File Offset: 0x00014CE4
	// (set) Token: 0x0600009B RID: 155 RVA: 0x00002133 File Offset: 0x00000333
	public unsafe bool UnloadAudioClipsOnDestroy
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_UnloadAudioClipsOnDestroy);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_UnloadAudioClipsOnDestroy)) = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600009C RID: 156 RVA: 0x00016B0C File Offset: 0x00014D0C
	// (set) Token: 0x0600009D RID: 157 RVA: 0x0000214E File Offset: 0x0000034E
	public unsafe bool UsePooledAudioObjects
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_UsePooledAudioObjects);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_UsePooledAudioObjects)) = value;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600009E RID: 158 RVA: 0x00016B34 File Offset: 0x00014D34
	// (set) Token: 0x0600009F RID: 159 RVA: 0x00002169 File Offset: 0x00000369
	public unsafe bool PlayWithZeroVolume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_PlayWithZeroVolume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_PlayWithZeroVolume)) = value;
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x00016B5C File Offset: 0x00014D5C
	// (set) Token: 0x060000A1 RID: 161 RVA: 0x00002184 File Offset: 0x00000384
	public unsafe bool EqualPowerCrossfade
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_EqualPowerCrossfade);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_EqualPowerCrossfade)) = value;
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x060000A2 RID: 162 RVA: 0x00016B84 File Offset: 0x00014D84
	// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000219F File Offset: 0x0000039F
	public unsafe float musicCrossFadeTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_musicCrossFadeTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_musicCrossFadeTime)) = value;
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x060000A4 RID: 164 RVA: 0x00016BAC File Offset: 0x00014DAC
	// (set) Token: 0x060000A5 RID: 165 RVA: 0x000021BA File Offset: 0x000003BA
	public unsafe bool specifyCrossFadeInAndOutSeperately
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_specifyCrossFadeInAndOutSeperately);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_specifyCrossFadeInAndOutSeperately)) = value;
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00016BD4 File Offset: 0x00014DD4
	// (set) Token: 0x060000A7 RID: 167 RVA: 0x000021D5 File Offset: 0x000003D5
	public unsafe float _musicCrossFadeTime_In
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicCrossFadeTime_In);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicCrossFadeTime_In)) = value;
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00016BFC File Offset: 0x00014DFC
	// (set) Token: 0x060000A9 RID: 169 RVA: 0x000021F0 File Offset: 0x000003F0
	public unsafe float _musicCrossFadeTime_Out
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicCrossFadeTime_Out);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicCrossFadeTime_Out)) = value;
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x060000AA RID: 170 RVA: 0x00016C24 File Offset: 0x00014E24
	// (set) Token: 0x060000AB RID: 171 RVA: 0x0000220B File Offset: 0x0000040B
	public unsafe Il2CppReferenceArray<AudioCategory> AudioCategories
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_AudioCategories);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioCategory>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_AudioCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x060000AC RID: 172 RVA: 0x00016C54 File Offset: 0x00014E54
	// (set) Token: 0x060000AD RID: 173 RVA: 0x0000222A File Offset: 0x0000042A
	public unsafe Il2CppStringArray musicPlaylist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_musicPlaylist);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_musicPlaylist), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x060000AE RID: 174 RVA: 0x00016C84 File Offset: 0x00014E84
	// (set) Token: 0x060000AF RID: 175 RVA: 0x00002249 File Offset: 0x00000449
	public unsafe bool loopPlaylist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_loopPlaylist);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_loopPlaylist)) = value;
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x00016CAC File Offset: 0x00014EAC
	// (set) Token: 0x060000B1 RID: 177 RVA: 0x00002264 File Offset: 0x00000464
	public unsafe bool shufflePlaylist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_shufflePlaylist);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_shufflePlaylist)) = value;
		}
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00016CD4 File Offset: 0x00014ED4
	// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000227F File Offset: 0x0000047F
	public unsafe bool crossfadePlaylist
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_crossfadePlaylist);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_crossfadePlaylist)) = value;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00016CFC File Offset: 0x00014EFC
	// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000229A File Offset: 0x0000049A
	public unsafe float delayBetweenPlaylistTracks
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_delayBetweenPlaylistTracks);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_delayBetweenPlaylistTracks)) = value;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x00016D24 File Offset: 0x00014F24
	// (set) Token: 0x060000B7 RID: 183 RVA: 0x000022B5 File Offset: 0x000004B5
	public unsafe bool logging
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_logging);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_logging)) = value;
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00016D4C File Offset: 0x00014F4C
	// (set) Token: 0x060000B9 RID: 185 RVA: 0x000022D0 File Offset: 0x000004D0
	public unsafe static PoolableReference<AudioObject> _currentMusicReference
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__currentMusicReference, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoolableReference<AudioObject>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__currentMusicReference, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00016D74 File Offset: 0x00014F74
	// (set) Token: 0x060000BB RID: 187 RVA: 0x000022E2 File Offset: 0x000004E2
	public unsafe AudioListener _currentAudioListener
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__currentAudioListener);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioListener>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__currentAudioListener), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00016DA4 File Offset: 0x00014FA4
	// (set) Token: 0x060000BD RID: 189 RVA: 0x00002301 File Offset: 0x00000501
	public unsafe bool _musicEnabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicEnabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__musicEnabled)) = value;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00016DCC File Offset: 0x00014FCC
	// (set) Token: 0x060000BF RID: 191 RVA: 0x0000231C File Offset: 0x0000051C
	public unsafe bool _soundMuted
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__soundMuted);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__soundMuted)) = value;
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x00016DF4 File Offset: 0x00014FF4
	// (set) Token: 0x060000C1 RID: 193 RVA: 0x00002337 File Offset: 0x00000537
	public unsafe bool _categoriesValidated
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__categoriesValidated);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__categoriesValidated)) = value;
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x00016E1C File Offset: 0x0001501C
	// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002352 File Offset: 0x00000552
	public unsafe bool _isAdditionalAudioController
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__isAdditionalAudioController);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__isAdditionalAudioController)) = value;
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x00016E44 File Offset: 0x00015044
	// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000236D File Offset: 0x0000056D
	public unsafe bool _audioDisabled
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__audioDisabled);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__audioDisabled)) = value;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00016E6C File Offset: 0x0001506C
	// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002388 File Offset: 0x00000588
	public unsafe Dictionary<string, AudioItem> _audioItems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__audioItems);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, AudioItem>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__audioItems), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00016E9C File Offset: 0x0001509C
	// (set) Token: 0x060000C9 RID: 201 RVA: 0x000023A7 File Offset: 0x000005A7
	public unsafe static List<int> _playlistPlayed
	{
		get
		{
			IntPtr intPtr;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__playlistPlayed, (void*)(&intPtr));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__playlistPlayed, IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x060000CA RID: 202 RVA: 0x00016EC4 File Offset: 0x000150C4
	// (set) Token: 0x060000CB RID: 203 RVA: 0x000023B9 File Offset: 0x000005B9
	public unsafe static bool _isPlaylistPlaying
	{
		get
		{
			bool flag;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__isPlaylistPlaying, (void*)(&flag));
			return flag;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__isPlaylistPlaying, (void*)(&value));
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000CC RID: 204 RVA: 0x00016EE0 File Offset: 0x000150E0
	// (set) Token: 0x060000CD RID: 205 RVA: 0x000023C7 File Offset: 0x000005C7
	public unsafe float _volume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__volume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__volume)) = value;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000CE RID: 206 RVA: 0x00016F08 File Offset: 0x00015108
	// (set) Token: 0x060000CF RID: 207 RVA: 0x000023E2 File Offset: 0x000005E2
	public unsafe static double _systemTime
	{
		get
		{
			double num;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__systemTime, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__systemTime, (void*)(&value));
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000D0 RID: 208 RVA: 0x00016F24 File Offset: 0x00015124
	// (set) Token: 0x060000D1 RID: 209 RVA: 0x000023F0 File Offset: 0x000005F0
	public unsafe static double _lastSystemTime
	{
		get
		{
			double num;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__lastSystemTime, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__lastSystemTime, (void*)(&value));
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00016F40 File Offset: 0x00015140
	// (set) Token: 0x060000D3 RID: 211 RVA: 0x000023FE File Offset: 0x000005FE
	public unsafe static double _systemDeltaTime
	{
		get
		{
			double num;
			IL2CPP.il2cpp_field_static_get_value(AudioController.NativeFieldInfoPtr__systemDeltaTime, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(AudioController.NativeFieldInfoPtr__systemDeltaTime, (void*)(&value));
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x00016F5C File Offset: 0x0001515C
	// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000240C File Offset: 0x0000060C
	public unsafe List<AudioController> _additionalAudioControllers
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__additionalAudioControllers);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioController>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__additionalAudioControllers), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x00016F8C File Offset: 0x0001518C
	// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000242B File Offset: 0x0000062B
	public unsafe AudioController_CurrentInspectorSelection _currentInspectorSelection
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__currentInspectorSelection);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioController_CurrentInspectorSelection>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr__currentInspectorSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x00016FBC File Offset: 0x000151BC
	// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000244A File Offset: 0x0000064A
	public unsafe IResolver resolver
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_resolver);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResolver>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_resolver), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060000DA RID: 218 RVA: 0x00016FEC File Offset: 0x000151EC
	// (set) Token: 0x060000DB RID: 219 RVA: 0x00002469 File Offset: 0x00000669
	public Nullable<bool> hasResolver
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_hasResolver);
			return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController.NativeFieldInfoPtr_hasResolver), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_AUDIO_TOOLKIT_VERSION;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr_AudioObjectPrefab;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_Persistent;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_UnloadAudioClipsOnDestroy;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_UsePooledAudioObjects;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr_PlayWithZeroVolume;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeFieldInfoPtr_EqualPowerCrossfade;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeFieldInfoPtr_musicCrossFadeTime;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeFieldInfoPtr_specifyCrossFadeInAndOutSeperately;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr__musicCrossFadeTime_In;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeFieldInfoPtr__musicCrossFadeTime_Out;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_AudioCategories;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_musicPlaylist;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr_loopPlaylist;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeFieldInfoPtr_shufflePlaylist;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeFieldInfoPtr_crossfadePlaylist;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeFieldInfoPtr_delayBetweenPlaylistTracks;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeFieldInfoPtr_logging;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeFieldInfoPtr__currentMusicReference;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeFieldInfoPtr__currentAudioListener;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeFieldInfoPtr__musicEnabled;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeFieldInfoPtr__soundMuted;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeFieldInfoPtr__categoriesValidated;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeFieldInfoPtr__isAdditionalAudioController;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeFieldInfoPtr__audioDisabled;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeFieldInfoPtr__audioItems;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeFieldInfoPtr__playlistPlayed;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeFieldInfoPtr__isPlaylistPlaying;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeFieldInfoPtr__volume;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeFieldInfoPtr__systemTime;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeFieldInfoPtr__lastSystemTime;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr__systemDeltaTime;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr__additionalAudioControllers;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr__currentInspectorSelection;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeFieldInfoPtr_resolver;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeFieldInfoPtr_hasResolver;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_set_DisableAudio_Public_set_Void_Boolean_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr_get_DisableAudio_Public_get_Boolean_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr_get_isAdditionalAudioController_Public_get_Boolean_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_set_isAdditionalAudioController_Public_set_Void_Boolean_0;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeMethodInfoPtr_get_musicEnabled_Public_get_Boolean_0;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeMethodInfoPtr_set_musicEnabled_Public_set_Void_Boolean_0;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeMethodInfoPtr_get_soundMuted_Public_get_Boolean_0;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_set_soundMuted_Public_set_Void_Boolean_0;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeMethodInfoPtr_get_musicCrossFadeTime_In_Public_get_Single_0;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_set_musicCrossFadeTime_In_Public_set_Void_Single_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_get_musicCrossFadeTime_Out_Public_get_Single_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_set_musicCrossFadeTime_Out_Public_set_Void_Single_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_get_systemTime_Public_Static_get_Double_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_get_systemDeltaTime_Public_Static_get_Double_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_Single_Single_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Single_0;

	// Token: 0x0400003E RID: 62
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_0;

	// Token: 0x0400003F RID: 63
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusic_Public_Static_AudioObject_String_Transform_Single_Single_Single_0;

	// Token: 0x04000040 RID: 64
	private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_0;

	// Token: 0x04000041 RID: 65
	private static readonly IntPtr NativeMethodInfoPtr_StopMusic_Public_Static_Boolean_Single_0;

	// Token: 0x04000042 RID: 66
	private static readonly IntPtr NativeMethodInfoPtr_PauseMusic_Public_Static_Boolean_Single_0;

	// Token: 0x04000043 RID: 67
	private static readonly IntPtr NativeMethodInfoPtr_IsMusicPaused_Public_Static_Boolean_0;

	// Token: 0x04000044 RID: 68
	private static readonly IntPtr NativeMethodInfoPtr_UnpauseMusic_Public_Static_Boolean_Single_0;

	// Token: 0x04000045 RID: 69
	private static readonly IntPtr NativeMethodInfoPtr_EnqueueMusic_Public_Static_Int32_String_0;

	// Token: 0x04000046 RID: 70
	private static readonly IntPtr NativeMethodInfoPtr_GetMusicPlaylist_Public_Static_Il2CppStringArray_0;

	// Token: 0x04000047 RID: 71
	private static readonly IntPtr NativeMethodInfoPtr_SetMusicPlaylist_Public_Static_Void_Il2CppStringArray_0;

	// Token: 0x04000048 RID: 72
	private static readonly IntPtr NativeMethodInfoPtr_PlayMusicPlaylist_Public_Static_AudioObject_0;

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeMethodInfoPtr_PlayNextMusicOnPlaylist_Public_Static_AudioObject_0;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeMethodInfoPtr_PlayPreviousMusicOnPlaylist_Public_Static_AudioObject_0;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeMethodInfoPtr_IsPlaylistPlaying_Public_Static_Boolean_0;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_ClearPlaylist_Public_Static_Void_0;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Object_0;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Single_Single_Single_0;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Object_0;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_Single_Single_Single_0;

	// Token: 0x04000051 RID: 81
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Object_0;

	// Token: 0x04000052 RID: 82
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_Transform_Single_Single_Single_Object_0;

	// Token: 0x04000053 RID: 83
	private static readonly IntPtr NativeMethodInfoPtr_PlayScheduled_Public_Static_AudioObject_String_Double_Vector3_Transform_Single_Single_0;

	// Token: 0x04000054 RID: 84
	private static readonly IntPtr NativeMethodInfoPtr_PlayAfter_Public_Static_AudioObject_String_AudioObject_Double_Single_Single_0;

	// Token: 0x04000055 RID: 85
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_Single_0;

	// Token: 0x04000056 RID: 86
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Static_Boolean_String_0;

	// Token: 0x04000057 RID: 87
	private static readonly IntPtr NativeMethodInfoPtr_StopAll_Public_Static_Void_Single_0;

	// Token: 0x04000058 RID: 88
	private static readonly IntPtr NativeMethodInfoPtr_StopAll_Public_Static_Void_0;

	// Token: 0x04000059 RID: 89
	private static readonly IntPtr NativeMethodInfoPtr_PauseAll_Public_Static_Void_Single_0;

	// Token: 0x0400005A RID: 90
	private static readonly IntPtr NativeMethodInfoPtr_UnpauseAll_Public_Static_Void_Single_0;

	// Token: 0x0400005B RID: 91
	private static readonly IntPtr NativeMethodInfoPtr_PauseCategory_Public_Static_Void_String_Single_0;

	// Token: 0x0400005C RID: 92
	private static readonly IntPtr NativeMethodInfoPtr_UnpauseCategory_Public_Static_Void_String_Single_0;

	// Token: 0x0400005D RID: 93
	private static readonly IntPtr NativeMethodInfoPtr_StopCategory_Public_Static_Void_String_Single_0;

	// Token: 0x0400005E RID: 94
	private static readonly IntPtr NativeMethodInfoPtr_IsPlaying_Public_Static_Boolean_String_0;

	// Token: 0x0400005F RID: 95
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_String_Boolean_0;

	// Token: 0x04000060 RID: 96
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayingAudioObjectsInCategory_Public_Static_Void_IList_1_AudioObject_String_Boolean_0;

	// Token: 0x04000061 RID: 97
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayingAudioObjects_Public_Static_Void_IList_1_AudioObject_Boolean_0;

	// Token: 0x04000062 RID: 98
	private static readonly IntPtr NativeMethodInfoPtr_GetPlayingAudioObjectsCount_Public_Static_Int32_String_Boolean_0;

	// Token: 0x04000063 RID: 99
	private static readonly IntPtr NativeMethodInfoPtr_EnableMusic_Public_Static_Void_Boolean_0;

	// Token: 0x04000064 RID: 100
	private static readonly IntPtr NativeMethodInfoPtr_MuteSound_Public_Static_Void_Boolean_0;

	// Token: 0x04000065 RID: 101
	private static readonly IntPtr NativeMethodInfoPtr_IsMusicEnabled_Public_Static_Boolean_0;

	// Token: 0x04000066 RID: 102
	private static readonly IntPtr NativeMethodInfoPtr_IsSoundMuted_Public_Static_Boolean_0;

	// Token: 0x04000067 RID: 103
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentAudioListener_Public_Static_AudioListener_0;

	// Token: 0x04000068 RID: 104
	private static readonly IntPtr NativeMethodInfoPtr_GetCurrentMusic_Public_Static_AudioObject_0;

	// Token: 0x04000069 RID: 105
	private static readonly IntPtr NativeMethodInfoPtr_GetCategory_Public_Static_AudioCategory_String_0;

	// Token: 0x0400006A RID: 106
	private static readonly IntPtr NativeMethodInfoPtr_SetCategoryVolume_Public_Static_Void_String_Single_0;

	// Token: 0x0400006B RID: 107
	private static readonly IntPtr NativeMethodInfoPtr_GetCategoryVolume_Public_Static_Single_String_0;

	// Token: 0x0400006C RID: 108
	private static readonly IntPtr NativeMethodInfoPtr_SetGlobalVolume_Public_Static_Void_Single_0;

	// Token: 0x0400006D RID: 109
	private static readonly IntPtr NativeMethodInfoPtr_GetGlobalVolume_Public_Static_Single_0;

	// Token: 0x0400006E RID: 110
	private static readonly IntPtr NativeMethodInfoPtr_NewCategory_Public_Static_AudioCategory_String_0;

	// Token: 0x0400006F RID: 111
	private static readonly IntPtr NativeMethodInfoPtr_RemoveCategory_Public_Static_Void_String_0;

	// Token: 0x04000070 RID: 112
	private static readonly IntPtr NativeMethodInfoPtr_AddToCategory_Public_Static_Void_AudioCategory_AudioItem_0;

	// Token: 0x04000071 RID: 113
	private static readonly IntPtr NativeMethodInfoPtr_AddToCategory_Public_Static_AudioItem_AudioCategory_AudioClip_String_0;

	// Token: 0x04000072 RID: 114
	private static readonly IntPtr NativeMethodInfoPtr_RemoveAudioItem_Public_Static_Boolean_String_0;

	// Token: 0x04000073 RID: 115
	private static readonly IntPtr NativeMethodInfoPtr_IsValidAudioID_Public_Static_Boolean_String_0;

	// Token: 0x04000074 RID: 116
	private static readonly IntPtr NativeMethodInfoPtr_GetAudioItem_Public_Static_AudioItem_String_0;

	// Token: 0x04000075 RID: 117
	private static readonly IntPtr NativeMethodInfoPtr_DetachAllAudios_Public_Static_Void_GameObject_0;

	// Token: 0x04000076 RID: 118
	private static readonly IntPtr NativeMethodInfoPtr_GetAudioItemMaxDistance_Public_Static_Single_String_0;

	// Token: 0x04000077 RID: 119
	private static readonly IntPtr NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_0;

	// Token: 0x04000078 RID: 120
	private static readonly IntPtr NativeMethodInfoPtr_getPlayingClips_Protected_HashSet_1_AudioClip_0;

	// Token: 0x04000079 RID: 121
	private static readonly IntPtr NativeMethodInfoPtr_set__currentMusic_Private_Static_set_Void_AudioObject_0;

	// Token: 0x0400007A RID: 122
	private static readonly IntPtr NativeMethodInfoPtr_get__currentMusic_Private_Static_get_AudioObject_0;

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeMethodInfoPtr__GetAudioItem_Internal_AudioItem_String_0;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Single_Single_Single_0;

	// Token: 0x0400007E RID: 126
	private static readonly IntPtr NativeMethodInfoPtr__StopMusic_Protected_Boolean_Single_0;

	// Token: 0x0400007F RID: 127
	private static readonly IntPtr NativeMethodInfoPtr__PauseMusic_Protected_Boolean_Single_0;

	// Token: 0x04000080 RID: 128
	private static readonly IntPtr NativeMethodInfoPtr__PlayMusic_Protected_AudioObject_String_Vector3_Transform_Single_Single_Single_0;

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeMethodInfoPtr__EnqueueMusic_Protected_Int32_String_0;

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeMethodInfoPtr__PlayMusicPlaylist_Protected_AudioObject_0;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeMethodInfoPtr__PlayMusicTrackWithID_Private_AudioObject_Int32_Single_Boolean_0;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeMethodInfoPtr__PlayNextMusicOnPlaylist_Internal_AudioObject_Single_0;

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeMethodInfoPtr__PlayPreviousMusicOnPlaylist_Internal_AudioObject_Single_0;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeMethodInfoPtr__ResetLastPlayedList_Private_Void_0;

	// Token: 0x04000087 RID: 135
	private static readonly IntPtr NativeMethodInfoPtr__GetNextMusicTrack_Protected_Int32_0;

	// Token: 0x04000088 RID: 136
	private static readonly IntPtr NativeMethodInfoPtr__GetPreviousMusicTrack_Protected_Int32_0;

	// Token: 0x04000089 RID: 137
	private static readonly IntPtr NativeMethodInfoPtr__GetPreviousMusicTrackShuffled_Private_Int32_0;

	// Token: 0x0400008A RID: 138
	private static readonly IntPtr NativeMethodInfoPtr__RemoveLastPlayedOnList_Private_Void_0;

	// Token: 0x0400008B RID: 139
	private static readonly IntPtr NativeMethodInfoPtr__GetNextMusicTrackShuffled_Private_Int32_0;

	// Token: 0x0400008C RID: 140
	private static readonly IntPtr NativeMethodInfoPtr__GetNextMusicTrackInOrder_Private_Int32_0;

	// Token: 0x0400008D RID: 141
	private static readonly IntPtr NativeMethodInfoPtr__GetPreviousMusicTrackInOrder_Private_Int32_0;

	// Token: 0x0400008E RID: 142
	private static readonly IntPtr NativeMethodInfoPtr__PlayAsSound_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Object_0;

	// Token: 0x0400008F RID: 143
	private static readonly IntPtr NativeMethodInfoPtr__PlayAsMusic_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_0;

	// Token: 0x04000090 RID: 144
	private static readonly IntPtr NativeMethodInfoPtr__PlayEx_Protected_AudioObject_String_Single_Vector3_Transform_Single_Single_Boolean_Double_AudioObject_Boolean_Object_0;

	// Token: 0x04000091 RID: 145
	private static readonly IntPtr NativeMethodInfoPtr_PlayAudioItem_Public_AudioObject_AudioItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0;

	// Token: 0x04000092 RID: 146
	private static readonly IntPtr NativeMethodInfoPtr__GetCategory_Internal_AudioCategory_String_0;

	// Token: 0x04000093 RID: 147
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000094 RID: 148
	private static readonly IntPtr NativeMethodInfoPtr__UpdateSystemTime_Private_Static_Void_0;

	// Token: 0x04000095 RID: 149
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

	// Token: 0x04000096 RID: 150
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

	// Token: 0x04000097 RID: 151
	private static readonly IntPtr NativeMethodInfoPtr_get_isSingletonObject_Public_Virtual_get_Boolean_0;

	// Token: 0x04000098 RID: 152
	private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

	// Token: 0x04000099 RID: 153
	private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

	// Token: 0x0400009A RID: 154
	private static readonly IntPtr NativeMethodInfoPtr_AwakeSingleton_Private_Void_0;

	// Token: 0x0400009B RID: 155
	private static readonly IntPtr NativeMethodInfoPtr__ValidateCategories_Protected_Void_0;

	// Token: 0x0400009C RID: 156
	private static readonly IntPtr NativeMethodInfoPtr__InvalidateCategories_Protected_Void_0;

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeMethodInfoPtr_InitializeAudioItems_Public_Void_0;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeMethodInfoPtr__InitializeAudioItems_Private_Void_AudioController_0;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeMethodInfoPtr__RegisterAdditionalAudioController_Private_Void_AudioController_0;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr__SyncCategoryVolumes_Private_Void_AudioController_AudioController_0;

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeMethodInfoPtr__UnregisterAdditionalAudioController_Private_Void_AudioController_0;

	// Token: 0x040000A2 RID: 162
	private static readonly IntPtr NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioObject_0;

	// Token: 0x040000A3 RID: 163
	private static readonly IntPtr NativeMethodInfoPtr__ChooseSingleSubItem_Internal_Static_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0;

	// Token: 0x040000A4 RID: 164
	private static readonly IntPtr NativeMethodInfoPtr__ChooseSubItems_Protected_Static_Il2CppReferenceArray_1_AudioSubItem_AudioItem_AudioPickSubItemMode_AudioObject_0;

	// Token: 0x040000A5 RID: 165
	private static readonly IntPtr NativeMethodInfoPtr__ChooseRandomSubitem_Private_Static_Int32_AudioItem_Boolean_Int32_Boolean_0;

	// Token: 0x040000A6 RID: 166
	private static readonly IntPtr NativeMethodInfoPtr_isOdd_Private_Static_Boolean_Int32_0;

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeMethodInfoPtr_PlayAudioSubItem_Public_AudioObject_AudioSubItem_Single_Vector3_Transform_Single_Single_Boolean_AudioObject_Double_Boolean_Object_0;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeMethodInfoPtr__GetAudioController_Private_AudioController_AudioSubItem_0;

	// Token: 0x040000A9 RID: 169
	private static readonly IntPtr NativeMethodInfoPtr__NotifyPlaylistTrackCompleteleyPlayed_Internal_Void_AudioObject_0;

	// Token: 0x040000AA RID: 170
	private static readonly IntPtr NativeMethodInfoPtr__ValidateAudioObjectPrefab_Private_Void_GameObject_0;

	// Token: 0x040000AB RID: 171
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x040000AC RID: 172
	private static readonly IntPtr NativeMethodInfoPtr_getResolver_Private_Void_0;

	// Token: 0x040000AD RID: 173
	private static readonly IntPtr NativeMethodInfoPtr_resolve_Private_Void_AudioSubItem_Object_0;
}
