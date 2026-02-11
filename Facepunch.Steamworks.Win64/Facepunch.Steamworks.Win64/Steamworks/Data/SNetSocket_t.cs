using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D7 RID: 471
	[StructLayout(2)]
	public struct SNetSocket_t
	{
		// Token: 0x060017B2 RID: 6066 RVA: 0x000743F8 File Offset: 0x000725F8
		// Note: this type is marked as 'beforefieldinit'.
		static SNetSocket_t()
		{
			Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SNetSocket_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr);
			SNetSocket_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, "Value");
			SNetSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SNetSocket_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667638);
			SNetSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667639);
			SNetSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667640);
			SNetSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667641);
			SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667642);
			SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667643);
			SNetSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667644);
			SNetSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667645);
			SNetSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, 100667646);
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x000744F0 File Offset: 0x000726F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SNetSocket_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SNetSocket_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x00074530 File Offset: 0x00072730
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(SNetSocket_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x00074570 File Offset: 0x00072770
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0007459C File Offset: 0x0007279C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x000745CC File Offset: 0x000727CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951502, XrefRangeEnd = 951505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00074610 File Offset: 0x00072810
		[CallerCount(0)]
		public unsafe bool Equals(SNetSocket_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00074650 File Offset: 0x00072850
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SNetSocket_t a, SNetSocket_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0007469C File Offset: 0x0007289C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SNetSocket_t a, SNetSocket_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x000746E8 File Offset: 0x000728E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SNetSocket_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SNetSocket_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017BC RID: 6076 RVA: 0x00007CCB File Offset: 0x00005ECB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SNetSocket_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D22 RID: 7458
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D23 RID: 7459
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SNetSocket_t_UInt32_0;

		// Token: 0x04001D24 RID: 7460
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_SNetSocket_t_0;

		// Token: 0x04001D25 RID: 7461
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D26 RID: 7462
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D27 RID: 7463
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D28 RID: 7464
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SNetSocket_t_0;

		// Token: 0x04001D29 RID: 7465
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0;

		// Token: 0x04001D2A RID: 7466
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SNetSocket_t_SNetSocket_t_0;

		// Token: 0x04001D2B RID: 7467
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SNetSocket_t_0;

		// Token: 0x04001D2C RID: 7468
		[FieldOffset(0)]
		public uint Value;
	}
}
