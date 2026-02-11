using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200017E RID: 382
	public class WindowsConsoleDriver : Object
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x0009CE78 File Offset: 0x0009B078
		// Note: this type is marked as 'beforefieldinit'.
		static WindowsConsoleDriver()
		{
			Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "WindowsConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr);
			WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "inputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "outputHandle");
			WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, "defaultAttribute");
			WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667655);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667656);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667657);
			WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667658);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667659);
			WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667660);
			WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr, 100667661);
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x0009CF70 File Offset: 0x0009B170
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350067, RefRangeEnd = 1350068, XrefRangeStart = 1350061, XrefRangeEnd = 1350067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WindowsConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WindowsConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x0009CFAC File Offset: 0x0009B1AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350068, XrefRangeEnd = 1350075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x0009CFE4 File Offset: 0x0009B1E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1350079, RefRangeEnd = 1350080, XrefRangeStart = 1350075, XrefRangeEnd = 1350079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x0009D030 File Offset: 0x0009B230
		[CallerCount(0)]
		public unsafe static bool IsModifierKey(short virtualKeyCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref virtualKeyCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194C RID: 6476 RVA: 0x0009D070 File Offset: 0x0009B270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1350083, RefRangeEnd = 1350085, XrefRangeStart = 1350080, XrefRangeEnd = 1350083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr GetStdHandle(Handles handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600194D RID: 6477 RVA: 0x0009D0B0 File Offset: 0x0009B2B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350085, XrefRangeEnd = 1350088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetConsoleScreenBufferInfo(IntPtr handle, out ConsoleScreenBufferInfo info)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &info;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x0009D0FC File Offset: 0x0009B2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1350088, XrefRangeEnd = 1350091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ReadConsoleInput(IntPtr handle, out InputRecord record, int length, out int nread)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &record;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &nread;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WindowsConsoleDriver.NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00008223 File Offset: 0x00006423
		public WindowsConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x0009D164 File Offset: 0x0009B364
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x0000822C File Offset: 0x0000642C
		public unsafe IntPtr inputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_inputHandle)) = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x0009D18C File Offset: 0x0009B38C
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x00008247 File Offset: 0x00006447
		public unsafe IntPtr outputHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_outputHandle)) = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x0009D1B4 File Offset: 0x0009B3B4
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x00008262 File Offset: 0x00006462
		public unsafe short defaultAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WindowsConsoleDriver.NativeFieldInfoPtr_defaultAttribute)) = value;
			}
		}

		// Token: 0x04001775 RID: 6005
		private static readonly IntPtr NativeFieldInfoPtr_inputHandle;

		// Token: 0x04001776 RID: 6006
		private static readonly IntPtr NativeFieldInfoPtr_outputHandle;

		// Token: 0x04001777 RID: 6007
		private static readonly IntPtr NativeFieldInfoPtr_defaultAttribute;

		// Token: 0x04001778 RID: 6008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001779 RID: 6009
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0;

		// Token: 0x0400177A RID: 6010
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x0400177B RID: 6011
		private static readonly IntPtr NativeMethodInfoPtr_IsModifierKey_Private_Static_Boolean_Int16_0;

		// Token: 0x0400177C RID: 6012
		private static readonly IntPtr NativeMethodInfoPtr_GetStdHandle_Private_Static_IntPtr_Handles_0;

		// Token: 0x0400177D RID: 6013
		private static readonly IntPtr NativeMethodInfoPtr_GetConsoleScreenBufferInfo_Private_Static_Boolean_IntPtr_byref_ConsoleScreenBufferInfo_0;

		// Token: 0x0400177E RID: 6014
		private static readonly IntPtr NativeMethodInfoPtr_ReadConsoleInput_Private_Static_Boolean_IntPtr_byref_InputRecord_Int32_byref_Int32_0;
	}
}
