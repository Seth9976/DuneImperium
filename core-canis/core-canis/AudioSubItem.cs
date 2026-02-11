using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Serializable]
public class AudioSubItem : global::Il2CppSystem.Object
{
	// Token: 0x06000154 RID: 340 RVA: 0x00018684 File Offset: 0x00016884
	// Note: this type is marked as 'beforefieldinit'.
	static AudioSubItem()
	{
		Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioSubItem");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr);
		AudioSubItem.NativeFieldInfoPtr_SubItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "SubItemType");
		AudioSubItem.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "Probability");
		AudioSubItem.NativeFieldInfoPtr_DisableOtherSubitems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "DisableOtherSubitems");
		AudioSubItem.NativeFieldInfoPtr_ItemModeAudioID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "ItemModeAudioID");
		AudioSubItem.NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "Clip");
		AudioSubItem.NativeFieldInfoPtr_ClipReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "ClipReference");
		AudioSubItem.NativeFieldInfoPtr_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "Volume");
		AudioSubItem.NativeFieldInfoPtr_PitchShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "PitchShift");
		AudioSubItem.NativeFieldInfoPtr_Pan2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "Pan2D");
		AudioSubItem.NativeFieldInfoPtr_Delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "Delay");
		AudioSubItem.NativeFieldInfoPtr_RandomPitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "RandomPitch");
		AudioSubItem.NativeFieldInfoPtr_RandomVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "RandomVolume");
		AudioSubItem.NativeFieldInfoPtr_RandomDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "RandomDelay");
		AudioSubItem.NativeFieldInfoPtr_ClipStopTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "ClipStopTime");
		AudioSubItem.NativeFieldInfoPtr_ClipStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "ClipStartTime");
		AudioSubItem.NativeFieldInfoPtr_FadeIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "FadeIn");
		AudioSubItem.NativeFieldInfoPtr_FadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "FadeOut");
		AudioSubItem.NativeFieldInfoPtr_RandomStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "RandomStartPosition");
		AudioSubItem.NativeFieldInfoPtr__summedProbability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "_summedProbability");
		AudioSubItem.NativeFieldInfoPtr__subItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "_subItemID");
		AudioSubItem.NativeFieldInfoPtr__item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, "_item");
		AudioSubItem.NativeMethodInfoPtr_get__SummedProbability_Internal_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663471);
		AudioSubItem.NativeMethodInfoPtr_set__SummedProbability_Internal_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663472);
		AudioSubItem.NativeMethodInfoPtr_set_item_Internal_set_Void_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663473);
		AudioSubItem.NativeMethodInfoPtr_get_item_Public_get_AudioItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663474);
		AudioSubItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663475);
		AudioSubItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr, 100663476);
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x06000155 RID: 341 RVA: 0x000188D0 File Offset: 0x00016AD0
	// (set) Token: 0x06000156 RID: 342 RVA: 0x0001890C File Offset: 0x00016B0C
	public unsafe float _SummedProbability
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSubItem.NativeMethodInfoPtr_get__SummedProbability_Internal_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSubItem.NativeMethodInfoPtr_set__SummedProbability_Internal_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06000158 RID: 344 RVA: 0x00018990 File Offset: 0x00016B90
	// (set) Token: 0x06000157 RID: 343 RVA: 0x0001894C File Offset: 0x00016B4C
	public unsafe AudioItem item
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSubItem.NativeMethodInfoPtr_get_item_Public_get_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSubItem.NativeMethodInfoPtr_set_item_Internal_set_Void_AudioItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000189D0 File Offset: 0x00016BD0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852258, XrefRangeEnd = 852267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSubItem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00018A14 File Offset: 0x00016C14
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 852267, XrefRangeEnd = 852268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioSubItem()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSubItem>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSubItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600015B RID: 347 RVA: 0x000028C6 File Offset: 0x00000AC6
	public AudioSubItem(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x0600015C RID: 348 RVA: 0x00018A50 File Offset: 0x00016C50
	// (set) Token: 0x0600015D RID: 349 RVA: 0x000028CF File Offset: 0x00000ACF
	public unsafe AudioSubItemType SubItemType
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_SubItemType);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_SubItemType)) = value;
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600015E RID: 350 RVA: 0x00018A78 File Offset: 0x00016C78
	// (set) Token: 0x0600015F RID: 351 RVA: 0x000028EA File Offset: 0x00000AEA
	public unsafe float Probability
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Probability);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Probability)) = value;
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000160 RID: 352 RVA: 0x00018AA0 File Offset: 0x00016CA0
	// (set) Token: 0x06000161 RID: 353 RVA: 0x00002905 File Offset: 0x00000B05
	public unsafe bool DisableOtherSubitems
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_DisableOtherSubitems);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_DisableOtherSubitems)) = value;
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x06000162 RID: 354 RVA: 0x00018AC8 File Offset: 0x00016CC8
	// (set) Token: 0x06000163 RID: 355 RVA: 0x00002920 File Offset: 0x00000B20
	public unsafe string ItemModeAudioID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ItemModeAudioID);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ItemModeAudioID), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x06000164 RID: 356 RVA: 0x00018AF0 File Offset: 0x00016CF0
	// (set) Token: 0x06000165 RID: 357 RVA: 0x0000293F File Offset: 0x00000B3F
	public unsafe AudioClip Clip
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Clip);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x06000166 RID: 358 RVA: 0x00018B20 File Offset: 0x00016D20
	// (set) Token: 0x06000167 RID: 359 RVA: 0x0000295E File Offset: 0x00000B5E
	public unsafe string ClipReference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipReference);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipReference), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06000168 RID: 360 RVA: 0x00018B48 File Offset: 0x00016D48
	// (set) Token: 0x06000169 RID: 361 RVA: 0x0000297D File Offset: 0x00000B7D
	public unsafe float Volume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Volume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Volume)) = value;
		}
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x0600016A RID: 362 RVA: 0x00018B70 File Offset: 0x00016D70
	// (set) Token: 0x0600016B RID: 363 RVA: 0x00002998 File Offset: 0x00000B98
	public unsafe float PitchShift
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_PitchShift);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_PitchShift)) = value;
		}
	}

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x0600016C RID: 364 RVA: 0x00018B98 File Offset: 0x00016D98
	// (set) Token: 0x0600016D RID: 365 RVA: 0x000029B3 File Offset: 0x00000BB3
	public unsafe float Pan2D
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Pan2D);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Pan2D)) = value;
		}
	}

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x0600016E RID: 366 RVA: 0x00018BC0 File Offset: 0x00016DC0
	// (set) Token: 0x0600016F RID: 367 RVA: 0x000029CE File Offset: 0x00000BCE
	public unsafe float Delay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Delay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_Delay)) = value;
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06000170 RID: 368 RVA: 0x00018BE8 File Offset: 0x00016DE8
	// (set) Token: 0x06000171 RID: 369 RVA: 0x000029E9 File Offset: 0x00000BE9
	public unsafe float RandomPitch
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomPitch);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomPitch)) = value;
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x06000172 RID: 370 RVA: 0x00018C10 File Offset: 0x00016E10
	// (set) Token: 0x06000173 RID: 371 RVA: 0x00002A04 File Offset: 0x00000C04
	public unsafe float RandomVolume
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomVolume);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomVolume)) = value;
		}
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x06000174 RID: 372 RVA: 0x00018C38 File Offset: 0x00016E38
	// (set) Token: 0x06000175 RID: 373 RVA: 0x00002A1F File Offset: 0x00000C1F
	public unsafe float RandomDelay
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomDelay);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomDelay)) = value;
		}
	}

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x06000176 RID: 374 RVA: 0x00018C60 File Offset: 0x00016E60
	// (set) Token: 0x06000177 RID: 375 RVA: 0x00002A3A File Offset: 0x00000C3A
	public unsafe float ClipStopTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipStopTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipStopTime)) = value;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x06000178 RID: 376 RVA: 0x00018C88 File Offset: 0x00016E88
	// (set) Token: 0x06000179 RID: 377 RVA: 0x00002A55 File Offset: 0x00000C55
	public unsafe float ClipStartTime
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipStartTime);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_ClipStartTime)) = value;
		}
	}

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x0600017A RID: 378 RVA: 0x00018CB0 File Offset: 0x00016EB0
	// (set) Token: 0x0600017B RID: 379 RVA: 0x00002A70 File Offset: 0x00000C70
	public unsafe float FadeIn
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_FadeIn);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_FadeIn)) = value;
		}
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x0600017C RID: 380 RVA: 0x00018CD8 File Offset: 0x00016ED8
	// (set) Token: 0x0600017D RID: 381 RVA: 0x00002A8B File Offset: 0x00000C8B
	public unsafe float FadeOut
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_FadeOut);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_FadeOut)) = value;
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x0600017E RID: 382 RVA: 0x00018D00 File Offset: 0x00016F00
	// (set) Token: 0x0600017F RID: 383 RVA: 0x00002AA6 File Offset: 0x00000CA6
	public unsafe bool RandomStartPosition
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomStartPosition);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr_RandomStartPosition)) = value;
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000180 RID: 384 RVA: 0x00018D28 File Offset: 0x00016F28
	// (set) Token: 0x06000181 RID: 385 RVA: 0x00002AC1 File Offset: 0x00000CC1
	public unsafe float _summedProbability
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__summedProbability);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__summedProbability)) = value;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000182 RID: 386 RVA: 0x00018D50 File Offset: 0x00016F50
	// (set) Token: 0x06000183 RID: 387 RVA: 0x00002ADC File Offset: 0x00000CDC
	public unsafe int _subItemID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__subItemID);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__subItemID)) = value;
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x06000184 RID: 388 RVA: 0x00018D78 File Offset: 0x00016F78
	// (set) Token: 0x06000185 RID: 389 RVA: 0x00002AF7 File Offset: 0x00000CF7
	public unsafe AudioItem _item
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__item);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioItem>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSubItem.NativeFieldInfoPtr__item), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeFieldInfoPtr_SubItemType;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeFieldInfoPtr_Probability;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeFieldInfoPtr_DisableOtherSubitems;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeFieldInfoPtr_ItemModeAudioID;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeFieldInfoPtr_Clip;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeFieldInfoPtr_ClipReference;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeFieldInfoPtr_Volume;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeFieldInfoPtr_PitchShift;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeFieldInfoPtr_Pan2D;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeFieldInfoPtr_Delay;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeFieldInfoPtr_RandomPitch;

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeFieldInfoPtr_RandomVolume;

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeFieldInfoPtr_RandomDelay;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeFieldInfoPtr_ClipStopTime;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeFieldInfoPtr_ClipStartTime;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeFieldInfoPtr_FadeIn;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeFieldInfoPtr_FadeOut;

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeFieldInfoPtr_RandomStartPosition;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeFieldInfoPtr__summedProbability;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeFieldInfoPtr__subItemID;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeFieldInfoPtr__item;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeMethodInfoPtr_get__SummedProbability_Internal_get_Single_0;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeMethodInfoPtr_set__SummedProbability_Internal_set_Void_Single_0;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeMethodInfoPtr_set_item_Internal_set_Void_AudioItem_0;

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeMethodInfoPtr_get_item_Public_get_AudioItem_0;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
