using System;
using boardgames.ranked.networking.notifications;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.ranked.commands
{
	// Token: 0x0200003B RID: 59
	public class RunRankedSeasonEndedNotificationFlow : Command
	{
		// Token: 0x060001F4 RID: 500 RVA: 0x0000908C File Offset: 0x0000728C
		// Note: this type is marked as 'beforefieldinit'.
		static RunRankedSeasonEndedNotificationFlow()
		{
			Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames-ranked.dll", "boardgames.ranked.commands", "RunRankedSeasonEndedNotificationFlow");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr);
			RunRankedSeasonEndedNotificationFlow.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr, "message");
			RunRankedSeasonEndedNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_RankedSeasonEnded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr, 100663518);
			RunRankedSeasonEndedNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr, 100663519);
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x000090F8 File Offset: 0x000072F8
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunRankedSeasonEndedNotificationFlow(RankedSeasonEnded message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow.NativeMethodInfoPtr__ctor_Public_Void_RankedSeasonEnded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00009144 File Offset: 0x00007344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226393, XrefRangeEnd = 1226398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunRankedSeasonEndedNotificationFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000313C File Offset: 0x0000133C
		public RunRankedSeasonEndedNotificationFlow(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00009190 File Offset: 0x00007390
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x00003145 File Offset: 0x00001345
		public unsafe RankedSeasonEnded message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankedSeasonEnded>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RankedSeasonEnded_0;

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200004C RID: 76
		[ObfuscatedName("boardgames.ranked.commands.RunRankedSeasonEndedNotificationFlow+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060002C6 RID: 710 RVA: 0x0000B47C File Offset: 0x0000967C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, "<>1__state");
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, "<>2__current");
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, "<>4__this");
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663520);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663521);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663522);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663523);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663524);
				RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr, 100663525);
			}

			// Token: 0x060002C7 RID: 711 RVA: 0x0000B55C File Offset: 0x0000975C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunRankedSeasonEndedNotificationFlow._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060002C8 RID: 712 RVA: 0x0000B5A4 File Offset: 0x000097A4
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060002C9 RID: 713 RVA: 0x0000B5D8 File Offset: 0x000097D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226332, XrefRangeEnd = 1226388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060002CA RID: 714 RVA: 0x0000B614 File Offset: 0x00009814
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002CB RID: 715 RVA: 0x0000B654 File Offset: 0x00009854
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226388, XrefRangeEnd = 1226393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000D3 RID: 211
			// (get) Token: 0x060002CC RID: 716 RVA: 0x0000B688 File Offset: 0x00009888
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060002CD RID: 717 RVA: 0x00003849 File Offset: 0x00001A49
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000CF RID: 207
			// (get) Token: 0x060002CE RID: 718 RVA: 0x0000B6C8 File Offset: 0x000098C8
			// (set) Token: 0x060002CF RID: 719 RVA: 0x00003852 File Offset: 0x00001A52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000D0 RID: 208
			// (get) Token: 0x060002D0 RID: 720 RVA: 0x0000B6F0 File Offset: 0x000098F0
			// (set) Token: 0x060002D1 RID: 721 RVA: 0x0000386D File Offset: 0x00001A6D
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000D1 RID: 209
			// (get) Token: 0x060002D2 RID: 722 RVA: 0x0000B720 File Offset: 0x00009920
			// (set) Token: 0x060002D3 RID: 723 RVA: 0x0000388C File Offset: 0x00001A8C
			public unsafe RunRankedSeasonEndedNotificationFlow __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunRankedSeasonEndedNotificationFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunRankedSeasonEndedNotificationFlow._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000189 RID: 393
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400018A RID: 394
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400018B RID: 395
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400018C RID: 396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400018D RID: 397
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400018E RID: 398
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400018F RID: 399
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000190 RID: 400
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000191 RID: 401
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
