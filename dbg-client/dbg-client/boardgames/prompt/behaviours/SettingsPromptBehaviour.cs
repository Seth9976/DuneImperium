using System;
using boardgames.prompts;
using boardgames.utils;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using zen.analytics;

namespace boardgames.prompt.behaviours
{
	// Token: 0x02000104 RID: 260
	public class SettingsPromptBehaviour : TabulatedPromptBehavior<SettingsPrompt>
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x00040E14 File Offset: 0x0003F014
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsPromptBehaviour()
		{
			Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.prompt.behaviours", "SettingsPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr);
			SettingsPromptBehaviour.NativeFieldInfoPtr_screenChangeSettingConfirmedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "screenChangeSettingConfirmedEvent");
			SettingsPromptBehaviour.NativeFieldInfoPtr_resolutionDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "resolutionDropdown");
			SettingsPromptBehaviour.NativeFieldInfoPtr_qualityDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "qualityDropdown");
			SettingsPromptBehaviour.NativeFieldInfoPtr_windowedToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "windowedToggle");
			SettingsPromptBehaviour.NativeFieldInfoPtr_vsyncToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "vsyncToggle");
			SettingsPromptBehaviour.NativeFieldInfoPtr_uiScaleDropdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "uiScaleDropdown");
			SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "musicVolume");
			SettingsPromptBehaviour.NativeFieldInfoPtr_effectsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "effectsVolume");
			SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "masterVolume");
			SettingsPromptBehaviour.NativeFieldInfoPtr_muteToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "muteToggle");
			SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "gamepadSupportEnabledToggle");
			SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggleGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "gamepadSupportEnabledToggleGameObject");
			SettingsPromptBehaviour.NativeFieldInfoPtr_restorePurchasesButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "restorePurchasesButton");
			SettingsPromptBehaviour.NativeFieldInfoPtr_resignButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "resignButton");
			SettingsPromptBehaviour.NativeFieldInfoPtr_saveAndExitButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "saveAndExitButton");
			SettingsPromptBehaviour.NativeFieldInfoPtr_leaveObserverButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "leaveObserverButton");
			SettingsPromptBehaviour.NativeFieldInfoPtr_restartChallengeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "restartChallengeButton");
			SettingsPromptBehaviour.NativeFieldInfoPtr_audioController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "audioController");
			SettingsPromptBehaviour.NativeFieldInfoPtr_analyticsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "analyticsManager");
			SettingsPromptBehaviour.NativeFieldInfoPtr_gameInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "gameInit");
			SettingsPromptBehaviour.NativeFieldInfoPtr_resolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "resolutions");
			SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolumeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "musicVolumeChanged");
			SettingsPromptBehaviour.NativeFieldInfoPtr_sfxVolumeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "sfxVolumeChanged");
			SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolumeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "masterVolumeChanged");
			SettingsPromptBehaviour.NativeFieldInfoPtr_qualityLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "qualityLevels");
			SettingsPromptBehaviour.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664923);
			SettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664924);
			SettingsPromptBehaviour.NativeMethodInfoPtr_GetUIScaleOptions_Protected_Virtual_New_IReadOnlyList_1_UIScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664925);
			SettingsPromptBehaviour.NativeMethodInfoPtr_restoreAudioSlider_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664926);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MusicVolumeChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664927);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SFXVolumeChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664928);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MasterVolumeChanged_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664929);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MuteVolume_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664930);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SetControllerSupportActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664931);
			SettingsPromptBehaviour.NativeMethodInfoPtr_UpdateResolutionOptions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664932);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_WindowToggled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664933);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_VSyncEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664934);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ResolutionChanged_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664935);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_QualityChanged_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664936);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShaderQualityChanged_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664937);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_UIScaleChanged_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664938);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ResignGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664939);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_HotkeysInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664940);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_GamepadInfo_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664941);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_Restart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664942);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SaveAndExitGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664943);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664944);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664945);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_AccountAndLogin_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664946);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShowEula_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664947);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_RedeemCode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664948);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664949);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Event_RestorePurchases_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664950);
			SettingsPromptBehaviour.NativeMethodInfoPtr_Handle_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664951);
			SettingsPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664952);
			SettingsPromptBehaviour.NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664953);
			SettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664954);
			SettingsPromptBehaviour.NativeMethodInfoPtr__Event_RestorePurchases_b__53_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, 100664955);
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x000412CC File Offset: 0x0003F4CC
		public unsafe override int StartingTabIndex
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507947, XrefRangeEnd = 507950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsPromptBehaviour.NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00041314 File Offset: 0x0003F514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507950, XrefRangeEnd = 508146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00041350 File Offset: 0x0003F550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508146, XrefRangeEnd = 508150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IReadOnlyList<DBGConstants.UIScale> GetUIScaleOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsPromptBehaviour.NativeMethodInfoPtr_GetUIScaleOptions_Protected_Virtual_New_IReadOnlyList_1_UIScale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<DBGConstants.UIScale>>(intPtr3) : null;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x0004139C File Offset: 0x0003F59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508150, XrefRangeEnd = 508155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator restoreAudioSlider()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_restoreAudioSlider_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000413DC File Offset: 0x0003F5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508155, XrefRangeEnd = 508157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MusicVolumeChanged(float newVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MusicVolumeChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x0004141C File Offset: 0x0003F61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508157, XrefRangeEnd = 508159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SFXVolumeChanged(float newVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SFXVolumeChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x0004145C File Offset: 0x0003F65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508159, XrefRangeEnd = 508161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MasterVolumeChanged(float newVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MasterVolumeChanged_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x0004149C File Offset: 0x0003F69C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508161, XrefRangeEnd = 508178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_MuteVolume(bool mute)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mute;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_MuteVolume_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x000414DC File Offset: 0x0003F6DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508178, XrefRangeEnd = 508189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SetControllerSupportActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref active;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SetControllerSupportActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x0004151C File Offset: 0x0003F71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 508311, RefRangeEnd = 508312, XrefRangeStart = 508189, XrefRangeEnd = 508311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateResolutionOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_UpdateResolutionOptions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00041550 File Offset: 0x0003F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508312, XrefRangeEnd = 508336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_WindowToggled(bool isWindowed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isWindowed;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_WindowToggled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00041590 File Offset: 0x0003F790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508336, XrefRangeEnd = 508351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_VSyncEnabled(bool vSyncEnabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref vSyncEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_VSyncEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x000415D0 File Offset: 0x0003F7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508351, XrefRangeEnd = 508374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResolutionChanged(int resolutionOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resolutionOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ResolutionChanged_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00041610 File Offset: 0x0003F810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508374, XrefRangeEnd = 508410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Event_QualityChanged(int qualityOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref qualityOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsPromptBehaviour.NativeMethodInfoPtr_Event_QualityChanged_Public_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0004165C File Offset: 0x0003F85C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508410, XrefRangeEnd = 508422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShaderQualityChanged(int qualityOption)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref qualityOption;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShaderQualityChanged_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x0004169C File Offset: 0x0003F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508422, XrefRangeEnd = 508451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_UIScaleChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_UIScaleChanged_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x000416D0 File Offset: 0x0003F8D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508451, XrefRangeEnd = 508454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ResignGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ResignGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00041704 File Offset: 0x0003F904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508454, XrefRangeEnd = 508457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HotkeysInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_HotkeysInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00041738 File Offset: 0x0003F938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508457, XrefRangeEnd = 508460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_GamepadInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_GamepadInfo_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x0004176C File Offset: 0x0003F96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508460, XrefRangeEnd = 508463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Restart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_Restart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000417A0 File Offset: 0x0003F9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508463, XrefRangeEnd = 508466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SaveAndExitGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SaveAndExitGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000417D4 File Offset: 0x0003F9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508466, XrefRangeEnd = 508474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_SendFeedback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00041808 File Offset: 0x0003FA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508474, XrefRangeEnd = 508482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowRules()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShowRules_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0004183C File Offset: 0x0003FA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508482, XrefRangeEnd = 508485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_AccountAndLogin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_AccountAndLogin_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00041870 File Offset: 0x0003FA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508485, XrefRangeEnd = 508493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ShowEula()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_ShowEula_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000418A4 File Offset: 0x0003FAA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508493, XrefRangeEnd = 508496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RedeemCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_RedeemCode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000418D8 File Offset: 0x0003FAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508496, XrefRangeEnd = 508499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x0004190C File Offset: 0x0003FB0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508499, XrefRangeEnd = 508546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RestorePurchases()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Event_RestorePurchases_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00041940 File Offset: 0x0003FB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508546, XrefRangeEnd = 508548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Handle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_Handle_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00041974 File Offset: 0x0003FB74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508548, XrefRangeEnd = 508563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000419A8 File Offset: 0x0003FBA8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 508578, RefRangeEnd = 508592, XrefRangeStart = 508563, XrefRangeEnd = 508578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void logAnalyticsMessage(string optionName, string valueName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(optionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(valueName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000419FC File Offset: 0x0003FBFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508592, XrefRangeEnd = 508607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00041A38 File Offset: 0x0003FC38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 508607, XrefRangeEnd = 508612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Event_RestorePurchases_b__53_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.NativeMethodInfoPtr__Event_RestorePurchases_b__53_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00007500 File Offset: 0x00005700
		public SettingsPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000B4E RID: 2894 RVA: 0x00041A6C File Offset: 0x0003FC6C
		// (set) Token: 0x06000B4F RID: 2895 RVA: 0x00007509 File Offset: 0x00005709
		public unsafe UnityEvent screenChangeSettingConfirmedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_screenChangeSettingConfirmedEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_screenChangeSettingConfirmedEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x00041A9C File Offset: 0x0003FC9C
		// (set) Token: 0x06000B51 RID: 2897 RVA: 0x00007528 File Offset: 0x00005728
		public unsafe TMP_Dropdown resolutionDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resolutionDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resolutionDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000B52 RID: 2898 RVA: 0x00041ACC File Offset: 0x0003FCCC
		// (set) Token: 0x06000B53 RID: 2899 RVA: 0x00007547 File Offset: 0x00005747
		public unsafe TMP_Dropdown qualityDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_qualityDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_qualityDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000B54 RID: 2900 RVA: 0x00041AFC File Offset: 0x0003FCFC
		// (set) Token: 0x06000B55 RID: 2901 RVA: 0x00007566 File Offset: 0x00005766
		public unsafe Toggle windowedToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_windowedToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_windowedToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000B56 RID: 2902 RVA: 0x00041B2C File Offset: 0x0003FD2C
		// (set) Token: 0x06000B57 RID: 2903 RVA: 0x00007585 File Offset: 0x00005785
		public unsafe Toggle vsyncToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_vsyncToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_vsyncToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000B58 RID: 2904 RVA: 0x00041B5C File Offset: 0x0003FD5C
		// (set) Token: 0x06000B59 RID: 2905 RVA: 0x000075A4 File Offset: 0x000057A4
		public unsafe TMP_Dropdown uiScaleDropdown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_uiScaleDropdown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Dropdown>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_uiScaleDropdown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000B5A RID: 2906 RVA: 0x00041B8C File Offset: 0x0003FD8C
		// (set) Token: 0x06000B5B RID: 2907 RVA: 0x000075C3 File Offset: 0x000057C3
		public unsafe Slider musicVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x00041BBC File Offset: 0x0003FDBC
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x000075E2 File Offset: 0x000057E2
		public unsafe Slider effectsVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_effectsVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_effectsVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x00041BEC File Offset: 0x0003FDEC
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x00007601 File Offset: 0x00005801
		public unsafe Slider masterVolume
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolume);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolume), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00041C1C File Offset: 0x0003FE1C
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x00007620 File Offset: 0x00005820
		public unsafe Toggle muteToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_muteToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_muteToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00041C4C File Offset: 0x0003FE4C
		// (set) Token: 0x06000B63 RID: 2915 RVA: 0x0000763F File Offset: 0x0000583F
		public unsafe Toggle gamepadSupportEnabledToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000B64 RID: 2916 RVA: 0x00041C7C File Offset: 0x0003FE7C
		// (set) Token: 0x06000B65 RID: 2917 RVA: 0x0000765E File Offset: 0x0000585E
		public unsafe GameObject gamepadSupportEnabledToggleGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggleGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gamepadSupportEnabledToggleGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000B66 RID: 2918 RVA: 0x00041CAC File Offset: 0x0003FEAC
		// (set) Token: 0x06000B67 RID: 2919 RVA: 0x0000767D File Offset: 0x0000587D
		public unsafe Button restorePurchasesButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_restorePurchasesButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_restorePurchasesButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000B68 RID: 2920 RVA: 0x00041CDC File Offset: 0x0003FEDC
		// (set) Token: 0x06000B69 RID: 2921 RVA: 0x0000769C File Offset: 0x0000589C
		public unsafe GameObject resignButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resignButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resignButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x00041D0C File Offset: 0x0003FF0C
		// (set) Token: 0x06000B6B RID: 2923 RVA: 0x000076BB File Offset: 0x000058BB
		public unsafe GameObject saveAndExitButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_saveAndExitButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_saveAndExitButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000B6C RID: 2924 RVA: 0x00041D3C File Offset: 0x0003FF3C
		// (set) Token: 0x06000B6D RID: 2925 RVA: 0x000076DA File Offset: 0x000058DA
		public unsafe GameObject leaveObserverButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_leaveObserverButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_leaveObserverButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000B6E RID: 2926 RVA: 0x00041D6C File Offset: 0x0003FF6C
		// (set) Token: 0x06000B6F RID: 2927 RVA: 0x000076F9 File Offset: 0x000058F9
		public unsafe GameObject restartChallengeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_restartChallengeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_restartChallengeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000B70 RID: 2928 RVA: 0x00041D9C File Offset: 0x0003FF9C
		// (set) Token: 0x06000B71 RID: 2929 RVA: 0x00007718 File Offset: 0x00005918
		public unsafe LotusAudioController audioController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_audioController);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LotusAudioController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_audioController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000B72 RID: 2930 RVA: 0x00041DCC File Offset: 0x0003FFCC
		// (set) Token: 0x06000B73 RID: 2931 RVA: 0x00007737 File Offset: 0x00005937
		public unsafe AnalyticsManager analyticsManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_analyticsManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnalyticsManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_analyticsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000B74 RID: 2932 RVA: 0x00041DFC File Offset: 0x0003FFFC
		// (set) Token: 0x06000B75 RID: 2933 RVA: 0x00007756 File Offset: 0x00005956
		public unsafe GameInit gameInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gameInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_gameInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x00041E2C File Offset: 0x0004002C
		// (set) Token: 0x06000B77 RID: 2935 RVA: 0x00007775 File Offset: 0x00005975
		public unsafe List<ScreenResolution> resolutions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resolutions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ScreenResolution>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_resolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x00041E5C File Offset: 0x0004005C
		// (set) Token: 0x06000B79 RID: 2937 RVA: 0x00007794 File Offset: 0x00005994
		public unsafe bool musicVolumeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolumeChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_musicVolumeChanged)) = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x00041E84 File Offset: 0x00040084
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x000077AF File Offset: 0x000059AF
		public unsafe bool sfxVolumeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_sfxVolumeChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_sfxVolumeChanged)) = value;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x00041EAC File Offset: 0x000400AC
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x000077CA File Offset: 0x000059CA
		public unsafe bool masterVolumeChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolumeChanged);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_masterVolumeChanged)) = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x00041ED4 File Offset: 0x000400D4
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x000077E5 File Offset: 0x000059E5
		public unsafe List<ValueTuple<int, string>> qualityLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_qualityLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<int, string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.NativeFieldInfoPtr_qualityLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006DD RID: 1757
		private static readonly IntPtr NativeFieldInfoPtr_screenChangeSettingConfirmedEvent;

		// Token: 0x040006DE RID: 1758
		private static readonly IntPtr NativeFieldInfoPtr_resolutionDropdown;

		// Token: 0x040006DF RID: 1759
		private static readonly IntPtr NativeFieldInfoPtr_qualityDropdown;

		// Token: 0x040006E0 RID: 1760
		private static readonly IntPtr NativeFieldInfoPtr_windowedToggle;

		// Token: 0x040006E1 RID: 1761
		private static readonly IntPtr NativeFieldInfoPtr_vsyncToggle;

		// Token: 0x040006E2 RID: 1762
		private static readonly IntPtr NativeFieldInfoPtr_uiScaleDropdown;

		// Token: 0x040006E3 RID: 1763
		private static readonly IntPtr NativeFieldInfoPtr_musicVolume;

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr_effectsVolume;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr_masterVolume;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeFieldInfoPtr_muteToggle;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeFieldInfoPtr_gamepadSupportEnabledToggle;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeFieldInfoPtr_gamepadSupportEnabledToggleGameObject;

		// Token: 0x040006E9 RID: 1769
		private static readonly IntPtr NativeFieldInfoPtr_restorePurchasesButton;

		// Token: 0x040006EA RID: 1770
		private static readonly IntPtr NativeFieldInfoPtr_resignButton;

		// Token: 0x040006EB RID: 1771
		private static readonly IntPtr NativeFieldInfoPtr_saveAndExitButton;

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_leaveObserverButton;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr_restartChallengeButton;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr_audioController;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr_analyticsManager;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr_gameInit;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr_resolutions;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr_musicVolumeChanged;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr_sfxVolumeChanged;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr_masterVolumeChanged;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr_qualityLevels;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeMethodInfoPtr_get_StartingTabIndex_Protected_Virtual_get_Int32_0;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeMethodInfoPtr_GetUIScaleOptions_Protected_Virtual_New_IReadOnlyList_1_UIScale_0;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeMethodInfoPtr_restoreAudioSlider_Private_IEnumerator_0;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeMethodInfoPtr_Event_MusicVolumeChanged_Public_Void_Single_0;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeMethodInfoPtr_Event_SFXVolumeChanged_Public_Void_Single_0;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeMethodInfoPtr_Event_MasterVolumeChanged_Public_Void_Single_0;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr_Event_MuteVolume_Public_Void_Boolean_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_Event_SetControllerSupportActive_Public_Void_Boolean_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_UpdateResolutionOptions_Private_Void_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_Event_WindowToggled_Public_Void_Boolean_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_Event_VSyncEnabled_Public_Void_Boolean_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResolutionChanged_Public_Void_Int32_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_Event_QualityChanged_Public_Virtual_New_Void_Int32_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShaderQualityChanged_Public_Void_Int32_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_Event_UIScaleChanged_Public_Void_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_Event_ResignGame_Public_Void_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_Event_HotkeysInfo_Public_Void_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_Event_GamepadInfo_Public_Void_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_Event_Restart_Public_Void_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_Event_SaveAndExitGame_Public_Void_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_Event_SendFeedback_Public_Void_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowRules_Public_Void_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_Event_AccountAndLogin_Public_Void_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_Event_ShowEula_Public_Void_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_Event_RedeemCode_Public_Void_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_Event_Back_Public_Void_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_Event_RestorePurchases_Public_Void_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_Handle_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_logAnalyticsMessage_Private_Void_String_String_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr__Event_RestorePurchases_b__53_0_Private_Void_0;

		// Token: 0x02000340 RID: 832
		[ObfuscatedName("boardgames.prompt.behaviours.SettingsPromptBehaviour+<>c")]
		[Serializable]
		public new sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600275E RID: 10078 RVA: 0x0009E388 File Offset: 0x0009C588
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr);
				SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, "<>9");
				SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, "<>9__27_0");
				SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, "<>9__27_2");
				SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, "<>9__35_0");
				SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, "<>9__35_1");
				SettingsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, 100664957);
				SettingsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__27_0_Internal_String_ValueTuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, 100664958);
				SettingsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__27_2_Internal_String_UIScale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, 100664959);
				SettingsPromptBehaviour.__c.NativeMethodInfoPtr__UpdateResolutionOptions_b__35_0_Internal_Boolean_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, 100664960);
				SettingsPromptBehaviour.__c.NativeMethodInfoPtr__UpdateResolutionOptions_b__35_1_Internal_Int32_ScreenResolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr, 100664961);
			}

			// Token: 0x0600275F RID: 10079 RVA: 0x0009E47C File Offset: 0x0009C67C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPromptBehaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002760 RID: 10080 RVA: 0x0009E4B8 File Offset: 0x0009C6B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507899, XrefRangeEnd = 507906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _initialize_b__27_0(ValueTuple<int, string> quality)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(quality));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__27_0_Internal_String_ValueTuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002761 RID: 10081 RVA: 0x0009E508 File Offset: 0x0009C708
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507906, XrefRangeEnd = 507916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _initialize_b__27_2(DBGConstants.UIScale s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref s;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c.NativeMethodInfoPtr__initialize_b__27_2_Internal_String_UIScale_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x0009E54C File Offset: 0x0009C74C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507916, XrefRangeEnd = 507920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _UpdateResolutionOptions_b__35_0(ScreenResolution resolution)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref resolution;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c.NativeMethodInfoPtr__UpdateResolutionOptions_b__35_0_Internal_Boolean_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002763 RID: 10083 RVA: 0x0009E598 File Offset: 0x0009C798
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 507920, RefRangeEnd = 507929, XrefRangeStart = 507920, XrefRangeEnd = 507920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _UpdateResolutionOptions_b__35_1(ScreenResolution r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref r;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c.NativeMethodInfoPtr__UpdateResolutionOptions_b__35_1_Internal_Int32_ScreenResolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002764 RID: 10084 RVA: 0x000146E9 File Offset: 0x000128E9
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AFB RID: 2811
			// (get) Token: 0x06002765 RID: 10085 RVA: 0x0009E5E4 File Offset: 0x0009C7E4
			// (set) Token: 0x06002766 RID: 10086 RVA: 0x000146F2 File Offset: 0x000128F2
			public unsafe static SettingsPromptBehaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsPromptBehaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFC RID: 2812
			// (get) Token: 0x06002767 RID: 10087 RVA: 0x0009E60C File Offset: 0x0009C80C
			// (set) Token: 0x06002768 RID: 10088 RVA: 0x00014704 File Offset: 0x00012904
			public unsafe static Func<ValueTuple<int, string>, string> __9__27_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, string>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFD RID: 2813
			// (get) Token: 0x06002769 RID: 10089 RVA: 0x0009E634 File Offset: 0x0009C834
			// (set) Token: 0x0600276A RID: 10090 RVA: 0x00014716 File Offset: 0x00012916
			public unsafe static Func<DBGConstants.UIScale, string> __9__27_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DBGConstants.UIScale, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__27_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFE RID: 2814
			// (get) Token: 0x0600276B RID: 10091 RVA: 0x0009E65C File Offset: 0x0009C85C
			// (set) Token: 0x0600276C RID: 10092 RVA: 0x00014728 File Offset: 0x00012928
			public unsafe static Func<ScreenResolution, bool> __9__35_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ScreenResolution, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000AFF RID: 2815
			// (get) Token: 0x0600276D RID: 10093 RVA: 0x0009E684 File Offset: 0x0009C884
			// (set) Token: 0x0600276E RID: 10094 RVA: 0x0001473A File Offset: 0x0001293A
			public unsafe static Func<ScreenResolution, int> __9__35_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ScreenResolution, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SettingsPromptBehaviour.__c.NativeFieldInfoPtr___9__35_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018B2 RID: 6322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040018B3 RID: 6323
			private static readonly IntPtr NativeFieldInfoPtr___9__27_0;

			// Token: 0x040018B4 RID: 6324
			private static readonly IntPtr NativeFieldInfoPtr___9__27_2;

			// Token: 0x040018B5 RID: 6325
			private static readonly IntPtr NativeFieldInfoPtr___9__35_0;

			// Token: 0x040018B6 RID: 6326
			private static readonly IntPtr NativeFieldInfoPtr___9__35_1;

			// Token: 0x040018B7 RID: 6327
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018B8 RID: 6328
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__27_0_Internal_String_ValueTuple_2_Int32_String_0;

			// Token: 0x040018B9 RID: 6329
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__27_2_Internal_String_UIScale_0;

			// Token: 0x040018BA RID: 6330
			private static readonly IntPtr NativeMethodInfoPtr__UpdateResolutionOptions_b__35_0_Internal_Boolean_ScreenResolution_0;

			// Token: 0x040018BB RID: 6331
			private static readonly IntPtr NativeMethodInfoPtr__UpdateResolutionOptions_b__35_1_Internal_Int32_ScreenResolution_0;
		}

		// Token: 0x02000341 RID: 833
		[ObfuscatedName("boardgames.prompt.behaviours.SettingsPromptBehaviour+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : global::Il2CppSystem.Object
		{
			// Token: 0x0600276F RID: 10095 RVA: 0x0009E6AC File Offset: 0x0009C8AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr);
				SettingsPromptBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_qualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr, "qualityLevel");
				SettingsPromptBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100664962);
				SettingsPromptBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_ValueTuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr, 100664963);
			}

			// Token: 0x06002770 RID: 10096 RVA: 0x0009E714 File Offset: 0x0009C914
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002771 RID: 10097 RVA: 0x0009E750 File Offset: 0x0009C950
			[CallerCount(0)]
			public unsafe bool _initialize_b__1(ValueTuple<int, string> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c__DisplayClass27_0.NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_ValueTuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002772 RID: 10098 RVA: 0x0001474C File Offset: 0x0001294C
			public __c__DisplayClass27_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B00 RID: 2816
			// (get) Token: 0x06002773 RID: 10099 RVA: 0x0009E7A4 File Offset: 0x0009C9A4
			// (set) Token: 0x06002774 RID: 10100 RVA: 0x00014755 File Offset: 0x00012955
			public unsafe int qualityLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_qualityLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.__c__DisplayClass27_0.NativeFieldInfoPtr_qualityLevel)) = value;
				}
			}

			// Token: 0x040018BC RID: 6332
			private static readonly IntPtr NativeFieldInfoPtr_qualityLevel;

			// Token: 0x040018BD RID: 6333
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018BE RID: 6334
			private static readonly IntPtr NativeMethodInfoPtr__initialize_b__1_Internal_Boolean_ValueTuple_2_Int32_String_0;
		}

		// Token: 0x02000342 RID: 834
		[ObfuscatedName("boardgames.prompt.behaviours.SettingsPromptBehaviour+<>c__DisplayClass39_0")]
		public sealed class __c__DisplayClass39_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06002775 RID: 10101 RVA: 0x0009E7CC File Offset: 0x0009C9CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass39_0()
			{
				Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "<>c__DisplayClass39_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr);
				SettingsPromptBehaviour.__c__DisplayClass39_0.NativeFieldInfoPtr_currentQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr, "currentQuality");
				SettingsPromptBehaviour.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr, 100664964);
				SettingsPromptBehaviour.__c__DisplayClass39_0.NativeMethodInfoPtr__Event_QualityChanged_b__0_Internal_Boolean_ValueTuple_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr, 100664965);
			}

			// Token: 0x06002776 RID: 10102 RVA: 0x0009E834 File Offset: 0x0009CA34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass39_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPromptBehaviour.__c__DisplayClass39_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c__DisplayClass39_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002777 RID: 10103 RVA: 0x0009E870 File Offset: 0x0009CA70
			[CallerCount(0)]
			public unsafe bool _Event_QualityChanged_b__0(ValueTuple<int, string> l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(l));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour.__c__DisplayClass39_0.NativeMethodInfoPtr__Event_QualityChanged_b__0_Internal_Boolean_ValueTuple_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002778 RID: 10104 RVA: 0x00014770 File Offset: 0x00012970
			public __c__DisplayClass39_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B01 RID: 2817
			// (get) Token: 0x06002779 RID: 10105 RVA: 0x0009E8C4 File Offset: 0x0009CAC4
			// (set) Token: 0x0600277A RID: 10106 RVA: 0x00014779 File Offset: 0x00012979
			public unsafe int currentQuality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.__c__DisplayClass39_0.NativeFieldInfoPtr_currentQuality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour.__c__DisplayClass39_0.NativeFieldInfoPtr_currentQuality)) = value;
				}
			}

			// Token: 0x040018BF RID: 6335
			private static readonly IntPtr NativeFieldInfoPtr_currentQuality;

			// Token: 0x040018C0 RID: 6336
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040018C1 RID: 6337
			private static readonly IntPtr NativeMethodInfoPtr__Event_QualityChanged_b__0_Internal_Boolean_ValueTuple_2_Int32_String_0;
		}

		// Token: 0x02000343 RID: 835
		[ObfuscatedName("boardgames.prompt.behaviours.SettingsPromptBehaviour+<restoreAudioSlider>d__29")]
		public sealed class _restoreAudioSlider_d__29 : global::Il2CppSystem.Object
		{
			// Token: 0x0600277B RID: 10107 RVA: 0x0009E8EC File Offset: 0x0009CAEC
			// Note: this type is marked as 'beforefieldinit'.
			static _restoreAudioSlider_d__29()
			{
				Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SettingsPromptBehaviour>.NativeClassPtr, "<restoreAudioSlider>d__29");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, "<>1__state");
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, "<>2__current");
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, "<>4__this");
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664966);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664967);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664968);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664969);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664970);
				SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr, 100664971);
			}

			// Token: 0x0600277C RID: 10108 RVA: 0x0009E9CC File Offset: 0x0009CBCC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _restoreAudioSlider_d__29(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsPromptBehaviour._restoreAudioSlider_d__29>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600277D RID: 10109 RVA: 0x0009EA14 File Offset: 0x0009CC14
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600277E RID: 10110 RVA: 0x0009EA48 File Offset: 0x0009CC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507929, XrefRangeEnd = 507942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B05 RID: 2821
			// (get) Token: 0x0600277F RID: 10111 RVA: 0x0009EA84 File Offset: 0x0009CC84
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002780 RID: 10112 RVA: 0x0009EAC4 File Offset: 0x0009CCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 507942, XrefRangeEnd = 507947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B06 RID: 2822
			// (get) Token: 0x06002781 RID: 10113 RVA: 0x0009EAF8 File Offset: 0x0009CCF8
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002782 RID: 10114 RVA: 0x00014794 File Offset: 0x00012994
			public _restoreAudioSlider_d__29(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B02 RID: 2818
			// (get) Token: 0x06002783 RID: 10115 RVA: 0x0009EB38 File Offset: 0x0009CD38
			// (set) Token: 0x06002784 RID: 10116 RVA: 0x0001479D File Offset: 0x0001299D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B03 RID: 2819
			// (get) Token: 0x06002785 RID: 10117 RVA: 0x0009EB60 File Offset: 0x0009CD60
			// (set) Token: 0x06002786 RID: 10118 RVA: 0x000147B8 File Offset: 0x000129B8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B04 RID: 2820
			// (get) Token: 0x06002787 RID: 10119 RVA: 0x0009EB90 File Offset: 0x0009CD90
			// (set) Token: 0x06002788 RID: 10120 RVA: 0x000147D7 File Offset: 0x000129D7
			public unsafe SettingsPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SettingsPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsPromptBehaviour._restoreAudioSlider_d__29.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040018C2 RID: 6338
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040018C3 RID: 6339
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040018C4 RID: 6340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040018C5 RID: 6341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040018C6 RID: 6342
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018C7 RID: 6343
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040018C8 RID: 6344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040018C9 RID: 6345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040018CA RID: 6346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
