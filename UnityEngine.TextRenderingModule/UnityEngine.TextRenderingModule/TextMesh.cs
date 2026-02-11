using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x02000010 RID: 16
	public sealed class TextMesh : Component
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000589C File Offset: 0x00003A9C
		// (set) Token: 0x060000DB RID: 219 RVA: 0x000025AF File Offset: 0x000007AF
		public string text
		{
			get
			{
				IntPtr intPtr = TextMesh.get_textDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				TextMesh.set_textDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000DC RID: 220 RVA: 0x000058C0 File Offset: 0x00003AC0
		// (set) Token: 0x060000DD RID: 221 RVA: 0x000025C7 File Offset: 0x000007C7
		public Font font
		{
			get
			{
				IntPtr intPtr = TextMesh.get_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Font>(intPtr2) : null;
			}
			set
			{
				TextMesh.set_fontDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000025DF File Offset: 0x000007DF
		// (set) Token: 0x060000DF RID: 223 RVA: 0x000025F1 File Offset: 0x000007F1
		public int fontSize
		{
			get
			{
				return TextMesh.get_fontSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_fontSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002604 File Offset: 0x00000804
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002616 File Offset: 0x00000816
		public FontStyle fontStyle
		{
			get
			{
				return TextMesh.get_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_fontStyleDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x00002629 File Offset: 0x00000829
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000263B File Offset: 0x0000083B
		public float offsetZ
		{
			get
			{
				return TextMesh.get_offsetZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_offsetZDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000264E File Offset: 0x0000084E
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x00002660 File Offset: 0x00000860
		public TextAlignment alignment
		{
			get
			{
				return TextMesh.get_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_alignmentDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x00002673 File Offset: 0x00000873
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x00002685 File Offset: 0x00000885
		public TextAnchor anchor
		{
			get
			{
				return TextMesh.get_anchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_anchorDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00002698 File Offset: 0x00000898
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x000026AA File Offset: 0x000008AA
		public float characterSize
		{
			get
			{
				return TextMesh.get_characterSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_characterSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000EA RID: 234 RVA: 0x000026BD File Offset: 0x000008BD
		// (set) Token: 0x060000EB RID: 235 RVA: 0x000026CF File Offset: 0x000008CF
		public float lineSpacing
		{
			get
			{
				return TextMesh.get_lineSpacingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_lineSpacingDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000026E2 File Offset: 0x000008E2
		// (set) Token: 0x060000ED RID: 237 RVA: 0x000026F4 File Offset: 0x000008F4
		public float tabSize
		{
			get
			{
				return TextMesh.get_tabSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_tabSizeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002707 File Offset: 0x00000907
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002719 File Offset: 0x00000919
		public bool richText
		{
			get
			{
				return TextMesh.get_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				TextMesh.set_richTextDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x000058EC File Offset: 0x00003AEC
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000272C File Offset: 0x0000092C
		public Color color
		{
			get
			{
				Color color;
				this.get_color_Injected(out color);
				return color;
			}
			set
			{
				this.set_color_Injected(ref value);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002736 File Offset: 0x00000936
		public void get_color_Injected(out Color ret)
		{
			TextMesh.get_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002749 File Offset: 0x00000949
		public void set_color_Injected(ref Color value)
		{
			TextMesh.set_color_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x040000B7 RID: 183
		private static readonly TextMesh.get_textDelegate get_textDelegateField = IL2CPP.ResolveICall<TextMesh.get_textDelegate>("UnityEngine.TextMesh::get_text");

		// Token: 0x040000B8 RID: 184
		private static readonly TextMesh.set_textDelegate set_textDelegateField = IL2CPP.ResolveICall<TextMesh.set_textDelegate>("UnityEngine.TextMesh::set_text");

		// Token: 0x040000B9 RID: 185
		private static readonly TextMesh.get_fontDelegate get_fontDelegateField = IL2CPP.ResolveICall<TextMesh.get_fontDelegate>("UnityEngine.TextMesh::get_font");

		// Token: 0x040000BA RID: 186
		private static readonly TextMesh.set_fontDelegate set_fontDelegateField = IL2CPP.ResolveICall<TextMesh.set_fontDelegate>("UnityEngine.TextMesh::set_font");

		// Token: 0x040000BB RID: 187
		private static readonly TextMesh.get_fontSizeDelegate get_fontSizeDelegateField = IL2CPP.ResolveICall<TextMesh.get_fontSizeDelegate>("UnityEngine.TextMesh::get_fontSize");

		// Token: 0x040000BC RID: 188
		private static readonly TextMesh.set_fontSizeDelegate set_fontSizeDelegateField = IL2CPP.ResolveICall<TextMesh.set_fontSizeDelegate>("UnityEngine.TextMesh::set_fontSize");

		// Token: 0x040000BD RID: 189
		private static readonly TextMesh.get_fontStyleDelegate get_fontStyleDelegateField = IL2CPP.ResolveICall<TextMesh.get_fontStyleDelegate>("UnityEngine.TextMesh::get_fontStyle");

		// Token: 0x040000BE RID: 190
		private static readonly TextMesh.set_fontStyleDelegate set_fontStyleDelegateField = IL2CPP.ResolveICall<TextMesh.set_fontStyleDelegate>("UnityEngine.TextMesh::set_fontStyle");

		// Token: 0x040000BF RID: 191
		private static readonly TextMesh.get_offsetZDelegate get_offsetZDelegateField = IL2CPP.ResolveICall<TextMesh.get_offsetZDelegate>("UnityEngine.TextMesh::get_offsetZ");

		// Token: 0x040000C0 RID: 192
		private static readonly TextMesh.set_offsetZDelegate set_offsetZDelegateField = IL2CPP.ResolveICall<TextMesh.set_offsetZDelegate>("UnityEngine.TextMesh::set_offsetZ");

		// Token: 0x040000C1 RID: 193
		private static readonly TextMesh.get_alignmentDelegate get_alignmentDelegateField = IL2CPP.ResolveICall<TextMesh.get_alignmentDelegate>("UnityEngine.TextMesh::get_alignment");

		// Token: 0x040000C2 RID: 194
		private static readonly TextMesh.set_alignmentDelegate set_alignmentDelegateField = IL2CPP.ResolveICall<TextMesh.set_alignmentDelegate>("UnityEngine.TextMesh::set_alignment");

		// Token: 0x040000C3 RID: 195
		private static readonly TextMesh.get_anchorDelegate get_anchorDelegateField = IL2CPP.ResolveICall<TextMesh.get_anchorDelegate>("UnityEngine.TextMesh::get_anchor");

		// Token: 0x040000C4 RID: 196
		private static readonly TextMesh.set_anchorDelegate set_anchorDelegateField = IL2CPP.ResolveICall<TextMesh.set_anchorDelegate>("UnityEngine.TextMesh::set_anchor");

		// Token: 0x040000C5 RID: 197
		private static readonly TextMesh.get_characterSizeDelegate get_characterSizeDelegateField = IL2CPP.ResolveICall<TextMesh.get_characterSizeDelegate>("UnityEngine.TextMesh::get_characterSize");

		// Token: 0x040000C6 RID: 198
		private static readonly TextMesh.set_characterSizeDelegate set_characterSizeDelegateField = IL2CPP.ResolveICall<TextMesh.set_characterSizeDelegate>("UnityEngine.TextMesh::set_characterSize");

		// Token: 0x040000C7 RID: 199
		private static readonly TextMesh.get_lineSpacingDelegate get_lineSpacingDelegateField = IL2CPP.ResolveICall<TextMesh.get_lineSpacingDelegate>("UnityEngine.TextMesh::get_lineSpacing");

		// Token: 0x040000C8 RID: 200
		private static readonly TextMesh.set_lineSpacingDelegate set_lineSpacingDelegateField = IL2CPP.ResolveICall<TextMesh.set_lineSpacingDelegate>("UnityEngine.TextMesh::set_lineSpacing");

		// Token: 0x040000C9 RID: 201
		private static readonly TextMesh.get_tabSizeDelegate get_tabSizeDelegateField = IL2CPP.ResolveICall<TextMesh.get_tabSizeDelegate>("UnityEngine.TextMesh::get_tabSize");

		// Token: 0x040000CA RID: 202
		private static readonly TextMesh.set_tabSizeDelegate set_tabSizeDelegateField = IL2CPP.ResolveICall<TextMesh.set_tabSizeDelegate>("UnityEngine.TextMesh::set_tabSize");

		// Token: 0x040000CB RID: 203
		private static readonly TextMesh.get_richTextDelegate get_richTextDelegateField = IL2CPP.ResolveICall<TextMesh.get_richTextDelegate>("UnityEngine.TextMesh::get_richText");

		// Token: 0x040000CC RID: 204
		private static readonly TextMesh.set_richTextDelegate set_richTextDelegateField = IL2CPP.ResolveICall<TextMesh.set_richTextDelegate>("UnityEngine.TextMesh::set_richText");

		// Token: 0x040000CD RID: 205
		private static readonly TextMesh.get_color_InjectedDelegate get_color_InjectedDelegateField = IL2CPP.ResolveICall<TextMesh.get_color_InjectedDelegate>("UnityEngine.TextMesh::get_color_Injected");

		// Token: 0x040000CE RID: 206
		private static readonly TextMesh.set_color_InjectedDelegate set_color_InjectedDelegateField = IL2CPP.ResolveICall<TextMesh.set_color_InjectedDelegate>("UnityEngine.TextMesh::set_color_Injected");

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000106 RID: 262
		private delegate IntPtr get_textDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000108 RID: 264
		private delegate void set_textDelegate(IntPtr @this, IntPtr value);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x0600010A RID: 266
		private delegate IntPtr get_fontDelegate(IntPtr @this);

		// Token: 0x0200001A RID: 26
		// (Invoke) Token: 0x0600010C RID: 268
		private delegate void set_fontDelegate(IntPtr @this, IntPtr value);

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x0600010E RID: 270
		private delegate int get_fontSizeDelegate(IntPtr @this);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000110 RID: 272
		private delegate void set_fontSizeDelegate(IntPtr @this, int value);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000112 RID: 274
		private delegate FontStyle get_fontStyleDelegate(IntPtr @this);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000114 RID: 276
		private delegate void set_fontStyleDelegate(IntPtr @this, FontStyle value);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x06000116 RID: 278
		private delegate float get_offsetZDelegate(IntPtr @this);

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000118 RID: 280
		private delegate void set_offsetZDelegate(IntPtr @this, float value);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600011A RID: 282
		private delegate TextAlignment get_alignmentDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x0600011C RID: 284
		private delegate void set_alignmentDelegate(IntPtr @this, TextAlignment value);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x0600011E RID: 286
		private delegate TextAnchor get_anchorDelegate(IntPtr @this);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000120 RID: 288
		private delegate void set_anchorDelegate(IntPtr @this, TextAnchor value);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000122 RID: 290
		private delegate float get_characterSizeDelegate(IntPtr @this);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000124 RID: 292
		private delegate void set_characterSizeDelegate(IntPtr @this, float value);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x06000126 RID: 294
		private delegate float get_lineSpacingDelegate(IntPtr @this);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x06000128 RID: 296
		private delegate void set_lineSpacingDelegate(IntPtr @this, float value);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600012A RID: 298
		private delegate float get_tabSizeDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x0600012C RID: 300
		private delegate void set_tabSizeDelegate(IntPtr @this, float value);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x0600012E RID: 302
		private delegate bool get_richTextDelegate(IntPtr @this);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000130 RID: 304
		private delegate void set_richTextDelegate(IntPtr @this, bool value);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000132 RID: 306
		private delegate void get_color_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000134 RID: 308
		private delegate void set_color_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
