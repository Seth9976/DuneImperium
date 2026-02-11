using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace lotus
{
	// Token: 0x0200000A RID: 10
	public static class AudioUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000035AC File Offset: 0x000017AC
		// Note: this type is marked as 'beforefieldinit'.
		static AudioUtil()
		{
			Il2CppClassPointerStore<AudioUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus", "AudioUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr);
			AudioUtil.NativeFieldInfoPtr_MatchStartAudioSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, "MatchStartAudioSkip");
			AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100663323);
			AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioUtil>.NativeClassPtr, 100663324);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003618 File Offset: 0x00001818
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1261333, RefRangeEnd = 1261343, XrefRangeStart = 1261322, XrefRangeEnd = 1261333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioObject Play(string sound, Transform parent = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003670 File Offset: 0x00001870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261343, XrefRangeEnd = 1261354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AudioObject Play(string sound, Vector3 globalPosition)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(sound);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref globalPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioUtil.NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AudioObject>(intPtr3) : null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000226F File Offset: 0x0000046F
		public AudioUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000036C4 File Offset: 0x000018C4
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002278 File Offset: 0x00000478
		public unsafe static bool MatchStartAudioSkip
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AudioUtil.NativeFieldInfoPtr_MatchStartAudioSkip, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioUtil.NativeFieldInfoPtr_MatchStartAudioSkip, (void*)(&value));
			}
		}

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_MatchStartAudioSkip;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Transform_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_AudioObject_String_Vector3_0;
	}
}
