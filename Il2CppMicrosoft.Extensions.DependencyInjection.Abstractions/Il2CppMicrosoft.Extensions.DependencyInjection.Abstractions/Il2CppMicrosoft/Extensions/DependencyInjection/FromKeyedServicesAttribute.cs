using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x0200000D RID: 13
	public class FromKeyedServicesAttribute : Attribute
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00002E7C File Offset: 0x0000107C
		// Note: this type is marked as 'beforefieldinit'.
		static FromKeyedServicesAttribute()
		{
			Il2CppClassPointerStore<FromKeyedServicesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "FromKeyedServicesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FromKeyedServicesAttribute>.NativeClassPtr);
			FromKeyedServicesAttribute.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FromKeyedServicesAttribute>.NativeClassPtr, "<Key>k__BackingField");
			FromKeyedServicesAttribute.NativeMethodInfoPtr_get_Key_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FromKeyedServicesAttribute>.NativeClassPtr, 100663318);
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002ED4 File Offset: 0x000010D4
		public unsafe Object Key
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FromKeyedServicesAttribute.NativeMethodInfoPtr_get_Key_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000021D2 File Offset: 0x000003D2
		public FromKeyedServicesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003C RID: 60 RVA: 0x00002F14 File Offset: 0x00001114
		// (set) Token: 0x0600003D RID: 61 RVA: 0x000021DB File Offset: 0x000003DB
		public unsafe Object _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FromKeyedServicesAttribute.NativeFieldInfoPtr__Key_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FromKeyedServicesAttribute.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002E RID: 46
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x0400002F RID: 47
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_Object_0;
	}
}
