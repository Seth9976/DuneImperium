using System;
using canis.Networking.game.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x02000217 RID: 535
	public class PostMatchHistoryCommand : Command
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x0006D28C File Offset: 0x0006B48C
		// Note: this type is marked as 'beforefieldinit'.
		static PostMatchHistoryCommand()
		{
			Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "PostMatchHistoryCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr);
			PostMatchHistoryCommand.NativeFieldInfoPtr__matchHistoryEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr, "_matchHistoryEntry");
			PostMatchHistoryCommand.NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr, 100666947);
			PostMatchHistoryCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr, 100666948);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0006D2F8 File Offset: 0x0006B4F8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostMatchHistoryCommand(MatchHistoryEntry matchHistoryEntry)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(matchHistoryEntry);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand.NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x0006D344 File Offset: 0x0006B544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527231, XrefRangeEnd = 527236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PostMatchHistoryCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0000D989 File Offset: 0x0000BB89
		public PostMatchHistoryCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x0006D390 File Offset: 0x0006B590
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0000D992 File Offset: 0x0000BB92
		public unsafe MatchHistoryEntry _matchHistoryEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand.NativeFieldInfoPtr__matchHistoryEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MatchHistoryEntry>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand.NativeFieldInfoPtr__matchHistoryEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F57 RID: 3927
		private static readonly IntPtr NativeFieldInfoPtr__matchHistoryEntry;

		// Token: 0x04000F58 RID: 3928
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MatchHistoryEntry_0;

		// Token: 0x04000F59 RID: 3929
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x020003EE RID: 1006
		[ObfuscatedName("boardgames.menus.commands.PostMatchHistoryCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06002EFA RID: 12026 RVA: 0x000B4B60 File Offset: 0x000B2D60
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PostMatchHistoryCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr);
				PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666949);
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666950);
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666951);
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666952);
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666953);
				PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr, 100666954);
			}

			// Token: 0x06002EFB RID: 12027 RVA: 0x000B4C40 File Offset: 0x000B2E40
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostMatchHistoryCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EFC RID: 12028 RVA: 0x000B4C88 File Offset: 0x000B2E88
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EFD RID: 12029 RVA: 0x000B4CBC File Offset: 0x000B2EBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527181, XrefRangeEnd = 527226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D72 RID: 3442
			// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000B4CF8 File Offset: 0x000B2EF8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002EFF RID: 12031 RVA: 0x000B4D38 File Offset: 0x000B2F38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 527226, XrefRangeEnd = 527231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D73 RID: 3443
			// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000B4D6C File Offset: 0x000B2F6C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostMatchHistoryCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002F01 RID: 12033 RVA: 0x00018485 File Offset: 0x00016685
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D6F RID: 3439
			// (get) Token: 0x06002F02 RID: 12034 RVA: 0x000B4DAC File Offset: 0x000B2FAC
			// (set) Token: 0x06002F03 RID: 12035 RVA: 0x0001848E File Offset: 0x0001668E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D70 RID: 3440
			// (get) Token: 0x06002F04 RID: 12036 RVA: 0x000B4DD4 File Offset: 0x000B2FD4
			// (set) Token: 0x06002F05 RID: 12037 RVA: 0x000184A9 File Offset: 0x000166A9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D71 RID: 3441
			// (get) Token: 0x06002F06 RID: 12038 RVA: 0x000B4E04 File Offset: 0x000B3004
			// (set) Token: 0x06002F07 RID: 12039 RVA: 0x000184C8 File Offset: 0x000166C8
			public unsafe PostMatchHistoryCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostMatchHistoryCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostMatchHistoryCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001D11 RID: 7441
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001D12 RID: 7442
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001D13 RID: 7443
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001D14 RID: 7444
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001D15 RID: 7445
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D16 RID: 7446
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001D17 RID: 7447
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001D18 RID: 7448
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001D19 RID: 7449
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
