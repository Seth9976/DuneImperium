using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UI
{
	// Token: 0x02000028 RID: 40
	public static class LayoutUtility : Object
	{
		// Token: 0x060004DD RID: 1245 RVA: 0x00019F88 File Offset: 0x00018188
		// Note: this type is marked as 'beforefieldinit'.
		static LayoutUtility()
		{
			Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "LayoutUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr);
			LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664092);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664093);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664094);
			LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664095);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664096);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664097);
			LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664098);
			LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664099);
			LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664100);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664101);
			LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, 100664102);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001A094 File Offset: 0x00018294
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1089273, RefRangeEnd = 1089285, XrefRangeStart = 1089242, XrefRangeEnd = 1089273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001A0E4 File Offset: 0x000182E4
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 1089344, RefRangeEnd = 1089356, XrefRangeStart = 1089285, XrefRangeEnd = 1089344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001A134 File Offset: 0x00018334
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1089387, RefRangeEnd = 1089396, XrefRangeStart = 1089356, XrefRangeEnd = 1089387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleSize(RectTransform rect, int axis)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001A184 File Offset: 0x00018384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089412, RefRangeEnd = 1089413, XrefRangeStart = 1089396, XrefRangeEnd = 1089412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001A1C8 File Offset: 0x000183C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1089443, RefRangeEnd = 1089447, XrefRangeStart = 1089413, XrefRangeEnd = 1089443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001A20C File Offset: 0x0001840C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089463, RefRangeEnd = 1089464, XrefRangeStart = 1089447, XrefRangeEnd = 1089463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleWidth(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001A250 File Offset: 0x00018450
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089480, RefRangeEnd = 1089481, XrefRangeStart = 1089464, XrefRangeEnd = 1089480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetMinHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001A294 File Offset: 0x00018494
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089511, RefRangeEnd = 1089512, XrefRangeStart = 1089481, XrefRangeEnd = 1089511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetPreferredHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0001A2D8 File Offset: 0x000184D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089528, RefRangeEnd = 1089529, XrefRangeStart = 1089512, XrefRangeEnd = 1089528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetFlexibleHeight(RectTransform rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001A31C File Offset: 0x0001851C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1089530, RefRangeEnd = 1089534, XrefRangeStart = 1089529, XrefRangeEnd = 1089530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001A380 File Offset: 0x00018580
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 1089571, RefRangeEnd = 1089585, XrefRangeStart = 1089534, XrefRangeEnd = 1089571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float GetLayoutProperty(RectTransform rect, Func<ILayoutElement, float> property, float defaultValue, out ILayoutElement source)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(property);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			source = ((intPtr4 == 0) ? null : new ILayoutElement(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00003A6F File Offset: 0x00001C6F
		public LayoutUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleSize_Public_Static_Single_RectTransform_Int32_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr_GetMinWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C2 RID: 962
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C3 RID: 963
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleWidth_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C4 RID: 964
		private static readonly IntPtr NativeMethodInfoPtr_GetMinHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C5 RID: 965
		private static readonly IntPtr NativeMethodInfoPtr_GetPreferredHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C6 RID: 966
		private static readonly IntPtr NativeMethodInfoPtr_GetFlexibleHeight_Public_Static_Single_RectTransform_0;

		// Token: 0x040003C7 RID: 967
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_0;

		// Token: 0x040003C8 RID: 968
		private static readonly IntPtr NativeMethodInfoPtr_GetLayoutProperty_Public_Static_Single_RectTransform_Func_2_ILayoutElement_Single_Single_byref_ILayoutElement_0;

		// Token: 0x020000A6 RID: 166
		[ObfuscatedName("UnityEngine.UI.LayoutUtility+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06000C9C RID: 3228 RVA: 0x00036D84 File Offset: 0x00034F84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LayoutUtility>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr);
				LayoutUtility.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9");
				LayoutUtility.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__3_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__4_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__5_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__6_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__6_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_0");
				LayoutUtility.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__7_1");
				LayoutUtility.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, "<>9__8_0");
				LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664104);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664105);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664106);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664107);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664108);
				LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664109);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664110);
				LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664111);
				LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr, 100664112);
			}

			// Token: 0x06000C9D RID: 3229 RVA: 0x00036F18 File Offset: 0x00035118
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LayoutUtility.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000C9E RID: 3230 RVA: 0x00036F54 File Offset: 0x00035154
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089210, XrefRangeEnd = 1089214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinWidth_b__3_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000C9F RID: 3231 RVA: 0x00036FA4 File Offset: 0x000351A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089214, XrefRangeEnd = 1089218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA0 RID: 3232 RVA: 0x00036FF4 File Offset: 0x000351F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089218, XrefRangeEnd = 1089222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredWidth_b__4_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA1 RID: 3233 RVA: 0x00037044 File Offset: 0x00035244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089222, XrefRangeEnd = 1089226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleWidth_b__5_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA2 RID: 3234 RVA: 0x00037094 File Offset: 0x00035294
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089226, XrefRangeEnd = 1089230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetMinHeight_b__6_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA3 RID: 3235 RVA: 0x000370E4 File Offset: 0x000352E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089230, XrefRangeEnd = 1089234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA4 RID: 3236 RVA: 0x00037134 File Offset: 0x00035334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089234, XrefRangeEnd = 1089238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetPreferredHeight_b__7_1(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA5 RID: 3237 RVA: 0x00037184 File Offset: 0x00035384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1089238, XrefRangeEnd = 1089242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetFlexibleHeight_b__8_0(ILayoutElement e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LayoutUtility.__c.NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000CA6 RID: 3238 RVA: 0x00006B48 File Offset: 0x00004D48
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700042C RID: 1068
			// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x000371D4 File Offset: 0x000353D4
			// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x00006B51 File Offset: 0x00004D51
			public unsafe static LayoutUtility.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LayoutUtility.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042D RID: 1069
			// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x000371FC File Offset: 0x000353FC
			// (set) Token: 0x06000CAA RID: 3242 RVA: 0x00006B63 File Offset: 0x00004D63
			public unsafe static Func<ILayoutElement, float> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042E RID: 1070
			// (get) Token: 0x06000CAB RID: 3243 RVA: 0x00037224 File Offset: 0x00035424
			// (set) Token: 0x06000CAC RID: 3244 RVA: 0x00006B75 File Offset: 0x00004D75
			public unsafe static Func<ILayoutElement, float> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700042F RID: 1071
			// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0003724C File Offset: 0x0003544C
			// (set) Token: 0x06000CAE RID: 3246 RVA: 0x00006B87 File Offset: 0x00004D87
			public unsafe static Func<ILayoutElement, float> __9__4_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000430 RID: 1072
			// (get) Token: 0x06000CAF RID: 3247 RVA: 0x00037274 File Offset: 0x00035474
			// (set) Token: 0x06000CB0 RID: 3248 RVA: 0x00006B99 File Offset: 0x00004D99
			public unsafe static Func<ILayoutElement, float> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000431 RID: 1073
			// (get) Token: 0x06000CB1 RID: 3249 RVA: 0x0003729C File Offset: 0x0003549C
			// (set) Token: 0x06000CB2 RID: 3250 RVA: 0x00006BAB File Offset: 0x00004DAB
			public unsafe static Func<ILayoutElement, float> __9__6_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__6_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000432 RID: 1074
			// (get) Token: 0x06000CB3 RID: 3251 RVA: 0x000372C4 File Offset: 0x000354C4
			// (set) Token: 0x06000CB4 RID: 3252 RVA: 0x00006BBD File Offset: 0x00004DBD
			public unsafe static Func<ILayoutElement, float> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000433 RID: 1075
			// (get) Token: 0x06000CB5 RID: 3253 RVA: 0x000372EC File Offset: 0x000354EC
			// (set) Token: 0x06000CB6 RID: 3254 RVA: 0x00006BCF File Offset: 0x00004DCF
			public unsafe static Func<ILayoutElement, float> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000434 RID: 1076
			// (get) Token: 0x06000CB7 RID: 3255 RVA: 0x00037314 File Offset: 0x00035514
			// (set) Token: 0x06000CB8 RID: 3256 RVA: 0x00006BE1 File Offset: 0x00004DE1
			public unsafe static Func<ILayoutElement, float> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ILayoutElement, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(LayoutUtility.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040009C0 RID: 2496
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040009C1 RID: 2497
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040009C2 RID: 2498
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x040009C3 RID: 2499
			private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

			// Token: 0x040009C4 RID: 2500
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040009C5 RID: 2501
			private static readonly IntPtr NativeFieldInfoPtr___9__6_0;

			// Token: 0x040009C6 RID: 2502
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x040009C7 RID: 2503
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x040009C8 RID: 2504
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x040009C9 RID: 2505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040009CA RID: 2506
			private static readonly IntPtr NativeMethodInfoPtr__GetMinWidth_b__3_0_Internal_Single_ILayoutElement_0;

			// Token: 0x040009CB RID: 2507
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_0_Internal_Single_ILayoutElement_0;

			// Token: 0x040009CC RID: 2508
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredWidth_b__4_1_Internal_Single_ILayoutElement_0;

			// Token: 0x040009CD RID: 2509
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleWidth_b__5_0_Internal_Single_ILayoutElement_0;

			// Token: 0x040009CE RID: 2510
			private static readonly IntPtr NativeMethodInfoPtr__GetMinHeight_b__6_0_Internal_Single_ILayoutElement_0;

			// Token: 0x040009CF RID: 2511
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_0_Internal_Single_ILayoutElement_0;

			// Token: 0x040009D0 RID: 2512
			private static readonly IntPtr NativeMethodInfoPtr__GetPreferredHeight_b__7_1_Internal_Single_ILayoutElement_0;

			// Token: 0x040009D1 RID: 2513
			private static readonly IntPtr NativeMethodInfoPtr__GetFlexibleHeight_b__8_0_Internal_Single_ILayoutElement_0;
		}
	}
}
