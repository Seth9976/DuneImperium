using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200000A RID: 10
[Serializable]
public class AudioItem : global::Il2CppSystem.Object
{
	// Token: 0x06000120 RID: 288 RVA: 0x00017EC4 File Offset: 0x000160C4
	// Note: this type is marked as 'beforefieldinit'.
	static AudioItem()
	{
		Il2CppClassPointerStore<AudioItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioItem>.NativeClassPtr);
		AudioItem.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "Name");
		AudioItem.NativeFieldInfoPtr_Loop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "Loop");
		AudioItem.NativeFieldInfoPtr_loopSequenceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "loopSequenceCount");
		AudioItem.NativeFieldInfoPtr_loopSequenceOverlap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "loopSequenceOverlap");
		AudioItem.NativeFieldInfoPtr_loopSequenceRandomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "loopSequenceRandomDelay");
		AudioItem.NativeFieldInfoPtr_loopSequenceRandomPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "loopSequenceRandomPitch");
		AudioItem.NativeFieldInfoPtr_loopSequenceRandomVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "loopSequenceRandomVolume");
		AudioItem.NativeFieldInfoPtr_DestroyOnLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "DestroyOnLoad");
		AudioItem.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "Volume");
		AudioItem.NativeFieldInfoPtr_SubItemPickMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "SubItemPickMode");
		AudioItem.NativeFieldInfoPtr_MinTimeBetweenPlayCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "MinTimeBetweenPlayCalls");
		AudioItem.NativeFieldInfoPtr_MaxInstanceCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "MaxInstanceCount");
		AudioItem.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "Delay");
		AudioItem.NativeFieldInfoPtr_overrideAudioSourceSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "overrideAudioSourceSettings");
		AudioItem.NativeFieldInfoPtr_audioSource_MinDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "audioSource_MinDistance");
		AudioItem.NativeFieldInfoPtr_audioSource_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "audioSource_MaxDistance");
		AudioItem.NativeFieldInfoPtr_spatialBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "spatialBlend");
		AudioItem.NativeFieldInfoPtr_subItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "subItems");
		AudioItem.NativeFieldInfoPtr__lastChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "_lastChosen");
		AudioItem.NativeFieldInfoPtr__lastPlayedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "_lastPlayedTime");
		AudioItem.NativeFieldInfoPtr__category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, "_category");
		AudioItem.NativeMethodInfoPtr_set_category_Private_set_Void_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663463);
		AudioItem.NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663464);
		AudioItem.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663465);
		AudioItem.NativeMethodInfoPtr__Initialize_Internal_Void_AudioCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663466);
		AudioItem.NativeMethodInfoPtr__NormalizeSubItems_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663467);
		AudioItem.NativeMethodInfoPtr__IsValidSubItem_Private_Static_Boolean_AudioSubItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663468);
		AudioItem.NativeMethodInfoPtr_UnloadAudioClip_Public_Void_HashSet_1_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663469);
		AudioItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioItem>.NativeClassPtr, 100663470);
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000122 RID: 290 RVA: 0x0001817C File Offset: 0x0001637C
	// (set) Token: 0x06000121 RID: 289 RVA: 0x00018138 File Offset: 0x00016338
	public unsafe AudioCategory category
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr_set_category_Private_set_Void_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000181BC File Offset: 0x000163BC
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000124 RID: 292 RVA: 0x000181F0 File Offset: 0x000163F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852216, XrefRangeEnd = 852218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _Initialize(AudioCategory categ)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(categ);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr__Initialize_Internal_Void_AudioCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00018234 File Offset: 0x00016434
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 852243, RefRangeEnd = 852245, XrefRangeStart = 852218, XrefRangeEnd = 852243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _NormalizeSubItems()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr__NormalizeSubItems_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000126 RID: 294 RVA: 0x00018268 File Offset: 0x00016468
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852245, XrefRangeEnd = 852247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool _IsValidSubItem(AudioSubItem item)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr__IsValidSubItem_Private_Static_Boolean_AudioSubItem_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x000182AC File Offset: 0x000164AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852247, XrefRangeEnd = 852257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UnloadAudioClip(HashSet<AudioClip> playingClips)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(playingClips);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr_UnloadAudioClip_Public_Void_HashSet_1_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000128 RID: 296 RVA: 0x000182F0 File Offset: 0x000164F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852257, XrefRangeEnd = 852258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000267A File Offset: 0x0000087A
	public AudioItem(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x0600012A RID: 298 RVA: 0x0001832C File Offset: 0x0001652C
	// (set) Token: 0x0600012B RID: 299 RVA: 0x00002683 File Offset: 0x00000883
	public unsafe string Name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x0600012C RID: 300 RVA: 0x00018354 File Offset: 0x00016554
	// (set) Token: 0x0600012D RID: 301 RVA: 0x000026A2 File Offset: 0x000008A2
	public unsafe AudioItem.LoopMode Loop
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Loop);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Loop)) = value;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x0600012E RID: 302 RVA: 0x0001837C File Offset: 0x0001657C
	// (set) Token: 0x0600012F RID: 303 RVA: 0x000026BD File Offset: 0x000008BD
	public unsafe int loopSequenceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceCount)) = value;
		}
	}

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x06000130 RID: 304 RVA: 0x000183A4 File Offset: 0x000165A4
	// (set) Token: 0x06000131 RID: 305 RVA: 0x000026D8 File Offset: 0x000008D8
	public unsafe float loopSequenceOverlap
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceOverlap);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceOverlap)) = value;
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06000132 RID: 306 RVA: 0x000183CC File Offset: 0x000165CC
	// (set) Token: 0x06000133 RID: 307 RVA: 0x000026F3 File Offset: 0x000008F3
	public unsafe float loopSequenceRandomDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomDelay)) = value;
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06000134 RID: 308 RVA: 0x000183F4 File Offset: 0x000165F4
	// (set) Token: 0x06000135 RID: 309 RVA: 0x0000270E File Offset: 0x0000090E
	public unsafe float loopSequenceRandomPitch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomPitch);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomPitch)) = value;
		}
	}

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x06000136 RID: 310 RVA: 0x0001841C File Offset: 0x0001661C
	// (set) Token: 0x06000137 RID: 311 RVA: 0x00002729 File Offset: 0x00000929
	public unsafe float loopSequenceRandomVolume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomVolume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_loopSequenceRandomVolume)) = value;
		}
	}

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x06000138 RID: 312 RVA: 0x00018444 File Offset: 0x00016644
	// (set) Token: 0x06000139 RID: 313 RVA: 0x00002744 File Offset: 0x00000944
	public unsafe bool DestroyOnLoad
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_DestroyOnLoad);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_DestroyOnLoad)) = value;
		}
	}

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x0600013A RID: 314 RVA: 0x0001846C File Offset: 0x0001666C
	// (set) Token: 0x0600013B RID: 315 RVA: 0x0000275F File Offset: 0x0000095F
	public unsafe float Volume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Volume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Volume)) = value;
		}
	}

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x0600013C RID: 316 RVA: 0x00018494 File Offset: 0x00016694
	// (set) Token: 0x0600013D RID: 317 RVA: 0x0000277A File Offset: 0x0000097A
	public unsafe AudioPickSubItemMode SubItemPickMode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_SubItemPickMode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_SubItemPickMode)) = value;
		}
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x0600013E RID: 318 RVA: 0x000184BC File Offset: 0x000166BC
	// (set) Token: 0x0600013F RID: 319 RVA: 0x00002795 File Offset: 0x00000995
	public unsafe float MinTimeBetweenPlayCalls
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_MinTimeBetweenPlayCalls);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_MinTimeBetweenPlayCalls)) = value;
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06000140 RID: 320 RVA: 0x000184E4 File Offset: 0x000166E4
	// (set) Token: 0x06000141 RID: 321 RVA: 0x000027B0 File Offset: 0x000009B0
	public unsafe int MaxInstanceCount
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_MaxInstanceCount);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_MaxInstanceCount)) = value;
		}
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x06000142 RID: 322 RVA: 0x0001850C File Offset: 0x0001670C
	// (set) Token: 0x06000143 RID: 323 RVA: 0x000027CB File Offset: 0x000009CB
	public unsafe float Delay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Delay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_Delay)) = value;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06000144 RID: 324 RVA: 0x00018534 File Offset: 0x00016734
	// (set) Token: 0x06000145 RID: 325 RVA: 0x000027E6 File Offset: 0x000009E6
	public unsafe bool overrideAudioSourceSettings
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_overrideAudioSourceSettings);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_overrideAudioSourceSettings)) = value;
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x06000146 RID: 326 RVA: 0x0001855C File Offset: 0x0001675C
	// (set) Token: 0x06000147 RID: 327 RVA: 0x00002801 File Offset: 0x00000A01
	public unsafe float audioSource_MinDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_audioSource_MinDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_audioSource_MinDistance)) = value;
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x06000148 RID: 328 RVA: 0x00018584 File Offset: 0x00016784
	// (set) Token: 0x06000149 RID: 329 RVA: 0x0000281C File Offset: 0x00000A1C
	public unsafe float audioSource_MaxDistance
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_audioSource_MaxDistance);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_audioSource_MaxDistance)) = value;
		}
	}

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x0600014A RID: 330 RVA: 0x000185AC File Offset: 0x000167AC
	// (set) Token: 0x0600014B RID: 331 RVA: 0x00002837 File Offset: 0x00000A37
	public unsafe float spatialBlend
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_spatialBlend);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_spatialBlend)) = value;
		}
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600014C RID: 332 RVA: 0x000185D4 File Offset: 0x000167D4
	// (set) Token: 0x0600014D RID: 333 RVA: 0x00002852 File Offset: 0x00000A52
	public unsafe Il2CppReferenceArray<AudioSubItem> subItems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_subItems);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioSubItem>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr_subItems), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x0600014E RID: 334 RVA: 0x00018604 File Offset: 0x00016804
	// (set) Token: 0x0600014F RID: 335 RVA: 0x00002871 File Offset: 0x00000A71
	public unsafe int _lastChosen
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__lastChosen);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__lastChosen)) = value;
		}
	}

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x06000150 RID: 336 RVA: 0x0001862C File Offset: 0x0001682C
	// (set) Token: 0x06000151 RID: 337 RVA: 0x0000288C File Offset: 0x00000A8C
	public unsafe double _lastPlayedTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__lastPlayedTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__lastPlayedTime)) = value;
		}
	}

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x06000152 RID: 338 RVA: 0x00018654 File Offset: 0x00016854
	// (set) Token: 0x06000153 RID: 339 RVA: 0x000028A7 File Offset: 0x00000AA7
	public unsafe AudioCategory _category
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__category);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioCategory>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioItem.NativeFieldInfoPtr__category), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeFieldInfoPtr_Name;

	// Token: 0x040000E7 RID: 231
	private static readonly IntPtr NativeFieldInfoPtr_Loop;

	// Token: 0x040000E8 RID: 232
	private static readonly IntPtr NativeFieldInfoPtr_loopSequenceCount;

	// Token: 0x040000E9 RID: 233
	private static readonly IntPtr NativeFieldInfoPtr_loopSequenceOverlap;

	// Token: 0x040000EA RID: 234
	private static readonly IntPtr NativeFieldInfoPtr_loopSequenceRandomDelay;

	// Token: 0x040000EB RID: 235
	private static readonly IntPtr NativeFieldInfoPtr_loopSequenceRandomPitch;

	// Token: 0x040000EC RID: 236
	private static readonly IntPtr NativeFieldInfoPtr_loopSequenceRandomVolume;

	// Token: 0x040000ED RID: 237
	private static readonly IntPtr NativeFieldInfoPtr_DestroyOnLoad;

	// Token: 0x040000EE RID: 238
	private static readonly IntPtr NativeFieldInfoPtr_Volume;

	// Token: 0x040000EF RID: 239
	private static readonly IntPtr NativeFieldInfoPtr_SubItemPickMode;

	// Token: 0x040000F0 RID: 240
	private static readonly IntPtr NativeFieldInfoPtr_MinTimeBetweenPlayCalls;

	// Token: 0x040000F1 RID: 241
	private static readonly IntPtr NativeFieldInfoPtr_MaxInstanceCount;

	// Token: 0x040000F2 RID: 242
	private static readonly IntPtr NativeFieldInfoPtr_Delay;

	// Token: 0x040000F3 RID: 243
	private static readonly IntPtr NativeFieldInfoPtr_overrideAudioSourceSettings;

	// Token: 0x040000F4 RID: 244
	private static readonly IntPtr NativeFieldInfoPtr_audioSource_MinDistance;

	// Token: 0x040000F5 RID: 245
	private static readonly IntPtr NativeFieldInfoPtr_audioSource_MaxDistance;

	// Token: 0x040000F6 RID: 246
	private static readonly IntPtr NativeFieldInfoPtr_spatialBlend;

	// Token: 0x040000F7 RID: 247
	private static readonly IntPtr NativeFieldInfoPtr_subItems;

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeFieldInfoPtr__lastChosen;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeFieldInfoPtr__lastPlayedTime;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeFieldInfoPtr__category;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeMethodInfoPtr_set_category_Private_set_Void_AudioCategory_0;

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeMethodInfoPtr_get_category_Public_get_AudioCategory_0;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeMethodInfoPtr__Initialize_Internal_Void_AudioCategory_0;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeMethodInfoPtr__NormalizeSubItems_Private_Void_0;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeMethodInfoPtr__IsValidSubItem_Private_Static_Boolean_AudioSubItem_0;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeMethodInfoPtr_UnloadAudioClip_Public_Void_HashSet_1_AudioClip_0;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200022C RID: 556
	[Serializable]
	public enum LoopMode
	{
		// Token: 0x04001509 RID: 5385
		DoNotLoop,
		// Token: 0x0400150A RID: 5386
		LoopSubitem,
		// Token: 0x0400150B RID: 5387
		LoopSequence,
		// Token: 0x0400150C RID: 5388
		PlaySequenceAndLoopLast = 4,
		// Token: 0x0400150D RID: 5389
		IntroLoopOutroSequence
	}
}
