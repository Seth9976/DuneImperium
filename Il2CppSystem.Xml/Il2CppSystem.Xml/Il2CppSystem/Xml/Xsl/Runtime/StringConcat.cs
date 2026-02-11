using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Xml.Xsl.Runtime
{
	// Token: 0x02000100 RID: 256
	public sealed class StringConcat : ValueType
	{
		// Token: 0x0600172D RID: 5933 RVA: 0x00079954 File Offset: 0x00077B54
		// Note: this type is marked as 'beforefieldinit'.
		static StringConcat()
		{
			Il2CppClassPointerStore<StringConcat>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Xsl.Runtime", "StringConcat");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringConcat>.NativeClassPtr);
			StringConcat.NativeFieldInfoPtr_s1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s1");
			StringConcat.NativeFieldInfoPtr_s2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s2");
			StringConcat.NativeFieldInfoPtr_s3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s3");
			StringConcat.NativeFieldInfoPtr_s4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "s4");
			StringConcat.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "delimiter");
			StringConcat.NativeFieldInfoPtr_strList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "strList");
			StringConcat.NativeFieldInfoPtr_idxStr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, "idxStr");
			StringConcat.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100666946);
			StringConcat.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100666947);
			StringConcat.NativeMethodInfoPtr_GetResult_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100666948);
			StringConcat.NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringConcat>.NativeClassPtr, 100666949);
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00079A60 File Offset: 0x00077C60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390395, RefRangeEnd = 390396, XrefRangeStart = 390394, XrefRangeEnd = 390395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00079A98 File Offset: 0x00077C98
		public unsafe int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_get_Count_Internal_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001730 RID: 5936 RVA: 0x00079ADC File Offset: 0x00077CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 390402, RefRangeEnd = 390404, XrefRangeStart = 390396, XrefRangeEnd = 390402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetResult()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_GetResult_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x00079B18 File Offset: 0x00077D18
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 390424, RefRangeEnd = 390425, XrefRangeStart = 390404, XrefRangeEnd = 390424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConcatNoDelimiter(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringConcat.NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001732 RID: 5938 RVA: 0x00009DFE File Offset: 0x00007FFE
		public StringConcat(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00009E07 File Offset: 0x00008007
		public StringConcat()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringConcat>.NativeClassPtr))
		{
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001734 RID: 5940 RVA: 0x00079B60 File Offset: 0x00077D60
		// (set) Token: 0x06001735 RID: 5941 RVA: 0x00009E19 File Offset: 0x00008019
		public unsafe string s1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s1);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s1), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00079B88 File Offset: 0x00077D88
		// (set) Token: 0x06001737 RID: 5943 RVA: 0x00009E38 File Offset: 0x00008038
		public unsafe string s2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s2);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s2), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00079BB0 File Offset: 0x00077DB0
		// (set) Token: 0x06001739 RID: 5945 RVA: 0x00009E57 File Offset: 0x00008057
		public unsafe string s3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s3);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s3), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00079BD8 File Offset: 0x00077DD8
		// (set) Token: 0x0600173B RID: 5947 RVA: 0x00009E76 File Offset: 0x00008076
		public unsafe string s4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s4);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_s4), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00079C00 File Offset: 0x00077E00
		// (set) Token: 0x0600173D RID: 5949 RVA: 0x00009E95 File Offset: 0x00008095
		public unsafe string delimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_delimiter);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_delimiter), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600173E RID: 5950 RVA: 0x00079C28 File Offset: 0x00077E28
		// (set) Token: 0x0600173F RID: 5951 RVA: 0x00009EB4 File Offset: 0x000080B4
		public unsafe List<string> strList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_strList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_strList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00079C58 File Offset: 0x00077E58
		// (set) Token: 0x06001741 RID: 5953 RVA: 0x00009ED3 File Offset: 0x000080D3
		public unsafe int idxStr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_idxStr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringConcat.NativeFieldInfoPtr_idxStr)) = value;
			}
		}

		// Token: 0x0400124A RID: 4682
		private static readonly IntPtr NativeFieldInfoPtr_s1;

		// Token: 0x0400124B RID: 4683
		private static readonly IntPtr NativeFieldInfoPtr_s2;

		// Token: 0x0400124C RID: 4684
		private static readonly IntPtr NativeFieldInfoPtr_s3;

		// Token: 0x0400124D RID: 4685
		private static readonly IntPtr NativeFieldInfoPtr_s4;

		// Token: 0x0400124E RID: 4686
		private static readonly IntPtr NativeFieldInfoPtr_delimiter;

		// Token: 0x0400124F RID: 4687
		private static readonly IntPtr NativeFieldInfoPtr_strList;

		// Token: 0x04001250 RID: 4688
		private static readonly IntPtr NativeFieldInfoPtr_idxStr;

		// Token: 0x04001251 RID: 4689
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001252 RID: 4690
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Internal_get_Int32_0;

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeMethodInfoPtr_GetResult_Public_String_0;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr_ConcatNoDelimiter_Internal_Void_String_0;
	}
}
