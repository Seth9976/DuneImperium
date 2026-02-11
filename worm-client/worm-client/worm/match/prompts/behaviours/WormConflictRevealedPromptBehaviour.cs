using System;
using boardgames.match;
using boardgames.match.behaviours;
using dwd.core.match;
using dwd.core.ui.prompt.behaviours;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using lotus;
using UnityEngine;
using UnityEngine.UI;

namespace worm.match.prompts.behaviours
{
	// Token: 0x020000C9 RID: 201
	public class WormConflictRevealedPromptBehaviour : PromptBehaviour<WormConflictRevealedPrompt>
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00031FF8 File Offset: 0x000301F8
		// Note: this type is marked as 'beforefieldinit'.
		static WormConflictRevealedPromptBehaviour()
		{
			Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.prompts.behaviours", "WormConflictRevealedPromptBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr);
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_cardAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "cardAnchor");
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_provider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "provider");
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "conflictLevel");
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevelSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "conflictLevelSprites");
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_tempPile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "tempPile");
			WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "entities");
			WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, 100664442);
			WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_Init_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, 100664443);
			WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, 100664444);
			WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, 100664445);
			WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, 100664446);
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00032104 File Offset: 0x00030304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698470, XrefRangeEnd = 698476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00032140 File Offset: 0x00030340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698476, XrefRangeEnd = 698481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_Init_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00032180 File Offset: 0x00030380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698481, XrefRangeEnd = 698486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_Event_Dismiss_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x000321B4 File Offset: 0x000303B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698486, XrefRangeEnd = 698488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000321F0 File Offset: 0x000303F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698488, XrefRangeEnd = 698495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormConflictRevealedPromptBehaviour()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000064CA File Offset: 0x000046CA
		public WormConflictRevealedPromptBehaviour(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0003222C File Offset: 0x0003042C
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x000064D3 File Offset: 0x000046D3
		public unsafe ContainerView cardAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_cardAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContainerView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_cardAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x0003225C File Offset: 0x0003045C
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x000064F2 File Offset: 0x000046F2
		public unsafe SubscriptionProvider provider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_provider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SubscriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_provider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x0003228C File Offset: 0x0003048C
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x00006511 File Offset: 0x00004711
		public unsafe Image conflictLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000322BC File Offset: 0x000304BC
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x00006530 File Offset: 0x00004730
		public unsafe Il2CppReferenceArray<Sprite> conflictLevelSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevelSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_conflictLevelSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000322EC File Offset: 0x000304EC
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x0000654F File Offset: 0x0000474F
		public unsafe EntityComponent tempPile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_tempPile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_tempPile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x0003231C File Offset: 0x0003051C
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x0000656E File Offset: 0x0000476E
		public unsafe DBGEntities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004D7 RID: 1239
		private static readonly IntPtr NativeFieldInfoPtr_cardAnchor;

		// Token: 0x040004D8 RID: 1240
		private static readonly IntPtr NativeFieldInfoPtr_provider;

		// Token: 0x040004D9 RID: 1241
		private static readonly IntPtr NativeFieldInfoPtr_conflictLevel;

		// Token: 0x040004DA RID: 1242
		private static readonly IntPtr NativeFieldInfoPtr_conflictLevelSprites;

		// Token: 0x040004DB RID: 1243
		private static readonly IntPtr NativeFieldInfoPtr_tempPile;

		// Token: 0x040004DC RID: 1244
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x040004DD RID: 1245
		private static readonly IntPtr NativeMethodInfoPtr_initialize_Protected_Virtual_Void_0;

		// Token: 0x040004DE RID: 1246
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_IEnumerator_0;

		// Token: 0x040004DF RID: 1247
		private static readonly IntPtr NativeMethodInfoPtr_Event_Dismiss_Public_Void_0;

		// Token: 0x040004E0 RID: 1248
		private static readonly IntPtr NativeMethodInfoPtr_cleanup_Protected_Virtual_Void_0;

		// Token: 0x040004E1 RID: 1249
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200032C RID: 812
		[ObfuscatedName("worm.match.prompts.behaviours.WormConflictRevealedPromptBehaviour+<Init>d__7")]
		public sealed class _Init_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060020C4 RID: 8388 RVA: 0x0007BE80 File Offset: 0x0007A080
			// Note: this type is marked as 'beforefieldinit'.
			static _Init_d__7()
			{
				Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour>.NativeClassPtr, "<Init>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, "<>1__state");
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, "<>2__current");
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, "<>4__this");
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, "<entitiesProvider>5__2");
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664447);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664448);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664449);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664450);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664451);
				WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr, 100664452);
			}

			// Token: 0x060020C5 RID: 8389 RVA: 0x0007BF74 File Offset: 0x0007A174
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Init_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormConflictRevealedPromptBehaviour._Init_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060020C6 RID: 8390 RVA: 0x0007BFBC File Offset: 0x0007A1BC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x0007BFF0 File Offset: 0x0007A1F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698452, XrefRangeEnd = 698465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000903 RID: 2307
			// (get) Token: 0x060020C8 RID: 8392 RVA: 0x0007C02C File Offset: 0x0007A22C
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x0007C06C File Offset: 0x0007A26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 698465, XrefRangeEnd = 698470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000904 RID: 2308
			// (get) Token: 0x060020CA RID: 8394 RVA: 0x0007C0A0 File Offset: 0x0007A2A0
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormConflictRevealedPromptBehaviour._Init_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060020CB RID: 8395 RVA: 0x00012765 File Offset: 0x00010965
			public _Init_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008FF RID: 2303
			// (get) Token: 0x060020CC RID: 8396 RVA: 0x0007C0E0 File Offset: 0x0007A2E0
			// (set) Token: 0x060020CD RID: 8397 RVA: 0x0001276E File Offset: 0x0001096E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000900 RID: 2304
			// (get) Token: 0x060020CE RID: 8398 RVA: 0x0007C108 File Offset: 0x0007A308
			// (set) Token: 0x060020CF RID: 8399 RVA: 0x00012789 File Offset: 0x00010989
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000901 RID: 2305
			// (get) Token: 0x060020D0 RID: 8400 RVA: 0x0007C138 File Offset: 0x0007A338
			// (set) Token: 0x060020D1 RID: 8401 RVA: 0x000127A8 File Offset: 0x000109A8
			public unsafe WormConflictRevealedPromptBehaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormConflictRevealedPromptBehaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000902 RID: 2306
			// (get) Token: 0x060020D2 RID: 8402 RVA: 0x0007C168 File Offset: 0x0007A368
			// (set) Token: 0x060020D3 RID: 8403 RVA: 0x000127C7 File Offset: 0x000109C7
			public unsafe DBGEntitiesProvider _entitiesProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGEntitiesProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormConflictRevealedPromptBehaviour._Init_d__7.NativeFieldInfoPtr__entitiesProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040012E0 RID: 4832
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040012E1 RID: 4833
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040012E2 RID: 4834
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040012E3 RID: 4835
			private static readonly IntPtr NativeFieldInfoPtr__entitiesProvider_5__2;

			// Token: 0x040012E4 RID: 4836
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040012E5 RID: 4837
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012E6 RID: 4838
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040012E7 RID: 4839
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040012E8 RID: 4840
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040012E9 RID: 4841
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
