using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Globalization
{
	// Token: 0x02000487 RID: 1159
	[Serializable]
	public sealed class NumberFormatInfo : Object
	{
		// Token: 0x0600469F RID: 18079 RVA: 0x0014A618 File Offset: 0x00148818
		// Note: this type is marked as 'beforefieldinit'.
		static NumberFormatInfo()
		{
			Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Globalization", "NumberFormatInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr);
			NumberFormatInfo.NativeFieldInfoPtr_invariantInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "invariantInfo");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSizes");
			NumberFormatInfo.NativeFieldInfoPtr_positiveSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveSign");
			NumberFormatInfo.NativeFieldInfoPtr_negativeSign = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeSign");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_currencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "ansiCurrencySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nanSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nanSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "positiveInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "negativeInfinitySymbol");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentGroupSeparator");
			NumberFormatInfo.NativeFieldInfoPtr_percentSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "perMilleSymbol");
			NumberFormatInfo.NativeFieldInfoPtr_nativeDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "nativeDigits");
			NumberFormatInfo.NativeFieldInfoPtr_m_dataItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_dataItem");
			NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "currencyNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "numberNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentPositivePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentNegativePattern");
			NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "percentDecimalDigits");
			NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "digitSubstitution");
			NumberFormatInfo.NativeFieldInfoPtr_isReadOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "isReadOnly");
			NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_useUserOverride");
			NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "m_isInvariant");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsNumber");
			NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "validForParseAsCurrency");
			NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, "InvalidNumberStyles");
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673671);
			NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673672);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673673);
			NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673674);
			NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673675);
			NumberFormatInfo.NativeMethodInfoPtr_VerifyWritable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673676);
			NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673677);
			NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673678);
			NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673679);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673680);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673681);
			NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673682);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673683);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673684);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673685);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673686);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673687);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673688);
			NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673689);
			NumberFormatInfo.NativeMethodInfoPtr_set_NaNSymbol_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673690);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673691);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673692);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673693);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673694);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673695);
			NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673696);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673697);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673698);
			NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673699);
			NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673700);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673701);
			NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673702);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673703);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673704);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673705);
			NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673706);
			NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673707);
			NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673708);
			NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673709);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673710);
			NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr, 100673711);
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x0014AC4C File Offset: 0x00148E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410707, XrefRangeEnd = 1410708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x0014AC88 File Offset: 0x00148E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1410708, XrefRangeEnd = 1410713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSerializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x0014ACD0 File Offset: 0x00148ED0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserializing(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x0014AD18 File Offset: 0x00148F18
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDeserialized(StreamingContext ctx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ctx));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x0014AD60 File Offset: 0x00148F60
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1410819, RefRangeEnd = 1410823, XrefRangeStart = 1410713, XrefRangeEnd = 1410819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberFormatInfo(CultureData cultureData)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberFormatInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cultureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x0014ADAC File Offset: 0x00148FAC
		[CallerCount(0)]
		public unsafe void VerifyWritable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_VerifyWritable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170011CE RID: 4558
		// (get) Token: 0x060046A6 RID: 18086 RVA: 0x0014ADE0 File Offset: 0x00148FE0
		public unsafe static NumberFormatInfo InvariantInfo
		{
			[CallerCount(119)]
			[CachedScanResults(RefRangeStart = 1410838, RefRangeEnd = 1410957, XrefRangeStart = 1410823, XrefRangeEnd = 1410838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x0014AE14 File Offset: 0x00149014
		[CallerCount(57)]
		[CachedScanResults(RefRangeStart = 1410965, RefRangeEnd = 1411022, XrefRangeStart = 1410957, XrefRangeEnd = 1410965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x0014AE58 File Offset: 0x00149058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1411025, RefRangeEnd = 1411027, XrefRangeStart = 1411022, XrefRangeEnd = 1411025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x170011CF RID: 4559
		// (get) Token: 0x060046A9 RID: 18089 RVA: 0x0014AE98 File Offset: 0x00149098
		public unsafe int CurrencyDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011D0 RID: 4560
		// (get) Token: 0x060046AA RID: 18090 RVA: 0x0014AED4 File Offset: 0x001490D4
		public unsafe string CurrencyDecimalSeparator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011D1 RID: 4561
		// (get) Token: 0x060046AB RID: 18091 RVA: 0x0014AF0C File Offset: 0x0014910C
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011D2 RID: 4562
		// (get) Token: 0x060046AC RID: 18092 RVA: 0x0014AF48 File Offset: 0x00149148
		public unsafe Il2CppStructArray<int> CurrencyGroupSizes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411030, RefRangeEnd = 1411031, XrefRangeStart = 1411027, XrefRangeEnd = 1411030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170011D3 RID: 4563
		// (get) Token: 0x060046AD RID: 18093 RVA: 0x0014AF88 File Offset: 0x00149188
		public unsafe Il2CppStructArray<int> NumberGroupSizes
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1411034, RefRangeEnd = 1411037, XrefRangeStart = 1411031, XrefRangeEnd = 1411034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170011D4 RID: 4564
		// (get) Token: 0x060046AE RID: 18094 RVA: 0x0014AFC8 File Offset: 0x001491C8
		public unsafe Il2CppStructArray<int> PercentGroupSizes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1411040, RefRangeEnd = 1411041, XrefRangeStart = 1411037, XrefRangeEnd = 1411040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x170011D5 RID: 4565
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x0014B008 File Offset: 0x00149208
		public unsafe string CurrencyGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011D6 RID: 4566
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x0014B040 File Offset: 0x00149240
		public unsafe string CurrencySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011D7 RID: 4567
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x0014B078 File Offset: 0x00149278
		public unsafe static NumberFormatInfo CurrentInfo
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 1411047, RefRangeEnd = 1411068, XrefRangeStart = 1411041, XrefRangeEnd = 1411047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x170011D8 RID: 4568
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x0014B0AC File Offset: 0x001492AC
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x0014B0E4 File Offset: 0x001492E4
		public unsafe string NaNSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411068, XrefRangeEnd = 1411084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_set_NaNSymbol_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170011D9 RID: 4569
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x0014B128 File Offset: 0x00149328
		public unsafe int CurrencyNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011DA RID: 4570
		// (get) Token: 0x060046B5 RID: 18101 RVA: 0x0014B164 File Offset: 0x00149364
		public unsafe int NumberNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011DB RID: 4571
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x0014B1A0 File Offset: 0x001493A0
		public unsafe int PercentPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011DC RID: 4572
		// (get) Token: 0x060046B7 RID: 18103 RVA: 0x0014B1DC File Offset: 0x001493DC
		public unsafe int PercentNegativePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011DD RID: 4573
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0014B218 File Offset: 0x00149418
		public unsafe string NegativeInfinitySymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011DE RID: 4574
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x0014B250 File Offset: 0x00149450
		public unsafe string NegativeSign
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x0014B288 File Offset: 0x00149488
		public unsafe int NumberDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060046BB RID: 18107 RVA: 0x0014B2C4 File Offset: 0x001494C4
		public unsafe string NumberDecimalSeparator
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0014B2FC File Offset: 0x001494FC
		public unsafe string NumberGroupSeparator
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060046BD RID: 18109 RVA: 0x0014B334 File Offset: 0x00149534
		public unsafe int CurrencyPositivePattern
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011E3 RID: 4579
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x0014B370 File Offset: 0x00149570
		public unsafe string PositiveInfinitySymbol
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 34746, RefRangeEnd = 34747, XrefRangeStart = 34746, XrefRangeEnd = 34747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E4 RID: 4580
		// (get) Token: 0x060046BF RID: 18111 RVA: 0x0014B3A8 File Offset: 0x001495A8
		public unsafe string PositiveSign
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E5 RID: 4581
		// (get) Token: 0x060046C0 RID: 18112 RVA: 0x0014B3E0 File Offset: 0x001495E0
		public unsafe int PercentDecimalDigits
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011E6 RID: 4582
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x0014B41C File Offset: 0x0014961C
		public unsafe string PercentDecimalSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060046C2 RID: 18114 RVA: 0x0014B454 File Offset: 0x00149654
		public unsafe string PercentGroupSeparator
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x0014B48C File Offset: 0x0014968C
		public unsafe string PercentSymbol
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060046C4 RID: 18116 RVA: 0x0014B4C4 File Offset: 0x001496C4
		public unsafe string PerMilleSymbol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0014B4FC File Offset: 0x001496FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411084, XrefRangeEnd = 1411091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetFormat(Type formatType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(formatType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x0014B54C File Offset: 0x0014974C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1411091, XrefRangeEnd = 1411094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nfi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0014B590 File Offset: 0x00149790
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 1411094, RefRangeEnd = 1411114, XrefRangeStart = 1411094, XrefRangeEnd = 1411094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleInteger(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0014B5C4 File Offset: 0x001497C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1411114, RefRangeEnd = 1411120, XrefRangeStart = 1411114, XrefRangeEnd = 1411114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateParseStyleFloatingPoint(NumberStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberFormatInfo.NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x000199C1 File Offset: 0x00017BC1
		public NumberFormatInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170011AA RID: 4522
		// (get) Token: 0x060046CA RID: 18122 RVA: 0x0014B5F8 File Offset: 0x001497F8
		// (set) Token: 0x060046CB RID: 18123 RVA: 0x000199CA File Offset: 0x00017BCA
		public unsafe static NumberFormatInfo invariantInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFormatInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_invariantInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AB RID: 4523
		// (get) Token: 0x060046CC RID: 18124 RVA: 0x0014B620 File Offset: 0x00149820
		// (set) Token: 0x060046CD RID: 18125 RVA: 0x000199DC File Offset: 0x00017BDC
		public unsafe Il2CppStructArray<int> numberGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AC RID: 4524
		// (get) Token: 0x060046CE RID: 18126 RVA: 0x0014B650 File Offset: 0x00149850
		// (set) Token: 0x060046CF RID: 18127 RVA: 0x000199FB File Offset: 0x00017BFB
		public unsafe Il2CppStructArray<int> currencyGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AD RID: 4525
		// (get) Token: 0x060046D0 RID: 18128 RVA: 0x0014B680 File Offset: 0x00149880
		// (set) Token: 0x060046D1 RID: 18129 RVA: 0x00019A1A File Offset: 0x00017C1A
		public unsafe Il2CppStructArray<int> percentGroupSizes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSizes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011AE RID: 4526
		// (get) Token: 0x060046D2 RID: 18130 RVA: 0x0014B6B0 File Offset: 0x001498B0
		// (set) Token: 0x060046D3 RID: 18131 RVA: 0x00019A39 File Offset: 0x00017C39
		public unsafe string positiveSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011AF RID: 4527
		// (get) Token: 0x060046D4 RID: 18132 RVA: 0x0014B6D8 File Offset: 0x001498D8
		// (set) Token: 0x060046D5 RID: 18133 RVA: 0x00019A58 File Offset: 0x00017C58
		public unsafe string negativeSign
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeSign), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x0014B700 File Offset: 0x00149900
		// (set) Token: 0x060046D7 RID: 18135 RVA: 0x00019A77 File Offset: 0x00017C77
		public unsafe string numberDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x060046D8 RID: 18136 RVA: 0x0014B728 File Offset: 0x00149928
		// (set) Token: 0x060046D9 RID: 18137 RVA: 0x00019A96 File Offset: 0x00017C96
		public unsafe string numberGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x060046DA RID: 18138 RVA: 0x0014B750 File Offset: 0x00149950
		// (set) Token: 0x060046DB RID: 18139 RVA: 0x00019AB5 File Offset: 0x00017CB5
		public unsafe string currencyGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x0014B778 File Offset: 0x00149978
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x00019AD4 File Offset: 0x00017CD4
		public unsafe string currencyDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x0014B7A0 File Offset: 0x001499A0
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x00019AF3 File Offset: 0x00017CF3
		public unsafe string currencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0014B7C8 File Offset: 0x001499C8
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x00019B12 File Offset: 0x00017D12
		public unsafe string ansiCurrencySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_ansiCurrencySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x060046E2 RID: 18146 RVA: 0x0014B7F0 File Offset: 0x001499F0
		// (set) Token: 0x060046E3 RID: 18147 RVA: 0x00019B31 File Offset: 0x00017D31
		public unsafe string nanSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nanSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x060046E4 RID: 18148 RVA: 0x0014B818 File Offset: 0x00149A18
		// (set) Token: 0x060046E5 RID: 18149 RVA: 0x00019B50 File Offset: 0x00017D50
		public unsafe string positiveInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_positiveInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x060046E6 RID: 18150 RVA: 0x0014B840 File Offset: 0x00149A40
		// (set) Token: 0x060046E7 RID: 18151 RVA: 0x00019B6F File Offset: 0x00017D6F
		public unsafe string negativeInfinitySymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_negativeInfinitySymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x060046E8 RID: 18152 RVA: 0x0014B868 File Offset: 0x00149A68
		// (set) Token: 0x060046E9 RID: 18153 RVA: 0x00019B8E File Offset: 0x00017D8E
		public unsafe string percentDecimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011BA RID: 4538
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x0014B890 File Offset: 0x00149A90
		// (set) Token: 0x060046EB RID: 18155 RVA: 0x00019BAD File Offset: 0x00017DAD
		public unsafe string percentGroupSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentGroupSeparator), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011BB RID: 4539
		// (get) Token: 0x060046EC RID: 18156 RVA: 0x0014B8B8 File Offset: 0x00149AB8
		// (set) Token: 0x060046ED RID: 18157 RVA: 0x00019BCC File Offset: 0x00017DCC
		public unsafe string percentSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011BC RID: 4540
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x0014B8E0 File Offset: 0x00149AE0
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x00019BEB File Offset: 0x00017DEB
		public unsafe string perMilleSymbol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_perMilleSymbol), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170011BD RID: 4541
		// (get) Token: 0x060046F0 RID: 18160 RVA: 0x0014B908 File Offset: 0x00149B08
		// (set) Token: 0x060046F1 RID: 18161 RVA: 0x00019C0A File Offset: 0x00017E0A
		public unsafe Il2CppStringArray nativeDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_nativeDigits), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170011BE RID: 4542
		// (get) Token: 0x060046F2 RID: 18162 RVA: 0x0014B938 File Offset: 0x00149B38
		// (set) Token: 0x060046F3 RID: 18163 RVA: 0x00019C29 File Offset: 0x00017E29
		public unsafe int m_dataItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_dataItem)) = value;
			}
		}

		// Token: 0x170011BF RID: 4543
		// (get) Token: 0x060046F4 RID: 18164 RVA: 0x0014B960 File Offset: 0x00149B60
		// (set) Token: 0x060046F5 RID: 18165 RVA: 0x00019C44 File Offset: 0x00017E44
		public unsafe int numberDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberDecimalDigits)) = value;
			}
		}

		// Token: 0x170011C0 RID: 4544
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x0014B988 File Offset: 0x00149B88
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x00019C5F File Offset: 0x00017E5F
		public unsafe int currencyDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyDecimalDigits)) = value;
			}
		}

		// Token: 0x170011C1 RID: 4545
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x0014B9B0 File Offset: 0x00149BB0
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x00019C7A File Offset: 0x00017E7A
		public unsafe int currencyPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyPositivePattern)) = value;
			}
		}

		// Token: 0x170011C2 RID: 4546
		// (get) Token: 0x060046FA RID: 18170 RVA: 0x0014B9D8 File Offset: 0x00149BD8
		// (set) Token: 0x060046FB RID: 18171 RVA: 0x00019C95 File Offset: 0x00017E95
		public unsafe int currencyNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_currencyNegativePattern)) = value;
			}
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060046FC RID: 18172 RVA: 0x0014BA00 File Offset: 0x00149C00
		// (set) Token: 0x060046FD RID: 18173 RVA: 0x00019CB0 File Offset: 0x00017EB0
		public unsafe int numberNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_numberNegativePattern)) = value;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060046FE RID: 18174 RVA: 0x0014BA28 File Offset: 0x00149C28
		// (set) Token: 0x060046FF RID: 18175 RVA: 0x00019CCB File Offset: 0x00017ECB
		public unsafe int percentPositivePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentPositivePattern)) = value;
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06004700 RID: 18176 RVA: 0x0014BA50 File Offset: 0x00149C50
		// (set) Token: 0x06004701 RID: 18177 RVA: 0x00019CE6 File Offset: 0x00017EE6
		public unsafe int percentNegativePattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentNegativePattern)) = value;
			}
		}

		// Token: 0x170011C6 RID: 4550
		// (get) Token: 0x06004702 RID: 18178 RVA: 0x0014BA78 File Offset: 0x00149C78
		// (set) Token: 0x06004703 RID: 18179 RVA: 0x00019D01 File Offset: 0x00017F01
		public unsafe int percentDecimalDigits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_percentDecimalDigits)) = value;
			}
		}

		// Token: 0x170011C7 RID: 4551
		// (get) Token: 0x06004704 RID: 18180 RVA: 0x0014BAA0 File Offset: 0x00149CA0
		// (set) Token: 0x06004705 RID: 18181 RVA: 0x00019D1C File Offset: 0x00017F1C
		public unsafe int digitSubstitution
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_digitSubstitution)) = value;
			}
		}

		// Token: 0x170011C8 RID: 4552
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0014BAC8 File Offset: 0x00149CC8
		// (set) Token: 0x06004707 RID: 18183 RVA: 0x00019D37 File Offset: 0x00017F37
		public unsafe bool isReadOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_isReadOnly)) = value;
			}
		}

		// Token: 0x170011C9 RID: 4553
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x0014BAF0 File Offset: 0x00149CF0
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00019D52 File Offset: 0x00017F52
		public unsafe bool m_useUserOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_useUserOverride)) = value;
			}
		}

		// Token: 0x170011CA RID: 4554
		// (get) Token: 0x0600470A RID: 18186 RVA: 0x0014BB18 File Offset: 0x00149D18
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x00019D6D File Offset: 0x00017F6D
		public unsafe bool m_isInvariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_m_isInvariant)) = value;
			}
		}

		// Token: 0x170011CB RID: 4555
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x0014BB40 File Offset: 0x00149D40
		// (set) Token: 0x0600470D RID: 18189 RVA: 0x00019D88 File Offset: 0x00017F88
		public unsafe bool validForParseAsNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsNumber)) = value;
			}
		}

		// Token: 0x170011CC RID: 4556
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x0014BB68 File Offset: 0x00149D68
		// (set) Token: 0x0600470F RID: 18191 RVA: 0x00019DA3 File Offset: 0x00017FA3
		public unsafe bool validForParseAsCurrency
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberFormatInfo.NativeFieldInfoPtr_validForParseAsCurrency)) = value;
			}
		}

		// Token: 0x170011CD RID: 4557
		// (get) Token: 0x06004710 RID: 18192 RVA: 0x0014BB90 File Offset: 0x00149D90
		// (set) Token: 0x06004711 RID: 18193 RVA: 0x00019DBE File Offset: 0x00017FBE
		public unsafe static NumberStyles InvalidNumberStyles
		{
			get
			{
				NumberStyles numberStyles;
				IL2CPP.il2cpp_field_static_get_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&numberStyles));
				return numberStyles;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NumberFormatInfo.NativeFieldInfoPtr_InvalidNumberStyles, (void*)(&value));
			}
		}

		// Token: 0x04003A4C RID: 14924
		private static readonly IntPtr NativeFieldInfoPtr_invariantInfo;

		// Token: 0x04003A4D RID: 14925
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSizes;

		// Token: 0x04003A4E RID: 14926
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSizes;

		// Token: 0x04003A4F RID: 14927
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSizes;

		// Token: 0x04003A50 RID: 14928
		private static readonly IntPtr NativeFieldInfoPtr_positiveSign;

		// Token: 0x04003A51 RID: 14929
		private static readonly IntPtr NativeFieldInfoPtr_negativeSign;

		// Token: 0x04003A52 RID: 14930
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalSeparator;

		// Token: 0x04003A53 RID: 14931
		private static readonly IntPtr NativeFieldInfoPtr_numberGroupSeparator;

		// Token: 0x04003A54 RID: 14932
		private static readonly IntPtr NativeFieldInfoPtr_currencyGroupSeparator;

		// Token: 0x04003A55 RID: 14933
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalSeparator;

		// Token: 0x04003A56 RID: 14934
		private static readonly IntPtr NativeFieldInfoPtr_currencySymbol;

		// Token: 0x04003A57 RID: 14935
		private static readonly IntPtr NativeFieldInfoPtr_ansiCurrencySymbol;

		// Token: 0x04003A58 RID: 14936
		private static readonly IntPtr NativeFieldInfoPtr_nanSymbol;

		// Token: 0x04003A59 RID: 14937
		private static readonly IntPtr NativeFieldInfoPtr_positiveInfinitySymbol;

		// Token: 0x04003A5A RID: 14938
		private static readonly IntPtr NativeFieldInfoPtr_negativeInfinitySymbol;

		// Token: 0x04003A5B RID: 14939
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalSeparator;

		// Token: 0x04003A5C RID: 14940
		private static readonly IntPtr NativeFieldInfoPtr_percentGroupSeparator;

		// Token: 0x04003A5D RID: 14941
		private static readonly IntPtr NativeFieldInfoPtr_percentSymbol;

		// Token: 0x04003A5E RID: 14942
		private static readonly IntPtr NativeFieldInfoPtr_perMilleSymbol;

		// Token: 0x04003A5F RID: 14943
		private static readonly IntPtr NativeFieldInfoPtr_nativeDigits;

		// Token: 0x04003A60 RID: 14944
		private static readonly IntPtr NativeFieldInfoPtr_m_dataItem;

		// Token: 0x04003A61 RID: 14945
		private static readonly IntPtr NativeFieldInfoPtr_numberDecimalDigits;

		// Token: 0x04003A62 RID: 14946
		private static readonly IntPtr NativeFieldInfoPtr_currencyDecimalDigits;

		// Token: 0x04003A63 RID: 14947
		private static readonly IntPtr NativeFieldInfoPtr_currencyPositivePattern;

		// Token: 0x04003A64 RID: 14948
		private static readonly IntPtr NativeFieldInfoPtr_currencyNegativePattern;

		// Token: 0x04003A65 RID: 14949
		private static readonly IntPtr NativeFieldInfoPtr_numberNegativePattern;

		// Token: 0x04003A66 RID: 14950
		private static readonly IntPtr NativeFieldInfoPtr_percentPositivePattern;

		// Token: 0x04003A67 RID: 14951
		private static readonly IntPtr NativeFieldInfoPtr_percentNegativePattern;

		// Token: 0x04003A68 RID: 14952
		private static readonly IntPtr NativeFieldInfoPtr_percentDecimalDigits;

		// Token: 0x04003A69 RID: 14953
		private static readonly IntPtr NativeFieldInfoPtr_digitSubstitution;

		// Token: 0x04003A6A RID: 14954
		private static readonly IntPtr NativeFieldInfoPtr_isReadOnly;

		// Token: 0x04003A6B RID: 14955
		private static readonly IntPtr NativeFieldInfoPtr_m_useUserOverride;

		// Token: 0x04003A6C RID: 14956
		private static readonly IntPtr NativeFieldInfoPtr_m_isInvariant;

		// Token: 0x04003A6D RID: 14957
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsNumber;

		// Token: 0x04003A6E RID: 14958
		private static readonly IntPtr NativeFieldInfoPtr_validForParseAsCurrency;

		// Token: 0x04003A6F RID: 14959
		private static readonly IntPtr NativeFieldInfoPtr_InvalidNumberStyles;

		// Token: 0x04003A70 RID: 14960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003A71 RID: 14961
		private static readonly IntPtr NativeMethodInfoPtr_OnSerializing_Private_Void_StreamingContext_0;

		// Token: 0x04003A72 RID: 14962
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserializing_Private_Void_StreamingContext_0;

		// Token: 0x04003A73 RID: 14963
		private static readonly IntPtr NativeMethodInfoPtr_OnDeserialized_Private_Void_StreamingContext_0;

		// Token: 0x04003A74 RID: 14964
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_CultureData_0;

		// Token: 0x04003A75 RID: 14965
		private static readonly IntPtr NativeMethodInfoPtr_VerifyWritable_Private_Void_0;

		// Token: 0x04003A76 RID: 14966
		private static readonly IntPtr NativeMethodInfoPtr_get_InvariantInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x04003A77 RID: 14967
		private static readonly IntPtr NativeMethodInfoPtr_GetInstance_Public_Static_NumberFormatInfo_IFormatProvider_0;

		// Token: 0x04003A78 RID: 14968
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;

		// Token: 0x04003A79 RID: 14969
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalDigits_Public_get_Int32_0;

		// Token: 0x04003A7A RID: 14970
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyDecimalSeparator_Public_get_String_0;

		// Token: 0x04003A7B RID: 14971
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04003A7C RID: 14972
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A7D RID: 14973
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A7E RID: 14974
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSizes_Public_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x04003A7F RID: 14975
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyGroupSeparator_Public_get_String_0;

		// Token: 0x04003A80 RID: 14976
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencySymbol_Public_get_String_0;

		// Token: 0x04003A81 RID: 14977
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentInfo_Public_Static_get_NumberFormatInfo_0;

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeMethodInfoPtr_get_NaNSymbol_Public_get_String_0;

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeMethodInfoPtr_set_NaNSymbol_Public_set_Void_String_0;

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyNegativePattern_Public_get_Int32_0;

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberNegativePattern_Public_get_Int32_0;

		// Token: 0x04003A86 RID: 14982
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentPositivePattern_Public_get_Int32_0;

		// Token: 0x04003A87 RID: 14983
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentNegativePattern_Public_get_Int32_0;

		// Token: 0x04003A88 RID: 14984
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeInfinitySymbol_Public_get_String_0;

		// Token: 0x04003A89 RID: 14985
		private static readonly IntPtr NativeMethodInfoPtr_get_NegativeSign_Public_get_String_0;

		// Token: 0x04003A8A RID: 14986
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalDigits_Public_get_Int32_0;

		// Token: 0x04003A8B RID: 14987
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberDecimalSeparator_Public_get_String_0;

		// Token: 0x04003A8C RID: 14988
		private static readonly IntPtr NativeMethodInfoPtr_get_NumberGroupSeparator_Public_get_String_0;

		// Token: 0x04003A8D RID: 14989
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrencyPositivePattern_Public_get_Int32_0;

		// Token: 0x04003A8E RID: 14990
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveInfinitySymbol_Public_get_String_0;

		// Token: 0x04003A8F RID: 14991
		private static readonly IntPtr NativeMethodInfoPtr_get_PositiveSign_Public_get_String_0;

		// Token: 0x04003A90 RID: 14992
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalDigits_Public_get_Int32_0;

		// Token: 0x04003A91 RID: 14993
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentDecimalSeparator_Public_get_String_0;

		// Token: 0x04003A92 RID: 14994
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentGroupSeparator_Public_get_String_0;

		// Token: 0x04003A93 RID: 14995
		private static readonly IntPtr NativeMethodInfoPtr_get_PercentSymbol_Public_get_String_0;

		// Token: 0x04003A94 RID: 14996
		private static readonly IntPtr NativeMethodInfoPtr_get_PerMilleSymbol_Public_get_String_0;

		// Token: 0x04003A95 RID: 14997
		private static readonly IntPtr NativeMethodInfoPtr_GetFormat_Public_Virtual_Final_New_Object_Type_0;

		// Token: 0x04003A96 RID: 14998
		private static readonly IntPtr NativeMethodInfoPtr_ReadOnly_Public_Static_NumberFormatInfo_NumberFormatInfo_0;

		// Token: 0x04003A97 RID: 14999
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleInteger_Internal_Static_Void_NumberStyles_0;

		// Token: 0x04003A98 RID: 15000
		private static readonly IntPtr NativeMethodInfoPtr_ValidateParseStyleFloatingPoint_Internal_Static_Void_NumberStyles_0;
	}
}
