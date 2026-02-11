using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D8 RID: 472
	[StructLayout(2)]
	public struct SNetListenSocket_t
	{
		// Token: 0x060017BD RID: 6077 RVA: 0x00074728 File Offset: 0x00072928
		// Note: this type is marked as 'beforefieldinit'.
		static SNetListenSocket_t()
		{
			Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SNetListenSocket_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr);
			SNetListenSocket_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, "Value");
			SNetListenSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SNetListenSocket_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667647);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667648);
			SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667649);
			SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667650);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667651);
			SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667652);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667653);
			SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667654);
			SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, 100667655);
		}

		// Token: 0x060017BE RID: 6078 RVA: 0x00074820 File Offset: 0x00072A20
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SNetListenSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SNetListenSocket_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017BF RID: 6079 RVA: 0x00074860 File Offset: 0x00072A60
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(SNetListenSocket_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C0 RID: 6080 RVA: 0x000748A0 File Offset: 0x00072AA0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017C1 RID: 6081 RVA: 0x000748CC File Offset: 0x00072ACC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C2 RID: 6082 RVA: 0x000748FC File Offset: 0x00072AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951505, XrefRangeEnd = 951508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C3 RID: 6083 RVA: 0x00074940 File Offset: 0x00072B40
		[CallerCount(0)]
		public unsafe bool Equals(SNetListenSocket_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C4 RID: 6084 RVA: 0x00074980 File Offset: 0x00072B80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SNetListenSocket_t a, SNetListenSocket_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C5 RID: 6085 RVA: 0x000749CC File Offset: 0x00072BCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SNetListenSocket_t a, SNetListenSocket_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017C6 RID: 6086 RVA: 0x00074A18 File Offset: 0x00072C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SNetListenSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetListenSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017C7 RID: 6087 RVA: 0x00007CDD File Offset: 0x00005EDD
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SNetListenSocket_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D2D RID: 7469
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D2E RID: 7470
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SNetListenSocket_t_UInt32_0;

		// Token: 0x04001D2F RID: 7471
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetListenSocket_t_0;

		// Token: 0x04001D30 RID: 7472
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D31 RID: 7473
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D32 RID: 7474
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D33 RID: 7475
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetListenSocket_t_0;

		// Token: 0x04001D34 RID: 7476
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x04001D35 RID: 7477
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetListenSocket_t_SNetListenSocket_t_0;

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetListenSocket_t_0;

		// Token: 0x04001D37 RID: 7479
		[FieldOffset(0)]
		public uint Value;
	}
}
