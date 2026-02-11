using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001C9 RID: 457
	[StructLayout(2)]
	public struct AccountID_t
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x00071758 File Offset: 0x0006F958
		// Note: this type is marked as 'beforefieldinit'.
		static AccountID_t()
		{
			Il2CppClassPointerStore<AccountID_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "AccountID_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr);
			AccountID_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, "Value");
			AccountID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_AccountID_t_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667512);
			AccountID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667513);
			AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667514);
			AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667515);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667516);
			AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667517);
			AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667518);
			AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667519);
			AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, 100667520);
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00071850 File Offset: 0x0006FA50
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator AccountID_t(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_AccountID_t_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00071890 File Offset: 0x0006FA90
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(AccountID_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x000718D0 File Offset: 0x0006FAD0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x000718FC File Offset: 0x0006FAFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0007192C File Offset: 0x0006FB2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951445, XrefRangeEnd = 951448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x00071970 File Offset: 0x0006FB70
		[CallerCount(0)]
		public unsafe bool Equals(AccountID_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x000719B0 File Offset: 0x0006FBB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(AccountID_t a, AccountID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x000719FC File Offset: 0x0006FBFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(AccountID_t a, AccountID_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00071A48 File Offset: 0x0006FC48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(AccountID_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AccountID_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00007BCF File Offset: 0x00005DCF
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AccountID_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001C88 RID: 7304
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001C89 RID: 7305
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_AccountID_t_UInt32_0;

		// Token: 0x04001C8A RID: 7306
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_AccountID_t_0;

		// Token: 0x04001C8B RID: 7307
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001C8C RID: 7308
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001C8D RID: 7309
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001C8E RID: 7310
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AccountID_t_0;

		// Token: 0x04001C8F RID: 7311
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x04001C90 RID: 7312
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AccountID_t_AccountID_t_0;

		// Token: 0x04001C91 RID: 7313
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_AccountID_t_0;

		// Token: 0x04001C92 RID: 7314
		[FieldOffset(0)]
		public uint Value;
	}
}
