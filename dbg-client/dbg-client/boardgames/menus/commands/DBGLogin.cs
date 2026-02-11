using System;
using boardgames.account;
using Canis.utils.ids;
using dwd.core;
using dwd.core.account;
using dwd.core.commands;
using dwd.core.networking.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using offlineChallenges;
using UnityEngine.Networking;

namespace boardgames.menus.commands
{
	// Token: 0x0200020C RID: 524
	public class DBGLogin : FailableCommand
	{
		// Token: 0x06001811 RID: 6161 RVA: 0x0006BB80 File Offset: 0x00069D80
		// Note: this type is marked as 'beforefieldinit'.
		static DBGLogin()
		{
			Il2CppClassPointerStore<DBGLogin>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.commands", "DBGLogin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr);
			DBGLogin.NativeFieldInfoPtr__Screenname_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<Screenname>k__BackingField");
			DBGLogin.NativeFieldInfoPtr__ScreennameID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<ScreennameID>k__BackingField");
			DBGLogin.NativeFieldInfoPtr__AccountID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<AccountID>k__BackingField");
			DBGLogin.NativeFieldInfoPtr_command = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "command");
			DBGLogin.NativeFieldInfoPtr__Interrupted_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<Interrupted>k__BackingField");
			DBGLogin.NativeMethodInfoPtr_get_Screenname_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666813);
			DBGLogin.NativeMethodInfoPtr_set_Screenname_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666814);
			DBGLogin.NativeMethodInfoPtr_get_ScreennameID_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666815);
			DBGLogin.NativeMethodInfoPtr_set_ScreennameID_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666816);
			DBGLogin.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666817);
			DBGLogin.NativeMethodInfoPtr_set_AccountID_Private_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666818);
			DBGLogin.NativeMethodInfoPtr__ctor_Public_Void_IFailable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666819);
			DBGLogin.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666820);
			DBGLogin.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666821);
			DBGLogin.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666822);
			DBGLogin.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, 100666823);
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x06001812 RID: 6162 RVA: 0x0006BCF0 File Offset: 0x00069EF0
		// (set) Token: 0x06001813 RID: 6163 RVA: 0x0006BD28 File Offset: 0x00069F28
		public unsafe string Screenname
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_get_Screenname_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_set_Screenname_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001814 RID: 6164 RVA: 0x0006BD6C File Offset: 0x00069F6C
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x0006BDA4 File Offset: 0x00069FA4
		public unsafe string ScreennameID
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_get_ScreennameID_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_set_ScreennameID_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001816 RID: 6166 RVA: 0x0006BDE8 File Offset: 0x00069FE8
		// (set) Token: 0x06001817 RID: 6167 RVA: 0x0006BE28 File Offset: 0x0006A028
		public unsafe AccountID AccountID
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_set_AccountID_Private_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x0006BE6C File Offset: 0x0006A06C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526261, XrefRangeEnd = 526263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGLogin(IFailable command)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr__ctor_Public_Void_IFailable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0006BEB8 File Offset: 0x0006A0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526263, XrefRangeEnd = 526268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGLogin.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0006BF04 File Offset: 0x0006A104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526268, XrefRangeEnd = 526269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interrupt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x0006BF38 File Offset: 0x0006A138
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x0006BF74 File Offset: 0x0006A174
		public unsafe virtual bool Interrupted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0000D5B1 File Offset: 0x0000B7B1
		public DBGLogin(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600181E RID: 6174 RVA: 0x0006BFB4 File Offset: 0x0006A1B4
		// (set) Token: 0x0600181F RID: 6175 RVA: 0x0000D5BA File Offset: 0x0000B7BA
		public unsafe string _Screenname_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__Screenname_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__Screenname_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001820 RID: 6176 RVA: 0x0006BFDC File Offset: 0x0006A1DC
		// (set) Token: 0x06001821 RID: 6177 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		public unsafe string _ScreennameID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__ScreennameID_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__ScreennameID_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001822 RID: 6178 RVA: 0x0006C004 File Offset: 0x0006A204
		// (set) Token: 0x06001823 RID: 6179 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		public unsafe AccountID _AccountID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__AccountID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__AccountID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001824 RID: 6180 RVA: 0x0006C034 File Offset: 0x0006A234
		// (set) Token: 0x06001825 RID: 6181 RVA: 0x0000D617 File Offset: 0x0000B817
		public unsafe IFailable command
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr_command);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IFailable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr_command), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x06001826 RID: 6182 RVA: 0x0006C064 File Offset: 0x0006A264
		// (set) Token: 0x06001827 RID: 6183 RVA: 0x0000D636 File Offset: 0x0000B836
		public unsafe bool _Interrupted_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__Interrupted_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.NativeFieldInfoPtr__Interrupted_k__BackingField)) = value;
			}
		}

		// Token: 0x04000F13 RID: 3859
		private static readonly IntPtr NativeFieldInfoPtr__Screenname_k__BackingField;

		// Token: 0x04000F14 RID: 3860
		private static readonly IntPtr NativeFieldInfoPtr__ScreennameID_k__BackingField;

		// Token: 0x04000F15 RID: 3861
		private static readonly IntPtr NativeFieldInfoPtr__AccountID_k__BackingField;

		// Token: 0x04000F16 RID: 3862
		private static readonly IntPtr NativeFieldInfoPtr_command;

		// Token: 0x04000F17 RID: 3863
		private static readonly IntPtr NativeFieldInfoPtr__Interrupted_k__BackingField;

		// Token: 0x04000F18 RID: 3864
		private static readonly IntPtr NativeMethodInfoPtr_get_Screenname_Public_get_String_0;

		// Token: 0x04000F19 RID: 3865
		private static readonly IntPtr NativeMethodInfoPtr_set_Screenname_Private_set_Void_String_0;

		// Token: 0x04000F1A RID: 3866
		private static readonly IntPtr NativeMethodInfoPtr_get_ScreennameID_Public_get_String_0;

		// Token: 0x04000F1B RID: 3867
		private static readonly IntPtr NativeMethodInfoPtr_set_ScreennameID_Private_set_Void_String_0;

		// Token: 0x04000F1C RID: 3868
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountID_Public_get_AccountID_0;

		// Token: 0x04000F1D RID: 3869
		private static readonly IntPtr NativeMethodInfoPtr_set_AccountID_Private_set_Void_AccountID_0;

		// Token: 0x04000F1E RID: 3870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IFailable_0;

		// Token: 0x04000F1F RID: 3871
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x04000F20 RID: 3872
		private static readonly IntPtr NativeMethodInfoPtr_Interrupt_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000F21 RID: 3873
		private static readonly IntPtr NativeMethodInfoPtr_get_Interrupted_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000F22 RID: 3874
		private static readonly IntPtr NativeMethodInfoPtr_set_Interrupted_Private_set_Void_Boolean_0;

		// Token: 0x020003DA RID: 986
		[ObfuscatedName("boardgames.menus.commands.DBGLogin+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06002DDE RID: 11742 RVA: 0x000B1774 File Offset: 0x000AF974
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr);
				DBGLogin.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, "<>9");
				DBGLogin.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, "<>9__14_0");
				DBGLogin.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, "<>9__14_2");
				DBGLogin.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, 100666825);
				DBGLogin.__c.NativeMethodInfoPtr__execute_b__14_0_Internal_Void_UnityWebRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, 100666826);
				DBGLogin.__c.NativeMethodInfoPtr__execute_b__14_2_Internal_Void_ErrorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr, 100666827);
			}

			// Token: 0x06002DDF RID: 11743 RVA: 0x000B1818 File Offset: 0x000AFA18
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLogin.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DE0 RID: 11744 RVA: 0x000B1854 File Offset: 0x000AFA54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525914, XrefRangeEnd = 525922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__14_0(UnityWebRequest request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.__c.NativeMethodInfoPtr__execute_b__14_0_Internal_Void_UnityWebRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DE1 RID: 11745 RVA: 0x000B1898 File Offset: 0x000AFA98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525922, XrefRangeEnd = 525932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__14_2(ErrorInfo status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(status));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.__c.NativeMethodInfoPtr__execute_b__14_2_Internal_Void_ErrorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DE2 RID: 11746 RVA: 0x00017B57 File Offset: 0x00015D57
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D0A RID: 3338
			// (get) Token: 0x06002DE3 RID: 11747 RVA: 0x000B18E0 File Offset: 0x000AFAE0
			// (set) Token: 0x06002DE4 RID: 11748 RVA: 0x00017B60 File Offset: 0x00015D60
			public unsafe static DBGLogin.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLogin.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLogin.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLogin.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0B RID: 3339
			// (get) Token: 0x06002DE5 RID: 11749 RVA: 0x000B1908 File Offset: 0x000AFB08
			// (set) Token: 0x06002DE6 RID: 11750 RVA: 0x00017B72 File Offset: 0x00015D72
			public unsafe static Action<UnityWebRequest> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLogin.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UnityWebRequest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLogin.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D0C RID: 3340
			// (get) Token: 0x06002DE7 RID: 11751 RVA: 0x000B1930 File Offset: 0x000AFB30
			// (set) Token: 0x06002DE8 RID: 11752 RVA: 0x00017B84 File Offset: 0x00015D84
			public unsafe static Action<ErrorInfo> __9__14_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DBGLogin.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ErrorInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DBGLogin.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C6A RID: 7274
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001C6B RID: 7275
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04001C6C RID: 7276
			private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

			// Token: 0x04001C6D RID: 7277
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C6E RID: 7278
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__14_0_Internal_Void_UnityWebRequest_0;

			// Token: 0x04001C6F RID: 7279
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__14_2_Internal_Void_ErrorInfo_0;
		}

		// Token: 0x020003DB RID: 987
		[ObfuscatedName("boardgames.menus.commands.DBGLogin+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x06002DE9 RID: 11753 RVA: 0x000B1958 File Offset: 0x000AFB58
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr);
				DBGLogin.__c__DisplayClass14_0.NativeFieldInfoPtr_challenges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr, "challenges");
				DBGLogin.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr, 100666828);
				DBGLogin.__c__DisplayClass14_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr, 100666829);
			}

			// Token: 0x06002DEA RID: 11754 RVA: 0x000B19C0 File Offset: 0x000AFBC0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLogin.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DEB RID: 11755 RVA: 0x000B19FC File Offset: 0x000AFBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525932, XrefRangeEnd = 525975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _execute_b__1(DwdWebRequestCommand request)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin.__c__DisplayClass14_0.NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DEC RID: 11756 RVA: 0x00017B96 File Offset: 0x00015D96
			public __c__DisplayClass14_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D0D RID: 3341
			// (get) Token: 0x06002DED RID: 11757 RVA: 0x000B1A40 File Offset: 0x000AFC40
			// (set) Token: 0x06002DEE RID: 11758 RVA: 0x00017B9F File Offset: 0x00015D9F
			public unsafe OfflineChallenges challenges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.__c__DisplayClass14_0.NativeFieldInfoPtr_challenges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OfflineChallenges>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin.__c__DisplayClass14_0.NativeFieldInfoPtr_challenges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C70 RID: 7280
			private static readonly IntPtr NativeFieldInfoPtr_challenges;

			// Token: 0x04001C71 RID: 7281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001C72 RID: 7282
			private static readonly IntPtr NativeMethodInfoPtr__execute_b__1_Internal_Void_DwdWebRequestCommand_0;
		}

		// Token: 0x020003DC RID: 988
		[ObfuscatedName("boardgames.menus.commands.DBGLogin+<execute>d__14")]
		public sealed class _execute_d__14 : Object
		{
			// Token: 0x06002DEF RID: 11759 RVA: 0x000B1A70 File Offset: 0x000AFC70
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__14()
			{
				Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGLogin>.NativeClassPtr, "<execute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr);
				DBGLogin._execute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<>1__state");
				DBGLogin._execute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<>2__current");
				DBGLogin._execute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<>4__this");
				DBGLogin._execute_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<>8__1");
				DBGLogin._execute_d__14.NativeFieldInfoPtr__accountProvider_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<accountProvider>5__2");
				DBGLogin._execute_d__14.NativeFieldInfoPtr__userDataProvider_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<userDataProvider>5__3");
				DBGLogin._execute_d__14.NativeFieldInfoPtr__account_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, "<account>5__4");
				DBGLogin._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666830);
				DBGLogin._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666831);
				DBGLogin._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666832);
				DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666833);
				DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666834);
				DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr, 100666835);
			}

			// Token: 0x06002DF0 RID: 11760 RVA: 0x000B1BA0 File Offset: 0x000AFDA0
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGLogin._execute_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002DF1 RID: 11761 RVA: 0x000B1BE8 File Offset: 0x000AFDE8
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002DF2 RID: 11762 RVA: 0x000B1C1C File Offset: 0x000AFE1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525975, XrefRangeEnd = 526256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000D15 RID: 3349
			// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x000B1C58 File Offset: 0x000AFE58
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002DF4 RID: 11764 RVA: 0x000B1C98 File Offset: 0x000AFE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 526256, XrefRangeEnd = 526261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000D16 RID: 3350
			// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x000B1CCC File Offset: 0x000AFECC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGLogin._execute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002DF6 RID: 11766 RVA: 0x00017BBE File Offset: 0x00015DBE
			public _execute_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D0E RID: 3342
			// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x000B1D0C File Offset: 0x000AFF0C
			// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00017BC7 File Offset: 0x00015DC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000D0F RID: 3343
			// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000B1D34 File Offset: 0x000AFF34
			// (set) Token: 0x06002DFA RID: 11770 RVA: 0x00017BE2 File Offset: 0x00015DE2
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D10 RID: 3344
			// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000B1D64 File Offset: 0x000AFF64
			// (set) Token: 0x06002DFC RID: 11772 RVA: 0x00017C01 File Offset: 0x00015E01
			public unsafe DBGLogin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLogin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D11 RID: 3345
			// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000B1D94 File Offset: 0x000AFF94
			// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00017C20 File Offset: 0x00015E20
			public unsafe DBGLogin.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGLogin.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D12 RID: 3346
			// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000B1DC4 File Offset: 0x000AFFC4
			// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00017C3F File Offset: 0x00015E3F
			public unsafe AccountProvider _accountProvider_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__accountProvider_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__accountProvider_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D13 RID: 3347
			// (get) Token: 0x06002E01 RID: 11777 RVA: 0x000B1DF4 File Offset: 0x000AFFF4
			// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00017C5E File Offset: 0x00015E5E
			public unsafe IUserDataProvider _userDataProvider_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__userDataProvider_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IUserDataProvider>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__userDataProvider_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D14 RID: 3348
			// (get) Token: 0x06002E03 RID: 11779 RVA: 0x000B1E24 File Offset: 0x000B0024
			// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00017C7D File Offset: 0x00015E7D
			public unsafe AccountComponent _account_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__account_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGLogin._execute_d__14.NativeFieldInfoPtr__account_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C73 RID: 7283
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C74 RID: 7284
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C75 RID: 7285
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C76 RID: 7286
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04001C77 RID: 7287
			private static readonly IntPtr NativeFieldInfoPtr__accountProvider_5__2;

			// Token: 0x04001C78 RID: 7288
			private static readonly IntPtr NativeFieldInfoPtr__userDataProvider_5__3;

			// Token: 0x04001C79 RID: 7289
			private static readonly IntPtr NativeFieldInfoPtr__account_5__4;

			// Token: 0x04001C7A RID: 7290
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C7B RID: 7291
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C7C RID: 7292
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C7D RID: 7293
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C7E RID: 7294
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C7F RID: 7295
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
