using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CF RID: 463
	[StructLayout(2)]
	public struct HServerListRequest
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x00072A78 File Offset: 0x00070C78
		// Note: this type is marked as 'beforefieldinit'.
		static HServerListRequest()
		{
			Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HServerListRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr);
			HServerListRequest.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, "Value");
			HServerListRequest.NativeMethodInfoPtr_op_Implicit_Public_Static_HServerListRequest_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667566);
			HServerListRequest.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667567);
			HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667568);
			HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667569);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667570);
			HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667571);
			HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667572);
			HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667573);
			HServerListRequest.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerListRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, 100667574);
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00072B70 File Offset: 0x00070D70
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HServerListRequest(IntPtr value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Implicit_Public_Static_HServerListRequest_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x00072BB0 File Offset: 0x00070DB0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator IntPtr(HServerListRequest value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600175D RID: 5981 RVA: 0x00072BF0 File Offset: 0x00070DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951468, XrefRangeEnd = 951469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600175E RID: 5982 RVA: 0x00072C1C File Offset: 0x00070E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x00072C4C File Offset: 0x00070E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951469, XrefRangeEnd = 951475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001760 RID: 5984 RVA: 0x00072C90 File Offset: 0x00070E90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951475, XrefRangeEnd = 951476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(HServerListRequest p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x00072CD0 File Offset: 0x00070ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951476, XrefRangeEnd = 951477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HServerListRequest a, HServerListRequest b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x00072D1C File Offset: 0x00070F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951477, XrefRangeEnd = 951478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerListRequest a, HServerListRequest b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x00072D68 File Offset: 0x00070F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951478, XrefRangeEnd = 951481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HServerListRequest other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerListRequest.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerListRequest_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001764 RID: 5988 RVA: 0x00007C3B File Offset: 0x00005E3B
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerListRequest>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CCA RID: 7370
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CCB RID: 7371
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HServerListRequest_IntPtr_0;

		// Token: 0x04001CCC RID: 7372
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_IntPtr_HServerListRequest_0;

		// Token: 0x04001CCD RID: 7373
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CCE RID: 7374
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CCF RID: 7375
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CD0 RID: 7376
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerListRequest_0;

		// Token: 0x04001CD1 RID: 7377
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x04001CD2 RID: 7378
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerListRequest_HServerListRequest_0;

		// Token: 0x04001CD3 RID: 7379
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerListRequest_0;

		// Token: 0x04001CD4 RID: 7380
		[FieldOffset(0)]
		public IntPtr Value;
	}
}
