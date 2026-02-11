using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using InControl;
using UnityEngine;

namespace MultiplayerWithBindingsExample
{
	// Token: 0x0200000D RID: 13
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00004ED8 File Offset: 0x000030D8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerManager()
		{
			Il2CppClassPointerStore<PlayerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "MultiplayerWithBindingsExample", "PlayerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr);
			PlayerManager.NativeFieldInfoPtr_playerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "playerPrefab");
			PlayerManager.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "maxPlayers");
			PlayerManager.NativeFieldInfoPtr_playerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "playerPositions");
			PlayerManager.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "players");
			PlayerManager.NativeFieldInfoPtr_keyboardListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "keyboardListener");
			PlayerManager.NativeFieldInfoPtr_joystickListener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "joystickListener");
			PlayerManager.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663372);
			PlayerManager.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663373);
			PlayerManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663374);
			PlayerManager.NativeMethodInfoPtr_JoinButtonWasPressedOnListener_Private_Boolean_PlayerActions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663375);
			PlayerManager.NativeMethodInfoPtr_FindPlayerUsingJoystick_Private_Player_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663376);
			PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingJoystick_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663377);
			PlayerManager.NativeMethodInfoPtr_FindPlayerUsingKeyboard_Private_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663378);
			PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingKeyboard_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663379);
			PlayerManager.NativeMethodInfoPtr_OnDeviceDetached_Private_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663380);
			PlayerManager.NativeMethodInfoPtr_CreatePlayer_Private_Player_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663381);
			PlayerManager.NativeMethodInfoPtr_RemovePlayer_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663382);
			PlayerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663383);
			PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663384);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00005084 File Offset: 0x00003284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251891, XrefRangeEnd = 1251905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000050B8 File Offset: 0x000032B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251905, XrefRangeEnd = 1251918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000050EC File Offset: 0x000032EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251918, XrefRangeEnd = 1251945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005120 File Offset: 0x00003320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251945, XrefRangeEnd = 1251949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JoinButtonWasPressedOnListener(PlayerActions actions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(actions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_JoinButtonWasPressedOnListener_Private_Boolean_PlayerActions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00005170 File Offset: 0x00003370
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1251953, RefRangeEnd = 1251956, XrefRangeStart = 1251949, XrefRangeEnd = 1251953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player FindPlayerUsingJoystick(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_FindPlayerUsingJoystick_Private_Player_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000051C0 File Offset: 0x000033C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251956, XrefRangeEnd = 1251961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ThereIsNoPlayerUsingJoystick(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingJoystick_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00005210 File Offset: 0x00003410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251961, XrefRangeEnd = 1251965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player FindPlayerUsingKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_FindPlayerUsingKeyboard_Private_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005250 File Offset: 0x00003450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251965, XrefRangeEnd = 1251974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ThereIsNoPlayerUsingKeyboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingKeyboard_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000528C File Offset: 0x0000348C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1251974, XrefRangeEnd = 1251993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeviceDetached(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_OnDeviceDetached_Private_Void_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000052D0 File Offset: 0x000034D0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1252000, RefRangeEnd = 1252002, XrefRangeStart = 1251993, XrefRangeEnd = 1252000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player CreatePlayer(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_CreatePlayer_Private_Player_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005320 File Offset: 0x00003520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252002, XrefRangeEnd = 1252017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemovePlayer(Player player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_RemovePlayer_Private_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005364 File Offset: 0x00003564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252017, XrefRangeEnd = 1252034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005398 File Offset: 0x00003598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252034, XrefRangeEnd = 1252064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002664 File Offset: 0x00000864
		public PlayerManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x000053D4 File Offset: 0x000035D4
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000266D File Offset: 0x0000086D
		public unsafe GameObject playerPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_playerPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_playerPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00005404 File Offset: 0x00003604
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000268C File Offset: 0x0000088C
		public unsafe static int maxPlayers
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(PlayerManager.NativeFieldInfoPtr_maxPlayers, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerManager.NativeFieldInfoPtr_maxPlayers, (void*)(&value));
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00005420 File Offset: 0x00003620
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000269A File Offset: 0x0000089A
		public unsafe List<Vector3> playerPositions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_playerPositions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_playerPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CE RID: 206 RVA: 0x00005450 File Offset: 0x00003650
		// (set) Token: 0x060000CF RID: 207 RVA: 0x000026B9 File Offset: 0x000008B9
		public unsafe List<Player> players
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_players);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005480 File Offset: 0x00003680
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x000026D8 File Offset: 0x000008D8
		public unsafe PlayerActions keyboardListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_keyboardListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerActions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_keyboardListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x000054B0 File Offset: 0x000036B0
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x000026F7 File Offset: 0x000008F7
		public unsafe PlayerActions joystickListener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_joystickListener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerActions>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerManager.NativeFieldInfoPtr_joystickListener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefab;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_maxPlayers;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_playerPositions;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_keyboardListener;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_joystickListener;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_JoinButtonWasPressedOnListener_Private_Boolean_PlayerActions_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerUsingJoystick_Private_Player_InputDevice_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_ThereIsNoPlayerUsingJoystick_Private_Boolean_InputDevice_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerUsingKeyboard_Private_Player_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ThereIsNoPlayerUsingKeyboard_Private_Boolean_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_OnDeviceDetached_Private_Void_InputDevice_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayer_Private_Player_InputDevice_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Private_Void_Player_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
