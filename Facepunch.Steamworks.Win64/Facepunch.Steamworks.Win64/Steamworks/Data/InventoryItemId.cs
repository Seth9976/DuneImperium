using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001E7 RID: 487
	[StructLayout(2)]
	public struct InventoryItemId
	{
		// Token: 0x06001862 RID: 6242 RVA: 0x000776F8 File Offset: 0x000758F8
		// Note: this type is marked as 'beforefieldinit'.
		static InventoryItemId()
		{
			Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "InventoryItemId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr);
			InventoryItemId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, "Value");
			InventoryItemId.NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryItemId_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667782);
			InventoryItemId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667783);
			InventoryItemId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667784);
			InventoryItemId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667785);
			InventoryItemId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667786);
			InventoryItemId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667787);
			InventoryItemId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667788);
			InventoryItemId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667789);
			InventoryItemId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryItemId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, 100667790);
		}

		// Token: 0x06001863 RID: 6243 RVA: 0x000777F0 File Offset: 0x000759F0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator InventoryItemId(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryItemId_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00077830 File Offset: 0x00075A30
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(InventoryItemId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InventoryItemId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00077870 File Offset: 0x00075A70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x0007789C File Offset: 0x00075A9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x000778CC File Offset: 0x00075ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951550, XrefRangeEnd = 951553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00077910 File Offset: 0x00075B10
		[CallerCount(0)]
		public unsafe bool Equals(InventoryItemId p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItemId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00077950 File Offset: 0x00075B50
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(InventoryItemId a, InventoryItemId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0007799C File Offset: 0x00075B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(InventoryItemId a, InventoryItemId b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000779E8 File Offset: 0x00075BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(InventoryItemId other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InventoryItemId.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryItemId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x00007DEB File Offset: 0x00005FEB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryItemId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DD2 RID: 7634
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001DD3 RID: 7635
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_InventoryItemId_UInt64_0;

		// Token: 0x04001DD4 RID: 7636
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_InventoryItemId_0;

		// Token: 0x04001DD5 RID: 7637
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DD6 RID: 7638
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DD7 RID: 7639
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DD8 RID: 7640
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_InventoryItemId_0;

		// Token: 0x04001DD9 RID: 7641
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0;

		// Token: 0x04001DDA RID: 7642
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_InventoryItemId_InventoryItemId_0;

		// Token: 0x04001DDB RID: 7643
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_InventoryItemId_0;

		// Token: 0x04001DDC RID: 7644
		[FieldOffset(0)]
		public ulong Value;
	}
}
