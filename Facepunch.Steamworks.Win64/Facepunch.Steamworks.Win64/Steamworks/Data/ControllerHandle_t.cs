using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001E0 RID: 480
	[StructLayout(2)]
	public struct ControllerHandle_t
	{
		// Token: 0x06001815 RID: 6165 RVA: 0x000760A8 File Offset: 0x000742A8
		// Note: this type is marked as 'beforefieldinit'.
		static ControllerHandle_t()
		{
			Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "ControllerHandle_t");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr);
			ControllerHandle_t.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, "Value");
			ControllerHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerHandle_t_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667719);
			ControllerHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667720);
			ControllerHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667721);
			ControllerHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667722);
			ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667723);
			ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667724);
			ControllerHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667725);
			ControllerHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667726);
			ControllerHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, 100667727);
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x000761A0 File Offset: 0x000743A0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ControllerHandle_t(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerHandle_t_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x000761E0 File Offset: 0x000743E0
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(ControllerHandle_t value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00076220 File Offset: 0x00074420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0007624C File Offset: 0x0007444C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 951431, RefRangeEnd = 951433, XrefRangeStart = 951431, XrefRangeEnd = 951433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0007627C File Offset: 0x0007447C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951529, XrefRangeEnd = 951532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x000762C0 File Offset: 0x000744C0
		[CallerCount(0)]
		public unsafe bool Equals(ControllerHandle_t p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x00076300 File Offset: 0x00074500
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 951436, RefRangeEnd = 951444, XrefRangeStart = 951436, XrefRangeEnd = 951444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(ControllerHandle_t a, ControllerHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0007634C File Offset: 0x0007454C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 43260, RefRangeEnd = 43261, XrefRangeStart = 43260, XrefRangeEnd = 43261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(ControllerHandle_t a, ControllerHandle_t b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00076398 File Offset: 0x00074598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(ControllerHandle_t other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControllerHandle_t.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x00007D6D File Offset: 0x00005F6D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControllerHandle_t>.NativeClassPtr, ref this));
		}

		// Token: 0x04001D85 RID: 7557
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001D86 RID: 7558
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ControllerHandle_t_UInt64_0;

		// Token: 0x04001D87 RID: 7559
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ControllerHandle_t_0;

		// Token: 0x04001D88 RID: 7560
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001D89 RID: 7561
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001D8A RID: 7562
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001D8B RID: 7563
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_ControllerHandle_t_0;

		// Token: 0x04001D8C RID: 7564
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0;

		// Token: 0x04001D8D RID: 7565
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ControllerHandle_t_ControllerHandle_t_0;

		// Token: 0x04001D8E RID: 7566
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_ControllerHandle_t_0;

		// Token: 0x04001D8F RID: 7567
		[FieldOffset(0)]
		public ulong Value;
	}
}
