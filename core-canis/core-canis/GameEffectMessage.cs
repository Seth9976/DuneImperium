using System;
using Canis.messages.effect;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x0200001F RID: 31
public class GameEffectMessage : EffectMessage
{
	// Token: 0x060002EF RID: 751 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
	// Note: this type is marked as 'beforefieldinit'.
	static GameEffectMessage()
	{
		Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GameEffectMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr);
		GameEffectMessage.NativeFieldInfoPtr_SourceID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr, "SourceID");
		GameEffectMessage.NativeFieldInfoPtr_Targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr, "Targets");
		GameEffectMessage.NativeFieldInfoPtr_Msg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr, "Msg");
		GameEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr, 100663678);
	}

	// Token: 0x060002F0 RID: 752 RVA: 0x0001DC78 File Offset: 0x0001BE78
	[CallerCount(220)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameEffectMessage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameEffectMessage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameEffectMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002F1 RID: 753 RVA: 0x000034A8 File Offset: 0x000016A8
	public GameEffectMessage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060002F2 RID: 754 RVA: 0x0001DCB4 File Offset: 0x0001BEB4
	// (set) Token: 0x060002F3 RID: 755 RVA: 0x000034B1 File Offset: 0x000016B1
	public unsafe EntityID SourceID
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_SourceID);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_SourceID), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000EC RID: 236
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x0001DCE4 File Offset: 0x0001BEE4
	// (set) Token: 0x060002F5 RID: 757 RVA: 0x000034D0 File Offset: 0x000016D0
	public unsafe Il2CppReferenceArray<EntityID> Targets
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_Targets);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EntityID>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_Targets), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x060002F6 RID: 758 RVA: 0x0001DD14 File Offset: 0x0001BF14
	// (set) Token: 0x060002F7 RID: 759 RVA: 0x000034EF File Offset: 0x000016EF
	public unsafe EffectMessage Msg
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_Msg);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<EffectMessage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameEffectMessage.NativeFieldInfoPtr_Msg), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000217 RID: 535
	private static readonly IntPtr NativeFieldInfoPtr_SourceID;

	// Token: 0x04000218 RID: 536
	private static readonly IntPtr NativeFieldInfoPtr_Targets;

	// Token: 0x04000219 RID: 537
	private static readonly IntPtr NativeFieldInfoPtr_Msg;

	// Token: 0x0400021A RID: 538
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
