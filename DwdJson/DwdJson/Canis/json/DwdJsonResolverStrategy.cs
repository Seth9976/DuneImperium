using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using JsonFx.Serialization.Resolvers;

namespace Canis.json
{
	// Token: 0x02000013 RID: 19
	public sealed class DwdJsonResolverStrategy : Object
	{
		// Token: 0x0600007F RID: 127 RVA: 0x000042A8 File Offset: 0x000024A8
		// Note: this type is marked as 'beforefieldinit'.
		static DwdJsonResolverStrategy()
		{
			Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdJsonResolverStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr);
			DwdJsonResolverStrategy.NativeFieldInfoPtr_JsonNameAttributeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, "JsonNameAttributeType");
			DwdJsonResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Final_New_Boolean_PropertyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663348);
			DwdJsonResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Final_New_Boolean_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663349);
			DwdJsonResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_Final_New_ValueIgnoredDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663350);
			DwdJsonResolverStrategy.NativeMethodInfoPtr_ValueIgnoredCallback_Private_Static_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663351);
			DwdJsonResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663352);
			DwdJsonResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Virtual_Final_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663353);
			DwdJsonResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, 100663354);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004378 File Offset: 0x00002578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248519, XrefRangeEnd = 1248523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPropertyIgnored(PropertyInfo member, bool isImmutableType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Final_New_Boolean_PropertyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000043D4 File Offset: 0x000025D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248523, XrefRangeEnd = 1248527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFieldIgnored(FieldInfo member, bool isImmutableType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Final_New_Boolean_FieldInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004430 File Offset: 0x00002630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248527, XrefRangeEnd = 1248538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueIgnoredDelegate GetValueIgnoredCallback(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_Final_New_ValueIgnoredDelegate_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004480 File Offset: 0x00002680
		[CallerCount(0)]
		public unsafe static bool ValueIgnoredCallback(Object instance, Object value)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_ValueIgnoredCallback_Private_Static_Boolean_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000044D4 File Offset: 0x000026D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248538, XrefRangeEnd = 1248549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetName(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000451C File Offset: 0x0000271C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<MemberMap> SortMembers(IEnumerable<MemberMap> members)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(members);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr_SortMembers_Public_Virtual_Final_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<MemberMap>>(intPtr3) : null;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000456C File Offset: 0x0000276C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonResolverStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002409 File Offset: 0x00000609
		public DwdJsonResolverStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000088 RID: 136 RVA: 0x000045A8 File Offset: 0x000027A8
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00002412 File Offset: 0x00000612
		public unsafe static Type JsonNameAttributeType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DwdJsonResolverStrategy.NativeFieldInfoPtr_JsonNameAttributeType, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DwdJsonResolverStrategy.NativeFieldInfoPtr_JsonNameAttributeType, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_JsonNameAttributeType;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Final_New_Boolean_PropertyInfo_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Final_New_Boolean_FieldInfo_Boolean_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_Final_New_ValueIgnoredDelegate_MemberInfo_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_ValueIgnoredCallback_Private_Static_Boolean_Object_Object_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_MemberInfo_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_SortMembers_Public_Virtual_Final_New_IEnumerable_1_MemberMap_IEnumerable_1_MemberMap_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000026 RID: 38
		[ObfuscatedName("Canis.json.DwdJsonResolverStrategy+<>O")]
		public static class __O : Object
		{
			// Token: 0x06000130 RID: 304 RVA: 0x000027CC File Offset: 0x000009CC
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<DwdJsonResolverStrategy.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DwdJsonResolverStrategy>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonResolverStrategy.__O>.NativeClassPtr);
				DwdJsonResolverStrategy.__O.NativeFieldInfoPtr__0___ValueIgnoredCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdJsonResolverStrategy.__O>.NativeClassPtr, "<0>__ValueIgnoredCallback");
			}

			// Token: 0x06000131 RID: 305 RVA: 0x00002800 File Offset: 0x00000A00
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x06000132 RID: 306 RVA: 0x00006A90 File Offset: 0x00004C90
			// (set) Token: 0x06000133 RID: 307 RVA: 0x00002809 File Offset: 0x00000A09
			public unsafe static ValueIgnoredDelegate _0___ValueIgnoredCallback
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DwdJsonResolverStrategy.__O.NativeFieldInfoPtr__0___ValueIgnoredCallback, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DwdJsonResolverStrategy.__O.NativeFieldInfoPtr__0___ValueIgnoredCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040000AD RID: 173
			private static readonly IntPtr NativeFieldInfoPtr__0___ValueIgnoredCallback;
		}
	}
}
