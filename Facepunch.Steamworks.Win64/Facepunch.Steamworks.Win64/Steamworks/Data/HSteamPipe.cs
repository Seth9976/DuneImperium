using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001CC RID: 460
	[StructLayout(2)]
	public struct HSteamPipe
	{
		// Token: 0x06001739 RID: 5945 RVA: 0x000720E8 File Offset: 0x000702E8
		// Note: this type is marked as 'beforefieldinit'.
		static HSteamPipe()
		{
			Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HSteamPipe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr);
			HSteamPipe.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, "Value");
			HSteamPipe.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamPipe_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667539);
			HSteamPipe.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667540);
			HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667541);
			HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667542);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667543);
			HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667544);
			HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667545);
			HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667546);
			HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, 100667547);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000721E0 File Offset: 0x000703E0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HSteamPipe(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamPipe_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x00072220 File Offset: 0x00070420
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(HSteamPipe value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x00072260 File Offset: 0x00070460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951454, XrefRangeEnd = 951455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0007228C File Offset: 0x0007048C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x000722BC File Offset: 0x000704BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951455, XrefRangeEnd = 951458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x00072300 File Offset: 0x00070500
		[CallerCount(0)]
		public unsafe bool Equals(HSteamPipe p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x00072340 File Offset: 0x00070540
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HSteamPipe a, HSteamPipe b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0007238C File Offset: 0x0007058C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HSteamPipe a, HSteamPipe b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x000723D8 File Offset: 0x000705D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951458, XrefRangeEnd = 951459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HSteamPipe other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HSteamPipe.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00007C05 File Offset: 0x00005E05
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HSteamPipe>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CA9 RID: 7337
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CAA RID: 7338
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HSteamPipe_Int32_0;

		// Token: 0x04001CAB RID: 7339
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HSteamPipe_0;

		// Token: 0x04001CAC RID: 7340
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CAD RID: 7341
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CAE RID: 7342
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CAF RID: 7343
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HSteamPipe_0;

		// Token: 0x04001CB0 RID: 7344
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x04001CB1 RID: 7345
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HSteamPipe_HSteamPipe_0;

		// Token: 0x04001CB2 RID: 7346
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HSteamPipe_0;

		// Token: 0x04001CB3 RID: 7347
		[FieldOffset(0)]
		public int Value;
	}
}
