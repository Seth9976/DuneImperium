using System;
using Canis.utils.ids;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.menus.commands
{
	// Token: 0x0200023D RID: 573
	public class RunUpdateLobbyGamePlayerMetadata : Command
	{
		// Token: 0x060019DA RID: 6618 RVA: 0x00071A68 File Offset: 0x0006FC68
		// Note: this type is marked as 'beforefieldinit'.
		static RunUpdateLobbyGamePlayerMetadata()
		{
			Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "RunUpdateLobbyGamePlayerMetadata");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr);
			RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_gameID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr, "gameID");
			RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_metadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr, "metadata");
			RunUpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr, 100667401);
			RunUpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr, 100667402);
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00071AE8 File Offset: 0x0006FCE8
		[CallerCount(17)]
		[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495165, XrefRangeEnd = 495182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunUpdateLobbyGamePlayerMetadata(GameID gameID, Dictionary<string, string> metadata)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00071B48 File Offset: 0x0006FD48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530886, XrefRangeEnd = 530891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunUpdateLobbyGamePlayerMetadata.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0000E267 File Offset: 0x0000C467
		public RunUpdateLobbyGamePlayerMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x00071B94 File Offset: 0x0006FD94
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0000E270 File Offset: 0x0000C470
		public unsafe GameID gameID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_gameID);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_gameID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x00071BC4 File Offset: 0x0006FDC4
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0000E28F File Offset: 0x0000C48F
		public unsafe Dictionary<string, string> metadata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_metadata);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata.NativeFieldInfoPtr_metadata), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeFieldInfoPtr_gameID;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_metadata;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameID_Dictionary_2_String_String_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200042B RID: 1067
		[ObfuscatedName("boardgames.menus.commands.RunUpdateLobbyGamePlayerMetadata+<execute>d__3")]
		public sealed class _execute_d__3 : Object
		{
			// Token: 0x06003272 RID: 12914 RVA: 0x000BF0B8 File Offset: 0x000BD2B8
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__3()
			{
				Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata>.NativeClassPtr, "<execute>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, "<>1__state");
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, "<>2__current");
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, "<>4__this");
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667403);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667404);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667405);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667406);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667407);
				RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr, 100667408);
			}

			// Token: 0x06003273 RID: 12915 RVA: 0x000BF198 File Offset: 0x000BD398
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunUpdateLobbyGamePlayerMetadata._execute_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06003274 RID: 12916 RVA: 0x000BF1E0 File Offset: 0x000BD3E0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003275 RID: 12917 RVA: 0x000BF214 File Offset: 0x000BD414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530865, XrefRangeEnd = 530881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000EB2 RID: 3762
			// (get) Token: 0x06003276 RID: 12918 RVA: 0x000BF250 File Offset: 0x000BD450
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003277 RID: 12919 RVA: 0x000BF290 File Offset: 0x000BD490
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530881, XrefRangeEnd = 530886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000EB3 RID: 3763
			// (get) Token: 0x06003278 RID: 12920 RVA: 0x000BF2C4 File Offset: 0x000BD4C4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06003279 RID: 12921 RVA: 0x0001A0E1 File Offset: 0x000182E1
			public _execute_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x0600327A RID: 12922 RVA: 0x000BF304 File Offset: 0x000BD504
			// (set) Token: 0x0600327B RID: 12923 RVA: 0x0001A0EA File Offset: 0x000182EA
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x0600327C RID: 12924 RVA: 0x000BF32C File Offset: 0x000BD52C
			// (set) Token: 0x0600327D RID: 12925 RVA: 0x0001A105 File Offset: 0x00018305
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x0600327E RID: 12926 RVA: 0x000BF35C File Offset: 0x000BD55C
			// (set) Token: 0x0600327F RID: 12927 RVA: 0x0001A124 File Offset: 0x00018324
			public unsafe RunUpdateLobbyGamePlayerMetadata __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunUpdateLobbyGamePlayerMetadata>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunUpdateLobbyGamePlayerMetadata._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F27 RID: 7975
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F28 RID: 7976
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F29 RID: 7977
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F2A RID: 7978
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F2B RID: 7979
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F2C RID: 7980
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F2D RID: 7981
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F2E RID: 7982
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F2F RID: 7983
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
