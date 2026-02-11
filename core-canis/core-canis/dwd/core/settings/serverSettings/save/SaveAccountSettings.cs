using System;
using dwd.core.account;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.settings.serverSettings.save
{
	// Token: 0x020000BE RID: 190
	public class SaveAccountSettings : Command
	{
		// Token: 0x06000C0C RID: 3084 RVA: 0x00041A20 File Offset: 0x0003FC20
		// Note: this type is marked as 'beforefieldinit'.
		static SaveAccountSettings()
		{
			Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.serverSettings.save", "SaveAccountSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr);
			SaveAccountSettings.NativeFieldInfoPtr_accountProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, "accountProvider");
			SaveAccountSettings.NativeFieldInfoPtr_newValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, "newValue");
			SaveAccountSettings.NativeFieldInfoPtr__Success_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, "<Success>k__BackingField");
			SaveAccountSettings.NativeMethodInfoPtr__ctor_Public_Void_AccountProvider_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, 100664993);
			SaveAccountSettings.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, 100664994);
			SaveAccountSettings.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, 100664995);
			SaveAccountSettings.NativeMethodInfoPtr_matches_Private_Static_Boolean_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, 100664996);
			SaveAccountSettings.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, 100664997);
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x00041AF0 File Offset: 0x0003FCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864239, XrefRangeEnd = 864248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveAccountSettings(AccountProvider accountProvider, IDictionary<int, int> newValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountProvider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings.NativeMethodInfoPtr__ctor_Public_Void_AccountProvider_IDictionary_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C0E RID: 3086 RVA: 0x00041B50 File Offset: 0x0003FD50
		// (set) Token: 0x06000C0F RID: 3087 RVA: 0x00041B8C File Offset: 0x0003FD8C
		public unsafe bool Success
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings.NativeMethodInfoPtr_get_Success_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings.NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x00041BCC File Offset: 0x0003FDCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864248, XrefRangeEnd = 864255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool matches(IDictionary<int, int> a, IDictionary<int, int> b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings.NativeMethodInfoPtr_matches_Private_Static_Boolean_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x00041C20 File Offset: 0x0003FE20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864255, XrefRangeEnd = 864260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SaveAccountSettings.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x0000645E File Offset: 0x0000465E
		public SaveAccountSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x00041C6C File Offset: 0x0003FE6C
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x00006467 File Offset: 0x00004667
		public unsafe AccountProvider accountProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr_accountProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr_accountProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x00041C9C File Offset: 0x0003FE9C
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x00006486 File Offset: 0x00004686
		public unsafe Dictionary<int, int> newValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr_newValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr_newValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x00041CCC File Offset: 0x0003FECC
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x000064A5 File Offset: 0x000046A5
		public unsafe bool _Success_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr__Success_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings.NativeFieldInfoPtr__Success_k__BackingField)) = value;
			}
		}

		// Token: 0x040008B4 RID: 2228
		private static readonly IntPtr NativeFieldInfoPtr_accountProvider;

		// Token: 0x040008B5 RID: 2229
		private static readonly IntPtr NativeFieldInfoPtr_newValue;

		// Token: 0x040008B6 RID: 2230
		private static readonly IntPtr NativeFieldInfoPtr__Success_k__BackingField;

		// Token: 0x040008B7 RID: 2231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AccountProvider_IDictionary_2_Int32_Int32_0;

		// Token: 0x040008B8 RID: 2232
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_get_Boolean_0;

		// Token: 0x040008B9 RID: 2233
		private static readonly IntPtr NativeMethodInfoPtr_set_Success_Private_set_Void_Boolean_0;

		// Token: 0x040008BA RID: 2234
		private static readonly IntPtr NativeMethodInfoPtr_matches_Private_Static_Boolean_IDictionary_2_Int32_Int32_IDictionary_2_Int32_Int32_0;

		// Token: 0x040008BB RID: 2235
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x0200029D RID: 669
		[ObfuscatedName("dwd.core.settings.serverSettings.save.SaveAccountSettings+<execute>d__8")]
		public sealed class _execute_d__8 : Object
		{
			// Token: 0x06001FC4 RID: 8132 RVA: 0x0009008C File Offset: 0x0008E28C
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__8()
			{
				Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SaveAccountSettings>.NativeClassPtr, "<execute>d__8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr);
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<>1__state");
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<>2__current");
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<>4__this");
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__data_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<data>5__2");
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__temp_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<temp>5__3");
				SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__cachedData_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, "<cachedData>5__4");
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100664998);
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100664999);
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100665000);
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100665001);
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100665002);
				SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr, 100665003);
			}

			// Token: 0x06001FC5 RID: 8133 RVA: 0x000901A8 File Offset: 0x0008E3A8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__8(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveAccountSettings._execute_d__8>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001FC6 RID: 8134 RVA: 0x000901F0 File Offset: 0x0008E3F0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001FC7 RID: 8135 RVA: 0x00090224 File Offset: 0x0008E424
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864208, XrefRangeEnd = 864234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008AD RID: 2221
			// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x00090260 File Offset: 0x0008E460
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FC9 RID: 8137 RVA: 0x000902A0 File Offset: 0x0008E4A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 864234, XrefRangeEnd = 864239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008AE RID: 2222
			// (get) Token: 0x06001FCA RID: 8138 RVA: 0x000902D4 File Offset: 0x0008E4D4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveAccountSettings._execute_d__8.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001FCB RID: 8139 RVA: 0x0000D853 File Offset: 0x0000BA53
			public _execute_d__8(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008A7 RID: 2215
			// (get) Token: 0x06001FCC RID: 8140 RVA: 0x00090314 File Offset: 0x0008E514
			// (set) Token: 0x06001FCD RID: 8141 RVA: 0x0000D85C File Offset: 0x0000BA5C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008A8 RID: 2216
			// (get) Token: 0x06001FCE RID: 8142 RVA: 0x0009033C File Offset: 0x0008E53C
			// (set) Token: 0x06001FCF RID: 8143 RVA: 0x0000D877 File Offset: 0x0000BA77
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008A9 RID: 2217
			// (get) Token: 0x06001FD0 RID: 8144 RVA: 0x0009036C File Offset: 0x0008E56C
			// (set) Token: 0x06001FD1 RID: 8145 RVA: 0x0000D896 File Offset: 0x0000BA96
			public unsafe SaveAccountSettings __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SaveAccountSettings>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AA RID: 2218
			// (get) Token: 0x06001FD2 RID: 8146 RVA: 0x0009039C File Offset: 0x0008E59C
			// (set) Token: 0x06001FD3 RID: 8147 RVA: 0x0000D8B5 File Offset: 0x0000BAB5
			public unsafe ServerSettingsData _data_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__data_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ServerSettingsData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__data_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AB RID: 2219
			// (get) Token: 0x06001FD4 RID: 8148 RVA: 0x000903CC File Offset: 0x0008E5CC
			// (set) Token: 0x06001FD5 RID: 8149 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
			public unsafe Dictionary<int, int> _temp_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__temp_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__temp_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008AC RID: 2220
			// (get) Token: 0x06001FD6 RID: 8150 RVA: 0x000903FC File Offset: 0x0008E5FC
			// (set) Token: 0x06001FD7 RID: 8151 RVA: 0x0000D8F3 File Offset: 0x0000BAF3
			public unsafe ulong _cachedData_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__cachedData_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SaveAccountSettings._execute_d__8.NativeFieldInfoPtr__cachedData_5__4)) = value;
				}
			}

			// Token: 0x0400163A RID: 5690
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400163B RID: 5691
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400163C RID: 5692
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400163D RID: 5693
			private static readonly IntPtr NativeFieldInfoPtr__data_5__2;

			// Token: 0x0400163E RID: 5694
			private static readonly IntPtr NativeFieldInfoPtr__temp_5__3;

			// Token: 0x0400163F RID: 5695
			private static readonly IntPtr NativeFieldInfoPtr__cachedData_5__4;

			// Token: 0x04001640 RID: 5696
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001641 RID: 5697
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001642 RID: 5698
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001643 RID: 5699
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001644 RID: 5700
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001645 RID: 5701
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
