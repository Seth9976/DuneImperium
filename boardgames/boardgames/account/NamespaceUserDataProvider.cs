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
using UnityEngine;

namespace boardgames.account
{
	// Token: 0x02000189 RID: 393
	public class NamespaceUserDataProvider : MonoBehaviour
	{
		// Token: 0x0600132E RID: 4910 RVA: 0x0004C528 File Offset: 0x0004A728
		// Note: this type is marked as 'beforefieldinit'.
		static NamespaceUserDataProvider()
		{
			Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.account", "NamespaceUserDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr);
			NamespaceUserDataProvider.NativeFieldInfoPtr_providers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, "providers");
			NamespaceUserDataProvider.NativeFieldInfoPtr_defaultNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, "defaultNamespace");
			NamespaceUserDataProvider.NativeMethodInfoPtr_AddProvider_Public_Void_UserDataNamespace_IUserDataProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666109);
			NamespaceUserDataProvider.NativeMethodInfoPtr_HasProvider_Public_Boolean_UserDataNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666110);
			NamespaceUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666111);
			NamespaceUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666112);
			NamespaceUserDataProvider.NativeMethodInfoPtr_GetUserByNamespace_Public_IHasAttributes_AccountID_UserDataNamespace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666113);
			NamespaceUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666114);
			NamespaceUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666115);
			NamespaceUserDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr, 100666116);
		}

		// Token: 0x0600132F RID: 4911 RVA: 0x0004C620 File Offset: 0x0004A820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001817, XrefRangeEnd = 1001821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddProvider(UserDataNamespace dataNamespace, IUserDataProvider provider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataNamespace;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(provider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_AddProvider_Public_Void_UserDataNamespace_IUserDataProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x0004C670 File Offset: 0x0004A870
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001825, RefRangeEnd = 1001826, XrefRangeStart = 1001821, XrefRangeEnd = 1001825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool HasProvider(UserDataNamespace dataNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dataNamespace;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_HasProvider_Public_Boolean_UserDataNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x0004C6BC File Offset: 0x0004A8BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001826, XrefRangeEnd = 1001847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0004C710 File Offset: 0x0004A910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001847, XrefRangeEnd = 1001855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IHasAttributes GetUser(AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x06001333 RID: 4915 RVA: 0x0004C760 File Offset: 0x0004A960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1001863, RefRangeEnd = 1001864, XrefRangeStart = 1001855, XrefRangeEnd = 1001863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IHasAttributes GetUserByNamespace(AccountID accountId, UserDataNamespace dataNamespace)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataNamespace;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_GetUserByNamespace_Public_IHasAttributes_AccountID_UserDataNamespace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x0004C7C0 File Offset: 0x0004A9C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001864, XrefRangeEnd = 1001885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x0004C83C File Offset: 0x0004AA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001885, XrefRangeEnd = 1001906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.MethodInfoStoreGeneric_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0004C8D8 File Offset: 0x0004AAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001906, XrefRangeEnd = 1001929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamespaceUserDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamespaceUserDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x0000AF35 File Offset: 0x00009135
		public NamespaceUserDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001338 RID: 4920 RVA: 0x0004C914 File Offset: 0x0004AB14
		// (set) Token: 0x06001339 RID: 4921 RVA: 0x0000AF3E File Offset: 0x0000913E
		public unsafe Dictionary<UserDataNamespace, IUserDataProvider> providers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceUserDataProvider.NativeFieldInfoPtr_providers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UserDataNamespace, IUserDataProvider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceUserDataProvider.NativeFieldInfoPtr_providers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x0600133A RID: 4922 RVA: 0x0004C944 File Offset: 0x0004AB44
		// (set) Token: 0x0600133B RID: 4923 RVA: 0x0000AF5D File Offset: 0x0000915D
		public unsafe UserDataNamespace defaultNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceUserDataProvider.NativeFieldInfoPtr_defaultNamespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamespaceUserDataProvider.NativeFieldInfoPtr_defaultNamespace)) = value;
			}
		}

		// Token: 0x04000BA7 RID: 2983
		private static readonly IntPtr NativeFieldInfoPtr_providers;

		// Token: 0x04000BA8 RID: 2984
		private static readonly IntPtr NativeFieldInfoPtr_defaultNamespace;

		// Token: 0x04000BA9 RID: 2985
		private static readonly IntPtr NativeMethodInfoPtr_AddProvider_Public_Void_UserDataNamespace_IUserDataProvider_0;

		// Token: 0x04000BAA RID: 2986
		private static readonly IntPtr NativeMethodInfoPtr_HasProvider_Public_Boolean_UserDataNamespace_0;

		// Token: 0x04000BAB RID: 2987
		private static readonly IntPtr NativeMethodInfoPtr_RebindUser_Public_Virtual_Final_New_Void_AccountID_AccountID_0;

		// Token: 0x04000BAC RID: 2988
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Public_Virtual_Final_New_IHasAttributes_AccountID_0;

		// Token: 0x04000BAD RID: 2989
		private static readonly IntPtr NativeMethodInfoPtr_GetUserByNamespace_Public_IHasAttributes_AccountID_UserDataNamespace_0;

		// Token: 0x04000BAE RID: 2990
		private static readonly IntPtr NativeMethodInfoPtr_SetUser_Public_Virtual_Final_New_Void_AccountID_String_String_Dictionary_2_String_String_0;

		// Token: 0x04000BAF RID: 2991
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0;

		// Token: 0x04000BB0 RID: 2992
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000298 RID: 664
		private sealed class MethodInfoStoreGeneric_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>
		{
			// Token: 0x0400126D RID: 4717
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(NamespaceUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Virtual_Final_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0, Il2CppClassPointerStore<NamespaceUserDataProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
