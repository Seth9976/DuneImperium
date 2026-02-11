using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine;

namespace Unity.Burst.LowLevel
{
	// Token: 0x02000057 RID: 87
	public static class BurstCompilerService : global::Il2CppSystem.Object
	{
		// Token: 0x060002EA RID: 746 RVA: 0x0001E458 File Offset: 0x0001C658
		// Note: this type is marked as 'beforefieldinit'.
		static BurstCompilerService()
		{
			Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Burst.LowLevel", "BurstCompilerService");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr);
			BurstCompilerService.NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663570);
			BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663571);
			BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663572);
			BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663573);
			BurstCompilerService.NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663574);
			BurstCompilerService.NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663575);
			BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663576);
			BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663577);
			BurstCompilerService.NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstCompilerService>.NativeClassPtr, 100663578);
			BurstCompilerService.GetMethodSignatureDelegateField = IL2CPP.ResolveICall<BurstCompilerService.GetMethodSignatureDelegate>("Unity.Burst.LowLevel.BurstCompilerService::GetMethodSignature");
			BurstCompilerService.get_IsInitializedDelegateField = IL2CPP.ResolveICall<BurstCompilerService.get_IsInitializedDelegate>("Unity.Burst.LowLevel.BurstCompilerService::get_IsInitialized");
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001E55C File Offset: 0x0001C75C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644256, RefRangeEnd = 644257, XrefRangeStart = 644254, XrefRangeEnd = 644256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetDisassembly(MethodInfo m, string compilerOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001E5AC File Offset: 0x0001C7AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644259, RefRangeEnd = 644261, XrefRangeStart = 644257, XrefRangeEnd = 644259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int CompileAsyncDelegateMethod(global::Il2CppSystem.Object delegateMethod, string compilerOptions)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(delegateMethod);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(compilerOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001E600 File Offset: 0x0001C800
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 644263, RefRangeEnd = 644265, XrefRangeStart = 644261, XrefRangeEnd = 644263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetAsyncCompiledAsyncDelegateMethod(int userID)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref userID;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return intPtr;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001E634 File Offset: 0x0001C834
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644267, RefRangeEnd = 644268, XrefRangeStart = 644265, XrefRangeEnd = 644267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void* GetOrCreateSharedMemory(ref global::UnityEngine.Hash128 key, uint size_of, uint alignment)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &key;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size_of;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alignment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return intPtr;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001E684 File Offset: 0x0001C884
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644270, RefRangeEnd = 644271, XrefRangeStart = 644268, XrefRangeEnd = 644270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetCurrentExecutionMode(uint environment)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref environment;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001E6B8 File Offset: 0x0001C8B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644273, RefRangeEnd = 644274, XrefRangeStart = 644271, XrefRangeEnd = 644273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint GetCurrentExecutionMode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001E6E8 File Offset: 0x0001C8E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644276, RefRangeEnd = 644277, XrefRangeStart = 644274, XrefRangeEnd = 644276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Log(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = message;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filename;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001E750 File Offset: 0x0001C950
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 644279, RefRangeEnd = 644280, XrefRangeStart = 644277, XrefRangeEnd = 644279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RuntimeLog(void* userData, BurstCompilerService.BurstLogType logType, byte* message, byte* filename, int lineNumber)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = userData;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = message;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = filename;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lineNumber;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001E7B8 File Offset: 0x0001C9B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 644280, XrefRangeEnd = 644282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool LoadBurstLibrary(string fullPathToLibBurstGenerated)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(fullPathToLibBurstGenerated);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstCompilerService.NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000382A File Offset: 0x00001A2A
		public BurstCompilerService(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001E7FC File Offset: 0x0001C9FC
		public static string GetMethodSignature(MethodInfo method)
		{
			IntPtr intPtr = BurstCompilerService.GetMethodSignatureDelegateField(IL2CPP.Il2CppObjectBaseToPtr(method));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00003833 File Offset: 0x00001A33
		public static bool IsInitialized
		{
			get
			{
				return BurstCompilerService.get_IsInitializedDelegateField();
			}
		}

		// Token: 0x04000226 RID: 550
		private static readonly IntPtr NativeMethodInfoPtr_GetDisassembly_Public_Static_String_MethodInfo_String_0;

		// Token: 0x04000227 RID: 551
		private static readonly IntPtr NativeMethodInfoPtr_CompileAsyncDelegateMethod_Public_Static_Int32_Object_String_0;

		// Token: 0x04000228 RID: 552
		private static readonly IntPtr NativeMethodInfoPtr_GetAsyncCompiledAsyncDelegateMethod_Public_Static_ptr_Void_Int32_0;

		// Token: 0x04000229 RID: 553
		private static readonly IntPtr NativeMethodInfoPtr_GetOrCreateSharedMemory_Public_Static_ptr_Void_byref_Hash128_UInt32_UInt32_0;

		// Token: 0x0400022A RID: 554
		private static readonly IntPtr NativeMethodInfoPtr_SetCurrentExecutionMode_Public_Static_Void_UInt32_0;

		// Token: 0x0400022B RID: 555
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentExecutionMode_Public_Static_UInt32_0;

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeLog_Public_Static_Void_ptr_Void_BurstLogType_ptr_Byte_ptr_Byte_Int32_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_LoadBurstLibrary_Public_Static_Boolean_String_0;

		// Token: 0x0400022F RID: 559
		private static readonly BurstCompilerService.GetMethodSignatureDelegate GetMethodSignatureDelegateField;

		// Token: 0x04000230 RID: 560
		private static readonly BurstCompilerService.get_IsInitializedDelegate get_IsInitializedDelegateField;

		// Token: 0x020003FA RID: 1018
		public enum BurstLogType
		{
			// Token: 0x04002B20 RID: 11040
			Info,
			// Token: 0x04002B21 RID: 11041
			Warning,
			// Token: 0x04002B22 RID: 11042
			Error
		}

		// Token: 0x020003FB RID: 1019
		// (Invoke) Token: 0x060030E5 RID: 12517
		private delegate IntPtr GetMethodSignatureDelegate(IntPtr method);

		// Token: 0x020003FC RID: 1020
		// (Invoke) Token: 0x060030E7 RID: 12519
		private delegate bool get_IsInitializedDelegate();
	}
}
