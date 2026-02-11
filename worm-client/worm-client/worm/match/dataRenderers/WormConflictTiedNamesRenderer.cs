using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using worm.canis.actions.phases;
using worm.match.data;

namespace worm.match.dataRenderers
{
	// Token: 0x0200010F RID: 271
	public class WormConflictTiedNamesRenderer : Subscriber<WormConflictAllPlayersRewardsData>
	{
		// Token: 0x06000C4C RID: 3148 RVA: 0x0003D764 File Offset: 0x0003B964
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictTiedNamesRenderer()
		{
			Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.dataRenderers", "WormConflictTiedNamesRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr);
			WormConflictTiedNamesRenderer.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, "text");
			WormConflictTiedNamesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, 100664997);
			WormConflictTiedNamesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, 100664998);
			WormConflictTiedNamesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, 100664999);
			WormConflictTiedNamesRenderer.NativeMethodInfoPtr__modelChanged_b__2_0_Private_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, 100665000);
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0003D7F8 File Offset: 0x0003B9F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704242, XrefRangeEnd = 704247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictTiedNamesRenderer.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x0003D834 File Offset: 0x0003BA34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704247, XrefRangeEnd = 704292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictTiedNamesRenderer.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x0003D870 File Offset: 0x0003BA70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704292, XrefRangeEnd = 704295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictTiedNamesRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x0003D8AC File Offset: 0x0003BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704295, XrefRangeEnd = 704310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _modelChanged_b__2_0(EntityComponent player)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.NativeMethodInfoPtr__modelChanged_b__2_0_Private_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x000087A4 File Offset: 0x000069A4
		public WormConflictTiedNamesRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000C52 RID: 3154 RVA: 0x0003D8FC File Offset: 0x0003BAFC
		// (set) Token: 0x06000C53 RID: 3155 RVA: 0x000087AD File Offset: 0x000069AD
		public unsafe TMP_Text text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictTiedNamesRenderer.NativeFieldInfoPtr_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictTiedNamesRenderer.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000720 RID: 1824
		private static readonly IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__2_0_Private_Boolean_EntityComponent_0;

		// Token: 0x02000373 RID: 883
		[ObfuscatedName("worm.match.dataRenderers.WormConflictTiedNamesRenderer+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002390 RID: 9104 RVA: 0x00083FFC File Offset: 0x000821FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr);
				WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr, "<>9");
				WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr, "<>9__2_1");
				WormConflictTiedNamesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr, 100665002);
				WormConflictTiedNamesRenderer.__c.NativeMethodInfoPtr__modelChanged_b__2_1_Internal_Object_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr, 100665003);
			}

			// Token: 0x06002391 RID: 9105 RVA: 0x00084078 File Offset: 0x00082278
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002392 RID: 9106 RVA: 0x000840B4 File Offset: 0x000822B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704229, XrefRangeEnd = 704237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _modelChanged_b__2_1(EntityComponent player)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(player);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.__c.NativeMethodInfoPtr__modelChanged_b__2_1_Internal_Object_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002393 RID: 9107 RVA: 0x00013D89 File Offset: 0x00011F89
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D1 RID: 2513
			// (get) Token: 0x06002394 RID: 9108 RVA: 0x00084104 File Offset: 0x00082304
			// (set) Token: 0x06002395 RID: 9109 RVA: 0x00013D92 File Offset: 0x00011F92
			public unsafe static WormConflictTiedNamesRenderer.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictTiedNamesRenderer.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009D2 RID: 2514
			// (get) Token: 0x06002396 RID: 9110 RVA: 0x0008412C File Offset: 0x0008232C
			// (set) Token: 0x06002397 RID: 9111 RVA: 0x00013DA4 File Offset: 0x00011FA4
			public unsafe static Func<EntityComponent, Object> __9__2_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9__2_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormConflictTiedNamesRenderer.__c.NativeFieldInfoPtr___9__2_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400146D RID: 5229
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400146E RID: 5230
			private static readonly IntPtr NativeFieldInfoPtr___9__2_1;

			// Token: 0x0400146F RID: 5231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001470 RID: 5232
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__2_1_Internal_Object_EntityComponent_0;
		}

		// Token: 0x02000374 RID: 884
		[ObfuscatedName("worm.match.dataRenderers.WormConflictTiedNamesRenderer+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06002398 RID: 9112 RVA: 0x00084154 File Offset: 0x00082354
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictTiedNamesRenderer>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr);
				WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr, "player");
				WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100665004);
				WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr, 100665005);
			}

			// Token: 0x06002399 RID: 9113 RVA: 0x000841BC File Offset: 0x000823BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictTiedNamesRenderer.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600239A RID: 9114 RVA: 0x000841F8 File Offset: 0x000823F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 704237, XrefRangeEnd = 704242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _modelChanged_b__2(SerializedPlayerReward r)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600239B RID: 9115 RVA: 0x00013DB6 File Offset: 0x00011FB6
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009D3 RID: 2515
			// (get) Token: 0x0600239C RID: 9116 RVA: 0x00084248 File Offset: 0x00082448
			// (set) Token: 0x0600239D RID: 9117 RVA: 0x00013DBF File Offset: 0x00011FBF
			public unsafe EntityComponent player
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_player);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictTiedNamesRenderer.__c__DisplayClass2_0.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001471 RID: 5233
			private static readonly IntPtr NativeFieldInfoPtr_player;

			// Token: 0x04001472 RID: 5234
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001473 RID: 5235
			private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__2_Internal_Boolean_SerializedPlayerReward_0;
		}
	}
}
