using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CA RID: 458
	[StructLayout(2)]
	public struct PartyBeaconID_t
	{
		// Token: 0x06001723 RID: 5923 RVA: 0x00071A88 File Offset: 0x0006FC88
		// Note: this type is marked as 'beforefieldinit'.
		static PartyBeaconID_t()
		{
			Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PartyBeaconID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr);
			PartyBeaconID_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, "Value");
			PartyBeaconID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_PartyBeaconID_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667521);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667522);
			PartyBeaconID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667523);
			PartyBeaconID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667524);
			PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667525);
			PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667526);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667527);
			PartyBeaconID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667528);
			PartyBeaconID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, 100667529);
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00071B80 File Offset: 0x0006FD80
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator PartyBeaconID_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_PartyBeaconID_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x00071BC0 File Offset: 0x0006FDC0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(PartyBeaconID_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00071C00 File Offset: 0x0006FE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00071C2C File Offset: 0x0006FE2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00071C5C File Offset: 0x0006FE5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951448, XrefRangeEnd = 951451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00071CA0 File Offset: 0x0006FEA0
		[CallerCount(0)]
		public unsafe bool Equals(PartyBeaconID_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00071CE0 File Offset: 0x0006FEE0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PartyBeaconID_t a, PartyBeaconID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x00071D2C File Offset: 0x0006FF2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PartyBeaconID_t a, PartyBeaconID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00071D78 File Offset: 0x0006FF78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PartyBeaconID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyBeaconID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00007BE1 File Offset: 0x00005DE1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PartyBeaconID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C93 RID: 7315
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001C94 RID: 7316
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PartyBeaconID_t_UInt64_0;

		// Token: 0x04001C95 RID: 7317
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PartyBeaconID_t_0;

		// Token: 0x04001C96 RID: 7318
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C97 RID: 7319
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C98 RID: 7320
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C99 RID: 7321
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PartyBeaconID_t_0;

		// Token: 0x04001C9A RID: 7322
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0;

		// Token: 0x04001C9B RID: 7323
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PartyBeaconID_t_PartyBeaconID_t_0;

		// Token: 0x04001C9C RID: 7324
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PartyBeaconID_t_0;

		// Token: 0x04001C9D RID: 7325
		[FieldOffset(0)]
		public ulong Value;
	}
}
