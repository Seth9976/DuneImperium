using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Resources;

namespace Il2CppSystem
{
	// Token: 0x02000008 RID: 8
	public static class SR : Object
	{
		// Token: 0x0600001B RID: 27 RVA: 0x0000373C File Offset: 0x0000193C
		// Note: this type is marked as 'beforefieldinit'.
		static SR()
		{
			Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "System", "SR");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr);
			Il2CppSystem.SR.NativeFieldInfoPtr_s_usingResourceKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, "s_usingResourceKeys");
			Il2CppSystem.SR.NativeFieldInfoPtr_s_resourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, "s_resourceManager");
			Il2CppSystem.SR.NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663303);
			Il2CppSystem.SR.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663304);
			Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663305);
			Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663306);
			Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663307);
			Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663308);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663309);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_AmbiguousConstructorException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663310);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_CannotResolveService_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663311);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_CircularDependencyException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663312);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_UnableToActivateTypeException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663313);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_OpenGenericServiceRequiresOpenGenericImplementation_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663314);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663315);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_TypeCannotBeActivated_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663316);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_NoConstructorMatch_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663317);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ScopedInSingletonException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663318);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ScopedResolvedFromRootException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663319);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_DirectScopedResolvedFromRootException_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663320);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ConstantCantBeConvertedToServiceType_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663321);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ImplementationTypeCantBeConvertedToServiceType_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663322);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_AsyncDisposableServiceDispose_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663323);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_InvalidServiceDescriptor_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663324);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_ServiceDescriptorNotExist_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663325);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_CallSiteTypeNotSupported_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663326);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663327);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_NewConstraint_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663328);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_AotCannotCreateEnumerableValueType_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663329);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_AotCannotCreateGenericValueType_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663330);
			Il2CppSystem.SR.NativeMethodInfoPtr_get_InvalidServiceKeyType_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Il2CppSystem.SR>.NativeClassPtr, 100663331);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000039D8 File Offset: 0x00001BD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202690, XrefRangeEnd = 1202694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsingResourceKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003A08 File Offset: 0x00001C08
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 1202723, RefRangeEnd = 1202746, XrefRangeStart = 1202694, XrefRangeEnd = 1202723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string resourceKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003A44 File Offset: 0x00001C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1202770, RefRangeEnd = 1202772, XrefRangeStart = 1202746, XrefRangeEnd = 1202770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003A94 File Offset: 0x00001C94
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1202800, RefRangeEnd = 1202802, XrefRangeStart = 1202772, XrefRangeEnd = 1202800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202802, XrefRangeEnd = 1202825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, Object p1, Object p2, Object p3)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003B68 File Offset: 0x00001D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202825, XrefRangeEnd = 1202827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003BC4 File Offset: 0x00001DC4
		public unsafe static ResourceManager ResourceManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202827, XrefRangeEnd = 1202846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00003BF8 File Offset: 0x00001DF8
		public unsafe static string AmbiguousConstructorException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202846, XrefRangeEnd = 1202852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_AmbiguousConstructorException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003C24 File Offset: 0x00001E24
		public unsafe static string CannotResolveService
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202852, XrefRangeEnd = 1202858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_CannotResolveService_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00003C50 File Offset: 0x00001E50
		public unsafe static string CircularDependencyException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202858, XrefRangeEnd = 1202864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_CircularDependencyException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003C7C File Offset: 0x00001E7C
		public unsafe static string UnableToActivateTypeException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202864, XrefRangeEnd = 1202870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_UnableToActivateTypeException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00003CA8 File Offset: 0x00001EA8
		public unsafe static string OpenGenericServiceRequiresOpenGenericImplementation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202870, XrefRangeEnd = 1202876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_OpenGenericServiceRequiresOpenGenericImplementation_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public unsafe static string ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202876, XrefRangeEnd = 1202882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00003D00 File Offset: 0x00001F00
		public unsafe static string TypeCannotBeActivated
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202882, XrefRangeEnd = 1202888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_TypeCannotBeActivated_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003D2C File Offset: 0x00001F2C
		public unsafe static string NoConstructorMatch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202888, XrefRangeEnd = 1202894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_NoConstructorMatch_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003D58 File Offset: 0x00001F58
		public unsafe static string ScopedInSingletonException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202894, XrefRangeEnd = 1202900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ScopedInSingletonException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003D84 File Offset: 0x00001F84
		public unsafe static string ScopedResolvedFromRootException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202900, XrefRangeEnd = 1202906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ScopedResolvedFromRootException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00003DB0 File Offset: 0x00001FB0
		public unsafe static string DirectScopedResolvedFromRootException
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202906, XrefRangeEnd = 1202912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_DirectScopedResolvedFromRootException_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002E RID: 46 RVA: 0x00003DDC File Offset: 0x00001FDC
		public unsafe static string ConstantCantBeConvertedToServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1202918, RefRangeEnd = 1202919, XrefRangeStart = 1202912, XrefRangeEnd = 1202918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ConstantCantBeConvertedToServiceType_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00003E08 File Offset: 0x00002008
		public unsafe static string ImplementationTypeCantBeConvertedToServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1202925, RefRangeEnd = 1202926, XrefRangeStart = 1202919, XrefRangeEnd = 1202925, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ImplementationTypeCantBeConvertedToServiceType_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003E34 File Offset: 0x00002034
		public unsafe static string AsyncDisposableServiceDispose
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202926, XrefRangeEnd = 1202932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_AsyncDisposableServiceDispose_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003E60 File Offset: 0x00002060
		public unsafe static string InvalidServiceDescriptor
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202932, XrefRangeEnd = 1202938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_InvalidServiceDescriptor_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00003E8C File Offset: 0x0000208C
		public unsafe static string ServiceDescriptorNotExist
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202938, XrefRangeEnd = 1202944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_ServiceDescriptorNotExist_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003EB8 File Offset: 0x000020B8
		public unsafe static string CallSiteTypeNotSupported
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1202950, RefRangeEnd = 1202951, XrefRangeStart = 1202944, XrefRangeEnd = 1202950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_CallSiteTypeNotSupported_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00003EE4 File Offset: 0x000020E4
		public unsafe static string TrimmingAnnotationsDoNotMatch
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202951, XrefRangeEnd = 1202957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00003F10 File Offset: 0x00002110
		public unsafe static string TrimmingAnnotationsDoNotMatch_NewConstraint
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202957, XrefRangeEnd = 1202963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_NewConstraint_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00003F3C File Offset: 0x0000213C
		public unsafe static string AotCannotCreateEnumerableValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202963, XrefRangeEnd = 1202969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_AotCannotCreateEnumerableValueType_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00003F68 File Offset: 0x00002168
		public unsafe static string AotCannotCreateGenericValueType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202969, XrefRangeEnd = 1202975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_AotCannotCreateGenericValueType_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00003F94 File Offset: 0x00002194
		public unsafe static string InvalidServiceKeyType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1202975, XrefRangeEnd = 1202981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Il2CppSystem.SR.NativeMethodInfoPtr_get_InvalidServiceKeyType_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002154 File Offset: 0x00000354
		public static string Format(string resourceFormat, params Object[] args)
		{
			return Il2CppSystem.SR.Format(resourceFormat, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002162 File Offset: 0x00000362
		public SR(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00003FC0 File Offset: 0x000021C0
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000216B File Offset: 0x0000036B
		public unsafe static bool s_usingResourceKeys
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Il2CppSystem.SR.NativeFieldInfoPtr_s_usingResourceKeys, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppSystem.SR.NativeFieldInfoPtr_s_usingResourceKeys, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00003FDC File Offset: 0x000021DC
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002179 File Offset: 0x00000379
		public unsafe static ResourceManager s_resourceManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Il2CppSystem.SR.NativeFieldInfoPtr_s_resourceManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Il2CppSystem.SR.NativeFieldInfoPtr_s_resourceManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeFieldInfoPtr_s_usingResourceKeys;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeFieldInfoPtr_s_resourceManager;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_Object_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_AmbiguousConstructorException_Internal_Static_get_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_CannotResolveService_Internal_Static_get_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_CircularDependencyException_Internal_Static_get_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_UnableToActivateTypeException_Internal_Static_get_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_OpenGenericServiceRequiresOpenGenericImplementation_Internal_Static_get_String_0;

		// Token: 0x04000019 RID: 25
		private static readonly IntPtr NativeMethodInfoPtr_get_ArityOfOpenGenericServiceNotEqualArityOfOpenGenericImplementation_Internal_Static_get_String_0;

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCannotBeActivated_Internal_Static_get_String_0;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_get_NoConstructorMatch_Internal_Static_get_String_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopedInSingletonException_Internal_Static_get_String_0;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopedResolvedFromRootException_Internal_Static_get_String_0;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_DirectScopedResolvedFromRootException_Internal_Static_get_String_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstantCantBeConvertedToServiceType_Internal_Static_get_String_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationTypeCantBeConvertedToServiceType_Internal_Static_get_String_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncDisposableServiceDispose_Internal_Static_get_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidServiceDescriptor_Internal_Static_get_String_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceDescriptorNotExist_Internal_Static_get_String_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_CallSiteTypeNotSupported_Internal_Static_get_String_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_Internal_Static_get_String_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr_get_TrimmingAnnotationsDoNotMatch_NewConstraint_Internal_Static_get_String_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_AotCannotCreateEnumerableValueType_Internal_Static_get_String_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_AotCannotCreateGenericValueType_Internal_Static_get_String_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_get_InvalidServiceKeyType_Internal_Static_get_String_0;
	}
}
