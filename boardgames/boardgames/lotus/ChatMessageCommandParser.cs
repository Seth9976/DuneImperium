using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000AA RID: 170
	public class ChatMessageCommandParser : MonoBehaviour
	{
		// Token: 0x06000822 RID: 2082 RVA: 0x0002AA8C File Offset: 0x00028C8C
		// Note: this type is marked as 'beforefieldinit'.
		static ChatMessageCommandParser()
		{
			Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "ChatMessageCommandParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr);
			ChatMessageCommandParser.NativeFieldInfoPtr_emoteButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, "emoteButton");
			ChatMessageCommandParser.NativeFieldInfoPtr_chatProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, "chatProvider");
			ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageCommandVisualizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, "chatMessageCommandVisualizer");
			ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, "chatMessageFilter");
			ChatMessageCommandParser.NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, 100664577);
			ChatMessageCommandParser.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, 100664578);
			ChatMessageCommandParser.NativeMethodInfoPtr_handleChatMessage_Private_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, 100664579);
			ChatMessageCommandParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, 100664580);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002AB5C File Offset: 0x00028D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991376, XrefRangeEnd = 991381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChatMessageCommandParser.NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002ABA8 File Offset: 0x00028DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991381, XrefRangeEnd = 991391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0002ABDC File Offset: 0x00028DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991391, XrefRangeEnd = 991402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void handleChatMessage(ClientChatMessage clientChatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientChatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser.NativeMethodInfoPtr_handleChatMessage_Private_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0002AC20 File Offset: 0x00028E20
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChatMessageCommandParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00005B38 File Offset: 0x00003D38
		public ChatMessageCommandParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0002AC5C File Offset: 0x00028E5C
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00005B41 File Offset: 0x00003D41
		public unsafe GameObject emoteButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_emoteButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_emoteButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x0002AC8C File Offset: 0x00028E8C
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00005B60 File Offset: 0x00003D60
		public unsafe ChatProvider chatProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0002ACBC File Offset: 0x00028EBC
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00005B7F File Offset: 0x00003D7F
		public unsafe IChatMessageCommandVisualizer chatMessageCommandVisualizer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageCommandVisualizer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChatMessageCommandVisualizer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageCommandVisualizer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x0002ACEC File Offset: 0x00028EEC
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00005B9E File Offset: 0x00003D9E
		public unsafe IChatMessageFilter chatMessageFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IChatMessageFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser.NativeFieldInfoPtr_chatMessageFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004F3 RID: 1267
		private static readonly IntPtr NativeFieldInfoPtr_emoteButton;

		// Token: 0x040004F4 RID: 1268
		private static readonly IntPtr NativeFieldInfoPtr_chatProvider;

		// Token: 0x040004F5 RID: 1269
		private static readonly IntPtr NativeFieldInfoPtr_chatMessageCommandVisualizer;

		// Token: 0x040004F6 RID: 1270
		private static readonly IntPtr NativeFieldInfoPtr_chatMessageFilter;

		// Token: 0x040004F7 RID: 1271
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_IEnumerator_0;

		// Token: 0x040004F8 RID: 1272
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040004F9 RID: 1273
		private static readonly IntPtr NativeMethodInfoPtr_handleChatMessage_Private_Void_ClientChatMessage_0;

		// Token: 0x040004FA RID: 1274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000219 RID: 537
		[ObfuscatedName("lotus.ChatMessageCommandParser+<Start>d__4")]
		public sealed class _Start_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600189D RID: 6301 RVA: 0x0005D60C File Offset: 0x0005B80C
			// Note: this type is marked as 'beforefieldinit'.
			static _Start_d__4()
			{
				Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChatMessageCommandParser>.NativeClassPtr, "<Start>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr);
				ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, "<>1__state");
				ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, "<>2__current");
				ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, "<>4__this");
				ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr__timeout_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, "<timeout>5__2");
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664581);
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664582);
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664583);
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664584);
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664585);
				ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr, 100664586);
			}

			// Token: 0x0600189E RID: 6302 RVA: 0x0005D700 File Offset: 0x0005B900
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Start_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatMessageCommandParser._Start_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600189F RID: 6303 RVA: 0x0005D748 File Offset: 0x0005B948
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060018A0 RID: 6304 RVA: 0x0005D77C File Offset: 0x0005B97C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991342, XrefRangeEnd = 991371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700071C RID: 1820
			// (get) Token: 0x060018A1 RID: 6305 RVA: 0x0005D7B8 File Offset: 0x0005B9B8
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018A2 RID: 6306 RVA: 0x0005D7F8 File Offset: 0x0005B9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991371, XrefRangeEnd = 991376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x060018A3 RID: 6307 RVA: 0x0005D82C File Offset: 0x0005BA2C
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChatMessageCommandParser._Start_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060018A4 RID: 6308 RVA: 0x0000D75C File Offset: 0x0000B95C
			public _Start_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000718 RID: 1816
			// (get) Token: 0x060018A5 RID: 6309 RVA: 0x0005D86C File Offset: 0x0005BA6C
			// (set) Token: 0x060018A6 RID: 6310 RVA: 0x0000D765 File Offset: 0x0000B965
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000719 RID: 1817
			// (get) Token: 0x060018A7 RID: 6311 RVA: 0x0005D894 File Offset: 0x0005BA94
			// (set) Token: 0x060018A8 RID: 6312 RVA: 0x0000D780 File Offset: 0x0000B980
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071A RID: 1818
			// (get) Token: 0x060018A9 RID: 6313 RVA: 0x0005D8C4 File Offset: 0x0005BAC4
			// (set) Token: 0x060018AA RID: 6314 RVA: 0x0000D79F File Offset: 0x0000B99F
			public unsafe ChatMessageCommandParser __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChatMessageCommandParser>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700071B RID: 1819
			// (get) Token: 0x060018AB RID: 6315 RVA: 0x0005D8F4 File Offset: 0x0005BAF4
			// (set) Token: 0x060018AC RID: 6316 RVA: 0x0000D7BE File Offset: 0x0000B9BE
			public unsafe float _timeout_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr__timeout_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChatMessageCommandParser._Start_d__4.NativeFieldInfoPtr__timeout_5__2)) = value;
				}
			}

			// Token: 0x04000EE8 RID: 3816
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000EE9 RID: 3817
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000EEA RID: 3818
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000EEB RID: 3819
			private static readonly IntPtr NativeFieldInfoPtr__timeout_5__2;

			// Token: 0x04000EEC RID: 3820
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000EED RID: 3821
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EEE RID: 3822
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000EEF RID: 3823
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000EF0 RID: 3824
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000EF1 RID: 3825
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
