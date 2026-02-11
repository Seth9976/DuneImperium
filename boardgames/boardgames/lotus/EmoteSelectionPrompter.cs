using System;
using dwd.core.ui.prompt;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000B1 RID: 177
	public class EmoteSelectionPrompter : MonoBehaviour
	{
		// Token: 0x060008F6 RID: 2294 RVA: 0x0002D5B4 File Offset: 0x0002B7B4
		// Note: this type is marked as 'beforefieldinit'.
		static EmoteSelectionPrompter()
		{
			Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "EmoteSelectionPrompter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr);
			EmoteSelectionPrompter.NativeFieldInfoPtr_playerView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "playerView");
			EmoteSelectionPrompter.NativeFieldInfoPtr_prompter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "prompter");
			EmoteSelectionPrompter.NativeFieldInfoPtr_chatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "chatProvider");
			EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageCommandVisualizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "chatMessageCommandVisualizer");
			EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageThrottler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "chatMessageThrottler");
			EmoteSelectionPrompter.NativeFieldInfoPtr_emoteSelectPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "emoteSelectPrompt");
			EmoteSelectionPrompter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664695);
			EmoteSelectionPrompter.NativeMethodInfoPtr_Event_RunEmoteSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664696);
			EmoteSelectionPrompter.NativeMethodInfoPtr_Event_HideEmoteSelection_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664697);
			EmoteSelectionPrompter.NativeMethodInfoPtr_runEmoteSelection_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664698);
			EmoteSelectionPrompter.NativeMethodInfoPtr_DelayedSendChatMessage_Private_IEnumerator_ClientChatMessage_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664699);
			EmoteSelectionPrompter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, 100664700);
		}

		// Token: 0x060008F7 RID: 2295 RVA: 0x0002D6D4 File Offset: 0x0002B8D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992084, XrefRangeEnd = 992096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F8 RID: 2296 RVA: 0x0002D708 File Offset: 0x0002B908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992096, XrefRangeEnd = 992102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_RunEmoteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr_Event_RunEmoteSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0002D73C File Offset: 0x0002B93C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992102, XrefRangeEnd = 992103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_HideEmoteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr_Event_HideEmoteSelection_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0002D770 File Offset: 0x0002B970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992103, XrefRangeEnd = 992108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator runEmoteSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr_runEmoteSelection_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008FB RID: 2299 RVA: 0x0002D7B0 File Offset: 0x0002B9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992108, XrefRangeEnd = 992114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DelayedSendChatMessage(ClientChatMessage message, float delay)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr_DelayedSendChatMessage_Private_IEnumerator_ClientChatMessage_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0002D810 File Offset: 0x0002BA10
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmoteSelectionPrompter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008FD RID: 2301 RVA: 0x00006203 File Offset: 0x00004403
		public EmoteSelectionPrompter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0002D84C File Offset: 0x0002BA4C
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0000620C File Offset: 0x0000440C
		public unsafe EntityView playerView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_playerView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_playerView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0002D87C File Offset: 0x0002BA7C
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0000622B File Offset: 0x0000442B
		public unsafe GenericPrompter prompter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_prompter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericPrompter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_prompter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0002D8AC File Offset: 0x0002BAAC
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0000624A File Offset: 0x0000444A
		public unsafe ChatProvider chatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0002D8DC File Offset: 0x0002BADC
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00006269 File Offset: 0x00004469
		public unsafe IChatMessageCommandVisualizer chatMessageCommandVisualizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageCommandVisualizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChatMessageCommandVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageCommandVisualizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0002D90C File Offset: 0x0002BB0C
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00006288 File Offset: 0x00004488
		public unsafe IChatMessageThrottler chatMessageThrottler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageThrottler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChatMessageThrottler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_chatMessageThrottler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0002D93C File Offset: 0x0002BB3C
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x000062A7 File Offset: 0x000044A7
		public unsafe EmoteSelectPrompt emoteSelectPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_emoteSelectPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmoteSelectPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter.NativeFieldInfoPtr_emoteSelectPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_playerView;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_prompter;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_chatProvider;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeFieldInfoPtr_chatMessageCommandVisualizer;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeFieldInfoPtr_chatMessageThrottler;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeFieldInfoPtr_emoteSelectPrompt;

		// Token: 0x04000585 RID: 1413
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04000586 RID: 1414
		private static readonly IntPtr NativeMethodInfoPtr_Event_RunEmoteSelection_Public_Void_0;

		// Token: 0x04000587 RID: 1415
		private static readonly IntPtr NativeMethodInfoPtr_Event_HideEmoteSelection_Public_Void_0;

		// Token: 0x04000588 RID: 1416
		private static readonly IntPtr NativeMethodInfoPtr_runEmoteSelection_Private_IEnumerator_0;

		// Token: 0x04000589 RID: 1417
		private static readonly IntPtr NativeMethodInfoPtr_DelayedSendChatMessage_Private_IEnumerator_ClientChatMessage_Single_0;

		// Token: 0x0400058A RID: 1418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000220 RID: 544
		[ObfuscatedName("lotus.EmoteSelectionPrompter+<DelayedSendChatMessage>d__10")]
		public sealed class _DelayedSendChatMessage_d__10 : global::Il2CppSystem.Object
		{
			// Token: 0x060018FD RID: 6397 RVA: 0x0005E82C File Offset: 0x0005CA2C
			// Note: this type is marked as 'beforefieldinit'.
			static _DelayedSendChatMessage_d__10()
			{
				Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "<DelayedSendChatMessage>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, "<>1__state");
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, "<>2__current");
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, "delay");
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, "<>4__this");
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, "message");
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664701);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664702);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664703);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664704);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664705);
				EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr, 100664706);
			}

			// Token: 0x060018FE RID: 6398 RVA: 0x0005E934 File Offset: 0x0005CB34
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DelayedSendChatMessage_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmoteSelectionPrompter._DelayedSendChatMessage_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060018FF RID: 6399 RVA: 0x0005E97C File Offset: 0x0005CB7C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001900 RID: 6400 RVA: 0x0005E9B0 File Offset: 0x0005CBB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992012, XrefRangeEnd = 992017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700073F RID: 1855
			// (get) Token: 0x06001901 RID: 6401 RVA: 0x0005E9EC File Offset: 0x0005CBEC
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001902 RID: 6402 RVA: 0x0005EA2C File Offset: 0x0005CC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992017, XrefRangeEnd = 992022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000740 RID: 1856
			// (get) Token: 0x06001903 RID: 6403 RVA: 0x0005EA60 File Offset: 0x0005CC60
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001904 RID: 6404 RVA: 0x0000DA49 File Offset: 0x0000BC49
			public _DelayedSendChatMessage_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700073A RID: 1850
			// (get) Token: 0x06001905 RID: 6405 RVA: 0x0005EAA0 File Offset: 0x0005CCA0
			// (set) Token: 0x06001906 RID: 6406 RVA: 0x0000DA52 File Offset: 0x0000BC52
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700073B RID: 1851
			// (get) Token: 0x06001907 RID: 6407 RVA: 0x0005EAC8 File Offset: 0x0005CCC8
			// (set) Token: 0x06001908 RID: 6408 RVA: 0x0000DA6D File Offset: 0x0000BC6D
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073C RID: 1852
			// (get) Token: 0x06001909 RID: 6409 RVA: 0x0005EAF8 File Offset: 0x0005CCF8
			// (set) Token: 0x0600190A RID: 6410 RVA: 0x0000DA8C File Offset: 0x0000BC8C
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x1700073D RID: 1853
			// (get) Token: 0x0600190B RID: 6411 RVA: 0x0005EB20 File Offset: 0x0005CD20
			// (set) Token: 0x0600190C RID: 6412 RVA: 0x0000DAA7 File Offset: 0x0000BCA7
			public unsafe EmoteSelectionPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmoteSelectionPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700073E RID: 1854
			// (get) Token: 0x0600190D RID: 6413 RVA: 0x0005EB50 File Offset: 0x0005CD50
			// (set) Token: 0x0600190E RID: 6414 RVA: 0x0000DAC6 File Offset: 0x0000BCC6
			public unsafe ClientChatMessage message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._DelayedSendChatMessage_d__10.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F22 RID: 3874
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F23 RID: 3875
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F24 RID: 3876
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04000F25 RID: 3877
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F26 RID: 3878
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04000F27 RID: 3879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F28 RID: 3880
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F29 RID: 3881
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F2A RID: 3882
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F2B RID: 3883
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F2C RID: 3884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000221 RID: 545
		[ObfuscatedName("lotus.EmoteSelectionPrompter+<runEmoteSelection>d__9")]
		public sealed class _runEmoteSelection_d__9 : global::Il2CppSystem.Object
		{
			// Token: 0x0600190F RID: 6415 RVA: 0x0005EB80 File Offset: 0x0005CD80
			// Note: this type is marked as 'beforefieldinit'.
			static _runEmoteSelection_d__9()
			{
				Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EmoteSelectionPrompter>.NativeClassPtr, "<runEmoteSelection>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, "<>1__state");
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, "<>2__current");
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, "<>4__this");
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664707);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664708);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664709);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664710);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664711);
				EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr, 100664712);
			}

			// Token: 0x06001910 RID: 6416 RVA: 0x0005EC60 File Offset: 0x0005CE60
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _runEmoteSelection_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmoteSelectionPrompter._runEmoteSelection_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001911 RID: 6417 RVA: 0x0005ECA8 File Offset: 0x0005CEA8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001912 RID: 6418 RVA: 0x0005ECDC File Offset: 0x0005CEDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992022, XrefRangeEnd = 992079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000744 RID: 1860
			// (get) Token: 0x06001913 RID: 6419 RVA: 0x0005ED18 File Offset: 0x0005CF18
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001914 RID: 6420 RVA: 0x0005ED58 File Offset: 0x0005CF58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992079, XrefRangeEnd = 992084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06001915 RID: 6421 RVA: 0x0005ED8C File Offset: 0x0005CF8C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001916 RID: 6422 RVA: 0x0000DAE5 File Offset: 0x0000BCE5
			public _runEmoteSelection_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000741 RID: 1857
			// (get) Token: 0x06001917 RID: 6423 RVA: 0x0005EDCC File Offset: 0x0005CFCC
			// (set) Token: 0x06001918 RID: 6424 RVA: 0x0000DAEE File Offset: 0x0000BCEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000742 RID: 1858
			// (get) Token: 0x06001919 RID: 6425 RVA: 0x0005EDF4 File Offset: 0x0005CFF4
			// (set) Token: 0x0600191A RID: 6426 RVA: 0x0000DB09 File Offset: 0x0000BD09
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000743 RID: 1859
			// (get) Token: 0x0600191B RID: 6427 RVA: 0x0005EE24 File Offset: 0x0005D024
			// (set) Token: 0x0600191C RID: 6428 RVA: 0x0000DB28 File Offset: 0x0000BD28
			public unsafe EmoteSelectionPrompter __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EmoteSelectionPrompter>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EmoteSelectionPrompter._runEmoteSelection_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F2D RID: 3885
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F2E RID: 3886
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F2F RID: 3887
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F30 RID: 3888
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F31 RID: 3889
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F32 RID: 3890
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F33 RID: 3891
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F34 RID: 3892
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F35 RID: 3893
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
