using System;
using boardgames;
using boardgames.matchMaking.commands;
using boardgames.menus;
using Canis.utils.ids;
using dwd.core.commands;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

// Token: 0x02000009 RID: 9
public class LaunchFriendGame : Command
{
	// Token: 0x0600003F RID: 63 RVA: 0x0001E198 File Offset: 0x0001C398
	// Note: this type is marked as 'beforefieldinit'.
	static LaunchFriendGame()
	{
		Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "", "LaunchFriendGame");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr);
		LaunchFriendGame.NativeFieldInfoPtr__friendData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, "_friendData");
		LaunchFriendGame.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, "id");
		LaunchFriendGame.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, 100663347);
		LaunchFriendGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, 100663348);
	}

	// Token: 0x06000040 RID: 64 RVA: 0x0001E218 File Offset: 0x0001C418
	[CallerCount(17)]
	[CachedScanResults(RefRangeStart = 495165, RefRangeEnd = 495182, XrefRangeStart = 495162, XrefRangeEnd = 495165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe LaunchFriendGame(DataComposition friendData, AccountID id)
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr))
	{
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(friendData);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame.NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000041 RID: 65 RVA: 0x0001E278 File Offset: 0x0001C478
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495182, XrefRangeEnd = 495187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override IEnumerator execute()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LaunchFriendGame.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		IntPtr intPtr3 = intPtr;
		return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
	}

	// Token: 0x06000042 RID: 66 RVA: 0x000021B8 File Offset: 0x000003B8
	public LaunchFriendGame(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700000F RID: 15
	// (get) Token: 0x06000043 RID: 67 RVA: 0x0001E2C4 File Offset: 0x0001C4C4
	// (set) Token: 0x06000044 RID: 68 RVA: 0x000021C1 File Offset: 0x000003C1
	public unsafe DataComposition _friendData
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.NativeFieldInfoPtr__friendData);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.NativeFieldInfoPtr__friendData), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000010 RID: 16
	// (get) Token: 0x06000045 RID: 69 RVA: 0x0001E2F4 File Offset: 0x0001C4F4
	// (set) Token: 0x06000046 RID: 70 RVA: 0x000021E0 File Offset: 0x000003E0
	public unsafe AccountID id
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.NativeFieldInfoPtr_id);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.NativeFieldInfoPtr_id), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000027 RID: 39
	private static readonly IntPtr NativeFieldInfoPtr__friendData;

	// Token: 0x04000028 RID: 40
	private static readonly IntPtr NativeFieldInfoPtr_id;

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataComposition_AccountID_0;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

	// Token: 0x020002C4 RID: 708
	[ObfuscatedName("LaunchFriendGame+<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : Object
	{
		// Token: 0x06002152 RID: 8530 RVA: 0x0008C330 File Offset: 0x0008A530
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr);
			LaunchFriendGame.__c__DisplayClass3_0.NativeFieldInfoPtr_lobbySessionProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr, "lobbySessionProvider");
			LaunchFriendGame.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr, 100663349);
			LaunchFriendGame.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr, 100663350);
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0008C398 File Offset: 0x0008A598
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunchFriendGame.__c__DisplayClass3_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0008C3D4 File Offset: 0x0008A5D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _execute_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame.__c__DisplayClass3_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00011698 File Offset: 0x0000F898
		public __c__DisplayClass3_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x06002156 RID: 8534 RVA: 0x0008C410 File Offset: 0x0008A610
		// (set) Token: 0x06002157 RID: 8535 RVA: 0x000116A1 File Offset: 0x0000F8A1
		public unsafe LobbySessionProvider lobbySessionProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.__c__DisplayClass3_0.NativeFieldInfoPtr_lobbySessionProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LobbySessionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame.__c__DisplayClass3_0.NativeFieldInfoPtr_lobbySessionProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014FC RID: 5372
		private static readonly IntPtr NativeFieldInfoPtr_lobbySessionProvider;

		// Token: 0x040014FD RID: 5373
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014FE RID: 5374
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_0;
	}

	// Token: 0x020002C5 RID: 709
	[ObfuscatedName("LaunchFriendGame+<execute>d__3")]
	public sealed class _execute_d__3 : Object
	{
		// Token: 0x06002158 RID: 8536 RVA: 0x0008C440 File Offset: 0x0008A640
		// Note: this type is marked as 'beforefieldinit'.
		static _execute_d__3()
		{
			Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LaunchFriendGame>.NativeClassPtr, "<execute>d__3");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr);
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<>1__state");
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<>2__current");
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<>4__this");
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<>8__1");
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__canInviteUser_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<canInviteUser>5__2");
			LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__constraints_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, "<constraints>5__3");
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663351);
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663352);
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663353);
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663354);
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663355);
			LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr, 100663356);
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0008C55C File Offset: 0x0008A75C
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe _execute_d__3(int <>1__state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LaunchFriendGame._execute_d__3>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0008C5A4 File Offset: 0x0008A7A4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_IDisposable_Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0008C5D8 File Offset: 0x0008A7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495132, XrefRangeEnd = 495157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x0600215C RID: 8540 RVA: 0x0008C614 File Offset: 0x0008A814
		public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0008C654 File Offset: 0x0008A854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 495157, XrefRangeEnd = 495162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Collections_IEnumerator_Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x0600215E RID: 8542 RVA: 0x0008C688 File Offset: 0x0008A888
		public unsafe Object System.Collections.IEnumerator.Current
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LaunchFriendGame._execute_d__3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x000116C0 File Offset: 0x0000F8C0
		public _execute_d__3(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06002160 RID: 8544 RVA: 0x0008C6C8 File Offset: 0x0008A8C8
		// (set) Token: 0x06002161 RID: 8545 RVA: 0x000116C9 File Offset: 0x0000F8C9
		public unsafe int __1__state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___1__state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___1__state)) = value;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06002162 RID: 8546 RVA: 0x0008C6F0 File Offset: 0x0008A8F0
		// (set) Token: 0x06002163 RID: 8547 RVA: 0x000116E4 File Offset: 0x0000F8E4
		public unsafe Object __2__current
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___2__current);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x06002164 RID: 8548 RVA: 0x0008C720 File Offset: 0x0008A920
		// (set) Token: 0x06002165 RID: 8549 RVA: 0x00011703 File Offset: 0x0000F903
		public unsafe LaunchFriendGame __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunchFriendGame>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x06002166 RID: 8550 RVA: 0x0008C750 File Offset: 0x0008A950
		// (set) Token: 0x06002167 RID: 8551 RVA: 0x00011722 File Offset: 0x0000F922
		public unsafe LaunchFriendGame.__c__DisplayClass3_0 __8__1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___8__1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LaunchFriendGame.__c__DisplayClass3_0>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x0008C780 File Offset: 0x0008A980
		// (set) Token: 0x06002169 RID: 8553 RVA: 0x00011741 File Offset: 0x0000F941
		public unsafe ICanInviteUser _canInviteUser_5__2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__canInviteUser_5__2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICanInviteUser>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__canInviteUser_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x0008C7B0 File Offset: 0x0008A9B0
		// (set) Token: 0x0600216B RID: 8555 RVA: 0x00011760 File Offset: 0x0000F960
		public unsafe GameConfigurationConstraints _constraints_5__3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__constraints_5__3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameConfigurationConstraints>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LaunchFriendGame._execute_d__3.NativeFieldInfoPtr__constraints_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040014FF RID: 5375
		private static readonly IntPtr NativeFieldInfoPtr___1__state;

		// Token: 0x04001500 RID: 5376
		private static readonly IntPtr NativeFieldInfoPtr___2__current;

		// Token: 0x04001501 RID: 5377
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeFieldInfoPtr___8__1;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeFieldInfoPtr__canInviteUser_5__2;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeFieldInfoPtr__constraints_5__3;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
	}
}
