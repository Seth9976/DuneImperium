using System;
using DG.Tweening;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace boardgames.util
{
	// Token: 0x02000108 RID: 264
	public static class ScrollRectUtil : global::Il2CppSystem.Object
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x000398B4 File Offset: 0x00037AB4
		// Note: this type is marked as 'beforefieldinit'.
		static ScrollRectUtil()
		{
			Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.util", "ScrollRectUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr);
			ScrollRectUtil.NativeMethodInfoPtr_ScrollTo_Public_Static_Tween_ScrollRect_RectTransform_RectTransform_RectTransform_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr, 100665297);
			ScrollRectUtil.NativeMethodInfoPtr_GetWidgetWorldPoint_Public_Static_Vector3_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr, 100665298);
			ScrollRectUtil.NativeMethodInfoPtr_GetWorldPointInWidget_Public_Static_Vector3_RectTransform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr, 100665299);
			ScrollRectUtil.NativeMethodInfoPtr_GetContentChildTransformInAncestor_Public_Static_RectTransform_RectTransform_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr, 100665300);
		}

		// Token: 0x06000CCA RID: 3274 RVA: 0x00039934 File Offset: 0x00037B34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995904, RefRangeEnd = 995906, XrefRangeStart = 995856, XrefRangeEnd = 995904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Tween ScrollTo(ScrollRect scrollRect, RectTransform targetItem, RectTransform viewportRectTransform = null, RectTransform contentRectTransform = null, float scrollDuration = 0f)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scrollRect);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetItem);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(viewportRectTransform);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentRectTransform);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scrollDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.NativeMethodInfoPtr_ScrollTo_Public_Static_Tween_ScrollRect_RectTransform_RectTransform_RectTransform_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tween>(intPtr3) : null;
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x000399BC File Offset: 0x00037BBC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 995913, RefRangeEnd = 995915, XrefRangeStart = 995906, XrefRangeEnd = 995913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetWidgetWorldPoint(RectTransform target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.NativeMethodInfoPtr_GetWidgetWorldPoint_Public_Static_Vector3_RectTransform_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00039A00 File Offset: 0x00037C00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995915, XrefRangeEnd = 995916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 GetWorldPointInWidget(RectTransform target, Vector3 worldPoint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPoint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.NativeMethodInfoPtr_GetWorldPointInWidget_Public_Static_Vector3_RectTransform_Vector3_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000CCD RID: 3277 RVA: 0x00039A50 File Offset: 0x00037C50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 995933, RefRangeEnd = 995934, XrefRangeStart = 995916, XrefRangeEnd = 995933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RectTransform GetContentChildTransformInAncestor(RectTransform rootTransform, RectTransform contentTransform)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rootTransform);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentTransform);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.NativeMethodInfoPtr_GetContentChildTransformInAncestor_Public_Static_RectTransform_RectTransform_RectTransform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr3) : null;
		}

		// Token: 0x06000CCE RID: 3278 RVA: 0x00007E71 File Offset: 0x00006071
		public ScrollRectUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007DB RID: 2011
		private static readonly IntPtr NativeMethodInfoPtr_ScrollTo_Public_Static_Tween_ScrollRect_RectTransform_RectTransform_RectTransform_Single_0;

		// Token: 0x040007DC RID: 2012
		private static readonly IntPtr NativeMethodInfoPtr_GetWidgetWorldPoint_Public_Static_Vector3_RectTransform_0;

		// Token: 0x040007DD RID: 2013
		private static readonly IntPtr NativeMethodInfoPtr_GetWorldPointInWidget_Public_Static_Vector3_RectTransform_Vector3_0;

		// Token: 0x040007DE RID: 2014
		private static readonly IntPtr NativeMethodInfoPtr_GetContentChildTransformInAncestor_Public_Static_RectTransform_RectTransform_RectTransform_0;

		// Token: 0x0200024F RID: 591
		[ObfuscatedName("boardgames.util.ScrollRectUtil+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B6D RID: 7021 RVA: 0x00065CB8 File Offset: 0x00063EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScrollRectUtil>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr);
				ScrollRectUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr, "scrollRect");
				ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr, 100665301);
				ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ScrollTo_b__0_Internal_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr, 100665302);
				ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ScrollTo_b__1_Internal_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr, 100665303);
			}

			// Token: 0x06001B6E RID: 7022 RVA: 0x00065D34 File Offset: 0x00063F34
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScrollRectUtil.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B6F RID: 7023 RVA: 0x00065D70 File Offset: 0x00063F70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995852, XrefRangeEnd = 995854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector2 _ScrollTo_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ScrollTo_b__0_Internal_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001B70 RID: 7024 RVA: 0x00065DAC File Offset: 0x00063FAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995854, XrefRangeEnd = 995856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ScrollTo_b__1(Vector2 newScrollPos)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref newScrollPos;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScrollRectUtil.__c__DisplayClass0_0.NativeMethodInfoPtr__ScrollTo_b__1_Internal_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B71 RID: 7025 RVA: 0x0000EDC8 File Offset: 0x0000CFC8
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001B72 RID: 7026 RVA: 0x00065DEC File Offset: 0x00063FEC
			// (set) Token: 0x06001B73 RID: 7027 RVA: 0x0000EDD1 File Offset: 0x0000CFD1
			public unsafe ScrollRect scrollRect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_scrollRect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ScrollRectUtil.__c__DisplayClass0_0.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001097 RID: 4247
			private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

			// Token: 0x04001098 RID: 4248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001099 RID: 4249
			private static readonly IntPtr NativeMethodInfoPtr__ScrollTo_b__0_Internal_Vector2_0;

			// Token: 0x0400109A RID: 4250
			private static readonly IntPtr NativeMethodInfoPtr__ScrollTo_b__1_Internal_Void_Vector2_0;
		}
	}
}
