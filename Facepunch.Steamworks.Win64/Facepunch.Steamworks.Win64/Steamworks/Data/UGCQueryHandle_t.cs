using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001E4 RID: 484
	[StructLayout(2)]
	public struct UGCQueryHandle_t
	{
		// Token: 0x06001841 RID: 6209 RVA: 0x00076D68 File Offset: 0x00074F68
		// Note: this type is marked as 'beforefieldinit'.
		static UGCQueryHandle_t()
		{
			Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "UGCQueryHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr);
			UGCQueryHandle_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, "Value");
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UGCQueryHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667755);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667756);
			UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667757);
			UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667758);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667759);
			UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667760);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667761);
			UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667762);
			UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, 100667763);
		}

		// Token: 0x06001842 RID: 6210 RVA: 0x00076E60 File Offset: 0x00075060
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator UGCQueryHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UGCQueryHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001843 RID: 6211 RVA: 0x00076EA0 File Offset: 0x000750A0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(UGCQueryHandle_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001844 RID: 6212 RVA: 0x00076EE0 File Offset: 0x000750E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001845 RID: 6213 RVA: 0x00076F0C File Offset: 0x0007510C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00076F3C File Offset: 0x0007513C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951541, XrefRangeEnd = 951544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00076F80 File Offset: 0x00075180
		[CallerCount(0)]
		public unsafe bool Equals(UGCQueryHandle_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00076FC0 File Offset: 0x000751C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(UGCQueryHandle_t a, UGCQueryHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001849 RID: 6217 RVA: 0x0007700C File Offset: 0x0007520C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(UGCQueryHandle_t a, UGCQueryHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00077058 File Offset: 0x00075258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(UGCQueryHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UGCQueryHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00007DB5 File Offset: 0x00005FB5
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UGCQueryHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001DB1 RID: 7601
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001DB2 RID: 7602
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UGCQueryHandle_t_UInt64_0;

		// Token: 0x04001DB3 RID: 7603
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_UGCQueryHandle_t_0;

		// Token: 0x04001DB4 RID: 7604
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001DB5 RID: 7605
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001DB6 RID: 7606
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001DB7 RID: 7607
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_UGCQueryHandle_t_0;

		// Token: 0x04001DB8 RID: 7608
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x04001DB9 RID: 7609
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_UGCQueryHandle_t_UGCQueryHandle_t_0;

		// Token: 0x04001DBA RID: 7610
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_UGCQueryHandle_t_0;

		// Token: 0x04001DBB RID: 7611
		[FieldOffset(0)]
		public ulong Value;
	}
}
