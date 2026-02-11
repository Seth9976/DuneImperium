using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using InControl;
using UnityEngine;

namespace MultiplayerBasicExample
{
	// Token: 0x0200000F RID: 15
	public class PlayerManager : MonoBehaviour
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00005774 File Offset: 0x00003974
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerManager()
		{
			Il2CppClassPointerStore<PlayerManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.Examples.dll", "MultiplayerBasicExample", "PlayerManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr);
			PlayerManager.NativeFieldInfoPtr_playerPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "playerPrefab");
			PlayerManager.NativeFieldInfoPtr_maxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "maxPlayers");
			PlayerManager.NativeFieldInfoPtr_playerPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "playerPositions");
			PlayerManager.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, "players");
			PlayerManager.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663391);
			PlayerManager.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663392);
			PlayerManager.NativeMethodInfoPtr_JoinButtonWasPressedOnDevice_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663393);
			PlayerManager.NativeMethodInfoPtr_FindPlayerUsingDevice_Private_Player_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663394);
			PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingDevice_Private_Boolean_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663395);
			PlayerManager.NativeMethodInfoPtr_OnDeviceDetached_Private_Void_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663396);
			PlayerManager.NativeMethodInfoPtr_CreatePlayer_Private_Player_InputDevice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663397);
			PlayerManager.NativeMethodInfoPtr_RemovePlayer_Private_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663398);
			PlayerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663399);
			PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr, 100663400);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000058BC File Offset: 0x00003ABC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252102, XrefRangeEnd = 1252112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000058F0 File Offset: 0x00003AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252112, XrefRangeEnd = 1252130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00005924 File Offset: 0x00003B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252130, XrefRangeEnd = 1252138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool JoinButtonWasPressedOnDevice(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_JoinButtonWasPressedOnDevice_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005974 File Offset: 0x00003B74
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1252142, RefRangeEnd = 1252145, XrefRangeStart = 1252138, XrefRangeEnd = 1252142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Player FindPlayerUsingDevice(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_FindPlayerUsingDevice_Private_Player_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000059C4 File Offset: 0x00003BC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252145, XrefRangeEnd = 1252150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ThereIsNoPlayerUsingDevice(InputDevice inputDevice)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputDevice);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_ThereIsNoPlayerUsingDevice_Private_Boolean_InputDevice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005A14 File Offset: 0x00003C14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252150, XrefRangeEnd = 1252169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000E7 RID: 231 RVA: 0x00005A58 File Offset: 0x00003C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252176, RefRangeEnd = 1252177, XrefRangeStart = 1252169, XrefRangeEnd = 1252176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000E8 RID: 232 RVA: 0x00005AA8 File Offset: 0x00003CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252177, XrefRangeEnd = 1252192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060000E9 RID: 233 RVA: 0x00005AEC File Offset: 0x00003CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252192, XrefRangeEnd = 1252209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnGUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00005B20 File Offset: 0x00003D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252209, XrefRangeEnd = 1252239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000275D File Offset: 0x0000095D
		public PlayerManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00005B5C File Offset: 0x00003D5C
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002766 File Offset: 0x00000966
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00005B8C File Offset: 0x00003D8C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002785 File Offset: 0x00000985
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002793 File Offset: 0x00000993
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

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00005BD8 File Offset: 0x00003DD8
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x000027B2 File Offset: 0x000009B2
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

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_playerPrefab;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeFieldInfoPtr_maxPlayers;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeFieldInfoPtr_playerPositions;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeFieldInfoPtr_players;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_JoinButtonWasPressedOnDevice_Private_Boolean_InputDevice_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_FindPlayerUsingDevice_Private_Player_InputDevice_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_ThereIsNoPlayerUsingDevice_Private_Boolean_InputDevice_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_OnDeviceDetached_Private_Void_InputDevice_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayer_Private_Player_InputDevice_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_RemovePlayer_Private_Void_Player_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
