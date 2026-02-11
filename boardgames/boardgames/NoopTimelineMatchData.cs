using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000017 RID: 23
public class NoopTimelineMatchData : Object
{
	// Token: 0x060000C0 RID: 192 RVA: 0x00013070 File Offset: 0x00011270
	// Note: this type is marked as 'beforefieldinit'.
	static NoopTimelineMatchData()
	{
		Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "NoopTimelineMatchData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr);
		NoopTimelineMatchData.NativeFieldInfoPtr__Initialized_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, "<Initialized>k__BackingField");
		NoopTimelineMatchData.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, 100663447);
		NoopTimelineMatchData.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, 100663448);
		NoopTimelineMatchData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, 100663449);
		NoopTimelineMatchData.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_SerializedGameState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, 100663450);
		NoopTimelineMatchData.NativeMethodInfoPtr_Apply_Public_Virtual_Final_New_Void_IGameMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr, 100663451);
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x00013118 File Offset: 0x00011318
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x00013154 File Offset: 0x00011354
	public unsafe virtual bool Initialized
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoopTimelineMatchData.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoopTimelineMatchData.NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x00013194 File Offset: 0x00011394
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 344029, RefRangeEnd = 344037, XrefRangeStart = 344029, XrefRangeEnd = 344037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe NoopTimelineMatchData()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoopTimelineMatchData>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoopTimelineMatchData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x000131D0 File Offset: 0x000113D0
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Initialize(SerializedGameState state)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoopTimelineMatchData.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_SerializedGameState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00013214 File Offset: 0x00011414
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Apply(IGameMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoopTimelineMatchData.NativeMethodInfoPtr_Apply_Public_Virtual_Final_New_Void_IGameMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000024E3 File Offset: 0x000006E3
	public NoopTimelineMatchData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700002C RID: 44
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x00013258 File Offset: 0x00011458
	// (set) Token: 0x060000C8 RID: 200 RVA: 0x000024EC File Offset: 0x000006EC
	public unsafe bool _Initialized_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoopTimelineMatchData.NativeFieldInfoPtr__Initialized_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoopTimelineMatchData.NativeFieldInfoPtr__Initialized_k__BackingField)) = value;
		}
	}

	// Token: 0x04000081 RID: 129
	private static readonly IntPtr NativeFieldInfoPtr__Initialized_k__BackingField;

	// Token: 0x04000082 RID: 130
	private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

	// Token: 0x04000083 RID: 131
	private static readonly IntPtr NativeMethodInfoPtr_set_Initialized_Private_set_Void_Boolean_0;

	// Token: 0x04000084 RID: 132
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000085 RID: 133
	private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_SerializedGameState_0;

	// Token: 0x04000086 RID: 134
	private static readonly IntPtr NativeMethodInfoPtr_Apply_Public_Virtual_Final_New_Void_IGameMessage_0;
}
