using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000060 RID: 96
	public static class MathUtils : Object
	{
		// Token: 0x060008A2 RID: 2210 RVA: 0x0003A31C File Offset: 0x0003851C
		// Note: this type is marked as 'beforefieldinit'.
		static MathUtils()
		{
			Il2CppClassPointerStore<MathUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "MathUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathUtils>.NativeClassPtr);
			MathUtils.NativeMethodInfoPtr_IntLength_Public_Static_Int32_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664953);
			MathUtils.NativeMethodInfoPtr_IntToHex_Public_Static_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664954);
			MathUtils.NativeMethodInfoPtr_Min_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664955);
			MathUtils.NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664956);
			MathUtils.NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Double_Nullable_1_Double_Nullable_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664957);
			MathUtils.NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Double_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MathUtils>.NativeClassPtr, 100664958);
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x0003A3C4 File Offset: 0x000385C4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 744600, RefRangeEnd = 744604, XrefRangeStart = 744600, XrefRangeEnd = 744600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int IntLength(ulong i)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_IntLength_Public_Static_Int32_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x0003A404 File Offset: 0x00038604
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 744604, RefRangeEnd = 744608, XrefRangeStart = 744604, XrefRangeEnd = 744604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char IntToHex(int n)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_IntToHex_Public_Static_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0003A444 File Offset: 0x00038644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744617, RefRangeEnd = 744619, XrefRangeStart = 744608, XrefRangeEnd = 744617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> Min(Nullable<int> val1, Nullable<int> val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_Min_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060008A6 RID: 2214 RVA: 0x0003A49C File Offset: 0x0003869C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 744628, RefRangeEnd = 744630, XrefRangeStart = 744619, XrefRangeEnd = 744628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<int> Max(Nullable<int> val1, Nullable<int> val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<int>(intPtr);
		}

		// Token: 0x060008A7 RID: 2215 RVA: 0x0003A4F4 File Offset: 0x000386F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 744639, RefRangeEnd = 744642, XrefRangeStart = 744630, XrefRangeEnd = 744639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Nullable<double> Max(Nullable<double> val1, Nullable<double> val2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val1));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(val2));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Double_Nullable_1_Double_Nullable_1_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new Nullable<double>(intPtr);
		}

		// Token: 0x060008A8 RID: 2216 RVA: 0x0003A54C File Offset: 0x0003874C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 744643, RefRangeEnd = 744644, XrefRangeStart = 744642, XrefRangeEnd = 744643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ApproxEquals(double d1, double d2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MathUtils.NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Double_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008A9 RID: 2217 RVA: 0x00004BB7 File Offset: 0x00002DB7
		public MathUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_IntLength_Public_Static_Int32_UInt64_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_IntToHex_Public_Static_Char_Int32_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_Min_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Int32_Nullable_1_Int32_Nullable_1_Int32_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_Max_Public_Static_Nullable_1_Double_Nullable_1_Double_Nullable_1_Double_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_ApproxEquals_Public_Static_Boolean_Double_Double_0;
	}
}
