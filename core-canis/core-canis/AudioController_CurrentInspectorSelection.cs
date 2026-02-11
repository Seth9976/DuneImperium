using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

// Token: 0x02000006 RID: 6
[Serializable]
public class AudioController_CurrentInspectorSelection : Object
{
	// Token: 0x060000DC RID: 220 RVA: 0x0001701C File Offset: 0x0001521C
	// Note: this type is marked as 'beforefieldinit'.
	static AudioController_CurrentInspectorSelection()
	{
		Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "AudioController_CurrentInspectorSelection");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr);
		AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentCategoryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr, "currentCategoryIndex");
		AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentItemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr, "currentItemIndex");
		AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentSubitemIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr, "currentSubitemIndex");
		AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentPlaylistIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr, "currentPlaylistIndex");
		AudioController_CurrentInspectorSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr, 100663433);
	}

	// Token: 0x060000DD RID: 221 RVA: 0x000170B0 File Offset: 0x000152B0
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe AudioController_CurrentInspectorSelection()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioController_CurrentInspectorSelection>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioController_CurrentInspectorSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060000DE RID: 222 RVA: 0x00002497 File Offset: 0x00000697
	public AudioController_CurrentInspectorSelection(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x060000DF RID: 223 RVA: 0x000170EC File Offset: 0x000152EC
	// (set) Token: 0x060000E0 RID: 224 RVA: 0x000024A0 File Offset: 0x000006A0
	public unsafe int currentCategoryIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentCategoryIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentCategoryIndex)) = value;
		}
	}

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x00017114 File Offset: 0x00015314
	// (set) Token: 0x060000E2 RID: 226 RVA: 0x000024BB File Offset: 0x000006BB
	public unsafe int currentItemIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentItemIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentItemIndex)) = value;
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x0001713C File Offset: 0x0001533C
	// (set) Token: 0x060000E4 RID: 228 RVA: 0x000024D6 File Offset: 0x000006D6
	public unsafe int currentSubitemIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentSubitemIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentSubitemIndex)) = value;
		}
	}

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x00017164 File Offset: 0x00015364
	// (set) Token: 0x060000E6 RID: 230 RVA: 0x000024F1 File Offset: 0x000006F1
	public unsafe int currentPlaylistIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentPlaylistIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioController_CurrentInspectorSelection.NativeFieldInfoPtr_currentPlaylistIndex)) = value;
		}
	}

	// Token: 0x040000AE RID: 174
	private static readonly IntPtr NativeFieldInfoPtr_currentCategoryIndex;

	// Token: 0x040000AF RID: 175
	private static readonly IntPtr NativeFieldInfoPtr_currentItemIndex;

	// Token: 0x040000B0 RID: 176
	private static readonly IntPtr NativeFieldInfoPtr_currentSubitemIndex;

	// Token: 0x040000B1 RID: 177
	private static readonly IntPtr NativeFieldInfoPtr_currentPlaylistIndex;

	// Token: 0x040000B2 RID: 178
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
