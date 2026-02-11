using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000219 RID: 537
	[StructLayout(2)]
	public struct BatchMaterialID
	{
		// Token: 0x06002479 RID: 9337 RVA: 0x0009D020 File Offset: 0x0009B220
		// Note: this type is marked as 'beforefieldinit'.
		static BatchMaterialID()
		{
			Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchMaterialID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr);
			BatchMaterialID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, "Null");
			BatchMaterialID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, "value");
			BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100668057);
			BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100668058);
			BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, 100668059);
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x0009D0B4 File Offset: 0x0009B2B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0009D0E4 File Offset: 0x0009B2E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683240, XrefRangeEnd = 683245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x0009D128 File Offset: 0x0009B328
		[CallerCount(0)]
		public unsafe bool Equals(BatchMaterialID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchMaterialID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600247D RID: 9341 RVA: 0x0000E531 File Offset: 0x0000C731
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchMaterialID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x0009D168 File Offset: 0x0009B368
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x0000E543 File Offset: 0x0000C743
		public unsafe static BatchMaterialID Null
		{
			get
			{
				BatchMaterialID batchMaterialID;
				IL2CPP.il2cpp_field_static_get_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*)(&batchMaterialID));
				return batchMaterialID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchMaterialID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x0009D184 File Offset: 0x0009B384
		public int CompareTo(BatchMaterialID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0009D1A8 File Offset: 0x0009B3A8
		public static bool operator ==(BatchMaterialID a, BatchMaterialID b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x0009D1C4 File Offset: 0x0009B3C4
		public static bool operator !=(BatchMaterialID a, BatchMaterialID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001FF1 RID: 8177
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001FF2 RID: 8178
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FF3 RID: 8179
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FF4 RID: 8180
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchMaterialID_0;

		// Token: 0x04001FF5 RID: 8181
		[FieldOffset(0)]
		public uint value;
	}
}
