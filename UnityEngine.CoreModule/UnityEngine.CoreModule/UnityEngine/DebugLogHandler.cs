using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007D RID: 125
	public sealed class DebugLogHandler : Object
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x000299C4 File Offset: 0x00027BC4
		// Note: this type is marked as 'beforefieldinit'.
		static DebugLogHandler()
		{
			Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DebugLogHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr);
			DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664029);
			DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664030);
			DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664031);
			DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664032);
			DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664033);
			DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr, 100664034);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00029A6C File Offset: 0x00027C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646414, XrefRangeEnd = 646416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Log(LogType level, LogOption options, string msg, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref level;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref options;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(msg);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00029AD0 File Offset: 0x00027CD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646416, XrefRangeEnd = 646418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_LogException(Exception ex, Object obj)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00029B18 File Offset: 0x00027D18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646418, XrefRangeEnd = 646421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFormat(LogType logType, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00029B9C File Offset: 0x00027D9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646421, XrefRangeEnd = 646424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogFormat(LogType logType, LogOption logOptions, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref logOptions;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00029C30 File Offset: 0x00027E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 646424, XrefRangeEnd = 646432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogException(Exception exception, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00029C84 File Offset: 0x00027E84
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugLogHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugLogHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000472C File Offset: 0x0000292C
		public void LogFormat(LogType logType, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000473E File Offset: 0x0000293E
		public void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, logOptions, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00004752 File Offset: 0x00002952
		public DebugLogHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000549 RID: 1353
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Log_Internal_Static_Void_LogType_LogOption_String_Object_0;

		// Token: 0x0400054A RID: 1354
		private static readonly IntPtr NativeMethodInfoPtr_Internal_LogException_Internal_Static_Void_Exception_Object_0;

		// Token: 0x0400054B RID: 1355
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Virtual_Final_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400054C RID: 1356
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Void_LogType_LogOption_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400054D RID: 1357
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Virtual_Final_New_Void_Exception_Object_0;

		// Token: 0x0400054E RID: 1358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
