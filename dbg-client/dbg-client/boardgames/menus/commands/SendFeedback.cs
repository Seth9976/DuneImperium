using System;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace boardgames.menus.commands
{
	// Token: 0x0200023F RID: 575
	public class SendFeedback : FailableCommand
	{
		// Token: 0x060019ED RID: 6637 RVA: 0x00071E40 File Offset: 0x00070040
		// Note: this type is marked as 'beforefieldinit'.
		static SendFeedback()
		{
			Il2CppClassPointerStore<SendFeedback>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "SendFeedback");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr);
			SendFeedback.NativeFieldInfoPtr_feedbackType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "feedbackType");
			SendFeedback.NativeFieldInfoPtr_feedback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "feedback");
			SendFeedback.NativeFieldInfoPtr_email = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "email");
			SendFeedback.NativeFieldInfoPtr_sendLogs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "sendLogs");
			SendFeedback.NativeFieldInfoPtr_additionalData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "additionalData");
			SendFeedback.NativeFieldInfoPtr_sendScreenshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "sendScreenshot");
			SendFeedback.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Boolean_Boolean_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, 100667423);
			SendFeedback.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, 100667424);
			SendFeedback.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, 100667425);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x00071F24 File Offset: 0x00070124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531160, XrefRangeEnd = 531165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendFeedback(string feedback, string feedbackType, string email = null, bool sendLogs = false, bool sendScreenshot = true, Dictionary<string, global::Il2CppSystem.Object> additionalData = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(feedback);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(feedbackType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(email);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendLogs;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sendScreenshot;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Boolean_Boolean_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x00071FC4 File Offset: 0x000701C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531165, XrefRangeEnd = 531170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SendFeedback.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x00072010 File Offset: 0x00070210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531170, XrefRangeEnd = 531175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback.NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0000E304 File Offset: 0x0000C504
		public SendFeedback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00072044 File Offset: 0x00070244
		// (set) Token: 0x060019F3 RID: 6643 RVA: 0x0000E30D File Offset: 0x0000C50D
		public unsafe string feedbackType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_feedbackType);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_feedbackType), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0007206C File Offset: 0x0007026C
		// (set) Token: 0x060019F5 RID: 6645 RVA: 0x0000E32C File Offset: 0x0000C52C
		public unsafe string feedback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_feedback);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_feedback), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x00072094 File Offset: 0x00070294
		// (set) Token: 0x060019F7 RID: 6647 RVA: 0x0000E34B File Offset: 0x0000C54B
		public unsafe string email
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_email);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_email), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x060019F8 RID: 6648 RVA: 0x000720BC File Offset: 0x000702BC
		// (set) Token: 0x060019F9 RID: 6649 RVA: 0x0000E36A File Offset: 0x0000C56A
		public unsafe bool sendLogs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_sendLogs);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_sendLogs)) = value;
			}
		}

		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x060019FA RID: 6650 RVA: 0x000720E4 File Offset: 0x000702E4
		// (set) Token: 0x060019FB RID: 6651 RVA: 0x0000E385 File Offset: 0x0000C585
		public unsafe Dictionary<string, global::Il2CppSystem.Object> additionalData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_additionalData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::Il2CppSystem.Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_additionalData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x060019FC RID: 6652 RVA: 0x00072114 File Offset: 0x00070314
		// (set) Token: 0x060019FD RID: 6653 RVA: 0x0000E3A4 File Offset: 0x0000C5A4
		public unsafe bool sendScreenshot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_sendScreenshot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.NativeFieldInfoPtr_sendScreenshot)) = value;
			}
		}

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeFieldInfoPtr_feedbackType;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeFieldInfoPtr_feedback;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeFieldInfoPtr_email;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeFieldInfoPtr_sendLogs;

		// Token: 0x0400102D RID: 4141
		private static readonly IntPtr NativeFieldInfoPtr_additionalData;

		// Token: 0x0400102E RID: 4142
		private static readonly IntPtr NativeFieldInfoPtr_sendScreenshot;

		// Token: 0x0400102F RID: 4143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Boolean_Boolean_Dictionary_2_String_Object_0;

		// Token: 0x04001030 RID: 4144
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001031 RID: 4145
		private static readonly IntPtr NativeMethodInfoPtr_Interrupted_Public_Virtual_Final_New_Void_0;

		// Token: 0x0200042E RID: 1070
		[ObfuscatedName("boardgames.menus.commands.SendFeedback+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : global::Il2CppSystem.Object
		{
			// Token: 0x060032A1 RID: 12961 RVA: 0x000BF94C File Offset: 0x000BDB4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr);
				SendFeedback.__c__DisplayClass7_0.NativeFieldInfoPtr_serverVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr, "serverVersion");
				SendFeedback.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr, 100667426);
				SendFeedback.__c__DisplayClass7_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr, 100667427);
			}

			// Token: 0x060032A2 RID: 12962 RVA: 0x000BF9B4 File Offset: 0x000BDBB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFeedback.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032A3 RID: 12963 RVA: 0x000BF9F0 File Offset: 0x000BDBF0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__0(string versionStr)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(versionStr);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback.__c__DisplayClass7_0.NativeMethodInfoPtr__execute_b__0_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032A4 RID: 12964 RVA: 0x0001A260 File Offset: 0x00018460
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EC0 RID: 3776
			// (get) Token: 0x060032A5 RID: 12965 RVA: 0x000BFA34 File Offset: 0x000BDC34
			// (set) Token: 0x060032A6 RID: 12966 RVA: 0x0001A269 File Offset: 0x00018469
			public unsafe string serverVersion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.__c__DisplayClass7_0.NativeFieldInfoPtr_serverVersion);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback.__c__DisplayClass7_0.NativeFieldInfoPtr_serverVersion), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04001F43 RID: 8003
			private static readonly IntPtr NativeFieldInfoPtr_serverVersion;

			// Token: 0x04001F44 RID: 8004
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F45 RID: 8005
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Void_String_0;
		}

		// Token: 0x0200042F RID: 1071
		[ObfuscatedName("boardgames.menus.commands.SendFeedback+<execute>d__7")]
		public sealed class _execute_d__7 : global::Il2CppSystem.Object
		{
			// Token: 0x060032A7 RID: 12967 RVA: 0x000BFA5C File Offset: 0x000BDC5C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SendFeedback>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr);
				SendFeedback._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<>1__state");
				SendFeedback._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<>2__current");
				SendFeedback._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<>4__this");
				SendFeedback._execute_d__7.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<>8__1");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__feedbackData_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<feedbackData>5__2");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__post_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<post>5__3");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__mainCanvas_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<mainCanvas>5__4");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__spinnerCanvas_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<spinnerCanvas>5__5");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__oldAlpha_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<oldAlpha>5__6");
				SendFeedback._execute_d__7.NativeFieldInfoPtr__oldSpinnerAlpha_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, "<oldSpinnerAlpha>5__7");
				SendFeedback._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667428);
				SendFeedback._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667429);
				SendFeedback._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667430);
				SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667431);
				SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667432);
				SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr, 100667433);
			}

			// Token: 0x060032A8 RID: 12968 RVA: 0x000BFBC8 File Offset: 0x000BDDC8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SendFeedback._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032A9 RID: 12969 RVA: 0x000BFC10 File Offset: 0x000BDE10
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032AA RID: 12970 RVA: 0x000BFC44 File Offset: 0x000BDE44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531071, XrefRangeEnd = 531155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ECB RID: 3787
			// (get) Token: 0x060032AB RID: 12971 RVA: 0x000BFC80 File Offset: 0x000BDE80
			public unsafe global::Il2CppSystem.Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032AC RID: 12972 RVA: 0x000BFCC0 File Offset: 0x000BDEC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531155, XrefRangeEnd = 531160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ECC RID: 3788
			// (get) Token: 0x060032AD RID: 12973 RVA: 0x000BFCF4 File Offset: 0x000BDEF4
			public unsafe global::Il2CppSystem.Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SendFeedback._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032AE RID: 12974 RVA: 0x0001A288 File Offset: 0x00018488
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000EC1 RID: 3777
			// (get) Token: 0x060032AF RID: 12975 RVA: 0x000BFD34 File Offset: 0x000BDF34
			// (set) Token: 0x060032B0 RID: 12976 RVA: 0x0001A291 File Offset: 0x00018491
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000EC2 RID: 3778
			// (get) Token: 0x060032B1 RID: 12977 RVA: 0x000BFD5C File Offset: 0x000BDF5C
			// (set) Token: 0x060032B2 RID: 12978 RVA: 0x0001A2AC File Offset: 0x000184AC
			public unsafe global::Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC3 RID: 3779
			// (get) Token: 0x060032B3 RID: 12979 RVA: 0x000BFD8C File Offset: 0x000BDF8C
			// (set) Token: 0x060032B4 RID: 12980 RVA: 0x0001A2CB File Offset: 0x000184CB
			public unsafe SendFeedback __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendFeedback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC4 RID: 3780
			// (get) Token: 0x060032B5 RID: 12981 RVA: 0x000BFDBC File Offset: 0x000BDFBC
			// (set) Token: 0x060032B6 RID: 12982 RVA: 0x0001A2EA File Offset: 0x000184EA
			public unsafe SendFeedback.__c__DisplayClass7_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SendFeedback.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC5 RID: 3781
			// (get) Token: 0x060032B7 RID: 12983 RVA: 0x000BFDEC File Offset: 0x000BDFEC
			// (set) Token: 0x060032B8 RID: 12984 RVA: 0x0001A309 File Offset: 0x00018509
			public unsafe Dictionary<string, global::Il2CppSystem.Object> _feedbackData_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__feedbackData_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, global::Il2CppSystem.Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__feedbackData_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC6 RID: 3782
			// (get) Token: 0x060032B9 RID: 12985 RVA: 0x000BFE1C File Offset: 0x000BE01C
			// (set) Token: 0x060032BA RID: 12986 RVA: 0x0001A328 File Offset: 0x00018528
			public unsafe HttpPostRequest _post_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__post_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HttpPostRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__post_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC7 RID: 3783
			// (get) Token: 0x060032BB RID: 12987 RVA: 0x000BFE4C File Offset: 0x000BE04C
			// (set) Token: 0x060032BC RID: 12988 RVA: 0x0001A347 File Offset: 0x00018547
			public unsafe CanvasGroup _mainCanvas_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__mainCanvas_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__mainCanvas_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC8 RID: 3784
			// (get) Token: 0x060032BD RID: 12989 RVA: 0x000BFE7C File Offset: 0x000BE07C
			// (set) Token: 0x060032BE RID: 12990 RVA: 0x0001A366 File Offset: 0x00018566
			public unsafe CanvasGroup _spinnerCanvas_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__spinnerCanvas_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__spinnerCanvas_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000EC9 RID: 3785
			// (get) Token: 0x060032BF RID: 12991 RVA: 0x000BFEAC File Offset: 0x000BE0AC
			// (set) Token: 0x060032C0 RID: 12992 RVA: 0x0001A385 File Offset: 0x00018585
			public unsafe float _oldAlpha_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__oldAlpha_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__oldAlpha_5__6)) = value;
				}
			}

			// Token: 0x17000ECA RID: 3786
			// (get) Token: 0x060032C1 RID: 12993 RVA: 0x000BFED4 File Offset: 0x000BE0D4
			// (set) Token: 0x060032C2 RID: 12994 RVA: 0x0001A3A0 File Offset: 0x000185A0
			public unsafe float _oldSpinnerAlpha_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__oldSpinnerAlpha_5__7);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SendFeedback._execute_d__7.NativeFieldInfoPtr__oldSpinnerAlpha_5__7)) = value;
				}
			}

			// Token: 0x04001F46 RID: 8006
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F47 RID: 8007
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F48 RID: 8008
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001F49 RID: 8009
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001F4A RID: 8010
			private static readonly IntPtr NativeFieldInfoPtr__feedbackData_5__2;

			// Token: 0x04001F4B RID: 8011
			private static readonly IntPtr NativeFieldInfoPtr__post_5__3;

			// Token: 0x04001F4C RID: 8012
			private static readonly IntPtr NativeFieldInfoPtr__mainCanvas_5__4;

			// Token: 0x04001F4D RID: 8013
			private static readonly IntPtr NativeFieldInfoPtr__spinnerCanvas_5__5;

			// Token: 0x04001F4E RID: 8014
			private static readonly IntPtr NativeFieldInfoPtr__oldAlpha_5__6;

			// Token: 0x04001F4F RID: 8015
			private static readonly IntPtr NativeFieldInfoPtr__oldSpinnerAlpha_5__7;

			// Token: 0x04001F50 RID: 8016
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F51 RID: 8017
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F52 RID: 8018
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F53 RID: 8019
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F54 RID: 8020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F55 RID: 8021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
