using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.platform.websocket.incoming
{
	// Token: 0x0200003B RID: 59
	public class Invitations : TypedMessage
	{
		// Token: 0x06000201 RID: 513 RVA: 0x0000BB54 File Offset: 0x00009D54
		// Note: this type is marked as 'beforefieldinit'.
		static Invitations()
		{
			Il2CppClassPointerStore<Invitations>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.incoming", "Invitations");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Invitations>.NativeClassPtr);
			Invitations.NativeFieldInfoPtr_ReceivedInvites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Invitations>.NativeClassPtr, "ReceivedInvites");
			Invitations.NativeFieldInfoPtr_SentInvites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Invitations>.NativeClassPtr, "SentInvites");
			Invitations.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Invitations>.NativeClassPtr, 100663620);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Invitations()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Invitations>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Invitations.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00003017 File Offset: 0x00001217
		public Invitations(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0000BBFC File Offset: 0x00009DFC
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00003020 File Offset: 0x00001220
		public unsafe Il2CppReferenceArray<InvitationEntry> ReceivedInvites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invitations.NativeFieldInfoPtr_ReceivedInvites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invitations.NativeFieldInfoPtr_ReceivedInvites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000206 RID: 518 RVA: 0x0000BC2C File Offset: 0x00009E2C
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000303F File Offset: 0x0000123F
		public unsafe Il2CppReferenceArray<InvitationEntry> SentInvites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invitations.NativeFieldInfoPtr_SentInvites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InvitationEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Invitations.NativeFieldInfoPtr_SentInvites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeFieldInfoPtr_ReceivedInvites;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeFieldInfoPtr_SentInvites;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
