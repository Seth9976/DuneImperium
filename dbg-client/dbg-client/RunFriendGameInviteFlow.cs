using System;
using boardgames.account;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.platform.websocket.incoming;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

// Token: 0x0200000F RID: 15
public class RunFriendGameInviteFlow : Command
{
	// Token: 0x06000079 RID: 121 RVA: 0x0001EE9C File Offset: 0x0001D09C
	// Note: this type is marked as 'beforefieldinit'.
	static RunFriendGameInviteFlow()
	{
		Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "RunFriendGameInviteFlow");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr);
		RunFriendGameInviteFlow.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, "request");
		RunFriendGameInviteFlow.NativeFieldInfoPtr__promptUser = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, "_promptUser");
		RunFriendGameInviteFlow.NativeFieldInfoPtr_playerMetadata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, "playerMetadata");
		RunFriendGameInviteFlow.NativeMethodInfoPtr_get_ConfirmKey_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, 100663383);
		RunFriendGameInviteFlow.NativeMethodInfoPtr_get_CancelKey_Protected_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, 100663384);
		RunFriendGameInviteFlow.NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGame_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, 100663385);
		RunFriendGameInviteFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, 100663386);
		RunFriendGameInviteFlow.NativeMethodInfoPtr_PreJoinEffects_Protected_Virtual_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, 100663387);
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600007A RID: 122 RVA: 0x0001EF6C File Offset: 0x0001D16C
	public unsafe virtual string ConfirmKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495570, XrefRangeEnd = 495572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFriendGameInviteFlow.NativeMethodInfoPtr_get_ConfirmKey_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600007B RID: 123 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
	public unsafe virtual string CancelKey
	{
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495572, XrefRangeEnd = 495574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFriendGameInviteFlow.NativeMethodInfoPtr_get_CancelKey_Protected_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}
	}

	// Token: 0x0600007C RID: 124 RVA: 0x0001EFF4 File Offset: 0x0001D1F4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495574, XrefRangeEnd = 495583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe RunFriendGameInviteFlow(RequestToJoinFriendGame request, bool promptUser)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref promptUser;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow.NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGame_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600007D RID: 125 RVA: 0x0001F050 File Offset: 0x0001D250
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495583, XrefRangeEnd = 495588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFriendGameInviteFlow.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600007E RID: 126 RVA: 0x0001F09C File Offset: 0x0001D29C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495588, XrefRangeEnd = 495593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual IEnumerator PreJoinEffects()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunFriendGameInviteFlow.NativeMethodInfoPtr_PreJoinEffects_Protected_Virtual_New_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x0600007F RID: 127 RVA: 0x0000235E File Offset: 0x0000055E
	public RunFriendGameInviteFlow(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000080 RID: 128 RVA: 0x0001F0E8 File Offset: 0x0001D2E8
	// (set) Token: 0x06000081 RID: 129 RVA: 0x00002367 File Offset: 0x00000567
	public unsafe RequestToJoinFriendGame request
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr_request);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<RequestToJoinFriendGame>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x06000082 RID: 130 RVA: 0x0001F118 File Offset: 0x0001D318
	// (set) Token: 0x06000083 RID: 131 RVA: 0x00002386 File Offset: 0x00000586
	public unsafe bool _promptUser
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr__promptUser);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr__promptUser)) = value;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000084 RID: 132 RVA: 0x0001F140 File Offset: 0x0001D340
	// (set) Token: 0x06000085 RID: 133 RVA: 0x000023A1 File Offset: 0x000005A1
	public unsafe Dictionary<string, string> playerMetadata
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr_playerMetadata);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow.NativeFieldInfoPtr_playerMetadata), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000049 RID: 73
	private static readonly IntPtr NativeFieldInfoPtr_request;

	// Token: 0x0400004A RID: 74
	private static readonly IntPtr NativeFieldInfoPtr__promptUser;

	// Token: 0x0400004B RID: 75
	private static readonly IntPtr NativeFieldInfoPtr_playerMetadata;

	// Token: 0x0400004C RID: 76
	private static readonly IntPtr NativeMethodInfoPtr_get_ConfirmKey_Protected_Virtual_New_get_String_0;

	// Token: 0x0400004D RID: 77
	private static readonly IntPtr NativeMethodInfoPtr_get_CancelKey_Protected_Virtual_New_get_String_0;

	// Token: 0x0400004E RID: 78
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RequestToJoinFriendGame_Boolean_0;

	// Token: 0x0400004F RID: 79
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x04000050 RID: 80
	private static readonly IntPtr NativeMethodInfoPtr_PreJoinEffects_Protected_Virtual_New_IEnumerator_0;

	// Token: 0x020002CA RID: 714
	[ObfuscatedName("RunFriendGameInviteFlow+<PreJoinEffects>d__9")]
	public sealed class _PreJoinEffects_d__9 : Object
	{
		// Token: 0x0600217F RID: 8575 RVA: 0x0008CBF4 File Offset: 0x0008ADF4
		// Note: this type is marked as 'beforefieldinit'.
		static _PreJoinEffects_d__9()
		{
			Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, "<PreJoinEffects>d__9");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, "<>1__state");
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, "<>2__current");
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, "<>4__this");
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663388);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663389);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663390);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663391);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663392);
			RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr, 100663393);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x0008CCD4 File Offset: 0x0008AED4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _PreJoinEffects_d__9(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendGameInviteFlow._PreJoinEffects_d__9>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x0008CD1C File Offset: 0x0008AF1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x0008CD50 File Offset: 0x0008AF50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495424, XrefRangeEnd = 495428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002183 RID: 8579 RVA: 0x0008CD8C File Offset: 0x0008AF8C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x0008CDCC File Offset: 0x0008AFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495428, XrefRangeEnd = 495433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002185 RID: 8581 RVA: 0x0008CE00 File Offset: 0x0008B000
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00011800 File Offset: 0x0000FA00
		public _PreJoinEffects_d__9(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002187 RID: 8583 RVA: 0x0008CE40 File Offset: 0x0008B040
		// (set) Token: 0x06002188 RID: 8584 RVA: 0x00011809 File Offset: 0x0000FA09
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06002189 RID: 8585 RVA: 0x0008CE68 File Offset: 0x0008B068
		// (set) Token: 0x0600218A RID: 8586 RVA: 0x00011824 File Offset: 0x0000FA24
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600218B RID: 8587 RVA: 0x0008CE98 File Offset: 0x0008B098
		// (set) Token: 0x0600218C RID: 8588 RVA: 0x00011843 File Offset: 0x0000FA43
		public unsafe RunFriendGameInviteFlow __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunFriendGameInviteFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._PreJoinEffects_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001518 RID: 5400
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001519 RID: 5401
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x0400151A RID: 5402
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400151B RID: 5403
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400151C RID: 5404
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400151D RID: 5405
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400151E RID: 5406
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400151F RID: 5407
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001520 RID: 5408
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}

	// Token: 0x020002CB RID: 715
	[ObfuscatedName("RunFriendGameInviteFlow+<execute>d__8")]
	public sealed class _execute_d__8 : Object
	{
		// Token: 0x0600218D RID: 8589 RVA: 0x0008CEC8 File Offset: 0x0008B0C8
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__8()
		{
			Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunFriendGameInviteFlow>.NativeClassPtr, "<execute>d__8");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr);
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<>1__state");
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<>2__current");
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<>4__this");
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__prompt_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<prompt>5__2");
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__gameID_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<gameID>5__3");
			RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__checkMultiplayer_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, "<checkMultiplayer>5__4");
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663394);
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663395);
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663396);
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663397);
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663398);
			RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr, 100663399);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0008CFE4 File Offset: 0x0008B1E4
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__8(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunFriendGameInviteFlow._execute_d__8>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0008D02C File Offset: 0x0008B22C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0008D060 File Offset: 0x0008B260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495433, XrefRangeEnd = 495565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06002191 RID: 8593 RVA: 0x0008D09C File Offset: 0x0008B29C
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0008D0DC File Offset: 0x0008B2DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495565, XrefRangeEnd = 495570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06002193 RID: 8595 RVA: 0x0008D110 File Offset: 0x0008B310
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunFriendGameInviteFlow._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00011862 File Offset: 0x0000FA62
		public _execute_d__8(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002195 RID: 8597 RVA: 0x0008D150 File Offset: 0x0008B350
		// (set) Token: 0x06002196 RID: 8598 RVA: 0x0001186B File Offset: 0x0000FA6B
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002197 RID: 8599 RVA: 0x0008D178 File Offset: 0x0008B378
		// (set) Token: 0x06002198 RID: 8600 RVA: 0x00011886 File Offset: 0x0000FA86
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002199 RID: 8601 RVA: 0x0008D1A8 File Offset: 0x0008B3A8
		// (set) Token: 0x0600219A RID: 8602 RVA: 0x000118A5 File Offset: 0x0000FAA5
		public unsafe RunFriendGameInviteFlow __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunFriendGameInviteFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x0600219B RID: 8603 RVA: 0x0008D1D8 File Offset: 0x0008B3D8
		// (set) Token: 0x0600219C RID: 8604 RVA: 0x000118C4 File Offset: 0x0000FAC4
		public unsafe ConfirmOrDenyPrompt _prompt_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__prompt_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrDenyPrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__prompt_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0008D208 File Offset: 0x0008B408
		// (set) Token: 0x0600219E RID: 8606 RVA: 0x000118E3 File Offset: 0x0000FAE3
		public unsafe GameID _gameID_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__gameID_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__gameID_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600219F RID: 8607 RVA: 0x0008D238 File Offset: 0x0008B438
		// (set) Token: 0x060021A0 RID: 8608 RVA: 0x00011902 File Offset: 0x0000FB02
		public unsafe ICheckPrivilegesCommand _checkMultiplayer_5__4
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__checkMultiplayer_5__4);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICheckPrivilegesCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunFriendGameInviteFlow._execute_d__8.NativeFieldInfoPtr__checkMultiplayer_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001521 RID: 5409
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001522 RID: 5410
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001523 RID: 5411
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001524 RID: 5412
		private static readonly IntPtr NativeFieldInfoPtr__prompt_5__2;

		// Token: 0x04001525 RID: 5413
		private static readonly IntPtr NativeFieldInfoPtr__gameID_5__3;

		// Token: 0x04001526 RID: 5414
		private static readonly IntPtr NativeFieldInfoPtr__checkMultiplayer_5__4;

		// Token: 0x04001527 RID: 5415
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001528 RID: 5416
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400152C RID: 5420
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
