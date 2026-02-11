using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BE RID: 190
	public sealed class InstructionList : Object
	{
		// Token: 0x06000A81 RID: 2689 RVA: 0x0003C370 File Offset: 0x0003A570
		// Note: this type is marked as 'beforefieldinit'.
		static InstructionList()
		{
			Il2CppClassPointerStore<InstructionList>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "InstructionList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionList>.NativeClassPtr);
			InstructionList.NativeFieldInfoPtr__instructions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_instructions");
			InstructionList.NativeFieldInfoPtr__objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_objects");
			InstructionList.NativeFieldInfoPtr__currentStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_currentStackDepth");
			InstructionList.NativeFieldInfoPtr__maxStackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_maxStackDepth");
			InstructionList.NativeFieldInfoPtr__currentContinuationsDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_currentContinuationsDepth");
			InstructionList.NativeFieldInfoPtr__maxContinuationDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_maxContinuationDepth");
			InstructionList.NativeFieldInfoPtr__runtimeLabelCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_runtimeLabelCount");
			InstructionList.NativeFieldInfoPtr__labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_labels");
			InstructionList.NativeFieldInfoPtr__debugCookies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "_debugCookies");
			InstructionList.NativeFieldInfoPtr_s_null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_null");
			InstructionList.NativeFieldInfoPtr_s_true = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_true");
			InstructionList.NativeFieldInfoPtr_s_false = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_false");
			InstructionList.NativeFieldInfoPtr_s_Ints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_Ints");
			InstructionList.NativeFieldInfoPtr_s_loadObjectCached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadObjectCached");
			InstructionList.NativeFieldInfoPtr_s_loadLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadLocal");
			InstructionList.NativeFieldInfoPtr_s_loadLocalBoxed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadLocalBoxed");
			InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadLocalFromClosure");
			InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosureBoxed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadLocalFromClosureBoxed");
			InstructionList.NativeFieldInfoPtr_s_assignLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_assignLocal");
			InstructionList.NativeFieldInfoPtr_s_storeLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_storeLocal");
			InstructionList.NativeFieldInfoPtr_s_assignLocalBoxed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_assignLocalBoxed");
			InstructionList.NativeFieldInfoPtr_s_storeLocalBoxed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_storeLocalBoxed");
			InstructionList.NativeFieldInfoPtr_s_assignLocalToClosure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_assignLocalToClosure");
			InstructionList.NativeFieldInfoPtr_s_loadFields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_loadFields");
			InstructionList.NativeFieldInfoPtr_s_emptyRuntimeLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "s_emptyRuntimeLabels");
			InstructionList.NativeMethodInfoPtr_Emit_Public_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665261);
			InstructionList.NativeMethodInfoPtr_UpdateStackDepth_Private_Void_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665262);
			InstructionList.NativeMethodInfoPtr_UnEmit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665263);
			InstructionList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665264);
			InstructionList.NativeMethodInfoPtr_get_CurrentStackDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665265);
			InstructionList.NativeMethodInfoPtr_get_CurrentContinuationsDepth_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665266);
			InstructionList.NativeMethodInfoPtr_GetInstruction_Internal_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665267);
			InstructionList.NativeMethodInfoPtr_ToArray_Public_InstructionArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665268);
			InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665269);
			InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665270);
			InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665271);
			InstructionList.NativeMethodInfoPtr_EmitDup_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665272);
			InstructionList.NativeMethodInfoPtr_EmitPop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665273);
			InstructionList.NativeMethodInfoPtr_SwitchToBoxed_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665274);
			InstructionList.NativeMethodInfoPtr_EmitLoadLocal_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665275);
			InstructionList.NativeMethodInfoPtr_EmitLoadLocalBoxed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665276);
			InstructionList.NativeMethodInfoPtr_LoadLocalBoxed_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665277);
			InstructionList.NativeMethodInfoPtr_EmitLoadLocalFromClosure_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665278);
			InstructionList.NativeMethodInfoPtr_EmitLoadLocalFromClosureBoxed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665279);
			InstructionList.NativeMethodInfoPtr_EmitAssignLocal_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665280);
			InstructionList.NativeMethodInfoPtr_EmitStoreLocal_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665281);
			InstructionList.NativeMethodInfoPtr_EmitAssignLocalBoxed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665282);
			InstructionList.NativeMethodInfoPtr_AssignLocalBoxed_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665283);
			InstructionList.NativeMethodInfoPtr_EmitStoreLocalBoxed_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665284);
			InstructionList.NativeMethodInfoPtr_StoreLocalBoxed_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665285);
			InstructionList.NativeMethodInfoPtr_EmitAssignLocalToClosure_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665286);
			InstructionList.NativeMethodInfoPtr_EmitStoreLocalToClosure_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665287);
			InstructionList.NativeMethodInfoPtr_EmitInitializeLocal_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665288);
			InstructionList.NativeMethodInfoPtr_EmitInitializeParameter_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665289);
			InstructionList.NativeMethodInfoPtr_Parameter_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665290);
			InstructionList.NativeMethodInfoPtr_ParameterBox_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665291);
			InstructionList.NativeMethodInfoPtr_InitReference_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665292);
			InstructionList.NativeMethodInfoPtr_InitImmutableRefBox_Internal_Static_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665293);
			InstructionList.NativeMethodInfoPtr_EmitNewRuntimeVariables_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665294);
			InstructionList.NativeMethodInfoPtr_EmitGetArrayItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665295);
			InstructionList.NativeMethodInfoPtr_EmitSetArrayItem_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665296);
			InstructionList.NativeMethodInfoPtr_EmitNewArray_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665297);
			InstructionList.NativeMethodInfoPtr_EmitNewArrayBounds_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665298);
			InstructionList.NativeMethodInfoPtr_EmitNewArrayInit_Public_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665299);
			InstructionList.NativeMethodInfoPtr_EmitAdd_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665300);
			InstructionList.NativeMethodInfoPtr_EmitSub_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665301);
			InstructionList.NativeMethodInfoPtr_EmitMul_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665302);
			InstructionList.NativeMethodInfoPtr_EmitDiv_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665303);
			InstructionList.NativeMethodInfoPtr_EmitModulo_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665304);
			InstructionList.NativeMethodInfoPtr_EmitExclusiveOr_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665305);
			InstructionList.NativeMethodInfoPtr_EmitAnd_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665306);
			InstructionList.NativeMethodInfoPtr_EmitOr_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665307);
			InstructionList.NativeMethodInfoPtr_EmitLeftShift_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665308);
			InstructionList.NativeMethodInfoPtr_EmitRightShift_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665309);
			InstructionList.NativeMethodInfoPtr_EmitEqual_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665310);
			InstructionList.NativeMethodInfoPtr_EmitNotEqual_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665311);
			InstructionList.NativeMethodInfoPtr_EmitLessThan_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665312);
			InstructionList.NativeMethodInfoPtr_EmitLessThanOrEqual_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665313);
			InstructionList.NativeMethodInfoPtr_EmitGreaterThan_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665314);
			InstructionList.NativeMethodInfoPtr_EmitGreaterThanOrEqual_Public_Void_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665315);
			InstructionList.NativeMethodInfoPtr_EmitNumericConvertChecked_Public_Void_TypeCode_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665316);
			InstructionList.NativeMethodInfoPtr_EmitNumericConvertUnchecked_Public_Void_TypeCode_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665317);
			InstructionList.NativeMethodInfoPtr_EmitConvertToUnderlying_Public_Void_TypeCode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665318);
			InstructionList.NativeMethodInfoPtr_EmitCast_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665319);
			InstructionList.NativeMethodInfoPtr_EmitCastToEnum_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665320);
			InstructionList.NativeMethodInfoPtr_EmitCastReferenceToEnum_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665321);
			InstructionList.NativeMethodInfoPtr_EmitNot_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665322);
			InstructionList.NativeMethodInfoPtr_EmitDefaultValue_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665323);
			InstructionList.NativeMethodInfoPtr_EmitNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665324);
			InstructionList.NativeMethodInfoPtr_EmitByRefNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665325);
			InstructionList.NativeMethodInfoPtr_EmitCreateDelegate_Internal_Void_LightDelegateCreator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665326);
			InstructionList.NativeMethodInfoPtr_EmitTypeEquals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665327);
			InstructionList.NativeMethodInfoPtr_EmitArrayLength_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665328);
			InstructionList.NativeMethodInfoPtr_EmitNegate_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665329);
			InstructionList.NativeMethodInfoPtr_EmitNegateChecked_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665330);
			InstructionList.NativeMethodInfoPtr_EmitIncrement_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665331);
			InstructionList.NativeMethodInfoPtr_EmitDecrement_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665332);
			InstructionList.NativeMethodInfoPtr_EmitTypeIs_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665333);
			InstructionList.NativeMethodInfoPtr_EmitTypeAs_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665334);
			InstructionList.NativeMethodInfoPtr_EmitLoadField_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665335);
			InstructionList.NativeMethodInfoPtr_GetLoadField_Private_Instruction_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665336);
			InstructionList.NativeMethodInfoPtr_EmitStoreField_Public_Void_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665337);
			InstructionList.NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665338);
			InstructionList.NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665339);
			InstructionList.NativeMethodInfoPtr_EmitByRefCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665340);
			InstructionList.NativeMethodInfoPtr_EmitNullableCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665341);
			InstructionList.NativeMethodInfoPtr_BuildRuntimeLabels_Private_Il2CppStructArray_1_RuntimeLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665342);
			InstructionList.NativeMethodInfoPtr_MakeLabel_Public_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665343);
			InstructionList.NativeMethodInfoPtr_FixupBranch_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665344);
			InstructionList.NativeMethodInfoPtr_EnsureLabelIndex_Private_Int32_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665345);
			InstructionList.NativeMethodInfoPtr_MarkRuntimeLabel_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665346);
			InstructionList.NativeMethodInfoPtr_MarkLabel_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665347);
			InstructionList.NativeMethodInfoPtr_EmitGoto_Public_Void_BranchLabel_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665348);
			InstructionList.NativeMethodInfoPtr_EmitBranch_Private_Void_OffsetInstruction_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665349);
			InstructionList.NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665350);
			InstructionList.NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665351);
			InstructionList.NativeMethodInfoPtr_EmitCoalescingBranch_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665352);
			InstructionList.NativeMethodInfoPtr_EmitBranchTrue_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665353);
			InstructionList.NativeMethodInfoPtr_EmitBranchFalse_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665354);
			InstructionList.NativeMethodInfoPtr_EmitThrow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665355);
			InstructionList.NativeMethodInfoPtr_EmitThrowVoid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665356);
			InstructionList.NativeMethodInfoPtr_EmitRethrow_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665357);
			InstructionList.NativeMethodInfoPtr_EmitRethrowVoid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665358);
			InstructionList.NativeMethodInfoPtr_EmitEnterTryFinally_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665359);
			InstructionList.NativeMethodInfoPtr_EmitEnterTryCatch_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665360);
			InstructionList.NativeMethodInfoPtr_EmitEnterTryFault_Public_EnterTryFaultInstruction_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665361);
			InstructionList.NativeMethodInfoPtr_EmitEnterFinally_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665362);
			InstructionList.NativeMethodInfoPtr_EmitLeaveFinally_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665363);
			InstructionList.NativeMethodInfoPtr_EmitEnterFault_Public_Void_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665364);
			InstructionList.NativeMethodInfoPtr_EmitLeaveFault_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665365);
			InstructionList.NativeMethodInfoPtr_EmitEnterExceptionFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665366);
			InstructionList.NativeMethodInfoPtr_EmitLeaveExceptionFilter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665367);
			InstructionList.NativeMethodInfoPtr_EmitEnterExceptionHandlerNonVoid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665368);
			InstructionList.NativeMethodInfoPtr_EmitEnterExceptionHandlerVoid_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665369);
			InstructionList.NativeMethodInfoPtr_EmitLeaveExceptionHandler_Public_Void_Boolean_BranchLabel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665370);
			InstructionList.NativeMethodInfoPtr_EmitIntSwitch_Public_Void_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665371);
			InstructionList.NativeMethodInfoPtr_EmitStringSwitch_Public_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665372);
			InstructionList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, 100665373);
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x0003CE68 File Offset: 0x0003B068
		[CallerCount(137)]
		[CachedScanResults(RefRangeStart = 1017431, RefRangeEnd = 1017568, XrefRangeStart = 1017426, XrefRangeEnd = 1017431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Emit(Instruction instruction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_Emit_Public_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x0003CEAC File Offset: 0x0003B0AC
		[CallerCount(0)]
		public unsafe void UpdateStackDepth(Instruction instruction)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_UpdateStackDepth_Private_Void_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x0003CEF0 File Offset: 0x0003B0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017568, XrefRangeEnd = 1017575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnEmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_UnEmit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06000A85 RID: 2693 RVA: 0x0003CF24 File Offset: 0x0003B124
		public unsafe int Count
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1017576, RefRangeEnd = 1017592, XrefRangeStart = 1017575, XrefRangeEnd = 1017576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06000A86 RID: 2694 RVA: 0x0003CF60 File Offset: 0x0003B160
		public unsafe int CurrentStackDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_get_CurrentStackDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06000A87 RID: 2695 RVA: 0x0003CF9C File Offset: 0x0003B19C
		public unsafe int CurrentContinuationsDepth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_get_CurrentContinuationsDepth_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0003CFD8 File Offset: 0x0003B1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017592, XrefRangeEnd = 1017596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction GetInstruction(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_GetInstruction_Internal_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x0003D024 File Offset: 0x0003B224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017596, XrefRangeEnd = 1017608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstructionArray ToArray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_ToArray_Public_InstructionArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new InstructionArray(intPtr);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0003D05C File Offset: 0x0003B25C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017608, XrefRangeEnd = 1017609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoad(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8B RID: 2699 RVA: 0x0003D0A0 File Offset: 0x0003B2A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1017641, RefRangeEnd = 1017644, XrefRangeStart = 1017609, XrefRangeEnd = 1017641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoad(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x0003D0E0 File Offset: 0x0003B2E0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1017683, RefRangeEnd = 1017697, XrefRangeStart = 1017644, XrefRangeEnd = 1017683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoad(Object value, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoad_Public_Void_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x0003D134 File Offset: 0x0003B334
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1017702, RefRangeEnd = 1017706, XrefRangeStart = 1017697, XrefRangeEnd = 1017702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitDup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitDup_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x0003D168 File Offset: 0x0003B368
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1017711, RefRangeEnd = 1017716, XrefRangeStart = 1017706, XrefRangeEnd = 1017711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitPop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0003D19C File Offset: 0x0003B39C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1017727, RefRangeEnd = 1017728, XrefRangeStart = 1017716, XrefRangeEnd = 1017727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwitchToBoxed(int index, int instructionIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref instructionIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_SwitchToBoxed_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0003D1E8 File Offset: 0x0003B3E8
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1017762, RefRangeEnd = 1017773, XrefRangeStart = 1017728, XrefRangeEnd = 1017762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoadLocal(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoadLocal_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x0003D228 File Offset: 0x0003B428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017773, XrefRangeEnd = 1017778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoadLocalBoxed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoadLocalBoxed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x0003D268 File Offset: 0x0003B468
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1017797, RefRangeEnd = 1017800, XrefRangeStart = 1017778, XrefRangeEnd = 1017797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction LoadLocalBoxed(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_LoadLocalBoxed_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0003D2A8 File Offset: 0x0003B4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1017834, RefRangeEnd = 1017835, XrefRangeStart = 1017800, XrefRangeEnd = 1017834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoadLocalFromClosure(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoadLocalFromClosure_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A94 RID: 2708 RVA: 0x0003D2E8 File Offset: 0x0003B4E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1017869, RefRangeEnd = 1017870, XrefRangeStart = 1017835, XrefRangeEnd = 1017869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoadLocalFromClosureBoxed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoadLocalFromClosureBoxed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x0003D328 File Offset: 0x0003B528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017904, RefRangeEnd = 1017906, XrefRangeStart = 1017870, XrefRangeEnd = 1017904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitAssignLocal(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitAssignLocal_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x0003D368 File Offset: 0x0003B568
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1017940, RefRangeEnd = 1017952, XrefRangeStart = 1017906, XrefRangeEnd = 1017940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStoreLocal(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitStoreLocal_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x0003D3A8 File Offset: 0x0003B5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017952, XrefRangeEnd = 1017957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitAssignLocalBoxed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitAssignLocalBoxed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0003D3E8 File Offset: 0x0003B5E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1017976, RefRangeEnd = 1017979, XrefRangeStart = 1017957, XrefRangeEnd = 1017976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction AssignLocalBoxed(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_AssignLocalBoxed_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0003D428 File Offset: 0x0003B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017979, XrefRangeEnd = 1017984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStoreLocalBoxed(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitStoreLocalBoxed_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0003D468 File Offset: 0x0003B668
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1018003, RefRangeEnd = 1018005, XrefRangeStart = 1017984, XrefRangeEnd = 1018003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction StoreLocalBoxed(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_StoreLocalBoxed_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0003D4A8 File Offset: 0x0003B6A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018039, RefRangeEnd = 1018040, XrefRangeStart = 1018005, XrefRangeEnd = 1018039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitAssignLocalToClosure(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitAssignLocalToClosure_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x0003D4E8 File Offset: 0x0003B6E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018040, XrefRangeEnd = 1018046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStoreLocalToClosure(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitStoreLocalToClosure_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x0003D528 File Offset: 0x0003B728
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018046, XrefRangeEnd = 1018067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitInitializeLocal(int index, Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitInitializeLocal_Public_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0003D578 File Offset: 0x0003B778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018067, XrefRangeEnd = 1018075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitInitializeParameter(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitInitializeParameter_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018075, XrefRangeEnd = 1018079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction Parameter(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_Parameter_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0003D5F8 File Offset: 0x0003B7F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018079, XrefRangeEnd = 1018083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction ParameterBox(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_ParameterBox_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x0003D638 File Offset: 0x0003B838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018083, XrefRangeEnd = 1018087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction InitReference(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_InitReference_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x0003D678 File Offset: 0x0003B878
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018091, RefRangeEnd = 1018092, XrefRangeStart = 1018087, XrefRangeEnd = 1018091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Instruction InitImmutableRefBox(int index)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_InitImmutableRefBox_Internal_Static_Instruction_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0003D6B8 File Offset: 0x0003B8B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018092, XrefRangeEnd = 1018097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNewRuntimeVariables(int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNewRuntimeVariables_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0003D6F8 File Offset: 0x0003B8F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018102, RefRangeEnd = 1018103, XrefRangeStart = 1018097, XrefRangeEnd = 1018102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGetArrayItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitGetArrayItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x0003D72C File Offset: 0x0003B92C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018103, XrefRangeEnd = 1018108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitSetArrayItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitSetArrayItem_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x0003D760 File Offset: 0x0003B960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018108, XrefRangeEnd = 1018113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNewArray(Type elementType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNewArray_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018113, XrefRangeEnd = 1018118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNewArrayBounds(Type elementType, int rank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rank;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNewArrayBounds_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018118, XrefRangeEnd = 1018123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNewArrayInit(Type elementType, int elementCount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNewArrayInit_Public_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x0003D844 File Offset: 0x0003BA44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018123, XrefRangeEnd = 1018128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitAdd(Type type, bool @checked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref @checked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitAdd_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0003D894 File Offset: 0x0003BA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018128, XrefRangeEnd = 1018133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitSub(Type type, bool @checked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref @checked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitSub_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0003D8E4 File Offset: 0x0003BAE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018133, XrefRangeEnd = 1018138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitMul(Type type, bool @checked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref @checked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitMul_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0003D934 File Offset: 0x0003BB34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018138, XrefRangeEnd = 1018140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitDiv(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitDiv_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0003D978 File Offset: 0x0003BB78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018140, XrefRangeEnd = 1018142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitModulo(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitModulo_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x0003D9BC File Offset: 0x0003BBBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018142, XrefRangeEnd = 1018144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitExclusiveOr(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitExclusiveOr_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0003DA00 File Offset: 0x0003BC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018144, XrefRangeEnd = 1018146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitAnd(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitAnd_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0003DA44 File Offset: 0x0003BC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018146, XrefRangeEnd = 1018148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitOr(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitOr_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0003DA88 File Offset: 0x0003BC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018148, XrefRangeEnd = 1018150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLeftShift(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLeftShift_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0003DACC File Offset: 0x0003BCCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018150, XrefRangeEnd = 1018152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitRightShift(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitRightShift_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0003DB10 File Offset: 0x0003BD10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018152, XrefRangeEnd = 1018154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEqual(Type type, bool liftedToNull = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEqual_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x0003DB60 File Offset: 0x0003BD60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018154, XrefRangeEnd = 1018156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNotEqual(Type type, bool liftedToNull = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNotEqual_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018156, XrefRangeEnd = 1018158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLessThan(Type type, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLessThan_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003DC00 File Offset: 0x0003BE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018158, XrefRangeEnd = 1018160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLessThanOrEqual(Type type, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLessThanOrEqual_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0003DC50 File Offset: 0x0003BE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018160, XrefRangeEnd = 1018162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGreaterThan(Type type, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitGreaterThan_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x0003DCA0 File Offset: 0x0003BEA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018162, XrefRangeEnd = 1018164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGreaterThanOrEqual(Type type, bool liftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitGreaterThanOrEqual_Public_Void_Type_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0003DCF0 File Offset: 0x0003BEF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018164, XrefRangeEnd = 1018169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNumericConvertChecked(TypeCode from, TypeCode to, bool isLiftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNumericConvertChecked_Public_Void_TypeCode_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x0003DD4C File Offset: 0x0003BF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018169, XrefRangeEnd = 1018174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNumericConvertUnchecked(TypeCode from, TypeCode to, bool isLiftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref from;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref to;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNumericConvertUnchecked_Public_Void_TypeCode_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0003DDA8 File Offset: 0x0003BFA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018174, XrefRangeEnd = 1018179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitConvertToUnderlying(TypeCode to, bool isLiftedToNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref to;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isLiftedToNull;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitConvertToUnderlying_Public_Void_TypeCode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0003DDF4 File Offset: 0x0003BFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018179, XrefRangeEnd = 1018181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCast(Type toType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCast_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0003DE38 File Offset: 0x0003C038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018181, XrefRangeEnd = 1018186, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCastToEnum(Type toType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCastToEnum_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0003DE7C File Offset: 0x0003C07C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018186, XrefRangeEnd = 1018191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCastReferenceToEnum(Type toType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(toType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCastReferenceToEnum_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x0003DEC0 File Offset: 0x0003C0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018191, XrefRangeEnd = 1018193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNot(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNot_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x0003DF04 File Offset: 0x0003C104
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1018198, RefRangeEnd = 1018201, XrefRangeStart = 1018193, XrefRangeEnd = 1018198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitDefaultValue(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitDefaultValue_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x0003DF48 File Offset: 0x0003C148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018201, XrefRangeEnd = 1018207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNew(ConstructorInfo constructorInfo, Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x0003DF9C File Offset: 0x0003C19C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018207, XrefRangeEnd = 1018213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitByRefNew(ConstructorInfo constructorInfo, Il2CppReferenceArray<ParameterInfo> parameters, Il2CppReferenceArray<ByRefUpdater> updaters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(updaters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitByRefNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0003E004 File Offset: 0x0003C204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018213, XrefRangeEnd = 1018218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCreateDelegate(LightDelegateCreator creator)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(creator);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCreateDelegate_Internal_Void_LightDelegateCreator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0003E048 File Offset: 0x0003C248
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018223, RefRangeEnd = 1018224, XrefRangeStart = 1018218, XrefRangeEnd = 1018223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitTypeEquals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitTypeEquals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0003E07C File Offset: 0x0003C27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018224, XrefRangeEnd = 1018229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitArrayLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitArrayLength_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x0003E0B0 File Offset: 0x0003C2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018229, XrefRangeEnd = 1018231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNegate(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNegate_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0003E0F4 File Offset: 0x0003C2F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018231, XrefRangeEnd = 1018233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNegateChecked(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNegateChecked_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0003E138 File Offset: 0x0003C338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018233, XrefRangeEnd = 1018235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitIncrement(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitIncrement_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0003E17C File Offset: 0x0003C37C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018235, XrefRangeEnd = 1018237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitDecrement(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitDecrement_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x0003E1C0 File Offset: 0x0003C3C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018237, XrefRangeEnd = 1018242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitTypeIs(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitTypeIs_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x0003E204 File Offset: 0x0003C404
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018242, XrefRangeEnd = 1018247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitTypeAs(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitTypeAs_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0003E248 File Offset: 0x0003C448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018247, XrefRangeEnd = 1018249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLoadField(FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLoadField_Public_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0003E28C File Offset: 0x0003C48C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1018281, RefRangeEnd = 1018283, XrefRangeStart = 1018249, XrefRangeEnd = 1018281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction GetLoadField(FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_GetLoadField_Private_Instruction_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x0003E2DC File Offset: 0x0003C4DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018293, RefRangeEnd = 1018294, XrefRangeStart = 1018283, XrefRangeEnd = 1018293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStoreField(FieldInfo field)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitStoreField_Public_Void_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x0003E320 File Offset: 0x0003C520
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1018300, RefRangeEnd = 1018306, XrefRangeStart = 1018294, XrefRangeEnd = 1018300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCall(MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0003E364 File Offset: 0x0003C564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018306, XrefRangeEnd = 1018308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCall(MethodInfo method, Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0003E3B8 File Offset: 0x0003C5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018308, XrefRangeEnd = 1018315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitByRefCall(MethodInfo method, Il2CppReferenceArray<ParameterInfo> parameters, Il2CppReferenceArray<ByRefUpdater> byrefArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(byrefArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitByRefCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x0003E420 File Offset: 0x0003C620
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018315, XrefRangeEnd = 1018318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitNullableCall(MethodInfo method, Il2CppReferenceArray<ParameterInfo> parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitNullableCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0003E474 File Offset: 0x0003C674
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1018343, RefRangeEnd = 1018345, XrefRangeStart = 1018318, XrefRangeEnd = 1018343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<RuntimeLabel> BuildRuntimeLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_BuildRuntimeLabels_Private_Il2CppStructArray_1_RuntimeLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimeLabel>>(intPtr3) : null;
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x0003E4B4 File Offset: 0x0003C6B4
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 1018359, RefRangeEnd = 1018387, XrefRangeStart = 1018345, XrefRangeEnd = 1018359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchLabel MakeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_MakeLabel_Public_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BranchLabel>(intPtr3) : null;
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0003E4F4 File Offset: 0x0003C6F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1018398, RefRangeEnd = 1018401, XrefRangeStart = 1018387, XrefRangeEnd = 1018398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixupBranch(int branchIndex, int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref branchIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_FixupBranch_Internal_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x0003E540 File Offset: 0x0003C740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018401, XrefRangeEnd = 1018402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int EnsureLabelIndex(BranchLabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EnsureLabelIndex_Private_Int32_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0003E590 File Offset: 0x0003C790
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1018405, RefRangeEnd = 1018407, XrefRangeStart = 1018402, XrefRangeEnd = 1018405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MarkRuntimeLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_MarkRuntimeLabel_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x0003E5CC File Offset: 0x0003C7CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018409, RefRangeEnd = 1018410, XrefRangeStart = 1018407, XrefRangeEnd = 1018409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MarkLabel(BranchLabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_MarkLabel_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x0003E610 File Offset: 0x0003C810
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018417, RefRangeEnd = 1018418, XrefRangeStart = 1018410, XrefRangeEnd = 1018417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitGoto(BranchLabel label, bool hasResult, bool hasValue, bool labelTargetGetsValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref labelTargetGetsValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitGoto_Public_Void_BranchLabel_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x0003E67C File Offset: 0x0003C87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018418, XrefRangeEnd = 1018422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitBranch(OffsetInstruction instruction, BranchLabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitBranch_Private_Void_OffsetInstruction_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0003E6D0 File Offset: 0x0003C8D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1018430, RefRangeEnd = 1018433, XrefRangeStart = 1018422, XrefRangeEnd = 1018430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitBranch(BranchLabel label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0003E714 File Offset: 0x0003C914
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1018441, RefRangeEnd = 1018448, XrefRangeStart = 1018433, XrefRangeEnd = 1018441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitBranch(BranchLabel label, bool hasResult, bool hasValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasResult;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x0003E774 File Offset: 0x0003C974
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018456, RefRangeEnd = 1018457, XrefRangeStart = 1018448, XrefRangeEnd = 1018456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitCoalescingBranch(BranchLabel leftNotNull)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(leftNotNull);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitCoalescingBranch_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x0003E7B8 File Offset: 0x0003C9B8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1018465, RefRangeEnd = 1018473, XrefRangeStart = 1018457, XrefRangeEnd = 1018465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitBranchTrue(BranchLabel elseLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elseLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitBranchTrue_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x0003E7FC File Offset: 0x0003C9FC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1018481, RefRangeEnd = 1018485, XrefRangeStart = 1018473, XrefRangeEnd = 1018481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitBranchFalse(BranchLabel elseLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elseLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitBranchFalse_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0003E840 File Offset: 0x0003CA40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018485, XrefRangeEnd = 1018490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitThrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitThrow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0003E874 File Offset: 0x0003CA74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018490, XrefRangeEnd = 1018495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitThrowVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitThrowVoid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x0003E8A8 File Offset: 0x0003CAA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018495, XrefRangeEnd = 1018500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitRethrow()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitRethrow_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0003E8DC File Offset: 0x0003CADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018500, XrefRangeEnd = 1018505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitRethrowVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitRethrowVoid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x0003E910 File Offset: 0x0003CB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018505, XrefRangeEnd = 1018509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterTryFinally(BranchLabel finallyStartLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(finallyStartLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterTryFinally_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0003E954 File Offset: 0x0003CB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018509, XrefRangeEnd = 1018511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterTryCatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterTryCatch_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0003E988 File Offset: 0x0003CB88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018511, XrefRangeEnd = 1018517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnterTryFaultInstruction EmitEnterTryFault(BranchLabel tryEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(tryEnd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterTryFault_Public_EnterTryFaultInstruction_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EnterTryFaultInstruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0003E9D8 File Offset: 0x0003CBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018517, XrefRangeEnd = 1018524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterFinally(BranchLabel finallyStartLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(finallyStartLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterFinally_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x0003EA1C File Offset: 0x0003CC1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018524, XrefRangeEnd = 1018529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLeaveFinally()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLeaveFinally_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0003EA50 File Offset: 0x0003CC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018529, XrefRangeEnd = 1018536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterFault(BranchLabel faultStartLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(faultStartLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterFault_Public_Void_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x0003EA94 File Offset: 0x0003CC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018536, XrefRangeEnd = 1018541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLeaveFault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLeaveFault_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x0003EAC8 File Offset: 0x0003CCC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018546, RefRangeEnd = 1018547, XrefRangeStart = 1018541, XrefRangeEnd = 1018546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterExceptionFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterExceptionFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x0003EAFC File Offset: 0x0003CCFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018552, RefRangeEnd = 1018553, XrefRangeStart = 1018547, XrefRangeEnd = 1018552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLeaveExceptionFilter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLeaveExceptionFilter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x0003EB30 File Offset: 0x0003CD30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018558, RefRangeEnd = 1018559, XrefRangeStart = 1018553, XrefRangeEnd = 1018558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterExceptionHandlerNonVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterExceptionHandlerNonVoid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x0003EB64 File Offset: 0x0003CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018564, RefRangeEnd = 1018565, XrefRangeStart = 1018559, XrefRangeEnd = 1018564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitEnterExceptionHandlerVoid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitEnterExceptionHandlerVoid_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003EB98 File Offset: 0x0003CD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018572, RefRangeEnd = 1018573, XrefRangeStart = 1018565, XrefRangeEnd = 1018572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitLeaveExceptionHandler(bool hasValue, BranchLabel tryExpressionEndLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref hasValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tryExpressionEndLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitLeaveExceptionHandler_Public_Void_Boolean_BranchLabel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x0003EBE8 File Offset: 0x0003CDE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1018581, RefRangeEnd = 1018582, XrefRangeStart = 1018573, XrefRangeEnd = 1018581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitIntSwitch<T>(Dictionary<T, int> cases)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cases);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.MethodInfoStoreGeneric_EmitIntSwitch_Public_Void_Dictionary_2_T_Int32_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0003EC2C File Offset: 0x0003CE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018582, XrefRangeEnd = 1018587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EmitStringSwitch(Dictionary<string, int> cases, StrongBox<int> nullCase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cases);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullCase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr_EmitStringSwitch_Public_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x0003EC80 File Offset: 0x0003CE80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1018587, XrefRangeEnd = 1018595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstructionList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00005091 File Offset: 0x00003291
		public InstructionList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0003ECBC File Offset: 0x0003CEBC
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x0000509A File Offset: 0x0000329A
		public unsafe List<Instruction> _instructions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__instructions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Instruction>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__instructions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000AF6 RID: 2806 RVA: 0x0003ECEC File Offset: 0x0003CEEC
		// (set) Token: 0x06000AF7 RID: 2807 RVA: 0x000050B9 File Offset: 0x000032B9
		public unsafe List<Object> _objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0003ED1C File Offset: 0x0003CF1C
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x000050D8 File Offset: 0x000032D8
		public unsafe int _currentStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__currentStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__currentStackDepth)) = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000AFA RID: 2810 RVA: 0x0003ED44 File Offset: 0x0003CF44
		// (set) Token: 0x06000AFB RID: 2811 RVA: 0x000050F3 File Offset: 0x000032F3
		public unsafe int _maxStackDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__maxStackDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__maxStackDepth)) = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000AFC RID: 2812 RVA: 0x0003ED6C File Offset: 0x0003CF6C
		// (set) Token: 0x06000AFD RID: 2813 RVA: 0x0000510E File Offset: 0x0000330E
		public unsafe int _currentContinuationsDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__currentContinuationsDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__currentContinuationsDepth)) = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000AFE RID: 2814 RVA: 0x0003ED94 File Offset: 0x0003CF94
		// (set) Token: 0x06000AFF RID: 2815 RVA: 0x00005129 File Offset: 0x00003329
		public unsafe int _maxContinuationDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__maxContinuationDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__maxContinuationDepth)) = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0003EDBC File Offset: 0x0003CFBC
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x00005144 File Offset: 0x00003344
		public unsafe int _runtimeLabelCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__runtimeLabelCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__runtimeLabelCount)) = value;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000B02 RID: 2818 RVA: 0x0003EDE4 File Offset: 0x0003CFE4
		// (set) Token: 0x06000B03 RID: 2819 RVA: 0x0000515F File Offset: 0x0000335F
		public unsafe List<BranchLabel> _labels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__labels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BranchLabel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__labels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000B04 RID: 2820 RVA: 0x0003EE14 File Offset: 0x0003D014
		// (set) Token: 0x06000B05 RID: 2821 RVA: 0x0000517E File Offset: 0x0000337E
		public unsafe List<KeyValuePair<int, Object>> _debugCookies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__debugCookies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<int, Object>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.NativeFieldInfoPtr__debugCookies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000B06 RID: 2822 RVA: 0x0003EE44 File Offset: 0x0003D044
		// (set) Token: 0x06000B07 RID: 2823 RVA: 0x0000519D File Offset: 0x0000339D
		public unsafe static Instruction s_null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0003EE6C File Offset: 0x0003D06C
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x000051AF File Offset: 0x000033AF
		public unsafe static Instruction s_true
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_true, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_true, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000B0A RID: 2826 RVA: 0x0003EE94 File Offset: 0x0003D094
		// (set) Token: 0x06000B0B RID: 2827 RVA: 0x000051C1 File Offset: 0x000033C1
		public unsafe static Instruction s_false
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_false, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_false, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0003EEBC File Offset: 0x0003D0BC
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x000051D3 File Offset: 0x000033D3
		public unsafe static Il2CppReferenceArray<Instruction> s_Ints
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_Ints, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_Ints, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000B0E RID: 2830 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		// (set) Token: 0x06000B0F RID: 2831 RVA: 0x000051E5 File Offset: 0x000033E5
		public unsafe static Il2CppReferenceArray<Instruction> s_loadObjectCached
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadObjectCached, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadObjectCached, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x0003EF0C File Offset: 0x0003D10C
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x000051F7 File Offset: 0x000033F7
		public unsafe static Il2CppReferenceArray<Instruction> s_loadLocal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadLocal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadLocal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000B12 RID: 2834 RVA: 0x0003EF34 File Offset: 0x0003D134
		// (set) Token: 0x06000B13 RID: 2835 RVA: 0x00005209 File Offset: 0x00003409
		public unsafe static Il2CppReferenceArray<Instruction> s_loadLocalBoxed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadLocalBoxed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadLocalBoxed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000B14 RID: 2836 RVA: 0x0003EF5C File Offset: 0x0003D15C
		// (set) Token: 0x06000B15 RID: 2837 RVA: 0x0000521B File Offset: 0x0000341B
		public unsafe static Il2CppReferenceArray<Instruction> s_loadLocalFromClosure
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosure, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosure, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000B16 RID: 2838 RVA: 0x0003EF84 File Offset: 0x0003D184
		// (set) Token: 0x06000B17 RID: 2839 RVA: 0x0000522D File Offset: 0x0000342D
		public unsafe static Il2CppReferenceArray<Instruction> s_loadLocalFromClosureBoxed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosureBoxed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadLocalFromClosureBoxed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0003EFAC File Offset: 0x0003D1AC
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0000523F File Offset: 0x0000343F
		public unsafe static Il2CppReferenceArray<Instruction> s_assignLocal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_assignLocal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_assignLocal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000B1A RID: 2842 RVA: 0x0003EFD4 File Offset: 0x0003D1D4
		// (set) Token: 0x06000B1B RID: 2843 RVA: 0x00005251 File Offset: 0x00003451
		public unsafe static Il2CppReferenceArray<Instruction> s_storeLocal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_storeLocal, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_storeLocal, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0003EFFC File Offset: 0x0003D1FC
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x00005263 File Offset: 0x00003463
		public unsafe static Il2CppReferenceArray<Instruction> s_assignLocalBoxed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_assignLocalBoxed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_assignLocalBoxed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000B1E RID: 2846 RVA: 0x0003F024 File Offset: 0x0003D224
		// (set) Token: 0x06000B1F RID: 2847 RVA: 0x00005275 File Offset: 0x00003475
		public unsafe static Il2CppReferenceArray<Instruction> s_storeLocalBoxed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_storeLocalBoxed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_storeLocalBoxed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06000B20 RID: 2848 RVA: 0x0003F04C File Offset: 0x0003D24C
		// (set) Token: 0x06000B21 RID: 2849 RVA: 0x00005287 File Offset: 0x00003487
		public unsafe static Il2CppReferenceArray<Instruction> s_assignLocalToClosure
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_assignLocalToClosure, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_assignLocalToClosure, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000B22 RID: 2850 RVA: 0x0003F074 File Offset: 0x0003D274
		// (set) Token: 0x06000B23 RID: 2851 RVA: 0x00005299 File Offset: 0x00003499
		public unsafe static Dictionary<FieldInfo, Instruction> s_loadFields
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_loadFields, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<FieldInfo, Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_loadFields, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06000B24 RID: 2852 RVA: 0x0003F09C File Offset: 0x0003D29C
		// (set) Token: 0x06000B25 RID: 2853 RVA: 0x000052AB File Offset: 0x000034AB
		public unsafe static Il2CppStructArray<RuntimeLabel> s_emptyRuntimeLabels
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InstructionList.NativeFieldInfoPtr_s_emptyRuntimeLabels, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RuntimeLabel>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InstructionList.NativeFieldInfoPtr_s_emptyRuntimeLabels, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007C7 RID: 1991
		private static readonly IntPtr NativeFieldInfoPtr__instructions;

		// Token: 0x040007C8 RID: 1992
		private static readonly IntPtr NativeFieldInfoPtr__objects;

		// Token: 0x040007C9 RID: 1993
		private static readonly IntPtr NativeFieldInfoPtr__currentStackDepth;

		// Token: 0x040007CA RID: 1994
		private static readonly IntPtr NativeFieldInfoPtr__maxStackDepth;

		// Token: 0x040007CB RID: 1995
		private static readonly IntPtr NativeFieldInfoPtr__currentContinuationsDepth;

		// Token: 0x040007CC RID: 1996
		private static readonly IntPtr NativeFieldInfoPtr__maxContinuationDepth;

		// Token: 0x040007CD RID: 1997
		private static readonly IntPtr NativeFieldInfoPtr__runtimeLabelCount;

		// Token: 0x040007CE RID: 1998
		private static readonly IntPtr NativeFieldInfoPtr__labels;

		// Token: 0x040007CF RID: 1999
		private static readonly IntPtr NativeFieldInfoPtr__debugCookies;

		// Token: 0x040007D0 RID: 2000
		private static readonly IntPtr NativeFieldInfoPtr_s_null;

		// Token: 0x040007D1 RID: 2001
		private static readonly IntPtr NativeFieldInfoPtr_s_true;

		// Token: 0x040007D2 RID: 2002
		private static readonly IntPtr NativeFieldInfoPtr_s_false;

		// Token: 0x040007D3 RID: 2003
		private static readonly IntPtr NativeFieldInfoPtr_s_Ints;

		// Token: 0x040007D4 RID: 2004
		private static readonly IntPtr NativeFieldInfoPtr_s_loadObjectCached;

		// Token: 0x040007D5 RID: 2005
		private static readonly IntPtr NativeFieldInfoPtr_s_loadLocal;

		// Token: 0x040007D6 RID: 2006
		private static readonly IntPtr NativeFieldInfoPtr_s_loadLocalBoxed;

		// Token: 0x040007D7 RID: 2007
		private static readonly IntPtr NativeFieldInfoPtr_s_loadLocalFromClosure;

		// Token: 0x040007D8 RID: 2008
		private static readonly IntPtr NativeFieldInfoPtr_s_loadLocalFromClosureBoxed;

		// Token: 0x040007D9 RID: 2009
		private static readonly IntPtr NativeFieldInfoPtr_s_assignLocal;

		// Token: 0x040007DA RID: 2010
		private static readonly IntPtr NativeFieldInfoPtr_s_storeLocal;

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeFieldInfoPtr_s_assignLocalBoxed;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeFieldInfoPtr_s_storeLocalBoxed;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeFieldInfoPtr_s_assignLocalToClosure;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeFieldInfoPtr_s_loadFields;

		// Token: 0x040007DF RID: 2015
		private static readonly IntPtr NativeFieldInfoPtr_s_emptyRuntimeLabels;

		// Token: 0x040007E0 RID: 2016
		private static readonly IntPtr NativeMethodInfoPtr_Emit_Public_Void_Instruction_0;

		// Token: 0x040007E1 RID: 2017
		private static readonly IntPtr NativeMethodInfoPtr_UpdateStackDepth_Private_Void_Instruction_0;

		// Token: 0x040007E2 RID: 2018
		private static readonly IntPtr NativeMethodInfoPtr_UnEmit_Public_Void_0;

		// Token: 0x040007E3 RID: 2019
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x040007E4 RID: 2020
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStackDepth_Public_get_Int32_0;

		// Token: 0x040007E5 RID: 2021
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentContinuationsDepth_Public_get_Int32_0;

		// Token: 0x040007E6 RID: 2022
		private static readonly IntPtr NativeMethodInfoPtr_GetInstruction_Internal_Instruction_Int32_0;

		// Token: 0x040007E7 RID: 2023
		private static readonly IntPtr NativeMethodInfoPtr_ToArray_Public_InstructionArray_0;

		// Token: 0x040007E8 RID: 2024
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoad_Public_Void_Object_0;

		// Token: 0x040007E9 RID: 2025
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoad_Public_Void_Boolean_0;

		// Token: 0x040007EA RID: 2026
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoad_Public_Void_Object_Type_0;

		// Token: 0x040007EB RID: 2027
		private static readonly IntPtr NativeMethodInfoPtr_EmitDup_Public_Void_0;

		// Token: 0x040007EC RID: 2028
		private static readonly IntPtr NativeMethodInfoPtr_EmitPop_Public_Void_0;

		// Token: 0x040007ED RID: 2029
		private static readonly IntPtr NativeMethodInfoPtr_SwitchToBoxed_Internal_Void_Int32_Int32_0;

		// Token: 0x040007EE RID: 2030
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoadLocal_Public_Void_Int32_0;

		// Token: 0x040007EF RID: 2031
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoadLocalBoxed_Public_Void_Int32_0;

		// Token: 0x040007F0 RID: 2032
		private static readonly IntPtr NativeMethodInfoPtr_LoadLocalBoxed_Internal_Static_Instruction_Int32_0;

		// Token: 0x040007F1 RID: 2033
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoadLocalFromClosure_Public_Void_Int32_0;

		// Token: 0x040007F2 RID: 2034
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoadLocalFromClosureBoxed_Public_Void_Int32_0;

		// Token: 0x040007F3 RID: 2035
		private static readonly IntPtr NativeMethodInfoPtr_EmitAssignLocal_Public_Void_Int32_0;

		// Token: 0x040007F4 RID: 2036
		private static readonly IntPtr NativeMethodInfoPtr_EmitStoreLocal_Public_Void_Int32_0;

		// Token: 0x040007F5 RID: 2037
		private static readonly IntPtr NativeMethodInfoPtr_EmitAssignLocalBoxed_Public_Void_Int32_0;

		// Token: 0x040007F6 RID: 2038
		private static readonly IntPtr NativeMethodInfoPtr_AssignLocalBoxed_Internal_Static_Instruction_Int32_0;

		// Token: 0x040007F7 RID: 2039
		private static readonly IntPtr NativeMethodInfoPtr_EmitStoreLocalBoxed_Public_Void_Int32_0;

		// Token: 0x040007F8 RID: 2040
		private static readonly IntPtr NativeMethodInfoPtr_StoreLocalBoxed_Internal_Static_Instruction_Int32_0;

		// Token: 0x040007F9 RID: 2041
		private static readonly IntPtr NativeMethodInfoPtr_EmitAssignLocalToClosure_Public_Void_Int32_0;

		// Token: 0x040007FA RID: 2042
		private static readonly IntPtr NativeMethodInfoPtr_EmitStoreLocalToClosure_Public_Void_Int32_0;

		// Token: 0x040007FB RID: 2043
		private static readonly IntPtr NativeMethodInfoPtr_EmitInitializeLocal_Public_Void_Int32_Type_0;

		// Token: 0x040007FC RID: 2044
		private static readonly IntPtr NativeMethodInfoPtr_EmitInitializeParameter_Internal_Void_Int32_0;

		// Token: 0x040007FD RID: 2045
		private static readonly IntPtr NativeMethodInfoPtr_Parameter_Internal_Static_Instruction_Int32_0;

		// Token: 0x040007FE RID: 2046
		private static readonly IntPtr NativeMethodInfoPtr_ParameterBox_Internal_Static_Instruction_Int32_0;

		// Token: 0x040007FF RID: 2047
		private static readonly IntPtr NativeMethodInfoPtr_InitReference_Internal_Static_Instruction_Int32_0;

		// Token: 0x04000800 RID: 2048
		private static readonly IntPtr NativeMethodInfoPtr_InitImmutableRefBox_Internal_Static_Instruction_Int32_0;

		// Token: 0x04000801 RID: 2049
		private static readonly IntPtr NativeMethodInfoPtr_EmitNewRuntimeVariables_Public_Void_Int32_0;

		// Token: 0x04000802 RID: 2050
		private static readonly IntPtr NativeMethodInfoPtr_EmitGetArrayItem_Public_Void_0;

		// Token: 0x04000803 RID: 2051
		private static readonly IntPtr NativeMethodInfoPtr_EmitSetArrayItem_Public_Void_0;

		// Token: 0x04000804 RID: 2052
		private static readonly IntPtr NativeMethodInfoPtr_EmitNewArray_Public_Void_Type_0;

		// Token: 0x04000805 RID: 2053
		private static readonly IntPtr NativeMethodInfoPtr_EmitNewArrayBounds_Public_Void_Type_Int32_0;

		// Token: 0x04000806 RID: 2054
		private static readonly IntPtr NativeMethodInfoPtr_EmitNewArrayInit_Public_Void_Type_Int32_0;

		// Token: 0x04000807 RID: 2055
		private static readonly IntPtr NativeMethodInfoPtr_EmitAdd_Public_Void_Type_Boolean_0;

		// Token: 0x04000808 RID: 2056
		private static readonly IntPtr NativeMethodInfoPtr_EmitSub_Public_Void_Type_Boolean_0;

		// Token: 0x04000809 RID: 2057
		private static readonly IntPtr NativeMethodInfoPtr_EmitMul_Public_Void_Type_Boolean_0;

		// Token: 0x0400080A RID: 2058
		private static readonly IntPtr NativeMethodInfoPtr_EmitDiv_Public_Void_Type_0;

		// Token: 0x0400080B RID: 2059
		private static readonly IntPtr NativeMethodInfoPtr_EmitModulo_Public_Void_Type_0;

		// Token: 0x0400080C RID: 2060
		private static readonly IntPtr NativeMethodInfoPtr_EmitExclusiveOr_Public_Void_Type_0;

		// Token: 0x0400080D RID: 2061
		private static readonly IntPtr NativeMethodInfoPtr_EmitAnd_Public_Void_Type_0;

		// Token: 0x0400080E RID: 2062
		private static readonly IntPtr NativeMethodInfoPtr_EmitOr_Public_Void_Type_0;

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeMethodInfoPtr_EmitLeftShift_Public_Void_Type_0;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeMethodInfoPtr_EmitRightShift_Public_Void_Type_0;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeMethodInfoPtr_EmitEqual_Public_Void_Type_Boolean_0;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr_EmitNotEqual_Public_Void_Type_Boolean_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_EmitLessThan_Public_Void_Type_Boolean_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_EmitLessThanOrEqual_Public_Void_Type_Boolean_0;

		// Token: 0x04000815 RID: 2069
		private static readonly IntPtr NativeMethodInfoPtr_EmitGreaterThan_Public_Void_Type_Boolean_0;

		// Token: 0x04000816 RID: 2070
		private static readonly IntPtr NativeMethodInfoPtr_EmitGreaterThanOrEqual_Public_Void_Type_Boolean_0;

		// Token: 0x04000817 RID: 2071
		private static readonly IntPtr NativeMethodInfoPtr_EmitNumericConvertChecked_Public_Void_TypeCode_TypeCode_Boolean_0;

		// Token: 0x04000818 RID: 2072
		private static readonly IntPtr NativeMethodInfoPtr_EmitNumericConvertUnchecked_Public_Void_TypeCode_TypeCode_Boolean_0;

		// Token: 0x04000819 RID: 2073
		private static readonly IntPtr NativeMethodInfoPtr_EmitConvertToUnderlying_Public_Void_TypeCode_Boolean_0;

		// Token: 0x0400081A RID: 2074
		private static readonly IntPtr NativeMethodInfoPtr_EmitCast_Public_Void_Type_0;

		// Token: 0x0400081B RID: 2075
		private static readonly IntPtr NativeMethodInfoPtr_EmitCastToEnum_Public_Void_Type_0;

		// Token: 0x0400081C RID: 2076
		private static readonly IntPtr NativeMethodInfoPtr_EmitCastReferenceToEnum_Public_Void_Type_0;

		// Token: 0x0400081D RID: 2077
		private static readonly IntPtr NativeMethodInfoPtr_EmitNot_Public_Void_Type_0;

		// Token: 0x0400081E RID: 2078
		private static readonly IntPtr NativeMethodInfoPtr_EmitDefaultValue_Public_Void_Type_0;

		// Token: 0x0400081F RID: 2079
		private static readonly IntPtr NativeMethodInfoPtr_EmitNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04000820 RID: 2080
		private static readonly IntPtr NativeMethodInfoPtr_EmitByRefNew_Public_Void_ConstructorInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0;

		// Token: 0x04000821 RID: 2081
		private static readonly IntPtr NativeMethodInfoPtr_EmitCreateDelegate_Internal_Void_LightDelegateCreator_0;

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeMethodInfoPtr_EmitTypeEquals_Public_Void_0;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeMethodInfoPtr_EmitArrayLength_Public_Void_0;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeMethodInfoPtr_EmitNegate_Public_Void_Type_0;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_EmitNegateChecked_Public_Void_Type_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_EmitIncrement_Public_Void_Type_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_EmitDecrement_Public_Void_Type_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_EmitTypeIs_Public_Void_Type_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_EmitTypeAs_Public_Void_Type_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_EmitLoadField_Public_Void_FieldInfo_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_GetLoadField_Private_Instruction_FieldInfo_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_EmitStoreField_Public_Void_FieldInfo_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_EmitCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_EmitByRefCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_Il2CppReferenceArray_1_ByRefUpdater_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_EmitNullableCall_Public_Void_MethodInfo_Il2CppReferenceArray_1_ParameterInfo_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_BuildRuntimeLabels_Private_Il2CppStructArray_1_RuntimeLabel_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_MakeLabel_Public_BranchLabel_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_FixupBranch_Internal_Void_Int32_Int32_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr_EnsureLabelIndex_Private_Int32_BranchLabel_0;

		// Token: 0x04000835 RID: 2101
		private static readonly IntPtr NativeMethodInfoPtr_MarkRuntimeLabel_Public_Int32_0;

		// Token: 0x04000836 RID: 2102
		private static readonly IntPtr NativeMethodInfoPtr_MarkLabel_Public_Void_BranchLabel_0;

		// Token: 0x04000837 RID: 2103
		private static readonly IntPtr NativeMethodInfoPtr_EmitGoto_Public_Void_BranchLabel_Boolean_Boolean_Boolean_0;

		// Token: 0x04000838 RID: 2104
		private static readonly IntPtr NativeMethodInfoPtr_EmitBranch_Private_Void_OffsetInstruction_BranchLabel_0;

		// Token: 0x04000839 RID: 2105
		private static readonly IntPtr NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_0;

		// Token: 0x0400083A RID: 2106
		private static readonly IntPtr NativeMethodInfoPtr_EmitBranch_Public_Void_BranchLabel_Boolean_Boolean_0;

		// Token: 0x0400083B RID: 2107
		private static readonly IntPtr NativeMethodInfoPtr_EmitCoalescingBranch_Public_Void_BranchLabel_0;

		// Token: 0x0400083C RID: 2108
		private static readonly IntPtr NativeMethodInfoPtr_EmitBranchTrue_Public_Void_BranchLabel_0;

		// Token: 0x0400083D RID: 2109
		private static readonly IntPtr NativeMethodInfoPtr_EmitBranchFalse_Public_Void_BranchLabel_0;

		// Token: 0x0400083E RID: 2110
		private static readonly IntPtr NativeMethodInfoPtr_EmitThrow_Public_Void_0;

		// Token: 0x0400083F RID: 2111
		private static readonly IntPtr NativeMethodInfoPtr_EmitThrowVoid_Public_Void_0;

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeMethodInfoPtr_EmitRethrow_Public_Void_0;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeMethodInfoPtr_EmitRethrowVoid_Public_Void_0;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterTryFinally_Public_Void_BranchLabel_0;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterTryCatch_Public_Void_0;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterTryFault_Public_EnterTryFaultInstruction_BranchLabel_0;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterFinally_Public_Void_BranchLabel_0;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeMethodInfoPtr_EmitLeaveFinally_Public_Void_0;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterFault_Public_Void_BranchLabel_0;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeMethodInfoPtr_EmitLeaveFault_Public_Void_0;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterExceptionFilter_Public_Void_0;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeMethodInfoPtr_EmitLeaveExceptionFilter_Public_Void_0;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterExceptionHandlerNonVoid_Public_Void_0;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeMethodInfoPtr_EmitEnterExceptionHandlerVoid_Public_Void_0;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeMethodInfoPtr_EmitLeaveExceptionHandler_Public_Void_Boolean_BranchLabel_0;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeMethodInfoPtr_EmitIntSwitch_Public_Void_Dictionary_2_T_Int32_0;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeMethodInfoPtr_EmitStringSwitch_Public_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024F RID: 591
		public sealed class DebugView : Object
		{
			// Token: 0x0600180F RID: 6159 RVA: 0x00009C35 File Offset: 0x00007E35
			// Note: this type is marked as 'beforefieldinit'.
			static DebugView()
			{
				Il2CppClassPointerStore<InstructionList.DebugView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstructionList>.NativeClassPtr, "DebugView");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionList.DebugView>.NativeClassPtr);
				InstructionList.DebugView.NativeMethodInfoPtr_GetInstructionViews_Internal_Static_Il2CppReferenceArray_1_InstructionView_IReadOnlyList_1_Instruction_IReadOnlyList_1_Object_Func_2_Int32_Int32_IReadOnlyList_1_KeyValuePair_2_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList.DebugView>.NativeClassPtr, 100665375);
			}

			// Token: 0x06001810 RID: 6160 RVA: 0x00073BE0 File Offset: 0x00071DE0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1017425, RefRangeEnd = 1017426, XrefRangeStart = 1017377, XrefRangeEnd = 1017425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Il2CppReferenceArray<InstructionList.DebugView.InstructionView> GetInstructionViews(IReadOnlyList<Instruction> instructions, IReadOnlyList<Object> objects, Func<int, int> labelIndexer, IReadOnlyList<KeyValuePair<int, Object>> debugCookies)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(instructions);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labelIndexer);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(debugCookies);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.DebugView.NativeMethodInfoPtr_GetInstructionViews_Internal_Static_Il2CppReferenceArray_1_InstructionView_IReadOnlyList_1_Instruction_IReadOnlyList_1_Object_Func_2_Int32_Int32_IReadOnlyList_1_KeyValuePair_2_Int32_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<InstructionList.DebugView.InstructionView>>(intPtr3) : null;
			}

			// Token: 0x06001811 RID: 6161 RVA: 0x00009C69 File Offset: 0x00007E69
			public DebugView(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04001099 RID: 4249
			private static readonly IntPtr NativeMethodInfoPtr_GetInstructionViews_Internal_Static_Il2CppReferenceArray_1_InstructionView_IReadOnlyList_1_Instruction_IReadOnlyList_1_Object_Func_2_Int32_Int32_IReadOnlyList_1_KeyValuePair_2_Int32_Object_0;

			// Token: 0x02000367 RID: 871
			public sealed class InstructionView : ValueType
			{
				// Token: 0x06001C6B RID: 7275 RVA: 0x00085E08 File Offset: 0x00084008
				// Note: this type is marked as 'beforefieldinit'.
				static InstructionView()
				{
					Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstructionList.DebugView>.NativeClassPtr, "InstructionView");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr);
					InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, "_index");
					InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__stackDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, "_stackDepth");
					InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__continuationsDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, "_continuationsDepth");
					InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, "_name");
					InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, "_instruction");
					InstructionList.DebugView.InstructionView.NativeMethodInfoPtr_GetValue_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, 100665376);
					InstructionList.DebugView.InstructionView.NativeMethodInfoPtr__ctor_Public_Void_Instruction_String_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr, 100665377);
				}

				// Token: 0x06001C6C RID: 7276 RVA: 0x00085EC0 File Offset: 0x000840C0
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string GetValue()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.DebugView.InstructionView.NativeMethodInfoPtr_GetValue_Internal_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06001C6D RID: 7277 RVA: 0x00085EFC File Offset: 0x000840FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017375, XrefRangeEnd = 1017377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe InstructionView(Instruction instruction, string name, int index, int stackDepth, int continuationsDepth)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(instruction);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
					ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref stackDepth;
					ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref continuationsDepth;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstructionList.DebugView.InstructionView.NativeMethodInfoPtr__ctor_Public_Void_Instruction_String_Int32_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06001C6E RID: 7278 RVA: 0x0000AD98 File Offset: 0x00008F98
				public InstructionView(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001C6F RID: 7279 RVA: 0x0000ADA1 File Offset: 0x00008FA1
				public InstructionView()
					: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstructionList.DebugView.InstructionView>.NativeClassPtr))
				{
				}

				// Token: 0x1700072C RID: 1836
				// (get) Token: 0x06001C70 RID: 7280 RVA: 0x00085F88 File Offset: 0x00084188
				// (set) Token: 0x06001C71 RID: 7281 RVA: 0x0000ADB3 File Offset: 0x00008FB3
				public unsafe int _index
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__index);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__index)) = value;
					}
				}

				// Token: 0x1700072D RID: 1837
				// (get) Token: 0x06001C72 RID: 7282 RVA: 0x00085FB0 File Offset: 0x000841B0
				// (set) Token: 0x06001C73 RID: 7283 RVA: 0x0000ADCE File Offset: 0x00008FCE
				public unsafe int _stackDepth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__stackDepth);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__stackDepth)) = value;
					}
				}

				// Token: 0x1700072E RID: 1838
				// (get) Token: 0x06001C74 RID: 7284 RVA: 0x00085FD8 File Offset: 0x000841D8
				// (set) Token: 0x06001C75 RID: 7285 RVA: 0x0000ADE9 File Offset: 0x00008FE9
				public unsafe int _continuationsDepth
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__continuationsDepth);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__continuationsDepth)) = value;
					}
				}

				// Token: 0x1700072F RID: 1839
				// (get) Token: 0x06001C76 RID: 7286 RVA: 0x00086000 File Offset: 0x00084200
				// (set) Token: 0x06001C77 RID: 7287 RVA: 0x0000AE04 File Offset: 0x00009004
				public unsafe string _name
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__name);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__name), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17000730 RID: 1840
				// (get) Token: 0x06001C78 RID: 7288 RVA: 0x00086028 File Offset: 0x00084228
				// (set) Token: 0x06001C79 RID: 7289 RVA: 0x0000AE23 File Offset: 0x00009023
				public unsafe Instruction _instruction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__instruction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstructionList.DebugView.InstructionView.NativeFieldInfoPtr__instruction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400132B RID: 4907
				private static readonly IntPtr NativeFieldInfoPtr__index;

				// Token: 0x0400132C RID: 4908
				private static readonly IntPtr NativeFieldInfoPtr__stackDepth;

				// Token: 0x0400132D RID: 4909
				private static readonly IntPtr NativeFieldInfoPtr__continuationsDepth;

				// Token: 0x0400132E RID: 4910
				private static readonly IntPtr NativeFieldInfoPtr__name;

				// Token: 0x0400132F RID: 4911
				private static readonly IntPtr NativeFieldInfoPtr__instruction;

				// Token: 0x04001330 RID: 4912
				private static readonly IntPtr NativeMethodInfoPtr_GetValue_Internal_String_0;

				// Token: 0x04001331 RID: 4913
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Instruction_String_Int32_Int32_Int32_0;
			}
		}

		// Token: 0x02000250 RID: 592
		private sealed class MethodInfoStoreGeneric_EmitIntSwitch_Public_Void_Dictionary_2_T_Int32_0<T>
		{
			// Token: 0x0400109A RID: 4250
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(InstructionList.NativeMethodInfoPtr_EmitIntSwitch_Public_Void_Dictionary_2_T_Int32_0, Il2CppClassPointerStore<InstructionList>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
