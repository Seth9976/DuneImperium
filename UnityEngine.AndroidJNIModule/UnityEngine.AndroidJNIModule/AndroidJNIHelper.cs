using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public static class AndroidJNIHelper : Object
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00006138 File Offset: 0x00004338
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJNIHelper()
		{
			Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJNIHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr);
			AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663372);
			AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663373);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663374);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663375);
			AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663376);
			AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663377);
			AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663378);
			AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663379);
			AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663380);
			AndroidJNIHelper.NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663381);
			AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663382);
			AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr, 100663383);
			AndroidJNIHelper.get_debugDelegateField = IL2CPP.ResolveICall<AndroidJNIHelper.get_debugDelegate>("UnityEngine.AndroidJNIHelper::get_debug");
			AndroidJNIHelper.set_debugDelegateField = IL2CPP.ResolveICall<AndroidJNIHelper.set_debugDelegate>("UnityEngine.AndroidJNIHelper::set_debug");
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006278 File Offset: 0x00004478
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229455, XrefRangeEnd = 1229456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetConstructorID(IntPtr javaClass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000062C8 File Offset: 0x000044C8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1229457, RefRangeEnd = 1229459, XrefRangeStart = 1229456, XrefRangeEnd = 1229457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature, bool isStatic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref javaClass;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isStatic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00006338 File Offset: 0x00004538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228528, RefRangeEnd = 1228529, XrefRangeStart = 1228528, XrefRangeEnd = 1228529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaRunnable(AndroidJavaRunnable jrunnable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(jrunnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000637C File Offset: 0x0000457C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229476, RefRangeEnd = 1229479, XrefRangeStart = 1229459, XrefRangeEnd = 1229476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CreateJavaProxy(AndroidJavaProxy proxy)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(proxy);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x000063C0 File Offset: 0x000045C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1229481, RefRangeEnd = 1229484, XrefRangeStart = 1229479, XrefRangeEnd = 1229481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateJNIArgArray(Il2CppReferenceArray<Object> args, Span<jvalue> jniArgs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(jniArgs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00006410 File Offset: 0x00004610
		[CallerCount(45)]
		[CachedScanResults(RefRangeStart = 1229498, RefRangeEnd = 1229543, XrefRangeStart = 1229484, XrefRangeEnd = 1229498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00006460 File Offset: 0x00004660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000064B0 File Offset: 0x000046B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229543, XrefRangeEnd = 1229556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ArrayType ConvertFromJNIArray<ArrayType>(IntPtr array)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref array;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ArrayType>(intPtr, false, true);
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000064EC File Offset: 0x000046EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229556, XrefRangeEnd = 1229566, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000655C File Offset: 0x0000475C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1229577, RefRangeEnd = 1229581, XrefRangeStart = 1229566, XrefRangeEnd = 1229577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Box(jvalue val, string boxedClass, string signature)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref val;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(boxedClass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(signature);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000065C0 File Offset: 0x000047C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229581, XrefRangeEnd = 1229586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Box(int value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00006600 File Offset: 0x00004800
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1229586, XrefRangeEnd = 1229591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr Box(bool value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJNIHelper.NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000240F File Offset: 0x0000060F
		public AndroidJNIHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00002418 File Offset: 0x00000618
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00002424 File Offset: 0x00000624
		public static bool debug
		{
			get
			{
				return AndroidJNIHelper.get_debugDelegateField();
			}
			set
			{
				AndroidJNIHelper.set_debugDelegateField(value);
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00006640 File Offset: 0x00004840
		public static IntPtr GetConstructorID(IntPtr javaClass)
		{
			return AndroidJNIHelper.GetConstructorID(javaClass, "");
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00006660 File Offset: 0x00004860
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName)
		{
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, "", false);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00006680 File Offset: 0x00004880
		public static IntPtr GetMethodID(IntPtr javaClass, string methodName, string signature)
		{
			return AndroidJNIHelper.GetMethodID(javaClass, methodName, signature, false);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000669C File Offset: 0x0000489C
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName)
		{
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, "", false);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000066BC File Offset: 0x000048BC
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature)
		{
			return AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, false);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000066D8 File Offset: 0x000048D8
		public static IntPtr GetFieldID(IntPtr javaClass, string fieldName, string signature, bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID(javaClass, fieldName, signature, isStatic);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000066F4 File Offset: 0x000048F4
		public static IntPtr ConvertToJNIArray(Array array)
		{
			return _AndroidJNIHelper.ConvertToJNIArray(array);
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00002431 File Offset: 0x00000631
		public static Il2CppStructArray<jvalue> CreateJNIArgArray(Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000243E File Offset: 0x0000063E
		public static void DeleteJNIArgArray(Il2CppReferenceArray<Object> args, Il2CppStructArray<jvalue> jniArgs)
		{
			_AndroidJNIHelper.DeleteJNIArgArray(args, jniArgs);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000670C File Offset: 0x0000490C
		public static string GetSignature(Object obj)
		{
			return _AndroidJNIHelper.GetSignature(obj);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00006724 File Offset: 0x00004924
		public static string GetSignature(Il2CppReferenceArray<Object> args)
		{
			return _AndroidJNIHelper.GetSignature(args);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000673C File Offset: 0x0000493C
		public static IntPtr GetFieldID<FieldType>(IntPtr jclass, string fieldName, bool isStatic)
		{
			return _AndroidJNIHelper.GetFieldID<FieldType>(jclass, fieldName, isStatic);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00006758 File Offset: 0x00004958
		public static string GetSignature<ReturnType>(Il2CppReferenceArray<Object> args)
		{
			return _AndroidJNIHelper.GetSignature<ReturnType>(args);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00006770 File Offset: 0x00004970
		public static IntPtr Box(sbyte value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				b = value
			}, "java/lang/Byte", "(B)Ljava/lang/Byte;");
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000067A4 File Offset: 0x000049A4
		public static IntPtr Box(short value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				s = value
			}, "java/lang/Short", "(S)Ljava/lang/Short;");
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000067D8 File Offset: 0x000049D8
		public static IntPtr Box(long value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				j = value
			}, "java/lang/Long", "(J)Ljava/lang/Long;");
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000680C File Offset: 0x00004A0C
		public static IntPtr Box(float value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				f = value
			}, "java/lang/Float", "(F)Ljava/lang/Float;");
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00006840 File Offset: 0x00004A40
		public static IntPtr Box(double value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				d = value
			}, "java/lang/Double", "(D)Ljava/lang/Double;");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00006874 File Offset: 0x00004A74
		public static IntPtr Box(char value)
		{
			return AndroidJNIHelper.Box(new jvalue
			{
				c = value
			}, "java/lang/Character", "(C)Ljava/lang/Character;");
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000068A8 File Offset: 0x00004AA8
		public static IntPtr GetUnboxMethod(IntPtr obj, string methodName, string signature)
		{
			IntPtr objectClass = AndroidJNISafe.GetObjectClass(obj);
			IntPtr methodID;
			try
			{
				methodID = AndroidJNISafe.GetMethodID(objectClass, methodName, signature);
			}
			finally
			{
				AndroidJNISafe.DeleteLocalRef(objectClass);
			}
			return methodID;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000068E4 File Offset: 0x00004AE4
		public static void Unbox(IntPtr obj, out sbyte value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "byteValue", "()B");
			value = AndroidJNISafe.CallSByteMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00006918 File Offset: 0x00004B18
		public static void Unbox(IntPtr obj, out short value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "shortValue", "()S");
			value = AndroidJNISafe.CallShortMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000694C File Offset: 0x00004B4C
		public static void Unbox(IntPtr obj, out int value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "intValue", "()I");
			value = AndroidJNISafe.CallIntMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00006980 File Offset: 0x00004B80
		public static void Unbox(IntPtr obj, out long value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "longValue", "()J");
			value = AndroidJNISafe.CallLongMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000069B4 File Offset: 0x00004BB4
		public static void Unbox(IntPtr obj, out float value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "floatValue", "()F");
			value = AndroidJNISafe.CallFloatMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000069E8 File Offset: 0x00004BE8
		public static void Unbox(IntPtr obj, out double value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "doubleValue", "()D");
			value = AndroidJNISafe.CallDoubleMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00006A1C File Offset: 0x00004C1C
		public static void Unbox(IntPtr obj, out char value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "charValue", "()C");
			value = AndroidJNISafe.CallCharMethod(obj, unboxMethod, null);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00006A50 File Offset: 0x00004C50
		public static void Unbox(IntPtr obj, out bool value)
		{
			IntPtr unboxMethod = AndroidJNIHelper.GetUnboxMethod(obj, "booleanValue", "()Z");
			value = AndroidJNISafe.CallBooleanMethod(obj, unboxMethod, null);
		}

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_String_Boolean_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaRunnable_Public_Static_IntPtr_AndroidJavaRunnable_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_CreateJavaProxy_Public_Static_IntPtr_AndroidJavaProxy_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_CreateJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_DeleteJNIArgArray_Public_Static_Void_Il2CppReferenceArray_1_Object_Span_1_jvalue_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_GetConstructorID_Public_Static_IntPtr_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_Box_Private_Static_IntPtr_jvalue_String_String_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_IntPtr_Int32_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr_Box_Public_Static_IntPtr_Boolean_0;

		// Token: 0x04000079 RID: 121
		private static readonly AndroidJNIHelper.get_debugDelegate get_debugDelegateField;

		// Token: 0x0400007A RID: 122
		private static readonly AndroidJNIHelper.set_debugDelegate set_debugDelegateField;

		// Token: 0x02000028 RID: 40
		private sealed class MethodInfoStoreGeneric_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0<ArrayType>
		{
			// Token: 0x0400019F RID: 415
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_ConvertFromJNIArray_Public_Static_ArrayType_IntPtr_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ArrayType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000029 RID: 41
		private sealed class MethodInfoStoreGeneric_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0<ReturnType>
		{
			// Token: 0x040001A0 RID: 416
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJNIHelper.NativeMethodInfoPtr_GetMethodID_Public_Static_IntPtr_IntPtr_String_Il2CppReferenceArray_1_Object_Boolean_0, Il2CppClassPointerStore<AndroidJNIHelper>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600029C RID: 668
		private delegate bool get_debugDelegate();

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600029E RID: 670
		private delegate void set_debugDelegate(bool value);
	}
}
