using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using Il2CppSystem.Threading.Tasks;
using Steamworks.Data;

namespace Steamworks
{
	// Token: 0x020000B5 RID: 181
	[StructLayout(2)]
	public struct Clan
	{
		// Token: 0x06000BBE RID: 3006 RVA: 0x0004FC94 File Offset: 0x0004DE94
		// Note: this type is marked as 'beforefieldinit'.
		static Clan()
		{
			Il2CppClassPointerStore<Clan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Clan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clan>.NativeClassPtr);
			Clan.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan>.NativeClassPtr, "Id");
			Clan.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666184);
			Clan.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666185);
			Clan.NativeMethodInfoPtr_get_Tag_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666186);
			Clan.NativeMethodInfoPtr_get_ChatMemberCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666187);
			Clan.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666188);
			Clan.NativeMethodInfoPtr_get_Public_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666189);
			Clan.NativeMethodInfoPtr_get_Official_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666190);
			Clan.NativeMethodInfoPtr_RequestOfficerList_Public_Task_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666191);
			Clan.NativeMethodInfoPtr_GetOfficers_Public_IEnumerable_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan>.NativeClassPtr, 100666192);
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0004FD8C File Offset: 0x0004DF8C
		[CallerCount(44)]
		[CachedScanResults(RefRangeStart = 315640, RefRangeEnd = 315684, XrefRangeStart = 315640, XrefRangeEnd = 315684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Clan(SteamId id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr__ctor_Public_Void_SteamId_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000BC0 RID: 3008 RVA: 0x0004FDC0 File Offset: 0x0004DFC0
		public unsafe string Name
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946148, XrefRangeEnd = 946151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000BC1 RID: 3009 RVA: 0x0004FDEC File Offset: 0x0004DFEC
		public unsafe string Tag
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946151, XrefRangeEnd = 946154, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_Tag_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000BC2 RID: 3010 RVA: 0x0004FE18 File Offset: 0x0004E018
		public unsafe int ChatMemberCount
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946154, XrefRangeEnd = 946157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_ChatMemberCount_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000BC3 RID: 3011 RVA: 0x0004FE48 File Offset: 0x0004E048
		public unsafe Friend Owner
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946157, XrefRangeEnd = 946160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_Owner_Public_get_Friend_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000BC4 RID: 3012 RVA: 0x0004FE78 File Offset: 0x0004E078
		public unsafe bool Public
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946160, XrefRangeEnd = 946163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_Public_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0004FEA8 File Offset: 0x0004E0A8
		public unsafe bool Official
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946163, XrefRangeEnd = 946166, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_get_Official_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004FED8 File Offset: 0x0004E0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946166, XrefRangeEnd = 946179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<bool> RequestOfficerList()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_RequestOfficerList_Public_Task_1_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<bool>>(intPtr3) : null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004FF0C File Offset: 0x0004E10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946179, XrefRangeEnd = 946184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Friend> GetOfficers()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan.NativeMethodInfoPtr_GetOfficers_Public_IEnumerable_1_Friend_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Friend>>(intPtr3) : null;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00002E99 File Offset: 0x00001099
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Clan>.NativeClassPtr, ref this));
		}

		// Token: 0x04001253 RID: 4691
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x04001254 RID: 4692
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SteamId_0;

		// Token: 0x04001255 RID: 4693
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001256 RID: 4694
		private static readonly IntPtr NativeMethodInfoPtr_get_Tag_Public_get_String_0;

		// Token: 0x04001257 RID: 4695
		private static readonly IntPtr NativeMethodInfoPtr_get_ChatMemberCount_Public_get_Int32_0;

		// Token: 0x04001258 RID: 4696
		private static readonly IntPtr NativeMethodInfoPtr_get_Owner_Public_get_Friend_0;

		// Token: 0x04001259 RID: 4697
		private static readonly IntPtr NativeMethodInfoPtr_get_Public_Public_get_Boolean_0;

		// Token: 0x0400125A RID: 4698
		private static readonly IntPtr NativeMethodInfoPtr_get_Official_Public_get_Boolean_0;

		// Token: 0x0400125B RID: 4699
		private static readonly IntPtr NativeMethodInfoPtr_RequestOfficerList_Public_Task_1_Boolean_0;

		// Token: 0x0400125C RID: 4700
		private static readonly IntPtr NativeMethodInfoPtr_GetOfficers_Public_IEnumerable_1_Friend_0;

		// Token: 0x0400125D RID: 4701
		[FieldOffset(0)]
		public SteamId Id;

		// Token: 0x0200026E RID: 622
		[ObfuscatedName("Steamworks.Clan+<GetOfficers>d__15")]
		public sealed class _GetOfficers_d__15 : Object
		{
			// Token: 0x06001F85 RID: 8069 RVA: 0x0008C96C File Offset: 0x0008AB6C
			// Note: this type is marked as 'beforefieldinit'.
			static _GetOfficers_d__15()
			{
				Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Clan>.NativeClassPtr, "<GetOfficers>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr);
				Clan._GetOfficers_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<>1__state");
				Clan._GetOfficers_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<>2__current");
				Clan._GetOfficers_d__15.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<>l__initialThreadId");
				Clan._GetOfficers_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<>4__this");
				Clan._GetOfficers_d__15.NativeFieldInfoPtr___3____4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<>3__<>4__this");
				Clan._GetOfficers_d__15.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, "<i>5__2");
				Clan._GetOfficers_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666193);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666194);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666195);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666196);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666197);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666198);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666199);
				Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr, 100666200);
			}

			// Token: 0x06001F86 RID: 8070 RVA: 0x0008CAB0 File Offset: 0x0008ACB0
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 3103, RefRangeEnd = 3229, XrefRangeStart = 3103, XrefRangeEnd = 3229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetOfficers_d__15(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clan._GetOfficers_d__15>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F87 RID: 8071 RVA: 0x0008CAF8 File Offset: 0x0008ACF8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F88 RID: 8072 RVA: 0x0008CB2C File Offset: 0x0008AD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946098, XrefRangeEnd = 946103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000813 RID: 2067
			// (get) Token: 0x06001F89 RID: 8073 RVA: 0x0008CB68 File Offset: 0x0008AD68
			public unsafe Friend System.Collections.Generic.IEnumerator<Steamworks.Friend>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001F8A RID: 8074 RVA: 0x0008CBA4 File Offset: 0x0008ADA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946103, XrefRangeEnd = 946108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000814 RID: 2068
			// (get) Token: 0x06001F8B RID: 8075 RVA: 0x0008CBD8 File Offset: 0x0008ADD8
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946108, XrefRangeEnd = 946111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001F8C RID: 8076 RVA: 0x0008CC18 File Offset: 0x0008AE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946111, XrefRangeEnd = 946118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<Friend> System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<Friend>>(intPtr3) : null;
			}

			// Token: 0x06001F8D RID: 8077 RVA: 0x0008CC58 File Offset: 0x0008AE58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._GetOfficers_d__15.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06001F8E RID: 8078 RVA: 0x0000BBFA File Offset: 0x00009DFA
			public _GetOfficers_d__15(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700080D RID: 2061
			// (get) Token: 0x06001F8F RID: 8079 RVA: 0x0008CC98 File Offset: 0x0008AE98
			// (set) Token: 0x06001F90 RID: 8080 RVA: 0x0000BC03 File Offset: 0x00009E03
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700080E RID: 2062
			// (get) Token: 0x06001F91 RID: 8081 RVA: 0x0008CCC0 File Offset: 0x0008AEC0
			// (set) Token: 0x06001F92 RID: 8082 RVA: 0x0000BC1E File Offset: 0x00009E1E
			public unsafe Friend __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___2__current);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___2__current)) = value;
				}
			}

			// Token: 0x1700080F RID: 2063
			// (get) Token: 0x06001F93 RID: 8083 RVA: 0x0008CCE8 File Offset: 0x0008AEE8
			// (set) Token: 0x06001F94 RID: 8084 RVA: 0x0000BC39 File Offset: 0x00009E39
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17000810 RID: 2064
			// (get) Token: 0x06001F95 RID: 8085 RVA: 0x0008CD10 File Offset: 0x0008AF10
			// (set) Token: 0x06001F96 RID: 8086 RVA: 0x0000BC54 File Offset: 0x00009E54
			public unsafe Clan __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000811 RID: 2065
			// (get) Token: 0x06001F97 RID: 8087 RVA: 0x0008CD38 File Offset: 0x0008AF38
			// (set) Token: 0x06001F98 RID: 8088 RVA: 0x0000BC6F File Offset: 0x00009E6F
			public unsafe Clan __3____4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___3____4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr___3____4__this)) = value;
				}
			}

			// Token: 0x17000812 RID: 2066
			// (get) Token: 0x06001F99 RID: 8089 RVA: 0x0008CD60 File Offset: 0x0008AF60
			// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0000BC8A File Offset: 0x00009E8A
			public unsafe int _i_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr__i_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._GetOfficers_d__15.NativeFieldInfoPtr__i_5__2)) = value;
				}
			}

			// Token: 0x04002245 RID: 8773
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002246 RID: 8774
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04002247 RID: 8775
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04002248 RID: 8776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002249 RID: 8777
			private static readonly IntPtr NativeFieldInfoPtr___3____4__this;

			// Token: 0x0400224A RID: 8778
			private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

			// Token: 0x0400224B RID: 8779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400224C RID: 8780
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400224D RID: 8781
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400224E RID: 8782
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_Steamworks_Friend__get_Current_Private_Virtual_Final_New_get_Friend_0;

			// Token: 0x0400224F RID: 8783
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002250 RID: 8784
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04002251 RID: 8785
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerable_Steamworks_Friend__GetEnumerator_Private_Virtual_Final_New_IEnumerator_1_Friend_0;

			// Token: 0x04002252 RID: 8786
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x0200026F RID: 623
		[ObfuscatedName("Steamworks.Clan+<RequestOfficerList>d__14")]
		public sealed class _RequestOfficerList_d__14 : ValueType
		{
			// Token: 0x06001F9B RID: 8091 RVA: 0x0008CD88 File Offset: 0x0008AF88
			// Note: this type is marked as 'beforefieldinit'.
			static _RequestOfficerList_d__14()
			{
				Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Clan>.NativeClassPtr, "<RequestOfficerList>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr);
				Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, "<>1__state");
				Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, "<>t__builder");
				Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, "<>4__this");
				Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, "<>u__1");
				Clan._RequestOfficerList_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, 100666201);
				Clan._RequestOfficerList_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr, 100666202);
			}

			// Token: 0x06001F9C RID: 8092 RVA: 0x0008CE2C File Offset: 0x0008B02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946118, XrefRangeEnd = 946142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._RequestOfficerList_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001F9D RID: 8093 RVA: 0x0008CE64 File Offset: 0x0008B064
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946142, XrefRangeEnd = 946148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Clan._RequestOfficerList_d__14.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001F9E RID: 8094 RVA: 0x0000BCA5 File Offset: 0x00009EA5
			public _RequestOfficerList_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06001F9F RID: 8095 RVA: 0x0000BCAE File Offset: 0x00009EAE
			public _RequestOfficerList_d__14()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Clan._RequestOfficerList_d__14>.NativeClassPtr))
			{
			}

			// Token: 0x17000815 RID: 2069
			// (get) Token: 0x06001FA0 RID: 8096 RVA: 0x0008CEAC File Offset: 0x0008B0AC
			// (set) Token: 0x06001FA1 RID: 8097 RVA: 0x0000BCC0 File Offset: 0x00009EC0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000816 RID: 2070
			// (get) Token: 0x06001FA2 RID: 8098 RVA: 0x0008CED4 File Offset: 0x0008B0D4
			// (set) Token: 0x06001FA3 RID: 8099 RVA: 0x0000BCDB File Offset: 0x00009EDB
			public AsyncTaskMethodBuilder<bool> __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___t__builder);
					return new AsyncTaskMethodBuilder<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncTaskMethodBuilder<bool>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000817 RID: 2071
			// (get) Token: 0x06001FA4 RID: 8100 RVA: 0x0008CF04 File Offset: 0x0008B104
			// (set) Token: 0x06001FA5 RID: 8101 RVA: 0x0000BD09 File Offset: 0x00009F09
			public unsafe Clan __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___4__this);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___4__this)) = value;
				}
			}

			// Token: 0x17000818 RID: 2072
			// (get) Token: 0x06001FA6 RID: 8102 RVA: 0x0008CF2C File Offset: 0x0008B12C
			// (set) Token: 0x06001FA7 RID: 8103 RVA: 0x0000BD24 File Offset: 0x00009F24
			public CallResult<ClanOfficerListResponse_t> __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___u__1);
					return new CallResult<ClanOfficerListResponse_t>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CallResult<ClanOfficerListResponse_t>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Clan._RequestOfficerList_d__14.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CallResult<ClanOfficerListResponse_t>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04002253 RID: 8787
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04002254 RID: 8788
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04002255 RID: 8789
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04002256 RID: 8790
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04002257 RID: 8791
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04002258 RID: 8792
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
