using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.IO;

namespace Il2CppSystem
{
	// Token: 0x02000165 RID: 357
	public class TermInfoDriver : Object
	{
		// Token: 0x06001816 RID: 6166 RVA: 0x00098880 File Offset: 0x00096A80
		// Note: this type is marked as 'beforefieldinit'.
		static TermInfoDriver()
		{
			Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "TermInfoDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr);
			TermInfoDriver.NativeFieldInfoPtr_native_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "native_terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_terminal_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "terminal_size");
			TermInfoDriver.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "locations");
			TermInfoDriver.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "reader");
			TermInfoDriver.NativeFieldInfoPtr_cursorLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorLeft");
			TermInfoDriver.NativeFieldInfoPtr_cursorTop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorTop");
			TermInfoDriver.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "title");
			TermInfoDriver.NativeFieldInfoPtr_titleFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "titleFormat");
			TermInfoDriver.NativeFieldInfoPtr_cursorVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrVisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrVisible");
			TermInfoDriver.NativeFieldInfoPtr_csrInvisible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "csrInvisible");
			TermInfoDriver.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "clear");
			TermInfoDriver.NativeFieldInfoPtr_bell = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bell");
			TermInfoDriver.NativeFieldInfoPtr_term = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "term");
			TermInfoDriver.NativeFieldInfoPtr_stdin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdin");
			TermInfoDriver.NativeFieldInfoPtr_stdout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "stdout");
			TermInfoDriver.NativeFieldInfoPtr_windowWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowWidth");
			TermInfoDriver.NativeFieldInfoPtr_windowHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "windowHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferHeight");
			TermInfoDriver.NativeFieldInfoPtr_bufferWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "bufferWidth");
			TermInfoDriver.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "buffer");
			TermInfoDriver.NativeFieldInfoPtr_readpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "readpos");
			TermInfoDriver.NativeFieldInfoPtr_writepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "writepos");
			TermInfoDriver.NativeFieldInfoPtr_keypadXmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadXmit");
			TermInfoDriver.NativeFieldInfoPtr_keypadLocal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keypadLocal");
			TermInfoDriver.NativeFieldInfoPtr_inited = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "inited");
			TermInfoDriver.NativeFieldInfoPtr_initLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initLock");
			TermInfoDriver.NativeFieldInfoPtr_initKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "initKeys");
			TermInfoDriver.NativeFieldInfoPtr_origPair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origPair");
			TermInfoDriver.NativeFieldInfoPtr_origColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "origColors");
			TermInfoDriver.NativeFieldInfoPtr_cursorAddress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "cursorAddress");
			TermInfoDriver.NativeFieldInfoPtr_fgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "fgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setfgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setfgcolor");
			TermInfoDriver.NativeFieldInfoPtr_setbgcolor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "setbgcolor");
			TermInfoDriver.NativeFieldInfoPtr_maxColors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "maxColors");
			TermInfoDriver.NativeFieldInfoPtr_noGetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "noGetPosition");
			TermInfoDriver.NativeFieldInfoPtr_keymap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "keymap");
			TermInfoDriver.NativeFieldInfoPtr_rootmap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rootmap");
			TermInfoDriver.NativeFieldInfoPtr_rl_startx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_startx");
			TermInfoDriver.NativeFieldInfoPtr_rl_starty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "rl_starty");
			TermInfoDriver.NativeFieldInfoPtr_control_characters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "control_characters");
			TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "_consoleColorToAnsiCode");
			TermInfoDriver.NativeFieldInfoPtr_echobuf = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echobuf");
			TermInfoDriver.NativeFieldInfoPtr_echon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, "echon");
			TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667510);
			TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667511);
			TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667512);
			TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667513);
			TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667514);
			TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667515);
			TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667516);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667517);
			TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667518);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667519);
			TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667520);
			TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667521);
			TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667522);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667523);
			TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667524);
			TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667525);
			TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667526);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667527);
			TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667528);
			TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667529);
			TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667530);
			TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667531);
			TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667532);
			TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667533);
			TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667534);
			TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667535);
			TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667536);
			TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667537);
			TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667538);
			TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667539);
			TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667540);
			TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667541);
			TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr, 100667542);
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00098EB4 File Offset: 0x000970B4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1348375, RefRangeEnd = 1348379, XrefRangeStart = 1348361, XrefRangeEnd = 1348375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string TryTermInfoDir(string dir, string term)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(dir);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(term);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00098F04 File Offset: 0x00097104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348379, XrefRangeEnd = 1348398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string SearchTerminfo(string term)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00098F40 File Offset: 0x00097140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348398, XrefRangeEnd = 1348399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteConsole(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteConsole_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00098F84 File Offset: 0x00097184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348487, RefRangeEnd = 1348488, XrefRangeStart = 1348399, XrefRangeEnd = 1348487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TermInfoDriver(string term)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TermInfoDriver>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(term);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00098FD0 File Offset: 0x000971D0
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0009900C File Offset: 0x0009720C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1348604, RefRangeEnd = 1348613, XrefRangeStart = 1348488, XrefRangeEnd = 1348604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x00099040 File Offset: 0x00097240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348613, XrefRangeEnd = 1348617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementX()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IncrementX_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600181E RID: 6174 RVA: 0x00099074 File Offset: 0x00097274
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348630, RefRangeEnd = 1348632, XrefRangeStart = 1348617, XrefRangeEnd = 1348630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600181F RID: 6175 RVA: 0x000990B4 File Offset: 0x000972B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348634, RefRangeEnd = 1348636, XrefRangeStart = 1348632, XrefRangeEnd = 1348634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void WriteSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x000990F4 File Offset: 0x000972F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348636, RefRangeEnd = 1348638, XrefRangeStart = 1348636, XrefRangeEnd = 1348636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x00099140 File Offset: 0x00097340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348640, RefRangeEnd = 1348642, XrefRangeStart = 1348638, XrefRangeEnd = 1348640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsSpecialKey(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0009918C File Offset: 0x0009738C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348661, RefRangeEnd = 1348663, XrefRangeStart = 1348642, XrefRangeEnd = 1348661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCursorPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetCursorPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x000991C0 File Offset: 0x000973C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1348678, RefRangeEnd = 1348685, XrefRangeStart = 1348663, XrefRangeEnd = 1348678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckWindowDimensions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x000991F4 File Offset: 0x000973F4
		public unsafe virtual int WindowHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348685, XrefRangeEnd = 1348687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001825 RID: 6181 RVA: 0x00099230 File Offset: 0x00097430
		public unsafe virtual int WindowWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348687, XrefRangeEnd = 1348689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0009926C File Offset: 0x0009746C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1348697, RefRangeEnd = 1348705, XrefRangeStart = 1348689, XrefRangeEnd = 1348697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddToBuffer(int b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x000992AC File Offset: 0x000974AC
		[CallerCount(0)]
		public unsafe void AdjustBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AdjustBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000992E0 File Offset: 0x000974E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1348713, RefRangeEnd = 1348717, XrefRangeStart = 1348705, XrefRangeEnd = 1348713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo CreateKeyInfoFromInt(int n, bool alt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref n;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x00099338 File Offset: 0x00097538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1348743, RefRangeEnd = 1348748, XrefRangeStart = 1348717, XrefRangeEnd = 1348743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetKeyFromBuffer(bool cooked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cooked;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00099384 File Offset: 0x00097584
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1348771, RefRangeEnd = 1348774, XrefRangeStart = 1348748, XrefRangeEnd = 1348771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo ReadKeyInternal(out bool fresh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &fresh;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x000993D0 File Offset: 0x000975D0
		[CallerCount(0)]
		public unsafe bool InputPending()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InputPending_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x0009940C File Offset: 0x0009760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348774, XrefRangeEnd = 1348780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueEcho(char c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x0009944C File Offset: 0x0009764C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1348783, RefRangeEnd = 1348786, XrefRangeStart = 1348780, XrefRangeEnd = 1348783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Echo(ConsoleKeyInfo key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref key;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x0009948C File Offset: 0x0009768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348786, XrefRangeEnd = 1348787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EchoFlush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_EchoFlush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x000994C0 File Offset: 0x000976C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348819, RefRangeEnd = 1348820, XrefRangeStart = 1348787, XrefRangeEnd = 1348819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read([In] [Out] Il2CppStructArray<char> dest, int index, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*dest = ((intPtr4 == 0) ? null : new Il2CppStructArray<char>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0009953C File Offset: 0x0009773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1348820, XrefRangeEnd = 1348823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00099588 File Offset: 0x00097788
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348824, RefRangeEnd = 1348825, XrefRangeStart = 1348823, XrefRangeEnd = 1348824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x000995C0 File Offset: 0x000977C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1348826, RefRangeEnd = 1348827, XrefRangeStart = 1348825, XrefRangeEnd = 1348826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadToEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadToEnd_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000995F8 File Offset: 0x000977F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348842, RefRangeEnd = 1348844, XrefRangeStart = 1348827, XrefRangeEnd = 1348842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntilConditionInternal(bool haltOnNewLine)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref haltOnNewLine;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0009963C File Offset: 0x0009783C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1348872, RefRangeEnd = 1348874, XrefRangeStart = 1348844, XrefRangeEnd = 1348872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetCursorPosition(int left, int top)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref top;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00099688 File Offset: 0x00097888
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349181, RefRangeEnd = 1349182, XrefRangeStart = 1348874, XrefRangeEnd = 1349181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateKeyMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_CreateKeyMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x000996BC File Offset: 0x000978BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349208, RefRangeEnd = 1349209, XrefRangeStart = 1349182, XrefRangeEnd = 1349208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitKeys()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_InitKeys_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000996F0 File Offset: 0x000978F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1349216, RefRangeEnd = 1349217, XrefRangeStart = 1349209, XrefRangeEnd = 1349216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddStringMapping(TermInfoStrings s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref s;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TermInfoDriver.NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x000078EB File Offset: 0x00005AEB
		public TermInfoDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x00099730 File Offset: 0x00097930
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x000078F4 File Offset: 0x00005AF4
		public unsafe static int* native_terminal_size
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)(&intPtr));
				return *intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_native_terminal_size, (void*)value);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0009974C File Offset: 0x0009794C
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x00007901 File Offset: 0x00005B01
		public unsafe static int terminal_size
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_terminal_size, (void*)(&value));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x00099768 File Offset: 0x00097968
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000790F File Offset: 0x00005B0F
		public unsafe static Il2CppStringArray locations
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr_locations, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr_locations, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600183F RID: 6207 RVA: 0x00099790 File Offset: 0x00097990
		// (set) Token: 0x06001840 RID: 6208 RVA: 0x00007921 File Offset: 0x00005B21
		public unsafe TermInfoReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TermInfoReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001841 RID: 6209 RVA: 0x000997C0 File Offset: 0x000979C0
		// (set) Token: 0x06001842 RID: 6210 RVA: 0x00007940 File Offset: 0x00005B40
		public unsafe int cursorLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorLeft)) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x000997E8 File Offset: 0x000979E8
		// (set) Token: 0x06001844 RID: 6212 RVA: 0x0000795B File Offset: 0x00005B5B
		public unsafe int cursorTop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorTop)) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00099810 File Offset: 0x00097A10
		// (set) Token: 0x06001846 RID: 6214 RVA: 0x00007976 File Offset: 0x00005B76
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x00099838 File Offset: 0x00097A38
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x00007995 File Offset: 0x00005B95
		public unsafe string titleFormat
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_titleFormat), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00099860 File Offset: 0x00097A60
		// (set) Token: 0x0600184A RID: 6218 RVA: 0x000079B4 File Offset: 0x00005BB4
		public unsafe bool cursorVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorVisible)) = value;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x0600184B RID: 6219 RVA: 0x00099888 File Offset: 0x00097A88
		// (set) Token: 0x0600184C RID: 6220 RVA: 0x000079CF File Offset: 0x00005BCF
		public unsafe string csrVisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrVisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x000998B0 File Offset: 0x00097AB0
		// (set) Token: 0x0600184E RID: 6222 RVA: 0x000079EE File Offset: 0x00005BEE
		public unsafe string csrInvisible
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_csrInvisible), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x0600184F RID: 6223 RVA: 0x000998D8 File Offset: 0x00097AD8
		// (set) Token: 0x06001850 RID: 6224 RVA: 0x00007A0D File Offset: 0x00005C0D
		public unsafe string clear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_clear), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001851 RID: 6225 RVA: 0x00099900 File Offset: 0x00097B00
		// (set) Token: 0x06001852 RID: 6226 RVA: 0x00007A2C File Offset: 0x00005C2C
		public unsafe string bell
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bell), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001853 RID: 6227 RVA: 0x00099928 File Offset: 0x00097B28
		// (set) Token: 0x06001854 RID: 6228 RVA: 0x00007A4B File Offset: 0x00005C4B
		public unsafe string term
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_term), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00099950 File Offset: 0x00097B50
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x00007A6A File Offset: 0x00005C6A
		public unsafe StreamReader stdin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StreamReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x00099980 File Offset: 0x00097B80
		// (set) Token: 0x06001858 RID: 6232 RVA: 0x00007A89 File Offset: 0x00005C89
		public unsafe CStreamWriter stdout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CStreamWriter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_stdout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001859 RID: 6233 RVA: 0x000999B0 File Offset: 0x00097BB0
		// (set) Token: 0x0600185A RID: 6234 RVA: 0x00007AA8 File Offset: 0x00005CA8
		public unsafe int windowWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowWidth)) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600185B RID: 6235 RVA: 0x000999D8 File Offset: 0x00097BD8
		// (set) Token: 0x0600185C RID: 6236 RVA: 0x00007AC3 File Offset: 0x00005CC3
		public unsafe int windowHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_windowHeight)) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600185D RID: 6237 RVA: 0x00099A00 File Offset: 0x00097C00
		// (set) Token: 0x0600185E RID: 6238 RVA: 0x00007ADE File Offset: 0x00005CDE
		public unsafe int bufferHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferHeight)) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600185F RID: 6239 RVA: 0x00099A28 File Offset: 0x00097C28
		// (set) Token: 0x06001860 RID: 6240 RVA: 0x00007AF9 File Offset: 0x00005CF9
		public unsafe int bufferWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_bufferWidth)) = value;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001861 RID: 6241 RVA: 0x00099A50 File Offset: 0x00097C50
		// (set) Token: 0x06001862 RID: 6242 RVA: 0x00007B14 File Offset: 0x00005D14
		public unsafe Il2CppStructArray<char> buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001863 RID: 6243 RVA: 0x00099A80 File Offset: 0x00097C80
		// (set) Token: 0x06001864 RID: 6244 RVA: 0x00007B33 File Offset: 0x00005D33
		public unsafe int readpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_readpos)) = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001865 RID: 6245 RVA: 0x00099AA8 File Offset: 0x00097CA8
		// (set) Token: 0x06001866 RID: 6246 RVA: 0x00007B4E File Offset: 0x00005D4E
		public unsafe int writepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_writepos)) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001867 RID: 6247 RVA: 0x00099AD0 File Offset: 0x00097CD0
		// (set) Token: 0x06001868 RID: 6248 RVA: 0x00007B69 File Offset: 0x00005D69
		public unsafe string keypadXmit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadXmit), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001869 RID: 6249 RVA: 0x00099AF8 File Offset: 0x00097CF8
		// (set) Token: 0x0600186A RID: 6250 RVA: 0x00007B88 File Offset: 0x00005D88
		public unsafe string keypadLocal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keypadLocal), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00099B20 File Offset: 0x00097D20
		// (set) Token: 0x0600186C RID: 6252 RVA: 0x00007BA7 File Offset: 0x00005DA7
		public unsafe bool inited
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_inited)) = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x00099B48 File Offset: 0x00097D48
		// (set) Token: 0x0600186E RID: 6254 RVA: 0x00007BC2 File Offset: 0x00005DC2
		public unsafe Object initLock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initLock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x00099B78 File Offset: 0x00097D78
		// (set) Token: 0x06001870 RID: 6256 RVA: 0x00007BE1 File Offset: 0x00005DE1
		public unsafe bool initKeys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_initKeys)) = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00099BA0 File Offset: 0x00097DA0
		// (set) Token: 0x06001872 RID: 6258 RVA: 0x00007BFC File Offset: 0x00005DFC
		public unsafe string origPair
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origPair), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x00099BC8 File Offset: 0x00097DC8
		// (set) Token: 0x06001874 RID: 6260 RVA: 0x00007C1B File Offset: 0x00005E1B
		public unsafe string origColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_origColors), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001875 RID: 6261 RVA: 0x00099BF0 File Offset: 0x00097DF0
		// (set) Token: 0x06001876 RID: 6262 RVA: 0x00007C3A File Offset: 0x00005E3A
		public unsafe string cursorAddress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_cursorAddress), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001877 RID: 6263 RVA: 0x00099C18 File Offset: 0x00097E18
		// (set) Token: 0x06001878 RID: 6264 RVA: 0x00007C59 File Offset: 0x00005E59
		public unsafe ConsoleColor fgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_fgcolor)) = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x00099C40 File Offset: 0x00097E40
		// (set) Token: 0x0600187A RID: 6266 RVA: 0x00007C74 File Offset: 0x00005E74
		public unsafe string setfgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setfgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600187B RID: 6267 RVA: 0x00099C68 File Offset: 0x00097E68
		// (set) Token: 0x0600187C RID: 6268 RVA: 0x00007C93 File Offset: 0x00005E93
		public unsafe string setbgcolor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_setbgcolor), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600187D RID: 6269 RVA: 0x00099C90 File Offset: 0x00097E90
		// (set) Token: 0x0600187E RID: 6270 RVA: 0x00007CB2 File Offset: 0x00005EB2
		public unsafe int maxColors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_maxColors)) = value;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x00099CB8 File Offset: 0x00097EB8
		// (set) Token: 0x06001880 RID: 6272 RVA: 0x00007CCD File Offset: 0x00005ECD
		public unsafe bool noGetPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_noGetPosition)) = value;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001881 RID: 6273 RVA: 0x00099CE0 File Offset: 0x00097EE0
		// (set) Token: 0x06001882 RID: 6274 RVA: 0x00007CE8 File Offset: 0x00005EE8
		public unsafe Hashtable keymap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_keymap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001883 RID: 6275 RVA: 0x00099D10 File Offset: 0x00097F10
		// (set) Token: 0x06001884 RID: 6276 RVA: 0x00007D07 File Offset: 0x00005F07
		public unsafe ByteMatcher rootmap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ByteMatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rootmap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x00099D40 File Offset: 0x00097F40
		// (set) Token: 0x06001886 RID: 6278 RVA: 0x00007D26 File Offset: 0x00005F26
		public unsafe int rl_startx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_startx)) = value;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001887 RID: 6279 RVA: 0x00099D68 File Offset: 0x00097F68
		// (set) Token: 0x06001888 RID: 6280 RVA: 0x00007D41 File Offset: 0x00005F41
		public unsafe int rl_starty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_rl_starty)) = value;
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x00099D90 File Offset: 0x00097F90
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x00007D5C File Offset: 0x00005F5C
		public unsafe Il2CppStructArray<byte> control_characters
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_control_characters), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x00099DC0 File Offset: 0x00097FC0
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x00007D7B File Offset: 0x00005F7B
		public unsafe static Il2CppStructArray<int> _consoleColorToAnsiCode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TermInfoDriver.NativeFieldInfoPtr__consoleColorToAnsiCode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x00099DE8 File Offset: 0x00097FE8
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x00007D8D File Offset: 0x00005F8D
		public unsafe Il2CppStructArray<char> echobuf
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echobuf), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x00099E18 File Offset: 0x00098018
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x00007DAC File Offset: 0x00005FAC
		public unsafe int echon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TermInfoDriver.NativeFieldInfoPtr_echon)) = value;
			}
		}

		// Token: 0x040014AC RID: 5292
		private static readonly IntPtr NativeFieldInfoPtr_native_terminal_size;

		// Token: 0x040014AD RID: 5293
		private static readonly IntPtr NativeFieldInfoPtr_terminal_size;

		// Token: 0x040014AE RID: 5294
		private static readonly IntPtr NativeFieldInfoPtr_locations;

		// Token: 0x040014AF RID: 5295
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x040014B0 RID: 5296
		private static readonly IntPtr NativeFieldInfoPtr_cursorLeft;

		// Token: 0x040014B1 RID: 5297
		private static readonly IntPtr NativeFieldInfoPtr_cursorTop;

		// Token: 0x040014B2 RID: 5298
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040014B3 RID: 5299
		private static readonly IntPtr NativeFieldInfoPtr_titleFormat;

		// Token: 0x040014B4 RID: 5300
		private static readonly IntPtr NativeFieldInfoPtr_cursorVisible;

		// Token: 0x040014B5 RID: 5301
		private static readonly IntPtr NativeFieldInfoPtr_csrVisible;

		// Token: 0x040014B6 RID: 5302
		private static readonly IntPtr NativeFieldInfoPtr_csrInvisible;

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_clear;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeFieldInfoPtr_bell;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeFieldInfoPtr_term;

		// Token: 0x040014BA RID: 5306
		private static readonly IntPtr NativeFieldInfoPtr_stdin;

		// Token: 0x040014BB RID: 5307
		private static readonly IntPtr NativeFieldInfoPtr_stdout;

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_windowWidth;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_windowHeight;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeFieldInfoPtr_bufferHeight;

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_bufferWidth;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x040014C1 RID: 5313
		private static readonly IntPtr NativeFieldInfoPtr_readpos;

		// Token: 0x040014C2 RID: 5314
		private static readonly IntPtr NativeFieldInfoPtr_writepos;

		// Token: 0x040014C3 RID: 5315
		private static readonly IntPtr NativeFieldInfoPtr_keypadXmit;

		// Token: 0x040014C4 RID: 5316
		private static readonly IntPtr NativeFieldInfoPtr_keypadLocal;

		// Token: 0x040014C5 RID: 5317
		private static readonly IntPtr NativeFieldInfoPtr_inited;

		// Token: 0x040014C6 RID: 5318
		private static readonly IntPtr NativeFieldInfoPtr_initLock;

		// Token: 0x040014C7 RID: 5319
		private static readonly IntPtr NativeFieldInfoPtr_initKeys;

		// Token: 0x040014C8 RID: 5320
		private static readonly IntPtr NativeFieldInfoPtr_origPair;

		// Token: 0x040014C9 RID: 5321
		private static readonly IntPtr NativeFieldInfoPtr_origColors;

		// Token: 0x040014CA RID: 5322
		private static readonly IntPtr NativeFieldInfoPtr_cursorAddress;

		// Token: 0x040014CB RID: 5323
		private static readonly IntPtr NativeFieldInfoPtr_fgcolor;

		// Token: 0x040014CC RID: 5324
		private static readonly IntPtr NativeFieldInfoPtr_setfgcolor;

		// Token: 0x040014CD RID: 5325
		private static readonly IntPtr NativeFieldInfoPtr_setbgcolor;

		// Token: 0x040014CE RID: 5326
		private static readonly IntPtr NativeFieldInfoPtr_maxColors;

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeFieldInfoPtr_noGetPosition;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeFieldInfoPtr_keymap;

		// Token: 0x040014D1 RID: 5329
		private static readonly IntPtr NativeFieldInfoPtr_rootmap;

		// Token: 0x040014D2 RID: 5330
		private static readonly IntPtr NativeFieldInfoPtr_rl_startx;

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeFieldInfoPtr_rl_starty;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeFieldInfoPtr_control_characters;

		// Token: 0x040014D5 RID: 5333
		private static readonly IntPtr NativeFieldInfoPtr__consoleColorToAnsiCode;

		// Token: 0x040014D6 RID: 5334
		private static readonly IntPtr NativeFieldInfoPtr_echobuf;

		// Token: 0x040014D7 RID: 5335
		private static readonly IntPtr NativeFieldInfoPtr_echon;

		// Token: 0x040014D8 RID: 5336
		private static readonly IntPtr NativeMethodInfoPtr_TryTermInfoDir_Private_Static_String_String_String_0;

		// Token: 0x040014D9 RID: 5337
		private static readonly IntPtr NativeMethodInfoPtr_SearchTerminfo_Private_Static_String_String_0;

		// Token: 0x040014DA RID: 5338
		private static readonly IntPtr NativeMethodInfoPtr_WriteConsole_Private_Void_String_0;

		// Token: 0x040014DB RID: 5339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x040014DC RID: 5340
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040014DD RID: 5341
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Final_New_Void_0;

		// Token: 0x040014DE RID: 5342
		private static readonly IntPtr NativeMethodInfoPtr_IncrementX_Private_Void_0;

		// Token: 0x040014DF RID: 5343
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_ConsoleKeyInfo_0;

		// Token: 0x040014E0 RID: 5344
		private static readonly IntPtr NativeMethodInfoPtr_WriteSpecialKey_Public_Void_Char_0;

		// Token: 0x040014E1 RID: 5345
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x040014E2 RID: 5346
		private static readonly IntPtr NativeMethodInfoPtr_IsSpecialKey_Public_Boolean_Char_0;

		// Token: 0x040014E3 RID: 5347
		private static readonly IntPtr NativeMethodInfoPtr_GetCursorPosition_Private_Void_0;

		// Token: 0x040014E4 RID: 5348
		private static readonly IntPtr NativeMethodInfoPtr_CheckWindowDimensions_Private_Void_0;

		// Token: 0x040014E5 RID: 5349
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowHeight_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014E6 RID: 5350
		private static readonly IntPtr NativeMethodInfoPtr_get_WindowWidth_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x040014E7 RID: 5351
		private static readonly IntPtr NativeMethodInfoPtr_AddToBuffer_Private_Void_Int32_0;

		// Token: 0x040014E8 RID: 5352
		private static readonly IntPtr NativeMethodInfoPtr_AdjustBuffer_Private_Void_0;

		// Token: 0x040014E9 RID: 5353
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyInfoFromInt_Private_ConsoleKeyInfo_Int32_Boolean_0;

		// Token: 0x040014EA RID: 5354
		private static readonly IntPtr NativeMethodInfoPtr_GetKeyFromBuffer_Private_Object_Boolean_0;

		// Token: 0x040014EB RID: 5355
		private static readonly IntPtr NativeMethodInfoPtr_ReadKeyInternal_Private_ConsoleKeyInfo_byref_Boolean_0;

		// Token: 0x040014EC RID: 5356
		private static readonly IntPtr NativeMethodInfoPtr_InputPending_Private_Boolean_0;

		// Token: 0x040014ED RID: 5357
		private static readonly IntPtr NativeMethodInfoPtr_QueueEcho_Private_Void_Char_0;

		// Token: 0x040014EE RID: 5358
		private static readonly IntPtr NativeMethodInfoPtr_Echo_Private_Void_ConsoleKeyInfo_0;

		// Token: 0x040014EF RID: 5359
		private static readonly IntPtr NativeMethodInfoPtr_EchoFlush_Private_Void_0;

		// Token: 0x040014F0 RID: 5360
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Int32_Il2CppStructArray_1_Char_Int32_Int32_0;

		// Token: 0x040014F1 RID: 5361
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x040014F2 RID: 5362
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0;

		// Token: 0x040014F3 RID: 5363
		private static readonly IntPtr NativeMethodInfoPtr_ReadToEnd_Public_String_0;

		// Token: 0x040014F4 RID: 5364
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntilConditionInternal_Private_String_Boolean_0;

		// Token: 0x040014F5 RID: 5365
		private static readonly IntPtr NativeMethodInfoPtr_SetCursorPosition_Public_Virtual_Final_New_Void_Int32_Int32_0;

		// Token: 0x040014F6 RID: 5366
		private static readonly IntPtr NativeMethodInfoPtr_CreateKeyMap_Private_Void_0;

		// Token: 0x040014F7 RID: 5367
		private static readonly IntPtr NativeMethodInfoPtr_InitKeys_Private_Void_0;

		// Token: 0x040014F8 RID: 5368
		private static readonly IntPtr NativeMethodInfoPtr_AddStringMapping_Private_Void_TermInfoStrings_0;
	}
}
