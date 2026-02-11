using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.lobby.responses
{
	// Token: 0x020000A6 RID: 166
	public class LobbyJoinFailed : NetworkMessageEvent
	{
		// Token: 0x06000567 RID: 1383 RVA: 0x00014664 File Offset: 0x00012864
		// Note: this type is marked as 'beforefieldinit'.
		static LobbyJoinFailed()
		{
			Il2CppClassPointerStore<LobbyJoinFailed>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby.responses", "LobbyJoinFailed");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LobbyJoinFailed>.NativeClassPtr);
			LobbyJoinFailed.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LobbyJoinFailed>.NativeClassPtr, "Message");
			LobbyJoinFailed.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LobbyJoinFailed>.NativeClassPtr, 100663641);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000146BC File Offset: 0x000128BC
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LobbyJoinFailed()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LobbyJoinFailed>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LobbyJoinFailed.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x000054FA File Offset: 0x000036FA
		public LobbyJoinFailed(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600056A RID: 1386 RVA: 0x000146F8 File Offset: 0x000128F8
		// (set) Token: 0x0600056B RID: 1387 RVA: 0x00005503 File Offset: 0x00003703
		public unsafe string Message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoinFailed.NativeFieldInfoPtr_Message);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LobbyJoinFailed.NativeFieldInfoPtr_Message), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeFieldInfoPtr_Message;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
