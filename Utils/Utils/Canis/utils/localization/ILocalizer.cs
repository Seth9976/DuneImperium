using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.utils.localization
{
	// Token: 0x0200000D RID: 13
	public class ILocalizer : Il2CppObjectBase
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000612C File Offset: 0x0000432C
		// Note: this type is marked as 'beforefieldinit'.
		static ILocalizer()
		{
			Il2CppClassPointerStore<ILocalizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.localization", "ILocalizer");
			ILocalizer.NativeMethodInfoPtr_GetChecksums_Public_Abstract_Virtual_New_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663360);
			ILocalizer.NativeMethodInfoPtr_SetChecksums_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663361);
			ILocalizer.NativeMethodInfoPtr_BeginTransaction_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663362);
			ILocalizer.NativeMethodInfoPtr_EndTransaction_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663363);
			ILocalizer.NativeMethodInfoPtr_SetPairs_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663364);
			ILocalizer.NativeMethodInfoPtr_RemoveKeys_Public_Abstract_Virtual_New_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663365);
			ILocalizer.NativeMethodInfoPtr_Localize_Public_Abstract_Virtual_New_String_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663366);
			ILocalizer.NativeMethodInfoPtr_TryLocalize_Public_Abstract_Virtual_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663367);
			ILocalizer.NativeMethodInfoPtr_Has_Public_Abstract_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663368);
			ILocalizer.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663369);
			ILocalizer.NativeMethodInfoPtr_get_Disabled_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663370);
			ILocalizer.NativeMethodInfoPtr_set_Disabled_Public_Abstract_Virtual_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663371);
			ILocalizer.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663372);
			ILocalizer.NativeMethodInfoPtr_GetKeysWithPrefix_Public_Abstract_Virtual_New_Boolean_String_ICollection_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILocalizer>.NativeClassPtr, 100663373);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000626C File Offset: 0x0000446C
		[CallerCount(0)]
		public unsafe virtual Dictionary<string, string> GetChecksums()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_GetChecksums_Public_Abstract_Virtual_New_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, string>>(intPtr3) : null;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000062B8 File Offset: 0x000044B8
		[CallerCount(0)]
		public unsafe virtual void SetChecksums(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_SetChecksums_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006308 File Offset: 0x00004508
		[CallerCount(0)]
		public unsafe virtual bool BeginTransaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_BeginTransaction_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00006350 File Offset: 0x00004550
		[CallerCount(0)]
		public unsafe virtual void EndTransaction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_EndTransaction_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000638C File Offset: 0x0000458C
		[CallerCount(0)]
		public unsafe virtual void SetPairs(IEnumerable<KeyValuePair<string, string>> pairs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pairs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_SetPairs_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000063DC File Offset: 0x000045DC
		[CallerCount(0)]
		public unsafe virtual void RemoveKeys(IEnumerable<string> keys)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keys);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_RemoveKeys_Public_Abstract_Virtual_New_Void_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000642C File Offset: 0x0000462C
		[CallerCount(0)]
		public unsafe virtual string Localize(string key, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_Localize_Public_Abstract_Virtual_New_String_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000064A0 File Offset: 0x000046A0
		[CallerCount(0)]
		public unsafe virtual bool TryLocalize(string key, out string value, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_TryLocalize_Public_Abstract_Virtual_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00006534 File Offset: 0x00004734
		[CallerCount(0)]
		public unsafe virtual bool Has(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_Has_Public_Abstract_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000658C File Offset: 0x0000478C
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000065C8 File Offset: 0x000047C8
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00006610 File Offset: 0x00004810
		public unsafe virtual bool Disabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_get_Disabled_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_set_Disabled_Public_Abstract_Virtual_New_set_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000076 RID: 118 RVA: 0x0000665C File Offset: 0x0000485C
		public unsafe virtual bool Initialized
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000066A4 File Offset: 0x000048A4
		[CallerCount(0)]
		public unsafe virtual bool GetKeysWithPrefix(string prefix, ICollection<string> list)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(prefix);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(list);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILocalizer.NativeMethodInfoPtr_GetKeysWithPrefix_Public_Abstract_Virtual_New_Boolean_String_ICollection_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002265 File Offset: 0x00000465
		public virtual string Localize(string key, params Object[] args)
		{
			return this.Localize(key, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002274 File Offset: 0x00000474
		public virtual bool TryLocalize(string key, out string value, params Object[] args)
		{
			return this.TryLocalize(key, out value, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002284 File Offset: 0x00000484
		public ILocalizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetChecksums_Public_Abstract_Virtual_New_Dictionary_2_String_String_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_SetChecksums_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_BeginTransaction_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr_EndTransaction_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_SetPairs_Public_Abstract_Virtual_New_Void_IEnumerable_1_KeyValuePair_2_String_String_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_RemoveKeys_Public_Abstract_Virtual_New_Void_IEnumerable_1_String_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Localize_Public_Abstract_Virtual_New_String_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr_TryLocalize_Public_Abstract_Virtual_New_Boolean_String_byref_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr_Has_Public_Abstract_Virtual_New_Boolean_String_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr_get_Disabled_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr_set_Disabled_Public_Abstract_Virtual_New_set_Void_Boolean_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_Initialized_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_GetKeysWithPrefix_Public_Abstract_Virtual_New_Boolean_String_ICollection_1_String_0;
	}
}
