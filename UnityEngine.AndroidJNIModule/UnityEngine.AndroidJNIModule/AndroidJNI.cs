using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200000D RID: 13
	public static class AndroidJNI : Object
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x00006A84 File Offset: 0x00004C84
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNI()
		{
			Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr);
			AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663384);
			AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663385);
			AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663386);
			AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663387);
			AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663388);
			AndroidJNI.NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663389);
			AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663390);
			AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663391);
			AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663392);
			AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663393);
			AndroidJNI.NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663394);
			AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663395);
			AndroidJNI.NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663396);
			AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663397);
			AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663398);
			AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663399);
			AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663400);
			AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663401);
			AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663402);
			AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663403);
			AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663404);
			AndroidJNI.NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663405);
			AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663406);
			AndroidJNI.NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663407);
			AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663408);
			AndroidJNI.NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663409);
			AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663410);
			AndroidJNI.NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663411);
			AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663412);
			AndroidJNI.NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663413);
			AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663414);
			AndroidJNI.NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663415);
			AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663416);
			AndroidJNI.NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663417);
			AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663418);
			AndroidJNI.NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663419);
			AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663420);
			AndroidJNI.NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663421);
			AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663422);
			AndroidJNI.NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663423);
			AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663424);
			AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663425);
			AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663426);
			AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663427);
			AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663428);
			AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663429);
			AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663430);
			AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663431);
			AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663432);
			AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663433);
			AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663434);
			AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663435);
			AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663436);
			AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663437);
			AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663438);
			AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663439);
			AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663440);
			AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663441);
			AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663442);
			AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663443);
			AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663444);
			AndroidJNI.NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663445);
			AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663446);
			AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663447);
			AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663448);
			AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663449);
			AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663450);
			AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663451);
			AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663452);
			AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663453);
			AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663454);
			AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663455);
			AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663456);
			AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663457);
			AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663458);
			AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663459);
			AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663460);
			AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663461);
			AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663462);
			AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663463);
			AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663464);
			AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663465);
			AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663466);
			AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663467);
			AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663468);
			AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663469);
			AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663470);
			AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663471);
			AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663472);
			AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663473);
			AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663474);
			AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663475);
			AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNI>.NativeClassPtr, 100663476);
			AndroidJNI.GetJavaVMDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetJavaVMDelegate>("UnityEngine.AndroidJNI::GetJavaVM");
			AndroidJNI.AttachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.AttachCurrentThreadDelegate>("UnityEngine.AndroidJNI::AttachCurrentThread");
			AndroidJNI.DetachCurrentThreadDelegateField = IL2CPP.ResolveICall<AndroidJNI.DetachCurrentThreadDelegate>("UnityEngine.AndroidJNI::DetachCurrentThread");
			AndroidJNI.GetVersionDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetVersionDelegate>("UnityEngine.AndroidJNI::GetVersion");
			AndroidJNI.FromReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromReflectedFieldDelegate>("UnityEngine.AndroidJNI::FromReflectedField");
			AndroidJNI.ToReflectedMethodDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedMethodDelegate>("UnityEngine.AndroidJNI::ToReflectedMethod");
			AndroidJNI.ToReflectedFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.ToReflectedFieldDelegate>("UnityEngine.AndroidJNI::ToReflectedField");
			AndroidJNI.GetSuperclassDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSuperclassDelegate>("UnityEngine.AndroidJNI::GetSuperclass");
			AndroidJNI.IsAssignableFromDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsAssignableFromDelegate>("UnityEngine.AndroidJNI::IsAssignableFrom");
			AndroidJNI.ThrowDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowDelegate>("UnityEngine.AndroidJNI::Throw");
			AndroidJNI.ThrowNewDelegateField = IL2CPP.ResolveICall<AndroidJNI.ThrowNewDelegate>("UnityEngine.AndroidJNI::ThrowNew");
			AndroidJNI.ExceptionDescribeDelegateField = IL2CPP.ResolveICall<AndroidJNI.ExceptionDescribeDelegate>("UnityEngine.AndroidJNI::ExceptionDescribe");
			AndroidJNI.FatalErrorDelegateField = IL2CPP.ResolveICall<AndroidJNI.FatalErrorDelegate>("UnityEngine.AndroidJNI::FatalError");
			AndroidJNI.PushLocalFrameDelegateField = IL2CPP.ResolveICall<AndroidJNI.PushLocalFrameDelegate>("UnityEngine.AndroidJNI::PushLocalFrame");
			AndroidJNI.PopLocalFrameDelegateField = IL2CPP.ResolveICall<AndroidJNI.PopLocalFrameDelegate>("UnityEngine.AndroidJNI::PopLocalFrame");
			AndroidJNI.DeleteGlobalRefDelegateField = IL2CPP.ResolveICall<AndroidJNI.DeleteGlobalRefDelegate>("UnityEngine.AndroidJNI::DeleteGlobalRef");
			AndroidJNI.GetQueueGlobalRefsCountDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetQueueGlobalRefsCountDelegate>("UnityEngine.AndroidJNI::GetQueueGlobalRefsCount");
			AndroidJNI.EnsureLocalCapacityDelegateField = IL2CPP.ResolveICall<AndroidJNI.EnsureLocalCapacityDelegate>("UnityEngine.AndroidJNI::EnsureLocalCapacity");
			AndroidJNI.AllocObjectDelegateField = IL2CPP.ResolveICall<AndroidJNI.AllocObjectDelegate>("UnityEngine.AndroidJNI::AllocObject");
			AndroidJNI.IsInstanceOfDelegateField = IL2CPP.ResolveICall<AndroidJNI.IsInstanceOfDelegate>("UnityEngine.AndroidJNI::IsInstanceOf");
			AndroidJNI.GetFieldIDDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFieldIDDelegate>("UnityEngine.AndroidJNI::GetFieldID");
			AndroidJNI.GetStaticFieldIDDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticFieldIDDelegate>("UnityEngine.AndroidJNI::GetStaticFieldID");
			AndroidJNI.NewStringDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringDelegate>("UnityEngine.AndroidJNI::NewString");
			AndroidJNI.NewStringUTFDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewStringUTFDelegate>("UnityEngine.AndroidJNI::NewStringUTF");
			AndroidJNI.GetStringLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringLengthDelegate>("UnityEngine.AndroidJNI::GetStringLength");
			AndroidJNI.GetStringUTFLengthDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFLengthDelegate>("UnityEngine.AndroidJNI::GetStringUTFLength");
			AndroidJNI.GetStringUTFCharsDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringUTFCharsDelegate>("UnityEngine.AndroidJNI::GetStringUTFChars");
			AndroidJNI.CallVoidMethodUnsafeDelegateField = IL2CPP.ResolveICall<AndroidJNI.CallVoidMethodUnsafeDelegate>("UnityEngine.AndroidJNI::CallVoidMethodUnsafe");
			AndroidJNI.GetStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStringFieldDelegate>("UnityEngine.AndroidJNI::GetStringField");
			AndroidJNI.GetObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetObjectFieldDelegate>("UnityEngine.AndroidJNI::GetObjectField");
			AndroidJNI.GetBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetBooleanFieldDelegate>("UnityEngine.AndroidJNI::GetBooleanField");
			AndroidJNI.GetSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSByteFieldDelegate>("UnityEngine.AndroidJNI::GetSByteField");
			AndroidJNI.GetCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetCharFieldDelegate>("UnityEngine.AndroidJNI::GetCharField");
			AndroidJNI.GetShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetShortFieldDelegate>("UnityEngine.AndroidJNI::GetShortField");
			AndroidJNI.GetIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetIntFieldDelegate>("UnityEngine.AndroidJNI::GetIntField");
			AndroidJNI.GetLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetLongFieldDelegate>("UnityEngine.AndroidJNI::GetLongField");
			AndroidJNI.GetFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFloatFieldDelegate>("UnityEngine.AndroidJNI::GetFloatField");
			AndroidJNI.GetDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDoubleFieldDelegate>("UnityEngine.AndroidJNI::GetDoubleField");
			AndroidJNI.SetStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStringFieldDelegate>("UnityEngine.AndroidJNI::SetStringField");
			AndroidJNI.SetObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetObjectFieldDelegate>("UnityEngine.AndroidJNI::SetObjectField");
			AndroidJNI.SetBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetBooleanField");
			AndroidJNI.SetSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteFieldDelegate>("UnityEngine.AndroidJNI::SetSByteField");
			AndroidJNI.SetCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharFieldDelegate>("UnityEngine.AndroidJNI::SetCharField");
			AndroidJNI.SetShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortFieldDelegate>("UnityEngine.AndroidJNI::SetShortField");
			AndroidJNI.SetIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntFieldDelegate>("UnityEngine.AndroidJNI::SetIntField");
			AndroidJNI.SetLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongFieldDelegate>("UnityEngine.AndroidJNI::SetLongField");
			AndroidJNI.SetFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatFieldDelegate>("UnityEngine.AndroidJNI::SetFloatField");
			AndroidJNI.SetDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetDoubleField");
			AndroidJNI.CallStaticVoidMethodUnsafeDelegateField = IL2CPP.ResolveICall<AndroidJNI.CallStaticVoidMethodUnsafeDelegate>("UnityEngine.AndroidJNI::CallStaticVoidMethodUnsafe");
			AndroidJNI.GetStaticStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticStringFieldDelegate>("UnityEngine.AndroidJNI::GetStaticStringField");
			AndroidJNI.GetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::GetStaticObjectField");
			AndroidJNI.GetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::GetStaticBooleanField");
			AndroidJNI.GetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::GetStaticSByteField");
			AndroidJNI.GetStaticCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::GetStaticCharField");
			AndroidJNI.GetStaticShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::GetStaticShortField");
			AndroidJNI.GetStaticIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::GetStaticIntField");
			AndroidJNI.GetStaticLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::GetStaticLongField");
			AndroidJNI.GetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::GetStaticFloatField");
			AndroidJNI.GetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::GetStaticDoubleField");
			AndroidJNI.SetStaticStringFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticStringFieldDelegate>("UnityEngine.AndroidJNI::SetStaticStringField");
			AndroidJNI.SetStaticObjectFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticObjectFieldDelegate>("UnityEngine.AndroidJNI::SetStaticObjectField");
			AndroidJNI.SetStaticBooleanFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticBooleanFieldDelegate>("UnityEngine.AndroidJNI::SetStaticBooleanField");
			AndroidJNI.SetStaticSByteFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticSByteFieldDelegate>("UnityEngine.AndroidJNI::SetStaticSByteField");
			AndroidJNI.SetStaticCharFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticCharFieldDelegate>("UnityEngine.AndroidJNI::SetStaticCharField");
			AndroidJNI.SetStaticShortFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticShortFieldDelegate>("UnityEngine.AndroidJNI::SetStaticShortField");
			AndroidJNI.SetStaticIntFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticIntFieldDelegate>("UnityEngine.AndroidJNI::SetStaticIntField");
			AndroidJNI.SetStaticLongFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticLongFieldDelegate>("UnityEngine.AndroidJNI::SetStaticLongField");
			AndroidJNI.SetStaticFloatFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticFloatFieldDelegate>("UnityEngine.AndroidJNI::SetStaticFloatField");
			AndroidJNI.SetStaticDoubleFieldDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetStaticDoubleFieldDelegate>("UnityEngine.AndroidJNI::SetStaticDoubleField");
			AndroidJNI.FromObjectArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.FromObjectArrayDelegate>("UnityEngine.AndroidJNI::FromObjectArray");
			AndroidJNI.NewBooleanArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewBooleanArrayDelegate>("UnityEngine.AndroidJNI::NewBooleanArray");
			AndroidJNI.NewSByteArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewSByteArrayDelegate>("UnityEngine.AndroidJNI::NewSByteArray");
			AndroidJNI.NewCharArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewCharArrayDelegate>("UnityEngine.AndroidJNI::NewCharArray");
			AndroidJNI.NewShortArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewShortArrayDelegate>("UnityEngine.AndroidJNI::NewShortArray");
			AndroidJNI.NewIntArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewIntArrayDelegate>("UnityEngine.AndroidJNI::NewIntArray");
			AndroidJNI.NewLongArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewLongArrayDelegate>("UnityEngine.AndroidJNI::NewLongArray");
			AndroidJNI.NewFloatArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewFloatArrayDelegate>("UnityEngine.AndroidJNI::NewFloatArray");
			AndroidJNI.NewDoubleArrayDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewDoubleArrayDelegate>("UnityEngine.AndroidJNI::NewDoubleArray");
			AndroidJNI.GetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::GetBooleanArrayElement");
			AndroidJNI.GetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::GetSByteArrayElement");
			AndroidJNI.GetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetCharArrayElementDelegate>("UnityEngine.AndroidJNI::GetCharArrayElement");
			AndroidJNI.GetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetShortArrayElementDelegate>("UnityEngine.AndroidJNI::GetShortArrayElement");
			AndroidJNI.GetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetIntArrayElementDelegate>("UnityEngine.AndroidJNI::GetIntArrayElement");
			AndroidJNI.GetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetLongArrayElementDelegate>("UnityEngine.AndroidJNI::GetLongArrayElement");
			AndroidJNI.GetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::GetFloatArrayElement");
			AndroidJNI.GetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::GetDoubleArrayElement");
			AndroidJNI.SetBooleanArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetBooleanArrayElementDelegate>("UnityEngine.AndroidJNI::SetBooleanArrayElement");
			AndroidJNI.SetSByteArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetSByteArrayElementDelegate>("UnityEngine.AndroidJNI::SetSByteArrayElement");
			AndroidJNI.SetCharArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetCharArrayElementDelegate>("UnityEngine.AndroidJNI::SetCharArrayElement");
			AndroidJNI.SetShortArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetShortArrayElementDelegate>("UnityEngine.AndroidJNI::SetShortArrayElement");
			AndroidJNI.SetIntArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetIntArrayElementDelegate>("UnityEngine.AndroidJNI::SetIntArrayElement");
			AndroidJNI.SetLongArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetLongArrayElementDelegate>("UnityEngine.AndroidJNI::SetLongArrayElement");
			AndroidJNI.SetFloatArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetFloatArrayElementDelegate>("UnityEngine.AndroidJNI::SetFloatArrayElement");
			AndroidJNI.SetDoubleArrayElementDelegateField = IL2CPP.ResolveICall<AndroidJNI.SetDoubleArrayElementDelegate>("UnityEngine.AndroidJNI::SetDoubleArrayElement");
			AndroidJNI.NewDirectByteBufferDelegateField = IL2CPP.ResolveICall<AndroidJNI.NewDirectByteBufferDelegate>("UnityEngine.AndroidJNI::NewDirectByteBuffer");
			AndroidJNI.GetDirectBufferCapacityDelegateField = IL2CPP.ResolveICall<AndroidJNI.GetDirectBufferCapacityDelegate>("UnityEngine.AndroidJNI::GetDirectBufferCapacity");
			AndroidJNI.RegisterNativesAllocateDelegateField = IL2CPP.ResolveICall<AndroidJNI.RegisterNativesAllocateDelegate>("UnityEngine.AndroidJNI::RegisterNativesAllocate");
			AndroidJNI.RegisterNativesSetDelegateField = IL2CPP.ResolveICall<AndroidJNI.RegisterNativesSetDelegate>("UnityEngine.AndroidJNI::RegisterNativesSet");
			AndroidJNI.RegisterNativesAndFreeDelegateField = IL2CPP.ResolveICall<AndroidJNI.RegisterNativesAndFreeDelegate>("UnityEngine.AndroidJNI::RegisterNativesAndFree");
			AndroidJNI.UnregisterNativesDelegateField = IL2CPP.ResolveICall<AndroidJNI.UnregisterNativesDelegate>("UnityEngine.AndroidJNI::UnregisterNatives");
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000077D4 File Offset: 0x000059D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229591, XrefRangeEnd = 1229593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FindClass(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00007818 File Offset: 0x00005A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229593, XrefRangeEnd = 1229595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr FromReflectedMethod(IntPtr refMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref refMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00007858 File Offset: 0x00005A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229595, XrefRangeEnd = 1229597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ExceptionOccurred()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00007888 File Offset: 0x00005A88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229597, XrefRangeEnd = 1229599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExceptionClear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000078B0 File Offset: 0x00005AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229599, XrefRangeEnd = 1229601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000078F0 File Offset: 0x00005AF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229601, XrefRangeEnd = 1229603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void QueueDeleteGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00007924 File Offset: 0x00005B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229603, XrefRangeEnd = 1229605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00007964 File Offset: 0x00005B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229605, XrefRangeEnd = 1229607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteWeakGlobalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00007998 File Offset: 0x00005B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229607, XrefRangeEnd = 1229609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000079D8 File Offset: 0x00005BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229609, XrefRangeEnd = 1229611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteLocalRef(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00007A0C File Offset: 0x00005C0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229613, RefRangeEnd = 1229615, XrefRangeStart = 1229611, XrefRangeEnd = 1229613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSameObject(IntPtr obj1, IntPtr obj2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00007A58 File Offset: 0x00005C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229615, XrefRangeEnd = 1229620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00007ABC File Offset: 0x00005CBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229620, XrefRangeEnd = 1229622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObjectA(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00007B14 File Offset: 0x00005D14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229622, XrefRangeEnd = 1229624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetObjectClass(IntPtr obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007B54 File Offset: 0x00005D54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229624, XrefRangeEnd = 1229626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr clazz, string name, string sig)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00007BB8 File Offset: 0x00005DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229626, XrefRangeEnd = 1229628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00007C1C File Offset: 0x00005E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229628, XrefRangeEnd = 1229630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewString(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007C60 File Offset: 0x00005E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewStringFromStr(string chars)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(chars);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00007CA4 File Offset: 0x00005EA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229630, XrefRangeEnd = 1229632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStringChars(IntPtr str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref str;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00007CDC File Offset: 0x00005EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229632, XrefRangeEnd = 1229639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStringMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007D34 File Offset: 0x00005F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229639, XrefRangeEnd = 1229644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00007D94 File Offset: 0x00005F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229644, XrefRangeEnd = 1229646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStringMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007DE8 File Offset: 0x00005FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229646, XrefRangeEnd = 1229651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007E4C File Offset: 0x0000604C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229651, XrefRangeEnd = 1229653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallObjectMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00007EA4 File Offset: 0x000060A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229653, XrefRangeEnd = 1229658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007F08 File Offset: 0x00006108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229658, XrefRangeEnd = 1229660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallIntMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00007F60 File Offset: 0x00006160
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229660, XrefRangeEnd = 1229665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00007FC4 File Offset: 0x000061C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229665, XrefRangeEnd = 1229667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallBooleanMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000801C File Offset: 0x0000621C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229667, XrefRangeEnd = 1229672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00008080 File Offset: 0x00006280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229672, XrefRangeEnd = 1229674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallShortMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000080D8 File Offset: 0x000062D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229674, XrefRangeEnd = 1229679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000813C File Offset: 0x0000633C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229679, XrefRangeEnd = 1229681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallSByteMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00008194 File Offset: 0x00006394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229681, XrefRangeEnd = 1229686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000081F8 File Offset: 0x000063F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229686, XrefRangeEnd = 1229688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallCharMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00008250 File Offset: 0x00006450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229688, XrefRangeEnd = 1229693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000082B4 File Offset: 0x000064B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229693, XrefRangeEnd = 1229695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallFloatMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000830C File Offset: 0x0000650C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229695, XrefRangeEnd = 1229700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00008370 File Offset: 0x00006570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229700, XrefRangeEnd = 1229702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallDoubleMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000083C8 File Offset: 0x000065C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229702, XrefRangeEnd = 1229707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000842C File Offset: 0x0000662C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229707, XrefRangeEnd = 1229709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallLongMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00008484 File Offset: 0x00006684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229709, XrefRangeEnd = 1229716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStaticStringMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000084DC File Offset: 0x000066DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229716, XrefRangeEnd = 1229721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000853C File Offset: 0x0000673C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229721, XrefRangeEnd = 1229723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string CallStaticStringMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00008590 File Offset: 0x00006790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229723, XrefRangeEnd = 1229728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000085F4 File Offset: 0x000067F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229728, XrefRangeEnd = 1229730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CallStaticObjectMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000864C File Offset: 0x0000684C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229730, XrefRangeEnd = 1229735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x000086B0 File Offset: 0x000068B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229735, XrefRangeEnd = 1229737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CallStaticIntMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00008708 File Offset: 0x00006908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229737, XrefRangeEnd = 1229742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000876C File Offset: 0x0000696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229742, XrefRangeEnd = 1229744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CallStaticBooleanMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x000087C4 File Offset: 0x000069C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229744, XrefRangeEnd = 1229749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00008828 File Offset: 0x00006A28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229749, XrefRangeEnd = 1229751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static short CallStaticShortMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00008880 File Offset: 0x00006A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229751, XrefRangeEnd = 1229756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000088E4 File Offset: 0x00006AE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229756, XrefRangeEnd = 1229758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static sbyte CallStaticSByteMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000893C File Offset: 0x00006B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229758, XrefRangeEnd = 1229763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000089A0 File Offset: 0x00006BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229763, XrefRangeEnd = 1229765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static char CallStaticCharMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000118 RID: 280 RVA: 0x000089F8 File Offset: 0x00006BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229765, XrefRangeEnd = 1229770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00008A5C File Offset: 0x00006C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229770, XrefRangeEnd = 1229772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float CallStaticFloatMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00008AB4 File Offset: 0x00006CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229772, XrefRangeEnd = 1229777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00008B18 File Offset: 0x00006D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229777, XrefRangeEnd = 1229779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double CallStaticDoubleMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00008B70 File Offset: 0x00006D70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229779, XrefRangeEnd = 1229784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00008BD4 File Offset: 0x00006DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229784, XrefRangeEnd = 1229786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long CallStaticLongMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clazz;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodID;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = args;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00008C2C File Offset: 0x00006E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229786, XrefRangeEnd = 1229788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ConvertToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00008C70 File Offset: 0x00006E70
		[CallerCount(0)]
		public unsafe static IntPtr ToBooleanArray(Il2CppStructArray<bool> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229788, XrefRangeEnd = 1229790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToByteArray(Il2CppStructArray<byte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00008CF8 File Offset: 0x00006EF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229790, XrefRangeEnd = 1229793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(Il2CppStructArray<sbyte> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00008D3C File Offset: 0x00006F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229793, XrefRangeEnd = 1229795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToSByteArray(sbyte* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00008D88 File Offset: 0x00006F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229795, XrefRangeEnd = 1229798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(Il2CppStructArray<char> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00008DCC File Offset: 0x00006FCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229798, XrefRangeEnd = 1229800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToCharArray(char* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008E18 File Offset: 0x00007018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229800, XrefRangeEnd = 1229803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(Il2CppStructArray<short> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00008E5C File Offset: 0x0000705C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229803, XrefRangeEnd = 1229805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToShortArray(short* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00008EA8 File Offset: 0x000070A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229805, XrefRangeEnd = 1229808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(Il2CppStructArray<int> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00008EEC File Offset: 0x000070EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229808, XrefRangeEnd = 1229810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToIntArray(int* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00008F38 File Offset: 0x00007138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229810, XrefRangeEnd = 1229813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(Il2CppStructArray<long> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00008F7C File Offset: 0x0000717C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229813, XrefRangeEnd = 1229815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToLongArray(long* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00008FC8 File Offset: 0x000071C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229815, XrefRangeEnd = 1229818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(Il2CppStructArray<float> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000900C File Offset: 0x0000720C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229818, XrefRangeEnd = 1229820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToFloatArray(float* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00009058 File Offset: 0x00007258
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229820, XrefRangeEnd = 1229823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(Il2CppStructArray<double> array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000909C File Offset: 0x0000729C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229823, XrefRangeEnd = 1229825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToDoubleArray(double* array, int length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000090E8 File Offset: 0x000072E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229825, XrefRangeEnd = 1229827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(IntPtr* array, int length, IntPtr arrayClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00009140 File Offset: 0x00007340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229827, XrefRangeEnd = 1229830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array, IntPtr arrayClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayClass;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00009190 File Offset: 0x00007390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229830, XrefRangeEnd = 1229832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<bool> FromBooleanArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000091D0 File Offset: 0x000073D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229832, XrefRangeEnd = 1229834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> FromByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00009210 File Offset: 0x00007410
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229834, XrefRangeEnd = 1229836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<sbyte> FromSByteArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<sbyte>>(intPtr3) : null;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00009250 File Offset: 0x00007450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229836, XrefRangeEnd = 1229838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<char> FromCharArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr3) : null;
			}
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00009290 File Offset: 0x00007490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229838, XrefRangeEnd = 1229840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<short> FromShortArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<short>>(intPtr3) : null;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x000092D0 File Offset: 0x000074D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229840, XrefRangeEnd = 1229842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<int> FromIntArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00009310 File Offset: 0x00007510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229842, XrefRangeEnd = 1229844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<long> FromLongArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00009350 File Offset: 0x00007550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229844, XrefRangeEnd = 1229846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<float> FromFloatArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr3) : null;
			}
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00009390 File Offset: 0x00007590
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229846, XrefRangeEnd = 1229848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<double> FromDoubleArray(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<double>>(intPtr3) : null;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000093D0 File Offset: 0x000075D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229848, XrefRangeEnd = 1229850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int GetArrayLength(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00009410 File Offset: 0x00007610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229850, XrefRangeEnd = 1229852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewObjectArray(int size, IntPtr clazz, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref size;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clazz;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000946C File Offset: 0x0000766C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229854, RefRangeEnd = 1229856, XrefRangeStart = 1229852, XrefRangeEnd = 1229854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000094B8 File Offset: 0x000076B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229856, XrefRangeEnd = 1229858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetObjectArrayElement(IntPtr array, int index, IntPtr obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref obj;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNI.NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000244E File Offset: 0x0000064E
		public AndroidJNI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002457 File Offset: 0x00000657
		public static IntPtr GetJavaVM()
		{
			return AndroidJNI.GetJavaVMDelegateField();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002463 File Offset: 0x00000663
		public static int AttachCurrentThread()
		{
			return AndroidJNI.AttachCurrentThreadDelegateField();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000246F File Offset: 0x0000066F
		public static int DetachCurrentThread()
		{
			return AndroidJNI.DetachCurrentThreadDelegateField();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000247B File Offset: 0x0000067B
		public static int GetVersion()
		{
			return AndroidJNI.GetVersionDelegateField();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002487 File Offset: 0x00000687
		public static IntPtr FromReflectedField(IntPtr refField)
		{
			return AndroidJNI.FromReflectedFieldDelegateField(refField);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002494 File Offset: 0x00000694
		public static IntPtr ToReflectedMethod(IntPtr clazz, IntPtr methodID, bool isStatic)
		{
			return AndroidJNI.ToReflectedMethodDelegateField(clazz, methodID, isStatic);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000024A3 File Offset: 0x000006A3
		public static IntPtr ToReflectedField(IntPtr clazz, IntPtr fieldID, bool isStatic)
		{
			return AndroidJNI.ToReflectedFieldDelegateField(clazz, fieldID, isStatic);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x000024B2 File Offset: 0x000006B2
		public static IntPtr GetSuperclass(IntPtr clazz)
		{
			return AndroidJNI.GetSuperclassDelegateField(clazz);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x000024BF File Offset: 0x000006BF
		public static bool IsAssignableFrom(IntPtr clazz1, IntPtr clazz2)
		{
			return AndroidJNI.IsAssignableFromDelegateField(clazz1, clazz2);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000024CD File Offset: 0x000006CD
		public static int Throw(IntPtr obj)
		{
			return AndroidJNI.ThrowDelegateField(obj);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000024DA File Offset: 0x000006DA
		public static int ThrowNew(IntPtr clazz, string message)
		{
			return AndroidJNI.ThrowNewDelegateField(clazz, IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000024ED File Offset: 0x000006ED
		public static void ExceptionDescribe()
		{
			AndroidJNI.ExceptionDescribeDelegateField();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000024F9 File Offset: 0x000006F9
		public static void FatalError(string message)
		{
			AndroidJNI.FatalErrorDelegateField(IL2CPP.ManagedStringToIl2Cpp(message));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000250B File Offset: 0x0000070B
		public static int PushLocalFrame(int capacity)
		{
			return AndroidJNI.PushLocalFrameDelegateField(capacity);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002518 File Offset: 0x00000718
		public static IntPtr PopLocalFrame(IntPtr ptr)
		{
			return AndroidJNI.PopLocalFrameDelegateField(ptr);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002525 File Offset: 0x00000725
		public static void DeleteGlobalRef(IntPtr obj)
		{
			AndroidJNI.DeleteGlobalRefDelegateField(obj);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002532 File Offset: 0x00000732
		public static uint GetQueueGlobalRefsCount()
		{
			return AndroidJNI.GetQueueGlobalRefsCountDelegateField();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000253E File Offset: 0x0000073E
		public static int EnsureLocalCapacity(int capacity)
		{
			return AndroidJNI.EnsureLocalCapacityDelegateField(capacity);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000254B File Offset: 0x0000074B
		public static IntPtr AllocObject(IntPtr clazz)
		{
			return AndroidJNI.AllocObjectDelegateField(clazz);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009508 File Offset: 0x00007708
		public static IntPtr NewObject(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.NewObject(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002558 File Offset: 0x00000758
		public static bool IsInstanceOf(IntPtr obj, IntPtr clazz)
		{
			return AndroidJNI.IsInstanceOfDelegateField(obj, clazz);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002566 File Offset: 0x00000766
		public static IntPtr GetFieldID(IntPtr clazz, string name, string sig)
		{
			return AndroidJNI.GetFieldIDDelegateField(clazz, IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.ManagedStringToIl2Cpp(sig));
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000257F File Offset: 0x0000077F
		public static IntPtr GetStaticFieldID(IntPtr clazz, string name, string sig)
		{
			return AndroidJNI.GetStaticFieldIDDelegateField(clazz, IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.ManagedStringToIl2Cpp(sig));
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00002598 File Offset: 0x00000798
		public static IntPtr NewString(Il2CppStructArray<char> chars)
		{
			return AndroidJNI.NewStringDelegateField(IL2CPP.Il2CppObjectBaseToPtr(chars));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000025AA File Offset: 0x000007AA
		public static IntPtr NewStringUTF(string bytes)
		{
			return AndroidJNI.NewStringUTFDelegateField(IL2CPP.ManagedStringToIl2Cpp(bytes));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000025BC File Offset: 0x000007BC
		public static int GetStringLength(IntPtr str)
		{
			return AndroidJNI.GetStringLengthDelegateField(str);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000025C9 File Offset: 0x000007C9
		public static int GetStringUTFLength(IntPtr str)
		{
			return AndroidJNI.GetStringUTFLengthDelegateField(str);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00009528 File Offset: 0x00007728
		public static string GetStringUTFChars(IntPtr str)
		{
			IntPtr intPtr = AndroidJNI.GetStringUTFCharsDelegateField(str);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00009548 File Offset: 0x00007748
		public static IntPtr CallObjectMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallObjectMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009568 File Offset: 0x00007768
		public static int CallIntMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallIntMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00009588 File Offset: 0x00007788
		public static bool CallBooleanMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallBooleanMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000095A8 File Offset: 0x000077A8
		public static short CallShortMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallShortMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000095C8 File Offset: 0x000077C8
		public static byte CallByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallSByteMethod(obj, methodID, args);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000095E4 File Offset: 0x000077E4
		public static sbyte CallSByteMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallSByteMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00009604 File Offset: 0x00007804
		public static char CallCharMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallCharMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00009624 File Offset: 0x00007824
		public static float CallFloatMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallFloatMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00009644 File Offset: 0x00007844
		public static double CallDoubleMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallDoubleMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00009664 File Offset: 0x00007864
		public static long CallLongMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallLongMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000025D6 File Offset: 0x000007D6
		public static void CallVoidMethod(IntPtr obj, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			AndroidJNI.CallVoidMethod(obj, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00009684 File Offset: 0x00007884
		public unsafe static void CallVoidMethod(IntPtr obj, IntPtr methodID, Span<jvalue> args)
		{
			fixed (jvalue* pinnableReference = args.GetPinnableReference())
			{
				jvalue* ptr = pinnableReference;
				AndroidJNI.CallVoidMethodUnsafe(obj, methodID, ptr);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000025E7 File Offset: 0x000007E7
		public unsafe static void CallVoidMethodUnsafe(IntPtr obj, IntPtr methodID, jvalue* args)
		{
			AndroidJNI.CallVoidMethodUnsafeDelegateField(obj, methodID, args);
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000096B0 File Offset: 0x000078B0
		public static string GetStringField(IntPtr obj, IntPtr fieldID)
		{
			IntPtr intPtr = AndroidJNI.GetStringFieldDelegateField(obj, fieldID);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000025F6 File Offset: 0x000007F6
		public static IntPtr GetObjectField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetObjectFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002604 File Offset: 0x00000804
		public static bool GetBooleanField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetBooleanFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000096D0 File Offset: 0x000078D0
		public static byte GetByteField(IntPtr obj, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetSByteField(obj, fieldID);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00002612 File Offset: 0x00000812
		public static sbyte GetSByteField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetSByteFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002620 File Offset: 0x00000820
		public static char GetCharField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetCharFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000262E File Offset: 0x0000082E
		public static short GetShortField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetShortFieldDelegateField(obj, fieldID);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000263C File Offset: 0x0000083C
		public static int GetIntField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetIntFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000264A File Offset: 0x0000084A
		public static long GetLongField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetLongFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002658 File Offset: 0x00000858
		public static float GetFloatField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetFloatFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002666 File Offset: 0x00000866
		public static double GetDoubleField(IntPtr obj, IntPtr fieldID)
		{
			return AndroidJNI.GetDoubleFieldDelegateField(obj, fieldID);
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00002674 File Offset: 0x00000874
		public static void SetStringField(IntPtr obj, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStringFieldDelegateField(obj, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00002688 File Offset: 0x00000888
		public static void SetObjectField(IntPtr obj, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetObjectFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002697 File Offset: 0x00000897
		public static void SetBooleanField(IntPtr obj, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetBooleanFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000026A6 File Offset: 0x000008A6
		public static void SetByteField(IntPtr obj, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetSByteField(obj, fieldID, (sbyte)val);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x000026B3 File Offset: 0x000008B3
		public static void SetSByteField(IntPtr obj, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetSByteFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x000026C2 File Offset: 0x000008C2
		public static void SetCharField(IntPtr obj, IntPtr fieldID, char val)
		{
			AndroidJNI.SetCharFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000026D1 File Offset: 0x000008D1
		public static void SetShortField(IntPtr obj, IntPtr fieldID, short val)
		{
			AndroidJNI.SetShortFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000026E0 File Offset: 0x000008E0
		public static void SetIntField(IntPtr obj, IntPtr fieldID, int val)
		{
			AndroidJNI.SetIntFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000026EF File Offset: 0x000008EF
		public static void SetLongField(IntPtr obj, IntPtr fieldID, long val)
		{
			AndroidJNI.SetLongFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000026FE File Offset: 0x000008FE
		public static void SetFloatField(IntPtr obj, IntPtr fieldID, float val)
		{
			AndroidJNI.SetFloatFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000270D File Offset: 0x0000090D
		public static void SetDoubleField(IntPtr obj, IntPtr fieldID, double val)
		{
			AndroidJNI.SetDoubleFieldDelegateField(obj, fieldID, val);
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000096EC File Offset: 0x000078EC
		public static IntPtr CallStaticObjectMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticObjectMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000970C File Offset: 0x0000790C
		public static int CallStaticIntMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticIntMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000972C File Offset: 0x0000792C
		public static bool CallStaticBooleanMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticBooleanMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000974C File Offset: 0x0000794C
		public static short CallStaticShortMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticShortMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000976C File Offset: 0x0000796C
		public static byte CallStaticByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return (byte)AndroidJNI.CallStaticSByteMethod(clazz, methodID, args);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009788 File Offset: 0x00007988
		public static sbyte CallStaticSByteMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticSByteMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000097A8 File Offset: 0x000079A8
		public static char CallStaticCharMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticCharMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000185 RID: 389 RVA: 0x000097C8 File Offset: 0x000079C8
		public static float CallStaticFloatMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticFloatMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000186 RID: 390 RVA: 0x000097E8 File Offset: 0x000079E8
		public static double CallStaticDoubleMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticDoubleMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00009808 File Offset: 0x00007A08
		public static long CallStaticLongMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			return AndroidJNI.CallStaticLongMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000271C File Offset: 0x0000091C
		public static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Il2CppStructArray<jvalue> args)
		{
			AndroidJNI.CallStaticVoidMethod(clazz, methodID, new Span<jvalue>(args));
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00009828 File Offset: 0x00007A28
		public unsafe static void CallStaticVoidMethod(IntPtr clazz, IntPtr methodID, Span<jvalue> args)
		{
			fixed (jvalue* pinnableReference = args.GetPinnableReference())
			{
				jvalue* ptr = pinnableReference;
				AndroidJNI.CallStaticVoidMethodUnsafe(clazz, methodID, ptr);
			}
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000272D File Offset: 0x0000092D
		public unsafe static void CallStaticVoidMethodUnsafe(IntPtr clazz, IntPtr methodID, jvalue* args)
		{
			AndroidJNI.CallStaticVoidMethodUnsafeDelegateField(clazz, methodID, args);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009854 File Offset: 0x00007A54
		public static string GetStaticStringField(IntPtr clazz, IntPtr fieldID)
		{
			IntPtr intPtr = AndroidJNI.GetStaticStringFieldDelegateField(clazz, fieldID);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000273C File Offset: 0x0000093C
		public static IntPtr GetStaticObjectField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticObjectFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000274A File Offset: 0x0000094A
		public static bool GetStaticBooleanField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticBooleanFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009874 File Offset: 0x00007A74
		public static byte GetStaticByteField(IntPtr clazz, IntPtr fieldID)
		{
			return (byte)AndroidJNI.GetStaticSByteField(clazz, fieldID);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00002758 File Offset: 0x00000958
		public static sbyte GetStaticSByteField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticSByteFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00002766 File Offset: 0x00000966
		public static char GetStaticCharField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticCharFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002774 File Offset: 0x00000974
		public static short GetStaticShortField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticShortFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00002782 File Offset: 0x00000982
		public static int GetStaticIntField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticIntFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00002790 File Offset: 0x00000990
		public static long GetStaticLongField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticLongFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000279E File Offset: 0x0000099E
		public static float GetStaticFloatField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticFloatFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x000027AC File Offset: 0x000009AC
		public static double GetStaticDoubleField(IntPtr clazz, IntPtr fieldID)
		{
			return AndroidJNI.GetStaticDoubleFieldDelegateField(clazz, fieldID);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x000027BA File Offset: 0x000009BA
		public static void SetStaticStringField(IntPtr clazz, IntPtr fieldID, string val)
		{
			AndroidJNI.SetStaticStringFieldDelegateField(clazz, fieldID, IL2CPP.ManagedStringToIl2Cpp(val));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000027CE File Offset: 0x000009CE
		public static void SetStaticObjectField(IntPtr clazz, IntPtr fieldID, IntPtr val)
		{
			AndroidJNI.SetStaticObjectFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000027DD File Offset: 0x000009DD
		public static void SetStaticBooleanField(IntPtr clazz, IntPtr fieldID, bool val)
		{
			AndroidJNI.SetStaticBooleanFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x000027EC File Offset: 0x000009EC
		public static void SetStaticByteField(IntPtr clazz, IntPtr fieldID, byte val)
		{
			AndroidJNI.SetStaticSByteField(clazz, fieldID, (sbyte)val);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x000027F9 File Offset: 0x000009F9
		public static void SetStaticSByteField(IntPtr clazz, IntPtr fieldID, sbyte val)
		{
			AndroidJNI.SetStaticSByteFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00002808 File Offset: 0x00000A08
		public static void SetStaticCharField(IntPtr clazz, IntPtr fieldID, char val)
		{
			AndroidJNI.SetStaticCharFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00002817 File Offset: 0x00000A17
		public static void SetStaticShortField(IntPtr clazz, IntPtr fieldID, short val)
		{
			AndroidJNI.SetStaticShortFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600019D RID: 413 RVA: 0x00002826 File Offset: 0x00000A26
		public static void SetStaticIntField(IntPtr clazz, IntPtr fieldID, int val)
		{
			AndroidJNI.SetStaticIntFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00002835 File Offset: 0x00000A35
		public static void SetStaticLongField(IntPtr clazz, IntPtr fieldID, long val)
		{
			AndroidJNI.SetStaticLongFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00002844 File Offset: 0x00000A44
		public static void SetStaticFloatField(IntPtr clazz, IntPtr fieldID, float val)
		{
			AndroidJNI.SetStaticFloatFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00002853 File Offset: 0x00000A53
		public static void SetStaticDoubleField(IntPtr clazz, IntPtr fieldID, double val)
		{
			AndroidJNI.SetStaticDoubleFieldDelegateField(clazz, fieldID, val);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009890 File Offset: 0x00007A90
		public static IntPtr ToObjectArray(Il2CppStructArray<IntPtr> array)
		{
			return AndroidJNI.ToObjectArray(array, IntPtr.Zero);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000098B0 File Offset: 0x00007AB0
		public static Il2CppStructArray<IntPtr> FromObjectArray(IntPtr array)
		{
			IntPtr intPtr = AndroidJNI.FromObjectArrayDelegateField(array);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<IntPtr>>(intPtr2) : null;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002862 File Offset: 0x00000A62
		public static IntPtr NewBooleanArray(int size)
		{
			return AndroidJNI.NewBooleanArrayDelegateField(size);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000098D8 File Offset: 0x00007AD8
		public static IntPtr NewByteArray(int size)
		{
			return AndroidJNI.NewSByteArray(size);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000286F File Offset: 0x00000A6F
		public static IntPtr NewSByteArray(int size)
		{
			return AndroidJNI.NewSByteArrayDelegateField(size);
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000287C File Offset: 0x00000A7C
		public static IntPtr NewCharArray(int size)
		{
			return AndroidJNI.NewCharArrayDelegateField(size);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002889 File Offset: 0x00000A89
		public static IntPtr NewShortArray(int size)
		{
			return AndroidJNI.NewShortArrayDelegateField(size);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002896 File Offset: 0x00000A96
		public static IntPtr NewIntArray(int size)
		{
			return AndroidJNI.NewIntArrayDelegateField(size);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000028A3 File Offset: 0x00000AA3
		public static IntPtr NewLongArray(int size)
		{
			return AndroidJNI.NewLongArrayDelegateField(size);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000028B0 File Offset: 0x00000AB0
		public static IntPtr NewFloatArray(int size)
		{
			return AndroidJNI.NewFloatArrayDelegateField(size);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000028BD File Offset: 0x00000ABD
		public static IntPtr NewDoubleArray(int size)
		{
			return AndroidJNI.NewDoubleArrayDelegateField(size);
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000028CA File Offset: 0x00000ACA
		public static bool GetBooleanArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetBooleanArrayElementDelegateField(array, index);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000098F0 File Offset: 0x00007AF0
		public static byte GetByteArrayElement(IntPtr array, int index)
		{
			return (byte)AndroidJNI.GetSByteArrayElement(array, index);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000028D8 File Offset: 0x00000AD8
		public static sbyte GetSByteArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetSByteArrayElementDelegateField(array, index);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x000028E6 File Offset: 0x00000AE6
		public static char GetCharArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetCharArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000028F4 File Offset: 0x00000AF4
		public static short GetShortArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetShortArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002902 File Offset: 0x00000B02
		public static int GetIntArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetIntArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002910 File Offset: 0x00000B10
		public static long GetLongArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetLongArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000291E File Offset: 0x00000B1E
		public static float GetFloatArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetFloatArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000292C File Offset: 0x00000B2C
		public static double GetDoubleArrayElement(IntPtr array, int index)
		{
			return AndroidJNI.GetDoubleArrayElementDelegateField(array, index);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000293A File Offset: 0x00000B3A
		public static void SetBooleanArrayElement(IntPtr array, int index, byte val)
		{
			AndroidJNI.SetBooleanArrayElement(array, index, val > 0);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002949 File Offset: 0x00000B49
		public static void SetBooleanArrayElement(IntPtr array, int index, bool val)
		{
			AndroidJNI.SetBooleanArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002958 File Offset: 0x00000B58
		public static void SetByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElement(array, index, val);
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002964 File Offset: 0x00000B64
		public static void SetSByteArrayElement(IntPtr array, int index, sbyte val)
		{
			AndroidJNI.SetSByteArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00002973 File Offset: 0x00000B73
		public static void SetCharArrayElement(IntPtr array, int index, char val)
		{
			AndroidJNI.SetCharArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00002982 File Offset: 0x00000B82
		public static void SetShortArrayElement(IntPtr array, int index, short val)
		{
			AndroidJNI.SetShortArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002991 File Offset: 0x00000B91
		public static void SetIntArrayElement(IntPtr array, int index, int val)
		{
			AndroidJNI.SetIntArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000029A0 File Offset: 0x00000BA0
		public static void SetLongArrayElement(IntPtr array, int index, long val)
		{
			AndroidJNI.SetLongArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000029AF File Offset: 0x00000BAF
		public static void SetFloatArrayElement(IntPtr array, int index, float val)
		{
			AndroidJNI.SetFloatArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000029BE File Offset: 0x00000BBE
		public static void SetDoubleArrayElement(IntPtr array, int index, double val)
		{
			AndroidJNI.SetDoubleArrayElementDelegateField(array, index, val);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x000029CD File Offset: 0x00000BCD
		public unsafe static IntPtr NewDirectByteBuffer(byte* buffer, long capacity)
		{
			return AndroidJNI.NewDirectByteBufferDelegateField(buffer, capacity);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000990C File Offset: 0x00007B0C
		public static IntPtr NewDirectByteBuffer(NativeArray<byte> buffer)
		{
			return AndroidJNI.NewDirectByteBufferFromNativeArray<byte>(buffer);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00009924 File Offset: 0x00007B24
		public static IntPtr NewDirectByteBuffer(NativeArray<sbyte> buffer)
		{
			return AndroidJNI.NewDirectByteBufferFromNativeArray<sbyte>(buffer);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000993C File Offset: 0x00007B3C
		public unsafe static IntPtr NewDirectByteBufferFromNativeArray<T>(NativeArray<T> buffer) where T : struct
		{
			bool flag = !buffer.IsCreated || buffer.Length <= 0;
			IntPtr intPtr;
			if (flag)
			{
				intPtr = IntPtr.Zero;
			}
			else
			{
				intPtr = AndroidJNI.NewDirectByteBuffer((byte*)buffer.GetUnsafePtr<T>(), (long)buffer.Length);
			}
			return intPtr;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x00009988 File Offset: 0x00007B88
		public unsafe static sbyte* GetDirectBufferAddress(IntPtr buffer)
		{
			return null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000029DB File Offset: 0x00000BDB
		public static long GetDirectBufferCapacity(IntPtr buffer)
		{
			return AndroidJNI.GetDirectBufferCapacityDelegateField(buffer);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000999C File Offset: 0x00007B9C
		public unsafe static NativeArray<T> GetDirectBuffer<T>(IntPtr buffer) where T : struct
		{
			bool flag = buffer == IntPtr.Zero;
			NativeArray<T> nativeArray;
			if (flag)
			{
				nativeArray = null;
			}
			else
			{
				sbyte* directBufferAddress = AndroidJNI.GetDirectBufferAddress(buffer);
				bool flag2 = directBufferAddress == null;
				if (flag2)
				{
					nativeArray = null;
				}
				else
				{
					long directBufferCapacity = AndroidJNI.GetDirectBufferCapacity(buffer);
					bool flag3 = directBufferCapacity > 2147483647L;
					if (flag3)
					{
						throw new Exception(String.Format("Direct buffer is too large ({0}) for NativeArray (max {1})", directBufferCapacity, int.MaxValue));
					}
					nativeArray = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>((void*)directBufferAddress, (int)directBufferCapacity, Allocator.None);
				}
			}
			return nativeArray;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00009A2C File Offset: 0x00007C2C
		public static NativeArray<byte> GetDirectByteBuffer(IntPtr buffer)
		{
			return AndroidJNI.GetDirectBuffer<byte>(buffer);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00009A44 File Offset: 0x00007C44
		public static NativeArray<sbyte> GetDirectSByteBuffer(IntPtr buffer)
		{
			return AndroidJNI.GetDirectBuffer<sbyte>(buffer);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x000029E8 File Offset: 0x00000BE8
		public static IntPtr RegisterNativesAllocate(int length)
		{
			return AndroidJNI.RegisterNativesAllocateDelegateField(length);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x000029F5 File Offset: 0x00000BF5
		public static void RegisterNativesSet(IntPtr natives, int idx, string name, string signature, IntPtr fnPtr)
		{
			AndroidJNI.RegisterNativesSetDelegateField(natives, idx, IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.ManagedStringToIl2Cpp(signature), fnPtr);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002A11 File Offset: 0x00000C11
		public static int RegisterNativesAndFree(IntPtr clazz, IntPtr natives, int n)
		{
			return AndroidJNI.RegisterNativesAndFreeDelegateField(clazz, natives, n);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002A20 File Offset: 0x00000C20
		public static int UnregisterNatives(IntPtr clazz)
		{
			return AndroidJNI.UnregisterNativesDelegateField(clazz);
		}

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_FindClass_Public_Static_IntPtr_String_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_FromReflectedMethod_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionOccurred_Public_Static_IntPtr_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_ExceptionClear_Public_Static_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_NewGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_QueueDeleteGlobalRef_Internal_Static_Void_IntPtr_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_NewWeakGlobalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_DeleteWeakGlobalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_NewLocalRef_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_DeleteLocalRef_Public_Static_Void_IntPtr_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_IsSameObject_Public_Static_Boolean_IntPtr_IntPtr_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_NewObject_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_NewObjectA_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectClass_Public_Static_IntPtr_IntPtr_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Public_Static_IntPtr_IntPtr_String_String_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_NewString_Public_Static_IntPtr_String_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_NewStringFromStr_Private_Static_IntPtr_String_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_GetStringChars_Public_Static_String_IntPtr_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeMethodInfoPtr_CallStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeMethodInfoPtr_CallObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_CallIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_CallBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_CallShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_CallSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400009C RID: 156
		private static readonly IntPtr NativeMethodInfoPtr_CallCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x0400009D RID: 157
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_CallFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_CallDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_CallLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Il2CppStructArray_1_jvalue_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethod_Public_Static_String_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticStringMethodUnsafe_Public_Static_String_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethod_Public_Static_IntPtr_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticObjectMethodUnsafe_Public_Static_IntPtr_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethod_Public_Static_Int32_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticIntMethodUnsafe_Public_Static_Int32_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethod_Public_Static_Boolean_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticBooleanMethodUnsafe_Public_Static_Boolean_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethod_Public_Static_Int16_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticShortMethodUnsafe_Public_Static_Int16_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethod_Public_Static_SByte_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticSByteMethodUnsafe_Public_Static_SByte_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethod_Public_Static_Char_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticCharMethodUnsafe_Public_Static_Char_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethod_Public_Static_Single_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticFloatMethodUnsafe_Public_Static_Single_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethod_Public_Static_Double_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticDoubleMethodUnsafe_Public_Static_Double_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethod_Public_Static_Int64_IntPtr_IntPtr_Span_1_jvalue_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_CallStaticLongMethodUnsafe_Public_Static_Int64_IntPtr_IntPtr_ptr_jvalue_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToBooleanArray_Private_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_ToBooleanArray_Public_Static_IntPtr_Il2CppStructArray_1_Boolean_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_ToByteArray_Public_Static_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000BB RID: 187
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_Il2CppStructArray_1_SByte_0;

		// Token: 0x040000BC RID: 188
		private static readonly IntPtr NativeMethodInfoPtr_ToSByteArray_Public_Static_IntPtr_ptr_SByte_Int32_0;

		// Token: 0x040000BD RID: 189
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_Il2CppStructArray_1_Char_0;

		// Token: 0x040000BE RID: 190
		private static readonly IntPtr NativeMethodInfoPtr_ToCharArray_Public_Static_IntPtr_ptr_Char_Int32_0;

		// Token: 0x040000BF RID: 191
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_Il2CppStructArray_1_Int16_0;

		// Token: 0x040000C0 RID: 192
		private static readonly IntPtr NativeMethodInfoPtr_ToShortArray_Public_Static_IntPtr_ptr_Int16_Int32_0;

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_Il2CppStructArray_1_Int32_0;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_ToIntArray_Public_Static_IntPtr_ptr_Int32_Int32_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_Il2CppStructArray_1_Int64_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_ToLongArray_Public_Static_IntPtr_ptr_Int64_Int32_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_Il2CppStructArray_1_Single_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_ToFloatArray_Public_Static_IntPtr_ptr_Single_Int32_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_Il2CppStructArray_1_Double_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_ToDoubleArray_Public_Static_IntPtr_ptr_Double_Int32_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_ptr_IntPtr_Int32_IntPtr_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_ToObjectArray_Public_Static_IntPtr_Il2CppStructArray_1_IntPtr_IntPtr_0;

		// Token: 0x040000CB RID: 203
		private static readonly IntPtr NativeMethodInfoPtr_FromBooleanArray_Public_Static_Il2CppStructArray_1_Boolean_IntPtr_0;

		// Token: 0x040000CC RID: 204
		private static readonly IntPtr NativeMethodInfoPtr_FromByteArray_Public_Static_Il2CppStructArray_1_Byte_IntPtr_0;

		// Token: 0x040000CD RID: 205
		private static readonly IntPtr NativeMethodInfoPtr_FromSByteArray_Public_Static_Il2CppStructArray_1_SByte_IntPtr_0;

		// Token: 0x040000CE RID: 206
		private static readonly IntPtr NativeMethodInfoPtr_FromCharArray_Public_Static_Il2CppStructArray_1_Char_IntPtr_0;

		// Token: 0x040000CF RID: 207
		private static readonly IntPtr NativeMethodInfoPtr_FromShortArray_Public_Static_Il2CppStructArray_1_Int16_IntPtr_0;

		// Token: 0x040000D0 RID: 208
		private static readonly IntPtr NativeMethodInfoPtr_FromIntArray_Public_Static_Il2CppStructArray_1_Int32_IntPtr_0;

		// Token: 0x040000D1 RID: 209
		private static readonly IntPtr NativeMethodInfoPtr_FromLongArray_Public_Static_Il2CppStructArray_1_Int64_IntPtr_0;

		// Token: 0x040000D2 RID: 210
		private static readonly IntPtr NativeMethodInfoPtr_FromFloatArray_Public_Static_Il2CppStructArray_1_Single_IntPtr_0;

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr_FromDoubleArray_Public_Static_Il2CppStructArray_1_Double_IntPtr_0;

		// Token: 0x040000D4 RID: 212
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayLength_Public_Static_Int32_IntPtr_0;

		// Token: 0x040000D5 RID: 213
		private static readonly IntPtr NativeMethodInfoPtr_NewObjectArray_Public_Static_IntPtr_Int32_IntPtr_IntPtr_0;

		// Token: 0x040000D6 RID: 214
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectArrayElement_Public_Static_IntPtr_IntPtr_Int32_0;

		// Token: 0x040000D7 RID: 215
		private static readonly IntPtr NativeMethodInfoPtr_SetObjectArrayElement_Public_Static_Void_IntPtr_Int32_IntPtr_0;

		// Token: 0x040000D8 RID: 216
		private static readonly AndroidJNI.GetJavaVMDelegate GetJavaVMDelegateField;

		// Token: 0x040000D9 RID: 217
		private static readonly AndroidJNI.AttachCurrentThreadDelegate AttachCurrentThreadDelegateField;

		// Token: 0x040000DA RID: 218
		private static readonly AndroidJNI.DetachCurrentThreadDelegate DetachCurrentThreadDelegateField;

		// Token: 0x040000DB RID: 219
		private static readonly AndroidJNI.GetVersionDelegate GetVersionDelegateField;

		// Token: 0x040000DC RID: 220
		private static readonly AndroidJNI.FromReflectedFieldDelegate FromReflectedFieldDelegateField;

		// Token: 0x040000DD RID: 221
		private static readonly AndroidJNI.ToReflectedMethodDelegate ToReflectedMethodDelegateField;

		// Token: 0x040000DE RID: 222
		private static readonly AndroidJNI.ToReflectedFieldDelegate ToReflectedFieldDelegateField;

		// Token: 0x040000DF RID: 223
		private static readonly AndroidJNI.GetSuperclassDelegate GetSuperclassDelegateField;

		// Token: 0x040000E0 RID: 224
		private static readonly AndroidJNI.IsAssignableFromDelegate IsAssignableFromDelegateField;

		// Token: 0x040000E1 RID: 225
		private static readonly AndroidJNI.ThrowDelegate ThrowDelegateField;

		// Token: 0x040000E2 RID: 226
		private static readonly AndroidJNI.ThrowNewDelegate ThrowNewDelegateField;

		// Token: 0x040000E3 RID: 227
		private static readonly AndroidJNI.ExceptionDescribeDelegate ExceptionDescribeDelegateField;

		// Token: 0x040000E4 RID: 228
		private static readonly AndroidJNI.FatalErrorDelegate FatalErrorDelegateField;

		// Token: 0x040000E5 RID: 229
		private static readonly AndroidJNI.PushLocalFrameDelegate PushLocalFrameDelegateField;

		// Token: 0x040000E6 RID: 230
		private static readonly AndroidJNI.PopLocalFrameDelegate PopLocalFrameDelegateField;

		// Token: 0x040000E7 RID: 231
		private static readonly AndroidJNI.DeleteGlobalRefDelegate DeleteGlobalRefDelegateField;

		// Token: 0x040000E8 RID: 232
		private static readonly AndroidJNI.GetQueueGlobalRefsCountDelegate GetQueueGlobalRefsCountDelegateField;

		// Token: 0x040000E9 RID: 233
		private static readonly AndroidJNI.EnsureLocalCapacityDelegate EnsureLocalCapacityDelegateField;

		// Token: 0x040000EA RID: 234
		private static readonly AndroidJNI.AllocObjectDelegate AllocObjectDelegateField;

		// Token: 0x040000EB RID: 235
		private static readonly AndroidJNI.IsInstanceOfDelegate IsInstanceOfDelegateField;

		// Token: 0x040000EC RID: 236
		private static readonly AndroidJNI.GetFieldIDDelegate GetFieldIDDelegateField;

		// Token: 0x040000ED RID: 237
		private static readonly AndroidJNI.GetStaticFieldIDDelegate GetStaticFieldIDDelegateField;

		// Token: 0x040000EE RID: 238
		private static readonly AndroidJNI.NewStringDelegate NewStringDelegateField;

		// Token: 0x040000EF RID: 239
		private static readonly AndroidJNI.NewStringUTFDelegate NewStringUTFDelegateField;

		// Token: 0x040000F0 RID: 240
		private static readonly AndroidJNI.GetStringLengthDelegate GetStringLengthDelegateField;

		// Token: 0x040000F1 RID: 241
		private static readonly AndroidJNI.GetStringUTFLengthDelegate GetStringUTFLengthDelegateField;

		// Token: 0x040000F2 RID: 242
		private static readonly AndroidJNI.GetStringUTFCharsDelegate GetStringUTFCharsDelegateField;

		// Token: 0x040000F3 RID: 243
		private static readonly AndroidJNI.CallVoidMethodUnsafeDelegate CallVoidMethodUnsafeDelegateField;

		// Token: 0x040000F4 RID: 244
		private static readonly AndroidJNI.GetStringFieldDelegate GetStringFieldDelegateField;

		// Token: 0x040000F5 RID: 245
		private static readonly AndroidJNI.GetObjectFieldDelegate GetObjectFieldDelegateField;

		// Token: 0x040000F6 RID: 246
		private static readonly AndroidJNI.GetBooleanFieldDelegate GetBooleanFieldDelegateField;

		// Token: 0x040000F7 RID: 247
		private static readonly AndroidJNI.GetSByteFieldDelegate GetSByteFieldDelegateField;

		// Token: 0x040000F8 RID: 248
		private static readonly AndroidJNI.GetCharFieldDelegate GetCharFieldDelegateField;

		// Token: 0x040000F9 RID: 249
		private static readonly AndroidJNI.GetShortFieldDelegate GetShortFieldDelegateField;

		// Token: 0x040000FA RID: 250
		private static readonly AndroidJNI.GetIntFieldDelegate GetIntFieldDelegateField;

		// Token: 0x040000FB RID: 251
		private static readonly AndroidJNI.GetLongFieldDelegate GetLongFieldDelegateField;

		// Token: 0x040000FC RID: 252
		private static readonly AndroidJNI.GetFloatFieldDelegate GetFloatFieldDelegateField;

		// Token: 0x040000FD RID: 253
		private static readonly AndroidJNI.GetDoubleFieldDelegate GetDoubleFieldDelegateField;

		// Token: 0x040000FE RID: 254
		private static readonly AndroidJNI.SetStringFieldDelegate SetStringFieldDelegateField;

		// Token: 0x040000FF RID: 255
		private static readonly AndroidJNI.SetObjectFieldDelegate SetObjectFieldDelegateField;

		// Token: 0x04000100 RID: 256
		private static readonly AndroidJNI.SetBooleanFieldDelegate SetBooleanFieldDelegateField;

		// Token: 0x04000101 RID: 257
		private static readonly AndroidJNI.SetSByteFieldDelegate SetSByteFieldDelegateField;

		// Token: 0x04000102 RID: 258
		private static readonly AndroidJNI.SetCharFieldDelegate SetCharFieldDelegateField;

		// Token: 0x04000103 RID: 259
		private static readonly AndroidJNI.SetShortFieldDelegate SetShortFieldDelegateField;

		// Token: 0x04000104 RID: 260
		private static readonly AndroidJNI.SetIntFieldDelegate SetIntFieldDelegateField;

		// Token: 0x04000105 RID: 261
		private static readonly AndroidJNI.SetLongFieldDelegate SetLongFieldDelegateField;

		// Token: 0x04000106 RID: 262
		private static readonly AndroidJNI.SetFloatFieldDelegate SetFloatFieldDelegateField;

		// Token: 0x04000107 RID: 263
		private static readonly AndroidJNI.SetDoubleFieldDelegate SetDoubleFieldDelegateField;

		// Token: 0x04000108 RID: 264
		private static readonly AndroidJNI.CallStaticVoidMethodUnsafeDelegate CallStaticVoidMethodUnsafeDelegateField;

		// Token: 0x04000109 RID: 265
		private static readonly AndroidJNI.GetStaticStringFieldDelegate GetStaticStringFieldDelegateField;

		// Token: 0x0400010A RID: 266
		private static readonly AndroidJNI.GetStaticObjectFieldDelegate GetStaticObjectFieldDelegateField;

		// Token: 0x0400010B RID: 267
		private static readonly AndroidJNI.GetStaticBooleanFieldDelegate GetStaticBooleanFieldDelegateField;

		// Token: 0x0400010C RID: 268
		private static readonly AndroidJNI.GetStaticSByteFieldDelegate GetStaticSByteFieldDelegateField;

		// Token: 0x0400010D RID: 269
		private static readonly AndroidJNI.GetStaticCharFieldDelegate GetStaticCharFieldDelegateField;

		// Token: 0x0400010E RID: 270
		private static readonly AndroidJNI.GetStaticShortFieldDelegate GetStaticShortFieldDelegateField;

		// Token: 0x0400010F RID: 271
		private static readonly AndroidJNI.GetStaticIntFieldDelegate GetStaticIntFieldDelegateField;

		// Token: 0x04000110 RID: 272
		private static readonly AndroidJNI.GetStaticLongFieldDelegate GetStaticLongFieldDelegateField;

		// Token: 0x04000111 RID: 273
		private static readonly AndroidJNI.GetStaticFloatFieldDelegate GetStaticFloatFieldDelegateField;

		// Token: 0x04000112 RID: 274
		private static readonly AndroidJNI.GetStaticDoubleFieldDelegate GetStaticDoubleFieldDelegateField;

		// Token: 0x04000113 RID: 275
		private static readonly AndroidJNI.SetStaticStringFieldDelegate SetStaticStringFieldDelegateField;

		// Token: 0x04000114 RID: 276
		private static readonly AndroidJNI.SetStaticObjectFieldDelegate SetStaticObjectFieldDelegateField;

		// Token: 0x04000115 RID: 277
		private static readonly AndroidJNI.SetStaticBooleanFieldDelegate SetStaticBooleanFieldDelegateField;

		// Token: 0x04000116 RID: 278
		private static readonly AndroidJNI.SetStaticSByteFieldDelegate SetStaticSByteFieldDelegateField;

		// Token: 0x04000117 RID: 279
		private static readonly AndroidJNI.SetStaticCharFieldDelegate SetStaticCharFieldDelegateField;

		// Token: 0x04000118 RID: 280
		private static readonly AndroidJNI.SetStaticShortFieldDelegate SetStaticShortFieldDelegateField;

		// Token: 0x04000119 RID: 281
		private static readonly AndroidJNI.SetStaticIntFieldDelegate SetStaticIntFieldDelegateField;

		// Token: 0x0400011A RID: 282
		private static readonly AndroidJNI.SetStaticLongFieldDelegate SetStaticLongFieldDelegateField;

		// Token: 0x0400011B RID: 283
		private static readonly AndroidJNI.SetStaticFloatFieldDelegate SetStaticFloatFieldDelegateField;

		// Token: 0x0400011C RID: 284
		private static readonly AndroidJNI.SetStaticDoubleFieldDelegate SetStaticDoubleFieldDelegateField;

		// Token: 0x0400011D RID: 285
		private static readonly AndroidJNI.FromObjectArrayDelegate FromObjectArrayDelegateField;

		// Token: 0x0400011E RID: 286
		private static readonly AndroidJNI.NewBooleanArrayDelegate NewBooleanArrayDelegateField;

		// Token: 0x0400011F RID: 287
		private static readonly AndroidJNI.NewSByteArrayDelegate NewSByteArrayDelegateField;

		// Token: 0x04000120 RID: 288
		private static readonly AndroidJNI.NewCharArrayDelegate NewCharArrayDelegateField;

		// Token: 0x04000121 RID: 289
		private static readonly AndroidJNI.NewShortArrayDelegate NewShortArrayDelegateField;

		// Token: 0x04000122 RID: 290
		private static readonly AndroidJNI.NewIntArrayDelegate NewIntArrayDelegateField;

		// Token: 0x04000123 RID: 291
		private static readonly AndroidJNI.NewLongArrayDelegate NewLongArrayDelegateField;

		// Token: 0x04000124 RID: 292
		private static readonly AndroidJNI.NewFloatArrayDelegate NewFloatArrayDelegateField;

		// Token: 0x04000125 RID: 293
		private static readonly AndroidJNI.NewDoubleArrayDelegate NewDoubleArrayDelegateField;

		// Token: 0x04000126 RID: 294
		private static readonly AndroidJNI.GetBooleanArrayElementDelegate GetBooleanArrayElementDelegateField;

		// Token: 0x04000127 RID: 295
		private static readonly AndroidJNI.GetSByteArrayElementDelegate GetSByteArrayElementDelegateField;

		// Token: 0x04000128 RID: 296
		private static readonly AndroidJNI.GetCharArrayElementDelegate GetCharArrayElementDelegateField;

		// Token: 0x04000129 RID: 297
		private static readonly AndroidJNI.GetShortArrayElementDelegate GetShortArrayElementDelegateField;

		// Token: 0x0400012A RID: 298
		private static readonly AndroidJNI.GetIntArrayElementDelegate GetIntArrayElementDelegateField;

		// Token: 0x0400012B RID: 299
		private static readonly AndroidJNI.GetLongArrayElementDelegate GetLongArrayElementDelegateField;

		// Token: 0x0400012C RID: 300
		private static readonly AndroidJNI.GetFloatArrayElementDelegate GetFloatArrayElementDelegateField;

		// Token: 0x0400012D RID: 301
		private static readonly AndroidJNI.GetDoubleArrayElementDelegate GetDoubleArrayElementDelegateField;

		// Token: 0x0400012E RID: 302
		private static readonly AndroidJNI.SetBooleanArrayElementDelegate SetBooleanArrayElementDelegateField;

		// Token: 0x0400012F RID: 303
		private static readonly AndroidJNI.SetSByteArrayElementDelegate SetSByteArrayElementDelegateField;

		// Token: 0x04000130 RID: 304
		private static readonly AndroidJNI.SetCharArrayElementDelegate SetCharArrayElementDelegateField;

		// Token: 0x04000131 RID: 305
		private static readonly AndroidJNI.SetShortArrayElementDelegate SetShortArrayElementDelegateField;

		// Token: 0x04000132 RID: 306
		private static readonly AndroidJNI.SetIntArrayElementDelegate SetIntArrayElementDelegateField;

		// Token: 0x04000133 RID: 307
		private static readonly AndroidJNI.SetLongArrayElementDelegate SetLongArrayElementDelegateField;

		// Token: 0x04000134 RID: 308
		private static readonly AndroidJNI.SetFloatArrayElementDelegate SetFloatArrayElementDelegateField;

		// Token: 0x04000135 RID: 309
		private static readonly AndroidJNI.SetDoubleArrayElementDelegate SetDoubleArrayElementDelegateField;

		// Token: 0x04000136 RID: 310
		private static readonly AndroidJNI.NewDirectByteBufferDelegate NewDirectByteBufferDelegateField;

		// Token: 0x04000137 RID: 311
		private static readonly AndroidJNI.GetDirectBufferCapacityDelegate GetDirectBufferCapacityDelegateField;

		// Token: 0x04000138 RID: 312
		private static readonly AndroidJNI.RegisterNativesAllocateDelegate RegisterNativesAllocateDelegateField;

		// Token: 0x04000139 RID: 313
		private static readonly AndroidJNI.RegisterNativesSetDelegate RegisterNativesSetDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly AndroidJNI.RegisterNativesAndFreeDelegate RegisterNativesAndFreeDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly AndroidJNI.UnregisterNativesDelegate UnregisterNativesDelegateField;

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x060002A0 RID: 672
		private delegate IntPtr GetJavaVMDelegate();

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x060002A2 RID: 674
		private delegate int AttachCurrentThreadDelegate();

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x060002A4 RID: 676
		private delegate int DetachCurrentThreadDelegate();

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060002A6 RID: 678
		private delegate int GetVersionDelegate();

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x060002A8 RID: 680
		private delegate IntPtr FromReflectedFieldDelegate(IntPtr refField);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x060002AA RID: 682
		private delegate IntPtr ToReflectedMethodDelegate(IntPtr clazz, IntPtr methodID, bool isStatic);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x060002AC RID: 684
		private delegate IntPtr ToReflectedFieldDelegate(IntPtr clazz, IntPtr fieldID, bool isStatic);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x060002AE RID: 686
		private delegate IntPtr GetSuperclassDelegate(IntPtr clazz);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x060002B0 RID: 688
		private delegate bool IsAssignableFromDelegate(IntPtr clazz1, IntPtr clazz2);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x060002B2 RID: 690
		private delegate int ThrowDelegate(IntPtr obj);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x060002B4 RID: 692
		private delegate int ThrowNewDelegate(IntPtr clazz, IntPtr message);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x060002B6 RID: 694
		private delegate void ExceptionDescribeDelegate();

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x060002B8 RID: 696
		private delegate void FatalErrorDelegate(IntPtr message);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x060002BA RID: 698
		private delegate int PushLocalFrameDelegate(int capacity);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x060002BC RID: 700
		private delegate IntPtr PopLocalFrameDelegate(IntPtr ptr);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x060002BE RID: 702
		private delegate void DeleteGlobalRefDelegate(IntPtr obj);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x060002C0 RID: 704
		private delegate uint GetQueueGlobalRefsCountDelegate();

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x060002C2 RID: 706
		private delegate int EnsureLocalCapacityDelegate(int capacity);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x060002C4 RID: 708
		private delegate IntPtr AllocObjectDelegate(IntPtr clazz);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x060002C6 RID: 710
		private delegate bool IsInstanceOfDelegate(IntPtr obj, IntPtr clazz);

		// Token: 0x02000040 RID: 64
		// (Invoke) Token: 0x060002C8 RID: 712
		private delegate IntPtr GetFieldIDDelegate(IntPtr clazz, IntPtr name, IntPtr sig);

		// Token: 0x02000041 RID: 65
		// (Invoke) Token: 0x060002CA RID: 714
		private delegate IntPtr GetStaticFieldIDDelegate(IntPtr clazz, IntPtr name, IntPtr sig);

		// Token: 0x02000042 RID: 66
		// (Invoke) Token: 0x060002CC RID: 716
		private delegate IntPtr NewStringDelegate(IntPtr chars);

		// Token: 0x02000043 RID: 67
		// (Invoke) Token: 0x060002CE RID: 718
		private delegate IntPtr NewStringUTFDelegate(IntPtr bytes);

		// Token: 0x02000044 RID: 68
		// (Invoke) Token: 0x060002D0 RID: 720
		private delegate int GetStringLengthDelegate(IntPtr str);

		// Token: 0x02000045 RID: 69
		// (Invoke) Token: 0x060002D2 RID: 722
		private delegate int GetStringUTFLengthDelegate(IntPtr str);

		// Token: 0x02000046 RID: 70
		// (Invoke) Token: 0x060002D4 RID: 724
		private delegate IntPtr GetStringUTFCharsDelegate(IntPtr str);

		// Token: 0x02000047 RID: 71
		// (Invoke) Token: 0x060002D6 RID: 726
		private delegate void CallVoidMethodUnsafeDelegate(IntPtr obj, IntPtr methodID, IntPtr args);

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060002D8 RID: 728
		private delegate IntPtr GetStringFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060002DA RID: 730
		private delegate IntPtr GetObjectFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060002DC RID: 732
		private delegate bool GetBooleanFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060002DE RID: 734
		private delegate sbyte GetSByteFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060002E0 RID: 736
		private delegate char GetCharFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060002E2 RID: 738
		private delegate short GetShortFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060002E4 RID: 740
		private delegate int GetIntFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060002E6 RID: 742
		private delegate long GetLongFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060002E8 RID: 744
		private delegate float GetFloatFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060002EA RID: 746
		private delegate double GetDoubleFieldDelegate(IntPtr obj, IntPtr fieldID);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060002EC RID: 748
		private delegate void SetStringFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060002EE RID: 750
		private delegate void SetObjectFieldDelegate(IntPtr obj, IntPtr fieldID, IntPtr val);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060002F0 RID: 752
		private delegate void SetBooleanFieldDelegate(IntPtr obj, IntPtr fieldID, bool val);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060002F2 RID: 754
		private delegate void SetSByteFieldDelegate(IntPtr obj, IntPtr fieldID, sbyte val);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060002F4 RID: 756
		private delegate void SetCharFieldDelegate(IntPtr obj, IntPtr fieldID, char val);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060002F6 RID: 758
		private delegate void SetShortFieldDelegate(IntPtr obj, IntPtr fieldID, short val);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060002F8 RID: 760
		private delegate void SetIntFieldDelegate(IntPtr obj, IntPtr fieldID, int val);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060002FA RID: 762
		private delegate void SetLongFieldDelegate(IntPtr obj, IntPtr fieldID, long val);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060002FC RID: 764
		private delegate void SetFloatFieldDelegate(IntPtr obj, IntPtr fieldID, float val);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060002FE RID: 766
		private delegate void SetDoubleFieldDelegate(IntPtr obj, IntPtr fieldID, double val);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x06000300 RID: 768
		private delegate void CallStaticVoidMethodUnsafeDelegate(IntPtr clazz, IntPtr methodID, IntPtr args);

		// Token: 0x0200005D RID: 93
		// (Invoke) Token: 0x06000302 RID: 770
		private delegate IntPtr GetStaticStringFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0200005E RID: 94
		// (Invoke) Token: 0x06000304 RID: 772
		private delegate IntPtr GetStaticObjectFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x0200005F RID: 95
		// (Invoke) Token: 0x06000306 RID: 774
		private delegate bool GetStaticBooleanFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000060 RID: 96
		// (Invoke) Token: 0x06000308 RID: 776
		private delegate sbyte GetStaticSByteFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000061 RID: 97
		// (Invoke) Token: 0x0600030A RID: 778
		private delegate char GetStaticCharFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000062 RID: 98
		// (Invoke) Token: 0x0600030C RID: 780
		private delegate short GetStaticShortFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x0600030E RID: 782
		private delegate int GetStaticIntFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000064 RID: 100
		// (Invoke) Token: 0x06000310 RID: 784
		private delegate long GetStaticLongFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000065 RID: 101
		// (Invoke) Token: 0x06000312 RID: 786
		private delegate float GetStaticFloatFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000066 RID: 102
		// (Invoke) Token: 0x06000314 RID: 788
		private delegate double GetStaticDoubleFieldDelegate(IntPtr clazz, IntPtr fieldID);

		// Token: 0x02000067 RID: 103
		// (Invoke) Token: 0x06000316 RID: 790
		private delegate void SetStaticStringFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x02000068 RID: 104
		// (Invoke) Token: 0x06000318 RID: 792
		private delegate void SetStaticObjectFieldDelegate(IntPtr clazz, IntPtr fieldID, IntPtr val);

		// Token: 0x02000069 RID: 105
		// (Invoke) Token: 0x0600031A RID: 794
		private delegate void SetStaticBooleanFieldDelegate(IntPtr clazz, IntPtr fieldID, bool val);

		// Token: 0x0200006A RID: 106
		// (Invoke) Token: 0x0600031C RID: 796
		private delegate void SetStaticSByteFieldDelegate(IntPtr clazz, IntPtr fieldID, sbyte val);

		// Token: 0x0200006B RID: 107
		// (Invoke) Token: 0x0600031E RID: 798
		private delegate void SetStaticCharFieldDelegate(IntPtr clazz, IntPtr fieldID, char val);

		// Token: 0x0200006C RID: 108
		// (Invoke) Token: 0x06000320 RID: 800
		private delegate void SetStaticShortFieldDelegate(IntPtr clazz, IntPtr fieldID, short val);

		// Token: 0x0200006D RID: 109
		// (Invoke) Token: 0x06000322 RID: 802
		private delegate void SetStaticIntFieldDelegate(IntPtr clazz, IntPtr fieldID, int val);

		// Token: 0x0200006E RID: 110
		// (Invoke) Token: 0x06000324 RID: 804
		private delegate void SetStaticLongFieldDelegate(IntPtr clazz, IntPtr fieldID, long val);

		// Token: 0x0200006F RID: 111
		// (Invoke) Token: 0x06000326 RID: 806
		private delegate void SetStaticFloatFieldDelegate(IntPtr clazz, IntPtr fieldID, float val);

		// Token: 0x02000070 RID: 112
		// (Invoke) Token: 0x06000328 RID: 808
		private delegate void SetStaticDoubleFieldDelegate(IntPtr clazz, IntPtr fieldID, double val);

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x0600032A RID: 810
		private delegate IntPtr FromObjectArrayDelegate(IntPtr array);

		// Token: 0x02000072 RID: 114
		// (Invoke) Token: 0x0600032C RID: 812
		private delegate IntPtr NewBooleanArrayDelegate(int size);

		// Token: 0x02000073 RID: 115
		// (Invoke) Token: 0x0600032E RID: 814
		private delegate IntPtr NewSByteArrayDelegate(int size);

		// Token: 0x02000074 RID: 116
		// (Invoke) Token: 0x06000330 RID: 816
		private delegate IntPtr NewCharArrayDelegate(int size);

		// Token: 0x02000075 RID: 117
		// (Invoke) Token: 0x06000332 RID: 818
		private delegate IntPtr NewShortArrayDelegate(int size);

		// Token: 0x02000076 RID: 118
		// (Invoke) Token: 0x06000334 RID: 820
		private delegate IntPtr NewIntArrayDelegate(int size);

		// Token: 0x02000077 RID: 119
		// (Invoke) Token: 0x06000336 RID: 822
		private delegate IntPtr NewLongArrayDelegate(int size);

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x06000338 RID: 824
		private delegate IntPtr NewFloatArrayDelegate(int size);

		// Token: 0x02000079 RID: 121
		// (Invoke) Token: 0x0600033A RID: 826
		private delegate IntPtr NewDoubleArrayDelegate(int size);

		// Token: 0x0200007A RID: 122
		// (Invoke) Token: 0x0600033C RID: 828
		private delegate bool GetBooleanArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x0600033E RID: 830
		private delegate sbyte GetSByteArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000340 RID: 832
		private delegate char GetCharArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000342 RID: 834
		private delegate short GetShortArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200007E RID: 126
		// (Invoke) Token: 0x06000344 RID: 836
		private delegate int GetIntArrayElementDelegate(IntPtr array, int index);

		// Token: 0x0200007F RID: 127
		// (Invoke) Token: 0x06000346 RID: 838
		private delegate long GetLongArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x06000348 RID: 840
		private delegate float GetFloatArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x0600034A RID: 842
		private delegate double GetDoubleArrayElementDelegate(IntPtr array, int index);

		// Token: 0x02000082 RID: 130
		// (Invoke) Token: 0x0600034C RID: 844
		private delegate void SetBooleanArrayElementDelegate(IntPtr array, int index, bool val);

		// Token: 0x02000083 RID: 131
		// (Invoke) Token: 0x0600034E RID: 846
		private delegate void SetSByteArrayElementDelegate(IntPtr array, int index, sbyte val);

		// Token: 0x02000084 RID: 132
		// (Invoke) Token: 0x06000350 RID: 848
		private delegate void SetCharArrayElementDelegate(IntPtr array, int index, char val);

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000352 RID: 850
		private delegate void SetShortArrayElementDelegate(IntPtr array, int index, short val);

		// Token: 0x02000086 RID: 134
		// (Invoke) Token: 0x06000354 RID: 852
		private delegate void SetIntArrayElementDelegate(IntPtr array, int index, int val);

		// Token: 0x02000087 RID: 135
		// (Invoke) Token: 0x06000356 RID: 854
		private delegate void SetLongArrayElementDelegate(IntPtr array, int index, long val);

		// Token: 0x02000088 RID: 136
		// (Invoke) Token: 0x06000358 RID: 856
		private delegate void SetFloatArrayElementDelegate(IntPtr array, int index, float val);

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600035A RID: 858
		private delegate void SetDoubleArrayElementDelegate(IntPtr array, int index, double val);

		// Token: 0x0200008A RID: 138
		// (Invoke) Token: 0x0600035C RID: 860
		private delegate IntPtr NewDirectByteBufferDelegate(IntPtr buffer, long capacity);

		// Token: 0x0200008B RID: 139
		// (Invoke) Token: 0x0600035E RID: 862
		private delegate long GetDirectBufferCapacityDelegate(IntPtr buffer);

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000360 RID: 864
		private delegate IntPtr RegisterNativesAllocateDelegate(int length);

		// Token: 0x0200008D RID: 141
		// (Invoke) Token: 0x06000362 RID: 866
		private delegate void RegisterNativesSetDelegate(IntPtr natives, int idx, IntPtr name, IntPtr signature, IntPtr fnPtr);

		// Token: 0x0200008E RID: 142
		// (Invoke) Token: 0x06000364 RID: 868
		private delegate int RegisterNativesAndFreeDelegate(IntPtr clazz, IntPtr natives, int n);

		// Token: 0x0200008F RID: 143
		// (Invoke) Token: 0x06000366 RID: 870
		private delegate int UnregisterNativesDelegate(IntPtr clazz);
	}
}
