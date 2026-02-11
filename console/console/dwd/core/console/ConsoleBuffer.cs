using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace dwd.core.console
{
	// Token: 0x02000010 RID: 16
	public sealed class ConsoleBuffer : MonoBehaviour
	{
		// Token: 0x060000CB RID: 203 RVA: 0x00004FA0 File Offset: 0x000031A0
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleBuffer()
		{
			Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("console.dll", "dwd.core.console", "ConsoleBuffer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr);
			ConsoleBuffer.NativeFieldInfoPtr_PrefName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "PrefName");
			ConsoleBuffer.NativeFieldInfoPtr_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "textField");
			ConsoleBuffer.NativeFieldInfoPtr_bufferFallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "bufferFallback");
			ConsoleBuffer.NativeFieldInfoPtr_currentIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "currentIndex");
			ConsoleBuffer.NativeFieldInfoPtr_userIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "userIndex");
			ConsoleBuffer.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663364);
			ConsoleBuffer.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663365);
			ConsoleBuffer.NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663366);
			ConsoleBuffer.NativeMethodInfoPtr_GetBuffer_Private_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663367);
			ConsoleBuffer.NativeMethodInfoPtr_GetBufferFallback_Private_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663368);
			ConsoleBuffer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, 100663369);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000050AC File Offset: 0x000032AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256020, XrefRangeEnd = 1256041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000050E0 File Offset: 0x000032E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256041, XrefRangeEnd = 1256054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005114 File Offset: 0x00003314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256054, XrefRangeEnd = 1256083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005148 File Offset: 0x00003348
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1256095, RefRangeEnd = 1256097, XrefRangeStart = 1256083, XrefRangeEnd = 1256095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IReadOnlyList<string> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr_GetBuffer_Private_IReadOnlyList_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005188 File Offset: 0x00003388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1256097, XrefRangeEnd = 1256101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStringArray GetBufferFallback()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr_GetBufferFallback_Private_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000051C8 File Offset: 0x000033C8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleBuffer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleBuffer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000027B6 File Offset: 0x000009B6
		public ConsoleBuffer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00005204 File Offset: 0x00003404
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x000027BF File Offset: 0x000009BF
		public unsafe static string PrefName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConsoleBuffer.NativeFieldInfoPtr_PrefName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConsoleBuffer.NativeFieldInfoPtr_PrefName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00005224 File Offset: 0x00003424
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000027D1 File Offset: 0x000009D1
		public unsafe InputField textField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_textField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00005254 File Offset: 0x00003454
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000027F0 File Offset: 0x000009F0
		public unsafe Il2CppStringArray bufferFallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_bufferFallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_bufferFallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00005284 File Offset: 0x00003484
		// (set) Token: 0x060000DA RID: 218 RVA: 0x0000280F File Offset: 0x00000A0F
		public unsafe int currentIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_currentIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_currentIndex)) = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000052AC File Offset: 0x000034AC
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000282A File Offset: 0x00000A2A
		public unsafe int userIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_userIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConsoleBuffer.NativeFieldInfoPtr_userIndex)) = value;
			}
		}

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_PrefName;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_textField;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_bufferFallback;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_currentIndex;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeFieldInfoPtr_userIndex;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_Event_OnSubmit_Public_Void_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Private_IReadOnlyList_1_String_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_GetBufferFallback_Private_Il2CppStringArray_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200001B RID: 27
		[ObfuscatedName("dwd.core.console.ConsoleBuffer+<>O")]
		public static class __O : global::Il2CppSystem.Object
		{
			// Token: 0x06000146 RID: 326 RVA: 0x00002BB9 File Offset: 0x00000DB9
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<ConsoleBuffer.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConsoleBuffer>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleBuffer.__O>.NativeClassPtr);
				ConsoleBuffer.__O.NativeFieldInfoPtr__0___IsNullOrEmpty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleBuffer.__O>.NativeClassPtr, "<0>__IsNullOrEmpty");
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00002BED File Offset: 0x00000DED
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000148 RID: 328 RVA: 0x0000645C File Offset: 0x0000465C
			// (set) Token: 0x06000149 RID: 329 RVA: 0x00002BF6 File Offset: 0x00000DF6
			public unsafe static Predicate<string> _0___IsNullOrEmpty
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ConsoleBuffer.__O.NativeFieldInfoPtr__0___IsNullOrEmpty, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ConsoleBuffer.__O.NativeFieldInfoPtr__0___IsNullOrEmpty, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000B7 RID: 183
			private static readonly IntPtr NativeFieldInfoPtr__0___IsNullOrEmpty;
		}
	}
}
