using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E0 RID: 736
	public static class StyleDebug
	{
		// Token: 0x06003431 RID: 13361 RVA: 0x000DA4CC File Offset: 0x000D86CC
		public static Object GetComputedStyleValue([In] ref ComputedStyle computedStyle, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition)
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.color;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.fontSize;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.letterSpacing;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.textShadow;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityFont;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityFontDefinition;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityFontStyleAndWeight;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityParagraphSpacing;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityTextAlign;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityTextOutlineColor;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.unityTextOutlineWidth;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.visibility;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.whiteSpace;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.wordSpacing;
				}
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.alignContent;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.alignItems;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.alignSelf;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.borderBottomWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.borderLeftWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.borderRightWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.borderTopWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.bottom;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Display:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.display;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.flexBasis;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.flexDirection;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.flexGrow;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.flexShrink;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.flexWrap;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Height:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.height;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.justifyContent;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Left:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.left;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.marginBottom;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.marginLeft;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.marginRight;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.marginTop;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.maxHeight;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.maxWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.minHeight;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.minWidth;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.paddingBottom;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.paddingLeft;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.paddingRight;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.paddingTop;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Position:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.position;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Right:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.right;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Top:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.top;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Width:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.width;
					}
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Cursor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.cursor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.textOverflow;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unityBackgroundImageTintColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unityOverflowClipBox;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unitySliceBottom;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unitySliceLeft;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unitySliceRight;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceScale:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unitySliceScale;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unitySliceTop;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.unityTextOverflowPosition;
						}
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.rotate;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.scale;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.transformOrigin;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Translate:
				{
					ComputedStyle computedStyle2 = computedStyle;
					return computedStyle2.translate;
				}
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDelay:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.transitionDelay;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDuration:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.transitionDuration;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionProperty:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.transitionProperty;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionTimingFunction:
					{
						ComputedStyle computedStyle2 = computedStyle;
						return computedStyle2.transitionTimingFunction;
					}
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundImage;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundPositionX;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundPositionY;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundRepeat;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundSize:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.backgroundSize;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderBottomColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderBottomLeftRadius;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderBottomRightRadius;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderLeftColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderRightColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderTopColor;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderTopLeftRadius;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.borderTopRightRadius;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.opacity;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow:
						{
							ComputedStyle computedStyle2 = computedStyle;
							return computedStyle2.overflow;
						}
						}
						break;
					}
					break;
				}
			}
			Debug.LogAssertion(String.Format("Cannot get computed style value for property id {0}", id));
			return null;
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x000DAE64 File Offset: 0x000D9064
		public static Type GetComputedStyleType(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition)
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextShadow>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Font>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FontDefinition>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FontStyle>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextAnchor>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Visibility>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<WhiteSpace>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Align>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Align>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Align>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Display:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<DisplayStyle>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<FlexDirection>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Wrap>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Height:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Justify>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Left:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Position:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Position>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Right:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Top:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Width:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Cursor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Cursor>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextOverflow>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<OverflowClipBox>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceScale:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<int>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TextOverflowPosition>());
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Rotate>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Scale>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TransformOrigin>());
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Translate:
					return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Translate>());
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDelay:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<List<TimeValue>>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDuration:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<List<TimeValue>>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionProperty:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<List<StylePropertyName>>());
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionTimingFunction:
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<List<EasingFunction>>());
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Background>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BackgroundPosition>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BackgroundPosition>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BackgroundRepeat>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundSize:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BackgroundSize>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow:
							return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<OverflowInternal>());
						}
						break;
					}
					break;
				}
			}
			Debug.LogAssertion(String.Format("Cannot get computed style type for property id {0}", id));
			return null;
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x000DB534 File Offset: 0x000D9734
		public static Type GetShorthandStyleType(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPosition:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<BackgroundPosition>());
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderColor:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Color>());
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRadius:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderWidth:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<float>());
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Margin:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Padding:
				return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Length>());
			}
			Debug.LogAssertion(String.Format("Cannot get shorthand style type for property id {0}", id));
			return null;
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00015449 File Offset: 0x00013649
		public static Object GetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00015456 File Offset: 0x00013656
		public static void SetInlineStyleValue(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00015463 File Offset: 0x00013663
		public static void SetInlineKeyword(IStyle style, UnityEngine.UIElements.StyleSheets.StylePropertyId id, StyleKeyword keyword)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x000DB5DC File Offset: 0x000D97DC
		public static List<StyleKeyword> GetValidKeyword(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition)
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing:
					return new List<StyleKeyword>();
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent:
					{
						List<StyleKeyword> list = new List<StyleKeyword>();
						list.Add(StyleKeyword.Auto);
						return list;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems:
					{
						List<StyleKeyword> list2 = new List<StyleKeyword>();
						list2.Add(StyleKeyword.Auto);
						return list2;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf:
					{
						List<StyleKeyword> list3 = new List<StyleKeyword>();
						list3.Add(StyleKeyword.Auto);
						return list3;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomWidth:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftWidth:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightWidth:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopWidth:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Bottom:
					{
						List<StyleKeyword> list4 = new List<StyleKeyword>();
						list4.Add(StyleKeyword.Auto);
						return list4;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Display:
					{
						List<StyleKeyword> list5 = new List<StyleKeyword>();
						list5.Add(StyleKeyword.None);
						return list5;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexBasis:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexGrow:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexShrink:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Height:
					{
						List<StyleKeyword> list6 = new List<StyleKeyword>();
						list6.Add(StyleKeyword.Auto);
						return list6;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Left:
					{
						List<StyleKeyword> list7 = new List<StyleKeyword>();
						list7.Add(StyleKeyword.Auto);
						return list7;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginBottom:
					{
						List<StyleKeyword> list8 = new List<StyleKeyword>();
						list8.Add(StyleKeyword.Auto);
						return list8;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginLeft:
					{
						List<StyleKeyword> list9 = new List<StyleKeyword>();
						list9.Add(StyleKeyword.Auto);
						return list9;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginRight:
					{
						List<StyleKeyword> list10 = new List<StyleKeyword>();
						list10.Add(StyleKeyword.Auto);
						return list10;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MarginTop:
					{
						List<StyleKeyword> list11 = new List<StyleKeyword>();
						list11.Add(StyleKeyword.Auto);
						return list11;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxHeight:
					{
						List<StyleKeyword> list12 = new List<StyleKeyword>();
						list12.Add(StyleKeyword.None);
						return list12;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MaxWidth:
					{
						List<StyleKeyword> list13 = new List<StyleKeyword>();
						list13.Add(StyleKeyword.None);
						return list13;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinHeight:
					{
						List<StyleKeyword> list14 = new List<StyleKeyword>();
						list14.Add(StyleKeyword.Auto);
						return list14;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.MinWidth:
					{
						List<StyleKeyword> list15 = new List<StyleKeyword>();
						list15.Add(StyleKeyword.Auto);
						return list15;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingBottom:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingLeft:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingRight:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.PaddingTop:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Position:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Right:
					{
						List<StyleKeyword> list16 = new List<StyleKeyword>();
						list16.Add(StyleKeyword.Auto);
						return list16;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Top:
					{
						List<StyleKeyword> list17 = new List<StyleKeyword>();
						list17.Add(StyleKeyword.Auto);
						return list17;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Width:
					{
						List<StyleKeyword> list18 = new List<StyleKeyword>();
						list18.Add(StyleKeyword.Auto);
						return list18;
					}
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Cursor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundImageTintColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceBottom:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceLeft:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceRight:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceScale:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnitySliceTop:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition:
							return new List<StyleKeyword>();
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Rotate:
				{
					List<StyleKeyword> list19 = new List<StyleKeyword>();
					list19.Add(StyleKeyword.None);
					return list19;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Scale:
				{
					List<StyleKeyword> list20 = new List<StyleKeyword>();
					list20.Add(StyleKeyword.None);
					return list20;
				}
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransformOrigin:
					return new List<StyleKeyword>();
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.Translate:
				{
					List<StyleKeyword> list21 = new List<StyleKeyword>();
					list21.Add(StyleKeyword.None);
					return list21;
				}
				default:
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDelay:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionDuration:
						return new List<StyleKeyword>();
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionProperty:
					{
						List<StyleKeyword> list22 = new List<StyleKeyword>();
						list22.Add(StyleKeyword.None);
						return list22;
					}
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.TransitionTimingFunction:
						return new List<StyleKeyword>();
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage:
						{
							List<StyleKeyword> list23 = new List<StyleKeyword>();
							list23.Add(StyleKeyword.None);
							return list23;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundSize:
						{
							List<StyleKeyword> list24 = new List<StyleKeyword>();
							list24.Add(StyleKeyword.Auto);
							return list24;
						}
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomLeftRadius:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderBottomRightRadius:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderLeftColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRightColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopColor:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopLeftRadius:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderTopRightRadius:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Opacity:
							return new List<StyleKeyword>();
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow:
							return new List<StyleKeyword>();
						}
						break;
					}
					break;
				}
			}
			Debug.LogAssertion(String.Format("Cannot get valid keyword value for property id {0}", id));
			return null;
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00015470 File Offset: 0x00013670
		public static Object ConvertComputedToInlineStyleValue(UnityEngine.UIElements.StyleSheets.StylePropertyId id, Object value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x0001547D File Offset: 0x0001367D
		public static Type GetInlineStyleType(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x0001548A File Offset: 0x0001368A
		public static Il2CppStringArray GetLonghandPropertyNames(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x000DBBCC File Offset: 0x000D9DCC
		public static bool IsShorthandProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.All:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPosition:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderColor:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderRadius:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.BorderWidth:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Flex:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Margin:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Padding:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Transition:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutline:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x000DBC4C File Offset: 0x000D9E4C
		public static bool IsInheritedProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			bool flag;
			switch (id)
			{
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Color:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.FontSize:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.LetterSpacing:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.TextShadow:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
				flag = true;
				break;
			case UnityEngine.UIElements.StyleSheets.StylePropertyId.WordSpacing:
				flag = true;
				break;
			default:
				flag = false;
				break;
			}
			return flag;
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00015497 File Offset: 0x00013697
		public static Il2CppStructArray<UnityEngine.UIElements.StyleSheets.StylePropertyId> GetInheritedProperties()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000DBCE4 File Offset: 0x000D9EE4
		public static bool IsDiscreteTypeProperty(UnityEngine.UIElements.StyleSheets.StylePropertyId id)
		{
			if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent)
			{
				if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.Display)
				{
					switch (id)
					{
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFont:
						return true;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontDefinition:
						return true;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityFontStyleAndWeight:
						return true;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityParagraphSpacing:
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineColor:
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOutlineWidth:
						break;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextAlign:
						return true;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.Visibility:
						return true;
					case UnityEngine.UIElements.StyleSheets.StylePropertyId.WhiteSpace:
						return true;
					default:
						switch (id)
						{
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignContent:
							return true;
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignItems:
							return true;
						case UnityEngine.UIElements.StyleSheets.StylePropertyId.AlignSelf:
							return true;
						default:
							if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.Display)
							{
								return true;
							}
							break;
						}
						break;
					}
				}
				else
				{
					if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexDirection)
					{
						return true;
					}
					if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.FlexWrap)
					{
						return true;
					}
					if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.JustifyContent)
					{
						return true;
					}
				}
			}
			else if (id <= UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox)
			{
				if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.Position)
				{
					return true;
				}
				if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.TextOverflow)
				{
					return true;
				}
				if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityOverflowClipBox)
				{
					return true;
				}
			}
			else
			{
				if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityTextOverflowPosition)
				{
					return true;
				}
				switch (id)
				{
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundImage:
					return true;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionX:
					return true;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundPositionY:
					return true;
				case UnityEngine.UIElements.StyleSheets.StylePropertyId.BackgroundRepeat:
					return true;
				default:
					if (id == UnityEngine.UIElements.StyleSheets.StylePropertyId.Overflow)
					{
						return true;
					}
					break;
				}
			}
			return false;
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x000154A4 File Offset: 0x000136A4
		public static Il2CppStringArray GetStylePropertyNames()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x000DBE48 File Offset: 0x000DA048
		public static Il2CppStringArray GetLonghandPropertyNames(string shorthandName)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
			bool flag = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(shorthandName, out stylePropertyId);
			if (flag)
			{
				bool flag2 = StyleDebug.IsShorthandProperty(stylePropertyId);
				if (flag2)
				{
					return StyleDebug.GetLonghandPropertyNames(stylePropertyId);
				}
			}
			return null;
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x000DBE84 File Offset: 0x000DA084
		public static UnityEngine.UIElements.StyleSheets.StylePropertyId GetStylePropertyIdFromName(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
			if (flag)
			{
				stylePropertyId = UnityEngine.UIElements.StyleSheets.StylePropertyId.Unknown;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId2;
				bool flag2 = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId2);
				if (flag2)
				{
					stylePropertyId = stylePropertyId2;
				}
				else
				{
					stylePropertyId = UnityEngine.UIElements.StyleSheets.StylePropertyId.Unknown;
				}
			}
			return stylePropertyId;
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x000DBEBC File Offset: 0x000DA0BC
		public static Object GetComputedStyleValue([In] ref ComputedStyle computedStyle, string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			Object @object;
			if (flag)
			{
				@object = null;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
				bool flag2 = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId);
				if (flag2)
				{
					bool flag3 = stylePropertyId == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode;
					if (flag3)
					{
						ComputedStyle computedStyle2 = computedStyle;
						BackgroundPosition backgroundPositionX = computedStyle2.backgroundPositionX;
						computedStyle2 = computedStyle;
						BackgroundPosition backgroundPositionY = computedStyle2.backgroundPositionY;
						computedStyle2 = computedStyle;
						BackgroundRepeat backgroundRepeat = computedStyle2.backgroundRepeat;
						computedStyle2 = computedStyle;
						bool flag4;
						@object = BackgroundPropertyHelper.ResolveUnityBackgroundScaleMode(backgroundPositionX, backgroundPositionY, backgroundRepeat, computedStyle2.backgroundSize, out flag4);
					}
					else
					{
						@object = StyleDebug.GetComputedStyleValue(ref computedStyle, stylePropertyId);
					}
				}
				else
				{
					@object = null;
				}
			}
			return @object;
		}

		// Token: 0x06003443 RID: 13379 RVA: 0x000DBF54 File Offset: 0x000DA154
		public static Object GetInlineStyleValue(IStyle style, string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			Object @object;
			if (flag)
			{
				@object = null;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
				bool flag2 = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId);
				if (flag2)
				{
					bool flag3 = stylePropertyId == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode;
					if (flag3)
					{
						@object = style.unityBackgroundScaleMode;
					}
					else
					{
						@object = StyleDebug.GetInlineStyleValue(style, stylePropertyId);
					}
				}
				else
				{
					@object = null;
				}
			}
			return @object;
		}

		// Token: 0x06003444 RID: 13380 RVA: 0x000DBFB0 File Offset: 0x000DA1B0
		public static void SetInlineStyleValue(IStyle style, string name, Object value)
		{
			UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
			bool flag = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId);
			if (flag)
			{
				StyleDebug.SetInlineStyleValue(style, stylePropertyId, value);
			}
		}

		// Token: 0x06003445 RID: 13381 RVA: 0x000DBFDC File Offset: 0x000DA1DC
		public static Type GetInlineStyleType(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			Type type;
			if (flag)
			{
				type = null;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
				bool flag2 = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId);
				if (flag2)
				{
					bool flag3 = stylePropertyId == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode;
					if (flag3)
					{
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<StyleEnum<ScaleMode>>());
					}
					bool flag4 = !StyleDebug.IsShorthandProperty(stylePropertyId);
					if (flag4)
					{
						return StyleDebug.GetInlineStyleType(stylePropertyId);
					}
				}
				type = null;
			}
			return type;
		}

		// Token: 0x06003446 RID: 13382 RVA: 0x000DC044 File Offset: 0x000DA244
		public static Type GetComputedStyleType(string name)
		{
			bool flag = String.IsNullOrEmpty(name);
			Type type;
			if (flag)
			{
				type = null;
			}
			else
			{
				UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId;
				bool flag2 = UnityEngine.UIElements.StyleSheets.StylePropertyUtil.s_NameToId.TryGetValue(name, out stylePropertyId);
				if (flag2)
				{
					bool flag3 = stylePropertyId == UnityEngine.UIElements.StyleSheets.StylePropertyId.UnityBackgroundScaleMode;
					if (flag3)
					{
						return Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ScaleMode>());
					}
					bool flag4 = !StyleDebug.IsShorthandProperty(stylePropertyId);
					if (flag4)
					{
						return StyleDebug.GetComputedStyleType(stylePropertyId);
					}
				}
				type = null;
			}
			return type;
		}

		// Token: 0x06003447 RID: 13383 RVA: 0x000154B1 File Offset: 0x000136B1
		public static void FindSpecifiedStyles([In] ref ComputedStyle computedStyle, IEnumerable<UnityEngine.UIElements.StyleSheets.SelectorMatchRecord> matchRecords, Dictionary<UnityEngine.UIElements.StyleSheets.StylePropertyId, int> result)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002607 RID: 9735
		public const int UnitySpecificity = -1;

		// Token: 0x04002608 RID: 9736
		public const int UndefinedSpecificity = 0;

		// Token: 0x04002609 RID: 9737
		public const int InheritedSpecificity = 2147483646;

		// Token: 0x0400260A RID: 9738
		public const int InlineSpecificity = 2147483647;
	}
}
