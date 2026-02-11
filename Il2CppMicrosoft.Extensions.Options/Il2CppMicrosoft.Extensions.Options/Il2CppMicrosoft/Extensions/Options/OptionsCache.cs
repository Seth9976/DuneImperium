using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Concurrent;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x02000019 RID: 25
	public class OptionsCache<TOptions> : Object where TOptions : class
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003B9C File Offset: 0x00001D9C
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsCache()
		{
			Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsCache`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr);
			OptionsCache<TOptions>.NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, "_cache");
			OptionsCache<TOptions>.NativeMethodInfoPtr_GetOrAdd_Public_Virtual_New_TOptions_String_Func_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, 100663325);
			OptionsCache<TOptions>.NativeMethodInfoPtr_GetOrAdd_Internal_TOptions_String_Func_3_String_TArg_TOptions_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, 100663326);
			OptionsCache<TOptions>.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_String_byref_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, 100663327);
			OptionsCache<TOptions>.NativeMethodInfoPtr_TryRemove_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, 100663328);
			OptionsCache<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, 100663329);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00003C80 File Offset: 0x00001E80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265700, XrefRangeEnd = 1265722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TOptions GetOrAdd(string name, Func<TOptions> createOptions)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createOptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsCache<TOptions>.NativeMethodInfoPtr_GetOrAdd_Public_Virtual_New_TOptions_String_Func_1_TOptions_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003CE8 File Offset: 0x00001EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265722, XrefRangeEnd = 1265755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TOptions GetOrAdd<TArg>(string name, Func<string, TArg, TOptions> createOptions, TArg factoryArgument)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createOptions);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TArg).IsValueType)
			{
				TArg targ = factoryArgument;
				intPtr = ((targ is string) ? IL2CPP.ManagedStringToIl2Cpp(targ as string) : IL2CPP.Il2CppObjectBaseToPtr(targ as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref factoryArgument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TArg>.MethodInfoStoreGeneric_GetOrAdd_Internal_TOptions_String_Func_3_String_TArg_TOptions_TArg_0.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<TOptions>(intPtr2, false, true);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003D8C File Offset: 0x00001F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265755, XrefRangeEnd = 1265760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(string name, out TOptions options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TOptions).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref options;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.NativeMethodInfoPtr_TryGetValue_Internal_Boolean_String_byref_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TOptions).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				options = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TOptions>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003E28 File Offset: 0x00002028
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265760, XrefRangeEnd = 1265765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryRemove(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsCache<TOptions>.NativeMethodInfoPtr_TryRemove_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003E80 File Offset: 0x00002080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265765, XrefRangeEnd = 1265777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsCache()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000022D6 File Offset: 0x000004D6
		public OptionsCache(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003EBC File Offset: 0x000020BC
		// (set) Token: 0x06000064 RID: 100 RVA: 0x000022DF File Offset: 0x000004DF
		public unsafe ConcurrentDictionary<string, Lazy<TOptions>> _cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.NativeFieldInfoPtr__cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConcurrentDictionary<string, Lazy<TOptions>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.NativeFieldInfoPtr__cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000037 RID: 55
		private static readonly IntPtr NativeFieldInfoPtr__cache;

		// Token: 0x04000038 RID: 56
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Public_Virtual_New_TOptions_String_Func_1_TOptions_0;

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeMethodInfoPtr_GetOrAdd_Internal_TOptions_String_Func_3_String_TArg_TOptions_TArg_0;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Internal_Boolean_String_byref_TOptions_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_TryRemove_Public_Virtual_New_Boolean_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000021 RID: 33
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsCache`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060000B8 RID: 184 RVA: 0x00005100 File Offset: 0x00003300
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr);
				OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr, "<>9");
				OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr, "<>9__2_0");
				OptionsCache<TOptions>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr, 100663331);
				OptionsCache<TOptions>.__c.NativeMethodInfoPtr__GetOrAdd_b__2_0_Internal_Lazy_1_TOptions_String_Func_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr, 100663332);
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x000051B8 File Offset: 0x000033B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCache<TOptions>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000BA RID: 186 RVA: 0x000051F4 File Offset: 0x000033F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265673, XrefRangeEnd = 1265676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Lazy<TOptions> _GetOrAdd_b__2_0(string name, Func<TOptions> createOptions)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(createOptions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c.NativeMethodInfoPtr__GetOrAdd_b__2_0_Internal_Lazy_1_TOptions_String_Func_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lazy<TOptions>>(intPtr3) : null;
			}

			// Token: 0x060000BB RID: 187 RVA: 0x000025BC File Offset: 0x000007BC
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x060000BC RID: 188 RVA: 0x00005258 File Offset: 0x00003458
			// (set) Token: 0x060000BD RID: 189 RVA: 0x000025C5 File Offset: 0x000007C5
			public unsafe static OptionsCache<TOptions>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionsCache<TOptions>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x060000BE RID: 190 RVA: 0x00005280 File Offset: 0x00003480
			// (set) Token: 0x060000BF RID: 191 RVA: 0x000025D7 File Offset: 0x000007D7
			public unsafe static Func<string, Func<TOptions>, Lazy<TOptions>> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, Func<TOptions>, Lazy<TOptions>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsCache<TOptions>.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400006D RID: 109
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400006E RID: 110
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x0400006F RID: 111
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000070 RID: 112
			private static readonly IntPtr NativeMethodInfoPtr__GetOrAdd_b__2_0_Internal_Lazy_1_TOptions_String_Func_1_TOptions_0;
		}

		// Token: 0x02000022 RID: 34
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsCache`1+<>c__3`1")]
		[Serializable]
		public sealed class __c__3<TArg> : Object
		{
			// Token: 0x060000C0 RID: 192 RVA: 0x000052A8 File Offset: 0x000034A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__3()
			{
				Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, "<>c__3`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr);
				OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr, "<>9");
				OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr, "<>9__3_0");
				OptionsCache<TOptions>.__c__3<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr, 100663334);
				OptionsCache<TOptions>.__c__3<TArg>.NativeMethodInfoPtr__GetOrAdd_b__3_0_Internal_Lazy_1_TOptions_String_ValueTuple_2_Func_3_String_TArg_TOptions_TArg_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr, 100663335);
			}

			// Token: 0x060000C1 RID: 193 RVA: 0x00005370 File Offset: 0x00003570
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__3()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__3<TArg>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__3<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x000053AC File Offset: 0x000035AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265676, XrefRangeEnd = 1265687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Lazy<TOptions> _GetOrAdd_b__3_0(string name, ValueTuple<Func<string, TArg, TOptions>, TArg> arg)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(arg));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__3<TArg>.NativeMethodInfoPtr__GetOrAdd_b__3_0_Internal_Lazy_1_TOptions_String_ValueTuple_2_Func_3_String_TArg_TOptions_TArg_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Lazy<TOptions>>(intPtr3) : null;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x000025E9 File Offset: 0x000007E9
			public __c__3(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x00005414 File Offset: 0x00003614
			// (set) Token: 0x060000C5 RID: 197 RVA: 0x000025F2 File Offset: 0x000007F2
			public unsafe static OptionsCache<TOptions>.__c__3<TArg> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionsCache<TOptions>.__c__3<TArg>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000543C File Offset: 0x0000363C
			// (set) Token: 0x060000C7 RID: 199 RVA: 0x00002604 File Offset: 0x00000804
			public unsafe static Func<string, ValueTuple<Func<string, TArg, TOptions>, TArg>, Lazy<TOptions>> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, ValueTuple<Func<string, TArg, TOptions>, TArg>, Lazy<TOptions>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(OptionsCache<TOptions>.__c__3<TArg>.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000071 RID: 113
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04000072 RID: 114
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04000073 RID: 115
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000074 RID: 116
			private static readonly IntPtr NativeMethodInfoPtr__GetOrAdd_b__3_0_Internal_Lazy_1_TOptions_String_ValueTuple_2_Func_3_String_TArg_TOptions_TArg_0;
		}

		// Token: 0x02000023 RID: 35
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsCache`1+<>c__DisplayClass3_0`1")]
		public sealed class __c__DisplayClass3_0<TArg> : Object
		{
			// Token: 0x060000C8 RID: 200 RVA: 0x00005464 File Offset: 0x00003664
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, "<>c__DisplayClass3_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr);
				OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localCreateOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr, "localCreateOptions");
				OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr, "localName");
				OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localFactoryArgument = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr, "localFactoryArgument");
				OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr, 100663336);
				OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeMethodInfoPtr__GetOrAdd_b__1_Internal_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr, 100663337);
			}

			// Token: 0x060000C9 RID: 201 RVA: 0x00005540 File Offset: 0x00003740
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000CA RID: 202 RVA: 0x0000557C File Offset: 0x0000377C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265687, XrefRangeEnd = 1265692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TOptions _GetOrAdd_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeMethodInfoPtr__GetOrAdd_b__1_Internal_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}

			// Token: 0x060000CB RID: 203 RVA: 0x00002616 File Offset: 0x00000816
			public __c__DisplayClass3_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x060000CC RID: 204 RVA: 0x000055B8 File Offset: 0x000037B8
			// (set) Token: 0x060000CD RID: 205 RVA: 0x0000261F File Offset: 0x0000081F
			public unsafe Func<string, TArg, TOptions> localCreateOptions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localCreateOptions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, TArg, TOptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localCreateOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x060000CE RID: 206 RVA: 0x000055E8 File Offset: 0x000037E8
			// (set) Token: 0x060000CF RID: 207 RVA: 0x0000263E File Offset: 0x0000083E
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x060000D0 RID: 208 RVA: 0x00005610 File Offset: 0x00003810
			// (set) Token: 0x060000D1 RID: 209 RVA: 0x00005638 File Offset: 0x00003838
			public unsafe TArg localFactoryArgument
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localFactoryArgument);
					return IL2CPP.PointerToValueGeneric<TArg>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_0<TArg>.NativeFieldInfoPtr_localFactoryArgument);
					Type typeFromHandle = typeof(TArg);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000075 RID: 117
			private static readonly IntPtr NativeFieldInfoPtr_localCreateOptions;

			// Token: 0x04000076 RID: 118
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x04000077 RID: 119
			private static readonly IntPtr NativeFieldInfoPtr_localFactoryArgument;

			// Token: 0x04000078 RID: 120
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000079 RID: 121
			private static readonly IntPtr NativeMethodInfoPtr__GetOrAdd_b__1_Internal_TOptions_0;
		}

		// Token: 0x02000024 RID: 36
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsCache`1+<>c__DisplayClass3_1`1")]
		public sealed class __c__DisplayClass3_1<TArg> : Object
		{
			// Token: 0x060000D2 RID: 210 RVA: 0x000056E0 File Offset: 0x000038E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_1()
			{
				Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsCache<TOptions>>.NativeClassPtr, "<>c__DisplayClass3_1`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr);
				OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_arg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr, "arg");
				OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr, "name");
				OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr, 100663338);
				OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeMethodInfoPtr__GetOrAdd_b__2_Internal_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr, 100663339);
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x000057A8 File Offset: 0x000039A8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_1()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x000057E4 File Offset: 0x000039E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265692, XrefRangeEnd = 1265700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TOptions _GetOrAdd_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeMethodInfoPtr__GetOrAdd_b__2_Internal_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x0000265D File Offset: 0x0000085D
			public __c__DisplayClass3_1(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x060000D6 RID: 214 RVA: 0x00005820 File Offset: 0x00003A20
			// (set) Token: 0x060000D7 RID: 215 RVA: 0x00002666 File Offset: 0x00000866
			public ValueTuple<Func<string, TArg, TOptions>, TArg> arg
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_arg);
					return new ValueTuple<Func<string, TArg, TOptions>, TArg>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<Func<string, TArg, TOptions>, TArg>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_arg), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<Func<string, TArg, TOptions>, TArg>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x060000D8 RID: 216 RVA: 0x00005850 File Offset: 0x00003A50
			// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002694 File Offset: 0x00000894
			public unsafe string name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsCache<TOptions>.__c__DisplayClass3_1<TArg>.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400007A RID: 122
			private static readonly IntPtr NativeFieldInfoPtr_arg;

			// Token: 0x0400007B RID: 123
			private static readonly IntPtr NativeFieldInfoPtr_name;

			// Token: 0x0400007C RID: 124
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400007D RID: 125
			private static readonly IntPtr NativeMethodInfoPtr__GetOrAdd_b__2_Internal_TOptions_0;
		}

		// Token: 0x02000025 RID: 37
		private sealed class MethodInfoStoreGeneric_GetOrAdd_Internal_TOptions_String_Func_3_String_TArg_TOptions_TArg_0
		{
			// Token: 0x0400007E RID: 126
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionsCache<TArg>.NativeMethodInfoPtr_GetOrAdd_Internal_TOptions_String_Func_3_String_TArg_TOptions_TArg_0, Il2CppClassPointerStore<OptionsCache<TArg>>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TArg>.NativeClassPtr)) }))));
		}
	}
}
