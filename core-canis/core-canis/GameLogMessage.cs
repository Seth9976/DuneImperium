using System;
using Canis.messages.effect;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000020 RID: 32
public class GameLogMessage : EffectMessage
{
	// Token: 0x060002F8 RID: 760 RVA: 0x0001DD44 File Offset: 0x0001BF44
	// Note: this type is marked as 'beforefieldinit'.
	static GameLogMessage()
	{
		Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GameLogMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr);
		GameLogMessage.NativeFieldInfoPtr_Message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr, "Message");
		GameLogMessage.NativeMethodInfoPtr_get_TextVars_Public_get_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr, 100663679);
		GameLogMessage.NativeMethodInfoPtr_get_ulMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr, 100663680);
		GameLogMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr, 100663681);
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x060002F9 RID: 761 RVA: 0x0001DDC4 File Offset: 0x0001BFC4
	public unsafe Dictionary<string, Object> TextVars
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogMessage.NativeMethodInfoPtr_get_TextVars_Public_get_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr3) : null;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x060002FA RID: 762 RVA: 0x0001DE04 File Offset: 0x0001C004
	public unsafe string ulMessage
	{
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogMessage.NativeMethodInfoPtr_get_ulMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x060002FB RID: 763 RVA: 0x0001DE3C File Offset: 0x0001C03C
	[CallerCount(220)]
	[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GameLogMessage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060002FC RID: 764 RVA: 0x0000350E File Offset: 0x0000170E
	public GameLogMessage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x170000EE RID: 238
	// (get) Token: 0x060002FD RID: 765 RVA: 0x0001DE78 File Offset: 0x0001C078
	// (set) Token: 0x060002FE RID: 766 RVA: 0x00003517 File Offset: 0x00001717
	public unsafe GameLogMessage.LoggedMessage Message
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.NativeFieldInfoPtr_Message);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogMessage.LoggedMessage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.NativeFieldInfoPtr_Message), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400021B RID: 539
	private static readonly IntPtr NativeFieldInfoPtr_Message;

	// Token: 0x0400021C RID: 540
	private static readonly IntPtr NativeMethodInfoPtr_get_TextVars_Public_get_Dictionary_2_String_Object_0;

	// Token: 0x0400021D RID: 541
	private static readonly IntPtr NativeMethodInfoPtr_get_ulMessage_Public_get_String_0;

	// Token: 0x0400021E RID: 542
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000238 RID: 568
	public class LoggedMessage : Object
	{
		// Token: 0x06001E81 RID: 7809 RVA: 0x0008B714 File Offset: 0x00089914
		// Note: this type is marked as 'beforefieldinit'.
		static LoggedMessage()
		{
			Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogMessage>.NativeClassPtr, "LoggedMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr);
			GameLogMessage.LoggedMessage.NativeFieldInfoPtr_ulMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr, "ulMessage");
			GameLogMessage.LoggedMessage.NativeFieldInfoPtr_TextVars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr, "TextVars");
			GameLogMessage.LoggedMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr, 100663682);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0008B77C File Offset: 0x0008997C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoggedMessage()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogMessage.LoggedMessage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogMessage.LoggedMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0000D117 File Offset: 0x0000B317
		public LoggedMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x0008B7B8 File Offset: 0x000899B8
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x0000D120 File Offset: 0x0000B320
		public unsafe string ulMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.LoggedMessage.NativeFieldInfoPtr_ulMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.LoggedMessage.NativeFieldInfoPtr_ulMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x0008B7E0 File Offset: 0x000899E0
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x0000D13F File Offset: 0x0000B33F
		public unsafe Dictionary<string, Object> TextVars
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.LoggedMessage.NativeFieldInfoPtr_TextVars);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogMessage.LoggedMessage.NativeFieldInfoPtr_TextVars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeFieldInfoPtr_ulMessage;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeFieldInfoPtr_TextVars;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
