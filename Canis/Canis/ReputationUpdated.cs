using System;
using Canis.json.events;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200000A RID: 10
public class ReputationUpdated : NetworkMessageEvent
{
	// Token: 0x0600004B RID: 75 RVA: 0x0001A7D0 File Offset: 0x000189D0
	// Note: this type is marked as 'beforefieldinit'.
	static ReputationUpdated()
	{
		Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "", "ReputationUpdated");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr);
		ReputationUpdated.NativeFieldInfoPtr_account = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, "account");
		ReputationUpdated.NativeFieldInfoPtr_change = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, "change");
		ReputationUpdated.NativeFieldInfoPtr_newReputation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, "newReputation");
		ReputationUpdated.NativeFieldInfoPtr_players = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, "players");
		ReputationUpdated.NativeFieldInfoPtr_startedAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, "startedAt");
		ReputationUpdated.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr, 100663309);
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0001A878 File Offset: 0x00018A78
	[CallerCount(114)]
	[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ReputationUpdated()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReputationUpdated>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReputationUpdated.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002309 File Offset: 0x00000509
	public ReputationUpdated(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x0600004E RID: 78 RVA: 0x0001A8B4 File Offset: 0x00018AB4
	// (set) Token: 0x0600004F RID: 79 RVA: 0x00002312 File Offset: 0x00000512
	public unsafe AccountID account
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_account);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_account), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000050 RID: 80 RVA: 0x0001A8E4 File Offset: 0x00018AE4
	// (set) Token: 0x06000051 RID: 81 RVA: 0x00002331 File Offset: 0x00000531
	public unsafe int change
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_change);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_change)) = value;
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000052 RID: 82 RVA: 0x0001A90C File Offset: 0x00018B0C
	// (set) Token: 0x06000053 RID: 83 RVA: 0x0000234C File Offset: 0x0000054C
	public unsafe int newReputation
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_newReputation);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_newReputation)) = value;
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000054 RID: 84 RVA: 0x0001A934 File Offset: 0x00018B34
	// (set) Token: 0x06000055 RID: 85 RVA: 0x00002367 File Offset: 0x00000567
	public unsafe List<AccountIDUsernameMetadata> players
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_players);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AccountIDUsernameMetadata>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_players), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000056 RID: 86 RVA: 0x0001A964 File Offset: 0x00018B64
	// (set) Token: 0x06000057 RID: 87 RVA: 0x00002386 File Offset: 0x00000586
	public unsafe long startedAt
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_startedAt);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReputationUpdated.NativeFieldInfoPtr_startedAt)) = value;
		}
	}

	// Token: 0x04000024 RID: 36
	private static readonly IntPtr NativeFieldInfoPtr_account;

	// Token: 0x04000025 RID: 37
	private static readonly IntPtr NativeFieldInfoPtr_change;

	// Token: 0x04000026 RID: 38
	private static readonly IntPtr NativeFieldInfoPtr_newReputation;

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr_players;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr_startedAt;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
