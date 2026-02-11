using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.AddressableAssets;

// Token: 0x02000005 RID: 5
public class LoadSceneOnAwake : MonoBehaviour
{
	// Token: 0x0600000F RID: 15 RVA: 0x000106B4 File Offset: 0x0000E8B4
	// Note: this type is marked as 'beforefieldinit'.
	static LoadSceneOnAwake()
	{
		Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "", "LoadSceneOnAwake");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr);
		LoadSceneOnAwake.NativeFieldInfoPtr_sceneReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr, "sceneReference");
		LoadSceneOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr, 100663301);
		LoadSceneOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr, 100663302);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00010720 File Offset: 0x0000E920
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneOnAwake.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00010754 File Offset: 0x0000E954
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LoadSceneOnAwake()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadSceneOnAwake>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadSceneOnAwake.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020DE File Offset: 0x000002DE
	public LoadSceneOnAwake(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00010790 File Offset: 0x0000E990
	// (set) Token: 0x06000014 RID: 20 RVA: 0x000020E7 File Offset: 0x000002E7
	public unsafe AssetReference sceneReference
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSceneOnAwake.NativeFieldInfoPtr_sceneReference);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadSceneOnAwake.NativeFieldInfoPtr_sceneReference), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_sceneReference;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
