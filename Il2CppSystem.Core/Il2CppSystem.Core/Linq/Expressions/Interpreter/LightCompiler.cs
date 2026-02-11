using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000CE RID: 206
	public sealed class LightCompiler : Object
	{
		// Token: 0x06000C6E RID: 3182 RVA: 0x00042CC0 File Offset: 0x00040EC0
		// Note: this type is marked as 'beforefieldinit'.
		static LightCompiler()
		{
			Il2CppClassPointerStore<LightCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LightCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr);
			LightCompiler.NativeFieldInfoPtr__instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_instructions");
			LightCompiler.NativeFieldInfoPtr__locals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_locals");
			LightCompiler.NativeFieldInfoPtr__debugInfos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_debugInfos");
			LightCompiler.NativeFieldInfoPtr__treeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_treeLabels");
			LightCompiler.NativeFieldInfoPtr__labelBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_labelBlock");
			LightCompiler.NativeFieldInfoPtr__exceptionForRethrowStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_exceptionForRethrowStack");
			LightCompiler.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_parent");
			LightCompiler.NativeFieldInfoPtr__guard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "_guard");
			LightCompiler.NativeFieldInfoPtr_s_emptyLocals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "s_emptyLocals");
			LightCompiler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665538);
			LightCompiler.NativeMethodInfoPtr__ctor_Private_Void_LightCompiler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665539);
			LightCompiler.NativeMethodInfoPtr_get_Instructions_Public_get_InstructionList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665540);
			LightCompiler.NativeMethodInfoPtr_CompileTop_Public_LightDelegateCreator_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665541);
			LightCompiler.NativeMethodInfoPtr_MakeInterpreter_Private_Interpreter_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665542);
			LightCompiler.NativeMethodInfoPtr_CompileConstantExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665543);
			LightCompiler.NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665544);
			LightCompiler.NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665545);
			LightCompiler.NativeMethodInfoPtr_EnsureAvailableForClosure_Private_LocalVariable_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665546);
			LightCompiler.NativeMethodInfoPtr_ResolveLocal_Private_LocalVariable_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665547);
			LightCompiler.NativeMethodInfoPtr_CompileGetVariable_Private_Void_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665548);
			LightCompiler.NativeMethodInfoPtr_EmitCopyValueType_Private_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665549);
			LightCompiler.NativeMethodInfoPtr_LoadLocalNoValueTypeCopy_Private_Void_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665550);
			LightCompiler.NativeMethodInfoPtr_MaybeMutableValueType_Private_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665551);
			LightCompiler.NativeMethodInfoPtr_CompileGetBoxedVariable_Private_Void_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665552);
			LightCompiler.NativeMethodInfoPtr_CompileSetVariable_Private_Void_ParameterExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665553);
			LightCompiler.NativeMethodInfoPtr_CompileParameterExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665554);
			LightCompiler.NativeMethodInfoPtr_CompileBlockExpression_Private_Void_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665555);
			LightCompiler.NativeMethodInfoPtr_CompileBlockStart_Private_Il2CppReferenceArray_1_LocalDefinition_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665556);
			LightCompiler.NativeMethodInfoPtr_CompileBlockEnd_Private_Void_Il2CppReferenceArray_1_LocalDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665557);
			LightCompiler.NativeMethodInfoPtr_CompileIndexExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665558);
			LightCompiler.NativeMethodInfoPtr_EmitIndexGet_Private_Void_IndexExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665559);
			LightCompiler.NativeMethodInfoPtr_CompileIndexAssignment_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665560);
			LightCompiler.NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665561);
			LightCompiler.NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_Boolean_MemberInfo_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665562);
			LightCompiler.NativeMethodInfoPtr_CompileVariableAssignment_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665563);
			LightCompiler.NativeMethodInfoPtr_CompileAssignBinaryExpression_Private_Void_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665564);
			LightCompiler.NativeMethodInfoPtr_CompileBinaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665565);
			LightCompiler.NativeMethodInfoPtr_CompileEqual_Private_Void_Expression_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665566);
			LightCompiler.NativeMethodInfoPtr_CompileNotEqual_Private_Void_Expression_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665567);
			LightCompiler.NativeMethodInfoPtr_CompileComparison_Private_Void_BinaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665568);
			LightCompiler.NativeMethodInfoPtr_CompileArithmetic_Private_Void_ExpressionType_Expression_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665569);
			LightCompiler.NativeMethodInfoPtr_CompileConvertUnaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665570);
			LightCompiler.NativeMethodInfoPtr_CompileConvertToType_Private_Void_Type_Type_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665571);
			LightCompiler.NativeMethodInfoPtr_CompileNotExpression_Private_Void_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665572);
			LightCompiler.NativeMethodInfoPtr_CompileUnaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665573);
			LightCompiler.NativeMethodInfoPtr_EmitUnaryMethodCall_Private_Void_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665574);
			LightCompiler.NativeMethodInfoPtr_EmitUnaryBoolCheck_Private_Void_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665575);
			LightCompiler.NativeMethodInfoPtr_CompileAndAlsoBinaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665576);
			LightCompiler.NativeMethodInfoPtr_CompileOrElseBinaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665577);
			LightCompiler.NativeMethodInfoPtr_CompileLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665578);
			LightCompiler.NativeMethodInfoPtr_CompileMethodLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665579);
			LightCompiler.NativeMethodInfoPtr_CompileLiftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665580);
			LightCompiler.NativeMethodInfoPtr_CompileUnliftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665581);
			LightCompiler.NativeMethodInfoPtr_CompileConditionalExpression_Private_Void_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665582);
			LightCompiler.NativeMethodInfoPtr_CompileLoopExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665583);
			LightCompiler.NativeMethodInfoPtr_CompileSwitchExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665584);
			LightCompiler.NativeMethodInfoPtr_CompileIntSwitchExpression_Private_Void_SwitchExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665585);
			LightCompiler.NativeMethodInfoPtr_CompileStringSwitchExpression_Private_Void_SwitchExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665586);
			LightCompiler.NativeMethodInfoPtr_CompileLabelExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665587);
			LightCompiler.NativeMethodInfoPtr_CompileGotoExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665588);
			LightCompiler.NativeMethodInfoPtr_PushLabelBlock_Private_Void_LabelScopeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665589);
			LightCompiler.NativeMethodInfoPtr_PopLabelBlock_Private_Void_LabelScopeKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665590);
			LightCompiler.NativeMethodInfoPtr_EnsureLabel_Private_LabelInfo_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665591);
			LightCompiler.NativeMethodInfoPtr_ReferenceLabel_Private_LabelInfo_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665592);
			LightCompiler.NativeMethodInfoPtr_DefineLabel_Private_LabelInfo_LabelTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665593);
			LightCompiler.NativeMethodInfoPtr_TryPushLabelBlock_Private_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665594);
			LightCompiler.NativeMethodInfoPtr_DefineBlockLabels_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665595);
			LightCompiler.NativeMethodInfoPtr_CheckRethrow_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665596);
			LightCompiler.NativeMethodInfoPtr_CompileThrowUnaryExpression_Private_Void_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665597);
			LightCompiler.NativeMethodInfoPtr_CompileTryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665598);
			LightCompiler.NativeMethodInfoPtr_CompileTryFaultExpression_Private_Void_TryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665599);
			LightCompiler.NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665600);
			LightCompiler.NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_MethodInfo_IArgumentProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665601);
			LightCompiler.NativeMethodInfoPtr_CompileArrayIndexAddress_Private_ByRefUpdater_Expression_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665602);
			LightCompiler.NativeMethodInfoPtr_EmitThisForMethodCall_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665603);
			LightCompiler.NativeMethodInfoPtr_ShouldWritebackNode_Private_Static_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665604);
			LightCompiler.NativeMethodInfoPtr_CompileAddress_Private_ByRefUpdater_Expression_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665605);
			LightCompiler.NativeMethodInfoPtr_CompileMultiDimArrayAccess_Private_ByRefUpdater_Expression_IArgumentProvider_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665606);
			LightCompiler.NativeMethodInfoPtr_CompileNewExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665607);
			LightCompiler.NativeMethodInfoPtr_CompileMemberExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665608);
			LightCompiler.NativeMethodInfoPtr_CompileMember_Private_Void_Expression_MemberInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665609);
			LightCompiler.NativeMethodInfoPtr_CompileNewArrayExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665610);
			LightCompiler.NativeMethodInfoPtr_CompileDebugInfoExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665611);
			LightCompiler.NativeMethodInfoPtr_CompileRuntimeVariablesExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665612);
			LightCompiler.NativeMethodInfoPtr_CompileLambdaExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665613);
			LightCompiler.NativeMethodInfoPtr_CompileCoalesceBinaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665614);
			LightCompiler.NativeMethodInfoPtr_CompileInvocationExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665615);
			LightCompiler.NativeMethodInfoPtr_CompileListInitExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665616);
			LightCompiler.NativeMethodInfoPtr_CompileListInit_Private_Void_ReadOnlyCollection_1_ElementInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665617);
			LightCompiler.NativeMethodInfoPtr_CompileMemberInitExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665618);
			LightCompiler.NativeMethodInfoPtr_CompileMemberInit_Private_Void_ReadOnlyCollection_1_MemberBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665619);
			LightCompiler.NativeMethodInfoPtr_GetMemberType_Private_Static_Type_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665620);
			LightCompiler.NativeMethodInfoPtr_CompileQuoteUnaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665621);
			LightCompiler.NativeMethodInfoPtr_CompileUnboxUnaryExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665622);
			LightCompiler.NativeMethodInfoPtr_CompileTypeEqualExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665623);
			LightCompiler.NativeMethodInfoPtr_CompileTypeAsExpression_Private_Void_UnaryExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665624);
			LightCompiler.NativeMethodInfoPtr_CompileTypeIsExpression_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665625);
			LightCompiler.NativeMethodInfoPtr_Compile_Private_Void_Expression_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665626);
			LightCompiler.NativeMethodInfoPtr_CompileAsVoid_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665627);
			LightCompiler.NativeMethodInfoPtr_CompileNoLabelPush_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665628);
			LightCompiler.NativeMethodInfoPtr_Compile_Private_Void_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, 100665629);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x000434D4 File Offset: 0x000416D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1020250, RefRangeEnd = 1020254, XrefRangeStart = 1020200, XrefRangeEnd = 1020250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCompiler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C70 RID: 3184 RVA: 0x00043510 File Offset: 0x00041710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020254, XrefRangeEnd = 1020256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightCompiler(LightCompiler parent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr__ctor_Private_Void_LightCompiler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x0004355C File Offset: 0x0004175C
		public unsafe InstructionList Instructions
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_get_Instructions_Public_get_InstructionList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InstructionList>(intPtr3) : null;
			}
		}

		// Token: 0x06000C72 RID: 3186 RVA: 0x0004359C File Offset: 0x0004179C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1020293, RefRangeEnd = 1020296, XrefRangeStart = 1020256, XrefRangeEnd = 1020293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightDelegateCreator CompileTop(LambdaExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTop_Public_LightDelegateCreator_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LightDelegateCreator>(intPtr3) : null;
			}
		}

		// Token: 0x06000C73 RID: 3187 RVA: 0x000435EC File Offset: 0x000417EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020340, RefRangeEnd = 1020341, XrefRangeStart = 1020296, XrefRangeEnd = 1020340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Interpreter MakeInterpreter(string lambdaName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lambdaName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_MakeInterpreter_Private_Interpreter_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr3) : null;
			}
		}

		// Token: 0x06000C74 RID: 3188 RVA: 0x0004363C File Offset: 0x0004183C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020341, XrefRangeEnd = 1020346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileConstantExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileConstantExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C75 RID: 3189 RVA: 0x00043680 File Offset: 0x00041880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020346, XrefRangeEnd = 1020360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileDefaultExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C76 RID: 3190 RVA: 0x000436C4 File Offset: 0x000418C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020360, XrefRangeEnd = 1020374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileDefaultExpression(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C77 RID: 3191 RVA: 0x00043708 File Offset: 0x00041908
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1020377, RefRangeEnd = 1020386, XrefRangeStart = 1020374, XrefRangeEnd = 1020377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariable EnsureAvailableForClosure(ParameterExpression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EnsureAvailableForClosure_Private_LocalVariable_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalVariable>(intPtr3) : null;
			}
		}

		// Token: 0x06000C78 RID: 3192 RVA: 0x00043758 File Offset: 0x00041958
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020388, RefRangeEnd = 1020389, XrefRangeStart = 1020386, XrefRangeEnd = 1020388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalVariable ResolveLocal(ParameterExpression variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_ResolveLocal_Private_LocalVariable_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalVariable>(intPtr3) : null;
			}
		}

		// Token: 0x06000C79 RID: 3193 RVA: 0x000437A8 File Offset: 0x000419A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1020397, RefRangeEnd = 1020400, XrefRangeStart = 1020389, XrefRangeEnd = 1020397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGetVariable(ParameterExpression variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileGetVariable_Private_Void_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7A RID: 3194 RVA: 0x000437EC File Offset: 0x000419EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020400, XrefRangeEnd = 1020407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCopyValueType(Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EmitCopyValueType_Private_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x00043830 File Offset: 0x00041A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1020421, RefRangeEnd = 1020423, XrefRangeStart = 1020407, XrefRangeEnd = 1020421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadLocalNoValueTypeCopy(ParameterExpression variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_LoadLocalNoValueTypeCopy_Private_Void_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x00043874 File Offset: 0x00041A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020423, XrefRangeEnd = 1020425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MaybeMutableValueType(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_MaybeMutableValueType_Private_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x000438C4 File Offset: 0x00041AC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1020433, RefRangeEnd = 1020435, XrefRangeStart = 1020425, XrefRangeEnd = 1020433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGetBoxedVariable(ParameterExpression variable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileGetBoxedVariable_Private_Void_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x00043908 File Offset: 0x00041B08
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1020449, RefRangeEnd = 1020452, XrefRangeStart = 1020435, XrefRangeEnd = 1020449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSetVariable(ParameterExpression variable, bool isVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variable);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileSetVariable_Private_Void_ParameterExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x00043958 File Offset: 0x00041B58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020452, XrefRangeEnd = 1020456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileParameterExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileParameterExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x0004399C File Offset: 0x00041B9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020473, RefRangeEnd = 1020474, XrefRangeStart = 1020456, XrefRangeEnd = 1020473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileBlockExpression(Expression expr, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileBlockExpression_Private_Void_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x000439EC File Offset: 0x00041BEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020538, RefRangeEnd = 1020539, XrefRangeStart = 1020474, XrefRangeEnd = 1020538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<LocalDefinition> CompileBlockStart(BlockExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileBlockStart_Private_Il2CppReferenceArray_1_LocalDefinition_BlockExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDefinition>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C82 RID: 3202 RVA: 0x00043A3C File Offset: 0x00041C3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020539, XrefRangeEnd = 1020542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileBlockEnd(Il2CppReferenceArray<LocalDefinition> locals)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locals);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileBlockEnd_Private_Void_Il2CppReferenceArray_1_LocalDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C83 RID: 3203 RVA: 0x00043A80 File Offset: 0x00041C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020542, XrefRangeEnd = 1020551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIndexExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileIndexExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00043AC4 File Offset: 0x00041CC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020560, RefRangeEnd = 1020561, XrefRangeStart = 1020551, XrefRangeEnd = 1020560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitIndexGet(IndexExpression index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(index);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EmitIndexGet_Private_Void_IndexExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00043B08 File Offset: 0x00041D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020596, RefRangeEnd = 1020597, XrefRangeStart = 1020561, XrefRangeEnd = 1020596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIndexAssignment(BinaryExpression node, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileIndexAssignment_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00043B58 File Offset: 0x00041D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020597, XrefRangeEnd = 1020602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMemberAssignment(BinaryExpression node, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C87 RID: 3207 RVA: 0x00043BA8 File Offset: 0x00041DA8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1020622, RefRangeEnd = 1020624, XrefRangeStart = 1020602, XrefRangeEnd = 1020622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMemberAssignment(bool asVoid, MemberInfo refMember, Expression value, bool forBinding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref asVoid;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(refMember);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forBinding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_Boolean_MemberInfo_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C88 RID: 3208 RVA: 0x00043C18 File Offset: 0x00041E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020624, XrefRangeEnd = 1020630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileVariableAssignment(BinaryExpression node, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileVariableAssignment_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x00043C68 File Offset: 0x00041E68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020633, RefRangeEnd = 1020634, XrefRangeStart = 1020630, XrefRangeEnd = 1020633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAssignBinaryExpression(Expression expr, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileAssignBinaryExpression_Private_Void_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8A RID: 3210 RVA: 0x00043CB8 File Offset: 0x00041EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020634, XrefRangeEnd = 1020648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileBinaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileBinaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8B RID: 3211 RVA: 0x00043CFC File Offset: 0x00041EFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020648, XrefRangeEnd = 1020653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileEqual(Expression left, Expression right, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileEqual_Private_Void_Expression_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8C RID: 3212 RVA: 0x00043D60 File Offset: 0x00041F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020653, XrefRangeEnd = 1020658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileNotEqual(Expression left, Expression right, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(left);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileNotEqual_Private_Void_Expression_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00043DC4 File Offset: 0x00041FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020658, XrefRangeEnd = 1020676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileComparison(BinaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileComparison_Private_Void_BinaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00043E08 File Offset: 0x00042008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020676, XrefRangeEnd = 1020698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileArithmetic(ExpressionType nodeType, Expression left, Expression right)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nodeType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileArithmetic_Private_Void_ExpressionType_Expression_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00043E6C File Offset: 0x0004206C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020698, XrefRangeEnd = 1020716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileConvertUnaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileConvertUnaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00043EB0 File Offset: 0x000420B0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1020739, RefRangeEnd = 1020742, XrefRangeStart = 1020716, XrefRangeEnd = 1020739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileConvertToType(Type typeFrom, Type typeTo, bool isChecked, bool isLiftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(typeFrom);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(typeTo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isChecked;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileConvertToType_Private_Void_Type_Type_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00043F20 File Offset: 0x00042120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020742, XrefRangeEnd = 1020746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileNotExpression(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileNotExpression_Private_Void_UnaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00043F64 File Offset: 0x00042164
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020746, XrefRangeEnd = 1020754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileUnaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileUnaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00043FA8 File Offset: 0x000421A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020754, XrefRangeEnd = 1020757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitUnaryMethodCall(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EmitUnaryMethodCall_Private_Void_UnaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00043FEC File Offset: 0x000421EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020768, RefRangeEnd = 1020769, XrefRangeStart = 1020757, XrefRangeEnd = 1020768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitUnaryBoolCheck(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EmitUnaryBoolCheck_Private_Void_UnaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00044030 File Offset: 0x00042230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020769, XrefRangeEnd = 1020773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAndAlsoBinaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileAndAlsoBinaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00044074 File Offset: 0x00042274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020773, XrefRangeEnd = 1020777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileOrElseBinaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileOrElseBinaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x000440B8 File Offset: 0x000422B8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1020783, RefRangeEnd = 1020786, XrefRangeStart = 1020777, XrefRangeEnd = 1020783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLogicalBinaryExpression(BinaryExpression b, bool andAlso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(b);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andAlso;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00044108 File Offset: 0x00042308
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1020809, RefRangeEnd = 1020810, XrefRangeStart = 1020786, XrefRangeEnd = 1020809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMethodLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andAlso;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMethodLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00044158 File Offset: 0x00042358
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020810, XrefRangeEnd = 1020917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLiftedLogicalBinaryExpression(BinaryExpression node, bool andAlso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andAlso;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileLiftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x000441A8 File Offset: 0x000423A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020917, XrefRangeEnd = 1020929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileUnliftedLogicalBinaryExpression(BinaryExpression expr, bool andAlso)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref andAlso;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileUnliftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000441F8 File Offset: 0x000423F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020929, XrefRangeEnd = 1020963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileConditionalExpression(Expression expr, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileConditionalExpression_Private_Void_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00044248 File Offset: 0x00042448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020963, XrefRangeEnd = 1021003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLoopExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileLoopExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x0004428C File Offset: 0x0004248C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021003, XrefRangeEnd = 1021044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileSwitchExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileSwitchExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x000442D0 File Offset: 0x000424D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1021098, RefRangeEnd = 1021099, XrefRangeStart = 1021044, XrefRangeEnd = 1021098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileIntSwitchExpression<T>(SwitchExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.MethodInfoStoreGeneric_CompileIntSwitchExpression_Private_Void_SwitchExpression_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00044314 File Offset: 0x00042514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021099, XrefRangeEnd = 1021181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileStringSwitchExpression(SwitchExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileStringSwitchExpression_Private_Void_SwitchExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00044358 File Offset: 0x00042558
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021181, XrefRangeEnd = 1021214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLabelExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileLabelExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0004439C File Offset: 0x0004259C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021214, XrefRangeEnd = 1021253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileGotoExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileGotoExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000443E0 File Offset: 0x000425E0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1021259, RefRangeEnd = 1021268, XrefRangeStart = 1021253, XrefRangeEnd = 1021259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushLabelBlock(LabelScopeKind type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_PushLabelBlock_Private_Void_LabelScopeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00044420 File Offset: 0x00042620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021268, XrefRangeEnd = 1021270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PopLabelBlock(LabelScopeKind kind)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref kind;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_PopLabelBlock_Private_Void_LabelScopeKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00044460 File Offset: 0x00042660
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1021280, RefRangeEnd = 1021286, XrefRangeStart = 1021270, XrefRangeEnd = 1021280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelInfo EnsureLabel(LabelTarget node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EnsureLabel_Private_LabelInfo_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x000444B0 File Offset: 0x000426B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021286, XrefRangeEnd = 1021293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelInfo ReferenceLabel(LabelTarget node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_ReferenceLabel_Private_LabelInfo_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x00044500 File Offset: 0x00042700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1021296, RefRangeEnd = 1021298, XrefRangeStart = 1021293, XrefRangeEnd = 1021296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabelInfo DefineLabel(LabelTarget node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_DefineLabel_Private_LabelInfo_LabelTarget_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LabelInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x00044550 File Offset: 0x00042750
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1021308, RefRangeEnd = 1021311, XrefRangeStart = 1021298, XrefRangeEnd = 1021308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryPushLabelBlock(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_TryPushLabelBlock_Private_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000445A0 File Offset: 0x000427A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1021325, RefRangeEnd = 1021326, XrefRangeStart = 1021311, XrefRangeEnd = 1021325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefineBlockLabels(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_DefineBlockLabels_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x000445E4 File Offset: 0x000427E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021326, XrefRangeEnd = 1021327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckRethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CheckRethrow_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00044618 File Offset: 0x00042818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1021363, RefRangeEnd = 1021364, XrefRangeStart = 1021327, XrefRangeEnd = 1021363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileThrowUnaryExpression(Expression expr, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileThrowUnaryExpression_Private_Void_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x00044668 File Offset: 0x00042868
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021364, XrefRangeEnd = 1021504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000446AC File Offset: 0x000428AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021504, XrefRangeEnd = 1021555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTryFaultExpression(TryExpression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTryFaultExpression_Private_Void_TryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000446F0 File Offset: 0x000428F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021555, XrefRangeEnd = 1021559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMethodCallExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00044734 File Offset: 0x00042934
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1021602, RefRangeEnd = 1021605, XrefRangeStart = 1021559, XrefRangeEnd = 1021602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMethodCallExpression(Expression @object, MethodInfo method, IArgumentProvider arguments)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_MethodInfo_IArgumentProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x0004479C File Offset: 0x0004299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021605, XrefRangeEnd = 1021633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefUpdater CompileArrayIndexAddress(Expression array, Expression index, int argumentIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(index);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileArrayIndexAddress_Private_ByRefUpdater_Expression_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByRefUpdater>(intPtr3) : null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x0004480C File Offset: 0x00042A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021633, XrefRangeEnd = 1021634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitThisForMethodCall(Expression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_EmitThisForMethodCall_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x00044850 File Offset: 0x00042A50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1021640, RefRangeEnd = 1021641, XrefRangeStart = 1021634, XrefRangeEnd = 1021640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ShouldWritebackNode(Expression node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_ShouldWritebackNode_Private_Static_Boolean_Expression_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00044894 File Offset: 0x00042A94
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1021701, RefRangeEnd = 1021713, XrefRangeStart = 1021641, XrefRangeEnd = 1021701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefUpdater CompileAddress(Expression node, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileAddress_Private_ByRefUpdater_Expression_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByRefUpdater>(intPtr3) : null;
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000448F4 File Offset: 0x00042AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021713, XrefRangeEnd = 1021766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByRefUpdater CompileMultiDimArrayAccess(Expression array, IArgumentProvider arguments, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMultiDimArrayAccess_Private_ByRefUpdater_Expression_IArgumentProvider_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ByRefUpdater>(intPtr3) : null;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00044964 File Offset: 0x00042B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021766, XrefRangeEnd = 1021806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileNewExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileNewExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000449A8 File Offset: 0x00042BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021806, XrefRangeEnd = 1021810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMemberExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMemberExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000449EC File Offset: 0x00042BEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1021830, RefRangeEnd = 1021833, XrefRangeStart = 1021810, XrefRangeEnd = 1021830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMember(Expression from, MemberInfo member, bool forBinding)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref forBinding;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMember_Private_Void_Expression_MemberInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00044A50 File Offset: 0x00042C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021833, XrefRangeEnd = 1021861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileNewArrayExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileNewArrayExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x00044A94 File Offset: 0x00042C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021861, XrefRangeEnd = 1021872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileDebugInfoExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileDebugInfoExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x00044AD8 File Offset: 0x00042CD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021872, XrefRangeEnd = 1021901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileRuntimeVariablesExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileRuntimeVariablesExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x00044B1C File Offset: 0x00042D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021901, XrefRangeEnd = 1021933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileLambdaExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileLambdaExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00044B60 File Offset: 0x00042D60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1021933, XrefRangeEnd = 1022003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileCoalesceBinaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileCoalesceBinaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x00044BA4 File Offset: 0x00042DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022003, XrefRangeEnd = 1022019, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileInvocationExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileInvocationExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x00044BE8 File Offset: 0x00042DE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022019, XrefRangeEnd = 1022025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileListInitExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileListInitExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBE RID: 3262 RVA: 0x00044C2C File Offset: 0x00042E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022063, RefRangeEnd = 1022065, XrefRangeStart = 1022025, XrefRangeEnd = 1022063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileListInit(ReadOnlyCollection<ElementInit> initializers)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(initializers);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileListInit_Private_Void_ReadOnlyCollection_1_ElementInit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CBF RID: 3263 RVA: 0x00044C70 File Offset: 0x00042E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022065, XrefRangeEnd = 1022071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMemberInitExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMemberInitExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC0 RID: 3264 RVA: 0x00044CB4 File Offset: 0x00042EB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022113, RefRangeEnd = 1022115, XrefRangeStart = 1022071, XrefRangeEnd = 1022113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileMemberInit(ReadOnlyCollection<MemberBinding> bindings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bindings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileMemberInit_Private_Void_ReadOnlyCollection_1_MemberBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x00044CF8 File Offset: 0x00042EF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1022131, RefRangeEnd = 1022132, XrefRangeStart = 1022115, XrefRangeEnd = 1022131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetMemberType(MemberInfo member)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_GetMemberType_Private_Static_Type_MemberInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00044D3C File Offset: 0x00042F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022132, XrefRangeEnd = 1022173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileQuoteUnaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileQuoteUnaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00044D80 File Offset: 0x00042F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022173, XrefRangeEnd = 1022186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileUnboxUnaryExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileUnboxUnaryExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00044DC4 File Offset: 0x00042FC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022186, XrefRangeEnd = 1022208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTypeEqualExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTypeEqualExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC5 RID: 3269 RVA: 0x00044E08 File Offset: 0x00043008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022208, XrefRangeEnd = 1022215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTypeAsExpression(UnaryExpression node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTypeAsExpression_Private_Void_UnaryExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x00044E4C File Offset: 0x0004304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1022215, XrefRangeEnd = 1022251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileTypeIsExpression(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileTypeIsExpression_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x00044E90 File Offset: 0x00043090
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022253, RefRangeEnd = 1022255, XrefRangeStart = 1022251, XrefRangeEnd = 1022253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile(Expression expr, bool asVoid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref asVoid;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_Compile_Private_Void_Expression_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x00044EE0 File Offset: 0x000430E0
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1022272, RefRangeEnd = 1022287, XrefRangeStart = 1022255, XrefRangeEnd = 1022272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileAsVoid(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileAsVoid_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CC9 RID: 3273 RVA: 0x00044F24 File Offset: 0x00043124
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1022297, RefRangeEnd = 1022301, XrefRangeStart = 1022287, XrefRangeEnd = 1022297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CompileNoLabelPush(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_CompileNoLabelPush_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00044F68 File Offset: 0x00043168
		[CallerCount(56)]
		[CachedScanResults(RefRangeStart = 1022304, RefRangeEnd = 1022360, XrefRangeStart = 1022301, XrefRangeEnd = 1022304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Compile(Expression expr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.NativeMethodInfoPtr_Compile_Private_Void_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00005D57 File Offset: 0x00003F57
		public LightCompiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00044FAC File Offset: 0x000431AC
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00005D60 File Offset: 0x00003F60
		public unsafe InstructionList _instructions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__instructions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InstructionList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__instructions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00044FDC File Offset: 0x000431DC
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00005D7F File Offset: 0x00003F7F
		public unsafe LocalVariables _locals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__locals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__locals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x0004500C File Offset: 0x0004320C
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00005D9E File Offset: 0x00003F9E
		public unsafe List<DebugInfo> _debugInfos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__debugInfos);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DebugInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__debugInfos), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x0004503C File Offset: 0x0004323C
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00005DBD File Offset: 0x00003FBD
		public unsafe HybridReferenceDictionary<LabelTarget, LabelInfo> _treeLabels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__treeLabels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HybridReferenceDictionary<LabelTarget, LabelInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__treeLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x0004506C File Offset: 0x0004326C
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00005DDC File Offset: 0x00003FDC
		public unsafe LabelScopeInfo _labelBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__labelBlock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LabelScopeInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__labelBlock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x0004509C File Offset: 0x0004329C
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00005DFB File Offset: 0x00003FFB
		public unsafe Stack<ParameterExpression> _exceptionForRethrowStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__exceptionForRethrowStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<ParameterExpression>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__exceptionForRethrowStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x000450CC File Offset: 0x000432CC
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00005E1A File Offset: 0x0000401A
		public unsafe LightCompiler _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCompiler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x000450FC File Offset: 0x000432FC
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00005E39 File Offset: 0x00004039
		public unsafe StackGuard _guard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__guard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StackGuard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.NativeFieldInfoPtr__guard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x0004512C File Offset: 0x0004332C
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00005E58 File Offset: 0x00004058
		public unsafe static Il2CppReferenceArray<LocalDefinition> s_emptyLocals
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LightCompiler.NativeFieldInfoPtr_s_emptyLocals, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LocalDefinition>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightCompiler.NativeFieldInfoPtr_s_emptyLocals, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400091B RID: 2331
		private static readonly IntPtr NativeFieldInfoPtr__instructions;

		// Token: 0x0400091C RID: 2332
		private static readonly IntPtr NativeFieldInfoPtr__locals;

		// Token: 0x0400091D RID: 2333
		private static readonly IntPtr NativeFieldInfoPtr__debugInfos;

		// Token: 0x0400091E RID: 2334
		private static readonly IntPtr NativeFieldInfoPtr__treeLabels;

		// Token: 0x0400091F RID: 2335
		private static readonly IntPtr NativeFieldInfoPtr__labelBlock;

		// Token: 0x04000920 RID: 2336
		private static readonly IntPtr NativeFieldInfoPtr__exceptionForRethrowStack;

		// Token: 0x04000921 RID: 2337
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000922 RID: 2338
		private static readonly IntPtr NativeFieldInfoPtr__guard;

		// Token: 0x04000923 RID: 2339
		private static readonly IntPtr NativeFieldInfoPtr_s_emptyLocals;

		// Token: 0x04000924 RID: 2340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000925 RID: 2341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_LightCompiler_0;

		// Token: 0x04000926 RID: 2342
		private static readonly IntPtr NativeMethodInfoPtr_get_Instructions_Public_get_InstructionList_0;

		// Token: 0x04000927 RID: 2343
		private static readonly IntPtr NativeMethodInfoPtr_CompileTop_Public_LightDelegateCreator_LambdaExpression_0;

		// Token: 0x04000928 RID: 2344
		private static readonly IntPtr NativeMethodInfoPtr_MakeInterpreter_Private_Interpreter_String_0;

		// Token: 0x04000929 RID: 2345
		private static readonly IntPtr NativeMethodInfoPtr_CompileConstantExpression_Private_Void_Expression_0;

		// Token: 0x0400092A RID: 2346
		private static readonly IntPtr NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Expression_0;

		// Token: 0x0400092B RID: 2347
		private static readonly IntPtr NativeMethodInfoPtr_CompileDefaultExpression_Private_Void_Type_0;

		// Token: 0x0400092C RID: 2348
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAvailableForClosure_Private_LocalVariable_ParameterExpression_0;

		// Token: 0x0400092D RID: 2349
		private static readonly IntPtr NativeMethodInfoPtr_ResolveLocal_Private_LocalVariable_ParameterExpression_0;

		// Token: 0x0400092E RID: 2350
		private static readonly IntPtr NativeMethodInfoPtr_CompileGetVariable_Private_Void_ParameterExpression_0;

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeMethodInfoPtr_EmitCopyValueType_Private_Void_Type_0;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_LoadLocalNoValueTypeCopy_Private_Void_ParameterExpression_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_MaybeMutableValueType_Private_Boolean_Type_0;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_CompileGetBoxedVariable_Private_Void_ParameterExpression_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_CompileSetVariable_Private_Void_ParameterExpression_Boolean_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr_CompileParameterExpression_Private_Void_Expression_0;

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_CompileBlockExpression_Private_Void_Expression_Boolean_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr_CompileBlockStart_Private_Il2CppReferenceArray_1_LocalDefinition_BlockExpression_0;

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_CompileBlockEnd_Private_Void_Il2CppReferenceArray_1_LocalDefinition_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr_CompileIndexExpression_Private_Void_Expression_0;

		// Token: 0x04000939 RID: 2361
		private static readonly IntPtr NativeMethodInfoPtr_EmitIndexGet_Private_Void_IndexExpression_0;

		// Token: 0x0400093A RID: 2362
		private static readonly IntPtr NativeMethodInfoPtr_CompileIndexAssignment_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400093B RID: 2363
		private static readonly IntPtr NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400093C RID: 2364
		private static readonly IntPtr NativeMethodInfoPtr_CompileMemberAssignment_Private_Void_Boolean_MemberInfo_Expression_Boolean_0;

		// Token: 0x0400093D RID: 2365
		private static readonly IntPtr NativeMethodInfoPtr_CompileVariableAssignment_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400093E RID: 2366
		private static readonly IntPtr NativeMethodInfoPtr_CompileAssignBinaryExpression_Private_Void_Expression_Boolean_0;

		// Token: 0x0400093F RID: 2367
		private static readonly IntPtr NativeMethodInfoPtr_CompileBinaryExpression_Private_Void_Expression_0;

		// Token: 0x04000940 RID: 2368
		private static readonly IntPtr NativeMethodInfoPtr_CompileEqual_Private_Void_Expression_Expression_Boolean_0;

		// Token: 0x04000941 RID: 2369
		private static readonly IntPtr NativeMethodInfoPtr_CompileNotEqual_Private_Void_Expression_Expression_Boolean_0;

		// Token: 0x04000942 RID: 2370
		private static readonly IntPtr NativeMethodInfoPtr_CompileComparison_Private_Void_BinaryExpression_0;

		// Token: 0x04000943 RID: 2371
		private static readonly IntPtr NativeMethodInfoPtr_CompileArithmetic_Private_Void_ExpressionType_Expression_Expression_0;

		// Token: 0x04000944 RID: 2372
		private static readonly IntPtr NativeMethodInfoPtr_CompileConvertUnaryExpression_Private_Void_Expression_0;

		// Token: 0x04000945 RID: 2373
		private static readonly IntPtr NativeMethodInfoPtr_CompileConvertToType_Private_Void_Type_Type_Boolean_Boolean_0;

		// Token: 0x04000946 RID: 2374
		private static readonly IntPtr NativeMethodInfoPtr_CompileNotExpression_Private_Void_UnaryExpression_0;

		// Token: 0x04000947 RID: 2375
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnaryExpression_Private_Void_Expression_0;

		// Token: 0x04000948 RID: 2376
		private static readonly IntPtr NativeMethodInfoPtr_EmitUnaryMethodCall_Private_Void_UnaryExpression_0;

		// Token: 0x04000949 RID: 2377
		private static readonly IntPtr NativeMethodInfoPtr_EmitUnaryBoolCheck_Private_Void_UnaryExpression_0;

		// Token: 0x0400094A RID: 2378
		private static readonly IntPtr NativeMethodInfoPtr_CompileAndAlsoBinaryExpression_Private_Void_Expression_0;

		// Token: 0x0400094B RID: 2379
		private static readonly IntPtr NativeMethodInfoPtr_CompileOrElseBinaryExpression_Private_Void_Expression_0;

		// Token: 0x0400094C RID: 2380
		private static readonly IntPtr NativeMethodInfoPtr_CompileLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400094D RID: 2381
		private static readonly IntPtr NativeMethodInfoPtr_CompileMethodLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400094E RID: 2382
		private static readonly IntPtr NativeMethodInfoPtr_CompileLiftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnliftedLogicalBinaryExpression_Private_Void_BinaryExpression_Boolean_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_CompileConditionalExpression_Private_Void_Expression_Boolean_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr_CompileLoopExpression_Private_Void_Expression_0;

		// Token: 0x04000952 RID: 2386
		private static readonly IntPtr NativeMethodInfoPtr_CompileSwitchExpression_Private_Void_Expression_0;

		// Token: 0x04000953 RID: 2387
		private static readonly IntPtr NativeMethodInfoPtr_CompileIntSwitchExpression_Private_Void_SwitchExpression_0;

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr_CompileStringSwitchExpression_Private_Void_SwitchExpression_0;

		// Token: 0x04000955 RID: 2389
		private static readonly IntPtr NativeMethodInfoPtr_CompileLabelExpression_Private_Void_Expression_0;

		// Token: 0x04000956 RID: 2390
		private static readonly IntPtr NativeMethodInfoPtr_CompileGotoExpression_Private_Void_Expression_0;

		// Token: 0x04000957 RID: 2391
		private static readonly IntPtr NativeMethodInfoPtr_PushLabelBlock_Private_Void_LabelScopeKind_0;

		// Token: 0x04000958 RID: 2392
		private static readonly IntPtr NativeMethodInfoPtr_PopLabelBlock_Private_Void_LabelScopeKind_0;

		// Token: 0x04000959 RID: 2393
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLabel_Private_LabelInfo_LabelTarget_0;

		// Token: 0x0400095A RID: 2394
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceLabel_Private_LabelInfo_LabelTarget_0;

		// Token: 0x0400095B RID: 2395
		private static readonly IntPtr NativeMethodInfoPtr_DefineLabel_Private_LabelInfo_LabelTarget_0;

		// Token: 0x0400095C RID: 2396
		private static readonly IntPtr NativeMethodInfoPtr_TryPushLabelBlock_Private_Boolean_Expression_0;

		// Token: 0x0400095D RID: 2397
		private static readonly IntPtr NativeMethodInfoPtr_DefineBlockLabels_Private_Void_Expression_0;

		// Token: 0x0400095E RID: 2398
		private static readonly IntPtr NativeMethodInfoPtr_CheckRethrow_Private_Void_0;

		// Token: 0x0400095F RID: 2399
		private static readonly IntPtr NativeMethodInfoPtr_CompileThrowUnaryExpression_Private_Void_Expression_Boolean_0;

		// Token: 0x04000960 RID: 2400
		private static readonly IntPtr NativeMethodInfoPtr_CompileTryExpression_Private_Void_Expression_0;

		// Token: 0x04000961 RID: 2401
		private static readonly IntPtr NativeMethodInfoPtr_CompileTryFaultExpression_Private_Void_TryExpression_0;

		// Token: 0x04000962 RID: 2402
		private static readonly IntPtr NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_0;

		// Token: 0x04000963 RID: 2403
		private static readonly IntPtr NativeMethodInfoPtr_CompileMethodCallExpression_Private_Void_Expression_MethodInfo_IArgumentProvider_0;

		// Token: 0x04000964 RID: 2404
		private static readonly IntPtr NativeMethodInfoPtr_CompileArrayIndexAddress_Private_ByRefUpdater_Expression_Expression_Int32_0;

		// Token: 0x04000965 RID: 2405
		private static readonly IntPtr NativeMethodInfoPtr_EmitThisForMethodCall_Private_Void_Expression_0;

		// Token: 0x04000966 RID: 2406
		private static readonly IntPtr NativeMethodInfoPtr_ShouldWritebackNode_Private_Static_Boolean_Expression_0;

		// Token: 0x04000967 RID: 2407
		private static readonly IntPtr NativeMethodInfoPtr_CompileAddress_Private_ByRefUpdater_Expression_Int32_0;

		// Token: 0x04000968 RID: 2408
		private static readonly IntPtr NativeMethodInfoPtr_CompileMultiDimArrayAccess_Private_ByRefUpdater_Expression_IArgumentProvider_Int32_0;

		// Token: 0x04000969 RID: 2409
		private static readonly IntPtr NativeMethodInfoPtr_CompileNewExpression_Private_Void_Expression_0;

		// Token: 0x0400096A RID: 2410
		private static readonly IntPtr NativeMethodInfoPtr_CompileMemberExpression_Private_Void_Expression_0;

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_CompileMember_Private_Void_Expression_MemberInfo_Boolean_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_CompileNewArrayExpression_Private_Void_Expression_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr_CompileDebugInfoExpression_Private_Void_Expression_0;

		// Token: 0x0400096E RID: 2414
		private static readonly IntPtr NativeMethodInfoPtr_CompileRuntimeVariablesExpression_Private_Void_Expression_0;

		// Token: 0x0400096F RID: 2415
		private static readonly IntPtr NativeMethodInfoPtr_CompileLambdaExpression_Private_Void_Expression_0;

		// Token: 0x04000970 RID: 2416
		private static readonly IntPtr NativeMethodInfoPtr_CompileCoalesceBinaryExpression_Private_Void_Expression_0;

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeMethodInfoPtr_CompileInvocationExpression_Private_Void_Expression_0;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeMethodInfoPtr_CompileListInitExpression_Private_Void_Expression_0;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr_CompileListInit_Private_Void_ReadOnlyCollection_1_ElementInit_0;

		// Token: 0x04000974 RID: 2420
		private static readonly IntPtr NativeMethodInfoPtr_CompileMemberInitExpression_Private_Void_Expression_0;

		// Token: 0x04000975 RID: 2421
		private static readonly IntPtr NativeMethodInfoPtr_CompileMemberInit_Private_Void_ReadOnlyCollection_1_MemberBinding_0;

		// Token: 0x04000976 RID: 2422
		private static readonly IntPtr NativeMethodInfoPtr_GetMemberType_Private_Static_Type_MemberInfo_0;

		// Token: 0x04000977 RID: 2423
		private static readonly IntPtr NativeMethodInfoPtr_CompileQuoteUnaryExpression_Private_Void_Expression_0;

		// Token: 0x04000978 RID: 2424
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnboxUnaryExpression_Private_Void_Expression_0;

		// Token: 0x04000979 RID: 2425
		private static readonly IntPtr NativeMethodInfoPtr_CompileTypeEqualExpression_Private_Void_Expression_0;

		// Token: 0x0400097A RID: 2426
		private static readonly IntPtr NativeMethodInfoPtr_CompileTypeAsExpression_Private_Void_UnaryExpression_0;

		// Token: 0x0400097B RID: 2427
		private static readonly IntPtr NativeMethodInfoPtr_CompileTypeIsExpression_Private_Void_Expression_0;

		// Token: 0x0400097C RID: 2428
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Void_Expression_Boolean_0;

		// Token: 0x0400097D RID: 2429
		private static readonly IntPtr NativeMethodInfoPtr_CompileAsVoid_Private_Void_Expression_0;

		// Token: 0x0400097E RID: 2430
		private static readonly IntPtr NativeMethodInfoPtr_CompileNoLabelPush_Private_Void_Expression_0;

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Void_Expression_0;

		// Token: 0x02000273 RID: 627
		public sealed class QuoteVisitor : ExpressionVisitor
		{
			// Token: 0x060018AC RID: 6316 RVA: 0x00075EE0 File Offset: 0x000740E0
			// Note: this type is marked as 'beforefieldinit'.
			static QuoteVisitor()
			{
				Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "QuoteVisitor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr);
				LightCompiler.QuoteVisitor.NativeFieldInfoPtr__definedParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, "_definedParameters");
				LightCompiler.QuoteVisitor.NativeFieldInfoPtr__hoistedParameters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, "_hoistedParameters");
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665631);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665632);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665633);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665634);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_PushParameters_Private_Void_IEnumerable_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665635);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr_PopParameters_Private_Void_IEnumerable_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665636);
				LightCompiler.QuoteVisitor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr, 100665637);
			}

			// Token: 0x060018AD RID: 6317 RVA: 0x00075FC0 File Offset: 0x000741C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020063, XrefRangeEnd = 1020069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitParameter(ParameterExpression node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x060018AE RID: 6318 RVA: 0x00076010 File Offset: 0x00074210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020069, XrefRangeEnd = 1020074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitBlock(BlockExpression node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x060018AF RID: 6319 RVA: 0x00076060 File Offset: 0x00074260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020074, XrefRangeEnd = 1020085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override CatchBlock VisitCatchBlock(CatchBlock node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<CatchBlock>(intPtr3) : null;
				}
			}

			// Token: 0x060018B0 RID: 6320 RVA: 0x000760B0 File Offset: 0x000742B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020085, XrefRangeEnd = 1020103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Expression VisitLambda<T>(Expression<T> node)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x060018B1 RID: 6321 RVA: 0x00076100 File Offset: 0x00074300
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1020129, RefRangeEnd = 1020132, XrefRangeStart = 1020103, XrefRangeEnd = 1020129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PushParameters(IEnumerable<ParameterExpression> parameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_PushParameters_Private_Void_IEnumerable_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018B2 RID: 6322 RVA: 0x00076144 File Offset: 0x00074344
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1020159, RefRangeEnd = 1020162, XrefRangeStart = 1020132, XrefRangeEnd = 1020159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void PopParameters(IEnumerable<ParameterExpression> parameters)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_PopParameters_Private_Void_IEnumerable_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018B3 RID: 6323 RVA: 0x00076188 File Offset: 0x00074388
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1020177, RefRangeEnd = 1020178, XrefRangeStart = 1020162, XrefRangeEnd = 1020177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe QuoteVisitor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.QuoteVisitor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018B4 RID: 6324 RVA: 0x00009E61 File Offset: 0x00008061
			public QuoteVisitor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x060018B5 RID: 6325 RVA: 0x000761C4 File Offset: 0x000743C4
			// (set) Token: 0x060018B6 RID: 6326 RVA: 0x00009E6A File Offset: 0x0000806A
			public unsafe Dictionary<ParameterExpression, int> _definedParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.QuoteVisitor.NativeFieldInfoPtr__definedParameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<ParameterExpression, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.QuoteVisitor.NativeFieldInfoPtr__definedParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x060018B7 RID: 6327 RVA: 0x000761F4 File Offset: 0x000743F4
			// (set) Token: 0x060018B8 RID: 6328 RVA: 0x00009E89 File Offset: 0x00008089
			public unsafe HashSet<ParameterExpression> _hoistedParameters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.QuoteVisitor.NativeFieldInfoPtr__hoistedParameters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<ParameterExpression>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightCompiler.QuoteVisitor.NativeFieldInfoPtr__hoistedParameters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010EB RID: 4331
			private static readonly IntPtr NativeFieldInfoPtr__definedParameters;

			// Token: 0x040010EC RID: 4332
			private static readonly IntPtr NativeFieldInfoPtr__hoistedParameters;

			// Token: 0x040010ED RID: 4333
			private static readonly IntPtr NativeMethodInfoPtr_VisitParameter_FamOrAssem_Virtual_Expression_ParameterExpression_0;

			// Token: 0x040010EE RID: 4334
			private static readonly IntPtr NativeMethodInfoPtr_VisitBlock_FamOrAssem_Virtual_Expression_BlockExpression_0;

			// Token: 0x040010EF RID: 4335
			private static readonly IntPtr NativeMethodInfoPtr_VisitCatchBlock_Protected_Virtual_CatchBlock_CatchBlock_0;

			// Token: 0x040010F0 RID: 4336
			private static readonly IntPtr NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0;

			// Token: 0x040010F1 RID: 4337
			private static readonly IntPtr NativeMethodInfoPtr_PushParameters_Private_Void_IEnumerable_1_ParameterExpression_0;

			// Token: 0x040010F2 RID: 4338
			private static readonly IntPtr NativeMethodInfoPtr_PopParameters_Private_Void_IEnumerable_1_ParameterExpression_0;

			// Token: 0x040010F3 RID: 4339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000368 RID: 872
			private sealed class MethodInfoStoreGeneric_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0<T>
			{
				// Token: 0x04001332 RID: 4914
				internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCompiler.QuoteVisitor.NativeMethodInfoPtr_VisitLambda_FamOrAssem_Virtual_Expression_Expression_1_T_0, Il2CppClassPointerStore<LightCompiler.QuoteVisitor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
			}
		}

		// Token: 0x02000274 RID: 628
		[ObfuscatedName("System.Linq.Expressions.Interpreter.LightCompiler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060018B9 RID: 6329 RVA: 0x00076224 File Offset: 0x00074424
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LightCompiler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr);
				LightCompiler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, "<>9");
				LightCompiler.__c.NativeFieldInfoPtr___9__56_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, "<>9__56_1");
				LightCompiler.__c.NativeFieldInfoPtr___9__56_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, "<>9__56_0");
				LightCompiler.__c.NativeFieldInfoPtr___9__101_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, "<>9__101_0");
				LightCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, 100665639);
				LightCompiler.__c.NativeMethodInfoPtr__CompileSwitchExpression_b__56_0_Internal_Boolean_SwitchCase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, 100665640);
				LightCompiler.__c.NativeMethodInfoPtr__CompileSwitchExpression_b__56_1_Internal_Boolean_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, 100665641);
				LightCompiler.__c.NativeMethodInfoPtr__CompileNoLabelPush_b__101_0_Internal_Void_LightCompiler_Expression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr, 100665642);
			}

			// Token: 0x060018BA RID: 6330 RVA: 0x000762F0 File Offset: 0x000744F0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightCompiler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018BB RID: 6331 RVA: 0x0007632C File Offset: 0x0007452C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020178, XrefRangeEnd = 1020197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompileSwitchExpression_b__56_0(SwitchCase c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.__c.NativeMethodInfoPtr__CompileSwitchExpression_b__56_0_Internal_Boolean_SwitchCase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018BC RID: 6332 RVA: 0x0007637C File Offset: 0x0007457C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020197, XrefRangeEnd = 1020198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CompileSwitchExpression_b__56_1(Expression t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.__c.NativeMethodInfoPtr__CompileSwitchExpression_b__56_1_Internal_Boolean_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060018BD RID: 6333 RVA: 0x000763CC File Offset: 0x000745CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1020198, XrefRangeEnd = 1020200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CompileNoLabelPush_b__101_0(LightCompiler @this, Expression e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@this);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightCompiler.__c.NativeMethodInfoPtr__CompileNoLabelPush_b__101_0_Internal_Void_LightCompiler_Expression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018BE RID: 6334 RVA: 0x00009EA8 File Offset: 0x000080A8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B4 RID: 1716
			// (get) Token: 0x060018BF RID: 6335 RVA: 0x00076420 File Offset: 0x00074620
			// (set) Token: 0x060018C0 RID: 6336 RVA: 0x00009EB1 File Offset: 0x000080B1
			public unsafe static LightCompiler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCompiler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LightCompiler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCompiler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x060018C1 RID: 6337 RVA: 0x00076448 File Offset: 0x00074648
			// (set) Token: 0x060018C2 RID: 6338 RVA: 0x00009EC3 File Offset: 0x000080C3
			public unsafe static Func<Expression, bool> __9__56_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCompiler.__c.NativeFieldInfoPtr___9__56_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Expression, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCompiler.__c.NativeFieldInfoPtr___9__56_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x060018C3 RID: 6339 RVA: 0x00076470 File Offset: 0x00074670
			// (set) Token: 0x060018C4 RID: 6340 RVA: 0x00009ED5 File Offset: 0x000080D5
			public unsafe static Func<SwitchCase, bool> __9__56_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCompiler.__c.NativeFieldInfoPtr___9__56_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SwitchCase, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCompiler.__c.NativeFieldInfoPtr___9__56_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x060018C5 RID: 6341 RVA: 0x00076498 File Offset: 0x00074698
			// (set) Token: 0x060018C6 RID: 6342 RVA: 0x00009EE7 File Offset: 0x000080E7
			public unsafe static Action<LightCompiler, Expression> __9__101_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LightCompiler.__c.NativeFieldInfoPtr___9__101_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LightCompiler, Expression>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LightCompiler.__c.NativeFieldInfoPtr___9__101_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010F4 RID: 4340
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040010F5 RID: 4341
			private static readonly IntPtr NativeFieldInfoPtr___9__56_1;

			// Token: 0x040010F6 RID: 4342
			private static readonly IntPtr NativeFieldInfoPtr___9__56_0;

			// Token: 0x040010F7 RID: 4343
			private static readonly IntPtr NativeFieldInfoPtr___9__101_0;

			// Token: 0x040010F8 RID: 4344
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040010F9 RID: 4345
			private static readonly IntPtr NativeMethodInfoPtr__CompileSwitchExpression_b__56_0_Internal_Boolean_SwitchCase_0;

			// Token: 0x040010FA RID: 4346
			private static readonly IntPtr NativeMethodInfoPtr__CompileSwitchExpression_b__56_1_Internal_Boolean_Expression_0;

			// Token: 0x040010FB RID: 4347
			private static readonly IntPtr NativeMethodInfoPtr__CompileNoLabelPush_b__101_0_Internal_Void_LightCompiler_Expression_0;
		}

		// Token: 0x02000275 RID: 629
		private sealed class MethodInfoStoreGeneric_CompileIntSwitchExpression_Private_Void_SwitchExpression_0<T>
		{
			// Token: 0x040010FC RID: 4348
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(LightCompiler.NativeMethodInfoPtr_CompileIntSwitchExpression_Private_Void_SwitchExpression_0, Il2CppClassPointerStore<LightCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
