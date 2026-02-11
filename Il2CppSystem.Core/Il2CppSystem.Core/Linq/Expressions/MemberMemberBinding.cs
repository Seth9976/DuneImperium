using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.ObjectModel;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x0200006B RID: 107
	public sealed class MemberMemberBinding : MemberBinding
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x0002BF14 File Offset: 0x0002A114
		// Note: this type is marked as 'beforefieldinit'.
		static MemberMemberBinding()
		{
			Il2CppClassPointerStore<MemberMemberBinding>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "MemberMemberBinding");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberMemberBinding>.NativeClassPtr);
			MemberMemberBinding.NativeFieldInfoPtr__Bindings_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMemberBinding>.NativeClassPtr, "<Bindings>k__BackingField");
			MemberMemberBinding.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberMemberBinding>.NativeClassPtr, 100664526);
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x0002BF6C File Offset: 0x0002A16C
		public unsafe ReadOnlyCollection<MemberBinding> Bindings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberMemberBinding.NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<MemberBinding>>(intPtr3) : null;
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00003625 File Offset: 0x00001825
		public MemberMemberBinding(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x0000362E File Offset: 0x0000182E
		public unsafe ReadOnlyCollection<MemberBinding> _Bindings_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMemberBinding.NativeFieldInfoPtr__Bindings_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyCollection<MemberBinding>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMemberBinding.NativeFieldInfoPtr__Bindings_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeFieldInfoPtr__Bindings_k__BackingField;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr_get_Bindings_Public_get_ReadOnlyCollection_1_MemberBinding_0;
	}
}
