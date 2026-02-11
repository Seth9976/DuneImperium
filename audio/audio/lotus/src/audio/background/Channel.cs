using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace lotus.src.audio.background
{
	// Token: 0x02000012 RID: 18
	[Serializable]
	public class Channel : Object
	{
		// Token: 0x060000A6 RID: 166 RVA: 0x000049CC File Offset: 0x00002BCC
		// Note: this type is marked as 'beforefieldinit'.
		static Channel()
		{
			Il2CppClassPointerStore<Channel>.NativeClassPtr = IL2CPP.GetIl2CppClass("audio.dll", "lotus.src.audio.background", "Channel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Channel>.NativeClassPtr);
			Channel.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "name");
			Channel.NativeFieldInfoPtr_tracks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "tracks");
			Channel.NativeFieldInfoPtr_activeTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Channel>.NativeClassPtr, "activeTrack");
			Channel.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100663363);
			Channel.NativeMethodInfoPtr_get_ActiveTrack_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100663364);
			Channel.NativeMethodInfoPtr_PlayTrack_Public_Void_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100663365);
			Channel.NativeMethodInfoPtr_Stop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100663366);
			Channel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Channel>.NativeClassPtr, 100663367);
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00004A9C File Offset: 0x00002C9C
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Channel.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00004AD4 File Offset: 0x00002CD4
		public unsafe string ActiveTrack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Channel.NativeMethodInfoPtr_get_ActiveTrack_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00004B0C File Offset: 0x00002D0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1261698, RefRangeEnd = 1261699, XrefRangeStart = 1261689, XrefRangeEnd = 1261698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(string track, out string error)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(track);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Channel.NativeMethodInfoPtr_PlayTrack_Public_Void_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			error = IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004B68 File Offset: 0x00002D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261699, XrefRangeEnd = 1261701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Channel.NativeMethodInfoPtr_Stop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00004B9C File Offset: 0x00002D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261701, XrefRangeEnd = 1261709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Channel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Channel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Channel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002557 File Offset: 0x00000757
		public Channel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00004BD8 File Offset: 0x00002DD8
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002560 File Offset: 0x00000760
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00004C00 File Offset: 0x00002E00
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000257F File Offset: 0x0000077F
		public unsafe Il2CppReferenceArray<Track> tracks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_tracks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Track>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_tracks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00004C30 File Offset: 0x00002E30
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000259E File Offset: 0x0000079E
		public unsafe Track activeTrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_activeTrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Track>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Channel.NativeFieldInfoPtr_activeTrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeFieldInfoPtr_tracks;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeFieldInfoPtr_activeTrack;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveTrack_Public_get_String_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_String_byref_String_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Void_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
