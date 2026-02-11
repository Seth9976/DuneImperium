using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Serializable]
public class AudioCategory : global::Il2CppSystem.Object
{
	// Token: 0x06000102 RID: 258 RVA: 0x00017800 File Offset: 0x00015A00
	// Note: this type is marked as 'beforefieldinit'.
	static AudioCategory()
	{
		Il2CppClassPointerStore<AudioCategory>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioCategory");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr);
		AudioCategory.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "Name");
		AudioCategory.NativeFieldInfoPtr__parentCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "_parentCategory");
		AudioCategory.NativeFieldInfoPtr__parentCategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "_parentCategoryName");
		AudioCategory.NativeFieldInfoPtr__audioController_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "<audioController>k__BackingField");
		AudioCategory.NativeFieldInfoPtr_AudioObjectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "AudioObjectPrefab");
		AudioCategory.NativeFieldInfoPtr_AudioItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "AudioItems");
		AudioCategory.NativeFieldInfoPtr__volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, "_volume");
		AudioCategory.NativeMethodInfoPtr_get_Volume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663449);
		AudioCategory.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663450);
		AudioCategory.NativeMethodInfoPtr_get_VolumeTotal_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663451);
		AudioCategory.NativeMethodInfoPtr_set_parentCategory_Public_set_Void_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663452);
		AudioCategory.NativeMethodInfoPtr_get_parentCategory_Public_get_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663453);
		AudioCategory.NativeMethodInfoPtr_get_audioController_Public_get_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663454);
		AudioCategory.NativeMethodInfoPtr_set_audioController_Public_set_Void_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663455);
		AudioCategory.NativeMethodInfoPtr__ctor_Public_Void_AudioController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663456);
		AudioCategory.NativeMethodInfoPtr_GetAudioObjectPrefab_Public_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663457);
		AudioCategory.NativeMethodInfoPtr__AnalyseAudioItems_Internal_Void_Dictionary_2_String_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663458);
		AudioCategory.NativeMethodInfoPtr__GetIndexOf_Internal_Int32_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663459);
		AudioCategory.NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663460);
		AudioCategory.NativeMethodInfoPtr__IsCategoryParentOf_Private_Boolean_AudioCategory_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663461);
		AudioCategory.NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_HashSet_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr, 100663462);
	}

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x06000103 RID: 259 RVA: 0x000179D4 File Offset: 0x00015BD4
	// (set) Token: 0x06000104 RID: 260 RVA: 0x00017A10 File Offset: 0x00015C10
	public unsafe float Volume
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 300360, RefRangeEnd = 300361, XrefRangeStart = 300360, XrefRangeEnd = 300361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_get_Volume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 852127, RefRangeEnd = 852131, XrefRangeStart = 852109, XrefRangeEnd = 852127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00017A50 File Offset: 0x00015C50
	public unsafe float VolumeTotal
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 852132, RefRangeEnd = 852134, XrefRangeStart = 852131, XrefRangeEnd = 852132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_get_VolumeTotal_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06000107 RID: 263 RVA: 0x00017AD0 File Offset: 0x00015CD0
	// (set) Token: 0x06000106 RID: 262 RVA: 0x00017A8C File Offset: 0x00015C8C
	public unsafe AudioCategory parentCategory
	{
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 852149, RefRangeEnd = 852160, XrefRangeStart = 852138, XrefRangeEnd = 852149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_get_parentCategory_Public_get_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852134, XrefRangeEnd = 852138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_set_parentCategory_Public_set_Void_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000108 RID: 264 RVA: 0x00017B10 File Offset: 0x00015D10
	// (set) Token: 0x06000109 RID: 265 RVA: 0x00017B50 File Offset: 0x00015D50
	public unsafe AudioController audioController
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_get_audioController_Public_get_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioController>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_set_audioController_Public_set_Void_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x00017B94 File Offset: 0x00015D94
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852160, XrefRangeEnd = 852162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioCategory(AudioController audioController)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioCategory>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr__ctor_Public_Void_AudioController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x00017BE0 File Offset: 0x00015DE0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852162, XrefRangeEnd = 852167, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameObject GetAudioObjectPrefab()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_GetAudioObjectPrefab_Public_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00017C20 File Offset: 0x00015E20
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 852184, RefRangeEnd = 852185, XrefRangeStart = 852167, XrefRangeEnd = 852184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _AnalyseAudioItems(Dictionary<string, AudioItem> audioItemsDict)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItemsDict);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr__AnalyseAudioItems_Internal_Void_Dictionary_2_String_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00017C64 File Offset: 0x00015E64
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852185, XrefRangeEnd = 852186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe int _GetIndexOf(AudioItem audioItem)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(audioItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr__GetIndexOf_Internal_Int32_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x00017CB4 File Offset: 0x00015EB4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852186, XrefRangeEnd = 852204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _ApplyVolumeChange()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00017CE8 File Offset: 0x00015EE8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852204, XrefRangeEnd = 852205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool _IsCategoryParentOf(AudioCategory toTest, AudioCategory parent)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toTest);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr__IsCategoryParentOf_Private_Boolean_AudioCategory_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00017D48 File Offset: 0x00015F48
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852205, XrefRangeEnd = 852216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadAllAudioClips(HashSet<AudioClip> playingClips)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playingClips);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioCategory.NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_HashSet_1_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x0000259C File Offset: 0x0000079C
	public AudioCategory(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x06000112 RID: 274 RVA: 0x00017D8C File Offset: 0x00015F8C
	// (set) Token: 0x06000113 RID: 275 RVA: 0x000025A5 File Offset: 0x000007A5
	public unsafe string Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00017DB4 File Offset: 0x00015FB4
	// (set) Token: 0x06000115 RID: 277 RVA: 0x000025C4 File Offset: 0x000007C4
	public unsafe AudioCategory _parentCategory
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__parentCategory);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__parentCategory), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06000116 RID: 278 RVA: 0x00017DE4 File Offset: 0x00015FE4
	// (set) Token: 0x06000117 RID: 279 RVA: 0x000025E3 File Offset: 0x000007E3
	public unsafe string _parentCategoryName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__parentCategoryName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__parentCategoryName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x06000118 RID: 280 RVA: 0x00017E0C File Offset: 0x0001600C
	// (set) Token: 0x06000119 RID: 281 RVA: 0x00002602 File Offset: 0x00000802
	public unsafe AudioController _audioController_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__audioController_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioController>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__audioController_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x0600011A RID: 282 RVA: 0x00017E3C File Offset: 0x0001603C
	// (set) Token: 0x0600011B RID: 283 RVA: 0x00002621 File Offset: 0x00000821
	public unsafe GameObject AudioObjectPrefab
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_AudioObjectPrefab);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_AudioObjectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x0600011C RID: 284 RVA: 0x00017E6C File Offset: 0x0001606C
	// (set) Token: 0x0600011D RID: 285 RVA: 0x00002640 File Offset: 0x00000840
	public unsafe Il2CppReferenceArray<AudioItem> AudioItems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_AudioItems);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioItem>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr_AudioItems), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x0600011E RID: 286 RVA: 0x00017E9C File Offset: 0x0001609C
	// (set) Token: 0x0600011F RID: 287 RVA: 0x0000265F File Offset: 0x0000085F
	public unsafe float _volume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__volume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioCategory.NativeFieldInfoPtr__volume)) = value;
		}
	}

	// Token: 0x040000C7 RID: 199
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x040000C8 RID: 200
	private static readonly IntPtr NativeFieldInfoPtr__parentCategory;

	// Token: 0x040000C9 RID: 201
	private static readonly IntPtr NativeFieldInfoPtr__parentCategoryName;

	// Token: 0x040000CA RID: 202
	private static readonly IntPtr NativeFieldInfoPtr__audioController_k__BackingField;

	// Token: 0x040000CB RID: 203
	private static readonly IntPtr NativeFieldInfoPtr_AudioObjectPrefab;

	// Token: 0x040000CC RID: 204
	private static readonly IntPtr NativeFieldInfoPtr_AudioItems;

	// Token: 0x040000CD RID: 205
	private static readonly IntPtr NativeFieldInfoPtr__volume;

	// Token: 0x040000CE RID: 206
	private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_get_Single_0;

	// Token: 0x040000CF RID: 207
	private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;

	// Token: 0x040000D0 RID: 208
	private static readonly IntPtr NativeMethodInfoPtr_get_VolumeTotal_Public_get_Single_0;

	// Token: 0x040000D1 RID: 209
	private static readonly IntPtr NativeMethodInfoPtr_set_parentCategory_Public_set_Void_AudioCategory_0;

	// Token: 0x040000D2 RID: 210
	private static readonly IntPtr NativeMethodInfoPtr_get_parentCategory_Public_get_AudioCategory_0;

	// Token: 0x040000D3 RID: 211
	private static readonly IntPtr NativeMethodInfoPtr_get_audioController_Public_get_AudioController_0;

	// Token: 0x040000D4 RID: 212
	private static readonly IntPtr NativeMethodInfoPtr_set_audioController_Public_set_Void_AudioController_0;

	// Token: 0x040000D5 RID: 213
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AudioController_0;

	// Token: 0x040000D6 RID: 214
	private static readonly IntPtr NativeMethodInfoPtr_GetAudioObjectPrefab_Public_GameObject_0;

	// Token: 0x040000D7 RID: 215
	private static readonly IntPtr NativeMethodInfoPtr__AnalyseAudioItems_Internal_Void_Dictionary_2_String_AudioItem_0;

	// Token: 0x040000D8 RID: 216
	private static readonly IntPtr NativeMethodInfoPtr__GetIndexOf_Internal_Int32_AudioItem_0;

	// Token: 0x040000D9 RID: 217
	private static readonly IntPtr NativeMethodInfoPtr__ApplyVolumeChange_Private_Void_0;

	// Token: 0x040000DA RID: 218
	private static readonly IntPtr NativeMethodInfoPtr__IsCategoryParentOf_Private_Boolean_AudioCategory_AudioCategory_0;

	// Token: 0x040000DB RID: 219
	private static readonly IntPtr NativeMethodInfoPtr_UnloadAllAudioClips_Public_Void_HashSet_1_AudioClip_0;
}
