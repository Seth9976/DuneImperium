using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace JsonFx.Serialization.Resolvers
{
	// Token: 0x02000016 RID: 22
	public class PocoResolverStrategy : Object
	{
		// Token: 0x060000F4 RID: 244 RVA: 0x000075AC File Offset: 0x000057AC
		// Note: this type is marked as 'beforefieldinit'.
		static PocoResolverStrategy()
		{
			Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.Resolvers", "PocoResolverStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr);
			PocoResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_New_Boolean_PropertyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663408);
			PocoResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_New_Boolean_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663409);
			PocoResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_New_ValueIgnoredDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663410);
			PocoResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_New_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663411);
			PocoResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663412);
			PocoResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr, 100663413);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00007654 File Offset: 0x00005854
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190604, XrefRangeEnd = 1190609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PocoResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_New_Boolean_PropertyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x000076BC File Offset: 0x000058BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1190609, XrefRangeEnd = 1190611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PocoResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_New_Boolean_FieldInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00007724 File Offset: 0x00005924
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ValueIgnoredDelegate GetValueIgnoredCallback(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PocoResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_New_ValueIgnoredDelegate_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00007780 File Offset: 0x00005980
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetName(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PocoResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_New_String_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000077D4 File Offset: 0x000059D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerable<MemberMap> SortMembers(IEnumerable<MemberMap> members)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PocoResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberMap>>(intPtr3) : null;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00007830 File Offset: 0x00005A30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PocoResolverStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PocoResolverStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PocoResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000259A File Offset: 0x0000079A
		public PocoResolverStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A3 RID: 163
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_New_Boolean_PropertyInfo_Boolean_0;

		// Token: 0x040000A4 RID: 164
		private static readonly IntPtr NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_New_Boolean_FieldInfo_Boolean_0;

		// Token: 0x040000A5 RID: 165
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_New_ValueIgnoredDelegate_MemberInfo_0;

		// Token: 0x040000A6 RID: 166
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_New_String_MemberInfo_0;

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_SortMembers_Public_Virtual_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
