using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001A RID: 26
	public class OptionsFactory<TOptions> : Object where TOptions : class
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003EEC File Offset: 0x000020EC
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsFactory()
		{
			Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsFactory`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr);
			OptionsFactory<TOptions>.NativeFieldInfoPtr__setups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, "_setups");
			OptionsFactory<TOptions>.NativeFieldInfoPtr__postConfigures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, "_postConfigures");
			OptionsFactory<TOptions>.NativeFieldInfoPtr__validations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, "_validations");
			OptionsFactory<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, 100663340);
			OptionsFactory<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_IEnumerable_1_IValidateOptions_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, 100663341);
			OptionsFactory<TOptions>.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, 100663342);
			OptionsFactory<TOptions>.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr, 100663343);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003FE4 File Offset: 0x000021E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265777, XrefRangeEnd = 1265782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsFactory(IEnumerable<IConfigureOptions<TOptions>> setups, IEnumerable<IPostConfigureOptions<TOptions>> postConfigures)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setups);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postConfigures);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsFactory<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00004044 File Offset: 0x00002244
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265805, RefRangeEnd = 1265806, XrefRangeStart = 1265782, XrefRangeEnd = 1265805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptionsFactory(IEnumerable<IConfigureOptions<TOptions>> setups, IEnumerable<IPostConfigureOptions<TOptions>> postConfigures, IEnumerable<IValidateOptions<TOptions>> validations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsFactory<TOptions>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(setups);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(postConfigures);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(validations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsFactory<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_IEnumerable_1_IValidateOptions_1_TOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000040B4 File Offset: 0x000022B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265806, XrefRangeEnd = 1265837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TOptions Create(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsFactory<TOptions>.NativeMethodInfoPtr_Create_Public_Virtual_Final_New_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00004100 File Offset: 0x00002300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265837, XrefRangeEnd = 1265838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TOptions CreateInstance(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptionsFactory<TOptions>.NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_TOptions_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TOptions>(intPtr, false, true);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000022FE File Offset: 0x000004FE
		public OptionsFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004158 File Offset: 0x00002358
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002307 File Offset: 0x00000507
		public unsafe Il2CppReferenceArray<IConfigureOptions<TOptions>> _setups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__setups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IConfigureOptions<TOptions>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__setups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004188 File Offset: 0x00002388
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002326 File Offset: 0x00000526
		public unsafe Il2CppReferenceArray<IPostConfigureOptions<TOptions>> _postConfigures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__postConfigures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IPostConfigureOptions<TOptions>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__postConfigures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000041B8 File Offset: 0x000023B8
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00002345 File Offset: 0x00000545
		public unsafe Il2CppReferenceArray<IValidateOptions<TOptions>> _validations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__validations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IValidateOptions<TOptions>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsFactory<TOptions>.NativeFieldInfoPtr__validations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr__setups;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeFieldInfoPtr__postConfigures;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeFieldInfoPtr__validations;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_IConfigureOptions_1_TOptions_IEnumerable_1_IPostConfigureOptions_1_TOptions_IEnumerable_1_IValidateOptions_1_TOptions_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Final_New_TOptions_String_0;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Protected_Virtual_New_TOptions_String_0;
	}
}
