using System;
using dwd.core.endorsement;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

// Token: 0x02000020 RID: 32
public class SceneChangeRequest : Request
{
	// Token: 0x06000101 RID: 257 RVA: 0x00013CAC File Offset: 0x00011EAC
	// Note: this type is marked as 'beforefieldinit'.
	static SceneChangeRequest()
	{
		Il2CppClassPointerStore<SceneChangeRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "SceneChangeRequest");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneChangeRequest>.NativeClassPtr);
		SceneChangeRequest.NativeFieldInfoPtr_Scene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneChangeRequest>.NativeClassPtr, "Scene");
		SceneChangeRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneChangeRequest>.NativeClassPtr, 100663499);
	}

	// Token: 0x06000102 RID: 258 RVA: 0x00013D04 File Offset: 0x00011F04
	[CallerCount(15)]
	[CachedScanResults(RefRangeStart = 983240, RefRangeEnd = 983255, XrefRangeStart = 983238, XrefRangeEnd = 983240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SceneChangeRequest(string scene)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneChangeRequest>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(scene);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SceneChangeRequest.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002760 File Offset: 0x00000960
	public SceneChangeRequest(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000104 RID: 260 RVA: 0x00013D50 File Offset: 0x00011F50
	// (set) Token: 0x06000105 RID: 261 RVA: 0x00002769 File Offset: 0x00000969
	public unsafe string Scene
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeRequest.NativeFieldInfoPtr_Scene);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SceneChangeRequest.NativeFieldInfoPtr_Scene), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x040000A7 RID: 167
	private static readonly IntPtr NativeFieldInfoPtr_Scene;

	// Token: 0x040000A8 RID: 168
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
}
