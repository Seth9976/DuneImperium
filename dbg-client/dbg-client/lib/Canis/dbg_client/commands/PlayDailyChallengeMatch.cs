using System;
using boardgames.menus.prompts;
using dbgclient.dataProviders;
using dwd.core.commands;
using dwd.core.networking.commands;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace lib.canis.dbg_client.commands
{
	// Token: 0x0200003B RID: 59
	public class PlayDailyChallengeMatch : FailableCommand
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00025044 File Offset: 0x00023244
		// Note: this type is marked as 'beforefieldinit'.
		static PlayDailyChallengeMatch()
		{
			Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "lib.canis.dbg_client.commands", "PlayDailyChallengeMatch");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr);
			PlayDailyChallengeMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, 100663674);
			PlayDailyChallengeMatch.NativeMethodInfoPtr_getUploadHandler_Private_Static_UploadHandler_DailyChallengeProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, 100663675);
			PlayDailyChallengeMatch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, 100663676);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000250B0 File Offset: 0x000232B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498657, XrefRangeEnd = 498662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayDailyChallengeMatch.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000250FC File Offset: 0x000232FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498662, XrefRangeEnd = 498676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UploadHandler getUploadHandler(DailyChallengeProvider provider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.NativeMethodInfoPtr_getUploadHandler_Private_Static_UploadHandler_DailyChallengeProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UploadHandler>(intPtr3) : null;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00025140 File Offset: 0x00023340
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 498677, RefRangeEnd = 498693, XrefRangeStart = 498676, XrefRangeEnd = 498677, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayDailyChallengeMatch()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003022 File Offset: 0x00001222
		public PlayDailyChallengeMatch(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000170 RID: 368
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000171 RID: 369
		private static readonly IntPtr NativeMethodInfoPtr_getUploadHandler_Private_Static_UploadHandler_DailyChallengeProvider_0;

		// Token: 0x04000172 RID: 370
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020002DE RID: 734
		[ObfuscatedName("lib.canis.dbg_client.commands.PlayDailyChallengeMatch+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002281 RID: 8833 RVA: 0x0008FBD0 File Offset: 0x0008DDD0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr);
				PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr, "<>9");
				PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr, "<>9__0_0");
				PlayDailyChallengeMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr, 100663678);
				PlayDailyChallengeMatch.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr, 100663679);
			}

			// Token: 0x06002282 RID: 8834 RVA: 0x0008FC4C File Offset: 0x0008DE4C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002283 RID: 8835 RVA: 0x0008FC88 File Offset: 0x0008DE88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498330, XrefRangeEnd = 498338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.__c.NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x00011FBA File Offset: 0x000101BA
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000949 RID: 2377
			// (get) Token: 0x06002285 RID: 8837 RVA: 0x0008FCCC File Offset: 0x0008DECC
			// (set) Token: 0x06002286 RID: 8838 RVA: 0x00011FC3 File Offset: 0x000101C3
			public unsafe static PlayDailyChallengeMatch.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayDailyChallengeMatch.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094A RID: 2378
			// (get) Token: 0x06002287 RID: 8839 RVA: 0x0008FCF4 File Offset: 0x0008DEF4
			// (set) Token: 0x06002288 RID: 8840 RVA: 0x00011FD5 File Offset: 0x000101D5
			public unsafe static Action<UnityWebRequest> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayDailyChallengeMatch.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015B6 RID: 5558
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040015B7 RID: 5559
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x040015B8 RID: 5560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015B9 RID: 5561
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_0_Internal_Void_UnityWebRequest_0;
		}

		// Token: 0x020002DF RID: 735
		[ObfuscatedName("lib.canis.dbg_client.commands.PlayDailyChallengeMatch+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06002289 RID: 8841 RVA: 0x0008FD1C File Offset: 0x0008DF1C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr);
				PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr, "url");
				PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_shouldContinueGame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr, "shouldContinueGame");
				PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr, 100663680);
				PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_IFailable_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr, 100663681);
			}

			// Token: 0x0600228A RID: 8842 RVA: 0x0008FD98 File Offset: 0x0008DF98
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeMatch.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600228B RID: 8843 RVA: 0x0008FDD4 File Offset: 0x0008DFD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498338, XrefRangeEnd = 498369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IFailable _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeMethodInfoPtr__execute_b__1_Internal_IFailable_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr3) : null;
				}
			}

			// Token: 0x0600228C RID: 8844 RVA: 0x00011FE7 File Offset: 0x000101E7
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094B RID: 2379
			// (get) Token: 0x0600228D RID: 8845 RVA: 0x0008FE24 File Offset: 0x0008E024
			// (set) Token: 0x0600228E RID: 8846 RVA: 0x00011FF0 File Offset: 0x000101F0
			public unsafe string url
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_url);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_url), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700094C RID: 2380
			// (get) Token: 0x0600228F RID: 8847 RVA: 0x0008FE4C File Offset: 0x0008E04C
			// (set) Token: 0x06002290 RID: 8848 RVA: 0x0001200F File Offset: 0x0001020F
			public unsafe bool shouldContinueGame
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_shouldContinueGame);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch.__c__DisplayClass0_0.NativeFieldInfoPtr_shouldContinueGame)) = value;
				}
			}

			// Token: 0x040015BA RID: 5562
			private static readonly IntPtr NativeFieldInfoPtr_url;

			// Token: 0x040015BB RID: 5563
			private static readonly IntPtr NativeFieldInfoPtr_shouldContinueGame;

			// Token: 0x040015BC RID: 5564
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040015BD RID: 5565
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_IFailable_DwdWebRequestCommand_0;
		}

		// Token: 0x020002E0 RID: 736
		[ObfuscatedName("lib.canis.dbg_client.commands.PlayDailyChallengeMatch+<execute>d__0")]
		public sealed class _execute_d__0 : Object
		{
			// Token: 0x06002291 RID: 8849 RVA: 0x0008FE74 File Offset: 0x0008E074
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__0()
			{
				Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayDailyChallengeMatch>.NativeClassPtr, "<execute>d__0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr);
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<>1__state");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<>2__current");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<>8__1");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<>4__this");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__dailyChallengeProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<dailyChallengeProvider>5__2");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__saveIsOld_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<saveIsOld>5__3");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__warningPrompt_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<warningPrompt>5__4");
				PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__continuePrompt_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, "<continuePrompt>5__5");
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663682);
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663683);
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663684);
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663685);
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663686);
				PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr, 100663687);
			}

			// Token: 0x06002292 RID: 8850 RVA: 0x0008FFB8 File Offset: 0x0008E1B8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__0(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayDailyChallengeMatch._execute_d__0>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002293 RID: 8851 RVA: 0x00090000 File Offset: 0x0008E200
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002294 RID: 8852 RVA: 0x00090034 File Offset: 0x0008E234
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498369, XrefRangeEnd = 498652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000955 RID: 2389
			// (get) Token: 0x06002295 RID: 8853 RVA: 0x00090070 File Offset: 0x0008E270
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002296 RID: 8854 RVA: 0x000900B0 File Offset: 0x0008E2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 498652, XrefRangeEnd = 498657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000956 RID: 2390
			// (get) Token: 0x06002297 RID: 8855 RVA: 0x000900E4 File Offset: 0x0008E2E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayDailyChallengeMatch._execute_d__0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002298 RID: 8856 RVA: 0x0001202A File Offset: 0x0001022A
			public _execute_d__0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700094D RID: 2381
			// (get) Token: 0x06002299 RID: 8857 RVA: 0x00090124 File Offset: 0x0008E324
			// (set) Token: 0x0600229A RID: 8858 RVA: 0x00012033 File Offset: 0x00010233
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700094E RID: 2382
			// (get) Token: 0x0600229B RID: 8859 RVA: 0x0009014C File Offset: 0x0008E34C
			// (set) Token: 0x0600229C RID: 8860 RVA: 0x0001204E File Offset: 0x0001024E
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700094F RID: 2383
			// (get) Token: 0x0600229D RID: 8861 RVA: 0x0009017C File Offset: 0x0008E37C
			// (set) Token: 0x0600229E RID: 8862 RVA: 0x0001206D File Offset: 0x0001026D
			public unsafe PlayDailyChallengeMatch.__c__DisplayClass0_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayDailyChallengeMatch.__c__DisplayClass0_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000950 RID: 2384
			// (get) Token: 0x0600229F RID: 8863 RVA: 0x000901AC File Offset: 0x0008E3AC
			// (set) Token: 0x060022A0 RID: 8864 RVA: 0x0001208C File Offset: 0x0001028C
			public unsafe PlayDailyChallengeMatch __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayDailyChallengeMatch>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000951 RID: 2385
			// (get) Token: 0x060022A1 RID: 8865 RVA: 0x000901DC File Offset: 0x0008E3DC
			// (set) Token: 0x060022A2 RID: 8866 RVA: 0x000120AB File Offset: 0x000102AB
			public unsafe DailyChallengeProvider _dailyChallengeProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__dailyChallengeProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DailyChallengeProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__dailyChallengeProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000952 RID: 2386
			// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0009020C File Offset: 0x0008E40C
			// (set) Token: 0x060022A4 RID: 8868 RVA: 0x000120CA File Offset: 0x000102CA
			public unsafe bool _saveIsOld_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__saveIsOld_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__saveIsOld_5__3)) = value;
				}
			}

			// Token: 0x17000953 RID: 2387
			// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00090234 File Offset: 0x0008E434
			// (set) Token: 0x060022A6 RID: 8870 RVA: 0x000120E5 File Offset: 0x000102E5
			public unsafe ConfirmOrDenyPrompt _warningPrompt_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__warningPrompt_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__warningPrompt_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000954 RID: 2388
			// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00090264 File Offset: 0x0008E464
			// (set) Token: 0x060022A8 RID: 8872 RVA: 0x00012104 File Offset: 0x00010304
			public unsafe ContinueGamePrompt _continuePrompt_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__continuePrompt_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContinueGamePrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayDailyChallengeMatch._execute_d__0.NativeFieldInfoPtr__continuePrompt_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040015BE RID: 5566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040015BF RID: 5567
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040015C0 RID: 5568
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040015C1 RID: 5569
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040015C2 RID: 5570
			private static readonly IntPtr NativeFieldInfoPtr__dailyChallengeProvider_5__2;

			// Token: 0x040015C3 RID: 5571
			private static readonly IntPtr NativeFieldInfoPtr__saveIsOld_5__3;

			// Token: 0x040015C4 RID: 5572
			private static readonly IntPtr NativeFieldInfoPtr__warningPrompt_5__4;

			// Token: 0x040015C5 RID: 5573
			private static readonly IntPtr NativeFieldInfoPtr__continuePrompt_5__5;

			// Token: 0x040015C6 RID: 5574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040015C7 RID: 5575
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015C8 RID: 5576
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040015C9 RID: 5577
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040015CA RID: 5578
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040015CB RID: 5579
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
