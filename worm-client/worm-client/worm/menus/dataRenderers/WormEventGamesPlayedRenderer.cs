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
	// Token: 0x02000086 RID: 134
	public class WormEventGamesPlayedRenderer : VersionedView<WormEventsProvider>
	{
		// Token: 0x06000533 RID: 1331 RVA: 0x00028B50 File Offset: 0x00026D50
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventGamesPlayedRenderer()
		{
			Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventGamesPlayedRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr);
			WormEventGamesPlayedRenderer.NativeFieldInfoPtr_display = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, "display");
			WormEventGamesPlayedRenderer.NativeFieldInfoPtr_eventDataProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, "eventDataProvider");
			WormEventGamesPlayedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, 100664053);
			WormEventGamesPlayedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, 100664054);
			WormEventGamesPlayedRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, 100664055);
			WormEventGamesPlayedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, 100664056);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00028BF8 File Offset: 0x00026DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694902, XrefRangeEnd = 694912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventGamesPlayedRenderer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00028C34 File Offset: 0x00026E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694912, XrefRangeEnd = 694916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventGamesPlayedRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00028C70 File Offset: 0x00026E70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694964, RefRangeEnd = 694965, XrefRangeStart = 694916, XrefRangeEnd = 694964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getDisplayText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventGamesPlayedRenderer.NativeMethodInfoPtr_getDisplayText_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00028CA8 File Offset: 0x00026EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694965, XrefRangeEnd = 694968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventGamesPlayedRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventGamesPlayedRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00004912 File Offset: 0x00002B12
		public WormEventGamesPlayedRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000539 RID: 1337 RVA: 0x00028CE4 File Offset: 0x00026EE4
		// (set) Token: 0x0600053A RID: 1338 RVA: 0x0000491B File Offset: 0x00002B1B
		public unsafe TMP_Text display
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.NativeFieldInfoPtr_display);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.NativeFieldInfoPtr_display), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x0600053B RID: 1339 RVA: 0x00028D14 File Offset: 0x00026F14
		// (set) Token: 0x0600053C RID: 1340 RVA: 0x0000493A File Offset: 0x00002B3A
		public unsafe SubscriptionProvider eventDataProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.NativeFieldInfoPtr_eventDataProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.NativeFieldInfoPtr_eventDataProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeFieldInfoPtr_display;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeFieldInfoPtr_eventDataProvider;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000306 RID: 774
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000307 RID: 775
		private static readonly IntPtr NativeMethodInfoPtr_getDisplayText_Private_String_0;

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000300 RID: 768
		[ObfuscatedName("worm.menus.dataRenderers.WormEventGamesPlayedRenderer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001EFB RID: 7931 RVA: 0x00076DCC File Offset: 0x00074FCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventGamesPlayedRenderer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr);
				WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr, "entry");
				WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664057);
				WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664058);
			}

			// Token: 0x06001EFC RID: 7932 RVA: 0x00076E34 File Offset: 0x00075034
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventGamesPlayedRenderer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EFD RID: 7933 RVA: 0x00076E70 File Offset: 0x00075070
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694897, XrefRangeEnd = 694902, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _getDisplayText_b__0(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001EFE RID: 7934 RVA: 0x0001187C File Offset: 0x0000FA7C
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000877 RID: 2167
			// (get) Token: 0x06001EFF RID: 7935 RVA: 0x00076EC0 File Offset: 0x000750C0
			// (set) Token: 0x06001F00 RID: 7936 RVA: 0x00011885 File Offset: 0x0000FA85
			public unsafe EventEntry entry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventGamesPlayedRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040011EA RID: 4586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011EB RID: 4587
			private static readonly IntPtr NativeMethodInfoPtr__getDisplayText_b__0_Internal_Boolean_EventRoundData_0;
		}
	}
}
