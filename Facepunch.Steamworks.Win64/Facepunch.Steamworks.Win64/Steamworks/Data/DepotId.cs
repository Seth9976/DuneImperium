using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001F7 RID: 503
	[StructLayout(2)]
	public struct DepotId
	{
		// Token: 0x06001943 RID: 6467 RVA: 0x0007AAF8 File Offset: 0x00078CF8
		// Note: this type is marked as 'beforefieldinit'.
		static DepotId()
		{
			Il2CppClassPointerStore<DepotId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "DepotId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepotId>.NativeClassPtr);
			DepotId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepotId>.NativeClassPtr, "Value");
			DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId>.NativeClassPtr, 100667911);
			DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId>.NativeClassPtr, 100667912);
			DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId>.NativeClassPtr, 100667913);
			DepotId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepotId>.NativeClassPtr, 100667914);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0007AB8C File Offset: 0x00078D8C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DepotId(uint value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0007ABCC File Offset: 0x00078DCC
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator DepotId(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0007AC0C File Offset: 0x00078E0C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 555492, RefRangeEnd = 555566, XrefRangeStart = 555492, XrefRangeEnd = 555566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator uint(DepotId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x0007AC4C File Offset: 0x00078E4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 946095, RefRangeEnd = 946098, XrefRangeStart = 946095, XrefRangeEnd = 946098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepotId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x00008301 File Offset: 0x00006501
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DepotId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001E83 RID: 7811
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001E84 RID: 7812
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_UInt32_0;

		// Token: 0x04001E85 RID: 7813
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_DepotId_Int32_0;

		// Token: 0x04001E86 RID: 7814
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_DepotId_0;

		// Token: 0x04001E87 RID: 7815
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001E88 RID: 7816
		[FieldOffset(0)]
		public uint Value;
	}
}
