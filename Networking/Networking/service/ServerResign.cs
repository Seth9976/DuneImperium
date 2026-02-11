using System;
using Canis.json.events;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.service
{
	// Token: 0x0200005C RID: 92
	public class ServerResign : NetworkMessageEvent
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0000D4D4 File Offset: 0x0000B6D4
		// Note: this type is marked as 'beforefieldinit'.
		static ServerResign()
		{
			Il2CppClassPointerStore<ServerResign>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "ServerResign");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServerResign>.NativeClassPtr);
			ServerResign.NativeFieldInfoPtr_GameSessionID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResign>.NativeClassPtr, "GameSessionID");
			ServerResign.NativeFieldInfoPtr_AccountID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServerResign>.NativeClassPtr, "AccountID");
			ServerResign.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServerResign>.NativeClassPtr, 100663443);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0000D540 File Offset: 0x0000B740
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServerResign()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServerResign>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServerResign.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00003F32 File Offset: 0x00002132
		public ServerResign(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000D57C File Offset: 0x0000B77C
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00003F3B File Offset: 0x0000213B
		public unsafe string GameSessionID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerResign.NativeFieldInfoPtr_GameSessionID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerResign.NativeFieldInfoPtr_GameSessionID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00003F5A File Offset: 0x0000215A
		public unsafe AccountID AccountID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerResign.NativeFieldInfoPtr_AccountID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServerResign.NativeFieldInfoPtr_AccountID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeFieldInfoPtr_GameSessionID;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeFieldInfoPtr_AccountID;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
