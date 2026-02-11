using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x02000035 RID: 53
	[StructLayout(2)]
	public struct FontStyleStack
	{
		// Token: 0x06000590 RID: 1424 RVA: 0x00017ABC File Offset: 0x00015CBC
		// Note: this type is marked as 'beforefieldinit'.
		static FontStyleStack()
		{
			Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreTextEngineModule.dll", "UnityEngine.TextCore.Text", "FontStyleStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr);
			FontStyleStack.NativeFieldInfoPtr_bold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "bold");
			FontStyleStack.NativeFieldInfoPtr_italic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "italic");
			FontStyleStack.NativeFieldInfoPtr_underline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "underline");
			FontStyleStack.NativeFieldInfoPtr_strikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "strikethrough");
			FontStyleStack.NativeFieldInfoPtr_highlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "highlight");
			FontStyleStack.NativeFieldInfoPtr_superscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "superscript");
			FontStyleStack.NativeFieldInfoPtr_subscript = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "subscript");
			FontStyleStack.NativeFieldInfoPtr_uppercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "uppercase");
			FontStyleStack.NativeFieldInfoPtr_lowercase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "lowercase");
			FontStyleStack.NativeFieldInfoPtr_smallcaps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, "smallcaps");
			FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100663682);
			FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100663683);
			FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, 100663684);
		}

		// Token: 0x06000591 RID: 1425 RVA: 0x00017BF0 File Offset: 0x00015DF0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1049645, RefRangeEnd = 1049651, XrefRangeStart = 1049645, XrefRangeEnd = 1049651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontStyleStack.NativeMethodInfoPtr_Clear_Public_Void_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00017C18 File Offset: 0x00015E18
		[CallerCount(0)]
		public unsafe byte Add(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontStyleStack.NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00017C58 File Offset: 0x00015E58
		[CallerCount(0)]
		public unsafe byte Remove(FontStyles style)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref style;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FontStyleStack.NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x000057D9 File Offset: 0x000039D9
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FontStyleStack>.NativeClassPtr, ref this));
		}

		// Token: 0x040004CF RID: 1231
		private static readonly IntPtr NativeFieldInfoPtr_bold;

		// Token: 0x040004D0 RID: 1232
		private static readonly IntPtr NativeFieldInfoPtr_italic;

		// Token: 0x040004D1 RID: 1233
		private static readonly IntPtr NativeFieldInfoPtr_underline;

		// Token: 0x040004D2 RID: 1234
		private static readonly IntPtr NativeFieldInfoPtr_strikethrough;

		// Token: 0x040004D3 RID: 1235
		private static readonly IntPtr NativeFieldInfoPtr_highlight;

		// Token: 0x040004D4 RID: 1236
		private static readonly IntPtr NativeFieldInfoPtr_superscript;

		// Token: 0x040004D5 RID: 1237
		private static readonly IntPtr NativeFieldInfoPtr_subscript;

		// Token: 0x040004D6 RID: 1238
		private static readonly IntPtr NativeFieldInfoPtr_uppercase;

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_lowercase;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_smallcaps;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Byte_FontStyles_0;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Byte_FontStyles_0;

		// Token: 0x040004DC RID: 1244
		[FieldOffset(0)]
		public byte bold;

		// Token: 0x040004DD RID: 1245
		[FieldOffset(1)]
		public byte italic;

		// Token: 0x040004DE RID: 1246
		[FieldOffset(2)]
		public byte underline;

		// Token: 0x040004DF RID: 1247
		[FieldOffset(3)]
		public byte strikethrough;

		// Token: 0x040004E0 RID: 1248
		[FieldOffset(4)]
		public byte highlight;

		// Token: 0x040004E1 RID: 1249
		[FieldOffset(5)]
		public byte superscript;

		// Token: 0x040004E2 RID: 1250
		[FieldOffset(6)]
		public byte subscript;

		// Token: 0x040004E3 RID: 1251
		[FieldOffset(7)]
		public byte uppercase;

		// Token: 0x040004E4 RID: 1252
		[FieldOffset(8)]
		public byte lowercase;

		// Token: 0x040004E5 RID: 1253
		[FieldOffset(9)]
		public byte smallcaps;
	}
}
