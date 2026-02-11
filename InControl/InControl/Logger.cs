using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace InControl
{
	// Token: 0x02000033 RID: 51
	public static class Logger : Object
	{
		// Token: 0x060003A3 RID: 931 RVA: 0x00014DF8 File Offset: 0x00012FF8
		// Note: this type is marked as 'beforefieldinit'.
		static Logger()
		{
			Il2CppClassPointerStore<Logger>.NativeClassPtr = IL2CPP.GetIl2CppClass("InControl.dll", "InControl", "Logger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Logger>.NativeClassPtr);
			Logger.NativeFieldInfoPtr_OnLogMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Logger>.NativeClassPtr, "OnLogMessage");
			Logger.NativeMethodInfoPtr_add_OnLogMessage_Public_Static_add_Void_Action_1_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663789);
			Logger.NativeMethodInfoPtr_remove_OnLogMessage_Public_Static_rem_Void_Action_1_LogMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663790);
			Logger.NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663791);
			Logger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663792);
			Logger.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Logger>.NativeClassPtr, 100663793);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00014EA0 File Offset: 0x000130A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 773684, RefRangeEnd = 773685, XrefRangeStart = 773675, XrefRangeEnd = 773684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_OnLogMessage(Action<LogMessage> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_add_OnLogMessage_Public_Static_add_Void_Action_1_LogMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00014ED8 File Offset: 0x000130D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 773685, XrefRangeEnd = 773694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_OnLogMessage(Action<LogMessage> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_remove_OnLogMessage_Public_Static_rem_Void_Action_1_LogMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00014F10 File Offset: 0x00013110
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 773698, RefRangeEnd = 773707, XrefRangeStart = 773694, XrefRangeEnd = 773698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogInfo(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00014F48 File Offset: 0x00013148
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 773711, RefRangeEnd = 773713, XrefRangeStart = 773707, XrefRangeEnd = 773711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogWarning(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00014F80 File Offset: 0x00013180
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 773717, RefRangeEnd = 773726, XrefRangeStart = 773713, XrefRangeEnd = 773717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void LogError(string text)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Logger.NativeMethodInfoPtr_LogError_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000358C File Offset: 0x0000178C
		public Logger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00014FB8 File Offset: 0x000131B8
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00003595 File Offset: 0x00001795
		public unsafe static Action<LogMessage> OnLogMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Logger.NativeFieldInfoPtr_OnLogMessage, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<LogMessage>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Logger.NativeFieldInfoPtr_OnLogMessage, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000440 RID: 1088
		private static readonly IntPtr NativeFieldInfoPtr_OnLogMessage;

		// Token: 0x04000441 RID: 1089
		private static readonly IntPtr NativeMethodInfoPtr_add_OnLogMessage_Public_Static_add_Void_Action_1_LogMessage_0;

		// Token: 0x04000442 RID: 1090
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnLogMessage_Public_Static_rem_Void_Action_1_LogMessage_0;

		// Token: 0x04000443 RID: 1091
		private static readonly IntPtr NativeMethodInfoPtr_LogInfo_Public_Static_Void_String_0;

		// Token: 0x04000444 RID: 1092
		private static readonly IntPtr NativeMethodInfoPtr_LogWarning_Public_Static_Void_String_0;

		// Token: 0x04000445 RID: 1093
		private static readonly IntPtr NativeMethodInfoPtr_LogError_Public_Static_Void_String_0;
	}
}
