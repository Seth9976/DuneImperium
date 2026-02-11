using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.util
{
	// Token: 0x02000009 RID: 9
	public class LogToText : MonoBehaviour
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000036FC File Offset: 0x000018FC
		// Note: this type is marked as 'beforefieldinit'.
		static LogToText()
		{
			Il2CppClassPointerStore<LogToText>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.util", "LogToText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogToText>.NativeClassPtr);
			LogToText.NativeFieldInfoPtr_MaxLogLength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "MaxLogLength");
			LogToText.NativeFieldInfoPtr_Bar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "Bar");
			LogToText.NativeFieldInfoPtr_MaxInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "MaxInstances");
			LogToText.NativeFieldInfoPtr_TextPrototype = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "TextPrototype");
			LogToText.NativeFieldInfoPtr_rt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "rt");
			LogToText.NativeFieldInfoPtr_scrollRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "scrollRectTransform");
			LogToText.NativeFieldInfoPtr_fullStackLogsAndWarnings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "fullStackLogsAndWarnings");
			LogToText.NativeFieldInfoPtr_scrollToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "scrollToBottom");
			LogToText.NativeFieldInfoPtr_reportedY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "reportedY");
			LogToText.NativeFieldInfoPtr_logStringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "logStringBuilder");
			LogToText.NativeFieldInfoPtr_corners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "corners");
			LogToText.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToText>.NativeClassPtr, "dispatcher");
			LogToText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663313);
			LogToText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663314);
			LogToText.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663315);
			LogToText.NativeMethodInfoPtr_colorText_Private_Static_Void_LogType_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663316);
			LogToText.NativeMethodInfoPtr_shouldLogType_Private_Static_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663317);
			LogToText.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663318);
			LogToText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToText>.NativeClassPtr, 100663319);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000038A8 File Offset: 0x00001AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255500, XrefRangeEnd = 1255522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000038DC File Offset: 0x00001ADC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255522, XrefRangeEnd = 1255534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003910 File Offset: 0x00001B10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255534, XrefRangeEnd = 1255582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleLog(string logString, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(logString);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003974 File Offset: 0x00001B74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255582, XrefRangeEnd = 1255584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void colorText(LogType type, Text newText)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_colorText_Private_Static_Void_LogType_Text_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000039B8 File Offset: 0x00001BB8
		[CallerCount(0)]
		public unsafe static bool shouldLogType(LogType type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_shouldLogType_Private_Static_Boolean_LogType_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000039F8 File Offset: 0x00001BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255584, XrefRangeEnd = 1255595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003A2C File Offset: 0x00001C2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255595, XrefRangeEnd = 1255605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogToText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogToText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000229B File Offset: 0x0000049B
		public LogToText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00003A68 File Offset: 0x00001C68
		// (set) Token: 0x06000049 RID: 73 RVA: 0x000022A4 File Offset: 0x000004A4
		public unsafe static int MaxLogLength
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LogToText.NativeFieldInfoPtr_MaxLogLength, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LogToText.NativeFieldInfoPtr_MaxLogLength, (void*)(&value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003A84 File Offset: 0x00001C84
		// (set) Token: 0x0600004B RID: 75 RVA: 0x000022B2 File Offset: 0x000004B2
		public unsafe Scrollbar Bar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_Bar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Scrollbar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_Bar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003AB4 File Offset: 0x00001CB4
		// (set) Token: 0x0600004D RID: 77 RVA: 0x000022D1 File Offset: 0x000004D1
		public unsafe int MaxInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_MaxInstances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_MaxInstances)) = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003ADC File Offset: 0x00001CDC
		// (set) Token: 0x0600004F RID: 79 RVA: 0x000022EC File Offset: 0x000004EC
		public unsafe Text TextPrototype
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_TextPrototype);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_TextPrototype), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00003B0C File Offset: 0x00001D0C
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000230B File Offset: 0x0000050B
		public unsafe RectTransform rt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_rt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_rt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00003B3C File Offset: 0x00001D3C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0000232A File Offset: 0x0000052A
		public unsafe RectTransform scrollRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_scrollRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_scrollRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003B6C File Offset: 0x00001D6C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002349 File Offset: 0x00000549
		public unsafe bool fullStackLogsAndWarnings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_fullStackLogsAndWarnings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_fullStackLogsAndWarnings)) = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003B94 File Offset: 0x00001D94
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002364 File Offset: 0x00000564
		public unsafe int scrollToBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_scrollToBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_scrollToBottom)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00003BBC File Offset: 0x00001DBC
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0000237F File Offset: 0x0000057F
		public unsafe float reportedY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_reportedY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_reportedY)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00003BE4 File Offset: 0x00001DE4
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0000239A File Offset: 0x0000059A
		public unsafe StringBuilder logStringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_logStringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_logStringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00003C14 File Offset: 0x00001E14
		// (set) Token: 0x0600005D RID: 93 RVA: 0x000023B9 File Offset: 0x000005B9
		public unsafe Il2CppStructArray<Vector3> corners
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_corners);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_corners), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00003C44 File Offset: 0x00001E44
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000023D8 File Offset: 0x000005D8
		public unsafe LogDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToText.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeFieldInfoPtr_MaxLogLength;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeFieldInfoPtr_Bar;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeFieldInfoPtr_MaxInstances;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeFieldInfoPtr_TextPrototype;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeFieldInfoPtr_rt;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeFieldInfoPtr_scrollRectTransform;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeFieldInfoPtr_fullStackLogsAndWarnings;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeFieldInfoPtr_scrollToBottom;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeFieldInfoPtr_reportedY;

		// Token: 0x0400002A RID: 42
		private static readonly IntPtr NativeFieldInfoPtr_logStringBuilder;

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_corners;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0;

		// Token: 0x04000030 RID: 48
		private static readonly IntPtr NativeMethodInfoPtr_colorText_Private_Static_Void_LogType_Text_0;

		// Token: 0x04000031 RID: 49
		private static readonly IntPtr NativeMethodInfoPtr_shouldLogType_Private_Static_Boolean_LogType_0;

		// Token: 0x04000032 RID: 50
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000033 RID: 51
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
