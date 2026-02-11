using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Unity.Burst.Intrinsics
{
	// Token: 0x0200001B RID: 27
	public sealed class BurstTargetCpuAttribute : Attribute
	{
		// Token: 0x060001FE RID: 510 RVA: 0x000099B8 File Offset: 0x00007BB8
		// Note: this type is marked as 'beforefieldinit'.
		static BurstTargetCpuAttribute()
		{
			Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst.Intrinsics", "BurstTargetCpuAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr);
			BurstTargetCpuAttribute.NativeFieldInfoPtr_TargetCpu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr, "TargetCpu");
			BurstTargetCpuAttribute.NativeMethodInfoPtr__ctor_Public_Void_BurstTargetCpu_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr, 100665941);
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00009A10 File Offset: 0x00007C10
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BurstTargetCpuAttribute(BurstTargetCpu TargetCpu)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BurstTargetCpuAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref TargetCpu;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BurstTargetCpuAttribute.NativeMethodInfoPtr__ctor_Public_Void_BurstTargetCpu_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002CED File Offset: 0x00000EED
		public BurstTargetCpuAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00009A58 File Offset: 0x00007C58
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002CF6 File Offset: 0x00000EF6
		public unsafe BurstTargetCpu TargetCpu
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstTargetCpuAttribute.NativeFieldInfoPtr_TargetCpu);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BurstTargetCpuAttribute.NativeFieldInfoPtr_TargetCpu)) = value;
			}
		}

		// Token: 0x04000203 RID: 515
		private static readonly IntPtr NativeFieldInfoPtr_TargetCpu;

		// Token: 0x04000204 RID: 516
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BurstTargetCpu_0;
	}
}
