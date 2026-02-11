using System;
using boardgames.menus.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using worm.canis.data.enums;

namespace worm.menus.components
{
	// Token: 0x02000098 RID: 152
	public class GameplayVariantDropdown : ConfigureGameOptionDropdown
	{
		// Token: 0x060005FF RID: 1535 RVA: 0x0002AF0C File Offset: 0x0002910C
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayVariantDropdown()
		{
			Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.menus.components", "GameplayVariantDropdown");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr);
			GameplayVariantDropdown.NativeFieldInfoPtr_enabledSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, "enabledSets");
			GameplayVariantDropdown.NativeMethodInfoPtr_Event_EnableRiseOfIx_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, 100664140);
			GameplayVariantDropdown.NativeMethodInfoPtr_Event_EnableImmortality_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, 100664141);
			GameplayVariantDropdown.NativeMethodInfoPtr_EnableSet_Private_Void_Set_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, 100664142);
			GameplayVariantDropdown.NativeMethodInfoPtr_GetOptions_Protected_Virtual_IEnumerable_1_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, 100664143);
			GameplayVariantDropdown.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, 100664144);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0002AFB4 File Offset: 0x000291B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695907, XrefRangeEnd = 695908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_EnableRiseOfIx(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown.NativeMethodInfoPtr_Event_EnableRiseOfIx_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0002AFF4 File Offset: 0x000291F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695908, XrefRangeEnd = 695909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_EnableImmortality(bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown.NativeMethodInfoPtr_Event_EnableImmortality_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0002B034 File Offset: 0x00029234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 695918, RefRangeEnd = 695920, XrefRangeStart = 695909, XrefRangeEnd = 695918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableSet(Set set, bool enable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref set;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown.NativeMethodInfoPtr_EnableSet_Private_Void_Set_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0002B080 File Offset: 0x00029280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695920, XrefRangeEnd = 695926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerable<ConfigureGameOptionDropdown.Choice> GetOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayVariantDropdown.NativeMethodInfoPtr_GetOptions_Protected_Virtual_IEnumerable_1_Choice_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ConfigureGameOptionDropdown.Choice>>(intPtr3) : null;
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0002B0CC File Offset: 0x000292CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695926, XrefRangeEnd = 695934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayVariantDropdown()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x00005044 File Offset: 0x00003244
		public GameplayVariantDropdown(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000606 RID: 1542 RVA: 0x0002B108 File Offset: 0x00029308
		// (set) Token: 0x06000607 RID: 1543 RVA: 0x0000504D File Offset: 0x0000324D
		public unsafe HashSet<Set> enabledSets
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown.NativeFieldInfoPtr_enabledSets);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Set>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown.NativeFieldInfoPtr_enabledSets), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000374 RID: 884
		private static readonly IntPtr NativeFieldInfoPtr_enabledSets;

		// Token: 0x04000375 RID: 885
		private static readonly IntPtr NativeMethodInfoPtr_Event_EnableRiseOfIx_Public_Void_Boolean_0;

		// Token: 0x04000376 RID: 886
		private static readonly IntPtr NativeMethodInfoPtr_Event_EnableImmortality_Public_Void_Boolean_0;

		// Token: 0x04000377 RID: 887
		private static readonly IntPtr NativeMethodInfoPtr_EnableSet_Private_Void_Set_Boolean_0;

		// Token: 0x04000378 RID: 888
		private static readonly IntPtr NativeMethodInfoPtr_GetOptions_Protected_Virtual_IEnumerable_1_Choice_0;

		// Token: 0x04000379 RID: 889
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000309 RID: 777
		[ObfuscatedName("worm.menus.components.GameplayVariantDropdown+<GetOptions>d__4")]
		public sealed class _GetOptions_d__4 : Object
		{
			// Token: 0x06001F4F RID: 8015 RVA: 0x00077CAC File Offset: 0x00075EAC
			// Note: this type is marked as 'beforefieldinit'.
			static _GetOptions_d__4()
			{
				Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayVariantDropdown>.NativeClassPtr, "<GetOptions>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr);
				GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, "<>1__state");
				GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, "<>2__current");
				GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, "<>l__initialThreadId");
				GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, "<>4__this");
				GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, "<i>5__2");
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664145);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664146);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664147);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__get_Current_Private_Virtual_Final_New_get_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664148);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664149);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664150);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Choice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664151);
				GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr, 100664152);
			}

			// Token: 0x06001F50 RID: 8016 RVA: 0x00077DDC File Offset: 0x00075FDC
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetOptions_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayVariantDropdown._GetOptions_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F51 RID: 8017 RVA: 0x00077E24 File Offset: 0x00076024
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F52 RID: 8018 RVA: 0x00077E58 File Offset: 0x00076058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695875, XrefRangeEnd = 695900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000894 RID: 2196
			// (get) Token: 0x06001F53 RID: 8019 RVA: 0x00077E94 File Offset: 0x00076094
			public unsafe ConfigureGameOptionDropdown.Choice System.Collections.Generic.IEnumerator<boardgames.menus.behaviours.ConfigureGameOptionDropdown.Choice>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__get_Current_Private_Virtual_Final_New_get_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigureGameOptionDropdown.Choice>(intPtr3) : null;
				}
			}

			// Token: 0x06001F54 RID: 8020 RVA: 0x00077ED4 File Offset: 0x000760D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695900, XrefRangeEnd = 695905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000895 RID: 2197
			// (get) Token: 0x06001F55 RID: 8021 RVA: 0x00077F08 File Offset: 0x00076108
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F56 RID: 8022 RVA: 0x00077F48 File Offset: 0x00076148
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 695905, XrefRangeEnd = 695907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ConfigureGameOptionDropdown.Choice> System_Collections_Generic_IEnumerable_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Choice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ConfigureGameOptionDropdown.Choice>>(intPtr3) : null;
			}

			// Token: 0x06001F57 RID: 8023 RVA: 0x00077F88 File Offset: 0x00076188
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayVariantDropdown._GetOptions_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F58 RID: 8024 RVA: 0x00011AE4 File Offset: 0x0000FCE4
			public _GetOptions_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700088F RID: 2191
			// (get) Token: 0x06001F59 RID: 8025 RVA: 0x00077FC8 File Offset: 0x000761C8
			// (set) Token: 0x06001F5A RID: 8026 RVA: 0x00011AED File Offset: 0x0000FCED
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000890 RID: 2192
			// (get) Token: 0x06001F5B RID: 8027 RVA: 0x00077FF0 File Offset: 0x000761F0
			// (set) Token: 0x06001F5C RID: 8028 RVA: 0x00011B08 File Offset: 0x0000FD08
			public unsafe ConfigureGameOptionDropdown.Choice __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigureGameOptionDropdown.Choice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000891 RID: 2193
			// (get) Token: 0x06001F5D RID: 8029 RVA: 0x00078020 File Offset: 0x00076220
			// (set) Token: 0x06001F5E RID: 8030 RVA: 0x00011B27 File Offset: 0x0000FD27
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000892 RID: 2194
			// (get) Token: 0x06001F5F RID: 8031 RVA: 0x00078048 File Offset: 0x00076248
			// (set) Token: 0x06001F60 RID: 8032 RVA: 0x00011B42 File Offset: 0x0000FD42
			public unsafe GameplayVariantDropdown __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayVariantDropdown>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000893 RID: 2195
			// (get) Token: 0x06001F61 RID: 8033 RVA: 0x00078078 File Offset: 0x00076278
			// (set) Token: 0x06001F62 RID: 8034 RVA: 0x00011B61 File Offset: 0x0000FD61
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayVariantDropdown._GetOptions_d__4.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04001216 RID: 4630
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001217 RID: 4631
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001218 RID: 4632
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04001219 RID: 4633
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400121A RID: 4634
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400121B RID: 4635
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400121C RID: 4636
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400121D RID: 4637
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400121E RID: 4638
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__get_Current_Private_Virtual_Final_New_get_Choice_0;

			// Token: 0x0400121F RID: 4639
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001220 RID: 4640
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001221 RID: 4641
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_boardgames_menus_behaviours_ConfigureGameOptionDropdown_Choice__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Choice_0;

			// Token: 0x04001222 RID: 4642
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}
	}
}
