using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Text;

namespace Unity.Burst
{
	// Token: 0x02000009 RID: 9
	public static class BurstCompiler : Object
	{
		// Token: 0x06000030 RID: 48 RVA: 0x00003E74 File Offset: 0x00002074
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompiler()
		{
			Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "BurstCompiler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr);
			BurstCompiler.NativeFieldInfoPtr__cmdBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "_cmdBuilder");
			BurstCompiler.NativeFieldInfoPtr__IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "_IsEnabled");
			BurstCompiler.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "Options");
			BurstCompiler.NativeFieldInfoPtr_OnCompileILPPMethod2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "OnCompileILPPMethod2");
			BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "DummyMethodInfo");
			BurstCompiler.NativeMethodInfoPtr_IsLoadAdditionalLibrarySupported_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663320);
			BurstCompiler.NativeMethodInfoPtr_BeginCompilerCommand_Private_Static_CommandBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663321);
			BurstCompiler.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663322);
			BurstCompiler.NativeMethodInfoPtr_SetExecutionMode_Public_Static_Void_BurstExecutionEnvironment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663323);
			BurstCompiler.NativeMethodInfoPtr_GetExecutionMode_Public_Static_BurstExecutionEnvironment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663324);
			BurstCompiler.NativeMethodInfoPtr_CompileDelegate_Internal_Static_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663325);
			BurstCompiler.NativeMethodInfoPtr_VerifyDelegateIsNotMulticast_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663326);
			BurstCompiler.NativeMethodInfoPtr_VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute_Private_Static_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663327);
			BurstCompiler.NativeMethodInfoPtr_CompileILPPMethod_Public_Static_IntPtr_RuntimeMethodHandle_RuntimeMethodHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663328);
			BurstCompiler.NativeMethodInfoPtr_CompileILPPMethod2_Public_Static_IntPtr_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663329);
			BurstCompiler.NativeMethodInfoPtr_GetILPPMethodFunctionPointer_Public_Static_ptr_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663330);
			BurstCompiler.NativeMethodInfoPtr_GetILPPMethodFunctionPointer2_Public_Static_ptr_Void_IntPtr_RuntimeMethodHandle_RuntimeTypeHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663331);
			BurstCompiler.NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663332);
			BurstCompiler.NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663333);
			BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663334);
			BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663335);
			BurstCompiler.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663336);
			BurstCompiler.NativeMethodInfoPtr_Cancel_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663337);
			BurstCompiler.NativeMethodInfoPtr_IsCurrentCompilationDone_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663338);
			BurstCompiler.NativeMethodInfoPtr_Enable_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663339);
			BurstCompiler.NativeMethodInfoPtr_Disable_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663340);
			BurstCompiler.NativeMethodInfoPtr_IsHostEditorArm_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663341);
			BurstCompiler.NativeMethodInfoPtr_TriggerUnsafeStaticMethodRecompilation_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663342);
			BurstCompiler.NativeMethodInfoPtr_TriggerRecompilation_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663343);
			BurstCompiler.NativeMethodInfoPtr_UnloadAdditionalLibraries_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663344);
			BurstCompiler.NativeMethodInfoPtr_InitialiseDebuggerHooks_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663345);
			BurstCompiler.NativeMethodInfoPtr_IsApiAvailable_Internal_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663346);
			BurstCompiler.NativeMethodInfoPtr_RequestSetProtocolVersion_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663347);
			BurstCompiler.NativeMethodInfoPtr_Initialize_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663348);
			BurstCompiler.NativeMethodInfoPtr_NotifyCompilationStarted_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663349);
			BurstCompiler.NativeMethodInfoPtr_NotifyAssemblyCompilationNotRequired_Internal_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663350);
			BurstCompiler.NativeMethodInfoPtr_NotifyAssemblyCompilationFinished_Internal_Static_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663351);
			BurstCompiler.NativeMethodInfoPtr_NotifyCompilationFinished_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663352);
			BurstCompiler.NativeMethodInfoPtr_AotCompilation_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663353);
			BurstCompiler.NativeMethodInfoPtr_SetProfilerCallbacks_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663354);
			BurstCompiler.NativeMethodInfoPtr_SendRawCommandToCompiler_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663355);
			BurstCompiler.NativeMethodInfoPtr_SendCommandToCompiler_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663356);
			BurstCompiler.NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, 100663357);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004200 File Offset: 0x00002400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050840, XrefRangeEnd = 1050846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsLoadAdditionalLibrarySupported()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_IsLoadAdditionalLibrarySupported_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004230 File Offset: 0x00002430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050846, XrefRangeEnd = 1050873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstCompiler.CommandBuilder BeginCompilerCommand(string cmd)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_BeginCompilerCommand_Private_Static_CommandBuilder_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00004274 File Offset: 0x00002474
		public unsafe static bool IsEnabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050873, XrefRangeEnd = 1050878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000042A4 File Offset: 0x000024A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050878, XrefRangeEnd = 1050879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetExecutionMode(BurstExecutionEnvironment mode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref mode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_SetExecutionMode_Public_Static_Void_BurstExecutionEnvironment_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000042D8 File Offset: 0x000024D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050879, XrefRangeEnd = 1050880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BurstExecutionEnvironment GetExecutionMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_GetExecutionMode_Public_Static_BurstExecutionEnvironment_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004308 File Offset: 0x00002508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050880, XrefRangeEnd = 1050892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CompileDelegate<T>(T delegateMethod) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = delegateMethod;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref delegateMethod;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.MethodInfoStoreGeneric_CompileDelegate_Internal_Static_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000437C File Offset: 0x0000257C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050892, XrefRangeEnd = 1050894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyDelegateIsNotMulticast<T>(T delegateMethod) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = delegateMethod;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref delegateMethod;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.MethodInfoStoreGeneric_VerifyDelegateIsNotMulticast_Private_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000043E8 File Offset: 0x000025E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050894, XrefRangeEnd = 1050915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute<T>(T delegateMethod) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = delegateMethod;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref delegateMethod;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.MethodInfoStoreGeneric_VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute_Private_Static_Void_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004454 File Offset: 0x00002654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050915, XrefRangeEnd = 1050920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CompileILPPMethod(RuntimeMethodHandle burstMethodHandle, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref burstMethodHandle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedMethodHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateTypeHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_CompileILPPMethod_Public_Static_IntPtr_RuntimeMethodHandle_RuntimeMethodHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000044B0 File Offset: 0x000026B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050920, XrefRangeEnd = 1050944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr CompileILPPMethod2(RuntimeMethodHandle burstMethodHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref burstMethodHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_CompileILPPMethod2_Public_Static_IntPtr_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000044F0 File Offset: 0x000026F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050944, XrefRangeEnd = 1050949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetILPPMethodFunctionPointer(IntPtr ilppMethod)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ilppMethod;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_GetILPPMethodFunctionPointer_Public_Static_ptr_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004524 File Offset: 0x00002724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050949, XrefRangeEnd = 1050952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetILPPMethodFunctionPointer2(IntPtr ilppMethod, RuntimeMethodHandle managedMethodHandle, RuntimeTypeHandle delegateTypeHandle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ilppMethod;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref managedMethodHandle;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delegateTypeHandle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_GetILPPMethodFunctionPointer2_Public_Static_ptr_Void_IntPtr_RuntimeMethodHandle_RuntimeTypeHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004574 File Offset: 0x00002774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050952, XrefRangeEnd = 1050957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* CompileUnsafeStaticMethod(RuntimeMethodHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000045A8 File Offset: 0x000027A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050957, XrefRangeEnd = 1050962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static FunctionPointer<T> CompileFunctionPointer<T>(T delegateMethod) where T : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = delegateMethod;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref delegateMethod;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return new FunctionPointer<T>(intPtr2);
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000461C File Offset: 0x0000281C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1050969, RefRangeEnd = 1050971, XrefRangeStart = 1050962, XrefRangeEnd = 1050969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Compile(Object delegateObj, bool isFunctionPointer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFunctionPointer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004664 File Offset: 0x00002864
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1051037, RefRangeEnd = 1051039, XrefRangeStart = 1050971, XrefRangeEnd = 1051037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* Compile(Object delegateObj, MethodInfo methodInfo, bool isFunctionPointer, bool isILPostProcessing)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(methodInfo);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isFunctionPointer;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isILPostProcessing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000046CC File Offset: 0x000028CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Shutdown()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000046F4 File Offset: 0x000028F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Cancel()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Cancel_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000471C File Offset: 0x0000291C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsCurrentCompilationDone()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_IsCurrentCompilationDone_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000474C File Offset: 0x0000294C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Enable_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004774 File Offset: 0x00002974
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Disable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Disable_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000479C File Offset: 0x0000299C
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsHostEditorArm()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_IsHostEditorArm_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000047CC File Offset: 0x000029CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051039, XrefRangeEnd = 1051087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerUnsafeStaticMethodRecompilation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_TriggerUnsafeStaticMethodRecompilation_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000047F4 File Offset: 0x000029F4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerRecompilation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_TriggerRecompilation_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000481C File Offset: 0x00002A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051087, XrefRangeEnd = 1051133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAdditionalLibraries()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_UnloadAdditionalLibraries_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004844 File Offset: 0x00002A44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051133, XrefRangeEnd = 1051155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitialiseDebuggerHooks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_InitialiseDebuggerHooks_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000486C File Offset: 0x00002A6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1051164, RefRangeEnd = 1051167, XrefRangeStart = 1051155, XrefRangeEnd = 1051164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsApiAvailable(string apiName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(apiName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_IsApiAvailable_Internal_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000048B0 File Offset: 0x00002AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051167, XrefRangeEnd = 1051191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int RequestSetProtocolVersion(int version)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref version;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_RequestSetProtocolVersion_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000048F0 File Offset: 0x00002AF0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Initialize(Il2CppStringArray assemblyFolders, Il2CppStringArray ignoreAssemblies)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyFolders);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreAssemblies);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_Initialize_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004938 File Offset: 0x00002B38
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyCompilationStarted(Il2CppStringArray assemblyFolders, Il2CppStringArray ignoreAssemblies)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyFolders);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreAssemblies);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_NotifyCompilationStarted_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004980 File Offset: 0x00002B80
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyAssemblyCompilationNotRequired(string assemblyName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_NotifyAssemblyCompilationNotRequired_Internal_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000049B8 File Offset: 0x00002BB8
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyAssemblyCompilationFinished(string assemblyName, Il2CppStringArray defines)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defines);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_NotifyAssemblyCompilationFinished_Internal_Static_Void_String_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004A00 File Offset: 0x00002C00
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NotifyCompilationFinished()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_NotifyCompilationFinished_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004A28 File Offset: 0x00002C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1051191, XrefRangeEnd = 1051193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string AotCompilation(Il2CppStringArray assemblyFolders, Il2CppStringArray assemblyRoots, string options)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assemblyFolders);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assemblyRoots);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_AotCompilation_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004A88 File Offset: 0x00002C88
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetProfilerCallbacks()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_SetProfilerCallbacks_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004AB0 File Offset: 0x00002CB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1051201, RefRangeEnd = 1051206, XrefRangeStart = 1051193, XrefRangeEnd = 1051201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SendRawCommandToCompiler(string command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_SendRawCommandToCompiler_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004AEC File Offset: 0x00002CEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1051251, RefRangeEnd = 1051254, XrefRangeStart = 1051206, XrefRangeEnd = 1051251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SendCommandToCompiler(string commandName, string commandArgs = null)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(commandName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(commandArgs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_SendCommandToCompiler_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004B3C File Offset: 0x00002D3C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DummyMethod()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000220E File Offset: 0x0000040E
		public BurstCompiler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00004B64 File Offset: 0x00002D64
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002217 File Offset: 0x00000417
		public unsafe static BurstCompiler.CommandBuilder _cmdBuilder
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr__cmdBuilder, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr__cmdBuilder, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004B8C File Offset: 0x00002D8C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002229 File Offset: 0x00000429
		public unsafe static bool _IsEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr__IsEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr__IsEnabled, (void*)(&value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004BA8 File Offset: 0x00002DA8
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002237 File Offset: 0x00000437
		public unsafe static BurstCompilerOptions Options
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr_Options, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompilerOptions>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr_Options, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004BD0 File Offset: 0x00002DD0
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002249 File Offset: 0x00000449
		public unsafe static Action OnCompileILPPMethod2
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr_OnCompileILPPMethod2, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr_OnCompileILPPMethod2, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00004BF8 File Offset: 0x00002DF8
		// (set) Token: 0x06000061 RID: 97 RVA: 0x0000225B File Offset: 0x0000045B
		public unsafe static MethodInfo DummyMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BurstCompiler.NativeFieldInfoPtr_DummyMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeFieldInfoPtr__cmdBuilder;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeFieldInfoPtr__IsEnabled;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeFieldInfoPtr_OnCompileILPPMethod2;

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_DummyMethodInfo;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_IsLoadAdditionalLibrarySupported_Public_Static_Boolean_0;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeMethodInfoPtr_BeginCompilerCommand_Private_Static_CommandBuilder_String_0;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_Static_get_Boolean_0;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_SetExecutionMode_Public_Static_Void_BurstExecutionEnvironment_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_GetExecutionMode_Public_Static_BurstExecutionEnvironment_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_CompileDelegate_Internal_Static_T_T_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_VerifyDelegateIsNotMulticast_Private_Static_Void_T_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute_Private_Static_Void_T_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_CompileILPPMethod_Public_Static_IntPtr_RuntimeMethodHandle_RuntimeMethodHandle_RuntimeTypeHandle_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_CompileILPPMethod2_Public_Static_IntPtr_RuntimeMethodHandle_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_GetILPPMethodFunctionPointer_Public_Static_ptr_Void_IntPtr_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_GetILPPMethodFunctionPointer2_Public_Static_ptr_Void_IntPtr_RuntimeMethodHandle_RuntimeTypeHandle_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_CompileUnsafeStaticMethod_Public_Static_ptr_Void_RuntimeMethodHandle_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_Boolean_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr_Compile_Private_Static_ptr_Void_Object_MethodInfo_Boolean_Boolean_0;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_Shutdown_Internal_Static_Void_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_Cancel_Internal_Static_Void_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_IsCurrentCompilationDone_Internal_Static_Boolean_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Internal_Static_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Internal_Static_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_IsHostEditorArm_Internal_Static_Boolean_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_TriggerUnsafeStaticMethodRecompilation_Internal_Static_Void_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_TriggerRecompilation_Internal_Static_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAdditionalLibraries_Internal_Static_Void_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_InitialiseDebuggerHooks_Internal_Static_Void_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_IsApiAvailable_Internal_Static_Boolean_String_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_RequestSetProtocolVersion_Internal_Static_Int32_Int32_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCompilationStarted_Internal_Static_Void_Il2CppStringArray_Il2CppStringArray_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAssemblyCompilationNotRequired_Internal_Static_Void_String_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_NotifyAssemblyCompilationFinished_Internal_Static_Void_String_Il2CppStringArray_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_NotifyCompilationFinished_Internal_Static_Void_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_AotCompilation_Internal_Static_String_Il2CppStringArray_Il2CppStringArray_String_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_SetProfilerCallbacks_Internal_Static_Void_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_SendRawCommandToCompiler_Private_Static_String_String_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_SendCommandToCompiler_Private_Static_String_String_String_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_DummyMethod_Private_Static_Void_0;

		// Token: 0x0200002B RID: 43
		public class CommandBuilder : Object
		{
			// Token: 0x060002C1 RID: 705 RVA: 0x0000E508 File Offset: 0x0000C708
			// Note: this type is marked as 'beforefieldinit'.
			static CommandBuilder()
			{
				Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "CommandBuilder");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr);
				BurstCompiler.CommandBuilder.NativeFieldInfoPtr__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, "_builder");
				BurstCompiler.CommandBuilder.NativeFieldInfoPtr__hasArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, "_hasArgs");
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663359);
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr_Begin_Public_CommandBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663360);
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr_With_Public_CommandBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663361);
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr_With_Public_CommandBuilder_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663362);
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr_And_Public_CommandBuilder_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663363);
				BurstCompiler.CommandBuilder.NativeMethodInfoPtr_SendToCompiler_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr, 100663364);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050691, XrefRangeEnd = 1050697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CommandBuilder()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.CommandBuilder>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C3 RID: 707 RVA: 0x0000E610 File Offset: 0x0000C810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050697, XrefRangeEnd = 1050699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BurstCompiler.CommandBuilder Begin(string cmd)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(cmd);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr_Begin_Public_CommandBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060002C4 RID: 708 RVA: 0x0000E660 File Offset: 0x0000C860
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050699, XrefRangeEnd = 1050701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BurstCompiler.CommandBuilder With(string arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(arg);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr_With_Public_CommandBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060002C5 RID: 709 RVA: 0x0000E6B0 File Offset: 0x0000C8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050701, XrefRangeEnd = 1050709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BurstCompiler.CommandBuilder With(IntPtr arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref arg;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr_With_Public_CommandBuilder_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060002C6 RID: 710 RVA: 0x0000E6FC File Offset: 0x0000C8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050709, XrefRangeEnd = 1050710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BurstCompiler.CommandBuilder And(char sep = '|')
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref sep;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr_And_Public_CommandBuilder_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<BurstCompiler.CommandBuilder>(intPtr3) : null;
				}
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0000E748 File Offset: 0x0000C948
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050710, XrefRangeEnd = 1050715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string SendToCompiler()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.CommandBuilder.NativeMethodInfoPtr_SendToCompiler_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x00002F95 File Offset: 0x00001195
			public CommandBuilder(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DC RID: 220
			// (get) Token: 0x060002C9 RID: 713 RVA: 0x0000E780 File Offset: 0x0000C980
			// (set) Token: 0x060002CA RID: 714 RVA: 0x00002F9E File Offset: 0x0000119E
			public unsafe StringBuilder _builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.CommandBuilder.NativeFieldInfoPtr__builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.CommandBuilder.NativeFieldInfoPtr__builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x060002CB RID: 715 RVA: 0x0000E7B0 File Offset: 0x0000C9B0
			// (set) Token: 0x060002CC RID: 716 RVA: 0x00002FBD File Offset: 0x000011BD
			public unsafe bool _hasArgs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.CommandBuilder.NativeFieldInfoPtr__hasArgs);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.CommandBuilder.NativeFieldInfoPtr__hasArgs)) = value;
				}
			}

			// Token: 0x04000469 RID: 1129
			private static readonly IntPtr NativeFieldInfoPtr__builder;

			// Token: 0x0400046A RID: 1130
			private static readonly IntPtr NativeFieldInfoPtr__hasArgs;

			// Token: 0x0400046B RID: 1131
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400046C RID: 1132
			private static readonly IntPtr NativeMethodInfoPtr_Begin_Public_CommandBuilder_String_0;

			// Token: 0x0400046D RID: 1133
			private static readonly IntPtr NativeMethodInfoPtr_With_Public_CommandBuilder_String_0;

			// Token: 0x0400046E RID: 1134
			private static readonly IntPtr NativeMethodInfoPtr_With_Public_CommandBuilder_IntPtr_0;

			// Token: 0x0400046F RID: 1135
			private static readonly IntPtr NativeMethodInfoPtr_And_Public_CommandBuilder_Char_0;

			// Token: 0x04000470 RID: 1136
			private static readonly IntPtr NativeMethodInfoPtr_SendToCompiler_Public_String_0;
		}

		// Token: 0x0200002C RID: 44
		public class StaticTypeReinitAttribute : Attribute
		{
			// Token: 0x060002CD RID: 717 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
			// Note: this type is marked as 'beforefieldinit'.
			static StaticTypeReinitAttribute()
			{
				Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "StaticTypeReinitAttribute");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr);
				BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr, "reinitType");
				BurstCompiler.StaticTypeReinitAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr, 100663365);
			}

			// Token: 0x060002CE RID: 718 RVA: 0x0000E82C File Offset: 0x0000CA2C
			[CallerCount(96)]
			[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StaticTypeReinitAttribute(Type toReinit)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.StaticTypeReinitAttribute>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(toReinit);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.StaticTypeReinitAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002CF RID: 719 RVA: 0x00002FD8 File Offset: 0x000011D8
			public StaticTypeReinitAttribute(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000E878 File Offset: 0x0000CA78
			// (set) Token: 0x060002D1 RID: 721 RVA: 0x00002FE1 File Offset: 0x000011E1
			public unsafe Type reinitType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.StaticTypeReinitAttribute.NativeFieldInfoPtr_reinitType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000471 RID: 1137
			private static readonly IntPtr NativeFieldInfoPtr_reinitType;

			// Token: 0x04000472 RID: 1138
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
		}

		// Token: 0x0200002D RID: 45
		public static class BurstCompilerHelper : Object
		{
			// Token: 0x060002D2 RID: 722 RVA: 0x0000E8A8 File Offset: 0x0000CAA8
			// Note: this type is marked as 'beforefieldinit'.
			static BurstCompilerHelper()
			{
				Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "BurstCompilerHelper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr);
				BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledImpl");
				BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstGenerated");
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663366);
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663367);
				BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, 100663368);
			}

			// Token: 0x060002D3 RID: 723 RVA: 0x0000E938 File Offset: 0x0000CB38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050815, XrefRangeEnd = 1050818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsBurstEnabled()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060002D4 RID: 724 RVA: 0x0000E968 File Offset: 0x0000CB68
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1050818, RefRangeEnd = 1050819, XrefRangeStart = 1050818, XrefRangeEnd = 1050818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void DiscardedMethod(ref bool value)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = &value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002D5 RID: 725 RVA: 0x0000E99C File Offset: 0x0000CB9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050819, XrefRangeEnd = 1050823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool IsCompiledByBurst(Delegate del)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(del);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002D6 RID: 726 RVA: 0x00003000 File Offset: 0x00001200
			public BurstCompilerHelper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x060002D7 RID: 727 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
			// (set) Token: 0x060002D8 RID: 728 RVA: 0x00003009 File Offset: 0x00001209
			public unsafe static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate IsBurstEnabledImpl
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstEnabledImpl, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x060002D9 RID: 729 RVA: 0x0000EA08 File Offset: 0x0000CC08
			// (set) Token: 0x060002DA RID: 730 RVA: 0x0000301B File Offset: 0x0000121B
			public unsafe static bool IsBurstGenerated
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.BurstCompilerHelper.NativeFieldInfoPtr_IsBurstGenerated, (void*)(&value));
				}
			}

			// Token: 0x04000473 RID: 1139
			private static readonly IntPtr NativeFieldInfoPtr_IsBurstEnabledImpl;

			// Token: 0x04000474 RID: 1140
			private static readonly IntPtr NativeFieldInfoPtr_IsBurstGenerated;

			// Token: 0x04000475 RID: 1141
			private static readonly IntPtr NativeMethodInfoPtr_IsBurstEnabled_Private_Static_Boolean_0;

			// Token: 0x04000476 RID: 1142
			private static readonly IntPtr NativeMethodInfoPtr_DiscardedMethod_Private_Static_Void_byref_Boolean_0;

			// Token: 0x04000477 RID: 1143
			private static readonly IntPtr NativeMethodInfoPtr_IsCompiledByBurst_Private_Static_Boolean_Delegate_0;

			// Token: 0x02000067 RID: 103
			public sealed class IsBurstEnabledDelegate : MulticastDelegate
			{
				// Token: 0x0600102D RID: 4141 RVA: 0x0005ECA0 File Offset: 0x0005CEA0
				// Note: this type is marked as 'beforefieldinit'.
				static IsBurstEnabledDelegate()
				{
					Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper>.NativeClassPtr, "IsBurstEnabledDelegate");
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663370);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663371);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663372);
					BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr, 100663373);
				}

				// Token: 0x0600102E RID: 4142 RVA: 0x0005ED14 File Offset: 0x0005CF14
				[CallerCount(97)]
				[CachedScanResults(RefRangeStart = 1050718, RefRangeEnd = 1050815, XrefRangeStart = 1050715, XrefRangeEnd = 1050718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsBurstEnabledDelegate(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600102F RID: 4143 RVA: 0x0005ED70 File Offset: 0x0005CF70
				[CallerCount(0)]
				public unsafe bool Invoke()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06001030 RID: 4144 RVA: 0x0005EDAC File Offset: 0x0005CFAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(AsyncCallback callback, Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(callback);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x06001031 RID: 4145 RVA: 0x0005EE10 File Offset: 0x0005D010
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x06001032 RID: 4146 RVA: 0x000033DF File Offset: 0x000015DF
				public IsBurstEnabledDelegate(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x06001033 RID: 4147 RVA: 0x000033E8 File Offset: 0x000015E8
				public static implicit operator BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate(Func<bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>(A_0);
				}

				// Token: 0x06001034 RID: 4148 RVA: 0x000033F0 File Offset: 0x000015F0
				public static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate operator +(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_0, BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>();
				}

				// Token: 0x06001035 RID: 4149 RVA: 0x000033FE File Offset: 0x000015FE
				public static BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate operator -(BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_0, BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<BurstCompiler.BurstCompilerHelper.IsBurstEnabledDelegate>();
					}
					return delegate2;
				}

				// Token: 0x040011D2 RID: 4562
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040011D3 RID: 4563
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_0;

				// Token: 0x040011D4 RID: 4564
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_AsyncCallback_Object_0;

				// Token: 0x040011D5 RID: 4565
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}
		}

		// Token: 0x0200002E RID: 46
		public class FakeDelegate : Object
		{
			// Token: 0x060002DB RID: 731 RVA: 0x0000EA24 File Offset: 0x0000CC24
			// Note: this type is marked as 'beforefieldinit'.
			static FakeDelegate()
			{
				Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "FakeDelegate");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr);
				BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, "<Method>k__BackingField");
				BurstCompiler.FakeDelegate.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, 100663374);
				BurstCompiler.FakeDelegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr, 100663375);
			}

			// Token: 0x060002DC RID: 732 RVA: 0x0000EA8C File Offset: 0x0000CC8C
			[CallerCount(148)]
			[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FakeDelegate(MethodInfo method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.FakeDelegate>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(method);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.FakeDelegate.NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x060002DD RID: 733 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
			public unsafe MethodInfo Method
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.FakeDelegate.NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
				}
			}

			// Token: 0x060002DE RID: 734 RVA: 0x00003029 File Offset: 0x00001229
			public FakeDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x060002DF RID: 735 RVA: 0x0000EB18 File Offset: 0x0000CD18
			// (set) Token: 0x060002E0 RID: 736 RVA: 0x00003032 File Offset: 0x00001232
			public unsafe MethodInfo _Method_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstCompiler.FakeDelegate.NativeFieldInfoPtr__Method_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000478 RID: 1144
			private static readonly IntPtr NativeFieldInfoPtr__Method_k__BackingField;

			// Token: 0x04000479 RID: 1145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MethodInfo_0;

			// Token: 0x0400047A RID: 1146
			private static readonly IntPtr NativeMethodInfoPtr_get_Method_Public_get_MethodInfo_0;
		}

		// Token: 0x0200002F RID: 47
		[ObfuscatedName("Unity.Burst.BurstCompiler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060002E1 RID: 737 RVA: 0x0000EB48 File Offset: 0x0000CD48
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr);
				BurstCompiler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, "<>9");
				BurstCompiler.__c.NativeFieldInfoPtr___9__22_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, "<>9__22_0");
				BurstCompiler.__c.NativeFieldInfoPtr___9__29_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, "<>9__29_0");
				BurstCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, 100663377);
				BurstCompiler.__c.NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, 100663378);
				BurstCompiler.__c.NativeMethodInfoPtr__TriggerUnsafeStaticMethodRecompilation_b__29_0_Internal_Boolean_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr, 100663379);
			}

			// Token: 0x060002E2 RID: 738 RVA: 0x0000EBEC File Offset: 0x0000CDEC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstCompiler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002E3 RID: 739 RVA: 0x0000EC28 File Offset: 0x0000CE28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050823, XrefRangeEnd = 1050828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Compile_b__22_0(Attribute s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.__c.NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002E4 RID: 740 RVA: 0x0000EC78 File Offset: 0x0000CE78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1050828, XrefRangeEnd = 1050840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TriggerUnsafeStaticMethodRecompilation_b__29_0(Attribute x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompiler.__c.NativeMethodInfoPtr__TriggerUnsafeStaticMethodRecompilation_b__29_0_Internal_Boolean_Attribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060002E5 RID: 741 RVA: 0x00003051 File Offset: 0x00001251
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x060002E6 RID: 742 RVA: 0x0000ECC8 File Offset: 0x0000CEC8
			// (set) Token: 0x060002E7 RID: 743 RVA: 0x0000305A File Offset: 0x0000125A
			public unsafe static BurstCompiler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BurstCompiler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
			// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000306C File Offset: 0x0000126C
			public unsafe static Func<Attribute, bool> __9__22_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.__c.NativeFieldInfoPtr___9__22_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Attribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.__c.NativeFieldInfoPtr___9__22_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x060002EA RID: 746 RVA: 0x0000ED18 File Offset: 0x0000CF18
			// (set) Token: 0x060002EB RID: 747 RVA: 0x0000307E File Offset: 0x0000127E
			public unsafe static Func<Attribute, bool> __9__29_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BurstCompiler.__c.NativeFieldInfoPtr___9__29_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Attribute, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BurstCompiler.__c.NativeFieldInfoPtr___9__29_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400047B RID: 1147
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400047C RID: 1148
			private static readonly IntPtr NativeFieldInfoPtr___9__22_0;

			// Token: 0x0400047D RID: 1149
			private static readonly IntPtr NativeFieldInfoPtr___9__29_0;

			// Token: 0x0400047E RID: 1150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400047F RID: 1151
			private static readonly IntPtr NativeMethodInfoPtr__Compile_b__22_0_Internal_Boolean_Attribute_0;

			// Token: 0x04000480 RID: 1152
			private static readonly IntPtr NativeMethodInfoPtr__TriggerUnsafeStaticMethodRecompilation_b__29_0_Internal_Boolean_Attribute_0;
		}

		// Token: 0x02000030 RID: 48
		private sealed class MethodInfoStoreGeneric_CompileDelegate_Internal_Static_T_T_0<T>
		{
			// Token: 0x04000481 RID: 1153
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstCompiler.NativeMethodInfoPtr_CompileDelegate_Internal_Static_T_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000031 RID: 49
		private sealed class MethodInfoStoreGeneric_VerifyDelegateIsNotMulticast_Private_Static_Void_T_0<T>
		{
			// Token: 0x04000482 RID: 1154
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstCompiler.NativeMethodInfoPtr_VerifyDelegateIsNotMulticast_Private_Static_Void_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000032 RID: 50
		private sealed class MethodInfoStoreGeneric_VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute_Private_Static_Void_T_0<T>
		{
			// Token: 0x04000483 RID: 1155
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstCompiler.NativeMethodInfoPtr_VerifyDelegateHasCorrectUnmanagedFunctionPointerAttribute_Private_Static_Void_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000033 RID: 51
		private sealed class MethodInfoStoreGeneric_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0<T>
		{
			// Token: 0x04000484 RID: 1156
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(BurstCompiler.NativeMethodInfoPtr_CompileFunctionPointer_Public_Static_FunctionPointer_1_T_T_0, Il2CppClassPointerStore<BurstCompiler>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
