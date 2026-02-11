using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C6 RID: 454
	[StructLayout(2)]
	public struct DepotId_t
	{
		// Token: 0x060016F7 RID: 5879 RVA: 0x00070DC8 File Offset: 0x0006EFC8
		// Note: this type is marked as 'beforefieldinit'.
		static DepotId_t()
		{
			Il2CppClassPointerStore<DepotId_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DepotId_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr);
			DepotId_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, "Value");
			DepotId_t.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667485);
			DepotId_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667486);
			DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667487);
			DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667488);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667489);
			DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667490);
			DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667491);
			DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667492);
			DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, 100667493);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00070EC0 File Offset: 0x0006F0C0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DepotId_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00070F00 File Offset: 0x0006F100
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(DepotId_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x00070F40 File Offset: 0x0006F140
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00070F6C File Offset: 0x0006F16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00070F9C File Offset: 0x0006F19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951418, XrefRangeEnd = 951421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00070FE0 File Offset: 0x0006F1E0
		[CallerCount(0)]
		public unsafe bool Equals(DepotId_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x00071020 File Offset: 0x0006F220
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(DepotId_t a, DepotId_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x0007106C File Offset: 0x0006F26C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(DepotId_t a, DepotId_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000710B8 File Offset: 0x0006F2B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951426, XrefRangeEnd = 951427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(DepotId_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00007B99 File Offset: 0x00005D99
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepotId_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_t_UInt32_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_t_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C6D RID: 7277
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DepotId_t_0;

		// Token: 0x04001C6E RID: 7278
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04001C6F RID: 7279
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_DepotId_t_DepotId_t_0;

		// Token: 0x04001C70 RID: 7280
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_DepotId_t_0;

		// Token: 0x04001C71 RID: 7281
		[FieldOffset(0)]
		public uint Value;
	}
}
