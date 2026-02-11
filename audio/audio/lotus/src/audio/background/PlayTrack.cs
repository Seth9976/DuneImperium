using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace lotus.src.audio.background
{
	// Token: 0x02000014 RID: 20
	public class PlayTrack : MonoBehaviour
	{
		// Token: 0x060000BE RID: 190 RVA: 0x00004E5C File Offset: 0x0000305C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayTrack()
		{
			Il2CppClassPointerStore<PlayTrack>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "PlayTrack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr);
			PlayTrack.NativeFieldInfoPtr_channel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr, "channel");
			PlayTrack.NativeFieldInfoPtr_track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr, "track");
			PlayTrack.NativeMethodInfoPtr_Play_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr, 100663377);
			PlayTrack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr, 100663378);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004EDC File Offset: 0x000030DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261750, XrefRangeEnd = 1261755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrack.NativeMethodInfoPtr_Play_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00004F10 File Offset: 0x00003110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1261761, RefRangeEnd = 1261763, XrefRangeStart = 1261755, XrefRangeEnd = 1261761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayTrack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayTrack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayTrack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000261F File Offset: 0x0000081F
		public PlayTrack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00004F4C File Offset: 0x0000314C
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe string channel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrack.NativeFieldInfoPtr_channel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrack.NativeFieldInfoPtr_channel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00004F74 File Offset: 0x00003174
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x00002647 File Offset: 0x00000847
		public unsafe string track
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrack.NativeFieldInfoPtr_track);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayTrack.NativeFieldInfoPtr_track), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_channel;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_track;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
