using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001EB RID: 491
	[StructLayout(2)]
	public struct RemotePlaySessionID_t
	{
		// Token: 0x0600188E RID: 6286 RVA: 0x000783B8 File Offset: 0x000765B8
		// Note: this type is marked as 'beforefieldinit'.
		static RemotePlaySessionID_t()
		{
			Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "RemotePlaySessionID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr);
			RemotePlaySessionID_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, "Value");
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySessionID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667818);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667819);
			RemotePlaySessionID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667820);
			RemotePlaySessionID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667821);
			RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667822);
			RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667823);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667824);
			RemotePlaySessionID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667825);
			RemotePlaySessionID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, 100667826);
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x000784B0 File Offset: 0x000766B0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator RemotePlaySessionID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySessionID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x000784F0 File Offset: 0x000766F0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(RemotePlaySessionID_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x00078530 File Offset: 0x00076730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0007855C File Offset: 0x0007675C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0007858C File Offset: 0x0007678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951562, XrefRangeEnd = 951565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000785D0 File Offset: 0x000767D0
		[CallerCount(0)]
		public unsafe bool Equals(RemotePlaySessionID_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x00078610 File Offset: 0x00076810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(RemotePlaySessionID_t a, RemotePlaySessionID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x0007865C File Offset: 0x0007685C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(RemotePlaySessionID_t a, RemotePlaySessionID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001897 RID: 6295 RVA: 0x000786A8 File Offset: 0x000768A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RemotePlaySessionID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemotePlaySessionID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x00007E33 File Offset: 0x00006033
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RemotePlaySessionID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RemotePlaySessionID_t_UInt32_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_RemotePlaySessionID_t_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RemotePlaySessionID_t_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_RemotePlaySessionID_t_RemotePlaySessionID_t_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RemotePlaySessionID_t_0;

		// Token: 0x04001E08 RID: 7688
		[FieldOffset(0)]
		public uint Value;
	}
}
