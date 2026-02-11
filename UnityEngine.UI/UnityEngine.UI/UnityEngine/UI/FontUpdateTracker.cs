using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000011 RID: 17
	public static class FontUpdateTracker : Object
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0000C180 File Offset: 0x0000A380
		// Note: this type is marked as 'beforefieldinit'.
		static FontUpdateTracker()
		{
			Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "FontUpdateTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr);
			FontUpdateTracker.NativeFieldInfoPtr_m_Tracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, "m_Tracked");
			FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663519);
			FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663520);
			FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, 100663521);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000C200 File Offset: 0x0000A400
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083538, RefRangeEnd = 1083540, XrefRangeStart = 1083491, XrefRangeEnd = 1083538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000C238 File Offset: 0x0000A438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1083540, XrefRangeEnd = 1083562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RebuildForFont(Font f)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(f);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000C270 File Offset: 0x0000A470
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1083602, RefRangeEnd = 1083604, XrefRangeStart = 1083562, XrefRangeEnd = 1083602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UntrackText(Text t)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontUpdateTracker.NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002755 File Offset: 0x00000955
		public FontUpdateTracker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000275E File Offset: 0x0000095E
		public unsafe static Dictionary<Font, HashSet<Text>> m_Tracked
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Font, HashSet<Text>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FontUpdateTracker.NativeFieldInfoPtr_m_Tracked, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000104 RID: 260
		private static readonly IntPtr NativeFieldInfoPtr_m_Tracked;

		// Token: 0x04000105 RID: 261
		private static readonly IntPtr NativeMethodInfoPtr_TrackText_Public_Static_Void_Text_0;

		// Token: 0x04000106 RID: 262
		private static readonly IntPtr NativeMethodInfoPtr_RebuildForFont_Private_Static_Void_Font_0;

		// Token: 0x04000107 RID: 263
		private static readonly IntPtr NativeMethodInfoPtr_UntrackText_Public_Static_Void_Text_0;

		// Token: 0x02000085 RID: 133
		[ObfuscatedName("UnityEngine.UI.FontUpdateTracker+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000C37 RID: 3127 RVA: 0x000067DC File Offset: 0x000049DC
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<FontUpdateTracker.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FontUpdateTracker>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontUpdateTracker.__O>.NativeClassPtr);
				FontUpdateTracker.__O.NativeFieldInfoPtr__0___RebuildForFont = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontUpdateTracker.__O>.NativeClassPtr, "<0>__RebuildForFont");
			}

			// Token: 0x06000C38 RID: 3128 RVA: 0x00006810 File Offset: 0x00004A10
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06000C39 RID: 3129 RVA: 0x00035B90 File Offset: 0x00033D90
			// (set) Token: 0x06000C3A RID: 3130 RVA: 0x00006819 File Offset: 0x00004A19
			public unsafe static Action<Font> _0___RebuildForFont
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FontUpdateTracker.__O.NativeFieldInfoPtr__0___RebuildForFont, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Font>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FontUpdateTracker.__O.NativeFieldInfoPtr__0___RebuildForFont, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000922 RID: 2338
			private static readonly IntPtr NativeFieldInfoPtr__0___RebuildForFont;
		}
	}
}
