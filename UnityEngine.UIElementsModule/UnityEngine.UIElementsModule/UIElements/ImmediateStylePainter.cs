using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x020002D4 RID: 724
	public class ImmediateStylePainter
	{
		// Token: 0x06003410 RID: 13328 RVA: 0x0001532D File Offset: 0x0001352D
		public static void DrawRect(Rect screenRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_Injected(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x06003411 RID: 13329 RVA: 0x000DA06C File Offset: 0x000D826C
		public static void DrawTexture(Rect screenRect, Texture texture, Rect sourceRect, Color color, Vector4 borderWidths, Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_Injected(ref screenRect, texture, ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x06003412 RID: 13330 RVA: 0x000DA094 File Offset: 0x000D8294
		public static void DrawText(Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_Injected(ref screenRect, text, font, fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x06003413 RID: 13331 RVA: 0x0001533C File Offset: 0x0001353C
		public static void DrawRect_Injected(ref Rect screenRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses)
		{
			ImmediateStylePainter.DrawRect_InjectedDelegateField(ref screenRect, ref color, ref borderWidths, ref borderRadiuses);
		}

		// Token: 0x06003414 RID: 13332 RVA: 0x000DA0BC File Offset: 0x000D82BC
		public static void DrawTexture_Injected(ref Rect screenRect, Texture texture, ref Rect sourceRect, ref Color color, ref Vector4 borderWidths, ref Vector4 borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha)
		{
			ImmediateStylePainter.DrawTexture_InjectedDelegateField(ref screenRect, IL2CPP.Il2CppObjectBaseToPtr(texture), ref sourceRect, ref color, ref borderWidths, ref borderRadiuses, leftBorder, topBorder, rightBorder, bottomBorder, usePremultiplyAlpha);
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x000DA0EC File Offset: 0x000D82EC
		public static void DrawText_Injected(ref Rect screenRect, string text, Font font, int fontSize, FontStyle fontStyle, ref Color fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping)
		{
			ImmediateStylePainter.DrawText_InjectedDelegateField(ref screenRect, IL2CPP.ManagedStringToIl2Cpp(text), IL2CPP.Il2CppObjectBaseToPtr(font), fontSize, fontStyle, ref fontColor, anchor, wordWrap, wordWrapWidth, richText, textClipping);
		}

		// Token: 0x040025EB RID: 9707
		private static readonly ImmediateStylePainter.DrawRect_InjectedDelegate DrawRect_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawRect_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawRect_Injected");

		// Token: 0x040025EC RID: 9708
		private static readonly ImmediateStylePainter.DrawTexture_InjectedDelegate DrawTexture_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawTexture_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawTexture_Injected");

		// Token: 0x040025ED RID: 9709
		private static readonly ImmediateStylePainter.DrawText_InjectedDelegate DrawText_InjectedDelegateField = IL2CPP.ResolveICall<ImmediateStylePainter.DrawText_InjectedDelegate>("UnityEngine.UIElements.ImmediateStylePainter::DrawText_Injected");

		// Token: 0x02000580 RID: 1408
		// (Invoke) Token: 0x060042A2 RID: 17058
		private delegate void DrawRect_InjectedDelegate(IntPtr screenRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses);

		// Token: 0x02000581 RID: 1409
		// (Invoke) Token: 0x060042A4 RID: 17060
		private delegate void DrawTexture_InjectedDelegate(IntPtr screenRect, IntPtr texture, IntPtr sourceRect, IntPtr color, IntPtr borderWidths, IntPtr borderRadiuses, int leftBorder, int topBorder, int rightBorder, int bottomBorder, bool usePremultiplyAlpha);

		// Token: 0x02000582 RID: 1410
		// (Invoke) Token: 0x060042A6 RID: 17062
		private delegate void DrawText_InjectedDelegate(IntPtr screenRect, IntPtr text, IntPtr font, int fontSize, FontStyle fontStyle, IntPtr fontColor, TextAnchor anchor, bool wordWrap, float wordWrapWidth, bool richText, TextClipping textClipping);
	}
}
