using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200015E RID: 350
	public class NullConsoleDriver : Object
	{
		// Token: 0x060017B5 RID: 6069 RVA: 0x00096B9C File Offset: 0x00094D9C
		// Note: this type is marked as 'beforefieldinit'.
		static NullConsoleDriver()
		{
			Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "NullConsoleDriver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr);
			NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, "EmptyConsoleKeyInfo");
			NullConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100667436);
			NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100667437);
			NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr, 100667438);
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x00096C1C File Offset: 0x00094E1C
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ReadLine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x00096C54 File Offset: 0x00094E54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1347118, XrefRangeEnd = 1347122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ConsoleKeyInfo ReadKey(bool intercept)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intercept;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00096CA0 File Offset: 0x00094EA0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NullConsoleDriver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NullConsoleDriver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NullConsoleDriver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x00007842 File Offset: 0x00005A42
		public NullConsoleDriver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060017BA RID: 6074 RVA: 0x00096CDC File Offset: 0x00094EDC
		// (set) Token: 0x060017BB RID: 6075 RVA: 0x0000784B File Offset: 0x00005A4B
		public unsafe static ConsoleKeyInfo EmptyConsoleKeyInfo
		{
			get
			{
				ConsoleKeyInfo consoleKeyInfo;
				IL2CPP.il2cpp_field_static_get_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&consoleKeyInfo));
				return consoleKeyInfo;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NullConsoleDriver.NativeFieldInfoPtr_EmptyConsoleKeyInfo, (void*)(&value));
			}
		}

		// Token: 0x04001455 RID: 5205
		private static readonly IntPtr NativeFieldInfoPtr_EmptyConsoleKeyInfo;

		// Token: 0x04001456 RID: 5206
		private static readonly IntPtr NativeMethodInfoPtr_ReadLine_Public_Virtual_Final_New_String_0;

		// Token: 0x04001457 RID: 5207
		private static readonly IntPtr NativeMethodInfoPtr_ReadKey_Public_Virtual_Final_New_ConsoleKeyInfo_Boolean_0;

		// Token: 0x04001458 RID: 5208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
