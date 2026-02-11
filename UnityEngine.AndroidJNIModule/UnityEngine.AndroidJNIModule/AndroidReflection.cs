using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000009 RID: 9
	public class AndroidReflection : Object
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000053AC File Offset: 0x000035AC
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidReflection()
		{
			Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidReflection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr);
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperClass");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetConstructorID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetMethodID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldID");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperGetFieldSignature");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperNewProxyInstance");
			AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_ReflectionHelperCeateInvocationError");
			AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, "s_FieldGetDeclaringClass");
			AndroidReflection.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663345);
			AndroidReflection.NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663346);
			AndroidReflection.NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663347);
			AndroidReflection.NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663348);
			AndroidReflection.NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663349);
			AndroidReflection.NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663350);
			AndroidReflection.NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663351);
			AndroidReflection.NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidReflection>.NativeClassPtr, 100663352);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000551C File Offset: 0x0000371C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 746539, RefRangeEnd = 746543, XrefRangeStart = 746539, XrefRangeEnd = 746543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPrimitive(Type t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005560 File Offset: 0x00003760
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1228427, RefRangeEnd = 1228430, XrefRangeStart = 1228426, XrefRangeEnd = 1228427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAssignableFrom(Type t, Type from)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(from);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000055B4 File Offset: 0x000037B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228430, XrefRangeEnd = 1228437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStaticMethodID(string clazz, string methodName, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000561C File Offset: 0x0000381C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228437, XrefRangeEnd = 1228444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(string clazz, string methodName, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(clazz);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00005684 File Offset: 0x00003884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228458, RefRangeEnd = 1228459, XrefRangeStart = 1228444, XrefRangeEnd = 1228458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorMember(IntPtr jclass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000056D4 File Offset: 0x000038D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228474, RefRangeEnd = 1228475, XrefRangeStart = 1228459, XrefRangeEnd = 1228474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodMember(IntPtr jclass, string methodName, string signature, bool isStatic)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005744 File Offset: 0x00003944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1228475, XrefRangeEnd = 1228485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr NewProxyInstance(IntPtr player, IntPtr delegateHandle, IntPtr interfaze)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref player;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref interfaze;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000057A0 File Offset: 0x000039A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1228497, RefRangeEnd = 1228499, XrefRangeStart = 1228485, XrefRangeEnd = 1228497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateInvocationError(Exception ex, bool methodNotFound)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref methodNotFound;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidReflection.NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002350 File Offset: 0x00000550
		public AndroidReflection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00002359 File Offset: 0x00000559
		public unsafe static GlobalJavaObjectRef s_ReflectionHelperClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperClass, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00005818 File Offset: 0x00003A18
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000236B File Offset: 0x0000056B
		public unsafe static IntPtr s_ReflectionHelperGetConstructorID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID, (void*)(&value));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00005834 File Offset: 0x00003A34
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002379 File Offset: 0x00000579
		public unsafe static IntPtr s_ReflectionHelperGetMethodID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetMethodID, (void*)(&value));
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00005850 File Offset: 0x00003A50
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002387 File Offset: 0x00000587
		public unsafe static IntPtr s_ReflectionHelperGetFieldID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldID, (void*)(&value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000586C File Offset: 0x00003A6C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002395 File Offset: 0x00000595
		public unsafe static IntPtr s_ReflectionHelperGetFieldSignature
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00005888 File Offset: 0x00003A88
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000023A3 File Offset: 0x000005A3
		public unsafe static IntPtr s_ReflectionHelperNewProxyInstance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000095 RID: 149 RVA: 0x000058A4 File Offset: 0x00003AA4
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000023B1 File Offset: 0x000005B1
		public unsafe static IntPtr s_ReflectionHelperCeateInvocationError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError, (void*)(&value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000097 RID: 151 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe static IntPtr s_FieldGetDeclaringClass
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidReflection.NativeFieldInfoPtr_s_FieldGetDeclaringClass, (void*)(&value));
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000023CD File Offset: 0x000005CD
		public static IntPtr GetFieldMember(IntPtr jclass, string fieldName, string signature, bool isStatic)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000058DC File Offset: 0x00003ADC
		public static IntPtr GetFieldClass(IntPtr field)
		{
			return AndroidJNISafe.CallObjectMethod(field, AndroidReflection.s_FieldGetDeclaringClass, null);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000023DA File Offset: 0x000005DA
		public static string GetFieldSignature(IntPtr field)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperClass;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetConstructorID;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetMethodID;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldID;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperGetFieldSignature;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperNewProxyInstance;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr_s_ReflectionHelperCeateInvocationError;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr_s_FieldGetDeclaringClass;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_IsPrimitive_Public_Static_Boolean_Type_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_IsAssignableFrom_Public_Static_Boolean_Type_Type_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_GetStaticMethodID_Private_Static_IntPtr_String_String_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Private_Static_IntPtr_String_String_String_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorMember_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodMember_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_NewProxyInstance_Public_Static_IntPtr_IntPtr_IntPtr_IntPtr_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_CreateInvocationError_Internal_Static_IntPtr_Exception_Boolean_0;

		// Token: 0x04000048 RID: 72
		public const string RELECTION_HELPER_CLASS_NAME = "com/unity3d/player/ReflectionHelper";
	}
}
