using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000057 RID: 87
	public sealed class ExpressionParser : Object
	{
		// Token: 0x060008BE RID: 2238 RVA: 0x0002E804 File Offset: 0x0002CA04
		// Note: this type is marked as 'beforefieldinit'.
		static ExpressionParser()
		{
			Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ExpressionParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr);
			ExpressionParser.NativeFieldInfoPtr_s_reservedwords = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "s_reservedwords");
			ExpressionParser.NativeFieldInfoPtr__escape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_escape");
			ExpressionParser.NativeFieldInfoPtr__decimalSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_decimalSeparator");
			ExpressionParser.NativeFieldInfoPtr__listSeparator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_listSeparator");
			ExpressionParser.NativeFieldInfoPtr__exponentL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_exponentL");
			ExpressionParser.NativeFieldInfoPtr__exponentU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_exponentU");
			ExpressionParser.NativeFieldInfoPtr__text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_text");
			ExpressionParser.NativeFieldInfoPtr__pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_pos");
			ExpressionParser.NativeFieldInfoPtr__start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_start");
			ExpressionParser.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_token");
			ExpressionParser.NativeFieldInfoPtr__op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_op");
			ExpressionParser.NativeFieldInfoPtr__ops = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_ops");
			ExpressionParser.NativeFieldInfoPtr__topOperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_topOperator");
			ExpressionParser.NativeFieldInfoPtr__topNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_topNode");
			ExpressionParser.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_table");
			ExpressionParser.NativeFieldInfoPtr__nodeStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_nodeStack");
			ExpressionParser.NativeFieldInfoPtr__prevOperand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_prevOperand");
			ExpressionParser.NativeFieldInfoPtr__expression = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "_expression");
			ExpressionParser.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664742);
			ExpressionParser.NativeMethodInfoPtr_LoadExpression_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664743);
			ExpressionParser.NativeMethodInfoPtr_StartScan_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664744);
			ExpressionParser.NativeMethodInfoPtr_Parse_Internal_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664745);
			ExpressionParser.NativeMethodInfoPtr_ParseAggregateArgument_Private_ExpressionNode_FunctionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664746);
			ExpressionParser.NativeMethodInfoPtr_NodePop_Private_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664747);
			ExpressionParser.NativeMethodInfoPtr_NodePeek_Private_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664748);
			ExpressionParser.NativeMethodInfoPtr_NodePush_Private_Void_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664749);
			ExpressionParser.NativeMethodInfoPtr_BuildExpression_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664750);
			ExpressionParser.NativeMethodInfoPtr_CheckToken_Internal_Void_Tokens_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664751);
			ExpressionParser.NativeMethodInfoPtr_Scan_Internal_Tokens_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664752);
			ExpressionParser.NativeMethodInfoPtr_ScanNumeric_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664753);
			ExpressionParser.NativeMethodInfoPtr_ScanName_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664754);
			ExpressionParser.NativeMethodInfoPtr_ScanName_Private_Void_Char_Char_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664755);
			ExpressionParser.NativeMethodInfoPtr_ScanDate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664756);
			ExpressionParser.NativeMethodInfoPtr_ScanBinaryConstant_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664757);
			ExpressionParser.NativeMethodInfoPtr_ScanReserved_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664758);
			ExpressionParser.NativeMethodInfoPtr_ScanString_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664759);
			ExpressionParser.NativeMethodInfoPtr_ScanToken_Internal_Void_Tokens_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664760);
			ExpressionParser.NativeMethodInfoPtr_ScanWhite_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664761);
			ExpressionParser.NativeMethodInfoPtr_IsWhiteSpace_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664762);
			ExpressionParser.NativeMethodInfoPtr_IsAlphaNumeric_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664763);
			ExpressionParser.NativeMethodInfoPtr_IsDigit_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664764);
			ExpressionParser.NativeMethodInfoPtr_IsAlpha_Private_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, 100664765);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x0002EB7C File Offset: 0x0002CD7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903614, XrefRangeEnd = 903624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionParser(DataTable table)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x0002EBC8 File Offset: 0x0002CDC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903624, XrefRangeEnd = 903633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadExpression(string data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_LoadExpression_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x0002EC0C File Offset: 0x0002CE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903633, XrefRangeEnd = 903695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartScan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_StartScan_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0002EC40 File Offset: 0x0002CE40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903935, RefRangeEnd = 903936, XrefRangeStart = 903695, XrefRangeEnd = 903935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionNode Parse()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_Parse_Internal_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0002EC80 File Offset: 0x0002CE80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 903950, RefRangeEnd = 903951, XrefRangeStart = 903936, XrefRangeEnd = 903950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionNode ParseAggregateArgument(FunctionId aggregate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref aggregate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ParseAggregateArgument_Private_ExpressionNode_FunctionId_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
			}
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x0002ECCC File Offset: 0x0002CECC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 903951, RefRangeEnd = 903958, XrefRangeStart = 903951, XrefRangeEnd = 903951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionNode NodePop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_NodePop_Private_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x0002ED0C File Offset: 0x0002CF0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 903958, RefRangeEnd = 903960, XrefRangeStart = 903958, XrefRangeEnd = 903958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExpressionNode NodePeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_NodePeek_Private_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr3) : null;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0002ED4C File Offset: 0x0002CF4C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 903969, RefRangeEnd = 903975, XrefRangeStart = 903960, XrefRangeEnd = 903969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NodePush(ExpressionNode node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_NodePush_Private_Void_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0002ED90 File Offset: 0x0002CF90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 903997, RefRangeEnd = 904002, XrefRangeStart = 903975, XrefRangeEnd = 903997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BuildExpression(int pri)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pri;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_BuildExpression_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0002EDD0 File Offset: 0x0002CFD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904002, RefRangeEnd = 904003, XrefRangeStart = 904002, XrefRangeEnd = 904002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckToken(Tokens token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_CheckToken_Internal_Void_Tokens_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0002EE10 File Offset: 0x0002D010
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 904046, RefRangeEnd = 904057, XrefRangeStart = 904003, XrefRangeEnd = 904046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Tokens Scan()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_Scan_Internal_Tokens_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0002EE4C File Offset: 0x0002D04C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904058, RefRangeEnd = 904059, XrefRangeStart = 904057, XrefRangeEnd = 904058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanNumeric()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanNumeric_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0002EE80 File Offset: 0x0002D080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 904060, RefRangeEnd = 904062, XrefRangeStart = 904059, XrefRangeEnd = 904060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanName_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0002EEB4 File Offset: 0x0002D0B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 904063, RefRangeEnd = 904065, XrefRangeStart = 904062, XrefRangeEnd = 904063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanName(char chEnd, char esc, string charsToEscape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref chEnd;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref esc;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(charsToEscape);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanName_Private_Void_Char_Char_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0002EF14 File Offset: 0x0002D114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904065, XrefRangeEnd = 904066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanDate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanDate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0002EF48 File Offset: 0x0002D148
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanBinaryConstant()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanBinaryConstant_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0002EF7C File Offset: 0x0002D17C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904084, RefRangeEnd = 904085, XrefRangeStart = 904066, XrefRangeEnd = 904084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanReserved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanReserved_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x0002EFB0 File Offset: 0x0002D1B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 904085, XrefRangeEnd = 904086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanString(char escape)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref escape;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanString_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0002EFF0 File Offset: 0x0002D1F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 904087, RefRangeEnd = 904091, XrefRangeStart = 904086, XrefRangeEnd = 904087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanToken(Tokens token)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref token;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanToken_Internal_Void_Tokens_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0002F030 File Offset: 0x0002D230
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 904092, RefRangeEnd = 904094, XrefRangeStart = 904091, XrefRangeEnd = 904092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ScanWhite()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_ScanWhite_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0002F064 File Offset: 0x0002D264
		[CallerCount(0)]
		public unsafe bool IsWhiteSpace(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_IsWhiteSpace_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D4 RID: 2260 RVA: 0x0002F0B0 File Offset: 0x0002D2B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 904094, RefRangeEnd = 904095, XrefRangeStart = 904094, XrefRangeEnd = 904094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAlphaNumeric(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_IsAlphaNumeric_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x0002F0FC File Offset: 0x0002D2FC
		[CallerCount(0)]
		public unsafe bool IsDigit(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_IsDigit_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x0002F148 File Offset: 0x0002D348
		[CallerCount(0)]
		public unsafe bool IsAlpha(char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ch;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.NativeMethodInfoPtr_IsAlpha_Private_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x00004A2E File Offset: 0x00002C2E
		public ExpressionParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0002F194 File Offset: 0x0002D394
		// (set) Token: 0x060008D9 RID: 2265 RVA: 0x00004A37 File Offset: 0x00002C37
		public unsafe static Il2CppReferenceArray<ExpressionParser.ReservedWords> s_reservedwords
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ExpressionParser.NativeFieldInfoPtr_s_reservedwords, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpressionParser.ReservedWords>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ExpressionParser.NativeFieldInfoPtr_s_reservedwords, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0002F1BC File Offset: 0x0002D3BC
		// (set) Token: 0x060008DB RID: 2267 RVA: 0x00004A49 File Offset: 0x00002C49
		public unsafe char _escape
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__escape);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__escape)) = value;
			}
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0002F1E4 File Offset: 0x0002D3E4
		// (set) Token: 0x060008DD RID: 2269 RVA: 0x00004A64 File Offset: 0x00002C64
		public unsafe char _decimalSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__decimalSeparator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__decimalSeparator)) = value;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0002F20C File Offset: 0x0002D40C
		// (set) Token: 0x060008DF RID: 2271 RVA: 0x00004A7F File Offset: 0x00002C7F
		public unsafe char _listSeparator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__listSeparator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__listSeparator)) = value;
			}
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0002F234 File Offset: 0x0002D434
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x00004A9A File Offset: 0x00002C9A
		public unsafe char _exponentL
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__exponentL);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__exponentL)) = value;
			}
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002F25C File Offset: 0x0002D45C
		// (set) Token: 0x060008E3 RID: 2275 RVA: 0x00004AB5 File Offset: 0x00002CB5
		public unsafe char _exponentU
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__exponentU);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__exponentU)) = value;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002F284 File Offset: 0x0002D484
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x00004AD0 File Offset: 0x00002CD0
		public unsafe Il2CppStructArray<char> _text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0002F2B4 File Offset: 0x0002D4B4
		// (set) Token: 0x060008E7 RID: 2279 RVA: 0x00004AEF File Offset: 0x00002CEF
		public unsafe int _pos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__pos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__pos)) = value;
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0002F2DC File Offset: 0x0002D4DC
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x00004B0A File Offset: 0x00002D0A
		public unsafe int _start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__start)) = value;
			}
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0002F304 File Offset: 0x0002D504
		// (set) Token: 0x060008EB RID: 2283 RVA: 0x00004B25 File Offset: 0x00002D25
		public unsafe Tokens _token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__token)) = value;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0002F32C File Offset: 0x0002D52C
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x00004B40 File Offset: 0x00002D40
		public unsafe int _op
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__op);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__op)) = value;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0002F354 File Offset: 0x0002D554
		// (set) Token: 0x060008EF RID: 2287 RVA: 0x00004B5B File Offset: 0x00002D5B
		public unsafe Il2CppReferenceArray<OperatorInfo> _ops
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__ops);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OperatorInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__ops), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0002F384 File Offset: 0x0002D584
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x00004B7A File Offset: 0x00002D7A
		public unsafe int _topOperator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__topOperator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__topOperator)) = value;
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0002F3AC File Offset: 0x0002D5AC
		// (set) Token: 0x060008F3 RID: 2291 RVA: 0x00004B95 File Offset: 0x00002D95
		public unsafe int _topNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__topNode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__topNode)) = value;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0002F3D4 File Offset: 0x0002D5D4
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x00004BB0 File Offset: 0x00002DB0
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0002F404 File Offset: 0x0002D604
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x00004BCF File Offset: 0x00002DCF
		public unsafe Il2CppReferenceArray<ExpressionNode> _nodeStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__nodeStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpressionNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__nodeStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0002F434 File Offset: 0x0002D634
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x00004BEE File Offset: 0x00002DEE
		public unsafe int _prevOperand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__prevOperand);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__prevOperand)) = value;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0002F45C File Offset: 0x0002D65C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x00004C09 File Offset: 0x00002E09
		public unsafe ExpressionNode _expression
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__expression);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpressionNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.NativeFieldInfoPtr__expression), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400073E RID: 1854
		private static readonly IntPtr NativeFieldInfoPtr_s_reservedwords;

		// Token: 0x0400073F RID: 1855
		private static readonly IntPtr NativeFieldInfoPtr__escape;

		// Token: 0x04000740 RID: 1856
		private static readonly IntPtr NativeFieldInfoPtr__decimalSeparator;

		// Token: 0x04000741 RID: 1857
		private static readonly IntPtr NativeFieldInfoPtr__listSeparator;

		// Token: 0x04000742 RID: 1858
		private static readonly IntPtr NativeFieldInfoPtr__exponentL;

		// Token: 0x04000743 RID: 1859
		private static readonly IntPtr NativeFieldInfoPtr__exponentU;

		// Token: 0x04000744 RID: 1860
		private static readonly IntPtr NativeFieldInfoPtr__text;

		// Token: 0x04000745 RID: 1861
		private static readonly IntPtr NativeFieldInfoPtr__pos;

		// Token: 0x04000746 RID: 1862
		private static readonly IntPtr NativeFieldInfoPtr__start;

		// Token: 0x04000747 RID: 1863
		private static readonly IntPtr NativeFieldInfoPtr__token;

		// Token: 0x04000748 RID: 1864
		private static readonly IntPtr NativeFieldInfoPtr__op;

		// Token: 0x04000749 RID: 1865
		private static readonly IntPtr NativeFieldInfoPtr__ops;

		// Token: 0x0400074A RID: 1866
		private static readonly IntPtr NativeFieldInfoPtr__topOperator;

		// Token: 0x0400074B RID: 1867
		private static readonly IntPtr NativeFieldInfoPtr__topNode;

		// Token: 0x0400074C RID: 1868
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400074D RID: 1869
		private static readonly IntPtr NativeFieldInfoPtr__nodeStack;

		// Token: 0x0400074E RID: 1870
		private static readonly IntPtr NativeFieldInfoPtr__prevOperand;

		// Token: 0x0400074F RID: 1871
		private static readonly IntPtr NativeFieldInfoPtr__expression;

		// Token: 0x04000750 RID: 1872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_0;

		// Token: 0x04000751 RID: 1873
		private static readonly IntPtr NativeMethodInfoPtr_LoadExpression_Internal_Void_String_0;

		// Token: 0x04000752 RID: 1874
		private static readonly IntPtr NativeMethodInfoPtr_StartScan_Internal_Void_0;

		// Token: 0x04000753 RID: 1875
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_ExpressionNode_0;

		// Token: 0x04000754 RID: 1876
		private static readonly IntPtr NativeMethodInfoPtr_ParseAggregateArgument_Private_ExpressionNode_FunctionId_0;

		// Token: 0x04000755 RID: 1877
		private static readonly IntPtr NativeMethodInfoPtr_NodePop_Private_ExpressionNode_0;

		// Token: 0x04000756 RID: 1878
		private static readonly IntPtr NativeMethodInfoPtr_NodePeek_Private_ExpressionNode_0;

		// Token: 0x04000757 RID: 1879
		private static readonly IntPtr NativeMethodInfoPtr_NodePush_Private_Void_ExpressionNode_0;

		// Token: 0x04000758 RID: 1880
		private static readonly IntPtr NativeMethodInfoPtr_BuildExpression_Private_Void_Int32_0;

		// Token: 0x04000759 RID: 1881
		private static readonly IntPtr NativeMethodInfoPtr_CheckToken_Internal_Void_Tokens_0;

		// Token: 0x0400075A RID: 1882
		private static readonly IntPtr NativeMethodInfoPtr_Scan_Internal_Tokens_0;

		// Token: 0x0400075B RID: 1883
		private static readonly IntPtr NativeMethodInfoPtr_ScanNumeric_Private_Void_0;

		// Token: 0x0400075C RID: 1884
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_Void_0;

		// Token: 0x0400075D RID: 1885
		private static readonly IntPtr NativeMethodInfoPtr_ScanName_Private_Void_Char_Char_String_0;

		// Token: 0x0400075E RID: 1886
		private static readonly IntPtr NativeMethodInfoPtr_ScanDate_Private_Void_0;

		// Token: 0x0400075F RID: 1887
		private static readonly IntPtr NativeMethodInfoPtr_ScanBinaryConstant_Private_Void_0;

		// Token: 0x04000760 RID: 1888
		private static readonly IntPtr NativeMethodInfoPtr_ScanReserved_Private_Void_0;

		// Token: 0x04000761 RID: 1889
		private static readonly IntPtr NativeMethodInfoPtr_ScanString_Private_Void_Char_0;

		// Token: 0x04000762 RID: 1890
		private static readonly IntPtr NativeMethodInfoPtr_ScanToken_Internal_Void_Tokens_0;

		// Token: 0x04000763 RID: 1891
		private static readonly IntPtr NativeMethodInfoPtr_ScanWhite_Private_Void_0;

		// Token: 0x04000764 RID: 1892
		private static readonly IntPtr NativeMethodInfoPtr_IsWhiteSpace_Private_Boolean_Char_0;

		// Token: 0x04000765 RID: 1893
		private static readonly IntPtr NativeMethodInfoPtr_IsAlphaNumeric_Private_Boolean_Char_0;

		// Token: 0x04000766 RID: 1894
		private static readonly IntPtr NativeMethodInfoPtr_IsDigit_Private_Boolean_Char_0;

		// Token: 0x04000767 RID: 1895
		private static readonly IntPtr NativeMethodInfoPtr_IsAlpha_Private_Boolean_Char_0;

		// Token: 0x020000E2 RID: 226
		public sealed class ReservedWords : ValueType
		{
			// Token: 0x060014A3 RID: 5283 RVA: 0x00062888 File Offset: 0x00060A88
			// Note: this type is marked as 'beforefieldinit'.
			static ReservedWords()
			{
				Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ExpressionParser>.NativeClassPtr, "ReservedWords");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr);
				ExpressionParser.ReservedWords.NativeFieldInfoPtr__word = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr, "_word");
				ExpressionParser.ReservedWords.NativeFieldInfoPtr__token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr, "_token");
				ExpressionParser.ReservedWords.NativeFieldInfoPtr__op = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr, "_op");
				ExpressionParser.ReservedWords.NativeMethodInfoPtr__ctor_Internal_Void_String_Tokens_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr, 100664767);
			}

			// Token: 0x060014A4 RID: 5284 RVA: 0x00062904 File Offset: 0x00060B04
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 745917, RefRangeEnd = 745928, XrefRangeStart = 745917, XrefRangeEnd = 745928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReservedWords(string word, Tokens token, int op)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(word);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref token;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExpressionParser.ReservedWords.NativeMethodInfoPtr__ctor_Internal_Void_String_Tokens_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060014A5 RID: 5285 RVA: 0x00007C32 File Offset: 0x00005E32
			public ReservedWords(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060014A6 RID: 5286 RVA: 0x00007C3B File Offset: 0x00005E3B
			public ReservedWords()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExpressionParser.ReservedWords>.NativeClassPtr))
			{
			}

			// Token: 0x170004AF RID: 1199
			// (get) Token: 0x060014A7 RID: 5287 RVA: 0x00062970 File Offset: 0x00060B70
			// (set) Token: 0x060014A8 RID: 5288 RVA: 0x00007C4D File Offset: 0x00005E4D
			public unsafe string _word
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__word);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__word), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170004B0 RID: 1200
			// (get) Token: 0x060014A9 RID: 5289 RVA: 0x00062998 File Offset: 0x00060B98
			// (set) Token: 0x060014AA RID: 5290 RVA: 0x00007C6C File Offset: 0x00005E6C
			public unsafe Tokens _token
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__token);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__token)) = value;
				}
			}

			// Token: 0x170004B1 RID: 1201
			// (get) Token: 0x060014AB RID: 5291 RVA: 0x000629C0 File Offset: 0x00060BC0
			// (set) Token: 0x060014AC RID: 5292 RVA: 0x00007C87 File Offset: 0x00005E87
			public unsafe int _op
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__op);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExpressionParser.ReservedWords.NativeFieldInfoPtr__op)) = value;
				}
			}

			// Token: 0x04001143 RID: 4419
			private static readonly IntPtr NativeFieldInfoPtr__word;

			// Token: 0x04001144 RID: 4420
			private static readonly IntPtr NativeFieldInfoPtr__token;

			// Token: 0x04001145 RID: 4421
			private static readonly IntPtr NativeFieldInfoPtr__op;

			// Token: 0x04001146 RID: 4422
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_Tokens_Int32_0;
		}
	}
}
