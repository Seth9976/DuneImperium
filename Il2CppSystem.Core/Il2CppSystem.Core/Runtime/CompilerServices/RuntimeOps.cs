using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Dynamic;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000109 RID: 265
	public static class RuntimeOps : Object
	{
		// Token: 0x06000FDF RID: 4063 RVA: 0x0005390C File Offset: 0x00051B0C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeOps()
		{
			Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "RuntimeOps");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr);
			RuntimeOps.NativeMethodInfoPtr_ExpandoTryGetValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr, 100666254);
			RuntimeOps.NativeMethodInfoPtr_ExpandoTrySetValue_Public_Static_Object_ExpandoObject_Object_Int32_Object_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr, 100666255);
			RuntimeOps.NativeMethodInfoPtr_ExpandoTryDeleteValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr, 100666256);
			RuntimeOps.NativeMethodInfoPtr_ExpandoCheckVersion_Public_Static_Boolean_ExpandoObject_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr, 100666257);
			RuntimeOps.NativeMethodInfoPtr_ExpandoPromoteClass_Public_Static_Void_ExpandoObject_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeOps>.NativeClassPtr, 100666258);
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000539A0 File Offset: 0x00051BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027021, XrefRangeEnd = 1027023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExpandoTryGetValue(ExpandoObject expando, Object indexClass, int index, string name, bool ignoreCase, out Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RuntimeOps.NativeMethodInfoPtr_ExpandoTryGetValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_byref_Object_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			value = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00053A48 File Offset: 0x00051C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027023, XrefRangeEnd = 1027024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ExpandoTrySetValue(ExpandoObject expando, Object indexClass, int index, Object value, string name, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeOps.NativeMethodInfoPtr_ExpandoTrySetValue_Public_Static_Object_ExpandoObject_Object_Int32_Object_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x00053AE0 File Offset: 0x00051CE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027024, XrefRangeEnd = 1027029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExpandoTryDeleteValue(ExpandoObject expando, Object indexClass, int index, string name, bool ignoreCase)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(indexClass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ignoreCase;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeOps.NativeMethodInfoPtr_ExpandoTryDeleteValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00053B64 File Offset: 0x00051D64
		[CallerCount(0)]
		public unsafe static bool ExpandoCheckVersion(ExpandoObject expando, Object version)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(version);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeOps.NativeMethodInfoPtr_ExpandoCheckVersion_Public_Static_Boolean_ExpandoObject_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00053BB8 File Offset: 0x00051DB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027029, XrefRangeEnd = 1027031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExpandoPromoteClass(ExpandoObject expando, Object oldClass, Object newClass)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expando);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(oldClass);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newClass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeOps.NativeMethodInfoPtr_ExpandoPromoteClass_Public_Static_Void_ExpandoObject_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00006F69 File Offset: 0x00005169
		public RuntimeOps(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B65 RID: 2917
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoTryGetValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_byref_Object_0;

		// Token: 0x04000B66 RID: 2918
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoTrySetValue_Public_Static_Object_ExpandoObject_Object_Int32_Object_String_Boolean_0;

		// Token: 0x04000B67 RID: 2919
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoTryDeleteValue_Public_Static_Boolean_ExpandoObject_Object_Int32_String_Boolean_0;

		// Token: 0x04000B68 RID: 2920
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoCheckVersion_Public_Static_Boolean_ExpandoObject_Object_0;

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeMethodInfoPtr_ExpandoPromoteClass_Public_Static_Void_ExpandoObject_Object_Object_0;
	}
}
