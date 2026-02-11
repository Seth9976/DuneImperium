using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

// Token: 0x02000034 RID: 52
public class MonoBounds : MonoBehaviour
{
	// Token: 0x0600047B RID: 1147 RVA: 0x00025188 File Offset: 0x00023388
	// Note: this type is marked as 'beforefieldinit'.
	static MonoBounds()
	{
		Il2CppClassPointerStore<MonoBounds>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "MonoBounds");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr);
		MonoBounds.NativeFieldInfoPtr_gizmoColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, "gizmoColor");
		MonoBounds.NativeFieldInfoPtr_alwaysDrawGizmos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, "alwaysDrawGizmos");
		MonoBounds.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663942);
		MonoBounds.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663943);
		MonoBounds.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663944);
		MonoBounds.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663945);
		MonoBounds.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663946);
		MonoBounds.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663947);
		MonoBounds.NativeMethodInfoPtr_OnDrawGizmos_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663948);
		MonoBounds.NativeMethodInfoPtr_OnDrawGizmosSelected_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663949);
		MonoBounds.NativeMethodInfoPtr_op_Implicit_Public_Static_Bounds_MonoBounds_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663950);
		MonoBounds.NativeMethodInfoPtr_get_CenterAsGlobalPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663951);
		MonoBounds.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr, 100663952);
	}

	// Token: 0x17000159 RID: 345
	// (get) Token: 0x0600047C RID: 1148 RVA: 0x000252BC File Offset: 0x000234BC
	public unsafe virtual Bounds Bounds
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBounds.NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700015A RID: 346
	// (get) Token: 0x0600047D RID: 1149 RVA: 0x00025304 File Offset: 0x00023504
	public unsafe Vector3 Size
	{
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 856747, RefRangeEnd = 856749, XrefRangeStart = 856747, XrefRangeEnd = 856747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_get_Size_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700015B RID: 347
	// (get) Token: 0x0600047E RID: 1150 RVA: 0x00025340 File Offset: 0x00023540
	public unsafe Vector3 Extents
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700015C RID: 348
	// (get) Token: 0x0600047F RID: 1151 RVA: 0x0002537C File Offset: 0x0002357C
	public unsafe Vector3 Center
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 856749, RefRangeEnd = 856750, XrefRangeStart = 856749, XrefRangeEnd = 856749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_get_Center_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000253B8 File Offset: 0x000235B8
	[CallerCount(0)]
	public unsafe void Awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000253EC File Offset: 0x000235EC
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void awake()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBounds.NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00025428 File Offset: 0x00023628
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856750, XrefRangeEnd = 856752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrawGizmos()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBounds.NativeMethodInfoPtr_OnDrawGizmos_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000483 RID: 1155 RVA: 0x00025464 File Offset: 0x00023664
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856752, XrefRangeEnd = 856754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnDrawGizmosSelected()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MonoBounds.NativeMethodInfoPtr_OnDrawGizmosSelected_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000484 RID: 1156 RVA: 0x000254A0 File Offset: 0x000236A0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856754, XrefRangeEnd = 856758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static implicit operator Bounds(MonoBounds bounds)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bounds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_op_Implicit_Public_Static_Bounds_MonoBounds_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x1700015D RID: 349
	// (get) Token: 0x06000485 RID: 1157 RVA: 0x000254E4 File Offset: 0x000236E4
	public unsafe Vector3 CenterAsGlobalPosition
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 856758, XrefRangeEnd = 856760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr_get_CenterAsGlobalPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000486 RID: 1158 RVA: 0x00025520 File Offset: 0x00023720
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 856761, RefRangeEnd = 856762, XrefRangeStart = 856760, XrefRangeEnd = 856761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe MonoBounds()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoBounds>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoBounds.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000487 RID: 1159 RVA: 0x00003AFF File Offset: 0x00001CFF
	public MonoBounds(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000157 RID: 343
	// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002555C File Offset: 0x0002375C
	// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003B08 File Offset: 0x00001D08
	public unsafe Color gizmoColor
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBounds.NativeFieldInfoPtr_gizmoColor);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBounds.NativeFieldInfoPtr_gizmoColor)) = value;
		}
	}

	// Token: 0x17000158 RID: 344
	// (get) Token: 0x0600048A RID: 1162 RVA: 0x00025584 File Offset: 0x00023784
	// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003B23 File Offset: 0x00001D23
	public unsafe bool alwaysDrawGizmos
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBounds.NativeFieldInfoPtr_alwaysDrawGizmos);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoBounds.NativeFieldInfoPtr_alwaysDrawGizmos)) = value;
		}
	}

	// Token: 0x04000348 RID: 840
	private static readonly IntPtr NativeFieldInfoPtr_gizmoColor;

	// Token: 0x04000349 RID: 841
	private static readonly IntPtr NativeFieldInfoPtr_alwaysDrawGizmos;

	// Token: 0x0400034A RID: 842
	private static readonly IntPtr NativeMethodInfoPtr_get_Bounds_Public_Abstract_Virtual_New_get_Bounds_0;

	// Token: 0x0400034B RID: 843
	private static readonly IntPtr NativeMethodInfoPtr_get_Size_Public_get_Vector3_0;

	// Token: 0x0400034C RID: 844
	private static readonly IntPtr NativeMethodInfoPtr_get_Extents_Public_get_Vector3_0;

	// Token: 0x0400034D RID: 845
	private static readonly IntPtr NativeMethodInfoPtr_get_Center_Public_get_Vector3_0;

	// Token: 0x0400034E RID: 846
	private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

	// Token: 0x0400034F RID: 847
	private static readonly IntPtr NativeMethodInfoPtr_awake_Protected_Virtual_New_Void_0;

	// Token: 0x04000350 RID: 848
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Protected_Virtual_New_Void_0;

	// Token: 0x04000351 RID: 849
	private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmosSelected_Protected_Virtual_New_Void_0;

	// Token: 0x04000352 RID: 850
	private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Bounds_MonoBounds_0;

	// Token: 0x04000353 RID: 851
	private static readonly IntPtr NativeMethodInfoPtr_get_CenterAsGlobalPosition_Public_get_Vector3_0;

	// Token: 0x04000354 RID: 852
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
