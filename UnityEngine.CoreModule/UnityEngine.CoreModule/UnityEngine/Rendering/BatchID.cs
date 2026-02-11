using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000218 RID: 536
	[StructLayout(2)]
	public struct BatchID
	{
		// Token: 0x0600246F RID: 9327 RVA: 0x0009CE5C File Offset: 0x0009B05C
		// Note: this type is marked as 'beforefieldinit'.
		static BatchID()
		{
			Il2CppClassPointerStore<BatchID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchID>.NativeClassPtr);
			BatchID.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchID>.NativeClassPtr, "Null");
			BatchID.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchID>.NativeClassPtr, "value");
			BatchID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100668053);
			BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100668054);
			BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchID>.NativeClassPtr, 100668055);
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0009CEF0 File Offset: 0x0009B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002471 RID: 9329 RVA: 0x0009CF20 File Offset: 0x0009B120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683235, XrefRangeEnd = 683240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002472 RID: 9330 RVA: 0x0009CF64 File Offset: 0x0009B164
		[CallerCount(0)]
		public unsafe bool Equals(BatchID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002473 RID: 9331 RVA: 0x0000E511 File Offset: 0x0000C711
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchID>.NativeClassPtr, ref this));
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0009CFA4 File Offset: 0x0009B1A4
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0000E523 File Offset: 0x0000C723
		public unsafe static BatchID Null
		{
			get
			{
				BatchID batchID;
				IL2CPP.il2cpp_field_static_get_value(BatchID.NativeFieldInfoPtr_Null, (void*)(&batchID));
				return batchID;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BatchID.NativeFieldInfoPtr_Null, (void*)(&value));
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0009CFC0 File Offset: 0x0009B1C0
		public int CompareTo(BatchID other)
		{
			return this.value.CompareTo(other.value);
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		public static bool operator ==(BatchID a, BatchID b)
		{
			return a.Equals(b);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0009D000 File Offset: 0x0009B200
		public static bool operator !=(BatchID a, BatchID b)
		{
			return !a.Equals(b);
		}

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04001FEC RID: 8172
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001FED RID: 8173
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001FEE RID: 8174
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchID_0;

		// Token: 0x04001FEF RID: 8175
		[FieldOffset(0)]
		public uint value;
	}
}
