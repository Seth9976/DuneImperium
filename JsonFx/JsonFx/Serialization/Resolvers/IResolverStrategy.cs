using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace JsonFx.Serialization.Resolvers
{
	// Token: 0x02000015 RID: 21
	public class IResolverStrategy : Il2CppObjectBase
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00007344 File Offset: 0x00005544
		// Note: this type is marked as 'beforefieldinit'.
		static IResolverStrategy()
		{
			Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.Resolvers", "IResolverStrategy");
			IResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Abstract_Virtual_New_Boolean_PropertyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr, 100663403);
			IResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Abstract_Virtual_New_Boolean_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr, 100663404);
			IResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Abstract_Virtual_New_ValueIgnoredDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr, 100663405);
			IResolverStrategy.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr, 100663406);
			IResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Abstract_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IResolverStrategy>.NativeClassPtr, 100663407);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000073D0 File Offset: 0x000055D0
		[CallerCount(0)]
		public unsafe virtual bool IsPropertyIgnored(PropertyInfo member, bool isImmutableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isImmutableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Abstract_Virtual_New_Boolean_PropertyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00007438 File Offset: 0x00005638
		[CallerCount(0)]
		public unsafe virtual bool IsFieldIgnored(FieldInfo member, bool isImmutableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isImmutableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Abstract_Virtual_New_Boolean_FieldInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000074A0 File Offset: 0x000056A0
		[CallerCount(0)]
		public unsafe virtual ValueIgnoredDelegate GetValueIgnoredCallback(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Abstract_Virtual_New_ValueIgnoredDelegate_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000074FC File Offset: 0x000056FC
		[CallerCount(0)]
		public unsafe virtual string GetName(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolverStrategy.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00007550 File Offset: 0x00005750
		[CallerCount(0)]
		public unsafe virtual IEnumerable<MemberMap> SortMembers(IEnumerable<MemberMap> members)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Abstract_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberMap>>(intPtr3) : null;
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002591 File Offset: 0x00000791
		public IResolverStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400009E RID: 158
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyIgnored_Public_Abstract_Virtual_New_Boolean_PropertyInfo_Boolean_0;

		// Token: 0x0400009F RID: 159
		private static readonly IntPtr NativeMethodInfoPtr_IsFieldIgnored_Public_Abstract_Virtual_New_Boolean_FieldInfo_Boolean_0;

		// Token: 0x040000A0 RID: 160
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Abstract_Virtual_New_ValueIgnoredDelegate_MemberInfo_0;

		// Token: 0x040000A1 RID: 161
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_MemberInfo_0;

		// Token: 0x040000A2 RID: 162
		private static readonly IntPtr NativeMethodInfoPtr_SortMembers_Public_Abstract_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0;
	}
}
