using System;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

// Token: 0x0200000A RID: 10
public class LotusAudioController : DataProvider
{
	// Token: 0x0600003D RID: 61 RVA: 0x00011170 File Offset: 0x0000F370
	// Note: this type is marked as 'beforefieldinit'.
	static LotusAudioController()
	{
		Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "LotusAudioController");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr);
		LotusAudioController.NativeFieldInfoPtr_musicCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "musicCategories");
		LotusAudioController.NativeFieldInfoPtr_sfxCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "sfxCategories");
		LotusAudioController.NativeFieldInfoPtr_ambienceCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "ambienceCategories");
		LotusAudioController.NativeFieldInfoPtr__Model_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "<Model>k__BackingField");
		LotusAudioController.NativeFieldInfoPtr_duckMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "duckMultiplier");
		LotusAudioController.NativeFieldInfoPtr_cachedDuck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "cachedDuck");
		LotusAudioController.NativeFieldInfoPtr_cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "cached");
		LotusAudioController.NativeMethodInfoPtr_get_Model_Public_get_AudioPreferencesModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663329);
		LotusAudioController.NativeMethodInfoPtr_set_Model_Private_set_Void_AudioPreferencesModel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663330);
		LotusAudioController.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663331);
		LotusAudioController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663332);
		LotusAudioController.NativeMethodInfoPtr_Duck_Public_Coroutine_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663333);
		LotusAudioController.NativeMethodInfoPtr_Unduck_Public_Coroutine_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663334);
		LotusAudioController.NativeMethodInfoPtr_duck_Private_IEnumerator_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663335);
		LotusAudioController.NativeMethodInfoPtr_dirtyUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663336);
		LotusAudioController.NativeMethodInfoPtr_SetVolumes_Private_Void_IEnumerable_1_String_AudioType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663337);
		LotusAudioController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, 100663338);
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x0600003E RID: 62 RVA: 0x000112F4 File Offset: 0x0000F4F4
	// (set) Token: 0x0600003F RID: 63 RVA: 0x00011334 File Offset: 0x0000F534
	public unsafe AudioPreferencesModel Model
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_get_Model_Public_get_AudioPreferencesModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioPreferencesModel>(intPtr3) : null;
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_set_Model_Private_set_Void_AudioPreferencesModel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00011378 File Offset: 0x0000F578
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982267, XrefRangeEnd = 982272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x000113AC File Offset: 0x0000F5AC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982272, XrefRangeEnd = 982280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000113E0 File Offset: 0x0000F5E0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982280, XrefRangeEnd = 982283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coroutine Duck(float duckPercent, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref duckPercent;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_Duck_Public_Coroutine_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
	}

	// Token: 0x06000043 RID: 67 RVA: 0x0001143C File Offset: 0x0000F63C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982283, XrefRangeEnd = 982285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Coroutine Unduck(float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_Unduck_Public_Coroutine_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr3) : null;
		}
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00011488 File Offset: 0x0000F688
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 982290, RefRangeEnd = 982292, XrefRangeStart = 982285, XrefRangeEnd = 982290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe IEnumerator duck(float start, float end, float duration)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_duck_Private_IEnumerator_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000114F0 File Offset: 0x0000F6F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982292, XrefRangeEnd = 982295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_dirtyUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00011524 File Offset: 0x0000F724
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 982320, RefRangeEnd = 982326, XrefRangeStart = 982295, XrefRangeEnd = 982320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void SetVolumes(IEnumerable<string> categories, global::AudioType audioType, bool duck)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(categories);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref audioType;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duck;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr_SetVolumes_Private_Void_IEnumerable_1_String_AudioType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00011584 File Offset: 0x0000F784
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982326, XrefRangeEnd = 982352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LotusAudioController()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x000021E7 File Offset: 0x000003E7
	public LotusAudioController(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000012 RID: 18
	// (get) Token: 0x06000049 RID: 73 RVA: 0x000115C0 File Offset: 0x0000F7C0
	// (set) Token: 0x0600004A RID: 74 RVA: 0x000021F0 File Offset: 0x000003F0
	public unsafe Il2CppStringArray musicCategories
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_musicCategories);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_musicCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x0600004B RID: 75 RVA: 0x000115F0 File Offset: 0x0000F7F0
	// (set) Token: 0x0600004C RID: 76 RVA: 0x0000220F File Offset: 0x0000040F
	public unsafe Il2CppStringArray sfxCategories
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_sfxCategories);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_sfxCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x0600004D RID: 77 RVA: 0x00011620 File Offset: 0x0000F820
	// (set) Token: 0x0600004E RID: 78 RVA: 0x0000222E File Offset: 0x0000042E
	public unsafe Il2CppStringArray ambienceCategories
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_ambienceCategories);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_ambienceCategories), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x0600004F RID: 79 RVA: 0x00011650 File Offset: 0x0000F850
	// (set) Token: 0x06000050 RID: 80 RVA: 0x0000224D File Offset: 0x0000044D
	public unsafe AudioPreferencesModel _Model_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr__Model_k__BackingField);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioPreferencesModel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr__Model_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000051 RID: 81 RVA: 0x00011680 File Offset: 0x0000F880
	// (set) Token: 0x06000052 RID: 82 RVA: 0x0000226C File Offset: 0x0000046C
	public unsafe float duckMultiplier
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_duckMultiplier);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_duckMultiplier)) = value;
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x06000053 RID: 83 RVA: 0x000116A8 File Offset: 0x0000F8A8
	// (set) Token: 0x06000054 RID: 84 RVA: 0x00002287 File Offset: 0x00000487
	public Nullable<float> cachedDuck
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_cachedDuck);
			return new Nullable<float>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_cachedDuck), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<float>>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x06000055 RID: 85 RVA: 0x000116D8 File Offset: 0x0000F8D8
	// (set) Token: 0x06000056 RID: 86 RVA: 0x000022B5 File Offset: 0x000004B5
	public unsafe ulong cached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_cached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController.NativeFieldInfoPtr_cached)) = value;
		}
	}

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeFieldInfoPtr_musicCategories;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeFieldInfoPtr_sfxCategories;

	// Token: 0x0400002F RID: 47
	private static readonly IntPtr NativeFieldInfoPtr_ambienceCategories;

	// Token: 0x04000030 RID: 48
	private static readonly IntPtr NativeFieldInfoPtr__Model_k__BackingField;

	// Token: 0x04000031 RID: 49
	private static readonly IntPtr NativeFieldInfoPtr_duckMultiplier;

	// Token: 0x04000032 RID: 50
	private static readonly IntPtr NativeFieldInfoPtr_cachedDuck;

	// Token: 0x04000033 RID: 51
	private static readonly IntPtr NativeFieldInfoPtr_cached;

	// Token: 0x04000034 RID: 52
	private static readonly IntPtr NativeMethodInfoPtr_get_Model_Public_get_AudioPreferencesModel_0;

	// Token: 0x04000035 RID: 53
	private static readonly IntPtr NativeMethodInfoPtr_set_Model_Private_set_Void_AudioPreferencesModel_0;

	// Token: 0x04000036 RID: 54
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x04000037 RID: 55
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x04000038 RID: 56
	private static readonly IntPtr NativeMethodInfoPtr_Duck_Public_Coroutine_Single_Single_0;

	// Token: 0x04000039 RID: 57
	private static readonly IntPtr NativeMethodInfoPtr_Unduck_Public_Coroutine_Single_0;

	// Token: 0x0400003A RID: 58
	private static readonly IntPtr NativeMethodInfoPtr_duck_Private_IEnumerator_Single_Single_Single_0;

	// Token: 0x0400003B RID: 59
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Private_Void_0;

	// Token: 0x0400003C RID: 60
	private static readonly IntPtr NativeMethodInfoPtr_SetVolumes_Private_Void_IEnumerable_1_String_AudioType_Boolean_0;

	// Token: 0x0400003D RID: 61
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200018B RID: 395
	[ObfuscatedName("LotusAudioController+<duck>d__14")]
	public sealed class _duck_d__14 : global::Il2CppSystem.Object
	{
		// Token: 0x06001343 RID: 4931 RVA: 0x0004CA4C File Offset: 0x0004AC4C
		// Note: this type is marked as 'beforefieldinit'.
		static _duck_d__14()
		{
			Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LotusAudioController>.NativeClassPtr, "<duck>d__14");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr);
			LotusAudioController._duck_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "<>1__state");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "<>2__current");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr_end = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "end");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "start");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "duration");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "<>4__this");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr__ducking_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "<ducking>5__2");
			LotusAudioController._duck_d__14.NativeFieldInfoPtr__startTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, "<startTime>5__3");
			LotusAudioController._duck_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663339);
			LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663340);
			LotusAudioController._duck_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663341);
			LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663342);
			LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663343);
			LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr, 100663344);
		}

		// Token: 0x06001344 RID: 4932 RVA: 0x0004CB90 File Offset: 0x0004AD90
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _duck_d__14(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LotusAudioController._duck_d__14>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001345 RID: 4933 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x0004CC0C File Offset: 0x0004AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982253, XrefRangeEnd = 982262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700056E RID: 1390
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0004CC48 File Offset: 0x0004AE48
		public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x0004CC88 File Offset: 0x0004AE88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 982262, XrefRangeEnd = 982267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700056F RID: 1391
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x0004CCBC File Offset: 0x0004AEBC
		public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LotusAudioController._duck_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0000AF9D File Offset: 0x0000919D
		public _duck_d__14(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000566 RID: 1382
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x0004CCFC File Offset: 0x0004AEFC
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x0000AFA6 File Offset: 0x000091A6
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x17000567 RID: 1383
		// (get) Token: 0x0600134D RID: 4941 RVA: 0x0004CD24 File Offset: 0x0004AF24
		// (set) Token: 0x0600134E RID: 4942 RVA: 0x0000AFC1 File Offset: 0x000091C1
		public unsafe global::Il2CppSystem.Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x0600134F RID: 4943 RVA: 0x0004CD54 File Offset: 0x0004AF54
		// (set) Token: 0x06001350 RID: 4944 RVA: 0x0000AFE0 File Offset: 0x000091E0
		public unsafe float end
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_end);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_end)) = value;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x0004CD7C File Offset: 0x0004AF7C
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0000AFFB File Offset: 0x000091FB
		public unsafe float start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x06001353 RID: 4947 RVA: 0x0004CDA4 File Offset: 0x0004AFA4
		// (set) Token: 0x06001354 RID: 4948 RVA: 0x0000B016 File Offset: 0x00009216
		public unsafe float duration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_duration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr_duration)) = value;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x0004CDCC File Offset: 0x0004AFCC
		// (set) Token: 0x06001356 RID: 4950 RVA: 0x0000B031 File Offset: 0x00009231
		public unsafe LotusAudioController __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LotusAudioController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x06001357 RID: 4951 RVA: 0x0004CDFC File Offset: 0x0004AFFC
		// (set) Token: 0x06001358 RID: 4952 RVA: 0x0000B050 File Offset: 0x00009250
		public unsafe bool _ducking_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr__ducking_5__2);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr__ducking_5__2)) = value;
			}
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06001359 RID: 4953 RVA: 0x0004CE24 File Offset: 0x0004B024
		// (set) Token: 0x0600135A RID: 4954 RVA: 0x0000B06B File Offset: 0x0000926B
		public unsafe float _startTime_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr__startTime_5__3);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LotusAudioController._duck_d__14.NativeFieldInfoPtr__startTime_5__3)) = value;
			}
		}

		// Token: 0x04000BB4 RID: 2996
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04000BB5 RID: 2997
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04000BB6 RID: 2998
		private static readonly IntPtr NativeFieldInfoPtr_end;

		// Token: 0x04000BB7 RID: 2999
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x04000BB8 RID: 3000
		private static readonly IntPtr NativeFieldInfoPtr_duration;

		// Token: 0x04000BB9 RID: 3001
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04000BBA RID: 3002
		private static readonly IntPtr NativeFieldInfoPtr__ducking_5__2;

		// Token: 0x04000BBB RID: 3003
		private static readonly IntPtr NativeFieldInfoPtr__startTime_5__3;

		// Token: 0x04000BBC RID: 3004
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04000BBD RID: 3005
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BBE RID: 3006
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04000BBF RID: 3007
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04000BC0 RID: 3008
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04000BC1 RID: 3009
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
