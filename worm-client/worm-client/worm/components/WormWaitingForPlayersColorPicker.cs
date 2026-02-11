using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;
using worm.match.data;
using worm.match.prompts.behaviours;

namespace worm.components
{
	// Token: 0x0200007E RID: 126
	public class WormWaitingForPlayersColorPicker : Subscriber<WormColorData>
	{
		// Token: 0x060004DC RID: 1244 RVA: 0x00027BB0 File Offset: 0x00025DB0
		// Note: this type is marked as 'beforefieldinit'.
		static WormWaitingForPlayersColorPicker()
		{
			Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.components", "WormWaitingForPlayersColorPicker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr);
			WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_toggles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "toggles");
			WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_prompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "prompt");
			WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_allColorData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "allColorData");
			WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_cachedVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "cachedVersion");
			WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_lastSavedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "lastSavedColor");
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664007);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664008);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664009);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_dirtyUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664010);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_Event_ConfirmColor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664011);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664012);
			WormWaitingForPlayersColorPicker.NativeMethodInfoPtr__start_b__5_1_Private_Void_PieceColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, 100664013);
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00027CD0 File Offset: 0x00025ED0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694396, XrefRangeEnd = 694448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00027D0C File Offset: 0x00025F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694448, XrefRangeEnd = 694455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00027D48 File Offset: 0x00025F48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694455, XrefRangeEnd = 694460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00027D7C File Offset: 0x00025F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 694496, RefRangeEnd = 694497, XrefRangeStart = 694460, XrefRangeEnd = 694496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_dirtyUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00027DB0 File Offset: 0x00025FB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694497, XrefRangeEnd = 694521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ConfirmColor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.NativeMethodInfoPtr_Event_ConfirmColor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00027DE4 File Offset: 0x00025FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694521, XrefRangeEnd = 694524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormWaitingForPlayersColorPicker()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00027E20 File Offset: 0x00026020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694524, XrefRangeEnd = 694527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _start_b__5_1(PieceColor color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.NativeMethodInfoPtr__start_b__5_1_Private_Void_PieceColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00004619 File Offset: 0x00002819
		public WormWaitingForPlayersColorPicker(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00027E60 File Offset: 0x00026060
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x00004622 File Offset: 0x00002822
		public unsafe WormSelectColorToggles toggles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_toggles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormSelectColorToggles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_toggles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x00027E90 File Offset: 0x00026090
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00004641 File Offset: 0x00002841
		public unsafe WormWaitingForPlayersPromptBehaviour prompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_prompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWaitingForPlayersPromptBehaviour>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_prompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00027EC0 File Offset: 0x000260C0
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x00004660 File Offset: 0x00002860
		public unsafe IReadOnlyList<WormColorData> allColorData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_allColorData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<WormColorData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_allColorData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x00027EF0 File Offset: 0x000260F0
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x0000467F File Offset: 0x0000287F
		public unsafe ulong cachedVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_cachedVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_cachedVersion)) = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00027F18 File Offset: 0x00026118
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x0000469A File Offset: 0x0000289A
		public Nullable<PieceColor> lastSavedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_lastSavedColor);
				return new Nullable<PieceColor>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PieceColor>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.NativeFieldInfoPtr_lastSavedColor), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PieceColor>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeFieldInfoPtr_toggles;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeFieldInfoPtr_prompt;

		// Token: 0x040002D4 RID: 724
		private static readonly IntPtr NativeFieldInfoPtr_allColorData;

		// Token: 0x040002D5 RID: 725
		private static readonly IntPtr NativeFieldInfoPtr_cachedVersion;

		// Token: 0x040002D6 RID: 726
		private static readonly IntPtr NativeFieldInfoPtr_lastSavedColor;

		// Token: 0x040002D7 RID: 727
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x040002D8 RID: 728
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x040002D9 RID: 729
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040002DA RID: 730
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Private_Void_0;

		// Token: 0x040002DB RID: 731
		private static readonly IntPtr NativeMethodInfoPtr_Event_ConfirmColor_Public_Void_0;

		// Token: 0x040002DC RID: 732
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040002DD RID: 733
		private static readonly IntPtr NativeMethodInfoPtr__start_b__5_1_Private_Void_PieceColor_0;

		// Token: 0x020002F9 RID: 761
		[ObfuscatedName("worm.components.WormWaitingForPlayersColorPicker+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001EC5 RID: 7877 RVA: 0x0007640C File Offset: 0x0007460C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr);
				WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr, "<>9");
				WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr, "<>9__5_0");
				WormWaitingForPlayersColorPicker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr, 100664015);
				WormWaitingForPlayersColorPicker.__c.NativeMethodInfoPtr__start_b__5_0_Internal_WormColorData_SubscriptionProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr, 100664016);
			}

			// Token: 0x06001EC6 RID: 7878 RVA: 0x00076488 File Offset: 0x00074688
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EC7 RID: 7879 RVA: 0x000764C4 File Offset: 0x000746C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694390, XrefRangeEnd = 694394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WormColorData _start_b__5_0(SubscriptionProvider s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.__c.NativeMethodInfoPtr__start_b__5_0_Internal_WormColorData_SubscriptionProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WormColorData>(intPtr3) : null;
				}
			}

			// Token: 0x06001EC8 RID: 7880 RVA: 0x00011713 File Offset: 0x0000F913
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x06001EC9 RID: 7881 RVA: 0x00076514 File Offset: 0x00074714
			// (set) Token: 0x06001ECA RID: 7882 RVA: 0x0001171C File Offset: 0x0000F91C
			public unsafe static WormWaitingForPlayersColorPicker.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormWaitingForPlayersColorPicker.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x06001ECB RID: 7883 RVA: 0x0007653C File Offset: 0x0007473C
			// (set) Token: 0x06001ECC RID: 7884 RVA: 0x0001172E File Offset: 0x0000F92E
			public unsafe static Func<SubscriptionProvider, WormColorData> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SubscriptionProvider, WormColorData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormWaitingForPlayersColorPicker.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011CC RID: 4556
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040011CD RID: 4557
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040011CE RID: 4558
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011CF RID: 4559
			private static readonly IntPtr NativeMethodInfoPtr__start_b__5_0_Internal_WormColorData_SubscriptionProvider_0;
		}

		// Token: 0x020002FA RID: 762
		[ObfuscatedName("worm.components.WormWaitingForPlayersColorPicker+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x06001ECD RID: 7885 RVA: 0x00076564 File Offset: 0x00074764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr);
				WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeFieldInfoPtr_pair = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr, "pair");
				WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr, 100664017);
				WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_WormColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr, 100664018);
				WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_WormColorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr, 100664019);
			}

			// Token: 0x06001ECE RID: 7886 RVA: 0x000765E0 File Offset: 0x000747E0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormWaitingForPlayersColorPicker.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ECF RID: 7887 RVA: 0x0007661C File Offset: 0x0007481C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694394, XrefRangeEnd = 694395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__0(WormColorData c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_WormColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ED0 RID: 7888 RVA: 0x0007666C File Offset: 0x0007486C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694395, XrefRangeEnd = 694396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(WormColorData c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_WormColorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001ED1 RID: 7889 RVA: 0x00011740 File Offset: 0x0000F940
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x06001ED2 RID: 7890 RVA: 0x000766BC File Offset: 0x000748BC
			// (set) Token: 0x06001ED3 RID: 7891 RVA: 0x00011749 File Offset: 0x0000F949
			public WormSelectColorToggles.ColorTogglePair pair
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeFieldInfoPtr_pair);
					return new WormSelectColorToggles.ColorTogglePair(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormWaitingForPlayersColorPicker.__c__DisplayClass8_0.NativeFieldInfoPtr_pair), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WormSelectColorToggles.ColorTogglePair>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040011D0 RID: 4560
			private static readonly IntPtr NativeFieldInfoPtr_pair;

			// Token: 0x040011D1 RID: 4561
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040011D2 RID: 4562
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Boolean_WormColorData_0;

			// Token: 0x040011D3 RID: 4563
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_WormColorData_0;
		}
	}
}
