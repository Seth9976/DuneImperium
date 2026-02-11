using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace lotus
{
	// Token: 0x020000B5 RID: 181
	public class FXEmoteChatMessageCommandVisualizer : MonoBehaviour
	{
		// Token: 0x0600091C RID: 2332 RVA: 0x0002DD38 File Offset: 0x0002BF38
		// Note: this type is marked as 'beforefieldinit'.
		static FXEmoteChatMessageCommandVisualizer()
		{
			Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "FXEmoteChatMessageCommandVisualizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr);
			FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_emoteVFXAnchor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, "emoteVFXAnchor");
			FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_defaultLookupFlavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, "defaultLookupFlavors");
			FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, 100664721);
			FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleLocalChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, 100664722);
			FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_ShowEmote_Private_IEnumerator_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, 100664723);
			FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, 100664724);
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0002DDE0 File Offset: 0x0002BFE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992252, XrefRangeEnd = 992259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleIncomingChatMessage(ClientChatMessage clientChatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientChatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x0002DE24 File Offset: 0x0002C024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992259, XrefRangeEnd = 992261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HandleLocalChatMessage(ClientChatMessage clientChatMessage)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(clientChatMessage);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_HandleLocalChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0002DE68 File Offset: 0x0002C068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 992267, RefRangeEnd = 992269, XrefRangeStart = 992261, XrefRangeEnd = 992267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowEmote(ClientChatMessage message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr_ShowEmote_Private_IEnumerator_ClientChatMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992269, XrefRangeEnd = 992286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXEmoteChatMessageCommandVisualizer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0000631F File Offset: 0x0000451F
		public FXEmoteChatMessageCommandVisualizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0002DEF4 File Offset: 0x0002C0F4
		// (set) Token: 0x06000923 RID: 2339 RVA: 0x00006328 File Offset: 0x00004528
		public unsafe Transform emoteVFXAnchor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_emoteVFXAnchor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_emoteVFXAnchor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0002DF24 File Offset: 0x0002C124
		// (set) Token: 0x06000925 RID: 2341 RVA: 0x00006347 File Offset: 0x00004547
		public unsafe List<string> defaultLookupFlavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_defaultLookupFlavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer.NativeFieldInfoPtr_defaultLookupFlavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_emoteVFXAnchor;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeFieldInfoPtr_defaultLookupFlavors;

		// Token: 0x04000597 RID: 1431
		private static readonly IntPtr NativeMethodInfoPtr_HandleIncomingChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0;

		// Token: 0x04000598 RID: 1432
		private static readonly IntPtr NativeMethodInfoPtr_HandleLocalChatMessage_Public_Virtual_Final_New_Void_ClientChatMessage_0;

		// Token: 0x04000599 RID: 1433
		private static readonly IntPtr NativeMethodInfoPtr_ShowEmote_Private_IEnumerator_ClientChatMessage_0;

		// Token: 0x0400059A RID: 1434
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000222 RID: 546
		[ObfuscatedName("lotus.FXEmoteChatMessageCommandVisualizer+<ShowEmote>d__4")]
		public sealed class _ShowEmote_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x0600191D RID: 6429 RVA: 0x0005EE54 File Offset: 0x0005D054
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowEmote_d__4()
			{
				Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer>.NativeClassPtr, "<ShowEmote>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, "<>1__state");
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, "<>2__current");
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, "message");
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, "<>4__this");
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664725);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664726);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664727);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664728);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664729);
				FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr, 100664730);
			}

			// Token: 0x0600191E RID: 6430 RVA: 0x0005EF48 File Offset: 0x0005D148
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowEmote_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600191F RID: 6431 RVA: 0x0005EF90 File Offset: 0x0005D190
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001920 RID: 6432 RVA: 0x0005EFC4 File Offset: 0x0005D1C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992196, XrefRangeEnd = 992247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06001921 RID: 6433 RVA: 0x0005F000 File Offset: 0x0005D200
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001922 RID: 6434 RVA: 0x0005F040 File Offset: 0x0005D240
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 992247, XrefRangeEnd = 992252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06001923 RID: 6435 RVA: 0x0005F074 File Offset: 0x0005D274
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001924 RID: 6436 RVA: 0x0000DB47 File Offset: 0x0000BD47
			public _ShowEmote_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06001925 RID: 6437 RVA: 0x0005F0B4 File Offset: 0x0005D2B4
			// (set) Token: 0x06001926 RID: 6438 RVA: 0x0000DB50 File Offset: 0x0000BD50
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06001927 RID: 6439 RVA: 0x0005F0DC File Offset: 0x0005D2DC
			// (set) Token: 0x06001928 RID: 6440 RVA: 0x0000DB6B File Offset: 0x0000BD6B
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06001929 RID: 6441 RVA: 0x0005F10C File Offset: 0x0005D30C
			// (set) Token: 0x0600192A RID: 6442 RVA: 0x0000DB8A File Offset: 0x0000BD8A
			public unsafe ClientChatMessage message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientChatMessage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x0600192B RID: 6443 RVA: 0x0005F13C File Offset: 0x0005D33C
			// (set) Token: 0x0600192C RID: 6444 RVA: 0x0000DBA9 File Offset: 0x0000BDA9
			public unsafe FXEmoteChatMessageCommandVisualizer __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FXEmoteChatMessageCommandVisualizer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXEmoteChatMessageCommandVisualizer._ShowEmote_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000F36 RID: 3894
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000F37 RID: 3895
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000F38 RID: 3896
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04000F39 RID: 3897
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000F3A RID: 3898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000F3B RID: 3899
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F3C RID: 3900
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000F3D RID: 3901
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000F3E RID: 3902
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000F3F RID: 3903
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
