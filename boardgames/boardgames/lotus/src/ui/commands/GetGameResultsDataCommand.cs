using System;
using boardgames.ui.commands;
using Canis.utils.ids;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace lotus.src.ui.commands
{
	// Token: 0x020000EE RID: 238
	public class GetGameResultsDataCommand : IGetGameResultsDataCommand
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00035DBC File Offset: 0x00033FBC
		// Note: this type is marked as 'beforefieldinit'.
		static GetGameResultsDataCommand()
		{
			Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus.src.ui.commands", "GetGameResultsDataCommand");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr);
			GetGameResultsDataCommand.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, "gameID");
			GetGameResultsDataCommand.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, 100665133);
			GetGameResultsDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, 100665134);
			GetGameResultsDataCommand.NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, 100665135);
			GetGameResultsDataCommand.NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, 100665136);
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x00035E50 File Offset: 0x00034050
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 994811, RefRangeEnd = 994813, XrefRangeStart = 994809, XrefRangeEnd = 994811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetGameResultsDataCommand(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x00035E9C File Offset: 0x0003409C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994813, XrefRangeEnd = 994818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetGameResultsDataCommand.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00035EE8 File Offset: 0x000340E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994818, XrefRangeEnd = 994822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DBGGameResults GetResults()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GetGameResultsDataCommand.NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DBGGameResults>(intPtr3) : null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00035F34 File Offset: 0x00034134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994822, XrefRangeEnd = 994825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__2_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand.NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00007416 File Offset: 0x00005616
		public GetGameResultsDataCommand(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000B8D RID: 2957 RVA: 0x00035F78 File Offset: 0x00034178
		// (set) Token: 0x06000B8E RID: 2958 RVA: 0x0000741F File Offset: 0x0000561F
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000721 RID: 1825
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04000722 RID: 1826
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x04000723 RID: 1827
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000724 RID: 1828
		private static readonly IntPtr NativeMethodInfoPtr_GetResults_Public_Virtual_DBGGameResults_0;

		// Token: 0x04000725 RID: 1829
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x02000244 RID: 580
		[ObfuscatedName("lotus.src.ui.commands.GetGameResultsDataCommand+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001AD9 RID: 6873 RVA: 0x00063FE0 File Offset: 0x000621E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr);
				GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr, "<>9");
				GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr, "<>9__2_0");
				GetGameResultsDataCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr, 100665138);
				GetGameResultsDataCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr, 100665139);
			}

			// Token: 0x06001ADA RID: 6874 RVA: 0x0006405C File Offset: 0x0006225C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommand.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001ADB RID: 6875 RVA: 0x00064098 File Offset: 0x00062298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994737, XrefRangeEnd = 994745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand.__c.NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001ADC RID: 6876 RVA: 0x0000E99F File Offset: 0x0000CB9F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E1 RID: 2017
			// (get) Token: 0x06001ADD RID: 6877 RVA: 0x000640DC File Offset: 0x000622DC
			// (set) Token: 0x06001ADE RID: 6878 RVA: 0x0000E9A8 File Offset: 0x0000CBA8
			public unsafe static GetGameResultsDataCommand.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetGameResultsDataCommand.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E2 RID: 2018
			// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00064104 File Offset: 0x00062304
			// (set) Token: 0x06001AE0 RID: 6880 RVA: 0x0000E9BA File Offset: 0x0000CBBA
			public unsafe static Action<UnityWebRequest> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GetGameResultsDataCommand.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400103B RID: 4155
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400103C RID: 4156
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400103D RID: 4157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400103E RID: 4158
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x02000245 RID: 581
		[ObfuscatedName("lotus.src.ui.commands.GetGameResultsDataCommand+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x06001AE1 RID: 6881 RVA: 0x0006412C File Offset: 0x0006232C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GetGameResultsDataCommand>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr);
				GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, "<>1__state");
				GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, "<>2__current");
				GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, "<>4__this");
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665140);
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665141);
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665142);
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665143);
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665144);
				GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr, 100665145);
			}

			// Token: 0x06001AE2 RID: 6882 RVA: 0x0006420C File Offset: 0x0006240C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetGameResultsDataCommand._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001AE3 RID: 6883 RVA: 0x00064254 File Offset: 0x00062454
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001AE4 RID: 6884 RVA: 0x00064288 File Offset: 0x00062488
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994745, XrefRangeEnd = 994804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170007E6 RID: 2022
			// (get) Token: 0x06001AE5 RID: 6885 RVA: 0x000642C4 File Offset: 0x000624C4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AE6 RID: 6886 RVA: 0x00064304 File Offset: 0x00062504
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994804, XrefRangeEnd = 994809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170007E7 RID: 2023
			// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x00064338 File Offset: 0x00062538
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetGameResultsDataCommand._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001AE8 RID: 6888 RVA: 0x0000E9CC File Offset: 0x0000CBCC
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170007E3 RID: 2019
			// (get) Token: 0x06001AE9 RID: 6889 RVA: 0x00064378 File Offset: 0x00062578
			// (set) Token: 0x06001AEA RID: 6890 RVA: 0x0000E9D5 File Offset: 0x0000CBD5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170007E4 RID: 2020
			// (get) Token: 0x06001AEB RID: 6891 RVA: 0x000643A0 File Offset: 0x000625A0
			// (set) Token: 0x06001AEC RID: 6892 RVA: 0x0000E9F0 File Offset: 0x0000CBF0
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170007E5 RID: 2021
			// (get) Token: 0x06001AED RID: 6893 RVA: 0x000643D0 File Offset: 0x000625D0
			// (set) Token: 0x06001AEE RID: 6894 RVA: 0x0000EA0F File Offset: 0x0000CC0F
			public unsafe GetGameResultsDataCommand __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetGameResultsDataCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GetGameResultsDataCommand._execute_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400103F RID: 4159
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001040 RID: 4160
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001041 RID: 4161
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001042 RID: 4162
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001043 RID: 4163
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001044 RID: 4164
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001045 RID: 4165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001046 RID: 4166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001047 RID: 4167
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
