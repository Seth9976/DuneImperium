using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.util
{
	// Token: 0x0200000A RID: 10
	public class LogToTMPText : MonoBehaviour
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00003C74 File Offset: 0x00001E74
		// Note: this type is marked as 'beforefieldinit'.
		static LogToTMPText()
		{
			Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.util", "LogToTMPText");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr);
			LogToTMPText.NativeFieldInfoPtr_template = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "template");
			LogToTMPText.NativeFieldInfoPtr_maxInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "maxInstances");
			LogToTMPText.NativeFieldInfoPtr_logQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "logQueue");
			LogToTMPText.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "scrollRect");
			LogToTMPText.NativeFieldInfoPtr_scrollToBottom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "scrollToBottom");
			LogToTMPText.NativeFieldInfoPtr_logLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "logLevels");
			LogToTMPText.NativeFieldInfoPtr_stackTraceLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "stackTraceLevels");
			LogToTMPText.NativeFieldInfoPtr_sb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "sb");
			LogToTMPText.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663320);
			LogToTMPText.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663321);
			LogToTMPText.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663322);
			LogToTMPText.NativeMethodInfoPtr_SetLogLevels_Public_Void_Il2CppStructArray_1_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663323);
			LogToTMPText.NativeMethodInfoPtr_SetStackTraceLevels_Public_Void_Il2CppStructArray_1_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663324);
			LogToTMPText.NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663325);
			LogToTMPText.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663326);
			LogToTMPText.NativeMethodInfoPtr_CopyToClipboard_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663327);
			LogToTMPText.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, 100663328);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003DF8 File Offset: 0x00001FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255605, XrefRangeEnd = 1255659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00003E2C File Offset: 0x0000202C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 483004, RefRangeEnd = 483006, XrefRangeStart = 483004, XrefRangeEnd = 483006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003E60 File Offset: 0x00002060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255659, XrefRangeEnd = 1255669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003E94 File Offset: 0x00002094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetLogLevels(Il2CppStructArray<LogType> newLevels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newLevels);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_SetLogLevels_Public_Void_Il2CppStructArray_1_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00003ED8 File Offset: 0x000020D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetStackTraceLevels(Il2CppStructArray<LogType> newLevels)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newLevels);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_SetStackTraceLevels_Public_Void_Il2CppStructArray_1_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003F1C File Offset: 0x0000211C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255669, XrefRangeEnd = 1255675, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleLog(string message, string stackTrace, LogType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stackTrace);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003F80 File Offset: 0x00002180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255675, XrefRangeEnd = 1255732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003FB4 File Offset: 0x000021B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255732, XrefRangeEnd = 1255747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyToClipboard()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr_CopyToClipboard_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003FE8 File Offset: 0x000021E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1255747, XrefRangeEnd = 1255753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogToTMPText()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000023F7 File Offset: 0x000005F7
		public LogToTMPText(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004024 File Offset: 0x00002224
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002400 File Offset: 0x00000600
		public unsafe TMP_Text template
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_template);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_template), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004054 File Offset: 0x00002254
		// (set) Token: 0x0600006E RID: 110 RVA: 0x0000241F File Offset: 0x0000061F
		public unsafe int maxInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_maxInstances);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_maxInstances)) = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600006F RID: 111 RVA: 0x0000407C File Offset: 0x0000227C
		// (set) Token: 0x06000070 RID: 112 RVA: 0x0000243A File Offset: 0x0000063A
		public unsafe ConcurrentQueue<ValueTuple<string, string, LogType>> logQueue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_logQueue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentQueue<ValueTuple<string, string, LogType>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_logQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000040AC File Offset: 0x000022AC
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00002459 File Offset: 0x00000659
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000040DC File Offset: 0x000022DC
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00002478 File Offset: 0x00000678
		public unsafe bool scrollToBottom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_scrollToBottom);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_scrollToBottom)) = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004104 File Offset: 0x00002304
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002493 File Offset: 0x00000693
		public unsafe Il2CppStructArray<LogType> logLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_logLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LogType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_logLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00004134 File Offset: 0x00002334
		// (set) Token: 0x06000078 RID: 120 RVA: 0x000024B2 File Offset: 0x000006B2
		public unsafe Il2CppStructArray<LogType> stackTraceLevels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_stackTraceLevels);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<LogType>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_stackTraceLevels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00004164 File Offset: 0x00002364
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000024D1 File Offset: 0x000006D1
		public unsafe StringBuilder sb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_sb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LogToTMPText.NativeFieldInfoPtr_sb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeFieldInfoPtr_template;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeFieldInfoPtr_maxInstances;

		// Token: 0x04000036 RID: 54
		private static readonly IntPtr NativeFieldInfoPtr_logQueue;

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeFieldInfoPtr_scrollToBottom;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_logLevels;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeFieldInfoPtr_stackTraceLevels;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_sb;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_SetLogLevels_Public_Void_Il2CppStructArray_1_LogType_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_SetStackTraceLevels_Public_Void_Il2CppStructArray_1_LogType_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_handleLog_Private_Void_String_String_LogType_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_CopyToClipboard_Public_Void_0;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000018 RID: 24
		[ObfuscatedName("dwd.core.util.LogToTMPText+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x06000128 RID: 296 RVA: 0x00005ECC File Offset: 0x000040CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LogToTMPText>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr);
				LogToTMPText.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr, "<>9");
				LogToTMPText.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr, "<>9__8_0");
				LogToTMPText.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr, 100663330);
				LogToTMPText.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_Boolean_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr, 100663331);
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00005F48 File Offset: 0x00004148
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LogToTMPText.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00005F84 File Offset: 0x00004184
			[CallerCount(0)]
			public unsafe bool _Awake_b__8_0(LogType type)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref type;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LogToTMPText.__c.NativeMethodInfoPtr__Awake_b__8_0_Internal_Boolean_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600012B RID: 299 RVA: 0x00002AE3 File Offset: 0x00000CE3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x0600012C RID: 300 RVA: 0x00005FD0 File Offset: 0x000041D0
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00002AEC File Offset: 0x00000CEC
			public unsafe static LogToTMPText.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LogToTMPText.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogToTMPText.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LogToTMPText.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x0600012E RID: 302 RVA: 0x00005FF8 File Offset: 0x000041F8
			// (set) Token: 0x0600012F RID: 303 RVA: 0x00002AFE File Offset: 0x00000CFE
			public unsafe static Func<LogType, bool> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LogToTMPText.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<LogType, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LogToTMPText.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000A6 RID: 166
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000A7 RID: 167
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040000A8 RID: 168
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000A9 RID: 169
			private static readonly IntPtr NativeMethodInfoPtr__Awake_b__8_0_Internal_Boolean_LogType_0;
		}
	}
}
