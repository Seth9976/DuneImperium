using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x0200001B RID: 27
	public sealed class DynamicAtlasCustomFilter : MulticastDelegate
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00021C64 File Offset: 0x0001FE64
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicAtlasCustomFilter()
		{
			Il2CppClassPointerStore<DynamicAtlasCustomFilter>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "DynamicAtlasCustomFilter");
			DynamicAtlasCustomFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasCustomFilter>.NativeClassPtr, 100663484);
			DynamicAtlasCustomFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Texture2D_byref_DynamicAtlasFilters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicAtlasCustomFilter>.NativeClassPtr, 100663485);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00021CB4 File Offset: 0x0001FEB4
		[CallerCount(23)]
		[CachedScanResults(RefRangeStart = 283310, RefRangeEnd = 283333, XrefRangeStart = 283306, XrefRangeEnd = 283310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicAtlasCustomFilter(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicAtlasCustomFilter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasCustomFilter.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00021D10 File Offset: 0x0001FF10
		[CallerCount(0)]
		public unsafe bool Invoke(Texture2D texture, ref DynamicAtlasFilters filtersToApply)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(texture);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &filtersToApply;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicAtlasCustomFilter.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Texture2D_byref_DynamicAtlasFilters_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000266D File Offset: 0x0000086D
		public DynamicAtlasCustomFilter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400013A RID: 314
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400013B RID: 315
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Texture2D_byref_DynamicAtlasFilters_0;
	}
}
