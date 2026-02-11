using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace dwd.core.cheats
{
	// Token: 0x02000013 RID: 19
	public class ClearConsole : MonoBehaviour
	{
		// Token: 0x060000F2 RID: 242 RVA: 0x00005680 File Offset: 0x00003880
		// Note: this type is marked as 'beforefieldinit'.
		static ClearConsole()
		{
			Il2CppClassPointerStore<ClearConsole>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.cheats", "ClearConsole");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr);
			ClearConsole.NativeFieldInfoPtr_consoleLogHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr, "consoleLogHistory");
			ClearConsole.NativeFieldInfoPtr_copyLog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr, "copyLog");
			ClearConsole.NativeMethodInfoPtr_get_ConsoleLogHistory_Public_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr, 100663377);
			ClearConsole.NativeMethodInfoPtr_get_CopyLog_Public_get_CopyLogsToClipboard_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr, 100663378);
			ClearConsole.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr, 100663379);
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00005714 File Offset: 0x00003914
		public unsafe Transform ConsoleLogHistory
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearConsole.NativeMethodInfoPtr_get_ConsoleLogHistory_Public_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr3) : null;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00005754 File Offset: 0x00003954
		public unsafe CopyLogsToClipboard CopyLog
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearConsole.NativeMethodInfoPtr_get_CopyLog_Public_get_CopyLogsToClipboard_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CopyLogsToClipboard>(intPtr3) : null;
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00005794 File Offset: 0x00003994
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearConsole()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearConsole>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearConsole.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000028EA File Offset: 0x00000AEA
		public ClearConsole(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000028F3 File Offset: 0x00000AF3
		public unsafe Transform consoleLogHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearConsole.NativeFieldInfoPtr_consoleLogHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearConsole.NativeFieldInfoPtr_consoleLogHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00005800 File Offset: 0x00003A00
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002912 File Offset: 0x00000B12
		public unsafe CopyLogsToClipboard copyLog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearConsole.NativeFieldInfoPtr_copyLog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyLogsToClipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearConsole.NativeFieldInfoPtr_copyLog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeFieldInfoPtr_consoleLogHistory;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeFieldInfoPtr_copyLog;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsoleLogHistory_Public_get_Transform_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_get_CopyLog_Public_get_CopyLogsToClipboard_0;

		// Token: 0x0400008F RID: 143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
