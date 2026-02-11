using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021A RID: 538
	[StructLayout(2)]
	public struct BatchMeshID
	{
		// Token: 0x06002483 RID: 9347 RVA: 0x0009D1E4 File Offset: 0x0009B3E4
		// Note: this type is marked as 'beforefieldinit'.
		static BatchMeshID()
		{
			Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchMeshID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr);
			BatchMeshID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, "Null");
			BatchMeshID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, "value");
			BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100668061);
			BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100668062);
			BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, 100668063);
		}

		// Token: 0x06002484 RID: 9348 RVA: 0x0009D278 File Offset: 0x0009B478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002485 RID: 9349 RVA: 0x0009D2A8 File Offset: 0x0009B4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683245, XrefRangeEnd = 683250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002486 RID: 9350 RVA: 0x0009D2EC File Offset: 0x0009B4EC
		[CallerCount(0)]
		public unsafe bool Equals(BatchMeshID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMeshID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002487 RID: 9351 RVA: 0x0000E551 File Offset: 0x0000C751
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMeshID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x06002488 RID: 9352 RVA: 0x0009D32C File Offset: 0x0009B52C
		// (set) Token: 0x06002489 RID: 9353 RVA: 0x0000E563 File Offset: 0x0000C763
		public unsafe static BatchMeshID Null
		{
			get
			{
				BatchMeshID batchMeshID;
				IL2CPP.il2cpp_field_static_get_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*)(&batchMeshID));
				return batchMeshID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchMeshID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x0009D348 File Offset: 0x0009B548
		public int CompareTo(BatchMeshID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x0009D36C File Offset: 0x0009B56C
		public static bool operator ==(BatchMeshID a, BatchMeshID b)
		{
			return a.Equals(b);
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x0009D388 File Offset: 0x0009B588
		public static bool operator !=(BatchMeshID a, BatchMeshID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001FF6 RID: 8182
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001FF7 RID: 8183
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001FF8 RID: 8184
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FF9 RID: 8185
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FFA RID: 8186
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMeshID_0;

		// Token: 0x04001FFB RID: 8187
		[FieldOffset(0)]
		public uint value;
	}
}
