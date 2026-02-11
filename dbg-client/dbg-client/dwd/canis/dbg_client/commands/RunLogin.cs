using System;
using boardgames.menus.commands;
using dwd.core;
using dwd.core.commands;
using dwd.core.data.async;
using dwd.core.notifications;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.canis.dbg_client.commands
{
	// Token: 0x02000079 RID: 121
	public class RunLogin : FailableCommand
	{
		// Token: 0x06000480 RID: 1152 RVA: 0x0002BA5C File Offset: 0x00029C5C
		// Note: this type is marked as 'beforefieldinit'.
		static RunLogin()
		{
			Il2CppClassPointerStore<RunLogin>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dwd.canis.dbg_client.commands", "RunLogin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLogin>.NativeClassPtr);
			RunLogin.NativeFieldInfoPtr_EulaNotAccepted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "EulaNotAccepted");
			RunLogin.NativeFieldInfoPtr_username = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "username");
			RunLogin.NativeFieldInfoPtr_password = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "password");
			RunLogin.NativeFieldInfoPtr_setErrorOnFailure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "setErrorOnFailure");
			RunLogin.NativeFieldInfoPtr__authCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "_authCommand");
			RunLogin.NativeFieldInfoPtr_showSpinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "showSpinner");
			RunLogin.NativeMethodInfoPtr__ctor_Public_Void_IFailable_String_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663977);
			RunLogin.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663978);
			RunLogin.NativeMethodInfoPtr_ShowSpinner_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663979);
			RunLogin.NativeMethodInfoPtr_WithSpinner_Private_IEnumerator_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663980);
			RunLogin.NativeMethodInfoPtr__execute_b__7_0_Private_Void_DBGLogin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663981);
			RunLogin.NativeMethodInfoPtr__execute_b__7_1_Private_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, 100663982);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0002BB7C File Offset: 0x00029D7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 500889, RefRangeEnd = 500891, XrefRangeStart = 500885, XrefRangeEnd = 500889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RunLogin(IFailable authCommand, string username, string password, bool setErrorOnFailure, bool showSpinner = true)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLogin>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(authCommand);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(password);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref setErrorOnFailure;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showSpinner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.NativeMethodInfoPtr__ctor_Public_Void_IFailable_String_String_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0002BC08 File Offset: 0x00029E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500891, XrefRangeEnd = 500896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RunLogin.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0002BC54 File Offset: 0x00029E54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 500896, RefRangeEnd = 500897, XrefRangeStart = 500896, XrefRangeEnd = 500896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowSpinner()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.NativeMethodInfoPtr_ShowSpinner_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0002BC88 File Offset: 0x00029E88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500897, XrefRangeEnd = 500903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator WithSpinner(IEnumerator command)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.NativeMethodInfoPtr_WithSpinner_Private_IEnumerator_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0002BCD8 File Offset: 0x00029ED8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500903, XrefRangeEnd = 500905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__7_0(DBGLogin success)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(success);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.NativeMethodInfoPtr__execute_b__7_0_Private_Void_DBGLogin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002BD1C File Offset: 0x00029F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500905, XrefRangeEnd = 500906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _execute_b__7_1(ErrorInfo loginError)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(loginError));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.NativeMethodInfoPtr__execute_b__7_1_Private_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x0000404D File Offset: 0x0000224D
		public RunLogin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0002BD64 File Offset: 0x00029F64
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00004056 File Offset: 0x00002256
		public unsafe static int EulaNotAccepted
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RunLogin.NativeFieldInfoPtr_EulaNotAccepted, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RunLogin.NativeFieldInfoPtr_EulaNotAccepted, (void*)(&value));
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0002BD80 File Offset: 0x00029F80
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00004064 File Offset: 0x00002264
		public unsafe string username
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_username);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_username), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0002BDA8 File Offset: 0x00029FA8
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00004083 File Offset: 0x00002283
		public unsafe string password
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_password);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_password), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0002BDD0 File Offset: 0x00029FD0
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x000040A2 File Offset: 0x000022A2
		public unsafe bool setErrorOnFailure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_setErrorOnFailure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_setErrorOnFailure)) = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x000040BD File Offset: 0x000022BD
		public unsafe IFailable _authCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr__authCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr__authCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0002BE28 File Offset: 0x0002A028
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x000040DC File Offset: 0x000022DC
		public unsafe bool showSpinner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_showSpinner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.NativeFieldInfoPtr_showSpinner)) = value;
			}
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeFieldInfoPtr_EulaNotAccepted;

		// Token: 0x040002B1 RID: 689
		private static readonly IntPtr NativeFieldInfoPtr_username;

		// Token: 0x040002B2 RID: 690
		private static readonly IntPtr NativeFieldInfoPtr_password;

		// Token: 0x040002B3 RID: 691
		private static readonly IntPtr NativeFieldInfoPtr_setErrorOnFailure;

		// Token: 0x040002B4 RID: 692
		private static readonly IntPtr NativeFieldInfoPtr__authCommand;

		// Token: 0x040002B5 RID: 693
		private static readonly IntPtr NativeFieldInfoPtr_showSpinner;

		// Token: 0x040002B6 RID: 694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFailable_String_String_Boolean_Boolean_0;

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_ShowSpinner_Public_Void_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_WithSpinner_Private_IEnumerator_IEnumerator_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_0_Private_Void_DBGLogin_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_1_Private_Void_ErrorInfo_0;

		// Token: 0x020002F5 RID: 757
		[ObfuscatedName("dwd.canis.dbg_client.commands.RunLogin+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060023BB RID: 9147 RVA: 0x0009365C File Offset: 0x0009185C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr);
				RunLogin.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr, "<>9");
				RunLogin.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr, "<>9__7_3");
				RunLogin.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr, 100663984);
				RunLogin.__c.NativeMethodInfoPtr__execute_b__7_3_Internal_Boolean_IAsyncData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr, 100663985);
			}

			// Token: 0x060023BC RID: 9148 RVA: 0x000936D8 File Offset: 0x000918D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLogin.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023BD RID: 9149 RVA: 0x00093714 File Offset: 0x00091914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500787, XrefRangeEnd = 500794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _execute_b__7_3(IAsyncData d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.__c.NativeMethodInfoPtr__execute_b__7_3_Internal_Boolean_IAsyncData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060023BE RID: 9150 RVA: 0x00012975 File Offset: 0x00010B75
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B7 RID: 2487
			// (get) Token: 0x060023BF RID: 9151 RVA: 0x00093764 File Offset: 0x00091964
			// (set) Token: 0x060023C0 RID: 9152 RVA: 0x0001297E File Offset: 0x00010B7E
			public unsafe static RunLogin.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunLogin.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLogin.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunLogin.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009B8 RID: 2488
			// (get) Token: 0x060023C1 RID: 9153 RVA: 0x0009378C File Offset: 0x0009198C
			// (set) Token: 0x060023C2 RID: 9154 RVA: 0x00012990 File Offset: 0x00010B90
			public unsafe static Func<IAsyncData, bool> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(RunLogin.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAsyncData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(RunLogin.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001675 RID: 5749
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001676 RID: 5750
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x04001677 RID: 5751
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001678 RID: 5752
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__7_3_Internal_Boolean_IAsyncData_0;
		}

		// Token: 0x020002F6 RID: 758
		[ObfuscatedName("dwd.canis.dbg_client.commands.RunLogin+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x060023C3 RID: 9155 RVA: 0x000937B4 File Offset: 0x000919B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr);
				RunLogin.__c__DisplayClass7_0.NativeFieldInfoPtr_asyncDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr, "asyncDatas");
				RunLogin.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr, 100663986);
				RunLogin.__c__DisplayClass7_0.NativeMethodInfoPtr__execute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr, 100663987);
			}

			// Token: 0x060023C4 RID: 9156 RVA: 0x0009381C File Offset: 0x00091A1C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLogin.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023C5 RID: 9157 RVA: 0x00093858 File Offset: 0x00091A58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500794, XrefRangeEnd = 500832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin.__c__DisplayClass7_0.NativeMethodInfoPtr__execute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023C6 RID: 9158 RVA: 0x000129A2 File Offset: 0x00010BA2
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009B9 RID: 2489
			// (get) Token: 0x060023C7 RID: 9159 RVA: 0x0009388C File Offset: 0x00091A8C
			// (set) Token: 0x060023C8 RID: 9160 RVA: 0x000129AB File Offset: 0x00010BAB
			public unsafe List<IAsyncData> asyncDatas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.__c__DisplayClass7_0.NativeFieldInfoPtr_asyncDatas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IAsyncData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin.__c__DisplayClass7_0.NativeFieldInfoPtr_asyncDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001679 RID: 5753
			private static readonly IntPtr NativeFieldInfoPtr_asyncDatas;

			// Token: 0x0400167A RID: 5754
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400167B RID: 5755
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__2_Internal_Void_0;
		}

		// Token: 0x020002F7 RID: 759
		[ObfuscatedName("dwd.canis.dbg_client.commands.RunLogin+<WithSpinner>d__9")]
		public sealed class _WithSpinner_d__9 : Object
		{
			// Token: 0x060023C9 RID: 9161 RVA: 0x000938BC File Offset: 0x00091ABC
			// Note: this type is marked as 'beforefieldinit'.
			static _WithSpinner_d__9()
			{
				Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "<WithSpinner>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr);
				RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, "<>1__state");
				RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, "<>2__current");
				RunLogin._WithSpinner_d__9.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, "command");
				RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, "<>4__this");
				RunLogin._WithSpinner_d__9.NativeFieldInfoPtr__showingSpinner_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, "<showingSpinner>5__2");
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663988);
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663989);
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663990);
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663991);
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663992);
				RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr, 100663993);
			}

			// Token: 0x060023CA RID: 9162 RVA: 0x000939C4 File Offset: 0x00091BC4
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _WithSpinner_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLogin._WithSpinner_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023CB RID: 9163 RVA: 0x00093A0C File Offset: 0x00091C0C
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023CC RID: 9164 RVA: 0x00093A40 File Offset: 0x00091C40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500832, XrefRangeEnd = 500849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009BF RID: 2495
			// (get) Token: 0x060023CD RID: 9165 RVA: 0x00093A7C File Offset: 0x00091C7C
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023CE RID: 9166 RVA: 0x00093ABC File Offset: 0x00091CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500849, XrefRangeEnd = 500854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C0 RID: 2496
			// (get) Token: 0x060023CF RID: 9167 RVA: 0x00093AF0 File Offset: 0x00091CF0
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._WithSpinner_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023D0 RID: 9168 RVA: 0x000129CA File Offset: 0x00010BCA
			public _WithSpinner_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009BA RID: 2490
			// (get) Token: 0x060023D1 RID: 9169 RVA: 0x00093B30 File Offset: 0x00091D30
			// (set) Token: 0x060023D2 RID: 9170 RVA: 0x000129D3 File Offset: 0x00010BD3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009BB RID: 2491
			// (get) Token: 0x060023D3 RID: 9171 RVA: 0x00093B58 File Offset: 0x00091D58
			// (set) Token: 0x060023D4 RID: 9172 RVA: 0x000129EE File Offset: 0x00010BEE
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BC RID: 2492
			// (get) Token: 0x060023D5 RID: 9173 RVA: 0x00093B88 File Offset: 0x00091D88
			// (set) Token: 0x060023D6 RID: 9174 RVA: 0x00012A0D File Offset: 0x00010C0D
			public unsafe IEnumerator command
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr_command);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BD RID: 2493
			// (get) Token: 0x060023D7 RID: 9175 RVA: 0x00093BB8 File Offset: 0x00091DB8
			// (set) Token: 0x060023D8 RID: 9176 RVA: 0x00012A2C File Offset: 0x00010C2C
			public unsafe RunLogin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLogin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009BE RID: 2494
			// (get) Token: 0x060023D9 RID: 9177 RVA: 0x00093BE8 File Offset: 0x00091DE8
			// (set) Token: 0x060023DA RID: 9178 RVA: 0x00012A4B File Offset: 0x00010C4B
			public unsafe bool _showingSpinner_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr__showingSpinner_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._WithSpinner_d__9.NativeFieldInfoPtr__showingSpinner_5__2)) = value;
				}
			}

			// Token: 0x0400167C RID: 5756
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400167D RID: 5757
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400167E RID: 5758
			private static readonly IntPtr NativeFieldInfoPtr_command;

			// Token: 0x0400167F RID: 5759
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001680 RID: 5760
			private static readonly IntPtr NativeFieldInfoPtr__showingSpinner_5__2;

			// Token: 0x04001681 RID: 5761
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001682 RID: 5762
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001683 RID: 5763
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001684 RID: 5764
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001685 RID: 5765
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001686 RID: 5766
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020002F8 RID: 760
		[ObfuscatedName("dwd.canis.dbg_client.commands.RunLogin+<execute>d__7")]
		public sealed class _execute_d__7 : Object
		{
			// Token: 0x060023DB RID: 9179 RVA: 0x00093C10 File Offset: 0x00091E10
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__7()
			{
				Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RunLogin>.NativeClassPtr, "<execute>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr);
				RunLogin._execute_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, "<>1__state");
				RunLogin._execute_d__7.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, "<>2__current");
				RunLogin._execute_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, "<>4__this");
				RunLogin._execute_d__7.NativeFieldInfoPtr__notifications_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, "<notifications>5__2");
				RunLogin._execute_d__7.NativeFieldInfoPtr__dbgLogin_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, "<dbgLogin>5__3");
				RunLogin._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663994);
				RunLogin._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663995);
				RunLogin._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663996);
				RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663997);
				RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663998);
				RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr, 100663999);
			}

			// Token: 0x060023DC RID: 9180 RVA: 0x00093D18 File Offset: 0x00091F18
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__7(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RunLogin._execute_d__7>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060023DD RID: 9181 RVA: 0x00093D60 File Offset: 0x00091F60
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060023DE RID: 9182 RVA: 0x00093D94 File Offset: 0x00091F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500854, XrefRangeEnd = 500880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170009C6 RID: 2502
			// (get) Token: 0x060023DF RID: 9183 RVA: 0x00093DD0 File Offset: 0x00091FD0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023E0 RID: 9184 RVA: 0x00093E10 File Offset: 0x00092010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 500880, XrefRangeEnd = 500885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170009C7 RID: 2503
			// (get) Token: 0x060023E1 RID: 9185 RVA: 0x00093E44 File Offset: 0x00092044
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RunLogin._execute_d__7.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060023E2 RID: 9186 RVA: 0x00012A66 File Offset: 0x00010C66
			public _execute_d__7(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170009C1 RID: 2497
			// (get) Token: 0x060023E3 RID: 9187 RVA: 0x00093E84 File Offset: 0x00092084
			// (set) Token: 0x060023E4 RID: 9188 RVA: 0x00012A6F File Offset: 0x00010C6F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170009C2 RID: 2498
			// (get) Token: 0x060023E5 RID: 9189 RVA: 0x00093EAC File Offset: 0x000920AC
			// (set) Token: 0x060023E6 RID: 9190 RVA: 0x00012A8A File Offset: 0x00010C8A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C3 RID: 2499
			// (get) Token: 0x060023E7 RID: 9191 RVA: 0x00093EDC File Offset: 0x000920DC
			// (set) Token: 0x060023E8 RID: 9192 RVA: 0x00012AA9 File Offset: 0x00010CA9
			public unsafe RunLogin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RunLogin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C4 RID: 2500
			// (get) Token: 0x060023E9 RID: 9193 RVA: 0x00093F0C File Offset: 0x0009210C
			// (set) Token: 0x060023EA RID: 9194 RVA: 0x00012AC8 File Offset: 0x00010CC8
			public unsafe Notifications _notifications_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr__notifications_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Notifications>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr__notifications_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170009C5 RID: 2501
			// (get) Token: 0x060023EB RID: 9195 RVA: 0x00093F3C File Offset: 0x0009213C
			// (set) Token: 0x060023EC RID: 9196 RVA: 0x00012AE7 File Offset: 0x00010CE7
			public unsafe DBGLogin _dbgLogin_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr__dbgLogin_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLogin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RunLogin._execute_d__7.NativeFieldInfoPtr__dbgLogin_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001687 RID: 5767
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001688 RID: 5768
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001689 RID: 5769
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400168A RID: 5770
			private static readonly IntPtr NativeFieldInfoPtr__notifications_5__2;

			// Token: 0x0400168B RID: 5771
			private static readonly IntPtr NativeFieldInfoPtr__dbgLogin_5__3;

			// Token: 0x0400168C RID: 5772
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400168D RID: 5773
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400168E RID: 5774
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400168F RID: 5775
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001690 RID: 5776
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001691 RID: 5777
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
