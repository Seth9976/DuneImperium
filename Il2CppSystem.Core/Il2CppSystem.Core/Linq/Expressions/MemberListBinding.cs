using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200006A RID: 106
	public sealed class MemberListBinding : MemberBinding
	{
		// Token: 0x060005C1 RID: 1473 RVA: 0x0002BE4C File Offset: 0x0002A04C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberListBinding()
		{
			Il2CppClassPointerStore<MemberListBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberListBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberListBinding>.NativeClassPtr);
			MemberListBinding.NativeFieldInfoPtr__Initializers_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberListBinding>.NativeClassPtr, "<Initializers>k__BackingField");
			MemberListBinding.NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberListBinding>.NativeClassPtr, 100664525);
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x0002BEA4 File Offset: 0x0002A0A4
		public unsafe ReadOnlyCollection<ElementInit> Initializers
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberListBinding.NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ElementInit>>(intPtr3) : null;
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x000035FD File Offset: 0x000017FD
		public MemberListBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060005C4 RID: 1476 RVA: 0x0002BEE4 File Offset: 0x0002A0E4
		// (set) Token: 0x060005C5 RID: 1477 RVA: 0x00003606 File Offset: 0x00001806
		public unsafe ReadOnlyCollection<ElementInit> _Initializers_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberListBinding.NativeFieldInfoPtr__Initializers_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<ElementInit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberListBinding.NativeFieldInfoPtr__Initializers_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeFieldInfoPtr__Initializers_k__BackingField;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_get_Initializers_Public_get_ReadOnlyCollection_1_ElementInit_0;
	}
}
