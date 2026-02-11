using System;
using Canis.messages.timer;
using Canis.utils.ids;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames
{
	// Token: 0x020000FF RID: 255
	public class BasicTimerInterface : MonoBehaviour
	{
		// Token: 0x06000C37 RID: 3127 RVA: 0x00037ED0 File Offset: 0x000360D0
		// Note: this type is marked as 'beforefieldinit'.
		static BasicTimerInterface()
		{
			Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames", "BasicTimerInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr);
			BasicTimerInterface.NativeFieldInfoPtr_accountTimers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, "accountTimers");
			BasicTimerInterface.NativeFieldInfoPtr__AccountTimers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, "<AccountTimers>k__BackingField");
			BasicTimerInterface.NativeMethodInfoPtr_get_AccountTimers_Public_get_IReadOnlyDictionary_2_AccountID_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665240);
			BasicTimerInterface.NativeMethodInfoPtr_set_AccountTimers_Private_set_Void_IReadOnlyDictionary_2_AccountID_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665241);
			BasicTimerInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665242);
			BasicTimerInterface.NativeMethodInfoPtr_GetTimerForAccount_Public_Virtual_Final_New_DataComposition_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665243);
			BasicTimerInterface.NativeMethodInfoPtr_DisplayTimer_Public_Virtual_Final_New_IEnumerator_DisplayTimer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665244);
			BasicTimerInterface.NativeMethodInfoPtr_HideTimer_Public_Virtual_Final_New_Void_TimerID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665245);
			BasicTimerInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, 100665246);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00037FB4 File Offset: 0x000361B4
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00037FF4 File Offset: 0x000361F4
		public unsafe IReadOnlyDictionary<AccountID, DataComposition> AccountTimers
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_get_AccountTimers_Public_get_IReadOnlyDictionary_2_AccountID_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<AccountID, DataComposition>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_set_AccountTimers_Private_set_Void_IReadOnlyDictionary_2_AccountID_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00038038 File Offset: 0x00036238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995387, XrefRangeEnd = 995394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x0003806C File Offset: 0x0003626C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995394, XrefRangeEnd = 995413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual DataComposition GetTimerForAccount(AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_GetTimerForAccount_Public_Virtual_Final_New_DataComposition_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3C RID: 3132 RVA: 0x000380BC File Offset: 0x000362BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995413, XrefRangeEnd = 995419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator DisplayTimer(DisplayTimer displayTimer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(displayTimer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_DisplayTimer_Public_Virtual_Final_New_IEnumerator_DisplayTimer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0003810C File Offset: 0x0003630C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995419, XrefRangeEnd = 995447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideTimer(TimerID timerID, AccountID accountID)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr_HideTimer_Public_Virtual_Final_New_Void_TimerID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x00038160 File Offset: 0x00036360
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995447, XrefRangeEnd = 995455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicTimerInterface()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x000079FD File Offset: 0x00005BFD
		public BasicTimerInterface(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x0003819C File Offset: 0x0003639C
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007A06 File Offset: 0x00005C06
		public unsafe Dictionary<AccountID, DataComposition> accountTimers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface.NativeFieldInfoPtr_accountTimers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface.NativeFieldInfoPtr_accountTimers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x000381CC File Offset: 0x000363CC
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007A25 File Offset: 0x00005C25
		public unsafe IReadOnlyDictionary<AccountID, DataComposition> _AccountTimers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface.NativeFieldInfoPtr__AccountTimers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReadOnlyDictionary<AccountID, DataComposition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface.NativeFieldInfoPtr__AccountTimers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeFieldInfoPtr_accountTimers;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeFieldInfoPtr__AccountTimers_k__BackingField;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountTimers_Public_get_IReadOnlyDictionary_2_AccountID_DataComposition_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_set_AccountTimers_Private_set_Void_IReadOnlyDictionary_2_AccountID_DataComposition_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_GetTimerForAccount_Public_Virtual_Final_New_DataComposition_AccountID_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_DisplayTimer_Public_Virtual_Final_New_IEnumerator_DisplayTimer_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_HideTimer_Public_Virtual_Final_New_Void_TimerID_AccountID_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200024D RID: 589
		[ObfuscatedName("boardgames.BasicTimerInterface+<DisplayTimer>d__7")]
		public sealed class _DisplayTimer_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x06001B4F RID: 6991 RVA: 0x000656CC File Offset: 0x000638CC
			// Note: this type is marked as 'beforefieldinit'.
			static _DisplayTimer_d__7()
			{
				Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BasicTimerInterface>.NativeClassPtr, "<DisplayTimer>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr);
				BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, "<>1__state");
				BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, "<>2__current");
				BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, "<>4__this");
				BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr_displayTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, "displayTimer");
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665247);
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665248);
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665249);
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665250);
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665251);
				BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr, 100665252);
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x000657C0 File Offset: 0x000639C0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DisplayTimer_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicTimerInterface._DisplayTimer_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00065808 File Offset: 0x00063A08
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x0006583C File Offset: 0x00063A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995370, XrefRangeEnd = 995382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001B53 RID: 6995 RVA: 0x00065878 File Offset: 0x00063A78
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x000658B8 File Offset: 0x00063AB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995382, XrefRangeEnd = 995387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001B55 RID: 6997 RVA: 0x000658EC File Offset: 0x00063AEC
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicTimerInterface._DisplayTimer_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001B56 RID: 6998 RVA: 0x0000ECE5 File Offset: 0x0000CEE5
			public _DisplayTimer_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080A RID: 2058
			// (get) Token: 0x06001B57 RID: 6999 RVA: 0x0006592C File Offset: 0x00063B2C
			// (set) Token: 0x06001B58 RID: 7000 RVA: 0x0000ECEE File Offset: 0x0000CEEE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700080B RID: 2059
			// (get) Token: 0x06001B59 RID: 7001 RVA: 0x00065954 File Offset: 0x00063B54
			// (set) Token: 0x06001B5A RID: 7002 RVA: 0x0000ED09 File Offset: 0x0000CF09
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080C RID: 2060
			// (get) Token: 0x06001B5B RID: 7003 RVA: 0x00065984 File Offset: 0x00063B84
			// (set) Token: 0x06001B5C RID: 7004 RVA: 0x0000ED28 File Offset: 0x0000CF28
			public unsafe BasicTimerInterface __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicTimerInterface>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06001B5D RID: 7005 RVA: 0x000659B4 File Offset: 0x00063BB4
			// (set) Token: 0x06001B5E RID: 7006 RVA: 0x0000ED47 File Offset: 0x0000CF47
			public unsafe DisplayTimer displayTimer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr_displayTimer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DisplayTimer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BasicTimerInterface._DisplayTimer_d__7.NativeFieldInfoPtr_displayTimer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001084 RID: 4228
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001085 RID: 4229
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001086 RID: 4230
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001087 RID: 4231
			private static readonly IntPtr NativeFieldInfoPtr_displayTimer;

			// Token: 0x04001088 RID: 4232
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001089 RID: 4233
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400108A RID: 4234
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400108B RID: 4235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400108C RID: 4236
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400108D RID: 4237
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
