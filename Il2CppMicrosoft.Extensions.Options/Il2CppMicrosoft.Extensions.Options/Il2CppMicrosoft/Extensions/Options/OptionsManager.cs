using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001B RID: 27
	public class OptionsManager<TOptions> : Object where TOptions : class
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000041E8 File Offset: 0x000023E8
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsManager()
		{
			Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsManager`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr);
			OptionsManager<TOptions>.NativeFieldInfoPtr__factory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, "_factory");
			OptionsManager<TOptions>.NativeFieldInfoPtr__cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, "_cache");
			OptionsManager<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, 100663344);
			OptionsManager<TOptions>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, 100663345);
			OptionsManager<TOptions>.NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, 100663346);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000042B8 File Offset: 0x000024B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265841, XrefRangeEnd = 1265858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsManager(IOptionsFactory<TOptions> factory)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(factory);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsManager<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004304 File Offset: 0x00002504
		public unsafe virtual TOptions Value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265858, XrefRangeEnd = 1265862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsManager<TOptions>.NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00004340 File Offset: 0x00002540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265862, XrefRangeEnd = 1265874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TOptions Get(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsManager<TOptions>.NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002364 File Offset: 0x00000564
		public OptionsManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00004398 File Offset: 0x00002598
		// (set) Token: 0x06000077 RID: 119 RVA: 0x0000236D File Offset: 0x0000056D
		public unsafe IOptionsFactory<TOptions> _factory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.NativeFieldInfoPtr__factory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsFactory<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.NativeFieldInfoPtr__factory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000043C8 File Offset: 0x000025C8
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000238C File Offset: 0x0000058C
		public unsafe OptionsCache<TOptions> _cache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.NativeFieldInfoPtr__cache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptionsCache<TOptions>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.NativeFieldInfoPtr__cache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr__factory;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr__cache;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IOptionsFactory_1_TOptions_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Virtual_Final_New_get_TOptions_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_New_TOptions_String_0;

		// Token: 0x02000026 RID: 38
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsManager`1+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x060000DB RID: 219 RVA: 0x000058CC File Offset: 0x00003ACC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsManager<TOptions>>.NativeClassPtr, "<>c__DisplayClass5_0"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr);
				OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr, "localFactory");
				OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr, "localName");
				OptionsManager<TOptions>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr, 100663347);
				OptionsManager<TOptions>.__c__DisplayClass5_0.NativeMethodInfoPtr__Get_b__0_Internal_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr, 100663348);
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00005984 File Offset: 0x00003B84
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsManager<TOptions>.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000DD RID: 221 RVA: 0x000059C0 File Offset: 0x00003BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265838, XrefRangeEnd = 1265841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TOptions _Get_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeMethodInfoPtr__Get_b__0_Internal_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}

			// Token: 0x060000DE RID: 222 RVA: 0x000026B3 File Offset: 0x000008B3
			public __c__DisplayClass5_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x060000DF RID: 223 RVA: 0x000059FC File Offset: 0x00003BFC
			// (set) Token: 0x060000E0 RID: 224 RVA: 0x000026BC File Offset: 0x000008BC
			public unsafe IOptionsFactory<TOptions> localFactory
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localFactory);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IOptionsFactory<TOptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005A2C File Offset: 0x00003C2C
			// (set) Token: 0x060000E2 RID: 226 RVA: 0x000026DB File Offset: 0x000008DB
			public unsafe string localName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsManager<TOptions>.__c__DisplayClass5_0.NativeFieldInfoPtr_localName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400007F RID: 127
			private static readonly IntPtr NativeFieldInfoPtr_localFactory;

			// Token: 0x04000080 RID: 128
			private static readonly IntPtr NativeFieldInfoPtr_localName;

			// Token: 0x04000081 RID: 129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000082 RID: 130
			private static readonly IntPtr NativeMethodInfoPtr__Get_b__0_Internal_TOptions_0;
		}
	}
}
