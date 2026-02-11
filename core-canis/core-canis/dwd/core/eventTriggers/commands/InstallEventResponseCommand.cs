using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Networking.eventtriggers;
using Networking.eventtriggers.clientactions;

namespace dwd.core.eventTriggers.commands
{
	// Token: 0x020001AD RID: 429
	public class InstallEventResponseCommand : Command
	{
		// Token: 0x06001849 RID: 6217 RVA: 0x00074F80 File Offset: 0x00073180
		// Note: this type is marked as 'beforefieldinit'.
		static InstallEventResponseCommand()
		{
			Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.commands", "InstallEventResponseCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr);
			InstallEventResponseCommand.NativeFieldInfoPtr_cer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr, "cer");
			InstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr, 100667181);
			InstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_InstallEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr, 100667182);
			InstallEventResponseCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr, 100667183);
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00075000 File Offset: 0x00073200
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 495009, RefRangeEnd = 495046, XrefRangeStart = 495009, XrefRangeEnd = 495046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstallEventResponseCommand(ClientEventResponse cer)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x0007504C File Offset: 0x0007324C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880433, XrefRangeEnd = 880436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstallEventResponseCommand(InstallEventResponse action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand.NativeMethodInfoPtr__ctor_Public_Void_InstallEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00075098 File Offset: 0x00073298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880436, XrefRangeEnd = 880441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InstallEventResponseCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x0000AA70 File Offset: 0x00008C70
		public InstallEventResponseCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x000750E4 File Offset: 0x000732E4
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x0000AA79 File Offset: 0x00008C79
		public unsafe ClientEventResponse cer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand.NativeFieldInfoPtr_cer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand.NativeFieldInfoPtr_cer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400112F RID: 4399
		private static readonly IntPtr NativeFieldInfoPtr_cer;

		// Token: 0x04001130 RID: 4400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0;

		// Token: 0x04001131 RID: 4401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_InstallEventResponse_0;

		// Token: 0x04001132 RID: 4402
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000358 RID: 856
		[ObfuscatedName("dwd.core.eventTriggers.commands.InstallEventResponseCommand+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x0600273E RID: 10046 RVA: 0x000A6B68 File Offset: 0x000A4D68
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InstallEventResponseCommand>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr);
				InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>1__state");
				InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>2__current");
				InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, "<>4__this");
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667184);
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667185);
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667186);
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667187);
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667188);
				InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr, 100667189);
			}

			// Token: 0x0600273F RID: 10047 RVA: 0x000A6C48 File Offset: 0x000A4E48
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstallEventResponseCommand._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002740 RID: 10048 RVA: 0x000A6C90 File Offset: 0x000A4E90
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002741 RID: 10049 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880425, XrefRangeEnd = 880428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000B1B RID: 2843
			// (get) Token: 0x06002742 RID: 10050 RVA: 0x000A6D00 File Offset: 0x000A4F00
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002743 RID: 10051 RVA: 0x000A6D40 File Offset: 0x000A4F40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 880428, XrefRangeEnd = 880433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000B1C RID: 2844
			// (get) Token: 0x06002744 RID: 10052 RVA: 0x000A6D74 File Offset: 0x000A4F74
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponseCommand._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002745 RID: 10053 RVA: 0x00011D54 File Offset: 0x0000FF54
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000B18 RID: 2840
			// (get) Token: 0x06002746 RID: 10054 RVA: 0x000A6DB4 File Offset: 0x000A4FB4
			// (set) Token: 0x06002747 RID: 10055 RVA: 0x00011D5D File Offset: 0x0000FF5D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000B19 RID: 2841
			// (get) Token: 0x06002748 RID: 10056 RVA: 0x000A6DDC File Offset: 0x000A4FDC
			// (set) Token: 0x06002749 RID: 10057 RVA: 0x00011D78 File Offset: 0x0000FF78
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000B1A RID: 2842
			// (get) Token: 0x0600274A RID: 10058 RVA: 0x000A6E0C File Offset: 0x000A500C
			// (set) Token: 0x0600274B RID: 10059 RVA: 0x00011D97 File Offset: 0x0000FF97
			public unsafe InstallEventResponseCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InstallEventResponseCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponseCommand._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001AAB RID: 6827
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001AAC RID: 6828
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001AAD RID: 6829
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001AAE RID: 6830
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001AAF RID: 6831
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB0 RID: 6832
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001AB1 RID: 6833
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001AB2 RID: 6834
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001AB3 RID: 6835
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
