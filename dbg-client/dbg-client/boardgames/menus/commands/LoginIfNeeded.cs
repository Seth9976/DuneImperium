using System;
using dwd.canis.dbg_client.commands;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.commands
{
	// Token: 0x0200020E RID: 526
	public class LoginIfNeeded : FailableCommand
	{
		// Token: 0x0600182E RID: 6190 RVA: 0x0006C1C0 File Offset: 0x0006A3C0
		// Note: this type is marked as 'beforefieldinit'.
		static LoginIfNeeded()
		{
			Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "LoginIfNeeded");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr);
			LoginIfNeeded.NativeFieldInfoPtr_Canceled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "Canceled");
			LoginIfNeeded.NativeFieldInfoPtr_EulaNotAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "EulaNotAccepted");
			LoginIfNeeded.NativeFieldInfoPtr_onlyAuto = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "onlyAuto");
			LoginIfNeeded.NativeFieldInfoPtr_loginCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "loginCommand");
			LoginIfNeeded.NativeFieldInfoPtr_autoLoginCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "autoLoginCommand");
			LoginIfNeeded.NativeMethodInfoPtr__ctor_Public_Void_Boolean_RunLoginPromptFlow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, 100666844);
			LoginIfNeeded.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, 100666845);
			LoginIfNeeded.NativeMethodInfoPtr_CanAutoLogin_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, 100666846);
			LoginIfNeeded.NativeMethodInfoPtr_SSOEnabled_Public_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, 100666847);
			LoginIfNeeded.NativeMethodInfoPtr_showErrorBasedOnStatus_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, 100666848);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x0006C2B8 File Offset: 0x0006A4B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 526557, RefRangeEnd = 526563, XrefRangeStart = 526555, XrefRangeEnd = 526557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoginIfNeeded(bool onlyAuto = false, RunLoginPromptFlow loginCommand = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyAuto;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loginCommand);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.NativeMethodInfoPtr__ctor_Public_Void_Boolean_RunLoginPromptFlow_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x0006C314 File Offset: 0x0006A514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526563, XrefRangeEnd = 526568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoginIfNeeded.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x0006C360 File Offset: 0x0006A560
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526568, XrefRangeEnd = 526583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CanAutoLogin()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.NativeMethodInfoPtr_CanAutoLogin_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x0006C390 File Offset: 0x0006A590
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool SSOEnabled()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.NativeMethodInfoPtr_SSOEnabled_Public_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x0006C3C0 File Offset: 0x0006A5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526583, XrefRangeEnd = 526588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator showErrorBasedOnStatus()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.NativeMethodInfoPtr_showErrorBasedOnStatus_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x0000D679 File Offset: 0x0000B879
		public LoginIfNeeded(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001835 RID: 6197 RVA: 0x0006C400 File Offset: 0x0006A600
		// (set) Token: 0x06001836 RID: 6198 RVA: 0x0000D682 File Offset: 0x0000B882
		public unsafe static int Canceled
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LoginIfNeeded.NativeFieldInfoPtr_Canceled, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginIfNeeded.NativeFieldInfoPtr_Canceled, (void*)(&value));
			}
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001837 RID: 6199 RVA: 0x0006C41C File Offset: 0x0006A61C
		// (set) Token: 0x06001838 RID: 6200 RVA: 0x0000D690 File Offset: 0x0000B890
		public unsafe static int EulaNotAccepted
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(LoginIfNeeded.NativeFieldInfoPtr_EulaNotAccepted, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LoginIfNeeded.NativeFieldInfoPtr_EulaNotAccepted, (void*)(&value));
			}
		}

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001839 RID: 6201 RVA: 0x0006C438 File Offset: 0x0006A638
		// (set) Token: 0x0600183A RID: 6202 RVA: 0x0000D69E File Offset: 0x0000B89E
		public unsafe bool onlyAuto
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_onlyAuto);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_onlyAuto)) = value;
			}
		}

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x0600183B RID: 6203 RVA: 0x0006C460 File Offset: 0x0006A660
		// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000D6B9 File Offset: 0x0000B8B9
		public unsafe RunLoginPromptFlow loginCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_loginCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_loginCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x0600183D RID: 6205 RVA: 0x0006C490 File Offset: 0x0006A690
		// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public unsafe RunLogin autoLoginCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_autoLoginCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLogin>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.NativeFieldInfoPtr_autoLoginCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F26 RID: 3878
		private static readonly IntPtr NativeFieldInfoPtr_Canceled;

		// Token: 0x04000F27 RID: 3879
		private static readonly IntPtr NativeFieldInfoPtr_EulaNotAccepted;

		// Token: 0x04000F28 RID: 3880
		private static readonly IntPtr NativeFieldInfoPtr_onlyAuto;

		// Token: 0x04000F29 RID: 3881
		private static readonly IntPtr NativeFieldInfoPtr_loginCommand;

		// Token: 0x04000F2A RID: 3882
		private static readonly IntPtr NativeFieldInfoPtr_autoLoginCommand;

		// Token: 0x04000F2B RID: 3883
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_RunLoginPromptFlow_0;

		// Token: 0x04000F2C RID: 3884
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F2D RID: 3885
		private static readonly IntPtr NativeMethodInfoPtr_CanAutoLogin_Private_Static_Boolean_0;

		// Token: 0x04000F2E RID: 3886
		private static readonly IntPtr NativeMethodInfoPtr_SSOEnabled_Public_Static_Boolean_0;

		// Token: 0x04000F2F RID: 3887
		private static readonly IntPtr NativeMethodInfoPtr_showErrorBasedOnStatus_Private_IEnumerator_0;

		// Token: 0x020003DE RID: 990
		[ObfuscatedName("boardgames.menus.commands.LoginIfNeeded+<>c__DisplayClass6_0")]
		public sealed class __c__DisplayClass6_0 : Object
		{
			// Token: 0x06002E15 RID: 11797 RVA: 0x000B216C File Offset: 0x000B036C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "<>c__DisplayClass6_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr);
				LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr, "<>4__this");
				LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr_runningLogin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr, "runningLogin");
				LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr, 100666849);
				LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_LoginIfNeeded_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr, 100666850);
				LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr, 100666851);
			}

			// Token: 0x06002E16 RID: 11798 RVA: 0x000B21FC File Offset: 0x000B03FC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginIfNeeded.__c__DisplayClass6_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E17 RID: 11799 RVA: 0x000B2238 File Offset: 0x000B0438
			[CallerCount(0)]
			public unsafe bool _execute_b__0(LoginIfNeeded c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__0_Internal_Boolean_LoginIfNeeded_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06002E18 RID: 11800 RVA: 0x000B2288 File Offset: 0x000B0488
			[CallerCount(0)]
			public unsafe bool _execute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded.__c__DisplayClass6_0.NativeMethodInfoPtr__execute_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06002E19 RID: 11801 RVA: 0x00017D1D File Offset: 0x00015F1D
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D1D RID: 3357
			// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000B22C4 File Offset: 0x000B04C4
			// (set) Token: 0x06002E1B RID: 11803 RVA: 0x00017D26 File Offset: 0x00015F26
			public unsafe LoginIfNeeded __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D1E RID: 3358
			// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000B22F4 File Offset: 0x000B04F4
			// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00017D45 File Offset: 0x00015F45
			public unsafe LoginIfNeeded runningLogin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr_runningLogin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded.__c__DisplayClass6_0.NativeFieldInfoPtr_runningLogin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C8A RID: 7306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C8B RID: 7307
			private static readonly IntPtr NativeFieldInfoPtr_runningLogin;

			// Token: 0x04001C8C RID: 7308
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C8D RID: 7309
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__0_Internal_Boolean_LoginIfNeeded_0;

			// Token: 0x04001C8E RID: 7310
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Boolean_0;
		}

		// Token: 0x020003DF RID: 991
		[ObfuscatedName("boardgames.menus.commands.LoginIfNeeded+<execute>d__6")]
		public sealed class _execute_d__6 : Object
		{
			// Token: 0x06002E1E RID: 11806 RVA: 0x000B2324 File Offset: 0x000B0524
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__6()
			{
				Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "<execute>d__6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr);
				LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, "<>1__state");
				LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, "<>2__current");
				LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, "<>4__this");
				LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLoginPromptFlow_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, "<runLoginPromptFlow>5__2");
				LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLogin_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, "<runLogin>5__3");
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666852);
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666853);
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666854);
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666855);
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666856);
				LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr, 100666857);
			}

			// Token: 0x06002E1F RID: 11807 RVA: 0x000B242C File Offset: 0x000B062C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__6(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginIfNeeded._execute_d__6>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E20 RID: 11808 RVA: 0x000B2474 File Offset: 0x000B0674
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E21 RID: 11809 RVA: 0x000B24A8 File Offset: 0x000B06A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526323, XrefRangeEnd = 526457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D24 RID: 3364
			// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000B24E4 File Offset: 0x000B06E4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E23 RID: 11811 RVA: 0x000B2524 File Offset: 0x000B0724
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526457, XrefRangeEnd = 526462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D25 RID: 3365
			// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000B2558 File Offset: 0x000B0758
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._execute_d__6.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E25 RID: 11813 RVA: 0x00017D64 File Offset: 0x00015F64
			public _execute_d__6(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D1F RID: 3359
			// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000B2598 File Offset: 0x000B0798
			// (set) Token: 0x06002E27 RID: 11815 RVA: 0x00017D6D File Offset: 0x00015F6D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D20 RID: 3360
			// (get) Token: 0x06002E28 RID: 11816 RVA: 0x000B25C0 File Offset: 0x000B07C0
			// (set) Token: 0x06002E29 RID: 11817 RVA: 0x00017D88 File Offset: 0x00015F88
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06002E2A RID: 11818 RVA: 0x000B25F0 File Offset: 0x000B07F0
			// (set) Token: 0x06002E2B RID: 11819 RVA: 0x00017DA7 File Offset: 0x00015FA7
			public unsafe LoginIfNeeded __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x06002E2C RID: 11820 RVA: 0x000B2620 File Offset: 0x000B0820
			// (set) Token: 0x06002E2D RID: 11821 RVA: 0x00017DC6 File Offset: 0x00015FC6
			public unsafe RunLoginPromptFlow _runLoginPromptFlow_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLoginPromptFlow_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLoginPromptFlow>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLoginPromptFlow_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06002E2E RID: 11822 RVA: 0x000B2650 File Offset: 0x000B0850
			// (set) Token: 0x06002E2F RID: 11823 RVA: 0x00017DE5 File Offset: 0x00015FE5
			public unsafe RunLogin _runLogin_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLogin_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLogin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._execute_d__6.NativeFieldInfoPtr__runLogin_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C8F RID: 7311
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C90 RID: 7312
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C91 RID: 7313
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C92 RID: 7314
			private static readonly IntPtr NativeFieldInfoPtr__runLoginPromptFlow_5__2;

			// Token: 0x04001C93 RID: 7315
			private static readonly IntPtr NativeFieldInfoPtr__runLogin_5__3;

			// Token: 0x04001C94 RID: 7316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C95 RID: 7317
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C96 RID: 7318
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C97 RID: 7319
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C98 RID: 7320
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C99 RID: 7321
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020003E0 RID: 992
		[ObfuscatedName("boardgames.menus.commands.LoginIfNeeded+<showErrorBasedOnStatus>d__9")]
		public sealed class _showErrorBasedOnStatus_d__9 : Object
		{
			// Token: 0x06002E30 RID: 11824 RVA: 0x000B2680 File Offset: 0x000B0880
			// Note: this type is marked as 'beforefieldinit'.
			static _showErrorBasedOnStatus_d__9()
			{
				Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LoginIfNeeded>.NativeClassPtr, "<showErrorBasedOnStatus>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, "<>1__state");
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, "<>2__current");
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, "<>4__this");
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666858);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666859);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666860);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666861);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666862);
				LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr, 100666863);
			}

			// Token: 0x06002E31 RID: 11825 RVA: 0x000B2760 File Offset: 0x000B0960
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _showErrorBasedOnStatus_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoginIfNeeded._showErrorBasedOnStatus_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002E32 RID: 11826 RVA: 0x000B27A8 File Offset: 0x000B09A8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002E33 RID: 11827 RVA: 0x000B27DC File Offset: 0x000B09DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526462, XrefRangeEnd = 526534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D29 RID: 3369
			// (get) Token: 0x06002E34 RID: 11828 RVA: 0x000B2818 File Offset: 0x000B0A18
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E35 RID: 11829 RVA: 0x000B2858 File Offset: 0x000B0A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526534, XrefRangeEnd = 526555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D2A RID: 3370
			// (get) Token: 0x06002E36 RID: 11830 RVA: 0x000B288C File Offset: 0x000B0A8C
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002E37 RID: 11831 RVA: 0x00017E04 File Offset: 0x00016004
			public _showErrorBasedOnStatus_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D26 RID: 3366
			// (get) Token: 0x06002E38 RID: 11832 RVA: 0x000B28CC File Offset: 0x000B0ACC
			// (set) Token: 0x06002E39 RID: 11833 RVA: 0x00017E0D File Offset: 0x0001600D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D27 RID: 3367
			// (get) Token: 0x06002E3A RID: 11834 RVA: 0x000B28F4 File Offset: 0x000B0AF4
			// (set) Token: 0x06002E3B RID: 11835 RVA: 0x00017E28 File Offset: 0x00016028
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D28 RID: 3368
			// (get) Token: 0x06002E3C RID: 11836 RVA: 0x000B2924 File Offset: 0x000B0B24
			// (set) Token: 0x06002E3D RID: 11837 RVA: 0x00017E47 File Offset: 0x00016047
			public unsafe LoginIfNeeded __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoginIfNeeded>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoginIfNeeded._showErrorBasedOnStatus_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C9A RID: 7322
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C9B RID: 7323
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C9C RID: 7324
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C9D RID: 7325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C9E RID: 7326
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C9F RID: 7327
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001CA0 RID: 7328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001CA1 RID: 7329
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001CA2 RID: 7330
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
