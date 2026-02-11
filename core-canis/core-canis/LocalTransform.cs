using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000048 RID: 72
[StructLayout(2)]
public struct LocalTransform
{
	// Token: 0x0600058D RID: 1421 RVA: 0x00029858 File Offset: 0x00027A58
	// Note: this type is marked as 'beforefieldinit'.
	static LocalTransform()
	{
		Il2CppClassPointerStore<LocalTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "LocalTransform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr);
		LocalTransform.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, "position");
		LocalTransform.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, "scale");
		LocalTransform.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, "rotation");
		LocalTransform.NativeFieldInfoPtr_Epsilon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, "Epsilon");
		LocalTransform.NativeFieldInfoPtr_IdentityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, "IdentityTransform");
		LocalTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664116);
		LocalTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664117);
		LocalTransform.NativeMethodInfoPtr_Approximately_Public_Boolean_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664118);
		LocalTransform.NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664119);
		LocalTransform.NativeMethodInfoPtr_Lerp_Public_Static_LocalTransform_LocalTransform_LocalTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664120);
		LocalTransform.NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664121);
		LocalTransform.NativeMethodInfoPtr_Approximately_Private_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664122);
		LocalTransform.NativeMethodInfoPtr_isValidRotation_Private_Boolean_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664123);
		LocalTransform.NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_GlobalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664124);
		LocalTransform.NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664125);
		LocalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664126);
		LocalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664127);
		LocalTransform.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664128);
		LocalTransform.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalTransform_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664129);
		LocalTransform.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocalTransform_LocalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, 100664130);
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x00029A18 File Offset: 0x00027C18
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 858010, RefRangeEnd = 858020, XrefRangeStart = 858007, XrefRangeEnd = 858010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalTransform(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x00029A50 File Offset: 0x00027C50
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 857911, RefRangeEnd = 857919, XrefRangeStart = 857911, XrefRangeEnd = 857919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalTransform(Vector3 position, Vector3 scale, Quaternion rotation)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref position;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x00029AA0 File Offset: 0x00027CA0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858020, XrefRangeEnd = 858032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Approximately(LocalTransform other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Approximately_Public_Boolean_LocalTransform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000591 RID: 1425 RVA: 0x00029AE0 File Offset: 0x00027CE0
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 858035, RefRangeEnd = 858036, XrefRangeStart = 858032, XrefRangeEnd = 858035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyToTransform(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000592 RID: 1426 RVA: 0x00029B18 File Offset: 0x00027D18
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static LocalTransform Lerp(LocalTransform start, LocalTransform end, float t)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref start;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref t;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Lerp_Public_Static_LocalTransform_LocalTransform_LocalTransform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000593 RID: 1427 RVA: 0x00029B74 File Offset: 0x00027D74
	[CallerCount(11)]
	[CachedScanResults(RefRangeStart = 858074, RefRangeEnd = 858085, XrefRangeStart = 858036, XrefRangeEnd = 858074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalTransform ToGlobal(Transform context)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000594 RID: 1428 RVA: 0x00029BB8 File Offset: 0x00027DB8
	[CallerCount(0)]
	public unsafe static bool Approximately(float a, float b)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref a;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Approximately_Private_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000595 RID: 1429 RVA: 0x00029C04 File Offset: 0x00027E04
	[CallerCount(0)]
	public unsafe bool isValidRotation(Quaternion rot)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rot;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_isValidRotation_Private_Boolean_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000596 RID: 1430 RVA: 0x00029C44 File Offset: 0x00027E44
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858085, XrefRangeEnd = 858100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalTransform ToGlobal(GlobalTransform context)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref context;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_GlobalTransform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000597 RID: 1431 RVA: 0x00029C84 File Offset: 0x00027E84
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858100, XrefRangeEnd = 858108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000598 RID: 1432 RVA: 0x00029CC8 File Offset: 0x00027EC8
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 858002, RefRangeEnd = 858007, XrefRangeStart = 858002, XrefRangeEnd = 858007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(LocalTransform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref t;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalTransform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000599 RID: 1433 RVA: 0x00029D08 File Offset: 0x00027F08
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858108, XrefRangeEnd = 858114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(global::Il2CppSystem.Object obj)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600059A RID: 1434 RVA: 0x00029D4C File Offset: 0x00027F4C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858114, XrefRangeEnd = 858124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override int GetHashCode()
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600059B RID: 1435 RVA: 0x00029D7C File Offset: 0x00027F7C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858124, XrefRangeEnd = 858128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator ==(LocalTransform rhs, LocalTransform lhs)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rhs;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lhs;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalTransform_LocalTransform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600059C RID: 1436 RVA: 0x00029DC8 File Offset: 0x00027FC8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 858128, XrefRangeEnd = 858135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static bool operator !=(LocalTransform rhs, LocalTransform lhs)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref rhs;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lhs;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalTransform.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocalTransform_LocalTransform_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600059D RID: 1437 RVA: 0x00003F7C File Offset: 0x0000217C
	public global::Il2CppSystem.Object BoxIl2CppObject()
	{
		return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocalTransform>.NativeClassPtr, ref this));
	}

	// Token: 0x1700019F RID: 415
	// (get) Token: 0x0600059E RID: 1438 RVA: 0x00029E14 File Offset: 0x00028014
	// (set) Token: 0x0600059F RID: 1439 RVA: 0x00003F8E File Offset: 0x0000218E
	public unsafe static float Epsilon
	{
		get
		{
			float num;
			IL2CPP.il2cpp_field_static_get_value(LocalTransform.NativeFieldInfoPtr_Epsilon, (void*)(&num));
			return num;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalTransform.NativeFieldInfoPtr_Epsilon, (void*)(&value));
		}
	}

	// Token: 0x170001A0 RID: 416
	// (get) Token: 0x060005A0 RID: 1440 RVA: 0x00029E30 File Offset: 0x00028030
	// (set) Token: 0x060005A1 RID: 1441 RVA: 0x00003F9C File Offset: 0x0000219C
	public unsafe static LocalTransform IdentityTransform
	{
		get
		{
			LocalTransform localTransform;
			IL2CPP.il2cpp_field_static_get_value(LocalTransform.NativeFieldInfoPtr_IdentityTransform, (void*)(&localTransform));
			return localTransform;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(LocalTransform.NativeFieldInfoPtr_IdentityTransform, (void*)(&value));
		}
	}

	// Token: 0x0400041D RID: 1053
	private static readonly IntPtr NativeFieldInfoPtr_position;

	// Token: 0x0400041E RID: 1054
	private static readonly IntPtr NativeFieldInfoPtr_scale;

	// Token: 0x0400041F RID: 1055
	private static readonly IntPtr NativeFieldInfoPtr_rotation;

	// Token: 0x04000420 RID: 1056
	private static readonly IntPtr NativeFieldInfoPtr_Epsilon;

	// Token: 0x04000421 RID: 1057
	private static readonly IntPtr NativeFieldInfoPtr_IdentityTransform;

	// Token: 0x04000422 RID: 1058
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;

	// Token: 0x04000423 RID: 1059
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0;

	// Token: 0x04000424 RID: 1060
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_LocalTransform_0;

	// Token: 0x04000425 RID: 1061
	private static readonly IntPtr NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0;

	// Token: 0x04000426 RID: 1062
	private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_LocalTransform_LocalTransform_LocalTransform_Single_0;

	// Token: 0x04000427 RID: 1063
	private static readonly IntPtr NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_Transform_0;

	// Token: 0x04000428 RID: 1064
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Private_Static_Boolean_Single_Single_0;

	// Token: 0x04000429 RID: 1065
	private static readonly IntPtr NativeMethodInfoPtr_isValidRotation_Private_Boolean_Quaternion_0;

	// Token: 0x0400042A RID: 1066
	private static readonly IntPtr NativeMethodInfoPtr_ToGlobal_Public_GlobalTransform_GlobalTransform_0;

	// Token: 0x0400042B RID: 1067
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0;

	// Token: 0x0400042C RID: 1068
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_LocalTransform_0;

	// Token: 0x0400042D RID: 1069
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x0400042E RID: 1070
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x0400042F RID: 1071
	private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_LocalTransform_LocalTransform_0;

	// Token: 0x04000430 RID: 1072
	private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_LocalTransform_LocalTransform_0;

	// Token: 0x04000431 RID: 1073
	[FieldOffset(0)]
	public Vector3 position;

	// Token: 0x04000432 RID: 1074
	[FieldOffset(12)]
	public Vector3 scale;

	// Token: 0x04000433 RID: 1075
	[FieldOffset(24)]
	public Quaternion rotation;
}
