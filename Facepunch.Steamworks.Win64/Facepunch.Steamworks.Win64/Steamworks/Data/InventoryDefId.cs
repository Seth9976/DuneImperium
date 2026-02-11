using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001E8 RID: 488
	[StructLayout(2)]
	public struct InventoryDefId
	{
		// Token: 0x0600186D RID: 6253 RVA: 0x00077A28 File Offset: 0x00075C28
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryDefId()
		{
			Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "InventoryDefId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr);
			InventoryDefId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, "Value");
			InventoryDefId.NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryDefId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667791);
			InventoryDefId.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667792);
			InventoryDefId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667793);
			InventoryDefId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667794);
			InventoryDefId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667795);
			InventoryDefId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667796);
			InventoryDefId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667797);
			InventoryDefId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667798);
			InventoryDefId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryDefId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, 100667799);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00077B20 File Offset: 0x00075D20
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator InventoryDefId(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryDefId_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00077B60 File Offset: 0x00075D60
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(InventoryDefId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00077BA0 File Offset: 0x00075DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00077BCC File Offset: 0x00075DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00077BFC File Offset: 0x00075DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951553, XrefRangeEnd = 951556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00077C40 File Offset: 0x00075E40
		[CallerCount(0)]
		public unsafe bool Equals(InventoryDefId p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDefId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x00077C80 File Offset: 0x00075E80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InventoryDefId a, InventoryDefId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x00077CCC File Offset: 0x00075ECC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InventoryDefId a, InventoryDefId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x00077D18 File Offset: 0x00075F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InventoryDefId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryDefId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryDefId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x00007DFD File Offset: 0x00005FFD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryDefId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DDD RID: 7645
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001DDE RID: 7646
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryDefId_Int32_0;

		// Token: 0x04001DDF RID: 7647
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_InventoryDefId_0;

		// Token: 0x04001DE0 RID: 7648
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DE1 RID: 7649
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DE2 RID: 7650
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DE3 RID: 7651
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryDefId_0;

		// Token: 0x04001DE4 RID: 7652
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0;

		// Token: 0x04001DE5 RID: 7653
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryDefId_InventoryDefId_0;

		// Token: 0x04001DE6 RID: 7654
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryDefId_0;

		// Token: 0x04001DE7 RID: 7655
		[FieldOffset(0)]
		public int Value;
	}
}
