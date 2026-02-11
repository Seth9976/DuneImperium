using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace zen.src.preferences
{
	// Token: 0x0200004E RID: 78
	public class DefaultConfigValues : Object
	{
		// Token: 0x0600030E RID: 782 RVA: 0x0001AE28 File Offset: 0x00019028
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultConfigValues()
		{
			Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.preferences", "DefaultConfigValues");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr);
			DefaultConfigValues.NativeMethodInfoPtr_getString_Protected_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663823);
			DefaultConfigValues.NativeMethodInfoPtr_getInt_Protected_Virtual_New_Nullable_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663824);
			DefaultConfigValues.NativeMethodInfoPtr_getBool_Protected_Virtual_New_Nullable_1_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663825);
			DefaultConfigValues.NativeMethodInfoPtr_GetString_Public_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663826);
			DefaultConfigValues.NativeMethodInfoPtr_GetInt_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663827);
			DefaultConfigValues.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663828);
			DefaultConfigValues.NativeMethodInfoPtr_Env_Protected_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663829);
			DefaultConfigValues.NativeMethodInfoPtr_Env_Protected_Static_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663830);
			DefaultConfigValues.NativeMethodInfoPtr_Get_Public_Static_DefaultConfigValues_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663831);
			DefaultConfigValues.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, 100663832);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0001AF20 File Offset: 0x00019120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985594, XrefRangeEnd = 985652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string getString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultConfigValues.NativeMethodInfoPtr_getString_Protected_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0001AF74 File Offset: 0x00019174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985652, XrefRangeEnd = 985656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<int> getInt(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultConfigValues.NativeMethodInfoPtr_getInt_Protected_Virtual_New_Nullable_1_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<int>(intPtr);
			}
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0001AFC8 File Offset: 0x000191C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985656, XrefRangeEnd = 985702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Nullable<bool> getBool(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultConfigValues.NativeMethodInfoPtr_getBool_Protected_Virtual_New_Nullable_1_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0001B01C File Offset: 0x0001921C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985702, XrefRangeEnd = 985711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_GetString_Public_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0001B064 File Offset: 0x00019264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985711, XrefRangeEnd = 985720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_GetInt_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0001B0B4 File Offset: 0x000192B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985720, XrefRangeEnd = 985729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_GetBool_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0001B104 File Offset: 0x00019304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75263, RefRangeEnd = 75264, XrefRangeStart = 75263, XrefRangeEnd = 75264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Env(string internalValue, string releaseValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(internalValue);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(releaseValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_Env_Protected_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0001B154 File Offset: 0x00019354
		[CallerCount(0)]
		public unsafe static bool Env(bool internalValue, bool releaseValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref internalValue;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref releaseValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_Env_Protected_Static_Boolean_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0001B1A0 File Offset: 0x000193A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 985769, RefRangeEnd = 985770, XrefRangeStart = 985729, XrefRangeEnd = 985769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DefaultConfigValues Get()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr_Get_Public_Static_DefaultConfigValues_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultConfigValues>(intPtr3) : null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0001B1D4 File Offset: 0x000193D4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultConfigValues()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x00003510 File Offset: 0x00001710
		public DefaultConfigValues(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001F2 RID: 498
		private static readonly IntPtr NativeMethodInfoPtr_getString_Protected_Virtual_New_String_String_0;

		// Token: 0x040001F3 RID: 499
		private static readonly IntPtr NativeMethodInfoPtr_getInt_Protected_Virtual_New_Nullable_1_Int32_String_0;

		// Token: 0x040001F4 RID: 500
		private static readonly IntPtr NativeMethodInfoPtr_getBool_Protected_Virtual_New_Nullable_1_Boolean_String_0;

		// Token: 0x040001F5 RID: 501
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_0;

		// Token: 0x040001F6 RID: 502
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_0;

		// Token: 0x040001F7 RID: 503
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_0;

		// Token: 0x040001F8 RID: 504
		private static readonly IntPtr NativeMethodInfoPtr_Env_Protected_Static_String_String_String_0;

		// Token: 0x040001F9 RID: 505
		private static readonly IntPtr NativeMethodInfoPtr_Env_Protected_Static_Boolean_Boolean_Boolean_0;

		// Token: 0x040001FA RID: 506
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Static_DefaultConfigValues_0;

		// Token: 0x040001FB RID: 507
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020001B7 RID: 439
		public sealed class EmptyConfig : DefaultConfigValues
		{
			// Token: 0x06001527 RID: 5415 RVA: 0x0000BE74 File Offset: 0x0000A074
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyConfig()
			{
				Il2CppClassPointerStore<DefaultConfigValues.EmptyConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, "EmptyConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultConfigValues.EmptyConfig>.NativeClassPtr);
				DefaultConfigValues.EmptyConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues.EmptyConfig>.NativeClassPtr, 100663833);
			}

			// Token: 0x06001528 RID: 5416 RVA: 0x00052404 File Offset: 0x00050604
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyConfig()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultConfigValues.EmptyConfig>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.EmptyConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001529 RID: 5417 RVA: 0x0000BEA8 File Offset: 0x0000A0A8
			public EmptyConfig(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000CD1 RID: 3281
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001B8 RID: 440
		[ObfuscatedName("zen.src.preferences.DefaultConfigValues+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600152A RID: 5418 RVA: 0x00052440 File Offset: 0x00050640
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DefaultConfigValues>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr);
				DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_classType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr, "classType");
				DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_emptyType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr, "emptyType");
				DefaultConfigValues.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr, 100663834);
				DefaultConfigValues.__c__DisplayClass8_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr, 100663835);
			}

			// Token: 0x0600152B RID: 5419 RVA: 0x000524BC File Offset: 0x000506BC
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultConfigValues.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600152C RID: 5420 RVA: 0x000524F8 File Offset: 0x000506F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985587, XrefRangeEnd = 985594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Get_b__0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultConfigValues.__c__DisplayClass8_0.NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600152D RID: 5421 RVA: 0x0000BEB1 File Offset: 0x0000A0B1
			public __c__DisplayClass8_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000608 RID: 1544
			// (get) Token: 0x0600152E RID: 5422 RVA: 0x00052548 File Offset: 0x00050748
			// (set) Token: 0x0600152F RID: 5423 RVA: 0x0000BEBA File Offset: 0x0000A0BA
			public unsafe Type classType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_classType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_classType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000609 RID: 1545
			// (get) Token: 0x06001530 RID: 5424 RVA: 0x00052578 File Offset: 0x00050778
			// (set) Token: 0x06001531 RID: 5425 RVA: 0x0000BED9 File Offset: 0x0000A0D9
			public unsafe Type emptyType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_emptyType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultConfigValues.__c__DisplayClass8_0.NativeFieldInfoPtr_emptyType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CD2 RID: 3282
			private static readonly IntPtr NativeFieldInfoPtr_classType;

			// Token: 0x04000CD3 RID: 3283
			private static readonly IntPtr NativeFieldInfoPtr_emptyType;

			// Token: 0x04000CD4 RID: 3284
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000CD5 RID: 3285
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_Boolean_Type_0;
		}
	}
}
