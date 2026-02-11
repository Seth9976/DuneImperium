using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using dwd.core.ui.prompt.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.commands
{
	// Token: 0x02000290 RID: 656
	public class PlayMatchCommand : FailableCommand
	{
		// Token: 0x06001ED8 RID: 7896 RVA: 0x0008464C File Offset: 0x0008284C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayMatchCommand()
		{
			Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "PlayMatchCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr);
			PlayMatchCommand.NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668409);
			PlayMatchCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668410);
			PlayMatchCommand.NativeMethodInfoPtr_AreEntitiesInitialized_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668411);
			PlayMatchCommand.NativeMethodInfoPtr_establishMatchContext_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668412);
			PlayMatchCommand.NativeMethodInfoPtr_setupSessionRelay_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668413);
			PlayMatchCommand.NativeMethodInfoPtr_createGameData_Protected_Abstract_Virtual_New_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668414);
			PlayMatchCommand.NativeMethodInfoPtr_createSpinnerData_Protected_Abstract_Virtual_New_List_1_DataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668415);
			PlayMatchCommand.NativeMethodInfoPtr_handleLoadTimeout_Protected_Abstract_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668416);
			PlayMatchCommand.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, 100668417);
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00084730 File Offset: 0x00082930
		public unsafe virtual GameID GameID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0008477C File Offset: 0x0008297C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540199, XrefRangeEnd = 540204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EDB RID: 7899 RVA: 0x000847C8 File Offset: 0x000829C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 540207, RefRangeEnd = 540210, XrefRangeStart = 540204, XrefRangeEnd = 540207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AreEntitiesInitialized()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand.NativeMethodInfoPtr_AreEntitiesInitialized_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x000847F8 File Offset: 0x000829F8
		[CallerCount(0)]
		public unsafe virtual IEnumerator establishMatchContext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_establishMatchContext_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EDD RID: 7901 RVA: 0x00084844 File Offset: 0x00082A44
		[CallerCount(0)]
		public unsafe virtual IEnumerator setupSessionRelay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_setupSessionRelay_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x00084890 File Offset: 0x00082A90
		[CallerCount(0)]
		public unsafe virtual DataComposition createGameData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_createGameData_Protected_Abstract_Virtual_New_DataComposition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}

		// Token: 0x06001EDF RID: 7903 RVA: 0x000848DC File Offset: 0x00082ADC
		[CallerCount(0)]
		public unsafe virtual List<DataComponent> createSpinnerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_createSpinnerData_Protected_Abstract_Virtual_New_List_1_DataComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DataComponent>>(intPtr3) : null;
		}

		// Token: 0x06001EE0 RID: 7904 RVA: 0x00084928 File Offset: 0x00082B28
		[CallerCount(0)]
		public unsafe virtual IEnumerator handleLoadTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayMatchCommand.NativeMethodInfoPtr_handleLoadTimeout_Protected_Abstract_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00084974 File Offset: 0x00082B74
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498677, XrefRangeEnd = 498693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayMatchCommand()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x000103FF File Offset: 0x0000E5FF
		public PlayMatchCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400137C RID: 4988
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Public_Abstract_Virtual_New_get_GameID_0;

		// Token: 0x0400137D RID: 4989
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0400137E RID: 4990
		private static readonly IntPtr NativeMethodInfoPtr_AreEntitiesInitialized_Private_Static_Boolean_0;

		// Token: 0x0400137F RID: 4991
		private static readonly IntPtr NativeMethodInfoPtr_establishMatchContext_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04001380 RID: 4992
		private static readonly IntPtr NativeMethodInfoPtr_setupSessionRelay_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04001381 RID: 4993
		private static readonly IntPtr NativeMethodInfoPtr_createGameData_Protected_Abstract_Virtual_New_DataComposition_0;

		// Token: 0x04001382 RID: 4994
		private static readonly IntPtr NativeMethodInfoPtr_createSpinnerData_Protected_Abstract_Virtual_New_List_1_DataComponent_0;

		// Token: 0x04001383 RID: 4995
		private static readonly IntPtr NativeMethodInfoPtr_handleLoadTimeout_Protected_Abstract_Virtual_New_IEnumerator_0;

		// Token: 0x04001384 RID: 4996
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000489 RID: 1161
		[ObfuscatedName("boardgames.match.commands.PlayMatchCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060036F9 RID: 14073 RVA: 0x000CCBC0 File Offset: 0x000CADC0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayMatchCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr);
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__fadeSpinner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<fadeSpinner>5__2");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__showSpinner_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<showSpinner>5__3");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__messageConsumer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<messageConsumer>5__4");
				PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__waitStartTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, "<waitStartTime>5__5");
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668418);
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668419);
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668420);
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668421);
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668422);
				PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr, 100668423);
			}

			// Token: 0x060036FA RID: 14074 RVA: 0x000CCCF0 File Offset: 0x000CAEF0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayMatchCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060036FB RID: 14075 RVA: 0x000CCD38 File Offset: 0x000CAF38
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060036FC RID: 14076 RVA: 0x000CCD6C File Offset: 0x000CAF6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540097, XrefRangeEnd = 540194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17001034 RID: 4148
			// (get) Token: 0x060036FD RID: 14077 RVA: 0x000CCDA8 File Offset: 0x000CAFA8
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060036FE RID: 14078 RVA: 0x000CCDE8 File Offset: 0x000CAFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 540194, XrefRangeEnd = 540199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001035 RID: 4149
			// (get) Token: 0x060036FF RID: 14079 RVA: 0x000CCE1C File Offset: 0x000CB01C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayMatchCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003700 RID: 14080 RVA: 0x0001C473 File Offset: 0x0001A673
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700102D RID: 4141
			// (get) Token: 0x06003701 RID: 14081 RVA: 0x000CCE5C File Offset: 0x000CB05C
			// (set) Token: 0x06003702 RID: 14082 RVA: 0x0001C47C File Offset: 0x0001A67C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700102E RID: 4142
			// (get) Token: 0x06003703 RID: 14083 RVA: 0x000CCE84 File Offset: 0x000CB084
			// (set) Token: 0x06003704 RID: 14084 RVA: 0x0001C497 File Offset: 0x0001A697
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700102F RID: 4143
			// (get) Token: 0x06003705 RID: 14085 RVA: 0x000CCEB4 File Offset: 0x000CB0B4
			// (set) Token: 0x06003706 RID: 14086 RVA: 0x0001C4B6 File Offset: 0x0001A6B6
			public unsafe PlayMatchCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayMatchCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001030 RID: 4144
			// (get) Token: 0x06003707 RID: 14087 RVA: 0x000CCEE4 File Offset: 0x000CB0E4
			// (set) Token: 0x06003708 RID: 14088 RVA: 0x0001C4D5 File Offset: 0x0001A6D5
			public unsafe FlavoredSpinner _fadeSpinner_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__fadeSpinner_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FlavoredSpinner>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__fadeSpinner_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001031 RID: 4145
			// (get) Token: 0x06003709 RID: 14089 RVA: 0x000CCF14 File Offset: 0x000CB114
			// (set) Token: 0x0600370A RID: 14090 RVA: 0x0001C4F4 File Offset: 0x0001A6F4
			public unsafe DisplayGenericPrompt _showSpinner_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__showSpinner_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayGenericPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__showSpinner_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001032 RID: 4146
			// (get) Token: 0x0600370B RID: 14091 RVA: 0x000CCF44 File Offset: 0x000CB144
			// (set) Token: 0x0600370C RID: 14092 RVA: 0x0001C513 File Offset: 0x0001A713
			public unsafe DBGMatchMessageConsumer _messageConsumer_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__messageConsumer_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGMatchMessageConsumer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__messageConsumer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001033 RID: 4147
			// (get) Token: 0x0600370D RID: 14093 RVA: 0x000CCF74 File Offset: 0x000CB174
			// (set) Token: 0x0600370E RID: 14094 RVA: 0x0001C532 File Offset: 0x0001A732
			public unsafe float _waitStartTime_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__waitStartTime_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayMatchCommand._execute_d__2.NativeFieldInfoPtr__waitStartTime_5__5)) = value;
				}
			}

			// Token: 0x040021D3 RID: 8659
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040021D4 RID: 8660
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040021D5 RID: 8661
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040021D6 RID: 8662
			private static readonly IntPtr NativeFieldInfoPtr__fadeSpinner_5__2;

			// Token: 0x040021D7 RID: 8663
			private static readonly IntPtr NativeFieldInfoPtr__showSpinner_5__3;

			// Token: 0x040021D8 RID: 8664
			private static readonly IntPtr NativeFieldInfoPtr__messageConsumer_5__4;

			// Token: 0x040021D9 RID: 8665
			private static readonly IntPtr NativeFieldInfoPtr__waitStartTime_5__5;

			// Token: 0x040021DA RID: 8666
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040021DB RID: 8667
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021DC RID: 8668
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040021DD RID: 8669
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040021DE RID: 8670
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040021DF RID: 8671
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
