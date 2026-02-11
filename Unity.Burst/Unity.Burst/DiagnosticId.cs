using System;

namespace Unity.Burst
{
	// Token: 0x02000012 RID: 18
	public enum DiagnosticId
	{
		// Token: 0x04000169 RID: 361
		ERR_InternalCompilerErrorInBackend = 100,
		// Token: 0x0400016A RID: 362
		ERR_InternalCompilerErrorInFunction,
		// Token: 0x0400016B RID: 363
		ERR_InternalCompilerErrorInInstruction,
		// Token: 0x0400016C RID: 364
		ERR_OnlyStaticMethodsAllowed = 1000,
		// Token: 0x0400016D RID: 365
		ERR_UnableToAccessManagedMethod,
		// Token: 0x0400016E RID: 366
		ERR_UnableToFindInterfaceMethod,
		// Token: 0x0400016F RID: 367
		ERR_UnexpectedEmptyMethodBody,
		// Token: 0x04000170 RID: 368
		ERR_ManagedArgumentsNotSupported,
		// Token: 0x04000171 RID: 369
		ERR_CatchConstructionNotSupported = 1006,
		// Token: 0x04000172 RID: 370
		ERR_CatchAndFilterConstructionNotSupported,
		// Token: 0x04000173 RID: 371
		ERR_LdfldaWithFixedArrayExpected,
		// Token: 0x04000174 RID: 372
		ERR_PointerExpected,
		// Token: 0x04000175 RID: 373
		ERR_LoadingFieldFromManagedObjectNotSupported,
		// Token: 0x04000176 RID: 374
		ERR_LoadingFieldWithManagedTypeNotSupported,
		// Token: 0x04000177 RID: 375
		ERR_LoadingArgumentWithManagedTypeNotSupported,
		// Token: 0x04000178 RID: 376
		ERR_CallingBurstDiscardMethodWithReturnValueNotSupported = 1015,
		// Token: 0x04000179 RID: 377
		ERR_CallingManagedMethodNotSupported,
		// Token: 0x0400017A RID: 378
		ERR_InstructionUnboxNotSupported = 1019,
		// Token: 0x0400017B RID: 379
		ERR_InstructionBoxNotSupported,
		// Token: 0x0400017C RID: 380
		ERR_InstructionNewobjWithManagedTypeNotSupported,
		// Token: 0x0400017D RID: 381
		ERR_AccessingManagedArrayNotSupported,
		// Token: 0x0400017E RID: 382
		ERR_InstructionLdtokenFieldNotSupported,
		// Token: 0x0400017F RID: 383
		ERR_InstructionLdtokenMethodNotSupported,
		// Token: 0x04000180 RID: 384
		ERR_InstructionLdtokenTypeNotSupported,
		// Token: 0x04000181 RID: 385
		ERR_InstructionLdtokenNotSupported,
		// Token: 0x04000182 RID: 386
		ERR_InstructionLdvirtftnNotSupported,
		// Token: 0x04000183 RID: 387
		ERR_InstructionNewarrNotSupported,
		// Token: 0x04000184 RID: 388
		ERR_InstructionRethrowNotSupported,
		// Token: 0x04000185 RID: 389
		ERR_InstructionCastclassNotSupported,
		// Token: 0x04000186 RID: 390
		ERR_InstructionLdftnNotSupported = 1032,
		// Token: 0x04000187 RID: 391
		ERR_InstructionLdstrNotSupported,
		// Token: 0x04000188 RID: 392
		ERR_InstructionStsfldNotSupported,
		// Token: 0x04000189 RID: 393
		ERR_InstructionEndfilterNotSupported,
		// Token: 0x0400018A RID: 394
		ERR_InstructionEndfinallyNotSupported,
		// Token: 0x0400018B RID: 395
		ERR_InstructionLeaveNotSupported,
		// Token: 0x0400018C RID: 396
		ERR_InstructionNotSupported,
		// Token: 0x0400018D RID: 397
		ERR_LoadingFromStaticFieldNotSupported,
		// Token: 0x0400018E RID: 398
		ERR_LoadingFromNonReadonlyStaticFieldNotSupported,
		// Token: 0x0400018F RID: 399
		ERR_LoadingFromManagedStaticFieldNotSupported,
		// Token: 0x04000190 RID: 400
		ERR_LoadingFromManagedNonReadonlyStaticFieldNotSupported,
		// Token: 0x04000191 RID: 401
		ERR_InstructionStfldToManagedObjectNotSupported,
		// Token: 0x04000192 RID: 402
		ERR_InstructionLdlenNonConstantLengthNotSupported,
		// Token: 0x04000193 RID: 403
		ERR_StructWithAutoLayoutNotSupported,
		// Token: 0x04000194 RID: 404
		ERR_StructWithGenericParametersAndExplicitLayoutNotSupported = 1047,
		// Token: 0x04000195 RID: 405
		ERR_StructSizeNotSupported,
		// Token: 0x04000196 RID: 406
		ERR_StructZeroSizeNotSupported,
		// Token: 0x04000197 RID: 407
		ERR_MarshalAsOnFieldNotSupported,
		// Token: 0x04000198 RID: 408
		ERR_TypeNotSupported,
		// Token: 0x04000199 RID: 409
		ERR_RequiredTypeModifierNotSupported,
		// Token: 0x0400019A RID: 410
		ERR_ErrorWhileProcessingVariable,
		// Token: 0x0400019B RID: 411
		ERR_UnableToResolveType,
		// Token: 0x0400019C RID: 412
		ERR_UnableToResolveMethod,
		// Token: 0x0400019D RID: 413
		ERR_ConstructorNotSupported,
		// Token: 0x0400019E RID: 414
		ERR_FunctionPointerMethodMissingBurstCompileAttribute,
		// Token: 0x0400019F RID: 415
		ERR_FunctionPointerTypeMissingBurstCompileAttribute,
		// Token: 0x040001A0 RID: 416
		ERR_FunctionPointerMethodAndTypeMissingBurstCompileAttribute,
		// Token: 0x040001A1 RID: 417
		INF_FunctionPointerMethodAndTypeMissingMonoPInvokeCallbackAttribute = 10590,
		// Token: 0x040001A2 RID: 418
		ERR_MarshalAsOnParameterNotSupported = 1061,
		// Token: 0x040001A3 RID: 419
		ERR_MarshalAsOnReturnTypeNotSupported,
		// Token: 0x040001A4 RID: 420
		ERR_TypeNotBlittableForFunctionPointer,
		// Token: 0x040001A5 RID: 421
		ERR_StructByValueNotSupported,
		// Token: 0x040001A6 RID: 422
		ERR_StructsWithNonUnicodeCharsNotSupported = 1066,
		// Token: 0x040001A7 RID: 423
		ERR_VectorsByValueNotSupported,
		// Token: 0x040001A8 RID: 424
		ERR_MissingExternBindings,
		// Token: 0x040001A9 RID: 425
		ERR_MarshalAsNativeTypeOnReturnTypeNotSupported,
		// Token: 0x040001AA RID: 426
		ERR_AssertTypeNotSupported = 1071,
		// Token: 0x040001AB RID: 427
		ERR_StoringToReadOnlyFieldNotAllowed,
		// Token: 0x040001AC RID: 428
		ERR_StoringToFieldInReadOnlyParameterNotAllowed,
		// Token: 0x040001AD RID: 429
		ERR_StoringToReadOnlyParameterNotAllowed,
		// Token: 0x040001AE RID: 430
		ERR_TypeManagerStaticFieldNotCompatible,
		// Token: 0x040001AF RID: 431
		ERR_UnableToFindTypeIndexForTypeManagerType,
		// Token: 0x040001B0 RID: 432
		ERR_UnableToFindFieldForTypeManager,
		// Token: 0x040001B1 RID: 433
		ERR_CircularStaticConstructorUsage = 1090,
		// Token: 0x040001B2 RID: 434
		ERR_ExternalInternalCallsInStaticConstructorsNotSupported,
		// Token: 0x040001B3 RID: 435
		ERR_PlatformNotSupported,
		// Token: 0x040001B4 RID: 436
		ERR_InitModuleVerificationError,
		// Token: 0x040001B5 RID: 437
		ERR_ModuleVerificationError,
		// Token: 0x040001B6 RID: 438
		ERR_UnableToFindTypeRequiredForTypeManager,
		// Token: 0x040001B7 RID: 439
		ERR_UnexpectedIntegerTypesForBinaryOperation,
		// Token: 0x040001B8 RID: 440
		ERR_BinaryOperationNotSupported,
		// Token: 0x040001B9 RID: 441
		ERR_CalliWithThisNotSupported,
		// Token: 0x040001BA RID: 442
		ERR_CalliNonCCallingConventionNotSupported,
		// Token: 0x040001BB RID: 443
		ERR_StringLiteralTooBig,
		// Token: 0x040001BC RID: 444
		ERR_LdftnNonCCallingConventionNotSupported,
		// Token: 0x040001BD RID: 445
		ERR_UnableToCallMethodOnInterfaceObject,
		// Token: 0x040001BE RID: 446
		ERR_UnsupportedCpuDependentBranch = 1199,
		// Token: 0x040001BF RID: 447
		ERR_InstructionTargetCpuFeatureNotAllowedInThisBlock,
		// Token: 0x040001C0 RID: 448
		ERR_AssumeRangeTypeMustBeInteger,
		// Token: 0x040001C1 RID: 449
		ERR_AssumeRangeTypeMustBeSameSign,
		// Token: 0x040001C2 RID: 450
		ERR_UnsupportedSpillTransform = 1300,
		// Token: 0x040001C3 RID: 451
		ERR_UnsupportedSpillTransformTooManyUsers,
		// Token: 0x040001C4 RID: 452
		ERR_MethodNotSupported,
		// Token: 0x040001C5 RID: 453
		ERR_VectorsLoadFieldIsAddress,
		// Token: 0x040001C6 RID: 454
		ERR_ConstantExpressionRequired,
		// Token: 0x040001C7 RID: 455
		ERR_PointerArgumentsUnexpectedAliasing = 1310,
		// Token: 0x040001C8 RID: 456
		ERR_LoopIntrinsicMustBeCalledInsideLoop = 1320,
		// Token: 0x040001C9 RID: 457
		ERR_LoopUnexpectedAutoVectorization,
		// Token: 0x040001CA RID: 458
		WRN_LoopIntrinsicCalledButLoopOptimizedAway,
		// Token: 0x040001CB RID: 459
		ERR_AssertArgTypesDiffer = 1330,
		// Token: 0x040001CC RID: 460
		ERR_StringInternalCompilerFixedStringTooManyUsers = 1340,
		// Token: 0x040001CD RID: 461
		ERR_StringInvalidFormatMissingClosingBrace,
		// Token: 0x040001CE RID: 462
		ERR_StringInvalidIntegerForArgumentIndex,
		// Token: 0x040001CF RID: 463
		ERR_StringInvalidFormatForArgument,
		// Token: 0x040001D0 RID: 464
		ERR_StringArgumentIndexOutOfRange,
		// Token: 0x040001D1 RID: 465
		ERR_StringInvalidArgumentType,
		// Token: 0x040001D2 RID: 466
		ERR_DebugLogNotSupported,
		// Token: 0x040001D3 RID: 467
		ERR_StringInvalidNonLiteralFormat,
		// Token: 0x040001D4 RID: 468
		ERR_StringInvalidStringFormatMethod,
		// Token: 0x040001D5 RID: 469
		ERR_StringInvalidArgument,
		// Token: 0x040001D6 RID: 470
		ERR_StringArrayInvalidArrayCreation,
		// Token: 0x040001D7 RID: 471
		ERR_StringArrayInvalidArraySize,
		// Token: 0x040001D8 RID: 472
		ERR_StringArrayInvalidControlFlow,
		// Token: 0x040001D9 RID: 473
		ERR_StringArrayInvalidArrayIndex,
		// Token: 0x040001DA RID: 474
		ERR_StringArrayInvalidArrayIndexOutOfRange,
		// Token: 0x040001DB RID: 475
		ERR_UnmanagedStringMethodMissing,
		// Token: 0x040001DC RID: 476
		ERR_UnmanagedStringMethodInvalid,
		// Token: 0x040001DD RID: 477
		ERR_ManagedStaticConstructor = 1360,
		// Token: 0x040001DE RID: 478
		ERR_StaticConstantArrayInStaticConstructor,
		// Token: 0x040001DF RID: 479
		WRN_ExceptionThrownInNonSafetyCheckGuardedFunction = 1370,
		// Token: 0x040001E0 RID: 480
		WRN_ACallToMethodHasBeenDiscarded,
		// Token: 0x040001E1 RID: 481
		ERR_AccessingNestedManagedArrayNotSupported = 1380,
		// Token: 0x040001E2 RID: 482
		ERR_LdobjFromANonPointerNonReference,
		// Token: 0x040001E3 RID: 483
		ERR_StringLiteralRequired,
		// Token: 0x040001E4 RID: 484
		ERR_MultiDimensionalArrayUnsupported,
		// Token: 0x040001E5 RID: 485
		ERR_NonBlittableAndNonManagedSequentialStructNotSupported,
		// Token: 0x040001E6 RID: 486
		ERR_VarArgFunctionNotSupported
	}
}
