using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace CanisData.generation.builders
{
	// Token: 0x0200002C RID: 44
	public class SampleBuilder : ScriptBuilder
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00009CA0 File Offset: 0x00007EA0
		// Note: this type is marked as 'beforefieldinit'.
		static SampleBuilder()
		{
			Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr = IL2CPP.GetIl2CppClass("CanisData.dll", "CanisData.generation.builders", "SampleBuilder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr);
			SampleBuilder.NativeFieldInfoPtr__Namespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr, "<Namespace>k__BackingField");
			SampleBuilder.NativeMethodInfoPtr_get_Namespace_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr, 100663518);
			SampleBuilder.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr, 100663519);
			SampleBuilder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr, 100663520);
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00009D20 File Offset: 0x00007F20
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00009D58 File Offset: 0x00007F58
		public unsafe string Namespace
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleBuilder.NativeMethodInfoPtr_get_Namespace_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleBuilder.NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00009D9C File Offset: 0x00007F9C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SampleBuilder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SampleBuilder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SampleBuilder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002CCC File Offset: 0x00000ECC
		public SampleBuilder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00009DD8 File Offset: 0x00007FD8
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002CD5 File Offset: 0x00000ED5
		public unsafe string _Namespace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBuilder.NativeFieldInfoPtr__Namespace_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SampleBuilder.NativeFieldInfoPtr__Namespace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000108 RID: 264
		private static readonly IntPtr NativeFieldInfoPtr__Namespace_k__BackingField;

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeMethodInfoPtr_get_Namespace_Public_get_String_0;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_set_Namespace_Public_set_Void_String_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
