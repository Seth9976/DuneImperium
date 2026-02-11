using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F4 RID: 244
	public sealed class AmbientValueAttribute : Attribute
	{
		// Token: 0x06000FB2 RID: 4018 RVA: 0x0005709C File Offset: 0x0005529C
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientValueAttribute()
		{
			Il2CppClassPointerStore<AmbientValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "AmbientValueAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientValueAttribute>.NativeClassPtr);
			AmbientValueAttribute.NativeFieldInfoPtr__Value_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientValueAttribute>.NativeClassPtr, "<Value>k__BackingField");
			AmbientValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientValueAttribute>.NativeClassPtr, 100665555);
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000570F4 File Offset: 0x000552F4
		public unsafe Object Value
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientValueAttribute.NativeMethodInfoPtr_get_Value_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00007AA4 File Offset: 0x00005CA4
		public AmbientValueAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00057134 File Offset: 0x00055334
		// (set) Token: 0x06000FB6 RID: 4022 RVA: 0x00007AAD File Offset: 0x00005CAD
		public unsafe Object _Value_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientValueAttribute.NativeFieldInfoPtr__Value_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientValueAttribute.NativeFieldInfoPtr__Value_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CB3 RID: 3251
		private static readonly IntPtr NativeFieldInfoPtr__Value_k__BackingField;

		// Token: 0x04000CB4 RID: 3252
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_Object_0;
	}
}
