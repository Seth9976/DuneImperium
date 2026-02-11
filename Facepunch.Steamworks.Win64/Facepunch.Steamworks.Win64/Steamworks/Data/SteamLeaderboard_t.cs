using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D5 RID: 469
	[StructLayout(2)]
	public struct SteamLeaderboard_t
	{
		// Token: 0x0600179C RID: 6044 RVA: 0x00073D98 File Offset: 0x00071F98
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLeaderboard_t()
		{
			Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamLeaderboard_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr);
			SteamLeaderboard_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, "Value");
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboard_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667620);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667621);
			SteamLeaderboard_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667622);
			SteamLeaderboard_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667623);
			SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667624);
			SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667625);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667626);
			SteamLeaderboard_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667627);
			SteamLeaderboard_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, 100667628);
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00073E90 File Offset: 0x00072090
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SteamLeaderboard_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboard_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x00073ED0 File Offset: 0x000720D0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(SteamLeaderboard_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x00073F10 File Offset: 0x00072110
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x00073F3C File Offset: 0x0007213C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x00073F6C File Offset: 0x0007216C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951496, XrefRangeEnd = 951499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x00073FB0 File Offset: 0x000721B0
		[CallerCount(0)]
		public unsafe bool Equals(SteamLeaderboard_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x00073FF0 File Offset: 0x000721F0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamLeaderboard_t a, SteamLeaderboard_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0007403C File Offset: 0x0007223C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamLeaderboard_t a, SteamLeaderboard_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x00074088 File Offset: 0x00072288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamLeaderboard_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboard_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A6 RID: 6054 RVA: 0x00007CA7 File Offset: 0x00005EA7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamLeaderboard_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D0C RID: 7436
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D0D RID: 7437
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboard_t_UInt64_0;

		// Token: 0x04001D0E RID: 7438
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboard_t_0;

		// Token: 0x04001D0F RID: 7439
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D10 RID: 7440
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D11 RID: 7441
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D12 RID: 7442
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboard_t_0;

		// Token: 0x04001D13 RID: 7443
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0;

		// Token: 0x04001D14 RID: 7444
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboard_t_SteamLeaderboard_t_0;

		// Token: 0x04001D15 RID: 7445
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboard_t_0;

		// Token: 0x04001D16 RID: 7446
		[FieldOffset(0)]
		public ulong Value;
	}
}
