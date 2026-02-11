using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000497 RID: 1175
	public class Bootstring : Object
	{
		// Token: 0x06004921 RID: 18721 RVA: 0x00153A44 File Offset: 0x00151C44
		// Note: this type is marked as 'beforefieldinit'.
		static Bootstring()
		{
			Il2CppClassPointerStore<Bootstring>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "Bootstring");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bootstring>.NativeClassPtr);
			Bootstring.NativeFieldInfoPtr_delimiter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "delimiter");
			Bootstring.NativeFieldInfoPtr_base_num = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "base_num");
			Bootstring.NativeFieldInfoPtr_tmin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmin");
			Bootstring.NativeFieldInfoPtr_tmax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "tmax");
			Bootstring.NativeFieldInfoPtr_skew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "skew");
			Bootstring.NativeFieldInfoPtr_damp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "damp");
			Bootstring.NativeFieldInfoPtr_initial_bias = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_bias");
			Bootstring.NativeFieldInfoPtr_initial_n = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, "initial_n");
			Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673970);
			Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673971);
			Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673972);
			Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673973);
			Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673974);
			Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstring>.NativeClassPtr, 100673975);
		}

		// Token: 0x06004922 RID: 18722 RVA: 0x00153B8C File Offset: 0x00151D8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1414085, XrefRangeEnd = 1414086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Bootstring(char delimiter, int baseNum, int tmin, int tmax, int skew, int damp, int initialBias, int initialN)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bootstring>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delimiter;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmin;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tmax;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref skew;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damp;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialBias;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialN;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004923 RID: 18723 RVA: 0x00153C38 File Offset: 0x00151E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414126, RefRangeEnd = 1414127, XrefRangeStart = 1414086, XrefRangeEnd = 1414126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Encode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Encode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004924 RID: 18724 RVA: 0x00153C90 File Offset: 0x00151E90
		[CallerCount(0)]
		public unsafe char EncodeDigit(int d)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004925 RID: 18725 RVA: 0x00153CDC File Offset: 0x00151EDC
		[CallerCount(0)]
		public unsafe int DecodeDigit(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004926 RID: 18726 RVA: 0x00153D28 File Offset: 0x00151F28
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1414128, RefRangeEnd = 1414130, XrefRangeStart = 1414127, XrefRangeEnd = 1414128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Adapt(int delta, int numPoints, bool firstTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numPoints;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004927 RID: 18727 RVA: 0x00153D90 File Offset: 0x00151F90
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1414148, RefRangeEnd = 1414149, XrefRangeStart = 1414130, XrefRangeEnd = 1414148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Decode(string s, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Bootstring.NativeMethodInfoPtr_Decode_Public_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004928 RID: 18728 RVA: 0x0001AA80 File Offset: 0x00018C80
		public Bootstring(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170012A7 RID: 4775
		// (get) Token: 0x06004929 RID: 18729 RVA: 0x00153DE8 File Offset: 0x00151FE8
		// (set) Token: 0x0600492A RID: 18730 RVA: 0x0001AA89 File Offset: 0x00018C89
		public unsafe char delimiter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_delimiter)) = value;
			}
		}

		// Token: 0x170012A8 RID: 4776
		// (get) Token: 0x0600492B RID: 18731 RVA: 0x00153E10 File Offset: 0x00152010
		// (set) Token: 0x0600492C RID: 18732 RVA: 0x0001AAA4 File Offset: 0x00018CA4
		public unsafe int base_num
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_base_num)) = value;
			}
		}

		// Token: 0x170012A9 RID: 4777
		// (get) Token: 0x0600492D RID: 18733 RVA: 0x00153E38 File Offset: 0x00152038
		// (set) Token: 0x0600492E RID: 18734 RVA: 0x0001AABF File Offset: 0x00018CBF
		public unsafe int tmin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmin)) = value;
			}
		}

		// Token: 0x170012AA RID: 4778
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x00153E60 File Offset: 0x00152060
		// (set) Token: 0x06004930 RID: 18736 RVA: 0x0001AADA File Offset: 0x00018CDA
		public unsafe int tmax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_tmax)) = value;
			}
		}

		// Token: 0x170012AB RID: 4779
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x00153E88 File Offset: 0x00152088
		// (set) Token: 0x06004932 RID: 18738 RVA: 0x0001AAF5 File Offset: 0x00018CF5
		public unsafe int skew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_skew)) = value;
			}
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x00153EB0 File Offset: 0x001520B0
		// (set) Token: 0x06004934 RID: 18740 RVA: 0x0001AB10 File Offset: 0x00018D10
		public unsafe int damp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_damp)) = value;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06004935 RID: 18741 RVA: 0x00153ED8 File Offset: 0x001520D8
		// (set) Token: 0x06004936 RID: 18742 RVA: 0x0001AB2B File Offset: 0x00018D2B
		public unsafe int initial_bias
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_bias)) = value;
			}
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06004937 RID: 18743 RVA: 0x00153F00 File Offset: 0x00152100
		// (set) Token: 0x06004938 RID: 18744 RVA: 0x0001AB46 File Offset: 0x00018D46
		public unsafe int initial_n
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Bootstring.NativeFieldInfoPtr_initial_n)) = value;
			}
		}

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeFieldInfoPtr_delimiter;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeFieldInfoPtr_base_num;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeFieldInfoPtr_tmin;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeFieldInfoPtr_tmax;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeFieldInfoPtr_skew;

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeFieldInfoPtr_damp;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeFieldInfoPtr_initial_bias;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeFieldInfoPtr_initial_n;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_Int32_Int32_Int32_Int32_Int32_Int32_Int32_0;

		// Token: 0x04003C15 RID: 15381
		private static readonly IntPtr NativeMethodInfoPtr_Encode_Public_String_String_Int32_0;

		// Token: 0x04003C16 RID: 15382
		private static readonly IntPtr NativeMethodInfoPtr_EncodeDigit_Private_Char_Int32_0;

		// Token: 0x04003C17 RID: 15383
		private static readonly IntPtr NativeMethodInfoPtr_DecodeDigit_Private_Int32_Char_0;

		// Token: 0x04003C18 RID: 15384
		private static readonly IntPtr NativeMethodInfoPtr_Adapt_Private_Int32_Int32_Int32_Boolean_0;

		// Token: 0x04003C19 RID: 15385
		private static readonly IntPtr NativeMethodInfoPtr_Decode_Public_String_String_Int32_0;
	}
}
