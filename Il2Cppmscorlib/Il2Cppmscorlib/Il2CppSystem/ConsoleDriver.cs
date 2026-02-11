using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000148 RID: 328
	public static class ConsoleDriver : Object
	{
		// Token: 0x060016DE RID: 5854 RVA: 0x00093484 File Offset: 0x00091684
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleDriver()
		{
			Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleDriver");
			ConsoleDriver.NativeFieldInfoPtr_driver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "driver");
			ConsoleDriver.NativeFieldInfoPtr_is_console = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "is_console");
			ConsoleDriver.NativeFieldInfoPtr_called_isatty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, "called_isatty");
			ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667314);
			ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667315);
			ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667316);
			ConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667317);
			ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667318);
			ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667319);
			ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667320);
			ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667321);
			ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667322);
			ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleDriver>.NativeClassPtr, 100667323);
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x000935B0 File Offset: 0x000917B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345165, RefRangeEnd = 1345166, XrefRangeStart = 1345162, XrefRangeEnd = 1345165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateNullConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x000935E4 File Offset: 0x000917E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345170, RefRangeEnd = 1345171, XrefRangeStart = 1345166, XrefRangeEnd = 1345170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateWindowsConsoleDriver()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
		}

		// Token: 0x060016E1 RID: 5857 RVA: 0x00093618 File Offset: 0x00091818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345175, RefRangeEnd = 1345176, XrefRangeStart = 1345171, XrefRangeEnd = 1345175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IConsoleDriver CreateTermInfoDriver(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr3) : null;
			}
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x0009365C File Offset: 0x0009185C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345176, XrefRangeEnd = 1345184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00093688 File Offset: 0x00091888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345184, XrefRangeEnd = 1345191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x060016E4 RID: 5860 RVA: 0x000936C8 File Offset: 0x000918C8
		public unsafe static bool IsConsole
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1345214, RefRangeEnd = 1345218, XrefRangeStart = 1345191, XrefRangeEnd = 1345214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x000936F8 File Offset: 0x000918F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345218, XrefRangeEnd = 1345219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Isatty(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00093738 File Offset: 0x00091938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int InternalKeyAvailable(int ms_timeout)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ms_timeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00093778 File Offset: 0x00091978
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345219, XrefRangeEnd = 1345238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TtySetup(string keypadXmit, string teardown, out Il2CppStructArray<byte> control_characters, out int* address)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(keypadXmit);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(teardown);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0, 0, (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			control_characters = ((intPtr5 == 0) ? null : new Il2CppStructArray<byte>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			address = ((intPtr6 == 0) ? null : new int*(intPtr6));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x060016E8 RID: 5864 RVA: 0x00093814 File Offset: 0x00091A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345238, XrefRangeEnd = 1345248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SetEcho(bool wantEcho)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref wantEcho;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleDriver.NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016E9 RID: 5865 RVA: 0x000073DE File Offset: 0x000055DE
		public ConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00093854 File Offset: 0x00091A54
		// (set) Token: 0x060016EB RID: 5867 RVA: 0x000073E7 File Offset: 0x000055E7
		public unsafe static IConsoleDriver driver
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_driver, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConsoleDriver>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_driver, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0009387C File Offset: 0x00091A7C
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x000073F9 File Offset: 0x000055F9
		public unsafe static bool is_console
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_is_console, (void*)(&value));
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x00093898 File Offset: 0x00091A98
		// (set) Token: 0x060016EF RID: 5871 RVA: 0x00007407 File Offset: 0x00005607
		public unsafe static bool called_isatty
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleDriver.NativeFieldInfoPtr_called_isatty, (void*)(&value));
			}
		}

		// Token: 0x040013B5 RID: 5045
		private static readonly IntPtr NativeFieldInfoPtr_driver;

		// Token: 0x040013B6 RID: 5046
		private static readonly IntPtr NativeFieldInfoPtr_is_console;

		// Token: 0x040013B7 RID: 5047
		private static readonly IntPtr NativeFieldInfoPtr_called_isatty;

		// Token: 0x040013B8 RID: 5048
		private static readonly IntPtr NativeMethodInfoPtr_CreateNullConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly IntPtr NativeMethodInfoPtr_CreateWindowsConsoleDriver_Private_Static_IConsoleDriver_0;

		// Token: 0x040013BA RID: 5050
		private static readonly IntPtr NativeMethodInfoPtr_CreateTermInfoDriver_Private_Static_IConsoleDriver_String_0;

		// Token: 0x040013BB RID: 5051
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Static_String_0;

		// Token: 0x040013BC RID: 5052
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040013BD RID: 5053
		private static readonly IntPtr NativeMethodInfoPtr_get_IsConsole_Public_Static_get_Boolean_0;

		// Token: 0x040013BE RID: 5054
		private static readonly IntPtr NativeMethodInfoPtr_Isatty_Private_Static_Boolean_IntPtr_0;

		// Token: 0x040013BF RID: 5055
		private static readonly IntPtr NativeMethodInfoPtr_InternalKeyAvailable_Internal_Static_Int32_Int32_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly IntPtr NativeMethodInfoPtr_TtySetup_Internal_Static_Boolean_String_String_byref_Il2CppStructArray_1_Byte_byref_ptr_Int32_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly IntPtr NativeMethodInfoPtr_SetEcho_Internal_Static_Boolean_Boolean_0;
	}
}
