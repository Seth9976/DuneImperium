using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000147 RID: 327
	public static class Console : Object
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x00092D88 File Offset: 0x00090F88
		// Note: this type is marked as 'beforefieldinit'.
		static Console()
		{
			Il2CppClassPointerStore<Console>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Console");
			Console.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdout");
			Console.NativeFieldInfoPtr_stderr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stderr");
			Console.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "stdin");
			Console.NativeFieldInfoPtr_IsRunningOnAndroid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "IsRunningOnAndroid");
			Console.NativeFieldInfoPtr_inputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "inputEncoding");
			Console.NativeFieldInfoPtr_outputEncoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "outputEncoding");
			Console.NativeFieldInfoPtr_cancel_event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console>.NativeClassPtr, "cancel_event");
			Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667288);
			Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667289);
			Console.NativeMethodInfoPtr_get_Out_Public_Static_get_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667290);
			Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667291);
			Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667292);
			Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667293);
			Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667294);
			Console.NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667295);
			Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667296);
			Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667297);
			Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667298);
			Console.NativeMethodInfoPtr_ReadLine_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667299);
			Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667300);
			Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667301);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667302);
			Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667303);
			Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console>.NativeClassPtr, 100667304);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00092F90 File Offset: 0x00091190
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1344939, RefRangeEnd = 1344940, XrefRangeStart = 1344861, XrefRangeEnd = 1344939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetupStreams(Encoding inputEncoding, Encoding outputEncoding)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(inputEncoding);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputEncoding);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x00092FD8 File Offset: 0x000911D8
		public unsafe static TextWriter Error
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344940, XrefRangeEnd = 1344944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x060016C0 RID: 5824 RVA: 0x0009300C File Offset: 0x0009120C
		public unsafe static TextWriter Out
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344944, XrefRangeEnd = 1344948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_Out_Public_Static_get_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr3) : null;
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00093040 File Offset: 0x00091240
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1344960, RefRangeEnd = 1344963, XrefRangeStart = 1344948, XrefRangeEnd = 1344960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream Open(IntPtr handle, FileAccess access, int bufferSize)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref access;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferSize;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0009309C File Offset: 0x0009129C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1344971, RefRangeEnd = 1344973, XrefRangeStart = 1344963, XrefRangeEnd = 1344971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardError(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000930DC File Offset: 0x000912DC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1344981, RefRangeEnd = 1344984, XrefRangeStart = 1344973, XrefRangeEnd = 1344981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardInput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0009311C File Offset: 0x0009131C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1344992, RefRangeEnd = 1344994, XrefRangeStart = 1344984, XrefRangeEnd = 1344992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Stream OpenStandardOutput(int bufferSize)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bufferSize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
			}
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x0009315C File Offset: 0x0009135C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345010, RefRangeEnd = 1345011, XrefRangeStart = 1344994, XrefRangeEnd = 1345010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetError(TextWriter newError)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newError);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x00093194 File Offset: 0x00091394
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345027, RefRangeEnd = 1345028, XrefRangeStart = 1345011, XrefRangeEnd = 1345027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetOut(TextWriter newOut)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newOut);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000931CC File Offset: 0x000913CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345033, RefRangeEnd = 1345034, XrefRangeStart = 1345028, XrefRangeEnd = 1345033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteLine(string value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016C8 RID: 5832 RVA: 0x00093204 File Offset: 0x00091404
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345087, RefRangeEnd = 1345088, XrefRangeStart = 1345034, XrefRangeEnd = 1345087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void WriteLine(string format, Object arg0)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(arg0);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C9 RID: 5833 RVA: 0x0009324C File Offset: 0x0009144C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345112, RefRangeEnd = 1345113, XrefRangeStart = 1345088, XrefRangeEnd = 1345112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadLine()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadLine_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x00093278 File Offset: 0x00091478
		public unsafe static Encoding InputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345113, XrefRangeEnd = 1345117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x060016CB RID: 5835 RVA: 0x000932AC File Offset: 0x000914AC
		public unsafe static Encoding OutputEncoding
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345117, XrefRangeEnd = 1345121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr3) : null;
			}
		}

		// Token: 0x060016CC RID: 5836 RVA: 0x000932E0 File Offset: 0x000914E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345134, RefRangeEnd = 1345135, XrefRangeStart = 1345121, XrefRangeEnd = 1345134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00093310 File Offset: 0x00091510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1345135, XrefRangeEnd = 1345145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ConsoleKeyInfo ReadKey(bool intercept)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x00093350 File Offset: 0x00091550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1345161, RefRangeEnd = 1345162, XrefRangeStart = 1345145, XrefRangeEnd = 1345161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoConsoleCancelEvent()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0000735B File Offset: 0x0000555B
		public Console(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00093378 File Offset: 0x00091578
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00007364 File Offset: 0x00005564
		public unsafe static TextWriter stdout
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdout, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdout, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x000933A0 File Offset: 0x000915A0
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00007376 File Offset: 0x00005576
		public unsafe static TextWriter stderr
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stderr, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextWriter>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stderr, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x000933C8 File Offset: 0x000915C8
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00007388 File Offset: 0x00005588
		public unsafe static TextReader stdin
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_stdin, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_stdin, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x060016D6 RID: 5846 RVA: 0x000933F0 File Offset: 0x000915F0
		// (set) Token: 0x060016D7 RID: 5847 RVA: 0x0000739A File Offset: 0x0000559A
		public unsafe static bool IsRunningOnAndroid
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_IsRunningOnAndroid, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_IsRunningOnAndroid, (void*)(&value));
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x060016D8 RID: 5848 RVA: 0x0009340C File Offset: 0x0009160C
		// (set) Token: 0x060016D9 RID: 5849 RVA: 0x000073A8 File Offset: 0x000055A8
		public unsafe static Encoding inputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_inputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_inputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x060016DA RID: 5850 RVA: 0x00093434 File Offset: 0x00091634
		// (set) Token: 0x060016DB RID: 5851 RVA: 0x000073BA File Offset: 0x000055BA
		public unsafe static Encoding outputEncoding
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_outputEncoding, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Encoding>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_outputEncoding, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x060016DC RID: 5852 RVA: 0x0009345C File Offset: 0x0009165C
		// (set) Token: 0x060016DD RID: 5853 RVA: 0x000073CC File Offset: 0x000055CC
		public unsafe static ConsoleCancelEventHandler cancel_event
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Console.NativeFieldInfoPtr_cancel_event, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConsoleCancelEventHandler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Console.NativeFieldInfoPtr_cancel_event, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400139D RID: 5021
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x0400139E RID: 5022
		private static readonly IntPtr NativeFieldInfoPtr_stderr;

		// Token: 0x0400139F RID: 5023
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_IsRunningOnAndroid;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_inputEncoding;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_outputEncoding;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_cancel_event;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeMethodInfoPtr_SetupStreams_Private_Static_Void_Encoding_Encoding_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_Static_get_TextWriter_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_get_Out_Public_Static_get_TextWriter_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_Open_Private_Static_Stream_IntPtr_FileAccess_Int32_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardError_Public_Static_Stream_Int32_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardInput_Public_Static_Stream_Int32_0;

		// Token: 0x040013AA RID: 5034
		private static readonly IntPtr NativeMethodInfoPtr_OpenStandardOutput_Public_Static_Stream_Int32_0;

		// Token: 0x040013AB RID: 5035
		private static readonly IntPtr NativeMethodInfoPtr_SetError_Public_Static_Void_TextWriter_0;

		// Token: 0x040013AC RID: 5036
		private static readonly IntPtr NativeMethodInfoPtr_SetOut_Public_Static_Void_TextWriter_0;

		// Token: 0x040013AD RID: 5037
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_0;

		// Token: 0x040013AE RID: 5038
		private static readonly IntPtr NativeMethodInfoPtr_WriteLine_Public_Static_Void_String_Object_0;

		// Token: 0x040013AF RID: 5039
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Static_String_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly IntPtr NativeMethodInfoPtr_get_InputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly IntPtr NativeMethodInfoPtr_get_OutputEncoding_Public_Static_get_Encoding_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Static_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly IntPtr NativeMethodInfoPtr_DoConsoleCancelEvent_Private_Static_Void_0;

		// Token: 0x020005F3 RID: 1523
		public class WindowsConsole : Object
		{
			// Token: 0x06005794 RID: 22420 RVA: 0x001939D0 File Offset: 0x00191BD0
			// Note: this type is marked as 'beforefieldinit'.
			static WindowsConsole()
			{
				Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console>.NativeClassPtr, "WindowsConsole");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr);
				Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "ctrlHandlerAdded");
				Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "cancelHandler");
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100667305);
				Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100667306);
				Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100667307);
				Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100667308);
				Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, 100667309);
			}

			// Token: 0x06005795 RID: 22421 RVA: 0x00193A88 File Offset: 0x00191C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344841, XrefRangeEnd = 1344843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005796 RID: 22422 RVA: 0x00193AB8 File Offset: 0x00191CB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344843, XrefRangeEnd = 1344845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetConsoleOutputCP()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005797 RID: 22423 RVA: 0x00193AE8 File Offset: 0x00191CE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344845, XrefRangeEnd = 1344849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool DoWindowsConsoleCancelEvent(int keyCode)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref keyCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005798 RID: 22424 RVA: 0x00193B28 File Offset: 0x00191D28
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344854, RefRangeEnd = 1344855, XrefRangeStart = 1344849, XrefRangeEnd = 1344854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetInputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005799 RID: 22425 RVA: 0x00193B58 File Offset: 0x00191D58
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1344860, RefRangeEnd = 1344861, XrefRangeStart = 1344855, XrefRangeEnd = 1344860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int GetOutputCodePage()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600579A RID: 22426 RVA: 0x0001F214 File Offset: 0x0001D414
			public WindowsConsole(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001653 RID: 5715
			// (get) Token: 0x0600579B RID: 22427 RVA: 0x00193B88 File Offset: 0x00191D88
			// (set) Token: 0x0600579C RID: 22428 RVA: 0x0001F21D File Offset: 0x0001D41D
			public unsafe static bool ctrlHandlerAdded
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_ctrlHandlerAdded, (void*)(&value));
				}
			}

			// Token: 0x17001654 RID: 5716
			// (get) Token: 0x0600579D RID: 22429 RVA: 0x00193BA4 File Offset: 0x00191DA4
			// (set) Token: 0x0600579E RID: 22430 RVA: 0x0001F22B File Offset: 0x0001D42B
			public unsafe static Console.WindowsConsole.WindowsCancelHandler cancelHandler
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Console.WindowsConsole.WindowsCancelHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Console.WindowsConsole.NativeFieldInfoPtr_cancelHandler, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400481A RID: 18458
			private static readonly IntPtr NativeFieldInfoPtr_ctrlHandlerAdded;

			// Token: 0x0400481B RID: 18459
			private static readonly IntPtr NativeFieldInfoPtr_cancelHandler;

			// Token: 0x0400481C RID: 18460
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleCP_Private_Static_Int32_0;

			// Token: 0x0400481D RID: 18461
			private static readonly IntPtr NativeMethodInfoPtr_GetConsoleOutputCP_Private_Static_Int32_0;

			// Token: 0x0400481E RID: 18462
			private static readonly IntPtr NativeMethodInfoPtr_DoWindowsConsoleCancelEvent_Private_Static_Boolean_Int32_0;

			// Token: 0x0400481F RID: 18463
			private static readonly IntPtr NativeMethodInfoPtr_GetInputCodePage_Public_Static_Int32_0;

			// Token: 0x04004820 RID: 18464
			private static readonly IntPtr NativeMethodInfoPtr_GetOutputCodePage_Public_Static_Int32_0;

			// Token: 0x02000787 RID: 1927
			public sealed class WindowsCancelHandler : MulticastDelegate
			{
				// Token: 0x060062F5 RID: 25333 RVA: 0x000250DE File Offset: 0x000232DE
				// Note: this type is marked as 'beforefieldinit'.
				static WindowsCancelHandler()
				{
					Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Console.WindowsConsole>.NativeClassPtr, "WindowsCancelHandler");
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100667311);
					Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr, 100667312);
				}

				// Token: 0x060062F6 RID: 25334 RVA: 0x001B9854 File Offset: 0x001B7A54
				[CallerCount(49)]
				[CachedScanResults(RefRangeStart = 864047, RefRangeEnd = 864096, XrefRangeStart = 864047, XrefRangeEnd = 864096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe WindowsCancelHandler(Object @object, IntPtr method)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Console.WindowsConsole.WindowsCancelHandler>.NativeClassPtr))
				{
					IntPtr* ptr;
					checked
					{
						ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					}
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060062F7 RID: 25335 RVA: 0x001B98B0 File Offset: 0x001B7AB0
				[CallerCount(0)]
				public unsafe bool Invoke(int keyCode)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref keyCode;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Console.WindowsConsole.WindowsCancelHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						return *IL2CPP.il2cpp_object_unbox(intPtr);
					}
				}

				// Token: 0x060062F8 RID: 25336 RVA: 0x0002511C File Offset: 0x0002331C
				public WindowsCancelHandler(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x060062F9 RID: 25337 RVA: 0x00025125 File Offset: 0x00023325
				public static implicit operator Console.WindowsConsole.WindowsCancelHandler(Func<int, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<Console.WindowsConsole.WindowsCancelHandler>(A_0);
				}

				// Token: 0x060062FA RID: 25338 RVA: 0x0002512D File Offset: 0x0002332D
				public static Console.WindowsConsole.WindowsCancelHandler operator +(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<Console.WindowsConsole.WindowsCancelHandler>();
				}

				// Token: 0x060062FB RID: 25339 RVA: 0x0002513B File Offset: 0x0002333B
				public static Console.WindowsConsole.WindowsCancelHandler operator -(Console.WindowsConsole.WindowsCancelHandler A_0, Console.WindowsConsole.WindowsCancelHandler A_1)
				{
					Delegate delegate2;
					Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
					if (@delegate != null)
					{
						delegate2 = @delegate.Cast<Console.WindowsConsole.WindowsCancelHandler>();
					}
					return delegate2;
				}

				// Token: 0x040050A7 RID: 20647
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x040050A8 RID: 20648
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Int32_0;
			}
		}
	}
}
