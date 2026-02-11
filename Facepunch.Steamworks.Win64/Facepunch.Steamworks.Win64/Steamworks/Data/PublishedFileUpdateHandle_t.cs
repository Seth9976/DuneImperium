using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001D2 RID: 466
	[StructLayout(2)]
	public struct PublishedFileUpdateHandle_t
	{
		// Token: 0x0600177B RID: 6011 RVA: 0x00073408 File Offset: 0x00071608
		// Note: this type is marked as 'beforefieldinit'.
		static PublishedFileUpdateHandle_t()
		{
			Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "PublishedFileUpdateHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr);
			PublishedFileUpdateHandle_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, "Value");
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667593);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667594);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667595);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667596);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667597);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667598);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667599);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667600);
			PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, 100667601);
		}

		// Token: 0x0600177C RID: 6012 RVA: 0x00073500 File Offset: 0x00071700
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator PublishedFileUpdateHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600177D RID: 6013 RVA: 0x00073540 File Offset: 0x00071740
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(PublishedFileUpdateHandle_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x00073580 File Offset: 0x00071780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600177F RID: 6015 RVA: 0x000735AC File Offset: 0x000717AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001780 RID: 6016 RVA: 0x000735DC File Offset: 0x000717DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951487, XrefRangeEnd = 951490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001781 RID: 6017 RVA: 0x00073620 File Offset: 0x00071820
		[CallerCount(0)]
		public unsafe bool Equals(PublishedFileUpdateHandle_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001782 RID: 6018 RVA: 0x00073660 File Offset: 0x00071860
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x000736AC File Offset: 0x000718AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(PublishedFileUpdateHandle_t a, PublishedFileUpdateHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x000736F8 File Offset: 0x000718F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(PublishedFileUpdateHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PublishedFileUpdateHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00007C71 File Offset: 0x00005E71
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PublishedFileUpdateHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PublishedFileUpdateHandle_t_UInt64_0;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_PublishedFileUpdateHandle_t_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_PublishedFileUpdateHandle_t_0;

		// Token: 0x04001CF5 RID: 7413
		[FieldOffset(0)]
		public ulong Value;
	}
}
