using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace boardgames.matchMaking.commands
{
	// Token: 0x02000119 RID: 281
	public class CanInviteUser : Command
	{
		// Token: 0x06000EB0 RID: 3760 RVA: 0x0003DA2C File Offset: 0x0003BC2C
		// Note: this type is marked as 'beforefieldinit'.
		static CanInviteUser()
		{
			Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.matchMaking.commands", "CanInviteUser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr);
			CanInviteUser.NativeMethodInfoPtr__ctor_Public_Void_Boolean_IDictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr, 100665390);
			CanInviteUser.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr, 100665391);
			CanInviteUser.NativeMethodInfoPtr_get_IsAllowed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr, 100665392);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0003DA98 File Offset: 0x0003BC98
		[CallerCount(55)]
		[CachedScanResults(RefRangeStart = 498694, RefRangeEnd = 498749, XrefRangeStart = 498694, XrefRangeEnd = 498749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanInviteUser(bool notifyUser, IDictionary<string, string> targetUser)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref notifyUser;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetUser);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser.NativeMethodInfoPtr__ctor_Public_Void_Boolean_IDictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x0003DAF4 File Offset: 0x0003BCF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996722, XrefRangeEnd = 996726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CanInviteUser.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06000EB3 RID: 3763 RVA: 0x0003DB40 File Offset: 0x0003BD40
		public unsafe virtual bool IsAllowed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser.NativeMethodInfoPtr_get_IsAllowed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00008E10 File Offset: 0x00007010
		public CanInviteUser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040008E2 RID: 2274
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_IDictionary_2_String_String_0;

		// Token: 0x040008E3 RID: 2275
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040008E4 RID: 2276
		private static readonly IntPtr NativeMethodInfoPtr_get_IsAllowed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0200025A RID: 602
		[ObfuscatedName("boardgames.matchMaking.commands.CanInviteUser+<execute>d__1")]
		public sealed class _execute_d__1 : Object
		{
			// Token: 0x06001BB5 RID: 7093 RVA: 0x00066898 File Offset: 0x00064A98
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__1()
			{
				Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanInviteUser>.NativeClassPtr, "<execute>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr);
				CanInviteUser._execute_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, "<>1__state");
				CanInviteUser._execute_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, "<>2__current");
				CanInviteUser._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665393);
				CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665394);
				CanInviteUser._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665395);
				CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665396);
				CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665397);
				CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr, 100665398);
			}

			// Token: 0x06001BB6 RID: 7094 RVA: 0x00066964 File Offset: 0x00064B64
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__1(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanInviteUser._execute_d__1>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001BB7 RID: 7095 RVA: 0x000669AC File Offset: 0x00064BAC
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BB8 RID: 7096 RVA: 0x000669E0 File Offset: 0x00064BE0
			[CallerCount(0)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06001BB9 RID: 7097 RVA: 0x00066A1C File Offset: 0x00064C1C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BBA RID: 7098 RVA: 0x00066A5C File Offset: 0x00064C5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 996717, XrefRangeEnd = 996722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06001BBB RID: 7099 RVA: 0x00066A90 File Offset: 0x00064C90
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanInviteUser._execute_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001BBC RID: 7100 RVA: 0x0000F02F File Offset: 0x0000D22F
			public _execute_d__1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001BBD RID: 7101 RVA: 0x00066AD0 File Offset: 0x00064CD0
			// (set) Token: 0x06001BBE RID: 7102 RVA: 0x0000F038 File Offset: 0x0000D238
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanInviteUser._execute_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanInviteUser._execute_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06001BBF RID: 7103 RVA: 0x00066AF8 File Offset: 0x00064CF8
			// (set) Token: 0x06001BC0 RID: 7104 RVA: 0x0000F053 File Offset: 0x0000D253
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanInviteUser._execute_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanInviteUser._execute_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040010D3 RID: 4307
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040010D4 RID: 4308
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040010D5 RID: 4309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040010D6 RID: 4310
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010D7 RID: 4311
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040010D8 RID: 4312
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040010D9 RID: 4313
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040010DA RID: 4314
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
