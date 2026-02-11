using System;
using Canis.messages.timer;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace zen.src.match.monobehaviours
{
	// Token: 0x0200006F RID: 111
	public class PlayerTimerController : MonoBehaviour
	{
		// Token: 0x060005E7 RID: 1511 RVA: 0x000232AC File Offset: 0x000214AC
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerTimerController()
		{
			Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.match.monobehaviours", "PlayerTimerController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr);
			PlayerTimerController.NativeFieldInfoPtr_timerInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, "timerInterface");
			PlayerTimerController.NativeMethodInfoPtr_get_TimerInterface_Private_get_ITimerInterface_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, 100664233);
			PlayerTimerController.NativeMethodInfoPtr_DisplayTimer_Public_IEnumerator_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, 100664234);
			PlayerTimerController.NativeMethodInfoPtr_HideTimer_Public_Void_TimerID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, 100664235);
			PlayerTimerController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, 100664236);
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00023340 File Offset: 0x00021540
		public unsafe ITimerInterface TimerInterface
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988243, XrefRangeEnd = 988247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController.NativeMethodInfoPtr_get_TimerInterface_Private_get_ITimerInterface_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITimerInterface>(intPtr3) : null;
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00023380 File Offset: 0x00021580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988247, XrefRangeEnd = 988253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DisplayTimer(DisplayTimer displayTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayTimer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController.NativeMethodInfoPtr_DisplayTimer_Public_IEnumerator_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x000233D0 File Offset: 0x000215D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988253, XrefRangeEnd = 988262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideTimer(TimerID timerID, AccountID accountID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timerID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(accountID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController.NativeMethodInfoPtr_HideTimer_Public_Void_TimerID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00023424 File Offset: 0x00021624
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerTimerController()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x00004B29 File Offset: 0x00002D29
		public PlayerTimerController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060005ED RID: 1517 RVA: 0x00023460 File Offset: 0x00021660
		// (set) Token: 0x060005EE RID: 1518 RVA: 0x00004B32 File Offset: 0x00002D32
		public unsafe ITimerInterface timerInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController.NativeFieldInfoPtr_timerInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ITimerInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController.NativeFieldInfoPtr_timerInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400039E RID: 926
		private static readonly IntPtr NativeFieldInfoPtr_timerInterface;

		// Token: 0x0400039F RID: 927
		private static readonly IntPtr NativeMethodInfoPtr_get_TimerInterface_Private_get_ITimerInterface_0;

		// Token: 0x040003A0 RID: 928
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTimer_Public_IEnumerator_DisplayTimer_0;

		// Token: 0x040003A1 RID: 929
		private static readonly IntPtr NativeMethodInfoPtr_HideTimer_Public_Void_TimerID_AccountID_0;

		// Token: 0x040003A2 RID: 930
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000203 RID: 515
		[ObfuscatedName("zen.src.match.monobehaviours.PlayerTimerController+<DisplayTimer>d__3")]
		public sealed class _DisplayTimer_d__3 : global::Il2CppSystem.Object
		{
			// Token: 0x06001778 RID: 6008 RVA: 0x00059DD4 File Offset: 0x00057FD4
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayTimer_d__3()
			{
				Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerTimerController>.NativeClassPtr, "<DisplayTimer>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr);
				PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, "<>1__state");
				PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, "<>2__current");
				PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, "<>4__this");
				PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr_displayTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, "displayTimer");
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664237);
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664238);
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664239);
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664240);
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664241);
				PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr, 100664242);
			}

			// Token: 0x06001779 RID: 6009 RVA: 0x00059EC8 File Offset: 0x000580C8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisplayTimer_d__3(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerTimerController._DisplayTimer_d__3>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600177A RID: 6010 RVA: 0x00059F10 File Offset: 0x00058110
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600177B RID: 6011 RVA: 0x00059F44 File Offset: 0x00058144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988230, XrefRangeEnd = 988238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006B9 RID: 1721
			// (get) Token: 0x0600177C RID: 6012 RVA: 0x00059F80 File Offset: 0x00058180
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600177D RID: 6013 RVA: 0x00059FC0 File Offset: 0x000581C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 988238, XrefRangeEnd = 988243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006BA RID: 1722
			// (get) Token: 0x0600177E RID: 6014 RVA: 0x00059FF4 File Offset: 0x000581F4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerTimerController._DisplayTimer_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600177F RID: 6015 RVA: 0x0000CE84 File Offset: 0x0000B084
			public _DisplayTimer_d__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006B5 RID: 1717
			// (get) Token: 0x06001780 RID: 6016 RVA: 0x0005A034 File Offset: 0x00058234
			// (set) Token: 0x06001781 RID: 6017 RVA: 0x0000CE8D File Offset: 0x0000B08D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006B6 RID: 1718
			// (get) Token: 0x06001782 RID: 6018 RVA: 0x0005A05C File Offset: 0x0005825C
			// (set) Token: 0x06001783 RID: 6019 RVA: 0x0000CEA8 File Offset: 0x0000B0A8
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B7 RID: 1719
			// (get) Token: 0x06001784 RID: 6020 RVA: 0x0005A08C File Offset: 0x0005828C
			// (set) Token: 0x06001785 RID: 6021 RVA: 0x0000CEC7 File Offset: 0x0000B0C7
			public unsafe PlayerTimerController __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerTimerController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006B8 RID: 1720
			// (get) Token: 0x06001786 RID: 6022 RVA: 0x0005A0BC File Offset: 0x000582BC
			// (set) Token: 0x06001787 RID: 6023 RVA: 0x0000CEE6 File Offset: 0x0000B0E6
			public unsafe DisplayTimer displayTimer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr_displayTimer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayTimer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerTimerController._DisplayTimer_d__3.NativeFieldInfoPtr_displayTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000E35 RID: 3637
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000E36 RID: 3638
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000E37 RID: 3639
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04000E38 RID: 3640
			private static readonly IntPtr NativeFieldInfoPtr_displayTimer;

			// Token: 0x04000E39 RID: 3641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000E3A RID: 3642
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E3B RID: 3643
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000E3C RID: 3644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000E3D RID: 3645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000E3E RID: 3646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
