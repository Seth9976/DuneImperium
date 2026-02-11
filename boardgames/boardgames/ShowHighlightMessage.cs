using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.eventtriggers.clientactions;

// Token: 0x02000015 RID: 21
public class ShowHighlightMessage : ClientAction
{
	// Token: 0x060000B4 RID: 180 RVA: 0x00012E34 File Offset: 0x00011034
	// Note: this type is marked as 'beforefieldinit'.
	static ShowHighlightMessage()
	{
		Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "ShowHighlightMessage");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr);
		ShowHighlightMessage.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr, "key");
		ShowHighlightMessage.NativeFieldInfoPtr_show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr, "show");
		ShowHighlightMessage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr, 100663437);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00012EA0 File Offset: 0x000110A0
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe ShowHighlightMessage()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowHighlightMessage>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowHighlightMessage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002497 File Offset: 0x00000697
	public ShowHighlightMessage(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x00012EDC File Offset: 0x000110DC
	// (set) Token: 0x060000B8 RID: 184 RVA: 0x000024A0 File Offset: 0x000006A0
	public unsafe string key
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessage.NativeFieldInfoPtr_key);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessage.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060000B9 RID: 185 RVA: 0x00012F04 File Offset: 0x00011104
	// (set) Token: 0x060000BA RID: 186 RVA: 0x000024BF File Offset: 0x000006BF
	public unsafe bool show
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessage.NativeFieldInfoPtr_show);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowHighlightMessage.NativeFieldInfoPtr_show)) = value;
		}
	}

	// Token: 0x0400007B RID: 123
	private static readonly IntPtr NativeFieldInfoPtr_key;

	// Token: 0x0400007C RID: 124
	private static readonly IntPtr NativeFieldInfoPtr_show;

	// Token: 0x0400007D RID: 125
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
