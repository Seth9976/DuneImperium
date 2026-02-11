using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000023 RID: 35
public class PlayAudioSound : MonoBehaviour
{
	// Token: 0x06000113 RID: 275 RVA: 0x00013FFC File Offset: 0x000121FC
	// Note: this type is marked as 'beforefieldinit'.
	static PlayAudioSound()
	{
		Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "PlayAudioSound");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr);
		PlayAudioSound.NativeFieldInfoPtr_SoundName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr, "SoundName");
		PlayAudioSound.NativeFieldInfoPtr_playingSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr, "playingSound");
		PlayAudioSound.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr, 100663511);
		PlayAudioSound.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr, 100663512);
		PlayAudioSound.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr, 100663513);
	}

	// Token: 0x06000114 RID: 276 RVA: 0x00014090 File Offset: 0x00012290
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983315, XrefRangeEnd = 983320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Play()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSound.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000115 RID: 277 RVA: 0x000140C4 File Offset: 0x000122C4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983320, XrefRangeEnd = 983328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Stop()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSound.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000140F8 File Offset: 0x000122F8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 983328, XrefRangeEnd = 983332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe PlayAudioSound()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayAudioSound>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayAudioSound.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000027D8 File Offset: 0x000009D8
	public PlayAudioSound(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000118 RID: 280 RVA: 0x00014134 File Offset: 0x00012334
	// (set) Token: 0x06000119 RID: 281 RVA: 0x000027E1 File Offset: 0x000009E1
	public unsafe string SoundName
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSound.NativeFieldInfoPtr_SoundName);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSound.NativeFieldInfoPtr_SoundName), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600011A RID: 282 RVA: 0x0001415C File Offset: 0x0001235C
	// (set) Token: 0x0600011B RID: 283 RVA: 0x00002800 File Offset: 0x00000A00
	public unsafe AudioObject playingSound
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSound.NativeFieldInfoPtr_playingSound);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayAudioSound.NativeFieldInfoPtr_playingSound), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeFieldInfoPtr_SoundName;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeFieldInfoPtr_playingSound;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

	// Token: 0x040000B3 RID: 179
	private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

	// Token: 0x040000B4 RID: 180
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
