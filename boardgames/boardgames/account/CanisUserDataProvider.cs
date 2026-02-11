using System;
using Canis.attributes;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace boardgames.account
{
	// Token: 0x02000181 RID: 385
	public class CanisUserDataProvider : Object
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x0004BDC0 File Offset: 0x00049FC0
		// Note: this type is marked as 'beforefieldinit'.
		static CanisUserDataProvider()
		{
			Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.account", "CanisUserDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr);
			CanisUserDataProvider.NativeFieldInfoPtr__userData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, "_userData");
			CanisUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666092);
			CanisUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666093);
			CanisUserDataProvider.NativeMethodInfoPtr_getUser_Private_IHasAttributes_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666094);
			CanisUserDataProvider.NativeMethodInfoPtr_createUser_Private_Static_IHasAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666095);
			CanisUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666096);
			CanisUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666097);
			CanisUserDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, 100666098);
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x0004BE90 File Offset: 0x0004A090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001685, XrefRangeEnd = 1001694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RebindUser(AccountID originalId, AccountID newId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(originalId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x0004BEE4 File Offset: 0x0004A0E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001701, RefRangeEnd = 1001702, XrefRangeStart = 1001694, XrefRangeEnd = 1001701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetUser(AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x0004BF34 File Offset: 0x0004A134
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001701, RefRangeEnd = 1001702, XrefRangeStart = 1001701, XrefRangeEnd = 1001702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHasAttributes getUser(AccountID account)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr_getUser_Private_IHasAttributes_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x0004BF84 File Offset: 0x0004A184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1001750, RefRangeEnd = 1001752, XrefRangeStart = 1001702, XrefRangeEnd = 1001750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IHasAttributes createUser()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr_createUser_Private_Static_IHasAttributes_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x0004BFB8 File Offset: 0x0004A1B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001752, XrefRangeEnd = 1001762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUser(AccountID account, string username, string usernameID, Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(username);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(usernameID);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(metadata);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x0004C034 File Offset: 0x0004A234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1001771, RefRangeEnd = 1001773, XrefRangeStart = 1001762, XrefRangeEnd = 1001771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetUserAttribute<TValue>(AccountID account, AttributeDefinition<TValue> attribute, TValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(account);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TValue).IsValueType)
			{
				TValue tvalue = value;
				intPtr = ((tvalue is string) ? IL2CPP.ManagedStringToIl2Cpp(tvalue as string) : IL2CPP.Il2CppObjectBaseToPtr(tvalue as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.MethodInfoStoreGeneric_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x0004C0D0 File Offset: 0x0004A2D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001773, XrefRangeEnd = 1001781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanisUserDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x0000AE72 File Offset: 0x00009072
		public CanisUserDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001319 RID: 4889 RVA: 0x0004C10C File Offset: 0x0004A30C
		// (set) Token: 0x0600131A RID: 4890 RVA: 0x0000AE7B File Offset: 0x0000907B
		public unsafe Dictionary<AccountID, IHasAttributes> _userData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisUserDataProvider.NativeFieldInfoPtr__userData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<AccountID, IHasAttributes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CanisUserDataProvider.NativeFieldInfoPtr__userData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B91 RID: 2961
		private static readonly IntPtr NativeFieldInfoPtr__userData;

		// Token: 0x04000B92 RID: 2962
		private static readonly IntPtr NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0;

		// Token: 0x04000B93 RID: 2963
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0;

		// Token: 0x04000B94 RID: 2964
		private static readonly IntPtr NativeMethodInfoPtr_getUser_Private_IHasAttributes_AccountID_0;

		// Token: 0x04000B95 RID: 2965
		private static readonly IntPtr NativeMethodInfoPtr_createUser_Private_Static_IHasAttributes_0;

		// Token: 0x04000B96 RID: 2966
		private static readonly IntPtr NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0;

		// Token: 0x04000B97 RID: 2967
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0;

		// Token: 0x04000B98 RID: 2968
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000295 RID: 661
		[ObfuscatedName("boardgames.account.CanisUserDataProvider+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001E45 RID: 7749 RVA: 0x0006E3C4 File Offset: 0x0006C5C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr);
				CanisUserDataProvider.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr, "<>9");
				CanisUserDataProvider.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr, "<>9__4_0");
				CanisUserDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr, 100666100);
				CanisUserDataProvider.__c.NativeMethodInfoPtr__createUser_b__4_0_Internal_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr, 100666101);
			}

			// Token: 0x06001E46 RID: 7750 RVA: 0x0006E440 File Offset: 0x0006C640
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanisUserDataProvider.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001E47 RID: 7751 RVA: 0x0006E47C File Offset: 0x0006C67C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001679, XrefRangeEnd = 1001685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _createUser_b__4_0(string name, string id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanisUserDataProvider.__c.NativeMethodInfoPtr__createUser_b__4_0_Internal_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06001E48 RID: 7752 RVA: 0x000103C2 File Offset: 0x0000E5C2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000907 RID: 2311
			// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0006E4D8 File Offset: 0x0006C6D8
			// (set) Token: 0x06001E4A RID: 7754 RVA: 0x000103CB File Offset: 0x0000E5CB
			public unsafe static CanisUserDataProvider.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisUserDataProvider.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanisUserDataProvider.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisUserDataProvider.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000908 RID: 2312
			// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0006E500 File Offset: 0x0006C700
			// (set) Token: 0x06001E4C RID: 7756 RVA: 0x000103DD File Offset: 0x0000E5DD
			public unsafe static Func<string, string, string> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CanisUserDataProvider.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CanisUserDataProvider.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001267 RID: 4711
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001268 RID: 4712
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04001269 RID: 4713
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400126A RID: 4714
			private static readonly IntPtr NativeMethodInfoPtr__createUser_b__4_0_Internal_String_String_String_0;
		}

		// Token: 0x02000296 RID: 662
		private sealed class MethodInfoStoreGeneric_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>
		{
			// Token: 0x0400126B RID: 4715
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CanisUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0, Il2CppClassPointerStore<CanisUserDataProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
