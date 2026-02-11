using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000006 RID: 6
	public class AndroidJavaProxy : Object
	{
		// Token: 0x0600001E RID: 30 RVA: 0x0000321C File Offset: 0x0000141C
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaProxy()
		{
			Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaProxy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr);
			AndroidJavaProxy.NativeFieldInfoPtr_javaInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "javaInterface");
			AndroidJavaProxy.NativeFieldInfoPtr_proxyObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "proxyObject");
			AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "s_JavaLangSystemClass");
			AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, "s_HashCodeMethodID");
			AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663308);
			AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663309);
			AndroidJavaProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663310);
			AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663311);
			AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663312);
			AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_String_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663313);
			AndroidJavaProxy.NativeMethodInfoPtr_equals_Public_Virtual_New_Boolean_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663314);
			AndroidJavaProxy.NativeMethodInfoPtr_hashCode_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663315);
			AndroidJavaProxy.NativeMethodInfoPtr_toString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663316);
			AndroidJavaProxy.NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663317);
			AndroidJavaProxy.NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr, 100663318);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003378 File Offset: 0x00001578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227326, XrefRangeEnd = 1227332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaProxy(string javaInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(javaInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000033C4 File Offset: 0x000015C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227332, XrefRangeEnd = 1227334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaProxy(AndroidJavaClass javaInterface)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaProxy>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(javaInterface);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003410 File Offset: 0x00001610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227334, XrefRangeEnd = 1227340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000344C File Offset: 0x0000164C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227340, XrefRangeEnd = 1227413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject Invoke(string methodName, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000034BC File Offset: 0x000016BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227413, XrefRangeEnd = 1227427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual AndroidJavaObject Invoke(string methodName, Il2CppReferenceArray<AndroidJavaObject> javaArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(javaArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000352C File Offset: 0x0000172C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227472, RefRangeEnd = 1227473, XrefRangeStart = 1227427, XrefRangeEnd = 1227472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IntPtr Invoke(string methodName, IntPtr javaArgs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref javaArgs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_String_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003594 File Offset: 0x00001794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227473, XrefRangeEnd = 1227477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool equals(AndroidJavaObject obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_equals_Public_Virtual_New_Boolean_AndroidJavaObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000035EC File Offset: 0x000017EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227477, XrefRangeEnd = 1227485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int hashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_hashCode_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003634 File Offset: 0x00001834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227485, XrefRangeEnd = 1227489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string toString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaProxy.NativeMethodInfoPtr_toString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003678 File Offset: 0x00001878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227489, XrefRangeEnd = 1227491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject GetProxyObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000036B8 File Offset: 0x000018B8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1227501, RefRangeEnd = 1227505, XrefRangeStart = 1227491, XrefRangeEnd = 1227501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntPtr GetRawProxy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaProxy.NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000210F File Offset: 0x0000030F
		public AndroidJavaProxy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002B RID: 43 RVA: 0x000036F4 File Offset: 0x000018F4
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002118 File Offset: 0x00000318
		public unsafe AndroidJavaClass javaInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_javaInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_javaInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003724 File Offset: 0x00001924
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002137 File Offset: 0x00000337
		public unsafe IntPtr proxyObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_proxyObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaProxy.NativeFieldInfoPtr_proxyObject)) = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000374C File Offset: 0x0000194C
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002152 File Offset: 0x00000352
		public unsafe static GlobalJavaObjectRef s_JavaLangSystemClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaProxy.NativeFieldInfoPtr_s_JavaLangSystemClass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003774 File Offset: 0x00001974
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002164 File Offset: 0x00000364
		public unsafe static IntPtr s_HashCodeMethodID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaProxy.NativeFieldInfoPtr_s_HashCodeMethodID, (void*)(&value));
			}
		}

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeFieldInfoPtr_javaInterface;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeFieldInfoPtr_proxyObject;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeFieldInfoPtr_s_JavaLangSystemClass;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeFieldInfoPtr_s_HashCodeMethodID;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AndroidJavaClass_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_AndroidJavaObject_String_Il2CppReferenceArray_1_AndroidJavaObject_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_IntPtr_String_IntPtr_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_equals_Public_Virtual_New_Boolean_AndroidJavaObject_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_hashCode_Public_Virtual_New_Int32_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_toString_Public_Virtual_New_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_GetProxyObject_Internal_AndroidJavaObject_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_GetRawProxy_Internal_IntPtr_0;
	}
}
