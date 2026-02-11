using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using worm.components;
using worm.networking.responses;

namespace worm.menus.dataRenderers
{
	// Token: 0x0200008A RID: 138
	public class WormEventPointsRenderer : VersionedView<WormEventsProvider>
	{
		// Token: 0x06000565 RID: 1381 RVA: 0x000293E4 File Offset: 0x000275E4
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventPointsRenderer()
		{
			Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventPointsRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr);
			WormEventPointsRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, "display");
			WormEventPointsRenderer.NativeFieldInfoPtr_eventDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, "eventDataProvider");
			WormEventPointsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, 100664069);
			WormEventPointsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, 100664070);
			WormEventPointsRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, 100664071);
			WormEventPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, 100664072);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0002948C File Offset: 0x0002768C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695055, XrefRangeEnd = 695065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventPointsRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x000294C8 File Offset: 0x000276C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695065, XrefRangeEnd = 695069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventPointsRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00029504 File Offset: 0x00027704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 695109, RefRangeEnd = 695110, XrefRangeStart = 695069, XrefRangeEnd = 695109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getDisplayText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPointsRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002953C File Offset: 0x0002773C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695110, XrefRangeEnd = 695113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventPointsRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPointsRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00004AE8 File Offset: 0x00002CE8
		public WormEventPointsRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00029578 File Offset: 0x00027778
		// (set) Token: 0x0600056C RID: 1388 RVA: 0x00004AF1 File Offset: 0x00002CF1
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600056D RID: 1389 RVA: 0x000295A8 File Offset: 0x000277A8
		// (set) Token: 0x0600056E RID: 1390 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe SubscriptionProvider eventDataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.NativeFieldInfoPtr_eventDataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.NativeFieldInfoPtr_eventDataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_eventDataProvider;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeMethodInfoPtr_getDisplayText_Private_String_0;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000301 RID: 769
		[ObfuscatedName("worm.menus.dataRenderers.WormEventPointsRenderer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001F01 RID: 7937 RVA: 0x00076EF0 File Offset: 0x000750F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventPointsRenderer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr);
				WormEventPointsRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr, "entry");
				WormEventPointsRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664073);
				WormEventPointsRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664074);
			}

			// Token: 0x06001F02 RID: 7938 RVA: 0x00076F58 File Offset: 0x00075158
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventPointsRenderer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPointsRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F03 RID: 7939 RVA: 0x00076F94 File Offset: 0x00075194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695050, XrefRangeEnd = 695055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getDisplayText_b__0(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventPointsRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F04 RID: 7940 RVA: 0x000118A4 File Offset: 0x0000FAA4
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000878 RID: 2168
			// (get) Token: 0x06001F05 RID: 7941 RVA: 0x00076FE4 File Offset: 0x000751E4
			// (set) Token: 0x06001F06 RID: 7942 RVA: 0x000118AD File Offset: 0x0000FAAD
			public unsafe EventEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventPointsRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011EC RID: 4588
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040011ED RID: 4589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011EE RID: 4590
			private static readonly IntPtr NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0;
		}
	}
}
