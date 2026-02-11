using System;
using Canis;
using Canis.utils.ids;
using dwd.core.notifications;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using zen.src.matchMaking.commands;

namespace boardgames.behaviours
{
	// Token: 0x020002A8 RID: 680
	public class NextGameButton : VersionedView<Notifications>
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x00089454 File Offset: 0x00087654
		// Note: this type is marked as 'beforefieldinit'.
		static NextGameButton()
		{
			Il2CppClassPointerStore<NextGameButton>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.behaviours", "NextGameButton");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr);
			NextGameButton.NativeFieldInfoPtr_button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "button");
			NextGameButton.NativeFieldInfoPtr_currentGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "currentGameID");
			NextGameButton.NativeFieldInfoPtr_nextGameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "nextGameID");
			NextGameButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668660);
			NextGameButton.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668661);
			NextGameButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668662);
			NextGameButton.NativeMethodInfoPtr_Event_PlayNextGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668663);
			NextGameButton.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668664);
			NextGameButton.NativeMethodInfoPtr___n__0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, 100668665);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00089538 File Offset: 0x00087738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542321, XrefRangeEnd = 542327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NextGameButton.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00089574 File Offset: 0x00087774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542327, XrefRangeEnd = 542332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002052 RID: 8274 RVA: 0x000895B4 File Offset: 0x000877B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542332, XrefRangeEnd = 542356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NextGameButton.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x000895F0 File Offset: 0x000877F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542356, XrefRangeEnd = 542375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_PlayNextGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.NativeMethodInfoPtr_Event_PlayNextGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00089624 File Offset: 0x00087824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542375, XrefRangeEnd = 542378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NextGameButton()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00089660 File Offset: 0x00087860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542378, XrefRangeEnd = 542381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.NativeMethodInfoPtr___n__0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00010F1F File Offset: 0x0000F11F
		public NextGameButton(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002057 RID: 8279 RVA: 0x00089694 File Offset: 0x00087894
		// (set) Token: 0x06002058 RID: 8280 RVA: 0x00010F28 File Offset: 0x0000F128
		public unsafe GameObject button
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_button);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_button), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002059 RID: 8281 RVA: 0x000896C4 File Offset: 0x000878C4
		// (set) Token: 0x0600205A RID: 8282 RVA: 0x00010F47 File Offset: 0x0000F147
		public unsafe GameID currentGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_currentGameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_currentGameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600205B RID: 8283 RVA: 0x000896F4 File Offset: 0x000878F4
		// (set) Token: 0x0600205C RID: 8284 RVA: 0x00010F66 File Offset: 0x0000F166
		public unsafe GameID nextGameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_nextGameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.NativeFieldInfoPtr_nextGameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeFieldInfoPtr_button;

		// Token: 0x0400146B RID: 5227
		private static readonly IntPtr NativeFieldInfoPtr_currentGameID;

		// Token: 0x0400146C RID: 5228
		private static readonly IntPtr NativeFieldInfoPtr_nextGameID;

		// Token: 0x0400146D RID: 5229
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x0400146E RID: 5230
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x0400146F RID: 5231
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001470 RID: 5232
		private static readonly IntPtr NativeMethodInfoPtr_Event_PlayNextGame_Public_Void_0;

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_Void_0;

		// Token: 0x0200049E RID: 1182
		[ObfuscatedName("boardgames.behaviours.NextGameButton+<>c")]
		[Serializable]
		public sealed class __c : global::Il2CppSystem.Object
		{
			// Token: 0x0600381B RID: 14363 RVA: 0x000D0180 File Offset: 0x000CE380
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr);
				NextGameButton.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr, "<>9");
				NextGameButton.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr, "<>9__5_2");
				NextGameButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr, 100668667);
				NextGameButton.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Int64_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr, 100668668);
			}

			// Token: 0x0600381C RID: 14364 RVA: 0x000D01FC File Offset: 0x000CE3FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextGameButton.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600381D RID: 14365 RVA: 0x000D0238 File Offset: 0x000CE438
			[CallerCount(0)]
			public unsafe long _dirtyUpdate_b__5_2(SaveMetaData game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c.NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Int64_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600381E RID: 14366 RVA: 0x0001CDA6 File Offset: 0x0001AFA6
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001094 RID: 4244
			// (get) Token: 0x0600381F RID: 14367 RVA: 0x000D0288 File Offset: 0x000CE488
			// (set) Token: 0x06003820 RID: 14368 RVA: 0x0001CDAF File Offset: 0x0001AFAF
			public unsafe static NextGameButton.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NextGameButton.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NextGameButton.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NextGameButton.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001095 RID: 4245
			// (get) Token: 0x06003821 RID: 14369 RVA: 0x000D02B0 File Offset: 0x000CE4B0
			// (set) Token: 0x06003822 RID: 14370 RVA: 0x0001CDC1 File Offset: 0x0001AFC1
			public unsafe static Func<SaveMetaData, long> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NextGameButton.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NextGameButton.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002280 RID: 8832
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002281 RID: 8833
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04002282 RID: 8834
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002283 RID: 8835
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__5_2_Internal_Int64_SaveMetaData_0;
		}

		// Token: 0x0200049F RID: 1183
		[ObfuscatedName("boardgames.behaviours.NextGameButton+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : global::Il2CppSystem.Object
		{
			// Token: 0x06003823 RID: 14371 RVA: 0x000D02D8 File Offset: 0x000CE4D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr);
				NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, "localPlayerID");
				NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, "<>9__1");
				NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, "<>9__3");
				NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, 100668669);
				NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Void_GetReconnectableGames_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, 100668670);
				NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, 100668671);
				NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__3_Internal_Boolean_SaveMetaData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr, 100668672);
			}

			// Token: 0x06003824 RID: 14372 RVA: 0x000D03A4 File Offset: 0x000CE5A4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextGameButton.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003825 RID: 14373 RVA: 0x000D03E0 File Offset: 0x000CE5E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542230, XrefRangeEnd = 542282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _dirtyUpdate_b__0(GetReconnectableGames getReconnectableGames)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(getReconnectableGames);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Void_GetReconnectableGames_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003826 RID: 14374 RVA: 0x000D0424 File Offset: 0x000CE624
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542282, XrefRangeEnd = 542291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__1(SaveMetaData game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003827 RID: 14375 RVA: 0x000D0474 File Offset: 0x000CE674
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542291, XrefRangeEnd = 542296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _dirtyUpdate_b__3(SaveMetaData game)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(game);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton.__c__DisplayClass5_0.NativeMethodInfoPtr__dirtyUpdate_b__3_Internal_Boolean_SaveMetaData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06003828 RID: 14376 RVA: 0x0001CDD3 File Offset: 0x0001AFD3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001096 RID: 4246
			// (get) Token: 0x06003829 RID: 14377 RVA: 0x000D04C4 File Offset: 0x000CE6C4
			// (set) Token: 0x0600382A RID: 14378 RVA: 0x0001CDDC File Offset: 0x0001AFDC
			public unsafe AccountID localPlayerID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr_localPlayerID), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001097 RID: 4247
			// (get) Token: 0x0600382B RID: 14379 RVA: 0x000D04F4 File Offset: 0x000CE6F4
			// (set) Token: 0x0600382C RID: 14380 RVA: 0x0001CDFB File Offset: 0x0001AFFB
			public unsafe NextGameButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NextGameButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001098 RID: 4248
			// (get) Token: 0x0600382D RID: 14381 RVA: 0x000D0524 File Offset: 0x000CE724
			// (set) Token: 0x0600382E RID: 14382 RVA: 0x0001CE1A File Offset: 0x0001B01A
			public unsafe Func<SaveMetaData, bool> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SaveMetaData, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001099 RID: 4249
			// (get) Token: 0x0600382F RID: 14383 RVA: 0x000D0554 File Offset: 0x000CE754
			// (set) Token: 0x06003830 RID: 14384 RVA: 0x0001CE39 File Offset: 0x0001B039
			public unsafe Predicate<SaveMetaData> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<SaveMetaData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton.__c__DisplayClass5_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002284 RID: 8836
			private static readonly IntPtr NativeFieldInfoPtr_localPlayerID;

			// Token: 0x04002285 RID: 8837
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002286 RID: 8838
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x04002287 RID: 8839
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04002288 RID: 8840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002289 RID: 8841
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__0_Internal_Void_GetReconnectableGames_0;

			// Token: 0x0400228A RID: 8842
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__1_Internal_Boolean_SaveMetaData_0;

			// Token: 0x0400228B RID: 8843
			private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__3_Internal_Boolean_SaveMetaData_0;
		}

		// Token: 0x020004A0 RID: 1184
		[ObfuscatedName("boardgames.behaviours.NextGameButton+<Init>d__4")]
		public sealed class _Init_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x06003831 RID: 14385 RVA: 0x000D0584 File Offset: 0x000CE784
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__4()
			{
				Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NextGameButton>.NativeClassPtr, "<Init>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr);
				NextGameButton._Init_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, "<>1__state");
				NextGameButton._Init_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, "<>2__current");
				NextGameButton._Init_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, "<>4__this");
				NextGameButton._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668673);
				NextGameButton._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668674);
				NextGameButton._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668675);
				NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668676);
				NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668677);
				NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr, 100668678);
			}

			// Token: 0x06003832 RID: 14386 RVA: 0x000D0664 File Offset: 0x000CE864
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NextGameButton._Init_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003833 RID: 14387 RVA: 0x000D06AC File Offset: 0x000CE8AC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003834 RID: 14388 RVA: 0x000D06E0 File Offset: 0x000CE8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542296, XrefRangeEnd = 542316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700109D RID: 4253
			// (get) Token: 0x06003835 RID: 14389 RVA: 0x000D071C File Offset: 0x000CE91C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003836 RID: 14390 RVA: 0x000D075C File Offset: 0x000CE95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 542316, XrefRangeEnd = 542321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700109E RID: 4254
			// (get) Token: 0x06003837 RID: 14391 RVA: 0x000D0790 File Offset: 0x000CE990
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NextGameButton._Init_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003838 RID: 14392 RVA: 0x0001CE58 File Offset: 0x0001B058
			public _Init_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700109A RID: 4250
			// (get) Token: 0x06003839 RID: 14393 RVA: 0x000D07D0 File Offset: 0x000CE9D0
			// (set) Token: 0x0600383A RID: 14394 RVA: 0x0001CE61 File Offset: 0x0001B061
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700109B RID: 4251
			// (get) Token: 0x0600383B RID: 14395 RVA: 0x000D07F8 File Offset: 0x000CE9F8
			// (set) Token: 0x0600383C RID: 14396 RVA: 0x0001CE7C File Offset: 0x0001B07C
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700109C RID: 4252
			// (get) Token: 0x0600383D RID: 14397 RVA: 0x000D0828 File Offset: 0x000CEA28
			// (set) Token: 0x0600383E RID: 14398 RVA: 0x0001CE9B File Offset: 0x0001B09B
			public unsafe NextGameButton __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NextGameButton>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NextGameButton._Init_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400228C RID: 8844
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400228D RID: 8845
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400228E RID: 8846
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400228F RID: 8847
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002290 RID: 8848
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002291 RID: 8849
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002292 RID: 8850
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002293 RID: 8851
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002294 RID: 8852
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
