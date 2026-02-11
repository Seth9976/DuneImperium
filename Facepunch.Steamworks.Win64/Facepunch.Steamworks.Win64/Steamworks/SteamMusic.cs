using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000A4 RID: 164
	public class SteamMusic : SteamClientClass<SteamMusic>
	{
		// Token: 0x0600098E RID: 2446 RVA: 0x00047130 File Offset: 0x00045330
		// Note: this type is marked as 'beforefieldinit'.
		static SteamMusic()
		{
			Il2CppClassPointerStore<SteamMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr);
			SteamMusic.NativeFieldInfoPtr_OnPlaybackChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, "OnPlaybackChanged");
			SteamMusic.NativeFieldInfoPtr_OnVolumeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, "OnVolumeChanged");
			SteamMusic.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMusic_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665655);
			SteamMusic.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665656);
			SteamMusic.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665657);
			SteamMusic.NativeMethodInfoPtr_add_OnPlaybackChanged_Public_Static_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665658);
			SteamMusic.NativeMethodInfoPtr_remove_OnPlaybackChanged_Public_Static_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665659);
			SteamMusic.NativeMethodInfoPtr_add_OnVolumeChanged_Public_Static_add_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665660);
			SteamMusic.NativeMethodInfoPtr_remove_OnVolumeChanged_Public_Static_rem_Void_Action_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665661);
			SteamMusic.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665662);
			SteamMusic.NativeMethodInfoPtr_get_IsPlaying_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665663);
			SteamMusic.NativeMethodInfoPtr_get_Status_Public_Static_get_MusicStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665664);
			SteamMusic.NativeMethodInfoPtr_Play_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665665);
			SteamMusic.NativeMethodInfoPtr_Pause_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665666);
			SteamMusic.NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665667);
			SteamMusic.NativeMethodInfoPtr_PlayNext_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665668);
			SteamMusic.NativeMethodInfoPtr_get_Volume_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665669);
			SteamMusic.NativeMethodInfoPtr_set_Volume_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665670);
			SteamMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, 100665671);
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x000472DC File Offset: 0x000454DC
		public unsafe static ISteamMusic Internal
		{
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 940675, RefRangeEnd = 940684, XrefRangeStart = 940672, XrefRangeEnd = 940675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMusic_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ISteamMusic>(intPtr3) : null;
			}
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00047310 File Offset: 0x00045510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940684, XrefRangeEnd = 940689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeInterface(bool server)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref server;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SteamMusic.NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x0004735C File Offset: 0x0004555C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 940729, RefRangeEnd = 940730, XrefRangeStart = 940689, XrefRangeEnd = 940729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InstallEvents()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x00047384 File Offset: 0x00045584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940730, XrefRangeEnd = 940737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnPlaybackChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_add_OnPlaybackChanged_Public_Static_add_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x000473BC File Offset: 0x000455BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940737, XrefRangeEnd = 940744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnPlaybackChanged(Action value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_remove_OnPlaybackChanged_Public_Static_rem_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x000473F4 File Offset: 0x000455F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940744, XrefRangeEnd = 940753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnVolumeChanged(Action<float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_add_OnVolumeChanged_Public_Static_add_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0004742C File Offset: 0x0004562C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940753, XrefRangeEnd = 940762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnVolumeChanged(Action<float> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_remove_OnVolumeChanged_Public_Static_rem_Void_Action_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00047464 File Offset: 0x00045664
		public unsafe static bool IsEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940762, XrefRangeEnd = 940765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000997 RID: 2455 RVA: 0x00047494 File Offset: 0x00045694
		public unsafe static bool IsPlaying
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940765, XrefRangeEnd = 940768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_get_IsPlaying_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x000474C4 File Offset: 0x000456C4
		public unsafe static MusicStatus Status
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940768, XrefRangeEnd = 940771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_get_Status_Public_Static_get_MusicStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000474F4 File Offset: 0x000456F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940771, XrefRangeEnd = 940774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Play()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_Play_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0004751C File Offset: 0x0004571C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940774, XrefRangeEnd = 940777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Pause()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_Pause_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00047544 File Offset: 0x00045744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940777, XrefRangeEnd = 940780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayPrevious()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x0004756C File Offset: 0x0004576C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940780, XrefRangeEnd = 940783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PlayNext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_PlayNext_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x00047594 File Offset: 0x00045794
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x000475C4 File Offset: 0x000457C4
		public unsafe static float Volume
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940783, XrefRangeEnd = 940786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_get_Volume_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940786, XrefRangeEnd = 940789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr_set_Volume_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x000475F8 File Offset: 0x000457F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940789, XrefRangeEnd = 940792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamMusic()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x00002969 File Offset: 0x00000B69
		public SteamMusic(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060009A1 RID: 2465 RVA: 0x00047634 File Offset: 0x00045834
		// (set) Token: 0x060009A2 RID: 2466 RVA: 0x00002972 File Offset: 0x00000B72
		public unsafe static Action OnPlaybackChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMusic.NativeFieldInfoPtr_OnPlaybackChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMusic.NativeFieldInfoPtr_OnPlaybackChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060009A3 RID: 2467 RVA: 0x0004765C File Offset: 0x0004585C
		// (set) Token: 0x060009A4 RID: 2468 RVA: 0x00002984 File Offset: 0x00000B84
		public unsafe static Action<float> OnVolumeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SteamMusic.NativeFieldInfoPtr_OnVolumeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SteamMusic.NativeFieldInfoPtr_OnVolumeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001086 RID: 4230
		private static readonly IntPtr NativeFieldInfoPtr_OnPlaybackChanged;

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_OnVolumeChanged;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeMethodInfoPtr_get_Internal_Internal_Static_get_ISteamMusic_0;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr_InitializeInterface_Internal_Virtual_Void_Boolean_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr_InstallEvents_Internal_Static_Void_0;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeMethodInfoPtr_add_OnPlaybackChanged_Public_Static_add_Void_Action_0;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnPlaybackChanged_Public_Static_rem_Void_Action_0;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeMethodInfoPtr_add_OnVolumeChanged_Public_Static_add_Void_Action_1_Single_0;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnVolumeChanged_Public_Static_rem_Void_Action_1_Single_0;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_Static_get_Boolean_0;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_Static_get_MusicStatus_0;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Static_Void_0;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Public_Static_Void_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_PlayPrevious_Public_Static_Void_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_PlayNext_Public_Static_Void_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_get_Volume_Public_Static_get_Single_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_set_Volume_Public_Static_set_Void_Single_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000242 RID: 578
		[ObfuscatedName("Steamworks.SteamMusic+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001D6C RID: 7532 RVA: 0x00087388 File Offset: 0x00085588
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SteamMusic>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr);
				SteamMusic.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, "<>9");
				SteamMusic.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, "<>9__3_0");
				SteamMusic.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, "<>9__3_1");
				SteamMusic.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, 100665673);
				SteamMusic.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_PlaybackStatusHasChanged_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, 100665674);
				SteamMusic.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_VolumeHasChanged_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr, 100665675);
			}

			// Token: 0x06001D6D RID: 7533 RVA: 0x0008742C File Offset: 0x0008562C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamMusic.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D6E RID: 7534 RVA: 0x00087468 File Offset: 0x00085668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940668, XrefRangeEnd = 940670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_0(PlaybackStatusHasChanged_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.__c.NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_PlaybackStatusHasChanged_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D6F RID: 7535 RVA: 0x000874A8 File Offset: 0x000856A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 940670, XrefRangeEnd = 940672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _InstallEvents_b__3_1(VolumeHasChanged_t x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamMusic.__c.NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_VolumeHasChanged_t_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D70 RID: 7536 RVA: 0x0000A6F7 File Offset: 0x000088F7
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700076A RID: 1898
			// (get) Token: 0x06001D71 RID: 7537 RVA: 0x000874E8 File Offset: 0x000856E8
			// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0000A700 File Offset: 0x00008900
			public unsafe static SteamMusic.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMusic.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SteamMusic.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMusic.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076B RID: 1899
			// (get) Token: 0x06001D73 RID: 7539 RVA: 0x00087510 File Offset: 0x00085710
			// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0000A712 File Offset: 0x00008912
			public unsafe static Action<PlaybackStatusHasChanged_t> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMusic.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<PlaybackStatusHasChanged_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMusic.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700076C RID: 1900
			// (get) Token: 0x06001D75 RID: 7541 RVA: 0x00087538 File Offset: 0x00085738
			// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0000A724 File Offset: 0x00008924
			public unsafe static Action<VolumeHasChanged_t> __9__3_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SteamMusic.__c.NativeFieldInfoPtr___9__3_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VolumeHasChanged_t>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SteamMusic.__c.NativeFieldInfoPtr___9__3_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400212A RID: 8490
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400212B RID: 8491
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x0400212C RID: 8492
			private static readonly IntPtr NativeFieldInfoPtr___9__3_1;

			// Token: 0x0400212D RID: 8493
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400212E RID: 8494
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_0_Internal_Void_PlaybackStatusHasChanged_t_0;

			// Token: 0x0400212F RID: 8495
			private static readonly IntPtr NativeMethodInfoPtr__InstallEvents_b__3_1_Internal_Void_VolumeHasChanged_t_0;
		}
	}
}
