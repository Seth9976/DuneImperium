using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000119 RID: 281
	public static class ThrowHelper : Object
	{
		// Token: 0x06001269 RID: 4713 RVA: 0x0007E5C4 File Offset: 0x0007C7C4
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowHelper()
		{
			Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ThrowHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666501);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666502);
			ThrowHelper.NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666503);
			ThrowHelper.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666504);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666505);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666506);
			ThrowHelper.NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666507);
			ThrowHelper.NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666508);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666509);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666510);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666511);
			ThrowHelper.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666512);
			ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666513);
			ThrowHelper.NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666514);
			ThrowHelper.NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666515);
			ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666516);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666517);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666518);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666519);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666520);
			ThrowHelper.NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666521);
			ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666522);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666523);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666524);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666525);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666526);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666527);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666528);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666529);
			ThrowHelper.NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666530);
			ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666531);
			ThrowHelper.NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666532);
			ThrowHelper.NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666533);
			ThrowHelper.NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666534);
			ThrowHelper.NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666535);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666536);
			ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666537);
			ThrowHelper.NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666538);
			ThrowHelper.NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666539);
			ThrowHelper.NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666540);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666541);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666542);
			ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666543);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666544);
			ThrowHelper.NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666545);
			ThrowHelper.NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666546);
			ThrowHelper.NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666547);
			ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100666548);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x0007E9B4 File Offset: 0x0007CBB4
		[CallerCount(97)]
		[CachedScanResults(RefRangeStart = 1333776, RefRangeEnd = 1333873, XrefRangeStart = 1333773, XrefRangeEnd = 1333776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333880, RefRangeEnd = 1333881, XrefRangeStart = 1333873, XrefRangeEnd = 1333880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0007EA28 File Offset: 0x0007CC28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333884, RefRangeEnd = 1333885, XrefRangeStart = 1333881, XrefRangeEnd = 1333884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArrayTypeMismatchException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0007EA50 File Offset: 0x0007CC50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333889, RefRangeEnd = 1333890, XrefRangeStart = 1333885, XrefRangeEnd = 1333889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArrayTypeMismatchException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0007EA84 File Offset: 0x0007CC84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1333893, RefRangeEnd = 1333896, XrefRangeStart = 1333890, XrefRangeEnd = 1333893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException_DestinationTooShort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0007EAAC File Offset: 0x0007CCAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333902, RefRangeEnd = 1333903, XrefRangeStart = 1333896, XrefRangeEnd = 1333902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentException_DestinationTooShort()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0007EAE0 File Offset: 0x0007CCE0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1333906, RefRangeEnd = 1333920, XrefRangeStart = 1333903, XrefRangeEnd = 1333906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIndexOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0007EB08 File Offset: 0x0007CD08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1333924, RefRangeEnd = 1333925, XrefRangeStart = 1333920, XrefRangeEnd = 1333924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateIndexOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0007EB3C File Offset: 0x0007CD3C
		[CallerCount(241)]
		[CachedScanResults(RefRangeStart = 1333928, RefRangeEnd = 1334169, XrefRangeStart = 1333925, XrefRangeEnd = 1333928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0007EB64 File Offset: 0x0007CD64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334173, RefRangeEnd = 1334174, XrefRangeStart = 1334169, XrefRangeEnd = 1334173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentOutOfRangeException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0007EB98 File Offset: 0x0007CD98
		[CallerCount(32)]
		[CachedScanResults(RefRangeStart = 1334177, RefRangeEnd = 1334209, XrefRangeStart = 1334174, XrefRangeEnd = 1334177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0007EBCC File Offset: 0x0007CDCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334216, RefRangeEnd = 1334217, XrefRangeStart = 1334209, XrefRangeEnd = 1334216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateArgumentOutOfRangeException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0007EC0C File Offset: 0x0007CE0C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1334220, RefRangeEnd = 1334225, XrefRangeStart = 1334217, XrefRangeEnd = 1334220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0007EC34 File Offset: 0x0007CE34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334229, RefRangeEnd = 1334230, XrefRangeStart = 1334225, XrefRangeEnd = 1334229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception CreateThrowNotSupportedException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0007EC68 File Offset: 0x0007CE68
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334246, RefRangeEnd = 1334248, XrefRangeStart = 1334230, XrefRangeEnd = 1334246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowWrongKeyTypeArgumentException(Object key, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0007ECB0 File Offset: 0x0007CEB0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1334264, RefRangeEnd = 1334272, XrefRangeStart = 1334248, XrefRangeEnd = 1334264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowWrongValueTypeArgumentException(Object value, Type targetType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0007ECF8 File Offset: 0x0007CEF8
		[CallerCount(46)]
		[CachedScanResults(RefRangeStart = 1334279, RefRangeEnd = 1334325, XrefRangeStart = 1334272, XrefRangeEnd = 1334279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0007ED2C File Offset: 0x0007CF2C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1334333, RefRangeEnd = 1334340, XrefRangeStart = 1334325, XrefRangeEnd = 1334333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException(ExceptionResource resource, ExceptionArgument argument)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argument;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0007ED6C File Offset: 0x0007CF6C
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 1334357, RefRangeEnd = 1334383, XrefRangeStart = 1334340, XrefRangeEnd = 1334357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0007EDAC File Offset: 0x0007CFAC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1334390, RefRangeEnd = 1334405, XrefRangeStart = 1334383, XrefRangeEnd = 1334390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334405, XrefRangeEnd = 1334412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowSerializationException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0007EE14 File Offset: 0x0007D014
		[CallerCount(33)]
		[CachedScanResults(RefRangeStart = 1334419, RefRangeEnd = 1334452, XrefRangeStart = 1334412, XrefRangeEnd = 1334419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNotSupportedException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0007EE48 File Offset: 0x0007D048
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1334458, RefRangeEnd = 1334475, XrefRangeStart = 1334452, XrefRangeEnd = 1334458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0007EE70 File Offset: 0x0007D070
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1334481, RefRangeEnd = 1334494, XrefRangeStart = 1334475, XrefRangeEnd = 1334481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0007EE98 File Offset: 0x0007D098
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334500, RefRangeEnd = 1334502, XrefRangeStart = 1334494, XrefRangeEnd = 1334500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumNotStarted()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x0007EEC0 File Offset: 0x0007D0C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334508, RefRangeEnd = 1334510, XrefRangeStart = 1334502, XrefRangeEnd = 1334508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_InvalidOperation_EnumEnded()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0007EEE8 File Offset: 0x0007D0E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334516, RefRangeEnd = 1334517, XrefRangeStart = 1334510, XrefRangeEnd = 1334516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_InvalidOperation_NoValue()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x0007EF10 File Offset: 0x0007D110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334522, RefRangeEnd = 1334524, XrefRangeStart = 1334517, XrefRangeEnd = 1334522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, string resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(resource);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x0007EF64 File Offset: 0x0007D164
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 1334528, RefRangeEnd = 1334544, XrefRangeStart = 1334524, XrefRangeEnd = 1334528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentOutOfRange_IndexException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x0007EF8C File Offset: 0x0007D18C
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1334548, RefRangeEnd = 1334571, XrefRangeStart = 1334544, XrefRangeEnd = 1334548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowIndexArgumentOutOfRange_NeedNonNegNumException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0007EFB4 File Offset: 0x0007D1B4
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 1334577, RefRangeEnd = 1334594, XrefRangeStart = 1334571, XrefRangeEnd = 1334577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArgumentException_Argument_InvalidArrayType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0007EFDC File Offset: 0x0007D1DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334601, RefRangeEnd = 1334602, XrefRangeStart = 1334594, XrefRangeEnd = 1334601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException GetAddingDuplicateWithKeyArgumentException(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x0007F020 File Offset: 0x0007D220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334602, XrefRangeEnd = 1334605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAddingDuplicateWithKeyArgumentException(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0007F058 File Offset: 0x0007D258
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334614, RefRangeEnd = 1334615, XrefRangeStart = 1334605, XrefRangeEnd = 1334614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static KeyNotFoundException GetKeyNotFoundException(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KeyNotFoundException>(intPtr3) : null;
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0007F09C File Offset: 0x0007D29C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334616, RefRangeEnd = 1334617, XrefRangeStart = 1334615, XrefRangeEnd = 1334616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyNotFoundException(Object key)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0007F0D4 File Offset: 0x0007D2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334617, XrefRangeEnd = 1334624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidTypeWithPointersNotSupported(Type targetType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x0007F10C File Offset: 0x0007D30C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1334628, RefRangeEnd = 1334631, XrefRangeStart = 1334624, XrefRangeEnd = 1334628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowInvalidOperationException_ConcurrentOperationsNotSupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x0007F134 File Offset: 0x0007D334
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334635, RefRangeEnd = 1334636, XrefRangeStart = 1334631, XrefRangeEnd = 1334635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static InvalidOperationException GetInvalidOperationException(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<InvalidOperationException>(intPtr3) : null;
			}
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x0007F178 File Offset: 0x0007D378
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334639, RefRangeEnd = 1334640, XrefRangeStart = 1334636, XrefRangeEnd = 1334639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowArraySegmentCtorValidationFailedExceptions(Array array, int offset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x0007F1CC File Offset: 0x0007D3CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334647, RefRangeEnd = 1334648, XrefRangeStart = 1334640, XrefRangeEnd = 1334647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Exception GetArraySegmentCtorValidationFailedException(Array array, int offset, int count)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0007F22C File Offset: 0x0007D42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334648, XrefRangeEnd = 1334655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentException GetArgumentException(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentException>(intPtr3) : null;
			}
		}

		// Token: 0x06001293 RID: 4755 RVA: 0x0007F26C File Offset: 0x0007D46C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334655, XrefRangeEnd = 1334660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentNullException GetArgumentNullException(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentNullException>(intPtr3) : null;
			}
		}

		// Token: 0x06001294 RID: 4756 RVA: 0x0007F2AC File Offset: 0x0007D4AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1334661, RefRangeEnd = 1334664, XrefRangeStart = 1334660, XrefRangeEnd = 1334661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void IfNullAndNullsAreIllegalThenThrow<T>(Object value, ExceptionArgument argName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argName;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x0007F2F0 File Offset: 0x0007D4F0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1334690, RefRangeEnd = 1334696, XrefRangeStart = 1334664, XrefRangeEnd = 1334690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetArgumentName(ExceptionArgument argument)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x0007F328 File Offset: 0x0007D528
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334704, RefRangeEnd = 1334706, XrefRangeStart = 1334696, XrefRangeEnd = 1334704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArgumentOutOfRangeException GetArgumentOutOfRangeException(ExceptionArgument argument, ExceptionResource resource)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref argument;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resource;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArgumentOutOfRangeException>(intPtr3) : null;
		}

		// Token: 0x06001297 RID: 4759 RVA: 0x0007F378 File Offset: 0x0007D578
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334709, RefRangeEnd = 1334710, XrefRangeStart = 1334706, XrefRangeEnd = 1334709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x0007F3A0 File Offset: 0x0007D5A0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1334713, RefRangeEnd = 1334716, XrefRangeStart = 1334710, XrefRangeEnd = 1334713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0007F3C8 File Offset: 0x0007D5C8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1334764, RefRangeEnd = 1334770, XrefRangeStart = 1334716, XrefRangeEnd = 1334764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceName(ExceptionResource resource)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref resource;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00006174 File Offset: 0x00004374
		public ThrowHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000FB3 RID: 4019
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Internal_Static_Void_ExceptionArgument_0;

		// Token: 0x04000FB4 RID: 4020
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentNullException_Private_Static_Exception_ExceptionArgument_0;

		// Token: 0x04000FB5 RID: 4021
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArrayTypeMismatchException_Internal_Static_Void_0;

		// Token: 0x04000FB6 RID: 4022
		private static readonly IntPtr NativeMethodInfoPtr_CreateArrayTypeMismatchException_Private_Static_Exception_0;

		// Token: 0x04000FB7 RID: 4023
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_DestinationTooShort_Internal_Static_Void_0;

		// Token: 0x04000FB8 RID: 4024
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentException_DestinationTooShort_Private_Static_Exception_0;

		// Token: 0x04000FB9 RID: 4025
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIndexOutOfRangeException_Internal_Static_Void_0;

		// Token: 0x04000FBA RID: 4026
		private static readonly IntPtr NativeMethodInfoPtr_CreateIndexOutOfRangeException_Private_Static_Exception_0;

		// Token: 0x04000FBB RID: 4027
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_0;

		// Token: 0x04000FBC RID: 4028
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_0;

		// Token: 0x04000FBD RID: 4029
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_0;

		// Token: 0x04000FBE RID: 4030
		private static readonly IntPtr NativeMethodInfoPtr_CreateArgumentOutOfRangeException_Private_Static_Exception_ExceptionArgument_0;

		// Token: 0x04000FBF RID: 4031
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_0;

		// Token: 0x04000FC0 RID: 4032
		private static readonly IntPtr NativeMethodInfoPtr_CreateThrowNotSupportedException_Private_Static_Exception_0;

		// Token: 0x04000FC1 RID: 4033
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWrongKeyTypeArgumentException_Internal_Static_Void_Object_Type_0;

		// Token: 0x04000FC2 RID: 4034
		private static readonly IntPtr NativeMethodInfoPtr_ThrowWrongValueTypeArgumentException_Internal_Static_Void_Object_Type_0;

		// Token: 0x04000FC3 RID: 4035
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000FC4 RID: 4036
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_Internal_Static_Void_ExceptionResource_ExceptionArgument_0;

		// Token: 0x04000FC5 RID: 4037
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRangeException_Internal_Static_Void_ExceptionArgument_ExceptionResource_0;

		// Token: 0x04000FC6 RID: 4038
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000FC7 RID: 4039
		private static readonly IntPtr NativeMethodInfoPtr_ThrowSerializationException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000FC8 RID: 4040
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNotSupportedException_Internal_Static_Void_ExceptionResource_0;

		// Token: 0x04000FC9 RID: 4041
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion_Internal_Static_Void_0;

		// Token: 0x04000FCA RID: 4042
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumOpCantHappen_Internal_Static_Void_0;

		// Token: 0x04000FCB RID: 4043
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumNotStarted_Internal_Static_Void_0;

		// Token: 0x04000FCC RID: 4044
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_EnumEnded_Internal_Static_Void_0;

		// Token: 0x04000FCD RID: 4045
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_InvalidOperation_NoValue_Internal_Static_Void_0;

		// Token: 0x04000FCE RID: 4046
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_String_0;

		// Token: 0x04000FCF RID: 4047
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentOutOfRange_IndexException_Internal_Static_Void_0;

		// Token: 0x04000FD0 RID: 4048
		private static readonly IntPtr NativeMethodInfoPtr_ThrowIndexArgumentOutOfRange_NeedNonNegNumException_Internal_Static_Void_0;

		// Token: 0x04000FD1 RID: 4049
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArgumentException_Argument_InvalidArrayType_Internal_Static_Void_0;

		// Token: 0x04000FD2 RID: 4050
		private static readonly IntPtr NativeMethodInfoPtr_GetAddingDuplicateWithKeyArgumentException_Private_Static_ArgumentException_Object_0;

		// Token: 0x04000FD3 RID: 4051
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAddingDuplicateWithKeyArgumentException_Internal_Static_Void_Object_0;

		// Token: 0x04000FD4 RID: 4052
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyNotFoundException_Private_Static_KeyNotFoundException_Object_0;

		// Token: 0x04000FD5 RID: 4053
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyNotFoundException_Internal_Static_Void_Object_0;

		// Token: 0x04000FD6 RID: 4054
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidTypeWithPointersNotSupported_Internal_Static_Void_Type_0;

		// Token: 0x04000FD7 RID: 4055
		private static readonly IntPtr NativeMethodInfoPtr_ThrowInvalidOperationException_ConcurrentOperationsNotSupported_Internal_Static_Void_0;

		// Token: 0x04000FD8 RID: 4056
		private static readonly IntPtr NativeMethodInfoPtr_GetInvalidOperationException_Internal_Static_InvalidOperationException_String_0;

		// Token: 0x04000FD9 RID: 4057
		private static readonly IntPtr NativeMethodInfoPtr_ThrowArraySegmentCtorValidationFailedExceptions_Internal_Static_Void_Array_Int32_Int32_0;

		// Token: 0x04000FDA RID: 4058
		private static readonly IntPtr NativeMethodInfoPtr_GetArraySegmentCtorValidationFailedException_Private_Static_Exception_Array_Int32_Int32_0;

		// Token: 0x04000FDB RID: 4059
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentException_Private_Static_ArgumentException_ExceptionResource_0;

		// Token: 0x04000FDC RID: 4060
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentNullException_Private_Static_ArgumentNullException_ExceptionArgument_0;

		// Token: 0x04000FDD RID: 4061
		private static readonly IntPtr NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0;

		// Token: 0x04000FDE RID: 4062
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentName_Internal_Static_String_ExceptionArgument_0;

		// Token: 0x04000FDF RID: 4063
		private static readonly IntPtr NativeMethodInfoPtr_GetArgumentOutOfRangeException_Private_Static_ArgumentOutOfRangeException_ExceptionArgument_ExceptionResource_0;

		// Token: 0x04000FE0 RID: 4064
		private static readonly IntPtr NativeMethodInfoPtr_ThrowStartIndexArgumentOutOfRange_ArgumentOutOfRange_Index_Internal_Static_Void_0;

		// Token: 0x04000FE1 RID: 4065
		private static readonly IntPtr NativeMethodInfoPtr_ThrowCountArgumentOutOfRange_ArgumentOutOfRange_Count_Internal_Static_Void_0;

		// Token: 0x04000FE2 RID: 4066
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceName_Internal_Static_String_ExceptionResource_0;

		// Token: 0x020005A4 RID: 1444
		private sealed class MethodInfoStoreGeneric_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0<T>
		{
			// Token: 0x04004730 RID: 18224
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ThrowHelper.NativeMethodInfoPtr_IfNullAndNullsAreIllegalThenThrow_Internal_Static_Void_Object_ExceptionArgument_0, Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
