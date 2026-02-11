using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200005A RID: 90
	public static class SecurityUtils : Object
	{
		// Token: 0x06000528 RID: 1320 RVA: 0x0002FBD0 File Offset: 0x0002DDD0
		// Note: this type is marked as 'beforefieldinit'.
		static SecurityUtils()
		{
			Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System", "SecurityUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr);
			SecurityUtils.NativeMethodInfoPtr_DemandReflectionAccess_Private_Static_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664193);
			SecurityUtils.NativeMethodInfoPtr_DemandGrantSet_Private_Static_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664194);
			SecurityUtils.NativeMethodInfoPtr_HasReflectionPermission_Private_Static_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664195);
			SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664196);
			SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664197);
			SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664198);
			SecurityUtils.NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664199);
			SecurityUtils.NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664200);
			SecurityUtils.NativeMethodInfoPtr_GenericArgumentsAreVisible_Private_Static_Boolean_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664201);
			SecurityUtils.NativeMethodInfoPtr_MethodInfoInvoke_Internal_Static_Object_MethodInfo_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecurityUtils>.NativeClassPtr, 100664202);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x0002FCC8 File Offset: 0x0002DEC8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DemandReflectionAccess(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_DemandReflectionAccess_Private_Static_Void_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x0002FD00 File Offset: 0x0002DF00
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DemandGrantSet(Assembly assembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_DemandGrantSet_Private_Static_Void_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x0002FD38 File Offset: 0x0002DF38
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 433932, RefRangeEnd = 433935, XrefRangeStart = 433932, XrefRangeEnd = 433932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool HasReflectionPermission(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_HasReflectionPermission_Private_Static_Boolean_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x0002FD7C File Offset: 0x0002DF7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433936, RefRangeEnd = 433937, XrefRangeStart = 433935, XrefRangeEnd = 433936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SecureCreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x0002FDC0 File Offset: 0x0002DFC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433944, RefRangeEnd = 433946, XrefRangeStart = 433937, XrefRangeEnd = 433944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SecureCreateInstance(Type type, Il2CppReferenceArray<Object> args, bool allowNonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x0002FE24 File Offset: 0x0002E024
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433947, RefRangeEnd = 433948, XrefRangeStart = 433946, XrefRangeEnd = 433947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SecureCreateInstance(Type type, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0002FE7C File Offset: 0x0002E07C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433960, RefRangeEnd = 433962, XrefRangeStart = 433948, XrefRangeEnd = 433960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SecureConstructorInvoke(Type type, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args, bool allowNonPublic)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNonPublic;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x0002FEF4 File Offset: 0x0002E0F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 433973, RefRangeEnd = 433974, XrefRangeStart = 433962, XrefRangeEnd = 433973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object SecureConstructorInvoke(Type type, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args, bool allowNonPublic, BindingFlags extraFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowNonPublic;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref extraFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x0002FF78 File Offset: 0x0002E178
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 433976, RefRangeEnd = 433978, XrefRangeStart = 433974, XrefRangeEnd = 433976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GenericArgumentsAreVisible(MethodInfo method)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_GenericArgumentsAreVisible_Private_Static_Boolean_MethodInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x0002FFBC File Offset: 0x0002E1BC
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 433990, RefRangeEnd = 433996, XrefRangeStart = 433978, XrefRangeEnd = 433990, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object MethodInfoInvoke(MethodInfo method, Object target, Il2CppReferenceArray<Object> args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(target);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecurityUtils.NativeMethodInfoPtr_MethodInfoInvoke_Internal_Static_Object_MethodInfo_Object_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00003BBB File Offset: 0x00001DBB
		public SecurityUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400043F RID: 1087
		private static readonly IntPtr NativeMethodInfoPtr_DemandReflectionAccess_Private_Static_Void_Type_0;

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeMethodInfoPtr_DemandGrantSet_Private_Static_Void_Assembly_0;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_HasReflectionPermission_Private_Static_Boolean_Type_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_SecureCreateInstance_Internal_Static_Object_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x04000446 RID: 1094
		private static readonly IntPtr NativeMethodInfoPtr_SecureConstructorInvoke_Internal_Static_Object_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_Boolean_BindingFlags_0;

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr_GenericArgumentsAreVisible_Private_Static_Boolean_MethodInfo_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_MethodInfoInvoke_Internal_Static_Object_MethodInfo_Object_Il2CppReferenceArray_1_Object_0;
	}
}
