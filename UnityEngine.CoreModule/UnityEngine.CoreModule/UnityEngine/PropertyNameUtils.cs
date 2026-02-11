using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000118 RID: 280
	public class PropertyNameUtils : Object
	{
		// Token: 0x060016C1 RID: 5825 RVA: 0x0006D398 File Offset: 0x0006B598
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyNameUtils()
		{
			Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "PropertyNameUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100666438);
			PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyNameUtils>.NativeClassPtr, 100666439);
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x0006D3F0 File Offset: 0x0006B5F0
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 660178, RefRangeEnd = 660198, XrefRangeStart = 660176, XrefRangeEnd = 660178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertyName PropertyNameFromString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x0006D434 File Offset: 0x0006B634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660198, XrefRangeEnd = 660200, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PropertyNameFromString_Injected(string name, out PropertyName ret)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &ret;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyNameUtils.NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x0000901A File Offset: 0x0000721A
		public PropertyNameUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014CF RID: 5327
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Public_Static_PropertyName_String_0;

		// Token: 0x040014D0 RID: 5328
		private static readonly IntPtr NativeMethodInfoPtr_PropertyNameFromString_Injected_Private_Static_Void_String_byref_PropertyName_0;
	}
}
