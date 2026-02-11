using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200006A RID: 106
	[StructLayout(2)]
	public struct ApplicationMemoryUsageChange
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x0002164C File Offset: 0x0001F84C
		// Note: this type is marked as 'beforefieldinit'.
		static ApplicationMemoryUsageChange()
		{
			Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ApplicationMemoryUsageChange");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr);
			ApplicationMemoryUsageChange.NativeFieldInfoPtr__memoryUsage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, "<memoryUsage>k__BackingField");
			ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663690);
			ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, 100663691);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00003F09 File Offset: 0x00002109
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x000216B8 File Offset: 0x0001F8B8
		public unsafe ApplicationMemoryUsage memoryUsage
		{
			get
			{
				return this._memoryUsage_k__BackingField;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000216EC File Offset: 0x0001F8EC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ApplicationMemoryUsageChange(ApplicationMemoryUsage usage)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref usage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ApplicationMemoryUsageChange.NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00003EF7 File Offset: 0x000020F7
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ApplicationMemoryUsageChange>.NativeClassPtr, ref this));
		}

		// Token: 0x04000308 RID: 776
		private static readonly IntPtr NativeFieldInfoPtr__memoryUsage_k__BackingField;

		// Token: 0x04000309 RID: 777
		private static readonly IntPtr NativeMethodInfoPtr_set_memoryUsage_Private_set_Void_ApplicationMemoryUsage_0;

		// Token: 0x0400030A RID: 778
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ApplicationMemoryUsage_0;

		// Token: 0x0400030B RID: 779
		[FieldOffset(0)]
		public ApplicationMemoryUsage _memoryUsage_k__BackingField;
	}
}
