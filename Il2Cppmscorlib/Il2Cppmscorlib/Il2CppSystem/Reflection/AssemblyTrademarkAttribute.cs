using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000402 RID: 1026
	public sealed class AssemblyTrademarkAttribute : Attribute
	{
		// Token: 0x06003BAD RID: 15277 RVA: 0x0011E1F4 File Offset: 0x0011C3F4
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyTrademarkAttribute()
		{
			Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "AssemblyTrademarkAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr);
			AssemblyTrademarkAttribute.NativeFieldInfoPtr__Trademark_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, "<Trademark>k__BackingField");
			AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr, 100672184);
		}

		// Token: 0x06003BAE RID: 15278 RVA: 0x0011E24C File Offset: 0x0011C44C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssemblyTrademarkAttribute(string trademark)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssemblyTrademarkAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(trademark);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssemblyTrademarkAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x000163F3 File Offset: 0x000145F3
		public AssemblyTrademarkAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x0011E298 File Offset: 0x0011C498
		// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x000163FC File Offset: 0x000145FC
		public unsafe string _Trademark_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr__Trademark_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssemblyTrademarkAttribute.NativeFieldInfoPtr__Trademark_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003033 RID: 12339
		private static readonly IntPtr NativeFieldInfoPtr__Trademark_k__BackingField;

		// Token: 0x04003034 RID: 12340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
