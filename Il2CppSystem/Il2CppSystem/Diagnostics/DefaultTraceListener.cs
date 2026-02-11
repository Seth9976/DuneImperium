using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Diagnostics
{
	// Token: 0x020000A5 RID: 165
	public class DefaultTraceListener : TraceListener
	{
		// Token: 0x06000C31 RID: 3121 RVA: 0x0004982C File Offset: 0x00047A2C
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultTraceListener()
		{
			Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Diagnostics", "DefaultTraceListener");
			DefaultTraceListener.NativeFieldInfoPtr_OnWin32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, "OnWin32");
			DefaultTraceListener.NativeFieldInfoPtr_MonoTracePrefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, "MonoTracePrefix");
			DefaultTraceListener.NativeFieldInfoPtr_MonoTraceFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, "MonoTraceFile");
			DefaultTraceListener.NativeFieldInfoPtr_logFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, "logFileName");
			DefaultTraceListener.NativeMethodInfoPtr_GetPrefix_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665045);
			DefaultTraceListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665046);
			DefaultTraceListener.NativeMethodInfoPtr_get_LogFileName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665047);
			DefaultTraceListener.NativeMethodInfoPtr_WriteWindowsDebugString_Private_Static_Void_ptr_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665048);
			DefaultTraceListener.NativeMethodInfoPtr_WriteDebugString_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665049);
			DefaultTraceListener.NativeMethodInfoPtr_WriteMonoTrace_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665050);
			DefaultTraceListener.NativeMethodInfoPtr_WritePrefix_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665051);
			DefaultTraceListener.NativeMethodInfoPtr_WriteImpl_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665052);
			DefaultTraceListener.NativeMethodInfoPtr_WriteLogFile_Private_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665053);
			DefaultTraceListener.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665054);
			DefaultTraceListener.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr, 100665055);
		}

		// Token: 0x06000C32 RID: 3122 RVA: 0x00049980 File Offset: 0x00047B80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451758, XrefRangeEnd = 451760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPrefix(string var, string target)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(var);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(target);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_GetPrefix_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000C33 RID: 3123 RVA: 0x000499D0 File Offset: 0x00047BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451760, XrefRangeEnd = 451764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultTraceListener()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultTraceListener>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00049A0C File Offset: 0x00047C0C
		public unsafe string LogFileName
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_get_LogFileName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000C35 RID: 3125 RVA: 0x00049A44 File Offset: 0x00047C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451764, XrefRangeEnd = 451765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteWindowsDebugString(char* message)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = message;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WriteWindowsDebugString_Private_Static_Void_ptr_Char_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C36 RID: 3126 RVA: 0x00049A78 File Offset: 0x00047C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451765, XrefRangeEnd = 451774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteDebugString(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WriteDebugString_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C37 RID: 3127 RVA: 0x00049ABC File Offset: 0x00047CBC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 451803, RefRangeEnd = 451807, XrefRangeStart = 451774, XrefRangeEnd = 451803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteMonoTrace(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WriteMonoTrace_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C38 RID: 3128 RVA: 0x00049B00 File Offset: 0x00047D00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451807, XrefRangeEnd = 451814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WritePrefix()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WritePrefix_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00049B34 File Offset: 0x00047D34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451840, RefRangeEnd = 451842, XrefRangeStart = 451814, XrefRangeEnd = 451840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteImpl(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WriteImpl_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00049B78 File Offset: 0x00047D78
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 451856, RefRangeEnd = 451858, XrefRangeStart = 451842, XrefRangeEnd = 451856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteLogFile(string message, string logFile)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(logFile);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultTraceListener.NativeMethodInfoPtr_WriteLogFile_Private_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00049BCC File Offset: 0x00047DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451858, XrefRangeEnd = 451889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Write(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTraceListener.NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x00049C1C File Offset: 0x00047E1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 451889, XrefRangeEnd = 451892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void WriteLine(string message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultTraceListener.NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x000068AE File Offset: 0x00004AAE
		public DefaultTraceListener(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00049C6C File Offset: 0x00047E6C
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x000068B7 File Offset: 0x00004AB7
		public unsafe static bool OnWin32
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(DefaultTraceListener.NativeFieldInfoPtr_OnWin32, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultTraceListener.NativeFieldInfoPtr_OnWin32, (void*)(&value));
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00049C88 File Offset: 0x00047E88
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x000068C5 File Offset: 0x00004AC5
		public unsafe static string MonoTracePrefix
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultTraceListener.NativeFieldInfoPtr_MonoTracePrefix, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultTraceListener.NativeFieldInfoPtr_MonoTracePrefix, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00049CA8 File Offset: 0x00047EA8
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x000068D7 File Offset: 0x00004AD7
		public unsafe static string MonoTraceFile
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultTraceListener.NativeFieldInfoPtr_MonoTraceFile, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultTraceListener.NativeFieldInfoPtr_MonoTraceFile, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00049CC8 File Offset: 0x00047EC8
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x000068E9 File Offset: 0x00004AE9
		public unsafe string logFileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultTraceListener.NativeFieldInfoPtr_logFileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultTraceListener.NativeFieldInfoPtr_logFileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000994 RID: 2452
		private static readonly IntPtr NativeFieldInfoPtr_OnWin32;

		// Token: 0x04000995 RID: 2453
		private static readonly IntPtr NativeFieldInfoPtr_MonoTracePrefix;

		// Token: 0x04000996 RID: 2454
		private static readonly IntPtr NativeFieldInfoPtr_MonoTraceFile;

		// Token: 0x04000997 RID: 2455
		private static readonly IntPtr NativeFieldInfoPtr_logFileName;

		// Token: 0x04000998 RID: 2456
		private static readonly IntPtr NativeMethodInfoPtr_GetPrefix_Private_Static_String_String_String_0;

		// Token: 0x04000999 RID: 2457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400099A RID: 2458
		private static readonly IntPtr NativeMethodInfoPtr_get_LogFileName_Public_get_String_0;

		// Token: 0x0400099B RID: 2459
		private static readonly IntPtr NativeMethodInfoPtr_WriteWindowsDebugString_Private_Static_Void_ptr_Char_0;

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeMethodInfoPtr_WriteDebugString_Private_Void_String_0;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeMethodInfoPtr_WriteMonoTrace_Private_Void_String_0;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr_WritePrefix_Private_Void_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_WriteImpl_Private_Void_String_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_WriteLogFile_Private_Void_String_String_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_String_0;

		// Token: 0x040009A2 RID: 2466
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Virtual_Void_String_0;
	}
}
