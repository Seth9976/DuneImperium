using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.data
{
	// Token: 0x020001C4 RID: 452
	public class FlavoredClassAttribute : Attribute
	{
		// Token: 0x0600193D RID: 6461 RVA: 0x000782C8 File Offset: 0x000764C8
		// Note: this type is marked as 'beforefieldinit'.
		static FlavoredClassAttribute()
		{
			Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data", "FlavoredClassAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr);
			FlavoredClassAttribute.NativeFieldInfoPtr__Flavors_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr, "<Flavors>k__BackingField");
			FlavoredClassAttribute.NativeMethodInfoPtr_get_Flavors_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr, 100667301);
			FlavoredClassAttribute.NativeMethodInfoPtr_set_Flavors_Private_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr, 100667302);
			FlavoredClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr, 100667303);
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x00078348 File Offset: 0x00076548
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x00078388 File Offset: 0x00076588
		public unsafe Il2CppStringArray Flavors
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassAttribute.NativeMethodInfoPtr_get_Flavors_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassAttribute.NativeMethodInfoPtr_set_Flavors_Private_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x000783CC File Offset: 0x000765CC
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlavoredClassAttribute([Optional] Il2CppStringArray flavors)
		{
			if (flavors == null)
			{
				flavors = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlavoredClassAttribute>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(flavors);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlavoredClassAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0000B161 File Offset: 0x00009361
		public FlavoredClassAttribute(params string[] flavors)
			: this(new Il2CppStringArray(flavors))
		{
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0000B16F File Offset: 0x0000936F
		public FlavoredClassAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x00078424 File Offset: 0x00076624
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0000B178 File Offset: 0x00009378
		public unsafe Il2CppStringArray _Flavors_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassAttribute.NativeFieldInfoPtr__Flavors_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlavoredClassAttribute.NativeFieldInfoPtr__Flavors_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011C4 RID: 4548
		private static readonly IntPtr NativeFieldInfoPtr__Flavors_k__BackingField;

		// Token: 0x040011C5 RID: 4549
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_get_Il2CppStringArray_0;

		// Token: 0x040011C6 RID: 4550
		private static readonly IntPtr NativeMethodInfoPtr_set_Flavors_Private_set_Void_Il2CppStringArray_0;

		// Token: 0x040011C7 RID: 4551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
