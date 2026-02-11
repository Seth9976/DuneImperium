using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using JsonFx.CodeGen;
using JsonFx.Serialization.Resolvers;

namespace JsonFx.Json.Resolvers
{
	// Token: 0x0200002C RID: 44
	public class JsonResolverStrategy : PocoResolverStrategy
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0000BA60 File Offset: 0x00009C60
		// Note: this type is marked as 'beforefieldinit'.
		static JsonResolverStrategy()
		{
			Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Json.Resolvers", "JsonResolverStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr);
			JsonResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, 100663626);
			JsonResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, 100663627);
			JsonResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_ValueIgnoredDelegate_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, 100663628);
			JsonResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_String_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, 100663629);
			JsonResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, 100663630);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0000BAF4 File Offset: 0x00009CF4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192940, RefRangeEnd = 1192941, XrefRangeStart = 1192930, XrefRangeEnd = 1192940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPropertyIgnored(PropertyInfo member, bool isImmutableType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0000BB5C File Offset: 0x00009D5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1192945, RefRangeEnd = 1192946, XrefRangeStart = 1192941, XrefRangeEnd = 1192945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsFieldIgnored(FieldInfo member, bool isImmutableType)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000BBC4 File Offset: 0x00009DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192946, XrefRangeEnd = 1192988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ValueIgnoredDelegate GetValueIgnoredCallback(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonResolverStrategy.NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_ValueIgnoredDelegate_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0000BC20 File Offset: 0x00009E20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192988, XrefRangeEnd = 1192998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName(MemberInfo member)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), JsonResolverStrategy.NativeMethodInfoPtr_GetName_Public_Virtual_String_MemberInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0000BC74 File Offset: 0x00009E74
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonResolverStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002E4B File Offset: 0x0000104B
		public JsonResolverStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000179 RID: 377
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0;

		// Token: 0x0400017A RID: 378
		private static readonly IntPtr NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0;

		// Token: 0x0400017B RID: 379
		private static readonly IntPtr NativeMethodInfoPtr_GetValueIgnoredCallback_Public_Virtual_ValueIgnoredDelegate_MemberInfo_0;

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_MemberInfo_0;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004E RID: 78
		[ObfuscatedName("JsonFx.Json.Resolvers.JsonResolverStrategy+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x06000430 RID: 1072 RVA: 0x00012BAC File Offset: 0x00010DAC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JsonResolverStrategy>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr);
				JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_specifiedPropertyGetter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, "specifiedPropertyGetter");
				JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_defaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, "defaultValue");
				JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, 100663631);
				JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__0_Internal_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, 100663632);
				JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__1_Internal_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, 100663633);
				JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__2_Internal_Boolean_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr, 100663634);
			}

			// Token: 0x06000431 RID: 1073 RVA: 0x00012C50 File Offset: 0x00010E50
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonResolverStrategy.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000432 RID: 1074 RVA: 0x00012C8C File Offset: 0x00010E8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192923, XrefRangeEnd = 1192927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValueIgnoredCallback_b__0(Object target, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__0_Internal_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000433 RID: 1075 RVA: 0x00012CEC File Offset: 0x00010EEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192927, XrefRangeEnd = 1192928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValueIgnoredCallback_b__1(Object target, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__1_Internal_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000434 RID: 1076 RVA: 0x00012D4C File Offset: 0x00010F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1192928, XrefRangeEnd = 1192930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetValueIgnoredCallback_b__2(Object target, Object value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonResolverStrategy.__c__DisplayClass2_0.NativeMethodInfoPtr__GetValueIgnoredCallback_b__2_Internal_Boolean_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000435 RID: 1077 RVA: 0x00003B2C File Offset: 0x00001D2C
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000436 RID: 1078 RVA: 0x00012DAC File Offset: 0x00010FAC
			// (set) Token: 0x06000437 RID: 1079 RVA: 0x00003B35 File Offset: 0x00001D35
			public unsafe GetterDelegate specifiedPropertyGetter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_specifiedPropertyGetter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetterDelegate>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_specifiedPropertyGetter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000133 RID: 307
			// (get) Token: 0x06000438 RID: 1080 RVA: 0x00012DDC File Offset: 0x00010FDC
			// (set) Token: 0x06000439 RID: 1081 RVA: 0x00003B54 File Offset: 0x00001D54
			public unsafe Object defaultValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_defaultValue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(JsonResolverStrategy.__c__DisplayClass2_0.NativeFieldInfoPtr_defaultValue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002C5 RID: 709
			private static readonly IntPtr NativeFieldInfoPtr_specifiedPropertyGetter;

			// Token: 0x040002C6 RID: 710
			private static readonly IntPtr NativeFieldInfoPtr_defaultValue;

			// Token: 0x040002C7 RID: 711
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002C8 RID: 712
			private static readonly IntPtr NativeMethodInfoPtr__GetValueIgnoredCallback_b__0_Internal_Boolean_Object_Object_0;

			// Token: 0x040002C9 RID: 713
			private static readonly IntPtr NativeMethodInfoPtr__GetValueIgnoredCallback_b__1_Internal_Boolean_Object_Object_0;

			// Token: 0x040002CA RID: 714
			private static readonly IntPtr NativeMethodInfoPtr__GetValueIgnoredCallback_b__2_Internal_Boolean_Object_Object_0;
		}
	}
}
