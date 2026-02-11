using System;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace boardgames.match.commands
{
	// Token: 0x02000289 RID: 649
	public class CheckActiveInGame : FailableCommand
	{
		// Token: 0x06001E8B RID: 7819 RVA: 0x000833CC File Offset: 0x000815CC
		// Note: this type is marked as 'beforefieldinit'.
		static CheckActiveInGame()
		{
			Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.commands", "CheckActiveInGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr);
			CheckActiveInGame.NativeFieldInfoPtr__GameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, "<GameID>k__BackingField");
			CheckActiveInGame.NativeFieldInfoPtr__ActiveInGame_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, "<ActiveInGame>k__BackingField");
			CheckActiveInGame.NativeMethodInfoPtr_get_GameID_Private_get_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668294);
			CheckActiveInGame.NativeMethodInfoPtr_get_ActiveInGame_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668295);
			CheckActiveInGame.NativeMethodInfoPtr_set_ActiveInGame_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668296);
			CheckActiveInGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668297);
			CheckActiveInGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668298);
			CheckActiveInGame.NativeMethodInfoPtr__execute_b__8_1_Private_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, 100668299);
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0008349C File Offset: 0x0008169C
		public unsafe GameID GameID
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.NativeMethodInfoPtr_get_GameID_Private_get_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr3) : null;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x000834DC File Offset: 0x000816DC
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x00083518 File Offset: 0x00081718
		public unsafe bool ActiveInGame
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.NativeMethodInfoPtr_get_ActiveInGame_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.NativeMethodInfoPtr_set_ActiveInGame_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x00083558 File Offset: 0x00081758
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 539238, RefRangeEnd = 539243, XrefRangeStart = 539236, XrefRangeEnd = 539238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CheckActiveInGame(GameID gameID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.NativeMethodInfoPtr__ctor_Public_Void_GameID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x000835A4 File Offset: 0x000817A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539243, XrefRangeEnd = 539248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CheckActiveInGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x000835F0 File Offset: 0x000817F0
		[CallerCount(0)]
		public unsafe void _execute_b__8_1(DwdWebRequestCommand request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.NativeMethodInfoPtr__execute_b__8_1_Private_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x00010234 File Offset: 0x0000E434
		public CheckActiveInGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x00083634 File Offset: 0x00081834
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x0001023D File Offset: 0x0000E43D
		public unsafe GameID _GameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame.NativeFieldInfoPtr__GameID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame.NativeFieldInfoPtr__GameID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x00083664 File Offset: 0x00081864
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x0001025C File Offset: 0x0000E45C
		public unsafe bool _ActiveInGame_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame.NativeFieldInfoPtr__ActiveInGame_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame.NativeFieldInfoPtr__ActiveInGame_k__BackingField)) = value;
			}
		}

		// Token: 0x04001349 RID: 4937
		private static readonly IntPtr NativeFieldInfoPtr__GameID_k__BackingField;

		// Token: 0x0400134A RID: 4938
		private static readonly IntPtr NativeFieldInfoPtr__ActiveInGame_k__BackingField;

		// Token: 0x0400134B RID: 4939
		private static readonly IntPtr NativeMethodInfoPtr_get_GameID_Private_get_GameID_0;

		// Token: 0x0400134C RID: 4940
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveInGame_Public_get_Boolean_0;

		// Token: 0x0400134D RID: 4941
		private static readonly IntPtr NativeMethodInfoPtr_set_ActiveInGame_Private_set_Void_Boolean_0;

		// Token: 0x0400134E RID: 4942
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_0;

		// Token: 0x0400134F RID: 4943
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001350 RID: 4944
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_1_Private_Void_DwdWebRequestCommand_0;

		// Token: 0x0200047A RID: 1146
		[ObfuscatedName("boardgames.match.commands.CheckActiveInGame+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003631 RID: 13873 RVA: 0x000CA5CC File Offset: 0x000C87CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr);
				CheckActiveInGame.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr, "<>9");
				CheckActiveInGame.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr, "<>9__8_0");
				CheckActiveInGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr, 100668301);
				CheckActiveInGame.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr, 100668302);
			}

			// Token: 0x06003632 RID: 13874 RVA: 0x000CA648 File Offset: 0x000C8848
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckActiveInGame.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003633 RID: 13875 RVA: 0x000CA684 File Offset: 0x000C8884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539156, XrefRangeEnd = 539164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__8_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame.__c.NativeMethodInfoPtr__execute_b__8_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003634 RID: 13876 RVA: 0x0001BEAF File Offset: 0x0001A0AF
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FE8 RID: 4072
			// (get) Token: 0x06003635 RID: 13877 RVA: 0x000CA6C8 File Offset: 0x000C88C8
			// (set) Token: 0x06003636 RID: 13878 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
			public unsafe static CheckActiveInGame.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckActiveInGame.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckActiveInGame.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckActiveInGame.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FE9 RID: 4073
			// (get) Token: 0x06003637 RID: 13879 RVA: 0x000CA6F0 File Offset: 0x000C88F0
			// (set) Token: 0x06003638 RID: 13880 RVA: 0x0001BECA File Offset: 0x0001A0CA
			public unsafe static Action<UnityWebRequest> __9__8_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CheckActiveInGame.__c.NativeFieldInfoPtr___9__8_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CheckActiveInGame.__c.NativeFieldInfoPtr___9__8_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400215A RID: 8538
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400215B RID: 8539
			private static readonly IntPtr NativeFieldInfoPtr___9__8_0;

			// Token: 0x0400215C RID: 8540
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400215D RID: 8541
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__8_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x0200047B RID: 1147
		[ObfuscatedName("boardgames.match.commands.CheckActiveInGame+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06003639 RID: 13881 RVA: 0x000CA718 File Offset: 0x000C8918
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CheckActiveInGame>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr);
				CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, "<>1__state");
				CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, "<>2__current");
				CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, "<>4__this");
				CheckActiveInGame._execute_d__8.NativeFieldInfoPtr__webRequest_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, "<webRequest>5__2");
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668303);
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668304);
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668305);
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668306);
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668307);
				CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr, 100668308);
			}

			// Token: 0x0600363A RID: 13882 RVA: 0x000CA80C File Offset: 0x000C8A0C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheckActiveInGame._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600363B RID: 13883 RVA: 0x000CA854 File Offset: 0x000C8A54
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600363C RID: 13884 RVA: 0x000CA888 File Offset: 0x000C8A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539164, XrefRangeEnd = 539231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000FEE RID: 4078
			// (get) Token: 0x0600363D RID: 13885 RVA: 0x000CA8C4 File Offset: 0x000C8AC4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600363E RID: 13886 RVA: 0x000CA904 File Offset: 0x000C8B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 539231, XrefRangeEnd = 539236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000FEF RID: 4079
			// (get) Token: 0x0600363F RID: 13887 RVA: 0x000CA938 File Offset: 0x000C8B38
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CheckActiveInGame._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003640 RID: 13888 RVA: 0x0001BEDC File Offset: 0x0001A0DC
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000FEA RID: 4074
			// (get) Token: 0x06003641 RID: 13889 RVA: 0x000CA978 File Offset: 0x000C8B78
			// (set) Token: 0x06003642 RID: 13890 RVA: 0x0001BEE5 File Offset: 0x0001A0E5
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000FEB RID: 4075
			// (get) Token: 0x06003643 RID: 13891 RVA: 0x000CA9A0 File Offset: 0x000C8BA0
			// (set) Token: 0x06003644 RID: 13892 RVA: 0x0001BF00 File Offset: 0x0001A100
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FEC RID: 4076
			// (get) Token: 0x06003645 RID: 13893 RVA: 0x000CA9D0 File Offset: 0x000C8BD0
			// (set) Token: 0x06003646 RID: 13894 RVA: 0x0001BF1F File Offset: 0x0001A11F
			public unsafe CheckActiveInGame __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CheckActiveInGame>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000FED RID: 4077
			// (get) Token: 0x06003647 RID: 13895 RVA: 0x000CAA00 File Offset: 0x000C8C00
			// (set) Token: 0x06003648 RID: 13896 RVA: 0x0001BF3E File Offset: 0x0001A13E
			public unsafe IFailable _webRequest_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr__webRequest_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CheckActiveInGame._execute_d__8.NativeFieldInfoPtr__webRequest_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400215E RID: 8542
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400215F RID: 8543
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002160 RID: 8544
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002161 RID: 8545
			private static readonly IntPtr NativeFieldInfoPtr__webRequest_5__2;

			// Token: 0x04002162 RID: 8546
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04002163 RID: 8547
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002164 RID: 8548
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04002165 RID: 8549
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002166 RID: 8550
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002167 RID: 8551
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
