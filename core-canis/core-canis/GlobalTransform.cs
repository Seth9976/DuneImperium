using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000046 RID: 70
[StructLayout(2)]
public struct GlobalTransform
{
	// Token: 0x0600057A RID: 1402 RVA: 0x000292F8 File Offset: 0x000274F8
	// Note: this type is marked as 'beforefieldinit'.
	static GlobalTransform()
	{
		Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "", "GlobalTransform");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr);
		GlobalTransform.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, "position");
		GlobalTransform.NativeFieldInfoPtr_scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, "scale");
		GlobalTransform.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, "rotation");
		GlobalTransform.NativeFieldInfoPtr_IdentityTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, "IdentityTransform");
		GlobalTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664102);
		GlobalTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664103);
		GlobalTransform.NativeMethodInfoPtr_Approximately_Public_Boolean_GlobalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664104);
		GlobalTransform.NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664105);
		GlobalTransform.NativeMethodInfoPtr_Lerp_Public_Static_GlobalTransform_GlobalTransform_GlobalTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664106);
		GlobalTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664107);
		GlobalTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664108);
		GlobalTransform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664109);
		GlobalTransform.NativeMethodInfoPtr_ToLocal_Public_LocalTransform_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664110);
		GlobalTransform.NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664111);
		GlobalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlobalTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, 100664112);
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x00029454 File Offset: 0x00027654
	[CallerCount(13)]
	[CachedScanResults(RefRangeStart = 857898, RefRangeEnd = 857911, XrefRangeStart = 857895, XrefRangeEnd = 857898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalTransform(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr__ctor_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0002948C File Offset: 0x0002768C
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 857911, RefRangeEnd = 857919, XrefRangeStart = 857911, XrefRangeEnd = 857911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe GlobalTransform(Vector3 position, Vector3 scale, Quaternion rotation)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x000294DC File Offset: 0x000276DC
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 857922, RefRangeEnd = 857924, XrefRangeStart = 857919, XrefRangeEnd = 857922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Approximately(GlobalTransform other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_Approximately_Public_Boolean_GlobalTransform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0002951C File Offset: 0x0002771C
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 857941, RefRangeEnd = 857947, XrefRangeStart = 857924, XrefRangeEnd = 857941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ApplyToTransform(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x00029554 File Offset: 0x00027754
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857947, XrefRangeEnd = 857952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static GlobalTransform Lerp(GlobalTransform start, GlobalTransform end, float t)
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
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_Lerp_Public_Static_GlobalTransform_GlobalTransform_GlobalTransform_Single_0, 0, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x000295B0 File Offset: 0x000277B0
	[CallerCount(8)]
	[CachedScanResults(RefRangeStart = 857956, RefRangeEnd = 857964, XrefRangeStart = 857952, XrefRangeEnd = 857956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformPoint(float x, float y, float z)
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref x;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref z;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0002960C File Offset: 0x0002780C
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 857965, RefRangeEnd = 857969, XrefRangeStart = 857964, XrefRangeEnd = 857965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 TransformPoint(Vector3 localPoint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref localPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0002964C File Offset: 0x0002784C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857969, XrefRangeEnd = 857971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Vector3 InverseTransformPoint(Vector3 globalPoint)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref globalPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0002968C File Offset: 0x0002788C
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 857989, RefRangeEnd = 857994, XrefRangeStart = 857971, XrefRangeEnd = 857989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LocalTransform ToLocal(Transform context)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_ToLocal_Public_LocalTransform_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x000296D0 File Offset: 0x000278D0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857994, XrefRangeEnd = 858002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(Transform t)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x00029714 File Offset: 0x00027914
	[CallerCount(5)]
	[CachedScanResults(RefRangeStart = 858002, RefRangeEnd = 858007, XrefRangeStart = 858002, XrefRangeEnd = 858002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe bool Equals(GlobalTransform other)
	{
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref other;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlobalTransform.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlobalTransform_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x00003F53 File Offset: 0x00002153
	public global::Il2CppSystem.Object BoxIl2CppObject()
	{
		return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlobalTransform>.NativeClassPtr, ref this));
	}

	// Token: 0x1700019C RID: 412
	// (get) Token: 0x06000587 RID: 1415 RVA: 0x00029754 File Offset: 0x00027954
	// (set) Token: 0x06000588 RID: 1416 RVA: 0x00003F65 File Offset: 0x00002165
	public unsafe static GlobalTransform IdentityTransform
	{
		get
		{
			GlobalTransform globalTransform;
			IL2CPP.il2cpp_field_static_get_value(GlobalTransform.NativeFieldInfoPtr_IdentityTransform, (void*)(&globalTransform));
			return globalTransform;
		}
		set
		{
			IL2CPP.il2cpp_field_static_set_value(GlobalTransform.NativeFieldInfoPtr_IdentityTransform, (void*)(&value));
		}
	}

	// Token: 0x04000409 RID: 1033
	private static readonly IntPtr NativeFieldInfoPtr_position;

	// Token: 0x0400040A RID: 1034
	private static readonly IntPtr NativeFieldInfoPtr_scale;

	// Token: 0x0400040B RID: 1035
	private static readonly IntPtr NativeFieldInfoPtr_rotation;

	// Token: 0x0400040C RID: 1036
	private static readonly IntPtr NativeFieldInfoPtr_IdentityTransform;

	// Token: 0x0400040D RID: 1037
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_0;

	// Token: 0x0400040E RID: 1038
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3_Vector3_Quaternion_0;

	// Token: 0x0400040F RID: 1039
	private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Boolean_GlobalTransform_0;

	// Token: 0x04000410 RID: 1040
	private static readonly IntPtr NativeMethodInfoPtr_ApplyToTransform_Public_Void_Transform_0;

	// Token: 0x04000411 RID: 1041
	private static readonly IntPtr NativeMethodInfoPtr_Lerp_Public_Static_GlobalTransform_GlobalTransform_GlobalTransform_Single_0;

	// Token: 0x04000412 RID: 1042
	private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Single_Single_Single_0;

	// Token: 0x04000413 RID: 1043
	private static readonly IntPtr NativeMethodInfoPtr_TransformPoint_Public_Vector3_Vector3_0;

	// Token: 0x04000414 RID: 1044
	private static readonly IntPtr NativeMethodInfoPtr_InverseTransformPoint_Public_Vector3_Vector3_0;

	// Token: 0x04000415 RID: 1045
	private static readonly IntPtr NativeMethodInfoPtr_ToLocal_Public_LocalTransform_Transform_0;

	// Token: 0x04000416 RID: 1046
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_Transform_0;

	// Token: 0x04000417 RID: 1047
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlobalTransform_0;

	// Token: 0x04000418 RID: 1048
	[FieldOffset(0)]
	public Vector3 position;

	// Token: 0x04000419 RID: 1049
	[FieldOffset(12)]
	public Vector3 scale;

	// Token: 0x0400041A RID: 1050
	[FieldOffset(24)]
	public Quaternion rotation;
}
