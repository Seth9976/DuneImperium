using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CD RID: 461
	[StructLayout(2)]
	public struct HSteamUser
	{
		// Token: 0x06001744 RID: 5956 RVA: 0x00072418 File Offset: 0x00070618
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamUser()
		{
			Il2CppClassPointerStore<HSteamUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HSteamUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr);
			HSteamUser.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, "Value");
			HSteamUser.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamUser_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667548);
			HSteamUser.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667549);
			HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667550);
			HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667551);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667552);
			HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667553);
			HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667554);
			HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667555);
			HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, 100667556);
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x00072510 File Offset: 0x00070710
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HSteamUser(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamUser_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00072550 File Offset: 0x00070750
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(HSteamUser value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00072590 File Offset: 0x00070790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000725BC File Offset: 0x000707BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000725EC File Offset: 0x000707EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951459, XrefRangeEnd = 951462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00072630 File Offset: 0x00070830
		[CallerCount(0)]
		public unsafe bool Equals(HSteamUser p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00072670 File Offset: 0x00070870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamUser a, HSteamUser b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x000726BC File Offset: 0x000708BC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamUser a, HSteamUser b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00072708 File Offset: 0x00070908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamUser other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamUser.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00007C17 File Offset: 0x00005E17
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamUser>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CB4 RID: 7348
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CB5 RID: 7349
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamUser_Int32_0;

		// Token: 0x04001CB6 RID: 7350
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamUser_0;

		// Token: 0x04001CB7 RID: 7351
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CB8 RID: 7352
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CB9 RID: 7353
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamUser_0;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamUser_HSteamUser_0;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamUser_0;

		// Token: 0x04001CBE RID: 7358
		[FieldOffset(0)]
		public int Value;
	}
}
