using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Steamworks
{
	// Token: 0x0200001F RID: 31
	public class ISteamMusic : SteamInterface
	{
		// Token: 0x06000440 RID: 1088 RVA: 0x00028BC4 File Offset: 0x00026DC4
		// Note: this type is marked as 'beforefieldinit'.
		static ISteamMusic()
		{
			Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "ISteamMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr);
			ISteamMusic.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664325);
			ISteamMusic.NativeMethodInfoPtr_SteamAPI_SteamMusic_v001_Internal_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664326);
			ISteamMusic.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664327);
			ISteamMusic.NativeMethodInfoPtr__BIsEnabled_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664328);
			ISteamMusic.NativeMethodInfoPtr_BIsEnabled_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664329);
			ISteamMusic.NativeMethodInfoPtr__BIsPlaying_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664330);
			ISteamMusic.NativeMethodInfoPtr_BIsPlaying_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664331);
			ISteamMusic.NativeMethodInfoPtr__GetPlaybackStatus_Private_Static_MusicStatus_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664332);
			ISteamMusic.NativeMethodInfoPtr_GetPlaybackStatus_Internal_MusicStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664333);
			ISteamMusic.NativeMethodInfoPtr__Play_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664334);
			ISteamMusic.NativeMethodInfoPtr_Play_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664335);
			ISteamMusic.NativeMethodInfoPtr__Pause_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664336);
			ISteamMusic.NativeMethodInfoPtr_Pause_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664337);
			ISteamMusic.NativeMethodInfoPtr__PlayPrevious_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664338);
			ISteamMusic.NativeMethodInfoPtr_PlayPrevious_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664339);
			ISteamMusic.NativeMethodInfoPtr__PlayNext_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664340);
			ISteamMusic.NativeMethodInfoPtr_PlayNext_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664341);
			ISteamMusic.NativeMethodInfoPtr__SetVolume_Private_Static_Void_IntPtr_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664342);
			ISteamMusic.NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664343);
			ISteamMusic.NativeMethodInfoPtr__GetVolume_Private_Static_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664344);
			ISteamMusic.NativeMethodInfoPtr_GetVolume_Internal_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr, 100664345);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00028D98 File Offset: 0x00026F98
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 930944, RefRangeEnd = 930966, XrefRangeStart = 930944, XrefRangeEnd = 930966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ISteamMusic(bool IsGameServer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ISteamMusic>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref IsGameServer;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00028DE0 File Offset: 0x00026FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933756, XrefRangeEnd = 933758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr SteamAPI_SteamMusic_v001()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_SteamAPI_SteamMusic_v001_Internal_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00028E10 File Offset: 0x00027010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IntPtr GetUserInterfacePointer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISteamMusic.NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00028E58 File Offset: 0x00027058
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933758, XrefRangeEnd = 933760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsEnabled(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__BIsEnabled_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00028E98 File Offset: 0x00027098
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933762, RefRangeEnd = 933763, XrefRangeStart = 933760, XrefRangeEnd = 933762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsEnabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_BIsEnabled_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00028ED4 File Offset: 0x000270D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933763, XrefRangeEnd = 933765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool _BIsPlaying(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__BIsPlaying_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00028F14 File Offset: 0x00027114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933767, RefRangeEnd = 933768, XrefRangeStart = 933765, XrefRangeEnd = 933767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BIsPlaying()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_BIsPlaying_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00028F50 File Offset: 0x00027150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933768, XrefRangeEnd = 933770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MusicStatus _GetPlaybackStatus(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__GetPlaybackStatus_Private_Static_MusicStatus_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00028F90 File Offset: 0x00027190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933772, RefRangeEnd = 933773, XrefRangeStart = 933770, XrefRangeEnd = 933772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicStatus GetPlaybackStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_GetPlaybackStatus_Internal_MusicStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00028FCC File Offset: 0x000271CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933773, XrefRangeEnd = 933775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Play(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__Play_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00029000 File Offset: 0x00027200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933777, RefRangeEnd = 933778, XrefRangeStart = 933775, XrefRangeEnd = 933777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_Play_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00029034 File Offset: 0x00027234
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933778, XrefRangeEnd = 933780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _Pause(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__Pause_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00029068 File Offset: 0x00027268
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933782, RefRangeEnd = 933783, XrefRangeStart = 933780, XrefRangeEnd = 933782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_Pause_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0002909C File Offset: 0x0002729C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933783, XrefRangeEnd = 933785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _PlayPrevious(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__PlayPrevious_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000290D0 File Offset: 0x000272D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933787, RefRangeEnd = 933788, XrefRangeStart = 933785, XrefRangeEnd = 933787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPrevious()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_PlayPrevious_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00029104 File Offset: 0x00027304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933788, XrefRangeEnd = 933790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _PlayNext(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__PlayNext_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00029138 File Offset: 0x00027338
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933792, RefRangeEnd = 933793, XrefRangeStart = 933790, XrefRangeEnd = 933792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_PlayNext_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0002916C File Offset: 0x0002736C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933793, XrefRangeEnd = 933795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void _SetVolume(IntPtr self, float flVolume)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref flVolume;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__SetVolume_Private_Static_Void_IntPtr_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000291AC File Offset: 0x000273AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933797, RefRangeEnd = 933798, XrefRangeStart = 933795, XrefRangeEnd = 933797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(float flVolume)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flVolume;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x000291EC File Offset: 0x000273EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 933798, XrefRangeEnd = 933800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float _GetVolume(IntPtr self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr__GetVolume_Private_Static_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0002922C File Offset: 0x0002742C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 933802, RefRangeEnd = 933803, XrefRangeStart = 933800, XrefRangeEnd = 933802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ISteamMusic.NativeMethodInfoPtr_GetVolume_Internal_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00002375 File Offset: 0x00000575
		public ISteamMusic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004CB RID: 1227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Boolean_0;

		// Token: 0x040004CC RID: 1228
		private static readonly IntPtr NativeMethodInfoPtr_SteamAPI_SteamMusic_v001_Internal_Static_IntPtr_0;

		// Token: 0x040004CD RID: 1229
		private static readonly IntPtr NativeMethodInfoPtr_GetUserInterfacePointer_Public_Virtual_IntPtr_0;

		// Token: 0x040004CE RID: 1230
		private static readonly IntPtr NativeMethodInfoPtr__BIsEnabled_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeMethodInfoPtr_BIsEnabled_Internal_Boolean_0;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeMethodInfoPtr__BIsPlaying_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeMethodInfoPtr_BIsPlaying_Internal_Boolean_0;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeMethodInfoPtr__GetPlaybackStatus_Private_Static_MusicStatus_IntPtr_0;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackStatus_Internal_MusicStatus_0;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeMethodInfoPtr__Play_Private_Static_Void_IntPtr_0;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeMethodInfoPtr_Play_Internal_Void_0;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeMethodInfoPtr__Pause_Private_Static_Void_IntPtr_0;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Internal_Void_0;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeMethodInfoPtr__PlayPrevious_Private_Static_Void_IntPtr_0;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_PlayPrevious_Internal_Void_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr__PlayNext_Private_Static_Void_IntPtr_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_PlayNext_Internal_Void_0;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeMethodInfoPtr__SetVolume_Private_Static_Void_IntPtr_Single_0;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_SetVolume_Internal_Void_Single_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr__GetVolume_Private_Static_Single_IntPtr_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_GetVolume_Internal_Single_0;
	}
}
