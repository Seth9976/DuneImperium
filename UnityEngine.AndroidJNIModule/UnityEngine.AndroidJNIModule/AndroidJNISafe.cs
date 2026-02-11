using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public class AndroidJNISafe : Object
	{
		// Token: 0x060001CC RID: 460 RVA: 0x00009A5C File Offset: 0x00007C5C
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNISafe()
		{
			Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNISafe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr);
			AndroidJNISafe.NativeMethodInfoPtr_CheckException_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663477);
			AndroidJNISafe.NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663478);
			AndroidJNISafe.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663479);
			AndroidJNISafe.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663480);
			AndroidJNISafe.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663481);
			AndroidJNISafe.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663482);
			AndroidJNISafe.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663483);
			AndroidJNISafe.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663484);
			AndroidJNISafe.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663485);
			AndroidJNISafe.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663486);
			AndroidJNISafe.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663487);
			AndroidJNISafe.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663488);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663489);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663490);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663491);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663492);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663493);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663494);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663495);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663496);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663497);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663498);
			AndroidJNISafe.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663499);
			AndroidJNISafe.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663500);
			AndroidJNISafe.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663501);
			AndroidJNISafe.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663502);
			AndroidJNISafe.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663503);
			AndroidJNISafe.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663504);
			AndroidJNISafe.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663505);
			AndroidJNISafe.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663506);
			AndroidJNISafe.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663507);
			AndroidJNISafe.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663508);
			AndroidJNISafe.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663509);
			AndroidJNISafe.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663510);
			AndroidJNISafe.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663511);
			AndroidJNISafe.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663512);
			AndroidJNISafe.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663513);
			AndroidJNISafe.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663514);
			AndroidJNISafe.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663515);
			AndroidJNISafe.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663516);
			AndroidJNISafe.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663517);
			AndroidJNISafe.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663518);
			AndroidJNISafe.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663519);
			AndroidJNISafe.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663520);
			AndroidJNISafe.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663521);
			AndroidJNISafe.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663522);
			AndroidJNISafe.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663523);
			AndroidJNISafe.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663524);
			AndroidJNISafe.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663525);
			AndroidJNISafe.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663526);
			AndroidJNISafe.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663527);
			AndroidJNISafe.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663528);
			AndroidJNISafe.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663529);
			AndroidJNISafe.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNISafe>.NativeClassPtr, 100663530);
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00009EC4 File Offset: 0x000080C4
		[CallerCount(98)]
		[CachedScanResults(RefRangeStart = 1229863, RefRangeEnd = 1229961, XrefRangeStart = 1229858, XrefRangeEnd = 1229863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CheckException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CheckException_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00009EEC File Offset: 0x000080EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229961, XrefRangeEnd = 1229964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QueueDeleteGlobalRef(IntPtr globalref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref globalref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00009F20 File Offset: 0x00008120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229964, XrefRangeEnd = 1229967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteWeakGlobalRef(IntPtr globalref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref globalref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00009F54 File Offset: 0x00008154
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1229970, RefRangeEnd = 1229976, XrefRangeStart = 1229967, XrefRangeEnd = 1229970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLocalRef(IntPtr localref)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref localref;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00009F88 File Offset: 0x00008188
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1229981, RefRangeEnd = 1229986, XrefRangeStart = 1229976, XrefRangeEnd = 1229981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewString(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00009FCC File Offset: 0x000081CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229991, RefRangeEnd = 1229992, XrefRangeStart = 1229986, XrefRangeEnd = 1229991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringChars(IntPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x0000A004 File Offset: 0x00008204
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229992, XrefRangeEnd = 1229997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectClass(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x0000A044 File Offset: 0x00008244
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1230002, RefRangeEnd = 1230005, XrefRangeStart = 1229997, XrefRangeEnd = 1230002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticMethodID(IntPtr clazz, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000A0A8 File Offset: 0x000082A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1230010, RefRangeEnd = 1230013, XrefRangeStart = 1230005, XrefRangeEnd = 1230010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr obj, string name, string sig)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(sig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x0000A10C File Offset: 0x0000830C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230018, RefRangeEnd = 1230020, XrefRangeStart = 1230013, XrefRangeEnd = 1230018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A14C File Offset: 0x0000834C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1230025, RefRangeEnd = 1230034, XrefRangeStart = 1230020, XrefRangeEnd = 1230025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindClass(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000A190 File Offset: 0x00008390
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230042, RefRangeEnd = 1230043, XrefRangeStart = 1230034, XrefRangeEnd = 1230042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000A1F4 File Offset: 0x000083F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230043, XrefRangeEnd = 1230046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000A254 File Offset: 0x00008454
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1230054, RefRangeEnd = 1230068, XrefRangeStart = 1230046, XrefRangeEnd = 1230054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000A2B8 File Offset: 0x000084B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230076, RefRangeEnd = 1230078, XrefRangeStart = 1230068, XrefRangeEnd = 1230076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000A318 File Offset: 0x00008518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230086, RefRangeEnd = 1230088, XrefRangeStart = 1230078, XrefRangeEnd = 1230086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000A37C File Offset: 0x0000857C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230096, RefRangeEnd = 1230098, XrefRangeStart = 1230088, XrefRangeEnd = 1230096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000A3E0 File Offset: 0x000085E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230106, RefRangeEnd = 1230108, XrefRangeStart = 1230098, XrefRangeEnd = 1230106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000A444 File Offset: 0x00008644
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230116, RefRangeEnd = 1230118, XrefRangeStart = 1230108, XrefRangeEnd = 1230116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x0000A4A8 File Offset: 0x000086A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230126, RefRangeEnd = 1230128, XrefRangeStart = 1230118, XrefRangeEnd = 1230126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000A50C File Offset: 0x0000870C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1230136, RefRangeEnd = 1230140, XrefRangeStart = 1230128, XrefRangeEnd = 1230136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000A570 File Offset: 0x00008770
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230148, RefRangeEnd = 1230150, XrefRangeStart = 1230140, XrefRangeEnd = 1230148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0000A5D4 File Offset: 0x000087D4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1230158, RefRangeEnd = 1230161, XrefRangeStart = 1230150, XrefRangeEnd = 1230158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000A638 File Offset: 0x00008838
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1230169, RefRangeEnd = 1230172, XrefRangeStart = 1230161, XrefRangeEnd = 1230169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000A69C File Offset: 0x0000889C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230180, RefRangeEnd = 1230181, XrefRangeStart = 1230172, XrefRangeEnd = 1230180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStringMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000A6FC File Offset: 0x000088FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230189, RefRangeEnd = 1230190, XrefRangeStart = 1230181, XrefRangeEnd = 1230189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallCharMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000A760 File Offset: 0x00008960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230198, RefRangeEnd = 1230199, XrefRangeStart = 1230190, XrefRangeEnd = 1230198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000A7C4 File Offset: 0x000089C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230207, RefRangeEnd = 1230208, XrefRangeStart = 1230199, XrefRangeEnd = 1230207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallFloatMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x0000A828 File Offset: 0x00008A28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230216, RefRangeEnd = 1230217, XrefRangeStart = 1230208, XrefRangeEnd = 1230216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallLongMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x0000A88C File Offset: 0x00008A8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230225, RefRangeEnd = 1230226, XrefRangeStart = 1230217, XrefRangeEnd = 1230225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallShortMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230234, RefRangeEnd = 1230236, XrefRangeStart = 1230226, XrefRangeEnd = 1230234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000A954 File Offset: 0x00008B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230244, RefRangeEnd = 1230245, XrefRangeStart = 1230236, XrefRangeEnd = 1230244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230253, RefRangeEnd = 1230254, XrefRangeStart = 1230245, XrefRangeEnd = 1230253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallIntMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000AA1C File Offset: 0x00008C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230254, XrefRangeEnd = 1230259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> FromCharArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000AA5C File Offset: 0x00008C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230259, XrefRangeEnd = 1230264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<double> FromDoubleArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000AA9C File Offset: 0x00008C9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230264, XrefRangeEnd = 1230269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> FromFloatArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000AADC File Offset: 0x00008CDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230269, XrefRangeEnd = 1230274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<long> FromLongArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000AB1C File Offset: 0x00008D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230274, XrefRangeEnd = 1230279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<short> FromShortArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000AB5C File Offset: 0x00008D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230279, XrefRangeEnd = 1230284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000AB9C File Offset: 0x00008D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230284, XrefRangeEnd = 1230289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<sbyte> FromSByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000ABDC File Offset: 0x00008DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230289, XrefRangeEnd = 1230294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> FromBooleanArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000AC1C File Offset: 0x00008E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1230294, XrefRangeEnd = 1230299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> FromIntArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000AC5C File Offset: 0x00008E5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230304, RefRangeEnd = 1230305, XrefRangeStart = 1230299, XrefRangeEnd = 1230304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array, IntPtr type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000ACAC File Offset: 0x00008EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230310, RefRangeEnd = 1230311, XrefRangeStart = 1230305, XrefRangeEnd = 1230310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(Il2CppStructArray<char> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000ACF0 File Offset: 0x00008EF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230316, RefRangeEnd = 1230317, XrefRangeStart = 1230311, XrefRangeEnd = 1230316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(Il2CppStructArray<double> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000AD34 File Offset: 0x00008F34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230322, RefRangeEnd = 1230323, XrefRangeStart = 1230317, XrefRangeEnd = 1230322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(Il2CppStructArray<float> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000AD78 File Offset: 0x00008F78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230328, RefRangeEnd = 1230329, XrefRangeStart = 1230323, XrefRangeEnd = 1230328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(Il2CppStructArray<long> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000ADBC File Offset: 0x00008FBC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230334, RefRangeEnd = 1230335, XrefRangeStart = 1230329, XrefRangeEnd = 1230334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(Il2CppStructArray<short> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000AE00 File Offset: 0x00009000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230340, RefRangeEnd = 1230341, XrefRangeStart = 1230335, XrefRangeEnd = 1230340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToByteArray(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x0000AE44 File Offset: 0x00009044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230346, RefRangeEnd = 1230347, XrefRangeStart = 1230341, XrefRangeEnd = 1230346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x0000AE88 File Offset: 0x00009088
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230352, RefRangeEnd = 1230353, XrefRangeStart = 1230347, XrefRangeEnd = 1230352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x0000AECC File Offset: 0x000090CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1230358, RefRangeEnd = 1230359, XrefRangeStart = 1230353, XrefRangeEnd = 1230358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000AF10 File Offset: 0x00009110
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1230364, RefRangeEnd = 1230366, XrefRangeStart = 1230359, XrefRangeEnd = 1230364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectArrayElement(IntPtr array, int index)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000AF5C File Offset: 0x0000915C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1230371, RefRangeEnd = 1230375, XrefRangeStart = 1230366, XrefRangeEnd = 1230371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayLength(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNISafe.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002A2D File Offset: 0x00000C2D
		public AndroidJNISafe(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000AF9C File Offset: 0x0000919C
		public static void DeleteGlobalRef(IntPtr globalref)
		{
			bool flag = globalref != IntPtr.Zero;
			if (flag)
			{
				AndroidJNI.DeleteGlobalRef(globalref);
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000AFC0 File Offset: 0x000091C0
		public static IntPtr NewStringUTF(string bytes)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.NewStringUTF(bytes);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public static string GetStringUTFChars(IntPtr str)
		{
			string stringUTFChars;
			try
			{
				stringUTFChars = AndroidJNI.GetStringUTFChars(str);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringUTFChars;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000B028 File Offset: 0x00009228
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr fieldID;
			try
			{
				fieldID = AndroidJNI.GetFieldID(clazz, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return fieldID;
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000B05C File Offset: 0x0000925C
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			IntPtr staticFieldID;
			try
			{
				staticFieldID = AndroidJNI.GetStaticFieldID(clazz, name, sig);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticFieldID;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000B090 File Offset: 0x00009290
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.FromReflectedField(refField);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x0000B0C4 File Offset: 0x000092C4
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.NewObject(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0000B0E4 File Offset: 0x000092E4
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetStaticObjectField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x0000B118 File Offset: 0x00009318
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStaticStringField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x0000B14C File Offset: 0x0000934C
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetStaticCharField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0000B180 File Offset: 0x00009380
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetStaticDoubleField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0000B1B4 File Offset: 0x000093B4
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetStaticFloatField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x0000B1E8 File Offset: 0x000093E8
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetStaticLongField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000B21C File Offset: 0x0000941C
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetStaticShortField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x0000B250 File Offset: 0x00009450
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			try
			{
				AndroidJNI.SetStaticSByteField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000B284 File Offset: 0x00009484
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetStaticBooleanField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetStaticIntField(clazz, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000B2EC File Offset: 0x000094EC
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr staticObjectField;
			try
			{
				staticObjectField = AndroidJNI.GetStaticObjectField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticObjectField;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000B320 File Offset: 0x00009520
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			string staticStringField;
			try
			{
				staticStringField = AndroidJNI.GetStaticStringField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticStringField;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000B354 File Offset: 0x00009554
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			char staticCharField;
			try
			{
				staticCharField = AndroidJNI.GetStaticCharField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticCharField;
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0000B388 File Offset: 0x00009588
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			double staticDoubleField;
			try
			{
				staticDoubleField = AndroidJNI.GetStaticDoubleField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticDoubleField;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B3BC File Offset: 0x000095BC
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			float staticFloatField;
			try
			{
				staticFloatField = AndroidJNI.GetStaticFloatField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticFloatField;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000B3F0 File Offset: 0x000095F0
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			long staticLongField;
			try
			{
				staticLongField = AndroidJNI.GetStaticLongField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticLongField;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000B424 File Offset: 0x00009624
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			short staticShortField;
			try
			{
				staticShortField = AndroidJNI.GetStaticShortField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticShortField;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000B458 File Offset: 0x00009658
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			sbyte staticSByteField;
			try
			{
				staticSByteField = AndroidJNI.GetStaticSByteField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticSByteField;
		}

		// Token: 0x0600021D RID: 541 RVA: 0x0000B48C File Offset: 0x0000968C
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			bool staticBooleanField;
			try
			{
				staticBooleanField = AndroidJNI.GetStaticBooleanField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticBooleanField;
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B4C0 File Offset: 0x000096C0
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			int staticIntField;
			try
			{
				staticIntField = AndroidJNI.GetStaticIntField(clazz, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return staticIntField;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002A36 File Offset: 0x00000C36
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			AndroidJNISafe.CallStaticVoidMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000B4F4 File Offset: 0x000096F4
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			try
			{
				AndroidJNI.CallStaticVoidMethod(clazz, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000B528 File Offset: 0x00009728
		public static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticStringMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000B548 File Offset: 0x00009748
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticCharMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000B568 File Offset: 0x00009768
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticDoubleMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0000B588 File Offset: 0x00009788
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticFloatMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0000B5A8 File Offset: 0x000097A8
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticLongMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000226 RID: 550 RVA: 0x0000B5C8 File Offset: 0x000097C8
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticShortMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x0000B5E8 File Offset: 0x000097E8
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticSByteMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000B608 File Offset: 0x00009808
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticBooleanMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000B628 File Offset: 0x00009828
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStaticIntMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000B648 File Offset: 0x00009848
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			try
			{
				AndroidJNI.SetObjectField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000B67C File Offset: 0x0000987C
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			try
			{
				AndroidJNI.SetStringField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000B6B0 File Offset: 0x000098B0
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			try
			{
				AndroidJNI.SetCharField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000B6E4 File Offset: 0x000098E4
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			try
			{
				AndroidJNI.SetDoubleField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000B718 File Offset: 0x00009918
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			try
			{
				AndroidJNI.SetFloatField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000B74C File Offset: 0x0000994C
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			try
			{
				AndroidJNI.SetLongField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x0000B780 File Offset: 0x00009980
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			try
			{
				AndroidJNI.SetShortField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0000B7B4 File Offset: 0x000099B4
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			try
			{
				AndroidJNI.SetSByteField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000B7E8 File Offset: 0x000099E8
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			try
			{
				AndroidJNI.SetBooleanField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000B81C File Offset: 0x00009A1C
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			try
			{
				AndroidJNI.SetIntField(obj, fieldID, val);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000B850 File Offset: 0x00009A50
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr objectField;
			try
			{
				objectField = AndroidJNI.GetObjectField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return objectField;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0000B884 File Offset: 0x00009A84
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			string stringField;
			try
			{
				stringField = AndroidJNI.GetStringField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return stringField;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0000B8B8 File Offset: 0x00009AB8
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			char charField;
			try
			{
				charField = AndroidJNI.GetCharField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return charField;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000B8EC File Offset: 0x00009AEC
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			double doubleField;
			try
			{
				doubleField = AndroidJNI.GetDoubleField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return doubleField;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x0000B920 File Offset: 0x00009B20
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			float floatField;
			try
			{
				floatField = AndroidJNI.GetFloatField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return floatField;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000B954 File Offset: 0x00009B54
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			long longField;
			try
			{
				longField = AndroidJNI.GetLongField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return longField;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x0000B988 File Offset: 0x00009B88
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			short shortField;
			try
			{
				shortField = AndroidJNI.GetShortField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return shortField;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000B9BC File Offset: 0x00009BBC
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			sbyte sbyteField;
			try
			{
				sbyteField = AndroidJNI.GetSByteField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return sbyteField;
		}

		// Token: 0x0600023C RID: 572 RVA: 0x0000B9F0 File Offset: 0x00009BF0
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			bool booleanField;
			try
			{
				booleanField = AndroidJNI.GetBooleanField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return booleanField;
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0000BA24 File Offset: 0x00009C24
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			int intField;
			try
			{
				intField = AndroidJNI.GetIntField(obj, fieldID);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intField;
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00002A47 File Offset: 0x00000C47
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			AndroidJNISafe.CallVoidMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BA58 File Offset: 0x00009C58
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			try
			{
				AndroidJNI.CallVoidMethod(obj, methodID, args);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BA8C File Offset: 0x00009C8C
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallObjectMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BAAC File Offset: 0x00009CAC
		public static string CallStringMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallStringMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BACC File Offset: 0x00009CCC
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallCharMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0000BAEC File Offset: 0x00009CEC
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallDoubleMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x0000BB0C File Offset: 0x00009D0C
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallFloatMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0000BB2C File Offset: 0x00009D2C
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallLongMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallShortMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000BB6C File Offset: 0x00009D6C
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallSByteMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000BB8C File Offset: 0x00009D8C
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallBooleanMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000BBAC File Offset: 0x00009DAC
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNISafe.CallIntMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000BBCC File Offset: 0x00009DCC
		public static Il2CppStructArray<IntPtr> FromObjectArray(IntPtr array)
		{
			Il2CppStructArray<IntPtr> il2CppStructArray;
			try
			{
				il2CppStructArray = AndroidJNI.FromObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return il2CppStructArray;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000BC00 File Offset: 0x00009E00
		public static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array)
		{
			IntPtr intPtr;
			try
			{
				intPtr = AndroidJNI.ToObjectArray(array);
			}
			finally
			{
				AndroidJNISafe.CheckException();
			}
			return intPtr;
		}

		// Token: 0x0400013C RID: 316
		private static readonly IntPtr NativeMethodInfoPtr_CheckException_Public_Static_Void_0;

		// Token: 0x0400013D RID: 317
		private static readonly IntPtr NativeMethodInfoPtr_QueueDeleteGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x0400013E RID: 318
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000148 RID: 328
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x04000149 RID: 329
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014A RID: 330
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014B RID: 331
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014C RID: 332
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014D RID: 333
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014E RID: 334
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400014F RID: 335
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000150 RID: 336
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000151 RID: 337
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000152 RID: 338
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000153 RID: 339
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000154 RID: 340
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000155 RID: 341
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000156 RID: 342
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000157 RID: 343
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000158 RID: 344
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000159 RID: 345
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400015A RID: 346
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400015B RID: 347
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400015C RID: 348
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400015D RID: 349
		private static readonly IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

		// Token: 0x0400015E RID: 350
		private static readonly IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

		// Token: 0x04000160 RID: 352
		private static readonly IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

		// Token: 0x04000161 RID: 353
		private static readonly IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

		// Token: 0x04000162 RID: 354
		private static readonly IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x04000163 RID: 355
		private static readonly IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

		// Token: 0x04000164 RID: 356
		private static readonly IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

		// Token: 0x04000165 RID: 357
		private static readonly IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

		// Token: 0x04000166 RID: 358
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

		// Token: 0x04000167 RID: 359
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x04000168 RID: 360
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

		// Token: 0x04000169 RID: 361
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x0400016A RID: 362
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

		// Token: 0x0400016B RID: 363
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

		// Token: 0x0400016C RID: 364
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x0400016D RID: 365
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

		// Token: 0x0400016E RID: 366
		private static readonly IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x0400016F RID: 367
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;
	}
}
