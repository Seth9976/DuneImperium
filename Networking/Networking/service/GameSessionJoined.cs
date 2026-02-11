using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.service
{
	// Token: 0x02000052 RID: 82
	public class GameSessionJoined : NetworkMessageEvent
	{
		// Token: 0x060002A5 RID: 677 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		// Note: this type is marked as 'beforefieldinit'.
		static GameSessionJoined()
		{
			Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "GameSessionJoined");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr);
			GameSessionJoined.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr, "GameSessionID");
			GameSessionJoined.NativeFieldInfoPtr_PlayerAccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr, "PlayerAccountID");
			GameSessionJoined.NativeFieldInfoPtr_PlayerScreenName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr, "PlayerScreenName");
			GameSessionJoined.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr, 100663432);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000CB2C File Offset: 0x0000AD2C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameSessionJoined()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameSessionJoined>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameSessionJoined.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00003B70 File Offset: 0x00001D70
		public GameSessionJoined(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x0000CB68 File Offset: 0x0000AD68
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00003B79 File Offset: 0x00001D79
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000CB90 File Offset: 0x0000AD90
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00003B98 File Offset: 0x00001D98
		public unsafe AccountID PlayerAccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_PlayerAccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_PlayerAccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		// (set) Token: 0x060002AD RID: 685 RVA: 0x00003BB7 File Offset: 0x00001DB7
		public unsafe string PlayerScreenName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_PlayerScreenName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameSessionJoined.NativeFieldInfoPtr_PlayerScreenName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeFieldInfoPtr_PlayerAccountID;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeFieldInfoPtr_PlayerScreenName;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
