using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x02000420 RID: 1056
	[DefaultMember("Item")]
	public sealed class ParameterModifier : ValueType
	{
		// Token: 0x06003CB8 RID: 15544 RVA: 0x00016792 File Offset: 0x00014992
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterModifier()
		{
			Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr);
			ParameterModifier.NativeFieldInfoPtr__byRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr, "_byRef");
		}

		// Token: 0x06003CB9 RID: 15545 RVA: 0x000167CB File Offset: 0x000149CB
		public ParameterModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x000167D4 File Offset: 0x000149D4
		public ParameterModifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr))
		{
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00123044 File Offset: 0x00121244
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x000167E6 File Offset: 0x000149E6
		public unsafe Il2CppStructArray<bool> _byRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeFieldInfoPtr__byRef;
	}
}
