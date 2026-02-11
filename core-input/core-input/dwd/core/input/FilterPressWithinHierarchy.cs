using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.input
{
	// Token: 0x02000044 RID: 68
	public class FilterPressWithinHierarchy : PressFilter
	{
		// Token: 0x06000204 RID: 516 RVA: 0x0000D260 File Offset: 0x0000B460
		// Note: this type is marked as 'beforefieldinit'.
		static FilterPressWithinHierarchy()
		{
			Il2CppClassPointerStore<FilterPressWithinHierarchy>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-input.dll", "dwd.core.input", "FilterPressWithinHierarchy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilterPressWithinHierarchy>.NativeClassPtr);
			FilterPressWithinHierarchy.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterPressWithinHierarchy>.NativeClassPtr, 100663560);
			FilterPressWithinHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilterPressWithinHierarchy>.NativeClassPtr, 100663561);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000D2B8 File Offset: 0x0000B4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1120423, XrefRangeEnd = 1120430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Matches(Press item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilterPressWithinHierarchy.NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000D310 File Offset: 0x0000B510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilterPressWithinHierarchy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilterPressWithinHierarchy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilterPressWithinHierarchy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00003326 File Offset: 0x00001526
		public FilterPressWithinHierarchy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400012B RID: 299
		private static readonly IntPtr NativeMethodInfoPtr_Matches_Public_Virtual_Boolean_Press_0;

		// Token: 0x0400012C RID: 300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
