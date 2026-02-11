using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000044 RID: 68
[Serializable]
public class CursorRecord : global::Il2CppSystem.Object
{
	// Token: 0x06000555 RID: 1365 RVA: 0x00028BE4 File Offset: 0x00026DE4
	// Note: this type is marked as 'beforefieldinit'.
	static CursorRecord()
	{
		Il2CppClassPointerStore<CursorRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "CursorRecord");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr);
		CursorRecord.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr, "name");
		CursorRecord.NativeFieldInfoPtr_texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr, "texture");
		CursorRecord.NativeFieldInfoPtr_hotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr, "hotSpot");
		CursorRecord.NativeFieldInfoPtr_mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr, "mode");
		CursorRecord.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr, 100664089);
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x00028C78 File Offset: 0x00026E78
	[CallerCount(2676)]
	[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CursorRecord()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorRecord>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorRecord.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x00003E1F File Offset: 0x0000201F
	public CursorRecord(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000558 RID: 1368 RVA: 0x00028CB4 File Offset: 0x00026EB4
	// (set) Token: 0x06000559 RID: 1369 RVA: 0x00003E28 File Offset: 0x00002028
	public unsafe string name
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_name);
			return IL2CPP.Il2CppStringToManaged(*intPtr);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
		}
	}

	// Token: 0x1700018F RID: 399
	// (get) Token: 0x0600055A RID: 1370 RVA: 0x00028CDC File Offset: 0x00026EDC
	// (set) Token: 0x0600055B RID: 1371 RVA: 0x00003E47 File Offset: 0x00002047
	public unsafe Texture2D texture
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_texture);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_texture), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000190 RID: 400
	// (get) Token: 0x0600055C RID: 1372 RVA: 0x00028D0C File Offset: 0x00026F0C
	// (set) Token: 0x0600055D RID: 1373 RVA: 0x00003E66 File Offset: 0x00002066
	public unsafe Vector2 hotSpot
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_hotSpot);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_hotSpot)) = value;
		}
	}

	// Token: 0x17000191 RID: 401
	// (get) Token: 0x0600055E RID: 1374 RVA: 0x00028D34 File Offset: 0x00026F34
	// (set) Token: 0x0600055F RID: 1375 RVA: 0x00003E81 File Offset: 0x00002081
	public unsafe CursorMode mode
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_mode);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CursorRecord.NativeFieldInfoPtr_mode)) = value;
		}
	}

	// Token: 0x040003F2 RID: 1010
	private static readonly IntPtr NativeFieldInfoPtr_name;

	// Token: 0x040003F3 RID: 1011
	private static readonly IntPtr NativeFieldInfoPtr_texture;

	// Token: 0x040003F4 RID: 1012
	private static readonly IntPtr NativeFieldInfoPtr_hotSpot;

	// Token: 0x040003F5 RID: 1013
	private static readonly IntPtr NativeFieldInfoPtr_mode;

	// Token: 0x040003F6 RID: 1014
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
