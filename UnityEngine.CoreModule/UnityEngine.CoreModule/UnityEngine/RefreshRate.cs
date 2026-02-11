using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008E RID: 142
	[StructLayout(2)]
	public struct RefreshRate
	{
		// Token: 0x06000801 RID: 2049 RVA: 0x000303CC File Offset: 0x0002E5CC
		// Note: this type is marked as 'beforefieldinit'.
		static RefreshRate()
		{
			Il2CppClassPointerStore<RefreshRate>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RefreshRate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr);
			RefreshRate.NativeFieldInfoPtr_numerator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, "numerator");
			RefreshRate.NativeFieldInfoPtr_denominator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, "denominator");
			RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664275);
			RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664276);
			RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664277);
			RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, 100664278);
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00030474 File Offset: 0x0002E674
		public unsafe double value
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_get_value_Public_get_Double_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000304A4 File Offset: 0x0002E6A4
		[CallerCount(0)]
		public unsafe bool Equals(RefreshRate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000304E4 File Offset: 0x0002E6E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649437, XrefRangeEnd = 649438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int CompareTo(RefreshRate other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x00030524 File Offset: 0x0002E724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 649438, XrefRangeEnd = 649443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RefreshRate.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x000050A2 File Offset: 0x000032A2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RefreshRate>.NativeClassPtr, ref this));
		}

		// Token: 0x0400067F RID: 1663
		private static readonly IntPtr NativeFieldInfoPtr_numerator;

		// Token: 0x04000680 RID: 1664
		private static readonly IntPtr NativeFieldInfoPtr_denominator;

		// Token: 0x04000681 RID: 1665
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_get_Double_0;

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RefreshRate_0;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_RefreshRate_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000685 RID: 1669
		[FieldOffset(0)]
		public uint numerator;

		// Token: 0x04000686 RID: 1670
		[FieldOffset(4)]
		public uint denominator;
	}
}
