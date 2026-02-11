using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Networking.lobby
{
	// Token: 0x0200009D RID: 157
	public class UpdateLobbyGamePlayerMetadata : NetworkMessageEvent
	{
		// Token: 0x0600052C RID: 1324 RVA: 0x00013E00 File Offset: 0x00012000
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateLobbyGamePlayerMetadata()
		{
			Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "UpdateLobbyGamePlayerMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr);
			UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_GameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr, "GameID");
			UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_Metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr, "Metadata");
			UpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr, 100663632);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00013E6C File Offset: 0x0001206C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpdateLobbyGamePlayerMetadata()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpdateLobbyGamePlayerMetadata>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0000528C File Offset: 0x0000348C
		public UpdateLobbyGamePlayerMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00013EA8 File Offset: 0x000120A8
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x00005295 File Offset: 0x00003495
		public unsafe GameID GameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_GameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_GameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x00013ED8 File Offset: 0x000120D8
		// (set) Token: 0x06000532 RID: 1330 RVA: 0x000052B4 File Offset: 0x000034B4
		public unsafe Dictionary<string, string> Metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_Metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_Metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002C6 RID: 710
		private static readonly IntPtr NativeFieldInfoPtr_GameID;

		// Token: 0x040002C7 RID: 711
		private static readonly IntPtr NativeFieldInfoPtr_Metadata;

		// Token: 0x040002C8 RID: 712
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
