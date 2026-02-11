using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.eventtriggers.clientactions;

namespace dwd.core.eventTriggers.commands
{
	// Token: 0x020001AE RID: 430
	public class UninstallEventResponseCommand : Command
	{
		// Token: 0x06001850 RID: 6224 RVA: 0x00075114 File Offset: 0x00073314
		// Note: this type is marked as 'beforefieldinit'.
		static UninstallEventResponseCommand()
		{
			Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.commands", "UninstallEventResponseCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr);
			UninstallEventResponseCommand.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr, "handle");
			UninstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr, 100667190);
			UninstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_UninstallEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr, 100667191);
			UninstallEventResponseCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr, 100667192);
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00075194 File Offset: 0x00073394
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UninstallEventResponseCommand(ClientEventResponseID handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x000751E0 File Offset: 0x000733E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UninstallEventResponseCommand(UninstallEventResponse action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_UninstallEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0007522C File Offset: 0x0007342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880458, XrefRangeEnd = 880463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UninstallEventResponseCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x0000AA98 File Offset: 0x00008C98
		public UninstallEventResponseCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x00075278 File Offset: 0x00073478
		// (set) Token: 0x06001856 RID: 6230 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		public unsafe ClientEventResponseID handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001133 RID: 4403
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04001134 RID: 4404
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0;

		// Token: 0x04001135 RID: 4405
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UninstallEventResponse_0;

		// Token: 0x04001136 RID: 4406
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000359 RID: 857
		[ObfuscatedName("dwd.core.eventTriggers.commands.UninstallEventResponseCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600274C RID: 10060 RVA: 0x000A6E3C File Offset: 0x000A503C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UninstallEventResponseCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr);
				UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667193);
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667194);
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667195);
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667196);
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667197);
				UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667198);
			}

			// Token: 0x0600274D RID: 10061 RVA: 0x000A6F1C File Offset: 0x000A511C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UninstallEventResponseCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600274E RID: 10062 RVA: 0x000A6F64 File Offset: 0x000A5164
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600274F RID: 10063 RVA: 0x000A6F98 File Offset: 0x000A5198
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880441, XrefRangeEnd = 880453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B20 RID: 2848
			// (get) Token: 0x06002750 RID: 10064 RVA: 0x000A6FD4 File Offset: 0x000A51D4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002751 RID: 10065 RVA: 0x000A7014 File Offset: 0x000A5214
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880453, XrefRangeEnd = 880458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B21 RID: 2849
			// (get) Token: 0x06002752 RID: 10066 RVA: 0x000A7048 File Offset: 0x000A5248
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002753 RID: 10067 RVA: 0x00011DB6 File Offset: 0x0000FFB6
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B1D RID: 2845
			// (get) Token: 0x06002754 RID: 10068 RVA: 0x000A7088 File Offset: 0x000A5288
			// (set) Token: 0x06002755 RID: 10069 RVA: 0x00011DBF File Offset: 0x0000FFBF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B1E RID: 2846
			// (get) Token: 0x06002756 RID: 10070 RVA: 0x000A70B0 File Offset: 0x000A52B0
			// (set) Token: 0x06002757 RID: 10071 RVA: 0x00011DDA File Offset: 0x0000FFDA
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1F RID: 2847
			// (get) Token: 0x06002758 RID: 10072 RVA: 0x000A70E0 File Offset: 0x000A52E0
			// (set) Token: 0x06002759 RID: 10073 RVA: 0x00011DF9 File Offset: 0x0000FFF9
			public unsafe UninstallEventResponseCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UninstallEventResponseCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AB4 RID: 6836
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AB5 RID: 6837
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AB6 RID: 6838
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AB7 RID: 6839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AB8 RID: 6840
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB9 RID: 6841
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001ABA RID: 6842
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001ABB RID: 6843
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001ABC RID: 6844
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
