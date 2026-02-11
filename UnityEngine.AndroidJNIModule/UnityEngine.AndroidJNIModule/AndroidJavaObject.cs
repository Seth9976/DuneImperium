using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000007 RID: 7
	public class AndroidJavaObject : Object
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00003790 File Offset: 0x00001990
		// Note: this type is marked as 'beforefieldinit'.
		static AndroidJavaObject()
		{
			Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.AndroidJNIModule.dll", "UnityEngine", "AndroidJavaObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr);
			AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "enableDebugPrints");
			AndroidJavaObject.NativeFieldInfoPtr_m_jobject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "m_jobject");
			AndroidJavaObject.NativeFieldInfoPtr_m_jclass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, "m_jclass");
			AndroidJavaObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663320);
			AndroidJavaObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663322);
			AndroidJavaObject.NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663323);
			AndroidJavaObject.NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663324);
			AndroidJavaObject.NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663325);
			AndroidJavaObject.NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663326);
			AndroidJavaObject.NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663327);
			AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663328);
			AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663329);
			AndroidJavaObject.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663330);
			AndroidJavaObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663331);
			AndroidJavaObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663332);
			AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663333);
			AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663334);
			AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663335);
			AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663336);
			AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663337);
			AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663338);
			AndroidJavaObject.NativeMethodInfoPtr_FromJavaArrayDeleteLocalRef_Internal_Static_ReturnType_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663339);
			AndroidJavaObject.NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663340);
			AndroidJavaObject.NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr, 100663341);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000039A0 File Offset: 0x00001BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227505, XrefRangeEnd = 1227507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject(string className, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003A0C File Offset: 0x00001C0C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227511, RefRangeEnd = 1227512, XrefRangeStart = 1227507, XrefRangeEnd = 1227511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003A40 File Offset: 0x00001C40
		[CallerCount(0)]
		public unsafe IntPtr GetRawObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003A7C File Offset: 0x00001C7C
		[CallerCount(0)]
		public unsafe IntPtr GetRawClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003AB8 File Offset: 0x00001CB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1227554, RefRangeEnd = 1227558, XrefRangeStart = 1227512, XrefRangeEnd = 1227554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003B24 File Offset: 0x00001D24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227570, RefRangeEnd = 1227571, XrefRangeStart = 1227558, XrefRangeEnd = 1227570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType CallStatic<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003B90 File Offset: 0x00001D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227571, XrefRangeEnd = 1227577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DebugPrint(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003BD4 File Offset: 0x00001DD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227614, RefRangeEnd = 1227615, XrefRangeStart = 1227577, XrefRangeEnd = 1227614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaObject(string className, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(className);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003C38 File Offset: 0x00001E38
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227636, RefRangeEnd = 1227637, XrefRangeStart = 1227615, XrefRangeEnd = 1227636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _AndroidJavaObject(IntPtr constructorID, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref constructorID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__AndroidJavaObject_Private_Void_IntPtr_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003C98 File Offset: 0x00001E98
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AndroidJavaObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003CD4 File Offset: 0x00001ED4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaObject.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003D10 File Offset: 0x00001F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227637, XrefRangeEnd = 1227647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AndroidJavaObject.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003D5C File Offset: 0x00001F5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227647, XrefRangeEnd = 1227652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _Call<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1227879, RefRangeEnd = 1227881, XrefRangeStart = 1227652, XrefRangeEnd = 1227879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _Call<ReturnType>(IntPtr methodID, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__Call_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003E30 File Offset: 0x00002030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227881, XrefRangeEnd = 1228116, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _CallStatic<ReturnType>(string methodName, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(methodName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003E9C File Offset: 0x0000209C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1228341, RefRangeEnd = 1228343, XrefRangeStart = 1228116, XrefRangeEnd = 1228341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReturnType _CallStatic<ReturnType>(IntPtr methodID, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref methodID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0<ReturnType>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003F04 File Offset: 0x00002104
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1228352, RefRangeEnd = 1228357, XrefRangeStart = 1228343, XrefRangeEnd = 1228352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaObject AndroidJavaObjectDeleteLocalRef(IntPtr jobject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003F44 File Offset: 0x00002144
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1228366, RefRangeEnd = 1228369, XrefRangeStart = 1228357, XrefRangeEnd = 1228366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AndroidJavaClass AndroidJavaClassDeleteLocalRef(IntPtr jclass)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jclass;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AndroidJavaClass>(intPtr3) : null;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003F84 File Offset: 0x00002184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1228379, RefRangeEnd = 1228380, XrefRangeStart = 1228369, XrefRangeEnd = 1228379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ReturnType FromJavaArrayDeleteLocalRef<ReturnType>(IntPtr jobject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref jobject;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.MethodInfoStoreGeneric_FromJavaArrayDeleteLocalRef_Internal_Static_ReturnType_IntPtr_0<ReturnType>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<ReturnType>(intPtr, false, true);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003FC0 File Offset: 0x000021C0
		[CallerCount(0)]
		public unsafe IntPtr _GetRawObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003FFC File Offset: 0x000021FC
		[CallerCount(0)]
		public unsafe IntPtr _GetRawClass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AndroidJavaObject.NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002172 File Offset: 0x00000372
		public AndroidJavaObject(string className, params Object[] args)
			: this(className, new Il2CppReferenceArray<Object>(args))
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002181 File Offset: 0x00000381
		public ReturnType Call<ReturnType>(string methodName, params Object[] args)
		{
			return this.Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002190 File Offset: 0x00000390
		public ReturnType CallStatic<ReturnType>(string methodName, params Object[] args)
		{
			return this.CallStatic(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000219F File Offset: 0x0000039F
		public void _AndroidJavaObject(string className, params Object[] args)
		{
			this._AndroidJavaObject(className, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000021AE File Offset: 0x000003AE
		public void _AndroidJavaObject(IntPtr constructorID, params Object[] args)
		{
			this._AndroidJavaObject(constructorID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000021BD File Offset: 0x000003BD
		public ReturnType _Call<ReturnType>(string methodName, params Object[] args)
		{
			return this._Call(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021CC File Offset: 0x000003CC
		public ReturnType _Call<ReturnType>(IntPtr methodID, params Object[] args)
		{
			return this._Call(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000021DB File Offset: 0x000003DB
		public ReturnType _CallStatic<ReturnType>(string methodName, params Object[] args)
		{
			return this._CallStatic(methodName, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000021EA File Offset: 0x000003EA
		public ReturnType _CallStatic<ReturnType>(IntPtr methodID, params Object[] args)
		{
			return this._CallStatic(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000021F9 File Offset: 0x000003F9
		public AndroidJavaObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00004038 File Offset: 0x00002238
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002202 File Offset: 0x00000402
		public unsafe static bool enableDebugPrints
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AndroidJavaObject.NativeFieldInfoPtr_enableDebugPrints, (void*)(&value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00004054 File Offset: 0x00002254
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002210 File Offset: 0x00000410
		public unsafe GlobalJavaObjectRef m_jobject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jobject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jobject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00004084 File Offset: 0x00002284
		// (set) Token: 0x06000058 RID: 88 RVA: 0x0000222F File Offset: 0x0000042F
		public unsafe GlobalJavaObjectRef m_jclass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jclass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GlobalJavaObjectRef>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AndroidJavaObject.NativeFieldInfoPtr_m_jclass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000224E File Offset: 0x0000044E
		public void Call<T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000225B File Offset: 0x0000045B
		public void Call<T>(IntPtr methodID, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002268 File Offset: 0x00000468
		public void Call(IntPtr methodID, Il2CppReferenceArray<Object> args)
		{
			this._Call(methodID, args);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002274 File Offset: 0x00000474
		public void Call(IntPtr methodID, params Object[] args)
		{
			this.Call(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002283 File Offset: 0x00000483
		public void CallStatic<T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002290 File Offset: 0x00000490
		public void CallStatic<T>(IntPtr methodID, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000229D File Offset: 0x0000049D
		public void CallStatic(IntPtr methodID, Il2CppReferenceArray<Object> args)
		{
			this._CallStatic(methodID, args);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000022A9 File Offset: 0x000004A9
		public void CallStatic(IntPtr methodID, params Object[] args)
		{
			this.CallStatic(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000040B4 File Offset: 0x000022B4
		public FieldType Get<FieldType>(string fieldName)
		{
			return this._Get<FieldType>(fieldName);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000040D0 File Offset: 0x000022D0
		public FieldType Get<FieldType>(IntPtr fieldID)
		{
			return this._Get<FieldType>(fieldID);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000022B8 File Offset: 0x000004B8
		public void Set<FieldType>(string fieldName, FieldType val)
		{
			this._Set<FieldType>(fieldName, val);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000022C4 File Offset: 0x000004C4
		public void Set<FieldType>(IntPtr fieldID, FieldType val)
		{
			this._Set<FieldType>(fieldID, val);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000040EC File Offset: 0x000022EC
		public FieldType GetStatic<FieldType>(string fieldName)
		{
			return this._GetStatic<FieldType>(fieldName);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004108 File Offset: 0x00002308
		public FieldType GetStatic<FieldType>(IntPtr fieldID)
		{
			return this._GetStatic<FieldType>(fieldID);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000022D0 File Offset: 0x000004D0
		public void SetStatic<FieldType>(string fieldName, FieldType val)
		{
			this._SetStatic<FieldType>(fieldName, val);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000022DC File Offset: 0x000004DC
		public void SetStatic<FieldType>(IntPtr fieldID, FieldType val)
		{
			this._SetStatic<FieldType>(fieldID, val);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004124 File Offset: 0x00002324
		public AndroidJavaObject CloneReference()
		{
			bool flag = this.m_jclass == null;
			if (flag)
			{
				throw new Exception("Cannot clone a disposed reference");
			}
			bool flag2 = this.m_jobject != null;
			AndroidJavaObject androidJavaObject;
			if (flag2)
			{
				androidJavaObject = new AndroidJavaObject
				{
					m_jobject = new GlobalJavaObjectRef(this.m_jobject),
					m_jclass = new GlobalJavaObjectRef(this.m_jclass)
				};
			}
			else
			{
				androidJavaObject = new AndroidJavaClass(this.m_jclass);
			}
			return androidJavaObject;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022E8 File Offset: 0x000004E8
		public ReturnType Call<ReturnType, T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000022F5 File Offset: 0x000004F5
		public ReturnType Call<ReturnType, T>(IntPtr methodID, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000041A4 File Offset: 0x000023A4
		public ReturnType Call<ReturnType>(IntPtr methodID, Il2CppReferenceArray<Object> args)
		{
			return this._Call<ReturnType>(methodID, args);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002302 File Offset: 0x00000502
		public ReturnType Call<ReturnType>(IntPtr methodID, params Object[] args)
		{
			return this.Call(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002311 File Offset: 0x00000511
		public ReturnType CallStatic<ReturnType, T>(string methodName, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000231E File Offset: 0x0000051E
		public ReturnType CallStatic<ReturnType, T>(IntPtr methodID, Il2CppArrayBase<T> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000041C0 File Offset: 0x000023C0
		public ReturnType CallStatic<ReturnType>(IntPtr methodID, Il2CppReferenceArray<Object> args)
		{
			return this._CallStatic<ReturnType>(methodID, args);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000232B File Offset: 0x0000052B
		public ReturnType CallStatic<ReturnType>(IntPtr methodID, params Object[] args)
		{
			return this.CallStatic(methodID, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000233A File Offset: 0x0000053A
		public void DebugPrint(string call, string methodName, string signature, Il2CppReferenceArray<Object> args)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000041DC File Offset: 0x000023DC
		public FieldType _Get<FieldType>(string fieldName)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, false);
			return this._Get<FieldType>(fieldID);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004208 File Offset: 0x00002408
		public FieldType _Get<FieldType>(IntPtr fieldID)
		{
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			FieldType fieldType;
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					fieldType = AndroidJNISafe.GetIntField(this.m_jobject, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						fieldType = AndroidJNISafe.GetBooleanField(this.m_jobject, fieldID).Cast<FieldType>();
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java get field call is obsolete, use field type <SByte> instead");
							fieldType = ((byte)AndroidJNISafe.GetSByteField(this.m_jobject, fieldID)).Cast<FieldType>();
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								fieldType = AndroidJNISafe.GetSByteField(this.m_jobject, fieldID).Cast<FieldType>();
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									fieldType = AndroidJNISafe.GetShortField(this.m_jobject, fieldID).Cast<FieldType>();
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										fieldType = AndroidJNISafe.GetLongField(this.m_jobject, fieldID).Cast<FieldType>();
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											fieldType = AndroidJNISafe.GetFloatField(this.m_jobject, fieldID).Cast<FieldType>();
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												fieldType = AndroidJNISafe.GetDoubleField(this.m_jobject, fieldID).Cast<FieldType>();
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													fieldType = AndroidJNISafe.GetCharField(this.m_jobject, fieldID).Cast<FieldType>();
												}
												else
												{
													fieldType = default(FieldType);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					fieldType = AndroidJNISafe.GetStringField(this.m_jobject, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						IntPtr objectField = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
						fieldType = ((objectField == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaClassDeleteLocalRef(objectField).Cast<FieldType>());
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							IntPtr objectField2 = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
							fieldType = ((objectField2 == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaObjectDeleteLocalRef(objectField2).Cast<FieldType>());
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (!flag14)
							{
								string text = "JNI: Unknown field type '";
								Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
								throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
							}
							IntPtr objectField3 = AndroidJNISafe.GetObjectField(this.m_jobject, fieldID);
							fieldType = AndroidJavaObject.FromJavaArrayDeleteLocalRef<FieldType>(objectField3);
						}
					}
				}
			}
			return fieldType;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000045EC File Offset: 0x000027EC
		public void _Set<FieldType>(string fieldName, FieldType val)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, false);
			this._Set<FieldType>(fieldID, val);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00004618 File Offset: 0x00002818
		public void _Set<FieldType>(IntPtr fieldID, FieldType val)
		{
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					AndroidJNISafe.SetIntField(this.m_jobject, fieldID, (int)((object)val));
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						AndroidJNISafe.SetBooleanField(this.m_jobject, fieldID, (bool)((object)val));
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java set field call is obsolete, use field type <SByte> instead");
							AndroidJNISafe.SetSByteField(this.m_jobject, fieldID, (sbyte)((byte)((object)val)));
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								AndroidJNISafe.SetSByteField(this.m_jobject, fieldID, (sbyte)((object)val));
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									AndroidJNISafe.SetShortField(this.m_jobject, fieldID, (short)((object)val));
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										AndroidJNISafe.SetLongField(this.m_jobject, fieldID, (long)((object)val));
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											AndroidJNISafe.SetFloatField(this.m_jobject, fieldID, (float)((object)val));
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												AndroidJNISafe.SetDoubleField(this.m_jobject, fieldID, (double)((object)val));
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													AndroidJNISafe.SetCharField(this.m_jobject, fieldID, (char)((object)val));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					AndroidJNISafe.SetStringField(this.m_jobject, fieldID, val.Cast<string>());
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaClass>().m_jclass);
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaObject>().m_jobject);
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaProxy>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (flag14)
							{
								AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaProxy>().GetRawProxy());
							}
							else
							{
								bool flag15 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
								if (!flag15)
								{
									string text = "JNI: Unknown field type '";
									Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
									throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
								}
								IntPtr intPtr = AndroidJNIHelper.ConvertToJNIArray(val.Cast<Array>());
								AndroidJNISafe.SetObjectField(this.m_jobject, fieldID, intPtr);
							}
						}
					}
				}
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00004A50 File Offset: 0x00002C50
		public FieldType _GetStatic<FieldType>(string fieldName)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, true);
			return this._GetStatic<FieldType>(fieldID);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00004A7C File Offset: 0x00002C7C
		public FieldType _GetStatic<FieldType>(IntPtr fieldID)
		{
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			FieldType fieldType;
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					fieldType = AndroidJNISafe.GetStaticIntField(this.m_jclass, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						fieldType = AndroidJNISafe.GetStaticBooleanField(this.m_jclass, fieldID).Cast<FieldType>();
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java get field call is obsolete, use field type <SByte> instead");
							fieldType = ((byte)AndroidJNISafe.GetStaticSByteField(this.m_jclass, fieldID)).Cast<FieldType>();
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								fieldType = AndroidJNISafe.GetStaticSByteField(this.m_jclass, fieldID).Cast<FieldType>();
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									fieldType = AndroidJNISafe.GetStaticShortField(this.m_jclass, fieldID).Cast<FieldType>();
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										fieldType = AndroidJNISafe.GetStaticLongField(this.m_jclass, fieldID).Cast<FieldType>();
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											fieldType = AndroidJNISafe.GetStaticFloatField(this.m_jclass, fieldID).Cast<FieldType>();
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												fieldType = AndroidJNISafe.GetStaticDoubleField(this.m_jclass, fieldID).Cast<FieldType>();
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													fieldType = AndroidJNISafe.GetStaticCharField(this.m_jclass, fieldID).Cast<FieldType>();
												}
												else
												{
													fieldType = default(FieldType);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					fieldType = AndroidJNISafe.GetStaticStringField(this.m_jclass, fieldID).Cast<FieldType>();
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						IntPtr staticObjectField = AndroidJNISafe.GetStaticObjectField(this.m_jclass, fieldID);
						fieldType = ((staticObjectField == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaClassDeleteLocalRef(staticObjectField).Cast<FieldType>());
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							IntPtr staticObjectField2 = AndroidJNISafe.GetStaticObjectField(this.m_jclass, fieldID);
							fieldType = ((staticObjectField2 == IntPtr.Zero) ? default(FieldType) : AndroidJavaObject.AndroidJavaObjectDeleteLocalRef(staticObjectField2).Cast<FieldType>());
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (!flag14)
							{
								string text = "JNI: Unknown field type '";
								Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
								throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
							}
							IntPtr staticObjectField3 = AndroidJNISafe.GetStaticObjectField(this.m_jclass, fieldID);
							fieldType = AndroidJavaObject.FromJavaArrayDeleteLocalRef<FieldType>(staticObjectField3);
						}
					}
				}
			}
			return fieldType;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00004E60 File Offset: 0x00003060
		public void _SetStatic<FieldType>(string fieldName, FieldType val)
		{
			IntPtr fieldID = AndroidJNIHelper.GetFieldID<FieldType>(this.m_jclass, fieldName, true);
			this._SetStatic<FieldType>(fieldID, val);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00004E8C File Offset: 0x0000308C
		public void _SetStatic<FieldType>(IntPtr fieldID, FieldType val)
		{
			bool flag = AndroidReflection.IsPrimitive(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
			if (flag)
			{
				bool flag2 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
				if (flag2)
				{
					AndroidJNISafe.SetStaticIntField(this.m_jclass, fieldID, (int)((object)val));
				}
				else
				{
					bool flag3 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<bool>());
					if (flag3)
					{
						AndroidJNISafe.SetStaticBooleanField(this.m_jclass, fieldID, (bool)((object)val));
					}
					else
					{
						bool flag4 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<byte>());
						if (flag4)
						{
							Debug.LogWarning("Field type <Byte> for Java set field call is obsolete, use field type <SByte> instead");
							AndroidJNISafe.SetStaticSByteField(this.m_jclass, fieldID, (sbyte)((byte)((object)val)));
						}
						else
						{
							bool flag5 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<sbyte>());
							if (flag5)
							{
								AndroidJNISafe.SetStaticSByteField(this.m_jclass, fieldID, (sbyte)((object)val));
							}
							else
							{
								bool flag6 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<short>());
								if (flag6)
								{
									AndroidJNISafe.SetStaticShortField(this.m_jclass, fieldID, (short)((object)val));
								}
								else
								{
									bool flag7 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<long>());
									if (flag7)
									{
										AndroidJNISafe.SetStaticLongField(this.m_jclass, fieldID, (long)((object)val));
									}
									else
									{
										bool flag8 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
										if (flag8)
										{
											AndroidJNISafe.SetStaticFloatField(this.m_jclass, fieldID, (float)((object)val));
										}
										else
										{
											bool flag9 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<double>());
											if (flag9)
											{
												AndroidJNISafe.SetStaticDoubleField(this.m_jclass, fieldID, (double)((object)val));
											}
											else
											{
												bool flag10 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<char>());
												if (flag10)
												{
													AndroidJNISafe.SetStaticCharField(this.m_jclass, fieldID, (char)((object)val));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			else
			{
				bool flag11 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<string>());
				if (flag11)
				{
					AndroidJNISafe.SetStaticStringField(this.m_jclass, fieldID, val.Cast<string>());
				}
				else
				{
					bool flag12 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaClass>());
					if (flag12)
					{
						AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaClass>().m_jclass);
					}
					else
					{
						bool flag13 = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaObject>());
						if (flag13)
						{
							AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaObject>().m_jobject);
						}
						else
						{
							bool flag14 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<AndroidJavaProxy>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
							if (flag14)
							{
								AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, (val == null) ? IntPtr.Zero : val.Cast<AndroidJavaProxy>().GetRawProxy());
							}
							else
							{
								bool flag15 = AndroidReflection.IsAssignableFrom(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Array>()), Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>()));
								if (!flag15)
								{
									string text = "JNI: Unknown field type '";
									Type typeFromHandle = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FieldType>());
									throw new Exception(String.Concat(text, (typeFromHandle != null) ? typeFromHandle.ToString() : null, "'"));
								}
								IntPtr intPtr = AndroidJNIHelper.ConvertToJNIArray(val.Cast<Array>());
								AndroidJNISafe.SetStaticObjectField(this.m_jclass, fieldID, intPtr);
							}
						}
					}
				}
			}
		}

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeFieldInfoPtr_enableDebugPrints;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeFieldInfoPtr_m_jobject;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeFieldInfoPtr_m_jclass;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_GetRawObject_Public_IntPtr_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_GetRawClass_Public_IntPtr_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_DebugPrint_Protected_Void_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaObject_Private_Void_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr__AndroidJavaObject_Private_Void_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr__Call_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr__CallStatic_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_AndroidJavaObjectDeleteLocalRef_Internal_Static_AndroidJavaObject_IntPtr_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_AndroidJavaClassDeleteLocalRef_Internal_Static_AndroidJavaClass_IntPtr_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr_FromJavaArrayDeleteLocalRef_Internal_Static_ReturnType_IntPtr_0;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr__GetRawObject_Protected_IntPtr_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr__GetRawClass_Protected_IntPtr_0;

		// Token: 0x0200001E RID: 30
		private sealed class MethodInfoStoreGeneric_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000195 RID: 405
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_Call_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000196 RID: 406
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_CallStatic_Public_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000197 RID: 407
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000021 RID: 33
		private sealed class MethodInfoStoreGeneric__Call_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000198 RID: 408
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__Call_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000022 RID: 34
		private sealed class MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x04000199 RID: 409
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_String_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000023 RID: 35
		private sealed class MethodInfoStoreGeneric__CallStatic_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0<ReturnType>
		{
			// Token: 0x0400019A RID: 410
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr__CallStatic_Protected_ReturnType_IntPtr_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}

		// Token: 0x02000024 RID: 36
		private sealed class MethodInfoStoreGeneric_FromJavaArrayDeleteLocalRef_Internal_Static_ReturnType_IntPtr_0<ReturnType>
		{
			// Token: 0x0400019B RID: 411
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(AndroidJavaObject.NativeMethodInfoPtr_FromJavaArrayDeleteLocalRef_Internal_Static_ReturnType_IntPtr_0, Il2CppClassPointerStore<AndroidJavaObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<ReturnType>.NativeClassPtr)) }))));
		}
	}
}
