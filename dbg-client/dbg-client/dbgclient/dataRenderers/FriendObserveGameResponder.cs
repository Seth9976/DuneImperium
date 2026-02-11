using System;
using boardgames.account;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B8 RID: 184
	public class FriendObserveGameResponder : Subscriber<FriendObserveGameData>
	{
		// Token: 0x06000783 RID: 1923 RVA: 0x00035110 File Offset: 0x00033310
		// Note: this type is marked as 'beforefieldinit'.
		static FriendObserveGameResponder()
		{
			Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "FriendObserveGameResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr);
			FriendObserveGameResponder.NativeFieldInfoPtr_observeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, "observeButton");
			FriendObserveGameResponder.NativeFieldInfoPtr_updateButtonRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, "updateButtonRoutine");
			FriendObserveGameResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664427);
			FriendObserveGameResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664428);
			FriendObserveGameResponder.NativeMethodInfoPtr_UpdateButton_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664429);
			FriendObserveGameResponder.NativeMethodInfoPtr_Event_ObserveGame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664430);
			FriendObserveGameResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664431);
			FriendObserveGameResponder.NativeMethodInfoPtr__modelChanged_b__3_0_Private_Void_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, 100664432);
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x000351E0 File Offset: 0x000333E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504318, XrefRangeEnd = 504323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendObserveGameResponder.NativeMethodInfoPtr_start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0003521C File Offset: 0x0003341C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504323, XrefRangeEnd = 504346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void modelChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendObserveGameResponder.NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00035258 File Offset: 0x00033458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504346, XrefRangeEnd = 504351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator UpdateButton()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder.NativeMethodInfoPtr_UpdateButton_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x00035298 File Offset: 0x00033498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504351, XrefRangeEnd = 504375, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_ObserveGame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder.NativeMethodInfoPtr_Event_ObserveGame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000352CC File Offset: 0x000334CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504375, XrefRangeEnd = 504378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendObserveGameResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00035308 File Offset: 0x00033508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504378, XrefRangeEnd = 504379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _modelChanged_b__3_0(IEnumerator _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder.NativeMethodInfoPtr__modelChanged_b__3_0_Private_Void_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000057E5 File Offset: 0x000039E5
		public FriendObserveGameResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x0003534C File Offset: 0x0003354C
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x000057EE File Offset: 0x000039EE
		public unsafe GameObject observeButton
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder.NativeFieldInfoPtr_observeButton);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder.NativeFieldInfoPtr_observeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x0003537C File Offset: 0x0003357C
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x0000580D File Offset: 0x00003A0D
		public unsafe Coroutine updateButtonRoutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder.NativeFieldInfoPtr_updateButtonRoutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder.NativeFieldInfoPtr_updateButtonRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000496 RID: 1174
		private static readonly IntPtr NativeFieldInfoPtr_observeButton;

		// Token: 0x04000497 RID: 1175
		private static readonly IntPtr NativeFieldInfoPtr_updateButtonRoutine;

		// Token: 0x04000498 RID: 1176
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_Void_0;

		// Token: 0x04000499 RID: 1177
		private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_Void_0;

		// Token: 0x0400049A RID: 1178
		private static readonly IntPtr NativeMethodInfoPtr_UpdateButton_Private_IEnumerator_0;

		// Token: 0x0400049B RID: 1179
		private static readonly IntPtr NativeMethodInfoPtr_Event_ObserveGame_Public_Void_0;

		// Token: 0x0400049C RID: 1180
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400049D RID: 1181
		private static readonly IntPtr NativeMethodInfoPtr__modelChanged_b__3_0_Private_Void_IEnumerator_0;

		// Token: 0x0200031F RID: 799
		[ObfuscatedName("dbgclient.dataRenderers.FriendObserveGameResponder+<UpdateButton>d__4")]
		public sealed class _UpdateButton_d__4 : global::Il2CppSystem.Object
		{
			// Token: 0x060025B0 RID: 9648 RVA: 0x000992C0 File Offset: 0x000974C0
			// Note: this type is marked as 'beforefieldinit'.
			static _UpdateButton_d__4()
			{
				Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendObserveGameResponder>.NativeClassPtr, "<UpdateButton>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr);
				FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, "<>1__state");
				FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, "<>2__current");
				FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, "<>4__this");
				FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__multiplayerCheck_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, "<multiplayerCheck>5__2");
				FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__crossplayCheck_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, "<crossplayCheck>5__3");
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664433);
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664434);
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664435);
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664436);
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664437);
				FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr, 100664438);
			}

			// Token: 0x060025B1 RID: 9649 RVA: 0x000993C8 File Offset: 0x000975C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UpdateButton_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendObserveGameResponder._UpdateButton_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060025B2 RID: 9650 RVA: 0x00099410 File Offset: 0x00097610
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060025B3 RID: 9651 RVA: 0x00099444 File Offset: 0x00097644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504296, XrefRangeEnd = 504313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000A68 RID: 2664
			// (get) Token: 0x060025B4 RID: 9652 RVA: 0x00099480 File Offset: 0x00097680
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025B5 RID: 9653 RVA: 0x000994C0 File Offset: 0x000976C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504313, XrefRangeEnd = 504318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000A69 RID: 2665
			// (get) Token: 0x060025B6 RID: 9654 RVA: 0x000994F4 File Offset: 0x000976F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendObserveGameResponder._UpdateButton_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060025B7 RID: 9655 RVA: 0x0001392B File Offset: 0x00011B2B
			public _UpdateButton_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A63 RID: 2659
			// (get) Token: 0x060025B8 RID: 9656 RVA: 0x00099534 File Offset: 0x00097734
			// (set) Token: 0x060025B9 RID: 9657 RVA: 0x00013934 File Offset: 0x00011B34
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000A64 RID: 2660
			// (get) Token: 0x060025BA RID: 9658 RVA: 0x0009955C File Offset: 0x0009775C
			// (set) Token: 0x060025BB RID: 9659 RVA: 0x0001394F File Offset: 0x00011B4F
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A65 RID: 2661
			// (get) Token: 0x060025BC RID: 9660 RVA: 0x0009958C File Offset: 0x0009778C
			// (set) Token: 0x060025BD RID: 9661 RVA: 0x0001396E File Offset: 0x00011B6E
			public unsafe FriendObserveGameResponder __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FriendObserveGameResponder>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A66 RID: 2662
			// (get) Token: 0x060025BE RID: 9662 RVA: 0x000995BC File Offset: 0x000977BC
			// (set) Token: 0x060025BF RID: 9663 RVA: 0x0001398D File Offset: 0x00011B8D
			public unsafe ICheckPrivilegesCommand _multiplayerCheck_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__multiplayerCheck_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__multiplayerCheck_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A67 RID: 2663
			// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000995EC File Offset: 0x000977EC
			// (set) Token: 0x060025C1 RID: 9665 RVA: 0x000139AC File Offset: 0x00011BAC
			public unsafe ICheckPrivilegesCommand _crossplayCheck_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__crossplayCheck_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendObserveGameResponder._UpdateButton_d__4.NativeFieldInfoPtr__crossplayCheck_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A4 RID: 6052
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040017A5 RID: 6053
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040017A6 RID: 6054
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040017A7 RID: 6055
			private static readonly IntPtr NativeFieldInfoPtr__multiplayerCheck_5__2;

			// Token: 0x040017A8 RID: 6056
			private static readonly IntPtr NativeFieldInfoPtr__crossplayCheck_5__3;

			// Token: 0x040017A9 RID: 6057
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040017AA RID: 6058
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017AB RID: 6059
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040017AC RID: 6060
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040017AD RID: 6061
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040017AE RID: 6062
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
