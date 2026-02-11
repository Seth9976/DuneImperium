using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D0 RID: 464
	[StructLayout(2)]
	public struct HServerQuery
	{
		// Token: 0x06001765 RID: 5989 RVA: 0x00072DA8 File Offset: 0x00070FA8
		// Note: this type is marked as 'beforefieldinit'.
		static HServerQuery()
		{
			Il2CppClassPointerStore<HServerQuery>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "HServerQuery");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr);
			HServerQuery.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, "Value");
			HServerQuery.NativeMethodInfoPtr_op_Implicit_Public_Static_HServerQuery_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667575);
			HServerQuery.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667576);
			HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667577);
			HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667578);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667579);
			HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667580);
			HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667581);
			HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667582);
			HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, 100667583);
		}

		// Token: 0x06001766 RID: 5990 RVA: 0x00072EA0 File Offset: 0x000710A0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator HServerQuery(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Implicit_Public_Static_HServerQuery_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x00072EE0 File Offset: 0x000710E0
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator int(HServerQuery value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001768 RID: 5992 RVA: 0x00072F20 File Offset: 0x00071120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00072F4C File Offset: 0x0007114C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951481, XrefRangeEnd = 951484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00072FC0 File Offset: 0x000711C0
		[CallerCount(0)]
		public unsafe bool Equals(HServerQuery p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x00073000 File Offset: 0x00071200
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 951421, RefRangeEnd = 951422, XrefRangeStart = 951421, XrefRangeEnd = 951422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(HServerQuery a, HServerQuery b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x0007304C File Offset: 0x0007124C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 951422, RefRangeEnd = 951426, XrefRangeStart = 951422, XrefRangeEnd = 951426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(HServerQuery a, HServerQuery b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00073098 File Offset: 0x00071298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(HServerQuery other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HServerQuery.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00007C4D File Offset: 0x00005E4D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HServerQuery>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CD5 RID: 7381
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CD6 RID: 7382
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_HServerQuery_Int32_0;

		// Token: 0x04001CD7 RID: 7383
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_HServerQuery_0;

		// Token: 0x04001CD8 RID: 7384
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CD9 RID: 7385
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CDA RID: 7386
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CDB RID: 7387
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_HServerQuery_0;

		// Token: 0x04001CDC RID: 7388
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_HServerQuery_HServerQuery_0;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_HServerQuery_0;

		// Token: 0x04001CDF RID: 7391
		[FieldOffset(0)]
		public int Value;
	}
}
