using System;
using Canis.actions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Canis.gameLogs
{
	// Token: 0x020000A3 RID: 163
	public class GameLogManager : Object
	{
		// Token: 0x060007E5 RID: 2021 RVA: 0x00039504 File Offset: 0x00037704
		// Note: this type is marked as 'beforefieldinit'.
		static GameLogManager()
		{
			Il2CppClassPointerStore<GameLogManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "GameLogManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr);
			GameLogManager.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "logger");
			GameLogManager.NativeFieldInfoPtr_Match = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "Match");
			GameLogManager.NativeMethodInfoPtr__ctor_Protected_Void_Match_IHasGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100664896);
			GameLogManager.NativeMethodInfoPtr_Make_Public_Static_GameLogManager_TMatchWithGameLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100664897);
			GameLogManager.NativeMethodInfoPtr_Log_Public_Virtual_New_Action_GameLogBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100664898);
			GameLogManager.NativeMethodInfoPtr_Update_Public_Virtual_New_Action_Int32_Func_2_SerializedGameLog_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, 100664899);
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x000395AC File Offset: 0x000377AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558836, XrefRangeEnd = 558839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameLogManager(Match match, IHasGameLogs logger)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.NativeMethodInfoPtr__ctor_Protected_Void_Match_IHasGameLogs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0003960C File Offset: 0x0003780C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 558847, RefRangeEnd = 558848, XrefRangeStart = 558843, XrefRangeEnd = 558847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameLogManager Make<TMatchWithGameLogs>(TMatchWithGameLogs mwgl) where TMatchWithGameLogs : Match
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TMatchWithGameLogs).IsValueType)
				{
					TMatchWithGameLogs tmatchWithGameLogs = mwgl;
					intPtr = ((tmatchWithGameLogs is string) ? IL2CPP.ManagedStringToIl2Cpp(tmatchWithGameLogs as string) : IL2CPP.Il2CppObjectBaseToPtr(tmatchWithGameLogs as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref mwgl;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameLogManager.MethodInfoStoreGeneric_Make_Public_Static_GameLogManager_TMatchWithGameLogs_0<TMatchWithGameLogs>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<GameLogManager>(intPtr4) : null;
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00039688 File Offset: 0x00037888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558848, XrefRangeEnd = 558858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action Log(GameLogBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogManager.NativeMethodInfoPtr_Log_Public_Virtual_New_Action_GameLogBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x000396E4 File Offset: 0x000378E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558858, XrefRangeEnd = 558868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Canis.actions.Action Update(int logID, Func<SerializedGameLog, SerializedGameLog> update)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logID;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogManager.NativeMethodInfoPtr_Update_Public_Virtual_New_Action_Int32_Func_2_SerializedGameLog_SerializedGameLog_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00005159 File Offset: 0x00003359
		public GameLogManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060007EB RID: 2027 RVA: 0x00039750 File Offset: 0x00037950
		// (set) Token: 0x060007EC RID: 2028 RVA: 0x00005162 File Offset: 0x00003362
		public unsafe IHasGameLogs logger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.NativeFieldInfoPtr_logger);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasGameLogs>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060007ED RID: 2029 RVA: 0x00039780 File Offset: 0x00037980
		// (set) Token: 0x060007EE RID: 2030 RVA: 0x00005181 File Offset: 0x00003381
		public unsafe Match Match
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.NativeFieldInfoPtr_Match);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.NativeFieldInfoPtr_Match), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeFieldInfoPtr_logger;

		// Token: 0x0400056D RID: 1389
		private static readonly IntPtr NativeFieldInfoPtr_Match;

		// Token: 0x0400056E RID: 1390
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Match_IHasGameLogs_0;

		// Token: 0x0400056F RID: 1391
		private static readonly IntPtr NativeMethodInfoPtr_Make_Public_Static_GameLogManager_TMatchWithGameLogs_0;

		// Token: 0x04000570 RID: 1392
		private static readonly IntPtr NativeMethodInfoPtr_Log_Public_Virtual_New_Action_GameLogBuilder_0;

		// Token: 0x04000571 RID: 1393
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_New_Action_Int32_Func_2_SerializedGameLog_SerializedGameLog_0;

		// Token: 0x020002E2 RID: 738
		public class AddLogAction : Canis.actions.Action
		{
			// Token: 0x06001ECF RID: 7887 RVA: 0x0008E9B8 File Offset: 0x0008CBB8
			// Note: this type is marked as 'beforefieldinit'.
			static AddLogAction()
			{
				Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "AddLogAction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr);
				GameLogManager.AddLogAction.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, "builder");
				GameLogManager.AddLogAction.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, "logger");
				GameLogManager.AddLogAction.NativeFieldInfoPtr__CreatedLog_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, "<CreatedLog>k__BackingField");
				GameLogManager.AddLogAction.NativeMethodInfoPtr_get_CreatedLog_Public_get_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, 100664900);
				GameLogManager.AddLogAction.NativeMethodInfoPtr_set_CreatedLog_Private_set_Void_SerializedGameLog_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, 100664901);
				GameLogManager.AddLogAction.NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_IHasGameLogs_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, 100664902);
				GameLogManager.AddLogAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, 100664903);
			}

			// Token: 0x17000739 RID: 1849
			// (get) Token: 0x06001ED0 RID: 7888 RVA: 0x0008EA70 File Offset: 0x0008CC70
			// (set) Token: 0x06001ED1 RID: 7889 RVA: 0x0008EAB0 File Offset: 0x0008CCB0
			public unsafe SerializedGameLog CreatedLog
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction.NativeMethodInfoPtr_get_CreatedLog_Public_get_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr3) : null;
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction.NativeMethodInfoPtr_set_CreatedLog_Private_set_Void_SerializedGameLog_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06001ED2 RID: 7890 RVA: 0x0008EAF4 File Offset: 0x0008CCF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558799, XrefRangeEnd = 558802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AddLogAction(GameLogBuilder builder, IHasGameLogs logger, Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction.NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_IHasGameLogs_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ED3 RID: 7891 RVA: 0x0008EB64 File Offset: 0x0008CD64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558802, XrefRangeEnd = 558808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Canis.actions.Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogManager.AddLogAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001ED4 RID: 7892 RVA: 0x0000ED25 File Offset: 0x0000CF25
			public AddLogAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000736 RID: 1846
			// (get) Token: 0x06001ED5 RID: 7893 RVA: 0x0008EBB0 File Offset: 0x0008CDB0
			// (set) Token: 0x06001ED6 RID: 7894 RVA: 0x0000ED2E File Offset: 0x0000CF2E
			public unsafe GameLogBuilder builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr_builder);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogBuilder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000737 RID: 1847
			// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0008EBE0 File Offset: 0x0008CDE0
			// (set) Token: 0x06001ED8 RID: 7896 RVA: 0x0000ED4D File Offset: 0x0000CF4D
			public unsafe IHasGameLogs logger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr_logger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasGameLogs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000738 RID: 1848
			// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x0008EC10 File Offset: 0x0008CE10
			// (set) Token: 0x06001EDA RID: 7898 RVA: 0x0000ED6C File Offset: 0x0000CF6C
			public unsafe SerializedGameLog _CreatedLog_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr__CreatedLog_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializedGameLog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction.NativeFieldInfoPtr__CreatedLog_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001376 RID: 4982
			private static readonly IntPtr NativeFieldInfoPtr_builder;

			// Token: 0x04001377 RID: 4983
			private static readonly IntPtr NativeFieldInfoPtr_logger;

			// Token: 0x04001378 RID: 4984
			private static readonly IntPtr NativeFieldInfoPtr__CreatedLog_k__BackingField;

			// Token: 0x04001379 RID: 4985
			private static readonly IntPtr NativeMethodInfoPtr_get_CreatedLog_Public_get_SerializedGameLog_0;

			// Token: 0x0400137A RID: 4986
			private static readonly IntPtr NativeMethodInfoPtr_set_CreatedLog_Private_set_Void_SerializedGameLog_0;

			// Token: 0x0400137B RID: 4987
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameLogBuilder_IHasGameLogs_Match_0;

			// Token: 0x0400137C RID: 4988
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x0200048A RID: 1162
			[ObfuscatedName("Canis.gameLogs.GameLogManager+AddLogAction+<execute>d__7")]
			public sealed class _execute_d__7 : Object
			{
				// Token: 0x060034BE RID: 13502 RVA: 0x000D60DC File Offset: 0x000D42DC
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__7()
				{
					Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager.AddLogAction>.NativeClassPtr, "<execute>d__7");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr);
					GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, "<>1__state");
					GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, "<>2__current");
					GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, "<>l__initialThreadId");
					GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, "<>4__this");
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664904);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664905);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664906);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664907);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664908);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664909);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664910);
					GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr, 100664911);
				}

				// Token: 0x060034BF RID: 13503 RVA: 0x000D61F8 File Offset: 0x000D43F8
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__7(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager.AddLogAction._execute_d__7>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060034C0 RID: 13504 RVA: 0x000D6240 File Offset: 0x000D4440
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034C1 RID: 13505 RVA: 0x000D6274 File Offset: 0x000D4474
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558759, XrefRangeEnd = 558792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E27 RID: 3623
				// (get) Token: 0x060034C2 RID: 13506 RVA: 0x000D62B0 File Offset: 0x000D44B0
				public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
					}
				}

				// Token: 0x060034C3 RID: 13507 RVA: 0x000D62F0 File Offset: 0x000D44F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558792, XrefRangeEnd = 558797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E28 RID: 3624
				// (get) Token: 0x060034C4 RID: 13508 RVA: 0x000D6324 File Offset: 0x000D4524
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060034C5 RID: 13509 RVA: 0x000D6364 File Offset: 0x000D4564
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558797, XrefRangeEnd = 558799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
				}

				// Token: 0x060034C6 RID: 13510 RVA: 0x000D63A4 File Offset: 0x000D45A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.AddLogAction._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x060034C7 RID: 13511 RVA: 0x000197FA File Offset: 0x000179FA
				public _execute_d__7(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E23 RID: 3619
				// (get) Token: 0x060034C8 RID: 13512 RVA: 0x000D63E4 File Offset: 0x000D45E4
				// (set) Token: 0x060034C9 RID: 13513 RVA: 0x00019803 File Offset: 0x00017A03
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E24 RID: 3620
				// (get) Token: 0x060034CA RID: 13514 RVA: 0x000D640C File Offset: 0x000D460C
				// (set) Token: 0x060034CB RID: 13515 RVA: 0x0001981E File Offset: 0x00017A1E
				public unsafe Canis.actions.Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E25 RID: 3621
				// (get) Token: 0x060034CC RID: 13516 RVA: 0x000D643C File Offset: 0x000D463C
				// (set) Token: 0x060034CD RID: 13517 RVA: 0x0001983D File Offset: 0x00017A3D
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E26 RID: 3622
				// (get) Token: 0x060034CE RID: 13518 RVA: 0x000D6464 File Offset: 0x000D4664
				// (set) Token: 0x060034CF RID: 13519 RVA: 0x00019858 File Offset: 0x00017A58
				public unsafe GameLogManager.AddLogAction __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogManager.AddLogAction>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.AddLogAction._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040020E7 RID: 8423
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040020E8 RID: 8424
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040020E9 RID: 8425
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x040020EA RID: 8426
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040020EB RID: 8427
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040020EC RID: 8428
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040020ED RID: 8429
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040020EE RID: 8430
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x040020EF RID: 8431
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040020F0 RID: 8432
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040020F1 RID: 8433
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x040020F2 RID: 8434
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x020002E3 RID: 739
		public class UpdateLogAction : Canis.actions.Action
		{
			// Token: 0x06001EDB RID: 7899 RVA: 0x0008EC40 File Offset: 0x0008CE40
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateLogAction()
			{
				Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager>.NativeClassPtr, "UpdateLogAction");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr);
				GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, "logID");
				GameLogManager.UpdateLogAction.NativeFieldInfoPtr_update = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, "update");
				GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, "logger");
				GameLogManager.UpdateLogAction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_2_SerializedGameLog_SerializedGameLog_IHasGameLogs_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, 100664912);
				GameLogManager.UpdateLogAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, 100664913);
			}

			// Token: 0x06001EDC RID: 7900 RVA: 0x0008ECD0 File Offset: 0x0008CED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558827, XrefRangeEnd = 558830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateLogAction(int logID, Func<SerializedGameLog, SerializedGameLog> update, IHasGameLogs logger, Match m)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref logID;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(update);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(logger);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction.NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_2_SerializedGameLog_SerializedGameLog_IHasGameLogs_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001EDD RID: 7901 RVA: 0x0008ED50 File Offset: 0x0008CF50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558830, XrefRangeEnd = 558836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IEnumerable<Canis.actions.Action> execute()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameLogManager.UpdateLogAction.NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Canis.actions.Action>>(intPtr3) : null;
			}

			// Token: 0x06001EDE RID: 7902 RVA: 0x0000ED8B File Offset: 0x0000CF8B
			public UpdateLogAction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0008ED9C File Offset: 0x0008CF9C
			// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0000ED94 File Offset: 0x0000CF94
			public unsafe int logID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logID);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logID)) = value;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001EE1 RID: 7905 RVA: 0x0008EDC4 File Offset: 0x0008CFC4
			// (set) Token: 0x06001EE2 RID: 7906 RVA: 0x0000EDAF File Offset: 0x0000CFAF
			public unsafe Func<SerializedGameLog, SerializedGameLog> update
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_update);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SerializedGameLog, SerializedGameLog>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_update), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x0008EDF4 File Offset: 0x0008CFF4
			// (set) Token: 0x06001EE4 RID: 7908 RVA: 0x0000EDCE File Offset: 0x0000CFCE
			public unsafe IHasGameLogs logger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logger);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IHasGameLogs>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction.NativeFieldInfoPtr_logger), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400137D RID: 4989
			private static readonly IntPtr NativeFieldInfoPtr_logID;

			// Token: 0x0400137E RID: 4990
			private static readonly IntPtr NativeFieldInfoPtr_update;

			// Token: 0x0400137F RID: 4991
			private static readonly IntPtr NativeFieldInfoPtr_logger;

			// Token: 0x04001380 RID: 4992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Func_2_SerializedGameLog_SerializedGameLog_IHasGameLogs_Match_0;

			// Token: 0x04001381 RID: 4993
			private static readonly IntPtr NativeMethodInfoPtr_execute_Public_Virtual_IEnumerable_1_Action_0;

			// Token: 0x0200048B RID: 1163
			[ObfuscatedName("Canis.gameLogs.GameLogManager+UpdateLogAction+<execute>d__4")]
			public sealed class _execute_d__4 : Object
			{
				// Token: 0x060034D0 RID: 13520 RVA: 0x000D6494 File Offset: 0x000D4694
				// Note: this type is marked as 'beforefieldinit'.
				static _execute_d__4()
				{
					Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameLogManager.UpdateLogAction>.NativeClassPtr, "<execute>d__4");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr);
					GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, "<>1__state");
					GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, "<>2__current");
					GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, "<>l__initialThreadId");
					GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, "<>4__this");
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664914);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664915);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664916);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664917);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664918);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664919);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664920);
					GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr, 100664921);
				}

				// Token: 0x060034D1 RID: 13521 RVA: 0x000D65B0 File Offset: 0x000D47B0
				[CallerCount(126)]
				[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe _execute_d__4(int <>1__state)
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameLogManager.UpdateLogAction._execute_d__4>.NativeClassPtr))
				{
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref <>1__state;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}

				// Token: 0x060034D2 RID: 13522 RVA: 0x000D65F8 File Offset: 0x000D47F8
				[CallerCount(21425)]
				[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060034D3 RID: 13523 RVA: 0x000D662C File Offset: 0x000D482C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558808, XrefRangeEnd = 558820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17000E2D RID: 3629
				// (get) Token: 0x060034D4 RID: 13524 RVA: 0x000D6668 File Offset: 0x000D4868
				public unsafe Canis.actions.Action System.Collections.Generic.IEnumerator<Canis.actions.Action>.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr3) : null;
					}
				}

				// Token: 0x060034D5 RID: 13525 RVA: 0x000D66A8 File Offset: 0x000D48A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558820, XrefRangeEnd = 558825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17000E2E RID: 3630
				// (get) Token: 0x060034D6 RID: 13526 RVA: 0x000D66DC File Offset: 0x000D48DC
				public unsafe Object System.Collections.IEnumerator.Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
					}
				}

				// Token: 0x060034D7 RID: 13527 RVA: 0x000D671C File Offset: 0x000D491C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 558825, XrefRangeEnd = 558827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator<Canis.actions.Action> System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Canis.actions.Action>>(intPtr3) : null;
				}

				// Token: 0x060034D8 RID: 13528 RVA: 0x000D675C File Offset: 0x000D495C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameLogManager.UpdateLogAction._execute_d__4.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
				}

				// Token: 0x060034D9 RID: 13529 RVA: 0x00019877 File Offset: 0x00017A77
				public _execute_d__4(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x17000E29 RID: 3625
				// (get) Token: 0x060034DA RID: 13530 RVA: 0x000D679C File Offset: 0x000D499C
				// (set) Token: 0x060034DB RID: 13531 RVA: 0x00019880 File Offset: 0x00017A80
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17000E2A RID: 3626
				// (get) Token: 0x060034DC RID: 13532 RVA: 0x000D67C4 File Offset: 0x000D49C4
				// (set) Token: 0x060034DD RID: 13533 RVA: 0x0001989B File Offset: 0x00017A9B
				public unsafe Canis.actions.Action __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canis.actions.Action>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17000E2B RID: 3627
				// (get) Token: 0x060034DE RID: 13534 RVA: 0x000D67F4 File Offset: 0x000D49F4
				// (set) Token: 0x060034DF RID: 13535 RVA: 0x000198BA File Offset: 0x00017ABA
				public unsafe int __l__initialThreadId
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___l__initialThreadId)) = value;
					}
				}

				// Token: 0x17000E2C RID: 3628
				// (get) Token: 0x060034E0 RID: 13536 RVA: 0x000D681C File Offset: 0x000D4A1C
				// (set) Token: 0x060034E1 RID: 13537 RVA: 0x000198D5 File Offset: 0x00017AD5
				public unsafe GameLogManager.UpdateLogAction __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameLogManager.UpdateLogAction>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameLogManager.UpdateLogAction._execute_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x040020F3 RID: 8435
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x040020F4 RID: 8436
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x040020F5 RID: 8437
				private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

				// Token: 0x040020F6 RID: 8438
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x040020F7 RID: 8439
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x040020F8 RID: 8440
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x040020F9 RID: 8441
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x040020FA RID: 8442
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Canis_actions_Action__get_Current_Private_Virtual_Final_New_get_Action_0;

				// Token: 0x040020FB RID: 8443
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x040020FC RID: 8444
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x040020FD RID: 8445
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Canis_actions_Action__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Action_0;

				// Token: 0x040020FE RID: 8446
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
			}
		}

		// Token: 0x020002E4 RID: 740
		private sealed class MethodInfoStoreGeneric_Make_Public_Static_GameLogManager_TMatchWithGameLogs_0<TMatchWithGameLogs>
		{
			// Token: 0x04001382 RID: 4994
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameLogManager.NativeMethodInfoPtr_Make_Public_Static_GameLogManager_TMatchWithGameLogs_0, Il2CppClassPointerStore<GameLogManager>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TMatchWithGameLogs>.NativeClassPtr)) }))));
		}
	}
}
