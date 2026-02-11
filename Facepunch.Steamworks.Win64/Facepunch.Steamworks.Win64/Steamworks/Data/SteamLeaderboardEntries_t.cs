using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D6 RID: 470
	[StructLayout(2)]
	public struct SteamLeaderboardEntries_t
	{
		// Token: 0x060017A7 RID: 6055 RVA: 0x000740C8 File Offset: 0x000722C8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamLeaderboardEntries_t()
		{
			Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "SteamLeaderboardEntries_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr);
			SteamLeaderboardEntries_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, "Value");
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667629);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667630);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667631);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667632);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667633);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667634);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667635);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667636);
			SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, 100667637);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000741C0 File Offset: 0x000723C0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SteamLeaderboardEntries_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x00074200 File Offset: 0x00072400
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(SteamLeaderboardEntries_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x00074240 File Offset: 0x00072440
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x0007426C File Offset: 0x0007246C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x0007429C File Offset: 0x0007249C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951499, XrefRangeEnd = 951502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x000742E0 File Offset: 0x000724E0
		[CallerCount(0)]
		public unsafe bool Equals(SteamLeaderboardEntries_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x00074320 File Offset: 0x00072520
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0007436C File Offset: 0x0007256C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(SteamLeaderboardEntries_t a, SteamLeaderboardEntries_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x000743B8 File Offset: 0x000725B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(SteamLeaderboardEntries_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamLeaderboardEntries_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00007CB9 File Offset: 0x00005EB9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamLeaderboardEntries_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D17 RID: 7447
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D18 RID: 7448
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SteamLeaderboardEntries_t_UInt64_0;

		// Token: 0x04001D19 RID: 7449
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamLeaderboardEntries_t_0;

		// Token: 0x04001D1A RID: 7450
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D1B RID: 7451
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D1C RID: 7452
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D1D RID: 7453
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SteamLeaderboardEntries_t_0;

		// Token: 0x04001D1E RID: 7454
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x04001D1F RID: 7455
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_SteamLeaderboardEntries_t_SteamLeaderboardEntries_t_0;

		// Token: 0x04001D20 RID: 7456
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_SteamLeaderboardEntries_t_0;

		// Token: 0x04001D21 RID: 7457
		[FieldOffset(0)]
		public ulong Value;
	}
}
