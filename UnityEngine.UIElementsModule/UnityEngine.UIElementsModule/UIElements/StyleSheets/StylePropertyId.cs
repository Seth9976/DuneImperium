using System;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000282 RID: 642
	public enum StylePropertyId
	{
		// Token: 0x040022CF RID: 8911
		Unknown,
		// Token: 0x040022D0 RID: 8912
		Custom = -1,
		// Token: 0x040022D1 RID: 8913
		AlignContent = 131072,
		// Token: 0x040022D2 RID: 8914
		AlignItems,
		// Token: 0x040022D3 RID: 8915
		AlignSelf,
		// Token: 0x040022D4 RID: 8916
		All = 262144,
		// Token: 0x040022D5 RID: 8917
		BackgroundColor = 458752,
		// Token: 0x040022D6 RID: 8918
		BackgroundImage,
		// Token: 0x040022D7 RID: 8919
		BackgroundPosition = 262145,
		// Token: 0x040022D8 RID: 8920
		BackgroundPositionX = 458754,
		// Token: 0x040022D9 RID: 8921
		BackgroundPositionY,
		// Token: 0x040022DA RID: 8922
		BackgroundRepeat,
		// Token: 0x040022DB RID: 8923
		BackgroundSize,
		// Token: 0x040022DC RID: 8924
		BorderBottomColor,
		// Token: 0x040022DD RID: 8925
		BorderBottomLeftRadius,
		// Token: 0x040022DE RID: 8926
		BorderBottomRightRadius,
		// Token: 0x040022DF RID: 8927
		BorderBottomWidth = 131075,
		// Token: 0x040022E0 RID: 8928
		BorderColor = 262146,
		// Token: 0x040022E1 RID: 8929
		BorderLeftColor = 458761,
		// Token: 0x040022E2 RID: 8930
		BorderLeftWidth = 131076,
		// Token: 0x040022E3 RID: 8931
		BorderRadius = 262147,
		// Token: 0x040022E4 RID: 8932
		BorderRightColor = 458762,
		// Token: 0x040022E5 RID: 8933
		BorderRightWidth = 131077,
		// Token: 0x040022E6 RID: 8934
		BorderTopColor = 458763,
		// Token: 0x040022E7 RID: 8935
		BorderTopLeftRadius,
		// Token: 0x040022E8 RID: 8936
		BorderTopRightRadius,
		// Token: 0x040022E9 RID: 8937
		BorderTopWidth = 131078,
		// Token: 0x040022EA RID: 8938
		BorderWidth = 262148,
		// Token: 0x040022EB RID: 8939
		Bottom = 131079,
		// Token: 0x040022EC RID: 8940
		Color = 65536,
		// Token: 0x040022ED RID: 8941
		Cursor = 196608,
		// Token: 0x040022EE RID: 8942
		Display = 131080,
		// Token: 0x040022EF RID: 8943
		Flex = 262149,
		// Token: 0x040022F0 RID: 8944
		FlexBasis = 131081,
		// Token: 0x040022F1 RID: 8945
		FlexDirection,
		// Token: 0x040022F2 RID: 8946
		FlexGrow,
		// Token: 0x040022F3 RID: 8947
		FlexShrink,
		// Token: 0x040022F4 RID: 8948
		FlexWrap,
		// Token: 0x040022F5 RID: 8949
		FontSize = 65537,
		// Token: 0x040022F6 RID: 8950
		Height = 131086,
		// Token: 0x040022F7 RID: 8951
		JustifyContent,
		// Token: 0x040022F8 RID: 8952
		Left,
		// Token: 0x040022F9 RID: 8953
		LetterSpacing = 65538,
		// Token: 0x040022FA RID: 8954
		Margin = 262150,
		// Token: 0x040022FB RID: 8955
		MarginBottom = 131089,
		// Token: 0x040022FC RID: 8956
		MarginLeft,
		// Token: 0x040022FD RID: 8957
		MarginRight,
		// Token: 0x040022FE RID: 8958
		MarginTop,
		// Token: 0x040022FF RID: 8959
		MaxHeight,
		// Token: 0x04002300 RID: 8960
		MaxWidth,
		// Token: 0x04002301 RID: 8961
		MinHeight,
		// Token: 0x04002302 RID: 8962
		MinWidth,
		// Token: 0x04002303 RID: 8963
		Opacity = 458766,
		// Token: 0x04002304 RID: 8964
		Overflow,
		// Token: 0x04002305 RID: 8965
		Padding = 262151,
		// Token: 0x04002306 RID: 8966
		PaddingBottom = 131097,
		// Token: 0x04002307 RID: 8967
		PaddingLeft,
		// Token: 0x04002308 RID: 8968
		PaddingRight,
		// Token: 0x04002309 RID: 8969
		PaddingTop,
		// Token: 0x0400230A RID: 8970
		Position,
		// Token: 0x0400230B RID: 8971
		Right,
		// Token: 0x0400230C RID: 8972
		Rotate = 327680,
		// Token: 0x0400230D RID: 8973
		Scale,
		// Token: 0x0400230E RID: 8974
		TextOverflow = 196609,
		// Token: 0x0400230F RID: 8975
		TextShadow = 65539,
		// Token: 0x04002310 RID: 8976
		Top = 131103,
		// Token: 0x04002311 RID: 8977
		TransformOrigin = 327682,
		// Token: 0x04002312 RID: 8978
		Transition = 262152,
		// Token: 0x04002313 RID: 8979
		TransitionDelay = 393216,
		// Token: 0x04002314 RID: 8980
		TransitionDuration,
		// Token: 0x04002315 RID: 8981
		TransitionProperty,
		// Token: 0x04002316 RID: 8982
		TransitionTimingFunction,
		// Token: 0x04002317 RID: 8983
		Translate = 327683,
		// Token: 0x04002318 RID: 8984
		UnityBackgroundImageTintColor = 196610,
		// Token: 0x04002319 RID: 8985
		UnityBackgroundScaleMode = 262153,
		// Token: 0x0400231A RID: 8986
		UnityFont = 65540,
		// Token: 0x0400231B RID: 8987
		UnityFontDefinition,
		// Token: 0x0400231C RID: 8988
		UnityFontStyleAndWeight,
		// Token: 0x0400231D RID: 8989
		UnityOverflowClipBox = 196611,
		// Token: 0x0400231E RID: 8990
		UnityParagraphSpacing = 65543,
		// Token: 0x0400231F RID: 8991
		UnitySliceBottom = 196612,
		// Token: 0x04002320 RID: 8992
		UnitySliceLeft,
		// Token: 0x04002321 RID: 8993
		UnitySliceRight,
		// Token: 0x04002322 RID: 8994
		UnitySliceScale,
		// Token: 0x04002323 RID: 8995
		UnitySliceTop,
		// Token: 0x04002324 RID: 8996
		UnityTextAlign = 65544,
		// Token: 0x04002325 RID: 8997
		UnityTextOutline = 262154,
		// Token: 0x04002326 RID: 8998
		UnityTextOutlineColor = 65545,
		// Token: 0x04002327 RID: 8999
		UnityTextOutlineWidth,
		// Token: 0x04002328 RID: 9000
		UnityTextOverflowPosition = 196617,
		// Token: 0x04002329 RID: 9001
		Visibility = 65547,
		// Token: 0x0400232A RID: 9002
		WhiteSpace,
		// Token: 0x0400232B RID: 9003
		Width = 131104,
		// Token: 0x0400232C RID: 9004
		WordSpacing = 65549
	}
}
