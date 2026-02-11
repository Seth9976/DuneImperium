using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

// Token: 0x02000043 RID: 67
public class CursorDefinition : MonoBehaviour
{
	// Token: 0x0600054E RID: 1358 RVA: 0x00028AE4 File Offset: 0x00026CE4
	// Note: this type is marked as 'beforefieldinit'.
	static CursorDefinition()
	{
		Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "CursorDefinition");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr);
		CursorDefinition.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr, "Texture");
		CursorDefinition.NativeFieldInfoPtr_HotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr, "HotSpot");
		CursorDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr, 100664088);
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x00028B50 File Offset: 0x00026D50
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CursorDefinition()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorDefinition>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x00003DDC File Offset: 0x00001FDC
	public CursorDefinition(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000551 RID: 1361 RVA: 0x00028B8C File Offset: 0x00026D8C
	// (set) Token: 0x06000552 RID: 1362 RVA: 0x00003DE5 File Offset: 0x00001FE5
	public unsafe Texture2D Texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorDefinition.NativeFieldInfoPtr_Texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorDefinition.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000553 RID: 1363 RVA: 0x00028BBC File Offset: 0x00026DBC
	// (set) Token: 0x06000554 RID: 1364 RVA: 0x00003E04 File Offset: 0x00002004
	public unsafe Vector2 HotSpot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorDefinition.NativeFieldInfoPtr_HotSpot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorDefinition.NativeFieldInfoPtr_HotSpot)) = value;
		}
	}

	// Token: 0x040003EF RID: 1007
	private static readonly IntPtr NativeFieldInfoPtr_Texture;

	// Token: 0x040003F0 RID: 1008
	private static readonly IntPtr NativeFieldInfoPtr_HotSpot;

	// Token: 0x040003F1 RID: 1009
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
