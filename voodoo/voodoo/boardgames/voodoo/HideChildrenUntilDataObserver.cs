using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;

namespace boardgames.voodoo
{
	// Token: 0x02000098 RID: 152
	public class HideChildrenUntilDataObserver : Observer
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x00027288 File Offset: 0x00025488
		// Note: this type is marked as 'beforefieldinit'.
		static HideChildrenUntilDataObserver()
		{
			Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "HideChildrenUntilDataObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr);
			HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, "excludeRenderers");
			HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeCanvasGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, "excludeCanvasGroups");
			HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, "hiddenRenderers");
			HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenCanvasGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, "hiddenCanvasGroups");
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664591);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_OnEnable_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664592);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664593);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_TrackChildrenOfTarget_Public_Void_GameObject_List_1_Renderer_List_1_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664594);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_showChildrenNextFrame_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664595);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr_toggleChildren_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664596);
			HideChildrenUntilDataObserver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, 100664597);
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00027394 File Offset: 0x00025594
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116999, XrefRangeEnd = 1117015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x000273C8 File Offset: 0x000255C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117015, XrefRangeEnd = 1117027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr_OnEnable_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x000273FC File Offset: 0x000255FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117027, XrefRangeEnd = 1117036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HideChildrenUntilDataObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F5 RID: 2293 RVA: 0x00027438 File Offset: 0x00025638
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1117062, RefRangeEnd = 1117063, XrefRangeStart = 1117036, XrefRangeEnd = 1117062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackChildrenOfTarget(GameObject target, List<Renderer> ignoreRenderers = null, List<CanvasGroup> ignoreCanvasGroups = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreRenderers);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ignoreCanvasGroups);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr_TrackChildrenOfTarget_Public_Void_GameObject_List_1_Renderer_List_1_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F6 RID: 2294 RVA: 0x000274A0 File Offset: 0x000256A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117063, XrefRangeEnd = 1117068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator showChildrenNextFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr_showChildrenNextFrame_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x000274E0 File Offset: 0x000256E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1117098, RefRangeEnd = 1117100, XrefRangeStart = 1117068, XrefRangeEnd = 1117098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void toggleChildren(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref visible;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr_toggleChildren_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x00027520 File Offset: 0x00025720
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HideChildrenUntilDataObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x000065DF File Offset: 0x000047DF
		public HideChildrenUntilDataObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0002755C File Offset: 0x0002575C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x000065E8 File Offset: 0x000047E8
		public unsafe List<Renderer> excludeRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0002758C File Offset: 0x0002578C
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x00006607 File Offset: 0x00004807
		public unsafe List<CanvasGroup> excludeCanvasGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeCanvasGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_excludeCanvasGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x000275BC File Offset: 0x000257BC
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00006626 File Offset: 0x00004826
		public unsafe List<Renderer> hiddenRenderers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenRenderers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Renderer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenRenderers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x000275EC File Offset: 0x000257EC
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00006645 File Offset: 0x00004845
		public unsafe List<CanvasGroup> hiddenCanvasGroups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenCanvasGroups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CanvasGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver.NativeFieldInfoPtr_hiddenCanvasGroups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeFieldInfoPtr_excludeRenderers;

		// Token: 0x0400059B RID: 1435
		private static readonly IntPtr NativeFieldInfoPtr_excludeCanvasGroups;

		// Token: 0x0400059C RID: 1436
		private static readonly IntPtr NativeFieldInfoPtr_hiddenRenderers;

		// Token: 0x0400059D RID: 1437
		private static readonly IntPtr NativeFieldInfoPtr_hiddenCanvasGroups;

		// Token: 0x0400059E RID: 1438
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400059F RID: 1439
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Void_0;

		// Token: 0x040005A0 RID: 1440
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040005A1 RID: 1441
		private static readonly IntPtr NativeMethodInfoPtr_TrackChildrenOfTarget_Public_Void_GameObject_List_1_Renderer_List_1_CanvasGroup_0;

		// Token: 0x040005A2 RID: 1442
		private static readonly IntPtr NativeMethodInfoPtr_showChildrenNextFrame_Private_IEnumerator_0;

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeMethodInfoPtr_toggleChildren_Private_Void_Boolean_0;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000114 RID: 276
		[ObfuscatedName("boardgames.voodoo.HideChildrenUntilDataObserver+<showChildrenNextFrame>d__8")]
		public sealed class _showChildrenNextFrame_d__8 : global::Il2CppSystem.Object
		{
			// Token: 0x06000E4C RID: 3660 RVA: 0x0003741C File Offset: 0x0003561C
			// Note: this type is marked as 'beforefieldinit'.
			static _showChildrenNextFrame_d__8()
			{
				Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HideChildrenUntilDataObserver>.NativeClassPtr, "<showChildrenNextFrame>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, "<>1__state");
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, "<>2__current");
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, "<>4__this");
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664598);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664599);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664600);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664601);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664602);
				HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr, 100664603);
			}

			// Token: 0x06000E4D RID: 3661 RVA: 0x000374FC File Offset: 0x000356FC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _showChildrenNextFrame_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HideChildrenUntilDataObserver._showChildrenNextFrame_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000E4E RID: 3662 RVA: 0x00037544 File Offset: 0x00035744
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000E4F RID: 3663 RVA: 0x00037578 File Offset: 0x00035778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116993, XrefRangeEnd = 1116994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000453 RID: 1107
			// (get) Token: 0x06000E50 RID: 3664 RVA: 0x000375B4 File Offset: 0x000357B4
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E51 RID: 3665 RVA: 0x000375F4 File Offset: 0x000357F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1116994, XrefRangeEnd = 1116999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x06000E52 RID: 3666 RVA: 0x00037628 File Offset: 0x00035828
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000E53 RID: 3667 RVA: 0x000091BE File Offset: 0x000073BE
			public _showChildrenNextFrame_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000450 RID: 1104
			// (get) Token: 0x06000E54 RID: 3668 RVA: 0x00037668 File Offset: 0x00035868
			// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000091C7 File Offset: 0x000073C7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000451 RID: 1105
			// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00037690 File Offset: 0x00035890
			// (set) Token: 0x06000E57 RID: 3671 RVA: 0x000091E2 File Offset: 0x000073E2
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06000E58 RID: 3672 RVA: 0x000376C0 File Offset: 0x000358C0
			// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00009201 File Offset: 0x00007401
			public unsafe HideChildrenUntilDataObserver __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HideChildrenUntilDataObserver>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HideChildrenUntilDataObserver._showChildrenNextFrame_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040008DE RID: 2270
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040008DF RID: 2271
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040008E0 RID: 2272
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040008E1 RID: 2273
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040008E2 RID: 2274
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008E3 RID: 2275
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040008E4 RID: 2276
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040008E5 RID: 2277
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040008E6 RID: 2278
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
