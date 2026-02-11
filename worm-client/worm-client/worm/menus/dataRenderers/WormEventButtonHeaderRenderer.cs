using System;
using boardgames.menus.ui;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using worm.networking.responses;

namespace worm.menus.dataRenderers
{
	// Token: 0x02000084 RID: 132
	public class WormEventButtonHeaderRenderer : Subscriber<WormEventData>
	{
		// Token: 0x06000513 RID: 1299 RVA: 0x00028578 File Offset: 0x00026778
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventButtonHeaderRenderer()
		{
			Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.dataRenderers", "WormEventButtonHeaderRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr);
			WormEventButtonHeaderRenderer.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "timer");
			WormEventButtonHeaderRenderer.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "title");
			WormEventButtonHeaderRenderer.NativeFieldInfoPtr_subtitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "subtitle");
			WormEventButtonHeaderRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, 100664030);
			WormEventButtonHeaderRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, 100664031);
			WormEventButtonHeaderRenderer.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, 100664032);
			WormEventButtonHeaderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, 100664033);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00028634 File Offset: 0x00026834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694723, XrefRangeEnd = 694731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventButtonHeaderRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00028670 File Offset: 0x00026870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694731, XrefRangeEnd = 694857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventButtonHeaderRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000286AC File Offset: 0x000268AC
		[CallerCount(0)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x000286E0 File Offset: 0x000268E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694857, XrefRangeEnd = 694860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventButtonHeaderRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x000047ED File Offset: 0x000029ED
		public WormEventButtonHeaderRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x0002871C File Offset: 0x0002691C
		// (set) Token: 0x0600051A RID: 1306 RVA: 0x000047F6 File Offset: 0x000029F6
		public unsafe TimerDisplay timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_timer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TimerDisplay>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_timer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0002874C File Offset: 0x0002694C
		// (set) Token: 0x0600051C RID: 1308 RVA: 0x00004815 File Offset: 0x00002A15
		public unsafe TMP_Text title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_title);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0002877C File Offset: 0x0002697C
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x00004834 File Offset: 0x00002A34
		public unsafe TMP_Text subtitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_subtitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.NativeFieldInfoPtr_subtitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002F0 RID: 752
		private static readonly IntPtr NativeFieldInfoPtr_timer;

		// Token: 0x040002F1 RID: 753
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x040002F2 RID: 754
		private static readonly IntPtr NativeFieldInfoPtr_subtitle;

		// Token: 0x040002F3 RID: 755
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040002F4 RID: 756
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040002F5 RID: 757
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x040002F6 RID: 758
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002FB RID: 763
		[ObfuscatedName("worm.menus.dataRenderers.WormEventButtonHeaderRenderer+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x06001ED4 RID: 7892 RVA: 0x000766EC File Offset: 0x000748EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_localRegTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, "localRegTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_lastRoundEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, "lastRoundEndTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_now = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, "now");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664034);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664035);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664036);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__6_Internal_Boolean_EventRoundData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr, 100664037);
			}

			// Token: 0x06001ED5 RID: 7893 RVA: 0x000767A4 File Offset: 0x000749A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED6 RID: 7894 RVA: 0x000767E0 File Offset: 0x000749E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694679, XrefRangeEnd = 694684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001ED7 RID: 7895 RVA: 0x0007681C File Offset: 0x00074A1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694684, XrefRangeEnd = 694689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__1_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001ED8 RID: 7896 RVA: 0x00076858 File Offset: 0x00074A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694689, XrefRangeEnd = 694698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__6(EventRoundData r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeMethodInfoPtr__modelChanged_b__6_Internal_Boolean_EventRoundData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ED9 RID: 7897 RVA: 0x00011777 File Offset: 0x0000F977
			public __c__DisplayClass4_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x06001EDA RID: 7898 RVA: 0x000768A8 File Offset: 0x00074AA8
			// (set) Token: 0x06001EDB RID: 7899 RVA: 0x00011780 File Offset: 0x0000F980
			public unsafe DateTime localRegTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_localRegTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_localRegTime)) = value;
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x06001EDC RID: 7900 RVA: 0x000768D0 File Offset: 0x00074AD0
			// (set) Token: 0x06001EDD RID: 7901 RVA: 0x0001179B File Offset: 0x0000F99B
			public unsafe DateTime lastRoundEndTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_lastRoundEndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_lastRoundEndTime)) = value;
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x06001EDE RID: 7902 RVA: 0x000768F8 File Offset: 0x00074AF8
			// (set) Token: 0x06001EDF RID: 7903 RVA: 0x000117B6 File Offset: 0x0000F9B6
			public unsafe DateTime now
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_now);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_0.NativeFieldInfoPtr_now)) = value;
				}
			}

			// Token: 0x040011D4 RID: 4564
			private static readonly IntPtr NativeFieldInfoPtr_localRegTime;

			// Token: 0x040011D5 RID: 4565
			private static readonly IntPtr NativeFieldInfoPtr_lastRoundEndTime;

			// Token: 0x040011D6 RID: 4566
			private static readonly IntPtr NativeFieldInfoPtr_now;

			// Token: 0x040011D7 RID: 4567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011D8 RID: 4568
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__0_Internal_TimeSpan_0;

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__1_Internal_TimeSpan_0;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__6_Internal_Boolean_EventRoundData_0;
		}

		// Token: 0x020002FC RID: 764
		[ObfuscatedName("worm.menus.dataRenderers.WormEventButtonHeaderRenderer+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Object
		{
			// Token: 0x06001EE0 RID: 7904 RVA: 0x00076920 File Offset: 0x00074B20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_lastRegTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr, "lastRegTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_localRoundEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr, "localRoundEndTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr, 100664038);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__modelChanged_b__2_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr, 100664039);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__modelChanged_b__3_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr, 100664040);
			}

			// Token: 0x06001EE1 RID: 7905 RVA: 0x000769B0 File Offset: 0x00074BB0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EE2 RID: 7906 RVA: 0x000769EC File Offset: 0x00074BEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694698, XrefRangeEnd = 694703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__modelChanged_b__2_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EE3 RID: 7907 RVA: 0x00076A28 File Offset: 0x00074C28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694703, XrefRangeEnd = 694708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeMethodInfoPtr__modelChanged_b__3_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EE4 RID: 7908 RVA: 0x000117D1 File Offset: 0x0000F9D1
			public __c__DisplayClass4_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x06001EE5 RID: 7909 RVA: 0x00076A64 File Offset: 0x00074C64
			// (set) Token: 0x06001EE6 RID: 7910 RVA: 0x000117DA File Offset: 0x0000F9DA
			public unsafe DateTime lastRegTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_lastRegTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_lastRegTime)) = value;
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x06001EE7 RID: 7911 RVA: 0x00076A8C File Offset: 0x00074C8C
			// (set) Token: 0x06001EE8 RID: 7912 RVA: 0x000117F5 File Offset: 0x0000F9F5
			public unsafe DateTime localRoundEndTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_localRoundEndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_1.NativeFieldInfoPtr_localRoundEndTime)) = value;
				}
			}

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeFieldInfoPtr_lastRegTime;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeFieldInfoPtr_localRoundEndTime;

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__2_Internal_TimeSpan_0;

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__3_Internal_TimeSpan_0;
		}

		// Token: 0x020002FD RID: 765
		[ObfuscatedName("worm.menus.dataRenderers.WormEventButtonHeaderRenderer+<>c__DisplayClass4_2")]
		public sealed class __c__DisplayClass4_2 : Object
		{
			// Token: 0x06001EE9 RID: 7913 RVA: 0x00076AB4 File Offset: 0x00074CB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_2()
			{
				Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "<>c__DisplayClass4_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeFieldInfoPtr_localRoundEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr, "localRoundEndTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr, 100664041);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeMethodInfoPtr__modelChanged_b__4_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr, 100664042);
			}

			// Token: 0x06001EEA RID: 7914 RVA: 0x00076B1C File Offset: 0x00074D1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_2()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EEB RID: 7915 RVA: 0x00076B58 File Offset: 0x00074D58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694708, XrefRangeEnd = 694713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeMethodInfoPtr__modelChanged_b__4_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EEC RID: 7916 RVA: 0x00011810 File Offset: 0x0000FA10
			public __c__DisplayClass4_2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x06001EED RID: 7917 RVA: 0x00076B94 File Offset: 0x00074D94
			// (set) Token: 0x06001EEE RID: 7918 RVA: 0x00011819 File Offset: 0x0000FA19
			public unsafe DateTime localRoundEndTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeFieldInfoPtr_localRoundEndTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_2.NativeFieldInfoPtr_localRoundEndTime)) = value;
				}
			}

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeFieldInfoPtr_localRoundEndTime;

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__4_Internal_TimeSpan_0;
		}

		// Token: 0x020002FE RID: 766
		[ObfuscatedName("worm.menus.dataRenderers.WormEventButtonHeaderRenderer+<>c__DisplayClass4_3")]
		public sealed class __c__DisplayClass4_3 : Object
		{
			// Token: 0x06001EEF RID: 7919 RVA: 0x00076BBC File Offset: 0x00074DBC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_3()
			{
				Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "<>c__DisplayClass4_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeFieldInfoPtr_lastRegTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr, "lastRegTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr, 100664043);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeMethodInfoPtr__modelChanged_b__5_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr, 100664044);
			}

			// Token: 0x06001EF0 RID: 7920 RVA: 0x00076C24 File Offset: 0x00074E24
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF1 RID: 7921 RVA: 0x00076C60 File Offset: 0x00074E60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694713, XrefRangeEnd = 694718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeMethodInfoPtr__modelChanged_b__5_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EF2 RID: 7922 RVA: 0x00011834 File Offset: 0x0000FA34
			public __c__DisplayClass4_3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x06001EF3 RID: 7923 RVA: 0x00076C9C File Offset: 0x00074E9C
			// (set) Token: 0x06001EF4 RID: 7924 RVA: 0x0001183D File Offset: 0x0000FA3D
			public unsafe DateTime lastRegTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeFieldInfoPtr_lastRegTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_3.NativeFieldInfoPtr_lastRegTime)) = value;
				}
			}

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeFieldInfoPtr_lastRegTime;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__5_Internal_TimeSpan_0;
		}

		// Token: 0x020002FF RID: 767
		[ObfuscatedName("worm.menus.dataRenderers.WormEventButtonHeaderRenderer+<>c__DisplayClass4_4")]
		public sealed class __c__DisplayClass4_4 : Object
		{
			// Token: 0x06001EF5 RID: 7925 RVA: 0x00076CC4 File Offset: 0x00074EC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_4()
			{
				Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventButtonHeaderRenderer>.NativeClassPtr, "<>c__DisplayClass4_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeFieldInfoPtr_nextStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr, "nextStartTime");
				WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr, 100664045);
				WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeMethodInfoPtr__modelChanged_b__7_Internal_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr, 100664046);
			}

			// Token: 0x06001EF6 RID: 7926 RVA: 0x00076D2C File Offset: 0x00074F2C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_4()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventButtonHeaderRenderer.__c__DisplayClass4_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EF7 RID: 7927 RVA: 0x00076D68 File Offset: 0x00074F68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694718, XrefRangeEnd = 694723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TimeSpan _modelChanged_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeMethodInfoPtr__modelChanged_b__7_Internal_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06001EF8 RID: 7928 RVA: 0x00011858 File Offset: 0x0000FA58
			public __c__DisplayClass4_4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x06001EF9 RID: 7929 RVA: 0x00076DA4 File Offset: 0x00074FA4
			// (set) Token: 0x06001EFA RID: 7930 RVA: 0x00011861 File Offset: 0x0000FA61
			public unsafe DateTime nextStartTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeFieldInfoPtr_nextStartTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventButtonHeaderRenderer.__c__DisplayClass4_4.NativeFieldInfoPtr_nextStartTime)) = value;
				}
			}

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeFieldInfoPtr_nextStartTime;

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__7_Internal_TimeSpan_0;
		}
	}
}
