using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000045 RID: 69
	public static class Error : Object
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x000221D4 File Offset: 0x000203D4
		// Note: this type is marked as 'beforefieldinit'.
		static Error()
		{
			Il2CppClassPointerStore<Error>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "Error");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Error>.NativeClassPtr);
			Error.NativeMethodInfoPtr_ReducibleMustOverrideReduce_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664181);
			Error.NativeMethodInfoPtr_InvalidMetaObjectCreated_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664182);
			Error.NativeMethodInfoPtr_AmbiguousMatchInExpandoObject_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664183);
			Error.NativeMethodInfoPtr_SameKeyExistsInExpando_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664184);
			Error.NativeMethodInfoPtr_KeyDoesNotExistInExpando_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664185);
			Error.NativeMethodInfoPtr_CollectionModifiedWhileEnumerating_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664186);
			Error.NativeMethodInfoPtr_CollectionReadOnly_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664187);
			Error.NativeMethodInfoPtr_MustReduceToDifferent_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664188);
			Error.NativeMethodInfoPtr_BinderNotCompatibleWithCallSite_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664189);
			Error.NativeMethodInfoPtr_DynamicBindingNeedsRestrictions_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664190);
			Error.NativeMethodInfoPtr_DynamicObjectResultNotAssignable_Internal_Static_Exception_Object_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664191);
			Error.NativeMethodInfoPtr_DynamicBinderResultNotAssignable_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664192);
			Error.NativeMethodInfoPtr_BindingCannotBeNull_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664193);
			Error.NativeMethodInfoPtr_ReducedNotCompatible_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664194);
			Error.NativeMethodInfoPtr_SetterHasNoParams_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664195);
			Error.NativeMethodInfoPtr_PropertyCannotHaveRefType_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664196);
			Error.NativeMethodInfoPtr_IndexesOfSetGetMustMatch_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664197);
			Error.NativeMethodInfoPtr_TypeParameterIsNotDelegate_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664198);
			Error.NativeMethodInfoPtr_FirstArgumentMustBeCallSite_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664199);
			Error.NativeMethodInfoPtr_AccessorsCannotHaveVarArgs_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664200);
			Error.NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664201);
			Error.NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Internal_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664202);
			Error.NativeMethodInfoPtr_TypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664203);
			Error.NativeMethodInfoPtr_NoOrInvalidRuleProduced_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664204);
			Error.NativeMethodInfoPtr_BoundsCannotBeLessThanOne_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664205);
			Error.NativeMethodInfoPtr_TypeMustNotBeByRef_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664206);
			Error.NativeMethodInfoPtr_TypeMustNotBePointer_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664207);
			Error.NativeMethodInfoPtr_SetterMustBeVoid_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664208);
			Error.NativeMethodInfoPtr_PropertyTypeMustMatchGetter_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664209);
			Error.NativeMethodInfoPtr_PropertyTypeMustMatchSetter_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664210);
			Error.NativeMethodInfoPtr_BothAccessorsMustBeStatic_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664211);
			Error.NativeMethodInfoPtr_OnlyStaticFieldsHaveNullInstance_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664212);
			Error.NativeMethodInfoPtr_OnlyStaticPropertiesHaveNullInstance_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664213);
			Error.NativeMethodInfoPtr_OnlyStaticMethodsHaveNullInstance_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664214);
			Error.NativeMethodInfoPtr_PropertyTypeCannotBeVoid_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664215);
			Error.NativeMethodInfoPtr_InvalidUnboxType_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664216);
			Error.NativeMethodInfoPtr_ExpressionMustBeWriteable_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664217);
			Error.NativeMethodInfoPtr_ArgumentMustNotHaveValueType_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664218);
			Error.NativeMethodInfoPtr_MustBeReducible_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664219);
			Error.NativeMethodInfoPtr_LabelMustBeVoidOrHaveExpression_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664220);
			Error.NativeMethodInfoPtr_LabelTypeMustBeVoid_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664221);
			Error.NativeMethodInfoPtr_QuotedExpressionMustBeLambda_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664222);
			Error.NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664223);
			Error.NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664224);
			Error.NativeMethodInfoPtr_DuplicateVariable_Private_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664225);
			Error.NativeMethodInfoPtr_DuplicateVariable_Internal_Static_Exception_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664226);
			Error.NativeMethodInfoPtr_FaultCannotHaveCatchOrFinally_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664227);
			Error.NativeMethodInfoPtr_TryMustHaveCatchFinallyOrFault_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664228);
			Error.NativeMethodInfoPtr_BodyOfCatchMustHaveSameTypeAsBodyOfTry_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664229);
			Error.NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664230);
			Error.NativeMethodInfoPtr_UserDefinedOperatorMustBeStatic_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664231);
			Error.NativeMethodInfoPtr_UserDefinedOperatorMustNotBeVoid_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664232);
			Error.NativeMethodInfoPtr_CoercionOperatorNotDefined_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664233);
			Error.NativeMethodInfoPtr_UnaryOperatorNotDefined_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664234);
			Error.NativeMethodInfoPtr_BinaryOperatorNotDefined_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664235);
			Error.NativeMethodInfoPtr_ReferenceEqualityNotDefined_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664236);
			Error.NativeMethodInfoPtr_OperandTypesDoNotMatchParameters_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664237);
			Error.NativeMethodInfoPtr_OverloadOperatorTypeDoesNotMatchConversionType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664238);
			Error.NativeMethodInfoPtr_ConversionIsNotSupportedForArithmeticTypes_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664239);
			Error.NativeMethodInfoPtr_ArgumentMustBeArray_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664240);
			Error.NativeMethodInfoPtr_ArgumentMustBeBoolean_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664241);
			Error.NativeMethodInfoPtr_ArgumentMustBeInteger_Private_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664242);
			Error.NativeMethodInfoPtr_ArgumentMustBeInteger_Internal_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664243);
			Error.NativeMethodInfoPtr_ArgumentMustBeArrayIndexType_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664244);
			Error.NativeMethodInfoPtr_ArgumentMustBeSingleDimensionalArrayType_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664245);
			Error.NativeMethodInfoPtr_ArgumentTypesMustMatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664246);
			Error.NativeMethodInfoPtr_CannotAutoInitializeValueTypeMemberThroughProperty_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664247);
			Error.NativeMethodInfoPtr_IncorrectTypeForTypeAs_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664248);
			Error.NativeMethodInfoPtr_CoalesceUsedOnNonNullType_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664249);
			Error.NativeMethodInfoPtr_ExpressionTypeCannotInitializeArrayType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664250);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchReturn_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664251);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchAssignment_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664252);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchLabel_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664253);
			Error.NativeMethodInfoPtr_ExpressionTypeNotInvocable_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664254);
			Error.NativeMethodInfoPtr_InstanceFieldNotDefinedForType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664255);
			Error.NativeMethodInfoPtr_FieldInfoNotDefinedForType_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664256);
			Error.NativeMethodInfoPtr_IncorrectNumberOfIndexes_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664257);
			Error.NativeMethodInfoPtr_IncorrectNumberOfLambdaDeclarationParameters_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664258);
			Error.NativeMethodInfoPtr_LambdaTypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664259);
			Error.NativeMethodInfoPtr_MemberNotFieldOrProperty_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664260);
			Error.NativeMethodInfoPtr_MethodContainsGenericParameters_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664261);
			Error.NativeMethodInfoPtr_MethodIsGeneric_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664262);
			Error.NativeMethodInfoPtr_PropertyDoesNotHaveAccessor_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664263);
			Error.NativeMethodInfoPtr_ParameterExpressionNotValidAsDelegate_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664264);
			Error.NativeMethodInfoPtr_PropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664265);
			Error.NativeMethodInfoPtr_InstancePropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664266);
			Error.NativeMethodInfoPtr_InstanceAndMethodTypeMismatch_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664267);
			Error.NativeMethodInfoPtr_UnhandledBinary_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664268);
			Error.NativeMethodInfoPtr_UnhandledUnary_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664269);
			Error.NativeMethodInfoPtr_UserDefinedOpMustHaveConsistentTypes_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664270);
			Error.NativeMethodInfoPtr_UserDefinedOpMustHaveValidReturnType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664271);
			Error.NativeMethodInfoPtr_LogicalOperatorMustHaveBooleanOperators_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664272);
			Error.NativeMethodInfoPtr_MethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664273);
			Error.NativeMethodInfoPtr_GenericMethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664274);
			Error.NativeMethodInfoPtr_MethodWithMoreThanOneMatch_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664275);
			Error.NativeMethodInfoPtr_ArgumentCannotBeOfTypeVoid_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664276);
			Error.NativeMethodInfoPtr_OutOfRange_Internal_Static_Exception_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664277);
			Error.NativeMethodInfoPtr_LabelTargetAlreadyDefined_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664278);
			Error.NativeMethodInfoPtr_LabelTargetUndefined_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664279);
			Error.NativeMethodInfoPtr_ControlCannotLeaveFinally_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664280);
			Error.NativeMethodInfoPtr_ControlCannotLeaveFilterTest_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664281);
			Error.NativeMethodInfoPtr_AmbiguousJump_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664282);
			Error.NativeMethodInfoPtr_ControlCannotEnterTry_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664283);
			Error.NativeMethodInfoPtr_ControlCannotEnterExpression_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664284);
			Error.NativeMethodInfoPtr_NonLocalJumpWithValue_Internal_Static_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664285);
			Error.NativeMethodInfoPtr_InvalidLvalue_Internal_Static_Exception_ExpressionType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664286);
			Error.NativeMethodInfoPtr_RethrowRequiresCatch_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664287);
			Error.NativeMethodInfoPtr_MustRewriteToSameNode_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664288);
			Error.NativeMethodInfoPtr_MustRewriteChildToSameType_Internal_Static_Exception_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664289);
			Error.NativeMethodInfoPtr_MustRewriteWithoutMethod_Internal_Static_Exception_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664290);
			Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664291);
			Error.NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664292);
			Error.NativeMethodInfoPtr_NonAbstractConstructorRequired_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664293);
			Error.NativeMethodInfoPtr_InvalidProgram_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664294);
			Error.NativeMethodInfoPtr_EnumerationIsDone_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664295);
			Error.NativeMethodInfoPtr_TypeContainsGenericParameters_Private_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664296);
			Error.NativeMethodInfoPtr_TypeContainsGenericParameters_Internal_Static_Exception_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664297);
			Error.NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664298);
			Error.NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664299);
			Error.NativeMethodInfoPtr_IncorrectNumberOfConstructorArguments_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664300);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664301);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664302);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664303);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664304);
			Error.NativeMethodInfoPtr_IncorrectNumberOfLambdaArguments_Internal_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664305);
			Error.NativeMethodInfoPtr_IncorrectNumberOfMethodCallArguments_Internal_Static_Exception_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664306);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664307);
			Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664308);
			Error.NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664309);
			Error.NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664310);
			Error.NativeMethodInfoPtr_InvalidArgumentValue_Internal_Static_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664311);
			Error.NativeMethodInfoPtr_InvalidNullValue_Internal_Static_Exception_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664312);
			Error.NativeMethodInfoPtr_InvalidTypeException_Internal_Static_Exception_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664313);
			Error.NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Error>.NativeClassPtr, 100664314);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00022C7C File Offset: 0x00020E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012226, XrefRangeEnd = 1012232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ReducibleMustOverrideReduce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ReducibleMustOverrideReduce_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00022CB0 File Offset: 0x00020EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012232, XrefRangeEnd = 1012239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidMetaObjectCreated(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidMetaObjectCreated_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00022CF4 File Offset: 0x00020EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012239, XrefRangeEnd = 1012246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AmbiguousMatchInExpandoObject(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_AmbiguousMatchInExpandoObject_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00022D38 File Offset: 0x00020F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012246, XrefRangeEnd = 1012255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception SameKeyExistsInExpando(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_SameKeyExistsInExpando_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00022D7C File Offset: 0x00020F7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012255, XrefRangeEnd = 1012262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception KeyDoesNotExistInExpando(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_KeyDoesNotExistInExpando_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00022DC0 File Offset: 0x00020FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012262, XrefRangeEnd = 1012268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CollectionModifiedWhileEnumerating()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_CollectionModifiedWhileEnumerating_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00022DF4 File Offset: 0x00020FF4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1012274, RefRangeEnd = 1012280, XrefRangeStart = 1012268, XrefRangeEnd = 1012274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CollectionReadOnly()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_CollectionReadOnly_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00022E28 File Offset: 0x00021028
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012286, RefRangeEnd = 1012287, XrefRangeStart = 1012280, XrefRangeEnd = 1012286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MustReduceToDifferent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MustReduceToDifferent_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00022E5C File Offset: 0x0002105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012287, XrefRangeEnd = 1012294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BinderNotCompatibleWithCallSite(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BinderNotCompatibleWithCallSite_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00022EC4 File Offset: 0x000210C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012294, XrefRangeEnd = 1012301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DynamicBindingNeedsRestrictions(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_DynamicBindingNeedsRestrictions_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00022F1C File Offset: 0x0002111C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012301, XrefRangeEnd = 1012306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DynamicObjectResultNotAssignable(Object p0, Object p1, Object p2, Object p3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_DynamicObjectResultNotAssignable_Internal_Static_Exception_Object_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00022F98 File Offset: 0x00021198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012306, XrefRangeEnd = 1012313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DynamicBinderResultNotAssignable(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_DynamicBinderResultNotAssignable_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00023000 File Offset: 0x00021200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012313, XrefRangeEnd = 1012319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BindingCannotBeNull()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BindingCannotBeNull_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00023034 File Offset: 0x00021234
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012325, RefRangeEnd = 1012326, XrefRangeStart = 1012319, XrefRangeEnd = 1012325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ReducedNotCompatible()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ReducedNotCompatible_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00023068 File Offset: 0x00021268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012326, XrefRangeEnd = 1012332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception SetterHasNoParams(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_SetterHasNoParams_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000230AC File Offset: 0x000212AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012332, XrefRangeEnd = 1012338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyCannotHaveRefType(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyCannotHaveRefType_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000230F0 File Offset: 0x000212F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012338, XrefRangeEnd = 1012344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IndexesOfSetGetMustMatch(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IndexesOfSetGetMustMatch_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00023134 File Offset: 0x00021334
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012344, XrefRangeEnd = 1012351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeParameterIsNotDelegate(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeParameterIsNotDelegate_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00023178 File Offset: 0x00021378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012351, XrefRangeEnd = 1012357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FirstArgumentMustBeCallSite()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_FirstArgumentMustBeCallSite_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x000231AC File Offset: 0x000213AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012363, RefRangeEnd = 1012364, XrefRangeStart = 1012357, XrefRangeEnd = 1012363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AccessorsCannotHaveVarArgs(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_AccessorsCannotHaveVarArgs_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000231F0 File Offset: 0x000213F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012364, XrefRangeEnd = 1012370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AccessorsCannotHaveByRefArgs(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Private_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00023234 File Offset: 0x00021434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012370, XrefRangeEnd = 1012377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AccessorsCannotHaveByRefArgs(string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Internal_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00023288 File Offset: 0x00021488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012377, XrefRangeEnd = 1012383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeMustBeDerivedFromSystemDelegate()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x000232BC File Offset: 0x000214BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012383, XrefRangeEnd = 1012389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NoOrInvalidRuleProduced()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NoOrInvalidRuleProduced_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000232F0 File Offset: 0x000214F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012395, RefRangeEnd = 1012396, XrefRangeStart = 1012389, XrefRangeEnd = 1012395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BoundsCannotBeLessThanOne(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BoundsCannotBeLessThanOne_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00023334 File Offset: 0x00021534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012396, XrefRangeEnd = 1012402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeMustNotBeByRef(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeMustNotBeByRef_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00023378 File Offset: 0x00021578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012402, XrefRangeEnd = 1012408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeMustNotBePointer(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeMustNotBePointer_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000233BC File Offset: 0x000215BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012408, XrefRangeEnd = 1012414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception SetterMustBeVoid(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_SetterMustBeVoid_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00023400 File Offset: 0x00021600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012414, XrefRangeEnd = 1012420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyTypeMustMatchGetter(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyTypeMustMatchGetter_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00023444 File Offset: 0x00021644
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012420, XrefRangeEnd = 1012426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyTypeMustMatchSetter(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyTypeMustMatchSetter_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00023488 File Offset: 0x00021688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012426, XrefRangeEnd = 1012432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BothAccessorsMustBeStatic(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BothAccessorsMustBeStatic_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000234CC File Offset: 0x000216CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012438, RefRangeEnd = 1012440, XrefRangeStart = 1012432, XrefRangeEnd = 1012438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OnlyStaticFieldsHaveNullInstance(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OnlyStaticFieldsHaveNullInstance_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00023510 File Offset: 0x00021710
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1012446, RefRangeEnd = 1012450, XrefRangeStart = 1012440, XrefRangeEnd = 1012446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OnlyStaticPropertiesHaveNullInstance(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OnlyStaticPropertiesHaveNullInstance_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00023554 File Offset: 0x00021754
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012456, RefRangeEnd = 1012458, XrefRangeStart = 1012450, XrefRangeEnd = 1012456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OnlyStaticMethodsHaveNullInstance()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OnlyStaticMethodsHaveNullInstance_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00023588 File Offset: 0x00021788
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012458, XrefRangeEnd = 1012464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyTypeCannotBeVoid(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyTypeCannotBeVoid_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000235CC File Offset: 0x000217CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012464, XrefRangeEnd = 1012470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidUnboxType(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidUnboxType_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00023610 File Offset: 0x00021810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012470, XrefRangeEnd = 1012476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionMustBeWriteable(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionMustBeWriteable_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00023654 File Offset: 0x00021854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012476, XrefRangeEnd = 1012482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustNotHaveValueType(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustNotHaveValueType_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00023698 File Offset: 0x00021898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012488, RefRangeEnd = 1012490, XrefRangeStart = 1012482, XrefRangeEnd = 1012488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MustBeReducible()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MustBeReducible_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x000236CC File Offset: 0x000218CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012490, XrefRangeEnd = 1012496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LabelMustBeVoidOrHaveExpression(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LabelMustBeVoidOrHaveExpression_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00023710 File Offset: 0x00021910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012496, XrefRangeEnd = 1012502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LabelTypeMustBeVoid(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LabelTypeMustBeVoid_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00023754 File Offset: 0x00021954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012502, XrefRangeEnd = 1012508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception QuotedExpressionMustBeLambda(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_QuotedExpressionMustBeLambda_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00023798 File Offset: 0x00021998
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012508, XrefRangeEnd = 1012515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception VariableMustNotBeByRef(Object p0, Object p1, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00023800 File Offset: 0x00021A00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012515, XrefRangeEnd = 1012523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception VariableMustNotBeByRef(Object p0, Object p1, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00023878 File Offset: 0x00021A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012523, XrefRangeEnd = 1012530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DuplicateVariable(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_DuplicateVariable_Private_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000238D0 File Offset: 0x00021AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012530, XrefRangeEnd = 1012538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception DuplicateVariable(Object p0, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_DuplicateVariable_Internal_Static_Exception_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00023934 File Offset: 0x00021B34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012538, XrefRangeEnd = 1012544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FaultCannotHaveCatchOrFinally(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_FaultCannotHaveCatchOrFinally_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00023978 File Offset: 0x00021B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012544, XrefRangeEnd = 1012550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TryMustHaveCatchFinallyOrFault()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TryMustHaveCatchFinallyOrFault_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x000239AC File Offset: 0x00021BAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012550, XrefRangeEnd = 1012556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BodyOfCatchMustHaveSameTypeAsBodyOfTry()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BodyOfCatchMustHaveSameTypeAsBodyOfTry_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000239E0 File Offset: 0x00021BE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012556, XrefRangeEnd = 1012563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExtensionNodeMustOverrideProperty(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00023A24 File Offset: 0x00021C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012563, XrefRangeEnd = 1012570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UserDefinedOperatorMustBeStatic(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UserDefinedOperatorMustBeStatic_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00023A7C File Offset: 0x00021C7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012570, XrefRangeEnd = 1012577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UserDefinedOperatorMustNotBeVoid(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UserDefinedOperatorMustNotBeVoid_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00023AD4 File Offset: 0x00021CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012577, XrefRangeEnd = 1012584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CoercionOperatorNotDefined(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_CoercionOperatorNotDefined_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00023B2C File Offset: 0x00021D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012584, XrefRangeEnd = 1012591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnaryOperatorNotDefined(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UnaryOperatorNotDefined_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00023B84 File Offset: 0x00021D84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012591, XrefRangeEnd = 1012598, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception BinaryOperatorNotDefined(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_BinaryOperatorNotDefined_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00023BEC File Offset: 0x00021DEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012598, XrefRangeEnd = 1012605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ReferenceEqualityNotDefined(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ReferenceEqualityNotDefined_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00023C44 File Offset: 0x00021E44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012612, RefRangeEnd = 1012614, XrefRangeStart = 1012605, XrefRangeEnd = 1012612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OperandTypesDoNotMatchParameters(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OperandTypesDoNotMatchParameters_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00023C9C File Offset: 0x00021E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012614, XrefRangeEnd = 1012621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OverloadOperatorTypeDoesNotMatchConversionType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OverloadOperatorTypeDoesNotMatchConversionType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00023CF4 File Offset: 0x00021EF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012621, XrefRangeEnd = 1012627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ConversionIsNotSupportedForArithmeticTypes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ConversionIsNotSupportedForArithmeticTypes_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00023D28 File Offset: 0x00021F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012627, XrefRangeEnd = 1012633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeArray(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeArray_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00023D6C File Offset: 0x00021F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012639, RefRangeEnd = 1012640, XrefRangeStart = 1012633, XrefRangeEnd = 1012639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeBoolean(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeBoolean_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00023DB0 File Offset: 0x00021FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012640, XrefRangeEnd = 1012646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeInteger(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeInteger_Private_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00023DF4 File Offset: 0x00021FF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012653, RefRangeEnd = 1012654, XrefRangeStart = 1012646, XrefRangeEnd = 1012653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeInteger(string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeInteger_Internal_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00023E48 File Offset: 0x00022048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012654, XrefRangeEnd = 1012660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeArrayIndexType(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeArrayIndexType_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00023E8C File Offset: 0x0002208C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012660, XrefRangeEnd = 1012666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentMustBeSingleDimensionalArrayType(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentMustBeSingleDimensionalArrayType_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00023ED0 File Offset: 0x000220D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012672, RefRangeEnd = 1012673, XrefRangeStart = 1012666, XrefRangeEnd = 1012672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentTypesMustMatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentTypesMustMatch_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00023F04 File Offset: 0x00022104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012673, XrefRangeEnd = 1012680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CannotAutoInitializeValueTypeMemberThroughProperty(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_CannotAutoInitializeValueTypeMemberThroughProperty_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00023F48 File Offset: 0x00022148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012680, XrefRangeEnd = 1012687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectTypeForTypeAs(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectTypeForTypeAs_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00023FA0 File Offset: 0x000221A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012687, XrefRangeEnd = 1012693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CoalesceUsedOnNonNullType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_CoalesceUsedOnNonNullType_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00023FD4 File Offset: 0x000221D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012693, XrefRangeEnd = 1012700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeCannotInitializeArrayType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeCannotInitializeArrayType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x0002402C File Offset: 0x0002222C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012700, XrefRangeEnd = 1012707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchReturn(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchReturn_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00024084 File Offset: 0x00022284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012707, XrefRangeEnd = 1012714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchAssignment(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchAssignment_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000240DC File Offset: 0x000222DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012714, XrefRangeEnd = 1012721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchLabel(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchLabel_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00024134 File Offset: 0x00022334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012728, RefRangeEnd = 1012729, XrefRangeStart = 1012721, XrefRangeEnd = 1012728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeNotInvocable(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeNotInvocable_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0002418C File Offset: 0x0002238C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012736, RefRangeEnd = 1012737, XrefRangeStart = 1012729, XrefRangeEnd = 1012736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InstanceFieldNotDefinedForType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InstanceFieldNotDefinedForType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000241E4 File Offset: 0x000223E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012744, RefRangeEnd = 1012745, XrefRangeStart = 1012737, XrefRangeEnd = 1012744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception FieldInfoNotDefinedForType(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_FieldInfoNotDefinedForType_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0002424C File Offset: 0x0002244C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012745, XrefRangeEnd = 1012751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectNumberOfIndexes()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectNumberOfIndexes_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00024280 File Offset: 0x00022480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012751, XrefRangeEnd = 1012757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectNumberOfLambdaDeclarationParameters()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectNumberOfLambdaDeclarationParameters_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000242B4 File Offset: 0x000224B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012757, XrefRangeEnd = 1012763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LambdaTypeMustBeDerivedFromSystemDelegate(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LambdaTypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000242F8 File Offset: 0x000224F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012763, XrefRangeEnd = 1012770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MemberNotFieldOrProperty(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MemberNotFieldOrProperty_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00024350 File Offset: 0x00022550
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012777, RefRangeEnd = 1012779, XrefRangeStart = 1012770, XrefRangeEnd = 1012777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MethodContainsGenericParameters(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MethodContainsGenericParameters_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000243A8 File Offset: 0x000225A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012786, RefRangeEnd = 1012788, XrefRangeStart = 1012779, XrefRangeEnd = 1012786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MethodIsGeneric(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MethodIsGeneric_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00024400 File Offset: 0x00022600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012795, RefRangeEnd = 1012796, XrefRangeStart = 1012788, XrefRangeEnd = 1012795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyDoesNotHaveAccessor(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyDoesNotHaveAccessor_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00024458 File Offset: 0x00022658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012796, XrefRangeEnd = 1012803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ParameterExpressionNotValidAsDelegate(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ParameterExpressionNotValidAsDelegate_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000244B0 File Offset: 0x000226B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012810, RefRangeEnd = 1012811, XrefRangeStart = 1012803, XrefRangeEnd = 1012810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception PropertyNotDefinedForType(Object p0, Object p1, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_PropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00024518 File Offset: 0x00022718
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012818, RefRangeEnd = 1012819, XrefRangeStart = 1012811, XrefRangeEnd = 1012818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InstancePropertyNotDefinedForType(Object p0, Object p1, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InstancePropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00024580 File Offset: 0x00022780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012819, XrefRangeEnd = 1012826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InstanceAndMethodTypeMismatch(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InstanceAndMethodTypeMismatch_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000245E8 File Offset: 0x000227E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012826, XrefRangeEnd = 1012833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnhandledBinary(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UnhandledBinary_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00024640 File Offset: 0x00022840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012833, XrefRangeEnd = 1012840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UnhandledUnary(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UnhandledUnary_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00024698 File Offset: 0x00022898
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012847, RefRangeEnd = 1012849, XrefRangeStart = 1012840, XrefRangeEnd = 1012847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UserDefinedOpMustHaveConsistentTypes(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UserDefinedOpMustHaveConsistentTypes_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000246F0 File Offset: 0x000228F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012849, XrefRangeEnd = 1012856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception UserDefinedOpMustHaveValidReturnType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_UserDefinedOpMustHaveValidReturnType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00024748 File Offset: 0x00022948
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1012863, RefRangeEnd = 1012865, XrefRangeStart = 1012856, XrefRangeEnd = 1012863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LogicalOperatorMustHaveBooleanOperators(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LogicalOperatorMustHaveBooleanOperators_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000247A0 File Offset: 0x000229A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012865, XrefRangeEnd = 1012872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MethodWithArgsDoesNotExistOnType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x000247F8 File Offset: 0x000229F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012872, XrefRangeEnd = 1012879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GenericMethodWithArgsDoesNotExistOnType(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GenericMethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00024850 File Offset: 0x00022A50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012879, XrefRangeEnd = 1012886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MethodWithMoreThanOneMatch(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MethodWithMoreThanOneMatch_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x000248A8 File Offset: 0x00022AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012892, RefRangeEnd = 1012893, XrefRangeStart = 1012886, XrefRangeEnd = 1012892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentCannotBeOfTypeVoid(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentCannotBeOfTypeVoid_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000248EC File Offset: 0x00022AEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012893, XrefRangeEnd = 1012900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception OutOfRange(string paramName, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_OutOfRange_Internal_Static_Exception_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00024944 File Offset: 0x00022B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012900, XrefRangeEnd = 1012907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LabelTargetAlreadyDefined(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LabelTargetAlreadyDefined_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00024988 File Offset: 0x00022B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012907, XrefRangeEnd = 1012914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception LabelTargetUndefined(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_LabelTargetUndefined_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x000249CC File Offset: 0x00022BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012914, XrefRangeEnd = 1012920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ControlCannotLeaveFinally()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ControlCannotLeaveFinally_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00024A00 File Offset: 0x00022C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012920, XrefRangeEnd = 1012926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ControlCannotLeaveFilterTest()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ControlCannotLeaveFilterTest_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00024A34 File Offset: 0x00022C34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012926, XrefRangeEnd = 1012933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception AmbiguousJump(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_AmbiguousJump_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00024A78 File Offset: 0x00022C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012933, XrefRangeEnd = 1012939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ControlCannotEnterTry()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ControlCannotEnterTry_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00024AAC File Offset: 0x00022CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012939, XrefRangeEnd = 1012945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ControlCannotEnterExpression()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ControlCannotEnterExpression_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00024AE0 File Offset: 0x00022CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012945, XrefRangeEnd = 1012952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NonLocalJumpWithValue(Object p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NonLocalJumpWithValue_Internal_Static_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00024B24 File Offset: 0x00022D24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012952, XrefRangeEnd = 1012962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidLvalue(ExpressionType p0)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p0;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidLvalue_Internal_Static_Exception_ExpressionType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00024B64 File Offset: 0x00022D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012968, RefRangeEnd = 1012969, XrefRangeStart = 1012962, XrefRangeEnd = 1012968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception RethrowRequiresCatch()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_RethrowRequiresCatch_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00024B98 File Offset: 0x00022D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012969, XrefRangeEnd = 1012976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MustRewriteToSameNode(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MustRewriteToSameNode_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00024C00 File Offset: 0x00022E00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012976, XrefRangeEnd = 1012983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MustRewriteChildToSameType(Object p0, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MustRewriteChildToSameType_Internal_Static_Exception_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00024C68 File Offset: 0x00022E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012983, XrefRangeEnd = 1012990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception MustRewriteWithoutMethod(Object p0, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_MustRewriteWithoutMethod_Internal_Static_Exception_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00024CC0 File Offset: 0x00022EC0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1012994, RefRangeEnd = 1012997, XrefRangeStart = 1012990, XrefRangeEnd = 1012994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ArgumentOutOfRange(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00024D04 File Offset: 0x00022F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012997, XrefRangeEnd = 1013001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00024D38 File Offset: 0x00022F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013001, XrefRangeEnd = 1013007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception NonAbstractConstructorRequired()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_NonAbstractConstructorRequired_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00024D6C File Offset: 0x00022F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013007, XrefRangeEnd = 1013011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidProgram()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidProgram_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00024DA0 File Offset: 0x00022FA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013011, XrefRangeEnd = 1013017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception EnumerationIsDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_EnumerationIsDone_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00024DD4 File Offset: 0x00022FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013017, XrefRangeEnd = 1013024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeContainsGenericParameters(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeContainsGenericParameters_Private_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00024E2C File Offset: 0x0002302C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013024, XrefRangeEnd = 1013032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeContainsGenericParameters(Object p0, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeContainsGenericParameters_Internal_Static_Exception_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00024E90 File Offset: 0x00023090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013032, XrefRangeEnd = 1013039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeIsGeneric(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00024EE8 File Offset: 0x000230E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013039, XrefRangeEnd = 1013047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception TypeIsGeneric(Object p0, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00024F4C File Offset: 0x0002314C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013047, XrefRangeEnd = 1013053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectNumberOfConstructorArguments()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectNumberOfConstructorArguments_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00024F80 File Offset: 0x00023180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013053, XrefRangeEnd = 1013060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchMethodParameter(Object p0, Object p1, Object p2, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00024FFC File Offset: 0x000231FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013060, XrefRangeEnd = 1013068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchMethodParameter(Object p0, Object p1, Object p2, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00025084 File Offset: 0x00023284
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013068, XrefRangeEnd = 1013075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchParameter(Object p0, Object p1, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000250EC File Offset: 0x000232EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013075, XrefRangeEnd = 1013083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchParameter(Object p0, Object p1, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00025164 File Offset: 0x00023364
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013083, XrefRangeEnd = 1013089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectNumberOfLambdaArguments()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectNumberOfLambdaArguments_Internal_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00025198 File Offset: 0x00023398
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1013096, RefRangeEnd = 1013099, XrefRangeStart = 1013089, XrefRangeEnd = 1013096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception IncorrectNumberOfMethodCallArguments(Object p0, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_IncorrectNumberOfMethodCallArguments_Internal_Static_Exception_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000251F0 File Offset: 0x000233F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013099, XrefRangeEnd = 1013106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchConstructorParameter(Object p0, Object p1, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00025258 File Offset: 0x00023458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013106, XrefRangeEnd = 1013114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionTypeDoesNotMatchConstructorParameter(Object p0, Object p1, string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p0);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000252D0 File Offset: 0x000234D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013114, XrefRangeEnd = 1013120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionMustBeReadable(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00025314 File Offset: 0x00023514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013120, XrefRangeEnd = 1013127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception ExpressionMustBeReadable(string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00025368 File Offset: 0x00023568
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1013133, RefRangeEnd = 1013136, XrefRangeStart = 1013127, XrefRangeEnd = 1013133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidArgumentValue(string paramName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidArgumentValue_Internal_Static_Exception_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000253AC File Offset: 0x000235AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013136, XrefRangeEnd = 1013143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidNullValue(Type type, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidNullValue_Internal_Static_Exception_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00025404 File Offset: 0x00023604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1013143, XrefRangeEnd = 1013153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception InvalidTypeException(Object value, Type type, string paramName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(paramName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_InvalidTypeException_Internal_Static_Exception_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0002546C File Offset: 0x0002366C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 1013155, RefRangeEnd = 1013165, XrefRangeStart = 1013153, XrefRangeEnd = 1013155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetParamName(string paramName, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Error.NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002E4D File Offset: 0x0000104D
		public Error(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002CA RID: 714
		private static readonly IntPtr NativeMethodInfoPtr_ReducibleMustOverrideReduce_Internal_Static_Exception_0;

		// Token: 0x040002CB RID: 715
		private static readonly IntPtr NativeMethodInfoPtr_InvalidMetaObjectCreated_Internal_Static_Exception_Object_0;

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_AmbiguousMatchInExpandoObject_Internal_Static_Exception_Object_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr_SameKeyExistsInExpando_Internal_Static_Exception_Object_0;

		// Token: 0x040002CE RID: 718
		private static readonly IntPtr NativeMethodInfoPtr_KeyDoesNotExistInExpando_Internal_Static_Exception_Object_0;

		// Token: 0x040002CF RID: 719
		private static readonly IntPtr NativeMethodInfoPtr_CollectionModifiedWhileEnumerating_Internal_Static_Exception_0;

		// Token: 0x040002D0 RID: 720
		private static readonly IntPtr NativeMethodInfoPtr_CollectionReadOnly_Internal_Static_Exception_0;

		// Token: 0x040002D1 RID: 721
		private static readonly IntPtr NativeMethodInfoPtr_MustReduceToDifferent_Internal_Static_Exception_0;

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr_BinderNotCompatibleWithCallSite_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_DynamicBindingNeedsRestrictions_Internal_Static_Exception_Object_Object_0;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeMethodInfoPtr_DynamicObjectResultNotAssignable_Internal_Static_Exception_Object_Object_Object_Object_0;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeMethodInfoPtr_DynamicBinderResultNotAssignable_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeMethodInfoPtr_BindingCannotBeNull_Internal_Static_Exception_0;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_ReducedNotCompatible_Internal_Static_Exception_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_SetterHasNoParams_Internal_Static_Exception_String_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_PropertyCannotHaveRefType_Internal_Static_Exception_String_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_IndexesOfSetGetMustMatch_Internal_Static_Exception_String_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_TypeParameterIsNotDelegate_Internal_Static_Exception_Object_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr_FirstArgumentMustBeCallSite_Internal_Static_Exception_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr_AccessorsCannotHaveVarArgs_Internal_Static_Exception_String_0;

		// Token: 0x040002DE RID: 734
		private static readonly IntPtr NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Private_Static_Exception_String_0;

		// Token: 0x040002DF RID: 735
		private static readonly IntPtr NativeMethodInfoPtr_AccessorsCannotHaveByRefArgs_Internal_Static_Exception_String_Int32_0;

		// Token: 0x040002E0 RID: 736
		private static readonly IntPtr NativeMethodInfoPtr_TypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_0;

		// Token: 0x040002E1 RID: 737
		private static readonly IntPtr NativeMethodInfoPtr_NoOrInvalidRuleProduced_Internal_Static_Exception_0;

		// Token: 0x040002E2 RID: 738
		private static readonly IntPtr NativeMethodInfoPtr_BoundsCannotBeLessThanOne_Internal_Static_Exception_String_0;

		// Token: 0x040002E3 RID: 739
		private static readonly IntPtr NativeMethodInfoPtr_TypeMustNotBeByRef_Internal_Static_Exception_String_0;

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr NativeMethodInfoPtr_TypeMustNotBePointer_Internal_Static_Exception_String_0;

		// Token: 0x040002E5 RID: 741
		private static readonly IntPtr NativeMethodInfoPtr_SetterMustBeVoid_Internal_Static_Exception_String_0;

		// Token: 0x040002E6 RID: 742
		private static readonly IntPtr NativeMethodInfoPtr_PropertyTypeMustMatchGetter_Internal_Static_Exception_String_0;

		// Token: 0x040002E7 RID: 743
		private static readonly IntPtr NativeMethodInfoPtr_PropertyTypeMustMatchSetter_Internal_Static_Exception_String_0;

		// Token: 0x040002E8 RID: 744
		private static readonly IntPtr NativeMethodInfoPtr_BothAccessorsMustBeStatic_Internal_Static_Exception_String_0;

		// Token: 0x040002E9 RID: 745
		private static readonly IntPtr NativeMethodInfoPtr_OnlyStaticFieldsHaveNullInstance_Internal_Static_Exception_String_0;

		// Token: 0x040002EA RID: 746
		private static readonly IntPtr NativeMethodInfoPtr_OnlyStaticPropertiesHaveNullInstance_Internal_Static_Exception_String_0;

		// Token: 0x040002EB RID: 747
		private static readonly IntPtr NativeMethodInfoPtr_OnlyStaticMethodsHaveNullInstance_Internal_Static_Exception_0;

		// Token: 0x040002EC RID: 748
		private static readonly IntPtr NativeMethodInfoPtr_PropertyTypeCannotBeVoid_Internal_Static_Exception_String_0;

		// Token: 0x040002ED RID: 749
		private static readonly IntPtr NativeMethodInfoPtr_InvalidUnboxType_Internal_Static_Exception_String_0;

		// Token: 0x040002EE RID: 750
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionMustBeWriteable_Internal_Static_Exception_String_0;

		// Token: 0x040002EF RID: 751
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustNotHaveValueType_Internal_Static_Exception_String_0;

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeMethodInfoPtr_MustBeReducible_Internal_Static_Exception_0;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeMethodInfoPtr_LabelMustBeVoidOrHaveExpression_Internal_Static_Exception_String_0;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeMethodInfoPtr_LabelTypeMustBeVoid_Internal_Static_Exception_String_0;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_QuotedExpressionMustBeLambda_Internal_Static_Exception_String_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_VariableMustNotBeByRef_Internal_Static_Exception_Object_Object_String_Int32_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateVariable_Private_Static_Exception_Object_String_0;

		// Token: 0x040002F7 RID: 759
		private static readonly IntPtr NativeMethodInfoPtr_DuplicateVariable_Internal_Static_Exception_Object_String_Int32_0;

		// Token: 0x040002F8 RID: 760
		private static readonly IntPtr NativeMethodInfoPtr_FaultCannotHaveCatchOrFinally_Internal_Static_Exception_String_0;

		// Token: 0x040002F9 RID: 761
		private static readonly IntPtr NativeMethodInfoPtr_TryMustHaveCatchFinallyOrFault_Internal_Static_Exception_0;

		// Token: 0x040002FA RID: 762
		private static readonly IntPtr NativeMethodInfoPtr_BodyOfCatchMustHaveSameTypeAsBodyOfTry_Internal_Static_Exception_0;

		// Token: 0x040002FB RID: 763
		private static readonly IntPtr NativeMethodInfoPtr_ExtensionNodeMustOverrideProperty_Internal_Static_Exception_Object_0;

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeMethodInfoPtr_UserDefinedOperatorMustBeStatic_Internal_Static_Exception_Object_String_0;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr_UserDefinedOperatorMustNotBeVoid_Internal_Static_Exception_Object_String_0;

		// Token: 0x040002FE RID: 766
		private static readonly IntPtr NativeMethodInfoPtr_CoercionOperatorNotDefined_Internal_Static_Exception_Object_Object_0;

		// Token: 0x040002FF RID: 767
		private static readonly IntPtr NativeMethodInfoPtr_UnaryOperatorNotDefined_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000300 RID: 768
		private static readonly IntPtr NativeMethodInfoPtr_BinaryOperatorNotDefined_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeMethodInfoPtr_ReferenceEqualityNotDefined_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr_OperandTypesDoNotMatchParameters_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr_OverloadOperatorTypeDoesNotMatchConversionType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr_ConversionIsNotSupportedForArithmeticTypes_Internal_Static_Exception_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeArray_Internal_Static_Exception_String_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeBoolean_Internal_Static_Exception_String_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeInteger_Private_Static_Exception_String_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeInteger_Internal_Static_Exception_String_Int32_0;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeArrayIndexType_Internal_Static_Exception_String_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentMustBeSingleDimensionalArrayType_Internal_Static_Exception_String_0;

		// Token: 0x0400030B RID: 779
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentTypesMustMatch_Internal_Static_Exception_0;

		// Token: 0x0400030C RID: 780
		private static readonly IntPtr NativeMethodInfoPtr_CannotAutoInitializeValueTypeMemberThroughProperty_Internal_Static_Exception_Object_0;

		// Token: 0x0400030D RID: 781
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectTypeForTypeAs_Internal_Static_Exception_Object_String_0;

		// Token: 0x0400030E RID: 782
		private static readonly IntPtr NativeMethodInfoPtr_CoalesceUsedOnNonNullType_Internal_Static_Exception_0;

		// Token: 0x0400030F RID: 783
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeCannotInitializeArrayType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000310 RID: 784
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchReturn_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000311 RID: 785
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchAssignment_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000312 RID: 786
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchLabel_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000313 RID: 787
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeNotInvocable_Internal_Static_Exception_Object_String_0;

		// Token: 0x04000314 RID: 788
		private static readonly IntPtr NativeMethodInfoPtr_InstanceFieldNotDefinedForType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeMethodInfoPtr_FieldInfoNotDefinedForType_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectNumberOfIndexes_Internal_Static_Exception_0;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectNumberOfLambdaDeclarationParameters_Internal_Static_Exception_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_LambdaTypeMustBeDerivedFromSystemDelegate_Internal_Static_Exception_String_0;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeMethodInfoPtr_MemberNotFieldOrProperty_Internal_Static_Exception_Object_String_0;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeMethodInfoPtr_MethodContainsGenericParameters_Internal_Static_Exception_Object_String_0;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeMethodInfoPtr_MethodIsGeneric_Internal_Static_Exception_Object_String_0;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeMethodInfoPtr_PropertyDoesNotHaveAccessor_Internal_Static_Exception_Object_String_0;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeMethodInfoPtr_ParameterExpressionNotValidAsDelegate_Internal_Static_Exception_Object_Object_0;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeMethodInfoPtr_InstancePropertyNotDefinedForType_Internal_Static_Exception_Object_Object_String_0;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeMethodInfoPtr_InstanceAndMethodTypeMismatch_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_UnhandledBinary_Internal_Static_Exception_Object_String_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_UnhandledUnary_Internal_Static_Exception_Object_String_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_UserDefinedOpMustHaveConsistentTypes_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr_UserDefinedOpMustHaveValidReturnType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeMethodInfoPtr_LogicalOperatorMustHaveBooleanOperators_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeMethodInfoPtr_MethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeMethodInfoPtr_GenericMethodWithArgsDoesNotExistOnType_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeMethodInfoPtr_MethodWithMoreThanOneMatch_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentCannotBeOfTypeVoid_Internal_Static_Exception_String_0;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeMethodInfoPtr_OutOfRange_Internal_Static_Exception_String_Object_0;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_LabelTargetAlreadyDefined_Internal_Static_Exception_Object_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_LabelTargetUndefined_Internal_Static_Exception_Object_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_ControlCannotLeaveFinally_Internal_Static_Exception_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_ControlCannotLeaveFilterTest_Internal_Static_Exception_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_AmbiguousJump_Internal_Static_Exception_Object_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr_ControlCannotEnterTry_Internal_Static_Exception_0;

		// Token: 0x04000331 RID: 817
		private static readonly IntPtr NativeMethodInfoPtr_ControlCannotEnterExpression_Internal_Static_Exception_0;

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr_NonLocalJumpWithValue_Internal_Static_Exception_Object_0;

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeMethodInfoPtr_InvalidLvalue_Internal_Static_Exception_ExpressionType_0;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr_RethrowRequiresCatch_Internal_Static_Exception_0;

		// Token: 0x04000335 RID: 821
		private static readonly IntPtr NativeMethodInfoPtr_MustRewriteToSameNode_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x04000336 RID: 822
		private static readonly IntPtr NativeMethodInfoPtr_MustRewriteChildToSameType_Internal_Static_Exception_Object_Object_Object_0;

		// Token: 0x04000337 RID: 823
		private static readonly IntPtr NativeMethodInfoPtr_MustRewriteWithoutMethod_Internal_Static_Exception_Object_Object_0;

		// Token: 0x04000338 RID: 824
		private static readonly IntPtr NativeMethodInfoPtr_ArgumentOutOfRange_Internal_Static_Exception_String_0;

		// Token: 0x04000339 RID: 825
		private static readonly IntPtr NativeMethodInfoPtr_NotSupported_Internal_Static_Exception_0;

		// Token: 0x0400033A RID: 826
		private static readonly IntPtr NativeMethodInfoPtr_NonAbstractConstructorRequired_Internal_Static_Exception_0;

		// Token: 0x0400033B RID: 827
		private static readonly IntPtr NativeMethodInfoPtr_InvalidProgram_Internal_Static_Exception_0;

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeMethodInfoPtr_EnumerationIsDone_Internal_Static_Exception_0;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr_TypeContainsGenericParameters_Private_Static_Exception_Object_String_0;

		// Token: 0x0400033E RID: 830
		private static readonly IntPtr NativeMethodInfoPtr_TypeContainsGenericParameters_Internal_Static_Exception_Object_String_Int32_0;

		// Token: 0x0400033F RID: 831
		private static readonly IntPtr NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_0;

		// Token: 0x04000340 RID: 832
		private static readonly IntPtr NativeMethodInfoPtr_TypeIsGeneric_Internal_Static_Exception_Object_String_Int32_0;

		// Token: 0x04000341 RID: 833
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectNumberOfConstructorArguments_Internal_Static_Exception_0;

		// Token: 0x04000342 RID: 834
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_0;

		// Token: 0x04000343 RID: 835
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchMethodParameter_Internal_Static_Exception_Object_Object_Object_String_Int32_0;

		// Token: 0x04000344 RID: 836
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_0;

		// Token: 0x04000345 RID: 837
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchParameter_Internal_Static_Exception_Object_Object_String_Int32_0;

		// Token: 0x04000346 RID: 838
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectNumberOfLambdaArguments_Internal_Static_Exception_0;

		// Token: 0x04000347 RID: 839
		private static readonly IntPtr NativeMethodInfoPtr_IncorrectNumberOfMethodCallArguments_Internal_Static_Exception_Object_String_0;

		// Token: 0x04000348 RID: 840
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_0;

		// Token: 0x04000349 RID: 841
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionTypeDoesNotMatchConstructorParameter_Internal_Static_Exception_Object_Object_String_Int32_0;

		// Token: 0x0400034A RID: 842
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_0;

		// Token: 0x0400034B RID: 843
		private static readonly IntPtr NativeMethodInfoPtr_ExpressionMustBeReadable_Internal_Static_Exception_String_Int32_0;

		// Token: 0x0400034C RID: 844
		private static readonly IntPtr NativeMethodInfoPtr_InvalidArgumentValue_Internal_Static_Exception_String_0;

		// Token: 0x0400034D RID: 845
		private static readonly IntPtr NativeMethodInfoPtr_InvalidNullValue_Internal_Static_Exception_Type_String_0;

		// Token: 0x0400034E RID: 846
		private static readonly IntPtr NativeMethodInfoPtr_InvalidTypeException_Internal_Static_Exception_Object_Type_String_0;

		// Token: 0x0400034F RID: 847
		private static readonly IntPtr NativeMethodInfoPtr_GetParamName_Private_Static_String_String_Int32_0;
	}
}
