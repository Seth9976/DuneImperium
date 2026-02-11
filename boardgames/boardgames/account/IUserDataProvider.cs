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
	// Token: 0x02000187 RID: 391
	public class IUserDataProvider : Il2CppObjectBase
	{
		// Token: 0x06001328 RID: 4904 RVA: 0x0004C2C8 File Offset: 0x0004A4C8
		// Note: this type is marked as 'beforefieldinit'.
		static IUserDataProvider()
		{
			Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.account", "IUserDataProvider");
			IUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Abstract_Virtual_New_Void_AccountID_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr, 100666105);
			IUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Abstract_Virtual_New_IHasAttributes_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr, 100666106);
			IUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Abstract_Virtual_New_Void_AccountID_String_String_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr, 100666107);
			IUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Abstract_Virtual_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr, 100666108);
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0004C340 File Offset: 0x0004A540
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataProvider.NativeMethodInfoPtr_RebindUser_Public_Abstract_Virtual_New_Void_AccountID_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132A RID: 4906 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		[CallerCount(0)]
		public unsafe virtual IHasAttributes GetUser(AccountID accountId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataProvider.NativeMethodInfoPtr_GetUser_Public_Abstract_Virtual_New_IHasAttributes_AccountID_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IHasAttributes>(intPtr3) : null;
			}
		}

		// Token: 0x0600132B RID: 4907 RVA: 0x0004C3FC File Offset: 0x0004A5FC
		[CallerCount(0)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataProvider.NativeMethodInfoPtr_SetUser_Public_Abstract_Virtual_New_Void_AccountID_String_String_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600132C RID: 4908 RVA: 0x0004C480 File Offset: 0x0004A680
		[CallerCount(0)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUserDataProvider.MethodInfoStoreGeneric_SetUserAttribute_Public_Abstract_Virtual_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x0600132D RID: 4909 RVA: 0x0000AF2C File Offset: 0x0000912C
		public IUserDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000BA0 RID: 2976
		private static readonly IntPtr NativeMethodInfoPtr_RebindUser_Public_Abstract_Virtual_New_Void_AccountID_AccountID_0;

		// Token: 0x04000BA1 RID: 2977
		private static readonly IntPtr NativeMethodInfoPtr_GetUser_Public_Abstract_Virtual_New_IHasAttributes_AccountID_0;

		// Token: 0x04000BA2 RID: 2978
		private static readonly IntPtr NativeMethodInfoPtr_SetUser_Public_Abstract_Virtual_New_Void_AccountID_String_String_Dictionary_2_String_String_0;

		// Token: 0x04000BA3 RID: 2979
		private static readonly IntPtr NativeMethodInfoPtr_SetUserAttribute_Public_Abstract_Virtual_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0;

		// Token: 0x02000297 RID: 663
		private sealed class MethodInfoStoreGeneric_SetUserAttribute_Public_Abstract_Virtual_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0<TValue>
		{
			// Token: 0x0400126C RID: 4716
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(IUserDataProvider.NativeMethodInfoPtr_SetUserAttribute_Public_Abstract_Virtual_New_Void_AccountID_AttributeDefinition_1_TValue_TValue_0, Il2CppClassPointerStore<IUserDataProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr)) }))));
		}
	}
}
