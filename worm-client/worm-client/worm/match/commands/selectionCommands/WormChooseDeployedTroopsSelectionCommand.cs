using System;
using Canis.utils.ids;
using dwd.core.match;
using dwd.core.match.selection;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace worm.match.commands.selectionCommands
{
	// Token: 0x02000275 RID: 629
	public class WormChooseDeployedTroopsSelectionCommand : WormTroopsSelectionCommand
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x00067430 File Offset: 0x00065630
		// Note: this type is marked as 'beforefieldinit'.
		static WormChooseDeployedTroopsSelectionCommand()
		{
			Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.commands.selectionCommands", "WormChooseDeployedTroopsSelectionCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr);
			WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr, 100667033);
			WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr, 100667034);
			WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr__Advance_b__1_2_Private_Boolean_EntityID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr, 100667035);
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0006749C File Offset: 0x0006569C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721264, XrefRangeEnd = 721265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormChooseDeployedTroopsSelectionCommand(ISelectionNode node, bool fromCancel)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fromCancel;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x000674F8 File Offset: 0x000656F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721265, XrefRangeEnd = 721270, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Advance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x00067538 File Offset: 0x00065738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721270, XrefRangeEnd = 721273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _Advance_b__1_2(EntityID s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.NativeMethodInfoPtr__Advance_b__1_2_Private_Boolean_EntityID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0000F242 File Offset: 0x0000D442
		public WormChooseDeployedTroopsSelectionCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000EEA RID: 3818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ISelectionNode_Boolean_0;

		// Token: 0x04000EEB RID: 3819
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04000EEC RID: 3820
		private static readonly IntPtr NativeMethodInfoPtr__Advance_b__1_2_Private_Boolean_EntityID_0;

		// Token: 0x02000427 RID: 1063
		[ObfuscatedName("worm.match.commands.selectionCommands.WormChooseDeployedTroopsSelectionCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002C12 RID: 11282 RVA: 0x0009DAAC File Offset: 0x0009BCAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr);
				WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, "<>9");
				WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, "<>9__1_0");
				WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, "<>9__1_1");
				WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, 100667037);
				WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__Advance_b__1_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, 100667038);
				WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__Advance_b__1_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr, 100667039);
			}

			// Token: 0x06002C13 RID: 11283 RVA: 0x0009DB50 File Offset: 0x0009BD50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C14 RID: 11284 RVA: 0x0009DB8C File Offset: 0x0009BD8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721122, XrefRangeEnd = 721129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Advance_b__1_0(EntityComponent e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__Advance_b__1_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C15 RID: 11285 RVA: 0x0009DBDC File Offset: 0x0009BDDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721129, XrefRangeEnd = 721139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Advance_b__1_1(EntityComponent c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand.__c.NativeMethodInfoPtr__Advance_b__1_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002C16 RID: 11286 RVA: 0x00017F7A File Offset: 0x0001617A
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9C RID: 3228
			// (get) Token: 0x06002C17 RID: 11287 RVA: 0x0009DC2C File Offset: 0x0009BE2C
			// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00017F83 File Offset: 0x00016183
			public unsafe static WormChooseDeployedTroopsSelectionCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseDeployedTroopsSelectionCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9D RID: 3229
			// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0009DC54 File Offset: 0x0009BE54
			// (set) Token: 0x06002C1A RID: 11290 RVA: 0x00017F95 File Offset: 0x00016195
			public unsafe static Func<EntityComponent, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000C9E RID: 3230
			// (get) Token: 0x06002C1B RID: 11291 RVA: 0x0009DC7C File Offset: 0x0009BE7C
			// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00017FA7 File Offset: 0x000161A7
			public unsafe static Func<EntityComponent, bool> __9__1_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(WormChooseDeployedTroopsSelectionCommand.__c.NativeFieldInfoPtr___9__1_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019A0 RID: 6560
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040019A1 RID: 6561
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x040019A2 RID: 6562
			private static readonly IntPtr NativeFieldInfoPtr___9__1_1;

			// Token: 0x040019A3 RID: 6563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040019A4 RID: 6564
			private static readonly IntPtr NativeMethodInfoPtr__Advance_b__1_0_Internal_Boolean_EntityComponent_0;

			// Token: 0x040019A5 RID: 6565
			private static readonly IntPtr NativeMethodInfoPtr__Advance_b__1_1_Internal_Boolean_EntityComponent_0;
		}

		// Token: 0x02000428 RID: 1064
		[ObfuscatedName("worm.match.commands.selectionCommands.WormChooseDeployedTroopsSelectionCommand+<Advance>d__1")]
		public sealed class _Advance_d__1 : Object
		{
			// Token: 0x06002C1D RID: 11293 RVA: 0x0009DCA4 File Offset: 0x0009BEA4
			// Note: this type is marked as 'beforefieldinit'.
			static _Advance_d__1()
			{
				Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand>.NativeClassPtr, "<Advance>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, "<>1__state");
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, "<>2__current");
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, "<>4__this");
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, "<confirmOrDenyPrompt>5__2");
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667040);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667041);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667042);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667043);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667044);
				WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr, 100667045);
			}

			// Token: 0x06002C1E RID: 11294 RVA: 0x0009DD98 File Offset: 0x0009BF98
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Advance_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormChooseDeployedTroopsSelectionCommand._Advance_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002C1F RID: 11295 RVA: 0x0009DDE0 File Offset: 0x0009BFE0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C20 RID: 11296 RVA: 0x0009DE14 File Offset: 0x0009C014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721139, XrefRangeEnd = 721259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CA3 RID: 3235
			// (get) Token: 0x06002C21 RID: 11297 RVA: 0x0009DE50 File Offset: 0x0009C050
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C22 RID: 11298 RVA: 0x0009DE90 File Offset: 0x0009C090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 721259, XrefRangeEnd = 721264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CA4 RID: 3236
			// (get) Token: 0x06002C23 RID: 11299 RVA: 0x0009DEC4 File Offset: 0x0009C0C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002C24 RID: 11300 RVA: 0x00017FB9 File Offset: 0x000161B9
			public _Advance_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000C9F RID: 3231
			// (get) Token: 0x06002C25 RID: 11301 RVA: 0x0009DF04 File Offset: 0x0009C104
			// (set) Token: 0x06002C26 RID: 11302 RVA: 0x00017FC2 File Offset: 0x000161C2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CA0 RID: 3232
			// (get) Token: 0x06002C27 RID: 11303 RVA: 0x0009DF2C File Offset: 0x0009C12C
			// (set) Token: 0x06002C28 RID: 11304 RVA: 0x00017FDD File Offset: 0x000161DD
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA1 RID: 3233
			// (get) Token: 0x06002C29 RID: 11305 RVA: 0x0009DF5C File Offset: 0x0009C15C
			// (set) Token: 0x06002C2A RID: 11306 RVA: 0x00017FFC File Offset: 0x000161FC
			public unsafe WormChooseDeployedTroopsSelectionCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormChooseDeployedTroopsSelectionCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CA2 RID: 3234
			// (get) Token: 0x06002C2B RID: 11307 RVA: 0x0009DF8C File Offset: 0x0009C18C
			// (set) Token: 0x06002C2C RID: 11308 RVA: 0x0001801B File Offset: 0x0001621B
			public unsafe ConfirmOrDenyPrompt _confirmOrDenyPrompt_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormChooseDeployedTroopsSelectionCommand._Advance_d__1.NativeFieldInfoPtr__confirmOrDenyPrompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040019A6 RID: 6566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040019A7 RID: 6567
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040019A8 RID: 6568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040019A9 RID: 6569
			private static readonly IntPtr NativeFieldInfoPtr__confirmOrDenyPrompt_5__2;

			// Token: 0x040019AA RID: 6570
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040019AB RID: 6571
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019AC RID: 6572
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040019AD RID: 6573
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040019AE RID: 6574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040019AF RID: 6575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
