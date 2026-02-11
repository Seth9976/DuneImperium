using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000009 RID: 9
public class SpaceGameobjectHolder : MonoBehaviour
{
	// Token: 0x06000034 RID: 52 RVA: 0x00019538 File Offset: 0x00017738
	// Note: this type is marked as 'beforefieldinit'.
	static SpaceGameobjectHolder()
	{
		Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "SpaceGameobjectHolder");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr);
		SpaceGameobjectHolder.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr, 100663331);
		SpaceGameobjectHolder.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr, 100663332);
		SpaceGameobjectHolder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr, 100663333);
	}

	// Token: 0x06000035 RID: 53 RVA: 0x000195A4 File Offset: 0x000177A4
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceGameobjectHolder.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000036 RID: 54 RVA: 0x000195D8 File Offset: 0x000177D8
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceGameobjectHolder.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000037 RID: 55 RVA: 0x0001960C File Offset: 0x0001780C
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe SpaceGameobjectHolder()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceGameobjectHolder>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceGameobjectHolder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000038 RID: 56 RVA: 0x000021B5 File Offset: 0x000003B5
	public SpaceGameobjectHolder(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0400001D RID: 29
	private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

	// Token: 0x0400001E RID: 30
	private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

	// Token: 0x0400001F RID: 31
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
