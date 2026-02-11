using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D3 RID: 467
	[StructLayout(2)]
	public struct PublishedFileId
	{
		// Token: 0x06001786 RID: 6022 RVA: 0x00073738 File Offset: 0x00071938
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileId()
		{
			Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PublishedFileId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr);
			PublishedFileId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, "Value");
			PublishedFileId.NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileId_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667602);
			PublishedFileId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667603);
			PublishedFileId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667604);
			PublishedFileId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667605);
			PublishedFileId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667606);
			PublishedFileId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667607);
			PublishedFileId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667608);
			PublishedFileId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667609);
			PublishedFileId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, 100667610);
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00073830 File Offset: 0x00071A30
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator PublishedFileId(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileId_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x00073870 File Offset: 0x00071A70
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(PublishedFileId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x000738B0 File Offset: 0x00071AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000738DC File Offset: 0x00071ADC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0007390C File Offset: 0x00071B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951490, XrefRangeEnd = 951493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00073950 File Offset: 0x00071B50
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileId p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00073990 File Offset: 0x00071B90
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PublishedFileId a, PublishedFileId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x000739DC File Offset: 0x00071BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileId a, PublishedFileId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00073A28 File Offset: 0x00071C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PublishedFileId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00007C83 File Offset: 0x00005E83
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileId_UInt64_0;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileId_0;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileId_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileId_PublishedFileId_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileId_0;

		// Token: 0x04001D00 RID: 7424
		[FieldOffset(0)]
		public ulong Value;
	}
}
