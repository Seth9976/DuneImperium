using System;
using dwd.core.util;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using UnityEngine;

namespace dwd.core.cheats
{
	// Token: 0x02000014 RID: 20
	public class CopyLogsToClipboard : MonoBehaviour
	{
		// Token: 0x060000FB RID: 251 RVA: 0x00005830 File Offset: 0x00003A30
		// Note: this type is marked as 'beforefieldinit'.
		static CopyLogsToClipboard()
		{
			Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.cheats", "CopyLogsToClipboard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr);
			CopyLogsToClipboard.NativeFieldInfoPtr_historyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "historyCount");
			CopyLogsToClipboard.NativeFieldInfoPtr_errorsOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "errorsOnly");
			CopyLogsToClipboard.NativeFieldInfoPtr_logs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "logs");
			CopyLogsToClipboard.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "stringBuilder");
			CopyLogsToClipboard.NativeFieldInfoPtr_copier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "copier");
			CopyLogsToClipboard.NativeFieldInfoPtr_dispatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "dispatcher");
			CopyLogsToClipboard.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663380);
			CopyLogsToClipboard.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663381);
			CopyLogsToClipboard.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663382);
			CopyLogsToClipboard.NativeMethodInfoPtr_Copy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663383);
			CopyLogsToClipboard.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663384);
			CopyLogsToClipboard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, 100663385);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00005950 File Offset: 0x00003B50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256208, XrefRangeEnd = 1256226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00005984 File Offset: 0x00003B84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256226, XrefRangeEnd = 1256237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000059B8 File Offset: 0x00003BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256237, XrefRangeEnd = 1256256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00005A1C File Offset: 0x00003C1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256256, XrefRangeEnd = 1256283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Copy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr_Copy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005A50 File Offset: 0x00003C50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256283, XrefRangeEnd = 1256290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00005A84 File Offset: 0x00003C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256290, XrefRangeEnd = 1256303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CopyLogsToClipboard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002931 File Offset: 0x00000B31
		public CopyLogsToClipboard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00005AC0 File Offset: 0x00003CC0
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000293A File Offset: 0x00000B3A
		public unsafe int historyCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_historyCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_historyCount)) = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00005AE8 File Offset: 0x00003CE8
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002955 File Offset: 0x00000B55
		public unsafe bool errorsOnly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_errorsOnly);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_errorsOnly)) = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00005B10 File Offset: 0x00003D10
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002970 File Offset: 0x00000B70
		public unsafe Queue<string> logs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_logs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_logs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00005B40 File Offset: 0x00003D40
		// (set) Token: 0x0600010A RID: 266 RVA: 0x0000298F File Offset: 0x00000B8F
		public unsafe StringBuilder stringBuilder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_stringBuilder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00005B70 File Offset: 0x00003D70
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000029AE File Offset: 0x00000BAE
		public unsafe CopyToClipboard copier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_copier);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyToClipboard>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_copier), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00005BA0 File Offset: 0x00003DA0
		// (set) Token: 0x0600010E RID: 270 RVA: 0x000029CD File Offset: 0x00000BCD
		public unsafe LogDispatcher dispatcher
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_dispatcher);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LogDispatcher>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CopyLogsToClipboard.NativeFieldInfoPtr_dispatcher), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000090 RID: 144
		private static readonly IntPtr NativeFieldInfoPtr_historyCount;

		// Token: 0x04000091 RID: 145
		private static readonly IntPtr NativeFieldInfoPtr_errorsOnly;

		// Token: 0x04000092 RID: 146
		private static readonly IntPtr NativeFieldInfoPtr_logs;

		// Token: 0x04000093 RID: 147
		private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeFieldInfoPtr_copier;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeFieldInfoPtr_dispatcher;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04000097 RID: 151
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr_HandleLog_Public_Void_String_String_LogType_0;

		// Token: 0x04000099 RID: 153
		private static readonly IntPtr NativeMethodInfoPtr_Copy_Public_Void_0;

		// Token: 0x0400009A RID: 154
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400009B RID: 155
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001C RID: 28
		[ObfuscatedName("dwd.core.cheats.CopyLogsToClipboard+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600014A RID: 330 RVA: 0x00006484 File Offset: 0x00004684
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CopyLogsToClipboard>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr);
				CopyLogsToClipboard.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr, "<>9");
				CopyLogsToClipboard.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr, "<>9__9_0");
				CopyLogsToClipboard.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr, 100663387);
				CopyLogsToClipboard.__c.NativeMethodInfoPtr__Copy_b__9_0_Internal_StringBuilder_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr, 100663388);
			}

			// Token: 0x0600014B RID: 331 RVA: 0x00006500 File Offset: 0x00004700
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CopyLogsToClipboard.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600014C RID: 332 RVA: 0x0000653C File Offset: 0x0000473C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256206, XrefRangeEnd = 1256208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringBuilder _Copy_b__9_0(StringBuilder log, string entry)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(log);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CopyLogsToClipboard.__c.NativeMethodInfoPtr__Copy_b__9_0_Internal_StringBuilder_StringBuilder_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}

			// Token: 0x0600014D RID: 333 RVA: 0x00002C08 File Offset: 0x00000E08
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x0600014E RID: 334 RVA: 0x000065A0 File Offset: 0x000047A0
			// (set) Token: 0x0600014F RID: 335 RVA: 0x00002C11 File Offset: 0x00000E11
			public unsafe static CopyLogsToClipboard.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyLogsToClipboard.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CopyLogsToClipboard.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyLogsToClipboard.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000150 RID: 336 RVA: 0x000065C8 File Offset: 0x000047C8
			// (set) Token: 0x06000151 RID: 337 RVA: 0x00002C23 File Offset: 0x00000E23
			public unsafe static Func<StringBuilder, string, StringBuilder> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CopyLogsToClipboard.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<StringBuilder, string, StringBuilder>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CopyLogsToClipboard.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B8 RID: 184
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040000B9 RID: 185
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040000BA RID: 186
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040000BB RID: 187
			private static readonly IntPtr NativeMethodInfoPtr__Copy_b__9_0_Internal_StringBuilder_StringBuilder_String_0;
		}
	}
}
