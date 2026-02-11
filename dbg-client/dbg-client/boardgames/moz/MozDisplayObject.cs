using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace boardgames.moz
{
	// Token: 0x0200011B RID: 283
	public class MozDisplayObject : BaseMoz
	{
		// Token: 0x06000C98 RID: 3224 RVA: 0x0004545C File Offset: 0x0004365C
		// Note: this type is marked as 'beforefieldinit'.
		static MozDisplayObject()
		{
			Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.moz", "MozDisplayObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr);
			MozDisplayObject.NativeFieldInfoPtr_SCREEN_PADDING = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, "SCREEN_PADDING");
			MozDisplayObject.NativeFieldInfoPtr_overlayCanvasRectT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, "overlayCanvasRectT");
			MozDisplayObject.NativeFieldInfoPtr_cursorManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, "cursorManager");
			MozDisplayObject.NativeFieldInfoPtr_tooltipAnchorOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, "tooltipAnchorOverride");
			MozDisplayObject.NativeMethodInfoPtr_createElement_Protected_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, 100665131);
			MozDisplayObject.NativeMethodInfoPtr_moveFromOffScreen_Protected_IEnumerator_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, 100665132);
			MozDisplayObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, 100665133);
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00045518 File Offset: 0x00043718
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 510026, RefRangeEnd = 510028, XrefRangeStart = 509909, XrefRangeEnd = 510026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameObject createElement(GameObject prefab)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(prefab);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject.NativeMethodInfoPtr_createElement_Protected_GameObject_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00045568 File Offset: 0x00043768
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510033, RefRangeEnd = 510034, XrefRangeStart = 510028, XrefRangeEnd = 510033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator moveFromOffScreen(GameObject instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject.NativeMethodInfoPtr_moveFromOffScreen_Protected_IEnumerator_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x000455B8 File Offset: 0x000437B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 510035, RefRangeEnd = 510036, XrefRangeStart = 510034, XrefRangeEnd = 510035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MozDisplayObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000081C8 File Offset: 0x000063C8
		public MozDisplayObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700035C RID: 860
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x000455F4 File Offset: 0x000437F4
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000081D1 File Offset: 0x000063D1
		public unsafe static float SCREEN_PADDING
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MozDisplayObject.NativeFieldInfoPtr_SCREEN_PADDING, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MozDisplayObject.NativeFieldInfoPtr_SCREEN_PADDING, (void*)(&value));
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x00045610 File Offset: 0x00043810
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x000081DF File Offset: 0x000063DF
		public unsafe RectTransform overlayCanvasRectT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_overlayCanvasRectT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_overlayCanvasRectT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000CA1 RID: 3233 RVA: 0x00045640 File Offset: 0x00043840
		// (set) Token: 0x06000CA2 RID: 3234 RVA: 0x000081FE File Offset: 0x000063FE
		public unsafe CursorManager cursorManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_cursorManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CursorManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_cursorManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700035F RID: 863
		// (get) Token: 0x06000CA3 RID: 3235 RVA: 0x00045670 File Offset: 0x00043870
		// (set) Token: 0x06000CA4 RID: 3236 RVA: 0x0000821D File Offset: 0x0000641D
		public unsafe Transform tooltipAnchorOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_tooltipAnchorOverride);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject.NativeFieldInfoPtr_tooltipAnchorOverride), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeFieldInfoPtr_SCREEN_PADDING;

		// Token: 0x040007C0 RID: 1984
		private static readonly IntPtr NativeFieldInfoPtr_overlayCanvasRectT;

		// Token: 0x040007C1 RID: 1985
		private static readonly IntPtr NativeFieldInfoPtr_cursorManager;

		// Token: 0x040007C2 RID: 1986
		private static readonly IntPtr NativeFieldInfoPtr_tooltipAnchorOverride;

		// Token: 0x040007C3 RID: 1987
		private static readonly IntPtr NativeMethodInfoPtr_createElement_Protected_GameObject_GameObject_0;

		// Token: 0x040007C4 RID: 1988
		private static readonly IntPtr NativeMethodInfoPtr_moveFromOffScreen_Protected_IEnumerator_GameObject_0;

		// Token: 0x040007C5 RID: 1989
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000352 RID: 850
		[ObfuscatedName("boardgames.moz.MozDisplayObject+<moveFromOffScreen>d__5")]
		public sealed class _moveFromOffScreen_d__5 : global::Il2CppSystem.Object
		{
			// Token: 0x06002820 RID: 10272 RVA: 0x000A09DC File Offset: 0x0009EBDC
			// Note: this type is marked as 'beforefieldinit'.
			static _moveFromOffScreen_d__5()
			{
				Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MozDisplayObject>.NativeClassPtr, "<moveFromOffScreen>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr);
				MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, "<>1__state");
				MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, "<>2__current");
				MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr_instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, "instance");
				MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr__tooltipTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, "<tooltipTransform>5__2");
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665134);
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665135);
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665136);
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665137);
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665138);
				MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr, 100665139);
			}

			// Token: 0x06002821 RID: 10273 RVA: 0x000A0AD0 File Offset: 0x0009ECD0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _moveFromOffScreen_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MozDisplayObject._moveFromOffScreen_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002822 RID: 10274 RVA: 0x000A0B18 File Offset: 0x0009ED18
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002823 RID: 10275 RVA: 0x000A0B4C File Offset: 0x0009ED4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509870, XrefRangeEnd = 509904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B3B RID: 2875
			// (get) Token: 0x06002824 RID: 10276 RVA: 0x000A0B88 File Offset: 0x0009ED88
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002825 RID: 10277 RVA: 0x000A0BC8 File Offset: 0x0009EDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 509904, XrefRangeEnd = 509909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B3C RID: 2876
			// (get) Token: 0x06002826 RID: 10278 RVA: 0x000A0BFC File Offset: 0x0009EDFC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MozDisplayObject._moveFromOffScreen_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002827 RID: 10279 RVA: 0x00014C0B File Offset: 0x00012E0B
			public _moveFromOffScreen_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B37 RID: 2871
			// (get) Token: 0x06002828 RID: 10280 RVA: 0x000A0C3C File Offset: 0x0009EE3C
			// (set) Token: 0x06002829 RID: 10281 RVA: 0x00014C14 File Offset: 0x00012E14
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B38 RID: 2872
			// (get) Token: 0x0600282A RID: 10282 RVA: 0x000A0C64 File Offset: 0x0009EE64
			// (set) Token: 0x0600282B RID: 10283 RVA: 0x00014C2F File Offset: 0x00012E2F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B39 RID: 2873
			// (get) Token: 0x0600282C RID: 10284 RVA: 0x000A0C94 File Offset: 0x0009EE94
			// (set) Token: 0x0600282D RID: 10285 RVA: 0x00014C4E File Offset: 0x00012E4E
			public unsafe GameObject instance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr_instance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr_instance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B3A RID: 2874
			// (get) Token: 0x0600282E RID: 10286 RVA: 0x000A0CC4 File Offset: 0x0009EEC4
			// (set) Token: 0x0600282F RID: 10287 RVA: 0x00014C6D File Offset: 0x00012E6D
			public unsafe RectTransform _tooltipTransform_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr__tooltipTransform_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MozDisplayObject._moveFromOffScreen_d__5.NativeFieldInfoPtr__tooltipTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001928 RID: 6440
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001929 RID: 6441
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400192A RID: 6442
			private static readonly IntPtr NativeFieldInfoPtr_instance;

			// Token: 0x0400192B RID: 6443
			private static readonly IntPtr NativeFieldInfoPtr__tooltipTransform_5__2;

			// Token: 0x0400192C RID: 6444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400192D RID: 6445
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400192E RID: 6446
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400192F RID: 6447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001930 RID: 6448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001931 RID: 6449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
