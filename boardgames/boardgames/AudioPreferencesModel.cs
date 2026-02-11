using System;
using Canis.utils;
using dwd.core.settings;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000009 RID: 9
public class AudioPreferencesModel : VersionedModel
{
	// Token: 0x0600001A RID: 26 RVA: 0x00010804 File Offset: 0x0000EA04
	// Note: this type is marked as 'beforefieldinit'.
	static AudioPreferencesModel()
	{
		Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "AudioPreferencesModel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr);
		AudioPreferencesModel.NativeFieldInfoPtr_mutedSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, "mutedSettings");
		AudioPreferencesModel.NativeFieldInfoPtr_volumeSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, "volumeSettings");
		AudioPreferencesModel.NativeFieldInfoPtr_volumeTempValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, "volumeTempValues");
		AudioPreferencesModel.NativeFieldInfoPtr_mutedTempValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, "mutedTempValues");
		AudioPreferencesModel.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663304);
		AudioPreferencesModel.NativeMethodInfoPtr_set_MasterVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663305);
		AudioPreferencesModel.NativeMethodInfoPtr_get_MasterMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663306);
		AudioPreferencesModel.NativeMethodInfoPtr_set_MasterMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663307);
		AudioPreferencesModel.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663308);
		AudioPreferencesModel.NativeMethodInfoPtr_set_MusicVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663309);
		AudioPreferencesModel.NativeMethodInfoPtr_get_MusicMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663310);
		AudioPreferencesModel.NativeMethodInfoPtr_set_MusicMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663311);
		AudioPreferencesModel.NativeMethodInfoPtr_get_SFXVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663312);
		AudioPreferencesModel.NativeMethodInfoPtr_set_SFXVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663313);
		AudioPreferencesModel.NativeMethodInfoPtr_get_SFXMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663314);
		AudioPreferencesModel.NativeMethodInfoPtr_set_SFXMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663315);
		AudioPreferencesModel.NativeMethodInfoPtr_get_AmbienceVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663316);
		AudioPreferencesModel.NativeMethodInfoPtr_set_AmbienceVolume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663317);
		AudioPreferencesModel.NativeMethodInfoPtr_get_AmbienceMuted_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663318);
		AudioPreferencesModel.NativeMethodInfoPtr_set_AmbienceMuted_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663319);
		AudioPreferencesModel.NativeMethodInfoPtr_Save_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663320);
		AudioPreferencesModel.NativeMethodInfoPtr_Revert_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663321);
		AudioPreferencesModel.NativeMethodInfoPtr_GetVolume_Public_Single_AudioType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663322);
		AudioPreferencesModel.NativeMethodInfoPtr_SetVolume_Public_Void_AudioType_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663323);
		AudioPreferencesModel.NativeMethodInfoPtr_GetMuted_Public_Boolean_AudioType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663324);
		AudioPreferencesModel.NativeMethodInfoPtr_SetMuted_Public_Void_AudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663325);
		AudioPreferencesModel.NativeMethodInfoPtr_get_UnsavedChanges_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663326);
		AudioPreferencesModel.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663327);
		AudioPreferencesModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr, 100663328);
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001B RID: 27 RVA: 0x00010A78 File Offset: 0x0000EC78
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00010AB4 File Offset: 0x0000ECB4
	public unsafe float MasterVolume
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 982002, RefRangeEnd = 982004, XrefRangeStart = 982001, XrefRangeEnd = 982002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982005, RefRangeEnd = 982006, XrefRangeStart = 982004, XrefRangeEnd = 982005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_MasterVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x0600001D RID: 29 RVA: 0x00010AF4 File Offset: 0x0000ECF4
	// (set) Token: 0x0600001E RID: 30 RVA: 0x00010B30 File Offset: 0x0000ED30
	public unsafe bool MasterMuted
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982006, XrefRangeEnd = 982007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_MasterMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982007, XrefRangeEnd = 982008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_MasterMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x0600001F RID: 31 RVA: 0x00010B70 File Offset: 0x0000ED70
	// (set) Token: 0x06000020 RID: 32 RVA: 0x00010BAC File Offset: 0x0000EDAC
	public unsafe float MusicVolume
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 982009, RefRangeEnd = 982011, XrefRangeStart = 982008, XrefRangeEnd = 982009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982012, RefRangeEnd = 982013, XrefRangeStart = 982011, XrefRangeEnd = 982012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_MusicVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000021 RID: 33 RVA: 0x00010BEC File Offset: 0x0000EDEC
	// (set) Token: 0x06000022 RID: 34 RVA: 0x00010C28 File Offset: 0x0000EE28
	public unsafe bool MusicMuted
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982013, XrefRangeEnd = 982014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_MusicMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982015, RefRangeEnd = 982016, XrefRangeStart = 982014, XrefRangeEnd = 982015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_MusicMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000023 RID: 35 RVA: 0x00010C68 File Offset: 0x0000EE68
	// (set) Token: 0x06000024 RID: 36 RVA: 0x00010CA4 File Offset: 0x0000EEA4
	public unsafe float SFXVolume
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 982017, RefRangeEnd = 982019, XrefRangeStart = 982016, XrefRangeEnd = 982017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_SFXVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982020, RefRangeEnd = 982021, XrefRangeStart = 982019, XrefRangeEnd = 982020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_SFXVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x06000025 RID: 37 RVA: 0x00010CE4 File Offset: 0x0000EEE4
	// (set) Token: 0x06000026 RID: 38 RVA: 0x00010D20 File Offset: 0x0000EF20
	public unsafe bool SFXMuted
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982021, XrefRangeEnd = 982022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_SFXMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 982023, RefRangeEnd = 982024, XrefRangeStart = 982022, XrefRangeEnd = 982023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_SFXMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x06000027 RID: 39 RVA: 0x00010D60 File Offset: 0x0000EF60
	// (set) Token: 0x06000028 RID: 40 RVA: 0x00010D9C File Offset: 0x0000EF9C
	public unsafe float AmbienceVolume
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982024, XrefRangeEnd = 982025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_AmbienceVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982025, XrefRangeEnd = 982026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_AmbienceVolume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000029 RID: 41 RVA: 0x00010DDC File Offset: 0x0000EFDC
	// (set) Token: 0x0600002A RID: 42 RVA: 0x00010E18 File Offset: 0x0000F018
	public unsafe bool AmbienceMuted
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982026, XrefRangeEnd = 982027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_AmbienceMuted_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982027, XrefRangeEnd = 982028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_set_AmbienceMuted_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00010E58 File Offset: 0x0000F058
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 982083, RefRangeEnd = 982089, XrefRangeStart = 982028, XrefRangeEnd = 982083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Save()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_Save_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00010E8C File Offset: 0x0000F08C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982089, XrefRangeEnd = 982097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Revert()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_Revert_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00010EC0 File Offset: 0x0000F0C0
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 982102, RefRangeEnd = 982110, XrefRangeStart = 982097, XrefRangeEnd = 982102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe float GetVolume(AudioType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_GetVolume_Public_Single_AudioType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00010F0C File Offset: 0x0000F10C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 982125, RefRangeEnd = 982130, XrefRangeStart = 982110, XrefRangeEnd = 982125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVolume(AudioType type, float value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_SetVolume_Public_Void_AudioType_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00010F58 File Offset: 0x0000F158
	[CallerCount(7)]
	[CachedScanResults(RefRangeStart = 982135, RefRangeEnd = 982142, XrefRangeStart = 982130, XrefRangeEnd = 982135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool GetMuted(AudioType type)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_GetMuted_Public_Boolean_AudioType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00010FA4 File Offset: 0x0000F1A4
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 982155, RefRangeEnd = 982161, XrefRangeStart = 982142, XrefRangeEnd = 982155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetMuted(AudioType type, bool value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref type;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_SetMuted_Public_Void_AudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000031 RID: 49 RVA: 0x00010FF0 File Offset: 0x0000F1F0
	public unsafe bool UnsavedChanges
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982161, XrefRangeEnd = 982165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr_get_UnsavedChanges_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000011 RID: 17
	// (get) Token: 0x06000032 RID: 50 RVA: 0x0001102C File Offset: 0x0000F22C
	public unsafe override ulong Version
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982165, XrefRangeEnd = 982175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioPreferencesModel.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00011074 File Offset: 0x0000F274
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 982252, RefRangeEnd = 982253, XrefRangeStart = 982175, XrefRangeEnd = 982252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioPreferencesModel()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioPreferencesModel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioPreferencesModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002162 File Offset: 0x00000362
	public AudioPreferencesModel(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000035 RID: 53 RVA: 0x000110B0 File Offset: 0x0000F2B0
	// (set) Token: 0x06000036 RID: 54 RVA: 0x0000216B File Offset: 0x0000036B
	public unsafe Dictionary<AudioType, IWritableSetting<bool>> mutedSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_mutedSettings);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioType, IWritableSetting<bool>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_mutedSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000037 RID: 55 RVA: 0x000110E0 File Offset: 0x0000F2E0
	// (set) Token: 0x06000038 RID: 56 RVA: 0x0000218A File Offset: 0x0000038A
	public unsafe Dictionary<AudioType, IWritableSetting<float>> volumeSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_volumeSettings);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioType, IWritableSetting<float>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_volumeSettings), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x06000039 RID: 57 RVA: 0x00011110 File Offset: 0x0000F310
	// (set) Token: 0x0600003A RID: 58 RVA: 0x000021A9 File Offset: 0x000003A9
	public unsafe Dictionary<AudioType, float> volumeTempValues
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_volumeTempValues);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioType, float>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_volumeTempValues), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600003B RID: 59 RVA: 0x00011140 File Offset: 0x0000F340
	// (set) Token: 0x0600003C RID: 60 RVA: 0x000021C8 File Offset: 0x000003C8
	public unsafe Dictionary<AudioType, bool> mutedTempValues
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_mutedTempValues);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AudioType, bool>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioPreferencesModel.NativeFieldInfoPtr_mutedTempValues), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeFieldInfoPtr_mutedSettings;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeFieldInfoPtr_volumeSettings;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeFieldInfoPtr_volumeTempValues;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr_mutedTempValues;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeMethodInfoPtr_get_MasterVolume_Public_get_Single_0;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_set_MasterVolume_Public_set_Void_Single_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_get_MasterMuted_Public_get_Boolean_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr_set_MasterMuted_Public_set_Void_Boolean_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_get_MusicVolume_Public_get_Single_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_set_MusicVolume_Public_set_Void_Single_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_get_MusicMuted_Public_get_Boolean_0;

	// Token: 0x0400001B RID: 27
	private static readonly IntPtr NativeMethodInfoPtr_set_MusicMuted_Public_set_Void_Boolean_0;

	// Token: 0x0400001C RID: 28
	private static readonly IntPtr NativeMethodInfoPtr_get_SFXVolume_Public_get_Single_0;

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_set_SFXVolume_Public_set_Void_Single_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_get_SFXMuted_Public_get_Boolean_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr_set_SFXMuted_Public_set_Void_Boolean_0;

	// Token: 0x04000020 RID: 32
	private static readonly IntPtr NativeMethodInfoPtr_get_AmbienceVolume_Public_get_Single_0;

	// Token: 0x04000021 RID: 33
	private static readonly IntPtr NativeMethodInfoPtr_set_AmbienceVolume_Public_set_Void_Single_0;

	// Token: 0x04000022 RID: 34
	private static readonly IntPtr NativeMethodInfoPtr_get_AmbienceMuted_Public_get_Boolean_0;

	// Token: 0x04000023 RID: 35
	private static readonly IntPtr NativeMethodInfoPtr_set_AmbienceMuted_Public_set_Void_Boolean_0;

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeMethodInfoPtr_Save_Public_Void_0;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeMethodInfoPtr_Revert_Public_Void_0;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Public_Single_AudioType_0;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_AudioType_Single_0;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeMethodInfoPtr_GetMuted_Public_Boolean_AudioType_0;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr_SetMuted_Public_Void_AudioType_Boolean_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_get_UnsavedChanges_Public_get_Boolean_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
