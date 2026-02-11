using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus.src.audio.background
{
	// Token: 0x02000011 RID: 17
	public class BackgroundAudio : MonoBehaviour
	{
		// Token: 0x0600009D RID: 157 RVA: 0x00004770 File Offset: 0x00002970
		// Note: this type is marked as 'beforefieldinit'.
		static BackgroundAudio()
		{
			Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "BackgroundAudio");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr);
			BackgroundAudio.NativeFieldInfoPtr_channels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, "channels");
			BackgroundAudio.NativeMethodInfoPtr_GetChannels_Public_IList_1_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, 100663358);
			BackgroundAudio.NativeMethodInfoPtr_StopChannel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, 100663359);
			BackgroundAudio.NativeMethodInfoPtr_findChannel_Private_Boolean_String_byref_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, 100663360);
			BackgroundAudio.NativeMethodInfoPtr_PlayTrack_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, 100663361);
			BackgroundAudio.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr, 100663362);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004818 File Offset: 0x00002A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261591, XrefRangeEnd = 1261595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IList<Channel> GetChannels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundAudio.NativeMethodInfoPtr_GetChannels_Public_IList_1_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<Channel>>(intPtr3) : null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004858 File Offset: 0x00002A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261595, XrefRangeEnd = 1261598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopChannel(string channelName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(channelName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundAudio.NativeMethodInfoPtr_StopChannel_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000489C File Offset: 0x00002A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1261632, RefRangeEnd = 1261634, XrefRangeStart = 1261598, XrefRangeEnd = 1261632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool findChannel(string channelName, out Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(channelName);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BackgroundAudio.NativeMethodInfoPtr_findChannel_Private_Boolean_String_byref_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			channel = ((intPtr4 == 0) ? null : new Channel(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000490C File Offset: 0x00002B0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1261677, RefRangeEnd = 1261681, XrefRangeStart = 1261634, XrefRangeEnd = 1261677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string channel, string track)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(channel);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(track);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundAudio.NativeMethodInfoPtr_PlayTrack_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004960 File Offset: 0x00002B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261681, XrefRangeEnd = 1261689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BackgroundAudio()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BackgroundAudio>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BackgroundAudio.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000252F File Offset: 0x0000072F
		public BackgroundAudio(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000499C File Offset: 0x00002B9C
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002538 File Offset: 0x00000738
		public unsafe List<Channel> channels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundAudio.NativeFieldInfoPtr_channels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Channel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BackgroundAudio.NativeFieldInfoPtr_channels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeFieldInfoPtr_channels;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_GetChannels_Public_IList_1_Channel_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_StopChannel_Public_Void_String_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_findChannel_Private_Boolean_String_byref_Channel_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
