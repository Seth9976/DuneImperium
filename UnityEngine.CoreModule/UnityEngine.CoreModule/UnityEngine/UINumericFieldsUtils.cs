using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000172 RID: 370
	public static class UINumericFieldsUtils : Object
	{
		// Token: 0x06001BBD RID: 7101 RVA: 0x0007EB68 File Offset: 0x0007CD68
		// Note: this type is marked as 'beforefieldinit'.
		static UINumericFieldsUtils()
		{
			Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UINumericFieldsUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr);
			UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForFloat");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_AllowedCharactersForInt");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_DoubleFieldFormatString");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_FloatFieldFormatString");
			UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, "k_IntFieldFormatString");
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667075);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667076);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667077);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667078);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667079);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667080);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667081);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667082);
			UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UINumericFieldsUtils>.NativeClassPtr, 100667083);
		}

		// Token: 0x06001BBE RID: 7102 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 674193, RefRangeEnd = 674197, XrefRangeStart = 674167, XrefRangeEnd = 674193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToDouble(string str, out double value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BBF RID: 7103 RVA: 0x0007ED24 File Offset: 0x0007CF24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674208, RefRangeEnd = 674209, XrefRangeStart = 674197, XrefRangeEnd = 674208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToDouble(string str, string initialValueAsString, out double value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC0 RID: 7104 RVA: 0x0007EDA8 File Offset: 0x0007CFA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 674227, RefRangeEnd = 674229, XrefRangeStart = 674209, XrefRangeEnd = 674227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToFloat(string str, string initialValueAsString, out float value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC1 RID: 7105 RVA: 0x0007EE2C File Offset: 0x0007D02C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674235, RefRangeEnd = 674236, XrefRangeStart = 674229, XrefRangeEnd = 674235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToLong(string str, out long value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC2 RID: 7106 RVA: 0x0007EEA0 File Offset: 0x0007D0A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 674252, RefRangeEnd = 674255, XrefRangeStart = 674236, XrefRangeEnd = 674252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToLong(string str, string initialValueAsString, out long value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC3 RID: 7107 RVA: 0x0007EF24 File Offset: 0x0007D124
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674261, RefRangeEnd = 674262, XrefRangeStart = 674255, XrefRangeEnd = 674261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToULong(string str, out ulong value, out ExpressionEvaluator.Expression expr)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expr = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC4 RID: 7108 RVA: 0x0007EF98 File Offset: 0x0007D198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674278, RefRangeEnd = 674279, XrefRangeStart = 674262, XrefRangeEnd = 674278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToULong(string str, string initialValueAsString, out ulong value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC5 RID: 7109 RVA: 0x0007F01C File Offset: 0x0007D21C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 674284, RefRangeEnd = 674286, XrefRangeStart = 674279, XrefRangeEnd = 674284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToInt(string str, string initialValueAsString, out int value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC6 RID: 7110 RVA: 0x0007F0A0 File Offset: 0x0007D2A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 674291, RefRangeEnd = 674292, XrefRangeStart = 674286, XrefRangeEnd = 674291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryConvertStringToUInt(string str, string initialValueAsString, out uint value, out ExpressionEvaluator.Expression expression)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(initialValueAsString);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &value;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UINumericFieldsUtils.NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			expression = ((intPtr4 == 0) ? null : new ExpressionEvaluator.Expression(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001BC7 RID: 7111 RVA: 0x0000ABDC File Offset: 0x00008DDC
		public UINumericFieldsUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005D0 RID: 1488
		// (get) Token: 0x06001BC8 RID: 7112 RVA: 0x0007F124 File Offset: 0x0007D324
		// (set) Token: 0x06001BC9 RID: 7113 RVA: 0x0000ABE5 File Offset: 0x00008DE5
		public unsafe static string k_AllowedCharactersForFloat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForFloat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D1 RID: 1489
		// (get) Token: 0x06001BCA RID: 7114 RVA: 0x0007F144 File Offset: 0x0007D344
		// (set) Token: 0x06001BCB RID: 7115 RVA: 0x0000ABF7 File Offset: 0x00008DF7
		public unsafe static string k_AllowedCharactersForInt
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_AllowedCharactersForInt, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D2 RID: 1490
		// (get) Token: 0x06001BCC RID: 7116 RVA: 0x0007F164 File Offset: 0x0007D364
		// (set) Token: 0x06001BCD RID: 7117 RVA: 0x0000AC09 File Offset: 0x00008E09
		public unsafe static string k_DoubleFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_DoubleFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06001BCE RID: 7118 RVA: 0x0007F184 File Offset: 0x0007D384
		// (set) Token: 0x06001BCF RID: 7119 RVA: 0x0000AC1B File Offset: 0x00008E1B
		public unsafe static string k_FloatFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_FloatFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001BD0 RID: 7120 RVA: 0x0007F1A4 File Offset: 0x0007D3A4
		// (set) Token: 0x06001BD1 RID: 7121 RVA: 0x0000AC2D File Offset: 0x00008E2D
		public unsafe static string k_IntFieldFormatString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UINumericFieldsUtils.NativeFieldInfoPtr_k_IntFieldFormatString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x06001BD2 RID: 7122 RVA: 0x0007F1C4 File Offset: 0x0007D3C4
		public static bool TryConvertStringToDouble(string str, out double value)
		{
			ExpressionEvaluator.Expression expression;
			return UINumericFieldsUtils.TryConvertStringToDouble(str, out value, out expression);
		}

		// Token: 0x06001BD3 RID: 7123 RVA: 0x0007F1E0 File Offset: 0x0007D3E0
		public static bool TryConvertStringToLong(string str, out long value)
		{
			ExpressionEvaluator.Expression expression;
			return ExpressionEvaluator.Evaluate<long>(str, out value, out expression);
		}

		// Token: 0x0400186C RID: 6252
		private static readonly IntPtr NativeFieldInfoPtr_k_AllowedCharactersForFloat;

		// Token: 0x0400186D RID: 6253
		private static readonly IntPtr NativeFieldInfoPtr_k_AllowedCharactersForInt;

		// Token: 0x0400186E RID: 6254
		private static readonly IntPtr NativeFieldInfoPtr_k_DoubleFieldFormatString;

		// Token: 0x0400186F RID: 6255
		private static readonly IntPtr NativeFieldInfoPtr_k_FloatFieldFormatString;

		// Token: 0x04001870 RID: 6256
		private static readonly IntPtr NativeFieldInfoPtr_k_IntFieldFormatString;

		// Token: 0x04001871 RID: 6257
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_byref_Double_byref_Expression_0;

		// Token: 0x04001872 RID: 6258
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToDouble_Public_Static_Boolean_String_String_byref_Double_byref_Expression_0;

		// Token: 0x04001873 RID: 6259
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToFloat_Public_Static_Boolean_String_String_byref_Single_byref_Expression_0;

		// Token: 0x04001874 RID: 6260
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_byref_Int64_byref_Expression_0;

		// Token: 0x04001875 RID: 6261
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToLong_Public_Static_Boolean_String_String_byref_Int64_byref_Expression_0;

		// Token: 0x04001876 RID: 6262
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_byref_UInt64_byref_Expression_0;

		// Token: 0x04001877 RID: 6263
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToULong_Public_Static_Boolean_String_String_byref_UInt64_byref_Expression_0;

		// Token: 0x04001878 RID: 6264
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToInt_Public_Static_Boolean_String_String_byref_Int32_byref_Expression_0;

		// Token: 0x04001879 RID: 6265
		private static readonly IntPtr NativeMethodInfoPtr_TryConvertStringToUInt_Public_Static_Boolean_String_String_byref_UInt32_byref_Expression_0;
	}
}
