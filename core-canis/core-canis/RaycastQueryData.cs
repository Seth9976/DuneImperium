using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000057 RID: 87
public sealed class RaycastQueryData : ValueType
{
	// Token: 0x0600065A RID: 1626 RVA: 0x0002D594 File Offset: 0x0002B794
	// Note: this type is marked as 'beforefieldinit'.
	static RaycastQueryData()
	{
		Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "RaycastQueryData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr);
		RaycastQueryData.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr, "Data");
		RaycastQueryData.NativeMethodInfoPtr__ctor_Public_Void_IList_1_CameraRaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr, 100664264);
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x0002D5EC File Offset: 0x0002B7EC
	[CallerCount(3)]
	[CachedScanResults(RefRangeStart = 307804, RefRangeEnd = 307807, XrefRangeStart = 307804, XrefRangeEnd = 307807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RaycastQueryData(IList<CameraRaycastHit> data)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr))
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RaycastQueryData.NativeMethodInfoPtr__ctor_Public_Void_IList_1_CameraRaycastHit_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x0000415D File Offset: 0x0000235D
	public RaycastQueryData(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00004166 File Offset: 0x00002366
	public RaycastQueryData()
		: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RaycastQueryData>.NativeClassPtr))
	{
	}

	// Token: 0x170001B2 RID: 434
	// (get) Token: 0x0600065E RID: 1630 RVA: 0x0002D63C File Offset: 0x0002B83C
	// (set) Token: 0x0600065F RID: 1631 RVA: 0x00004178 File Offset: 0x00002378
	public unsafe IList<CameraRaycastHit> Data
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastQueryData.NativeFieldInfoPtr_Data);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IList<CameraRaycastHit>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RaycastQueryData.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040004C8 RID: 1224
	private static readonly IntPtr NativeFieldInfoPtr_Data;

	// Token: 0x040004C9 RID: 1225
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IList_1_CameraRaycastHit_0;
}
