using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200000A RID: 10
	public sealed class _AndroidJNIHelper : Object
	{
		// Token: 0x0600009C RID: 156 RVA: 0x000058FC File Offset: 0x00003AFC
		// Note: this type is marked as 'beforefieldinit'.
		static _AndroidJNIHelper()
		{
			Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "_AndroidJNIHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663354);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663355);
			_AndroidJNIHelper.NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663356);
			_AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663357);
			_AndroidJNIHelper.NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663358);
			_AndroidJNIHelper.NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663359);
			_AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663360);
			_AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663361);
			_AndroidJNIHelper.NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663362);
			_AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663363);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663364);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663365);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663366);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663367);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663368);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663369);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663370);
			_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr, 100663371);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00005A94 File Offset: 0x00003C94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228499, XrefRangeEnd = 1228512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaProxy(IntPtr player, IntPtr delegateHandle, AndroidJavaProxy proxy)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref player;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005AF4 File Offset: 0x00003CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228528, RefRangeEnd = 1228529, XrefRangeStart = 1228512, XrefRangeEnd = 1228528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jrunnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005B38 File Offset: 0x00003D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228529, XrefRangeEnd = 1228535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr InvokeJavaProxyMethod(AndroidJavaProxy proxy, IntPtr jmethodName, IntPtr jargs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jmethodName;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref jargs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00005B98 File Offset: 0x00003D98
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1228607, RefRangeEnd = 1228609, XrefRangeStart = 1228535, XrefRangeEnd = 1228607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateJNIArgArray(Il2CppReferenceArray<Object> args, Span<jvalue> ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(ret));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00005BE8 File Offset: 0x00003DE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228737, RefRangeEnd = 1228738, XrefRangeStart = 1228609, XrefRangeEnd = 1228737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object UnboxArray(AndroidJavaObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00005C2C File Offset: 0x00003E2C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1228919, RefRangeEnd = 1228921, XrefRangeStart = 1228738, XrefRangeEnd = 1228919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Unbox(AndroidJavaObject obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00005C70 File Offset: 0x00003E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228955, RefRangeEnd = 1228956, XrefRangeStart = 1228921, XrefRangeEnd = 1228955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject Box(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00005CB4 File Offset: 0x00003EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228956, XrefRangeEnd = 1228970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeleteJNIArgArray(Il2CppReferenceArray<Object> args, Span<jvalue> jniArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jniArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005D04 File Offset: 0x00003F04
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229154, RefRangeEnd = 1229155, XrefRangeStart = 1228970, XrefRangeEnd = 1229154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr ConvertToJNIArray(Array array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005D48 File Offset: 0x00003F48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229255, RefRangeEnd = 1229257, XrefRangeStart = 1229155, XrefRangeEnd = 1229255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ArrayType>(intPtr, false, true);
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00005D84 File Offset: 0x00003F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229257, XrefRangeEnd = 1229274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr jclass, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00005DD4 File Offset: 0x00003FD4
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1229279, RefRangeEnd = 1229292, XrefRangeStart = 1229274, XrefRangeEnd = 1229279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID<ReturnType>(IntPtr jclass, string methodName, Il2CppReferenceArray<Object> args, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00005E44 File Offset: 0x00004044
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1229307, RefRangeEnd = 1229311, XrefRangeStart = 1229292, XrefRangeEnd = 1229307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr jclass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00005E94 File Offset: 0x00004094
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229325, RefRangeEnd = 1229326, XrefRangeStart = 1229311, XrefRangeEnd = 1229325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00005F04 File Offset: 0x00004104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229330, RefRangeEnd = 1229331, XrefRangeStart = 1229326, XrefRangeEnd = 1229330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodIDFallback(IntPtr jclass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00005F74 File Offset: 0x00004174
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1229410, RefRangeEnd = 1229417, XrefRangeStart = 1229331, XrefRangeEnd = 1229410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00005FB0 File Offset: 0x000041B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229417, XrefRangeEnd = 1229430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00005FEC File Offset: 0x000041EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1229454, RefRangeEnd = 1229455, XrefRangeStart = 1229430, XrefRangeEnd = 1229454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetSignature<ReturnType>(Il2CppReferenceArray<Object> args)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(_AndroidJNIHelper.MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023E7 File Offset: 0x000005E7
		public _AndroidJNIHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00006028 File Offset: 0x00004228
		public static IntPtr GetFieldID<ReturnType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return AndroidJNIHelper.GetFieldID(jclass, fieldName, _AndroidJNIHelper.GetSignature(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ReturnType>())), isStatic);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000023F0 File Offset: 0x000005F0
		public static IntPtr GetFieldID(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_IntPtr_IntPtr_AndroidJavaProxy_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_InvokeJavaProxyMethod_Public_Static_IntPtr_AndroidJavaProxy_IntPtr_IntPtr_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_UnboxArray_Public_Static_Object_AndroidJavaObject_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Unbox_Public_Static_Object_AndroidJavaObject_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_AndroidJavaObject_Object_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToJNIArray_Public_Static_IntPtr_Array_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodIDFallback_Private_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Object_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x02000025 RID: 37
		private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
		{
			// Token: 0x0400019C RID: 412
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000026 RID: 38
		private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
		{
			// Token: 0x0400019D RID: 413
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000027 RID: 39
		private sealed class MethodInfoStoreGeneric_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x0400019E RID: 414
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(_AndroidJNIHelper.NativeMethodInfoPtr_GetSignature_Public_Static_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<_AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}
	}
}
