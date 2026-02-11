using System;
using Canis.messages;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Networking.game.messages.pbm;

namespace boardgames.menus.commands
{
	// Token: 0x02000240 RID: 576
	public class ShowGameResigned : Command
	{
		// Token: 0x060019FE RID: 6654 RVA: 0x0007213C File Offset: 0x0007033C
		// Note: this type is marked as 'beforefieldinit'.
		static ShowGameResigned()
		{
			Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "ShowGameResigned");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr);
			ShowGameResigned.NativeFieldInfoPtr_usernames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, "usernames");
			ShowGameResigned.NativeMethodInfoPtr__ctor_Public_Void_PBMGameResigned_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, 100667434);
			ShowGameResigned.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, 100667435);
			ShowGameResigned.NativeMethodInfoPtr_getLocalUsername_Private_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, 100667436);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000721BC File Offset: 0x000703BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 531206, RefRangeEnd = 531207, XrefRangeStart = 531185, XrefRangeEnd = 531206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShowGameResigned(PBMGameResigned gameResigned)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(gameResigned);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned.NativeMethodInfoPtr__ctor_Public_Void_PBMGameResigned_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x00072208 File Offset: 0x00070408
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531207, XrefRangeEnd = 531211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShowGameResigned.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00072254 File Offset: 0x00070454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531211, XrefRangeEnd = 531223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string getLocalUsername()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned.NativeMethodInfoPtr_getLocalUsername_Private_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000E3BF File Offset: 0x0000C5BF
		public ShowGameResigned(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0007228C File Offset: 0x0007048C
		// (set) Token: 0x06001A04 RID: 6660 RVA: 0x0000E3C8 File Offset: 0x0000C5C8
		public unsafe IEnumerable<string> usernames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned.NativeFieldInfoPtr_usernames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned.NativeFieldInfoPtr_usernames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001032 RID: 4146
		private static readonly IntPtr NativeFieldInfoPtr_usernames;

		// Token: 0x04001033 RID: 4147
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PBMGameResigned_0;

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04001035 RID: 4149
		private static readonly IntPtr NativeMethodInfoPtr_getLocalUsername_Private_String_0;

		// Token: 0x02000430 RID: 1072
		[ObfuscatedName("boardgames.menus.commands.ShowGameResigned+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060032C3 RID: 12995 RVA: 0x000BFEFC File Offset: 0x000BE0FC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr);
				ShowGameResigned.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr, "<>9");
				ShowGameResigned.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr, "<>9__1_0");
				ShowGameResigned.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr, 100667438);
				ShowGameResigned.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_String_AccountIDUsernameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr, 100667439);
			}

			// Token: 0x060032C4 RID: 12996 RVA: 0x000BFF78 File Offset: 0x000BE178
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGameResigned.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032C5 RID: 12997 RVA: 0x000BFFB4 File Offset: 0x000BE1B4
			[CallerCount(0)]
			public unsafe string __ctor_b__1_0(AccountIDUsernameMetadata slot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(slot);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned.__c.NativeMethodInfoPtr___ctor_b__1_0_Internal_String_AccountIDUsernameMetadata_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060032C6 RID: 12998 RVA: 0x0001A3BB File Offset: 0x000185BB
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ECD RID: 3789
			// (get) Token: 0x060032C7 RID: 12999 RVA: 0x000BFFFC File Offset: 0x000BE1FC
			// (set) Token: 0x060032C8 RID: 13000 RVA: 0x0001A3C4 File Offset: 0x000185C4
			public unsafe static ShowGameResigned.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShowGameResigned.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShowGameResigned.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShowGameResigned.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000ECE RID: 3790
			// (get) Token: 0x060032C9 RID: 13001 RVA: 0x000C0024 File Offset: 0x000BE224
			// (set) Token: 0x060032CA RID: 13002 RVA: 0x0001A3D6 File Offset: 0x000185D6
			public unsafe static Func<AccountIDUsernameMetadata, string> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShowGameResigned.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AccountIDUsernameMetadata, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShowGameResigned.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F56 RID: 8022
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F57 RID: 8023
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001F58 RID: 8024
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F59 RID: 8025
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__1_0_Internal_String_AccountIDUsernameMetadata_0;
		}

		// Token: 0x02000431 RID: 1073
		[ObfuscatedName("boardgames.menus.commands.ShowGameResigned+<execute>d__2")]
		public sealed class _execute_d__2 : Object
		{
			// Token: 0x060032CB RID: 13003 RVA: 0x000C004C File Offset: 0x000BE24C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__2()
			{
				Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShowGameResigned>.NativeClassPtr, "<execute>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr);
				ShowGameResigned._execute_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, "<>1__state");
				ShowGameResigned._execute_d__2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, "<>2__current");
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667440);
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667441);
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667442);
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667443);
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667444);
				ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr, 100667445);
			}

			// Token: 0x060032CC RID: 13004 RVA: 0x000C0118 File Offset: 0x000BE318
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__2(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShowGameResigned._execute_d__2>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060032CD RID: 13005 RVA: 0x000C0160 File Offset: 0x000BE360
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060032CE RID: 13006 RVA: 0x000C0194 File Offset: 0x000BE394
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531175, XrefRangeEnd = 531180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000ED1 RID: 3793
			// (get) Token: 0x060032CF RID: 13007 RVA: 0x000C01D0 File Offset: 0x000BE3D0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032D0 RID: 13008 RVA: 0x000C0210 File Offset: 0x000BE410
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531180, XrefRangeEnd = 531185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000ED2 RID: 3794
			// (get) Token: 0x060032D1 RID: 13009 RVA: 0x000C0244 File Offset: 0x000BE444
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShowGameResigned._execute_d__2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060032D2 RID: 13010 RVA: 0x0001A3E8 File Offset: 0x000185E8
			public _execute_d__2(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000ECF RID: 3791
			// (get) Token: 0x060032D3 RID: 13011 RVA: 0x000C0284 File Offset: 0x000BE484
			// (set) Token: 0x060032D4 RID: 13012 RVA: 0x0001A3F1 File Offset: 0x000185F1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned._execute_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned._execute_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000ED0 RID: 3792
			// (get) Token: 0x060032D5 RID: 13013 RVA: 0x000C02AC File Offset: 0x000BE4AC
			// (set) Token: 0x060032D6 RID: 13014 RVA: 0x0001A40C File Offset: 0x0001860C
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned._execute_d__2.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShowGameResigned._execute_d__2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F5A RID: 8026
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001F5B RID: 8027
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001F5C RID: 8028
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001F5D RID: 8029
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F5E RID: 8030
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001F5F RID: 8031
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001F60 RID: 8032
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001F61 RID: 8033
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
