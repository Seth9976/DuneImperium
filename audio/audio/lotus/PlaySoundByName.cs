using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200000D RID: 13
	public class PlaySoundByName : MonoBehaviour
	{
		// Token: 0x06000056 RID: 86 RVA: 0x000039AC File Offset: 0x00001BAC
		// Note: this type is marked as 'beforefieldinit'.
		static PlaySoundByName()
		{
			Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus", "PlaySoundByName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr);
			PlaySoundByName.NativeFieldInfoPtr_conditionallySkipMatchStartAudio = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr, "conditionallySkipMatchStartAudio");
			PlaySoundByName.NativeMethodInfoPtr_PlaySound_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr, 100663331);
			PlaySoundByName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr, 100663332);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003A18 File Offset: 0x00001C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261423, XrefRangeEnd = 1261426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlaySound(string soundName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(soundName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundByName.NativeMethodInfoPtr_PlaySound_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003A5C File Offset: 0x00001C5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 506167, RefRangeEnd = 506168, XrefRangeStart = 506167, XrefRangeEnd = 506168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaySoundByName()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaySoundByName>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaySoundByName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000022F5 File Offset: 0x000004F5
		public PlaySoundByName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003A98 File Offset: 0x00001C98
		// (set) Token: 0x0600005B RID: 91 RVA: 0x000022FE File Offset: 0x000004FE
		public unsafe bool conditionallySkipMatchStartAudio
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundByName.NativeFieldInfoPtr_conditionallySkipMatchStartAudio);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaySoundByName.NativeFieldInfoPtr_conditionallySkipMatchStartAudio)) = value;
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr_conditionallySkipMatchStartAudio;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_PlaySound_Public_Void_String_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
