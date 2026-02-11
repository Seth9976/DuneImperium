using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x02000009 RID: 9
	public class AnimationPlaySoundByIndex : MonoBehaviour
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00003458 File Offset: 0x00001658
		// Note: this type is marked as 'beforefieldinit'.
		static AnimationPlaySoundByIndex()
		{
			Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus", "AnimationPlaySoundByIndex");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr);
			AnimationPlaySoundByIndex.NativeFieldInfoPtr_sounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr, "sounds");
			AnimationPlaySoundByIndex.NativeFieldInfoPtr_conditionallySkipMatchStartAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr, "conditionallySkipMatchStartAudio");
			AnimationPlaySoundByIndex.NativeMethodInfoPtr_PlaySound_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr, 100663321);
			AnimationPlaySoundByIndex.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr, 100663322);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000034D8 File Offset: 0x000016D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261314, XrefRangeEnd = 1261317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySound(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlaySoundByIndex.NativeMethodInfoPtr_PlaySound_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003518 File Offset: 0x00001718
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261317, XrefRangeEnd = 1261322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnimationPlaySoundByIndex()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimationPlaySoundByIndex>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnimationPlaySoundByIndex.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000222C File Offset: 0x0000042C
		public AnimationPlaySoundByIndex(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003554 File Offset: 0x00001754
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002235 File Offset: 0x00000435
		public unsafe Il2CppStringArray sounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySoundByIndex.NativeFieldInfoPtr_sounds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySoundByIndex.NativeFieldInfoPtr_sounds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00003584 File Offset: 0x00001784
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00002254 File Offset: 0x00000454
		public unsafe bool conditionallySkipMatchStartAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySoundByIndex.NativeFieldInfoPtr_conditionallySkipMatchStartAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AnimationPlaySoundByIndex.NativeFieldInfoPtr_conditionallySkipMatchStartAudio)) = value;
			}
		}

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_sounds;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_conditionallySkipMatchStartAudio;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Void_Int32_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
